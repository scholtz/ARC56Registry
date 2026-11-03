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

namespace Arc56.Generated.Ishankalhe911.TraceLoop.TraceLoopLedger_02f478c8
{


    public class TraceLoopLedgerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TraceLoopLedgerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DeviceRecord : AVMObjectType
            {
                public ulong State { get; set; }

                public string OwnerHash { get; set; }

                public string ConfigHash { get; set; }

                public bool StampValid { get; set; }

                public Algorand.Address LastVerifier { get; set; }

                public ulong UpdatedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vState = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vState.From(State);
                    ret.AddRange(vState.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwnerHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOwnerHash.From(OwnerHash);
                    stringRef[ret.Count] = vOwnerHash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConfigHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vConfigHash.From(ConfigHash);
                    stringRef[ret.Count] = vConfigHash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStampValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vStampValid.From(StampValid);
                    ret.AddRange(vStampValid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastVerifier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vLastVerifier.From(LastVerifier);
                    ret.AddRange(vLastVerifier.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUpdatedAt.From(UpdatedAt);
                    ret.AddRange(vUpdatedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DeviceRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new DeviceRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vState = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vState.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueState = vState.ToValue();
                    if (valueState is ulong vStateValue) { ret.State = vStateValue; }
                    var indexOwnerHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwnerHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOwnerHash.Decode(bytes.Skip(indexOwnerHash + prefixOffset).ToArray());
                    var valueOwnerHash = vOwnerHash.ToValue();
                    if (valueOwnerHash is string vOwnerHashValue) { ret.OwnerHash = vOwnerHashValue; }
                    var indexConfigHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConfigHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vConfigHash.Decode(bytes.Skip(indexConfigHash + prefixOffset).ToArray());
                    var valueConfigHash = vConfigHash.ToValue();
                    if (valueConfigHash is string vConfigHashValue) { ret.ConfigHash = vConfigHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStampValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vStampValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStampValid = vStampValid.ToValue();
                    if (valueStampValid is bool vStampValidValue) { ret.StampValid = vStampValidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastVerifier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vLastVerifier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastVerifier = vLastVerifier.ToValue();
                    if (valueLastVerifier is Algorand.Address vLastVerifierValue) { ret.LastVerifier = vLastVerifierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUpdatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUpdatedAt = vUpdatedAt.ToValue();
                    if (valueUpdatedAt is ulong vUpdatedAtValue) { ret.UpdatedAt = vUpdatedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DeviceRecord);
                }
                public bool Equals(DeviceRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DeviceRecord left, DeviceRecord right)
                {
                    return EqualityComparer<DeviceRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(DeviceRecord left, DeviceRecord right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class DeviceRegisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 75, 248, 215, 196 };
                public const string Signature = "DeviceRegistered(string,string,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string DeviceId { get; set; }
                public string OwnerHash { get; set; }
                public ulong Timestamp { get; set; }

                public static DeviceRegisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DeviceRegisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexDeviceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeviceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDeviceId.Decode(eventData.Skip(indexDeviceId).ToArray());
                    var valueDeviceId = vDeviceId.ToValue();
                    if (valueDeviceId is string vDeviceIdValue) { ret.DeviceId = vDeviceIdValue; }
                    var indexOwnerHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwnerHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOwnerHash.Decode(eventData.Skip(indexOwnerHash).ToArray());
                    var valueOwnerHash = vOwnerHash.ToValue();
                    if (valueOwnerHash is string vOwnerHashValue) { ret.OwnerHash = vOwnerHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

            public class DeviceVerifiedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 212, 241, 16, 214 };
                public const string Signature = "DeviceVerified(string,address,string,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string DeviceId { get; set; }
                public Algorand.Address Verifier { get; set; }
                public string ConfigHash { get; set; }
                public ulong Timestamp { get; set; }

                public static DeviceVerifiedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DeviceVerifiedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexDeviceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeviceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDeviceId.Decode(eventData.Skip(indexDeviceId).ToArray());
                    var valueDeviceId = vDeviceId.ToValue();
                    if (valueDeviceId is string vDeviceIdValue) { ret.DeviceId = vDeviceIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vVerifier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVerifier = vVerifier.ToValue();
                    if (valueVerifier is Algorand.Address vVerifierValue) { ret.Verifier = vVerifierValue; }
                    var indexConfigHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConfigHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vConfigHash.Decode(eventData.Skip(indexConfigHash).ToArray());
                    var valueConfigHash = vConfigHash.ToValue();
                    if (valueConfigHash is string vConfigHashValue) { ret.ConfigHash = vConfigHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

            public class DeviceTransferredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 217, 80, 104, 185 };
                public const string Signature = "DeviceTransferred(string,string,address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string DeviceId { get; set; }
                public string NewOwnerHash { get; set; }
                public Algorand.Address Verifier { get; set; }
                public ulong Timestamp { get; set; }

                public static DeviceTransferredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DeviceTransferredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexDeviceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeviceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDeviceId.Decode(eventData.Skip(indexDeviceId).ToArray());
                    var valueDeviceId = vDeviceId.ToValue();
                    if (valueDeviceId is string vDeviceIdValue) { ret.DeviceId = vDeviceIdValue; }
                    var indexNewOwnerHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwnerHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vNewOwnerHash.Decode(eventData.Skip(indexNewOwnerHash).ToArray());
                    var valueNewOwnerHash = vNewOwnerHash.ToValue();
                    if (valueNewOwnerHash is string vNewOwnerHashValue) { ret.NewOwnerHash = vNewOwnerHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vVerifier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVerifier = vVerifier.ToValue();
                    if (valueVerifier is Algorand.Address vVerifierValue) { ret.Verifier = vVerifierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

            public class HardwareChangeDeclaredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 199, 212, 194, 225 };
                public const string Signature = "HardwareChangeDeclared(string,string,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string DeviceId { get; set; }
                public string NewConfigHash { get; set; }
                public ulong Timestamp { get; set; }

                public static HardwareChangeDeclaredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new HardwareChangeDeclaredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexDeviceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeviceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDeviceId.Decode(eventData.Skip(indexDeviceId).ToArray());
                    var valueDeviceId = vDeviceId.ToValue();
                    if (valueDeviceId is string vDeviceIdValue) { ret.DeviceId = vDeviceIdValue; }
                    var indexNewConfigHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewConfigHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vNewConfigHash.Decode(eventData.Skip(indexNewConfigHash).ToArray());
                    var valueNewConfigHash = vNewConfigHash.ToValue();
                    if (valueNewConfigHash is string vNewConfigHashValue) { ret.NewConfigHash = vNewConfigHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

            public class DisputeRaisedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 68, 34, 137, 164 };
                public const string Signature = "DisputeRaised(string,address,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string DeviceId { get; set; }
                public Algorand.Address RaisedBy { get; set; }
                public ulong DisputeType { get; set; }
                public ulong Timestamp { get; set; }

                public static DisputeRaisedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DisputeRaisedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexDeviceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeviceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDeviceId.Decode(eventData.Skip(indexDeviceId).ToArray());
                    var valueDeviceId = vDeviceId.ToValue();
                    if (valueDeviceId is string vDeviceIdValue) { ret.DeviceId = vDeviceIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRaisedBy = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRaisedBy.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRaisedBy = vRaisedBy.ToValue();
                    if (valueRaisedBy is Algorand.Address vRaisedByValue) { ret.RaisedBy = vRaisedByValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDisputeType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisputeType = vDisputeType.ToValue();
                    if (valueDisputeType is ulong vDisputeTypeValue) { ret.DisputeType = vDisputeTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

            public class DisputeResolvedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 162, 25, 30, 122 };
                public const string Signature = "DisputeResolved(string,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string DeviceId { get; set; }
                public ulong ResolvedState { get; set; }
                public ulong Timestamp { get; set; }

                public static DisputeResolvedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DisputeResolvedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexDeviceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeviceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDeviceId.Decode(eventData.Skip(indexDeviceId).ToArray());
                    var valueDeviceId = vDeviceId.ToValue();
                    if (valueDeviceId is string vDeviceIdValue) { ret.DeviceId = vDeviceIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolvedState = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vResolvedState.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueResolvedState = vResolvedState.ToValue();
                    if (valueResolvedState is ulong vResolvedStateValue) { ret.ResolvedState = vResolvedStateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

            public class DeviceRecycledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 102, 213, 108, 180 };
                public const string Signature = "DeviceRecycled(string,address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string DeviceId { get; set; }
                public Algorand.Address Recycler { get; set; }
                public ulong Timestamp { get; set; }

                public static DeviceRecycledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DeviceRecycledEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexDeviceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeviceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDeviceId.Decode(eventData.Skip(indexDeviceId).ToArray());
                    var valueDeviceId = vDeviceId.ToValue();
                    if (valueDeviceId is string vDeviceIdValue) { ret.DeviceId = vDeviceIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecycler = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRecycler.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecycler = vRecycler.ToValue();
                    if (valueRecycler is Algorand.Address vRecyclerValue) { ret.Recycler = vRecyclerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

            public class DeviceExportedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 134, 161, 159, 70 };
                public const string Signature = "DeviceExported(string,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string DeviceId { get; set; }
                public ulong Timestamp { get; set; }

                public static DeviceExportedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DeviceExportedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexDeviceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeviceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDeviceId.Decode(eventData.Skip(indexDeviceId).ToArray());
                    var valueDeviceId = vDeviceId.ToValue();
                    if (valueDeviceId is string vDeviceIdValue) { ret.DeviceId = vDeviceIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///One-time (or rotate-time) assignment of the backend operator
        ///account. Admin only.
        ///</summary>
        /// <param name="operator"> </param>
        public async Task SetOperator(Algorand.Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 15, 107, 138 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            var result = await base.CallApp(new List<object> { abiHandle, operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetOperator_Transactions(Algorand.Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 15, 107, 138 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            return await base.MakeTransactionList(new List<object> { abiHandle, operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Whitelist a new authorized service center account.
        ///Admin only — reflects in-person onboarding, no self-serve.
        ///</summary>
        /// <param name="verifier"> </param>
        public async Task AddVerifier(Algorand.Address verifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 234, 125, 69 };
            var verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); verifierAbi.From(verifier);

            var result = await base.CallApp(new List<object> { abiHandle, verifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddVerifier_Transactions(Algorand.Address verifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 234, 125, 69 };
            var verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); verifierAbi.From(verifier);

            return await base.MakeTransactionList(new List<object> { abiHandle, verifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revoke a verifier's authorization (e.g. reputation dropped
        ///below threshold, or brand authorization lost). Admin only.
        ///</summary>
        /// <param name="verifier"> </param>
        public async Task RemoveVerifier(Algorand.Address verifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 100, 20, 39 };
            var verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); verifierAbi.From(verifier);

            var result = await base.CallApp(new List<object> { abiHandle, verifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveVerifier_Transactions(Algorand.Address verifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 100, 20, 39 };
            var verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); verifierAbi.From(verifier);

            return await base.MakeTransactionList(new List<object> { abiHandle, verifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Whitelist a CPCB-registered recycler account. Admin only.
        ///</summary>
        /// <param name="recycler"> </param>
        public async Task AddRecycler(Algorand.Address recycler, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 36, 224, 158 };
            var recyclerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recyclerAbi.From(recycler);

            var result = await base.CallApp(new List<object> { abiHandle, recyclerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddRecycler_Transactions(Algorand.Address recycler, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 36, 224, 158 };
            var recyclerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recyclerAbi.From(recycler);

            return await base.MakeTransactionList(new List<object> { abiHandle, recyclerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revoke a recycler's authorization. Admin only.
        ///</summary>
        /// <param name="recycler"> </param>
        public async Task RemoveRecycler(Algorand.Address recycler, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 197, 158, 134 };
            var recyclerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recyclerAbi.From(recycler);

            var result = await base.CallApp(new List<object> { abiHandle, recyclerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveRecycler_Transactions(Algorand.Address recycler, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 197, 158, 134 };
            var recyclerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recyclerAbi.From(recycler);

            return await base.MakeTransactionList(new List<object> { abiHandle, recyclerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        /// <param name="owner_hash"> </param>
        /// <param name="config_hash"> </param>
        public async Task RegisterDevice(string device_id, string owner_hash, string config_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 178, 156, 67 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var owner_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); owner_hashAbi.From(owner_hash);
            var config_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); config_hashAbi.From(config_hash);

            var result = await base.CallApp(new List<object> { abiHandle, device_idAbi, owner_hashAbi, config_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterDevice_Transactions(string device_id, string owner_hash, string config_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 178, 156, 67 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var owner_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); owner_hashAbi.From(owner_hash);
            var config_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); config_hashAbi.From(config_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi, owner_hashAbi, config_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        /// <param name="confirmed_config_hash"> </param>
        public async Task VerifyDevice(string device_id, string confirmed_config_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 217, 168, 96 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var confirmed_config_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); confirmed_config_hashAbi.From(confirmed_config_hash);

            var result = await base.CallApp(new List<object> { abiHandle, device_idAbi, confirmed_config_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VerifyDevice_Transactions(string device_id, string confirmed_config_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 217, 168, 96 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var confirmed_config_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); confirmed_config_hashAbi.From(confirmed_config_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi, confirmed_config_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        /// <param name="new_owner_hash"> </param>
        public async Task TransferDevice(string device_id, string new_owner_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 179, 128, 35 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var new_owner_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_owner_hashAbi.From(new_owner_hash);

            var result = await base.CallApp(new List<object> { abiHandle, device_idAbi, new_owner_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferDevice_Transactions(string device_id, string new_owner_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 179, 128, 35 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var new_owner_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_owner_hashAbi.From(new_owner_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi, new_owner_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        /// <param name="new_config_hash"> </param>
        public async Task DeclareHardwareChange(string device_id, string new_config_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 108, 213, 65 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var new_config_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_config_hashAbi.From(new_config_hash);

            var result = await base.CallApp(new List<object> { abiHandle, device_idAbi, new_config_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeclareHardwareChange_Transactions(string device_id, string new_config_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 108, 213, 65 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var new_config_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_config_hashAbi.From(new_config_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi, new_config_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        /// <param name="dispute_type"> </param>
        public async Task RaiseDispute(string device_id, ulong dispute_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 82, 208, 26 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var dispute_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_typeAbi.From(dispute_type);

            var result = await base.CallApp(new List<object> { abiHandle, device_idAbi, dispute_typeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RaiseDispute_Transactions(string device_id, ulong dispute_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 82, 208, 26 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var dispute_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_typeAbi.From(dispute_type);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi, dispute_typeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin only. resolved_state must be REGISTERED, VERIFIED, or
        ///TRANSFERRED — never a terminal state (use mark_recycled / mark_exported for that) and never DISPUTED again (no-op).
        ///</summary>
        /// <param name="device_id"> </param>
        /// <param name="resolved_state"> </param>
        public async Task ResolveDispute(string device_id, ulong resolved_state, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 173, 208, 172 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var resolved_stateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolved_stateAbi.From(resolved_state);

            var result = await base.CallApp(new List<object> { abiHandle, device_idAbi, resolved_stateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResolveDispute_Transactions(string device_id, ulong resolved_state, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 173, 208, 172 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var resolved_stateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolved_stateAbi.From(resolved_state);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi, resolved_stateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        public async Task MarkRecycled(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 113, 134, 185 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            var result = await base.CallApp(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkRecycled_Transactions(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 113, 134, 185 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        public async Task MarkExported(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 38, 1, 20 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            var result = await base.CallApp(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkExported_Transactions(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 38, 1, 20 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        public async Task<Structs.DeviceRecord> GetDeviceState(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 239, 166, 216 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            var result = await base.SimApp(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DeviceRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetDeviceState_Transactions(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 239, 166, 216 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        public async Task<bool> CanVerify(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 111, 240, 231 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            var result = await base.SimApp(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CanVerify_Transactions(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 111, 240, 231 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        public async Task<bool> CanTransfer(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 250, 63, 178 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            var result = await base.SimApp(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CanTransfer_Transactions(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 250, 63, 178 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="device_id"> </param>
        public async Task<bool> CanRecycle(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 30, 240, 54 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            var result = await base.SimApp(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CanRecycle_Transactions(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 30, 240, 54 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJhY2VMb29wTGVkZ2VyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkRldmljZVJlY29yZCI6W3sibmFtZSI6InN0YXRlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im93bmVyX2hhc2giLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiY29uZmlnX2hhc2giLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoic3RhbXBfdmFsaWQiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6Imxhc3RfdmVyaWZpZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InVwZGF0ZWRfYXQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InNldF9vcGVyYXRvciIsImRlc2MiOiJPbmUtdGltZSAob3Igcm90YXRlLXRpbWUpIGFzc2lnbm1lbnQgb2YgdGhlIGJhY2tlbmQgb3BlcmF0b3JcbmFjY291bnQuIEFkbWluIG9ubHkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfdmVyaWZpZXIiLCJkZXNjIjoiV2hpdGVsaXN0IGEgbmV3IGF1dGhvcml6ZWQgc2VydmljZSBjZW50ZXIgYWNjb3VudC5cbkFkbWluIG9ubHkg4oCUIHJlZmxlY3RzIGluLXBlcnNvbiBvbmJvYXJkaW5nLCBubyBzZWxmLXNlcnZlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyaWZpZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlX3ZlcmlmaWVyIiwiZGVzYyI6IlJldm9rZSBhIHZlcmlmaWVyJ3MgYXV0aG9yaXphdGlvbiAoZS5nLiByZXB1dGF0aW9uIGRyb3BwZWRcbmJlbG93IHRocmVzaG9sZCwgb3IgYnJhbmQgYXV0aG9yaXphdGlvbiBsb3N0KS4gQWRtaW4gb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcmlmaWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9yZWN5Y2xlciIsImRlc2MiOiJXaGl0ZWxpc3QgYSBDUENCLXJlZ2lzdGVyZWQgcmVjeWNsZXIgYWNjb3VudC4gQWRtaW4gb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY3ljbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbW92ZV9yZWN5Y2xlciIsImRlc2MiOiJSZXZva2UgYSByZWN5Y2xlcidzIGF1dGhvcml6YXRpb24uIEFkbWluIG9ubHkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWN5Y2xlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3Rlcl9kZXZpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lcl9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb25maWdfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRGV2aWNlUmVnaXN0ZXJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZpY2VfaWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lcl9oYXNoIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2RldmljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZpY2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbmZpcm1lZF9jb25maWdfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRGV2aWNlVmVyaWZpZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcmlmaWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29uZmlnX2hhc2giLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2Zlcl9kZXZpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXJfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRGV2aWNlVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyX2hhc2giLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyaWZpZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWNsYXJlX2hhcmR3YXJlX2NoYW5nZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZpY2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19jb25maWdfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiSGFyZHdhcmVDaGFuZ2VEZWNsYXJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZpY2VfaWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfY29uZmlnX2hhc2giLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyYWlzZV9kaXNwdXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRldmljZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGlzcHV0ZV90eXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJEaXNwdXRlUmFpc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRldmljZV9pZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyYWlzZWRfYnkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaXNwdXRlX3R5cGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNvbHZlX2Rpc3B1dGUiLCJkZXNjIjoiQWRtaW4gb25seS4gcmVzb2x2ZWRfc3RhdGUgbXVzdCBiZSBSRUdJU1RFUkVELCBWRVJJRklFRCwgb3JcblRSQU5TRkVSUkVEIOKAlCBuZXZlciBhIHRlcm1pbmFsIHN0YXRlICh1c2UgbWFya19yZWN5Y2xlZCAvIG1hcmtfZXhwb3J0ZWQgZm9yIHRoYXQpIGFuZCBuZXZlciBESVNQVVRFRCBhZ2FpbiAobm8tb3ApLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZpY2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc29sdmVkX3N0YXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJEaXNwdXRlUmVzb2x2ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzb2x2ZWRfc3RhdGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXJrX3JlY3ljbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRldmljZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRGV2aWNlUmVjeWNsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY3ljbGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya19leHBvcnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZpY2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkRldmljZUV4cG9ydGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRldmljZV9pZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9kZXZpY2Vfc3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsc3RyaW5nLHN0cmluZyxib29sLGFkZHJlc3MsdWludDY0KSIsInN0cnVjdCI6IkRldmljZVJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuX3ZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZpY2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5fdHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuX3JlY3ljbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4OTJdLCJlcnJvck1lc3NhZ2UiOiJjYW5ub3QgZGVjbGFyZSBoYXJkd2FyZSBjaGFuZ2Ugd2hpbGUgZGlzcHV0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDA4LDE2MzVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm9wZXJhdG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4OF0sImVycm9yTWVzc2FnZSI6ImRldmljZSBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjYyXSwiZXJyb3JNZXNzYWdlIjoiZGV2aWNlIGlzIGV4cG9ydGVkIOKAlCB0ZXJtaW5hbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NTZdLCJlcnJvck1lc3NhZ2UiOiJkZXZpY2UgaXMgcmVjeWNsZWQg4oCUIHRlcm1pbmFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2OV0sImVycm9yTWVzc2FnZSI6ImRldmljZSBtdXN0IGJlIGZyZXNobHkgVFJBTlNGRVJSRUQgdG8gYSByZWN5Y2xlciB0byBiZSByZWN5Y2xlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNDddLCJlcnJvck1lc3NhZ2UiOiJkZXZpY2Ugbm90IGRpc3B1dGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTEyLDY5MSw4NzIsMTAyNywxMTM0LDEyNTYsMTM0MiwxNDE1XSwiZXJyb3JNZXNzYWdlIjoiZGV2aWNlIG5vdCByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTE0XSwiZXJyb3JNZXNzYWdlIjoiaGFyZHdhcmUgY2hhbmdlIG9ubHkgYWxsb3dlZCBpbiBSRUdJU1RFUkVELCBWRVJJRklFRCwgb3IgVFJBTlNGRVJSRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTksNTUzLDY5OSw3MTIsODc5LDEwMzUsMTE0MiwxMjY0LDEzNTAsMTQ1OSwxNDg4LDE1NDcsMTU1OCwxNjE3XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNiwzNTIsMzY4LDQ3NSw0OTQsNjUzLDY2OSw4MzUsODU0LDk4NywxMDk4LDEyMzEsMTMyMCwxNDAwLDE0MzEsMTUxOSwxNTg5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ2LDM2MiwzNzUsNDg1LDUwMCw2NjMsNjc5LDg0NSw4NjAsOTk0LDExMDUsMTIzOCwxMzI3LDE0MDcsMTQzOCwxNTI2LDE1OTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE0LDIzNSwyNTksMjg2LDMxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDAyLDExMTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTczXSwiZXJyb3JNZXNzYWdlIjoibXVzdCByZXNvbHZlIGludG8gUkVHSVNURVJFRCwgVkVSSUZJRUQsIG9yIFRSQU5TRkVSUkVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0N10sImVycm9yTWVzc2FnZSI6Im5vdCBhbiBhdXRob3JpemVkIHJlY3ljbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY0Nl0sImVycm9yTWVzc2FnZSI6Im5vdCBhbiBhdXRob3JpemVkIHZlcmlmaWVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxOF0sImVycm9yTWVzc2FnZSI6Im5vdCBhdXRob3JpemVkIHRvIHJhaXNlIGRpc3B1dGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjAsMjQxLDI2NSwyOTIsMzE3LDExMjIsMTMzM10sImVycm9yTWVzc2FnZSI6Im9ubHkgYWRtaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjM3XSwiZXJyb3JNZXNzYWdlIjoib25seSBvcGVyYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyNl0sImVycm9yTWVzc2FnZSI6InJlY3ljbGVyIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyMl0sImVycm9yTWVzc2FnZSI6InN0YW1wIG5vdCB2YWxpZCDigJQgcmUtdmVyaWZ5IGZpcnN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzA3XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNmZXIgb25seSBhbGxvd2VkIGZyb20gVkVSSUZJRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzNdLCJlcnJvck1lc3NhZ2UiOiJ2ZXJpZmllciBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjddLCJlcnJvck1lc3NhZ2UiOiJ2ZXJpZnkgb25seSBhbGxvd2VkIGZyb20gUkVHSVNURVJFRCwgVFJBTlNGRVJSRUQsIG9yIFZFUklGSUVEIHdpdGggaW52YWxpZCBzdGFtcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWlBNENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE5qUTJOVGMyTmprMk16WTFOV1lnTUhnd01DQXdlRGMyTmpVM01qWTVOalkyT1RZMU56STFaaUF3ZURFMU1XWTNZemMxSURCNE5tWTNNRFkxTnpJMk1UYzBObVkzTWlBd2VEY3lOalUyTXpjNU5qTTJZelkxTnpJMVppQXdlREF3TUdNZ01IZ3dNREpqQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk1UY3pDaUFnSUNBdkx5QmpiR0Z6Y3lCVWNtRmpaVXh2YjNCTVpXUm5aWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREkyQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGczWkRCbU5tSTRZU0F3ZURRNVpXRTNaRFExSURCNE1HRTJOREUwTWpjZ01IZzJNREkwWlRBNVpTQXdlRE5tWXpVNVpUZzJJREI0T1dGaU1qbGpORE1nTUhoaU1tUTVZVGcyTUNBd2VETmxZak00TURJeklEQjRZMlUyWTJRMU5ERWdNSGhrWlRVeVpEQXhZU0F3ZUdKallXUmtNR0ZqSURCNFl6STNNVGcyWWprZ01IZzJNakkyTURFeE5DQXdlR1prWldaaE5tUTRJREI0TnprMlptWXdaVGNnTUhnek9XWmhNMlppTWlBd2VEVXlNV1ZtTURNMklDOHZJRzFsZEdodlpDQWljMlYwWDI5d1pYSmhkRzl5S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlZV1JrWDNabGNtbG1hV1Z5S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljbVZ0YjNabFgzWmxjbWxtYVdWeUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdSa1gzSmxZM2xqYkdWeUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WdGIzWmxYM0psWTNsamJHVnlLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVm5hWE4wWlhKZlpHVjJhV05sS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW5abGNtbG1lVjlrWlhacFkyVW9jM1J5YVc1bkxITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0owY21GdWMyWmxjbDlrWlhacFkyVW9jM1J5YVc1bkxITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0prWldOc1lYSmxYMmhoY21SM1lYSmxYMk5vWVc1blpTaHpkSEpwYm1jc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpoYVhObFgyUnBjM0IxZEdVb2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaWE52YkhabFgyUnBjM0IxZEdVb2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnRZWEpyWDNKbFkzbGpiR1ZrS0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSnRZWEpyWDJWNGNHOXlkR1ZrS0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmWkdWMmFXTmxYM04wWVhSbEtITjBjbWx1Wnlrb2RXbHVkRFkwTEhOMGNtbHVaeXh6ZEhKcGJtY3NZbTl2YkN4aFpHUnlaWE56TEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1OaGJsOTJaWEpwWm5rb2MzUnlhVzVuS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbU5oYmw5MGNtRnVjMlpsY2loemRISnBibWNwWW05dmJDSXNJRzFsZEdodlpDQWlZMkZ1WDNKbFkzbGpiR1VvYzNSeWFXNW5LV0p2YjJ3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnpaWFJmYjNCbGNtRjBiM0lnWVdSa1gzWmxjbWxtYVdWeUlISmxiVzkyWlY5MlpYSnBabWxsY2lCaFpHUmZjbVZqZVdOc1pYSWdjbVZ0YjNabFgzSmxZM2xqYkdWeUlISmxaMmx6ZEdWeVgyUmxkbWxqWlNCMlpYSnBabmxmWkdWMmFXTmxJSFJ5WVc1elptVnlYMlJsZG1salpTQmtaV05zWVhKbFgyaGhjbVIzWVhKbFgyTm9ZVzVuWlNCeVlXbHpaVjlrYVhOd2RYUmxJSEpsYzI5c2RtVmZaR2x6Y0hWMFpTQnRZWEpyWDNKbFkzbGpiR1ZrSUcxaGNtdGZaWGh3YjNKMFpXUWdaMlYwWDJSbGRtbGpaVjl6ZEdGMFpTQmpZVzVmZG1WeWFXWjVJR05oYmw5MGNtRnVjMlpsY2lCallXNWZjbVZqZVdOc1pRb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREkyT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwY21GalpXeHZiM0F1VkhKaFkyVk1iMjl3VEdWa1oyVnlMbk5sZEY5dmNHVnlZWFJ2Y2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjl2Y0dWeVlYUnZjam9LSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRveU1EUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pJd09Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0ltOXViSGtnWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiMjVzZVNCaFpHMXBiZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pJd09Rb2dJQ0FnTHk4Z2MyVnNaaTV2Y0dWeVlYUnZjaTUyWVd4MVpTQTlJRzl3WlhKaGRHOXlDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRObVkzTURZMU56STJNVGMwTm1ZM01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pJd05Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkSEpoWTJWc2IyOXdMbFJ5WVdObFRHOXZjRXhsWkdkbGNpNWhaR1JmZG1WeWFXWnBaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUmZkbVZ5YVdacFpYSTZDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TWpFeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG95TVRVS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNKdmJteDVJR0ZrYldsdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnWVdSdGFXNEtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG95TVRZS0lDQWdJQzh2SUhObGJHWXVkbVZ5YVdacFpYSnpXM1psY21sbWFXVnlYU0E5SUdGeVl6UXVRbTl2YkNoVWNuVmxLU0FnSXlCdWIzRmhPaUJHUWxRd01ETUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzNOalkxTnpJMk9UWTJOamsyTlRjeU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUb3lNVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSeVlXTmxiRzl2Y0M1VWNtRmpaVXh2YjNCTVpXUm5aWEl1Y21WdGIzWmxYM1psY21sbWFXVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WdGIzWmxYM1psY21sbWFXVnlPZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pJeE9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TWpJeUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaWIyNXNlU0JoWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZibXg1SUdGa2JXbHVDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TWpJekNpQWdJQ0F2THlCaGMzTmxjblFnZG1WeWFXWnBaWElnYVc0Z2MyVnNaaTUyWlhKcFptbGxjbk1zSUNKMlpYSnBabWxsY2lCdWIzUWdabTkxYm1RaUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE56WTJOVGN5TmprMk5qWTVOalUzTWpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdkbVZ5YVdacFpYSWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TWpJMENpQWdJQ0F2THlCa1pXd2djMlZzWmk1MlpYSnBabWxsY25OYmRtVnlhV1pwWlhKZENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG95TVRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUnlZV05sYkc5dmNDNVVjbUZqWlV4dmIzQk1aV1JuWlhJdVlXUmtYM0psWTNsamJHVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVdSa1gzSmxZM2xqYkdWeU9nb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPakl5TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNakk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpYjI1c2VTQmhaRzFwYmlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJR0ZrYldsdUNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNak13Q2lBZ0lDQXZMeUJ6Wld4bUxuSmxZM2xqYkdWeWMxdHlaV041WTJ4bGNsMGdQU0JoY21NMExrSnZiMndvVkhKMVpTa2dJQ01nYm05eFlUb2dSa0pVTURBekNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE56STJOVFl6TnprMk16WmpOalUzTWpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk1qSTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwY21GalpXeHZiM0F1VkhKaFkyVk1iMjl3VEdWa1oyVnlMbkpsYlc5MlpWOXlaV041WTJ4bGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsYlc5MlpWOXlaV041WTJ4bGNqb0tJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG95TXpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPakl6TkFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSW05dWJIa2dZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0JoWkcxcGJnb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPakl6TlFvZ0lDQWdMeThnWVhOelpYSjBJSEpsWTNsamJHVnlJR2x1SUhObGJHWXVjbVZqZVdOc1pYSnpMQ0FpY21WamVXTnNaWElnYm05MElHWnZkVzVrSWdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURjeU5qVTJNemM1TmpNMll6WTFOekkxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklISmxZM2xqYkdWeUlHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPakl6TmdvZ0lDQWdMeThnWkdWc0lITmxiR1l1Y21WamVXTnNaWEp6VzNKbFkzbGpiR1Z5WFFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNak14Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMGNtRmpaV3h2YjNBdVZISmhZMlZNYjI5d1RHVmtaMlZ5TG5KbFoybHpkR1Z5WDJSbGRtbGpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFoybHpkR1Z5WDJSbGRtbGpaVG9LSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRveU5Ua0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk1qWTJDaUFnSUNBdkx5QnpaV3htTGw5aGMzTmxjblJmYjNCbGNtRjBiM0lvS1FvZ0lDQWdZMkZzYkhOMVlpQmZZWE56WlhKMFgyOXdaWEpoZEc5eUNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNalkzQ2lBZ0lDQXZMeUJoYzNObGNuUWdaR1YyYVdObFgybGtJRzV2ZENCcGJpQnpaV3htTG1SbGRtbGpaWE1zSUNKa1pYWnBZMlVnWVd4eVpXRmtlU0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZME5qVTNOalk1TmpNMk5UVm1DaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR1JsZG1salpTQmhiSEpsWVdSNUlISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG95TnpRS0lDQWdJQzh2SUd4aGMzUmZkbVZ5YVdacFpYSTlZWEpqTkM1QlpHUnlaWE56S0Vkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNcExBb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk1qYzFDaUFnSUNBdkx5QjFjR1JoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRveU5qa3RNamMyQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0JFWlhacFkyVlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdjM1JoZEdVOVlYSmpOQzVWU1c1ME5qUW9VMVJCVkVWZlVrVkhTVk5VUlZKRlJDa3NDaUFnSUNBdkx5QWdJQ0FnYjNkdVpYSmZhR0Z6YUQxdmQyNWxjbDlvWVhOb0xBb2dJQ0FnTHk4Z0lDQWdJR052Ym1acFoxOW9ZWE5vUFdOdmJtWnBaMTlvWVhOb0xBb2dJQ0FnTHk4Z0lDQWdJSE4wWVcxd1gzWmhiR2xrUFdGeVl6UXVRbTl2YkNoR1lXeHpaU2tzSUNBaklHNXZjV0U2SUVaQ1ZEQXdNeURpZ0pRZ2JtOTBJSFpsY21sbWFXVmtJSGxsZEFvZ0lDQWdMeThnSUNBZ0lHeGhjM1JmZG1WeWFXWnBaWEk5WVhKak5DNUJaR1J5WlhOektFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXBMQW9nSUNBZ0x5OGdJQ0FnSUhWd1pHRjBaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHbHVkQ0ExTXdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNVEF3TXpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPakkzTXdvZ0lDQWdMeThnYzNSaGJYQmZkbUZzYVdROVlYSmpOQzVDYjI5c0tFWmhiSE5sS1N3Z0lDTWdibTl4WVRvZ1JrSlVNREF6SU9LQWxDQnViM1FnZG1WeWFXWnBaV1FnZVdWMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG95TmprdE1qYzJDaUFnSUNBdkx5QnlaV052Y21RZ1BTQkVaWFpwWTJWU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkR1U5WVhKak5DNVZTVzUwTmpRb1UxUkJWRVZmVWtWSFNWTlVSVkpGUkNrc0NpQWdJQ0F2THlBZ0lDQWdiM2R1WlhKZmFHRnphRDF2ZDI1bGNsOW9ZWE5vTEFvZ0lDQWdMeThnSUNBZ0lHTnZibVpwWjE5b1lYTm9QV052Ym1acFoxOW9ZWE5vTEFvZ0lDQWdMeThnSUNBZ0lITjBZVzF3WDNaaGJHbGtQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NJQ0FqSUc1dmNXRTZJRVpDVkRBd015RGlnSlFnYm05MElIWmxjbWxtYVdWa0lIbGxkQW9nSUNBZ0x5OGdJQ0FnSUd4aGMzUmZkbVZ5YVdacFpYSTlZWEpqTkM1QlpHUnlaWE56S0Vkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNcExBb2dJQ0FnTHk4Z0lDQWdJSFZ3WkdGMFpXUmZZWFE5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPakkzTndvZ0lDQWdMeThnYzJWc1ppNWtaWFpwWTJWelcyUmxkbWxqWlY5cFpGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk1qZ3pDaUFnSUNBdkx5QjBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pJNE1DMHlPRFFLSUNBZ0lDOHZJRVJsZG1salpWSmxaMmx6ZEdWeVpXUW9DaUFnSUNBdkx5QWdJQ0FnWkdWMmFXTmxYMmxrUFdSbGRtbGpaVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQnZkMjVsY2w5b1lYTm9QVzkzYm1WeVgyaGhjMmdzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01EQmpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qSTNPUzB5T0RVS0lDQWdJQzh2SUdGeVl6UXVaVzFwZENnS0lDQWdJQzh2SUNBZ0lDQkVaWFpwWTJWU1pXZHBjM1JsY21Wa0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCa1pYWnBZMlZmYVdROVpHVjJhV05sWDJsa0xBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCdmQyNWxjbDlvWVhOb1BXOTNibVZ5WDJoaGMyZ3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lIUnBiV1Z6ZEdGdGNEMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QWdJQ0FnS1FvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdKbU9HUTNZelFnTHk4Z2JXVjBhRzlrSUNKRVpYWnBZMlZTWldkcGMzUmxjbVZrS0hOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TWpVNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBjbUZqWld4dmIzQXVWSEpoWTJWTWIyOXdUR1ZrWjJWeUxuWmxjbWxtZVY5a1pYWnBZMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabmxmWkdWMmFXTmxPZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pJNU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk1qazRDaUFnSUNBdkx5QnpaV3htTGw5aGMzTmxjblJmZG1WeWFXWnBaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQmZZWE56WlhKMFgzWmxjbWxtYVdWeUNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNams1Q2lBZ0lDQXZMeUJoYzNObGNuUWdaR1YyYVdObFgybGtJR2x1SUhObGJHWXVaR1YyYVdObGN5d2dJbVJsZG1salpTQnViM1FnY21WbmFYTjBaWEpsWkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk5EWTFOelkyT1RZek5qVTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHUmxkbWxqWlNCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pNd01Rb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVrWlhacFkyVnpXMlJsZG1salpWOXBaRjB1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pNd01TMHpNRElLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpHVjJhV05sYzF0a1pYWnBZMlZmYVdSZExtTnZjSGtvS1FvZ0lDQWdMeThnYzNSaGRHVWdQU0J5WldOdmNtUXVjM1JoZEdVdWJtRjBhWFpsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk16QXlDaUFnSUNBdkx5QnpkR0YwWlNBOUlISmxZMjl5WkM1emRHRjBaUzV1WVhScGRtVUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pNd013b2dJQ0FnTHk4Z2MyVnNaaTVmWVhOelpYSjBYMjV2ZEY5MFpYSnRhVzVoYkNoemRHRjBaU2tLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZllYTnpaWEowWDI1dmRGOTBaWEp0YVc1aGJBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPak13TlFvZ0lDQWdMeThnYzNSaGRHVWdQVDBnVTFSQlZFVmZVa1ZIU1ZOVVJWSkZSQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNekExTFRNd053b2dJQ0FnTHk4Z2MzUmhkR1VnUFQwZ1UxUkJWRVZmVWtWSFNWTlVSVkpGUkFvZ0lDQWdMeThnYjNJZ2MzUmhkR1VnUFQwZ1UxUkJWRVZmVkZKQlRsTkdSVkpTUlVRS0lDQWdJQzh2SUc5eUlDaHpkR0YwWlNBOVBTQlRWRUZVUlY5V1JWSkpSa2xGUkNCaGJtUWdibTkwSUhKbFkyOXlaQzV6ZEdGdGNGOTJZV3hwWkM1dVlYUnBkbVVwQ2lBZ0lDQmlibm9nZG1WeWFXWjVYMlJsZG1salpWOWliMjlzWDNSeWRXVkFOUW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pNd05nb2dJQ0FnTHk4Z2IzSWdjM1JoZEdVZ1BUMGdVMVJCVkVWZlZGSkJUbE5HUlZKU1JVUUtJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk16QTFMVE13TndvZ0lDQWdMeThnYzNSaGRHVWdQVDBnVTFSQlZFVmZVa1ZIU1ZOVVJWSkZSQW9nSUNBZ0x5OGdiM0lnYzNSaGRHVWdQVDBnVTFSQlZFVmZWRkpCVGxOR1JWSlNSVVFLSUNBZ0lDOHZJRzl5SUNoemRHRjBaU0E5UFNCVFZFRlVSVjlXUlZKSlJrbEZSQ0JoYm1RZ2JtOTBJSEpsWTI5eVpDNXpkR0Z0Y0Y5MllXeHBaQzV1WVhScGRtVXBDaUFnSUNCaWJub2dkbVZ5YVdaNVgyUmxkbWxqWlY5aWIyOXNYM1J5ZFdWQU5Rb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPak13TndvZ0lDQWdMeThnYjNJZ0tITjBZWFJsSUQwOUlGTlVRVlJGWDFaRlVrbEdTVVZFSUdGdVpDQnViM1FnY21WamIzSmtMbk4wWVcxd1gzWmhiR2xrTG01aGRHbDJaU2tLSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1BUMEtJQ0FnSUdKNklIWmxjbWxtZVY5a1pYWnBZMlZmWW05dmJGOW1ZV3h6WlVBMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbTU2SUhabGNtbG1lVjlrWlhacFkyVmZZbTl2YkY5bVlXeHpaVUEyQ2dwMlpYSnBabmxmWkdWMmFXTmxYMkp2YjJ4ZmRISjFaVUExT2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ25abGNtbG1lVjlrWlhacFkyVmZZbTl2YkY5dFpYSm5aVUEzT2dvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qTXdOQzB6TURnS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkR1VnUFQwZ1UxUkJWRVZmVWtWSFNWTlVSVkpGUkFvZ0lDQWdMeThnSUNBZ0lHOXlJSE4wWVhSbElEMDlJRk5VUVZSRlgxUlNRVTVUUmtWU1VrVkVDaUFnSUNBdkx5QWdJQ0FnYjNJZ0tITjBZWFJsSUQwOUlGTlVRVlJGWDFaRlVrbEdTVVZFSUdGdVpDQnViM1FnY21WamIzSmtMbk4wWVcxd1gzWmhiR2xrTG01aGRHbDJaU2tLSUNBZ0lDOHZJQ2tzSUNKMlpYSnBabmtnYjI1c2VTQmhiR3h2ZDJWa0lHWnliMjBnVWtWSFNWTlVSVkpGUkN3Z1ZGSkJUbE5HUlZKU1JVUXNJRzl5SUZaRlVrbEdTVVZFSUhkcGRHZ2dhVzUyWVd4cFpDQnpkR0Z0Y0NJS0lDQWdJR0Z6YzJWeWRDQXZMeUIyWlhKcFpua2diMjVzZVNCaGJHeHZkMlZrSUdaeWIyMGdVa1ZIU1ZOVVJWSkZSQ3dnVkZKQlRsTkdSVkpTUlVRc0lHOXlJRlpGVWtsR1NVVkVJSGRwZEdnZ2FXNTJZV3hwWkNCemRHRnRjQW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pNeE1Bb2dJQ0FnTHk4Z2NtVmpiM0prTG5OMFlYUmxJRDBnWVhKak5DNVZTVzUwTmpRb1UxUkJWRVZmVmtWU1NVWkpSVVFwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPak14TVFvZ0lDQWdMeThnY21WamIzSmtMbU52Ym1acFoxOW9ZWE5vSUQwZ1kyOXVabWx5YldWa1gyTnZibVpwWjE5b1lYTm9DaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG96TVRJS0lDQWdJQzh2SUhKbFkyOXlaQzV6ZEdGdGNGOTJZV3hwWkNBOUlHRnlZelF1UW05dmJDaFVjblZsS1NBZ0l5QnViM0ZoT2lCR1FsUXdNRE1LSUNBZ0lIQjFjMmhwYm5RZ09UWUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J6WlhSaWFYUUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG96TVRNS0lDQWdJQzh2SUhKbFkyOXlaQzVzWVhOMFgzWmxjbWxtYVdWeUlEMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnlaWEJzWVdObE1pQXhNd29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pNeE5Bb2dJQ0FnTHk4Z2NtVmpiM0prTG5Wd1pHRjBaV1JmWVhRZ1BTQmhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURRMUNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNekUxQ2lBZ0lDQXZMeUJ6Wld4bUxtUmxkbWxqWlhOYlpHVjJhV05sWDJsa1hTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUb3pNakFLSUNBZ0lDOHZJSFpsY21sbWFXVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUb3pNaklLSUNBZ0lDOHZJSFJwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk16RTRMVE15TXdvZ0lDQWdMeThnUkdWMmFXTmxWbVZ5YVdacFpXUW9DaUFnSUNBdkx5QWdJQ0FnWkdWMmFXTmxYMmxrUFdSbGRtbGpaVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQjJaWEpwWm1sbGNqMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdZMjl1Wm1sblgyaGhjMmc5WTI5dVptbHliV1ZrWDJOdmJtWnBaMTlvWVhOb0xBb2dJQ0FnTHk4Z0lDQWdJSFJwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vYVc1MElEUTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TURKakNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNekUzTFRNeU5Bb2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtBb2dJQ0FnTHk4Z0lDQWdJRVJsZG1salpWWmxjbWxtYVdWa0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCa1pYWnBZMlZmYVdROVpHVjJhV05sWDJsa0xBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCMlpYSnBabWxsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR052Ym1acFoxOW9ZWE5vUFdOdmJtWnBjbTFsWkY5amIyNW1hV2RmYUdGemFDd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ2RHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDQWdJQ0FwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrTkdZeE1UQmtOaUF2THlCdFpYUm9iMlFnSWtSbGRtbGpaVlpsY21sbWFXVmtLSE4wY21sdVp5eGhaR1J5WlhOekxITjBjbWx1Wnl4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUb3lPVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkbVZ5YVdaNVgyUmxkbWxqWlY5aWIyOXNYMlpoYkhObFFEWTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCMlpYSnBabmxmWkdWMmFXTmxYMkp2YjJ4ZmJXVnlaMlZBTndvS0NpOHZJSFJ5WVdObGJHOXZjQzVVY21GalpVeHZiM0JNWldSblpYSXVkSEpoYm5ObVpYSmZaR1YyYVdObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkSEpoYm5ObVpYSmZaR1YyYVdObE9nb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPak16TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvek16a0tJQ0FnSUM4dklITmxiR1l1WDJGemMyVnlkRjkyWlhKcFptbGxjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlGOWhjM05sY25SZmRtVnlhV1pwWlhJS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUb3pOREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmtaWFpwWTJWZmFXUWdhVzRnYzJWc1ppNWtaWFpwWTJWekxDQWlaR1YyYVdObElHNXZkQ0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZME5qVTNOalk1TmpNMk5UVm1DaUFnSUNCa2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUdSbGRtbGpaU0J1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPak0wTWdvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWtaWFpwWTJWelcyUmxkbWxqWlY5cFpGMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPak0wTWkwek5ETUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WkdWMmFXTmxjMXRrWlhacFkyVmZhV1JkTG1OdmNIa29LUW9nSUNBZ0x5OGdjM1JoZEdVZ1BTQnlaV052Y21RdWMzUmhkR1V1Ym1GMGFYWmxDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG96TkRNS0lDQWdJQzh2SUhOMFlYUmxJRDBnY21WamIzSmtMbk4wWVhSbExtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qTTBOQW9nSUNBZ0x5OGdjMlZzWmk1ZllYTnpaWEowWDI1dmRGOTBaWEp0YVc1aGJDaHpkR0YwWlNrS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQmZZWE56WlhKMFgyNXZkRjkwWlhKdGFXNWhiQW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pNME5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhOMFlYUmxJRDA5SUZOVVFWUkZYMVpGVWtsR1NVVkVMQ0FpZEhKaGJuTm1aWElnYjI1c2VTQmhiR3h2ZDJWa0lHWnliMjBnVmtWU1NVWkpSVVFpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMlpsY2lCdmJteDVJR0ZzYkc5M1pXUWdabkp2YlNCV1JWSkpSa2xGUkFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qTTBOZ29nSUNBZ0x5OGdZWE56WlhKMElISmxZMjl5WkM1emRHRnRjRjkyWVd4cFpDNXVZWFJwZG1Vc0lDSnpkR0Z0Y0NCdWIzUWdkbUZzYVdRZzRvQ1VJSEpsTFhabGNtbG1lU0JtYVhKemRDSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZWE56WlhKMElDOHZJSE4wWVcxd0lHNXZkQ0IyWVd4cFpDRGlnSlFnY21VdGRtVnlhV1o1SUdacGNuTjBDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TXpRNENpQWdJQ0F2THlCeVpXTnZjbVF1YzNSaGRHVWdQU0JoY21NMExsVkpiblEyTkNoVFZFRlVSVjlVVWtGT1UwWkZVbEpGUkNrS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk16UTVDaUFnSUNBdkx5QnlaV052Y21RdWIzZHVaWEpmYUdGemFDQTlJRzVsZDE5dmQyNWxjbDlvWVhOb0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdMUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnlaWEJzWVdObE1pQXhNQW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pNMU1Bb2dJQ0FnTHk4Z2NtVmpiM0prTG5Wd1pHRjBaV1JmWVhRZ1BTQmhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURRMUNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNelV4Q2lBZ0lDQXZMeUJ6Wld4bUxtUmxkbWxqWlhOYlpHVjJhV05sWDJsa1hTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvek5UY0tJQ0FnSUM4dklIWmxjbWxtYVdWeVBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvek5UZ0tJQ0FnSUM4dklIUnBiV1Z6ZEdGdGNEMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TXpVMExUTTFPUW9nSUNBZ0x5OGdSR1YyYVdObFZISmhibk5tWlhKeVpXUW9DaUFnSUNBdkx5QWdJQ0FnWkdWMmFXTmxYMmxrUFdSbGRtbGpaVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQnVaWGRmYjNkdVpYSmZhR0Z6YUQxdVpYZGZiM2R1WlhKZmFHRnphQ3dLSUNBZ0lDOHZJQ0FnSUNCMlpYSnBabWxsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaHBiblFnTkRRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01ESmpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvek5UTXRNell3Q2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvQ2lBZ0lDQXZMeUFnSUNBZ1JHVjJhV05sVkhKaGJuTm1aWEp5WldRb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdSbGRtbGpaVjlwWkQxa1pYWnBZMlZmYVdRc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUc1bGQxOXZkMjVsY2w5b1lYTm9QVzVsZDE5dmQyNWxjbDlvWVhOb0xBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCMlpYSnBabWxsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJSFJwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0tRb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpEazFNRFk0WWprZ0x5OGdiV1YwYUc5a0lDSkVaWFpwWTJWVWNtRnVjMlpsY25KbFpDaHpkSEpwYm1jc2MzUnlhVzVuTEdGa1pISmxjM01zZFdsdWREWTBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk16TXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwY21GalpXeHZiM0F1VkhKaFkyVk1iMjl3VEdWa1oyVnlMbVJsWTJ4aGNtVmZhR0Z5WkhkaGNtVmZZMmhoYm1kbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZqYkdGeVpWOW9ZWEprZDJGeVpWOWphR0Z1WjJVNkNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNelkzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG96TnpNS0lDQWdJQzh2SUhObGJHWXVYMkZ6YzJWeWRGOXZjR1Z5WVhSdmNpZ3BDaUFnSUNCallXeHNjM1ZpSUY5aGMzTmxjblJmYjNCbGNtRjBiM0lLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvek56UUtJQ0FnSUM4dklHRnpjMlZ5ZENCa1pYWnBZMlZmYVdRZ2FXNGdjMlZzWmk1a1pYWnBZMlZ6TENBaVpHVjJhV05sSUc1dmRDQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFkwTmpVM05qWTVOak0yTlRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnWkdWMmFXTmxJRzV2ZENCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNemMyQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtUmxkbWxqWlhOYlpHVjJhV05sWDJsa1hTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNemMyTFRNM053b2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVrWlhacFkyVnpXMlJsZG1salpWOXBaRjB1WTI5d2VTZ3BDaUFnSUNBdkx5QnpkR0YwWlNBOUlISmxZMjl5WkM1emRHRjBaUzV1WVhScGRtVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG96TnpjS0lDQWdJQzh2SUhOMFlYUmxJRDBnY21WamIzSmtMbk4wWVhSbExtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMkNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNemM0Q2lBZ0lDQXZMeUJ6Wld4bUxsOWhjM05sY25SZmJtOTBYM1JsY20xcGJtRnNLSE4wWVhSbEtRb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRjloYzNObGNuUmZibTkwWDNSbGNtMXBibUZzQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk16YzVMVE00TVFvZ0lDQWdMeThnSXlCRWFYTndkWFJsWkNCa1pYWnBZMlZ6SUdOaGJtNXZkQ0JrWldOc1lYSmxJR2hoY21SM1lYSmxJR05vWVc1blpYTWc0b0NVSUdScGMzQjFkR1VLSUNBZ0lDOHZJQ01nYlhWemRDQmlaU0J5WlhOdmJIWmxaQ0JtYVhKemRDNEtJQ0FnSUM4dklHRnpjMlZ5ZENCemRHRjBaU0FoUFNCVFZFRlVSVjlFU1ZOUVZWUkZSQ3dnS0FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUNFOUNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNemM1TFRNNE13b2dJQ0FnTHk4Z0l5QkVhWE53ZFhSbFpDQmtaWFpwWTJWeklHTmhibTV2ZENCa1pXTnNZWEpsSUdoaGNtUjNZWEpsSUdOb1lXNW5aWE1nNG9DVUlHUnBjM0IxZEdVS0lDQWdJQzh2SUNNZ2JYVnpkQ0JpWlNCeVpYTnZiSFpsWkNCbWFYSnpkQzRLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpkR0YwWlNBaFBTQlRWRUZVUlY5RVNWTlFWVlJGUkN3Z0tBb2dJQ0FnTHk4Z0lDQWdJQ0pqWVc1dWIzUWdaR1ZqYkdGeVpTQm9ZWEprZDJGeVpTQmphR0Z1WjJVZ2QyaHBiR1VnWkdsemNIVjBaV1FpQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1Ym05MElHUmxZMnhoY21VZ2FHRnlaSGRoY21VZ1kyaGhibWRsSUhkb2FXeGxJR1JwYzNCMWRHVmtDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TXpnNUNpQWdJQ0F2THlCemRHRjBaU0E5UFNCVFZFRlVSVjlTUlVkSlUxUkZVa1ZFQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG96T0RrdE16a3hDaUFnSUNBdkx5QnpkR0YwWlNBOVBTQlRWRUZVUlY5U1JVZEpVMVJGVWtWRUNpQWdJQ0F2THlCdmNpQnpkR0YwWlNBOVBTQlRWRUZVUlY5V1JWSkpSa2xGUkFvZ0lDQWdMeThnYjNJZ2MzUmhkR1VnUFQwZ1UxUkJWRVZmVkZKQlRsTkdSVkpTUlVRS0lDQWdJR0p1ZWlCa1pXTnNZWEpsWDJoaGNtUjNZWEpsWDJOb1lXNW5aVjlpYjI5c1gzUnlkV1ZBTkFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qTTVNQW9nSUNBZ0x5OGdiM0lnYzNSaGRHVWdQVDBnVTFSQlZFVmZWa1ZTU1VaSlJVUUtJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUb3pPRGt0TXpreENpQWdJQ0F2THlCemRHRjBaU0E5UFNCVFZFRlVSVjlTUlVkSlUxUkZVa1ZFQ2lBZ0lDQXZMeUJ2Y2lCemRHRjBaU0E5UFNCVFZFRlVSVjlXUlZKSlJrbEZSQW9nSUNBZ0x5OGdiM0lnYzNSaGRHVWdQVDBnVTFSQlZFVmZWRkpCVGxOR1JWSlNSVVFLSUNBZ0lHSnVlaUJrWldOc1lYSmxYMmhoY21SM1lYSmxYMk5vWVc1blpWOWliMjlzWDNSeWRXVkFOQW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pNNU1Rb2dJQ0FnTHk4Z2IzSWdjM1JoZEdVZ1BUMGdVMVJCVkVWZlZGSkJUbE5HUlZKU1JVUUtJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk16ZzVMVE01TVFvZ0lDQWdMeThnYzNSaGRHVWdQVDBnVTFSQlZFVmZVa1ZIU1ZOVVJWSkZSQW9nSUNBZ0x5OGdiM0lnYzNSaGRHVWdQVDBnVTFSQlZFVmZWa1ZTU1VaSlJVUUtJQ0FnSUM4dklHOXlJSE4wWVhSbElEMDlJRk5VUVZSRlgxUlNRVTVUUmtWU1VrVkVDaUFnSUNCaWVpQmtaV05zWVhKbFgyaGhjbVIzWVhKbFgyTm9ZVzVuWlY5aWIyOXNYMlpoYkhObFFEVUtDbVJsWTJ4aGNtVmZhR0Z5WkhkaGNtVmZZMmhoYm1kbFgySnZiMnhmZEhKMVpVQTBPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbVJsWTJ4aGNtVmZhR0Z5WkhkaGNtVmZZMmhoYm1kbFgySnZiMnhmYldWeVoyVkFOam9LSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvek9EUXRNemt5Q2lBZ0lDQXZMeUFqSUZaaGJHbGtJR2x1SUdGdWVTQmhZM1JwZG1VZ2IzZHVaWEp6YUdsd0lITjBZWFJsT2lCaVpXWnZjbVVnWm1seWMzUWdkbVZ5YVdaNUNpQWdJQ0F2THlBaklDaFNSVWRKVTFSRlVrVkVLU3dnWVdaMFpYSWdkbVZ5YVdaNUlDaFdSVkpKUmtsRlJDa3NJRzl5SUdGbWRHVnlJSFJ5WVc1elptVnlDaUFnSUNBdkx5QWpJQ2hVVWtGT1UwWkZVbEpGUkNrdUlGQmxjaUJUVDFBZ01TNHlMQ0JHU1ZKVFZGOUNWVmxGVWlCcGN5QmxlSEJzYVdOcGRHeDVDaUFnSUNBdkx5QWpJSEJsY20xcGRIUmxaQ0IwYnlCa1pXTnNZWEpsSUdOb1lXNW5aWE1nWW1WbWIzSmxJR2x1YVhScFlXd2dkbVZ5YVdacFkyRjBhVzl1TGdvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBaU0E5UFNCVFZFRlVSVjlTUlVkSlUxUkZVa1ZFQ2lBZ0lDQXZMeUFnSUNBZ2IzSWdjM1JoZEdVZ1BUMGdVMVJCVkVWZlZrVlNTVVpKUlVRS0lDQWdJQzh2SUNBZ0lDQnZjaUJ6ZEdGMFpTQTlQU0JUVkVGVVJWOVVVa0ZPVTBaRlVsSkZSQW9nSUNBZ0x5OGdLU3dnSW1oaGNtUjNZWEpsSUdOb1lXNW5aU0J2Ym14NUlHRnNiRzkzWldRZ2FXNGdVa1ZIU1ZOVVJWSkZSQ3dnVmtWU1NVWkpSVVFzSUc5eUlGUlNRVTVUUmtWU1VrVkVJZ29nSUNBZ1lYTnpaWEowSUM4dklHaGhjbVIzWVhKbElHTm9ZVzVuWlNCdmJteDVJR0ZzYkc5M1pXUWdhVzRnVWtWSFNWTlVSVkpGUkN3Z1ZrVlNTVVpKUlVRc0lHOXlJRlJTUVU1VFJrVlNVa1ZFQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk16azBDaUFnSUNBdkx5QnlaV052Y21RdVkyOXVabWxuWDJoaGMyZ2dQU0J1WlhkZlkyOXVabWxuWDJoaGMyZ0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPak01TlFvZ0lDQWdMeThnY21WamIzSmtMbk4wWVcxd1gzWmhiR2xrSUQwZ1lYSmpOQzVDYjI5c0tFWmhiSE5sS1NBZ0l5QnViM0ZoT2lCR1FsUXdNRE1nNG9DVUlHWnZjbU5sSUhKbExYWmxjbWxtZVFvZ0lDQWdjSFZ6YUdsdWRDQTVOZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pNNU5nb2dJQ0FnTHk4Z2NtVmpiM0prTG5Wd1pHRjBaV1JmWVhRZ1BTQmhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURRMUNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNemszQ2lBZ0lDQXZMeUJ6Wld4bUxtUmxkbWxqWlhOYlpHVjJhV05sWDJsa1hTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzBNRE1LSUNBZ0lDOHZJSFJwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5EQXdMVFF3TkFvZ0lDQWdMeThnU0dGeVpIZGhjbVZEYUdGdVoyVkVaV05zWVhKbFpDZ0tJQ0FnSUM4dklDQWdJQ0JrWlhacFkyVmZhV1E5WkdWMmFXTmxYMmxrTEFvZ0lDQWdMeThnSUNBZ0lHNWxkMTlqYjI1bWFXZGZhR0Z6YUQxdVpYZGZZMjl1Wm1sblgyaGhjMmdzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01EQmpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qTTVPUzAwTURVS0lDQWdJQzh2SUdGeVl6UXVaVzFwZENnS0lDQWdJQzh2SUNBZ0lDQklZWEprZDJGeVpVTm9ZVzVuWlVSbFkyeGhjbVZrS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JrWlhacFkyVmZhV1E5WkdWMmFXTmxYMmxrTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J1WlhkZlkyOXVabWxuWDJoaGMyZzlibVYzWDJOdmJtWnBaMTlvWVhOb0xBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCMGFXMWxjM1JoYlhBOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0lDQWdJQ2tLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR00zWkRSak1tVXhJQzh2SUcxbGRHaHZaQ0FpU0dGeVpIZGhjbVZEYUdGdVoyVkVaV05zWVhKbFpDaHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qTTJOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGtaV05zWVhKbFgyaGhjbVIzWVhKbFgyTm9ZVzVuWlY5aWIyOXNYMlpoYkhObFFEVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCa1pXTnNZWEpsWDJoaGNtUjNZWEpsWDJOb1lXNW5aVjlpYjI5c1gyMWxjbWRsUURZS0Nnb3ZMeUIwY21GalpXeHZiM0F1VkhKaFkyVk1iMjl3VEdWa1oyVnlMbkpoYVhObFgyUnBjM0IxZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlZV2x6WlY5a2FYTndkWFJsT2dvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qUXhNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZOREU0Q2lBZ0lDQXZMeUJwYzE5dmNHVnlZWFJ2Y2lBOUlGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXZjR1Z5WVhSdmNpNTJZV3gxWlM1dVlYUnBkbVVLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzJaamN3TmpVM01qWXhOelEyWmpjeUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZjR1Z5WVhSdmNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5ERTVDaUFnSUNBdkx5QnBjMTkyWlhKcFptbGxjaUE5SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0JwYmlCelpXeG1MblpsY21sbWFXVnljd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlRGMyTmpVM01qWTVOalkyT1RZMU56STFaZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzBNakFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBjMTl2Y0dWeVlYUnZjaUJ2Y2lCcGMxOTJaWEpwWm1sbGNpd2dJbTV2ZENCaGRYUm9iM0pwZW1Wa0lIUnZJSEpoYVhObElHUnBjM0IxZEdVaUNpQWdJQ0I4ZkFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCaGRYUm9iM0pwZW1Wa0lIUnZJSEpoYVhObElHUnBjM0IxZEdVS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzBNakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmtaWFpwWTJWZmFXUWdhVzRnYzJWc1ppNWtaWFpwWTJWekxDQWlaR1YyYVdObElHNXZkQ0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZME5qVTNOalk1TmpNMk5UVm1DaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUdSbGRtbGpaU0J1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPalF5TXdvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWtaWFpwWTJWelcyUmxkbWxqWlY5cFpGMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPalF5TXkwME1qUUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WkdWMmFXTmxjMXRrWlhacFkyVmZhV1JkTG1OdmNIa29LUW9nSUNBZ0x5OGdjM1JoZEdVZ1BTQnlaV052Y21RdWMzUmhkR1V1Ym1GMGFYWmxDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG8wTWpRS0lDQWdJQzh2SUhOMFlYUmxJRDBnY21WamIzSmtMbk4wWVhSbExtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qUXlOUW9nSUNBZ0x5OGdjMlZzWmk1ZllYTnpaWEowWDI1dmRGOTBaWEp0YVc1aGJDaHpkR0YwWlNrS0lDQWdJR05oYkd4emRXSWdYMkZ6YzJWeWRGOXViM1JmZEdWeWJXbHVZV3dLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME1qY0tJQ0FnSUM4dklISmxZMjl5WkM1emRHRjBaU0E5SUdGeVl6UXVWVWx1ZERZMEtGTlVRVlJGWDBSSlUxQlZWRVZFS1FvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME1qZ0tJQ0FnSUM4dklISmxZMjl5WkM1emRHRnRjRjkyWVd4cFpDQTlJR0Z5WXpRdVFtOXZiQ2hHWVd4elpTa2dJQ01nYm05eFlUb2dSa0pVTURBekNpQWdJQ0J3ZFhOb2FXNTBJRGsyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5ESTVDaUFnSUNBdkx5QnlaV052Y21RdWRYQmtZWFJsWkY5aGRDQTlJR0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLUW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ05EVUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG8wTXpBS0lDQWdJQzh2SUhObGJHWXVaR1YyYVdObGMxdGtaWFpwWTJWZmFXUmRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qUXpOUW9nSUNBZ0x5OGdjbUZwYzJWa1gySjVQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzBNemNLSUNBZ0lDOHZJSFJwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5ETXpMVFF6T0FvZ0lDQWdMeThnUkdsemNIVjBaVkpoYVhObFpDZ0tJQ0FnSUM4dklDQWdJQ0JrWlhacFkyVmZhV1E5WkdWMmFXTmxYMmxrTEFvZ0lDQWdMeThnSUNBZ0lISmhhWE5sWkY5aWVUMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdaR2x6Y0hWMFpWOTBlWEJsUFdScGMzQjFkR1ZmZEhsd1pTd0tJQ0FnSUM4dklDQWdJQ0IwYVcxbGMzUmhiWEE5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBek1nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPalF6TWkwME16a0tJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ0tJQ0FnSUM4dklDQWdJQ0JFYVhOd2RYUmxVbUZwYzJWa0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCa1pYWnBZMlZmYVdROVpHVjJhV05sWDJsa0xBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCeVlXbHpaV1JmWW5rOVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JrYVhOd2RYUmxYM1I1Y0dVOVpHbHpjSFYwWlY5MGVYQmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQjBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURRME1qSTRPV0UwSUM4dklHMWxkR2h2WkNBaVJHbHpjSFYwWlZKaGFYTmxaQ2h6ZEhKcGJtY3NZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZOREV5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMGNtRmpaV3h2YjNBdVZISmhZMlZNYjI5d1RHVmtaMlZ5TG5KbGMyOXNkbVZmWkdsemNIVjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGMyOXNkbVZmWkdsemNIVjBaVG9LSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME5ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TkRVd0NpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaWIyNXNlU0JoWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZibXg1SUdGa2JXbHVDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TkRVeENpQWdJQ0F2THlCaGMzTmxjblFnWkdWMmFXTmxYMmxrSUdsdUlITmxiR1l1WkdWMmFXTmxjeXdnSW1SbGRtbGpaU0J1YjNRZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJORFkxTnpZMk9UWXpOalUxWmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCa1pYWnBZMlVnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG8wTlRNS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXVaR1YyYVdObGMxdGtaWFpwWTJWZmFXUmRMbU52Y0hrb0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME5UTXRORFUwQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtUmxkbWxqWlhOYlpHVjJhV05sWDJsa1hTNWpiM0I1S0NrS0lDQWdJQzh2SUdGemMyVnlkQ0J5WldOdmNtUXVjM1JoZEdVdWJtRjBhWFpsSUQwOUlGTlVRVlJGWDBSSlUxQlZWRVZFTENBaVpHVjJhV05sSUc1dmRDQmthWE53ZFhSbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG8wTlRRS0lDQWdJQzh2SUdGemMyVnlkQ0J5WldOdmNtUXVjM1JoZEdVdWJtRjBhWFpsSUQwOUlGTlVRVlJGWDBSSlUxQlZWRVZFTENBaVpHVjJhV05sSUc1dmRDQmthWE53ZFhSbFpDSUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmtaWFpwWTJVZ2JtOTBJR1JwYzNCMWRHVmtDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TkRVMkNpQWdJQ0F2THlCMFlYSm5aWFFnUFNCeVpYTnZiSFpsWkY5emRHRjBaUzV1WVhScGRtVUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pRMU9Bb2dJQ0FnTHk4Z2RHRnlaMlYwSUQwOUlGTlVRVlJGWDFKRlIwbFRWRVZTUlVRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pRMU9DMDBOakFLSUNBZ0lDOHZJSFJoY21kbGRDQTlQU0JUVkVGVVJWOVNSVWRKVTFSRlVrVkVDaUFnSUNBdkx5QnZjaUIwWVhKblpYUWdQVDBnVTFSQlZFVmZWa1ZTU1VaSlJVUUtJQ0FnSUM4dklHOXlJSFJoY21kbGRDQTlQU0JUVkVGVVJWOVVVa0ZPVTBaRlVsSkZSQW9nSUNBZ1ltNTZJSEpsYzI5c2RtVmZaR2x6Y0hWMFpWOWliMjlzWDNSeWRXVkFOQW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pRMU9Rb2dJQ0FnTHk4Z2IzSWdkR0Z5WjJWMElEMDlJRk5VUVZSRlgxWkZVa2xHU1VWRUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5EVTRMVFEyTUFvZ0lDQWdMeThnZEdGeVoyVjBJRDA5SUZOVVFWUkZYMUpGUjBsVFZFVlNSVVFLSUNBZ0lDOHZJRzl5SUhSaGNtZGxkQ0E5UFNCVFZFRlVSVjlXUlZKSlJrbEZSQW9nSUNBZ0x5OGdiM0lnZEdGeVoyVjBJRDA5SUZOVVFWUkZYMVJTUVU1VFJrVlNVa1ZFQ2lBZ0lDQmlibm9nY21WemIyeDJaVjlrYVhOd2RYUmxYMkp2YjJ4ZmRISjFaVUEwQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5EWXdDaUFnSUNBdkx5QnZjaUIwWVhKblpYUWdQVDBnVTFSQlZFVmZWRkpCVGxOR1JWSlNSVVFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZORFU0TFRRMk1Bb2dJQ0FnTHk4Z2RHRnlaMlYwSUQwOUlGTlVRVlJGWDFKRlIwbFRWRVZTUlVRS0lDQWdJQzh2SUc5eUlIUmhjbWRsZENBOVBTQlRWRUZVUlY5V1JWSkpSa2xGUkFvZ0lDQWdMeThnYjNJZ2RHRnlaMlYwSUQwOUlGTlVRVlJGWDFSU1FVNVRSa1ZTVWtWRUNpQWdJQ0JpZWlCeVpYTnZiSFpsWDJScGMzQjFkR1ZmWW05dmJGOW1ZV3h6WlVBMUNncHlaWE52YkhabFgyUnBjM0IxZEdWZlltOXZiRjkwY25WbFFEUTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0tjbVZ6YjJ4MlpWOWthWE53ZFhSbFgySnZiMnhmYldWeVoyVkFOam9LSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME5UY3RORFl4Q2lBZ0lDQXZMeUJoYzNObGNuUWdLQW9nSUNBZ0x5OGdJQ0FnSUhSaGNtZGxkQ0E5UFNCVFZFRlVSVjlTUlVkSlUxUkZVa1ZFQ2lBZ0lDQXZMeUFnSUNBZ2IzSWdkR0Z5WjJWMElEMDlJRk5VUVZSRlgxWkZVa2xHU1VWRUNpQWdJQ0F2THlBZ0lDQWdiM0lnZEdGeVoyVjBJRDA5SUZOVVFWUkZYMVJTUVU1VFJrVlNVa1ZFQ2lBZ0lDQXZMeUFwTENBaWJYVnpkQ0J5WlhOdmJIWmxJR2x1ZEc4Z1VrVkhTVk5VUlZKRlJDd2dWa1ZTU1VaSlJVUXNJRzl5SUZSU1FVNVRSa1ZTVWtWRUlnb2dJQ0FnWVhOelpYSjBJQzh2SUcxMWMzUWdjbVZ6YjJ4MlpTQnBiblJ2SUZKRlIwbFRWRVZTUlVRc0lGWkZVa2xHU1VWRUxDQnZjaUJVVWtGT1UwWkZVbEpGUkFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qUTJNd29nSUNBZ0x5OGdjbVZqYjNKa0xuTjBZWFJsSUQwZ1lYSmpOQzVWU1c1ME5qUW9kR0Z5WjJWMEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME5qUXRORFkyQ2lBZ0lDQXZMeUFqSUVGc2QyRjVjeUJtYjNKalpTQnlaUzEyWlhKcFptbGpZWFJwYjI0Z1lXWjBaWElnWVNCa2FYTndkWFJsSUhKbGMyOXNkWFJwYjI0c0NpQWdJQ0F2THlBaklISmxaMkZ5Wkd4bGMzTWdiMllnZDJocFkyZ2djM1JoZEdVZ2FYUWdjbVZ6YjJ4MlpYTWdhVzUwYnk0S0lDQWdJQzh2SUhKbFkyOXlaQzV6ZEdGdGNGOTJZV3hwWkNBOUlHRnlZelF1UW05dmJDaEdZV3h6WlNrZ0lDTWdibTl4WVRvZ1JrSlVNREF6Q2lBZ0lDQndkWE5vYVc1MElEazJDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TkRZM0NpQWdJQ0F2THlCeVpXTnZjbVF1ZFhCa1lYUmxaRjloZENBOUlHRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tRb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTkRVS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzBOamdLSUNBZ0lDOHZJSE5sYkdZdVpHVjJhV05sYzF0a1pYWnBZMlZmYVdSZElEMGdjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qUTNOQW9nSUNBZ0x5OGdkR2x0WlhOMFlXMXdQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME56RXRORGMxQ2lBZ0lDQXZMeUJFYVhOd2RYUmxVbVZ6YjJ4MlpXUW9DaUFnSUNBdkx5QWdJQ0FnWkdWMmFXTmxYMmxrUFdSbGRtbGpaVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQnlaWE52YkhabFpGOXpkR0YwWlQxeVpYTnZiSFpsWkY5emRHRjBaU3dLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxjM1JoYlhBOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5EY3dMVFEzTmdvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0FvZ0lDQWdMeThnSUNBZ0lFUnBjM0IxZEdWU1pYTnZiSFpsWkNnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWkdWMmFXTmxYMmxrUFdSbGRtbGpaVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnY21WemIyeDJaV1JmYzNSaGRHVTljbVZ6YjJ4MlpXUmZjM1JoZEdVc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUhScGJXVnpkR0Z0Y0QxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lDQWdLUW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZVEl4T1RGbE4yRWdMeThnYldWMGFHOWtJQ0pFYVhOd2RYUmxVbVZ6YjJ4MlpXUW9jM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzBOREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVZ6YjJ4MlpWOWthWE53ZFhSbFgySnZiMnhmWm1Gc2MyVkFOVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlISmxjMjlzZG1WZlpHbHpjSFYwWlY5aWIyOXNYMjFsY21kbFFEWUtDZ292THlCMGNtRmpaV3h2YjNBdVZISmhZMlZNYjI5d1RHVmtaMlZ5TG0xaGNtdGZjbVZqZVdOc1pXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0WVhKclgzSmxZM2xqYkdWa09nb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPalE0TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNalE1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcElHbHVJSE5sYkdZdWNtVmplV05zWlhKekxDQWlibTkwSUdGdUlHRjFkR2h2Y21sNlpXUWdjbVZqZVdOc1pYSWlDaUFnSUNCaWVYUmxZeUExSUM4dklEQjROekkyTlRZek56azJNelpqTmpVM01qVm1DaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCaGJpQmhkWFJvYjNKcGVtVmtJSEpsWTNsamJHVnlDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TkRnNUNpQWdJQ0F2THlCaGMzTmxjblFnWkdWMmFXTmxYMmxrSUdsdUlITmxiR1l1WkdWMmFXTmxjeXdnSW1SbGRtbGpaU0J1YjNRZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJORFkxTnpZMk9UWXpOalUxWmdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmtaWFpwWTJVZ2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME9URUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WkdWMmFXTmxjMXRrWlhacFkyVmZhV1JkTG1OdmNIa29LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME9UTUtJQ0FnSUM4dklISmxZMjl5WkM1emRHRjBaUzV1WVhScGRtVWdQVDBnVTFSQlZFVmZWRkpCVGxOR1JWSlNSVVFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E5UFFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qUTVNaTAwT1RRS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpiM0prTG5OMFlYUmxMbTVoZEdsMlpTQTlQU0JUVkVGVVJWOVVVa0ZPVTBaRlVsSkZSQW9nSUNBZ0x5OGdLU3dnSW1SbGRtbGpaU0J0ZFhOMElHSmxJR1p5WlhOb2JIa2dWRkpCVGxOR1JWSlNSVVFnZEc4Z1lTQnlaV041WTJ4bGNpQjBieUJpWlNCeVpXTjVZMnhsWkNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJrWlhacFkyVWdiWFZ6ZENCaVpTQm1jbVZ6YUd4NUlGUlNRVTVUUmtWU1VrVkVJSFJ2SUdFZ2NtVmplV05zWlhJZ2RHOGdZbVVnY21WamVXTnNaV1FLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME9UWUtJQ0FnSUM4dklISmxZMjl5WkM1emRHRjBaU0E5SUdGeVl6UXVWVWx1ZERZMEtGTlVRVlJGWDFKRlExbERURVZFS1FvZ0lDQWdjSFZ6YUdsdWRDQTFDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvME9UY0tJQ0FnSUM4dklISmxZMjl5WkM1MWNHUmhkR1ZrWDJGMElEMGdZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBME5Rb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPalE1T0FvZ0lDQWdMeThnYzJWc1ppNWtaWFpwWTJWelcyUmxkbWxqWlY5cFpGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5UQXpDaUFnSUNBdkx5QnlaV041WTJ4bGNqMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5UQTBDaUFnSUNBdkx5QjBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pVd01TMDFNRFVLSUNBZ0lDOHZJRVJsZG1salpWSmxZM2xqYkdWa0tBb2dJQ0FnTHk4Z0lDQWdJR1JsZG1salpWOXBaRDFrWlhacFkyVmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmplV05zWlhJOVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNBZ0lIUnBiV1Z6ZEdGdGNEMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREpoQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzFNREF0TlRBMkNpQWdJQ0F2THlCaGNtTTBMbVZ0YVhRb0NpQWdJQ0F2THlBZ0lDQWdSR1YyYVdObFVtVmplV05zWldRb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdSbGRtbGpaVjlwWkQxa1pYWnBZMlZmYVdRc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUhKbFkzbGpiR1Z5UFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdkR2x0WlhOMFlXMXdQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNBcENpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMk5tUTFObU5pTkNBdkx5QnRaWFJvYjJRZ0lrUmxkbWxqWlZKbFkzbGpiR1ZrS0hOMGNtbHVaeXhoWkdSeVpYTnpMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pRNE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkSEpoWTJWc2IyOXdMbFJ5WVdObFRHOXZjRXhsWkdkbGNpNXRZWEpyWDJWNGNHOXlkR1ZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JXRnlhMTlsZUhCdmNuUmxaRG9LSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvMU1USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pVeE5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0ltOXViSGtnWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiMjVzZVNCaFpHMXBiZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pVeE5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdSbGRtbGpaVjlwWkNCcGJpQnpaV3htTG1SbGRtbGpaWE1zSUNKa1pYWnBZMlVnYm05MElISmxaMmx6ZEdWeVpXUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROalEyTlRjMk5qazJNelkxTldZS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdaR1YyYVdObElHNXZkQ0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5URTNDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1SbGRtbGpaWE5iWkdWMmFXTmxYMmxrWFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5URTNMVFV4T0FvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWtaWFpwWTJWelcyUmxkbWxqWlY5cFpGMHVZMjl3ZVNncENpQWdJQ0F2THlCelpXeG1MbDloYzNObGNuUmZibTkwWDNSbGNtMXBibUZzS0hKbFkyOXlaQzV6ZEdGMFpTNXVZWFJwZG1VcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzFNVGdLSUNBZ0lDOHZJSE5sYkdZdVgyRnpjMlZ5ZEY5dWIzUmZkR1Z5YldsdVlXd29jbVZqYjNKa0xuTjBZWFJsTG01aGRHbDJaU2tLSUNBZ0lHSjBiMmtLSUNBZ0lHTmhiR3h6ZFdJZ1gyRnpjMlZ5ZEY5dWIzUmZkR1Z5YldsdVlXd0tJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG8xTWpBS0lDQWdJQzh2SUhKbFkyOXlaQzV6ZEdGMFpTQTlJR0Z5WXpRdVZVbHVkRFkwS0ZOVVFWUkZYMFZZVUU5U1ZFVkVLUW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG8xTWpFS0lDQWdJQzh2SUhKbFkyOXlaQzUxY0dSaGRHVmtYMkYwSUQwZ1lYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcENpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUEwTlFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qVXlNZ29nSUNBZ0x5OGdjMlZzWmk1a1pYWnBZMlZ6VzJSbGRtbGpaVjlwWkYwZ1BTQnlaV052Y21RdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TlRJM0NpQWdJQ0F2THlCMGFXMWxjM1JoYlhBOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPalV5TlMwMU1qZ0tJQ0FnSUM4dklFUmxkbWxqWlVWNGNHOXlkR1ZrS0FvZ0lDQWdMeThnSUNBZ0lHUmxkbWxqWlY5cFpEMWtaWFpwWTJWZmFXUXNDaUFnSUNBdkx5QWdJQ0FnZEdsdFpYTjBZVzF3UFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3S1N3S0lDQWdJQzh2SUNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01HRUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5USTBMVFV5T1FvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0FvZ0lDQWdMeThnSUNBZ0lFUmxkbWxqWlVWNGNHOXlkR1ZrS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JrWlhacFkyVmZhV1E5WkdWMmFXTmxYMmxrTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0IwYVcxbGMzUmhiWEE5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnSUNBZ0lDa0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZzJZVEU1WmpRMklDOHZJRzFsZEdodlpDQWlSR1YyYVdObFJYaHdiM0owWldRb2MzUnlhVzVuTEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qVXhNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEhKaFkyVnNiMjl3TGxSeVlXTmxURzl2Y0V4bFpHZGxjaTVuWlhSZlpHVjJhV05sWDNOMFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyUmxkbWxqWlY5emRHRjBaVG9LSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvMU16WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPalV6T0FvZ0lDQWdMeThnWVhOelpYSjBJR1JsZG1salpWOXBaQ0JwYmlCelpXeG1MbVJsZG1salpYTXNJQ0prWlhacFkyVWdibTkwSUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qUTJOVGMyTmprMk16WTFOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCa1pYWnBZMlVnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG8xTXprS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtUmxkbWxqWlhOYlpHVjJhV05sWDJsa1hTNWpiM0I1S0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPalV6TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEhKaFkyVnNiMjl3TGxSeVlXTmxURzl2Y0V4bFpHZGxjaTVqWVc1ZmRtVnlhV1o1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyRnVYM1psY21sbWVUb0tJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPalUwTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5UUXpDaUFnSUNBdkx5QnBaaUJrWlhacFkyVmZhV1FnYm05MElHbHVJSE5sYkdZdVpHVjJhV05sY3pvS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk5EWTFOelkyT1RZek5qVTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHTmhibDkyWlhKcFpubGZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZOVFEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLRVpoYkhObEtTQWdJeUJ1YjNGaE9pQkdRbFF3TURNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Bb0tZMkZ1WDNabGNtbG1lVjloWm5SbGNsOXBibXhwYm1Wa1gzUnlZV05sYkc5dmNDNVVjbUZqWlV4dmIzQk1aV1JuWlhJdVkyRnVYM1psY21sbWVVQXhNRG9LSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvMU5ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWTJGdVgzWmxjbWxtZVY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5UUTFMVFUwTmdvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWtaWFpwWTJWelcyUmxkbWxqWlY5cFpGMHVZMjl3ZVNncENpQWdJQ0F2THlCemRHRjBaU0E5SUhKbFkyOXlaQzV6ZEdGMFpTNXVZWFJwZG1VS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qVTBOZ29nSUNBZ0x5OGdjM1JoZEdVZ1BTQnlaV052Y21RdWMzUmhkR1V1Ym1GMGFYWmxDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNd29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pVME9Bb2dJQ0FnTHk4Z2MzUmhkR1VnUFQwZ1UxUkJWRVZmVWtWSFNWTlVSVkpGUkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TlRRNExUVTFNQW9nSUNBZ0x5OGdjM1JoZEdVZ1BUMGdVMVJCVkVWZlVrVkhTVk5VUlZKRlJBb2dJQ0FnTHk4Z2IzSWdjM1JoZEdVZ1BUMGdVMVJCVkVWZlZGSkJUbE5HUlZKU1JVUUtJQ0FnSUM4dklHOXlJQ2h6ZEdGMFpTQTlQU0JUVkVGVVJWOVdSVkpKUmtsRlJDQmhibVFnYm05MElISmxZMjl5WkM1emRHRnRjRjkyWVd4cFpDNXVZWFJwZG1VcENpQWdJQ0JpYm5vZ1kyRnVYM1psY21sbWVWOWliMjlzWDNSeWRXVkFOd29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pVME9Rb2dJQ0FnTHk4Z2IzSWdjM1JoZEdVZ1BUMGdVMVJCVkVWZlZGSkJUbE5HUlZKU1JVUUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5UUTRMVFUxTUFvZ0lDQWdMeThnYzNSaGRHVWdQVDBnVTFSQlZFVmZVa1ZIU1ZOVVJWSkZSQW9nSUNBZ0x5OGdiM0lnYzNSaGRHVWdQVDBnVTFSQlZFVmZWRkpCVGxOR1JWSlNSVVFLSUNBZ0lDOHZJRzl5SUNoemRHRjBaU0E5UFNCVFZFRlVSVjlXUlZKSlJrbEZSQ0JoYm1RZ2JtOTBJSEpsWTI5eVpDNXpkR0Z0Y0Y5MllXeHBaQzV1WVhScGRtVXBDaUFnSUNCaWJub2dZMkZ1WDNabGNtbG1lVjlpYjI5c1gzUnlkV1ZBTndvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qVTFNQW9nSUNBZ0x5OGdiM0lnS0hOMFlYUmxJRDA5SUZOVVFWUkZYMVpGVWtsR1NVVkVJR0Z1WkNCdWIzUWdjbVZqYjNKa0xuTjBZVzF3WDNaaGJHbGtMbTVoZEdsMlpTa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0o2SUdOaGJsOTJaWEpwWm5sZlltOXZiRjltWVd4elpVQTRDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0p1ZWlCallXNWZkbVZ5YVdaNVgySnZiMnhmWm1Gc2MyVkFPQW9LWTJGdVgzWmxjbWxtZVY5aWIyOXNYM1J5ZFdWQU56b0tJQ0FnSUdsdWRHTmZNU0F2THlBeENncGpZVzVmZG1WeWFXWjVYMkp2YjJ4ZmJXVnlaMlZBT1RvS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzFOVElLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29iMnNwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pVME1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaUlHTmhibDkyWlhKcFpubGZZV1owWlhKZmFXNXNhVzVsWkY5MGNtRmpaV3h2YjNBdVZISmhZMlZNYjI5d1RHVmtaMlZ5TG1OaGJsOTJaWEpwWm5sQU1UQUtDbU5oYmw5MlpYSnBabmxmWW05dmJGOW1ZV3h6WlVBNE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWTJGdVgzWmxjbWxtZVY5aWIyOXNYMjFsY21kbFFEa0tDZ292THlCMGNtRmpaV3h2YjNBdVZISmhZMlZNYjI5d1RHVmtaMlZ5TG1OaGJsOTBjbUZ1YzJabGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oYmw5MGNtRnVjMlpsY2pvS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzFOVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pVMU5nb2dJQ0FnTHk4Z2FXWWdaR1YyYVdObFgybGtJRzV2ZENCcGJpQnpaV3htTG1SbGRtbGpaWE02Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpRMk5UYzJOamsyTXpZMU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCallXNWZkSEpoYm5ObVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZOVFUzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLRVpoYkhObEtTQWdJeUJ1YjNGaE9pQkdRbFF3TURNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Bb0tZMkZ1WDNSeVlXNXpabVZ5WDJGbWRHVnlYMmx1YkdsdVpXUmZkSEpoWTJWc2IyOXdMbFJ5WVdObFRHOXZjRXhsWkdkbGNpNWpZVzVmZEhKaGJuTm1aWEpBT0RvS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzFOVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1kyRnVYM1J5WVc1elptVnlYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG8xTmpBS0lDQWdJQzh2SUhKbFkyOXlaQzV6ZEdGMFpTNXVZWFJwZG1VZ1BUMGdVMVJCVkVWZlZrVlNTVVpKUlVRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lEMDlDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TlRZd0xUVTJNUW9nSUNBZ0x5OGdjbVZqYjNKa0xuTjBZWFJsTG01aGRHbDJaU0E5UFNCVFZFRlVSVjlXUlZKSlJrbEZSQW9nSUNBZ0x5OGdZVzVrSUhKbFkyOXlaQzV6ZEdGdGNGOTJZV3hwWkM1dVlYUnBkbVVLSUNBZ0lHSjZJR05oYmw5MGNtRnVjMlpsY2w5aWIyOXNYMlpoYkhObFFEWUtJQ0FnSUM4dklIUnlZV05sYkc5dmNDNXdlVG8xTmpFS0lDQWdJQzh2SUdGdVpDQnlaV052Y21RdWMzUmhiWEJmZG1Gc2FXUXVibUYwYVhabENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lDOHZJSFJ5WVdObGJHOXZjQzV3ZVRvMU5qQXROVFl4Q2lBZ0lDQXZMeUJ5WldOdmNtUXVjM1JoZEdVdWJtRjBhWFpsSUQwOUlGTlVRVlJGWDFaRlVrbEdTVVZFQ2lBZ0lDQXZMeUJoYm1RZ2NtVmpiM0prTG5OMFlXMXdYM1poYkdsa0xtNWhkR2wyWlFvZ0lDQWdZbm9nWTJGdVgzUnlZVzV6Wm1WeVgySnZiMnhmWm1Gc2MyVkFOZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbU5oYmw5MGNtRnVjMlpsY2w5aWIyOXNYMjFsY21kbFFEYzZDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TlRZekNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0c5cktRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzFOVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJqWVc1ZmRISmhibk5tWlhKZllXWjBaWEpmYVc1c2FXNWxaRjkwY21GalpXeHZiM0F1VkhKaFkyVk1iMjl3VEdWa1oyVnlMbU5oYmw5MGNtRnVjMlpsY2tBNENncGpZVzVmZEhKaGJuTm1aWEpmWW05dmJGOW1ZV3h6WlVBMk9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWTJGdVgzUnlZVzV6Wm1WeVgySnZiMnhmYldWeVoyVkFOd29LQ2k4dklIUnlZV05sYkc5dmNDNVVjbUZqWlV4dmIzQk1aV1JuWlhJdVkyRnVYM0psWTNsamJHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqWVc1ZmNtVmplV05zWlRvS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzFOalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pVMk53b2dJQ0FnTHk4Z2FXWWdaR1YyYVdObFgybGtJRzV2ZENCcGJpQnpaV3htTG1SbGRtbGpaWE02Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpRMk5UYzJOamsyTXpZMU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCallXNWZjbVZqZVdOc1pWOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qVTJPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaEdZV3h6WlNrZ0lDTWdibTl4WVRvZ1JrSlVNREF6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0NtTmhibDl5WldONVkyeGxYMkZtZEdWeVgybHViR2x1WldSZmRISmhZMlZzYjI5d0xsUnlZV05sVEc5dmNFeGxaR2RsY2k1allXNWZjbVZqZVdOc1pVQTBPZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pVMk5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BqWVc1ZmNtVmplV05zWlY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUIwY21GalpXeHZiM0F1Y0hrNk5UWTVMVFUzTUFvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWtaWFpwWTJWelcyUmxkbWxqWlY5cFpGMHVZMjl3ZVNncENpQWdJQ0F2THlCdmF5QTlJSEpsWTI5eVpDNXpkR0YwWlM1dVlYUnBkbVVnUFQwZ1UxUkJWRVZmVkZKQlRsTkdSVkpTUlVRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUbzFOekFLSUNBZ0lDOHZJRzlySUQwZ2NtVmpiM0prTG5OMFlYUmxMbTVoZEdsMlpTQTlQU0JUVkVGVVJWOVVVa0ZPVTBaRlVsSkZSQW9nSUNBZ1luUnZhUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E5UFFvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qVTNNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaHZheWtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QjBjbUZqWld4dmIzQXVjSGs2TlRZMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdJZ1kyRnVYM0psWTNsamJHVmZZV1owWlhKZmFXNXNhVzVsWkY5MGNtRmpaV3h2YjNBdVZISmhZMlZNYjI5d1RHVmtaMlZ5TG1OaGJsOXlaV041WTJ4bFFEUUtDZ292THlCMGNtRmpaV3h2YjNBdVZISmhZMlZNYjI5d1RHVmtaMlZ5TGw5aGMzTmxjblJmYjNCbGNtRjBiM0lvS1NBdFBpQjJiMmxrT2dwZllYTnpaWEowWDI5d1pYSmhkRzl5T2dvZ0lDQWdMeThnZEhKaFkyVnNiMjl3TG5CNU9qSTBNd29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXZjR1Z5WVhSdmNpNTJZV3gxWlM1dVlYUnBkbVVzSUNKdmJteDVJRzl3WlhKaGRHOXlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEWm1OekEyTlRjeU5qRTNORFptTnpJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOXdaWEpoZEc5eUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZibXg1SUc5d1pYSmhkRzl5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwY21GalpXeHZiM0F1VkhKaFkyVk1iMjl3VEdWa1oyVnlMbDloYzNObGNuUmZkbVZ5YVdacFpYSW9LU0F0UGlCMmIybGtPZ3BmWVhOelpYSjBYM1psY21sbWFXVnlPZ29nSUNBZ0x5OGdkSEpoWTJWc2IyOXdMbkI1T2pJME5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0JwYmlCelpXeG1MblpsY21sbWFXVnljeXdnSW01dmRDQmhiaUJoZFhSb2IzSnBlbVZrSUhabGNtbG1hV1Z5SWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURjMk5qVTNNalk1TmpZMk9UWTFOekkxWmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdZVzRnWVhWMGFHOXlhWHBsWkNCMlpYSnBabWxsY2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEhKaFkyVnNiMjl3TGxSeVlXTmxURzl2Y0V4bFpHZGxjaTVmWVhOelpYSjBYMjV2ZEY5MFpYSnRhVzVoYkNoemRHRjBaVG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BmWVhOelpYSjBYMjV2ZEY5MFpYSnRhVzVoYkRvS0lDQWdJQzh2SUhSeVlXTmxiRzl2Y0M1d2VUb3lOVEVLSUNBZ0lDOHZJR1JsWmlCZllYTnpaWEowWDI1dmRGOTBaWEp0YVc1aGJDaHpaV3htTENCemRHRjBaVG9nVlVsdWREWTBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCMGNtRmpaV3h2YjNBdWNIazZNalV5Q2lBZ0lDQXZMeUJoYzNObGNuUWdjM1JoZEdVZ0lUMGdVMVJCVkVWZlVrVkRXVU5NUlVRc0lDSmtaWFpwWTJVZ2FYTWdjbVZqZVdOc1pXUWc0b0NVSUhSbGNtMXBibUZzSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElEVUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnWkdWMmFXTmxJR2x6SUhKbFkzbGpiR1ZrSU9LQWxDQjBaWEp0YVc1aGJBb2dJQ0FnTHk4Z2RISmhZMlZzYjI5d0xuQjVPakkxTXdvZ0lDQWdMeThnWVhOelpYSjBJSE4wWVhSbElDRTlJRk5VUVZSRlgwVllVRTlTVkVWRUxDQWlaR1YyYVdObElHbHpJR1Y0Y0c5eWRHVmtJT0tBbENCMFpYSnRhVzVoYkNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUdSbGRtbGpaU0JwY3lCbGVIQnZjblJsWkNEaWdKUWdkR1Z5YldsdVlXd0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lJQjJSbGRtbGpaVjhCQUFsMlpYSnBabWxsY2w4RUZSOThkUWh2Y0dWeVlYUnZjZ2x5WldONVkyeGxjbDhDQUF3Q0FDd3hHMEVBaGpFWkZFUXhHRVNDRVFSOUQydUtCRW5xZlVVRUNtUVVKd1JnSk9DZUJEL0Zub1lFbXJLY1F3U3kyYWhnQkQ2emdDTUV6bXpWUVFUZVV0QWFCTHl0MEt3RXduR0d1UVJpSmdFVUJQM3ZwdGdFZVcvdzV3UTUrait5QkZJZThEWTJHZ0NPRVFBSkFCNEFOZ0JSQUdvQWhnRVFBY01DZUFNUkEzOEVCUVJlQks0RXl3VWxCV3NBTVJrVU1SZ1VFRU0yR2dGSkZZRWdFa1F4QURJSkVrUW5CRXkvSTBNMkdnRkpGWUVnRWtReEFESUpFa1FxVEZDQUFZQy9JME0yR2dGSkZZRWdFa1F4QURJSkVrUXFURkJKdlVVQlJMeElJME0yR2dGSkZZRWdFa1F4QURJSkVrUW5CVXhRZ0FHQXZ5TkROaG9CU1JXQklCSkVNUUF5Q1JKRUp3Vk1VRW05UlFGRXZFZ2pRellhQVVraVdTUUlTd0VWU1U4Q0VrUTJHZ0pKSWxra0NFc0JGVWxQQWhKRU5ob0RTU0paSkFoTEFSVVNSSWdFNHloTEJWQkp2VVVCRkVReUF6SUhGb0UxVHdVSUZsY0dBb0FLQUFBQUFBQUFBQUVBTlV4UUtWQlBBbEJNVUVzRFVFOENVRXNCdkVpL01nY1dnUXhQQXdnV1Z3WUNKd1pNVUV4UVR3SlFURkNBQkV2NDE4Uk1VTEFqUXpZYUFVY0NJbGtrQ0VzQkZVbE9BeEpFTmhvQ1NVNENTU0paSkFoTUZSSkVpQVJ2S0V4UVJ3SzlSUUZFU2I1SVRDSWx1aGRKVGdaSmlBUmdJeEpBQUNGTEJZRURFa0FBR1VzRkpCSkJBR0JMQVlFTUk3b2lVeWtpVHdKVUlsTkFBRTRqUkNRV1hBQkpnUXBaSWt4WVR3SkpUZ0pRZ1dBalZERUFYQTB5QnhaY0xVOENTYnhJVEw4eEFESUhGb0VzVHdRSUp3ZFBBMUJNRmxjR0FsQk1VRThDVUV4UWdBVFU4UkRXVEZDd0kwTWlRdit2TmhvQlNTSlpKQWhMQVJWSlR3SVNSRFlhQWtraVdTUUlTd0VWU1U4Q0VrU0lBN3dvU3dSUVNiMUZBVVJKdmtoTVNTSWx1aGRKaUFPdkpCSkVTWUVNSTdvaVV5a2lUd0pVSWxORWdRTVdUd0pNWEFCSkpWbExBU0pMQWxoTEJWQkxBb0VLV1VzREZVOEVTd0pQQWxKUEFreFFTd0ZQQXdsUEFrOEVDRXdKRmxjR0Fsd0tNZ2NXWEMxTEFieEl2ekVBTWdjV2dTeFBCQWdXVndZQ0p3ZE1VRThDVUV4UVR3SlFURkNBQk5sUWFMbE1VTEFqUXpZYUFVY0NJbGtrQ0VzQkZVbE9BeEpFTmhvQ1NVNENTU0paSkFoTUZSSkVpQUwrS0V4UVJ3SzlSUUZFU2I1SVRDSWx1aGRKVGdaSmlBTDRTWUVFRTBRakVrQUFEMHNGSkJKQUFBaExCWUVERWtFQVFTTkVTWUVLV1NKTVdFOENTVTRDVUlGZ0lsUXlCeFpjTFU4Q1NieElUTDh5QnhhQkRFOERDQlpYQmdJbkJreFFURkJQQWxCTVVJQUV4OVRDNFV4UXNDTkRJa0wvdkRZYUFVa2lXU1FJU3dFVkVrUTJHZ0pKRlNVU1JERUFKd1MrUkJJcU1RQlF2VVVCRVVRb1N3SlFTYjFGQVVSSnZraE1TU0lsdWhlSUFtQ0JCQlpQQWt4Y0FJRmdJbFF5QnhaY0xVc0J2RWkvTVFBeUJ4YUFBZ0F5VHdKUVR3SlFURkJNVUlBRVJDS0pwRXhRc0NORE5ob0JSd0lpV1NRSVN3RVZFa1EyR2dKSlRnSkpGU1VTUkRFQU1na1NSQ2hQQWxCSlRnSkp2VVVCUkVtK1NFNENJaVc2RjRFRUVrUVhTVTRGSXhKQUFBOUxCQ1FTUUFBSVN3U0JBeEpCQURJalJFOENTVTRDWEFDQllDSlVNZ2NXWEMxUEFrbThTRXkvTWdjV2dBSUFFazhDVUV4UVRGQ0FCS0laSG5wTVVMQWpReUpDLzhzMkdnRkpJbGtrQ0VzQkZSSkVKd1V4QUZDOVJRRkVLRXNCVUVtOVJRRkVTYjVJVEVraUpib1hnUU1TUklFRkZrOENURndBTWdjV1hDMUxBYnhJdnpFQU1nY1dnQUlBS2s4Q1VFeFFURkNBQkdiVmJMUk1VTEFqUXpZYUFVa2lXU1FJU3dFVkVrUXhBRElKRWtRb1N3RlFTYjFGQVVSSnZraE1TU0lsdWhlSUFTV0JCaFpQQWt4Y0FESUhGbHd0U3dHOFNMOHlCeGFBQWdBS1RGQk1VSUFFaHFHZlJreFFzQ05ETmhvQlNTSlpKQWhMQVJVU1JDaE1VRW05UlFGRXZrZ3JURkN3STBPQUFEWWFBVWtpV1NRSVN3RVZFa1FvVEZCSnZVVUJRQUFIS1N0TVVMQWpRMGtpSmJvWFNVVURJeEpBQUNCTEFZRURFa0FBR0VzQkpCSkJBQnBKZ1F3anVpSlRLU0pQQWxRaVUwQUFDU01wSWs4Q1ZFTC94Q0pDLy9RMkdnRkpJbGtrQ0VzQkZSSkVLRXhRU2IxRkFVQUFCeWtyVEZDd0kwTkpJaVc2RnlRU1FRQWFTWUVNSTdvaVV5a2lUd0pVSWxOQkFBa2pLU0pQQWxSQy85WWlRdi8wTmhvQlNTSlpKQWhMQVJVU1JDaE1VRW05UlFGQUFBaElLU3RNVUxBalF5SWx1aGVCQXhJcElrOENWRUwvNnpFQUp3UytSQkpFaVNveEFGQzlSUUZFaVlvQkFJdi9nUVVUUkl2L2dRWVRSSWs9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkRldmljZVJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXJfaGFzaCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRGV2aWNlVmVyaWZpZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcmlmaWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29uZmlnX2hhc2giLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkRldmljZVRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRldmljZV9pZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vd25lcl9oYXNoIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcmlmaWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJIYXJkd2FyZUNoYW5nZURlY2xhcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRldmljZV9pZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19jb25maWdfaGFzaCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRGlzcHV0ZVJhaXNlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZpY2VfaWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmFpc2VkX2J5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGlzcHV0ZV90eXBlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJEaXNwdXRlUmVzb2x2ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzb2x2ZWRfc3RhdGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkRldmljZVJlY3ljbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRldmljZV9pZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWN5Y2xlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRGV2aWNlRXhwb3J0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2aWNlX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
