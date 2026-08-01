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

namespace Arc56.Generated.algorandfoundation.auto_draw_card.Main_eea3dabd
{


    public class MainProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MainProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CardData : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public Algorand.Address Address { get; set; }

                public ulong Nonce { get; set; }

                public ulong WithdrawalNonce { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawalNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWithdrawalNonce.From(WithdrawalNonce);
                    ret.AddRange(vWithdrawalNonce.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CardData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CardData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNonce = vNonce.ToValue();
                    if (valueNonce is ulong vNonceValue) { ret.Nonce = vNonceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawalNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWithdrawalNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWithdrawalNonce = vWithdrawalNonce.ToValue();
                    if (valueWithdrawalNonce is ulong vWithdrawalNonceValue) { ret.WithdrawalNonce = vWithdrawalNonceValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CardData);
                }
                public bool Equals(CardData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CardData left, CardData right)
                {
                    return EqualityComparer<CardData>.Default.Equals(left, right);
                }
                public static bool operator !=(CardData left, CardData right)
                {
                    return !(left == right);
                }

            }

            public class WithdrawalRequest : AVMObjectType
            {
                public Algorand.Address Card { get; set; }

                public Algorand.Address Recipient { get; set; }

                public ulong Asset { get; set; }

                public ulong Amount { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong Nonce { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCard.From(Card);
                    ret.AddRange(vCard.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vRecipient.From(Recipient);
                    ret.AddRange(vRecipient.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
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

                public static WithdrawalRequest Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new WithdrawalRequest();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCard.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCard = vCard.ToValue();
                    if (valueCard is Algorand.Address vCardValue) { ret.Card = vCardValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRecipient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecipient = vRecipient.ToValue();
                    if (valueRecipient is Algorand.Address vRecipientValue) { ret.Recipient = vRecipientValue; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
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
                    return Equals(obj as WithdrawalRequest);
                }
                public bool Equals(WithdrawalRequest? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(WithdrawalRequest left, WithdrawalRequest right)
                {
                    return EqualityComparer<WithdrawalRequest>.Default.Equals(left, right);
                }
                public static bool operator !=(WithdrawalRequest left, WithdrawalRequest right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class CardAssetEnabledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 87, 25, 206, 209 };
                public const string Signature = "CardAssetEnabled(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Card { get; set; }
                public ulong Asset { get; set; }

                public static CardAssetEnabledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CardAssetEnabledEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCard.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCard = vCard.ToValue();
                    if (valueCard is Algorand.Address vCardValue) { ret.Card = vCardValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    return ret;

                }

            }

            public class OwnershipTransferredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 154, 34, 62, 251 };
                public const string Signature = "OwnershipTransferred(address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address PreviousOwner { get; set; }
                public Algorand.Address NewOwner { get; set; }

                public static OwnershipTransferredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OwnershipTransferredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is Algorand.Address vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is Algorand.Address vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

            public class CardCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 245, 51, 64, 68 };
                public const string Signature = "CardCreated(address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address CardOwner { get; set; }
                public Algorand.Address Card { get; set; }

                public static CardCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CardCreatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCardOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCardOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCardOwner = vCardOwner.ToValue();
                    if (valueCardOwner is Algorand.Address vCardOwnerValue) { ret.CardOwner = vCardOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCard.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCard = vCard.ToValue();
                    if (valueCard is Algorand.Address vCardValue) { ret.Card = vCardValue; }
                    return ret;

                }

            }

            public class DebitEvent
            {
                public static readonly byte[] Selector = new byte[4] { 153, 74, 19, 103 };
                public const string Signature = "Debit(address,uint64,uint64,uint64,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Card { get; set; }
                public ulong Asset { get; set; }
                public ulong Amount { get; set; }
                public ulong Nonce { get; set; }
                public string Reference { get; set; }

                public static DebitEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DebitEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCard.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCard = vCard.ToValue();
                    if (valueCard is Algorand.Address vCardValue) { ret.Card = vCardValue; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNonce = vNonce.ToValue();
                    if (valueNonce is ulong vNonceValue) { ret.Nonce = vNonceValue; }
                    var indexReference = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReference = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vReference.Decode(eventData.Skip(indexReference).ToArray());
                    var valueReference = vReference.ToValue();
                    if (valueReference is string vReferenceValue) { ret.Reference = vReferenceValue; }
                    return ret;

                }

            }

            public class CardAssetDisabledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 128, 215, 127, 49 };
                public const string Signature = "CardAssetDisabled(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Card { get; set; }
                public ulong Asset { get; set; }

                public static CardAssetDisabledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CardAssetDisabledEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCard.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCard = vCard.ToValue();
                    if (valueCard is Algorand.Address vCardValue) { ret.Card = vCardValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    return ret;

                }

            }

            public class WithdrawalRequestEvent
            {
                public static readonly byte[] Selector = new byte[4] { 216, 95, 98, 10 };
                public const string Signature = "WithdrawalRequest(address,address,uint64,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Card { get; set; }
                public Algorand.Address Recipient { get; set; }
                public ulong Asset { get; set; }
                public ulong Amount { get; set; }
                public ulong CreatedAt { get; set; }
                public ulong Nonce { get; set; }

                public static WithdrawalRequestEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new WithdrawalRequestEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCard.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCard = vCard.ToValue();
                    if (valueCard is Algorand.Address vCardValue) { ret.Card = vCardValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRecipient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecipient = vRecipient.ToValue();
                    if (valueRecipient is Algorand.Address vRecipientValue) { ret.Recipient = vRecipientValue; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNonce = vNonce.ToValue();
                    if (valueNonce is ulong vNonceValue) { ret.Nonce = vNonceValue; }
                    return ret;

                }

            }

            public class WithdrawalRequestCancelledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 63, 215, 130, 149 };
                public const string Signature = "WithdrawalRequestCancelled(address,address,uint64,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Card { get; set; }
                public Algorand.Address Recipient { get; set; }
                public ulong Asset { get; set; }
                public ulong Amount { get; set; }
                public ulong CreatedAt { get; set; }
                public ulong Nonce { get; set; }

                public static WithdrawalRequestCancelledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new WithdrawalRequestCancelledEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCard.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCard = vCard.ToValue();
                    if (valueCard is Algorand.Address vCardValue) { ret.Card = vCardValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRecipient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecipient = vRecipient.ToValue();
                    if (valueRecipient is Algorand.Address vRecipientValue) { ret.Recipient = vRecipientValue; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNonce = vNonce.ToValue();
                    if (valueNonce is ulong vNonceValue) { ret.Nonce = vNonceValue; }
                    return ret;

                }

            }

            public class WithdrawalEvent
            {
                public static readonly byte[] Selector = new byte[4] { 187, 77, 208, 6 };
                public const string Signature = "Withdrawal(address,address,uint64,uint64,uint64,uint64,uint64,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Card { get; set; }
                public Algorand.Address Recipient { get; set; }
                public ulong Asset { get; set; }
                public ulong Amount { get; set; }
                public ulong CreatedAt { get; set; }
                public ulong ExpiresAt { get; set; }
                public ulong Nonce { get; set; }
                public string Type { get; set; }

                public static WithdrawalEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new WithdrawalEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCard.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCard = vCard.ToValue();
                    if (valueCard is Algorand.Address vCardValue) { ret.Card = vCardValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRecipient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecipient = vRecipient.ToValue();
                    if (valueRecipient is Algorand.Address vRecipientValue) { ret.Recipient = vRecipientValue; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiresAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiresAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiresAt = vExpiresAt.ToValue();
                    if (valueExpiresAt is ulong vExpiresAtValue) { ret.ExpiresAt = vExpiresAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNonce = vNonce.ToValue();
                    if (valueNonce is ulong vNonceValue) { ret.Nonce = vNonceValue; }
                    var indexType = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vType.Decode(eventData.Skip(indexType).ToArray());
                    var valueType = vType.ToValue();
                    if (valueType is string vTypeValue) { ret.Type = vTypeValue; }
                    return ret;

                }

            }

            public class PauseEvent
            {
                public static readonly byte[] Selector = new byte[4] { 207, 35, 163, 15 };
                public const string Signature = "Pause()";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }

                public static PauseEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PauseEvent();
                    var eventData = log.Skip(4).ToArray();
                    return ret;

                }

            }

            public class UnpauseEvent
            {
                public static readonly byte[] Selector = new byte[4] { 177, 99, 238, 11 };
                public const string Signature = "Unpause()";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }

                public static UnpauseEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new UnpauseEvent();
                    var eventData = log.Skip(4).ToArray();
                    return ret;

                }

            }

            public class PauserChangedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 204, 64, 146, 60 };
                public const string Signature = "PauserChanged(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address NewAddress { get; set; }

                public static PauserChangedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PauserChangedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vNewAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewAddress = vNewAddress.ToValue();
                    if (valueNewAddress is Algorand.Address vNewAddressValue) { ret.NewAddress = vNewAddressValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Opt-in a card into an asset. Minimum balance requirement must be met prior to calling this function.
        ///Only the partner can call this function.
        ///</summary>
        /// <param name="card">Card address </param>
        /// <param name="asset">Asset to opt-in to </param>
        public async Task CardAssetOptIn(Algorand.Address card, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 170, 218, 67 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, cardAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CardAssetOptIn_Transactions(Algorand.Address card, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 170, 218, 67 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deploy the contract, setting the owner as provided and initializing global state.
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="omnibus"> </param>
        public async Task<Algorand.Address> Deploy(Algorand.Address owner, Algorand.Address omnibus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 72, 25, 61 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var omnibusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); omnibusAbi.From(omnibus);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, omnibusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Deploy_Transactions(Algorand.Address owner, Algorand.Address omnibus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 72, 25, 61 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var omnibusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); omnibusAbi.From(omnibus);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, omnibusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allows the owner to update the smart contract
        ///</summary>
        public async Task Update(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Destroy the smart contract, sending all Algo to the owner account. This can only be done if there are no active cards
        ///</summary>
        public async Task Destroy(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 134, 161, 133 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Destroy_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 134, 161, 133 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set the number of seconds a withdrawal request must wait until being withdrawn
        ///</summary>
        /// <param name="seconds">New number of seconds to wait </param>
        public async Task SetWithdrawalTimeout(ulong seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 80, 245, 241 };
            var secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); secondsAbi.From(seconds);

            var result = await base.CallApp(new List<object> { abiHandle, secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetWithdrawalTimeout_Transactions(ulong seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 80, 245, 241 };
            var secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); secondsAbi.From(seconds);

            return await base.MakeTransactionList(new List<object> { abiHandle, secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the withdrawal public key.
        ///</summary>
        /// <param name="pubkey">- The public key to set. </param>
        public async Task SetWithdrawalPubkey(byte[] pubkey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 223, 149, 220 };
            var pubkeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); pubkeyAbi.From(pubkey);

            var result = await base.CallApp(new List<object> { abiHandle, pubkeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetWithdrawalPubkey_Transactions(byte[] pubkey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 223, 149, 220 };
            var pubkeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); pubkeyAbi.From(pubkey);

            return await base.MakeTransactionList(new List<object> { abiHandle, pubkeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a card. This generates a brand new account and funds the minimum balance requirement
        ///from the contract (owner-sponsored). Only the partner can call this function.
        ///</summary>
        /// <param name="cardOwner">The card holder who will own/control the card </param>
        /// <param name="asset">Asset to opt-in to. 0 = No asset opt-in </param>
        public async Task<Algorand.Address> CardCreate(Algorand.Address cardOwner, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 39, 113, 67 };
            var cardOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardOwnerAbi.From(cardOwner);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, cardOwnerAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> CardCreate_Transactions(Algorand.Address cardOwner, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 39, 113, 67 };
            var cardOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardOwnerAbi.From(cardOwner);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardOwnerAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Close account. This permanently removes the rekey and deletes the account from the ledger.
        ///Only the partner or the card holder can call this function.
        ///</summary>
        /// <param name="card">Address to close </param>
        public async Task CardClose(Algorand.Address card, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 187, 157, 253 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);

            var result = await base.CallApp(new List<object> { abiHandle, cardAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CardClose_Transactions(Algorand.Address card, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 187, 157, 253 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Recovers funds from an old card and transfers them to a new card.
        ///Only the owner of the contract can perform this operation.
        ///</summary>
        /// <param name="card">- The card to recover. </param>
        /// <param name="newCardHolder">- The address of the new card holder. </param>
        public async Task CardRecover(Algorand.Address card, Algorand.Address newCardHolder, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 161, 35, 139 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var newCardHolderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newCardHolderAbi.From(newCardHolder);

            var result = await base.CallApp(new List<object> { abiHandle, cardAbi, newCardHolderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CardRecover_Transactions(Algorand.Address card, Algorand.Address newCardHolder, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 161, 35, 139 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var newCardHolderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newCardHolderAbi.From(newCardHolder);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi, newCardHolderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Debits the specified amount of the given asset from the card account.
        ///Only the owner of the contract can perform this operation.
        ///
        ///The AutoDraw lsig binds `card` and `cardOwner` to the axfer receiver, so verifying here that
        ///`cardOwner` owns `card` prevents the delegated draw from funding (and subsequently
        ///debiting) a card the account does not own.
        ///</summary>
        /// <param name="cardOwner"> </param>
        /// <param name="card">The card from which the asset will be debited. </param>
        /// <param name="asset">The asset to be debited. </param>
        /// <param name="amount">The amount of the asset to be debited. </param>
        /// <param name="nonce"> </param>
        /// <param name="ref"> </param>
        public async Task CardDebit(Algorand.Address cardOwner, Algorand.Address card, ulong asset, ulong amount, ulong nonce, string @ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 22, 38, 36 };
            var cardOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardOwnerAbi.From(cardOwner);
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); refAbi.From(@ref);

            var result = await base.CallApp(new List<object> { abiHandle, cardOwnerAbi, cardAbi, assetAbi, amountAbi, nonceAbi, refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CardDebit_Transactions(Algorand.Address cardOwner, Algorand.Address card, ulong asset, ulong amount, ulong nonce, string @ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 22, 38, 36 };
            var cardOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardOwnerAbi.From(cardOwner);
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); refAbi.From(@ref);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardOwnerAbi, cardAbi, assetAbi, amountAbi, nonceAbi, refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the next available nonce for the card.
        ///</summary>
        /// <param name="card">The card address. </param>
        public async Task<ulong> GetNextCardNonce(Algorand.Address card, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 238, 43, 161 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);

            var result = await base.SimApp(new List<object> { abiHandle, cardAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetNextCardNonce_Transactions(Algorand.Address card, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 238, 43, 161 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the card data for a given card address.
        ///</summary>
        /// <param name="card">The address of the card. </param>
        public async Task<Structs.CardData> GetCardData(Algorand.Address card, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 93, 191, 22 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);

            var result = await base.SimApp(new List<object> { abiHandle, cardAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CardData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetCardData_Transactions(Algorand.Address card, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 93, 191, 22 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the partner address.
        ///Only the owner of the contract can call this method.
        ///</summary>
        /// <param name="newPartnerAddress">The new partner address to be set. </param>
        public async Task SetPartnerAddress(Algorand.Address newPartnerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 27, 39, 137 };
            var newPartnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newPartnerAddressAbi.From(newPartnerAddress);

            var result = await base.CallApp(new List<object> { abiHandle, newPartnerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPartnerAddress_Transactions(Algorand.Address newPartnerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 27, 39, 137 };
            var newPartnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newPartnerAddressAbi.From(newPartnerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, newPartnerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the omnibus address.
        ///Only the owner of the contract can call this method.
        ///</summary>
        /// <param name="newOmnibusAddress">The new omnibus address to be set. </param>
        public async Task SetOmnibusAddress(Algorand.Address newOmnibusAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 115, 29, 230 };
            var newOmnibusAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOmnibusAddressAbi.From(newOmnibusAddress);

            var result = await base.CallApp(new List<object> { abiHandle, newOmnibusAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetOmnibusAddress_Transactions(Algorand.Address newOmnibusAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 115, 29, 230 };
            var newOmnibusAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOmnibusAddressAbi.From(newOmnibusAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOmnibusAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allows the card holder (or partner) to CloseOut of an asset, reducing the minimum balance
        ///requirement of the account. The freed MBR remains within the card account.
        ///</summary>
        /// <param name="card">- The address of the card. </param>
        /// <param name="asset">- The ID of the asset to be removed. </param>
        public async Task CardDisableAsset(Algorand.Address card, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 55, 213, 9 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, cardAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CardDisableAsset_Transactions(Algorand.Address card, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 55, 213, 9 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allows the card holder to request a withdrawal of an amount of assets from the account
        ///</summary>
        /// <param name="card">Address to withdraw from </param>
        /// <param name="asset">Asset to withdraw </param>
        /// <param name="amount">Amount to withdraw </param>
        public async Task<Structs.WithdrawalRequest> WithdrawalRequest(Algorand.Address card, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 52, 145, 88 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, cardAbi, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.WithdrawalRequest.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> WithdrawalRequest_Transactions(Algorand.Address card, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 52, 145, 88 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allows the card holder to cancel a withdrawal request
        ///</summary>
        /// <param name="card">Address to withdraw from </param>
        public async Task WithdrawalCancel(Algorand.Address card, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 208, 222, 240 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);

            var result = await base.CallApp(new List<object> { abiHandle, cardAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawalCancel_Transactions(Algorand.Address card, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 208, 222, 240 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allows the card holder to send an amount of assets from the account
        ///</summary>
        /// <param name="card">Address to withdraw from </param>
        /// <param name="amount"> </param>
        public async Task Withdraw(Algorand.Address card, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 255, 28, 233 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, cardAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(Algorand.Address card, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 255, 28, 233 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraws funds before the withdrawal timestamp has lapsed, by using the permissioned withdrawal signature provided by partner.
        ///</summary>
        /// <param name="card">- The address of the card. </param>
        /// <param name="asset">- The ID of the asset to be withdrawn. </param>
        /// <param name="amount">- The amount of the withdrawal. </param>
        /// <param name="expiresAt">- The expiry of the withdrawal signature. </param>
        /// <param name="nonce"> </param>
        /// <param name="signature">- The signature for permissioned withdrawal. </param>
        public async Task WithdrawPermissioned(Algorand.Address card, ulong asset, ulong amount, ulong expiresAt, ulong nonce, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 227, 243, 127 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var expiresAtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiresAtAbi.From(expiresAt);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(64, "byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, cardAbi, assetAbi, amountAbi, expiresAtAbi, nonceAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawPermissioned_Transactions(Algorand.Address card, ulong asset, ulong amount, ulong expiresAt, ulong nonce, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 227, 243, 127 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var expiresAtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiresAtAbi.From(expiresAt);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(64, "byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi, assetAbi, amountAbi, expiresAtAbi, nonceAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Owner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 187, 176, 168 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Owner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 187, 176, 168 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfers the ownership of the contract to a new owner.
        ///Requires the caller to be the current owner.
        ///</summary>
        /// <param name="newOwner">The address of the new owner. </param>
        public async Task TransferOwnership(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 123, 175, 180 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferOwnership_Transactions(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 123, 175, 180 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Pauser(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 217, 83, 179 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Pauser_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 217, 83, 179 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Pause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Unpause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Unpause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_newPauser"> </param>
        public async Task UpdatePauser(Algorand.Address _newPauser, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 173, 209, 99 };
            var _newPauserAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _newPauserAbi.From(_newPauser);

            var result = await base.CallApp(new List<object> { abiHandle, _newPauserAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdatePauser_Transactions(Algorand.Address _newPauser, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 173, 209, 99 };
            var _newPauserAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _newPauserAbi.From(_newPauser);

            return await base.MakeTransactionList(new List<object> { abiHandle, _newPauserAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Recover an asset sent to the contract by mistake. Only the owner can call this function.
        ///</summary>
        /// <param name="asset">Asset ID of the asset to recover. If 0, Algo will be recovered. </param>
        /// <param name="amount">Amount of the asset to recover. If Algos, remember the minimum balance requirement. </param>
        /// <param name="recipient">Address to send the recovered asset to. </param>
        public async Task RecoverAsset(ulong asset, ulong amount, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 90, 27, 249 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, amountAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecoverAsset_Transactions(ulong asset, ulong amount, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 90, 27, 249 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, amountAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWFpbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDYXJkRGF0YSI6W3sibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3aXRoZHJhd2FsTm9uY2UiLCJ0eXBlIjoidWludDY0In1dLCJXaXRoZHJhd2FsUmVxdWVzdCI6W3sibmFtZSI6ImNhcmQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlY2lwaWVudCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXNzZXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNyZWF0ZWRBdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY2FyZEFzc2V0T3B0SW4iLCJkZXNjIjoiT3B0LWluIGEgY2FyZCBpbnRvIGFuIGFzc2V0LiBNaW5pbXVtIGJhbGFuY2UgcmVxdWlyZW1lbnQgbXVzdCBiZSBtZXQgcHJpb3IgdG8gY2FsbGluZyB0aGlzIGZ1bmN0aW9uLlxuT25seSB0aGUgcGFydG5lciBjYW4gY2FsbCB0aGlzIGZ1bmN0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOiJDYXJkIGFkZHJlc3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IkFzc2V0IHRvIG9wdC1pbiB0byIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ2FyZEFzc2V0RW5hYmxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwbG95IiwiZGVzYyI6IkRlcGxveSB0aGUgY29udHJhY3QsIHNldHRpbmcgdGhlIG93bmVyIGFzIHByb3ZpZGVkIGFuZCBpbml0aWFsaXppbmcgZ2xvYmFsIHN0YXRlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbW5pYnVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZSIsImRlc2MiOiJBbGxvd3MgdGhlIG93bmVyIHRvIHVwZGF0ZSB0aGUgc21hcnQgY29udHJhY3QiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlc3Ryb3kiLCJkZXNjIjoiRGVzdHJveSB0aGUgc21hcnQgY29udHJhY3QsIHNlbmRpbmcgYWxsIEFsZ28gdG8gdGhlIG93bmVyIGFjY291bnQuIFRoaXMgY2FuIG9ubHkgYmUgZG9uZSBpZiB0aGVyZSBhcmUgbm8gYWN0aXZlIGNhcmRzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRXaXRoZHJhd2FsVGltZW91dCIsImRlc2MiOiJTZXQgdGhlIG51bWJlciBvZiBzZWNvbmRzIGEgd2l0aGRyYXdhbCByZXF1ZXN0IG11c3Qgd2FpdCB1bnRpbCBiZWluZyB3aXRoZHJhd24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2Vjb25kcyIsImRlc2MiOiJOZXcgbnVtYmVyIG9mIHNlY29uZHMgdG8gd2FpdCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRXaXRoZHJhd2FsUHVia2V5IiwiZGVzYyI6IlNldHMgdGhlIHdpdGhkcmF3YWwgcHVibGljIGtleS4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJrZXkiLCJkZXNjIjoiLSBUaGUgcHVibGljIGtleSB0byBzZXQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhcmRDcmVhdGUiLCJkZXNjIjoiQ3JlYXRlIGEgY2FyZC4gVGhpcyBnZW5lcmF0ZXMgYSBicmFuZCBuZXcgYWNjb3VudCBhbmQgZnVuZHMgdGhlIG1pbmltdW0gYmFsYW5jZSByZXF1aXJlbWVudFxuZnJvbSB0aGUgY29udHJhY3QgKG93bmVyLXNwb25zb3JlZCkuIE9ubHkgdGhlIHBhcnRuZXIgY2FuIGNhbGwgdGhpcyBmdW5jdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmRPd25lciIsImRlc2MiOiJUaGUgY2FyZCBob2xkZXIgd2hvIHdpbGwgb3duL2NvbnRyb2wgdGhlIGNhcmQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IkFzc2V0IHRvIG9wdC1pbiB0by4gMCA9IE5vIGFzc2V0IG9wdC1pbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjoiTmV3bHkgZ2VuZXJhdGVkIGFjY291bnQgdXNlZCBieSB0aGVpciBjYXJkIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNhcmRBc3NldEVuYWJsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ2FyZENyZWF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmRPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FyZENsb3NlIiwiZGVzYyI6IkNsb3NlIGFjY291bnQuIFRoaXMgcGVybWFuZW50bHkgcmVtb3ZlcyB0aGUgcmVrZXkgYW5kIGRlbGV0ZXMgdGhlIGFjY291bnQgZnJvbSB0aGUgbGVkZ2VyLlxuT25seSB0aGUgcGFydG5lciBvciB0aGUgY2FyZCBob2xkZXIgY2FuIGNhbGwgdGhpcyBmdW5jdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiQWRkcmVzcyB0byBjbG9zZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYXJkUmVjb3ZlciIsImRlc2MiOiJSZWNvdmVycyBmdW5kcyBmcm9tIGFuIG9sZCBjYXJkIGFuZCB0cmFuc2ZlcnMgdGhlbSB0byBhIG5ldyBjYXJkLlxuT25seSB0aGUgb3duZXIgb2YgdGhlIGNvbnRyYWN0IGNhbiBwZXJmb3JtIHRoaXMgb3BlcmF0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOiItIFRoZSBjYXJkIHRvIHJlY292ZXIuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3Q2FyZEhvbGRlciIsImRlc2MiOiItIFRoZSBhZGRyZXNzIG9mIHRoZSBuZXcgY2FyZCBob2xkZXIuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhcmREZWJpdCIsImRlc2MiOiJEZWJpdHMgdGhlIHNwZWNpZmllZCBhbW91bnQgb2YgdGhlIGdpdmVuIGFzc2V0IGZyb20gdGhlIGNhcmQgYWNjb3VudC5cbk9ubHkgdGhlIG93bmVyIG9mIHRoZSBjb250cmFjdCBjYW4gcGVyZm9ybSB0aGlzIG9wZXJhdGlvbi5cblxuVGhlIEF1dG9EcmF3IGxzaWcgYmluZHMgYGNhcmRgIGFuZCBgY2FyZE93bmVyYCB0byB0aGUgYXhmZXIgcmVjZWl2ZXIsIHNvIHZlcmlmeWluZyBoZXJlIHRoYXRcbmBjYXJkT3duZXJgIG93bnMgYGNhcmRgIHByZXZlbnRzIHRoZSBkZWxlZ2F0ZWQgZHJhdyBmcm9tIGZ1bmRpbmcgKGFuZCBzdWJzZXF1ZW50bHlcbmRlYml0aW5nKSBhIGNhcmQgdGhlIGFjY291bnQgZG9lcyBub3Qgb3duLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZE93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOiJUaGUgY2FyZCBmcm9tIHdoaWNoIHRoZSBhc3NldCB3aWxsIGJlIGRlYml0ZWQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdG8gYmUgZGViaXRlZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJUaGUgYW1vdW50IG9mIHRoZSBhc3NldCB0byBiZSBkZWJpdGVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRGViaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmZXJlbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TmV4dENhcmROb25jZSIsImRlc2MiOiJSZXRyaWV2ZXMgdGhlIG5leHQgYXZhaWxhYmxlIG5vbmNlIGZvciB0aGUgY2FyZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiVGhlIGNhcmQgYWRkcmVzcy4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIG5vbmNlIGZvciB0aGUgY2FyZC4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldENhcmREYXRhIiwiZGVzYyI6IlJldHJpZXZlcyB0aGUgY2FyZCBkYXRhIGZvciBhIGdpdmVuIGNhcmQgYWRkcmVzcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIGNhcmQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJDYXJkRGF0YSIsImRlc2MiOiJUaGUgY2FyZCBkYXRhLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UGFydG5lckFkZHJlc3MiLCJkZXNjIjoiU2V0cyB0aGUgcGFydG5lciBhZGRyZXNzLlxuT25seSB0aGUgb3duZXIgb2YgdGhlIGNvbnRyYWN0IGNhbiBjYWxsIHRoaXMgbWV0aG9kLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3UGFydG5lckFkZHJlc3MiLCJkZXNjIjoiVGhlIG5ldyBwYXJ0bmVyIGFkZHJlc3MgdG8gYmUgc2V0LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRPbW5pYnVzQWRkcmVzcyIsImRlc2MiOiJTZXRzIHRoZSBvbW5pYnVzIGFkZHJlc3MuXG5Pbmx5IHRoZSBvd25lciBvZiB0aGUgY29udHJhY3QgY2FuIGNhbGwgdGhpcyBtZXRob2QuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPbW5pYnVzQWRkcmVzcyIsImRlc2MiOiJUaGUgbmV3IG9tbmlidXMgYWRkcmVzcyB0byBiZSBzZXQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhcmREaXNhYmxlQXNzZXQiLCJkZXNjIjoiQWxsb3dzIHRoZSBjYXJkIGhvbGRlciAob3IgcGFydG5lcikgdG8gQ2xvc2VPdXQgb2YgYW4gYXNzZXQsIHJlZHVjaW5nIHRoZSBtaW5pbXVtIGJhbGFuY2VcbnJlcXVpcmVtZW50IG9mIHRoZSBhY2NvdW50LiBUaGUgZnJlZWQgTUJSIHJlbWFpbnMgd2l0aGluIHRoZSBjYXJkIGFjY291bnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6Ii0gVGhlIGFkZHJlc3Mgb2YgdGhlIGNhcmQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiItIFRoZSBJRCBvZiB0aGUgYXNzZXQgdG8gYmUgcmVtb3ZlZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNhcmRBc3NldERpc2FibGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd2FsUmVxdWVzdCIsImRlc2MiOiJBbGxvd3MgdGhlIGNhcmQgaG9sZGVyIHRvIHJlcXVlc3QgYSB3aXRoZHJhd2FsIG9mIGFuIGFtb3VudCBvZiBhc3NldHMgZnJvbSB0aGUgYWNjb3VudCIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOiJBZGRyZXNzIHRvIHdpdGhkcmF3IGZyb20iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IkFzc2V0IHRvIHdpdGhkcmF3IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiQW1vdW50IHRvIHdpdGhkcmF3IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IldpdGhkcmF3YWxSZXF1ZXN0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IldpdGhkcmF3YWxSZXF1ZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRlZEF0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd2FsQ2FuY2VsIiwiZGVzYyI6IkFsbG93cyB0aGUgY2FyZCBob2xkZXIgdG8gY2FuY2VsIGEgd2l0aGRyYXdhbCByZXF1ZXN0IiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6IkFkZHJlc3MgdG8gd2l0aGRyYXcgZnJvbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiV2l0aGRyYXdhbFJlcXVlc3RDYW5jZWxsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdGVkQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6IkFsbG93cyB0aGUgY2FyZCBob2xkZXIgdG8gc2VuZCBhbiBhbW91bnQgb2YgYXNzZXRzIGZyb20gdGhlIGFjY291bnQiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiQWRkcmVzcyB0byB3aXRoZHJhdyBmcm9tIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IldpdGhkcmF3YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdGVkQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcmVzQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR5cGUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd1Blcm1pc3Npb25lZCIsImRlc2MiOiJXaXRoZHJhd3MgZnVuZHMgYmVmb3JlIHRoZSB3aXRoZHJhd2FsIHRpbWVzdGFtcCBoYXMgbGFwc2VkLCBieSB1c2luZyB0aGUgcGVybWlzc2lvbmVkIHdpdGhkcmF3YWwgc2lnbmF0dXJlIHByb3ZpZGVkIGJ5IHBhcnRuZXIuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6Ii0gVGhlIGFkZHJlc3Mgb2YgdGhlIGNhcmQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiItIFRoZSBJRCBvZiB0aGUgYXNzZXQgdG8gYmUgd2l0aGRyYXduLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6Ii0gVGhlIGFtb3VudCBvZiB0aGUgd2l0aGRyYXdhbC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyZXNBdCIsImRlc2MiOiItIFRoZSBleHBpcnkgb2YgdGhlIHdpdGhkcmF3YWwgc2lnbmF0dXJlLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNjRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmF0dXJlIiwiZGVzYyI6Ii0gVGhlIHNpZ25hdHVyZSBmb3IgcGVybWlzc2lvbmVkIHdpdGhkcmF3YWwuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJXaXRoZHJhd2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRlZEF0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJlc0F0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eXBlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2Zlck93bmVyc2hpcCIsImRlc2MiOiJUcmFuc2ZlcnMgdGhlIG93bmVyc2hpcCBvZiB0aGUgY29udHJhY3QgdG8gYSBuZXcgb3duZXIuXG5SZXF1aXJlcyB0aGUgY2FsbGVyIHRvIGJlIHRoZSBjdXJyZW50IG93bmVyLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIG5ldyBvd25lci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJQYXVzZXIncyBhZGRyZXNzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bnBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJVbnBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVQYXVzZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9uZXdQYXVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlBhdXNlckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0FkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvdmVyQXNzZXQiLCJkZXNjIjoiUmVjb3ZlciBhbiBhc3NldCBzZW50IHRvIHRoZSBjb250cmFjdCBieSBtaXN0YWtlLiBPbmx5IHRoZSBvd25lciBjYW4gY2FsbCB0aGlzIGZ1bmN0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJBc3NldCBJRCBvZiB0aGUgYXNzZXQgdG8gcmVjb3Zlci4gSWYgMCwgQWxnbyB3aWxsIGJlIHJlY292ZXJlZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJBbW91bnQgb2YgdGhlIGFzc2V0IHRvIHJlY292ZXIuIElmIEFsZ29zLCByZW1lbWJlciB0aGUgbWluaW11bSBiYWxhbmNlIHJlcXVpcmVtZW50LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOiJBZGRyZXNzIHRvIHNlbmQgdGhlIHJlY292ZXJlZCBhc3NldCB0by4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjo1fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMzYxXSwiZXJyb3JNZXNzYWdlIjoiQU1PVU5UX0lOVkFMSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NzIsOTg0LDEwMDYsMTE2MCwxMjQ4LDEzNDcsMTM1MywxNDk4XSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxOF0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDhdLCJlcnJvck1lc3NhZ2UiOiJDQVJEU19TVElMTF9BQ1RJVkUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzkzXSwiZXJyb3JNZXNzYWdlIjoiQ0FSRF9OT1RfRk9VTkQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTcxXSwiZXJyb3JNZXNzYWdlIjoiSU5TVUZGSUNJRU5UX0JBTEFOQ0UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODgsMTM3NSwxNTE0XSwiZXJyb3JNZXNzYWdlIjoiTk9OQ0VfSU5WQUxJRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4MF0sImVycm9yTWVzc2FnZSI6Ik9XTkVSX0lOVkFMSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTQsNzI1LDEwNzksMTE1NCwxMjM0LDEzMzMsMTQ5MiwxODE4LDE5OTFdLCJlcnJvck1lc3NhZ2UiOiJTRU5ERVJfTk9UX0FMTE9XRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTg1XSwiZXJyb3JNZXNzYWdlIjoiU0lHTkFUVVJFX0lOVkFMSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjQyLDEzNDFdLCJlcnJvck1lc3NhZ2UiOiJXSVRIRFJBV0FMX1JFUVVFU1RfTk9UX0ZPVU5EIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM5MiwxNTA0XSwiZXJyb3JNZXNzYWdlIjoiV0lUSERSQVdBTF9USU1FX0lOVkFMSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDYsNDE2LDY3NCw3NTUsODYwLDg5NCwxMzg1LDE1ODAsMTYxMywxNjQwLDE4MDksMTk4OSwyMDA5LDIwMzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTMsOTY5LDE5ODFdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM0LDM1NiwzNjQsNDU4LDQ3Niw3MTAsNzc0LDc4Miw4MDMsODExLDk3OSwxMDAxLDEwMjAsMTAzNywxMDU0LDExMzAsMTIzMCwxMzE4LDE0MjgsMTYyNywxNjg2LDE3NDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDIsNDQwLDQ4NCw4MTksODI4LDgzNywxMDYyLDExMzgsMTE0NywxMzI2LDE0MzYsMTQ0OCwxNDYyLDE0NzQsMTcxOCwxNzI4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURNeUlEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltTm1JaUFpZDNJaUlEQjRNVFV4Wmpkak56VWdJbU5tWVdNaUlDSmZiM2R1WlhJaUlDSmZjR0YxYzJWeUlpQWljR0YxYzJWa0lpQWliMkVpSUNKM2QzUWlJQ0p3ZDNCcklpQWljR0VpSUNKd1pYSnRhWE56YVc5dWJHVnpjeUlnTUhnd05qZ3hNREVnSW1Gd2NISnZkbVZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ETUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOWVdsdUlHVjRkR1Z1WkhNZ1kyeGhjM05sY3loUGQyNWhZbXhsTENCUVlYVnpZV0pzWlN3Z1VtVmpiM1psY21GaWJHVXBJSHNLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhoTUdVNE1UZzNNaUF3ZURsak9EWmhNVGcxSUM4dklHMWxkR2h2WkNBaWRYQmtZWFJsS0NsMmIybGtJaXdnYldWMGFHOWtJQ0prWlhOMGNtOTVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MWNHUmhkR1ZmY205MWRHVkFOQ0J0WVdsdVgyUmxjM1J5YjNsZmNtOTFkR1ZBTlFvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTFoYVc0Z1pYaDBaVzVrY3lCamJHRnpjMlZ6S0U5M2JtRmliR1VzSUZCaGRYTmhZbXhsTENCU1pXTnZkbVZ5WVdKc1pTa2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBek1nb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHRXhZV0ZrWVRReklEQjRZVEExTUdZMVpqRWdNSGhpWm1SbU9UVmtZeUF3ZURWaU1qYzNNVFF6SURCNE5EZGlZamxrWm1RZ01IZ3pabUV4TWpNNFlpQXdlR0ZrTVRZeU5qSTBJREI0WTJKbFpUSmlZVEVnTUhnM05EVmtZbVl4TmlBd2VHUmhNV0l5TnpnNUlEQjRZV00zTXpGa1pUWWdNSGc1TlRNM1pEVXdPU0F3ZUdJM016UTVNVFU0SURCNFltSmtNR1JsWmpBZ01IZ3hNMlptTVdObE9TQXdlR1l5WlRObU16ZG1JREI0WWpGaVltSXdZVGdnTUhobE1UZGlZV1ppTkNBd2VHSXdaRGsxTTJJeklEQjRNREUzT0dZNU5HSWdNSGd4WWpVeU9XUmxPQ0F3ZURCallXUmtNVFl6SURCNE56ZzFZVEZpWmprZ0x5OGdiV1YwYUc5a0lDSmpZWEprUVhOelpYUlBjSFJKYmloaFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJYYVhSb1pISmhkMkZzVkdsdFpXOTFkQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBWMmwwYUdSeVlYZGhiRkIxWW10bGVTaGllWFJsV3pNeVhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKallYSmtRM0psWVhSbEtHRmtaSEpsYzNNc2RXbHVkRFkwS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW1OaGNtUkRiRzl6WlNoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5oY21SU1pXTnZkbVZ5S0dGa1pISmxjM01zWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmpZWEprUkdWaWFYUW9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUk9aWGgwUTJGeVpFNXZibU5sS0dGa1pISmxjM01wZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSRFlYSmtSR0YwWVNoaFpHUnlaWE56S1NoaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbk5sZEZCaGNuUnVaWEpCWkdSeVpYTnpLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBUMjF1YVdKMWMwRmtaSEpsYzNNb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0pqWVhKa1JHbHpZV0pzWlVGemMyVjBLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5kcGRHaGtjbUYzWVd4U1pYRjFaWE4wS0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5Da29ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNZV3hEWVc1alpXd29ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKM2FYUm9aSEpoZHloaFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjNhWFJvWkhKaGQxQmxjbTFwYzNOcGIyNWxaQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hpZVhSbFd6WTBYU2wyYjJsa0lpd2diV1YwYUc5a0lDSnZkMjVsY2lncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaWRISmhibk5tWlhKUGQyNWxjbk5vYVhBb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p3WVhWelpYSW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbkJoZFhObEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMWJuQmhkWE5sS0NsMmIybGtJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVlFZWFZ6WlhJb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p5WldOdmRtVnlRWE56WlhRb2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpZWEprUVhOelpYUlBjSFJKYmlCelpYUlhhWFJvWkhKaGQyRnNWR2x0Wlc5MWRDQnpaWFJYYVhSb1pISmhkMkZzVUhWaWEyVjVJR05oY21SRGNtVmhkR1VnWTJGeVpFTnNiM05sSUdOaGNtUlNaV052ZG1WeUlHTmhjbVJFWldKcGRDQm5aWFJPWlhoMFEyRnlaRTV2Ym1ObElHZGxkRU5oY21SRVlYUmhJSE5sZEZCaGNuUnVaWEpCWkdSeVpYTnpJSE5sZEU5dGJtbGlkWE5CWkdSeVpYTnpJR05oY21SRWFYTmhZbXhsUVhOelpYUWdkMmwwYUdSeVlYZGhiRkpsY1hWbGMzUWdkMmwwYUdSeVlYZGhiRU5oYm1ObGJDQjNhWFJvWkhKaGR5QjNhWFJvWkhKaGQxQmxjbTFwYzNOcGIyNWxaQ0J2ZDI1bGNpQjBjbUZ1YzJabGNrOTNibVZ5YzJocGNDQndZWFZ6WlhJZ2NHRjFjMlVnZFc1d1lYVnpaU0IxY0dSaGRHVlFZWFZ6WlhJZ2NtVmpiM1psY2tGemMyVjBDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNekk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTFoYVc0Z1pYaDBaVzVrY3lCamJHRnpjMlZ6S0U5M2JtRmliR1VzSUZCaGRYTmhZbXhsTENCU1pXTnZkbVZ5WVdKc1pTa2dld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVGMwT0RFNU0yUWdMeThnYldWMGFHOWtJQ0prWlhCc2Iza29ZV1JrY21WemN5eGhaR1J5WlhOektXRmtaSEpsYzNNaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmtaWEJzYjNrS0lDQWdJR1Z5Y2dvS2JXRnBibDlrWlhOMGNtOTVYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlkZElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQndkWE5vYVc1MElEVWdMeThnUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZaUJrWlhOMGNtOTVDZ3B0WVdsdVgzVndaR0YwWlY5eWIzVjBaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9UY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc25WWEJrWVhSbFFYQndiR2xqWVhScGIyNG5YU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklGVndaR0YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdJZ2RYQmtZWFJsQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdGcGJpNWpZWEprUVhOelpYUlBjSFJKYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTmhjbVJCYzNObGRFOXdkRWx1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EWUtJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtRWE56WlhSUGNIUkpiaWhqWVhKa09pQkJZMk52ZFc1MExDQmhjM05sZERvZ1FYTnpaWFFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMkZzYkhOMVlpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtTmhjbVJCYzNObGRFOXdkRWx1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdGcGJpNWtaWEJzYjNsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaWEJzYjNrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dXeWRPYjA5d0oxMHNJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE1nb2dJQ0FnTHk4Z2RHaHBjeTVmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFvYjNkdVpYSXBDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1qUUtJQ0FnSUM4dklIUm9hWE11YjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTkFvZ0lDQWdMeThnY0hWaWJHbGpJRzl0Ym1saWRYTmZZV1JrY21WemN5QTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2EyVjVPaUFuYjJFbklIMHBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSnZZU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRJMkNpQWdJQ0F2THlCMGFHbHpMbTl0Ym1saWRYTmZZV1JrY21WemN5NTJZV3gxWlNBOUlHNWxkMDl0Ym1saWRYTkJaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSEIxWW14cFl5QmZjR0YxYzJWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWDNCaGRYTmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnMENpQWdJQ0F2THlCMGFHbHpMbDl3WVhWelpYSXVkbUZzZFdVZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGdLSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprYzE5aFkzUnBkbVZmWTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWTJaaFl5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbU5tWVdNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRPQW9nSUNBZ0x5OGdkR2hwY3k1allYSmtjMTloWTNScGRtVmZZMjkxYm5RdWRtRnNkV1VnUFNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRjFjMlZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9LUW9nSUNBZ1lubDBaV01nTmlBdkx5QWljR0YxYzJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPRGtLSUNBZ0lDOHZJSFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxJRDBnWm1Gc2MyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPREFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNuVG05UGNDZGRMQ0J2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa3hDaUFnSUNBdkx5QnlaWFIxY200Z1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZE9iMDl3SjEwc0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdGcGJpNTFjR1JoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVPUW9nSUNBZ0x5OGdkR2hwY3k1dmJteDVUM2R1WlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJ2Ym14NVQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lCYkoxVndaR0YwWlVGd2NHeHBZMkYwYVc5dUoxMGdmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtUmxjM1J5YjNsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaWE4wY205NU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNRGNLSUNBZ0lDOHZJSFJvYVhNdWIyNXNlVTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnYjI1c2VVOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeE1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbU5oY21SelgyRmpkR2wyWlY5amIzVnVkQzUyWVd4MVpTd2dKME5CVWtSVFgxTlVTVXhNWDBGRFZFbFdSU2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRnS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa2MxOWhZM1JwZG1WZlkyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBblkyWmhZeWNnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1ObVlXTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TUFvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxtTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDNTJZV3gxWlN3Z0owTkJVa1JUWDFOVVNVeE1YMEZEVkVsV1JTY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRU5CVWtSVFgxTlVTVXhNWDBGRFZFbFdSUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVRJdE16RTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUhSb2FYTXViM2R1WlhJb0tTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TkFvZ0lDQWdMeThnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxsOXZkMjVsY2k1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJSEIxWW14cFl5QmZiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pmYjNkdVpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1ZmIzZHVaWEl1ZG1Gc2RXVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOc2IzTmxVbVZ0WVdsdVpHVnlWRzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFMUNpQWdJQ0F2THlCaGJXOTFiblE2SURBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RXlMVE14TndvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ0lDQmpiRzl6WlZKbGJXRnBibVJsY2xSdk9pQjBhR2x6TG05M2JtVnlLQ2tzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TWkwek1UZ0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklEQXNDaUFnSUNBdkx5QWdJQ0FnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nZEdocGN5NXZkMjVsY2lncExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlkZElIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV0ZwYmk1elpYUlhhWFJvWkhKaGQyRnNWR2x0Wlc5MWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZkcGRHaGtjbUYzWVd4VWFXMWxiM1YwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1qWUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlhhWFJvWkhKaGQyRnNWR2x0Wlc5MWRDaHpaV052Ym1Sek9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekkzQ2lBZ0lDQXZMeUIwYUdsekxtOXViSGxQZDI1bGNpZ3BDaUFnSUNCallXeHNjM1ZpSUc5dWJIbFBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5URUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDJGc1gzZGhhWFJmZEdsdFpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2QzZDNRbklIMHBDaUFnSUNCaWVYUmxZeUE0SUM4dklDSjNkM1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeU9Rb2dJQ0FnTHk4Z2RHaHBjeTUzYVhSb1pISmhkMkZzWDNkaGFYUmZkR2x0WlM1MllXeDFaU0E5SUhObFkyOXVaSE1LSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeU5nb2dJQ0FnTHk4Z2NIVmliR2xqSUhObGRGZHBkR2hrY21GM1lXeFVhVzFsYjNWMEtITmxZMjl1WkhNNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxaGFXNHVjMlYwVjJsMGFHUnlZWGRoYkZCMVltdGxlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGZHBkR2hrY21GM1lXeFFkV0pyWlhrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpOZ29nSUNBZ0x5OGdjSFZpYkdsaklITmxkRmRwZEdoa2NtRjNZV3hRZFdKclpYa29jSFZpYTJWNU9pQmllWFJsY3p3ek1qNHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNemNLSUNBZ0lDOHZJSFJvYVhNdWIyNXNlVTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnYjI1c2VVOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhkcGRHaGtjbUYzWVd4ZmNIVmlhMlY1SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNOE16SStQaWg3SUd0bGVUb2dKM0IzY0dzbklIMHBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSndkM0JySWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek16a0tJQ0FnSUM4dklIUm9hWE11ZDJsMGFHUnlZWGRoYkY5d2RXSnJaWGt1ZG1Gc2RXVWdQU0J3ZFdKclpYa0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak16TmdvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEZkcGRHaGtjbUYzWVd4UWRXSnJaWGtvY0hWaWEyVjVPaUJpZVhSbGN6d3pNajRwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtTmhjbVJEY21WaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqWVhKa1EzSmxZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Ea0tJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtRM0psWVhSbEtHTmhjbVJQZDI1bGNqb2dRV05qYjNWdWRDd2dZWE56WlhRNklFRnpjMlYwS1RvZ1FXTmpiM1Z1ZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selVHRnlkRzVsY2lncExDQW5VMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVKeWtLSUNBZ0lHTmhiR3h6ZFdJZ2FYTlFZWEowYm1WeUNpQWdJQ0JoYzNObGNuUWdMeThnVTBWT1JFVlNYMDVQVkY5QlRFeFBWMFZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMU5Bb2dJQ0FnTHk4Z1lXUmtjbVZ6Y3pvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMU1pMHpOVGNLSUNBZ0lDOHZJR052Ym5OMElHTmhjbVJFWVhSaE9pQkRZWEprUkdGMFlTQTlJSHNLSUNBZ0lDOHZJQ0FnYjNkdVpYSTZJR05oY21SUGQyNWxjaXdLSUNBZ0lDOHZJQ0FnWVdSa2NtVnpjem9nUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCdWIyNWpaVG9nTUN3S0lDQWdJQzh2SUNBZ2QybDBhR1J5WVhkaGJFNXZibU5sT2lBd0xBb2dJQ0FnTHk4Z2ZRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0xTlFvZ0lDQWdMeThnYm05dVkyVTZJREFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TlRJdE16VTNDaUFnSUNBdkx5QmpiMjV6ZENCallYSmtSR0YwWVRvZ1EyRnlaRVJoZEdFZ1BTQjdDaUFnSUNBdkx5QWdJRzkzYm1WeU9pQmpZWEprVDNkdVpYSXNDaUFnSUNBdkx5QWdJR0ZrWkhKbGMzTTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnYm05dVkyVTZJREFzQ2lBZ0lDQXZMeUFnSUhkcGRHaGtjbUYzWVd4T2IyNWpaVG9nTUN3S0lDQWdJQzh2SUgwS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmpFdE16WTFDaUFnSUNBdkx5QmpiMjV6ZENCallYSmtRV1JrY2lBOUlHRnlZelF1WVdKcFEyRnNiRHgwZVhCbGIyWWdRMjl1ZEhKdmJHeGxaRUZrWkhKbGMzTXVjSEp2ZEc5MGVYQmxMbTVsZHo0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJ5YjNaaGJGQnliMmR5WVcwNklHTnZiWEJwYkdWa1EyRnlaQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMHNDaUFnSUNBdkx5QWdJR05zWldGeVUzUmhkR1ZRY205bmNtRnRPaUJqYjIxd2FXeGxaRU5oY21RdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwc0NpQWdJQ0F2THlBZ0lHOXVRMjl0Y0d4bGRHbHZiam9nVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVFWld4bGRHVkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMk5Bb2dJQ0FnTHk4Z2IyNURiMjF3YkdWMGFXOXVPaUJQYmtOdmJYQnNaWFJsUVdOMGFXOXVMa1JsYkdWMFpVRndjR3hwWTJGMGFXOXVMQW9nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOakFLSUNBZ0lDOHZJR052Ym5OMElHTnZiWEJwYkdWa1EyRnlaQ0E5SUdOdmJYQnBiR1VvUTI5dWRISnZiR3hsWkVGa1pISmxjM01wQ2lBZ0lDQndkWE5vWW5sMFpYTWdZbUZ6WlRZMEtFTTBSVUpSZHowOUtRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHVmhjbE4wWVhSbFVISnZaM0poYlZCaFoyVnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVFkwS0VONVFVTkJRVWRCUWtaWlpFd3JiekpIWjBOUFFWRkJRa0ZFUlZwblVWVlRUVkpuVlVWRlVrTkJRVU40VFdkdmVVUnlTV2RKY2tsSmMyZGphbk5vUVdselowZDZaMEZSVmtnemVERk5aM0JSYzBOT1JDa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNell4TFRNMk5Rb2dJQ0FnTHk4Z1kyOXVjM1FnWTJGeVpFRmtaSElnUFNCaGNtTTBMbUZpYVVOaGJHdzhkSGx3Wlc5bUlFTnZiblJ5YjJ4c1pXUkJaR1J5WlhOekxuQnliM1J2ZEhsd1pTNXVaWGMrS0hzS0lDQWdJQzh2SUNBZ1lYQndjbTkyWVd4UWNtOW5jbUZ0T2lCamIyMXdhV3hsWkVOaGNtUXVZWEJ3Y205MllXeFFjbTluY21GdExBb2dJQ0FnTHk4Z0lDQmpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJUb2dZMjl0Y0dsc1pXUkRZWEprTG1Oc1pXRnlVM1JoZEdWUWNtOW5jbUZ0TEFvZ0lDQWdMeThnSUNCdmJrTnZiWEJzWlhScGIyNDZJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVSR1ZzWlhSbFFYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRZeFpESm1aV0VnTHk4Z2JXVjBhRzlrSUNKdVpYY29LV0ZrWkhKbGMzTWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelk0Q2lBZ0lDQXZMeUJqWVhKa1JHRjBZUzVoWkdSeVpYTnpJRDBnWTJGeVpFRmtaSElLSUNBZ0lISmxjR3hoWTJVeUlETXlDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0zTVFvZ0lDQWdMeThnWTI5dWMzUWdZWE56WlhSTlluSTZJSFZwYm5RMk5DQTlJR0Z6YzJWMExtbGtJRDhnUjJ4dlltRnNMbUZ6YzJWMFQzQjBTVzVOYVc1Q1lXeGhibU5sSURvZ01Bb2dJQ0FnWW5vZ1kyRnlaRU55WldGMFpWOTBaWEp1WVhKNVgyWmhiSE5sUURRS0lDQWdJR2RzYjJKaGJDQkJjM05sZEU5d2RFbHVUV2x1UW1Gc1lXNWpaUW9LWTJGeVpFTnlaV0YwWlY5MFpYSnVZWEo1WDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM01pMHpOemNLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJqWVhKa1FXUmtjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUVkc2IySmhiQzV0YVc1Q1lXeGhibU5sSUNzZ1lYTnpaWFJOWW5Jc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOelVLSUNBZ0lDOHZJR0Z0YjNWdWREb2dSMnh2WW1Gc0xtMXBia0poYkdGdVkyVWdLeUJoYzNObGRFMWljaXdLSUNBZ0lHZHNiMkpoYkNCTmFXNUNZV3hoYm1ObENpQWdJQ0FyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y3lMVE0zTmdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUdOaGNtUkJaR1J5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1IyeHZZbUZzTG0xcGJrSmhiR0Z1WTJVZ0t5QmhjM05sZEUxaWNpd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y3lMVE0zTndvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUdOaGNtUkJaR1J5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1IyeHZZbUZzTG0xcGJrSmhiR0Z1WTJVZ0t5QmhjM05sZEUxaWNpd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0RBS0lDQWdJQzh2SUdsbUlDaGhjM05sZEM1cFpDa2dld29nSUNBZ1pHbG5JRE1LSUNBZ0lHSjZJR05oY21SRGNtVmhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00TVFvZ0lDQWdMeThnZEdocGN5NWpZWEprUVhOelpYUlBjSFJKYmloallYSmtRV1JrY2l3Z1lYTnpaWFFwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaR2xuSURRS0lDQWdJR05oYkd4emRXSWdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdGcGJpNWpZWEprUVhOelpYUlBjSFJKYmdvS1kyRnlaRU55WldGMFpWOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOZ29nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVOaGNtUkVZWFJoUGloN0lHdGxlVkJ5WldacGVEb2dKMk5tSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyWWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00TlFvZ0lDQWdMeThnZEdocGN5NWpZWEprY3loallYSmtRV1JrY2lrdWRtRnNkV1VnUFNCamJHOXVaU2hqWVhKa1JHRjBZU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0RnS0lDQWdJQzh2SUhSb2FYTXVZMkZ5WkhOZllXTjBhWFpsWDJOdmRXNTBMblpoYkhWbElEMGdkR2hwY3k1allYSmtjMTloWTNScGRtVmZZMjkxYm5RdWRtRnNkV1VnS3lBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EZ0tJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtjMTloWTNScGRtVmZZMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ZMlpoWXljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTm1ZV01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNE9Bb2dJQ0FnTHk4Z2RHaHBjeTVqWVhKa2MxOWhZM1JwZG1WZlkyOTFiblF1ZG1Gc2RXVWdQU0IwYUdsekxtTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDNTJZV3gxWlNBcklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRnS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa2MxOWhZM1JwZG1WZlkyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBblkyWmhZeWNnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1ObVlXTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00T0FvZ0lDQWdMeThnZEdocGN5NWpZWEprYzE5aFkzUnBkbVZmWTI5MWJuUXVkbUZzZFdVZ1BTQjBhR2x6TG1OaGNtUnpYMkZqZEdsMlpWOWpiM1Z1ZEM1MllXeDFaU0FySURFS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTVNQzB6T1RNS0lDQWdJQzh2SUdWdGFYUThRMkZ5WkVOeVpXRjBaV1ErS0hzS0lDQWdJQzh2SUNBZ1kyRnlaRTkzYm1WeU9pQmpZWEprVDNkdVpYSXNDaUFnSUNBdkx5QWdJR05oY21RNklHTmhjbVJCWkdSeUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1kxTXpNME1EUTBJQzh2SUcxbGRHaHZaQ0FpUTJGeVpFTnlaV0YwWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBPUW9nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJEY21WaGRHVW9ZMkZ5WkU5M2JtVnlPaUJCWTJOdmRXNTBMQ0JoYzNObGREb2dRWE56WlhRcE9pQkJZMk52ZFc1MElIc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU5oY21SRGNtVmhkR1ZmZEdWeWJtRnllVjltWVd4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TnpFS0lDQWdJQzh2SUdOdmJuTjBJR0Z6YzJWMFRXSnlPaUIxYVc1ME5qUWdQU0JoYzNObGRDNXBaQ0EvSUVkc2IySmhiQzVoYzNObGRFOXdkRWx1VFdsdVFtRnNZVzVqWlNBNklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdOaGNtUkRjbVZoZEdWZmRHVnlibUZ5ZVY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdGcGJpNWpZWEprUTJ4dmMyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqWVhKa1EyeHZjMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd05Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUkRiRzl6WlNoallYSmtPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREExQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1cGMxQmhjblJ1WlhJb0tTQjhmQ0IwYUdsekxtbHpRMkZ5WkU5M2JtVnlLR05oY21RcExDQW5VMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVKeWtLSUNBZ0lHTmhiR3h6ZFdJZ2FYTlFZWEowYm1WeUNpQWdJQ0JpYm5vZ1kyRnlaRU5zYjNObFgySnZiMnhmZEhKMVpVQXpDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnYVhORFlYSmtUM2R1WlhJS0lDQWdJR0o2SUdOaGNtUkRiRzl6WlY5aWIyOXNYMlpoYkhObFFEUUtDbU5oY21SRGJHOXpaVjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwallYSmtRMnh2YzJWZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTURVS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtbHpVR0Z5ZEc1bGNpZ3BJSHg4SUhSb2FYTXVhWE5EWVhKa1QzZHVaWElvWTJGeVpDa3NJQ2RUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFuS1FvZ0lDQWdZWE56WlhKMElDOHZJRk5GVGtSRlVsOU9UMVJmUVV4TVQxZEZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTURrdE5ERTJDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JqYkc5elpWSmxiV0ZwYm1SbGNsUnZPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4TWdvZ0lDQWdMeThnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRFMENpQWdJQ0F2THlCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiRzl6WlZKbGJXRnBibVJsY2xSdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXhNd29nSUNBZ0x5OGdZVzF2ZFc1ME9pQXdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd09TMDBNVFVLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNRGt0TkRFMkNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWEk2SUdOaGNtUXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ0lDQmpiRzl6WlZKbGJXRnBibVJsY2xSdk9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORFlLSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCRFlYSmtSR0YwWVQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqWmljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTm1JZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReE9Rb2dJQ0FnTHk4Z2RHaHBjeTVqWVhKa2N5aGpZWEprS1M1a1pXeGxkR1VvS1FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlNZ29nSUNBZ0x5OGdkR2hwY3k1allYSmtjMTloWTNScGRtVmZZMjkxYm5RdWRtRnNkV1VnUFNCMGFHbHpMbU5oY21SelgyRmpkR2wyWlY5amIzVnVkQzUyWVd4MVpTQXRJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwT0FvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SelgyRmpkR2wyWlY5amIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkalptRmpKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWTJaaFl5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREl5Q2lBZ0lDQXZMeUIwYUdsekxtTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDNTJZV3gxWlNBOUlIUm9hWE11WTJGeVpITmZZV04wYVhabFgyTnZkVzUwTG5aaGJIVmxJQzBnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBPQW9nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RqWm1Gakp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZMlpoWXlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESXlDaUFnSUNBdkx5QjBhR2x6TG1OaGNtUnpYMkZqZEdsMlpWOWpiM1Z1ZEM1MllXeDFaU0E5SUhSb2FYTXVZMkZ5WkhOZllXTjBhWFpsWDJOdmRXNTBMblpoYkhWbElDMGdNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBMENpQWdJQ0F2THlCd2RXSnNhV01nWTJGeVpFTnNiM05sS0dOaGNtUTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU5oY21SRGJHOXpaVjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJqWVhKa1EyeHZjMlZmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTVqWVhKa1VtVmpiM1psY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTmhjbVJTWldOdmRtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXpJS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa1VtVmpiM1psY2loallYSmtPaUJCWTJOdmRXNTBMQ0J1WlhkRFlYSmtTRzlzWkdWeU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME16TUtJQ0FnSUM4dklIUm9hWE11YjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTmdvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lFTmhjbVJFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJObUp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMllpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXpVS0lDQWdJQzh2SUhSb2FYTXVZMkZ5WkhNb1kyRnlaQ2t1ZG1Gc2RXVXViM2R1WlhJZ1BTQnVaWGREWVhKa1NHOXNaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXpJS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa1VtVmpiM1psY2loallYSmtPaUJCWTJOdmRXNTBMQ0J1WlhkRFlYSmtTRzlzWkdWeU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTVqWVhKa1JHVmlhWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwallYSmtSR1ZpYVhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTFNQW9nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJFWldKcGRDaGpZWEprVDNkdVpYSTZJRUZqWTI5MWJuUXNJR05oY21RNklFRmpZMjkxYm5Rc0lHRnpjMlYwT2lCQmMzTmxkQ3dnWVcxdmRXNTBPaUIxYVc1ME5qUXNJRzV2Ym1ObE9pQjFhVzUwTmpRc0lISmxaam9nYzNSeWFXNW5LVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxuQmhkWE5sWkM1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZFhObFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdKdmIyeGxZVzQrS0NrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5CaGRYTmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVjR0YxYzJWa0xuWmhiSFZsS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTlRJS0lDQWdJQzh2SUhSb2FYTXViMjVzZVU5M2JtVnlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2IyNXNlVTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOZ29nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVOaGNtUkVZWFJoUGloN0lHdGxlVkJ5WldacGVEb2dKMk5tSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyWWlDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMU5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZMkZ5WkhNb1kyRnlaQ2t1ZG1Gc2RXVXViM2R1WlhJZ1BUMDlJR05oY21SUGQyNWxjaXdnSjA5WFRrVlNYMGxPVmtGTVNVUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBWMDVGVWw5SlRsWkJURWxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMU9Bb2dJQ0FnTHk4Z1kyOXVjM1FnYm1WNGRFNXZibU5sT2lCMWFXNTBOalFnUFNCMGFHbHpMbU5oY21SektHTmhjbVFwTG5aaGJIVmxMbTV2Ym1ObENpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENodVpYaDBUbTl1WTJVZ1BUMDlJRzV2Ym1ObExDQW5UazlPUTBWZlNVNVdRVXhKUkNjcENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTVQVGtORlgwbE9Wa0ZNU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWXhMVFEyT1FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeU9pQmpZWEprTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUhSb2FYTXViMjF1YVdKMWMxOWhaR1J5WlhOekxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCdWIzUmxPaUJ5WldZc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOalFLSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklIUm9hWE11YjIxdWFXSjFjMTloWkdSeVpYTnpMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTBDaUFnSUNBdkx5QndkV0pzYVdNZ2IyMXVhV0oxYzE5aFpHUnlaWE56SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklDZHZZU2NnZlNrS0lDQWdJR0o1ZEdWaklEY2dMeThnSW05aElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOalFLSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklIUm9hWE11YjIxdWFXSjFjMTloWkdSeVpYTnpMblpoYkhWbExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUU1dmRHVUtJQ0FnSUdScFp5QTFDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCa2FXY2dOZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1pHbG5JRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJNUzAwTmpnS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCMGFHbHpMbTl0Ym1saWRYTmZZV1JrY21WemN5NTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVG9nY21WbUxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZeExUUTJPUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJSFJvYVhNdWIyMXVhV0oxYzE5aFpHUnlaWE56TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbE9pQnlaV1lzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EY3hMVFEzTndvZ0lDQWdMeThnWlcxcGREeEVaV0pwZEQ0b2V3b2dJQ0FnTHk4Z0lDQmpZWEprT2lCallYSmtMQW9nSUNBZ0x5OGdJQ0JoYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCdWIyNWpaVG9nYm05dVkyVXNDaUFnSUNBdkx5QWdJSEpsWm1WeVpXNWpaVG9nY21WbUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUROaENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPVGswWVRFek5qY2dMeThnYldWMGFHOWtJQ0pFWldKcGRDaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0RBS0lDQWdJQzh2SUhSb2FYTXVZMkZ5WkhNb1kyRnlaQ2t1ZG1Gc2RXVXVibTl1WTJVZ1BTQnVaWGgwVG05dVkyVWdLeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFV3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZMkZ5WkVSbFltbDBLR05oY21SUGQyNWxjam9nUVdOamIzVnVkQ3dnWTJGeVpEb2dRV05qYjNWdWRDd2dZWE56WlhRNklFRnpjMlYwTENCaGJXOTFiblE2SUhWcGJuUTJOQ3dnYm05dVkyVTZJSFZwYm5RMk5Dd2djbVZtT2lCemRISnBibWNwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtZGxkRTVsZUhSRFlYSmtUbTl1WTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJPWlhoMFEyRnlaRTV2Ym1ObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPRGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME5nb2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRU5oY21SRVlYUmhQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTm1KeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTJZaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGt4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1allYSmtjeWhqWVhKa0tTNTJZV3gxWlM1dWIyNWpaUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHVjRkSEpoWTNRZ05qUWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0RrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1WjJWMFEyRnlaRVJoZEdGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJEWVhKa1JHRjBZVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORFlLSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCRFlYSmtSR0YwWVQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqWmljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTm1JZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVd01nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZMkZ5WkhNb1kyRnlaQ2t1ZG1Gc2RXVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTV6WlhSUVlYSjBibVZ5UVdSa2NtVnpjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGQmhjblJ1WlhKQlpHUnlaWE56T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1URUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlFZWEowYm1WeVFXUmtjbVZ6Y3lodVpYZFFZWEowYm1WeVFXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeE1nb2dJQ0FnTHk4Z2RHaHBjeTV2Ym14NVQzZHVaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQnZibXg1VDNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0Z5ZEc1bGNsOWhaR1J5WlhOeklEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCclpYazZJQ2R3WVNjZ2ZTa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSndZU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFMENpQWdJQ0F2THlCMGFHbHpMbkJoY25SdVpYSmZZV1JrY21WemN5NTJZV3gxWlNBOUlHNWxkMUJoY25SdVpYSkJaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNVEVLSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJRWVhKMGJtVnlRV1JrY21WemN5aHVaWGRRWVhKMGJtVnlRV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1YzJWMFQyMXVhV0oxYzBGa1pISmxjM05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUlBiVzVwWW5WelFXUmtjbVZ6Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USXpDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBUMjF1YVdKMWMwRmtaSEpsYzNNb2JtVjNUMjF1YVdKMWMwRmtaSEpsYzNNNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1qUUtJQ0FnSUM4dklIUm9hWE11YjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTkFvZ0lDQWdMeThnY0hWaWJHbGpJRzl0Ym1saWRYTmZZV1JrY21WemN5QTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2EyVjVPaUFuYjJFbklIMHBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSnZZU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRJMkNpQWdJQ0F2THlCMGFHbHpMbTl0Ym1saWRYTmZZV1JrY21WemN5NTJZV3gxWlNBOUlHNWxkMDl0Ym1saWRYTkJaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNak1LSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJQYlc1cFluVnpRV1JrY21WemN5aHVaWGRQYlc1cFluVnpRV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1WTJGeVpFUnBjMkZpYkdWQmMzTmxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OaGNtUkVhWE5oWW14bFFYTnpaWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVek53b2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUkVhWE5oWW14bFFYTnpaWFFvWTJGeVpEb2dRV05qYjNWdWRDd2dZWE56WlhRNklFRnpjMlYwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTTRDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVwYzFCaGNuUnVaWElvS1NCOGZDQjBhR2x6TG1selEyRnlaRTkzYm1WeUtHTmhjbVFwTENBblUwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUp5a0tJQ0FnSUdOaGJHeHpkV0lnYVhOUVlYSjBibVZ5Q2lBZ0lDQmlibm9nWTJGeVpFUnBjMkZpYkdWQmMzTmxkRjlpYjI5c1gzUnlkV1ZBTXdvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdhWE5EWVhKa1QzZHVaWElLSUNBZ0lHSjZJR05oY21SRWFYTmhZbXhsUVhOelpYUmZZbTl2YkY5bVlXeHpaVUEwQ2dwallYSmtSR2x6WVdKc1pVRnpjMlYwWDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtTmhjbVJFYVhOaFlteGxRWE56WlhSZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTXpnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtbHpVR0Z5ZEc1bGNpZ3BJSHg4SUhSb2FYTXVhWE5EWVhKa1QzZHVaWElvWTJGeVpDa3NJQ2RUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFuS1FvZ0lDQWdZWE56WlhKMElDOHZJRk5GVGtSRlVsOU9UMVJmUVV4TVQxZEZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpVdE1qTXpDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWEk2SUdOaGNtUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVOc2IzTmxWRzg2SUdOaGNtUXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek1Rb2dJQ0FnTHk4Z1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRMnh2YzJWVWJ3b2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJMUxUSXpNZ29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJR05oY21Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSRGJHOXpaVlJ2T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNalV0TWpNekNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTZJR05oY21Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1kyRnlaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRU5zYjNObFZHODZJR05oY21Rc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXpVdE1qTTRDaUFnSUNBdkx5QmxiV2wwUEVOaGNtUkJjM05sZEVScGMyRmliR1ZrUGloN0NpQWdJQ0F2THlBZ0lHTmhjbVE2SUdOaGNtUXNDaUFnSUNBdkx5QWdJR0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUgwcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3daRGMzWmpNeElDOHZJRzFsZEdodlpDQWlRMkZ5WkVGemMyVjBSR2x6WVdKc1pXUW9ZV1JrY21WemN5eDFhVzUwTmpRcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE0zQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZMkZ5WkVScGMyRmliR1ZCYzNObGRDaGpZWEprT2lCQlkyTnZkVzUwTENCaGMzTmxkRG9nUVhOelpYUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU5oY21SRWFYTmhZbXhsUVhOelpYUmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdZMkZ5WkVScGMyRmliR1ZCYzNObGRGOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxuZHBkR2hrY21GM1lXeFNaWEYxWlhOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkMmwwYUdSeVlYZGhiRkpsY1hWbGMzUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUwT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkT2IwOXdKMTBnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RJS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtbHpRMkZ5WkU5M2JtVnlLR05oY21RcExDQW5VMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVKeWtLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlHbHpRMkZ5WkU5M2JtVnlDaUFnSUNCaGMzTmxjblFnTHk4Z1UwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOZ29nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVOaGNtUkVZWFJoUGloN0lHdGxlVkJ5WldacGVEb2dKMk5tSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyWWlDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMU1nb2dJQ0FnTHk4Z1kyOXVjM1FnWTJGeVpFUmhkR0VnUFNCamJHOXVaU2gwYUdsekxtTmhjbVJ6S0dOaGNtUXBMblpoYkhWbEtRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFV6Q2lBZ0lDQXZMeUJqYjI1emRDQmJZbUZzWVc1alpWMGdQU0J2Y0M1QmMzTmxkRWh2YkdScGJtY3VZWE56WlhSQ1lXeGhibU5sS0dOaGNtUXNJR0Z6YzJWMEtRb2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXpDaUFnSUNCaGMzTmxkRjlvYjJ4a2FXNW5YMmRsZENCQmMzTmxkRUpoYkdGdVkyVUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhiVzkxYm5RZ1BEMGdZbUZzWVc1alpTd2dKMGxPVTFWR1JrbERTVVZPVkY5Q1FVeEJUa05GSnlrS0lDQWdJR1JwWnlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWxPVTFWR1JrbERTVVZPVkY5Q1FVeEJUa05GQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMU9Bb2dJQ0FnTHk4Z2NtVmphWEJwWlc1ME9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOakVLSUNBZ0lDOHZJR055WldGMFpXUkJkRG9nUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDd0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFl5Q2lBZ0lDQXZMeUJ1YjI1alpUb2dZMkZ5WkVSaGRHRXVkMmwwYUdSeVlYZGhiRTV2Ym1ObExBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMElEY3lJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRVMkxUVTJNd29nSUNBZ0x5OGdZMjl1YzNRZ2QybDBhR1J5WVhkaGJEb2dWMmwwYUdSeVlYZGhiRkpsY1hWbGMzUWdQU0I3Q2lBZ0lDQXZMeUFnSUdOaGNtUTZJR05oY21Rc0NpQWdJQ0F2THlBZ0lISmxZMmx3YVdWdWREb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUTZJR0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1kzSmxZWFJsWkVGME9pQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3TEFvZ0lDQWdMeThnSUNCdWIyNWpaVG9nWTJGeVpFUmhkR0V1ZDJsMGFHUnlZWGRoYkU1dmJtTmxMQW9nSUNBZ0x5OGdmUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxT0FvZ0lDQWdMeThnY0hWaWJHbGpJSGRwZEdoa2NtRjNZV3h6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUZkcGRHaGtjbUYzWVd4U1pYRjFaWE4wUGloN0lHdGxlVkJ5WldacGVEb2dKM2R5SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWQzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyTlFvZ0lDQWdMeThnZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUdOc2IyNWxLSGRwZEdoa2NtRjNZV3dwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxT0FvZ0lDQWdMeThnY0hWaWJHbGpJSGRwZEdoa2NtRjNZV3h6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUZkcGRHaGtjbUYzWVd4U1pYRjFaWE4wUGloN0lHdGxlVkJ5WldacGVEb2dKM2R5SnlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyTlFvZ0lDQWdMeThnZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUdOc2IyNWxLSGRwZEdoa2NtRjNZV3dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOamNLSUNBZ0lDOHZJR1Z0YVhROFYybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIZHBkR2hrY21GM1lXd3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtPRFZtTmpJd1lTQXZMeUJ0WlhSb2IyUWdJbGRwZEdoa2NtRjNZV3hTWlhGMVpYTjBLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVME9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZE9iMDl3SjEwZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5ZV2x1TG5kcGRHaGtjbUYzWVd4RFlXNWpaV3hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwM2FYUm9aSEpoZDJGc1EyRnVZMlZzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU56WUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDJGc1EyRnVZMlZzS0dOaGNtUTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRElLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selEyRnlaRTkzYm1WeUtHTmhjbVFwTENBblUwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUp5a0tJQ0FnSUdOaGJHeHpkV0lnYVhORFlYSmtUM2R1WlhJS0lDQWdJR0Z6YzJWeWRDQXZMeUJUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVNENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjNENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1bGVHbHpkSE1zSUNkWFNWUklSRkpCVjBGTVgxSkZVVlZGVTFSZlRrOVVYMFpQVlU1RUp5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTRDaUFnSUNBdkx5QndkV0pzYVdNZ2QybDBhR1J5WVhkaGJITWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dWMmwwYUdSeVlYZGhiRkpsY1hWbGMzUStLSHNnYTJWNVVISmxabWw0T2lBbmQzSW5JSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UYzRDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTUzYVhSb1pISmhkMkZzY3loVWVHNHVjMlZ1WkdWeUtTNWxlR2x6ZEhNc0lDZFhTVlJJUkZKQlYwRk1YMUpGVVZWRlUxUmZUazlVWDBaUFZVNUVKeWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZkSlZFaEVVa0ZYUVV4ZlVrVlJWVVZUVkY5T1QxUmZSazlWVGtRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTRDaUFnSUNBdkx5QndkV0pzYVdNZ2QybDBhR1J5WVhkaGJITWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dWMmwwYUdSeVlYZGhiRkpsY1hWbGMzUStLSHNnYTJWNVVISmxabWw0T2lBbmQzSW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ozY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UYzVDaUFnSUNBdkx5QmpiMjV6ZENCM2FYUm9aSEpoZDJGc0lEMGdZMnh2Ym1Vb2RHaHBjeTUzYVhSb1pISmhkMkZzY3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVNENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjNUNpQWdJQ0F2THlCamIyNXpkQ0IzYVhSb1pISmhkMkZzSUQwZ1kyeHZibVVvZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhkcGRHaGtjbUYzWVd4eklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lGZHBkR2hrY21GM1lXeFNaWEYxWlhOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNkeUp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkM0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNE1Bb2dJQ0FnTHk4Z2RHaHBjeTUzYVhSb1pISmhkMkZzY3loVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UZ0tJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDJGc2N5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQlhhWFJvWkhKaGQyRnNVbVZ4ZFdWemRENG9leUJyWlhsUWNtVm1hWGc2SUNkM2NpY2dmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9EQUtJQ0FnSUM4dklIUm9hWE11ZDJsMGFHUnlZWGRoYkhNb1ZIaHVMbk5sYm1SbGNpa3VaR1ZzWlhSbEtDa0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT0RFS0lDQWdJQzh2SUdWdGFYUThWMmwwYUdSeVlYZGhiRkpsY1hWbGMzUkRZVzVqWld4c1pXUStLSGRwZEdoa2NtRjNZV3dwQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRGdLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElEY3lJRGdLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElEZ3dJRGdLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWlhoMGNtRmpkQ0E0T0NBNENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURObVpEYzRNamsxSUM4dklHMWxkR2h2WkNBaVYybDBhR1J5WVhkaGJGSmxjWFZsYzNSRFlXNWpaV3hzWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOellLSUNBZ0lDOHZJSEIxWW14cFl5QjNhWFJvWkhKaGQyRnNRMkZ1WTJWc0tHTmhjbVE2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxuZHBkR2hrY21GM1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkMmwwYUdSeVlYYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU0T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkT2IwOXdKMTBnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRElLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selEyRnlaRTkzYm1WeUtHTmhjbVFwTENBblUwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUp5a0tJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUdselEyRnlaRTkzYm1WeUNpQWdJQ0JoYzNObGNuUWdMeThnVTBWT1JFVlNYMDVQVkY5QlRFeFBWMFZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhkcGRHaGtjbUYzWVd4eklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lGZHBkR2hrY21GM1lXeFNaWEYxWlhOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNkeUp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkM0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkMmwwYUdSeVlYZGhiSE1vVkhodUxuTmxibVJsY2lrdVpYaHBjM1J6TENBblYwbFVTRVJTUVZkQlRGOVNSVkZWUlZOVVgwNVBWRjlHVDFWT1JDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFPQW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1lXeHpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRmRwZEdoa2NtRjNZV3hTWlhGMVpYTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZHlKeUI5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTVNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11ZDJsMGFHUnlZWGRoYkhNb1ZIaHVMbk5sYm1SbGNpa3VaWGhwYzNSekxDQW5WMGxVU0VSU1FWZEJURjlTUlZGVlJWTlVYMDVQVkY5R1QxVk9SQ2NwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCWFNWUklSRkpCVjBGTVgxSkZVVlZGVTFSZlRrOVVYMFpQVlU1RUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOZ29nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVOaGNtUkVZWFJoUGloN0lHdGxlVkJ5WldacGVEb2dKMk5tSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyWWlDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNU1nb2dJQ0FnTHk4Z1kyOXVjM1FnWTJGeVpFUmhkR0VnUFNCamJHOXVaU2gwYUdsekxtTmhjbVJ6S0dOaGNtUXBMblpoYkhWbEtRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFU0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZGhiSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVjJsMGFHUnlZWGRoYkZKbGNYVmxjM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQW5kM0luSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKM2NpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGt6Q2lBZ0lDQXZMeUJqYjI1emRDQjNhWFJvWkhKaGQyRnNJRDBnWTJ4dmJtVW9kR2hwY3k1M2FYUm9aSEpoZDJGc2N5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTRDaUFnSUNBdkx5QndkV0pzYVdNZ2QybDBhR1J5WVhkaGJITWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dWMmwwYUdSeVlYZGhiRkpsY1hWbGMzUStLSHNnYTJWNVVISmxabWw0T2lBbmQzSW5JSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ua3pDaUFnSUNBdkx5QmpiMjV6ZENCM2FYUm9aSEpoZDJGc0lEMGdZMnh2Ym1Vb2RHaHBjeTUzYVhSb1pISmhkMkZzY3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTVOQW9nSUNBZ0x5OGdZWE56WlhKMEtHRnRiM1Z1ZENBOFBTQjNhWFJvWkhKaGQyRnNMbUZ0YjNWdWRDd2dKMEZOVDFWT1ZGOUpUbFpCVEVsRUp5a0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EzTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBekNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRUZOVDFWT1ZGOUpUbFpCVEVsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTVOUW9nSUNBZ0x5OGdZWE56WlhKMEtHTmhjbVJFWVhSaExuZHBkR2hrY21GM1lXeE9iMjVqWlNBOVBUMGdkMmwwYUdSeVlYZGhiQzV1YjI1alpTd2dKMDVQVGtORlgwbE9Wa0ZNU1VRbktRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0EzTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGc0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUazlPUTBWZlNVNVdRVXhKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9UY0tJQ0FnSUM4dklHTnZibk4wSUhKbGJHVmhjMlZVYVcxbE9pQjFhVzUwTmpRZ1BTQjNhWFJvWkhKaGQyRnNMbU55WldGMFpXUkJkQ0FySUhSb2FYTXVkMmwwYUdSeVlYZGhiRjkzWVdsMFgzUnBiV1V1ZG1Gc2RXVUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURnd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXhDaUFnSUNBdkx5QndkV0pzYVdNZ2QybDBhR1J5WVhkaGJGOTNZV2wwWDNScGJXVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuZDNkMEp5QjlLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkM2QwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9UY0tJQ0FnSUM4dklHTnZibk4wSUhKbGJHVmhjMlZVYVcxbE9pQjFhVzUwTmpRZ1BTQjNhWFJvWkhKaGQyRnNMbU55WldGMFpXUkJkQ0FySUhSb2FYTXVkMmwwYUdSeVlYZGhiRjkzWVdsMFgzUnBiV1V1ZG1Gc2RXVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdJRDQ5SUhKbGJHVmhjMlZVYVcxbExDQW5WMGxVU0VSU1FWZEJURjlVU1UxRlgwbE9Wa0ZNU1VRbktRb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJYU1ZSSVJGSkJWMEZNWDFSSlRVVmZTVTVXUVV4SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNRE1LSUNBZ0lDOHZJSGRwZEdoa2NtRjNZV3d1WVhOelpYUXNDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZd01TMDJNRGdLSUNBZ0lDOHZJSFJvYVhNdWQybDBhR1J5WVhkR2RXNWtjeWdLSUNBZ0lDOHZJQ0FnWTJGeVpDd0tJQ0FnSUM4dklDQWdkMmwwYUdSeVlYZGhiQzVoYzNObGRDd0tJQ0FnSUM4dklDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQjNhWFJvWkhKaGQyRnNMbU55WldGMFpXUkJkQ3dLSUNBZ0lDOHZJQ0FnZDJsMGFHUnlZWGRoYkM1dWIyNWpaU3dLSUNBZ0lDOHZJQ0FnVjJsMGFHUnlZWGRoYkZSNWNHVlFaWEp0YVhOemFXOXVUR1Z6Y3l3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNRGNLSUNBZ0lDOHZJRmRwZEdoa2NtRjNZV3hVZVhCbFVHVnliV2x6YzJsdmJreGxjM01zQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpY0dWeWJXbHpjMmx2Ym14bGMzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3TVMwMk1EZ0tJQ0FnSUM4dklIUm9hWE11ZDJsMGFHUnlZWGRHZFc1a2N5Z0tJQ0FnSUM4dklDQWdZMkZ5WkN3S0lDQWdJQzh2SUNBZ2QybDBhR1J5WVhkaGJDNWhjM05sZEN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCM2FYUm9aSEpoZDJGc0xtTnlaV0YwWldSQmRDd0tJQ0FnSUM4dklDQWdkMmwwYUdSeVlYZGhiQzV1YjI1alpTd0tJQ0FnSUM4dklDQWdWMmwwYUdSeVlYZGhiRlI1Y0dWUVpYSnRhWE56YVc5dVRHVnpjeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2QybDBhR1J5WVhkR2RXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRnS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCWGFYUm9aSEpoZDJGc1VtVnhkV1Z6ZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2QzY2ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luZHlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTURrS0lDQWdJQzh2SUhSb2FYTXVkMmwwYUdSeVlYZGhiSE1vVkhodUxuTmxibVJsY2lrdVpHVnNaWFJsS0NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVNENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpBNUNpQWdJQ0F2THlCMGFHbHpMbmRwZEdoa2NtRjNZV3h6S0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGc0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUJiSjA1dlQzQW5YU0I5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxaGFXNHVkMmwwYUdSeVlYZFFaWEp0YVhOemFXOXVaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwM2FYUm9aSEpoZDFCbGNtMXBjM05wYjI1bFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakl3TFRZeU53b2dJQ0FnTHk4Z2NIVmliR2xqSUhkcGRHaGtjbUYzVUdWeWJXbHpjMmx2Ym1Wa0tBb2dJQ0FnTHk4Z0lDQmpZWEprT2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRG9nUVhOelpYUXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmxlSEJwY21WelFYUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdibTl1WTJVNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2MybG5ibUYwZFhKbE9pQmllWFJsY3p3Mk5ENHNDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEWUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTmpRK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRNZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YVhORFlYSmtUM2R1WlhJb1kyRnlaQ2tzSUNkVFJVNUVSVkpmVGs5VVgwRk1URTlYUlVRbktRb2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnYVhORFlYSmtUM2R1WlhJS0lDQWdJR0Z6YzJWeWRDQXZMeUJUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRMkNpQWdJQ0F2THlCd2RXSnNhV01nWTJGeVpITWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dRMkZ5WkVSaGRHRStLSHNnYTJWNVVISmxabWw0T2lBblkyWW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqWmlJS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakk1Q2lBZ0lDQXZMeUJqYjI1emRDQmpZWEprUkdGMFlTQTlJR05zYjI1bEtIUm9hWE11WTJGeVpITW9ZMkZ5WkNrdWRtRnNkV1VwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk16RUtJQ0FnSUM4dklHRnpjMlZ5ZENoSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdJRHdnWlhod2FYSmxjMEYwTENBblYwbFVTRVJTUVZkQlRGOVVTVTFGWDBsT1ZrRk1TVVFuS1FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaR2xuSURNS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QlhTVlJJUkZKQlYwRk1YMVJKVFVWZlNVNVdRVXhKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk16SUtJQ0FnSUM4dklHRnpjMlZ5ZENoallYSmtSR0YwWVM1M2FYUm9aSEpoZDJGc1RtOXVZMlVnUFQwOUlHNXZibU5sTENBblRrOU9RMFZmU1U1V1FVeEpSQ2NwQ2lBZ0lDQndkWE5vYVc1MElEY3lDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9UMDVEUlY5SlRsWkJURWxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZek5nb2dJQ0FnTHk4Z2NtVmphWEJwWlc1ME9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOREVLSUNBZ0lDOHZJR2RsYm1WemFYTklZWE5vT2lCSGJHOWlZV3d1WjJWdVpYTnBjMGhoYzJnc0NpQWdJQ0JuYkc5aVlXd2dSMlZ1WlhOcGMwaGhjMmdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpNMExUWTBNZ29nSUNBZ0x5OGdZMjl1YzNRZ2QybDBhR1J5WVhkaGJEb2dVR1Z5YldsemMybHZibVZrVjJsMGFHUnlZWGRoYkNBOUlIc0tJQ0FnSUM4dklDQWdZMkZ5WkN3S0lDQWdJQzh2SUNBZ2NtVmphWEJwWlc1ME9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JoYzNObGRDd0tJQ0FnSUM4dklDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQmxlSEJwY21WelFYUXNDaUFnSUNBdkx5QWdJRzV2Ym1ObExBb2dJQ0FnTHk4Z0lDQm5aVzVsYzJselNHRnphRG9nUjJ4dlltRnNMbWRsYm1WemFYTklZWE5vTEFvZ0lDQWdMeThnZlFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkRRS0lDQWdJQzh2SUdOdmJuTjBJSGRwZEdoa2NtRjNZV3hmYUdGemFDQTlJRzl3TG5Ob1lUSTFOaWhoY21NMExtVnVZMjlrWlVGeVl6UW9kMmwwYUdSeVlYZGhiQ2twQ2lBZ0lDQnphR0V5TlRZS0NuZHBkR2hrY21GM1VHVnliV2x6YzJsdmJtVmtYM2RvYVd4bFgzUnZjRUExT2dvZ0lDQWdjSFZ6YUdsdWRDQXlOVEV3Q2lBZ0lDQm5iRzlpWVd3Z1QzQmpiMlJsUW5Wa1oyVjBDaUFnSUNBK0NpQWdJQ0JpZWlCM2FYUm9aSEpoZDFCbGNtMXBjM05wYjI1bFpGOWhablJsY2w5M2FHbHNaVUF4TUFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUJFWld4bGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURZNE1UQXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjSEp2ZG1Gc1VISnZaM0poYlFvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhnd05qZ3hNREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR0lnZDJsMGFHUnlZWGRRWlhKdGFYTnphVzl1WldSZmQyaHBiR1ZmZEc5d1FEVUtDbmRwZEdoa2NtRjNVR1Z5YldsemMybHZibVZrWDJGbWRHVnlYM2RvYVd4bFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkRrS0lDQWdJQzh2SUdGemMyVnlkQ2h2Y0M1bFpESTFOVEU1ZG1WeWFXWjVRbUZ5WlNoM2FYUm9aSEpoZDJGc1gyaGhjMmdzSUhOcFoyNWhkSFZ5WlN3Z2RHaHBjeTUzYVhSb1pISmhkMkZzWDNCMVltdGxlUzUyWVd4MVpTa3NJQ2RUU1VkT1FWUlZVa1ZmU1U1V1FVeEpSQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRRS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzWDNCMVltdGxlU0E5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UERNeVBqNG9leUJyWlhrNklDZHdkM0JySnlCOUtRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWNIZHdheUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpRNUNpQWdJQ0F2THlCaGMzTmxjblFvYjNBdVpXUXlOVFV4T1habGNtbG1lVUpoY21Vb2QybDBhR1J5WVhkaGJGOW9ZWE5vTENCemFXZHVZWFIxY21Vc0lIUm9hWE11ZDJsMGFHUnlZWGRoYkY5d2RXSnJaWGt1ZG1Gc2RXVXBMQ0FuVTBsSFRrRlVWVkpGWDBsT1ZrRk1TVVFuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1ZrTWpVMU1UbDJaWEpwWm5sZlltRnlaUW9nSUNBZ1lYTnpaWEowSUM4dklGTkpSMDVCVkZWU1JWOUpUbFpCVEVsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFNZ29nSUNBZ0x5OGdkR2hwY3k1M2FYUm9aSEpoZDBaMWJtUnpLR05oY21Rc0lHRnpjMlYwTENCaGJXOTFiblFzSUdWNGNHbHlaWE5CZEN3Z1kyRnlaRVJoZEdFdWQybDBhR1J5WVhkaGJFNXZibU5sTENCWGFYUm9aSEpoZDJGc1ZIbHdaVUZ3Y0hKdmRtVmtLUW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbUZ3Y0hKdmRtVmtJZ29nSUNBZ1kyRnNiSE4xWWlCM2FYUm9aSEpoZDBaMWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxT0FvZ0lDQWdMeThnY0hWaWJHbGpJSGRwZEdoa2NtRjNZV3h6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUZkcGRHaGtjbUYzWVd4U1pYRjFaWE4wUGloN0lHdGxlVkJ5WldacGVEb2dKM2R5SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWQzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkxTndvZ0lDQWdMeThnYVdZZ0tIUm9hWE11ZDJsMGFHUnlZWGRoYkhNb1ZIaHVMbk5sYm1SbGNpa3VaWGhwYzNSektTQjdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFPQW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1lXeHpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRmRwZEdoa2NtRjNZV3hTWlhGMVpYTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZHlKeUI5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFOd29nSUNBZ0x5OGdhV1lnS0hSb2FYTXVkMmwwYUdSeVlYZGhiSE1vVkhodUxuTmxibVJsY2lrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJSGRwZEdoa2NtRjNVR1Z5YldsemMybHZibVZrWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRnS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCWGFYUm9aSEpoZDJGc1VtVnhkV1Z6ZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2QzY2ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luZHlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlRnS0lDQWdJQzh2SUhSb2FYTXVkMmwwYUdSeVlYZGhiSE1vVkhodUxuTmxibVJsY2lrdVpHVnNaWFJsS0NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVNENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVNENpQWdJQ0F2THlCMGFHbHpMbmRwZEdoa2NtRjNZV3h6S0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtDbmRwZEdoa2NtRjNVR1Z5YldsemMybHZibVZrWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpJd0xUWXlOd29nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1VHVnliV2x6YzJsdmJtVmtLQW9nSUNBZ0x5OGdJQ0JqWVhKa09pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmhjM05sZERvZ1FYTnpaWFFzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JsZUhCcGNtVnpRWFE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYm05dVkyVTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdjMmxuYm1GMGRYSmxPaUJpZVhSbGN6dzJORDRzQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPanBQZDI1aFlteGxMbTkzYm1WeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiM2R1WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVmYjNkdVpYSXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCd2RXSnNhV01nWDI5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVgyOTNibVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVYMjkzYm1WeUxuWmhiSFZsQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvNlQzZHVZV0pzWlM1MGNtRnVjMlpsY2s5M2JtVnljMmhwY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdjSFZpYkdsaklIUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd0tHNWxkMDkzYm1WeU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk9USUtJQ0FnSUM4dklIUm9hWE11YjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUIwYUdsekxsOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNDaHVaWGRQZDI1bGNpa0tJQ0FnSUdOaGJHeHpkV0lnWDNSeVlXNXpabVZ5VDNkdVpYSnphR2x3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2preENpQWdJQ0F2THlCd2RXSnNhV01nZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFvYm1WM1QzZHVaWEk2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem82VUdGMWMyRmliR1V1Y0dGMWMyVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0dGMWMyVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxsOXdZWFZ6WlhJdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY0hWaWJHbGpJRjl3WVhWelpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKZmNHRjFjMlZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbDl3WVhWelpYSXVkbUZzZFdVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhCaGRYTmxjaWdwT2lCQlkyTnZkVzUwSUhzS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvNlVHRjFjMkZpYkdVdWNHRjFjMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd1lYVnpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCMGFHbHpMbTl1YkhsUVlYVnpaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQnZibXg1VUdGMWMyVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZFhObFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdKdmIyeGxZVzQrS0NrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5CaGRYTmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCMGFHbHpMbkJoZFhObFpDNTJZV3gxWlNBOUlIUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUdWdGFYUThVR0YxYzJVK0tIdDlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZMll5TTJFek1HWUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSEIxWW14cFl5QndZWFZ6WlNncE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvNlVHRjFjMkZpYkdVdWRXNXdZWFZ6WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVnVjR0YxYzJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzNOd29nSUNBZ0x5OGdkR2hwY3k1dmJteDVVR0YxYzJWeUtDa0tJQ0FnSUdOaGJHeHpkV0lnYjI1c2VWQmhkWE5sY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklIQjFZbXhwWXlCd1lYVnpaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGliMjlzWldGdVBpZ3BDaUFnSUNCaWVYUmxZeUEySUM4dklDSndZWFZ6WldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzNPUW9nSUNBZ0x5OGdkR2hwY3k1d1lYVnpaV1F1ZG1Gc2RXVWdQU0JtWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdaVzFwZER4VmJuQmhkWE5sUGloN2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHSXhOak5sWlRCaUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qYzJDaUFnSUNBdkx5QndkV0pzYVdNZ2RXNXdZWFZ6WlNncE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvNlVHRjFjMkZpYkdVdWRYQmtZWFJsVUdGMWMyVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxVR0YxYzJWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJSEIxWW14cFl5QjFjR1JoZEdWUVlYVnpaWElvWDI1bGQxQmhkWE5sY2pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z2RHaHBjeTV2Ym14NVVHRjFjMlZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVZCaGRYTmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02T0RrS0lDQWdJQzh2SUdGemMyVnlkQ2hmYm1WM1VHRjFjMlZ5SUNFOVBTQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXBDaUFnSUNCa2RYQUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklIQjFZbXhwWXlCZmNHRjFjMlZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlYM0JoZFhObGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUIwYUdsekxsOXdZWFZ6WlhJdWRtRnNkV1VnUFNCZmJtVjNVR0YxYzJWeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamt4Q2lBZ0lDQXZMeUJsYldsMFBGQmhkWE5sY2tOb1lXNW5aV1ErS0hzZ2JtVjNRV1JrY21WemN6b2dkR2hwY3k1ZmNHRjFjMlZ5TG5aaGJIVmxJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqWXpRd09USXpZeUF2THlCdFpYUm9iMlFnSWxCaGRYTmxja05vWVc1blpXUW9ZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUhCMVlteHBZeUIxY0dSaGRHVlFZWFZ6WlhJb1gyNWxkMUJoZFhObGNqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXlaV052ZG1WeVlXSnNaUzVoYkdkdkxuUnpPanBTWldOdmRtVnlZV0pzWlM1eVpXTnZkbVZ5UVhOelpYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldOdmRtVnlRWE56WlhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjbVZqYjNabGNtRmliR1V1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnY0hWaWJHbGpJSEpsWTI5MlpYSkJjM05sZENoaGMzTmxkRG9nUVhOelpYUXNJR0Z0YjNWdWREb2dkV2x1ZERZMExDQnlaV05wY0dsbGJuUTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y21WamIzWmxjbUZpYkdVdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2RHaHBjeTV2Ym14NVQzZHVaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQnZibXg1VDNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl5WldOdmRtVnlZV0pzWlM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCcFppQW9ZWE56WlhRdWFXUXBJSHNLSUNBZ0lHSjZJSEpsWTI5MlpYSkJjM05sZEY5bGJITmxYMkp2WkhsQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0psWTI5MlpYSmhZbXhsTG1Gc1oyOHVkSE02TkRJdE5EZ0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ2NtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNKbFkyOTJaWEpoWW14bExtRnNaMjh1ZEhNNk5ESXRORGNLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2djbVZqYVhCcFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0psWTI5MlpYSmhZbXhsTG1Gc1oyOHVkSE02TkRJdE5EZ0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ2NtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLQ25KbFkyOTJaWEpCYzNObGRGOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjbVZqYjNabGNtRmliR1V1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnY0hWaWJHbGpJSEpsWTI5MlpYSkJjM05sZENoaGMzTmxkRG9nUVhOelpYUXNJR0Z0YjNWdWREb2dkV2x1ZERZMExDQnlaV05wY0dsbGJuUTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkpsWTI5MlpYSkJjM05sZEY5bGJITmxYMkp2WkhsQU5Eb0tJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNKbFkyOTJaWEpoWW14bExtRnNaMjh1ZEhNNk5UQXROVFVLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJ5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXlaV052ZG1WeVlXSnNaUzVoYkdkdkxuUnpPalV3TFRVMENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ2NtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzSmxZMjkyWlhKaFlteGxMbUZzWjI4dWRITTZOVEF0TlRVS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCeVpXTnBjR2xsYm5Rc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdJZ2NtVmpiM1psY2tGemMyVjBYMkZtZEdWeVgybG1YMlZzYzJWQU5nb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1YVhORFlYSmtUM2R1WlhJb1kyRnlaRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LYVhORFlYSmtUM2R1WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNZ29nSUNBZ0x5OGdjSEpwZG1GMFpTQnBjME5oY21SUGQyNWxjaWhqWVhKa09pQkJZMk52ZFc1MEtUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTJDaUFnSUNBdkx5QndkV0pzYVdNZ1kyRnlaSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnUTJGeVpFUmhkR0UrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZMlluSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKalppSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVkyRnlaSE1vWTJGeVpDa3VaWGhwYzNSekxDQW5RMEZTUkY5T1QxUmZSazlWVGtRbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRRVkpFWDA1UFZGOUdUMVZPUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56UUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbU5oY21SektHTmhjbVFwTG5aaGJIVmxMbTkzYm1WeUlEMDlQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFoYVc0dWFYTlFZWEowYm1WeUtDa2dMVDRnZFdsdWREWTBPZ3BwYzFCaGNuUnVaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdWNHRnlkRzVsY2w5aFpHUnlaWE56TG5aaGJIVmxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qRUtJQ0FnSUM4dklIQjFZbXhwWXlCd1lYSjBibVZ5WDJGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR3RsZVRvZ0ozQmhKeUI5S1FvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5CaElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQlVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbkJoY25SdVpYSmZZV1JrY21WemN5NTJZV3gxWlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtTmhjbVJCYzNObGRFOXdkRWx1S0dOaGNtUTZJR0o1ZEdWekxDQmhjM05sZERvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5ZV2x1TG1OaGNtUkJjM05sZEU5d2RFbHVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURZS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa1FYTnpaWFJQY0hSSmJpaGpZWEprT2lCQlkyTnZkVzUwTENCaGMzTmxkRG9nUVhOelpYUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9UY0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbWx6VUdGeWRHNWxjaWdwTENBblUwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUp5a0tJQ0FnSUdOaGJHeHpkV0lnYVhOUVlYSjBibVZ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3T1MweU1UWUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQmpZWEprTEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVFFLSUNBZ0lDOHZJR0Z6YzJWMFFXMXZkVzUwT2lBd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdPUzB5TVRVS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRGt0TWpFMkNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTZJR05oY21Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1kyRnlaQ3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhPQzB5TWpFS0lDQWdJQzh2SUdWdGFYUThRMkZ5WkVGemMyVjBSVzVoWW14bFpENG9ld29nSUNBZ0x5OGdJQ0JqWVhKa09pQmpZWEprTEFvZ0lDQWdMeThnSUNCaGMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROVGN4T1dObFpERWdMeThnYldWMGFHOWtJQ0pEWVhKa1FYTnpaWFJGYm1GaWJHVmtLR0ZrWkhKbGMzTXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxuZHBkR2hrY21GM1JuVnVaSE1vWTJGeVpEb2dZbmwwWlhNc0lHRnpjMlYwT2lCMWFXNTBOalFzSUdGdGIzVnVkRG9nZFdsdWREWTBMQ0IwYVcxbGMzUmhiWEE2SUhWcGJuUTJOQ3dnYm05dVkyVTZJSFZwYm5RMk5Dd2dkMmwwYUdSeVlYZGhiRlI1Y0dVNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwM2FYUm9aSEpoZDBaMWJtUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRFdE1qUTRDaUFnSUNBdkx5QndjbWwyWVhSbElIZHBkR2hrY21GM1JuVnVaSE1vQ2lBZ0lDQXZMeUFnSUdOaGNtUTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJR0Z6YzJWME9pQkJjM05sZEN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhScGJXVnpkR0Z0Y0RvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCdWIyNWpaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0IzYVhSb1pISmhkMkZzVkhsd1pUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QTJJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVd0NpQWdJQ0F2THlCcFppQW9ZVzF2ZFc1MElENGdNQ2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmllaUIzYVhSb1pISmhkMFoxYm1SelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5URXRNalU0Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5UUUtJQ0FnSUM4dklHRnpjMlYwVW1WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDJDaUFnSUNCcGRIaHVYMlpwWld4a0lGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5URXRNalUzQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVEV0TWpVNENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTZJR05oY21Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtDbmRwZEdoa2NtRjNSblZ1WkhOZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qUUtJQ0FnSUM4dklISmxZMmx3YVdWdWREb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalkzQ2lBZ0lDQXZMeUJqY21WaGRHVmtRWFE2SUhkcGRHaGtjbUYzWVd4VWVYQmxJRDA5UFNCWGFYUm9aSEpoZDJGc1ZIbHdaVkJsY20xcGMzTnBiMjVNWlhOeklEOGdkR2x0WlhOMFlXMXdJRG9nTUN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldNZ01URWdMeThnSW5CbGNtMXBjM05wYjI1c1pYTnpJZ29nSUNBZ1BUMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMk9Bb2dJQ0FnTHk4Z1pYaHdhWEpsYzBGME9pQjNhWFJvWkhKaGQyRnNWSGx3WlNBOVBUMGdWMmwwYUdSeVlYZGhiRlI1Y0dWQmNIQnliM1psWkNBL0lIUnBiV1Z6ZEdGdGNDQTZJREFzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0poY0hCeWIzWmxaQ0lLSUNBZ0lEMDlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qSXRNamN4Q2lBZ0lDQXZMeUJsYldsMFBGZHBkR2hrY21GM1lXdytLSHNLSUNBZ0lDOHZJQ0FnWTJGeVpEb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ2NtVmphWEJwWlc1ME9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JoYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCamNtVmhkR1ZrUVhRNklIZHBkR2hrY21GM1lXeFVlWEJsSUQwOVBTQlhhWFJvWkhKaGQyRnNWSGx3WlZCbGNtMXBjM05wYjI1TVpYTnpJRDhnZEdsdFpYTjBZVzF3SURvZ01Dd0tJQ0FnSUM4dklDQWdaWGh3YVhKbGMwRjBPaUIzYVhSb1pISmhkMkZzVkhsd1pTQTlQVDBnVjJsMGFHUnlZWGRoYkZSNWNHVkJjSEJ5YjNabFpDQS9JSFJwYldWemRHRnRjQ0E2SURBc0NpQWdJQ0F2THlBZ0lHNXZibU5sT2lCdWIyNWpaU3dLSUNBZ0lDOHZJQ0FnZEhsd1pUb2dkMmwwYUdSeVlYZGhiRlI1Y0dVc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMkNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBMllRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0ppTkdSa01EQTJJQzh2SUcxbGRHaHZaQ0FpVjJsMGFHUnlZWGRoYkNoaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3h6ZEhKcGJtY3BJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjekNpQWdJQ0F2THlCMGFHbHpMbU5oY21SektHTmhjbVFwTG5aaGJIVmxMbmRwZEdoa2NtRjNZV3hPYjI1alpTQTlJRzV2Ym1ObElDc2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EWUtJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JEWVhKa1JHRjBZVDRvZXlCclpYbFFjbVZtYVhnNklDZGpaaWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1ObUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamN6Q2lBZ0lDQXZMeUIwYUdsekxtTmhjbVJ6S0dOaGNtUXBMblpoYkhWbExuZHBkR2hrY21GM1lXeE9iMjVqWlNBOUlHNXZibU5sSUNzZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHbHVkQ0EzTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZPazkzYm1GaWJHVXViMjVzZVU5M2JtVnlLQ2tnTFQ0Z2RtOXBaRG9LYjI1c2VVOTNibVZ5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVgyOTNibVZ5TG5aaGJIVmxMQ0FuVTBWT1JFVlNYMDVQVkY5QlRFeFBWMFZFSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdYMjkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWDI5M2JtVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WDI5M2JtVnlMblpoYkhWbExDQW5VMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZORlRrUkZVbDlPVDFSZlFVeE1UMWRGUkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvNlQzZHVZV0pzWlM1ZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBb2JtVjNUM2R1WlhJNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QndjbTkwWldOMFpXUWdYM1J5WVc1elptVnlUM2R1WlhKemFHbHdLRzVsZDA5M2JtVnlPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklHTnZibk4wSUhCeVpYWnBiM1Z6VDNkdVpYSWdQU0IwYUdsekxsOXZkMjVsY2k1b1lYTldZV3gxWlNBL0lIUm9hWE11WDI5M2JtVnlMblpoYkhWbElEb2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdjSFZpYkdsaklGOXZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbDl2ZDI1bGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJR052Ym5OMElIQnlaWFpwYjNWelQzZHVaWElnUFNCMGFHbHpMbDl2ZDI1bGNpNW9ZWE5XWVd4MVpTQS9JSFJvYVhNdVgyOTNibVZ5TG5aaGJIVmxJRG9nUjJ4dlltRnNMbnBsY205QlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmZkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUY5dmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lsOXZkMjVsY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklHTnZibk4wSUhCeVpYWnBiM1Z6VDNkdVpYSWdQU0IwYUdsekxsOXZkMjVsY2k1b1lYTldZV3gxWlNBL0lIUm9hWE11WDI5M2JtVnlMblpoYkhWbElEb2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b0tYM1J5WVc1elptVnlUM2R1WlhKemFHbHdYM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJSEIxWW14cFl5QmZiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pmYjNkdVpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUIwYUdsekxsOXZkMjVsY2k1MllXeDFaU0E5SUc1bGQwOTNibVZ5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pjNExUZ3hDaUFnSUNBdkx5QmxiV2wwUEU5M2JtVnljMmhwY0ZSeVlXNXpabVZ5Y21Wa1BpaDdDaUFnSUNBdkx5QWdJSEJ5WlhacGIzVnpUM2R1WlhJNklIQnlaWFpwYjNWelQzZHVaWElzQ2lBZ0lDQXZMeUFnSUc1bGQwOTNibVZ5T2lCdVpYZFBkMjVsY2l3S0lDQWdJQzh2SUgwcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9XRXlNak5sWm1JZ0x5OGdiV1YwYUc5a0lDSlBkMjVsY25Ob2FYQlVjbUZ1YzJabGNuSmxaQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lISmxkSE4xWWdvS1gzUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd1gzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklHTnZibk4wSUhCeVpYWnBiM1Z6VDNkdVpYSWdQU0IwYUdsekxsOXZkMjVsY2k1b1lYTldZV3gxWlNBL0lIUm9hWE11WDI5M2JtVnlMblpoYkhWbElEb2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0lnWDNSeVlXNXpabVZ5VDNkdVpYSnphR2x3WDNSbGNtNWhjbmxmYldWeVoyVkFNd29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPanBRWVhWellXSnNaUzV2Ym14NVVHRjFjMlZ5S0NrZ0xUNGdkbTlwWkRvS2IyNXNlVkJoZFhObGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVmY0dGMWMyVnlMblpoYkhWbEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCd2RXSnNhV01nWDNCaGRYTmxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lsOXdZWFZ6WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVYM0JoZFhObGNpNTJZV3gxWlNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVnQ0NZT0FtTm1BbmR5QkJVZmZIVUVZMlpoWXdaZmIzZHVaWElIWDNCaGRYTmxjZ1p3WVhWelpXUUNiMkVEZDNkMEJIQjNjR3NDY0dFT2NHVnliV2x6YzJsdmJteGxjM01EQm9FQkNHRndjSEp2ZG1Wa2dnSUVvT2dZY2dTY2hxR0ZOaG9BamdJQXpBREFNUmtVUkRFWVFRQ3BnaGNFb2FyYVF3U2dVUFh4QkwvZmxkd0VXeWR4UXdSSHU1MzlCRCtoSTRzRXJSWW1KQVRMN2l1aEJIUmR2eFlFMmhzbmlRU3NjeDNtQkpVMzFRa0V0elNSV0FTNzBON3dCQlAvSE9rRTh1UHpmd1N4dTdDb0JPRjdyN1FFc05sVHN3UUJlUGxMQkJ0U25lZ0VESzNSWXdSNFdodjVOaG9BamhjQUp3Q1JBS01BdEFHZkFkOEIvQUtzQXNJQzFRTG1BdmNEUXdPbkEvOEViQVVwQlRRRlJBVlBCVjhGYndXUEFJQUVGMGdaUFRZYUFJNEJBQzhBTVJtQkJSSXhHQkJFUWdCVk1SbUJCQkl4R0JCRVFnQkVOaG9CU1JVa0VrUTJHZ0pKRlNVU1JCZUlCYmtqUXpZYUFVa1ZKQkpFTmhvQ1NSVWtFa1JNaUFaWWlBWkxKd2RNWnljRk1RQm5LeUpuSndZaVp5b3lDbEN3STBPSUJqRWpRNGdHTENJclpVUVVSTEV5Q2lJbkJHVkVzZ2tpc2dpeUJ5T3lFQ0t5QWJNalF6WWFBVWtWSlJKRUY0Z0dBaWNJVEdjalF6WWFBVWtWSkJKRWlBWHhKd2xNWnlORE5ob0JSd0lWSkJKRU5ob0NTUlVsRWtRWFNVNENUZ09JQlIxRU1nTlFJaFpNU3dGUVRGQ3hnUVd5R1lBRUM0RUJRN0pDZ0Q4TElBSUFBWUFFVmgwdjZqWWFBSTRCQUFFQU1SbUJCUkl4R0JRUVJFSUFBTEV5Q2pJT3NpQWlzZ2l5QnlPeUVDS3lBYk9BQkJVZmZIVXlDbEN3STBPeVFJQUVWaDB2NnJJYWdRYXlFQ0t5QWJPMFBrbFhCQUJKVGdKT0JGY0FCQ29TUkVrVkpCSkVYQ0JNUVFCRk1oQ3hNZ0VJc2doTEFiSUhJN0lRSXJJQnMwc0RRUUFIU3dGTEJJZ0VmeWhQQWtsT0FsQlBBcjhpSzJWRUl3Z3JUR2RNU3dGUWdBVDFNMEJFVEZDd0treFFzQ05ESWtML3VUWWFBVWtWSkJKRWlBUkJRQUFIU1lnRUpVRUFKeU5Fc1RJS1NiSUpJcklJc2dkSnNnQWpzaEFpc2dHektFeFF2RWdpSzJWRUl3a3JUR2NqUXlKQy85WTJHZ0ZKRlNRU1JEWWFBa2tWSkJKRWlBU3RLRThDVUNKUEFyc2pRellhQVVrVkpCSkVOaG9DU1JVa0VrUTJHZ05KRlNVU1JCYzJHZ1JKRlNVU1JCYzJHZ1ZKRlNVU1JCYzJHZ1pKSWxtQkFnaExBUlVTUkZjQ0FDSW5CbVZFRkVTSUJGMG9Td1ZRU2I1RVNWY0FJRThJRWtTQlFGdEpTd1FTUkxFaUp3ZGxSRXNEc2dWTEJiSVNTd2F5RWJJVVN3YXlBSUVFc2hBaXNnR3pUd1VXVHdaTVVFOEZGbEJQQkJaUVN3TVZGbGNHQWs4RVVFeUFBZ0E2VUV4UWdBU1pTaE5uVEZDd0l3Z1dnVUJNdXlORE5ob0JTUlVrRWtRb1RGQytSRmRBQ0NwTVVMQWpRellhQVVrVkpCSkVLRXhRdmtRcVRGQ3dJME0yR2dGSkZTUVNSSWdEdnljS1RHY2pRellhQVVrVkpCSkVpQU91SndkTVp5TkROaG9CU1JVa0VrUTJHZ0pKRlNVU1JCZUlBdUJBQUFoTEFZZ0N3MEVBS1NORXNTS3lFa215RVV4SnNoVkpzaFJKc2dDQkJMSVFJcklCczB3V1VJQUVnTmQvTVV4UXNDTkRJa0wvMURZYUFVa1ZKQkpFTmhvQ1NSVWxFa1FYTmhvRFNSVWxFa1FYU3dLSUFuUkVLRXNEVUw1RVN3TkxBM0FBU0VzQ0QwUXhBRElIVHdKWFNBaFBCVThEVUU4RUZsQlBBeFpRVHdJV1VFeFFLVEVBVUVzQnY0QUUyRjlpQ2tzQlVMQXFURkN3STBNMkdnRkpGU1FTUklnQ0pFUXBNUUJRdlVVQlJDa3hBRkMrUkNreEFGQzhTRWxYQUNCTEFWY2dJRXNDVjBBSVN3TlhTQWhMQkZkUUNFOEZWMWdJVHdWUEJWQlBCRkJQQTFCUEFsQk1VSUFFUDllQ2xVeFFzQ05ETmhvQlNSVWtFa1EyR2dKSkZTVVNSQmRMQVlnQndVUXBNUUJRdlVVQlJDaExBbEMrUkNreEFGQytSRW1CU0Z0TEF3OUVUSUZJVzBzQmdWaGJURXNCRWtSTEFZRlFXeUluQ0dWRVN3RUlNZ2NPUkU4Q2dVQmJUd1JNVHdSUEEwOEVKd3VJQWNBcE1RQlF2RWdqUXpZYUFVY0NGU1FTUkRZYUFra1ZKUkpFRjBsUEFqWWFBMGtWSlJKRUYwbE9BazRETmhvRVNSVWxFa1FYU1U0RU5ob0ZTUlVsRWtRWE5ob0dTVTRHRllGQUVrUkxBb2dCSWtRb1N3TlF2a1F5QjBzRERFU0JTRnRKVGdkTEFSSkVNUUF5RVU4RVR3SlFUd1VXVUU4RUZsQlBBeFpRVHdJV1VFeFFBWUhPRXpJTURVRUFHTEdCQnJJUWdRV3lHU2NNc2g0bkRMSWZJcklCczBMLzN5SW5DV1ZFVEU0Q2hFUW5EWWdCRFNreEFGQzlSUUZCQUFZcE1RQlF2RWdqUXlJbkJHVkVLa3hRc0NORE5ob0JTUlVrRWtTSUFXQ0lBV2NqUXlJbkJXVkVLa3hRc0NORGlBRi9Kd1lqWjRBRXp5T2pEN0FqUTRnQmJ5Y0dJbWVBQkxGajdndXdJME0yR2dGSkZTUVNSSWdCVjBreUF4TkVKd1ZMQVdlQUJNeEFranhNVUxBalF6WWFBVWtWSlJKRUYwazJHZ0pKRlNVU1JCZE9BallhQTBsT0FoVWtFa1NJQU81QkFCR3hzaFN5RWJJU2dRU3lFQ0t5QWJNalEwVUJzYklIc2dnanNoQWlzZ0d6UXYvdGlnRUJLSXYvVUVtOVJRRkV2a2hYQUNBeEFCS0pNUUFpSndwbFJCS0ppZ0lBaVAveFJMRWlzaEtMLzdJUmkvNnlGSXYrc2dDQkJMSVFJcklCczR2L0ZvditURkNBQkZjWnp0Rk1VTENKaWdZQWkveEJBQm14TVFDTC9MSVNpL3V5RWJJVWkvcXlBSUVFc2hBaXNnR3pNUUNML3ljTEVpS0wvVThDVFl2L0p3MFNJb3Y5VHdKTmkvcFBBMUNMK3haUWkvd1dVRThDRmxCTUZsQ0wvaFpRaS84VkZsY0dBb3YvVUV5QUFnQnFVRXhRZ0FTN1RkQUdURkN3aS80akNDaUwrbEJNRm9GSVRMdUpNUUFpSndSbFJCSkVpWW9CQUNJbkJHVkZBVUVBRnlJbkJHVkVKd1NMLzJlTC8xQ0FCSm9pUHZ0TVVMQ0pNZ05DLytreEFDSW5CV1ZFRWtTSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkNhcmRBc3NldEVuYWJsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNhcmRDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRGViaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmZXJlbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJDYXJkQXNzZXREaXNhYmxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJXaXRoZHJhd2FsUmVxdWVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0ZWRBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJXaXRoZHJhd2FsUmVxdWVzdENhbmNlbGxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0ZWRBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJXaXRoZHJhd2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRlZEF0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJlc0F0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eXBlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJQYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdfSx7Im5hbWUiOiJVbnBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119LHsibmFtZSI6IlBhdXNlckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0FkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
