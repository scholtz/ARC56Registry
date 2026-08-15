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
        ///Opt-in a card into an asset. Any shortfall in the card's minimum balance requirement is
        ///topped up from the contract escrow, so the caller does not have to pre-fund the card.
        ///A card already opted into the asset is rejected, since the call would do nothing.
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
        ///Sets the Killswitch application whose AutoDraw delegations are revoked when a card opts out
        ///of an asset. The app id is owner-controlled rather than passed in per call, so a caller
        ///cannot point the revocation at a look-alike contract and have the real delegation survive.
        ///Only the owner of the contract can call this method.
        ///</summary>
        /// <param name="newKillswitchApp">The Killswitch application to register. </param>
        public async Task SetKillswitchApp(ulong newKillswitchApp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 121, 107, 69 };
            var newKillswitchAppAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newKillswitchAppAbi.From(newKillswitchApp);

            var result = await base.CallApp(new List<object> { abiHandle, newKillswitchAppAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetKillswitchApp_Transactions(ulong newKillswitchApp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 121, 107, 69 };
            var newKillswitchAppAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newKillswitchAppAbi.From(newKillswitchApp);

            return await base.MakeTransactionList(new List<object> { abiHandle, newKillswitchAppAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///requirement of the account. The freed MBR — along with any other surplus Algo on the card —
        ///is swept back to the contract escrow that sponsored it.
        ///
        ///The holder's AutoDraw delegation for the asset goes with it. Opting the card out is the point
        ///at which the asset can no longer be drawn into it, and it is the only chokepoint that catches
        ///every case — a card cannot be closed while it still holds an ASA, so every asset a card ever
        ///held passes through here. Revoking is best-effort, so an asset that was never delegated
        ///closes out normally.
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWFpbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDYXJkRGF0YSI6W3sibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3aXRoZHJhd2FsTm9uY2UiLCJ0eXBlIjoidWludDY0In1dLCJXaXRoZHJhd2FsUmVxdWVzdCI6W3sibmFtZSI6ImNhcmQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlY2lwaWVudCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXNzZXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNyZWF0ZWRBdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY2FyZEFzc2V0T3B0SW4iLCJkZXNjIjoiT3B0LWluIGEgY2FyZCBpbnRvIGFuIGFzc2V0LiBBbnkgc2hvcnRmYWxsIGluIHRoZSBjYXJkJ3MgbWluaW11bSBiYWxhbmNlIHJlcXVpcmVtZW50IGlzXG50b3BwZWQgdXAgZnJvbSB0aGUgY29udHJhY3QgZXNjcm93LCBzbyB0aGUgY2FsbGVyIGRvZXMgbm90IGhhdmUgdG8gcHJlLWZ1bmQgdGhlIGNhcmQuXG5BIGNhcmQgYWxyZWFkeSBvcHRlZCBpbnRvIHRoZSBhc3NldCBpcyByZWplY3RlZCwgc2luY2UgdGhlIGNhbGwgd291bGQgZG8gbm90aGluZy5cbk9ubHkgdGhlIHBhcnRuZXIgY2FuIGNhbGwgdGhpcyBmdW5jdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiQ2FyZCBhZGRyZXNzIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJBc3NldCB0byBvcHQtaW4gdG8iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNhcmRBc3NldEVuYWJsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcGxveSIsImRlc2MiOiJEZXBsb3kgdGhlIGNvbnRyYWN0LCBzZXR0aW5nIHRoZSBvd25lciBhcyBwcm92aWRlZCBhbmQgaW5pdGlhbGl6aW5nIGdsb2JhbCBzdGF0ZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib21uaWJ1cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGUiLCJkZXNjIjoiQWxsb3dzIHRoZSBvd25lciB0byB1cGRhdGUgdGhlIHNtYXJ0IGNvbnRyYWN0IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiVXBkYXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXN0cm95IiwiZGVzYyI6IkRlc3Ryb3kgdGhlIHNtYXJ0IGNvbnRyYWN0LCBzZW5kaW5nIGFsbCBBbGdvIHRvIHRoZSBvd25lciBhY2NvdW50LiBUaGlzIGNhbiBvbmx5IGJlIGRvbmUgaWYgdGhlcmUgYXJlIG5vIGFjdGl2ZSBjYXJkcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0V2l0aGRyYXdhbFRpbWVvdXQiLCJkZXNjIjoiU2V0IHRoZSBudW1iZXIgb2Ygc2Vjb25kcyBhIHdpdGhkcmF3YWwgcmVxdWVzdCBtdXN0IHdhaXQgdW50aWwgYmVpbmcgd2l0aGRyYXduIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlY29uZHMiLCJkZXNjIjoiTmV3IG51bWJlciBvZiBzZWNvbmRzIHRvIHdhaXQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0V2l0aGRyYXdhbFB1YmtleSIsImRlc2MiOiJTZXRzIHRoZSB3aXRoZHJhd2FsIHB1YmxpYyBrZXkuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVia2V5IiwiZGVzYyI6Ii0gVGhlIHB1YmxpYyBrZXkgdG8gc2V0LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYXJkQ3JlYXRlIiwiZGVzYyI6IkNyZWF0ZSBhIGNhcmQuIFRoaXMgZ2VuZXJhdGVzIGEgYnJhbmQgbmV3IGFjY291bnQgYW5kIGZ1bmRzIHRoZSBtaW5pbXVtIGJhbGFuY2UgcmVxdWlyZW1lbnRcbmZyb20gdGhlIGNvbnRyYWN0IChvd25lci1zcG9uc29yZWQpLiBPbmx5IHRoZSBwYXJ0bmVyIGNhbiBjYWxsIHRoaXMgZnVuY3Rpb24uIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkT3duZXIiLCJkZXNjIjoiVGhlIGNhcmQgaG9sZGVyIHdobyB3aWxsIG93bi9jb250cm9sIHRoZSBjYXJkIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJBc3NldCB0byBvcHQtaW4gdG8uIDAgPSBObyBhc3NldCBvcHQtaW4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6Ik5ld2x5IGdlbmVyYXRlZCBhY2NvdW50IHVzZWQgYnkgdGhlaXIgY2FyZCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJDYXJkQXNzZXRFbmFibGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNhcmRDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhcmRDbG9zZSIsImRlc2MiOiJDbG9zZSBhY2NvdW50LiBUaGlzIHBlcm1hbmVudGx5IHJlbW92ZXMgdGhlIHJla2V5IGFuZCBkZWxldGVzIHRoZSBhY2NvdW50IGZyb20gdGhlIGxlZGdlci5cbk9ubHkgdGhlIHBhcnRuZXIgb3IgdGhlIGNhcmQgaG9sZGVyIGNhbiBjYWxsIHRoaXMgZnVuY3Rpb24uIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6IkFkZHJlc3MgdG8gY2xvc2UiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IldpdGhkcmF3YWxSZXF1ZXN0Q2FuY2VsbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRlZEF0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYXJkUmVjb3ZlciIsImRlc2MiOiJSZWNvdmVycyBmdW5kcyBmcm9tIGFuIG9sZCBjYXJkIGFuZCB0cmFuc2ZlcnMgdGhlbSB0byBhIG5ldyBjYXJkLlxuT25seSB0aGUgb3duZXIgb2YgdGhlIGNvbnRyYWN0IGNhbiBwZXJmb3JtIHRoaXMgb3BlcmF0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOiItIFRoZSBjYXJkIHRvIHJlY292ZXIuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3Q2FyZEhvbGRlciIsImRlc2MiOiItIFRoZSBhZGRyZXNzIG9mIHRoZSBuZXcgY2FyZCBob2xkZXIuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJXaXRoZHJhd2FsUmVxdWVzdENhbmNlbGxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0ZWRBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJDYXJkUmVjb3ZlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9sZENhcmRPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDYXJkT3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYXJkRGViaXQiLCJkZXNjIjoiRGViaXRzIHRoZSBzcGVjaWZpZWQgYW1vdW50IG9mIHRoZSBnaXZlbiBhc3NldCBmcm9tIHRoZSBjYXJkIGFjY291bnQuXG5Pbmx5IGEgd2l0aGRyYXcgb3BlcmF0b3IgY2FuIHBlcmZvcm0gdGhpcyBvcGVyYXRpb24uXG5cblRoZSBBdXRvRHJhdyBsc2lnIGJpbmRzIGBjYXJkYCBhbmQgYGNhcmRPd25lcmAgdG8gdGhlIGF4ZmVyIHJlY2VpdmVyLCBzbyB2ZXJpZnlpbmcgaGVyZSB0aGF0XG5gY2FyZE93bmVyYCBvd25zIGBjYXJkYCBwcmV2ZW50cyB0aGUgZGVsZWdhdGVkIGRyYXcgZnJvbSBmdW5kaW5nIChhbmQgc3Vic2VxdWVudGx5XG5kZWJpdGluZykgYSBjYXJkIHRoZSBhY2NvdW50IGRvZXMgbm90IG93bi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmRPd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiVGhlIGNhcmQgZnJvbSB3aGljaCB0aGUgYXNzZXQgd2lsbCBiZSBkZWJpdGVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiVGhlIGFzc2V0IHRvIGJlIGRlYml0ZWQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiVGhlIGFtb3VudCBvZiB0aGUgYXNzZXQgdG8gYmUgZGViaXRlZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkRlYml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZmVyZW5jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldE5leHRDYXJkTm9uY2UiLCJkZXNjIjoiUmV0cmlldmVzIHRoZSBuZXh0IGF2YWlsYWJsZSBub25jZSBmb3IgdGhlIGNhcmQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6IlRoZSBjYXJkIGFkZHJlc3MuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBub25jZSBmb3IgdGhlIGNhcmQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDYXJkRGF0YSIsImRlc2MiOiJSZXRyaWV2ZXMgdGhlIGNhcmQgZGF0YSBmb3IgYSBnaXZlbiBjYXJkIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6IlRoZSBhZGRyZXNzIG9mIHRoZSBjYXJkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQ2FyZERhdGEiLCJkZXNjIjoiVGhlIGNhcmQgZGF0YS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFBhcnRuZXJBZGRyZXNzIiwiZGVzYyI6IlNldHMgdGhlIHBhcnRuZXIgYWRkcmVzcy5cbk9ubHkgdGhlIG93bmVyIG9mIHRoZSBjb250cmFjdCBjYW4gY2FsbCB0aGlzIG1ldGhvZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1BhcnRuZXJBZGRyZXNzIiwiZGVzYyI6IlRoZSBuZXcgcGFydG5lciBhZGRyZXNzIHRvIGJlIHNldC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0T21uaWJ1c0FkZHJlc3MiLCJkZXNjIjoiU2V0cyB0aGUgb21uaWJ1cyBhZGRyZXNzLlxuT25seSB0aGUgb3duZXIgb2YgdGhlIGNvbnRyYWN0IGNhbiBjYWxsIHRoaXMgbWV0aG9kLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T21uaWJ1c0FkZHJlc3MiLCJkZXNjIjoiVGhlIG5ldyBvbW5pYnVzIGFkZHJlc3MgdG8gYmUgc2V0LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRLaWxsc3dpdGNoQXBwIiwiZGVzYyI6IlNldHMgdGhlIEtpbGxzd2l0Y2ggYXBwbGljYXRpb24gd2hvc2UgQXV0b0RyYXcgZGVsZWdhdGlvbnMgYXJlIHJldm9rZWQgd2hlbiBhIGNhcmQgb3B0cyBvdXRcbm9mIGFuIGFzc2V0LiBUaGUgYXBwIGlkIGlzIG93bmVyLWNvbnRyb2xsZWQgcmF0aGVyIHRoYW4gcGFzc2VkIGluIHBlciBjYWxsLCBzbyBhIGNhbGxlclxuY2Fubm90IHBvaW50IHRoZSByZXZvY2F0aW9uIGF0IGEgbG9vay1hbGlrZSBjb250cmFjdCBhbmQgaGF2ZSB0aGUgcmVhbCBkZWxlZ2F0aW9uIHN1cnZpdmUuXG5Pbmx5IHRoZSBvd25lciBvZiB0aGUgY29udHJhY3QgY2FuIGNhbGwgdGhpcyBtZXRob2QuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0tpbGxzd2l0Y2hBcHAiLCJkZXNjIjoiVGhlIEtpbGxzd2l0Y2ggYXBwbGljYXRpb24gdG8gcmVnaXN0ZXIuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZFdpdGhkcmF3T3BlcmF0b3IiLCJkZXNjIjoiQXV0aG9yaXplIGFuIGFjY291bnQgYXMgYSB3aXRoZHJhdyBvcGVyYXRvciwgYWxsb3dpbmcgaXQgdG8gY2FsbCBjYXJkRGViaXQuXG5Pbmx5IHRoZSBvd25lciBvZiB0aGUgY29udHJhY3QgY2FuIGNhbGwgdGhpcyBtZXRob2QuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRvciIsImRlc2MiOiJUaGUgYWNjb3VudCB0byBhdXRob3JpemUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbW92ZVdpdGhkcmF3T3BlcmF0b3IiLCJkZXNjIjoiUmV2b2tlIGEgd2l0aGRyYXcgb3BlcmF0b3IuIERlbGV0aW5nIHRoZSBib3ggcmVsZWFzZXMgaXRzIE1CUiBiYWNrIHRvIHRoZVxuY29udHJhY3QuIE9ubHkgdGhlIG93bmVyIG9mIHRoZSBjb250cmFjdCBjYW4gY2FsbCB0aGlzIG1ldGhvZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6IlRoZSBhY2NvdW50IHRvIHJldm9rZS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FyZERpc2FibGVBc3NldCIsImRlc2MiOiJBbGxvd3MgdGhlIGNhcmQgaG9sZGVyIChvciBwYXJ0bmVyKSB0byBDbG9zZU91dCBvZiBhbiBhc3NldCwgcmVkdWNpbmcgdGhlIG1pbmltdW0gYmFsYW5jZVxucmVxdWlyZW1lbnQgb2YgdGhlIGFjY291bnQuIFRoZSBmcmVlZCBNQlIg4oCUIGFsb25nIHdpdGggYW55IG90aGVyIHN1cnBsdXMgQWxnbyBvbiB0aGUgY2FyZCDigJRcbmlzIHN3ZXB0IGJhY2sgdG8gdGhlIGNvbnRyYWN0IGVzY3JvdyB0aGF0IHNwb25zb3JlZCBpdC5cblxuVGhlIGhvbGRlcidzIEF1dG9EcmF3IGRlbGVnYXRpb24gZm9yIHRoZSBhc3NldCBnb2VzIHdpdGggaXQuIE9wdGluZyB0aGUgY2FyZCBvdXQgaXMgdGhlIHBvaW50XG5hdCB3aGljaCB0aGUgYXNzZXQgY2FuIG5vIGxvbmdlciBiZSBkcmF3biBpbnRvIGl0LCBhbmQgaXQgaXMgdGhlIG9ubHkgY2hva2Vwb2ludCB0aGF0IGNhdGNoZXNcbmV2ZXJ5IGNhc2Ug4oCUIGEgY2FyZCBjYW5ub3QgYmUgY2xvc2VkIHdoaWxlIGl0IHN0aWxsIGhvbGRzIGFuIEFTQSwgc28gZXZlcnkgYXNzZXQgYSBjYXJkIGV2ZXJcbmhlbGQgcGFzc2VzIHRocm91Z2ggaGVyZS4gUmV2b2tpbmcgaXMgYmVzdC1lZmZvcnQsIHNvIGFuIGFzc2V0IHRoYXQgd2FzIG5ldmVyIGRlbGVnYXRlZFxuY2xvc2VzIG91dCBub3JtYWxseS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiLSBUaGUgYWRkcmVzcyBvZiB0aGUgY2FyZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6Ii0gVGhlIElEIG9mIHRoZSBhc3NldCB0byBiZSByZW1vdmVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ2FyZEFzc2V0RGlzYWJsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3YWxSZXF1ZXN0IiwiZGVzYyI6IkFsbG93cyB0aGUgY2FyZCBob2xkZXIgdG8gcmVxdWVzdCBhIHdpdGhkcmF3YWwgb2YgYW4gYW1vdW50IG9mIGFzc2V0cyBmcm9tIHRoZSBhY2NvdW50IiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6IkFkZHJlc3MgdG8gd2l0aGRyYXcgZnJvbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiQXNzZXQgdG8gd2l0aGRyYXciLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJBbW91bnQgdG8gd2l0aGRyYXciLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiV2l0aGRyYXdhbFJlcXVlc3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiV2l0aGRyYXdhbFJlcXVlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdGVkQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3YWxDYW5jZWwiLCJkZXNjIjoiQWxsb3dzIHRoZSBjYXJkIGhvbGRlciB0byBjYW5jZWwgYSB3aXRoZHJhd2FsIHJlcXVlc3QiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiQWRkcmVzcyB0byB3aXRoZHJhdyBmcm9tIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJXaXRoZHJhd2FsUmVxdWVzdENhbmNlbGxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0ZWRBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjoiQWxsb3dzIHRoZSBjYXJkIGhvbGRlciB0byBzZW5kIGFuIGFtb3VudCBvZiBhc3NldHMgZnJvbSB0aGUgYWNjb3VudCIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOiJBZGRyZXNzIHRvIHdpdGhkcmF3IGZyb20iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiV2l0aGRyYXdhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0ZWRBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyZXNBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHlwZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3UGVybWlzc2lvbmVkIiwiZGVzYyI6IldpdGhkcmF3cyBmdW5kcyBiZWZvcmUgdGhlIHdpdGhkcmF3YWwgdGltZXN0YW1wIGhhcyBsYXBzZWQsIGJ5IHVzaW5nIHRoZSBwZXJtaXNzaW9uZWQgd2l0aGRyYXdhbCBzaWduYXR1cmUgcHJvdmlkZWQgYnkgcGFydG5lci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjoiLSBUaGUgYWRkcmVzcyBvZiB0aGUgY2FyZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6Ii0gVGhlIElEIG9mIHRoZSBhc3NldCB0byBiZSB3aXRoZHJhd24uIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiLSBUaGUgYW1vdW50IG9mIHRoZSB3aXRoZHJhd2FsLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJlc0F0IiwiZGVzYyI6Ii0gVGhlIGV4cGlyeSBvZiB0aGUgd2l0aGRyYXdhbCBzaWduYXR1cmUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs2NF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmUiLCJkZXNjIjoiLSBUaGUgc2lnbmF0dXJlIGZvciBwZXJtaXNzaW9uZWQgd2l0aGRyYXdhbC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IldpdGhkcmF3YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdGVkQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcmVzQXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR5cGUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyT3duZXJzaGlwIiwiZGVzYyI6IlRyYW5zZmVycyB0aGUgb3duZXJzaGlwIG9mIHRoZSBjb250cmFjdCB0byBhIG5ldyBvd25lci5cblJlcXVpcmVzIHRoZSBjYWxsZXIgdG8gYmUgdGhlIGN1cnJlbnQgb3duZXIuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOiJUaGUgYWRkcmVzcyBvZiB0aGUgbmV3IG93bmVyLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXVzZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlBhdXNlcidzIGFkZHJlc3MifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVucGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlVucGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZVBhdXNlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX25ld1BhdXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUGF1c2VyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QWRkcmVzcyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY292ZXJBc3NldCIsImRlc2MiOiJSZWNvdmVyIGFuIGFzc2V0IHNlbnQgdG8gdGhlIGNvbnRyYWN0IGJ5IG1pc3Rha2UuIE9ubHkgdGhlIG93bmVyIGNhbiBjYWxsIHRoaXMgZnVuY3Rpb24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IkFzc2V0IElEIG9mIHRoZSBhc3NldCB0byByZWNvdmVyLiBJZiAwLCBBbGdvIHdpbGwgYmUgcmVjb3ZlcmVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6IkFtb3VudCBvZiB0aGUgYXNzZXQgdG8gcmVjb3Zlci4gSWYgQWxnb3MsIHJlbWVtYmVyIHRoZSBtaW5pbXVtIGJhbGFuY2UgcmVxdWlyZW1lbnQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6IkFkZHJlc3MgdG8gc2VuZCB0aGUgcmVjb3ZlcmVkIGFzc2V0IHRvLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjV9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE5MzZdLCJlcnJvck1lc3NhZ2UiOiJBRERSRVNTX05PVF9BTExPV0VEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU5NV0sImVycm9yTWVzc2FnZSI6IkFNT1VOVF9JTlZBTElEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA3OV0sImVycm9yTWVzc2FnZSI6IkFTU0VUX0FMUkVBRFlfRU5BQkxFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1NiwxMDY4LDEwOTAsMTQwMCwxNDg3LDE1ODEsMTU4NywxNzQwLDIxNzksMjE5M10sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDhdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM4XSwiZXJyb3JNZXNzYWdlIjoiQ0FSRFNfU1RJTExfQUNUSVZFIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYxOF0sImVycm9yTWVzc2FnZSI6IkNBUkRfTUlTTUFUQ0giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDYsODM5LDEyMTcsMjAzNSwyMDY5XSwiZXJyb3JNZXNzYWdlIjoiQ0FSRF9OT1RfRk9VTkQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDBdLCJlcnJvck1lc3NhZ2UiOiJDT05UUkFDVF9QQVVTRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDExXSwiZXJyb3JNZXNzYWdlIjoiSU5TVUZGSUNJRU5UX0JBTEFOQ0UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NzIsMTYwOSwxNzU2XSwiZXJyb3JNZXNzYWdlIjoiTk9OQ0VfSU5WQUxJRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2NF0sImVycm9yTWVzc2FnZSI6Ik9XTkVSX0lOVkFMSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjQsNzY2LDk0OSwxMjQwLDIwNDQsMjA2MSwyMzc5LDI0MjldLCJlcnJvck1lc3NhZ2UiOiJTRU5ERVJfTk9UX0FMTE9XRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODI3XSwiZXJyb3JNZXNzYWdlIjoiU0lHTkFUVVJFX0lOVkFMSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDgxLDE1NzVdLCJlcnJvck1lc3NhZ2UiOiJXSVRIRFJBV0FMX1JFUVVFU1RfTk9UX0ZPVU5EIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzNSwxNzQ2XSwiZXJyb3JNZXNzYWdlIjoiV0lUSERSQVdBTF9USU1FX0lOVkFMSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjcwLDEyNzQsMTI4NywxMjkyLDIwODQsMjA5MywyMTAzXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzYsNDQ2LDY4OSw4MDAsOTM4LDk3OCwxMzMyLDE2MjgsMTgyMiwxODU1LDE4ODIsMjA1MiwyMzc3LDIzOTcsMjQyN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1NiwxMDUzLDIzNjldLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTIyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY3LDM4OSwzOTcsNDg4LDUwNiw3MzcsODE5LDgyNyw4ODEsODg5LDEwNjMsMTA4NSwxMTA0LDExMjEsMTE1NiwxMTc2LDExOTYsMTM3MSwxNDcwLDE1NTMsMTY3MSwxODY5LDE5MjgsMTk4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzI5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NSw0NzAsNTE0LDg5Nyw5MDYsOTE1LDExMzgsMTIwNywxMzc5LDEzODgsMTU2MSwxNjc5LDE2OTEsMTcwNSwxNzE3LDE5NjAsMTk3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbU5tSWlBaWQzSWlJREI0TVRVeFpqZGpOelVnSW1ObVlXTWlJQ0pmYjNkdVpYSWlJQ0pmY0dGMWMyVnlJaUFpY0dGMWMyVmtJaUFpYjJFaUlDSjNiM0FpSUNKcmN5SWdJbmQzZENJZ0luQjNjR3NpSUNKd1lTSWdNSGd6Wm1RM09ESTVOU0FpY0dWeWJXbHpjMmx2Ym14bGMzTWlJREI0TURZNE1UQXhJQ0poY0hCeWIzWmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjd0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUV0ZwYmlCbGVIUmxibVJ6SUdOc1lYTnpaWE1vVDNkdVlXSnNaU3dnVUdGMWMyRmliR1VzSUZKbFkyOTJaWEpoWW14bEtTQjdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZVEJsT0RFNE56SWdNSGc1WXpnMllURTROU0F2THlCdFpYUm9iMlFnSW5Wd1pHRjBaU2dwZG05cFpDSXNJRzFsZEdodlpDQWlaR1Z6ZEhKdmVTZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZFhCa1lYUmxYM0p2ZFhSbFFEUWdiV0ZwYmw5a1pYTjBjbTk1WDNKdmRYUmxRRFVLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk5ZV2x1SUdWNGRHVnVaSE1nWTJ4aGMzTmxjeWhQZDI1aFlteGxMQ0JRWVhWellXSnNaU3dnVW1WamIzWmxjbUZpYkdVcElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTXpVS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaE1XRmhaR0UwTXlBd2VHRXdOVEJtTldZeElEQjRZbVprWmprMVpHTWdNSGcxWWpJM056RTBNeUF3ZURRM1ltSTVaR1prSURCNE0yWmhNVEl6T0dJZ01IaGhaREUyTWpZeU5DQXdlR05pWldVeVltRXhJREI0TnpRMVpHSm1NVFlnTUhoa1lURmlNamM0T1NBd2VHRmpOek14WkdVMklEQjRZV1UzT1RaaU5EVWdNSGc0TjJRNU9UUTJOQ0F3ZURKak16bGpOemcxSURCNE9UVXpOMlExTURrZ01IaGlOek0wT1RFMU9DQXdlR0ppWkRCa1pXWXdJREI0TVRObVpqRmpaVGtnTUhobU1tVXpaak0zWmlBd2VHSXhZbUppTUdFNElEQjRaVEUzWW1GbVlqUWdNSGhpTUdRNU5UTmlNeUF3ZURBeE56aG1PVFJpSURCNE1XSTFNamxrWlRnZ01IZ3dZMkZrWkRFMk15QXdlRGM0TldFeFltWTVJQzh2SUcxbGRHaHZaQ0FpWTJGeVpFRnpjMlYwVDNCMFNXNG9ZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFYybDBhR1J5WVhkaGJGUnBiV1Z2ZFhRb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEZkcGRHaGtjbUYzWVd4UWRXSnJaWGtvWW5sMFpWc3pNbDBwZG05cFpDSXNJRzFsZEdodlpDQWlZMkZ5WkVOeVpXRjBaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSmpZWEprUTJ4dmMyVW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKallYSmtVbVZqYjNabGNpaGhaR1J5WlhOekxHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJGeVpFUmxZbWwwS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwVG1WNGRFTmhjbVJPYjI1alpTaGhaR1J5WlhOektYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBRMkZ5WkVSaGRHRW9ZV1JrY21WemN5a29ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKelpYUlFZWEowYm1WeVFXUmtjbVZ6Y3loaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEU5dGJtbGlkWE5CWkdSeVpYTnpLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBTMmxzYkhOM2FYUmphRUZ3Y0NoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZV1JrVjJsMGFHUnlZWGRQY0dWeVlYUnZjaWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxiVzkyWlZkcGRHaGtjbUYzVDNCbGNtRjBiM0lvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmpZWEprUkdsellXSnNaVUZ6YzJWMEtHRmtaSEpsYzNNc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNZV3hTWlhGMVpYTjBLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkNrb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luZHBkR2hrY21GM1lXeERZVzVqWld3b1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0ozYVhSb1pISmhkeWhoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKM2FYUm9aSEpoZDFCbGNtMXBjM05wYjI1bFpDaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGllWFJsV3pZMFhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmQyNWxjaWdwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSndZWFZ6WlhJb0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0luQmhkWE5sS0NsMmIybGtJaXdnYldWMGFHOWtJQ0oxYm5CaGRYTmxLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWUVlYVnpaWElvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaV052ZG1WeVFYTnpaWFFvZFdsdWREWTBMSFZwYm5RMk5DeGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCallYSmtRWE56WlhSUGNIUkpiaUJ6WlhSWGFYUm9aSEpoZDJGc1ZHbHRaVzkxZENCelpYUlhhWFJvWkhKaGQyRnNVSFZpYTJWNUlHTmhjbVJEY21WaGRHVWdZMkZ5WkVOc2IzTmxJR05oY21SU1pXTnZkbVZ5SUdOaGNtUkVaV0pwZENCblpYUk9aWGgwUTJGeVpFNXZibU5sSUdkbGRFTmhjbVJFWVhSaElITmxkRkJoY25SdVpYSkJaR1J5WlhOeklITmxkRTl0Ym1saWRYTkJaR1J5WlhOeklITmxkRXRwYkd4emQybDBZMmhCY0hBZ1lXUmtWMmwwYUdSeVlYZFBjR1Z5WVhSdmNpQnlaVzF2ZG1WWGFYUm9aSEpoZDA5d1pYSmhkRzl5SUdOaGNtUkVhWE5oWW14bFFYTnpaWFFnZDJsMGFHUnlZWGRoYkZKbGNYVmxjM1FnZDJsMGFHUnlZWGRoYkVOaGJtTmxiQ0IzYVhSb1pISmhkeUIzYVhSb1pISmhkMUJsY20xcGMzTnBiMjVsWkNCdmQyNWxjaUIwY21GdWMyWmxjazkzYm1WeWMyaHBjQ0J3WVhWelpYSWdjR0YxYzJVZ2RXNXdZWFZ6WlNCMWNHUmhkR1ZRWVhWelpYSWdjbVZqYjNabGNrRnpjMlYwQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTXpVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxaGFXNGdaWGgwWlc1a2N5QmpiR0Z6YzJWektFOTNibUZpYkdVc0lGQmhkWE5oWW14bExDQlNaV052ZG1WeVlXSnNaU2tnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRjME9ERTVNMlFnTHk4Z2JXVjBhRzlrSUNKa1pYQnNiM2tvWVdSa2NtVnpjeXhoWkdSeVpYTnpLV0ZrWkhKbGMzTWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JrWlhCc2Iza0tJQ0FnSUdWeWNnb0tiV0ZwYmw5a1pYTjBjbTk1WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRek53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZEVaV3hsZEdWQmNIQnNhV05oZEdsdmJpZGRJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z1JHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCa1pYTjBjbTk1Q2dwdFlXbHVYM1Z3WkdGMFpWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNamtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNuVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRuWFNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2NIVnphR2x1ZENBMElDOHZJRlZ3WkdGMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHSWdkWEJrWVhSbENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTVqWVhKa1FYTnpaWFJQY0hSSmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oY21SQmMzTmxkRTl3ZEVsdU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprUVhOelpYUlBjSFJKYmloallYSmtPaUJCWTJOdmRXNTBMQ0JoYzNObGREb2dRWE56WlhRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWTJGc2JITjFZaUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTllXbHVMbU5oY21SQmMzTmxkRTl3ZEVsdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTVrWlhCc2IzbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWlhCc2IzazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkT2IwOXdKMTBzSUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXhOQW9nSUNBZ0x5OGdkR2hwY3k1ZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBb2IzZHVaWElwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVEVLSUNBZ0lDOHZJSEIxWW14cFl5QnZiVzVwWW5WelgyRmtaSEpsYzNNZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMjloSnlCOUtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWIyRWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4TlFvZ0lDQWdMeThnZEdocGN5NXZiVzVwWW5WelgyRmtaSEpsYzNNdWRtRnNkV1VnUFNCdmJXNXBZblZ6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklIQjFZbXhwWXlCZmNHRjFjMlZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlYM0JoZFhObGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREUyQ2lBZ0lDQXZMeUIwYUdsekxsOXdZWFZ6WlhJdWRtRnNkV1VnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56VUtJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtjMTloWTNScGRtVmZZMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ZMlpoWXljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTm1ZV01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReU1Bb2dJQ0FnTHk4Z2RHaHBjeTVqWVhKa2MxOWhZM1JwZG1WZlkyOTFiblF1ZG1Gc2RXVWdQU0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCd2RXSnNhV01nY0dGMWMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFltOXZiR1ZoYmo0b0tRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWNHRjFjMlZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1qRUtJQ0FnSUM4dklIUm9hWE11Y0dGMWMyVmtMblpoYkhWbElEMGdabUZzYzJVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1USUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc25UbTlQY0NkZExDQnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRJekNpQWdJQ0F2THlCeVpYUjFjbTRnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkT2IwOXdKMTBzSUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV0ZwYmk1MWNHUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRek1Rb2dJQ0FnTHk4Z2RHaHBjeTV2Ym14NVQzZHVaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQnZibXg1VDNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREk1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUJiSjFWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1SjEwZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5ZV2x1TG1SbGMzUnliM2xiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pYTjBjbTk1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME16a0tJQ0FnSUM4dklIUm9hWE11YjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEwTWdvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxtTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDNTJZV3gxWlN3Z0owTkJVa1JUWDFOVVNVeE1YMEZEVkVsV1JTY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOelVLSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprYzE5aFkzUnBkbVZmWTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWTJaaFl5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbU5tWVdNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBNZ29nSUNBZ0x5OGdZWE56WlhKMEtDRjBhR2x6TG1OaGNtUnpYMkZqZEdsMlpWOWpiM1Z1ZEM1MllXeDFaU3dnSjBOQlVrUlRYMU5VU1V4TVgwRkRWRWxXUlNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFTkJVa1JUWDFOVVNVeE1YMEZEVkVsV1JRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBORFF0TkRVd0NpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJSFJvYVhNdWIzZHVaWElvS1N3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBOZ29nSUNBZ0x5OGdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIQjFZbXhwWXlCZmIzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmZiM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVmYjNkdVpYSXVkbUZzZFdVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zYjNObFVtVnRZV2x1WkdWeVZHOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFEzQ2lBZ0lDQXZMeUJoYlc5MWJuUTZJREFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRRMExUUTBPUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCMGFHbHpMbTkzYm1WeUtDa3NDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBOQzAwTlRBS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lDQWdZMnh2YzJWU1pXMWhhVzVrWlhKVWJ6b2dkR2hwY3k1dmQyNWxjaWdwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXpOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dXeWRFWld4bGRHVkJjSEJzYVdOaGRHbHZiaWRkSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTV6WlhSWGFYUm9aSEpoZDJGc1ZHbHRaVzkxZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRmRwZEdoa2NtRjNZV3hVYVcxbGIzVjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTlRnS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSWGFYUm9aSEpoZDJGc1ZHbHRaVzkxZENoelpXTnZibVJ6T2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVTVDaUFnSUNBdkx5QjBhR2x6TG05dWJIbFBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpnS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzWDNkaGFYUmZkR2x0WlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZDNkM1FuSUgwcENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWQzZDBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTmpFS0lDQWdJQzh2SUhSb2FYTXVkMmwwYUdSeVlYZGhiRjkzWVdsMFgzUnBiV1V1ZG1Gc2RXVWdQU0J6WldOdmJtUnpDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTlRnS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSWGFYUm9aSEpoZDJGc1ZHbHRaVzkxZENoelpXTnZibVJ6T2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxuTmxkRmRwZEdoa2NtRjNZV3hRZFdKclpYbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSWGFYUm9aSEpoZDJGc1VIVmlhMlY1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5qZ0tJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlhhWFJvWkhKaGQyRnNVSFZpYTJWNUtIQjFZbXRsZVRvZ1lubDBaWE04TXpJK0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWTVDaUFnSUNBdkx5QjBhR2x6TG05dWJIbFBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RFS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzWDNCMVltdGxlU0E5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UERNeVBqNG9leUJyWlhrNklDZHdkM0JySnlCOUtRb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0luQjNjR3NpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM01Rb2dJQ0FnTHk4Z2RHaHBjeTUzYVhSb1pISmhkMkZzWDNCMVltdGxlUzUyWVd4MVpTQTlJSEIxWW10bGVRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFk0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwVjJsMGFHUnlZWGRoYkZCMVltdGxlU2h3ZFdKclpYazZJR0o1ZEdWelBETXlQaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFoYVc0dVkyRnlaRU55WldGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oY21SRGNtVmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNE1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUkRjbVZoZEdVb1kyRnlaRTkzYm1WeU9pQkJZMk52ZFc1MExDQmhjM05sZERvZ1FYTnpaWFFwT2lCQlkyTnZkVzUwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpNd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YVhOUVlYSjBibVZ5S0Nrc0lDZFRSVTVFUlZKZlRrOVVYMEZNVEU5WFJVUW5LUW9nSUNBZ1kyRnNiSE4xWWlCcGMxQmhjblJ1WlhJS0lDQWdJR0Z6YzJWeWRDQXZMeUJUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRnMkNpQWdJQ0F2THlCaFpHUnlaWE56T2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRnMExUUTRPUW9nSUNBZ0x5OGdZMjl1YzNRZ1kyRnlaRVJoZEdFNklFTmhjbVJFWVhSaElEMGdld29nSUNBZ0x5OGdJQ0J2ZDI1bGNqb2dZMkZ5WkU5M2JtVnlMQW9nSUNBZ0x5OGdJQ0JoWkdSeVpYTnpPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUc1dmJtTmxPaUF3TEFvZ0lDQWdMeThnSUNCM2FYUm9aSEpoZDJGc1RtOXVZMlU2SURBc0NpQWdJQ0F2THlCOUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGczQ2lBZ0lDQXZMeUJ1YjI1alpUb2dNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE0TkMwME9Ea0tJQ0FnSUM4dklHTnZibk4wSUdOaGNtUkVZWFJoT2lCRFlYSmtSR0YwWVNBOUlIc0tJQ0FnSUM4dklDQWdiM2R1WlhJNklHTmhjbVJQZDI1bGNpd0tJQ0FnSUM4dklDQWdZV1JrY21WemN6b2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0J1YjI1alpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZDJsMGFHUnlZWGRoYkU1dmJtTmxPaUF3TEFvZ0lDQWdMeThnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1TXkwME9UY0tJQ0FnSUM4dklHTnZibk4wSUdOaGNtUkJaR1J5SUQwZ1lYSmpOQzVoWW1sRFlXeHNQSFI1Y0dWdlppQkRiMjUwY205c2JHVmtRV1JrY21WemN5NXdjbTkwYjNSNWNHVXVibVYzUGloN0NpQWdJQ0F2THlBZ0lHRndjSEp2ZG1Gc1VISnZaM0poYlRvZ1kyOXRjR2xzWldSRFlYSmtMbUZ3Y0hKdmRtRnNVSEp2WjNKaGJTd0tJQ0FnSUM4dklDQWdZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMDZJR052YlhCcGJHVmtRMkZ5WkM1amJHVmhjbE4wWVhSbFVISnZaM0poYlN3S0lDQWdJQzh2SUNBZ2IyNURiMjF3YkdWMGFXOXVPaUJQYmtOdmJYQnNaWFJsUVdOMGFXOXVMa1JsYkdWMFpVRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRrMkNpQWdJQ0F2THlCdmJrTnZiWEJzWlhScGIyNDZJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVSR1ZzWlhSbFFYQndiR2xqWVhScGIyNHNDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTVNZ29nSUNBZ0x5OGdZMjl1YzNRZ1kyOXRjR2xzWldSRFlYSmtJRDBnWTI5dGNHbHNaU2hEYjI1MGNtOXNiR1ZrUVdSa2NtVnpjeWtLSUNBZ0lIQjFjMmhpZVhSbGN5QmlZWE5sTmpRb1F6UkZRbEYzUFQwcENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOc1pXRnlVM1JoZEdWUWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUhCMWMyaGllWFJsY3lCaVlYTmxOalFvUTNsQlEwRkJSMEZDUmxsa1RDdHZNa2RuUTA5QlVVRkNRVVJGV21kUlZWTk5VbWRWUlVWU1EwRkJRM2hOWjI5NVJISkpaMGx5U1VseloyTnFjMmhCYVhOblIzcG5RVkZXU0RONE1VMW5jRkZ6UTA1RUtRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnliM1poYkZCeWIyZHlZVzFRWVdkbGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPVE10TkRrM0NpQWdJQ0F2THlCamIyNXpkQ0JqWVhKa1FXUmtjaUE5SUdGeVl6UXVZV0pwUTJGc2JEeDBlWEJsYjJZZ1EyOXVkSEp2Ykd4bFpFRmtaSEpsYzNNdWNISnZkRzkwZVhCbExtNWxkejRvZXdvZ0lDQWdMeThnSUNCaGNIQnliM1poYkZCeWIyZHlZVzA2SUdOdmJYQnBiR1ZrUTJGeVpDNWhjSEJ5YjNaaGJGQnliMmR5WVcwc0NpQWdJQ0F2THlBZ0lHTnNaV0Z5VTNSaGRHVlFjbTluY21GdE9pQmpiMjF3YVd4bFpFTmhjbVF1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBzQ2lBZ0lDQXZMeUFnSUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNUVaV3hsZEdWQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklIMHBMbkpsZEhWeWJsWmhiSFZsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTmpGa01tWmxZU0F2THlCdFpYUm9iMlFnSW01bGR5Z3BZV1JrY21WemN5SUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNREFLSUNBZ0lDOHZJR05oY21SRVlYUmhMbUZrWkhKbGMzTWdQU0JqWVhKa1FXUmtjZ29nSUNBZ2NtVndiR0ZqWlRJZ016SUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBekNpQWdJQ0F2THlCamIyNXpkQ0JoYzNObGRFMWljam9nZFdsdWREWTBJRDBnWVhOelpYUXVhV1FnUHlCSGJHOWlZV3d1WVhOelpYUlBjSFJKYmsxcGJrSmhiR0Z1WTJVZ09pQXdDaUFnSUNCaWVpQmpZWEprUTNKbFlYUmxYM1JsY201aGNubGZabUZzYzJWQU5Bb2dJQ0FnWjJ4dlltRnNJRUZ6YzJWMFQzQjBTVzVOYVc1Q1lXeGhibU5sQ2dwallYSmtRM0psWVhSbFgzUmxjbTVoY25sZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UQTBMVFV3T1FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUdOaGNtUkJaR1J5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1IyeHZZbUZzTG0xcGJrSmhiR0Z1WTJVZ0t5QmhjM05sZEUxaWNpd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3TndvZ0lDQWdMeThnWVcxdmRXNTBPaUJIYkc5aVlXd3ViV2x1UW1Gc1lXNWpaU0FySUdGemMyVjBUV0p5TEFvZ0lDQWdaMnh2WW1Gc0lFMXBia0poYkdGdVkyVUtJQ0FnSUNzS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEEwTFRVd09Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklHTmhjbVJCWkdSeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dSMnh2WW1Gc0xtMXBia0poYkdGdVkyVWdLeUJoYzNObGRFMWljaXdLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEEwTFRVd09Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklHTmhjbVJCWkdSeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dSMnh2WW1Gc0xtMXBia0poYkdGdVkyVWdLeUJoYzNObGRFMWljaXdLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56TUtJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JEWVhKa1JHRjBZVDRvZXlCclpYbFFjbVZtYVhnNklDZGpaaWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1ObUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4TWdvZ0lDQWdMeThnZEdocGN5NWpZWEprY3loallYSmtRV1JrY2lrdWRtRnNkV1VnUFNCamJHOXVaU2hqWVhKa1JHRjBZU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVRVS0lDQWdJQzh2SUhSb2FYTXVZMkZ5WkhOZllXTjBhWFpsWDJOdmRXNTBMblpoYkhWbElEMGdkR2hwY3k1allYSmtjMTloWTNScGRtVmZZMjkxYm5RdWRtRnNkV1VnS3lBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56VUtJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtjMTloWTNScGRtVmZZMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ZMlpoWXljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTm1ZV01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeE5Rb2dJQ0FnTHk4Z2RHaHBjeTVqWVhKa2MxOWhZM1JwZG1WZlkyOTFiblF1ZG1Gc2RXVWdQU0IwYUdsekxtTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDNTJZV3gxWlNBcklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpVS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa2MxOWhZM1JwZG1WZlkyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBblkyWmhZeWNnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1ObVlXTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4TlFvZ0lDQWdMeThnZEdocGN5NWpZWEprYzE5aFkzUnBkbVZmWTI5MWJuUXVkbUZzZFdVZ1BTQjBhR2x6TG1OaGNtUnpYMkZqZEdsMlpWOWpiM1Z1ZEM1MllXeDFaU0FySURFS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhPQW9nSUNBZ0x5OGdhV1lnS0dGemMyVjBMbWxrS1NCN0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWW5vZ1kyRnlaRU55WldGMFpWOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URTVDaUFnSUNBdkx5QjBhR2x6TG1OaGNtUkJjM05sZEU5d2RFbHVLR05oY21SQlpHUnlMQ0JoYzNObGRDa0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUdOaGJHeHpkV0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXRnBiaTVqWVhKa1FYTnpaWFJQY0hSSmJnb0tZMkZ5WkVOeVpXRjBaVjloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV5TWkwMU1qVUtJQ0FnSUM4dklHVnRhWFE4UTJGeVpFTnlaV0YwWldRK0tIc0tJQ0FnSUM4dklDQWdZMkZ5WkU5M2JtVnlPaUJqWVhKa1QzZHVaWElzQ2lBZ0lDQXZMeUFnSUdOaGNtUTZJR05oY21SQlpHUnlMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobU5UTXpOREEwTkNBdkx5QnRaWFJvYjJRZ0lrTmhjbVJEY21WaGRHVmtLR0ZrWkhKbGMzTXNZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0RFS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa1EzSmxZWFJsS0dOaGNtUlBkMjVsY2pvZ1FXTmpiM1Z1ZEN3Z1lYTnpaWFE2SUVGemMyVjBLVG9nUVdOamIzVnVkQ0I3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwallYSmtRM0psWVhSbFgzUmxjbTVoY25sZlptRnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UQXpDaUFnSUNBdkx5QmpiMjV6ZENCaGMzTmxkRTFpY2pvZ2RXbHVkRFkwSUQwZ1lYTnpaWFF1YVdRZ1B5QkhiRzlpWVd3dVlYTnpaWFJQY0hSSmJrMXBia0poYkdGdVkyVWdPaUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQmpZWEprUTNKbFlYUmxYM1JsY201aGNubGZiV1Z5WjJWQU5Rb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1WTJGeVpFTnNiM05sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyRnlaRU5zYjNObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNellLSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprUTJ4dmMyVW9ZMkZ5WkRvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNd29nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVOaGNtUkVZWFJoUGloN0lHdGxlVkJ5WldacGVEb2dKMk5tSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyWWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU16Y0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbU5oY21SektHTmhjbVFwTG1WNGFYTjBjeXdnSjBOQlVrUmZUazlVWDBaUFZVNUVKeWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOQlVrUmZUazlVWDBaUFZVNUVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV6T0FvZ0lDQWdMeThnWTI5dWMzUWdZMkZ5WkU5M2JtVnlJRDBnZEdocGN5NWpZWEprY3loallYSmtLUzUyWVd4MVpTNXZkMjVsY2dvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTTVDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVwYzFCaGNuUnVaWElvS1NCOGZDQmpZWEprVDNkdVpYSWdQVDA5SUZSNGJpNXpaVzVrWlhJc0lDZFRSVTVFUlZKZlRrOVVYMEZNVEU5WFJVUW5LUW9nSUNBZ1kyRnNiSE4xWWlCcGMxQmhjblJ1WlhJS0lDQWdJR0p1ZWlCallYSmtRMnh2YzJWZlltOXZiRjkwY25WbFFETUtJQ0FnSUdSMWNBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHSjZJR05oY21SRGJHOXpaVjlpYjI5c1gyWmhiSE5sUURRS0NtTmhjbVJEYkc5elpWOWliMjlzWDNSeWRXVkFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3BqWVhKa1EyeHZjMlZmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNemtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selVHRnlkRzVsY2lncElIeDhJR05oY21SUGQyNWxjaUE5UFQwZ1ZIaHVMbk5sYm1SbGNpd2dKMU5GVGtSRlVsOU9UMVJmUVV4TVQxZEZSQ2NwQ2lBZ0lDQmhjM05sY25RZ0x5OGdVMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUwTXdvZ0lDQWdMeThnZEdocGN5NWpiR1ZoY2xkcGRHaGtjbUYzWVd4U1pYRjFaWE4wS0dOaGNtUlBkMjVsY2l3Z1kyRnlaQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUdOc1pXRnlWMmwwYUdSeVlYZGhiRkpsY1hWbGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFEzTFRVMU5Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lDQWdZMnh2YzJWU1pXMWhhVzVrWlhKVWJ6b2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOVEFLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxTWdvZ0lDQWdMeThnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyeHZjMlZTWlcxaGFXNWtaWEpVYndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5URUtJQ0FnSUM4dklHRnRiM1Z1ZERvZ01Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRRM0xUVTFNd29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeU9pQmpZWEprTEFvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklEQXNDaUFnSUNBdkx5QWdJQ0FnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTBOeTAxTlRRS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFOd29nSUNBZ0x5OGdkR2hwY3k1allYSmtjeWhqWVhKa0tTNWtaV3hsZEdVb0tRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyTUFvZ0lDQWdMeThnZEdocGN5NWpZWEprYzE5aFkzUnBkbVZmWTI5MWJuUXVkbUZzZFdVZ1BTQjBhR2x6TG1OaGNtUnpYMkZqZEdsMlpWOWpiM1Z1ZEM1MllXeDFaU0F0SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM05Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUnpYMkZqZEdsMlpWOWpiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZGpabUZqSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVkyWmhZeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRZd0NpQWdJQ0F2THlCMGFHbHpMbU5oY21SelgyRmpkR2wyWlY5amIzVnVkQzUyWVd4MVpTQTlJSFJvYVhNdVkyRnlaSE5mWVdOMGFYWmxYMk52ZFc1MExuWmhiSFZsSUMwZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTlFvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SelgyRmpkR2wyWlY5amIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkalptRmpKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWTJaaFl5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFl3Q2lBZ0lDQXZMeUIwYUdsekxtTmhjbVJ6WDJGamRHbDJaVjlqYjNWdWRDNTJZV3gxWlNBOUlIUm9hWE11WTJGeVpITmZZV04wYVhabFgyTnZkVzUwTG5aaGJIVmxJQzBnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTTJDaUFnSUNBdkx5QndkV0pzYVdNZ1kyRnlaRU5zYjNObEtHTmhjbVE2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21OaGNtUkRiRzl6WlY5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCallYSmtRMnh2YzJWZlltOXZiRjl0WlhKblpVQTFDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV0ZwYmk1allYSmtVbVZqYjNabGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oY21SU1pXTnZkbVZ5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU56QUtJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtVbVZqYjNabGNpaGpZWEprT2lCQlkyTnZkVzUwTENCdVpYZERZWEprU0c5c1pHVnlPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOekVLSUNBZ0lDOHZJSFJvYVhNdWIyNXNlVTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnYjI1c2VVOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM013b2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRU5oY21SRVlYUmhQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTm1KeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTJZaUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzTWdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVkyRnlaSE1vWTJGeVpDa3VaWGhwYzNSekxDQW5RMEZTUkY5T1QxUmZSazlWVGtRbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRRVkpFWDA1UFZGOUdUMVZPUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU56UUtJQ0FnSUM4dklHTnZibk4wSUc5c1pFTmhjbVJJYjJ4a1pYSWdQU0IwYUdsekxtTmhjbVJ6S0dOaGNtUXBMblpoYkhWbExtOTNibVZ5Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM09Bb2dJQ0FnTHk4Z2RHaHBjeTVqYkdWaGNsZHBkR2hrY21GM1lXeFNaWEYxWlhOMEtHOXNaRU5oY21SSWIyeGtaWElzSUdOaGNtUXBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNCallXeHNjM1ZpSUdOc1pXRnlWMmwwYUdSeVlYZGhiRkpsY1hWbGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGd3Q2lBZ0lDQXZMeUIwYUdsekxtTmhjbVJ6S0dOaGNtUXBMblpoYkhWbExtOTNibVZ5SUQwZ2JtVjNRMkZ5WkVodmJHUmxjZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdScFp5QXpDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9ESXROVGcyQ2lBZ0lDQXZMeUJsYldsMFBFTmhjbVJTWldOdmRtVnlaV1ErS0hzS0lDQWdJQzh2SUNBZ1kyRnlaRG9nWTJGeVpDd0tJQ0FnSUM4dklDQWdiMnhrUTJGeVpFOTNibVZ5T2lCdmJHUkRZWEprU0c5c1pHVnlMQW9nSUNBZ0x5OGdJQ0J1WlhkRFlYSmtUM2R1WlhJNklHNWxkME5oY21SSWIyeGtaWElzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdNM09HTXlORFVnTHk4Z2JXVjBhRzlrSUNKRFlYSmtVbVZqYjNabGNtVmtLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzTUFvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SU1pXTnZkbVZ5S0dOaGNtUTZJRUZqWTI5MWJuUXNJRzVsZDBOaGNtUkliMnhrWlhJNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTllXbHVMbU5oY21SRVpXSnBkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OaGNtUkVaV0pwZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qQXhDaUFnSUNBdkx5QndkV0pzYVdNZ1kyRnlaRVJsWW1sMEtHTmhjbVJQZDI1bGNqb2dRV05qYjNWdWRDd2dZMkZ5WkRvZ1FXTmpiM1Z1ZEN3Z1lYTnpaWFE2SUVGemMyVjBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5Dd2dibTl1WTJVNklIVnBiblEyTkN3Z2NtVm1PaUJ6ZEhKcGJtY3BPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxMQ0FuUTA5T1ZGSkJRMVJmVUVGVlUwVkVKeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZFhObFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdKdmIyeGxZVzQrS0NrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5CaGRYTmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVjR0YxYzJWa0xuWmhiSFZsTENBblEwOU9WRkpCUTFSZlVFRlZVMFZFSnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1EwOU9WRkpCUTFSZlVFRlZVMFZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhkcGRHaGtjbUYzWDI5d1pYSmhkRzl5Y3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQW5kMjl3SnlCOUtRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWQyOXdJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuZHBkR2hrY21GM1gyOXdaWEpoZEc5eWN5aFVlRzR1YzJWdVpHVnlLUzVsZUdsemRITXNJQ2RUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFuS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RVS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMTl2Y0dWeVlYUnZjbk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZHZjQ2NnZlNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOREFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5kcGRHaGtjbUYzWDI5d1pYSmhkRzl5Y3loVWVHNHVjMlZ1WkdWeUtTNWxlR2x6ZEhNc0lDZFRSVTVFUlZKZlRrOVVYMEZNVEU5WFJVUW5LUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVTBWT1JFVlNYMDVQVkY5QlRFeFBWMFZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM013b2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRU5oY21SRVlYUmhQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTm1KeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTJZaUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3TmdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVkyRnlaSE1vWTJGeVpDa3VkbUZzZFdVdWIzZHVaWElnUFQwOUlHTmhjbVJQZDI1bGNpd2dKMDlYVGtWU1gwbE9Wa0ZNU1VRbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUFYwNUZVbDlKVGxaQlRFbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3T1FvZ0lDQWdMeThnWTI5dWMzUWdibVY0ZEU1dmJtTmxPaUIxYVc1ME5qUWdQU0IwYUdsekxtTmhjbVJ6S0dOaGNtUXBMblpoYkhWbExtNXZibU5sQ2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVRBS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhoMFRtOXVZMlVnUFQwOUlHNXZibU5sTENBblRrOU9RMFZmU1U1V1FVeEpSQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFNVBUa05GWDBsT1ZrRk1TVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpFeUxUWXlNQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJSFJvYVhNdWIyMXVhV0oxYzE5aFpHUnlaWE56TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbE9pQnlaV1lzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1UVUtJQ0FnSUM4dklHRnpjMlYwVW1WalpXbDJaWEk2SUhSb2FYTXViMjF1YVdKMWMxOWhaR1J5WlhOekxuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRreENpQWdJQ0F2THlCd2RXSnNhV01nYjIxdWFXSjFjMTloWkdSeVpYTnpJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnJaWGs2SUNkdllTY2dmU2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbTloSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1UVUtJQ0FnSUM4dklHRnpjMlYwVW1WalpXbDJaWEk2SUhSb2FYTXViMjF1YVdKMWMxOWhaR1J5WlhOekxuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTV2ZEdVS0lDQWdJR1JwWnlBMUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JrYVdjZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeE1pMDJNVGtLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2pvZ1kyRnlaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUIwYUdsekxtOXRibWxpZFhOZllXUmtjbVZ6Y3k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnYm05MFpUb2djbVZtTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakV5TFRZeU1Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlPaUJqWVhKa0xBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklIUm9hWE11YjIxdWFXSjFjMTloWkdSeVpYTnpMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnViM1JsT2lCeVpXWXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpJeUxUWXlPQW9nSUNBZ0x5OGdaVzFwZER4RVpXSnBkRDRvZXdvZ0lDQWdMeThnSUNCallYSmtPaUJqWVhKa0xBb2dJQ0FnTHk4Z0lDQmhjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0J1YjI1alpUb2dibTl1WTJVc0NpQWdJQ0F2THlBZ0lISmxabVZ5Wlc1alpUb2djbVZtTEFvZ0lDQWdMeThnZlNrS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRE5oQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9UazBZVEV6TmpjZ0x5OGdiV1YwYUc5a0lDSkVaV0pwZENoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1WnlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNekVLSUNBZ0lDOHZJSFJvYVhNdVkyRnlaSE1vWTJGeVpDa3VkbUZzZFdVdWJtOXVZMlVnUFNCdVpYaDBUbTl1WTJVZ0t5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdsdWRDQTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qQXhDaUFnSUNBdkx5QndkV0pzYVdNZ1kyRnlaRVJsWW1sMEtHTmhjbVJQZDI1bGNqb2dRV05qYjNWdWRDd2dZMkZ5WkRvZ1FXTmpiM1Z1ZEN3Z1lYTnpaWFE2SUVGemMyVjBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5Dd2dibTl1WTJVNklIVnBiblEyTkN3Z2NtVm1PaUJ6ZEhKcGJtY3BPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5ZV2x1TG1kbGRFNWxlSFJEWVhKa1RtOXVZMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUk9aWGgwUTJGeVpFNXZibU5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lFTmhjbVJFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJObUp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMllpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qUXlDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVqWVhKa2N5aGpZWEprS1M1MllXeDFaUzV1YjI1alpRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdWNGRISmhZM1FnTmpRZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOREFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxaGFXNHVaMlYwUTJGeVpFUmhkR0ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkRZWEprUkdGMFlUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalV4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56TUtJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JEWVhKa1JHRjBZVDRvZXlCclpYbFFjbVZtYVhnNklDZGpaaWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1ObUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkxTXdvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVkyRnlaSE1vWTJGeVpDa3VkbUZzZFdVS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdGcGJpNXpaWFJRWVhKMGJtVnlRV1JrY21WemMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZCaGNuUnVaWEpCWkdSeVpYTnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmpJS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSUVlYSjBibVZ5UVdSa2NtVnpjeWh1WlhkUVlYSjBibVZ5UVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyTXdvZ0lDQWdMeThnZEdocGN5NXZibXg1VDNkdVpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCdmJteDVUM2R1WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzRDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRnlkRzVsY2w5aFpHUnlaWE56SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklDZHdZU2NnZlNrS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKd1lTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalkxQ2lBZ0lDQXZMeUIwYUdsekxuQmhjblJ1WlhKZllXUmtjbVZ6Y3k1MllXeDFaU0E5SUc1bGQxQmhjblJ1WlhKQlpHUnlaWE56Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5qSUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlFZWEowYm1WeVFXUmtjbVZ6Y3lodVpYZFFZWEowYm1WeVFXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxaGFXNHVjMlYwVDIxdWFXSjFjMEZrWkhKbGMzTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSUGJXNXBZblZ6UVdSa2NtVnpjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjMENpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFQyMXVhV0oxYzBGa1pISmxjM01vYm1WM1QyMXVhV0oxYzBGa1pISmxjM002SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTnpVS0lDQWdJQzh2SUhSb2FYTXViMjVzZVU5M2JtVnlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2IyNXNlVTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVNUW9nSUNBZ0x5OGdjSFZpYkdsaklHOXRibWxpZFhOZllXUmtjbVZ6Y3lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYTJWNU9pQW5iMkVuSUgwcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKdllTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamMzQ2lBZ0lDQXZMeUIwYUdsekxtOXRibWxpZFhOZllXUmtjbVZ6Y3k1MllXeDFaU0E5SUc1bGQwOXRibWxpZFhOQlpHUnlaWE56Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk56UUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlBiVzVwWW5WelFXUmtjbVZ6Y3lodVpYZFBiVzVwWW5WelFXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxaGFXNHVjMlYwUzJsc2JITjNhWFJqYUVGd2NGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEV0cGJHeHpkMmwwWTJoQmNIQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk0T0FvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEV0cGJHeHpkMmwwWTJoQmNIQW9ibVYzUzJsc2JITjNhWFJqYUVGd2NEb2dRWEJ3YkdsallYUnBiMjRwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZzVDaUFnSUNBdkx5QjBhR2x6TG05dWJIbFBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURBS0lDQWdJQzh2SUhCMVlteHBZeUJyYVd4c2MzZHBkR05vWDJGd2NDQTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ0oydHpKeUI5S1FvZ0lDQWdZbmwwWldNZ09TQXZMeUFpYTNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTVNUW9nSUNBZ0x5OGdkR2hwY3k1cmFXeHNjM2RwZEdOb1gyRndjQzUyWVd4MVpTQTlJRzVsZDB0cGJHeHpkMmwwWTJoQmNIQUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk0T0FvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEV0cGJHeHpkMmwwWTJoQmNIQW9ibVYzUzJsc2JITjNhWFJqYUVGd2NEb2dRWEJ3YkdsallYUnBiMjRwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtRmtaRmRwZEdoa2NtRjNUM0JsY21GMGIzSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWkdSWGFYUm9aSEpoZDA5d1pYSmhkRzl5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01EQUtJQ0FnSUM4dklIQjFZbXhwWXlCaFpHUlhhWFJvWkhKaGQwOXdaWEpoZEc5eUtHOXdaWEpoZEc5eU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56QXhDaUFnSUNBdkx5QjBhR2x6TG05dWJIbFBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RVS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMTl2Y0dWeVlYUnZjbk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZHZjQ2NnZlNrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5kdmNDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTURNS0lDQWdJQzh2SUhSb2FYTXVkMmwwYUdSeVlYZGZiM0JsY21GMGIzSnpLRzl3WlhKaGRHOXlLUzUyWVd4MVpTQTlJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjd01Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdGa1pGZHBkR2hrY21GM1QzQmxjbUYwYjNJb2IzQmxjbUYwYjNJNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTllXbHVMbkpsYlc5MlpWZHBkR2hrY21GM1QzQmxjbUYwYjNKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaVzF2ZG1WWGFYUm9aSEpoZDA5d1pYSmhkRzl5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01USUtJQ0FnSUM4dklIQjFZbXhwWXlCeVpXMXZkbVZYYVhSb1pISmhkMDl3WlhKaGRHOXlLRzl3WlhKaGRHOXlPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOekV6Q2lBZ0lDQXZMeUIwYUdsekxtOXViSGxQZDI1bGNpZ3BDaUFnSUNCallXeHNjM1ZpSUc5dWJIbFBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9UVUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDE5dmNHVnlZWFJ2Y25NZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dKM2R2Y0NjZ2ZTa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luZHZjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01UVUtJQ0FnSUM4dklIUm9hWE11ZDJsMGFHUnlZWGRmYjNCbGNtRjBiM0p6S0c5d1pYSmhkRzl5S1M1a1pXeGxkR1VvS1FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3hNZ29nSUNBZ0x5OGdjSFZpYkdsaklISmxiVzkyWlZkcGRHaGtjbUYzVDNCbGNtRjBiM0lvYjNCbGNtRjBiM0k2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtTmhjbVJFYVhOaFlteGxRWE56WlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZWEprUkdsellXSnNaVUZ6YzJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNek1LSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprUkdsellXSnNaVUZ6YzJWMEtHTmhjbVE2SUVGalkyOTFiblFzSUdGemMyVjBPaUJCYzNObGRDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3pDaUFnSUNBdkx5QndkV0pzYVdNZ1kyRnlaSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnUTJGeVpFUmhkR0UrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZMlluSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKalppSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTXpRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtTmhjbVJ6S0dOaGNtUXBMbVY0YVhOMGN5d2dKME5CVWtSZlRrOVVYMFpQVlU1RUp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRMEZTUkY5T1QxUmZSazlWVGtRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56TTFDaUFnSUNBdkx5QmpiMjV6ZENCallYSmtUM2R1WlhJZ1BTQjBhR2x6TG1OaGNtUnpLR05oY21RcExuWmhiSFZsTG05M2JtVnlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM016WUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbWx6VUdGeWRHNWxjaWdwSUh4OElHTmhjbVJQZDI1bGNpQTlQVDBnVkhodUxuTmxibVJsY2l3Z0oxTkZUa1JGVWw5T1QxUmZRVXhNVDFkRlJDY3BDaUFnSUNCallXeHNjM1ZpSUdselVHRnlkRzVsY2dvZ0lDQWdZbTU2SUdOaGNtUkVhWE5oWW14bFFYTnpaWFJmWW05dmJGOTBjblZsUURNS0lDQWdJR1JwWnlBeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZMkZ5WkVScGMyRmliR1ZCYzNObGRGOWliMjlzWDJaaGJITmxRRFFLQ21OaGNtUkVhWE5oWW14bFFYTnpaWFJmWW05dmJGOTBjblZsUURNNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvS1kyRnlaRVJwYzJGaWJHVkJjM05sZEY5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN6TmdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWFYTlFZWEowYm1WeUtDa2dmSHdnWTJGeVpFOTNibVZ5SUQwOVBTQlVlRzR1YzJWdVpHVnlMQ0FuVTBWT1JFVlNYMDVQVkY5QlRFeFBWMFZFSnlrS0lDQWdJR0Z6YzJWeWRDQXZMeUJUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprNUxUTXdOd29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJR05oY21Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSRGJHOXpaVlJ2T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1EVUtJQ0FnSUM4dklHRnpjMlYwUVcxdmRXNTBPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJEYkc5elpWUnZDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Ua3RNekEyQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFTnNiM05sVkc4NklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1T1Mwek1EY0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQmpZWEprTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUTJ4dmMyVlViem9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd09Rb2dJQ0FnTHk4Z2FXWWdLR05oY21RdVltRnNZVzVqWlNBK0lHTmhjbVF1YldsdVFtRnNZVzVqWlNrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdjM2RoY0FvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JOYVc1Q1lXeGhibU5sQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJRDRLSUNBZ0lHSjZJR05oY21SRWFYTmhZbXhsUVhOelpYUmZZV1owWlhKZmFXWmZaV3h6WlVBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhNQzB6TVRZS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJqWVhKa0xtSmhiR0Z1WTJVZ0xTQmpZWEprTG0xcGJrSmhiR0Z1WTJVc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNVE1LSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TkFvZ0lDQWdMeThnWVcxdmRXNTBPaUJqWVhKa0xtSmhiR0Z1WTJVZ0xTQmpZWEprTG0xcGJrSmhiR0Z1WTJVc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdaR2xuSURFS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVFdsdVFtRnNZVzVqWlFvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdablZ1WkdWa0NpQWdJQ0F0Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekV3TFRNeE5Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdOaGNtUXVZbUZzWVc1alpTQXRJR05oY21RdWJXbHVRbUZzWVc1alpTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RXdMVE14TmdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlPaUJqWVhKa0xBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJR05oY21RdVltRnNZVzVqWlNBdElHTmhjbVF1YldsdVFtRnNZVzVqWlN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tZMkZ5WkVScGMyRmliR1ZCYzNObGRGOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhPUzB6TWpJS0lDQWdJQzh2SUdWdGFYUThRMkZ5WkVGemMyVjBSR2x6WVdKc1pXUStLSHNLSUNBZ0lDOHZJQ0FnWTJGeVpEb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ1lYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RCa056ZG1NekVnTHk4Z2JXVjBhRzlrSUNKRFlYSmtRWE56WlhSRWFYTmhZbXhsWkNoaFpHUnlaWE56TEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5qTUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NXJhV3hzYzNkcGRHTm9YMkZ3Y0M1b1lYTldZV3gxWlNrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQXdDaUFnSUNBdkx5QndkV0pzYVdNZ2EybHNiSE4zYVhSamFGOWhjSEFnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJQ2RyY3ljZ2ZTa0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltdHpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmpNS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1cmFXeHNjM2RwZEdOb1gyRndjQzVvWVhOV1lXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZMkZ5WkVScGMyRmliR1ZCYzNObGRGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1YTJsc2JFUmxiR1ZuWVhScGIyNUFNVE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZM0xUTTNNQW9nSUNBZ0x5OGdZWEpqTkM1aFltbERZV3hzUEhSNWNHVnZaaUJMYVd4c2MzZHBkR05vTG5CeWIzUnZkSGx3WlM1cmFXeHNSbTl5UGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCMGFHbHpMbXRwYkd4emQybDBZMmhmWVhCd0xuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiYjNkdVpYSXNJR0Z6YzJWMFhTd0tJQ0FnSUM4dklIMHBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJPQW9nSUNBZ0x5OGdZWEJ3U1dRNklIUm9hWE11YTJsc2JITjNhWFJqYUY5aGNIQXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EQUtJQ0FnSUM4dklIQjFZbXhwWXlCcmFXeHNjM2RwZEdOb1gyRndjQ0E5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dKMnR6SnlCOUtRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWEzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yT0FvZ0lDQWdMeThnWVhCd1NXUTZJSFJvYVhNdWEybHNiSE4zYVhSamFGOWhjSEF1ZG1Gc2RXVXNDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yTnkwek56QUtJQ0FnSUM4dklHRnlZelF1WVdKcFEyRnNiRHgwZVhCbGIyWWdTMmxzYkhOM2FYUmphQzV3Y205MGIzUjVjR1V1YTJsc2JFWnZjajRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nZEdocGN5NXJhV3hzYzNkcGRHTm9YMkZ3Y0M1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMjkzYm1WeUxDQmhjM05sZEYwc0NpQWdJQ0F2THlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE4ySmlPVE5rWVRJZ0x5OGdiV1YwYUc5a0lDSnJhV3hzUm05eUtHRmtaSEpsYzNNc2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LWTJGeVpFUnBjMkZpYkdWQmMzTmxkRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFoYVc0dWEybHNiRVJsYkdWbllYUnBiMjVBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3pNd29nSUNBZ0x5OGdjSFZpYkdsaklHTmhjbVJFYVhOaFlteGxRWE56WlhRb1kyRnlaRG9nUVdOamIzVnVkQ3dnWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGpZWEprUkdsellXSnNaVUZ6YzJWMFgySnZiMnhmWm1Gc2MyVkFORG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHTmhjbVJFYVhOaFlteGxRWE56WlhSZlltOXZiRjl0WlhKblpVQTFDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV0ZwYmk1M2FYUm9aSEpoZDJGc1VtVnhkV1Z6ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHBkR2hrY21GM1lXeFNaWEYxWlhOME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNORGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNuVG05UGNDZGRJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelV3Q2lBZ0lDQXZMeUIwYUdsekxtOXViSGxEWVhKa1QzZHVaWElvWTJGeVpDa0tJQ0FnSUdScFp5QXlDaUFnSUNCallXeHNjM1ZpSUc5dWJIbERZWEprVDNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZMkZ5WkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1EyRnlaRVJoZEdFK0tIc2dhMlY1VUhKbFptbDRPaUFuWTJZbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpaaUlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56VXhDaUFnSUNBdkx5QmpiMjV6ZENCallYSmtSR0YwWVNBOUlHTnNiMjVsS0hSb2FYTXVZMkZ5WkhNb1kyRnlaQ2t1ZG1Gc2RXVXBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTlRJS0lDQWdJQzh2SUdOdmJuTjBJRnRpWVd4aGJtTmxYU0E5SUc5d0xrRnpjMlYwU0c5c1pHbHVaeTVoYzNObGRFSmhiR0Z1WTJVb1kyRnlaQ3dnWVhOelpYUXBDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHRnpjMlYwWDJodmJHUnBibWRmWjJWMElFRnpjMlYwUW1Gc1lXNWpaUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMxTXdvZ0lDQWdMeThnWVhOelpYSjBLR0Z0YjNWdWRDQThQU0JpWVd4aGJtTmxMQ0FuU1U1VFZVWkdTVU5KUlU1VVgwSkJURUZPUTBVbktRb2dJQ0FnWkdsbklESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnU1U1VFZVWkdTVU5KUlU1VVgwSkJURUZPUTBVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56VTNDaUFnSUNBdkx5QnlaV05wY0dsbGJuUTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyTUFvZ0lDQWdMeThnWTNKbFlYUmxaRUYwT2lCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdMQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTmpFS0lDQWdJQzh2SUc1dmJtTmxPaUJqWVhKa1JHRjBZUzUzYVhSb1pISmhkMkZzVG05dVkyVXNDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdOeklnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05UVXROell5Q2lBZ0lDQXZMeUJqYjI1emRDQjNhWFJvWkhKaGQyRnNPaUJYYVhSb1pISmhkMkZzVW1WeGRXVnpkQ0E5SUhzS0lDQWdJQzh2SUNBZ1kyRnlaRG9nWTJGeVpDd0tJQ0FnSUM4dklDQWdjbVZqYVhCcFpXNTBPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCaGMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQmpjbVZoZEdWa1FYUTZJRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBc0NpQWdJQ0F2THlBZ0lHNXZibU5sT2lCallYSmtSR0YwWVM1M2FYUm9aSEpoZDJGc1RtOXVZMlVzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMUNpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZMENpQWdJQ0F2THlCMGFHbHpMbmRwZEdoa2NtRjNZV3h6S0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ1kyeHZibVVvZDJsMGFHUnlZWGRoYkNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMUNpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZMENpQWdJQ0F2THlCMGFHbHpMbmRwZEdoa2NtRjNZV3h6S0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ1kyeHZibVVvZDJsMGFHUnlZWGRoYkNrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyTmdvZ0lDQWdMeThnWlcxcGREeFhhWFJvWkhKaGQyRnNVbVZ4ZFdWemRENG9kMmwwYUdSeVlYZGhiQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1E0TldZMk1qQmhJQzh2SUcxbGRHaHZaQ0FpVjJsMGFHUnlZWGRoYkZKbGNYVmxjM1FvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56UTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMDV2VDNBblhTQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFoYVc0dWQybDBhR1J5WVhkaGJFTmhibU5sYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHBkR2hrY21GM1lXeERZVzVqWld3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzNOUW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1lXeERZVzVqWld3b1kyRnlaRG9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMzTmdvZ0lDQWdMeThnZEdocGN5NXZibXg1UTJGeVpFOTNibVZ5S0dOaGNtUXBDaUFnSUNCallXeHNjM1ZpSUc5dWJIbERZWEprVDNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGcxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZGhiSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVjJsMGFHUnlZWGRoYkZKbGNYVmxjM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQW5kM0luSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKM2NpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemMzQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1M2FYUm9aSEpoZDJGc2N5aFVlRzR1YzJWdVpHVnlLUzVsZUdsemRITXNJQ2RYU1ZSSVJGSkJWMEZNWDFKRlVWVkZVMVJmVGs5VVgwWlBWVTVFSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMUNpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1bGVHbHpkSE1zSUNkWFNWUklSRkpCVjBGTVgxSkZVVlZGVTFSZlRrOVVYMFpQVlU1RUp5a0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRmRKVkVoRVVrRlhRVXhmVWtWUlZVVlRWRjlPVDFSZlJrOVZUa1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMUNpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjNENpQWdJQ0F2THlCamIyNXpkQ0IzYVhSb1pISmhkMkZzSUQwZ1kyeHZibVVvZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGcxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZGhiSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVjJsMGFHUnlZWGRoYkZKbGNYVmxjM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQW5kM0luSUgwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemM0Q2lBZ0lDQXZMeUJqYjI1emRDQjNhWFJvWkhKaGQyRnNJRDBnWTJ4dmJtVW9kR2hwY3k1M2FYUm9aSEpoZDJGc2N5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TlFvZ0lDQWdMeThnY0hWaWJHbGpJSGRwZEdoa2NtRjNZV3h6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUZkcGRHaGtjbUYzWVd4U1pYRjFaWE4wUGloN0lHdGxlVkJ5WldacGVEb2dKM2R5SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWQzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMzT1FvZ0lDQWdMeThnZEdocGN5NTNhWFJvWkhKaGQyRnNjeWhVZUc0dWMyVnVaR1Z5S1M1a1pXeGxkR1VvS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RVS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCWGFYUm9aSEpoZDJGc1VtVnhkV1Z6ZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2QzY2ljZ2ZTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTnprS0lDQWdJQzh2SUhSb2FYTXVkMmwwYUdSeVlYZGhiSE1vVkhodUxuTmxibVJsY2lrdVpHVnNaWFJsS0NrS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPREFLSUNBZ0lDOHZJR1Z0YVhROFYybDBhR1J5WVhkaGJGSmxjWFZsYzNSRFlXNWpaV3hzWldRK0tIZHBkR2hrY21GM1lXd3BDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURZMElEZ0tJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURjeUlEZ0tJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURnd0lEZ0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdaWGgwY21GamRDQTRPQ0E0Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURFeklDOHZJRzFsZEdodlpDQWlWMmwwYUdSeVlYZGhiRkpsY1hWbGMzUkRZVzVqWld4c1pXUW9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTnpVS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzUTJGdVkyVnNLR05oY21RNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTllXbHVMbmRwZEdoa2NtRjNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZDJsMGFHUnlZWGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNE53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZE9iMDl3SjEwZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0RrS0lDQWdJQzh2SUhSb2FYTXViMjVzZVVOaGNtUlBkMjVsY2loallYSmtLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ2IyNXNlVU5oY21SUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RVS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCWGFYUm9aSEpoZDJGc1VtVnhkV1Z6ZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2QzY2ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luZHlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1RBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuZHBkR2hrY21GM1lXeHpLRlI0Ymk1elpXNWtaWElwTG1WNGFYTjBjeXdnSjFkSlZFaEVVa0ZYUVV4ZlVrVlJWVVZUVkY5T1QxUmZSazlWVGtRbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9EVUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDJGc2N5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQlhhWFJvWkhKaGQyRnNVbVZ4ZFdWemRENG9leUJyWlhsUWNtVm1hWGc2SUNkM2NpY2dmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09UQUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbmRwZEdoa2NtRjNZV3h6S0ZSNGJpNXpaVzVrWlhJcExtVjRhWE4wY3l3Z0oxZEpWRWhFVWtGWFFVeGZVa1ZSVlVWVFZGOU9UMVJmUms5VlRrUW5LUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVjBsVVNFUlNRVmRCVEY5U1JWRlZSVk5VWDA1UFZGOUdUMVZPUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56TUtJQ0FnSUM4dklIQjFZbXhwWXlCallYSmtjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JEWVhKa1JHRjBZVDRvZXlCclpYbFFjbVZtYVhnNklDZGpaaWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1ObUlnb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1RFS0lDQWdJQzh2SUdOdmJuTjBJR05oY21SRVlYUmhJRDBnWTJ4dmJtVW9kR2hwY3k1allYSmtjeWhqWVhKa0tTNTJZV3gxWlNrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROUW9nSUNBZ0x5OGdjSFZpYkdsaklIZHBkR2hrY21GM1lXeHpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRmRwZEdoa2NtRjNZV3hTWlhGMVpYTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZHlKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZDNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzVNZ29nSUNBZ0x5OGdZMjl1YzNRZ2QybDBhR1J5WVhkaGJDQTlJR05zYjI1bEtIUm9hWE11ZDJsMGFHUnlZWGRoYkhNb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhkcGRHaGtjbUYzWVd4eklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lGZHBkR2hrY21GM1lXeFNaWEYxWlhOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNkeUp5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNU1nb2dJQ0FnTHk4Z1kyOXVjM1FnZDJsMGFHUnlZWGRoYkNBOUlHTnNiMjVsS0hSb2FYTXVkMmwwYUdSeVlYZGhiSE1vVkhodUxuTmxibVJsY2lrdWRtRnNkV1VwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09UTUtJQ0FnSUM4dklHRnpjMlZ5ZENoaGJXOTFiblFnUEQwZ2QybDBhR1J5WVhkaGJDNWhiVzkxYm5Rc0lDZEJUVTlWVGxSZlNVNVdRVXhKUkNjcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJUVTlWVGxSZlNVNVdRVXhKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09UUUtJQ0FnSUM4dklHRnpjMlZ5ZENoallYSmtSR0YwWVM1M2FYUm9aSEpoZDJGc1RtOXVZMlVnUFQwOUlIZHBkR2hrY21GM1lXd3VibTl1WTJVc0lDZE9UMDVEUlY5SlRsWkJURWxFSnlrS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdOeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTRPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFNVBUa05GWDBsT1ZrRk1TVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnprMUNpQWdJQ0F2THlCaGMzTmxjblFvZDJsMGFHUnlZWGRoYkM1allYSmtJRDA5UFNCallYSmtMQ0FuUTBGU1JGOU5TVk5OUVZSRFNDY3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCa2FXY2dOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRFFWSkVYMDFKVTAxQlZFTklDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM1TndvZ0lDQWdMeThnWTI5dWMzUWdjbVZzWldGelpWUnBiV1U2SUhWcGJuUTJOQ0E5SUhkcGRHaGtjbUYzWVd3dVkzSmxZWFJsWkVGMElDc2dkR2hwY3k1M2FYUm9aSEpoZDJGc1gzZGhhWFJmZEdsdFpTNTJZV3gxWlFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdPREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpnS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkMkZzWDNkaGFYUmZkR2x0WlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZDNkM1FuSUgwcENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWQzZDBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1RjS0lDQWdJQzh2SUdOdmJuTjBJSEpsYkdWaGMyVlVhVzFsT2lCMWFXNTBOalFnUFNCM2FYUm9aSEpoZDJGc0xtTnlaV0YwWldSQmRDQXJJSFJvYVhNdWQybDBhR1J5WVhkaGJGOTNZV2wwWDNScGJXVXVkbUZzZFdVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1RnS0lDQWdJQzh2SUdGemMyVnlkQ2hIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0lENDlJSEpsYkdWaGMyVlVhVzFsTENBblYwbFVTRVJTUVZkQlRGOVVTVTFGWDBsT1ZrRk1TVVFuS1FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlhTVlJJUkZKQlYwRk1YMVJKVFVWZlNVNVdRVXhKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1ETUtJQ0FnSUM4dklIZHBkR2hrY21GM1lXd3VZWE56WlhRc0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd3TVMwNE1EZ0tJQ0FnSUM4dklIUm9hWE11ZDJsMGFHUnlZWGRHZFc1a2N5Z0tJQ0FnSUM4dklDQWdZMkZ5WkN3S0lDQWdJQzh2SUNBZ2QybDBhR1J5WVhkaGJDNWhjM05sZEN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCM2FYUm9aSEpoZDJGc0xtTnlaV0YwWldSQmRDd0tJQ0FnSUM4dklDQWdkMmwwYUdSeVlYZGhiQzV1YjI1alpTd0tJQ0FnSUM4dklDQWdWMmwwYUdSeVlYZGhiRlI1Y0dWUVpYSnRhWE56YVc5dVRHVnpjeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1EY0tJQ0FnSUM4dklGZHBkR2hrY21GM1lXeFVlWEJsVUdWeWJXbHpjMmx2Ymt4bGMzTXNDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWljR1Z5YldsemMybHZibXhsYzNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3dNUzA0TURnS0lDQWdJQzh2SUhSb2FYTXVkMmwwYUdSeVlYZEdkVzVrY3lnS0lDQWdJQzh2SUNBZ1kyRnlaQ3dLSUNBZ0lDOHZJQ0FnZDJsMGFHUnlZWGRoYkM1aGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0IzYVhSb1pISmhkMkZzTG1OeVpXRjBaV1JCZEN3S0lDQWdJQzh2SUNBZ2QybDBhR1J5WVhkaGJDNXViMjVqWlN3S0lDQWdJQzh2SUNBZ1YybDBhR1J5WVhkaGJGUjVjR1ZRWlhKdGFYTnphVzl1VEdWemN5d0tJQ0FnSUM4dklDa0tJQ0FnSUdOaGJHeHpkV0lnZDJsMGFHUnlZWGRHZFc1a2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRFVLSUNBZ0lDOHZJSEIxWW14cFl5QjNhWFJvWkhKaGQyRnNjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JYYVhSb1pISmhkMkZzVW1WeGRXVnpkRDRvZXlCclpYbFFjbVZtYVhnNklDZDNjaWNnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5keUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNRGtLSUNBZ0lDOHZJSFJvYVhNdWQybDBhR1J5WVhkaGJITW9WSGh1TG5ObGJtUmxjaWt1WkdWc1pYUmxLQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGcxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZGhiSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVjJsMGFHUnlZWGRoYkZKbGNYVmxjM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQW5kM0luSUgwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREE1Q2lBZ0lDQXZMeUIwYUdsekxuZHBkR2hrY21GM1lXeHpLRlI0Ymk1elpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56ZzNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMDV2VDNBblhTQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFoYVc0dWQybDBhR1J5WVhkUVpYSnRhWE56YVc5dVpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1pISmhkMUJsY20xcGMzTnBiMjVsWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ESXdMVGd5TndvZ0lDQWdMeThnY0hWaWJHbGpJSGRwZEdoa2NtRjNVR1Z5YldsemMybHZibVZrS0FvZ0lDQWdMeThnSUNCallYSmtPaUJCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0JoYzNObGREb2dRWE56WlhRc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCbGVIQnBjbVZ6UVhRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2JtOXVZMlU2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYzJsbmJtRjBkWEpsT2lCaWVYUmxjencyTkQ0c0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURZS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dOalErQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pneU9Bb2dJQ0FnTHk4Z2RHaHBjeTV2Ym14NVEyRnlaRTkzYm1WeUtHTmhjbVFwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQnZibXg1UTJGeVpFOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM013b2dJQ0FnTHk4Z2NIVmliR2xqSUdOaGNtUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRU5oY21SRVlYUmhQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTm1KeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTJZaUNpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd5T1FvZ0lDQWdMeThnWTI5dWMzUWdZMkZ5WkVSaGRHRWdQU0JqYkc5dVpTaDBhR2x6TG1OaGNtUnpLR05oY21RcExuWmhiSFZsS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ETXhDaUFnSUNBdkx5QmhjM05sY25Rb1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ0E4SUdWNGNHbHlaWE5CZEN3Z0oxZEpWRWhFVWtGWFFVeGZWRWxOUlY5SlRsWkJURWxFSnlrS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR1JwWnlBekNpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdWMGxVU0VSU1FWZEJURjlVU1UxRlgwbE9Wa0ZNU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ETXlDaUFnSUNBdkx5QmhjM05sY25Rb1kyRnlaRVJoZEdFdWQybDBhR1J5WVhkaGJFNXZibU5sSUQwOVBTQnViMjVqWlN3Z0owNVBUa05GWDBsT1ZrRk1TVVFuS1FvZ0lDQWdjSFZ6YUdsdWRDQTNNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTndvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUazlPUTBWZlNVNVdRVXhKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE16WUtJQ0FnSUM4dklISmxZMmx3YVdWdWREb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFF4Q2lBZ0lDQXZMeUJuWlc1bGMybHpTR0Z6YURvZ1IyeHZZbUZzTG1kbGJtVnphWE5JWVhOb0xBb2dJQ0FnWjJ4dlltRnNJRWRsYm1WemFYTklZWE5vQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnek5DMDRORElLSUNBZ0lDOHZJR052Ym5OMElIZHBkR2hrY21GM1lXdzZJRkJsY20xcGMzTnBiMjVsWkZkcGRHaGtjbUYzWVd3Z1BTQjdDaUFnSUNBdkx5QWdJR05oY21Rc0NpQWdJQ0F2THlBZ0lISmxZMmx3YVdWdWREb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdaWGh3YVhKbGMwRjBMQW9nSUNBZ0x5OGdJQ0J1YjI1alpTd0tJQ0FnSUM4dklDQWdaMlZ1WlhOcGMwaGhjMmc2SUVkc2IySmhiQzVuWlc1bGMybHpTR0Z6YUN3S0lDQWdJQzh2SUgwS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRMENpQWdJQ0F2THlCamIyNXpkQ0IzYVhSb1pISmhkMkZzWDJoaGMyZ2dQU0J2Y0M1emFHRXlOVFlvWVhKak5DNWxibU52WkdWQmNtTTBLSGRwZEdoa2NtRjNZV3dwS1FvZ0lDQWdjMmhoTWpVMkNncDNhWFJvWkhKaGQxQmxjbTFwYzNOcGIyNWxaRjkzYUdsc1pWOTBiM0JBTlRvS0lDQWdJSEIxYzJocGJuUWdNalV4TUFvZ0lDQWdaMnh2WW1Gc0lFOXdZMjlrWlVKMVpHZGxkQW9nSUNBZ1Bnb2dJQ0FnWW5vZ2QybDBhR1J5WVhkUVpYSnRhWE56YVc5dVpXUmZZV1owWlhKZmQyaHBiR1ZBTVRBS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEVWdMeThnUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUF3ZURBMk9ERXdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcwS0lDQWdJR0o1ZEdWaklERTFJQzh2SURCNE1EWTRNVEF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpSUhkcGRHaGtjbUYzVUdWeWJXbHpjMmx2Ym1Wa1gzZG9hV3hsWDNSdmNFQTFDZ3AzYVhSb1pISmhkMUJsY20xcGMzTnBiMjVsWkY5aFpuUmxjbDkzYUdsc1pVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRNUNpQWdJQ0F2THlCaGMzTmxjblFvYjNBdVpXUXlOVFV4T1habGNtbG1lVUpoY21Vb2QybDBhR1J5WVhkaGJGOW9ZWE5vTENCemFXZHVZWFIxY21Vc0lIUm9hWE11ZDJsMGFHUnlZWGRoYkY5d2RXSnJaWGt1ZG1Gc2RXVXBMQ0FuVTBsSFRrRlVWVkpGWDBsT1ZrRk1TVVFuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRneENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkY5d2RXSnJaWGtnUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3p3ek1qNCtLSHNnYTJWNU9pQW5jSGR3YXljZ2ZTa0tJQ0FnSUdKNWRHVmpJREV4SUM4dklDSndkM0JySWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENodmNDNWxaREkxTlRFNWRtVnlhV1o1UW1GeVpTaDNhWFJvWkhKaGQyRnNYMmhoYzJnc0lITnBaMjVoZEhWeVpTd2dkR2hwY3k1M2FYUm9aSEpoZDJGc1gzQjFZbXRsZVM1MllXeDFaU2tzSUNkVFNVZE9RVlJWVWtWZlNVNVdRVXhKUkNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWldReU5UVXhPWFpsY21sbWVWOWlZWEpsQ2lBZ0lDQmhjM05sY25RZ0x5OGdVMGxIVGtGVVZWSkZYMGxPVmtGTVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFV5Q2lBZ0lDQXZMeUIwYUdsekxuZHBkR2hrY21GM1JuVnVaSE1vWTJGeVpDd2dZWE56WlhRc0lHRnRiM1Z1ZEN3Z1pYaHdhWEpsYzBGMExDQmpZWEprUkdGMFlTNTNhWFJvWkhKaGQyRnNUbTl1WTJVc0lGZHBkR2hrY21GM1lXeFVlWEJsUVhCd2NtOTJaV1FwQ2lBZ0lDQmllWFJsWXlBeE5pQXZMeUFpWVhCd2NtOTJaV1FpQ2lBZ0lDQmpZV3hzYzNWaUlIZHBkR2hrY21GM1JuVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMUNpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGRoYkhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1YybDBhR1J5WVhkaGJGSmxjWFZsYzNRK0tIc2dhMlY1VUhKbFptbDRPaUFuZDNJbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RVM0NpQWdJQ0F2THlCcFppQW9kR2hwY3k1M2FYUm9aSEpoZDJGc2N5aFVlRzR1YzJWdVpHVnlLUzVsZUdsemRITXBJSHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGcxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZGhiSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVjJsMGFHUnlZWGRoYkZKbGNYVmxjM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQW5kM0luSUgwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFUzQ2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTUzYVhSb1pISmhkMkZzY3loVWVHNHVjMlZ1WkdWeUtTNWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nZDJsMGFHUnlZWGRRWlhKdGFYTnphVzl1WldSZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhkcGRHaGtjbUYzWVd4eklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lGZHBkR2hrY21GM1lXeFNaWEYxWlhOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNkeUp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkM0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMU9Bb2dJQ0FnTHk4Z2RHaHBjeTUzYVhSb1pISmhkMkZzY3loVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9EVUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDJGc2N5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQlhhWFJvWkhKaGQyRnNVbVZ4ZFdWemRENG9leUJyWlhsUWNtVm1hWGc2SUNkM2NpY2dmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5UZ0tJQ0FnSUM4dklIUm9hWE11ZDJsMGFHUnlZWGRoYkhNb1ZIaHVMbk5sYm1SbGNpa3VaR1ZzWlhSbEtDa0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9LZDJsMGFHUnlZWGRRWlhKdGFYTnphVzl1WldSZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1qQXRPREkzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkMmwwYUdSeVlYZFFaWEp0YVhOemFXOXVaV1FvQ2lBZ0lDQXZMeUFnSUdOaGNtUTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJR0Z6YzJWME9pQkJjM05sZEN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdWNGNHbHlaWE5CZERvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCdWIyNWpaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J6YVdkdVlYUjFjbVU2SUdKNWRHVnpQRFkwUGl3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02T2s5M2JtRmliR1V1YjNkdVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2ZDI1bGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIQjFZbXhwWXlCZmIzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmZiM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVmYjNkdVpYSXVkbUZzZFdVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qcFBkMjVoWW14bExuUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPamt4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQW9ibVYzVDNkdVpYSTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdkR2hwY3k1dmJteDVUM2R1WlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJ2Ym14NVQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02T1RRS0lDQWdJQzh2SUhSb2FYTXVYM1J5WVc1elptVnlUM2R1WlhKemFHbHdLRzVsZDA5M2JtVnlLUW9nSUNBZ1kyRnNiSE4xWWlCZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklIQjFZbXhwWXlCMGNtRnVjMlpsY2s5M2JtVnljMmhwY0NodVpYZFBkMjVsY2pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pwUVlYVnpZV0pzWlM1d1lYVnpaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd1lYVnpaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVYM0JoZFhObGNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCd2RXSnNhV01nWDNCaGRYTmxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lsOXdZWFZ6WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WDNCaGRYTmxjaTUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRjFjMlZ5S0NrNklFRmpZMjkxYm5RZ2V3b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qcFFZWFZ6WVdKc1pTNXdZWFZ6WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQmhkWE5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUm9hWE11YjI1c2VWQmhkWE5sY2lncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsUVlYVnpaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCd2RXSnNhV01nY0dGMWMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFltOXZiR1ZoYmo0b0tRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWNHRjFjMlZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklIUm9hWE11Y0dGMWMyVmtMblpoYkhWbElEMGdkSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvM01Rb2dJQ0FnTHk4Z1pXMXBkRHhRWVhWelpUNG9lMzBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqWmpJellUTXdaZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem8yTndvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZFhObEtDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qcFFZWFZ6WVdKc1pTNTFibkJoZFhObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkVzV3WVhWelpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUIwYUdsekxtOXViSGxRWVhWelpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCdmJteDVVR0YxYzJWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdjSFZpYkdsaklIQmhkWE5sWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLQ2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbkJoZFhObFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUIwYUdsekxuQmhkWE5sWkM1MllXeDFaU0E5SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamd4Q2lBZ0lDQXZMeUJsYldsMFBGVnVjR0YxYzJVK0tIdDlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZakUyTTJWbE1HSUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJSEIxWW14cFl5QjFibkJoZFhObEtDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qcFFZWFZ6WVdKc1pTNTFjR1JoZEdWUVlYVnpaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZRWVhWelpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnY0hWaWJHbGpJSFZ3WkdGMFpWQmhkWE5sY2loZmJtVjNVR0YxYzJWeU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QjBhR2x6TG05dWJIbFBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02T1RBS0lDQWdJQzh2SUdGemMyVnlkQ2hmYm1WM1VHRjFjMlZ5SUNFOVBTQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNJQ2RCUkVSU1JWTlRYMDVQVkY5QlRFeFBWMFZFSnlrS0lDQWdJR1IxY0FvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGRVJGSkZVMU5mVGs5VVgwRk1URTlYUlVRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QndkV0pzYVdNZ1gzQmhkWE5sY2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbDl3WVhWelpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem81TVFvZ0lDQWdMeThnZEdocGN5NWZjR0YxYzJWeUxuWmhiSFZsSUQwZ1gyNWxkMUJoZFhObGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem81TWdvZ0lDQWdMeThnWlcxcGREeFFZWFZ6WlhKRGFHRnVaMlZrUGloN0lHNWxkMEZrWkhKbGMzTTZJSFJvYVhNdVgzQmhkWE5sY2k1MllXeDFaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WTJNME1Ea3lNMk1nTHk4Z2JXVjBhRzlrSUNKUVlYVnpaWEpEYUdGdVoyVmtLR0ZrWkhKbGMzTXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pnM0NpQWdJQ0F2THlCd2RXSnNhV01nZFhCa1lYUmxVR0YxYzJWeUtGOXVaWGRRWVhWelpYSTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjbVZqYjNabGNtRmliR1V1WVd4bmJ5NTBjem82VW1WamIzWmxjbUZpYkdVdWNtVmpiM1psY2tGemMyVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WamIzWmxja0Z6YzJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0psWTI5MlpYSmhZbXhsTG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUhCMVlteHBZeUJ5WldOdmRtVnlRWE56WlhRb1lYTnpaWFE2SUVGemMyVjBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5Dd2djbVZqYVhCcFpXNTBPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNKbFkyOTJaWEpoWW14bExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklIUm9hWE11YjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y21WamIzWmxjbUZpYkdVdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z2FXWWdLR0Z6YzJWMExtbGtLU0I3Q2lBZ0lDQmllaUJ5WldOdmRtVnlRWE56WlhSZlpXeHpaVjlpYjJSNVFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl5WldOdmRtVnlZV0pzWlM1aGJHZHZMblJ6T2pReUxUUTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5eVpXTnZkbVZ5WVdKc1pTNWhiR2R2TG5Sek9qUXlMVFEzQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJSEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl5WldOdmRtVnlZV0pzWlM1aGJHZHZMblJ6T2pReUxUUTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dweVpXTnZkbVZ5UVhOelpYUmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0psWTI5MlpYSmhZbXhsTG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUhCMVlteHBZeUJ5WldOdmRtVnlRWE56WlhRb1lYTnpaWFE2SUVGemMyVjBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5Dd2djbVZqYVhCcFpXNTBPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B5WldOdmRtVnlRWE56WlhSZlpXeHpaVjlpYjJSNVFEUTZDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5eVpXTnZkbVZ5WVdKc1pTNWhiR2R2TG5Sek9qVXdMVFUxQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nY21WamFYQnBaVzUwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjbVZqYjNabGNtRmliR1V1WVd4bmJ5NTBjem8xTUMwMU5Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklISmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXlaV052ZG1WeVlXSnNaUzVoYkdkdkxuUnpPalV3TFRVMUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ2NtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCaUlISmxZMjkyWlhKQmMzTmxkRjloWm5SbGNsOXBabDlsYkhObFFEWUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5ZV2x1TG05dWJIbERZWEprVDNkdVpYSW9ZMkZ5WkRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q205dWJIbERZWEprVDNkdVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TndvZ0lDQWdMeThnY0hKcGRtRjBaU0J2Ym14NVEyRnlaRTkzYm1WeUtHTmhjbVE2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOek1LSUNBZ0lDOHZJSEIxWW14cFl5QmpZWEprY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCRFlYSmtSR0YwWVQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqWmljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTm1JZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZV2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBNUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWpZWEprY3loallYSmtLUzVsZUdsemRITXNJQ2REUVZKRVgwNVBWRjlHVDFWT1JDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5CVWtSZlRrOVVYMFpQVlU1RUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WTJGeVpITW9ZMkZ5WkNrdWRtRnNkV1V1YjNkdVpYSWdQVDA5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtbHpRMkZ5WkU5M2JtVnlLR05oY21RcExDQW5VMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVKeWtLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRSVTVFUlZKZlRrOVVYMEZNVEU5WFJVUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFoYVc0dWFYTlFZWEowYm1WeUtDa2dMVDRnZFdsdWREWTBPZ3BwYzFCaGNuUnVaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdWNHRnlkRzVsY2w5aFpHUnlaWE56TG5aaGJIVmxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9EZ0tJQ0FnSUM4dklIQjFZbXhwWXlCd1lYSjBibVZ5WDJGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR3RsZVRvZ0ozQmhKeUI5S1FvZ0lDQWdZbmwwWldNZ01USWdMeThnSW5CaElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNallLSUNBZ0lDOHZJSEpsZEhWeWJpQlVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbkJoY25SdVpYSmZZV1JrY21WemN5NTJZV3gxWlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtTmhjbVJCYzNObGRFOXdkRWx1S0dOaGNtUTZJR0o1ZEdWekxDQmhjM05sZERvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5ZV2x1TG1OaGNtUkJjM05sZEU5d2RFbHVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlRFS0lDQWdJQzh2SUhCMVlteHBZeUJqWVhKa1FYTnpaWFJQY0hSSmJpaGpZWEprT2lCQlkyTnZkVzUwTENCaGMzTmxkRG9nUVhOelpYUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16TUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbWx6VUdGeWRHNWxjaWdwTENBblUwVk9SRVZTWDA1UFZGOUJURXhQVjBWRUp5a0tJQ0FnSUdOaGJHeHpkV0lnYVhOUVlYSjBibVZ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lFTmhjbVJFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJObUp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMllpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5UTUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbU5oY21SektHTmhjbVFwTG1WNGFYTjBjeXdnSjBOQlVrUmZUazlVWDBaUFZVNUVKeWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOQlVrUmZUazlVWDBaUFZVNUVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTndvZ0lDQWdMeThnWTI5dWMzUWdXeXdnWVd4eVpXRmtlVTl3ZEdWa1NXNWRJRDBnYjNBdVFYTnpaWFJJYjJ4a2FXNW5MbUZ6YzJWMFFtRnNZVzVqWlNoallYSmtMQ0JoYzNObGRDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGRGOW9iMnhrYVc1blgyZGxkQ0JCYzNObGRFSmhiR0Z1WTJVS0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hZV3h5WldGa2VVOXdkR1ZrU1c0c0lDZEJVMU5GVkY5QlRGSkZRVVJaWDBWT1FVSk1SVVFuS1FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRlRVMFZVWDBGTVVrVkJSRmxmUlU1QlFreEZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmpJS0lDQWdJQzh2SUdOdmJuTjBJSEpsY1hWcGNtVmtPaUIxYVc1ME5qUWdQU0JqWVhKa0xtMXBia0poYkdGdVkyVWdLeUJIYkc5aVlXd3VZWE56WlhSUGNIUkpiazFwYmtKaGJHRnVZMlVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUk5hVzVDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lHZHNiMkpoYkNCQmMzTmxkRTl3ZEVsdVRXbHVRbUZzWVc1alpRb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMk13b2dJQ0FnTHk4Z2FXWWdLR05oY21RdVltRnNZVzVqWlNBOElISmxjWFZwY21Wa0tTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFFtRnNZVzVqWlFvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdablZ1WkdWa0NpQWdJQ0ErQ2lBZ0lDQmllaUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTllXbHVMbU5oY21SQmMzTmxkRTl3ZEVsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qUXRNalk1Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJSEpsY1hWcGNtVmtJQzBnWTJGeVpDNWlZV3hoYm1ObExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalkzQ2lBZ0lDQXZMeUJoYlc5MWJuUTZJSEpsY1hWcGNtVmtJQzBnWTJGeVpDNWlZV3hoYm1ObExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalkwTFRJMk9Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCeVpYRjFhWEpsWkNBdElHTmhjbVF1WW1Gc1lXNWpaU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalkwTFRJMk9Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklHTmhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCeVpYRjFhWEpsWkNBdElHTmhjbVF1WW1Gc1lXNWpaU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV0ZwYmk1allYSmtRWE56WlhSUGNIUkpibDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzTWkweU56a0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQmpZWEprTEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOemNLSUNBZ0lDOHZJR0Z6YzJWMFFXMXZkVzUwT2lBd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNNaTB5TnpnS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqb2dZMkZ5WkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCallYSmtMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOekl0TWpjNUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTZJR05oY21Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1kyRnlaQ3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRNUzB5T0RRS0lDQWdJQzh2SUdWdGFYUThRMkZ5WkVGemMyVjBSVzVoWW14bFpENG9ld29nSUNBZ0x5OGdJQ0JqWVhKa09pQmpZWEprTEFvZ0lDQWdMeThnSUNCaGMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROVGN4T1dObFpERWdMeThnYldWMGFHOWtJQ0pEWVhKa1FYTnpaWFJGYm1GaWJHVmtLR0ZrWkhKbGMzTXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWVdsdUxtTnNaV0Z5VjJsMGFHUnlZWGRoYkZKbGNYVmxjM1FvYjNkdVpYSTZJR0o1ZEdWekxDQmpZWEprT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWTJ4bFlYSlhhWFJvWkhKaGQyRnNVbVZ4ZFdWemREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelF3Q2lBZ0lDQXZMeUJ3Y21sMllYUmxJR05zWldGeVYybDBhR1J5WVhkaGJGSmxjWFZsYzNRb2IzZHVaWEk2SUVGalkyOTFiblFzSUdOaGNtUTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9EVUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDJGc2N5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQlhhWFJvWkhKaGQyRnNVbVZ4ZFdWemRENG9leUJyWlhsUWNtVm1hWGc2SUNkM2NpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbmR5SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5ERUtJQ0FnSUM4dklHbG1JQ2gwYUdsekxuZHBkR2hrY21GM1lXeHpLRzkzYm1WeUtTNWxlR2x6ZEhNZ0ppWWdkR2hwY3k1M2FYUm9aSEpoZDJGc2N5aHZkMjVsY2lrdWRtRnNkV1V1WTJGeVpDQTlQVDBnWTJGeVpDa2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCamJHVmhjbGRwZEdoa2NtRjNZV3hTWlhGMVpYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHSjZJR05zWldGeVYybDBhR1J5WVhkaGJGSmxjWFZsYzNSZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNME1nb2dJQ0FnTHk4Z1kyOXVjM1FnZDJsMGFHUnlZWGRoYkNBOUlHTnNiMjVsS0hSb2FYTXVkMmwwYUdSeVlYZGhiSE1vYjNkdVpYSXBMblpoYkhWbEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UXpDaUFnSUNBdkx5QjBhR2x6TG5kcGRHaGtjbUYzWVd4ektHOTNibVZ5S1M1a1pXeGxkR1VvS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBOQW9nSUNBZ0x5OGdaVzFwZER4WGFYUm9aSEpoZDJGc1VtVnhkV1Z6ZEVOaGJtTmxiR3hsWkQ0b2QybDBhR1J5WVhkaGJDa0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmpRZ09Bb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnTnpJZ09Bb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnT0RBZ09Bb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmxlSFJ5WVdOMElEZzRJRGdLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdiV1YwYUc5a0lDSlhhWFJvWkhKaGQyRnNVbVZ4ZFdWemRFTmhibU5sYkd4bFpDaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DZ3BqYkdWaGNsZHBkR2hrY21GM1lXeFNaWEYxWlhOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWhhVzR1ZDJsMGFHUnlZWGRHZFc1a2N5aGpZWEprT2lCaWVYUmxjeXdnWVhOelpYUTZJSFZwYm5RMk5Dd2dZVzF2ZFc1ME9pQjFhVzUwTmpRc0lIUnBiV1Z6ZEdGdGNEb2dkV2x1ZERZMExDQnViMjVqWlRvZ2RXbHVkRFkwTENCM2FYUm9aSEpoZDJGc1ZIbHdaVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbmRwZEdoa2NtRjNSblZ1WkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNNeTB6T0RBS0lDQWdJQzh2SUhCeWFYWmhkR1VnZDJsMGFHUnlZWGRHZFc1a2N5Z0tJQ0FnSUM4dklDQWdZMkZ5WkRvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1lYTnpaWFE2SUVGemMyVjBMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdkR2x0WlhOMFlXMXdPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJRzV2Ym1ObE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lIZHBkR2hrY21GM1lXeFVlWEJsT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURZZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPRElLSUNBZ0lDOHZJR2xtSUNoaGJXOTFiblFnUGlBd0tTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdKNklIZHBkR2hrY21GM1JuVnVaSE5mWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00TXkwek9UQUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00TmdvZ0lDQWdMeThnWVhOelpYUlNaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00TXkwek9Ea0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nWTJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0ZwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNE15MHpPVEFLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2pvZ1kyRnlaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS2QybDBhR1J5WVhkR2RXNWtjMTloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak01TmdvZ0lDQWdMeThnY21WamFYQnBaVzUwT2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Ua0tJQ0FnSUM4dklHTnlaV0YwWldSQmREb2dkMmwwYUdSeVlYZGhiRlI1Y0dVZ1BUMDlJRmRwZEdoa2NtRjNZV3hVZVhCbFVHVnliV2x6YzJsdmJreGxjM01nUHlCMGFXMWxjM1JoYlhBZ09pQXdMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWljR1Z5YldsemMybHZibXhsYzNNaUNpQWdJQ0E5UFFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlXbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREF3Q2lBZ0lDQXZMeUJsZUhCcGNtVnpRWFE2SUhkcGRHaGtjbUYzWVd4VWVYQmxJRDA5UFNCWGFYUm9aSEpoZDJGc1ZIbHdaVUZ3Y0hKdmRtVmtJRDhnZEdsdFpYTjBZVzF3SURvZ01Dd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0ltRndjSEp2ZG1Wa0lnb2dJQ0FnUFQwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak01TkMwME1ETUtJQ0FnSUM4dklHVnRhWFE4VjJsMGFHUnlZWGRoYkQ0b2V3b2dJQ0FnTHk4Z0lDQmpZWEprT2lCallYSmtMQW9nSUNBZ0x5OGdJQ0J5WldOcGNHbGxiblE2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lHRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJR055WldGMFpXUkJkRG9nZDJsMGFHUnlZWGRoYkZSNWNHVWdQVDA5SUZkcGRHaGtjbUYzWVd4VWVYQmxVR1Z5YldsemMybHZia3hsYzNNZ1B5QjBhVzFsYzNSaGJYQWdPaUF3TEFvZ0lDQWdMeThnSUNCbGVIQnBjbVZ6UVhRNklIZHBkR2hrY21GM1lXeFVlWEJsSUQwOVBTQlhhWFJvWkhKaGQyRnNWSGx3WlVGd2NISnZkbVZrSUQ4Z2RHbHRaWE4wWVcxd0lEb2dNQ3dLSUNBZ0lDOHZJQ0FnYm05dVkyVTZJRzV2Ym1ObExBb2dJQ0FnTHk4Z0lDQjBlWEJsT2lCM2FYUm9aSEpoZDJGc1ZIbHdaU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFlLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFpoQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFltSTBaR1F3TURZZ0x5OGdiV1YwYUc5a0lDSlhhWFJvWkhKaGQyRnNLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1WnlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNRFVLSUNBZ0lDOHZJSFJvYVhNdVkyRnlaSE1vWTJGeVpDa3VkbUZzZFdVdWQybDBhR1J5WVhkaGJFNXZibU5sSUQwZ2JtOXVZMlVnS3lBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnY0hWaWJHbGpJR05oY21SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lFTmhjbVJFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJObUp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMllpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1EVUtJQ0FnSUM4dklIUm9hWE11WTJGeVpITW9ZMkZ5WkNrdWRtRnNkV1V1ZDJsMGFHUnlZWGRoYkU1dmJtTmxJRDBnYm05dVkyVWdLeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vYVc1MElEY3lDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvNlQzZHVZV0pzWlM1dmJteDVUM2R1WlhJb0tTQXRQaUIyYjJsa09ncHZibXg1VDNkdVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVmYjNkdVpYSXVkbUZzZFdVc0lDZFRSVTVFUlZKZlRrOVVYMEZNVEU5WFJVUW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIQjFZbXhwWXlCZmIzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmZiM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VzSUNkVFJVNUVSVkpmVGs5VVgwRk1URTlYUlVRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPanBQZDI1aFlteGxMbDkwY21GdWMyWmxjazkzYm1WeWMyaHBjQ2h1WlhkUGQyNWxjam9nWW5sMFpYTXBJQzArSUhadmFXUTZDbDkwY21GdWMyWmxjazkzYm1WeWMyaHBjRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUhCeWIzUmxZM1JsWkNCZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBb2JtVjNUM2R1WlhJNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWTI5dWMzUWdjSEpsZG1sdmRYTlBkMjVsY2lBOUlIUm9hWE11WDI5M2JtVnlMbWhoYzFaaGJIVmxJRDhnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VnT2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCd2RXSnNhV01nWDI5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVgyOTNibVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0hKbGRtbHZkWE5QZDI1bGNpQTlJSFJvYVhNdVgyOTNibVZ5TG1oaGMxWmhiSFZsSUQ4Z2RHaHBjeTVmYjNkdVpYSXVkbUZzZFdVZ09pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUY5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0Y5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdYMjkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWDI5M2JtVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWTI5dWMzUWdjSEpsZG1sdmRYTlBkMjVsY2lBOUlIUm9hWE11WDI5M2JtVnlMbWhoYzFaaGJIVmxJRDhnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VnT2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2dwZmRISmhibk5tWlhKUGQyNWxjbk5vYVhCZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUY5dmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lsOXZkMjVsY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklIUm9hWE11WDI5M2JtVnlMblpoYkhWbElEMGdibVYzVDNkdVpYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZOemd0T0RFS0lDQWdJQzh2SUdWdGFYUThUM2R1WlhKemFHbHdWSEpoYm5ObVpYSnlaV1ErS0hzS0lDQWdJQzh2SUNBZ2NISmxkbWx2ZFhOUGQyNWxjam9nY0hKbGRtbHZkWE5QZDI1bGNpd0tJQ0FnSUM4dklDQWdibVYzVDNkdVpYSTZJRzVsZDA5M2JtVnlMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc1WVRJeU0yVm1ZaUF2THlCdFpYUm9iMlFnSWs5M2JtVnljMmhwY0ZSeVlXNXpabVZ5Y21Wa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ3BmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEJmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWTI5dWMzUWdjSEpsZG1sdmRYTlBkMjVsY2lBOUlIUm9hWE11WDI5M2JtVnlMbWhoYzFaaGJIVmxJRDhnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VnT2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1lpQmZkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQmZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk9sQmhkWE5oWW14bExtOXViSGxRWVhWelpYSW9LU0F0UGlCMmIybGtPZ3B2Ym14NVVHRjFjMlZ5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxsOXdZWFZ6WlhJdWRtRnNkV1VzSUNkVFJVNUVSVkpmVGs5VVgwRk1URTlYUlVRbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCd2RXSnNhV01nWDNCaGRYTmxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lsOXdZWFZ6WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVYM0JoZFhObGNpNTJZV3gxWlN3Z0oxTkZUa1JGVWw5T1QxUmZRVXhNVDFkRlJDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVnQ0NZUkFtTm1BbmR5QkJVZmZIVUVZMlpoWXdaZmIzZHVaWElIWDNCaGRYTmxjZ1p3WVhWelpXUUNiMkVEZDI5d0FtdHpBM2QzZEFSd2QzQnJBbkJoQkQvWGdwVU9jR1Z5YldsemMybHZibXhsYzNNREJvRUJDR0Z3Y0hKdmRtVmtnZ0lFb09nWWNnU2NocUdGTmhvQWpnSUE0UURWTVJrVVJERVlRUUMrZ2hvRW9hcmFRd1NnVVBYeEJML2ZsZHdFV3lkeFF3Ukh1NTM5QkQraEk0c0VyUlltSkFUTDdpdWhCSFJkdnhZRTJoc25pUVNzY3gzbUJLNTVhMFVFaDltVVpBUXNPY2VGQkpVMzFRa0V0elNSV0FTNzBON3dCQlAvSE9rRTh1UHpmd1N4dTdDb0JPRjdyN1FFc05sVHN3UUJlUGxMQkJ0U25lZ0VESzNSWXdSNFdodjVOaG9BamhvQUp3Q09BS0FBc1FHWUFlc0NLUUxmQXZVRENBTVpBeW9EUEFOUUEyTUVFd1IyQk1rRlBnWDZCZ1VHRlFZZ0JqQUdRQVpnQUlBRUYwZ1pQVFlhQUk0QkFDOEFNUm1CQlJJeEdCQkVRZ0JTTVJtQkJCSXhHQkJFUWdCQk5ob0JTUlVrRWtRMkdnSkpGU1VTUkJlSUJvc2pRellhQVVrVkpCSkVOaG9DU1JVa0VrUk1pQWU3SndkTVp5Y0ZNUUJuS3lKbkp3WWlaeW95Q2xDd0kwT0lCNWNqUTRnSGtpSXJaVVFVUkxFeUNpSW5CR1ZFc2draXNnaXlCeU95RUNLeUFiTWpRellhQVVrVkpSSkVGNGdIYUNjS1RHY2pRellhQVVrVkpCSkVpQWRYSnd0TVp5TkROaG9CUndJVkpCSkVOaG9DU1JVbEVrUVhTVTRDVGdPSUJmSkVNZ05RSWhaTVN3RlFURkN4Z1FXeUdZQUVDNEVCUTdKQ2dEOExJQUlBQVlBRVZoMHY2allhQUk0QkFBRUFNUm1CQlJJeEdCUVFSRUlBQUxFeUNqSU9zaUFpc2dpeUJ5T3lFQ0t5QWJPQUJCVWZmSFV5Q2xDd0kwT3lRSUFFVmgwdjZySWFnUWF5RUNLeUFiTzBQa2xYQkFCSlRnSk9CRmNBQkNvU1JFa1ZKQkpFWENCT0FrRUFRRElRc1RJQkNMSUlSd0t5QnlPeUVDS3lBYk1vVEZCUEFyOGlLMlZFSXdnclRHZExBa0VBQmtsTEE0Z0ZSVWxPQWxDQUJQVXpRRVJNVUxBcVRGQ3dJME1pUXYrK05ob0JSd0lWSkJKRUtFeFFSd0s5UlFGRXZraFhBQ0NJQlF0QUFBZEpNUUFTUVFBckkwUlBBa2xPQW9nRmE3RXlDa215Q1NLeUNMSUhzZ0Fqc2hBaXNnR3p2RWdpSzJWRUl3a3JUR2NqUXlKQy85STJHZ0ZKRlNRU1JEWWFBa2tWSkJKRWlBWUVLRXNDVUVtOVJRRkVTYjVJVndBZ1NVc0VpQVVlVENKTEE3dFBBa3hRVEZDQUJFeDR3a1ZNVUxBalF6WWFBVWtWSkJKRU5ob0NTUlVrRWtRMkdnTkpGU1VTUkJjMkdnUkpGU1VTUkJjMkdnVkpGU1VTUkJjMkdnWkpJbG1CQWdoTEFSVVNSRmNDQUNJbkJtVkVGRVFuQ0RFQVVMMUZBVVFvU3dWUVNiNUVTVmNBSUU4SUVrU0JRRnRKU3dRU1JMRWlKd2RsUkVzRHNnVkxCYklTU3dheUViSVVTd2F5QUlFRXNoQWlzZ0d6VHdVV1R3Wk1VRThGRmxCUEJCWlFTd01WRmxjR0FrOEVVRXlBQWdBNlVFeFFnQVNaU2hOblRGQ3dJd2dXZ1VCTXV5TkROaG9CU1JVa0VrUW9URkMrUkZkQUNDcE1VTEFqUXpZYUFVa1ZKQkpFS0V4UXZrUXFURkN3STBNMkdnRkpGU1FTUklnRTd5Y01UR2NqUXpZYUFVa1ZKQkpFaUFUZUp3ZE1aeU5ETmhvQlNSVWxFa1FYaUFUTUp3bE1aeU5ETmhvQlNSVWtFa1NJQkxzbkNFeFFJeGEvSTBNMkdnRkpGU1FTUklnRXB5Y0lURkM4U0NORE5ob0JSd0lWSkJKRU5ob0NTVTREU1JVbEVrUVhUQ2hNVUVtOVJRRkV2a2hYQUNCT0FvZ0RNa0FBQ0VzQ01RQVNRUUI1STBTeElySVNTYklSU3dGSnNoVkpzaFJKc2dDQkJMSVFJcklCczBsekFFUk1jd0ZFRFVFQUhMRXlDa3NDU1hNQVJFc0Jjd0ZFQ2JJSXNnQ3lCeU95RUNLeUFiTVdVSUFFZ05kL01VeFFzQ0luQ1dWRkFVRUFIN0VpSndsbFJMSVlnQVI3dVQyaXNocEpzaHBMQWJJYWdRYXlFQ0t5QWJNalF5SkMvNFEyR2dGSkZTUVNSRFlhQWtrVkpSSkVGellhQTBrVkpSSkVGMHNDaUFKMUtFc0RVTDVFU3dOTEEzQUFTRXNDRDBReEFESUhUd0pYU0FoUEJVOERVRThFRmxCUEF4WlFUd0lXVUV4UUtURUFVRXNCdjRBRTJGOWlDa3NCVUxBcVRGQ3dJME0yR2dGSkZTUVNSSWdDSmlreEFGQzlSUUZFS1RFQVVMNUVLVEVBVUx4SVNWY0FJRXNCVnlBZ1N3SlhRQWhMQTFkSUNFc0VWMUFJVHdWWFdBaFBCVThGVUU4RVVFOERVRThDVUV4UUp3MU1VTEFqUXpZYUFVa1ZKQkpFTmhvQ1NSVWxFa1FYU3dHSUFjZ3BNUUJRdlVVQlJDaExBbEMrUkNreEFGQytSRW1CU0Z0TEF3OUVUSUZJVzBzQmdWaGJURXNCRWtSTEFWY0FJRXNFRWtSTEFZRlFXeUluQ21WRVN3RUlNZ2NPUkU4Q2dVQmJUd1JNVHdSUEEwOEVKdzZJQWxFcE1RQlF2RWdqUXpZYUFVY0NGU1FTUkRZYUFra1ZKUkpFRjBsUEFqWWFBMGtWSlJKRUYwbE9BazRETmhvRVNSVWxFa1FYU1U0RU5ob0ZTUlVsRWtRWE5ob0dTVTRHRllGQUVrUkxBb2dCSVNoTEExQytSRElIU3dNTVJJRklXMGxPQjBzQkVrUXhBRElSVHdSUEFsQlBCUlpRVHdRV1VFOERGbEJQQWhaUVRGQUJnYzRUTWd3TlFRQVlzWUVHc2hDQkJiSVpKdyt5SGljUHNoOGlzZ0d6UXYvZklpY0xaVVJNVGdLRVJDY1FpQUdmS1RFQVVMMUZBVUVBQmlreEFGQzhTQ05ESWljRVpVUXFURkN3STBNMkdnRkpGU1FTUklnQjhvZ0IrU05ESWljRlpVUXFURkN3STBPSUFoRW5CaU5uZ0FUUEk2TVBzQ05EaUFJQkp3WWlaNEFFc1dQdUM3QWpRellhQVVrVkpCSkVpQUczU1RJREUwUW5CVXNCWjRBRXpFQ1NQRXhRc0NORE5ob0JTUlVsRWtRWFNUWWFBa2tWSlJKRUYwNENOaG9EU1U0Q0ZTUVNSSWdCZ0VFQUViR3lGTElSc2hLQkJMSVFJcklCc3lORFJRR3hzZ2V5Q0NPeUVDS3lBYk5DLysyS0FRQW9pLzlRU2IxRkFVUytTRmNBSURFQUVrU0pNUUFpSnd4bFJCS0ppZ0lBaVAveFJDaUwvbEM5UlFGRWkvNkwvM0FBUlFFVVJJditjd0ZFTWhBSVNZditjd0JFRFVFQUY3R0wvbk1BUklzQVRBbXlDSXYrc2djanNoQWlzZ0d6c1NLeUVvdi9zaEdML3JJVWkvNnlBSUVFc2hBaXNnR3ppLzhXaS81TVVJQUVWeG5PMFV4UXNJbUtBZ0FwaS81UVNiMUZBVUVBUjRzQXZrUlhBQ0NML3hKQkFEcUxBRW0rUkV5OFNFbFhBQ0JMQVZjZ0lFc0NWMEFJU3dOWFNBaExCRmRRQ0U4RlYxZ0lUd1ZQQlZCUEJGQlBBMUJQQWxCTVVDY05URkN3aVlvR0FJdjhRUUFac1RFQWkveXlFb3Y3c2hHeUZJdjZzZ0NCQkxJUUlySUJzekVBaS84bkRoSWlpLzFQQWsyTC95Y1FFaUtML1U4Q1RZdjZUd05RaS9zV1VJdjhGbEJQQWhaUVRCWlFpLzRXVUl2L0ZSWlhCZ0tMLzFCTWdBSUFhbEJNVUlBRXUwM1FCa3hRc0l2K0l3Z29pL3BRVEJhQlNFeTdpVEVBSWljRVpVUVNSSW1LQVFBaUp3UmxSUUZCQUJjaUp3UmxSQ2NFaS85bmkvOVFnQVNhSWo3N1RGQ3dpVElEUXYvcE1RQWlKd1ZsUkJKRWlRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJDYXJkQXNzZXRFbmFibGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJDYXJkQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZE93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IldpdGhkcmF3YWxSZXF1ZXN0Q2FuY2VsbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRlZEF0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNhcmRSZWNvdmVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkQ2FyZE93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0NhcmRPd25lciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRGViaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmZXJlbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJDYXJkQXNzZXREaXNhYmxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJXaXRoZHJhd2FsUmVxdWVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0ZWRBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJXaXRoZHJhd2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRlZEF0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJlc0F0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eXBlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJQYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdfSx7Im5hbWUiOiJVbnBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119LHsibmFtZSI6IlBhdXNlckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0FkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
