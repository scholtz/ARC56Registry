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

            public class CardRecoveredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 76, 120, 194, 69 };
                public const string Signature = "CardRecovered(address,address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Card { get; set; }
                public Algorand.Address OldCardOwner { get; set; }
                public Algorand.Address NewCardOwner { get; set; }

                public static CardRecoveredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CardRecoveredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCard.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCard = vCard.ToValue();
                    if (valueCard is Algorand.Address vCardValue) { ret.Card = vCardValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOldCardOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOldCardOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOldCardOwner = vOldCardOwner.ToValue();
                    if (valueOldCardOwner is Algorand.Address vOldCardOwnerValue) { ret.OldCardOwner = vOldCardOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewCardOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vNewCardOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewCardOwner = vNewCardOwner.ToValue();
                    if (valueNewCardOwner is Algorand.Address vNewCardOwnerValue) { ret.NewCardOwner = vNewCardOwnerValue; }
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
        ///Only a withdraw operator can perform this operation.
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
        ///Authorize an account as a withdraw operator, allowing it to call cardDebit.
        ///Only the owner of the contract can call this method.
        ///</summary>
        /// <param name="operator">The account to authorize. </param>
        public async Task AddWithdrawOperator(Algorand.Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 217, 148, 100 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            var result = await base.CallApp(new List<object> { abiHandle, operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddWithdrawOperator_Transactions(Algorand.Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 217, 148, 100 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            return await base.MakeTransactionList(new List<object> { abiHandle, operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revoke a withdraw operator. Deleting the box releases its MBR back to the
        ///contract. Only the owner of the contract can call this method.
        ///</summary>
        /// <param name="operator">The account to revoke. </param>
        public async Task RemoveWithdrawOperator(Algorand.Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 57, 199, 133 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            var result = await base.CallApp(new List<object> { abiHandle, operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveWithdrawOperator_Transactions(Algorand.Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 57, 199, 133 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            return await base.MakeTransactionList(new List<object> { abiHandle, operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWFpbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDYXJkRGF0YSI6W3sibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3aXRoZHJhd2FsTm9uY2UiLCJ0eXBlIjoidWludDY0In1dLCJXaXRoZHJhd2FsUmVxdWVzdCI6W3sibmFtZSI6ImNhcmQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlY2lwaWVudCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXNzZXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNyZWF0ZWRBdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY2FyZEFzc2V0T3B0SW4iLCJkZXNjIjoiT3B0LWluIGEgY2FyZCBpbnRvIGFuIGFzc2V0LiBNaW5pbXVtIGJhbGFuY2UgcmVxdWlyZW1lbnQgbXVzdCBiZSBtZXQgcHJpb3IgdG8gY2FsbGluZyB0aGlzIGZ1bmN0aW9uLlxuT25seSB0aGUgcGFydG5lciBjYW4gY2FsbCB0aGlzIGZ1bmN0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOiJDYXJkIGFkZHJlc3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IkFzc2V0IHRvIG9wdC1pbiB0byIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ2FyZEFzc2V0RW5hYmxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwbG95IiwiZGVzYyI6IkRlcGxveSB0aGUgY29udHJhY3QsIHNldHRpbmcgdGhlIG93bmVyIGFzIHByb3ZpZGVkIGFuZCBpbml0aWFsaXppbmcgZ2xvYmFsIHN0YXRlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbW5pYnVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZSIsImRlc2MiOiJBbGxvd3MgdGhlIG93bmVyIHRvIHVwZGF0ZSB0aGUgc21hcnQgY29udHJhY3QiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlc3Ryb3kiLCJkZXNjIjoiRGVzdHJveSB0aGUgc21hcnQgY29udHJhY3QsIHNlbmRpbmcgYWxsIEFsZ28gdG8gdGhlIG93bmVyIGFjY291bnQuIFRoaXMgY2FuIG9ubHkgYmUgZG9uZSBpZiB0aGVyZSBhcmUgbm8gYWN0aXZlIGNhcmRzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRXaXRoZHJhd2FsVGltZW91dCIsImRlc2MiOiJTZXQgdGhlIG51bWJlciBvZiBzZWNvbmRzIGEgd2l0aGRyYXdhbCByZXF1ZXN0IG11c3Qgd2FpdCB1bnRpbCBiZWluZyB3aXRoZHJhd24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2Vjb25kcyIsImRlc2MiOiJOZXcgbnVtYmVyIG9mIHNlY29uZHMgdG8gd2FpdCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRXaXRoZHJhd2FsUHVia2V5IiwiZGVzYyI6IlNldHMgdGhlIHdpdGhkcmF3YWwgcHVibGljIGtleS4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJrZXkiLCJkZXNjIjoiLSBUaGUgcHVibGljIGtleSB0byBzZXQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhcmRDcmVhdGUiLCJkZXNjIjoiQ3JlYXRlIGEgY2FyZC4gVGhpcyBnZW5lcmF0ZXMgYSBicmFuZCBuZXcgYWNjb3VudCBhbmQgZnVuZHMgdGhlIG1pbmltdW0gYmFsYW5jZSByZXF1aXJlbWVudFxuZnJvbSB0aGUgY29udHJhY3QgKG93bmVyLXNwb25zb3JlZCkuIE9ubHkgdGhlIHBhcnRuZXIgY2FuIGNhbGwgdGhpcyBmdW5jdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmRPd25lciIsImRlc2MiOiJUaGUgY2FyZCBob2xkZXIgd2hvIHdpbGwgb3duL2NvbnRyb2wgdGhlIGNhcmQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IkFzc2V0IHRvIG9wdC1pbiB0by4gMCA9IE5vIGFzc2V0IG9wdC1pbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjoiTmV3bHkgZ2VuZXJhdGVkIGFjY291bnQgdXNlZCBieSB0aGVpciBjYXJkIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNhcmRBc3NldEVuYWJsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ2FyZENyZWF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmRPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FyZENsb3NlIiwiZGVzYyI6IkNsb3NlIGFjY291bnQuIFRoaXMgcGVybWFuZW50bHkgcmVtb3ZlcyB0aGUgcmVrZXkgYW5kIGRlbGV0ZXMgdGhlIGFjY291bnQgZnJvbSB0aGUgbGVkZ2VyLlxuT25seSB0aGUgcGFydG5lciBvciB0aGUgY2FyZCBob2xkZXIgY2FuIGNhbGwgdGhpcyBmdW5jdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiQWRkcmVzcyB0byBjbG9zZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiV2l0aGRyYXdhbFJlcXVlc3RDYW5jZWxsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdGVkQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhcmRSZWNvdmVyIiwiZGVzYyI6IlJlY292ZXJzIGZ1bmRzIGZyb20gYW4gb2xkIGNhcmQgYW5kIHRyYW5zZmVycyB0aGVtIHRvIGEgbmV3IGNhcmQuXG5Pbmx5IHRoZSBvd25lciBvZiB0aGUgY29udHJhY3QgY2FuIHBlcmZvcm0gdGhpcyBvcGVyYXRpb24uIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6Ii0gVGhlIGNhcmQgdG8gcmVjb3Zlci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDYXJkSG9sZGVyIiwiZGVzYyI6Ii0gVGhlIGFkZHJlc3Mgb2YgdGhlIG5ldyBjYXJkIGhvbGRlci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IldpdGhkcmF3YWxSZXF1ZXN0Q2FuY2VsbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRlZEF0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNhcmRSZWNvdmVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkQ2FyZE93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0NhcmRPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhcmREZWJpdCIsImRlc2MiOiJEZWJpdHMgdGhlIHNwZWNpZmllZCBhbW91bnQgb2YgdGhlIGdpdmVuIGFzc2V0IGZyb20gdGhlIGNhcmQgYWNjb3VudC5cbk9ubHkgYSB3aXRoZHJhdyBvcGVyYXRvciBjYW4gcGVyZm9ybSB0aGlzIG9wZXJhdGlvbi5cblxuVGhlIEF1dG9EcmF3IGxzaWcgYmluZHMgYGNhcmRgIGFuZCBgY2FyZE93bmVyYCB0byB0aGUgYXhmZXIgcmVjZWl2ZXIsIHNvIHZlcmlmeWluZyBoZXJlIHRoYXRcbmBjYXJkT3duZXJgIG93bnMgYGNhcmRgIHByZXZlbnRzIHRoZSBkZWxlZ2F0ZWQgZHJhdyBmcm9tIGZ1bmRpbmcgKGFuZCBzdWJzZXF1ZW50bHlcbmRlYml0aW5nKSBhIGNhcmQgdGhlIGFjY291bnQgZG9lcyBub3Qgb3duLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZE93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOiJUaGUgY2FyZCBmcm9tIHdoaWNoIHRoZSBhc3NldCB3aWxsIGJlIGRlYml0ZWQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdG8gYmUgZGViaXRlZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJUaGUgYW1vdW50IG9mIHRoZSBhc3NldCB0byBiZSBkZWJpdGVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRGViaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmZXJlbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TmV4dENhcmROb25jZSIsImRlc2MiOiJSZXRyaWV2ZXMgdGhlIG5leHQgYXZhaWxhYmxlIG5vbmNlIGZvciB0aGUgY2FyZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiVGhlIGNhcmQgYWRkcmVzcy4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIG5vbmNlIGZvciB0aGUgY2FyZC4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldENhcmREYXRhIiwiZGVzYyI6IlJldHJpZXZlcyB0aGUgY2FyZCBkYXRhIGZvciBhIGdpdmVuIGNhcmQgYWRkcmVzcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIGNhcmQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJDYXJkRGF0YSIsImRlc2MiOiJUaGUgY2FyZCBkYXRhLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UGFydG5lckFkZHJlc3MiLCJkZXNjIjoiU2V0cyB0aGUgcGFydG5lciBhZGRyZXNzLlxuT25seSB0aGUgb3duZXIgb2YgdGhlIGNvbnRyYWN0IGNhbiBjYWxsIHRoaXMgbWV0aG9kLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3UGFydG5lckFkZHJlc3MiLCJkZXNjIjoiVGhlIG5ldyBwYXJ0bmVyIGFkZHJlc3MgdG8gYmUgc2V0LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRPbW5pYnVzQWRkcmVzcyIsImRlc2MiOiJTZXRzIHRoZSBvbW5pYnVzIGFkZHJlc3MuXG5Pbmx5IHRoZSBvd25lciBvZiB0aGUgY29udHJhY3QgY2FuIGNhbGwgdGhpcyBtZXRob2QuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPbW5pYnVzQWRkcmVzcyIsImRlc2MiOiJUaGUgbmV3IG9tbmlidXMgYWRkcmVzcyB0byBiZSBzZXQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZFdpdGhkcmF3T3BlcmF0b3IiLCJkZXNjIjoiQXV0aG9yaXplIGFuIGFjY291bnQgYXMgYSB3aXRoZHJhdyBvcGVyYXRvciwgYWxsb3dpbmcgaXQgdG8gY2FsbCBjYXJkRGViaXQuXG5Pbmx5IHRoZSBvd25lciBvZiB0aGUgY29udHJhY3QgY2FuIGNhbGwgdGhpcyBtZXRob2QuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRvciIsImRlc2MiOiJUaGUgYWNjb3VudCB0byBhdXRob3JpemUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbW92ZVdpdGhkcmF3T3BlcmF0b3IiLCJkZXNjIjoiUmV2b2tlIGEgd2l0aGRyYXcgb3BlcmF0b3IuIERlbGV0aW5nIHRoZSBib3ggcmVsZWFzZXMgaXRzIE1CUiBiYWNrIHRvIHRoZVxuY29udHJhY3QuIE9ubHkgdGhlIG93bmVyIG9mIHRoZSBjb250cmFjdCBjYW4gY2FsbCB0aGlzIG1ldGhvZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6IlRoZSBhY2NvdW50IHRvIHJldm9rZS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FyZERpc2FibGVBc3NldCIsImRlc2MiOiJBbGxvd3MgdGhlIGNhcmQgaG9sZGVyIChvciBwYXJ0bmVyKSB0byBDbG9zZU91dCBvZiBhbiBhc3NldCwgcmVkdWNpbmcgdGhlIG1pbmltdW0gYmFsYW5jZVxucmVxdWlyZW1lbnQgb2YgdGhlIGFjY291bnQuIFRoZSBmcmVlZCBNQlIgcmVtYWlucyB3aXRoaW4gdGhlIGNhcmQgYWNjb3VudC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiLSBUaGUgYWRkcmVzcyBvZiB0aGUgY2FyZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6Ii0gVGhlIElEIG9mIHRoZSBhc3NldCB0byBiZSByZW1vdmVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ2FyZEFzc2V0RGlzYWJsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3YWxSZXF1ZXN0IiwiZGVzYyI6IkFsbG93cyB0aGUgY2FyZCBob2xkZXIgdG8gcmVxdWVzdCBhIHdpdGhkcmF3YWwgb2YgYW4gYW1vdW50IG9mIGFzc2V0cyBmcm9tIHRoZSBhY2NvdW50IiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6IkFkZHJlc3MgdG8gd2l0aGRyYXcgZnJvbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiQXNzZXQgdG8gd2l0aGRyYXciLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJBbW91bnQgdG8gd2l0aGRyYXciLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiV2l0aGRyYXdhbFJlcXVlc3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiV2l0aGRyYXdhbFJlcXVlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdGVkQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3YWxDYW5jZWwiLCJkZXNjIjoiQWxsb3dzIHRoZSBjYXJkIGhvbGRlciB0byBjYW5jZWwgYSB3aXRoZHJhd2FsIHJlcXVlc3QiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiQWRkcmVzcyB0byB3aXRoZHJhdyBmcm9tIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJXaXRoZHJhd2FsUmVxdWVzdENhbmNlbGxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0ZWRBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjoiQWxsb3dzIHRoZSBjYXJkIGhvbGRlciB0byBzZW5kIGFuIGFtb3VudCBvZiBhc3NldHMgZnJvbSB0aGUgYWNjb3VudCIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOiJBZGRyZXNzIHRvIHdpdGhkcmF3IGZyb20iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiV2l0aGRyYXdhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0ZWRBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyZXNBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHlwZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3UGVybWlzc2lvbmVkIiwiZGVzYyI6IldpdGhkcmF3cyBmdW5kcyBiZWZvcmUgdGhlIHdpdGhkcmF3YWwgdGltZXN0YW1wIGhhcyBsYXBzZWQsIGJ5IHVzaW5nIHRoZSBwZXJtaXNzaW9uZWQgd2l0aGRyYXdhbCBzaWduYXR1cmUgcHJvdmlkZWQgYnkgcGFydG5lci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiLSBUaGUgYWRkcmVzcyBvZiB0aGUgY2FyZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6Ii0gVGhlIElEIG9mIHRoZSBhc3NldCB0byBiZSB3aXRoZHJhd24uIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiLSBUaGUgYW1vdW50IG9mIHRoZSB3aXRoZHJhd2FsLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJlc0F0IiwiZGVzYyI6Ii0gVGhlIGV4cGlyeSBvZiB0aGUgd2l0aGRyYXdhbCBzaWduYXR1cmUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs2NF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmUiLCJkZXNjIjoiLSBUaGUgc2lnbmF0dXJlIGZvciBwZXJtaXNzaW9uZWQgd2l0aGRyYXdhbC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IldpdGhkcmF3YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdGVkQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcmVzQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR5cGUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyT3duZXJzaGlwIiwiZGVzYyI6IlRyYW5zZmVycyB0aGUgb3duZXJzaGlwIG9mIHRoZSBjb250cmFjdCB0byBhIG5ldyBvd25lci5cblJlcXVpcmVzIHRoZSBjYWxsZXIgdG8gYmUgdGhlIGN1cnJlbnQgb3duZXIuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOiJUaGUgYWRkcmVzcyBvZiB0aGUgbmV3IG93bmVyLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXVzZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlBhdXNlcidzIGFkZHJlc3MifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVucGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlVucGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZVBhdXNlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX25ld1BhdXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUGF1c2VyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QWRkcmVzcyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY292ZXJBc3NldCIsImRlc2MiOiJSZWNvdmVyIGFuIGFzc2V0IHNlbnQgdG8gdGhlIGNvbnRyYWN0IGJ5IG1pc3Rha2UuIE9ubHkgdGhlIG93bmVyIGNhbiBjYWxsIHRoaXMgZnVuY3Rpb24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IkFzc2V0IElEIG9mIHRoZSBhc3NldCB0byByZWNvdmVyLiBJZiAwLCBBbGdvIHdpbGwgYmUgcmVjb3ZlcmVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6IkFtb3VudCBvZiB0aGUgYXNzZXQgdG8gcmVjb3Zlci4gSWYgQWxnb3MsIHJlbWVtYmVyIHRoZSBtaW5pbXVtIGJhbGFuY2UgcmVxdWlyZW1lbnQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6IkFkZHJlc3MgdG8gc2VuZCB0aGUgcmVjb3ZlcmVkIGFzc2V0IHRvLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjV9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0ODFdLCJlcnJvck1lc3NhZ2UiOiJBTU9VTlRfSU5WQUxJRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0NywxMDU5LDEwODEsMTI4NCwxMzcyLDE0NjcsMTQ3MywxNjI3LDIwMTQsMjAyOF0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDFdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMxXSwiZXJyb3JNZXNzYWdlIjoiQ0FSRFNfU1RJTExfQUNUSVZFIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwNF0sImVycm9yTWVzc2FnZSI6IkNBUkRfTUlTTUFUQ0giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTMsODMwLDEyMDEsMTkyMiwxOTU1XSwiZXJyb3JNZXNzYWdlIjoiQ0FSRF9OT1RfRk9VTkQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjk1XSwiZXJyb3JNZXNzYWdlIjoiSU5TVUZGSUNJRU5UX0JBTEFOQ0UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjMsMTQ5NSwxNjQzXSwiZXJyb3JNZXNzYWdlIjoiTk9OQ0VfSU5WQUxJRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1NV0sImVycm9yTWVzc2FnZSI6Ik9XTkVSX0lOVkFMSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTcsNzQ0LDk0MCwxMTkzLDEyNzgsMTM1OCwxNDUzLDE2MjEsMTk0NywyMjE0XSwiZXJyb3JNZXNzYWdlIjoiU0VOREVSX05PVF9BTExPV0VEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcxNF0sImVycm9yTWVzc2FnZSI6IlNJR05BVFVSRV9JTlZBTElEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2NiwxNDYxXSwiZXJyb3JNZXNzYWdlIjoiV0lUSERSQVdBTF9SRVFVRVNUX05PVF9GT1VORCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MjEsMTYzM10sImVycm9yTWVzc2FnZSI6IldJVEhEUkFXQUxfVElNRV9JTlZBTElEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI5LDQzOSw2ODIsNzkxLDkyOSw5NjksMTUxNCwxNzA5LDE3NDIsMTc2OSwxOTM4LDIyMTIsMjIzMiwyMjYyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODQ3LDEwNDQsMjIwNF0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTcsMzc5LDM4Nyw0ODEsNDk5LDcyOSw4MTAsODE4LDg3Miw4ODAsMTA1NCwxMDc2LDEwOTUsMTExMiwxMTI5LDExNDksMTE2OCwxMjU0LDEzNTQsMTQzOCwxNTU3LDE3NTYsMTgxNSwxODcwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgNjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY1LDQ2Myw1MDcsODg4LDg5Nyw5MDYsMTE3NiwxMjYyLDEyNzEsMTQ0NiwxNTY1LDE1NzcsMTU5MSwxNjAzLDE4NDcsMTg1N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbU5tSWlBaWQzSWlJREI0TVRVeFpqZGpOelVnSW1ObVlXTWlJQ0pmYjNkdVpYSWlJQ0pmY0dGMWMyVnlJaUFpY0dGMWMyVmtJaUFpYjJFaUlDSjNiM0FpSUNKM2QzUWlJQ0p3ZDNCcklpQWljR0VpSURCNE0yWmtOemd5T1RVZ0luQmxjbTFwYzNOcGIyNXNaWE56SWlBd2VEQTJPREV3TVNBaVlYQndjbTkyWldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBPUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxaGFXNGdaWGgwWlc1a2N5QmpiR0Z6YzJWektFOTNibUZpYkdVc0lGQmhkWE5oWW14bExDQlNaV052ZG1WeVlXSnNaU2tnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdFd1pUZ3hPRGN5SURCNE9XTTRObUV4T0RVZ0x5OGdiV1YwYUc5a0lDSjFjR1JoZEdVb0tYWnZhV1FpTENCdFpYUm9iMlFnSW1SbGMzUnliM2tvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzVndaR0YwWlY5eWIzVjBaVUEwSUcxaGFXNWZaR1Z6ZEhKdmVWOXliM1YwWlVBMUNncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVFdGcGJpQmxlSFJsYm1SeklHTnNZWE56WlhNb1QzZHVZV0pzWlN3Z1VHRjFjMkZpYkdVc0lGSmxZMjkyWlhKaFlteGxLU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FETTBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZVEZoWVdSaE5ETWdNSGhoTURVd1pqVm1NU0F3ZUdKbVpHWTVOV1JqSURCNE5XSXlOemN4TkRNZ01IZzBOMkppT1dSbVpDQXdlRE5tWVRFeU16aGlJREI0WVdReE5qSTJNalFnTUhoalltVmxNbUpoTVNBd2VEYzBOV1JpWmpFMklEQjRaR0V4WWpJM09Ea2dNSGhoWXpjek1XUmxOaUF3ZURnM1pEazVORFkwSURCNE1tTXpPV00zT0RVZ01IZzVOVE0zWkRVd09TQXdlR0kzTXpRNU1UVTRJREI0WW1Ka01HUmxaakFnTUhneE0yWm1NV05sT1NBd2VHWXlaVE5tTXpkbUlEQjRZakZpWW1Jd1lUZ2dNSGhsTVRkaVlXWmlOQ0F3ZUdJd1pEazFNMkl6SURCNE1ERTNPR1k1TkdJZ01IZ3hZalV5T1dSbE9DQXdlREJqWVdSa01UWXpJREI0TnpnMVlURmlaamtnTHk4Z2JXVjBhRzlrSUNKallYSmtRWE56WlhSUGNIUkpiaWhoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUlhhWFJvWkhKaGQyRnNWR2x0Wlc5MWRDaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFYybDBhR1J5WVhkaGJGQjFZbXRsZVNoaWVYUmxXek15WFNsMmIybGtJaXdnYldWMGFHOWtJQ0pqWVhKa1EzSmxZWFJsS0dGa1pISmxjM01zZFdsdWREWTBLV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbU5oY21SRGJHOXpaU2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTmhjbVJTWldOdmRtVnlLR0ZrWkhKbGMzTXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKallYSmtSR1ZpYVhRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhST1pYaDBRMkZ5WkU1dmJtTmxLR0ZrWkhKbGMzTXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJEWVhKa1JHRjBZU2hoWkdSeVpYTnpLU2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luTmxkRkJoY25SdVpYSkJaR1J5WlhOektHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFQyMXVhV0oxYzBGa1pISmxjM01vWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmhaR1JYYVhSb1pISmhkMDl3WlhKaGRHOXlLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVnRiM1psVjJsMGFHUnlZWGRQY0dWeVlYUnZjaWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTmhjbVJFYVhOaFlteGxRWE56WlhRb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYZGhiRkpsY1hWbGMzUW9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NoaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWQybDBhR1J5WVhkaGJFTmhibU5sYkNoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5kcGRHaGtjbUYzVUdWeWJXbHpjMmx2Ym1Wa0tHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHSjVkR1ZiTmpSZEtYWnZhV1FpTENCdFpYUm9iMlFnSW05M2JtVnlLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0owY21GdWMyWmxjazkzYm1WeWMyaHBjQ2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luQmhkWE5sY2lncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaWNHRjFjMlVvS1hadmFXUWlMQ0J0WlhSb2IyUWdJblZ1Y0dGMWMyVW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0luVndaR0YwWlZCaGRYTmxjaWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxZMjkyWlhKQmMzTmxkQ2gxYVc1ME5qUXNkV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOaGNtUkJjM05sZEU5d2RFbHVJSE5sZEZkcGRHaGtjbUYzWVd4VWFXMWxiM1YwSUhObGRGZHBkR2hrY21GM1lXeFFkV0pyWlhrZ1kyRnlaRU55WldGMFpTQmpZWEprUTJ4dmMyVWdZMkZ5WkZKbFkyOTJaWElnWTJGeVpFUmxZbWwwSUdkbGRFNWxlSFJEWVhKa1RtOXVZMlVnWjJWMFEyRnlaRVJoZEdFZ2MyVjBVR0Z5ZEc1bGNrRmtaSEpsYzNNZ2MyVjBUMjF1YVdKMWMwRmtaSEpsYzNNZ1lXUmtWMmwwYUdSeVlYZFBjR1Z5WVhSdmNpQnlaVzF2ZG1WWGFYUm9aSEpoZDA5d1pYSmhkRzl5SUdOaGNtUkVhWE5oWW14bFFYTnpaWFFnZDJsMGFHUnlZWGRoYkZKbGNYVmxjM1FnZDJsMGFHUnlZWGRoYkVOaGJtTmxiQ0IzYVhSb1pISmhkeUIzYVhSb1pISmhkMUJsY20xcGMzTnBiMjVsWkNCdmQyNWxjaUIwY21GdWMyWmxjazkzYm1WeWMyaHBjQ0J3WVhWelpYSWdjR0YxYzJVZ2RXNXdZWFZ6WlNCMWNHUmhkR1ZRWVhWelpYSWdjbVZqYjNabGNrRnpjMlYwQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTXpRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBPUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxaGFXNGdaWGgwWlc1a2N5QmpiR0Z6YzJWektFOTNibUZpYkdVc0lGQmhkWE5oWW14bExDQlNaV052ZG1WeVlXSnNaU2tnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRjME9ERTVNMlFnTHk4Z2JXVjBhRzlrSUNKa1pYQnNiM2tvWVdSa2NtVnpjeXhoWkdSeVpYTnpLV0ZrWkhKbGMzTWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JrWlhCc2Iza0tJQ0FnSUdWeWNnb0tiV0ZwYmw5a1pYTjBjbTk1WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNME5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZEVaV3hsZEdWQmNIQnNhV05oZEdsdmJpZGRJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z1JHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCa1pYTjBjbTk1Q2dwdFlXbHVYM1Z3WkdGMFpWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNemdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNuVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRuWFNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2NIVnphR2x1ZENBMElDOHZJRlZ3WkdGMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHSWdkWEJrWVhSbENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTVqWVhKa1FYTnpaWFJQY0hSSmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oY21SQmMzTmxkRTl3ZEVsdU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNak1LSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprUVhOelpYUlBjSFJKYmloallYSmtPaUJCWTJOdmRXNTBMQ0JoYzNObGREb2dRWE56WlhRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWTJGc2JITjFZaUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTllXbHVMbU5oY21SQmMzTmxkRTl3ZEVsdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTVrWlhCc2IzbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWlhCc2IzazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkT2IwOXdKMTBzSUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlNd29nSUNBZ0x5OGdkR2hwY3k1ZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBb2IzZHVaWElwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPRE1LSUNBZ0lDOHZJSFJvYVhNdWIyNXNlVTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnYjI1c2VVOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM01Bb2dJQ0FnTHk4Z2NIVmliR2xqSUc5dGJtbGlkWE5mWVdSa2NtVnpjeUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lBbmIyRW5JSDBwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p2WVNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZzFDaUFnSUNBdkx5QjBhR2x6TG05dGJtbGlkWE5mWVdSa2NtVnpjeTUyWVd4MVpTQTlJRzVsZDA5dGJtbGlkWE5CWkdSeVpYTnpDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhCMVlteHBZeUJmY0dGMWMyVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVgzQmhkWE5sY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16STFDaUFnSUNBdkx5QjBhR2x6TGw5d1lYVnpaWEl1ZG1Gc2RXVWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRRS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa2MxOWhZM1JwZG1WZlkyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBblkyWmhZeWNnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1ObVlXTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15T1FvZ0lDQWdMeThnZEdocGN5NWpZWEprYzE5aFkzUnBkbVZmWTI5MWJuUXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0YxYzJWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpY0dGMWMyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXpBS0lDQWdJQzh2SUhSb2FYTXVjR0YxYzJWa0xuWmhiSFZsSUQwZ1ptRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUZzblRtOVBjQ2RkTENCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek15Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dXeWRPYjA5d0oxMHNJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTUxY0dSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wTUFvZ0lDQWdMeThnZEdocGN5NXZibXg1VDNkdVpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCdmJteDVUM2R1WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMVZ3WkdGMFpVRndjR3hwWTJGMGFXOXVKMTBnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTllXbHVMbVJsYzNSeWIzbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWlhOMGNtOTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkRnS0lDQWdJQzh2SUhSb2FYTXViMjVzZVU5M2JtVnlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2IyNXNlVTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTFNUW9nSUNBZ0x5OGdZWE56WlhKMEtDRjBhR2x6TG1OaGNtUnpYMkZqZEdsMlpWOWpiM1Z1ZEM1MllXeDFaU3dnSjBOQlVrUlRYMU5VU1V4TVgwRkRWRWxXUlNjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UUUtJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtjMTloWTNScGRtVmZZMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ZMlpoWXljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTm1ZV01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbU5oY21SelgyRmpkR2wyWlY5amIzVnVkQzUyWVd4MVpTd2dKME5CVWtSVFgxTlVTVXhNWDBGRFZFbFdSU2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVOQlVrUlRYMU5VU1V4TVgwRkRWRWxXUlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5UTXRNelU1Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklIUm9hWE11YjNkdVpYSW9LU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMU5Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbDl2ZDI1bGNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhCMVlteHBZeUJmYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKZmIzZHVaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnNiM05sVW1WdFlXbHVaR1Z5Vkc4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VTJDaUFnSUNBdkx5QmhiVzkxYm5RNklEQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelV6TFRNMU9Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JqYkc5elpWSmxiV0ZwYm1SbGNsUnZPaUIwYUdsekxtOTNibVZ5S0Nrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMU15MHpOVGtLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ1kyeHZjMlZTWlcxaGFXNWtaWEpVYnpvZ2RHaHBjeTV2ZDI1bGNpZ3BMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNME5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZEVaV3hsZEdWQmNIQnNhV05oZEdsdmJpZGRJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdGcGJpNXpaWFJYYVhSb1pISmhkMkZzVkdsdFpXOTFkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGZHBkR2hrY21GM1lXeFVhVzFsYjNWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOamNLSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJYYVhSb1pISmhkMkZzVkdsdFpXOTFkQ2h6WldOdmJtUnpPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZNENpQWdJQ0F2THlCMGFHbHpMbTl1YkhsUGQyNWxjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHOXViSGxQZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVGNLSUNBZ0lDOHZJSEIxWW14cFl5QjNhWFJvWkhKaGQyRnNYM2RoYVhSZmRHbHRaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkM2QzUW5JSDBwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0ozZDNRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNNQW9nSUNBZ0x5OGdkR2hwY3k1M2FYUm9aSEpoZDJGc1gzZGhhWFJmZEdsdFpTNTJZV3gxWlNBOUlITmxZMjl1WkhNS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJOd29nSUNBZ0x5OGdjSFZpYkdsaklITmxkRmRwZEdoa2NtRjNZV3hVYVcxbGIzVjBLSE5sWTI5dVpITTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1YzJWMFYybDBhR1J5WVhkaGJGQjFZbXRsZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRmRwZEdoa2NtRjNZV3hRZFdKclpYazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0zTndvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEZkcGRHaGtjbUYzWVd4UWRXSnJaWGtvY0hWaWEyVjVPaUJpZVhSbGN6d3pNajRwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TnpnS0lDQWdJQzh2SUhSb2FYTXViMjVzZVU5M2JtVnlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2IyNXNlVTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNQW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1lXeGZjSFZpYTJWNUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTThNekkrUGloN0lHdGxlVG9nSjNCM2NHc25JSDBwQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpY0hkd2F5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemd3Q2lBZ0lDQXZMeUIwYUdsekxuZHBkR2hrY21GM1lXeGZjSFZpYTJWNUxuWmhiSFZsSUQwZ2NIVmlhMlY1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek56Y0tJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlhhWFJvWkhKaGQyRnNVSFZpYTJWNUtIQjFZbXRsZVRvZ1lubDBaWE04TXpJK0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTVqWVhKa1EzSmxZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyRnlaRU55WldGMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemt3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZMkZ5WkVOeVpXRjBaU2hqWVhKa1QzZHVaWEk2SUVGalkyOTFiblFzSUdGemMyVjBPaUJCYzNObGRDazZJRUZqWTI5MWJuUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXBjMUJoY25SdVpYSW9LU3dnSjFORlRrUkZVbDlPVDFSZlFVeE1UMWRGUkNjcENpQWdJQ0JqWVd4c2MzVmlJR2x6VUdGeWRHNWxjZ29nSUNBZ1lYTnpaWEowSUM4dklGTkZUa1JGVWw5T1QxUmZRVXhNVDFkRlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPVFVLSUNBZ0lDOHZJR0ZrWkhKbGMzTTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPVE10TXprNENpQWdJQ0F2THlCamIyNXpkQ0JqWVhKa1JHRjBZVG9nUTJGeVpFUmhkR0VnUFNCN0NpQWdJQ0F2THlBZ0lHOTNibVZ5T2lCallYSmtUM2R1WlhJc0NpQWdJQ0F2THlBZ0lHRmtaSEpsYzNNNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdibTl1WTJVNklEQXNDaUFnSUNBdkx5QWdJSGRwZEdoa2NtRjNZV3hPYjI1alpUb2dNQ3dLSUNBZ0lDOHZJSDBLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9UWUtJQ0FnSUM4dklHNXZibU5sT2lBd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16a3pMVE01T0FvZ0lDQWdMeThnWTI5dWMzUWdZMkZ5WkVSaGRHRTZJRU5oY21SRVlYUmhJRDBnZXdvZ0lDQWdMeThnSUNCdmQyNWxjam9nWTJGeVpFOTNibVZ5TEFvZ0lDQWdMeThnSUNCaFpHUnlaWE56T2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHNXZibU5sT2lBd0xBb2dJQ0FnTHk4Z0lDQjNhWFJvWkhKaGQyRnNUbTl1WTJVNklEQXNDaUFnSUNBdkx5QjlDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EQXlMVFF3TmdvZ0lDQWdMeThnWTI5dWMzUWdZMkZ5WkVGa1pISWdQU0JoY21NMExtRmlhVU5oYkd3OGRIbHdaVzltSUVOdmJuUnliMnhzWldSQlpHUnlaWE56TG5CeWIzUnZkSGx3WlM1dVpYYytLSHNLSUNBZ0lDOHZJQ0FnWVhCd2NtOTJZV3hRY205bmNtRnRPaUJqYjIxd2FXeGxaRU5oY21RdVlYQndjbTkyWVd4UWNtOW5jbUZ0TEFvZ0lDQWdMeThnSUNCamJHVmhjbE4wWVhSbFVISnZaM0poYlRvZ1kyOXRjR2xzWldSRFlYSmtMbU5zWldGeVUzUmhkR1ZRY205bmNtRnRMQW9nSUNBZ0x5OGdJQ0J2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNRFVLSUNBZ0lDOHZJRzl1UTI5dGNHeGxkR2x2YmpvZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1RVpXeGxkR1ZCY0hCc2FXTmhkR2x2Yml3S0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBeENpQWdJQ0F2THlCamIyNXpkQ0JqYjIxd2FXeGxaRU5oY21RZ1BTQmpiMjF3YVd4bEtFTnZiblJ5YjJ4c1pXUkJaR1J5WlhOektRb2dJQ0FnY0hWemFHSjVkR1Z6SUdKaGMyVTJOQ2hETkVWQ1VYYzlQU2tLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMVFZV2RsY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVMk5DaERlVUZEUVVGSFFVSkdXV1JNSzI4eVIyZERUMEZSUVVKQlJFVmFaMUZWVTAxU1oxVkZSVkpEUVVGRGVFMW5iM2xFY2tsblNYSkpTWE5uWTJwemFFRnBjMmRIZW1kQlVWWklNM2d4VFdkd1VYTkRUa1FwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0hKdmRtRnNVSEp2WjNKaGJWQmhaMlZ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd01pMDBNRFlLSUNBZ0lDOHZJR052Ym5OMElHTmhjbVJCWkdSeUlEMGdZWEpqTkM1aFltbERZV3hzUEhSNWNHVnZaaUJEYjI1MGNtOXNiR1ZrUVdSa2NtVnpjeTV3Y205MGIzUjVjR1V1Ym1WM1BpaDdDaUFnSUNBdkx5QWdJR0Z3Y0hKdmRtRnNVSEp2WjNKaGJUb2dZMjl0Y0dsc1pXUkRZWEprTG1Gd2NISnZkbUZzVUhKdlozSmhiU3dLSUNBZ0lDOHZJQ0FnWTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzA2SUdOdmJYQnBiR1ZrUTJGeVpDNWpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJTd0tJQ0FnSUM4dklDQWdiMjVEYjIxd2JHVjBhVzl1T2lCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVTJNV1F5Wm1WaElDOHZJRzFsZEdodlpDQWlibVYzS0NsaFpHUnlaWE56SWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd09Rb2dJQ0FnTHk4Z1kyRnlaRVJoZEdFdVlXUmtjbVZ6Y3lBOUlHTmhjbVJCWkdSeUNpQWdJQ0J5WlhCc1lXTmxNaUF6TWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNVElLSUNBZ0lDOHZJR052Ym5OMElHRnpjMlYwVFdKeU9pQjFhVzUwTmpRZ1BTQmhjM05sZEM1cFpDQS9JRWRzYjJKaGJDNWhjM05sZEU5d2RFbHVUV2x1UW1Gc1lXNWpaU0E2SURBS0lDQWdJR0o2SUdOaGNtUkRjbVZoZEdWZmRHVnlibUZ5ZVY5bVlXeHpaVUEwQ2lBZ0lDQm5iRzlpWVd3Z1FYTnpaWFJQY0hSSmJrMXBia0poYkdGdVkyVUtDbU5oY21SRGNtVmhkR1ZmZEdWeWJtRnllVjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVRNdE5ERTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dZMkZ5WkVGa1pISXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJIYkc5aVlXd3ViV2x1UW1Gc1lXNWpaU0FySUdGemMyVjBUV0p5TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ERTJDaUFnSUNBdkx5QmhiVzkxYm5RNklFZHNiMkpoYkM1dGFXNUNZV3hoYm1ObElDc2dZWE56WlhSTlluSXNDaUFnSUNCbmJHOWlZV3dnVFdsdVFtRnNZVzVqWlFvZ0lDQWdLd29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1UTXROREUzQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nWTJGeVpFRmtaSElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCSGJHOWlZV3d1YldsdVFtRnNZVzVqWlNBcklHRnpjMlYwVFdKeUxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1UTXROREU0Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nWTJGeVpFRmtaSElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCSGJHOWlZV3d1YldsdVFtRnNZVzVqWlNBcklHRnpjMlYwVFdKeUxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTWdvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lFTmhjbVJFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJObUp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMllpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESXhDaUFnSUNBdkx5QjBhR2x6TG1OaGNtUnpLR05oY21SQlpHUnlLUzUyWVd4MVpTQTlJR05zYjI1bEtHTmhjbVJFWVhSaEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlOQW9nSUNBZ0x5OGdkR2hwY3k1allYSmtjMTloWTNScGRtVmZZMjkxYm5RdWRtRnNkV1VnUFNCMGFHbHpMbU5oY21SelgyRmpkR2wyWlY5amIzVnVkQzUyWVd4MVpTQXJJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTkFvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SelgyRmpkR2wyWlY5amIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkalptRmpKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWTJaaFl5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREkwQ2lBZ0lDQXZMeUIwYUdsekxtTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDNTJZV3gxWlNBOUlIUm9hWE11WTJGeVpITmZZV04wYVhabFgyTnZkVzUwTG5aaGJIVmxJQ3NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFOQW9nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RqWm1Gakp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZMlpoWXlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESTBDaUFnSUNBdkx5QjBhR2x6TG1OaGNtUnpYMkZqZEdsMlpWOWpiM1Z1ZEM1MllXeDFaU0E5SUhSb2FYTXVZMkZ5WkhOZllXTjBhWFpsWDJOdmRXNTBMblpoYkhWbElDc2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRJM0NpQWdJQ0F2THlCcFppQW9ZWE56WlhRdWFXUXBJSHNLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmllaUJqWVhKa1EzSmxZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTWpnS0lDQWdJQzh2SUhSb2FYTXVZMkZ5WkVGemMyVjBUM0IwU1c0b1kyRnlaRUZrWkhJc0lHRnpjMlYwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMkZzYkhOMVlpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtTmhjbVJCYzNObGRFOXdkRWx1Q2dwallYSmtRM0psWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETXhMVFF6TkFvZ0lDQWdMeThnWlcxcGREeERZWEprUTNKbFlYUmxaRDRvZXdvZ0lDQWdMeThnSUNCallYSmtUM2R1WlhJNklHTmhjbVJQZDI1bGNpd0tJQ0FnSUM4dklDQWdZMkZ5WkRvZ1kyRnlaRUZrWkhJc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1kxTXpNME1EUTBJQzh2SUcxbGRHaHZaQ0FpUTJGeVpFTnlaV0YwWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTVNQW9nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJEY21WaGRHVW9ZMkZ5WkU5M2JtVnlPaUJCWTJOdmRXNTBMQ0JoYzNObGREb2dRWE56WlhRcE9pQkJZMk52ZFc1MElIc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU5oY21SRGNtVmhkR1ZmZEdWeWJtRnllVjltWVd4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVRJS0lDQWdJQzh2SUdOdmJuTjBJR0Z6YzJWMFRXSnlPaUIxYVc1ME5qUWdQU0JoYzNObGRDNXBaQ0EvSUVkc2IySmhiQzVoYzNObGRFOXdkRWx1VFdsdVFtRnNZVzVqWlNBNklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdOaGNtUkRjbVZoZEdWZmRHVnlibUZ5ZVY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdGcGJpNWpZWEprUTJ4dmMyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqWVhKa1EyeHZjMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRME5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUkRiRzl6WlNoallYSmtPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1cGMxQmhjblJ1WlhJb0tTQjhmQ0IwYUdsekxtbHpRMkZ5WkU5M2JtVnlLR05oY21RcExDQW5VMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVKeWtLSUNBZ0lHTmhiR3h6ZFdJZ2FYTlFZWEowYm1WeUNpQWdJQ0JpYm5vZ1kyRnlaRU5zYjNObFgySnZiMnhmZEhKMVpVQXpDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnYVhORFlYSmtUM2R1WlhJS0lDQWdJR0o2SUdOaGNtUkRiRzl6WlY5aWIyOXNYMlpoYkhObFFEUUtDbU5oY21SRGJHOXpaVjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwallYSmtRMnh2YzJWZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkRZS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtbHpVR0Z5ZEc1bGNpZ3BJSHg4SUhSb2FYTXVhWE5EWVhKa1QzZHVaWElvWTJGeVpDa3NJQ2RUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFuS1FvZ0lDQWdZWE56WlhKMElDOHZJRk5GVGtSRlVsOU9UMVJmUVV4TVQxZEZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa2N5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQkRZWEprUkdGMFlUNG9leUJyWlhsUWNtVm1hWGc2SUNkalppY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU5tSWdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBORGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1OaGNtUnpLR05oY21RcExtVjRhWE4wY3l3Z0owTkJVa1JmVGs5VVgwWlBWVTVFSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1EwRlNSRjlPVDFSZlJrOVZUa1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRVeENpQWdJQ0F2THlCMGFHbHpMbU5zWldGeVYybDBhR1J5WVhkaGJGSmxjWFZsYzNRb2RHaHBjeTVqWVhKa2N5aGpZWEprS1M1MllXeDFaUzV2ZDI1bGNpd2dZMkZ5WkNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJR05zWldGeVYybDBhR1J5WVhkaGJGSmxjWFZsYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVTFMVFEyTWdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlPaUJqWVhKa0xBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ1kyeHZjMlZTWlcxaGFXNWtaWEpVYnpvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5UZ0tJQ0FnSUM4dklISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJNQW9nSUNBZ0x5OGdZMnh2YzJWU1pXMWhhVzVrWlhKVWJ6b2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTJ4dmMyVlNaVzFoYVc1a1pYSlVid29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTlRrS0lDQWdJQzh2SUdGdGIzVnVkRG9nTUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFUxTFRRMk1Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lDQWdZMnh2YzJWU1pXMWhhVzVrWlhKVWJ6b2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMU5TMDBOaklLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMk5Rb2dJQ0FnTHk4Z2RHaHBjeTVqWVhKa2N5aGpZWEprS1M1a1pXeGxkR1VvS1FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJPQW9nSUNBZ0x5OGdkR2hwY3k1allYSmtjMTloWTNScGRtVmZZMjkxYm5RdWRtRnNkV1VnUFNCMGFHbHpMbU5oY21SelgyRmpkR2wyWlY5amIzVnVkQzUyWVd4MVpTQXRJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTkFvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SelgyRmpkR2wyWlY5amIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkalptRmpKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWTJaaFl5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFk0Q2lBZ0lDQXZMeUIwYUdsekxtTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDNTJZV3gxWlNBOUlIUm9hWE11WTJGeVpITmZZV04wYVhabFgyTnZkVzUwTG5aaGJIVmxJQzBnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFOQW9nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RqWm1Gakp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZMlpoWXlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWTRDaUFnSUNBdkx5QjBhR2x6TG1OaGNtUnpYMkZqZEdsMlpWOWpiM1Z1ZEM1MllXeDFaU0E5SUhSb2FYTXVZMkZ5WkhOZllXTjBhWFpsWDJOdmRXNTBMblpoYkhWbElDMGdNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRRMUNpQWdJQ0F2THlCd2RXSnNhV01nWTJGeVpFTnNiM05sS0dOaGNtUTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU5oY21SRGJHOXpaVjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJqWVhKa1EyeHZjMlZmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTVqWVhKa1VtVmpiM1psY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTmhjbVJTWldOdmRtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTnpnS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa1VtVmpiM1psY2loallYSmtPaUJCWTJOdmRXNTBMQ0J1WlhkRFlYSmtTRzlzWkdWeU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME56a0tJQ0FnSUM4dklIUm9hWE11YjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTWdvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lFTmhjbVJFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJObUp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMllpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRNQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WTJGeVpITW9ZMkZ5WkNrdVpYaHBjM1J6TENBblEwRlNSRjlPVDFSZlJrOVZUa1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRFFWSkVYMDVQVkY5R1QxVk9SQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0RJS0lDQWdJQzh2SUdOdmJuTjBJRzlzWkVOaGNtUkliMnhrWlhJZ1BTQjBhR2x6TG1OaGNtUnpLR05oY21RcExuWmhiSFZsTG05M2JtVnlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE0TmdvZ0lDQWdMeThnZEdocGN5NWpiR1ZoY2xkcGRHaGtjbUYzWVd4U1pYRjFaWE4wS0c5c1pFTmhjbVJJYjJ4a1pYSXNJR05oY21RcENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMENpQWdJQ0JqWVd4c2MzVmlJR05zWldGeVYybDBhR1J5WVhkaGJGSmxjWFZsYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EZzRDaUFnSUNBdkx5QjBhR2x6TG1OaGNtUnpLR05oY21RcExuWmhiSFZsTG05M2JtVnlJRDBnYm1WM1EyRnlaRWh2YkdSbGNnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1JwWnlBekNpQWdJQ0JpYjNoZmNtVndiR0ZqWlNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT1RBdE5EazBDaUFnSUNBdkx5QmxiV2wwUEVOaGNtUlNaV052ZG1WeVpXUStLSHNLSUNBZ0lDOHZJQ0FnWTJGeVpEb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ2IyeGtRMkZ5WkU5M2JtVnlPaUJ2YkdSRFlYSmtTRzlzWkdWeUxBb2dJQ0FnTHk4Z0lDQnVaWGREWVhKa1QzZHVaWEk2SUc1bGQwTmhjbVJJYjJ4a1pYSXNDaUFnSUNBdkx5QjlLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROR00zT0dNeU5EVWdMeThnYldWMGFHOWtJQ0pEWVhKa1VtVmpiM1psY21Wa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNPQW9nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJTWldOdmRtVnlLR05oY21RNklFRmpZMjkxYm5Rc0lHNWxkME5oY21SSWIyeGtaWEk2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtTmhjbVJFWldKcGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oY21SRVpXSnBkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBNUNpQWdJQ0F2THlCd2RXSnNhV01nWTJGeVpFUmxZbWwwS0dOaGNtUlBkMjVsY2pvZ1FXTmpiM1Z1ZEN3Z1kyRnlaRG9nUVdOamIzVnVkQ3dnWVhOelpYUTZJRUZ6YzJWMExDQmhiVzkxYm5RNklIVnBiblEyTkN3Z2JtOXVZMlU2SUhWcGJuUTJOQ3dnY21WbU9pQnpkSEpwYm1jcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11Y0dGMWMyVmtMblpoYkhWbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRjFjMlZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9LUW9nSUNBZ1lubDBaV01nTmlBdkx5QWljR0YxYzJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1d1lYVnpaV1F1ZG1Gc2RXVXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1gyOXdaWEpoZEc5eWN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDI5d0p5QjlLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkMjl3SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UUUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbmRwZEdoa2NtRjNYMjl3WlhKaGRHOXljeWhVZUc0dWMyVnVaR1Z5S1M1bGVHbHpkSE1zSUNkVFJVNUVSVkpmVGs5VVgwRk1URTlYUlVRbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56UUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDE5dmNHVnlZWFJ2Y25NZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dKM2R2Y0NjZ2ZTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuZHBkR2hrY21GM1gyOXdaWEpoZEc5eWN5aFVlRzR1YzJWdVpHVnlLUzVsZUdsemRITXNJQ2RUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFuS1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1UwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNZ29nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVOaGNtUkVZWFJoUGloN0lHdGxlVkJ5WldacGVEb2dKMk5tSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyWWlDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeE5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZMkZ5WkhNb1kyRnlaQ2t1ZG1Gc2RXVXViM2R1WlhJZ1BUMDlJR05oY21SUGQyNWxjaXdnSjA5WFRrVlNYMGxPVmtGTVNVUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBWMDVGVWw5SlRsWkJURWxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeE53b2dJQ0FnTHk4Z1kyOXVjM1FnYm1WNGRFNXZibU5sT2lCMWFXNTBOalFnUFNCMGFHbHpMbU5oY21SektHTmhjbVFwTG5aaGJIVmxMbTV2Ym1ObENpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENodVpYaDBUbTl1WTJVZ1BUMDlJRzV2Ym1ObExDQW5UazlPUTBWZlNVNVdRVXhKUkNjcENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTVQVGtORlgwbE9Wa0ZNU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USXdMVFV5T0FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeU9pQmpZWEprTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUhSb2FYTXViMjF1YVdKMWMxOWhaR1J5WlhOekxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCdWIzUmxPaUJ5WldZc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNak1LSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklIUm9hWE11YjIxdWFXSjFjMTloWkdSeVpYTnpMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3dDaUFnSUNBdkx5QndkV0pzYVdNZ2IyMXVhV0oxYzE5aFpHUnlaWE56SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklDZHZZU2NnZlNrS0lDQWdJR0o1ZEdWaklEY2dMeThnSW05aElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNak1LSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklIUm9hWE11YjIxdWFXSjFjMTloWkdSeVpYTnpMblpoYkhWbExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUU1dmRHVUtJQ0FnSUdScFp5QTFDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCa2FXY2dOZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1pHbG5JRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXlNQzAxTWpjS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCMGFHbHpMbTl0Ym1saWRYTmZZV1JrY21WemN5NTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVG9nY21WbUxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRJd0xUVXlPQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJSFJvYVhNdWIyMXVhV0oxYzE5aFpHUnlaWE56TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbE9pQnlaV1lzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTXdMVFV6TmdvZ0lDQWdMeThnWlcxcGREeEVaV0pwZEQ0b2V3b2dJQ0FnTHk4Z0lDQmpZWEprT2lCallYSmtMQW9nSUNBZ0x5OGdJQ0JoYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCdWIyNWpaVG9nYm05dVkyVXNDaUFnSUNBdkx5QWdJSEpsWm1WeVpXNWpaVG9nY21WbUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUROaENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPVGswWVRFek5qY2dMeThnYldWMGFHOWtJQ0pFWldKcGRDaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTXprS0lDQWdJQzh2SUhSb2FYTXVZMkZ5WkhNb1kyRnlaQ2t1ZG1Gc2RXVXVibTl1WTJVZ1BTQnVaWGgwVG05dVkyVWdLeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEE1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZMkZ5WkVSbFltbDBLR05oY21SUGQyNWxjam9nUVdOamIzVnVkQ3dnWTJGeVpEb2dRV05qYjNWdWRDd2dZWE56WlhRNklFRnpjMlYwTENCaGJXOTFiblE2SUhWcGJuUTJOQ3dnYm05dVkyVTZJSFZwYm5RMk5Dd2djbVZtT2lCemRISnBibWNwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtZGxkRTVsZUhSRFlYSmtUbTl1WTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJPWlhoMFEyRnlaRTV2Ym1ObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFORGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRU5oY21SRVlYUmhQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTm1KeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTJZaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFV3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1allYSmtjeWhqWVhKa0tTNTJZV3gxWlM1dWIyNWpaUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHVjRkSEpoWTNRZ05qUWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTkRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1WjJWMFEyRnlaRVJoZEdGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJEWVhKa1JHRjBZVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRVNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVElLSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCRFlYSmtSR0YwWVQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqWmljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTm1JZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMk1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZMkZ5WkhNb1kyRnlaQ2t1ZG1Gc2RXVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTV6WlhSUVlYSjBibVZ5UVdSa2NtVnpjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGQmhjblJ1WlhKQlpHUnlaWE56T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU56QUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlFZWEowYm1WeVFXUmtjbVZ6Y3lodVpYZFFZWEowYm1WeVFXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM01Rb2dJQ0FnTHk4Z2RHaHBjeTV2Ym14NVQzZHVaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQnZibXg1VDNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0Z5ZEc1bGNsOWhaR1J5WlhOeklEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCclpYazZJQ2R3WVNjZ2ZTa0tJQ0FnSUdKNWRHVmpJREV4SUM4dklDSndZU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjekNpQWdJQ0F2THlCMGFHbHpMbkJoY25SdVpYSmZZV1JrY21WemN5NTJZV3gxWlNBOUlHNWxkMUJoY25SdVpYSkJaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOekFLSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJRWVhKMGJtVnlRV1JrY21WemN5aHVaWGRRWVhKMGJtVnlRV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1YzJWMFQyMXVhV0oxYzBGa1pISmxjM05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUlBiVzVwWW5WelFXUmtjbVZ6Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZ3lDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBUMjF1YVdKMWMwRmtaSEpsYzNNb2JtVjNUMjF1YVdKMWMwRmtaSEpsYzNNNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9ETUtJQ0FnSUM4dklIUm9hWE11YjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTUFvZ0lDQWdMeThnY0hWaWJHbGpJRzl0Ym1saWRYTmZZV1JrY21WemN5QTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2EyVjVPaUFuYjJFbklIMHBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSnZZU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRnMUNpQWdJQ0F2THlCMGFHbHpMbTl0Ym1saWRYTmZZV1JrY21WemN5NTJZV3gxWlNBOUlHNWxkMDl0Ym1saWRYTkJaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPRElLSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJQYlc1cFluVnpRV1JrY21WemN5aHVaWGRQYlc1cFluVnpRV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1WVdSa1YybDBhR1J5WVhkUGNHVnlZWFJ2Y2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtaRmRwZEdoa2NtRjNUM0JsY21GMGIzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU1TkFvZ0lDQWdMeThnY0hWaWJHbGpJR0ZrWkZkcGRHaGtjbUYzVDNCbGNtRjBiM0lvYjNCbGNtRjBiM0k2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT1RVS0lDQWdJQzh2SUhSb2FYTXViMjVzZVU5M2JtVnlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2IyNXNlVTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1gyOXdaWEpoZEc5eWN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDI5d0p5QjlLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkMjl3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTVOd29nSUNBZ0x5OGdkR2hwY3k1M2FYUm9aSEpoZDE5dmNHVnlZWFJ2Y25Nb2IzQmxjbUYwYjNJcExuWmhiSFZsSUQwZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGswQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZV1JrVjJsMGFHUnlZWGRQY0dWeVlYUnZjaWh2Y0dWeVlYUnZjam9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFoYVc0dWNtVnRiM1psVjJsMGFHUnlZWGRQY0dWeVlYUnZjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGJXOTJaVmRwZEdoa2NtRjNUM0JsY21GMGIzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3TmdvZ0lDQWdMeThnY0hWaWJHbGpJSEpsYlc5MlpWZHBkR2hrY21GM1QzQmxjbUYwYjNJb2IzQmxjbUYwYjNJNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1EY0tJQ0FnSUM4dklIUm9hWE11YjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnY0hWaWJHbGpJSGRwZEdoa2NtRjNYMjl3WlhKaGRHOXljeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lBbmQyOXdKeUI5S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZDI5d0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3T1FvZ0lDQWdMeThnZEdocGN5NTNhWFJvWkhKaGQxOXZjR1Z5WVhSdmNuTW9iM0JsY21GMGIzSXBMbVJsYkdWMFpTZ3BDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpBMkNpQWdJQ0F2THlCd2RXSnNhV01nY21WdGIzWmxWMmwwYUdSeVlYZFBjR1Z5WVhSdmNpaHZjR1Z5WVhSdmNqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1WTJGeVpFUnBjMkZpYkdWQmMzTmxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OaGNtUkVhWE5oWW14bFFYTnpaWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeU1Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUkVhWE5oWW14bFFYTnpaWFFvWTJGeVpEb2dRV05qYjNWdWRDd2dZWE56WlhRNklFRnpjMlYwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qSXhDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVwYzFCaGNuUnVaWElvS1NCOGZDQjBhR2x6TG1selEyRnlaRTkzYm1WeUtHTmhjbVFwTENBblUwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUp5a0tJQ0FnSUdOaGJHeHpkV0lnYVhOUVlYSjBibVZ5Q2lBZ0lDQmlibm9nWTJGeVpFUnBjMkZpYkdWQmMzTmxkRjlpYjI5c1gzUnlkV1ZBTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlHbHpRMkZ5WkU5M2JtVnlDaUFnSUNCaWVpQmpZWEprUkdsellXSnNaVUZ6YzJWMFgySnZiMnhmWm1Gc2MyVkFOQW9LWTJGeVpFUnBjMkZpYkdWQmMzTmxkRjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwallYSmtSR2x6WVdKc1pVRnpjMlYwWDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakl4Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1cGMxQmhjblJ1WlhJb0tTQjhmQ0IwYUdsekxtbHpRMkZ5WkU5M2JtVnlLR05oY21RcExDQW5VMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVKeWtLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRSVTVFUlZKZlRrOVVYMEZNVEU5WFJVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZMkZ5WkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1EyRnlaRVJoZEdFK0tIc2dhMlY1VUhKbFptbDRPaUFuWTJZbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpaaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qSXlDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVqWVhKa2N5aGpZWEprS1M1bGVHbHpkSE1zSUNkRFFWSkVYMDVQVkY5R1QxVk9SQ2NwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRFFWSkVYMDVQVkY5R1QxVk9SQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRNdE1qVXhDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWEk2SUdOaGNtUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVOc2IzTmxWRzg2SUdOaGNtUXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJME9Rb2dJQ0FnTHk4Z1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJEYkc5elpWUnZDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalF6TFRJMU1Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlPaUJqWVhKa0xBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJEYkc5elpWUnZPaUJqWVhKa0xBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5ETXRNalV4Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFTnNiM05sVkc4NklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVE10TWpVMkNpQWdJQ0F2THlCbGJXbDBQRU5oY21SQmMzTmxkRVJwYzJGaWJHVmtQaWg3Q2lBZ0lDQXZMeUFnSUdOaGNtUTZJR05oY21Rc0NpQWdJQ0F2THlBZ0lHRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd1pEYzNaak14SUM4dklHMWxkR2h2WkNBaVEyRnlaRUZ6YzJWMFJHbHpZV0pzWldRb1lXUmtjbVZ6Y3l4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qSXdDaUFnSUNBdkx5QndkV0pzYVdNZ1kyRnlaRVJwYzJGaWJHVkJjM05sZENoallYSmtPaUJCWTJOdmRXNTBMQ0JoYzNObGREb2dRWE56WlhRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtTmhjbVJFYVhOaFlteGxRWE56WlhSZlltOXZiRjltWVd4elpVQTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1kyRnlaRVJwYzJGaWJHVkJjM05sZEY5aWIyOXNYMjFsY21kbFFEVUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5ZV2x1TG5kcGRHaGtjbUYzWVd4U1pYRjFaWE4wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2QybDBhR1J5WVhkaGJGSmxjWFZsYzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXpNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dXeWRPYjA5d0oxMGdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVElLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selEyRnlaRTkzYm1WeUtHTmhjbVFwTENBblUwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUp5a0tJQ0FnSUdScFp5QXlDaUFnSUNCallXeHNjM1ZpSUdselEyRnlaRTkzYm1WeUNpQWdJQ0JoYzNObGNuUWdMeThnVTBWT1JFVlNYMDVQVkY5QlRFeFBWMFZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRU5oY21SRVlYUmhQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTm1KeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTJZaUNpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6TmdvZ0lDQWdMeThnWTI5dWMzUWdZMkZ5WkVSaGRHRWdQU0JqYkc5dVpTaDBhR2x6TG1OaGNtUnpLR05oY21RcExuWmhiSFZsS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qTTNDaUFnSUNBdkx5QmpiMjV6ZENCYlltRnNZVzVqWlYwZ1BTQnZjQzVCYzNObGRFaHZiR1JwYm1jdVlYTnpaWFJDWVd4aGJtTmxLR05oY21Rc0lHRnpjMlYwS1FvZ0lDQWdaR2xuSURNS0lDQWdJR1JwWnlBekNpQWdJQ0JoYzNObGRGOW9iMnhrYVc1blgyZGxkQ0JCYzNObGRFSmhiR0Z1WTJVS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENoaGJXOTFiblFnUEQwZ1ltRnNZVzVqWlN3Z0owbE9VMVZHUmtsRFNVVk9WRjlDUVV4QlRrTkZKeWtLSUNBZ0lHUnBaeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFbE9VMVZHUmtsRFNVVk9WRjlDUVV4QlRrTkZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkwTWdvZ0lDQWdMeThnY21WamFYQnBaVzUwT2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5EVUtJQ0FnSUM4dklHTnlaV0YwWldSQmREb2dSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0N3S0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qUTJDaUFnSUNBdkx5QnViMjVqWlRvZ1kyRnlaRVJoZEdFdWQybDBhR1J5WVhkaGJFNXZibU5sTEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wSURjeUlEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalF3TFRZME53b2dJQ0FnTHk4Z1kyOXVjM1FnZDJsMGFHUnlZWGRoYkRvZ1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRZ1BTQjdDaUFnSUNBdkx5QWdJR05oY21RNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZERvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWTNKbFlYUmxaRUYwT2lCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdMQW9nSUNBZ0x5OGdJQ0J1YjI1alpUb2dZMkZ5WkVSaGRHRXVkMmwwYUdSeVlYZGhiRTV2Ym1ObExBb2dJQ0FnTHk4Z2ZRb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOQW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1lXeHpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRmRwZEdoa2NtRjNZV3hTWlhGMVpYTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZHlKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZDNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBPUW9nSUNBZ0x5OGdkR2hwY3k1M2FYUm9aSEpoZDJGc2N5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJR05zYjI1bEtIZHBkR2hrY21GM1lXd3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOQW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1lXeHpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRmRwZEdoa2NtRjNZV3hTWlhGMVpYTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZHlKeUI5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBPUW9nSUNBZ0x5OGdkR2hwY3k1M2FYUm9aSEpoZDJGc2N5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJR05zYjI1bEtIZHBkR2hrY21GM1lXd3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5URUtJQ0FnSUM4dklHVnRhWFE4VjJsMGFHUnlZWGRoYkZKbGNYVmxjM1ErS0hkcGRHaGtjbUYzWVd3cENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa09EVm1Oakl3WVNBdkx5QnRaWFJvYjJRZ0lsZHBkR2hrY21GM1lXeFNaWEYxWlhOMEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkT2IwOXdKMTBnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTllXbHVMbmRwZEdoa2NtRjNZV3hEWVc1alpXeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1pISmhkMkZzUTJGdVkyVnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmpBS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzUTJGdVkyVnNLR05oY21RNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9USUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbWx6UTJGeVpFOTNibVZ5S0dOaGNtUXBMQ0FuVTBWT1JFVlNYMDVQVkY5QlRFeFBWMFZFSnlrS0lDQWdJR05oYkd4emRXSWdhWE5EWVhKa1QzZHVaWElLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRSVTVFUlZKZlRrOVVYMEZNVEU5WFJVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZGhiSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVjJsMGFHUnlZWGRoYkZKbGNYVmxjM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQW5kM0luSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKM2NpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOall5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1M2FYUm9aSEpoZDJGc2N5aFVlRzR1YzJWdVpHVnlLUzVsZUdsemRITXNJQ2RYU1ZSSVJGSkJWMEZNWDFKRlVWVkZVMVJmVGs5VVgwWlBWVTVFSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZMENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZeUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1bGVHbHpkSE1zSUNkWFNWUklSRkpCVjBGTVgxSkZVVlZGVTFSZlRrOVVYMFpQVlU1RUp5a0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRmRKVkVoRVVrRlhRVXhmVWtWUlZVVlRWRjlPVDFSZlJrOVZUa1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZMENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZekNpQWdJQ0F2THlCamIyNXpkQ0IzYVhSb1pISmhkMkZzSUQwZ1kyeHZibVVvZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZGhiSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVjJsMGFHUnlZWGRoYkZKbGNYVmxjM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQW5kM0luSUgwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOall6Q2lBZ0lDQXZMeUJqYjI1emRDQjNhWFJvWkhKaGQyRnNJRDBnWTJ4dmJtVW9kR2hwY3k1M2FYUm9aSEpoZDJGc2N5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTkFvZ0lDQWdMeThnY0hWaWJHbGpJSGRwZEdoa2NtRjNZV3h6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUZkcGRHaGtjbUYzWVd4U1pYRjFaWE4wUGloN0lHdGxlVkJ5WldacGVEb2dKM2R5SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWQzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyTkFvZ0lDQWdMeThnZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1a1pXeGxkR1VvS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpRS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCWGFYUm9aSEpoZDJGc1VtVnhkV1Z6ZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2QzY2ljZ2ZTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmpRS0lDQWdJQzh2SUhSb2FYTXVkMmwwYUdSeVlYZGhiSE1vVkhodUxuTmxibVJsY2lrdVpHVnNaWFJsS0NrS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOalVLSUNBZ0lDOHZJR1Z0YVhROFYybDBhR1J5WVhkaGJGSmxjWFZsYzNSRFlXNWpaV3hzWldRK0tIZHBkR2hrY21GM1lXd3BDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURZMElEZ0tJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURjeUlEZ0tJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURnd0lEZ0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdaWGgwY21GamRDQTRPQ0E0Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJRzFsZEdodlpDQWlWMmwwYUdSeVlYZGhiRkpsY1hWbGMzUkRZVzVqWld4c1pXUW9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmpBS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzUTJGdVkyVnNLR05oY21RNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTllXbHVMbmRwZEdoa2NtRjNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZDJsMGFHUnlZWGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZM01nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZE9iMDl3SjEwZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RJS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtbHpRMkZ5WkU5M2JtVnlLR05oY21RcExDQW5VMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVKeWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHbHpRMkZ5WkU5M2JtVnlDaUFnSUNCaGMzTmxjblFnTHk4Z1UwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOQW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1lXeHpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRmRwZEdoa2NtRjNZV3hTWlhGMVpYTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZHlKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZDNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNOUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11ZDJsMGFHUnlZWGRoYkhNb1ZIaHVMbk5sYm1SbGNpa3VaWGhwYzNSekxDQW5WMGxVU0VSU1FWZEJURjlTUlZGVlJWTlVYMDVQVkY5R1QxVk9SQ2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTkFvZ0lDQWdMeThnY0hWaWJHbGpJSGRwZEdoa2NtRjNZV3h6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUZkcGRHaGtjbUYzWVd4U1pYRjFaWE4wUGloN0lHdGxlVkJ5WldacGVEb2dKM2R5SnlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzTlFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWQybDBhR1J5WVhkaGJITW9WSGh1TG5ObGJtUmxjaWt1WlhocGMzUnpMQ0FuVjBsVVNFUlNRVmRCVEY5U1JWRlZSVk5VWDA1UFZGOUdUMVZPUkNjcENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlhTVlJJUkZKQlYwRk1YMUpGVVZWRlUxUmZUazlVWDBaUFZVNUVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTWdvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lFTmhjbVJFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJObUp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMllpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNOZ29nSUNBZ0x5OGdZMjl1YzNRZ1kyRnlaRVJoZEdFZ1BTQmpiRzl1WlNoMGFHbHpMbU5oY21SektHTmhjbVFwTG5aaGJIVmxLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZMENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjM0NpQWdJQ0F2THlCamIyNXpkQ0IzYVhSb1pISmhkMkZzSUQwZ1kyeHZibVVvZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZGhiSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVjJsMGFHUnlZWGRoYkZKbGNYVmxjM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQW5kM0luSUgwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamMzQ2lBZ0lDQXZMeUJqYjI1emRDQjNhWFJvWkhKaGQyRnNJRDBnWTJ4dmJtVW9kR2hwY3k1M2FYUm9aSEpoZDJGc2N5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzT0FvZ0lDQWdMeThnWVhOelpYSjBLR0Z0YjNWdWRDQThQU0IzYVhSb1pISmhkMkZzTG1GdGIzVnVkQ3dnSjBGTlQxVk9WRjlKVGxaQlRFbEVKeWtLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBM01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXpDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVGTlQxVk9WRjlKVGxaQlRFbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzT1FvZ0lDQWdMeThnWVhOelpYSjBLR05oY21SRVlYUmhMbmRwZEdoa2NtRjNZV3hPYjI1alpTQTlQVDBnZDJsMGFHUnlZWGRoYkM1dWIyNWpaU3dnSjA1UFRrTkZYMGxPVmtGTVNVUW5LUW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBM01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURnNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVGs5T1EwVmZTVTVXUVV4SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPREFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDNhWFJvWkhKaGQyRnNMbU5oY21RZ1BUMDlJR05oY21Rc0lDZERRVkpFWDAxSlUwMUJWRU5JSnlrS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR1JwWnlBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRU5CVWtSZlRVbFRUVUZVUTBnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZ3lDaUFnSUNBdkx5QmpiMjV6ZENCeVpXeGxZWE5sVkdsdFpUb2dkV2x1ZERZMElEMGdkMmwwYUdSeVlYZGhiQzVqY21WaGRHVmtRWFFnS3lCMGFHbHpMbmRwZEdoa2NtRjNZV3hmZDJGcGRGOTBhVzFsTG5aaGJIVmxDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBNE1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFOd29nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1lXeGZkMkZwZEY5MGFXMWxJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNkM2RDY2dmU2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbmQzZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZ3lDaUFnSUNBdkx5QmpiMjV6ZENCeVpXeGxZWE5sVkdsdFpUb2dkV2x1ZERZMElEMGdkMmwwYUdSeVlYZGhiQzVqY21WaGRHVmtRWFFnS3lCMGFHbHpMbmRwZEdoa2NtRjNZV3hmZDJGcGRGOTBhVzFsTG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZ3pDaUFnSUNBdkx5QmhjM05sY25Rb1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ0ErUFNCeVpXeGxZWE5sVkdsdFpTd2dKMWRKVkVoRVVrRlhRVXhmVkVsTlJWOUpUbFpCVEVsRUp5a0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVjBsVVNFUlNRVmRCVEY5VVNVMUZYMGxPVmtGTVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamc0Q2lBZ0lDQXZMeUIzYVhSb1pISmhkMkZzTG1GemMyVjBMQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9EWXROamt6Q2lBZ0lDQXZMeUIwYUdsekxuZHBkR2hrY21GM1JuVnVaSE1vQ2lBZ0lDQXZMeUFnSUdOaGNtUXNDaUFnSUNBdkx5QWdJSGRwZEdoa2NtRjNZV3d1WVhOelpYUXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdkMmwwYUdSeVlYZGhiQzVqY21WaGRHVmtRWFFzQ2lBZ0lDQXZMeUFnSUhkcGRHaGtjbUYzWVd3dWJtOXVZMlVzQ2lBZ0lDQXZMeUFnSUZkcGRHaGtjbUYzWVd4VWVYQmxVR1Z5YldsemMybHZia3hsYzNNc0NpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamt5Q2lBZ0lDQXZMeUJYYVhSb1pISmhkMkZzVkhsd1pWQmxjbTFwYzNOcGIyNU1aWE56TEFvZ0lDQWdZbmwwWldNZ01UTWdMeThnSW5CbGNtMXBjM05wYjI1c1pYTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT0RZdE5qa3pDaUFnSUNBdkx5QjBhR2x6TG5kcGRHaGtjbUYzUm5WdVpITW9DaUFnSUNBdkx5QWdJR05oY21Rc0NpQWdJQ0F2THlBZ0lIZHBkR2hrY21GM1lXd3VZWE56WlhRc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ2QybDBhR1J5WVhkaGJDNWpjbVZoZEdWa1FYUXNDaUFnSUNBdkx5QWdJSGRwZEdoa2NtRjNZV3d1Ym05dVkyVXNDaUFnSUNBdkx5QWdJRmRwZEdoa2NtRjNZV3hVZVhCbFVHVnliV2x6YzJsdmJreGxjM01zQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpZV3hzYzNWaUlIZHBkR2hrY21GM1JuVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZMENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmprMENpQWdJQ0F2THlCMGFHbHpMbmRwZEdoa2NtRjNZV3h6S0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhkcGRHaGtjbUYzWVd4eklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lGZHBkR2hrY21GM1lXeFNaWEYxWlhOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNkeUp5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNU5Bb2dJQ0FnTHk4Z2RHaHBjeTUzYVhSb1pISmhkMkZzY3loVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkT2IwOXdKMTBnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTllXbHVMbmRwZEdoa2NtRjNVR1Z5YldsemMybHZibVZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2QybDBhR1J5WVhkUVpYSnRhWE56YVc5dVpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN3TlMwM01USUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDFCbGNtMXBjM05wYjI1bFpDZ0tJQ0FnSUM4dklDQWdZMkZ5WkRvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1lYTnpaWFE2SUVGemMyVjBMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdaWGh3YVhKbGMwRjBPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJRzV2Ym1ObE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lITnBaMjVoZEhWeVpUb2dZbmwwWlhNOE5qUStMQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTJDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURZMFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVElLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selEyRnlaRTkzYm1WeUtHTmhjbVFwTENBblUwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUp5a0tJQ0FnSUdScFp5QXlDaUFnSUNCallXeHNjM1ZpSUdselEyRnlaRTkzYm1WeUNpQWdJQ0JoYzNObGNuUWdMeThnVTBWT1JFVlNYMDVQVkY5QlRFeFBWMFZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRU5oY21SRVlYUmhQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTm1KeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTJZaUNpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN4TkFvZ0lDQWdMeThnWTI5dWMzUWdZMkZ5WkVSaGRHRWdQU0JqYkc5dVpTaDBhR2x6TG1OaGNtUnpLR05oY21RcExuWmhiSFZsS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56RTJDaUFnSUNBdkx5QmhjM05sY25Rb1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ0E4SUdWNGNHbHlaWE5CZEN3Z0oxZEpWRWhFVWtGWFFVeGZWRWxOUlY5SlRsWkJURWxFSnlrS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR1JwWnlBekNpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdWMGxVU0VSU1FWZEJURjlVU1UxRlgwbE9Wa0ZNU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56RTNDaUFnSUNBdkx5QmhjM05sY25Rb1kyRnlaRVJoZEdFdWQybDBhR1J5WVhkaGJFNXZibU5sSUQwOVBTQnViMjVqWlN3Z0owNVBUa05GWDBsT1ZrRk1TVVFuS1FvZ0lDQWdjSFZ6YUdsdWRDQTNNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTndvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUazlPUTBWZlNVNVdRVXhKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01qRUtJQ0FnSUM4dklISmxZMmx3YVdWdWREb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOekkyQ2lBZ0lDQXZMeUJuWlc1bGMybHpTR0Z6YURvZ1IyeHZZbUZzTG1kbGJtVnphWE5JWVhOb0xBb2dJQ0FnWjJ4dlltRnNJRWRsYm1WemFYTklZWE5vQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjeE9TMDNNamNLSUNBZ0lDOHZJR052Ym5OMElIZHBkR2hrY21GM1lXdzZJRkJsY20xcGMzTnBiMjVsWkZkcGRHaGtjbUYzWVd3Z1BTQjdDaUFnSUNBdkx5QWdJR05oY21Rc0NpQWdJQ0F2THlBZ0lISmxZMmx3YVdWdWREb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdaWGh3YVhKbGMwRjBMQW9nSUNBZ0x5OGdJQ0J1YjI1alpTd0tJQ0FnSUM4dklDQWdaMlZ1WlhOcGMwaGhjMmc2SUVkc2IySmhiQzVuWlc1bGMybHpTR0Z6YUN3S0lDQWdJQzh2SUgwS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpJNUNpQWdJQ0F2THlCamIyNXpkQ0IzYVhSb1pISmhkMkZzWDJoaGMyZ2dQU0J2Y0M1emFHRXlOVFlvWVhKak5DNWxibU52WkdWQmNtTTBLSGRwZEdoa2NtRjNZV3dwS1FvZ0lDQWdjMmhoTWpVMkNncDNhWFJvWkhKaGQxQmxjbTFwYzNOcGIyNWxaRjkzYUdsc1pWOTBiM0JBTlRvS0lDQWdJSEIxYzJocGJuUWdNalV4TUFvZ0lDQWdaMnh2WW1Gc0lFOXdZMjlrWlVKMVpHZGxkQW9nSUNBZ1Bnb2dJQ0FnWW5vZ2QybDBhR1J5WVhkUVpYSnRhWE56YVc5dVpXUmZZV1owWlhKZmQyaHBiR1ZBTVRBS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEVWdMeThnUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmllWFJsWXlBeE5DQXZMeUF3ZURBMk9ERXdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcwS0lDQWdJR0o1ZEdWaklERTBJQzh2SURCNE1EWTRNVEF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpSUhkcGRHaGtjbUYzVUdWeWJXbHpjMmx2Ym1Wa1gzZG9hV3hsWDNSdmNFQTFDZ3AzYVhSb1pISmhkMUJsY20xcGMzTnBiMjVsWkY5aFpuUmxjbDkzYUdsc1pVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpNMENpQWdJQ0F2THlCaGMzTmxjblFvYjNBdVpXUXlOVFV4T1habGNtbG1lVUpoY21Vb2QybDBhR1J5WVhkaGJGOW9ZWE5vTENCemFXZHVZWFIxY21Vc0lIUm9hWE11ZDJsMGFHUnlZWGRoYkY5d2RXSnJaWGt1ZG1Gc2RXVXBMQ0FuVTBsSFRrRlVWVkpGWDBsT1ZrRk1TVVFuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZd0NpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkY5d2RXSnJaWGtnUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3p3ek1qNCtLSHNnYTJWNU9pQW5jSGR3YXljZ2ZTa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSndkM0JySWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM016UUtJQ0FnSUM4dklHRnpjMlZ5ZENodmNDNWxaREkxTlRFNWRtVnlhV1o1UW1GeVpTaDNhWFJvWkhKaGQyRnNYMmhoYzJnc0lITnBaMjVoZEhWeVpTd2dkR2hwY3k1M2FYUm9aSEpoZDJGc1gzQjFZbXRsZVM1MllXeDFaU2tzSUNkVFNVZE9RVlJWVWtWZlNVNVdRVXhKUkNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWldReU5UVXhPWFpsY21sbWVWOWlZWEpsQ2lBZ0lDQmhjM05sY25RZ0x5OGdVMGxIVGtGVVZWSkZYMGxPVmtGTVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek0zQ2lBZ0lDQXZMeUIwYUdsekxuZHBkR2hrY21GM1JuVnVaSE1vWTJGeVpDd2dZWE56WlhRc0lHRnRiM1Z1ZEN3Z1pYaHdhWEpsYzBGMExDQmpZWEprUkdGMFlTNTNhWFJvWkhKaGQyRnNUbTl1WTJVc0lGZHBkR2hrY21GM1lXeFVlWEJsUVhCd2NtOTJaV1FwQ2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpWVhCd2NtOTJaV1FpQ2lBZ0lDQmpZV3hzYzNWaUlIZHBkR2hrY21GM1JuVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZMENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpReUNpQWdJQ0F2THlCcFppQW9kR2hwY3k1M2FYUm9aSEpoZDJGc2N5aFVlRzR1YzJWdVpHVnlLUzVsZUdsemRITXBJSHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZGhiSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVjJsMGFHUnlZWGRoYkZKbGNYVmxjM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQW5kM0luSUgwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelF5Q2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTUzYVhSb1pISmhkMkZzY3loVWVHNHVjMlZ1WkdWeUtTNWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nZDJsMGFHUnlZWGRRWlhKdGFYTnphVzl1WldSZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhkcGRHaGtjbUYzWVd4eklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lGZHBkR2hrY21GM1lXeFNaWEYxWlhOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNkeUp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkM0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjME13b2dJQ0FnTHk4Z2RHaHBjeTUzYVhSb1pISmhkMkZzY3loVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qUUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDJGc2N5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQlhhWFJvWkhKaGQyRnNVbVZ4ZFdWemRENG9leUJyWlhsUWNtVm1hWGc2SUNkM2NpY2dmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05ETUtJQ0FnSUM4dklIUm9hWE11ZDJsMGFHUnlZWGRoYkhNb1ZIaHVMbk5sYm1SbGNpa3VaR1ZzWlhSbEtDa0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9LZDJsMGFHUnlZWGRRWlhKdGFYTnphVzl1WldSZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01EVXROekV5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZFFaWEp0YVhOemFXOXVaV1FvQ2lBZ0lDQXZMeUFnSUdOaGNtUTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJR0Z6YzJWME9pQkJjM05sZEN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdWNGNHbHlaWE5CZERvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCdWIyNWpaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J6YVdkdVlYUjFjbVU2SUdKNWRHVnpQRFkwUGl3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02T2s5M2JtRmliR1V1YjNkdVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2ZDI1bGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIQjFZbXhwWXlCZmIzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmZiM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVmYjNkdVpYSXVkbUZzZFdVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qcFBkMjVoWW14bExuUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPamt4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQW9ibVYzVDNkdVpYSTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdkR2hwY3k1dmJteDVUM2R1WlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJ2Ym14NVQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02T1RRS0lDQWdJQzh2SUhSb2FYTXVYM1J5WVc1elptVnlUM2R1WlhKemFHbHdLRzVsZDA5M2JtVnlLUW9nSUNBZ1kyRnNiSE4xWWlCZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklIQjFZbXhwWXlCMGNtRnVjMlpsY2s5M2JtVnljMmhwY0NodVpYZFBkMjVsY2pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pwUVlYVnpZV0pzWlM1d1lYVnpaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd1lYVnpaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVYM0JoZFhObGNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCd2RXSnNhV01nWDNCaGRYTmxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lsOXdZWFZ6WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WDNCaGRYTmxjaTUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRjFjMlZ5S0NrNklFRmpZMjkxYm5RZ2V3b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qcFFZWFZ6WVdKc1pTNXdZWFZ6WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQmhkWE5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklIUm9hWE11YjI1c2VWQmhkWE5sY2lncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsUVlYVnpaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCd2RXSnNhV01nY0dGMWMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFltOXZiR1ZoYmo0b0tRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWNHRjFjMlZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk5qa0tJQ0FnSUM4dklIUm9hWE11Y0dGMWMyVmtMblpoYkhWbElEMGdkSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z1pXMXBkRHhRWVhWelpUNG9lMzBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqWmpJellUTXdaZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZFhObEtDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qcFFZWFZ6WVdKc1pTNTFibkJoZFhObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkVzV3WVhWelpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamMzQ2lBZ0lDQXZMeUIwYUdsekxtOXViSGxRWVhWelpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCdmJteDVVR0YxYzJWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdjSFZpYkdsaklIQmhkWE5sWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLQ2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbkJoZFhObFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamM1Q2lBZ0lDQXZMeUIwYUdsekxuQmhkWE5sWkM1MllXeDFaU0E5SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUJsYldsMFBGVnVjR0YxYzJVK0tIdDlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZakUyTTJWbE1HSUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJSEIxWW14cFl5QjFibkJoZFhObEtDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qcFFZWFZ6WVdKc1pTNTFjR1JoZEdWUVlYVnpaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZRWVhWelpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnY0hWaWJHbGpJSFZ3WkdGMFpWQmhkWE5sY2loZmJtVjNVR0YxYzJWeU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qZzNDaUFnSUNBdkx5QjBhR2x6TG05dWJIbFFZWFZ6WlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJ2Ym14NVVHRjFjMlZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvNE9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0Y5dVpYZFFZWFZ6WlhJZ0lUMDlJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeWtLSUNBZ0lHUjFjQW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdjSFZpYkdsaklGOXdZWFZ6WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pmY0dGMWMyVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02T1RBS0lDQWdJQzh2SUhSb2FYTXVYM0JoZFhObGNpNTJZV3gxWlNBOUlGOXVaWGRRWVhWelpYSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUdWdGFYUThVR0YxYzJWeVEyaGhibWRsWkQ0b2V5QnVaWGRCWkdSeVpYTnpPaUIwYUdsekxsOXdZWFZ6WlhJdWRtRnNkV1VnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdOak5EQTVNak5qSUM4dklHMWxkR2h2WkNBaVVHRjFjMlZ5UTJoaGJtZGxaQ2hoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvNE5nb2dJQ0FnTHk4Z2NIVmliR2xqSUhWd1pHRjBaVkJoZFhObGNpaGZibVYzVUdGMWMyVnlPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0psWTI5MlpYSmhZbXhsTG1Gc1oyOHVkSE02T2xKbFkyOTJaWEpoWW14bExuSmxZMjkyWlhKQmMzTmxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyOTJaWEpCYzNObGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl5WldOdmRtVnlZV0pzWlM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCd2RXSnNhV01nY21WamIzWmxja0Z6YzJWMEtHRnpjMlYwT2lCQmMzTmxkQ3dnWVcxdmRXNTBPaUIxYVc1ME5qUXNJSEpsWTJsd2FXVnVkRG9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5eVpXTnZkbVZ5WVdKc1pTNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QjBhR2x6TG05dWJIbFBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNKbFkyOTJaWEpoWW14bExtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklHbG1JQ2hoYzNObGRDNXBaQ2tnZXdvZ0lDQWdZbm9nY21WamIzWmxja0Z6YzJWMFgyVnNjMlZmWW05a2VVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y21WamIzWmxjbUZpYkdVdVlXeG5ieTUwY3pvME1pMDBPQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQnlaV05wY0dsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNtVmpiM1psY21GaWJHVXVZV3huYnk1MGN6bzBNaTAwTndvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJ5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y21WamIzWmxjbUZpYkdVdVlXeG5ieTUwY3pvME1pMDBPQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQnlaV05wY0dsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS2NtVmpiM1psY2tGemMyVjBYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl5WldOdmRtVnlZV0pzWlM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCd2RXSnNhV01nY21WamIzWmxja0Z6YzJWMEtHRnpjMlYwT2lCQmMzTmxkQ3dnWVcxdmRXNTBPaUIxYVc1ME5qUXNJSEpsWTJsd2FXVnVkRG9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY21WamIzWmxja0Z6YzJWMFgyVnNjMlZmWW05a2VVQTBPZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNtVmpiM1psY21GaWJHVXVZV3huYnk1MGN6bzFNQzAxTlFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0psWTI5MlpYSmhZbXhsTG1Gc1oyOHVkSE02TlRBdE5UUUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQnlaV05wY0dsbGJuUXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjbVZqYjNabGNtRmliR1V1WVd4bmJ5NTBjem8xTUMwMU5Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklISmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lpQnlaV052ZG1WeVFYTnpaWFJmWVdaMFpYSmZhV1pmWld4elpVQTJDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV0ZwYmk1cGMwTmhjbVJQZDI1bGNpaGpZWEprT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwcGMwTmhjbVJQZDI1bGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd5Q2lBZ0lDQXZMeUJ3Y21sMllYUmxJR2x6UTJGeVpFOTNibVZ5S0dOaGNtUTZJRUZqWTI5MWJuUXBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVElLSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCRFlYSmtSR0YwWVQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqWmljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTm1JZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnekNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWpZWEprY3loallYSmtLUzVsZUdsemRITXNJQ2REUVZKRVgwNVBWRjlHVDFWT1JDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5CVWtSZlRrOVVYMFpQVlU1RUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WTJGeVpITW9ZMkZ5WkNrdWRtRnNkV1V1YjNkdVpYSWdQVDA5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdGcGJpNXBjMUJoY25SdVpYSW9LU0F0UGlCMWFXNTBOalE2Q21selVHRnlkRzVsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQXdDaUFnSUNBdkx5QnlaWFIxY200Z1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NXdZWEowYm1WeVgyRmtaSEpsYzNNdWRtRnNkV1VLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOd29nSUNBZ0x5OGdjSFZpYkdsaklIQmhjblJ1WlhKZllXUmtjbVZ6Y3lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYTJWNU9pQW5jR0VuSUgwcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWNHRWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TUFvZ0lDQWdMeThnY21WMGRYSnVJRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11Y0dGeWRHNWxjbDloWkdSeVpYTnpMblpoYkhWbENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxaGFXNHVZMkZ5WkVGemMyVjBUM0IwU1c0b1kyRnlaRG9nWW5sMFpYTXNJR0Z6YzJWME9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuTnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFoYVc0dVkyRnlaRUZ6YzJWMFQzQjBTVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU13b2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUkJjM05sZEU5d2RFbHVLR05oY21RNklFRmpZMjkxYm5Rc0lHRnpjMlYwT2lCQmMzTmxkQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YVhOUVlYSjBibVZ5S0Nrc0lDZFRSVTVFUlZKZlRrOVVYMEZNVEU5WFJVUW5LUW9nSUNBZ1kyRnNiSE4xWWlCcGMxQmhjblJ1WlhJS0lDQWdJR0Z6YzJWeWRDQXZMeUJUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVeUNpQWdJQ0F2THlCd2RXSnNhV01nWTJGeVpITWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dRMkZ5WkVSaGRHRStLSHNnYTJWNVVISmxabWw0T2lBblkyWW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqWmlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlOUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WTJGeVpITW9ZMkZ5WkNrdVpYaHBjM1J6TENBblEwRlNSRjlPVDFSZlJrOVZUa1FuS1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1EwRlNSRjlPVDFSZlJrOVZUa1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJM0xUSXpOQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJR05oY21Rc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TWdvZ0lDQWdMeThnWVhOelpYUkJiVzkxYm5RNklEQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakkzTFRJek13b2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlPaUJqWVhKa0xBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TnkweU16UUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQmpZWEprTEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0yTFRJek9Rb2dJQ0FnTHk4Z1pXMXBkRHhEWVhKa1FYTnpaWFJGYm1GaWJHVmtQaWg3Q2lBZ0lDQXZMeUFnSUdOaGNtUTZJR05oY21Rc0NpQWdJQ0F2THlBZ0lHRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTnpFNVkyVmtNU0F2THlCdFpYUm9iMlFnSWtOaGNtUkJjM05sZEVWdVlXSnNaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxaGFXNHVZMnhsWVhKWGFYUm9aSEpoZDJGc1VtVnhkV1Z6ZENodmQyNWxjam9nWW5sMFpYTXNJR05oY21RNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwamJHVmhjbGRwZEdoa2NtRjNZV3hTWlhGMVpYTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TnpRS0lDQWdJQzh2SUhCeWFYWmhkR1VnWTJ4bFlYSlhhWFJvWkhKaGQyRnNVbVZ4ZFdWemRDaHZkMjVsY2pvZ1FXTmpiM1Z1ZEN3Z1kyRnlaRG9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOQW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1lXeHpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRmRwZEdoa2NtRjNZV3hTWlhGMVpYTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZHlKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZDNJaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNOUW9nSUNBZ0x5OGdhV1lnS0hSb2FYTXVkMmwwYUdSeVlYZGhiSE1vYjNkdVpYSXBMbVY0YVhOMGN5QW1KaUIwYUdsekxuZHBkR2hrY21GM1lXeHpLRzkzYm1WeUtTNTJZV3gxWlM1allYSmtJRDA5UFNCallYSmtLU0I3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHTnNaV0Z5VjJsMGFHUnlZWGRoYkZKbGNYVmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJ4bFlYSlhhWFJvWkhKaGQyRnNVbVZ4ZFdWemRGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qYzJDaUFnSUNBdkx5QmpiMjV6ZENCM2FYUm9aSEpoZDJGc0lEMGdZMnh2Ym1Vb2RHaHBjeTUzYVhSb1pISmhkMkZzY3lodmQyNWxjaWt1ZG1Gc2RXVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOemNLSUNBZ0lDOHZJSFJvYVhNdWQybDBhR1J5WVhkaGJITW9iM2R1WlhJcExtUmxiR1YwWlNncENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamM0Q2lBZ0lDQXZMeUJsYldsMFBGZHBkR2hrY21GM1lXeFNaWEYxWlhOMFEyRnVZMlZzYkdWa1BpaDNhWFJvWkhKaGQyRnNLUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBMk5DQTRDaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBM01pQTRDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBNE1DQTRDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR1Y0ZEhKaFkzUWdPRGdnT0FvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUJ0WlhSb2IyUWdJbGRwZEdoa2NtRjNZV3hTWlhGMVpYTjBRMkZ1WTJWc2JHVmtLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLQ21Oc1pXRnlWMmwwYUdSeVlYZGhiRkpsY1hWbGMzUmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV0ZwYmk1M2FYUm9aSEpoZDBaMWJtUnpLR05oY21RNklHSjVkR1Z6TENCaGMzTmxkRG9nZFdsdWREWTBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5Dd2dkR2x0WlhOMFlXMXdPaUIxYVc1ME5qUXNJRzV2Ym1ObE9pQjFhVzUwTmpRc0lIZHBkR2hrY21GM1lXeFVlWEJsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZDJsMGFHUnlZWGRHZFc1a2N6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamd5TFRJNE9Rb2dJQ0FnTHk4Z2NISnBkbUYwWlNCM2FYUm9aSEpoZDBaMWJtUnpLQW9nSUNBZ0x5OGdJQ0JqWVhKa09pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmhjM05sZERvZ1FYTnpaWFFzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0IwYVcxbGMzUmhiWEE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYm05dVkyVTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdkMmwwYUdSeVlYZGhiRlI1Y0dVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z05pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1TVFvZ0lDQWdMeThnYVdZZ0tHRnRiM1Z1ZENBK0lEQXBJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1lub2dkMmwwYUdSeVlYZEdkVzVrYzE5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpreUxUSTVPUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprMUNpQWdJQ0F2THlCaGMzTmxkRkpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpreUxUSTVPQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa3lMVEk1T1FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeU9pQmpZWEprTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENncDNhWFJvWkhKaGQwWjFibVJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBMUNpQWdJQ0F2THlCeVpXTnBjR2xsYm5RNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdPQW9nSUNBZ0x5OGdZM0psWVhSbFpFRjBPaUIzYVhSb1pISmhkMkZzVkhsd1pTQTlQVDBnVjJsMGFHUnlZWGRoYkZSNWNHVlFaWEp0YVhOemFXOXVUR1Z6Y3lBL0lIUnBiV1Z6ZEdGdGNDQTZJREFzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0p3WlhKdGFYTnphVzl1YkdWemN5SUtJQ0FnSUQwOUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TURrS0lDQWdJQzh2SUdWNGNHbHlaWE5CZERvZ2QybDBhR1J5WVhkaGJGUjVjR1VnUFQwOUlGZHBkR2hrY21GM1lXeFVlWEJsUVhCd2NtOTJaV1FnUHlCMGFXMWxjM1JoYlhBZ09pQXdMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWlZWEJ3Y205MlpXUWlDaUFnSUNBOVBRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBekxUTXhNZ29nSUNBZ0x5OGdaVzFwZER4WGFYUm9aSEpoZDJGc1BpaDdDaUFnSUNBdkx5QWdJR05oY21RNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZERvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWTNKbFlYUmxaRUYwT2lCM2FYUm9aSEpoZDJGc1ZIbHdaU0E5UFQwZ1YybDBhR1J5WVhkaGJGUjVjR1ZRWlhKdGFYTnphVzl1VEdWemN5QS9JSFJwYldWemRHRnRjQ0E2SURBc0NpQWdJQ0F2THlBZ0lHVjRjR2x5WlhOQmREb2dkMmwwYUdSeVlYZGhiRlI1Y0dVZ1BUMDlJRmRwZEdoa2NtRjNZV3hVZVhCbFFYQndjbTkyWldRZ1B5QjBhVzFsYzNSaGJYQWdPaUF3TEFvZ0lDQWdMeThnSUNCdWIyNWpaVG9nYm05dVkyVXNDaUFnSUNBdkx5QWdJSFI1Y0dVNklIZHBkR2hrY21GM1lXeFVlWEJsTEFvZ0lDQWdMeThnZlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Tm1FS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGlZalJrWkRBd05pQXZMeUJ0WlhSb2IyUWdJbGRwZEdoa2NtRjNZV3dvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNjM1J5YVc1bktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TkFvZ0lDQWdMeThnZEdocGN5NWpZWEprY3loallYSmtLUzUyWVd4MVpTNTNhWFJvWkhKaGQyRnNUbTl1WTJVZ1BTQnViMjVqWlNBcklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVeUNpQWdJQ0F2THlCd2RXSnNhV01nWTJGeVpITWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dRMkZ5WkVSaGRHRStLSHNnYTJWNVVISmxabWw0T2lBblkyWW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqWmlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhOQW9nSUNBZ0x5OGdkR2hwY3k1allYSmtjeWhqWVhKa0tTNTJZV3gxWlM1M2FYUm9aSEpoZDJGc1RtOXVZMlVnUFNCdWIyNWpaU0FySURFS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJocGJuUWdOeklLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qcFBkMjVoWW14bExtOXViSGxQZDI1bGNpZ3BJQzArSUhadmFXUTZDbTl1YkhsUGQyNWxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpTd2dKMU5GVGtSRlVsOU9UMVJmUVV4TVQxZEZSQ2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdjSFZpYkdsaklGOXZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbDl2ZDI1bGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbDl2ZDI1bGNpNTJZV3gxWlN3Z0oxTkZUa1JGVWw5T1QxUmZRVXhNVDFkRlJDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02T2s5M2JtRmliR1V1WDNSeVlXNXpabVZ5VDNkdVpYSnphR2x3S0c1bGQwOTNibVZ5T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWDNSeVlXNXpabVZ5VDNkdVpYSnphR2x3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z2NISnZkR1ZqZEdWa0lGOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNDaHVaWGRQZDI1bGNqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCamIyNXpkQ0J3Y21WMmFXOTFjMDkzYm1WeUlEMGdkR2hwY3k1ZmIzZHVaWEl1YUdGelZtRnNkV1VnUHlCMGFHbHpMbDl2ZDI1bGNpNTJZV3gxWlNBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIQjFZbXhwWXlCZmIzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmZiM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmpiMjV6ZENCd2NtVjJhVzkxYzA5M2JtVnlJRDBnZEdocGN5NWZiM2R1WlhJdWFHRnpWbUZzZFdVZ1B5QjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpTQTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjd29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1gzUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd1gzUmxjbTVoY25sZlptRnNjMlZBTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhCMVlteHBZeUJmYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKZmIzZHVaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCamIyNXpkQ0J3Y21WMmFXOTFjMDkzYm1WeUlEMGdkR2hwY3k1ZmIzZHVaWEl1YUdGelZtRnNkV1VnUHlCMGFHbHpMbDl2ZDI1bGNpNTJZV3gxWlNBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0NsOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNGOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QndkV0pzYVdNZ1gyOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlYMjkzYm1WeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdkR2hwY3k1ZmIzZHVaWEl1ZG1Gc2RXVWdQU0J1WlhkUGQyNWxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8zT0MwNE1Rb2dJQ0FnTHk4Z1pXMXBkRHhQZDI1bGNuTm9hWEJVY21GdWMyWmxjbkpsWkQ0b2V3b2dJQ0FnTHk4Z0lDQndjbVYyYVc5MWMwOTNibVZ5T2lCd2NtVjJhVzkxYzA5M2JtVnlMQW9nSUNBZ0x5OGdJQ0J1WlhkUGQyNWxjam9nYm1WM1QzZHVaWElzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURsaE1qSXpaV1ppSUM4dklHMWxkR2h2WkNBaVQzZHVaWEp6YUdsd1ZISmhibk5tWlhKeVpXUW9ZV1JrY21WemN5eGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2w5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0Y5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCamIyNXpkQ0J3Y21WMmFXOTFjMDkzYm1WeUlEMGdkR2hwY3k1ZmIzZHVaWEl1YUdGelZtRnNkV1VnUHlCMGFHbHpMbDl2ZDI1bGNpNTJZV3gxWlNBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQmlJRjkwY21GdWMyWmxjazkzYm1WeWMyaHBjRjkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzZVR0YxYzJGaWJHVXViMjVzZVZCaGRYTmxjaWdwSUMwK0lIWnZhV1E2Q205dWJIbFFZWFZ6WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVYM0JoZFhObGNpNTJZV3gxWlNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY0hWaWJHbGpJRjl3WVhWelpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKZmNHRjFjMlZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxsOXdZWFZ6WlhJdWRtRnNkV1VwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVnQ0NZUUFtTm1BbmR5QkJVZmZIVUVZMlpoWXdaZmIzZHVaWElIWDNCaGRYTmxjZ1p3WVhWelpXUUNiMkVEZDI5d0EzZDNkQVJ3ZDNCckFuQmhCRC9YZ3BVT2NHVnliV2x6YzJsdmJteGxjM01EQm9FQkNHRndjSEp2ZG1Wa2dnSUVvT2dZY2dTY2hxR0ZOaG9BamdJQTJnRE9NUmtVUkRFWVFRQzNnaGtFb2FyYVF3U2dVUFh4QkwvZmxkd0VXeWR4UXdSSHU1MzlCRCtoSTRzRXJSWW1KQVRMN2l1aEJIUmR2eFlFMmhzbmlRU3NjeDNtQklmWmxHUUVMRG5IaFFTVk45VUpCTGMwa1ZnRXU5RGU4QVFUL3h6cEJQTGo4MzhFc2J1d3FBVGhlNiswQkxEWlU3TUVBWGo1U3dRYlVwM29CQXl0MFdNRWVGb2IrVFlhQUk0WkFDY0FrUUNqQUxRQm13SHNBaW9DNEFMMkF3a0RHZ01yQXo4RFVnT29CQXdFWUFUV0JaTUZuZ1d1QmJrRnlRWFpCZmtBZ0FRWFNCazlOaG9BamdFQUx3QXhHWUVGRWpFWUVFUkNBRlV4R1lFRUVqRVlFRVJDQUVRMkdnRkpGU1FTUkRZYUFra1ZKUkpFRjRnR0l5TkROaG9CU1JVa0VrUTJHZ0pKRlNRU1JFeUlCeUNJQnhNbkIweG5Kd1V4QUdjckltY25CaUpuS2pJS1VMQWpRNGdHK1NORGlBYjBJaXRsUkJSRXNUSUtJaWNFWlVTeUNTS3lDTElISTdJUUlySUJzeU5ETmhvQlNSVWxFa1FYaUFiS0p3bE1aeU5ETmhvQlNSVWtFa1NJQnJrbkNreG5JME0yR2dGSEFoVWtFa1EyR2dKSkZTVVNSQmRKVGdKT0E0Z0ZoMFF5QTFBaUZreExBVkJNVUxHQkJiSVpnQVFMZ1FGRHNrS0FQd3NnQWdBQmdBUldIUy9xTmhvQWpnRUFBUUF4R1lFRkVqRVlGQkJFUWdBQXNUSUtNZzZ5SUNLeUNMSUhJN0lRSXJJQnM0QUVGUjk4ZFRJS1VMQWpRN0pBZ0FSV0hTL3FzaHFCQnJJUUlySUJzN1ErU1ZjRUFFbE9BazRFVndBRUtoSkVTUlVrRWtSY0lFNENRUUJBTWhDeE1nRUlzZ2hIQXJJSEk3SVFJcklCc3loTVVFOEN2eUlyWlVRakNDdE1aMHNDUVFBR1NVc0RpQVRhU1U0Q1VJQUU5VE5BUkV4UXNDcE1VTEFqUXlKQy83NDJHZ0ZKRlNRU1JJZ0VyMEFBQjBtSUJKTkJBRGdqUkNoTEFWQkp2VVVCUkVtK1NGY0FJRXNDaUFUUXNUSUtTYklKSXJJSXNnZE1zZ0Fqc2hBaXNnR3p2RWdpSzJWRUl3a3JUR2NqUXlKQy84VTJHZ0ZKRlNRU1JEWWFBa2tWSkJKRWlBVm9LRXNDVUVtOVJRRkVTYjVJVndBZ1NVc0VpQVNDVENKTEE3dFBBa3hRVEZDQUJFeDR3a1ZNVUxBalF6WWFBVWtWSkJKRU5ob0NTUlVrRWtRMkdnTkpGU1VTUkJjMkdnUkpGU1VTUkJjMkdnVkpGU1VTUkJjMkdnWkpJbG1CQWdoTEFSVVNSRmNDQUNJbkJtVkVGRVFuQ0RFQVVMMUZBVVFvU3dWUVNiNUVTVmNBSUU4SUVrU0JRRnRKU3dRU1JMRWlKd2RsUkVzRHNnVkxCYklTU3dheUViSVVTd2F5QUlFRXNoQWlzZ0d6VHdVV1R3Wk1VRThGRmxCUEJCWlFTd01WRmxjR0FrOEVVRXlBQWdBNlVFeFFnQVNaU2hOblRGQ3dJd2dXZ1VCTXV5TkROaG9CU1JVa0VrUW9URkMrUkZkQUNDcE1VTEFqUXpZYUFVa1ZKQkpFS0V4UXZrUXFURkN3STBNMkdnRkpGU1FTUklnRVV5Y0xUR2NqUXpZYUFVa1ZKQkpFaUFSQ0p3ZE1aeU5ETmhvQlNSVWtFa1NJQkRFbkNFeFFJeGEvSTBNMkdnRkpGU1FTUklnRUhTY0lURkM4U0NORE5ob0JTUlVrRWtRMkdnSkpGU1VTUkJkTWlBTHVRQUFIU1lnQzBrRUFNeU5FS0VzQlVMMUZBVVN4SXJJU1RFbXlFVXNCc2hWTEFiSVVTd0d5QUlFRXNoQWlzZ0d6RmxDQUJJRFhmekZNVUxBalF5SkMvOG8yR2dGSkZTUVNSRFlhQWtrVkpSSkVGellhQTBrVkpSSkVGMHNDaUFKNVJDaExBMUMrUkVzRFN3TndBRWhMQWc5RU1RQXlCMDhDVjBnSVR3VlBBMUJQQkJaUVR3TVdVRThDRmxCTVVDa3hBRkJMQWIrQUJOaGZZZ3BMQVZDd0treFFzQ05ETmhvQlNSVWtFa1NJQWlsRUtURUFVTDFGQVVRcE1RQlF2a1FwTVFCUXZFaEpWd0FnU3dGWElDQkxBbGRBQ0VzRFYwZ0lTd1JYVUFoUEJWZFlDRThGVHdWUVR3UlFUd05RVHdKUVRGQW5ERXhRc0NORE5ob0JTUlVrRWtRMkdnSkpGU1VTUkJkTEFZZ0J5a1FwTVFCUXZVVUJSQ2hMQWxDK1JDa3hBRkMrUkVtQlNGdExBdzlFVElGSVcwc0JnVmhiVEVzQkVrUkxBVmNBSUVzRUVrUkxBWUZRV3lJbkNXVkVTd0VJTWdjT1JFOENnVUJiVHdSTVR3UlBBMDhFSncySUFoNHBNUUJRdkVnalF6WWFBVWNDRlNRU1JEWWFBa2tWSlJKRUYwbFBBallhQTBrVkpSSkVGMGxPQWs0RE5ob0VTUlVsRWtRWFNVNEVOaG9GU1JVbEVrUVhOaG9HU1U0R0ZZRkFFa1JMQW9nQklrUW9Td05RdmtReUIwc0RERVNCU0Z0SlRnZExBUkpFTVFBeUVVOEVUd0pRVHdVV1VFOEVGbEJQQXhaUVR3SVdVRXhRQVlIT0V6SU1EVUVBR0xHQkJySVFnUVd5R1NjT3NoNG5EcklmSXJJQnMwTC8zeUluQ21WRVRFNENoRVFuRDRnQmF5a3hBRkM5UlFGQkFBWXBNUUJRdkVnalF5SW5CR1ZFS2t4UXNDTkROaG9CU1JVa0VrU0lBYjZJQWNValF5SW5CV1ZFS2t4UXNDTkRpQUhkSndZalo0QUV6eU9qRDdBalE0Z0J6U2NHSW1lQUJMRmo3Z3V3STBNMkdnRkpGU1FTUklnQnRVa3lBeE5FSndWTEFXZUFCTXhBa2p4TVVMQWpRellhQVVrVkpSSkVGMGsyR2dKSkZTVVNSQmRPQWpZYUEwbE9BaFVrRWtTSUFVeEJBQkd4c2hTeUViSVNnUVN5RUNLeUFiTWpRMFVCc2JJSHNnZ2pzaEFpc2dHelF2L3RpZ0VCS0l2L1VFbTlSUUZFdmtoWEFDQXhBQktKTVFBaUp3dGxSQktKaWdJQWlQL3hSQ2lML2xDOVJRRkVzU0t5RW92L3NoR0wvcklVaS82eUFJRUVzaEFpc2dHemkvOFdpLzVNVUlBRVZ4bk8wVXhRc0ltS0FnQXBpLzVRU2IxRkFVRUFSNHNBdmtSWEFDQ0wveEpCQURxTEFFbStSRXk4U0VsWEFDQkxBVmNnSUVzQ1YwQUlTd05YU0FoTEJGZFFDRThGVjFnSVR3VlBCVkJQQkZCUEExQlBBbEJNVUNjTVRGQ3dpWW9HQUl2OFFRQVpzVEVBaS95eUVvdjdzaEd5Rkl2NnNnQ0JCTElRSXJJQnN6RUFpLzhuRFJJaWkvMVBBazJML3ljUEVpS0wvVThDVFl2NlR3TlFpL3NXVUl2OEZsQlBBaFpRVEJaUWkvNFdVSXYvRlJaWEJnS0wvMUJNZ0FJQWFsQk1VSUFFdTAzUUJreFFzSXYrSXdnb2kvcFFUQmFCU0V5N2lURUFJaWNFWlVRU1JJbUtBUUFpSndSbFJRRkJBQmNpSndSbFJDY0VpLzluaS85UWdBU2FJajc3VEZDd2lUSURRdi9wTVFBaUp3VmxSQkpFaVE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkNhcmRBc3NldEVuYWJsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNhcmRDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiV2l0aGRyYXdhbFJlcXVlc3RDYW5jZWxsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdGVkQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ2FyZFJlY292ZXJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRDYXJkT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3Q2FyZE93bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJEZWJpdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWZlcmVuY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNhcmRBc3NldERpc2FibGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IldpdGhkcmF3YWxSZXF1ZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRlZEF0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IldpdGhkcmF3YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdGVkQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcmVzQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR5cGUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119LHsibmFtZSI6IlVucGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXX0seyJuYW1lIjoiUGF1c2VyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QWRkcmVzcyIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
