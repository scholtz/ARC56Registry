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

namespace Arc56.Generated.akita_protocol.akita_sc.MockGuildSubscriptions_e1c3b3d1
{


    //
    // Deterministic implementation of the subscription read ABI used by subscription consensus.
    //
    public class MockGuildSubscriptionsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockGuildSubscriptionsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ServiceKey : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public ulong Id { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ServiceKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ServiceKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ServiceKey);
                }
                public bool Equals(ServiceKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ServiceKey left, ServiceKey right)
                {
                    return EqualityComparer<ServiceKey>.Default.Equals(left, right);
                }
                public static bool operator !=(ServiceKey left, ServiceKey right)
                {
                    return !(left == right);
                }

            }

            public class Service : AVMObjectType
            {
                public byte Status { get; set; }

                public ulong Interval { get; set; }

                public ulong Asset { get; set; }

                public ulong Amount { get; set; }

                public ulong Passes { get; set; }

                public ulong GateId { get; set; }

                public Algorand.Address PayoutAddress { get; set; }

                public string Title { get; set; }

                public string Description { get; set; }

                public byte[] BannerImage { get; set; }

                public byte HighlightMessage { get; set; }

                public byte[] HighlightColor { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInterval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInterval.From(Interval);
                    ret.AddRange(vInterval.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPasses = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPasses.From(Passes);
                    ret.AddRange(vPasses.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGateId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGateId.From(GateId);
                    ret.AddRange(vGateId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayoutAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayoutAddress.From(PayoutAddress);
                    ret.AddRange(vPayoutAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTitle.From(Title);
                    stringRef[ret.Count] = vTitle.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.From(Description);
                    stringRef[ret.Count] = vDescription.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBannerImage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[36]");
                    vBannerImage.From(BannerImage);
                    ret.AddRange(vBannerImage.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHighlightMessage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vHighlightMessage.From(HighlightMessage);
                    ret.AddRange(vHighlightMessage.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHighlightColor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[3]");
                    vHighlightColor.From(HighlightColor);
                    ret.AddRange(vHighlightColor.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Service Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Service();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInterval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInterval.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInterval = vInterval.ToValue();
                    if (valueInterval is ulong vIntervalValue) { ret.Interval = vIntervalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPasses = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPasses.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePasses = vPasses.ToValue();
                    if (valuePasses is ulong vPassesValue) { ret.Passes = vPassesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGateId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGateId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGateId = vGateId.ToValue();
                    if (valueGateId is ulong vGateIdValue) { ret.GateId = vGateIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayoutAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayoutAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayoutAddress = vPayoutAddress.ToValue();
                    if (valuePayoutAddress is Algorand.Address vPayoutAddressValue) { ret.PayoutAddress = vPayoutAddressValue; }
                    var indexTitle = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTitle.Decode(bytes.Skip(indexTitle + prefixOffset).ToArray());
                    var valueTitle = vTitle.ToValue();
                    if (valueTitle is string vTitleValue) { ret.Title = vTitleValue; }
                    var indexDescription = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.Decode(bytes.Skip(indexDescription + prefixOffset).ToArray());
                    var valueDescription = vDescription.ToValue();
                    if (valueDescription is string vDescriptionValue) { ret.Description = vDescriptionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBannerImage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[36]");
                    count = vBannerImage.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBannerImage = vBannerImage.ToValue();
                    if (valueBannerImage is byte[] vBannerImageValue) { ret.BannerImage = vBannerImageValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHighlightMessage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vHighlightMessage.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHighlightMessage = vHighlightMessage.ToValue();
                    if (valueHighlightMessage is byte vHighlightMessageValue) { ret.HighlightMessage = vHighlightMessageValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHighlightColor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[3]");
                    count = vHighlightColor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHighlightColor = vHighlightColor.ToValue();
                    if (valueHighlightColor is byte[] vHighlightColorValue) { ret.HighlightColor = vHighlightColorValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Service);
                }
                public bool Equals(Service? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Service left, Service right)
                {
                    return EqualityComparer<Service>.Default.Equals(left, right);
                }
                public static bool operator !=(Service left, Service right)
                {
                    return !(left == right);
                }

            }

            public class SubscriptionInfoWithExistence : AVMObjectType
            {
                public bool Exists { get; set; }

                public Algorand.Address Recipient { get; set; }

                public ulong ServiceId { get; set; }

                public ulong StartDate { get; set; }

                public ulong Amount { get; set; }

                public ulong Interval { get; set; }

                public ulong Asset { get; set; }

                public ulong GateId { get; set; }

                public ulong LastPayment { get; set; }

                public ulong Streak { get; set; }

                public ulong Escrowed { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vRecipient.From(Recipient);
                    ret.AddRange(vRecipient.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vServiceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vServiceId.From(ServiceId);
                    ret.AddRange(vServiceId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartDate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartDate.From(StartDate);
                    ret.AddRange(vStartDate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInterval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInterval.From(Interval);
                    ret.AddRange(vInterval.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGateId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGateId.From(GateId);
                    ret.AddRange(vGateId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastPayment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastPayment.From(LastPayment);
                    ret.AddRange(vLastPayment.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStreak = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStreak.From(Streak);
                    ret.AddRange(vStreak.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEscrowed.From(Escrowed);
                    ret.AddRange(vEscrowed.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SubscriptionInfoWithExistence Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SubscriptionInfoWithExistence();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRecipient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecipient = vRecipient.ToValue();
                    if (valueRecipient is Algorand.Address vRecipientValue) { ret.Recipient = vRecipientValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vServiceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vServiceId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueServiceId = vServiceId.ToValue();
                    if (valueServiceId is ulong vServiceIdValue) { ret.ServiceId = vServiceIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartDate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartDate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartDate = vStartDate.ToValue();
                    if (valueStartDate is ulong vStartDateValue) { ret.StartDate = vStartDateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInterval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInterval.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInterval = vInterval.ToValue();
                    if (valueInterval is ulong vIntervalValue) { ret.Interval = vIntervalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGateId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGateId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGateId = vGateId.ToValue();
                    if (valueGateId is ulong vGateIdValue) { ret.GateId = vGateIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastPayment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastPayment.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastPayment = vLastPayment.ToValue();
                    if (valueLastPayment is ulong vLastPaymentValue) { ret.LastPayment = vLastPaymentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStreak = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStreak.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStreak = vStreak.ToValue();
                    if (valueStreak is ulong vStreakValue) { ret.Streak = vStreakValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEscrowed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEscrowed = vEscrowed.ToValue();
                    if (valueEscrowed is ulong vEscrowedValue) { ret.Escrowed = vEscrowedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SubscriptionInfoWithExistence);
                }
                public bool Equals(SubscriptionInfoWithExistence? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SubscriptionInfoWithExistence left, SubscriptionInfoWithExistence right)
                {
                    return EqualityComparer<SubscriptionInfoWithExistence>.Default.Equals(left, right);
                }
                public static bool operator !=(SubscriptionInfoWithExistence left, SubscriptionInfoWithExistence right)
                {
                    return !(left == right);
                }

            }

            public class SubscriptionKey : AVMObjectType
            {
                public Algorand.Address Address { get; set; }

                public ulong Id { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SubscriptionKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SubscriptionKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SubscriptionKey);
                }
                public bool Equals(SubscriptionKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SubscriptionKey left, SubscriptionKey right)
                {
                    return EqualityComparer<SubscriptionKey>.Default.Equals(left, right);
                }
                public static bool operator !=(SubscriptionKey left, SubscriptionKey right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="interval"> </param>
        /// <param name="asset"> </param>
        /// <param name="amount"> </param>
        /// <param name="passes"> </param>
        /// <param name="gateID"> </param>
        /// <param name="payoutAddress"> </param>
        /// <param name="title"> </param>
        /// <param name="bannerImage"> </param>
        /// <param name="highlightMessage"> </param>
        /// <param name="highlightColor"> </param>
        /// <param name="wallet"> </param>
        public async Task<ulong> NewService(PaymentTransaction payment, ulong interval, ulong asset, ulong amount, ulong passes, ulong gateID, Algorand.Address payoutAddress, string title, byte[] bannerImage, byte highlightMessage, byte[] highlightColor, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 70, 142, 190, 99 };
            var intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); intervalAbi.From(interval);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var passesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); passesAbi.From(passes);
            var gateIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateIDAbi.From(gateID);
            var payoutAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payoutAddressAbi.From(payoutAddress);
            var titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); titleAbi.From(title);
            var bannerImageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(36, "byte"); bannerImageAbi.From(bannerImage);
            var highlightMessageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); highlightMessageAbi.From(highlightMessage);
            var highlightColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(3, "byte"); highlightColorAbi.From(highlightColor);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, payment, intervalAbi, assetAbi, amountAbi, passesAbi, gateIDAbi, payoutAddressAbi, titleAbi, bannerImageAbi, highlightMessageAbi, highlightColorAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NewService_Transactions(PaymentTransaction payment, ulong interval, ulong asset, ulong amount, ulong passes, ulong gateID, Algorand.Address payoutAddress, string title, byte[] bannerImage, byte highlightMessage, byte[] highlightColor, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 70, 142, 190, 99 };
            var intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); intervalAbi.From(interval);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var passesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); passesAbi.From(passes);
            var gateIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateIDAbi.From(gateID);
            var payoutAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payoutAddressAbi.From(payoutAddress);
            var titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); titleAbi.From(title);
            var bannerImageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(36, "byte"); bannerImageAbi.From(bannerImage);
            var highlightMessageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); highlightMessageAbi.From(highlightMessage);
            var highlightColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(3, "byte"); highlightColorAbi.From(highlightColor);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, intervalAbi, assetAbi, amountAbi, passesAbi, gateIDAbi, payoutAddressAbi, titleAbi, bannerImageAbi, highlightMessageAbi, highlightColorAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ActivateService(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 131, 81, 48 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ActivateService_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 131, 81, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task ShutdownService(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 224, 85, 198 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ShutdownService_Transactions(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 224, 85, 198 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="wallet"> </param>
        public async Task<ulong> NewServiceCost(ulong asset, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 7, 7, 142 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, assetAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NewServiceCost_Transactions(ulong asset, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 7, 7, 142 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="id"> </param>
        /// <param name="status"> </param>
        public async Task SetService(Algorand.Address owner, ulong id, byte status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 134, 131, 94 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); statusAbi.From(status);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, idAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetService_Transactions(Algorand.Address owner, ulong id, byte status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 134, 131, 94 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, idAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///An established subscription: paid in each of its first three windows, the last time at
        ///`lastPayment`. It started two intervals before that, so it is seasoned for any ballot opened
        ///from one interval before `lastPayment` onwards. Use `setSubscriptionRun` to choose the history.
        ///</summary>
        /// <param name="account"> </param>
        /// <param name="id"> </param>
        /// <param name="recipient"> </param>
        /// <param name="serviceID"> </param>
        /// <param name="interval"> </param>
        /// <param name="lastPayment"> </param>
        public async Task SetSubscription(Algorand.Address account, ulong id, Algorand.Address recipient, ulong serviceID, ulong interval, ulong lastPayment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 215, 89, 136 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var serviceIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); serviceIDAbi.From(serviceID);
            var intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); intervalAbi.From(interval);
            var lastPaymentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastPaymentAbi.From(lastPayment);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi, idAbi, recipientAbi, serviceIDAbi, intervalAbi, lastPaymentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSubscription_Transactions(Algorand.Address account, ulong id, Algorand.Address recipient, ulong serviceID, ulong interval, ulong lastPayment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 215, 89, 136 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var serviceIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); serviceIDAbi.From(serviceID);
            var intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); intervalAbi.From(interval);
            var lastPaymentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastPaymentAbi.From(lastPayment);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, idAbi, recipientAbi, serviceIDAbi, intervalAbi, lastPaymentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///A subscription with an explicit payment history (`startDate`, `lastPayment`, `streak`), as the real app records it.
        ///</summary>
        /// <param name="account"> </param>
        /// <param name="id"> </param>
        /// <param name="recipient"> </param>
        /// <param name="serviceID"> </param>
        /// <param name="interval"> </param>
        /// <param name="startDate"> </param>
        /// <param name="lastPayment"> </param>
        /// <param name="streak"> </param>
        public async Task SetSubscriptionRun(Algorand.Address account, ulong id, Algorand.Address recipient, ulong serviceID, ulong interval, ulong startDate, ulong lastPayment, ulong streak, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 17, 34, 7 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var serviceIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); serviceIDAbi.From(serviceID);
            var intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); intervalAbi.From(interval);
            var startDateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startDateAbi.From(startDate);
            var lastPaymentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastPaymentAbi.From(lastPayment);
            var streakAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); streakAbi.From(streak);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi, idAbi, recipientAbi, serviceIDAbi, intervalAbi, startDateAbi, lastPaymentAbi, streakAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSubscriptionRun_Transactions(Algorand.Address account, ulong id, Algorand.Address recipient, ulong serviceID, ulong interval, ulong startDate, ulong lastPayment, ulong streak, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 17, 34, 7 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var serviceIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); serviceIDAbi.From(serviceID);
            var intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); intervalAbi.From(interval);
            var startDateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startDateAbi.From(startDate);
            var lastPaymentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastPaymentAbi.From(lastPayment);
            var streakAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); streakAbi.From(streak);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, idAbi, recipientAbi, serviceIDAbi, intervalAbi, startDateAbi, lastPaymentAbi, streakAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="account"> </param>
        /// <param name="blocked"> </param>
        public async Task SetBlocked(Algorand.Address owner, Algorand.Address account, bool blocked, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 244, 13, 69 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var blockedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); blockedAbi.From(blocked);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, accountAbi, blockedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBlocked_Transactions(Algorand.Address owner, Algorand.Address account, bool blocked, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 244, 13, 69 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var blockedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); blockedAbi.From(blocked);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, accountAbi, blockedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        /// <param name="id"> </param>
        public async Task<Structs.Service> GetService(Algorand.Address address, ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 177, 110, 122 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Service.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetService_Transactions(Algorand.Address address, ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 177, 110, 122 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> SubscriptionKey</param>
        public async Task<Structs.SubscriptionInfoWithExistence> GetSubscription(Structs.SubscriptionKey key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 184, 18, 167 };

            var result = await base.SimApp(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SubscriptionInfoWithExistence.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetSubscription_Transactions(Structs.SubscriptionKey key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 184, 18, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        /// <param name="blocked"> </param>
        public async Task<bool> IsBlocked(Algorand.Address address, Algorand.Address blocked, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 3, 102, 142 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var blockedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); blockedAbi.From(blocked);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi, blockedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsBlocked_Transactions(Algorand.Address address, Algorand.Address blocked, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 3, 102, 142 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var blockedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); blockedAbi.From(blocked);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi, blockedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja0d1aWxkU3Vic2NyaXB0aW9ucyIsImRlc2MiOiJEZXRlcm1pbmlzdGljIGltcGxlbWVudGF0aW9uIG9mIHRoZSBzdWJzY3JpcHRpb24gcmVhZCBBQkkgdXNlZCBieSBzdWJzY3JpcHRpb24gY29uc2Vuc3VzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTZXJ2aWNlS2V5IjpbeyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImlkIiwidHlwZSI6InVpbnQ2NCJ9XSwiU2VydmljZSI6W3sibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImludGVydmFsIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwYXNzZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ2F0ZUlEIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBheW91dEFkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InRpdGxlIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImRlc2NyaXB0aW9uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImJhbm5lckltYWdlIiwidHlwZSI6ImJ5dGVbMzZdIn0seyJuYW1lIjoiaGlnaGxpZ2h0TWVzc2FnZSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImhpZ2hsaWdodENvbG9yIiwidHlwZSI6ImJ5dGVbM10ifV0sIlN1YnNjcmlwdGlvbkluZm9XaXRoRXhpc3RlbmNlIjpbeyJuYW1lIjoiZXhpc3RzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJyZWNpcGllbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InNlcnZpY2VJRCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGFydERhdGUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImludGVydmFsIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImdhdGVJRCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0UGF5bWVudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdHJlYWsiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXNjcm93ZWQiLCJ0eXBlIjoidWludDY0In1dLCJTdWJzY3JpcHRpb25LZXkiOlt7Im5hbWUiOiJhZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJpZCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5ld1NlcnZpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJ2YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhc3NlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ2F0ZUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5b3V0QWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGl0bGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFubmVySW1hZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGlnaGxpZ2h0TWVzc2FnZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhpZ2hsaWdodENvbG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY3RpdmF0ZVNlcnZpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2h1dGRvd25TZXJ2aWNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5ld1NlcnZpY2VDb3N0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFNlcnZpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGF0dXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0U3Vic2NyaXB0aW9uIiwiZGVzYyI6IkFuIGVzdGFibGlzaGVkIHN1YnNjcmlwdGlvbjogcGFpZCBpbiBlYWNoIG9mIGl0cyBmaXJzdCB0aHJlZSB3aW5kb3dzLCB0aGUgbGFzdCB0aW1lIGF0XG5gbGFzdFBheW1lbnRgLiBJdCBzdGFydGVkIHR3byBpbnRlcnZhbHMgYmVmb3JlIHRoYXQsIHNvIGl0IGlzIHNlYXNvbmVkIGZvciBhbnkgYmFsbG90IG9wZW5lZFxuZnJvbSBvbmUgaW50ZXJ2YWwgYmVmb3JlIGBsYXN0UGF5bWVudGAgb253YXJkcy4gVXNlIGBzZXRTdWJzY3JpcHRpb25SdW5gIHRvIGNob29zZSB0aGUgaGlzdG9yeS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZXJ2aWNlSUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVydmFsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYXN0UGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRTdWJzY3JpcHRpb25SdW4iLCJkZXNjIjoiQSBzdWJzY3JpcHRpb24gd2l0aCBhbiBleHBsaWNpdCBwYXltZW50IGhpc3RvcnkgKGBzdGFydERhdGVgLCBgbGFzdFBheW1lbnRgLCBgc3RyZWFrYCksIGFzIHRoZSByZWFsIGFwcCByZWNvcmRzIGl0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlcnZpY2VJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJ2YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0RGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFzdFBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0cmVhayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRCbG9ja2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJibG9ja2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFNlcnZpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50OCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LGFkZHJlc3Msc3RyaW5nLHN0cmluZyxieXRlWzM2XSx1aW50OCxieXRlWzNdKSIsInN0cnVjdCI6IlNlcnZpY2UiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFN1YnNjcmlwdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQpIiwic3RydWN0IjoiU3Vic2NyaXB0aW9uS2V5IiwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCxhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlN1YnNjcmlwdGlvbkluZm9XaXRoRXhpc3RlbmNlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0Jsb2NrZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJibG9ja2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyOTksMzYyLDM3MSw0MDksNzUxLDc2NSw4NTFdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTQsNDY3LDUwNSw1MjIsNTk1LDYxMiw2NzEsNjc5LDczMSw5NzYsOTg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzNj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTAsMTU5LDE2NywxNzcsMTg0LDIzOCwzOTAsNDM1LDQ0Miw0NzUsNTEzLDUzMCw1MzksNTQ5LDYwMyw2MjAsNjI5LDYzOCw2NDcsNjU2LDczOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMiw0ODRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50OCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvc3Vic2NyaXB0aW9ucy90eXBlcy50czo6U3Vic2NyaXB0aW9uS2V5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQTRJRE15SURBS0lDQWdJR0o1ZEdWallteHZZMnNnSW5NaUlDSnVJaUF3ZURFMU1XWTNZemMxSUNKaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pveU1TMHlNZ29nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYzNSaGRHVlViM1JoYkhNNklIc2daMnh2WW1Gc1FubDBaWE02SURBc0lHZHNiMkpoYkZWcGJuUnpPaUF3SUgwZ2ZTa0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOYjJOclIzVnBiR1JUZFdKelkzSnBjSFJwYjI1eklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TlFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURRMk9HVmlaVFl6SURCNFl6ZzRNelV4TXpBZ01IZzROMlV3TlRWak5pQXdlREl5TURjd056aGxJREI0TVdFNE5qZ3pOV1VnTUhnMk1HUTNOVGs0T0NBd2VHTmhNVEV5TWpBM0lEQjROV0ptTkRCa05EVWdNSGhrTkdJeE5tVTNZU0F3ZURJMVlqZ3hNbUUzSURCNE5ETXdNelkyT0dVZ0x5OGdiV1YwYUc5a0lDSnVaWGRUWlhKMmFXTmxLSEJoZVN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdGa1pISmxjM01zYzNSeWFXNW5MR0o1ZEdWYk16WmRMSFZwYm5RNExHSjVkR1ZiTTEwc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWVdOMGFYWmhkR1ZUWlhKMmFXTmxLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnphSFYwWkc5M2JsTmxjblpwWTJVb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTVsZDFObGNuWnBZMlZEYjNOMEtIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p6WlhSVFpYSjJhV05sS0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RNEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGTjFZbk5qY21sd2RHbHZiaWhoWkdSeVpYTnpMSFZwYm5RMk5DeGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRk4xWW5OamNtbHdkR2x2YmxKMWJpaGhaR1J5WlhOekxIVnBiblEyTkN4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwUW14dlkydGxaQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSVFpYSjJhV05sS0dGa1pISmxjM01zZFdsdWREWTBLU2gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHRmtaSEpsYzNNc2MzUnlhVzVuTEhOMGNtbHVaeXhpZVhSbFd6TTJYU3gxYVc1ME9DeGllWFJsV3pOZEtTSXNJRzFsZEdodlpDQWlaMlYwVTNWaWMyTnlhWEIwYVc5dUtDaGhaR1J5WlhOekxIVnBiblEyTkNrcEtHSnZiMndzWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1selFteHZZMnRsWkNoaFpHUnlaWE56TEdGa1pISmxjM01wWW05dmJDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzVsZDFObGNuWnBZMlVnWVdOMGFYWmhkR1ZUWlhKMmFXTmxJSE5vZFhSa2IzZHVVMlZ5ZG1salpTQnVaWGRUWlhKMmFXTmxRMjl6ZENCelpYUlRaWEoyYVdObElITmxkRk4xWW5OamNtbHdkR2x2YmlCelpYUlRkV0p6WTNKcGNIUnBiMjVTZFc0Z2MyVjBRbXh2WTJ0bFpDQm5aWFJUWlhKMmFXTmxJR2RsZEZOMVluTmpjbWx3ZEdsdmJpQnBjMEpzYjJOclpXUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZNakV0TWpJS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lITjBZWFJsVkc5MFlXeHpPaUI3SUdkc2IySmhiRUo1ZEdWek9pQXdMQ0JuYkc5aVlXeFZhVzUwY3pvZ01DQjlJSDBwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RXOWphMGQxYVd4a1UzVmljMk55YVhCMGFXOXVjeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJqTldNMk1XSmhJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZmY205MWRHVkFNVFlLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZmNtOTFkR1ZBTVRZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZPazF2WTJ0SGRXbHNaRk4xWW5OamNtbHdkR2x2Ym5NdWJtVjNVMlZ5ZG1salpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTVsZDFObGNuWnBZMlU2Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZNemd0TlRFS0lDQWdJQzh2SUc1bGQxTmxjblpwWTJVb0NpQWdJQ0F2THlBZ0lIQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3S0lDQWdJQzh2SUNBZ2FXNTBaWEoyWVd3NklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1lYTnpaWFE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJSEJoYzNObGN6b2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQm5ZWFJsU1VRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2NHRjViM1YwUVdSa2NtVnpjem9nUVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnZEdsMGJHVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdZbUZ1Ym1WeVNXMWhaMlU2SUVOSlJDd0tJQ0FnSUM4dklDQWdhR2xuYUd4cFoyaDBUV1Z6YzJGblpUb2dWV2x1ZERnc0NpQWdJQ0F2THlBZ0lHaHBaMmhzYVdkb2RFTnZiRzl5T2lCaWVYUmxjend6UGl3S0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFwT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQnVJRElLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEY0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGdLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016WStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTVDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblE0Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TUFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnWVhOelpYSjBLSGRoYkd4bGRDQTlQVDBnTUNrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpJQ1ltSUhCaGVXMWxiblF1WVcxdmRXNTBJRDA5UFNCTmIyTnJVMlZ5ZG1salpVTnZjM1FwQ2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmllaUJ1WlhkVFpYSjJhV05sWDJKdmIyeGZabUZzYzJWQU5Bb2dJQ0FnWkdsbklETUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnY0hWemFHbHVkQ0F5TURBd01Bb2dJQ0FnUFQwS0lDQWdJR0o2SUc1bGQxTmxjblpwWTJWZlltOXZiRjltWVd4elpVQTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb0tibVYzVTJWeWRtbGpaVjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCaGMzTmxjblFvY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01nSmlZZ2NHRjViV1Z1ZEM1aGJXOTFiblFnUFQwOUlFMXZZMnRUWlhKMmFXTmxRMjl6ZENrS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dsdWRHVnlkbUZzSUQ0OUlEWXdJQ1ltSUdGdGIzVnVkQ0ErUFNBektRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0EyTUFvZ0lDQWdQajBLSUNBZ0lHSjZJRzVsZDFObGNuWnBZMlZmWW05dmJGOW1ZV3h6WlVBNENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQStQUW9nSUNBZ1lub2dibVYzVTJWeWRtbGpaVjlpYjI5c1gyWmhiSE5sUURnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwdVpYZFRaWEoyYVdObFgySnZiMnhmYldWeVoyVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHBiblJsY25aaGJDQStQU0EyTUNBbUppQmhiVzkxYm5RZ1BqMGdNeWtLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnYkdWMElHbGtPaUIxYVc1ME5qUWdQU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1luVnllU0EwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJ6WlhKMmFXTmxRMjkxYm5SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2R1SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklHbG1JQ2gwYUdsekxuTmxjblpwWTJWRGIzVnVkSE1vVkhodUxuTmxibVJsY2lrdVpYaHBjM1J6S1NCN0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJ6WlhKMmFXTmxRMjkxYm5SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2R1SnlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QnBaaUFvZEdocGN5NXpaWEoyYVdObFEyOTFiblJ6S0ZSNGJpNXpaVzVrWlhJcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJ1WlhkVFpYSjJhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJSE5sY25acFkyVkRiM1Z1ZEhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dKMjRuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2FXUWdQU0IwYUdsekxuTmxjblpwWTJWRGIzVnVkSE1vVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnS3lBeENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJ6WlhKMmFXTmxRMjkxYm5SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2R1SnlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QnBaQ0E5SUhSb2FYTXVjMlZ5ZG1salpVTnZkVzUwY3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBcklERUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBMENncHVaWGRUWlhKMmFXTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QnpaWEoyYVdObFEyOTFiblJ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZHVKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkV0p6WTNKcGNIUnBiMjV6TG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUhSb2FYTXVjMlZ5ZG1salpVTnZkVzUwY3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlHbGtDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCelpYSjJhV05sUTI5MWJuUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUNkdUp5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUIwYUdsekxuTmxjblpwWTJWRGIzVnVkSE1vVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCcFpBb2dJQ0FnWkdsbklEUUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUIwYUdsekxuTmxjblpwWTJWektIc2diM2R1WlhJNklGUjRiaTV6Wlc1a1pYSXNJR2xrSUgwcExuWmhiSFZsSUQwZ1UyVnlkbWxqWlZOMFlYUjFjMFJ5WVdaMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCelpYSjJhV05sY3lBOUlFSnZlRTFoY0R4VFpYSjJhV05sUzJWNUxDQlRaWEoyYVdObFUzUmhkSFZ6UGloN0lHdGxlVkJ5WldacGVEb2dKM01uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QjBhR2x6TG5ObGNuWnBZMlZ6S0hzZ2IzZHVaWEk2SUZSNGJpNXpaVzVrWlhJc0lHbGtJSDBwTG5aaGJIVmxJRDBnVTJWeWRtbGpaVk4wWVhSMWMwUnlZV1owQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3WVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z2RHaHBjeTV3WVhsdmRYUnpLSHNnYjNkdVpYSTZJRlI0Ymk1elpXNWtaWElzSUdsa0lIMHBMblpoYkhWbElEMGdjR0Y1YjNWMFFXUmtjbVZ6Y3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnY0dGNWIzVjBjeUE5SUVKdmVFMWhjRHhUWlhKMmFXTmxTMlY1TENCQlkyTnZkVzUwUGloN0lHdGxlVkJ5WldacGVEb2dKM0FuSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5BaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklIUm9hWE11Y0dGNWIzVjBjeWg3SUc5M2JtVnlPaUJVZUc0dWMyVnVaR1Z5TENCcFpDQjlLUzUyWVd4MVpTQTlJSEJoZVc5MWRFRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem96T0MwMU1Rb2dJQ0FnTHk4Z2JtVjNVMlZ5ZG1salpTZ0tJQ0FnSUM4dklDQWdjR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxBb2dJQ0FnTHk4Z0lDQnBiblJsY25aaGJEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmhjM05sZERvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnY0dGemMyVnpPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJR2RoZEdWSlJEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQndZWGx2ZFhSQlpHUnlaWE56T2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCMGFYUnNaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JpWVc1dVpYSkpiV0ZuWlRvZ1EwbEVMQW9nSUNBZ0x5OGdJQ0JvYVdkb2JHbG5hSFJOWlhOellXZGxPaUJWYVc1ME9Dd0tJQ0FnSUM4dklDQWdhR2xuYUd4cFoyaDBRMjlzYjNJNklHSjVkR1Z6UERNK0xBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNrNklIVnBiblEyTkNCN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHVaWGRUWlhKMmFXTmxYMkp2YjJ4ZlptRnNjMlZBT0RvS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmlJRzVsZDFObGNuWnBZMlZmWW05dmJGOXRaWEpuWlVBNUNncHVaWGRUWlhKMmFXTmxYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmlJRzVsZDFObGNuWnBZMlZmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem82VFc5amEwZDFhV3hrVTNWaWMyTnlhWEIwYVc5dWN5NWhZM1JwZG1GMFpWTmxjblpwWTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhZM1JwZG1GMFpWTmxjblpwWTJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCamIyNXpkQ0JyWlhrNklGTmxjblpwWTJWTFpYa2dQU0I3SUc5M2JtVnlPaUJVZUc0dWMyVnVaR1Z5TENCcFpEb2dkR2hwY3k1elpYSjJhV05sUTI5MWJuUnpLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJSDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklITmxjblpwWTJWRGIzVnVkSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0oyNG5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem8yTndvZ0lDQWdMeThnWTI5dWMzUWdhMlY1T2lCVFpYSjJhV05sUzJWNUlEMGdleUJ2ZDI1bGNqb2dWSGh1TG5ObGJtUmxjaXdnYVdRNklIUm9hWE11YzJWeWRtbGpaVU52ZFc1MGN5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQjlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCelpYSjJhV05sUTI5MWJuUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUNkdUp5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJqYjI1emRDQnJaWGs2SUZObGNuWnBZMlZMWlhrZ1BTQjdJRzkzYm1WeU9pQlVlRzR1YzJWdVpHVnlMQ0JwWkRvZ2RHaHBjeTV6WlhKMmFXTmxRMjkxYm5SektGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElIMEtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCaWRHOXBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJSE5sY25acFkyVnpJRDBnUW05NFRXRndQRk5sY25acFkyVkxaWGtzSUZObGNuWnBZMlZUZEdGMGRYTStLSHNnYTJWNVVISmxabWw0T2lBbmN5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkV0p6WTNKcGNIUnBiMjV6TG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuTmxjblpwWTJWektHdGxlU2t1ZG1Gc2RXVWdQVDA5SUZObGNuWnBZMlZUZEdGMGRYTkVjbUZtZENrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCaENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCMGFHbHpMbk5sY25acFkyVnpLR3RsZVNrdWRtRnNkV1VnUFNCVFpYSjJhV05sVTNSaGRIVnpRV04wYVhabENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5Bb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMVluTmpjbWx3ZEdsdmJuTXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdZV04wYVhaaGRHVlRaWEoyYVdObEtDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkV0p6WTNKcGNIUnBiMjV6TG1Gc1oyOHVkSE02T2sxdlkydEhkV2xzWkZOMVluTmpjbWx3ZEdsdmJuTXVjMmgxZEdSdmQyNVRaWEoyYVdObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMmgxZEdSdmQyNVRaWEoyYVdObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z2MyaDFkR1J2ZDI1VFpYSjJhV05sS0dsa09pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklHTnZibk4wSUd0bGVUb2dVMlZ5ZG1salpVdGxlU0E5SUhzZ2IzZHVaWEk2SUZSNGJpNXpaVzVrWlhJc0lHbGtJSDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMVluTmpjbWx3ZEdsdmJuTXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdjMlZ5ZG1salpYTWdQU0JDYjNoTllYQThVMlZ5ZG1salpVdGxlU3dnVTJWeWRtbGpaVk4wWVhSMWN6NG9leUJyWlhsUWNtVm1hWGc2SUNkekp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1elpYSjJhV05sY3loclpYa3BMbVY0YVhOMGN5QW1KaUIwYUdsekxuTmxjblpwWTJWektHdGxlU2t1ZG1Gc2RXVWdJVDA5SUZObGNuWnBZMlZUZEdGMGRYTlRhSFYwWkc5M2Jpa0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nYzJoMWRHUnZkMjVUWlhKMmFXTmxYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpnS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ6YUhWMFpHOTNibE5sY25acFkyVmZZbTl2YkY5bVlXeHpaVUEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9LYzJoMWRHUnZkMjVUWlhKMmFXTmxYMkp2YjJ4ZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkV0p6WTNKcGNIUnBiMjV6TG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuTmxjblpwWTJWektHdGxlU2t1WlhocGMzUnpJQ1ltSUhSb2FYTXVjMlZ5ZG1salpYTW9hMlY1S1M1MllXeDFaU0FoUFQwZ1UyVnlkbWxqWlZOMFlYUjFjMU5vZFhSa2IzZHVLUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUIwYUdsekxuTmxjblpwWTJWektHdGxlU2t1ZG1Gc2RXVWdQU0JUWlhKMmFXTmxVM1JoZEhWelUyaDFkR1J2ZDI0S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJNENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qY3lDaUFnSUNBdkx5QnphSFYwWkc5M2JsTmxjblpwWTJVb2FXUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjMmgxZEdSdmQyNVRaWEoyYVdObFgySnZiMnhmWm1Gc2MyVkFORG9LSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCaUlITm9kWFJrYjNkdVUyVnlkbWxqWlY5aWIyOXNYMjFsY21kbFFEVUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSVGRXSnpZM0pwY0hScGIyNXpMbTVsZDFObGNuWnBZMlZEYjNOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tibVYzVTJWeWRtbGpaVU52YzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQTBaVEl3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qcE5iMk5yUjNWcGJHUlRkV0p6WTNKcGNIUnBiMjV6TG5ObGRGTmxjblpwWTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJUWlhKMmFXTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMVluTmpjbWx3ZEdsdmJuTXVZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdjMlYwVTJWeWRtbGpaU2h2ZDI1bGNqb2dRV05qYjNWdWRDd2dhV1E2SUhWcGJuUTJOQ3dnYzNSaGRIVnpPaUJUWlhKMmFXTmxVM1JoZEhWektUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMVluTmpjbWx3ZEdsdmJuTXVZV3huYnk1MGN6bzROQW9nSUNBZ0x5OGdkR2hwY3k1elpYSjJhV05sY3loN0lHOTNibVZ5TENCcFpDQjlLUzUyWVd4MVpTQTlJSE4wWVhSMWN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkV0p6WTNKcGNIUnBiMjV6TG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUhObGNuWnBZMlZ6SUQwZ1FtOTRUV0Z3UEZObGNuWnBZMlZMWlhrc0lGTmxjblpwWTJWVGRHRjBkWE0rS0hzZ2EyVjVVSEpsWm1sNE9pQW5jeWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk9EUUtJQ0FnSUM4dklIUm9hWE11YzJWeWRtbGpaWE1vZXlCdmQyNWxjaXdnYVdRZ2ZTa3VkbUZzZFdVZ1BTQnpkR0YwZFhNS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklITmxkRk5sY25acFkyVW9iM2R1WlhJNklFRmpZMjkxYm5Rc0lHbGtPaUIxYVc1ME5qUXNJSE4wWVhSMWN6b2dVMlZ5ZG1salpWTjBZWFIxY3lrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZPazF2WTJ0SGRXbHNaRk4xWW5OamNtbHdkR2x2Ym5NdWMyVjBVM1ZpYzJOeWFYQjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBVM1ZpYzJOeWFYQjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem81TWkwNU9Rb2dJQ0FnTHk4Z2MyVjBVM1ZpYzJOeWFYQjBhVzl1S0FvZ0lDQWdMeThnSUNCaFkyTnZkVzUwT2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCcFpEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnlaV05wY0dsbGJuUTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJSE5sY25acFkyVkpSRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JwYm5SbGNuWmhiRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JzWVhOMFVHRjViV1Z1ZERvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pveE1EQUtJQ0FnSUM4dklHTnZibk4wSUdGblpUb2dkV2x1ZERZMElEMGdhVzUwWlhKMllXd2dLaUF5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNvS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pveE1ERUtJQ0FnSUM4dklIUm9hWE11YzJWMFUzVmljMk55YVhCMGFXOXVVblZ1S0dGalkyOTFiblFzSUdsa0xDQnlaV05wY0dsbGJuUXNJSE5sY25acFkyVkpSQ3dnYVc1MFpYSjJZV3dzSUd4aGMzUlFZWGx0Wlc1MElENGdZV2RsSUQ4Z2JHRnpkRkJoZVcxbGJuUWdMU0JoWjJVZ09pQXdMQ0JzWVhOMFVHRjViV1Z1ZEN3Z015a0tJQ0FnSUQ0S0lDQWdJR0o2SUhObGRGTjFZbk5qY21sd2RHbHZibDkwWlhKdVlYSjVYMlpoYkhObFFETUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNBdENncHpaWFJUZFdKelkzSnBjSFJwYjI1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem94TURFS0lDQWdJQzh2SUhSb2FYTXVjMlYwVTNWaWMyTnlhWEIwYVc5dVVuVnVLR0ZqWTI5MWJuUXNJR2xrTENCeVpXTnBjR2xsYm5Rc0lITmxjblpwWTJWSlJDd2dhVzUwWlhKMllXd3NJR3hoYzNSUVlYbHRaVzUwSUQ0Z1lXZGxJRDhnYkdGemRGQmhlVzFsYm5RZ0xTQmhaMlVnT2lBd0xDQnNZWE4wVUdGNWJXVnVkQ3dnTXlrS0lDQWdJR052ZG1WeUlEWUtJQ0FnSUdOdmRtVnlJRFlLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUdOaGJHeHpkV0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem82VFc5amEwZDFhV3hrVTNWaWMyTnlhWEIwYVc5dWN5NXpaWFJUZFdKelkzSnBjSFJwYjI1U2RXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk9USXRPVGtLSUNBZ0lDOHZJSE5sZEZOMVluTmpjbWx3ZEdsdmJpZ0tJQ0FnSUM4dklDQWdZV05qYjNWdWREb2dRV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdhV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnY21WamFYQnBaVzUwT2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCelpYSjJhV05sU1VRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2FXNTBaWEoyWVd3NklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2JHRnpkRkJoZVcxbGJuUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjMlYwVTNWaWMyTnlhWEIwYVc5dVgzUmxjbTVoY25sZlptRnNjMlZBTXpvS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem94TURFS0lDQWdJQzh2SUhSb2FYTXVjMlYwVTNWaWMyTnlhWEIwYVc5dVVuVnVLR0ZqWTI5MWJuUXNJR2xrTENCeVpXTnBjR2xsYm5Rc0lITmxjblpwWTJWSlJDd2dhVzUwWlhKMllXd3NJR3hoYzNSUVlYbHRaVzUwSUQ0Z1lXZGxJRDhnYkdGemRGQmhlVzFsYm5RZ0xTQmhaMlVnT2lBd0xDQnNZWE4wVUdGNWJXVnVkQ3dnTXlrS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmlJSE5sZEZOMVluTmpjbWx3ZEdsdmJsOTBaWEp1WVhKNVgyMWxjbWRsUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPanBOYjJOclIzVnBiR1JUZFdKelkzSnBjSFJwYjI1ekxuTmxkRk4xWW5OamNtbHdkR2x2YmxKMWJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZOMVluTmpjbWx3ZEdsdmJsSjFiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZNVEExTFRFeE5Bb2dJQ0FnTHk4Z2MyVjBVM1ZpYzJOeWFYQjBhVzl1VW5WdUtBb2dJQ0FnTHk4Z0lDQmhZMk52ZFc1ME9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQnBaRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J5WldOcGNHbGxiblE2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUhObGNuWnBZMlZKUkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCcGJuUmxjblpoYkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCemRHRnlkRVJoZEdVNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2JHRnpkRkJoZVcxbGJuUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdjM1J5WldGck9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBM0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpZV3hzYzNWaUlITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk9rMXZZMnRIZFdsc1pGTjFZbk5qY21sd2RHbHZibk11YzJWMFUzVmljMk55YVhCMGFXOXVVblZ1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMVluTmpjbWx3ZEdsdmJuTXVZV3huYnk1MGN6bzZUVzlqYTBkMWFXeGtVM1ZpYzJOeWFYQjBhVzl1Y3k1elpYUkNiRzlqYTJWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwUW14dlkydGxaRG9LSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qRXpNQW9nSUNBZ0x5OGdjMlYwUW14dlkydGxaQ2h2ZDI1bGNqb2dRV05qYjNWdWRDd2dZV05qYjNWdWREb2dRV05qYjNWdWRDd2dZbXh2WTJ0bFpEb2dZbTl2YkdWaGJpazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdWMyaGhNalUyS0c5M2JtVnlMbUo1ZEdWekxtTnZibU5oZENoaFkyTnZkVzUwTG1KNWRHVnpLU2tLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qRXpNZ29nSUNBZ0x5OGdhV1lnS0dKc2IyTnJaV1FwSUhSb2FYTXVZbXh2WTJ0ektHdGxlU2t1ZG1Gc2RXVWdQU0IwY25WbENpQWdJQ0JpZWlCelpYUkNiRzlqYTJWa1gyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QmliRzlqYTNNZ1BTQkNiM2hOWVhBOFlubDBaWE04TXpJK0xDQmliMjlzWldGdVBpaDdJR3RsZVZCeVpXWnBlRG9nSjJJbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPakV6TWdvZ0lDQWdMeThnYVdZZ0tHSnNiMk5yWldRcElIUm9hWE11WW14dlkydHpLR3RsZVNrdWRtRnNkV1VnUFNCMGNuVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9LYzJWMFFteHZZMnRsWkY5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPakV6TUFvZ0lDQWdMeThnYzJWMFFteHZZMnRsWkNodmQyNWxjam9nUVdOamIzVnVkQ3dnWVdOamIzVnVkRG9nUVdOamIzVnVkQ3dnWW14dlkydGxaRG9nWW05dmJHVmhiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYzJWMFFteHZZMnRsWkY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklHSnNiMk5yY3lBOUlFSnZlRTFoY0R4aWVYUmxjend6TWo0c0lHSnZiMnhsWVc0K0tIc2dhMlY1VUhKbFptbDRPaUFuWWljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltSWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPakV6TXdvZ0lDQWdMeThnWld4elpTQnBaaUFvZEdocGN5NWliRzlqYTNNb2EyVjVLUzVsZUdsemRITXBJSFJvYVhNdVlteHZZMnR6S0d0bGVTa3VaR1ZzWlhSbEtDa0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nYzJWMFFteHZZMnRsWkY5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmlJSE5sZEVKc2IyTnJaV1JmWVdaMFpYSmZhV1pmWld4elpVQTJDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pvNlRXOWphMGQxYVd4a1UzVmljMk55YVhCMGFXOXVjeTVuWlhSVFpYSjJhV05sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBVMlZ5ZG1salpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk1UTTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem94TXpnS0lDQWdJQzh2SUdOdmJuTjBJR3RsZVRvZ1UyVnlkbWxqWlV0bGVTQTlJSHNnYjNkdVpYSTZJR0ZrWkhKbGMzTXNJR2xrSUgwS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2MyVnlkbWxqWlhNZ1BTQkNiM2hOWVhBOFUyVnlkbWxqWlV0bGVTd2dVMlZ5ZG1salpWTjBZWFIxY3o0b2V5QnJaWGxRY21WbWFYZzZJQ2R6SnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWN5SUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZNVFF3Q2lBZ0lDQXZMeUJ6ZEdGMGRYTTZJSFJvYVhNdWMyVnlkbWxqWlhNb2EyVjVLUzUyWVd4MVpTd0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJ3WVhsdmRYUnpJRDBnUW05NFRXRndQRk5sY25acFkyVkxaWGtzSUVGalkyOTFiblErS0hzZ2EyVjVVSEpsWm1sNE9pQW5jQ2NnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpY0NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pFME5nb2dJQ0FnTHk4Z2NHRjViM1YwUVdSa2NtVnpjem9nZEdocGN5NXdZWGx2ZFhSektHdGxlU2t1WlhocGMzUnpJRDhnZEdocGN5NXdZWGx2ZFhSektHdGxlU2t1ZG1Gc2RXVWdPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHZGxkRk5sY25acFkyVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBekNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb0taMlYwVTJWeWRtbGpaVjkwWlhKdVlYSjVYMjFsY21kbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qRTBPUW9nSUNBZ0x5OGdZbUZ1Ym1WeVNXMWhaMlU2SUc5d0xtSjZaWEp2S0RNMktTd0tJQ0FnSUhCMWMyaHBiblFnTXpZS0lDQWdJR0o2WlhKdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pFMU1Bb2dJQ0FnTHk4Z2FHbG5hR3hwWjJoMFRXVnpjMkZuWlRvZ2JtVjNJRlZwYm5RNEtEQXBMQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk1UVXhDaUFnSUNBdkx5Qm9hV2RvYkdsbmFIUkRiMnh2Y2pvZ2IzQXVZbnBsY204b015a3NDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJR0o2WlhKdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pFek9TMHhOVElLSUNBZ0lDOHZJSEpsZEhWeWJpQjdDaUFnSUNBdkx5QWdJSE4wWVhSMWN6b2dkR2hwY3k1elpYSjJhV05sY3loclpYa3BMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQnBiblJsY25aaGJEb2dNQ3dLSUNBZ0lDOHZJQ0FnWVhOelpYUTZJREFzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ2NHRnpjMlZ6T2lBd0xBb2dJQ0FnTHk4Z0lDQm5ZWFJsU1VRNklEQXNDaUFnSUNBdkx5QWdJSEJoZVc5MWRFRmtaSEpsYzNNNklIUm9hWE11Y0dGNWIzVjBjeWhyWlhrcExtVjRhWE4wY3lBL0lIUm9hWE11Y0dGNWIzVjBjeWhyWlhrcExuWmhiSFZsSURvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjBhWFJzWlRvZ0p5Y3NDaUFnSUNBdkx5QWdJR1JsYzJOeWFYQjBhVzl1T2lBbkp5d0tJQ0FnSUM4dklDQWdZbUZ1Ym1WeVNXMWhaMlU2SUc5d0xtSjZaWEp2S0RNMktTd0tJQ0FnSUM4dklDQWdhR2xuYUd4cFoyaDBUV1Z6YzJGblpUb2dibVYzSUZWcGJuUTRLREFwTEFvZ0lDQWdMeThnSUNCb2FXZG9iR2xuYUhSRGIyeHZjam9nYjNBdVlucGxjbThvTXlrc0NpQWdJQ0F2THlCOUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREEzTlRBd056Y0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk1UVXdDaUFnSUNBdkx5Qm9hV2RvYkdsbmFIUk5aWE56WVdkbE9pQnVaWGNnVldsdWREZ29NQ2tzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem94TXprdE1UVXlDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQnpkR0YwZFhNNklIUm9hWE11YzJWeWRtbGpaWE1vYTJWNUtTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ2FXNTBaWEoyWVd3NklEQXNDaUFnSUNBdkx5QWdJR0Z6YzJWME9pQXdMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUhCaGMzTmxjem9nTUN3S0lDQWdJQzh2SUNBZ1oyRjBaVWxFT2lBd0xBb2dJQ0FnTHk4Z0lDQndZWGx2ZFhSQlpHUnlaWE56T2lCMGFHbHpMbkJoZVc5MWRITW9hMlY1S1M1bGVHbHpkSE1nUHlCMGFHbHpMbkJoZVc5MWRITW9hMlY1S1M1MllXeDFaU0E2SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ2RHbDBiR1U2SUNjbkxBb2dJQ0FnTHk4Z0lDQmtaWE5qY21sd2RHbHZiam9nSnljc0NpQWdJQ0F2THlBZ0lHSmhibTVsY2tsdFlXZGxPaUJ2Y0M1aWVtVnlieWd6Tmlrc0NpQWdJQ0F2THlBZ0lHaHBaMmhzYVdkb2RFMWxjM05oWjJVNklHNWxkeUJWYVc1ME9DZ3dLU3dLSUNBZ0lDOHZJQ0FnYUdsbmFHeHBaMmgwUTI5c2IzSTZJRzl3TG1KNlpYSnZLRE1wTEFvZ0lDQWdMeThnZlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk1UTTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21kbGRGTmxjblpwWTJWZmRHVnlibUZ5ZVY5bVlXeHpaVUF6T2dvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPakUwTmdvZ0lDQWdMeThnY0dGNWIzVjBRV1JrY21WemN6b2dkR2hwY3k1d1lYbHZkWFJ6S0d0bGVTa3VaWGhwYzNSeklEOGdkR2hwY3k1d1lYbHZkWFJ6S0d0bGVTa3VkbUZzZFdVZ09pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0lnWjJWMFUyVnlkbWxqWlY5MFpYSnVZWEo1WDIxbGNtZGxRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qcE5iMk5yUjNWcGJHUlRkV0p6WTNKcGNIUnBiMjV6TG1kbGRGTjFZbk5qY21sd2RHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGTjFZbk5qY21sd2RHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZNVFUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dWN5OTBlWEJsY3k1MGN6bzZVM1ZpYzJOeWFYQjBhVzl1UzJWNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCemRXSnpZM0pwY0hScGIyNXpJRDBnUW05NFRXRndQRk4xWW5OamNtbHdkR2x2Ymt0bGVTd2dVM1ZpYzJOeWFYQjBhVzl1U1c1bWIxZHBkR2hGZUdsemRHVnVZMlUrS0hzZ2EyVjVVSEpsWm1sNE9pQW5kU2NnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpZFNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pFMU53b2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWMzVmljMk55YVhCMGFXOXVjeWhyWlhrcExtVjRhWE4wY3lrZ2NtVjBkWEp1SUhSb2FYTXVjM1ZpYzJOeWFYQjBhVzl1Y3loclpYa3BMblpoYkhWbENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJR2RsZEZOMVluTmpjbWx3ZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENncG5aWFJUZFdKelkzSnBjSFJwYjI1ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPanBOYjJOclIzVnBiR1JUZFdKelkzSnBjSFJwYjI1ekxtZGxkRk4xWW5OamNtbHdkR2x2YmtBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pveE5UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWjJWMFUzVmljMk55YVhCMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pveE5UZ3RNVGN3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdld29nSUNBZ0x5OGdJQ0JsZUdsemRITTZJR1poYkhObExBb2dJQ0FnTHk4Z0lDQnlaV05wY0dsbGJuUTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnYzJWeWRtbGpaVWxFT2lBd0xBb2dJQ0FnTHk4Z0lDQnpkR0Z5ZEVSaGRHVTZJREFzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ2FXNTBaWEoyWVd3NklEQXNDaUFnSUNBdkx5QWdJR0Z6YzJWME9pQXdMQW9nSUNBZ0x5OGdJQ0JuWVhSbFNVUTZJREFzQ2lBZ0lDQXZMeUFnSUd4aGMzUlFZWGx0Wlc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0J6ZEhKbFlXczZJREFzQ2lBZ0lDQXZMeUFnSUdWelkzSnZkMlZrT2lBd0xBb2dJQ0FnTHk4Z2ZRb2dJQ0FnY0hWemFHSjVkR1Z6SUdKaGMyVXpNaWhCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qRTFOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmlJR2RsZEZOMVluTmpjbWx3ZEdsdmJsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkV0p6WTNKcGNIUnBiMjV6TG1Gc1oyOHVkSE02T2sxdlkydEhkV2xzWkZOMVluTmpjbWx3ZEdsdmJuTXVaMlYwVTNWaWMyTnlhWEIwYVc5dVFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSVGRXSnpZM0pwY0hScGIyNXpMbWx6UW14dlkydGxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21selFteHZZMnRsWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkV0p6WTNKcGNIUnBiMjV6TG1Gc1oyOHVkSE02TVRjekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdWMyaGhNalUyS0c5M2JtVnlMbUo1ZEdWekxtTnZibU5oZENoaFkyTnZkVzUwTG1KNWRHVnpLU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1ZpYzJOeWFYQjBhVzl1Y3k1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCaWJHOWphM01nUFNCQ2IzaE5ZWEE4WW5sMFpYTThNekkrTENCaWIyOXNaV0Z1UGloN0lHdGxlVkJ5WldacGVEb2dKMkluSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qRTNOUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WW14dlkydHpLSFJvYVhNdVlteHZZMnRMWlhrb1lXUmtjbVZ6Y3l3Z1lteHZZMnRsWkNrcExtVjRhWE4wY3dvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qRTNNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pvNlRXOWphMGQxYVd4a1UzVmljMk55YVhCMGFXOXVjeTV6WlhSVGRXSnpZM0pwY0hScGIyNVNkVzRvWVdOamIzVnVkRG9nWW5sMFpYTXNJR2xrT2lCMWFXNTBOalFzSUhKbFkybHdhV1Z1ZERvZ1lubDBaWE1zSUhObGNuWnBZMlZKUkRvZ2RXbHVkRFkwTENCcGJuUmxjblpoYkRvZ2RXbHVkRFkwTENCemRHRnlkRVJoZEdVNklIVnBiblEyTkN3Z2JHRnpkRkJoZVcxbGJuUTZJSFZwYm5RMk5Dd2djM1J5WldGck9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuTnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk9rMXZZMnRIZFdsc1pGTjFZbk5qY21sd2RHbHZibk11YzJWMFUzVmljMk55YVhCMGFXOXVVblZ1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjFZbk5qY21sd2RHbHZibk11WVd4bmJ5NTBjem94TURVdE1URTBDaUFnSUNBdkx5QnpaWFJUZFdKelkzSnBjSFJwYjI1U2RXNG9DaUFnSUNBdkx5QWdJR0ZqWTI5MWJuUTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJR2xrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZERvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ2MyVnlkbWxqWlVsRU9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHbHVkR1Z5ZG1Gc09pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lITjBZWEowUkdGMFpUb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnNZWE4wVUdGNWJXVnVkRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J6ZEhKbFlXczZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdPQ0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPakV4TlMweE1qY0tJQ0FnSUM4dklIUm9hWE11YzNWaWMyTnlhWEIwYVc5dWN5aDdJR0ZrWkhKbGMzTTZJR0ZqWTI5MWJuUXNJR2xrSUgwcExuWmhiSFZsSUQwZ2V3b2dJQ0FnTHk4Z0lDQmxlR2x6ZEhNNklIUnlkV1VzQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ2MyVnlkbWxqWlVsRUxBb2dJQ0FnTHk4Z0lDQnpkR0Z5ZEVSaGRHVXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dNU3dLSUNBZ0lDOHZJQ0FnYVc1MFpYSjJZV3dzQ2lBZ0lDQXZMeUFnSUdGemMyVjBPaUF3TEFvZ0lDQWdMeThnSUNCbllYUmxTVVE2SURBc0NpQWdJQ0F2THlBZ0lHeGhjM1JRWVhsdFpXNTBMQW9nSUNBZ0x5OGdJQ0J6ZEhKbFlXc3NDaUFnSUNBdkx5QWdJR1Z6WTNKdmQyVmtPaUF3TEFvZ0lDQWdMeThnZlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZFdKelkzSnBjSFJwYjI1ekxtRnNaMjh1ZEhNNk1USXdDaUFnSUNBdkx5QmhiVzkxYm5RNklERXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4xWW5OamNtbHdkR2x2Ym5NdVlXeG5ieTUwY3pveE1UVXRNVEkzQ2lBZ0lDQXZMeUIwYUdsekxuTjFZbk5qY21sd2RHbHZibk1vZXlCaFpHUnlaWE56T2lCaFkyTnZkVzUwTENCcFpDQjlLUzUyWVd4MVpTQTlJSHNLSUNBZ0lDOHZJQ0FnWlhocGMzUnpPaUIwY25WbExBb2dJQ0FnTHk4Z0lDQnlaV05wY0dsbGJuUXNDaUFnSUNBdkx5QWdJSE5sY25acFkyVkpSQ3dLSUNBZ0lDOHZJQ0FnYzNSaGNuUkVZWFJsTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SURFc0NpQWdJQ0F2THlBZ0lHbHVkR1Z5ZG1Gc0xBb2dJQ0FnTHk4Z0lDQmhjM05sZERvZ01Dd0tJQ0FnSUM4dklDQWdaMkYwWlVsRU9pQXdMQW9nSUNBZ0x5OGdJQ0JzWVhOMFVHRjViV1Z1ZEN3S0lDQWdJQzh2SUNBZ2MzUnlaV0ZyTEFvZ0lDQWdMeThnSUNCbGMyTnliM2RsWkRvZ01Dd0tJQ0FnSUM4dklIMEtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZNVEl5Q2lBZ0lDQXZMeUJoYzNObGREb2dNQ3dLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNWaWMyTnlhWEIwYVc5dWN5NWhiR2R2TG5Sek9qRXhOUzB4TWpjS0lDQWdJQzh2SUhSb2FYTXVjM1ZpYzJOeWFYQjBhVzl1Y3loN0lHRmtaSEpsYzNNNklHRmpZMjkxYm5Rc0lHbGtJSDBwTG5aaGJIVmxJRDBnZXdvZ0lDQWdMeThnSUNCbGVHbHpkSE02SUhSeWRXVXNDaUFnSUNBdkx5QWdJSEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnYzJWeWRtbGpaVWxFTEFvZ0lDQWdMeThnSUNCemRHRnlkRVJoZEdVc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ01Td0tJQ0FnSUM4dklDQWdhVzUwWlhKMllXd3NDaUFnSUNBdkx5QWdJR0Z6YzJWME9pQXdMQW9nSUNBZ0x5OGdJQ0JuWVhSbFNVUTZJREFzQ2lBZ0lDQXZMeUFnSUd4aGMzUlFZWGx0Wlc1MExBb2dJQ0FnTHk4Z0lDQnpkSEpsWVdzc0NpQWdJQ0F2THlBZ0lHVnpZM0p2ZDJWa09pQXdMQW9nSUNBZ0x5OGdmUW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZNVEUxQ2lBZ0lDQXZMeUIwYUdsekxuTjFZbk5qY21sd2RHbHZibk1vZXlCaFpHUnlaWE56T2lCaFkyTnZkVzUwTENCcFpDQjlLUzUyWVd4MVpTQTlJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QXROd29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDRDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRXSnpZM0pwY0hScGIyNXpMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSE4xWW5OamNtbHdkR2x2Ym5NZ1BTQkNiM2hOWVhBOFUzVmljMk55YVhCMGFXOXVTMlY1TENCVGRXSnpZM0pwY0hScGIyNUpibVp2VjJsMGFFVjRhWE4wWlc1alpUNG9leUJyWlhsUWNtVm1hWGc2SUNkMUp5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSjFJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzVmljMk55YVhCMGFXOXVjeTVoYkdkdkxuUnpPakV4TlMweE1qY0tJQ0FnSUM4dklIUm9hWE11YzNWaWMyTnlhWEIwYVc5dWN5aDdJR0ZrWkhKbGMzTTZJR0ZqWTI5MWJuUXNJR2xrSUgwcExuWmhiSFZsSUQwZ2V3b2dJQ0FnTHk4Z0lDQmxlR2x6ZEhNNklIUnlkV1VzQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ2MyVnlkbWxqWlVsRUxBb2dJQ0FnTHk4Z0lDQnpkR0Z5ZEVSaGRHVXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dNU3dLSUNBZ0lDOHZJQ0FnYVc1MFpYSjJZV3dzQ2lBZ0lDQXZMeUFnSUdGemMyVjBPaUF3TEFvZ0lDQWdMeThnSUNCbllYUmxTVVE2SURBc0NpQWdJQ0F2THlBZ0lHeGhjM1JRWVhsdFpXNTBMQW9nSUNBZ0x5OGdJQ0J6ZEhKbFlXc3NDaUFnSUNBdkx5QWdJR1Z6WTNKdmQyVmtPaUF3TEFvZ0lDQWdMeThnZlFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRZ2dBQ1lFQVhNQmJnUVZIM3gxQVdJeEdSUkVNUmhCQUZXQ0N3UkdqcjVqQk1pRFVUQUVoK0JWeGdRaUJ3ZU9CQnFHZzE0RVlOZFppQVRLRVNJSEJGdjBEVVVFMUxGdWVnUWx1QktuQkVNRFpvNDJHZ0NPQ3dBUkFQSUJEZ0U4QVZzQmdRSGJBaVlDWXdMTUExZ0FnQVJNWEdHNk5ob0FqZ0VBQVFBaVE0QUFNUllpQ1VjQ09CQWlFa1EyR2dGSkZTTVNSQmRNTmhvQ0ZTTVNSRFlhQTBrVkl4SkVGMDRDTmhvRUZTTVNSRFlhQlJVakVrUTJHZ1pKVGdJVkpCSkVOaG9IU1NWWmdRSUlUQlVTUkRZYUNCV0JKQkpFTmhvSkZTSVNSRFlhQ2hXQkF4SkVOaG9MU1JVakVrUVhGRVE0QnpJS0VrRUFaVXNET0FpQm9Kd0JFa0VBV1NKRVRJRThEMEVBVEVzQmdRTVBRUUJFSWtRaVJRUXBNUUJRdlVVQlFRQUxLVEVBVUw1RUZ5SUlSUVFwTVFCUVN3UVdURXNCdnpFQVN3RlFLRXhRZ0FFS3Z6RUFTd0ZRZ0FGd1RGQlBBcjhxVEZDd0lrTWxRdis1SlVML3BERUFLVEVBVUw1RUZ4WlFLRXhRU2I1RWdBRUtFa1NBQVJTL0lrTTJHZ0ZKRlNNU1JCY3hBRXdXVUNoTVVFbTlSUUZCQUJKSnZrU0FBU2dUUVFBSUlrU0FBU2kvSWtNbFF2LzFOaG9CRlNNU1JEWWFBaFVqRWtTQURCVWZmSFVBQUFBQUFBQk9JTEFpUXpZYUFVa1ZKQkpFTmhvQ1NSVWpFa1FYTmhvRFNSVWlFa1JNRms4Q1RGQW9URkJNdnlKRE5ob0JTUlVrRWtRMkdnSkpGU01TUkJjMkdnTkpGU1FTUkRZYUJFa1ZJeEpFRnpZYUJVa1ZJeEpFRjBrMkdnWkpGU01TUkJkSlR3S0JBZ3RKVGdJTlFRQVRTd0ZNQ1U0R1RnWlBCVThHZ1FPSUFha2lRMGdsUXYvc05ob0JTUlVrRWtRMkdnSkpGU01TUkJjMkdnTkpGU1FTUkRZYUJFa1ZJeEpFRnpZYUJVa1ZJeEpFRnpZYUJra1ZJeEpFRnpZYUIwa1ZJeEpFRnpZYUNFa1ZJeEpFRjRnQldTSkRKVFlhQVVrVkpCSkVOaG9DU1JVa0VrUTJHZ05KRlNJU1JDVlRUZ0pRQVV4QkFBZ3JURkFpRnI4aVF5dE1VRWxGQXIxRkFVSC84a204U0VMLzdEWWFBVWtWSkJKRU5ob0NTUlVqRWtRWEZsQW9Td0ZRdmt4T0FrU0FBWEJNVUVtOVJRRkJBRHUrUklFa3J5VVdnUU92VHdSTEFsQkxBbEJMQWxCTEFsQlBBbEJQQTFDQUJBQjFBSGRRVHdKUWdBRUFVRXhRZ0FRQUFBQUFVQ3BNVUxBaVEwZ3lBMEwvd1RZYUFVa1ZnU2dTUklBQmRVeFFTYjFGQVVFQUNMNUVLa3hRc0NKRFNJQnBBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVF2K0xOaG9CU1JVa0VrUTJHZ0pKRlNRU1JGQUJLMHhRdlVVQmdBRUFKVThDVkNwTVVMQWlRNG9JQUlBQmdJdjZVSXY3RmxDTC9SWlFJaFpRaS93V1VDVVdURXNCVUVzQlVJditGbENML3haUVRGQ0wrUmFMK0V4UWdBRjFURkJNdjRrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
