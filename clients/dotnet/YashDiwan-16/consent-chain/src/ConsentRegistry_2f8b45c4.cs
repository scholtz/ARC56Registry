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

namespace Arc56.Generated.YashDiwan_16.consent_chain.ConsentRegistry_2f8b45c4
{


    public class ConsentRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ConsentRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AccessGrant : AVMObjectType
            {
                public ulong DocumentId { get; set; }

                public byte[] Sender { get; set; }

                public byte[] Receiver { get; set; }

                public byte[] PurposeHash { get; set; }

                public ulong Permissions { get; set; }

                public ulong ExpiryTimestamp { get; set; }

                public ulong Status { get; set; }

                public ulong GrantedAt { get; set; }

                public ulong RevokedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDocumentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDocumentId.From(DocumentId);
                    ret.AddRange(vDocumentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vSender.From(Sender);
                    ret.AddRange(vSender.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurposeHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vPurposeHash.From(PurposeHash);
                    ret.AddRange(vPurposeHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPermissions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPermissions.From(Permissions);
                    ret.AddRange(vPermissions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiryTimestamp.From(ExpiryTimestamp);
                    ret.AddRange(vExpiryTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGrantedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGrantedAt.From(GrantedAt);
                    ret.AddRange(vGrantedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRevokedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRevokedAt.From(RevokedAt);
                    ret.AddRange(vRevokedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AccessGrant Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AccessGrant();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDocumentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDocumentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDocumentId = vDocumentId.ToValue();
                    if (valueDocumentId is ulong vDocumentIdValue) { ret.DocumentId = vDocumentIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is byte[] vSenderValue) { ret.Sender = vSenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is byte[] vReceiverValue) { ret.Receiver = vReceiverValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurposeHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vPurposeHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePurposeHash = vPurposeHash.ToValue();
                    if (valuePurposeHash is byte[] vPurposeHashValue) { ret.PurposeHash = vPurposeHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPermissions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPermissions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePermissions = vPermissions.ToValue();
                    if (valuePermissions is ulong vPermissionsValue) { ret.Permissions = vPermissionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiryTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiryTimestamp = vExpiryTimestamp.ToValue();
                    if (valueExpiryTimestamp is ulong vExpiryTimestampValue) { ret.ExpiryTimestamp = vExpiryTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGrantedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGrantedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGrantedAt = vGrantedAt.ToValue();
                    if (valueGrantedAt is ulong vGrantedAtValue) { ret.GrantedAt = vGrantedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRevokedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRevokedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRevokedAt = vRevokedAt.ToValue();
                    if (valueRevokedAt is ulong vRevokedAtValue) { ret.RevokedAt = vRevokedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AccessGrant);
                }
                public bool Equals(AccessGrant? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AccessGrant left, AccessGrant right)
                {
                    return EqualityComparer<AccessGrant>.Default.Equals(left, right);
                }
                public static bool operator !=(AccessGrant left, AccessGrant right)
                {
                    return !(left == right);
                }

            }

            public class AccessVerification : AVMObjectType
            {
                public bool Valid { get; set; }

                public ulong Permissions { get; set; }

                public ulong Status { get; set; }

                public ulong ExpiryTimestamp { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vValid.From(Valid);
                    ret.AddRange(vValid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPermissions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPermissions.From(Permissions);
                    ret.AddRange(vPermissions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiryTimestamp.From(ExpiryTimestamp);
                    ret.AddRange(vExpiryTimestamp.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AccessVerification Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AccessVerification();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValid = vValid.ToValue();
                    if (valueValid is bool vValidValue) { ret.Valid = vValidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPermissions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPermissions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePermissions = vPermissions.ToValue();
                    if (valuePermissions is ulong vPermissionsValue) { ret.Permissions = vPermissionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiryTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiryTimestamp = vExpiryTimestamp.ToValue();
                    if (valueExpiryTimestamp is ulong vExpiryTimestampValue) { ret.ExpiryTimestamp = vExpiryTimestampValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AccessVerification);
                }
                public bool Equals(AccessVerification? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AccessVerification left, AccessVerification right)
                {
                    return EqualityComparer<AccessVerification>.Default.Equals(left, right);
                }
                public static bool operator !=(AccessVerification left, AccessVerification right)
                {
                    return !(left == right);
                }

            }

            public class DocumentRecord : AVMObjectType
            {
                public ulong DocumentId { get; set; }

                public byte[] Owner { get; set; }

                public byte[] DocumentHash { get; set; }

                public byte[] IpfsCidHash { get; set; }

                public byte[] MetadataHash { get; set; }

                public ulong CreatedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDocumentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDocumentId.From(DocumentId);
                    ret.AddRange(vDocumentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDocumentHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vDocumentHash.From(DocumentHash);
                    ret.AddRange(vDocumentHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsCidHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vIpfsCidHash.From(IpfsCidHash);
                    ret.AddRange(vIpfsCidHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vMetadataHash.From(MetadataHash);
                    ret.AddRange(vMetadataHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DocumentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DocumentRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDocumentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDocumentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDocumentId = vDocumentId.ToValue();
                    if (valueDocumentId is ulong vDocumentIdValue) { ret.DocumentId = vDocumentIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is byte[] vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDocumentHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vDocumentHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDocumentHash = vDocumentHash.ToValue();
                    if (valueDocumentHash is byte[] vDocumentHashValue) { ret.DocumentHash = vDocumentHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsCidHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vIpfsCidHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIpfsCidHash = vIpfsCidHash.ToValue();
                    if (valueIpfsCidHash is byte[] vIpfsCidHashValue) { ret.IpfsCidHash = vIpfsCidHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vMetadataHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMetadataHash = vMetadataHash.ToValue();
                    if (valueMetadataHash is byte[] vMetadataHashValue) { ret.MetadataHash = vMetadataHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DocumentRecord);
                }
                public bool Equals(DocumentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DocumentRecord left, DocumentRecord right)
                {
                    return EqualityComparer<DocumentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(DocumentRecord left, DocumentRecord right)
                {
                    return !(left == right);
                }

            }

            public class GrantKey : AVMObjectType
            {
                public ulong DocumentId { get; set; }

                public byte[] Receiver { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDocumentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDocumentId.From(DocumentId);
                    ret.AddRange(vDocumentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GrantKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GrantKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDocumentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDocumentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDocumentId = vDocumentId.ToValue();
                    if (valueDocumentId is ulong vDocumentIdValue) { ret.DocumentId = vDocumentIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is byte[] vReceiverValue) { ret.Receiver = vReceiverValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GrantKey);
                }
                public bool Equals(GrantKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GrantKey left, GrantKey right)
                {
                    return EqualityComparer<GrantKey>.Default.Equals(left, right);
                }
                public static bool operator !=(GrantKey left, GrantKey right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class DocumentRegisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 191, 129, 89, 211 };
                public const string Signature = "DocumentRegistered(uint64,address,byte[32],byte[32],byte[32],uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field0 { get; set; }
                public Algorand.Address Field1 { get; set; }
                public byte[] Field2 { get; set; }
                public byte[] Field3 { get; set; }
                public byte[] Field4 { get; set; }
                public ulong Field5 { get; set; }

                public static DocumentRegisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DocumentRegisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is byte[] vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is byte[] vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

            }

            public class AccessGrantedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 18, 208, 35, 135 };
                public const string Signature = "AccessGranted(uint64,address,address,byte[32],uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field0 { get; set; }
                public Algorand.Address Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public byte[] Field3 { get; set; }
                public ulong Field4 { get; set; }
                public ulong Field5 { get; set; }
                public ulong Field6 { get; set; }

                public static AccessGrantedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AccessGrantedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is byte[] vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is ulong vField6Value) { ret.Field6 = vField6Value; }
                    return ret;

                }

            }

            public class AccessRevokedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 65, 248, 81, 255 };
                public const string Signature = "AccessRevoked(uint64,address,address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field0 { get; set; }
                public Algorand.Address Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public ulong Field3 { get; set; }

                public static AccessRevokedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AccessRevokedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

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

        ///<summary>
        ///
        ///</summary>
        /// <param name="documentHash"> </param>
        /// <param name="ipfsCidHash"> </param>
        /// <param name="metadataHash"> </param>
        public async Task<ulong> RegisterDocument(byte[] documentHash, byte[] ipfsCidHash, byte[] metadataHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 15, 252, 37 };
            var documentHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); documentHashAbi.From(documentHash);
            var ipfsCidHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); ipfsCidHashAbi.From(ipfsCidHash);
            var metadataHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); metadataHashAbi.From(metadataHash);

            var result = await base.CallApp(new List<object> { abiHandle, documentHashAbi, ipfsCidHashAbi, metadataHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterDocument_Transactions(byte[] documentHash, byte[] ipfsCidHash, byte[] metadataHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 15, 252, 37 };
            var documentHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); documentHashAbi.From(documentHash);
            var ipfsCidHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); ipfsCidHashAbi.From(ipfsCidHash);
            var metadataHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); metadataHashAbi.From(metadataHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, documentHashAbi, ipfsCidHashAbi, metadataHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="documentId"> </param>
        /// <param name="receiverAddress"> </param>
        /// <param name="purposeHash"> </param>
        /// <param name="permissions"> </param>
        /// <param name="expiryTimestamp"> </param>
        public async Task GrantAccess(ulong documentId, Algorand.Address receiverAddress, byte[] purposeHash, ulong permissions, ulong expiryTimestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 231, 115, 87 };
            var documentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); documentIdAbi.From(documentId);
            var receiverAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAddressAbi.From(receiverAddress);
            var purposeHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); purposeHashAbi.From(purposeHash);
            var permissionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permissionsAbi.From(permissions);
            var expiryTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiryTimestampAbi.From(expiryTimestamp);

            var result = await base.CallApp(new List<object> { abiHandle, documentIdAbi, receiverAddressAbi, purposeHashAbi, permissionsAbi, expiryTimestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantAccess_Transactions(ulong documentId, Algorand.Address receiverAddress, byte[] purposeHash, ulong permissions, ulong expiryTimestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 231, 115, 87 };
            var documentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); documentIdAbi.From(documentId);
            var receiverAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAddressAbi.From(receiverAddress);
            var purposeHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); purposeHashAbi.From(purposeHash);
            var permissionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permissionsAbi.From(permissions);
            var expiryTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiryTimestampAbi.From(expiryTimestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, documentIdAbi, receiverAddressAbi, purposeHashAbi, permissionsAbi, expiryTimestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="documentId"> </param>
        /// <param name="receiverAddress"> </param>
        public async Task RevokeAccess(ulong documentId, Algorand.Address receiverAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 153, 42, 224 };
            var documentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); documentIdAbi.From(documentId);
            var receiverAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAddressAbi.From(receiverAddress);

            var result = await base.CallApp(new List<object> { abiHandle, documentIdAbi, receiverAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeAccess_Transactions(ulong documentId, Algorand.Address receiverAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 153, 42, 224 };
            var documentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); documentIdAbi.From(documentId);
            var receiverAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAddressAbi.From(receiverAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, documentIdAbi, receiverAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="documentId"> </param>
        /// <param name="receiverAddress"> </param>
        public async Task<Structs.AccessVerification> VerifyAccess(ulong documentId, Algorand.Address receiverAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 99, 139, 115 };
            var documentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); documentIdAbi.From(documentId);
            var receiverAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAddressAbi.From(receiverAddress);

            var result = await base.SimApp(new List<object> { abiHandle, documentIdAbi, receiverAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AccessVerification.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> VerifyAccess_Transactions(ulong documentId, Algorand.Address receiverAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 99, 139, 115 };
            var documentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); documentIdAbi.From(documentId);
            var receiverAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAddressAbi.From(receiverAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, documentIdAbi, receiverAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="documentId"> </param>
        public async Task<Structs.DocumentRecord> GetDocument(ulong documentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 114, 9, 196 };
            var documentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); documentIdAbi.From(documentId);

            var result = await base.SimApp(new List<object> { abiHandle, documentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DocumentRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetDocument_Transactions(ulong documentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 114, 9, 196 };
            var documentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); documentIdAbi.From(documentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, documentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="documentId"> </param>
        /// <param name="receiverAddress"> </param>
        public async Task<Structs.AccessGrant> GetAccessGrant(ulong documentId, Algorand.Address receiverAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 135, 157, 84 };
            var documentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); documentIdAbi.From(documentId);
            var receiverAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAddressAbi.From(receiverAddress);

            var result = await base.SimApp(new List<object> { abiHandle, documentIdAbi, receiverAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AccessGrant.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAccessGrant_Transactions(ulong documentId, Algorand.Address receiverAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 135, 157, 84 };
            var documentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); documentIdAbi.From(documentId);
            var receiverAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAddressAbi.From(receiverAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, documentIdAbi, receiverAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29uc2VudFJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFjY2Vzc0dyYW50IjpbeyJuYW1lIjoiZG9jdW1lbnRJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzZW5kZXIiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJyZWNlaXZlciIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6InB1cnBvc2VIYXNoIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoicGVybWlzc2lvbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXhwaXJ5VGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJncmFudGVkQXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmV2b2tlZEF0IiwidHlwZSI6InVpbnQ2NCJ9XSwiQWNjZXNzVmVyaWZpY2F0aW9uIjpbeyJuYW1lIjoidmFsaWQiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6InBlcm1pc3Npb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleHBpcnlUaW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In1dLCJEb2N1bWVudFJlY29yZCI6W3sibmFtZSI6ImRvY3VtZW50SWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJkb2N1bWVudEhhc2giLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJpcGZzQ2lkSGFzaCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6Im1ldGFkYXRhSGFzaCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6ImNyZWF0ZWRBdCIsInR5cGUiOiJ1aW50NjQifV0sIkdyYW50S2V5IjpbeyJuYW1lIjoiZG9jdW1lbnRJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWNlaXZlciIsInR5cGUiOiJieXRlWzMyXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RlckRvY3VtZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZG9jdW1lbnRIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlwZnNDaWRIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1ldGFkYXRhSGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJEb2N1bWVudFJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiI0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiNSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdyYW50QWNjZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRvY3VtZW50SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVycG9zZUhhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1pc3Npb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcnlUaW1lc3RhbXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFjY2Vzc0dyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiI0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiNSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjYiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VBY2Nlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZG9jdW1lbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjZXNzUmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlBY2Nlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZG9jdW1lbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJBY2Nlc3NWZXJpZmljYXRpb24iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldERvY3VtZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRvY3VtZW50SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxieXRlWzMyXSxieXRlWzMyXSxieXRlWzMyXSxieXRlWzMyXSx1aW50NjQpIiwic3RydWN0IjoiRG9jdW1lbnRSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFjY2Vzc0dyYW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRvY3VtZW50SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxieXRlWzMyXSxieXRlWzMyXSxieXRlWzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkFjY2Vzc0dyYW50IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ2Nl0sImVycm9yTWVzc2FnZSI6IkFjY2VzcyBncmFudCBhbHJlYWR5IHJldm9rZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTYsNjk0XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzIGdyYW50IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzN10sImVycm9yTWVzc2FnZSI6IkFjdGl2ZSBhY2Nlc3MgZ3JhbnQgYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzIsNTkxXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1OCw3MjNdLCJlcnJvck1lc3NhZ2UiOiJEb2N1bWVudCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTldLCJlcnJvck1lc3NhZ2UiOiJFeHBpcnkgbXVzdCBiZSBpbiB0aGUgZnV0dXJlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBkb2N1bWVudCBvd25lciBjYW4gcGVyZm9ybSB0aGlzIGFjdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMF0sImVycm9yTWVzc2FnZSI6Ik93bmVyIGNhbm5vdCBncmFudCBhY2Nlc3MgdG8gc2VsZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Ml0sImVycm9yTWVzc2FnZSI6IlJlY2VpdmVyIGFkZHJlc3MgaXMgaW52YWxpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxM10sImVycm9yTWVzc2FnZSI6IlVua25vd24gcGVybWlzc2lvbiBmbGFncyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwOF0sImVycm9yTWVzc2FnZSI6IlZpZXcgcGVybWlzc2lvbiBpcyByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExOCwxMjYsMTM0LDIzMiwyNDIsNDM2LDUyNCw2ODNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE5LDI1MywyNjgsNDI2LDUxNSw2NDgsNjc0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBzaXplIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F6TWlBNElEQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltUWlJREI0TVRVeFpqZGpOelVnSW1jaUlDSnVaWGgwUkc5amRXMWxiblJKWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRGIyNXpaVzUwVW1WbmFYTjBjbmtnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVEFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd6WmpCbVptTXlOU0F3ZURsa1pUYzNNelUzSURCNFpHTTVPVEpoWlRBZ01IZzJOVFl6T0dJM015QXdlRGRqTnpJd09XTTBJREI0WkRJNE56bGtOVFFnTHk4Z2JXVjBhRzlrSUNKeVpXZHBjM1JsY2tSdlkzVnRaVzUwS0dKNWRHVmJNekpkTEdKNWRHVmJNekpkTEdKNWRHVmJNekpkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjNKaGJuUkJZMk5sYzNNb2RXbHVkRFkwTEdGa1pISmxjM01zWW5sMFpWc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpYWnZhMlZCWTJObGMzTW9kV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVRV05qWlhOektIVnBiblEyTkN4aFpHUnlaWE56S1NoaWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBSRzlqZFcxbGJuUW9kV2x1ZERZMEtTaDFhVzUwTmpRc1lubDBaVnN6TWwwc1lubDBaVnN6TWwwc1lubDBaVnN6TWwwc1lubDBaVnN6TWwwc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBRV05qWlhOelIzSmhiblFvZFdsdWREWTBMR0ZrWkhKbGMzTXBLSFZwYm5RMk5DeGllWFJsV3pNeVhTeGllWFJsV3pNeVhTeGllWFJsV3pNeVhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSEpsWjJsemRHVnlSRzlqZFcxbGJuUWdaM0poYm5SQlkyTmxjM01nY21WMmIydGxRV05qWlhOeklIWmxjbWxtZVVGalkyVnpjeUJuWlhSRWIyTjFiV1Z1ZENCblpYUkJZMk5sYzNOSGNtRnVkQW9nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVOdmJuTmxiblJTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0k0TkRRM1lqTTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURFeENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QnVaWGgwUkc5amRXMWxiblJKWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHVaWGgwUkc5amRXMWxiblJKWkNjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltNWxlSFJFYjJOMWJXVnVkRWxrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdkR2hwY3k1dVpYaDBSRzlqZFcxbGJuUkpaQzUyWVd4MVpTQTlJRlZwYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlEyOXVjMlZ1ZEZKbFoybHpkSEo1TG5KbFoybHpkR1Z5Ukc5amRXMWxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2tSdlkzVnRaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOaTAzTUFvZ0lDQWdMeThnY0hWaWJHbGpJSEpsWjJsemRHVnlSRzlqZFcxbGJuUW9DaUFnSUNBdkx5QWdJR1J2WTNWdFpXNTBTR0Z6YURvZ1lubDBaWE04TXpJK0xBb2dJQ0FnTHk4Z0lDQnBjR1p6UTJsa1NHRnphRG9nWW5sMFpYTThNekkrTEFvZ0lDQWdMeThnSUNCdFpYUmhaR0YwWVVoaGMyZzZJR0o1ZEdWelBETXlQaXdLSUNBZ0lDOHZJQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCamIyNXpkQ0JrYjJOMWJXVnVkRWxrSUQwZ2RHaHBjeTV1WlhoMFJHOWpkVzFsYm5SSlpDNTJZV3gxWlFvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklHNWxlSFJFYjJOMWJXVnVkRWxrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyNWxlSFJFYjJOMWJXVnVkRWxrSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJtVjRkRVJ2WTNWdFpXNTBTV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QmpiMjV6ZENCa2IyTjFiV1Z1ZEVsa0lEMGdkR2hwY3k1dVpYaDBSRzlqZFcxbGJuUkpaQzUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJRzkzYm1WeU9pQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdZM0psWVhSbFpFRjBPaUJIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0xBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTWkwM09Rb2dJQ0FnTHk4Z1kyOXVjM1FnWkc5amRXMWxiblE2SUVSdlkzVnRaVzUwVW1WamIzSmtJRDBnZXdvZ0lDQWdMeThnSUNCa2IyTjFiV1Z1ZEVsa0xBb2dJQ0FnTHk4Z0lDQnZkMjVsY2pvZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3l3S0lDQWdJQzh2SUNBZ1pHOWpkVzFsYm5SSVlYTm9MQW9nSUNBZ0x5OGdJQ0JwY0daelEybGtTR0Z6YUN3S0lDQWdJQzh2SUNBZ2JXVjBZV1JoZEdGSVlYTm9MQW9nSUNBZ0x5OGdJQ0JqY21WaGRHVmtRWFE2SUVkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQXNDaUFnSUNBdkx5QjlDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJR1J2WTNWdFpXNTBjeUE5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRVJ2WTNWdFpXNTBVbVZqYjNKa1BpaDdJR3RsZVZCeVpXWnBlRG9nSjJRbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmtJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNUW9nSUNBZ0x5OGdkR2hwY3k1a2IyTjFiV1Z1ZEhNb1pHOWpkVzFsYm5SSlpDa3VkbUZzZFdVZ1BTQmpiRzl1WlNoa2IyTjFiV1Z1ZENrS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RJS0lDQWdJQzh2SUhSb2FYTXVibVY0ZEVSdlkzVnRaVzUwU1dRdWRtRnNkV1VnUFNCa2IyTjFiV1Z1ZEVsa0lDc2dWV2x1ZERZMEtERXBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdibVY0ZEVSdlkzVnRaVzUwU1dRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ibVY0ZEVSdlkzVnRaVzUwU1dRbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnVaWGgwUkc5amRXMWxiblJKWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRElLSUNBZ0lDOHZJSFJvYVhNdWJtVjRkRVJ2WTNWdFpXNTBTV1F1ZG1Gc2RXVWdQU0JrYjJOMWJXVnVkRWxrSUNzZ1ZXbHVkRFkwS0RFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFzQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzBMVGt5Q2lBZ0lDQXZMeUJsYldsMEtBb2dJQ0FnTHk4Z0lDQW5SRzlqZFcxbGJuUlNaV2RwYzNSbGNtVmtKeXdLSUNBZ0lDOHZJQ0FnWkc5amRXMWxiblJKWkN3S0lDQWdJQzh2SUNBZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdaRzlqZFcxbGJuUklZWE5vTEFvZ0lDQWdMeThnSUNCcGNHWnpRMmxrU0dGemFDd0tJQ0FnSUM4dklDQWdiV1YwWVdSaGRHRklZWE5vTEFvZ0lDQWdMeThnSUNCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdKbU9ERTFPV1F6SUM4dklHMWxkR2h2WkNBaVJHOWpkVzFsYm5SU1pXZHBjM1JsY21Wa0tIVnBiblEyTkN4aFpHUnlaWE56TEdKNWRHVmJNekpkTEdKNWRHVmJNekpkTEdKNWRHVmJNekpkTEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOaTAzTUFvZ0lDQWdMeThnY0hWaWJHbGpJSEpsWjJsemRHVnlSRzlqZFcxbGJuUW9DaUFnSUNBdkx5QWdJR1J2WTNWdFpXNTBTR0Z6YURvZ1lubDBaWE04TXpJK0xBb2dJQ0FnTHk4Z0lDQnBjR1p6UTJsa1NHRnphRG9nWW5sMFpYTThNekkrTEFvZ0lDQWdMeThnSUNCdFpYUmhaR0YwWVVoaGMyZzZJR0o1ZEdWelBETXlQaXdLSUNBZ0lDOHZJQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlEyOXVjMlZ1ZEZKbFoybHpkSEo1TG1keVlXNTBRV05qWlhOelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taM0poYm5SQlkyTmxjM002Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazNMVEV3TXdvZ0lDQWdMeThnY0hWaWJHbGpJR2R5WVc1MFFXTmpaWE56S0FvZ0lDQWdMeThnSUNCa2IyTjFiV1Z1ZEVsa09pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeVFXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ2NIVnljRzl6WlVoaGMyZzZJR0o1ZEdWelBETXlQaXdLSUNBZ0lDOHZJQ0FnY0dWeWJXbHpjMmx2Ym5NNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1pYaHdhWEo1VkdsdFpYTjBZVzF3T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjNabGNpQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z1kyOXVjM1FnWkc5amRXMWxiblFnUFNCMGFHbHpMbkpsY1hWcGNtVkViMk4xYldWdWRFOTNibVZ5S0dSdlkzVnRaVzUwU1dRcENpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJ5WlhGMWFYSmxSRzlqZFcxbGJuUlBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFVLSUNBZ0lDOHZJR052Ym5OMElHdGxlU0E5SUhSb2FYTXVaM0poYm5STFpYa29aRzlqZFcxbGJuUkpaQ3dnY21WalpXbDJaWEpCWkdSeVpYTnpLUW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTJGc2JITjFZaUJuY21GdWRFdGxlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklHRnpjMlZ5ZENoeVpXTmxhWFpsY2tGa1pISmxjM011WW5sMFpYTWdJVDA5SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3k1aWVYUmxjeXdnSjFKbFkyVnBkbVZ5SUdGa1pISmxjM01nYVhNZ2FXNTJZV3hwWkNjcENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklGSmxZMlZwZG1WeUlHRmtaSEpsYzNNZ2FYTWdhVzUyWVd4cFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURnS0lDQWdJQzh2SUdGemMyVnlkQ2h5WldObGFYWmxja0ZrWkhKbGMzTXVZbmwwWlhNZ0lUMDlJR1J2WTNWdFpXNTBMbTkzYm1WeUxDQW5UM2R1WlhJZ1kyRnVibTkwSUdkeVlXNTBJR0ZqWTJWemN5QjBieUJ6Wld4bUp5a0tJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnT0NBek1nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFOTNibVZ5SUdOaGJtNXZkQ0JuY21GdWRDQmhZMk5sYzNNZ2RHOGdjMlZzWmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdaWEp0YVhOemFXOXVjeUFsSUZWcGJuUTJOQ2d5S1NBOVBUMGdVRVZTVFVsVFUwbFBUbDlXU1VWWExDQW5WbWxsZHlCd1pYSnRhWE56YVc5dUlHbHpJSEpsY1hWcGNtVmtKeWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdKUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVm1sbGR5QndaWEp0YVhOemFXOXVJR2x6SUhKbGNYVnBjbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNQW9nSUNBZ0x5OGdZWE56WlhKMEtIQmxjbTFwYzNOcGIyNXpJRHc5SUUxQldGOVFSVkpOU1ZOVFNVOU9YMFpNUVVkVExDQW5WVzVyYm05M2JpQndaWEp0YVhOemFXOXVJR1pzWVdkekp5a0tJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTVRVZ0x5OGdNVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNXJibTkzYmlCd1pYSnRhWE56YVc5dUlHWnNZV2R6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNUW9nSUNBZ0x5OGdZWE56WlhKMEtHVjRjR2x5ZVZScGJXVnpkR0Z0Y0NBK0lFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFzSUNkRmVIQnBjbmtnYlhWemRDQmlaU0JwYmlCMGFHVWdablYwZFhKbEp5a0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklFVjRjR2x5ZVNCdGRYTjBJR0psSUdsdUlIUm9aU0JtZFhSMWNtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUdkeVlXNTBjeUE5SUVKdmVFMWhjRHhIY21GdWRFdGxlU3dnUVdOalpYTnpSM0poYm5RK0tIc2dhMlY1VUhKbFptbDRPaUFuWnljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltY2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UTUtJQ0FnSUM4dklHbG1JQ2gwYUdsekxtZHlZVzUwY3loclpYa3BMbVY0YVhOMGN5a2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCbmNtRnVkRUZqWTJWemMxOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUJqYjI1emRDQmxlR2x6ZEdsdVowZHlZVzUwSUQwZ1kyeHZibVVvZEdocGN5NW5jbUZ1ZEhNb2EyVjVLUzUyWVd4MVpTa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NW5aWFJCWTJObGMzTlRkR0YwZFhNb1pYaHBjM1JwYm1kSGNtRnVkQ2tnSVQwOUlGTlVRVlJWVTE5QlExUkpWa1VzSUNkQlkzUnBkbVVnWVdOalpYTnpJR2R5WVc1MElHRnNjbVZoWkhrZ1pYaHBjM1J6SnlrS0lDQWdJR05oYkd4emRXSWdaMlYwUVdOalpYTnpVM1JoZEhWekNpQWdJQ0J3YjNBS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTNScGRtVWdZV05qWlhOeklHZHlZVzUwSUdGc2NtVmhaSGtnWlhocGMzUnpDZ3BuY21GdWRFRmpZMlZ6YzE5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNQW9nSUNBZ0x5OGdjMlZ1WkdWeU9pQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNallLSUNBZ0lDOHZJR2R5WVc1MFpXUkJkRG9nUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDd0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNExURXlPQW9nSUNBZ0x5OGdZMjl1YzNRZ1ozSmhiblE2SUVGalkyVnpjMGR5WVc1MElEMGdld29nSUNBZ0x5OGdJQ0JrYjJOMWJXVnVkRWxrTEFvZ0lDQWdMeThnSUNCelpXNWtaWEk2SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCeVpXTmxhWFpsY2tGa1pISmxjM011WW5sMFpYTXNDaUFnSUNBdkx5QWdJSEIxY25CdmMyVklZWE5vTEFvZ0lDQWdMeThnSUNCd1pYSnRhWE56YVc5dWN5d0tJQ0FnSUM4dklDQWdaWGh3YVhKNVZHbHRaWE4wWVcxd0xBb2dJQ0FnTHk4Z0lDQnpkR0YwZFhNNklGTlVRVlJWVTE5QlExUkpWa1VzQ2lBZ0lDQXZMeUFnSUdkeVlXNTBaV1JCZERvZ1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ3dLSUNBZ0lDOHZJQ0FnY21WMmIydGxaRUYwT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlCOUNpQWdJQ0JrYVdjZ09Rb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBNENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRGdLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ053b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOUW9nSUNBZ0x5OGdjM1JoZEhWek9pQlRWRUZVVlZOZlFVTlVTVlpGTEFvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTRMVEV5T0FvZ0lDQWdMeThnWTI5dWMzUWdaM0poYm5RNklFRmpZMlZ6YzBkeVlXNTBJRDBnZXdvZ0lDQWdMeThnSUNCa2IyTjFiV1Z1ZEVsa0xBb2dJQ0FnTHk4Z0lDQnpaVzVrWlhJNklGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQnlaV05sYVhabGNrRmtaSEpsYzNNdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUhCMWNuQnZjMlZJWVhOb0xBb2dJQ0FnTHk4Z0lDQndaWEp0YVhOemFXOXVjeXdLSUNBZ0lDOHZJQ0FnWlhod2FYSjVWR2x0WlhOMFlXMXdMQW9nSUNBZ0x5OGdJQ0J6ZEdGMGRYTTZJRk5VUVZSVlUxOUJRMVJKVmtVc0NpQWdJQ0F2THlBZ0lHZHlZVzUwWldSQmREb2dSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0N3S0lDQWdJQzh2SUNBZ2NtVjJiMnRsWkVGME9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QjlDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNQW9nSUNBZ0x5OGdkR2hwY3k1bmNtRnVkSE1vYTJWNUtTNTJZV3gxWlNBOUlHTnNiMjVsS0dkeVlXNTBLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0xQ2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EQUtJQ0FnSUM4dklFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFzQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNaTB4TkRFS0lDQWdJQzh2SUdWdGFYUW9DaUFnSUNBdkx5QWdJQ2RCWTJObGMzTkhjbUZ1ZEdWa0p5d0tJQ0FnSUM4dklDQWdaRzlqZFcxbGJuUkpaQ3dLSUNBZ0lDOHZJQ0FnVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhKQlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCd2RYSndiM05sU0dGemFDd0tJQ0FnSUM4dklDQWdjR1Z5YldsemMybHZibk1zQ2lBZ0lDQXZMeUFnSUdWNGNHbHllVlJwYldWemRHRnRjQ3dLSUNBZ0lDOHZJQ0FnUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDd0tJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QXhNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TW1Rd01qTTROeUF2THlCdFpYUm9iMlFnSWtGalkyVnpjMGR5WVc1MFpXUW9kV2x1ZERZMExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWVYUmxXek15WFN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU55MHhNRE1LSUNBZ0lDOHZJSEIxWW14cFl5Qm5jbUZ1ZEVGalkyVnpjeWdLSUNBZ0lDOHZJQ0FnWkc5amRXMWxiblJKWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2tGa1pISmxjM002SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUhCMWNuQnZjMlZJWVhOb09pQmllWFJsY3p3ek1qNHNDaUFnSUNBdkx5QWdJSEJsY20xcGMzTnBiMjV6T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdWNGNHbHllVlJwYldWemRHRnRjRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UTI5dWMyVnVkRkpsWjJsemRISjVMbkpsZG05clpVRmpZMlZ6YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxkbTlyWlVGalkyVnpjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTBDaUFnSUNBdkx5QndkV0pzYVdNZ2NtVjJiMnRsUVdOalpYTnpLR1J2WTNWdFpXNTBTV1E2SUhWcGJuUTJOQ3dnY21WalpXbDJaWEpCWkdSeVpYTnpPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EVUtJQ0FnSUM4dklIUm9hWE11Y21WeGRXbHlaVVJ2WTNWdFpXNTBUM2R1WlhJb1pHOWpkVzFsYm5SSlpDa0tJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUhKbGNYVnBjbVZFYjJOMWJXVnVkRTkzYm1WeUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEzQ2lBZ0lDQXZMeUJqYjI1emRDQnJaWGtnUFNCMGFHbHpMbWR5WVc1MFMyVjVLR1J2WTNWdFpXNTBTV1FzSUhKbFkyVnBkbVZ5UVdSa2NtVnpjeWtLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHZHlZVzUwUzJWNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJuY21GdWRITWdQU0JDYjNoTllYQThSM0poYm5STFpYa3NJRUZqWTJWemMwZHlZVzUwUGloN0lHdGxlVkJ5WldacGVEb2dKMmNuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVaM0poYm5SektHdGxlU2t1WlhocGMzUnpMQ0FuUVdOalpYTnpJR2R5WVc1MElHNXZkQ0JtYjNWdVpDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRUZqWTJWemN5Qm5jbUZ1ZENCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV3Q2lBZ0lDQXZMeUJqYjI1emRDQm5jbUZ1ZENBOUlHTnNiMjVsS0hSb2FYTXVaM0poYm5SektHdGxlU2t1ZG1Gc2RXVXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5URUtJQ0FnSUM4dklHRnpjMlZ5ZENobmNtRnVkQzV6ZEdGMGRYTWdJVDA5SUZOVVFWUlZVMTlTUlZaUFMwVkVMQ0FuUVdOalpYTnpJR2R5WVc1MElHRnNjbVZoWkhrZ2NtVjJiMnRsWkNjcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEl3SUM4dklERXlNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjeUJuY21GdWRDQmhiSEpsWVdSNUlISmxkbTlyWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV6Q2lBZ0lDQXZMeUJuY21GdWRDNXpkR0YwZFhNZ1BTQlRWRUZVVlZOZlVrVldUMHRGUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlERXlNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UUUtJQ0FnSUM4dklHZHlZVzUwTG5KbGRtOXJaV1JCZENBOUlFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlERXpOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UVUtJQ0FnSUM4dklIUm9hWE11WjNKaGJuUnpLR3RsZVNrdWRtRnNkV1VnUFNCamJHOXVaU2huY21GdWRDa0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTNDaUFnSUNBdkx5QmxiV2wwS0NkQlkyTmxjM05TWlhadmEyVmtKeXdnWkc5amRXMWxiblJKWkN3Z1ZIaHVMbk5sYm1SbGNpd2djbVZqWldsMlpYSkJaR1J5WlhOekxDQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRGbU9EVXhabVlnTHk4Z2JXVjBhRzlrSUNKQlkyTmxjM05TWlhadmEyVmtLSFZwYm5RMk5DeGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTkFvZ0lDQWdMeThnY0hWaWJHbGpJSEpsZG05clpVRmpZMlZ6Y3loa2IyTjFiV1Z1ZEVsa09pQjFhVzUwTmpRc0lISmxZMlZwZG1WeVFXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rTnZibk5sYm5SU1pXZHBjM1J5ZVM1MlpYSnBabmxCWTJObGMzTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpubEJZMk5sYzNNNkNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qQXRNVFl4Q2lBZ0lDQXZMeUJBY21WaFpHOXViSGtLSUNBZ0lDOHZJSEIxWW14cFl5QjJaWEpwWm5sQlkyTmxjM01vWkc5amRXMWxiblJKWkRvZ2RXbHVkRFkwTENCeVpXTmxhWFpsY2tGa1pISmxjM002SUVGalkyOTFiblFwT2lCQlkyTmxjM05XWlhKcFptbGpZWFJwYjI0Z2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk1nb2dJQ0FnTHk4Z1kyOXVjM1FnYTJWNUlEMGdkR2hwY3k1bmNtRnVkRXRsZVNoa2IyTjFiV1Z1ZEVsa0xDQnlaV05sYVhabGNrRmtaSEpsYzNNcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJuY21GdWRFdGxlUW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qTUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NWtiMk4xYldWdWRITW9aRzlqZFcxbGJuUkpaQ2t1WlhocGMzUnpJSHg4SUNGMGFHbHpMbWR5WVc1MGN5aHJaWGtwTG1WNGFYTjBjeWtnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdaRzlqZFcxbGJuUnpJRDBnUW05NFRXRndQSFZwYm5RMk5Dd2dSRzlqZFcxbGJuUlNaV052Y21RK0tIc2dhMlY1VUhKbFptbDRPaUFuWkNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXpDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXVaRzlqZFcxbGJuUnpLR1J2WTNWdFpXNTBTV1FwTG1WNGFYTjBjeUI4ZkNBaGRHaHBjeTVuY21GdWRITW9hMlY1S1M1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dkbVZ5YVdaNVFXTmpaWE56WDJsbVgySnZaSGxBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdaM0poYm5SeklEMGdRbTk0VFdGd1BFZHlZVzUwUzJWNUxDQkJZMk5sYzNOSGNtRnVkRDRvZXlCclpYbFFjbVZtYVhnNklDZG5KeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWnlJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk13b2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxtUnZZM1Z0Wlc1MGN5aGtiMk4xYldWdWRFbGtLUzVsZUdsemRITWdmSHdnSVhSb2FYTXVaM0poYm5SektHdGxlU2t1WlhocGMzUnpLU0I3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQjJaWEpwWm5sQlkyTmxjM05mWVdaMFpYSmZhV1pmWld4elpVQTBDZ3AyWlhKcFpubEJZMk5sYzNOZmFXWmZZbTlrZVVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpRdE1UWTVDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQjJZV3hwWkRvZ1ptRnNjMlVzQ2lBZ0lDQXZMeUFnSUhCbGNtMXBjM05wYjI1ek9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJSE4wWVhSMWN6b2dVMVJCVkZWVFgwVllVRWxTUlVRc0NpQWdJQ0F2THlBZ0lHVjRjR2x5ZVZScGJXVnpkR0Z0Y0RvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z2ZRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWpBd01EQXdNREF3TURBd01EQXdNREFLQ25abGNtbG1lVUZqWTJWemMxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa052Ym5ObGJuUlNaV2RwYzNSeWVTNTJaWEpwWm5sQlkyTmxjM05BT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl3TFRFMk1Rb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nZG1WeWFXWjVRV05qWlhOektHUnZZM1Z0Wlc1MFNXUTZJSFZwYm5RMk5Dd2djbVZqWldsMlpYSkJaR1J5WlhOek9pQkJZMk52ZFc1MEtUb2dRV05qWlhOelZtVnlhV1pwWTJGMGFXOXVJSHNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25abGNtbG1lVUZqWTJWemMxOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTWdvZ0lDQWdMeThnWTI5dWMzUWdaM0poYm5RZ1BTQmpiRzl1WlNoMGFHbHpMbWR5WVc1MGN5aHJaWGtwTG5aaGJIVmxLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNd29nSUNBZ0x5OGdZMjl1YzNRZ2MzUmhkSFZ6SUQwZ2RHaHBjeTVuWlhSQlkyTmxjM05UZEdGMGRYTW9aM0poYm5RcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEVGalkyVnpjMU4wWVhSMWN3b2dJQ0FnWW5WeWVTQTFDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56UUtJQ0FnSUM4dklHTnZibk4wSUhaaGJHbGtJRDBnYzNSaGRIVnpJRDA5UFNCVFZFRlVWVk5mUVVOVVNWWkZDaUFnSUNCa2RYQUtJQ0FnSUNFS0lDQWdJR0oxY25rZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpnS0lDQWdJQzh2SUhCbGNtMXBjM05wYjI1ek9pQjJZV3hwWkNBL0lHZHlZVzUwTG5CbGNtMXBjM05wYjI1eklEb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ1ltNTZJSFpsY21sbWVVRmpZMlZ6YzE5MFpYSnVZWEo1WDJaaGJITmxRRFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElERXdOQ0F2THlBeE1EUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDZ3AyWlhKcFpubEJZMk5sYzNOZmRHVnlibUZ5ZVY5dFpYSm5aVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPREFLSUNBZ0lDOHZJR1Y0Y0dseWVWUnBiV1Z6ZEdGdGNEb2daM0poYm5RdVpYaHdhWEo1VkdsdFpYTjBZVzF3TEFvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdNVEV5SURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMyTFRFNE1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ2RtRnNhV1FzQ2lBZ0lDQXZMeUFnSUhCbGNtMXBjM05wYjI1ek9pQjJZV3hwWkNBL0lHZHlZVzUwTG5CbGNtMXBjM05wYjI1eklEb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0J6ZEdGMGRYTXNDaUFnSUNBdkx5QWdJR1Y0Y0dseWVWUnBiV1Z6ZEdGdGNEb2daM0poYm5RdVpYaHdhWEo1VkdsdFpYTjBZVzF3TEFvZ0lDQWdMeThnZlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdjMlYwWW1sMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk1DMHhOakVLSUNBZ0lDOHZJRUJ5WldGa2IyNXNlUW9nSUNBZ0x5OGdjSFZpYkdsaklIWmxjbWxtZVVGalkyVnpjeWhrYjJOMWJXVnVkRWxrT2lCMWFXNTBOalFzSUhKbFkyVnBkbVZ5UVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUVGalkyVnpjMVpsY21sbWFXTmhkR2x2YmlCN0NpQWdJQ0JpSUhabGNtbG1lVUZqWTJWemMxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa052Ym5ObGJuUlNaV2RwYzNSeWVTNTJaWEpwWm5sQlkyTmxjM05BT0FvS2RtVnlhV1o1UVdOalpYTnpYM1JsY201aGNubGZabUZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjNENpQWdJQ0F2THlCd1pYSnRhWE56YVc5dWN6b2dkbUZzYVdRZ1B5Qm5jbUZ1ZEM1d1pYSnRhWE56YVc5dWN5QTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCaUlIWmxjbWxtZVVGalkyVnpjMTkwWlhKdVlYSjVYMjFsY21kbFFEY0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEYjI1elpXNTBVbVZuYVhOMGNua3VaMlYwUkc5amRXMWxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkViMk4xYldWdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMExURTROUW9nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBSRzlqZFcxbGJuUW9aRzlqZFcxbGJuUkpaRG9nZFdsdWREWTBLVG9nUkc5amRXMWxiblJTWldOdmNtUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1SdlkzVnRaVzUwY3loa2IyTjFiV1Z1ZEVsa0tTNWxlR2x6ZEhNc0lDZEViMk4xYldWdWRDQnViM1FnWm05MWJtUW5LUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z1pHOWpkVzFsYm5SeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1JHOWpkVzFsYm5SU1pXTnZjbVErS0hzZ2EyVjVVSEpsWm1sNE9pQW5aQ2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMkNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWtiMk4xYldWdWRITW9aRzlqZFcxbGJuUkpaQ2t1WlhocGMzUnpMQ0FuUkc5amRXMWxiblFnYm05MElHWnZkVzVrSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1JHOWpkVzFsYm5RZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TndvZ0lDQWdMeThnY21WMGRYSnVJR05zYjI1bEtIUm9hWE11Wkc5amRXMWxiblJ6S0dSdlkzVnRaVzUwU1dRcExuWmhiSFZsS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TkMweE9EVUtJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFUnZZM1Z0Wlc1MEtHUnZZM1Z0Wlc1MFNXUTZJSFZwYm5RMk5DazZJRVJ2WTNWdFpXNTBVbVZqYjNKa0lIc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEYjI1elpXNTBVbVZuYVhOMGNua3VaMlYwUVdOalpYTnpSM0poYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJCWTJObGMzTkhjbUZ1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGt3TFRFNU1Rb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFFXTmpaWE56UjNKaGJuUW9aRzlqZFcxbGJuUkpaRG9nZFdsdWREWTBMQ0J5WldObGFYWmxja0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXBPaUJCWTJObGMzTkhjbUZ1ZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRreUNpQWdJQ0F2THlCamIyNXpkQ0JyWlhrZ1BTQjBhR2x6TG1keVlXNTBTMlY1S0dSdlkzVnRaVzUwU1dRc0lISmxZMlZwZG1WeVFXUmtjbVZ6Y3lrS0lDQWdJR05oYkd4emRXSWdaM0poYm5STFpYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUdkeVlXNTBjeUE5SUVKdmVFMWhjRHhIY21GdWRFdGxlU3dnUVdOalpYTnpSM0poYm5RK0tIc2dhMlY1VUhKbFptbDRPaUFuWnljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltY2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3pDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVuY21GdWRITW9hMlY1S1M1bGVHbHpkSE1zSUNkQlkyTmxjM01nWjNKaGJuUWdibTkwSUdadmRXNWtKeWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpJR2R5WVc1MElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RVS0lDQWdJQzh2SUdOdmJuTjBJR2R5WVc1MElEMGdZMnh2Ym1Vb2RHaHBjeTVuY21GdWRITW9hMlY1S1M1MllXeDFaU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVFlLSUNBZ0lDOHZJR2R5WVc1MExuTjBZWFIxY3lBOUlIUm9hWE11WjJWMFFXTmpaWE56VTNSaGRIVnpLR2R5WVc1MEtRb2dJQ0FnWTJGc2JITjFZaUJuWlhSQlkyTmxjM05UZEdGMGRYTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURFeU1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RBdE1Ua3hDaUFnSUNBdkx5QkFjbVZoWkc5dWJIa0tJQ0FnSUM4dklIQjFZbXhwWXlCblpYUkJZMk5sYzNOSGNtRnVkQ2hrYjJOMWJXVnVkRWxrT2lCMWFXNTBOalFzSUhKbFkyVnBkbVZ5UVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUVGalkyVnpjMGR5WVc1MElIc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEYjI1elpXNTBVbVZuYVhOMGNua3VjbVZ4ZFdseVpVUnZZM1Z0Wlc1MFQzZHVaWElvWkc5amRXMWxiblJKWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2NtVnhkV2x5WlVSdlkzVnRaVzUwVDNkdVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd01Bb2dJQ0FnTHk4Z2NISnBkbUYwWlNCeVpYRjFhWEpsUkc5amRXMWxiblJQZDI1bGNpaGtiMk4xYldWdWRFbGtPaUIxYVc1ME5qUXBPaUJFYjJOMWJXVnVkRkpsWTI5eVpDQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakF4Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1a2IyTjFiV1Z1ZEhNb1pHOWpkVzFsYm5SSlpDa3VaWGhwYzNSekxDQW5SRzlqZFcxbGJuUWdibTkwSUdadmRXNWtKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z1pHOWpkVzFsYm5SeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1JHOWpkVzFsYm5SU1pXTnZjbVErS0hzZ2EyVjVVSEpsWm1sNE9pQW5aQ2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBeENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWtiMk4xYldWdWRITW9aRzlqZFcxbGJuUkpaQ2t1WlhocGMzUnpMQ0FuUkc5amRXMWxiblFnYm05MElHWnZkVzVrSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1JHOWpkVzFsYm5RZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TXdvZ0lDQWdMeThnWTI5dWMzUWdaRzlqZFcxbGJuUWdQU0JqYkc5dVpTaDBhR2x6TG1SdlkzVnRaVzUwY3loa2IyTjFiV1Z1ZEVsa0tTNTJZV3gxWlNrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURRS0lDQWdJQzh2SUdGemMyVnlkQ2hrYjJOMWJXVnVkQzV2ZDI1bGNpQTlQVDBnVkhodUxuTmxibVJsY2k1aWVYUmxjeXdnSjA5dWJIa2daRzlqZFcxbGJuUWdiM2R1WlhJZ1kyRnVJSEJsY21admNtMGdkR2hwY3lCaFkzUnBiMjRuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dNeklLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmtiMk4xYldWdWRDQnZkMjVsY2lCallXNGdjR1Z5Wm05eWJTQjBhR2x6SUdGamRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EVUtJQ0FnSUM4dklISmxkSFZ5YmlCa2IyTjFiV1Z1ZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRMjl1YzJWdWRGSmxaMmx6ZEhKNUxtZHlZVzUwUzJWNUtHUnZZM1Z0Wlc1MFNXUTZJSFZwYm5RMk5Dd2djbVZqWldsMlpYSkJaR1J5WlhOek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtZHlZVzUwUzJWNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURnS0lDQWdJQzh2SUhCeWFYWmhkR1VnWjNKaGJuUkxaWGtvWkc5amRXMWxiblJKWkRvZ2RXbHVkRFkwTENCeVpXTmxhWFpsY2tGa1pISmxjM002SUVGalkyOTFiblFwT2lCSGNtRnVkRXRsZVNCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQTVMVEl4TWdvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnWkc5amRXMWxiblJKWkN3S0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklISmxZMlZwZG1WeVFXUmtjbVZ6Y3k1aWVYUmxjeXdLSUNBZ0lDOHZJSDBLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSE5wZW1VS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEYjI1elpXNTBVbVZuYVhOMGNua3VaMlYwUVdOalpYTnpVM1JoZEhWektHZHlZVzUwT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwTENCaWVYUmxjem9LWjJWMFFXTmpaWE56VTNSaGRIVnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UVUtJQ0FnSUM4dklIQnlhWFpoZEdVZ1oyVjBRV05qWlhOelUzUmhkSFZ6S0dkeVlXNTBPaUJCWTJObGMzTkhjbUZ1ZENrNklIVnBiblEyTkNCN0NpQWdJQ0J3Y205MGJ5QXhJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRTJDaUFnSUNBdkx5QnBaaUFvWjNKaGJuUXVjM1JoZEhWeklEMDlQU0JUVkVGVVZWTmZRVU5VU1ZaRklDWW1JRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBZ1BpQm5jbUZ1ZEM1bGVIQnBjbmxVYVcxbGMzUmhiWEFwSUhzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXhNakFnTHk4Z01USXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWJub2daMlYwUVdOalpYTnpVM1JoZEhWelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElERXhNaUF2THlBeE1USUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBK0NpQWdJQ0JpZWlCblpYUkJZMk5sYzNOVGRHRjBkWE5mWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUZOVVFWUlZVMTlGV0ZCSlVrVkVDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEpsZEhOMVlnb0taMlYwUVdOalpYTnpVM1JoZEhWelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakl3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdaM0poYm5RdWMzUmhkSFZ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBU0FJQUNZRUFXUUVGUjk4ZFFGbkRtNWxlSFJFYjJOMWJXVnVkRWxrTVJrVVJERVlRUUF5Z2dZRVB3LzhKUVNkNTNOWEJOeVpLdUFFWldPTGN3UjhjZ25FQk5LSG5WUTJHZ0NPQmdBVUFIZ0JTQUdjQWlZQ1FBQ0FCTGhFZXpZMkdnQ09BUUFCQUNzaVp5SkROaG9CU1JVakVrUTJHZ0pKRlNNU1JEWWFBMGtWSXhKRUpTdGxSREVBTWdkTEFoWkpUd05RU3daUVN3VlFTd1JRVHdJV1VDaExBbEJNdjB3aUNDdE1aekVBTWdjV1N3SlBBbEJQQlZCUEJGQlBBMUJNVUlBRXY0RlowMHhRc0NsTVVMQWlRellhQVVjQ0ZTUVNSQmRKTmhvQ1NVNENTUlVqRWtRMkdnTkpUZ01WSXhKRU5ob0VTVTREU1JVa0VrUVhTVTRETmhvRlNVNEVTUlVrRWtRWFNVNENUZ1JMQTRnQnJrOEVTd1NJQWNCTEJESURFMFJNVndnZ1R3UVRSRXNCZ1FJWUloSkVUSUVQRGtReUIwOENERVFxVEZCSnZVVUJRUUFJU2I1RWlBR2ZTRVF4QURJSFN3a1dUd0pRU3doSlRnTlFTd2hKVGdSUVN3Y1dVRXNGRmxBbEZreExBVkJQQWhaUVRGQkxBMHkvTVFBeUJ4WkxERThDVUU4Q1VFOENVRXNHVUVzRVVFeFFnQVFTMENPSFRGQ3dJa00yR2dGSkZTUVNSRWtYTmhvQ1NSVWpFa1JMQVlnQkRFaE1Td0dJQVI0cVRGQkp2VVVCUkVtK1NFbUJlRnNpRTBRaUZseDRNZ2NXWElpL01RQXlCeFpQQTA4Q1VFOENVRXhRZ0FSQitGSC9URkN3SWtNbFNZQUFTVFlhQVVrVkpCSkVGellhQWtrVkl4SkVTd0ZNaUFETVRCWW9URkM5UlFGQkFBMHFTd0ZRU1VVR3ZVVUJRQUFoZ0JrQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdBQUFBQUFBQUFBS1V4UXNDSkRTd1MrUklnQW5FVUZTVVVFU1JSRkEwQUFIa3NEZ1doYlN3UlhjQWlBQVFBbFN3VlVUd0lXVUVzRUZsQk1VRUwveVNWQy8rTTJHZ0ZKRlNRU1JCY1dLRXhRU2IxRkFVUytTQ2xNVUxBaVF6WWFBVWtWSkJKRUZ6WWFBa2tWSXhKRWlBQXdLa3hRU2IxRkFVUytTSWdBTTB3V1hIZ3BURkN3SWtPS0FRR0wveFlvVEZCSnZVVUJSTDVJU1ZjSUlERUFFa1NKaWdJQmkvNFdpLzhWSXhKRWkvOVFpWW9CQW92L2dYaGJTVUFBRWpJSGkvK0JjRnNOUVFBSGdRS0wvMDhDaVlzQWkvOVBBb2s9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiRG9jdW1lbnRSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMyIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiNCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFjY2Vzc0dyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiI0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiNSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjYiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFjY2Vzc1Jldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIzIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
