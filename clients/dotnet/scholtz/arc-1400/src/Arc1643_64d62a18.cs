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

namespace Arc56.Generated.scholtz.arc_1400.Arc1643_64d62a18
{


    public class Arc1643Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc1643Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ApprovalStruct : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ApprovalAmount { get; set; }

                public Algorand.Address Owner { get; set; }

                public Algorand.Address Spender { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApprovalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vApprovalAmount.From(ApprovalAmount);
                    ret.AddRange(vApprovalAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSpender.From(Spender);
                    ret.AddRange(vSpender.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ApprovalStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ApprovalStruct();
                    uint count = 0;
                    var vApprovalAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vApprovalAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ApprovalAmount = vApprovalAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is Algorand.Address vSpenderValue) { ret.Spender = vSpenderValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ApprovalStruct);
                }
                public bool Equals(ApprovalStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ApprovalStruct left, ApprovalStruct right)
                {
                    return EqualityComparer<ApprovalStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(ApprovalStruct left, ApprovalStruct right)
                {
                    return !(left == right);
                }

            }

            public class Arc1410HoldingPartitionsPaginatedKey : AVMObjectType
            {
                public Algorand.Address Holder { get; set; }

                public ulong Page { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHolder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vHolder.From(Holder);
                    ret.AddRange(vHolder.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPage.From(Page);
                    ret.AddRange(vPage.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1410HoldingPartitionsPaginatedKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1410HoldingPartitionsPaginatedKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHolder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vHolder.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHolder = vHolder.ToValue();
                    if (valueHolder is Algorand.Address vHolderValue) { ret.Holder = vHolderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPage.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePage = vPage.ToValue();
                    if (valuePage is ulong vPageValue) { ret.Page = vPageValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1410HoldingPartitionsPaginatedKey);
                }
                public bool Equals(Arc1410HoldingPartitionsPaginatedKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1410HoldingPartitionsPaginatedKey left, Arc1410HoldingPartitionsPaginatedKey right)
                {
                    return EqualityComparer<Arc1410HoldingPartitionsPaginatedKey>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1410HoldingPartitionsPaginatedKey left, Arc1410HoldingPartitionsPaginatedKey right)
                {
                    return !(left == right);
                }

            }

            public class Arc1410OperatorKey : AVMObjectType
            {
                public Algorand.Address Holder { get; set; }

                public Algorand.Address Operator { get; set; }

                public Algorand.Address Partition { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHolder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vHolder.From(Holder);
                    ret.AddRange(vHolder.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOperator.From(Operator);
                    ret.AddRange(vOperator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPartition.From(Partition);
                    ret.AddRange(vPartition.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1410OperatorKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1410OperatorKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHolder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vHolder.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHolder = vHolder.ToValue();
                    if (valueHolder is Algorand.Address vHolderValue) { ret.Holder = vHolderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOperator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOperator = vOperator.ToValue();
                    if (valueOperator is Algorand.Address vOperatorValue) { ret.Operator = vOperatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPartition.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePartition = vPartition.ToValue();
                    if (valuePartition is Algorand.Address vPartitionValue) { ret.Partition = vPartitionValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1410OperatorKey);
                }
                public bool Equals(Arc1410OperatorKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1410OperatorKey left, Arc1410OperatorKey right)
                {
                    return EqualityComparer<Arc1410OperatorKey>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1410OperatorKey left, Arc1410OperatorKey right)
                {
                    return !(left == right);
                }

            }

            public class Arc1410OperatorPortionKey : AVMObjectType
            {
                public Algorand.Address Holder { get; set; }

                public Algorand.Address Operator { get; set; }

                public Algorand.Address Partition { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHolder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vHolder.From(Holder);
                    ret.AddRange(vHolder.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOperator.From(Operator);
                    ret.AddRange(vOperator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPartition.From(Partition);
                    ret.AddRange(vPartition.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1410OperatorPortionKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1410OperatorPortionKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHolder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vHolder.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHolder = vHolder.ToValue();
                    if (valueHolder is Algorand.Address vHolderValue) { ret.Holder = vHolderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOperator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOperator = vOperator.ToValue();
                    if (valueOperator is Algorand.Address vOperatorValue) { ret.Operator = vOperatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPartition.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePartition = vPartition.ToValue();
                    if (valuePartition is Algorand.Address vPartitionValue) { ret.Partition = vPartitionValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1410OperatorPortionKey);
                }
                public bool Equals(Arc1410OperatorPortionKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1410OperatorPortionKey left, Arc1410OperatorPortionKey right)
                {
                    return EqualityComparer<Arc1410OperatorPortionKey>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1410OperatorPortionKey left, Arc1410OperatorPortionKey right)
                {
                    return !(left == right);
                }

            }

            public class Arc1410PartitionKey : AVMObjectType
            {
                public Algorand.Address Holder { get; set; }

                public Algorand.Address Partition { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHolder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vHolder.From(Holder);
                    ret.AddRange(vHolder.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPartition.From(Partition);
                    ret.AddRange(vPartition.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1410PartitionKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1410PartitionKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHolder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vHolder.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHolder = vHolder.ToValue();
                    if (valueHolder is Algorand.Address vHolderValue) { ret.Holder = vHolderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPartition.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePartition = vPartition.ToValue();
                    if (valuePartition is Algorand.Address vPartitionValue) { ret.Partition = vPartitionValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1410PartitionKey);
                }
                public bool Equals(Arc1410PartitionKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1410PartitionKey left, Arc1410PartitionKey right)
                {
                    return EqualityComparer<Arc1410PartitionKey>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1410PartitionKey left, Arc1410PartitionKey right)
                {
                    return !(left == right);
                }

            }

            public class Arc1410CanTransferByPartitionReturn : AVMObjectType
            {
                public byte Code { get; set; }

                public string Status { get; set; }

                public Algorand.Address ReceiverPartition { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte");
                    vCode.From(Code);
                    ret.AddRange(vCode.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStatus.From(Status);
                    stringRef[ret.Count] = vStatus.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiverPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReceiverPartition.From(ReceiverPartition);
                    ret.AddRange(vReceiverPartition.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1410CanTransferByPartitionReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Arc1410CanTransferByPartitionReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte");
                    count = vCode.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCode = vCode.ToValue();
                    if (valueCode is byte vCodeValue) { ret.Code = vCodeValue; }
                    var indexStatus = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStatus.Decode(bytes.Skip(indexStatus + prefixOffset).ToArray());
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is string vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiverPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReceiverPartition.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiverPartition = vReceiverPartition.ToValue();
                    if (valueReceiverPartition is Algorand.Address vReceiverPartitionValue) { ret.ReceiverPartition = vReceiverPartitionValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1410CanTransferByPartitionReturn);
                }
                public bool Equals(Arc1410CanTransferByPartitionReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1410CanTransferByPartitionReturn left, Arc1410CanTransferByPartitionReturn right)
                {
                    return EqualityComparer<Arc1410CanTransferByPartitionReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1410CanTransferByPartitionReturn left, Arc1410CanTransferByPartitionReturn right)
                {
                    return !(left == right);
                }

            }

            public class Arc1410PartitionIssue : AVMObjectType
            {
                public Algorand.Address To { get; set; }

                public Algorand.Address Partition { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte[] Data { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTo.From(To);
                    ret.AddRange(vTo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPartition.From(Partition);
                    ret.AddRange(vPartition.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vData.From(Data);
                    ret.AddRange(vData.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1410PartitionIssue Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1410PartitionIssue();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is Algorand.Address vToValue) { ret.To = vToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPartition.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePartition = vPartition.ToValue();
                    if (valuePartition is Algorand.Address vPartitionValue) { ret.Partition = vPartitionValue; }
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vData.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueData = vData.ToValue();
                    if (valueData is byte[] vDataValue) { ret.Data = vDataValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1410PartitionIssue);
                }
                public bool Equals(Arc1410PartitionIssue? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1410PartitionIssue left, Arc1410PartitionIssue right)
                {
                    return EqualityComparer<Arc1410PartitionIssue>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1410PartitionIssue left, Arc1410PartitionIssue right)
                {
                    return !(left == right);
                }

            }

            public class Arc1410PartitionRedeem : AVMObjectType
            {
                public Algorand.Address From { get; set; }

                public Algorand.Address Partition { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte[] Data { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vFrom.From(From);
                    ret.AddRange(vFrom.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPartition.From(Partition);
                    ret.AddRange(vPartition.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vData.From(Data);
                    ret.AddRange(vData.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1410PartitionRedeem Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1410PartitionRedeem();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is Algorand.Address vFromValue) { ret.From = vFromValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPartition.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePartition = vPartition.ToValue();
                    if (valuePartition is Algorand.Address vPartitionValue) { ret.Partition = vPartitionValue; }
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vData.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueData = vData.ToValue();
                    if (valueData is byte[] vDataValue) { ret.Data = vDataValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1410PartitionRedeem);
                }
                public bool Equals(Arc1410PartitionRedeem? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1410PartitionRedeem left, Arc1410PartitionRedeem right)
                {
                    return EqualityComparer<Arc1410PartitionRedeem>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1410PartitionRedeem left, Arc1410PartitionRedeem right)
                {
                    return !(left == right);
                }

            }

            public class Arc1410PartitionTransfer : AVMObjectType
            {
                public Algorand.Address From { get; set; }

                public Algorand.Address To { get; set; }

                public Algorand.Address Partition { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte[] Data { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vFrom.From(From);
                    ret.AddRange(vFrom.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTo.From(To);
                    ret.AddRange(vTo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPartition.From(Partition);
                    ret.AddRange(vPartition.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vData.From(Data);
                    ret.AddRange(vData.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1410PartitionTransfer Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1410PartitionTransfer();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is Algorand.Address vFromValue) { ret.From = vFromValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is Algorand.Address vToValue) { ret.To = vToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartition = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPartition.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePartition = vPartition.ToValue();
                    if (valuePartition is Algorand.Address vPartitionValue) { ret.Partition = vPartitionValue; }
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vData.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueData = vData.ToValue();
                    if (valueData is byte[] vDataValue) { ret.Data = vDataValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1410PartitionTransfer);
                }
                public bool Equals(Arc1410PartitionTransfer? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1410PartitionTransfer left, Arc1410PartitionTransfer right)
                {
                    return EqualityComparer<Arc1410PartitionTransfer>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1410PartitionTransfer left, Arc1410PartitionTransfer right)
                {
                    return !(left == right);
                }

            }

            public class Arc1594IssueEvent : AVMObjectType
            {
                public Algorand.Address To { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte[] Data { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTo.From(To);
                    ret.AddRange(vTo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vData.From(Data);
                    ret.AddRange(vData.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1594IssueEvent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1594IssueEvent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is Algorand.Address vToValue) { ret.To = vToValue; }
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vData.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueData = vData.ToValue();
                    if (valueData is byte[] vDataValue) { ret.Data = vDataValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1594IssueEvent);
                }
                public bool Equals(Arc1594IssueEvent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1594IssueEvent left, Arc1594IssueEvent right)
                {
                    return EqualityComparer<Arc1594IssueEvent>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1594IssueEvent left, Arc1594IssueEvent right)
                {
                    return !(left == right);
                }

            }

            public class Arc1594RedeemEvent : AVMObjectType
            {
                public Algorand.Address From { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte[] Data { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vFrom.From(From);
                    ret.AddRange(vFrom.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vData.From(Data);
                    ret.AddRange(vData.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1594RedeemEvent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1594RedeemEvent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is Algorand.Address vFromValue) { ret.From = vFromValue; }
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vData.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueData = vData.ToValue();
                    if (valueData is byte[] vDataValue) { ret.Data = vDataValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1594RedeemEvent);
                }
                public bool Equals(Arc1594RedeemEvent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1594RedeemEvent left, Arc1594RedeemEvent right)
                {
                    return EqualityComparer<Arc1594RedeemEvent>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1594RedeemEvent left, Arc1594RedeemEvent right)
                {
                    return !(left == right);
                }

            }

            public class Arc1643DocumentRecord : AVMObjectType
            {
                public string Uri { get; set; }

                public byte[] Hash { get; set; }

                public ulong Timestamp { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUri = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUri.From(Uri);
                    stringRef[ret.Count] = vUri.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vHash.From(Hash);
                    ret.AddRange(vHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1643DocumentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Arc1643DocumentRecord();
                    uint count = 0;
                    var indexUri = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUri = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUri.Decode(bytes.Skip(indexUri + prefixOffset).ToArray());
                    var valueUri = vUri.ToValue();
                    if (valueUri is string vUriValue) { ret.Uri = vUriValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHash = vHash.ToValue();
                    if (valueHash is byte[] vHashValue) { ret.Hash = vHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1643DocumentRecord);
                }
                public bool Equals(Arc1643DocumentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1643DocumentRecord left, Arc1643DocumentRecord right)
                {
                    return EqualityComparer<Arc1643DocumentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1643DocumentRecord left, Arc1643DocumentRecord right)
                {
                    return !(left == right);
                }

            }

            public class Arc1643DocumentRemovedEvent : AVMObjectType
            {
                public byte[] Name { get; set; }

                public string Uri { get; set; }

                public byte[] Hash { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vName.From(Name);
                    ret.AddRange(vName.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUri = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUri.From(Uri);
                    stringRef[ret.Count] = vUri.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vHash.From(Hash);
                    ret.AddRange(vHash.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1643DocumentRemovedEvent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Arc1643DocumentRemovedEvent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vName.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueName = vName.ToValue();
                    if (valueName is byte[] vNameValue) { ret.Name = vNameValue; }
                    var indexUri = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUri = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUri.Decode(bytes.Skip(indexUri + prefixOffset).ToArray());
                    var valueUri = vUri.ToValue();
                    if (valueUri is string vUriValue) { ret.Uri = vUriValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHash = vHash.ToValue();
                    if (valueHash is byte[] vHashValue) { ret.Hash = vHashValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1643DocumentRemovedEvent);
                }
                public bool Equals(Arc1643DocumentRemovedEvent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1643DocumentRemovedEvent left, Arc1643DocumentRemovedEvent right)
                {
                    return EqualityComparer<Arc1643DocumentRemovedEvent>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1643DocumentRemovedEvent left, Arc1643DocumentRemovedEvent right)
                {
                    return !(left == right);
                }

            }

            public class Arc1643DocumentUpdatedEvent : AVMObjectType
            {
                public byte[] Name { get; set; }

                public string Uri { get; set; }

                public byte[] Hash { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vName.From(Name);
                    ret.AddRange(vName.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUri = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUri.From(Uri);
                    stringRef[ret.Count] = vUri.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vHash.From(Hash);
                    ret.AddRange(vHash.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1643DocumentUpdatedEvent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Arc1643DocumentUpdatedEvent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vName.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueName = vName.ToValue();
                    if (valueName is byte[] vNameValue) { ret.Name = vNameValue; }
                    var indexUri = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUri = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUri.Decode(bytes.Skip(indexUri + prefixOffset).ToArray());
                    var valueUri = vUri.ToValue();
                    if (valueUri is string vUriValue) { ret.Uri = vUriValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHash = vHash.ToValue();
                    if (valueHash is byte[] vHashValue) { ret.Hash = vHashValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1643DocumentUpdatedEvent);
                }
                public bool Equals(Arc1643DocumentUpdatedEvent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1643DocumentUpdatedEvent left, Arc1643DocumentUpdatedEvent right)
                {
                    return EqualityComparer<Arc1643DocumentUpdatedEvent>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1643DocumentUpdatedEvent left, Arc1643DocumentUpdatedEvent right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class DocumentUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 45, 192, 60, 54 };
                public const string Signature = "DocumentUpdated((byte[],string,byte[]))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1643DocumentUpdatedEvent Field0 { get; set; }

                public static DocumentUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DocumentUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.Arc1643DocumentUpdatedEvent.Parse(eventData.Skip(indexField0).ToArray());
                    return ret;

                }

            }

            public class DocumentRemovedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 174, 122, 79, 160 };
                public const string Signature = "DocumentRemoved((byte[],string,byte[]))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1643DocumentRemovedEvent Field0 { get; set; }

                public static DocumentRemovedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DocumentRemovedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.Arc1643DocumentRemovedEvent.Parse(eventData.Skip(indexField0).ToArray());
                    return ret;

                }

            }

            public class IssueEvent
            {
                public static readonly byte[] Selector = new byte[4] { 250, 68, 59, 27 };
                public const string Signature = "Issue((address,address,uint256,byte[]))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1410PartitionIssue Field0 { get; set; }

                public static IssueEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new IssueEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.Arc1410PartitionIssue.Parse(eventData.Skip(indexField0).ToArray());
                    return ret;

                }

            }

            public class IssueEvent2
            {
                public static readonly byte[] Selector = new byte[4] { 242, 233, 152, 175 };
                public const string Signature = "Issue((address,uint256,byte[]))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1594IssueEvent Field0 { get; set; }

                public static IssueEvent2 Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new IssueEvent2();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.Arc1594IssueEvent.Parse(eventData.Skip(indexField0).ToArray());
                    return ret;

                }

            }

            public class RedeemEvent
            {
                public static readonly byte[] Selector = new byte[4] { 215, 252, 74, 152 };
                public const string Signature = "Redeem((address,uint256,byte[]))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1594RedeemEvent Field0 { get; set; }

                public static RedeemEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RedeemEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.Arc1594RedeemEvent.Parse(eventData.Skip(indexField0).ToArray());
                    return ret;

                }

            }

            public class TransferEvent
            {
                public static readonly byte[] Selector = new byte[4] { 32, 107, 121, 64 };
                public const string Signature = "Transfer((address,address,address,uint256,byte[]))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1410PartitionTransfer Field0 { get; set; }

                public static TransferEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new TransferEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.Arc1410PartitionTransfer.Parse(eventData.Skip(indexField0).ToArray());
                    return ret;

                }

            }

            public class Arc200TransferEvent
            {
                public static readonly byte[] Selector = new byte[4] { 121, 131, 195, 92 };
                public const string Signature = "arc200_Transfer(address,address,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address From { get; set; }
                public Algorand.Address To { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

                public static Arc200TransferEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc200TransferEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is Algorand.Address vFromValue) { ret.From = vFromValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is Algorand.Address vToValue) { ret.To = vToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

            public class Arc200ApprovalEvent
            {
                public static readonly byte[] Selector = new byte[4] { 25, 105, 248, 101 };
                public const string Signature = "arc200_Approval(address,address,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Owner { get; set; }
                public Algorand.Address Spender { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

                public static Arc200ApprovalEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc200ApprovalEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is Algorand.Address vSpenderValue) { ret.Spender = vSpenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

            public class RedeemEvent2
            {
                public static readonly byte[] Selector = new byte[4] { 92, 39, 180, 252 };
                public const string Signature = "Redeem((address,address,uint256,byte[]))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1410PartitionRedeem Field0 { get; set; }

                public static RedeemEvent2 Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RedeemEvent2();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.Arc1410PartitionRedeem.Parse(eventData.Skip(indexField0).ToArray());
                    return ret;

                }

            }

            public class Arc88OwnershipTransferredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 67, 85, 210, 173 };
                public const string Signature = "arc88_OwnershipTransferred(address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address PreviousOwner { get; set; }
                public Algorand.Address NewOwner { get; set; }

                public static Arc88OwnershipTransferredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc88OwnershipTransferredEvent();
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

            public class Arc88OwnershipRenouncedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 52, 106, 161, 102 };
                public const string Signature = "arc88_OwnershipRenounced(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address PreviousOwner { get; set; }

                public static Arc88OwnershipRenouncedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc88OwnershipRenouncedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is Algorand.Address vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    return ret;

                }

            }

            public class Arc88OwnershipTransferRequestedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 22, 191, 31, 145 };
                public const string Signature = "arc88_OwnershipTransferRequested(address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address PreviousOwner { get; set; }
                public Algorand.Address PendingOwner { get; set; }

                public static Arc88OwnershipTransferRequestedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc88OwnershipTransferRequestedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is Algorand.Address vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPendingOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPendingOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePendingOwner = vPendingOwner.ToValue();
                    if (valuePendingOwner is Algorand.Address vPendingOwnerValue) { ret.PendingOwner = vPendingOwnerValue; }
                    return ret;

                }

            }

            public class Arc88OwnershipTransferAcceptedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 247, 227, 107, 55 };
                public const string Signature = "arc88_OwnershipTransferAccepted(address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address PreviousOwner { get; set; }
                public Algorand.Address NewOwner { get; set; }

                public static Arc88OwnershipTransferAcceptedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc88OwnershipTransferAcceptedEvent();
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

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="uri"> </param>
        /// <param name="hash"> </param>
        public async Task Arc1643SetDocument(byte[] name, string uri, byte[] hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 203, 54, 245 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); uriAbi.From(uri);
            var hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashAbi.From(hash);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, uriAbi, hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1643SetDocument_Transactions(byte[] name, string uri, byte[] hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 203, 54, 245 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); uriAbi.From(uri);
            var hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashAbi.From(hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, uriAbi, hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<Structs.Arc1643DocumentRecord> Arc1643GetDocument(byte[] name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 109, 122, 140 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);

            var result = await base.SimApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Arc1643DocumentRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Arc1643GetDocument_Transactions(byte[] name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 109, 122, 140 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task Arc1643RemoveDocument(byte[] name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 203, 52, 130 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1643RemoveDocument_Transactions(byte[] name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 203, 52, 130 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[][]> Arc1643GetAllDocuments(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 182, 54, 200 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> Arc1643GetAllDocuments_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 182, 54, 200 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="flag"> </param>
        public async Task Arc1594SetIssuable(bool flag, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 177, 104, 42 };
            var flagAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); flagAbi.From(flag);

            var result = await base.CallApp(new List<object> { abiHandle, flagAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1594SetIssuable_Transactions(bool flag, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 177, 104, 42 };
            var flagAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); flagAbi.From(flag);

            return await base.MakeTransactionList(new List<object> { abiHandle, flagAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task Arc1594Issue(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 48, 89, 155 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1594Issue_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 48, 89, 155 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task Arc1594RedeemFrom(Algorand.Address from, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 43, 95, 203 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1594RedeemFrom_Transactions(Algorand.Address from, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 43, 95, 203 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task Arc1594Redeem(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 131, 142, 185 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1594Redeem_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 131, 142, 185 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task<bool> Arc1594TransferWithData(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 136, 43, 250 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc1594TransferWithData_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 136, 43, 250 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task<bool> Arc1594TransferFromWithData(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 204, 161, 111 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc1594TransferFromWithData_Transactions(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 204, 161, 111 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Arc1594IsIssuable(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 101, 151, 192 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc1594IsIssuable_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 101, 151, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="holder"> </param>
        /// <param name="partition"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc1410BalanceOfPartition(Algorand.Address holder, Algorand.Address partition, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 248, 19, 95 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            var result = await base.SimApp(new List<object> { abiHandle, holderAbi, partitionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc1410BalanceOfPartition_Transactions(Algorand.Address holder, Algorand.Address partition, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 248, 19, 95 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            return await base.MakeTransactionList(new List<object> { abiHandle, holderAbi, partitionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="value"> </param>
        public async Task<bool> Arc200Transfer(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 112, 37, 185 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200Transfer_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 112, 37, 185 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer an amount of tokens from partition to receiver. Sender must be msg.sender or authorized operator.
        ///</summary>
        /// <param name="partition"> </param>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task<Algorand.Address> Arc1410TransferByPartition(Algorand.Address partition, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 37, 103, 19 };
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, partitionAbi, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Arc1410TransferByPartition_Transactions(Algorand.Address partition, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 37, 103, 19 };
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, partitionAbi, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="holder"> </param>
        /// <param name="page"> </param>
        public async Task<Algorand.Address[]> Arc1410PartitionsOf(Algorand.Address holder, ulong page, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 180, 249, 227 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var pageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pageAbi.From(page);

            var result = await base.CallApp(new List<object> { abiHandle, holderAbi, pageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> Arc1410PartitionsOf_Transactions(Algorand.Address holder, ulong page, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 180, 249, 227 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var pageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pageAbi.From(page);

            return await base.MakeTransactionList(new List<object> { abiHandle, holderAbi, pageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="holder"> </param>
        /// <param name="operator"> </param>
        /// <param name="partition"> </param>
        public async Task<bool> Arc1410IsOperator(Algorand.Address holder, Algorand.Address @operator, Algorand.Address partition, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 204, 73, 171 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            var result = await base.SimApp(new List<object> { abiHandle, holderAbi, operatorAbi, partitionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc1410IsOperator_Transactions(Algorand.Address holder, Algorand.Address @operator, Algorand.Address partition, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 204, 73, 171 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            return await base.MakeTransactionList(new List<object> { abiHandle, holderAbi, operatorAbi, partitionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="holder"> </param>
        /// <param name="operator"> </param>
        /// <param name="partition"> </param>
        public async Task Arc1410AuthorizeOperator(Algorand.Address holder, Algorand.Address @operator, Algorand.Address partition, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 150, 33, 101 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            var result = await base.CallApp(new List<object> { abiHandle, holderAbi, operatorAbi, partitionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1410AuthorizeOperator_Transactions(Algorand.Address holder, Algorand.Address @operator, Algorand.Address partition, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 150, 33, 101 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            return await base.MakeTransactionList(new List<object> { abiHandle, holderAbi, operatorAbi, partitionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="holder"> </param>
        /// <param name="operator"> </param>
        /// <param name="partition"> </param>
        public async Task Arc1410RevokeOperator(Algorand.Address holder, Algorand.Address @operator, Algorand.Address partition, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 137, 97, 218 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            var result = await base.CallApp(new List<object> { abiHandle, holderAbi, operatorAbi, partitionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1410RevokeOperator_Transactions(Algorand.Address holder, Algorand.Address @operator, Algorand.Address partition, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 137, 97, 218 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            return await base.MakeTransactionList(new List<object> { abiHandle, holderAbi, operatorAbi, partitionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="partition"> </param>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task<Algorand.Address> Arc1410OperatorTransferByPartition(Algorand.Address from, Algorand.Address partition, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 148, 128, 215 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, partitionAbi, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Arc1410OperatorTransferByPartition_Transactions(Algorand.Address from, Algorand.Address partition, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 148, 128, 215 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, partitionAbi, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="partition"> </param>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task<Structs.Arc1410CanTransferByPartitionReturn> Arc1410CanTransferByPartition(Algorand.Address from, Algorand.Address partition, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 177, 214, 154 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, partitionAbi, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Arc1410CanTransferByPartitionReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Arc1410CanTransferByPartition_Transactions(Algorand.Address from, Algorand.Address partition, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 177, 214, 154 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, partitionAbi, toAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="holder"> </param>
        /// <param name="operator"> </param>
        /// <param name="partition"> </param>
        /// <param name="amount"> </param>
        public async Task Arc1410AuthorizeOperatorByPortion(Algorand.Address holder, Algorand.Address @operator, Algorand.Address partition, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 190, 215, 137 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            var result = await base.CallApp(new List<object> { abiHandle, holderAbi, operatorAbi, partitionAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1410AuthorizeOperatorByPortion_Transactions(Algorand.Address holder, Algorand.Address @operator, Algorand.Address partition, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 190, 215, 137 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            return await base.MakeTransactionList(new List<object> { abiHandle, holderAbi, operatorAbi, partitionAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="holder"> </param>
        /// <param name="operator"> </param>
        /// <param name="partition"> </param>
        public async Task<bool> Arc1410IsOperatorByPortion(Algorand.Address holder, Algorand.Address @operator, Algorand.Address partition, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 254, 24, 51 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            var result = await base.SimApp(new List<object> { abiHandle, holderAbi, operatorAbi, partitionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc1410IsOperatorByPortion_Transactions(Algorand.Address holder, Algorand.Address @operator, Algorand.Address partition, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 254, 24, 51 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);

            return await base.MakeTransactionList(new List<object> { abiHandle, holderAbi, operatorAbi, partitionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="partition"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task Arc1410IssueByPartition(Algorand.Address to, Algorand.Address partition, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 156, 209, 165 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, partitionAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1410IssueByPartition_Transactions(Algorand.Address to, Algorand.Address partition, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 156, 209, 165 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, partitionAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="partition"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task Arc1410RedeemByPartition(Algorand.Address partition, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 233, 65, 102 };
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, partitionAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1410RedeemByPartition_Transactions(Algorand.Address partition, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 233, 65, 102 };
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, partitionAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="partition"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        public async Task Arc1410OperatorRedeemByPartition(Algorand.Address from, Algorand.Address partition, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 240, 35, 215 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, partitionAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1410OperatorRedeemByPartition_Transactions(Algorand.Address from, Algorand.Address partition, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 240, 35, 215 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var partitionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partitionAbi.From(partition);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, partitionAbi, amount, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="symbol"> </param>
        /// <param name="decimals"> </param>
        /// <param name="totalSupply"> </param>
        public async Task<bool> Bootstrap(byte[] name, byte[] symbol, byte decimals, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalSupply, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 83, 130, 226 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); symbolAbi.From(symbol);
            var decimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); decimalsAbi.From(decimals);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, symbolAbi, decimalsAbi, totalSupply }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(byte[] name, byte[] symbol, byte decimals, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalSupply, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 83, 130, 226 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); symbolAbi.From(symbol);
            var decimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); decimalsAbi.From(decimals);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, symbolAbi, decimalsAbi, totalSupply }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the name of the token
        ///</summary>
        public async Task<byte[]> Arc200Name(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 125, 19, 236 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Arc200Name_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 125, 19, 236 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the symbol of the token
        ///</summary>
        public async Task<byte[]> Arc200Symbol(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 174, 26, 37 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(8, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Arc200Symbol_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 174, 26, 37 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the decimals of the token
        ///</summary>
        public async Task<byte> Arc200Decimals(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 236, 19, 213 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Byte();
            returnValueObj.Decode(lastLogReturnData);
            return ReverseIfLittleEndian(lastLogReturnData)[0];

        }

        public async Task<List<Transaction>> Arc200Decimals_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 236, 19, 213 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the total supply of the token
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc200TotalSupply(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 153, 96, 65 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc200TotalSupply_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 153, 96, 65 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the current balance of the owner of the token
        ///</summary>
        /// <param name="owner">The address of the owner of the token </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc200BalanceOf(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 229, 115, 196 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc200BalanceOf_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 229, 115, 196 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfers tokens from source to destination as approved spender
        ///</summary>
        /// <param name="from">The source of the transfer </param>
        /// <param name="to">The destination of the transfer </param>
        /// <param name="value">Amount of tokens to transfer </param>
        public async Task<bool> Arc200TransferFrom(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 150, 143, 143 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200TransferFrom_Transactions(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 150, 143, 143 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Approve spender for a token
        ///</summary>
        /// <param name="spender">Who is allowed to take tokens on owner's behalf </param>
        /// <param name="value">Amount of tokens to be taken by spender </param>
        public async Task<bool> Arc200Approve(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 66, 33, 37 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200Approve_Transactions(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 66, 33, 37 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the current allowance of the spender of the tokens of the owner
        ///</summary>
        /// <param name="owner">Owner's account </param>
        /// <param name="spender">Who is allowed to take tokens on owner's behalf </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc200Allowance(Algorand.Address owner, Algorand.Address spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 179, 25, 243 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc200Allowance_Transactions(Algorand.Address owner, Algorand.Address spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 179, 25, 243 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Arc88Owner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 2, 101, 78 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Arc88Owner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 2, 101, 78 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="query"> </param>
        public async Task<bool> Arc88IsOwner(Algorand.Address query, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 21, 114, 78 };
            var queryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); queryAbi.From(query);

            var result = await base.SimApp(new List<object> { abiHandle, queryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc88IsOwner_Transactions(Algorand.Address query, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 21, 114, 78 };
            var queryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); queryAbi.From(query);

            return await base.MakeTransactionList(new List<object> { abiHandle, queryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Explicit initialization override (creation group recommended). Fails if already initialized.
        ///</summary>
        /// <param name="new_owner"> </param>
        public async Task Arc88InitializeOwner(Algorand.Address new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 159, 236, 192 };
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_ownerAbi.From(new_owner);

            var result = await base.CallApp(new List<object> { abiHandle, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88InitializeOwner_Transactions(Algorand.Address new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 159, 236, 192 };
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_ownerAbi.From(new_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_owner"> </param>
        public async Task Arc88TransferOwnership(Algorand.Address new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 73, 51, 78 };
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_ownerAbi.From(new_owner);

            var result = await base.CallApp(new List<object> { abiHandle, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88TransferOwnership_Transactions(Algorand.Address new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 73, 51, 78 };
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_ownerAbi.From(new_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc88RenounceOwnership(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 124, 130, 239 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88RenounceOwnership_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 124, 130, 239 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pending"> </param>
        public async Task Arc88TransferOwnershipRequest(Algorand.Address pending, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 44, 44, 110 };
            var pendingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pendingAbi.From(pending);

            var result = await base.CallApp(new List<object> { abiHandle, pendingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88TransferOwnershipRequest_Transactions(Algorand.Address pending, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 44, 44, 110 };
            var pendingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pendingAbi.From(pending);

            return await base.MakeTransactionList(new List<object> { abiHandle, pendingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc88AcceptOwnership(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 165, 240, 101 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88AcceptOwnership_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 165, 240, 101 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc88CancelOwnershipRequest(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 79, 104, 234 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88CancelOwnershipRequest_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 79, 104, 234 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 2;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjMTY0MyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBcHByb3ZhbFN0cnVjdCI6W3sibmFtZSI6ImFwcHJvdmFsQW1vdW50IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic3BlbmRlciIsInR5cGUiOiJhZGRyZXNzIn1dLCJhcmMxNDEwX0hvbGRpbmdQYXJ0aXRpb25zUGFnaW5hdGVkS2V5IjpbeyJuYW1lIjoiaG9sZGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYWdlIiwidHlwZSI6InVpbnQ2NCJ9XSwiYXJjMTQxMF9PcGVyYXRvcktleSI6W3sibmFtZSI6ImhvbGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoib3BlcmF0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhcnRpdGlvbiIsInR5cGUiOiJhZGRyZXNzIn1dLCJhcmMxNDEwX09wZXJhdG9yUG9ydGlvbktleSI6W3sibmFtZSI6ImhvbGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoib3BlcmF0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhcnRpdGlvbiIsInR5cGUiOiJhZGRyZXNzIn1dLCJhcmMxNDEwX1BhcnRpdGlvbktleSI6W3sibmFtZSI6ImhvbGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicGFydGl0aW9uIiwidHlwZSI6ImFkZHJlc3MifV0sImFyYzE0MTBfY2FuX3RyYW5zZmVyX2J5X3BhcnRpdGlvbl9yZXR1cm4iOlt7Im5hbWUiOiJjb2RlIiwidHlwZSI6ImJ5dGUifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicmVjZWl2ZXJQYXJ0aXRpb24iLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiYXJjMTQxMF9wYXJ0aXRpb25faXNzdWUiOlt7Im5hbWUiOiJ0byIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicGFydGl0aW9uIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImRhdGEiLCJ0eXBlIjoiYnl0ZVtdIn1dLCJhcmMxNDEwX3BhcnRpdGlvbl9yZWRlZW0iOlt7Im5hbWUiOiJmcm9tIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYXJ0aXRpb24iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGF0YSIsInR5cGUiOiJieXRlW10ifV0sImFyYzE0MTBfcGFydGl0aW9uX3RyYW5zZmVyIjpbeyJuYW1lIjoiZnJvbSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidG8iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhcnRpdGlvbiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJkYXRhIiwidHlwZSI6ImJ5dGVbXSJ9XSwiYXJjMTU5NF9pc3N1ZV9ldmVudCI6W3sibmFtZSI6InRvIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImRhdGEiLCJ0eXBlIjoiYnl0ZVtdIn1dLCJhcmMxNTk0X3JlZGVlbV9ldmVudCI6W3sibmFtZSI6ImZyb20iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGF0YSIsInR5cGUiOiJieXRlW10ifV0sImFyYzE2NDNfZG9jdW1lbnRfcmVjb3JkIjpbeyJuYW1lIjoidXJpIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6Imhhc2giLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoidGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9XSwiYXJjMTY0M19kb2N1bWVudF9yZW1vdmVkX2V2ZW50IjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJ1cmkiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiaGFzaCIsInR5cGUiOiJieXRlW10ifV0sImFyYzE2NDNfZG9jdW1lbnRfdXBkYXRlZF9ldmVudCI6W3sibmFtZSI6Im5hbWUiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoidXJpIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6Imhhc2giLCJ0eXBlIjoiYnl0ZVtdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImFyYzE2NDNfc2V0X2RvY3VtZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVyaSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRG9jdW1lbnRVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihieXRlW10sc3RyaW5nLGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNjQzX2RvY3VtZW50X3VwZGF0ZWRfZXZlbnQiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE2NDNfZ2V0X2RvY3VtZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxieXRlW10sdWludDY0KSIsInN0cnVjdCI6ImFyYzE2NDNfZG9jdW1lbnRfcmVjb3JkIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNjQzX3JlbW92ZV9kb2N1bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJEb2N1bWVudFJlbW92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGJ5dGVbXSxzdHJpbmcsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE2NDNfZG9jdW1lbnRfcmVtb3ZlZF9ldmVudCIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTY0M19nZXRfYWxsX2RvY3VtZW50cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNTk0X3NldF9pc3N1YWJsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmxhZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNTk0X2lzc3VlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiSXNzdWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl9pc3N1ZSIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJJc3N1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNTk0X2lzc3VlX2V2ZW50IiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNTk0X3JlZGVlbUZyb20iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlZGVlbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNTk0X3JlZGVlbV9ldmVudCIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTU5NF9yZWRlZW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE1OTRfcmVkZWVtX2V2ZW50IiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNTk0X3RyYW5zZmVyX3dpdGhfZGF0YSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl90cmFuc2ZlciIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNTk0X3RyYW5zZmVyX2Zyb21fd2l0aF9kYXRhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzIwMF9BcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjMjAwX1RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTU5NF9pc19pc3N1YWJsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfYmFsYW5jZV9vZl9wYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF90cmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE0MTBfcGFydGl0aW9uX3RyYW5zZmVyIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzIwMF9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfdHJhbnNmZXJfYnlfcGFydGl0aW9uIiwiZGVzYyI6IlRyYW5zZmVyIGFuIGFtb3VudCBvZiB0b2tlbnMgZnJvbSBwYXJ0aXRpb24gdG8gcmVjZWl2ZXIuIFNlbmRlciBtdXN0IGJlIG1zZy5zZW5kZXIgb3IgYXV0aG9yaXplZCBvcGVyYXRvci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlW10pIiwic3RydWN0IjoiYXJjMTQxMF9wYXJ0aXRpb25fdHJhbnNmZXIiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfcGFydGl0aW9uc19vZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9sZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYWdlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTQxMF9pc19vcGVyYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9sZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX2F1dGhvcml6ZV9vcGVyYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9sZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTQxMF9yZXZva2Vfb3BlcmF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfb3BlcmF0b3JfdHJhbnNmZXJfYnlfcGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl90cmFuc2ZlciIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTQxMF9jYW5fdHJhbnNmZXJfYnlfcGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGUsc3RyaW5nLGFkZHJlc3MpIiwic3RydWN0IjoiYXJjMTQxMF9jYW5fdHJhbnNmZXJfYnlfcGFydGl0aW9uX3JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfYXV0aG9yaXplX29wZXJhdG9yX2J5X3BvcnRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfaXNfb3BlcmF0b3JfYnlfcG9ydGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9sZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX2lzc3VlX2J5X3BhcnRpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Iklzc3VlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlW10pIiwic3RydWN0IjoiYXJjMTQxMF9wYXJ0aXRpb25faXNzdWUiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfcmVkZWVtX2J5X3BhcnRpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSZWRlZW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl9yZWRlZW0iLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfb3BlcmF0b3JfcmVkZWVtX2J5X3BhcnRpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlW10pIiwic3RydWN0IjoiYXJjMTQxMF9wYXJ0aXRpb25fcmVkZWVtIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3ltYm9sIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlY2ltYWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxTdXBwbHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzIwMF9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF9uYW1lIiwiZGVzYyI6IlJldHVybnMgdGhlIG5hbWUgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIG5hbWUgb2YgdGhlIHRva2VuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfc3ltYm9sIiwiZGVzYyI6IlJldHVybnMgdGhlIHN5bWJvbCBvZiB0aGUgdG9rZW4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVs4XSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBzeW1ib2wgb2YgdGhlIHRva2VuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfZGVjaW1hbHMiLCJkZXNjIjoiUmV0dXJucyB0aGUgZGVjaW1hbHMgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGRlY2ltYWxzIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3RvdGFsU3VwcGx5IiwiZGVzYyI6IlJldHVybnMgdGhlIHRvdGFsIHN1cHBseSBvZiB0aGUgdG9rZW4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSB0b3RhbCBzdXBwbHkgb2YgdGhlIHRva2VuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfYmFsYW5jZU9mIiwiZGVzYyI6IlJldHVybnMgdGhlIGN1cnJlbnQgYmFsYW5jZSBvZiB0aGUgb3duZXIgb2YgdGhlIHRva2VuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOiJUaGUgYWRkcmVzcyBvZiB0aGUgb3duZXIgb2YgdGhlIHRva2VuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgY3VycmVudCBiYWxhbmNlIG9mIHRoZSBob2xkZXIgb2YgdGhlIHRva2VuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfdHJhbnNmZXJGcm9tIiwiZGVzYyI6IlRyYW5zZmVycyB0b2tlbnMgZnJvbSBzb3VyY2UgdG8gZGVzdGluYXRpb24gYXMgYXBwcm92ZWQgc3BlbmRlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOiJUaGUgc291cmNlIG9mIHRoZSB0cmFuc2ZlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6IlRoZSBkZXN0aW5hdGlvbiBvZiB0aGUgdHJhbnNmZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJBbW91bnQgb2YgdG9rZW5zIHRvIHRyYW5zZmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJTdWNjZXNzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzIwMF9BcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjMjAwX1RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2FwcHJvdmUiLCJkZXNjIjoiQXBwcm92ZSBzcGVuZGVyIGZvciBhIHRva2VuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6IldobyBpcyBhbGxvd2VkIHRvIHRha2UgdG9rZW5zIG9uIG93bmVyJ3MgYmVoYWxmIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjoiQW1vdW50IG9mIHRva2VucyB0byBiZSB0YWtlbiBieSBzcGVuZGVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJTdWNjZXNzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzIwMF9BcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF9hbGxvd2FuY2UiLCJkZXNjIjoiUmV0dXJucyB0aGUgY3VycmVudCBhbGxvd2FuY2Ugb2YgdGhlIHNwZW5kZXIgb2YgdGhlIHRva2VucyBvZiB0aGUgb3duZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6Ik93bmVyJ3MgYWNjb3VudCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjoiV2hvIGlzIGFsbG93ZWQgdG8gdGFrZSB0b2tlbnMgb24gb3duZXIncyBiZWhhbGYiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSByZW1haW5pbmcgYWxsb3dhbmNlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9vd25lciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzg4X2lzX293bmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWVyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzg4X2luaXRpYWxpemVfb3duZXIiLCJkZXNjIjoiRXhwbGljaXQgaW5pdGlhbGl6YXRpb24gb3ZlcnJpZGUgKGNyZWF0aW9uIGdyb3VwIHJlY29tbWVuZGVkKS4gRmFpbHMgaWYgYWxyZWFkeSBpbml0aWFsaXplZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF90cmFuc2Zlcl9vd25lcnNoaXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjODhfT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzg4X3Jlbm91bmNlX293bmVyc2hpcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjODhfT3duZXJzaGlwUmVub3VuY2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzg4X3RyYW5zZmVyX293bmVyc2hpcF9yZXF1ZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZW5kaW5nIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBUcmFuc2ZlclJlcXVlc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVuZGluZ19vd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzg4X2FjY2VwdF9vd25lcnNoaXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVyQWNjZXB0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vd25lciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjODhfT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzg4X2NhbmNlbF9vd25lcnNoaXBfcmVxdWVzdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjh9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2MjYsMTY3OSwxNjk5LDE3NzgsMTkyNywxOTQwLDIwMzAsMjA0MywyMTQ2LDIyMjcsMjI3NiwyMzA4LDI0MzIsMjU3NCwyNzY5LDI5NTQsMzAxNywzMDc1LDMwOTAsMzIwNywzMjk2LDMzNzksMzQ0NCwzNDgyLDM1NjgsMzU3NSwzNjA1LDM2MTgsMzcyNiwzNzczLDM3ODAsMzgxMywzODI2LDQxMTIsNDI0NF0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDQzLDQyNDVdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MTMsMzgyMV0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDEzM10sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIGF0IHRoZSBzZW5kZXIgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NzIsMzc3N10sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBwYXJ0aXRpb24gYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxODIsMzQxMSwzNTQ5XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBhbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODk5XSwiZXJyb3JNZXNzYWdlIjoiTmFtZSBvZiB0aGUgYXNzZXQgbXVzdCBiZSBsb25nZXIgb3IgZXF1YWwgdG8gMSBjaGFyYWN0ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTAyXSwiZXJyb3JNZXNzYWdlIjoiTmFtZSBvZiB0aGUgYXNzZXQgbXVzdCBiZSBzaG9ydGVyIG9yIGVxdWFsIHRvIDMyIGNoYXJhY3RlcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDU5LDM3NTNdLCJlcnJvck1lc3NhZ2UiOiJOb3QgYXV0aG9yaXplZCBvcGVyYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyNCw1MzYsNTQ4LDU2Myw1NzUsNTkwLDYwNSw2MjQsNjQwLDY2Miw2ODQsNzA5LDcyOCw3NDQsNzYwLDc3Niw3OTIsODIwLDg0NCw4NjUsODg5LDkxNCw5MzgsOTY5LDEwMDAsMTAyMSwxMDQyLDEwNjcsMTA4OSwxMTE3LDExMzksMTE2MSwxMTc3LDEyMDUsMTIzMCwxMjQ4LDEyNjksMTI5MCwxMzA1LDEzMjEsMTMzNiwxMzU1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg5MV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgZGVwbG95ZXIgb2YgdGhpcyBzbWFydCBjb250cmFjdCBjYW4gY2FsbCBib290c3RyYXAgbWV0aG9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMzM10sImVycm9yTWVzc2FnZSI6Ik9ubHkgaG9sZGVyIGNhbiBhdXRob3JpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzE4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBob2xkZXIgY2FuIGF1dGhvcml6ZSBwb3J0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM1OF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgaG9sZGVyIGNhbiByZXZva2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTY1LDM3NzBdLCJlcnJvck1lc3NhZ2UiOiJQYXJ0aXRpb24gYmFsYW5jZSBtaXNzaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQzNywzNzMxXSwiZXJyb3JNZXNzYWdlIjoiUG9ydGlvbiBhbGxvd2FuY2UgZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTEwXSwiZXJyb3JNZXNzYWdlIjoiU3ltYm9sIG9mIHRoZSBhc3NldCBtdXN0IGJlIGxvbmdlciBvciBlcXVhbCB0byAxIGNoYXJhY3RlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5MTRdLCJlcnJvck1lc3NhZ2UiOiJTeW1ib2wgb2YgdGhlIGFzc2V0IG11c3QgYmUgc2hvcnRlciBvciBlcXVhbCB0byA4IGNoYXJhY3RlcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTIxXSwiZXJyb3JNZXNzYWdlIjoiVGhpcyBtZXRob2QgY2FuIGJlIGNhbGxlZCBvbmx5IG9uY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDA4XSwiZXJyb3JNZXNzYWdlIjoiYWxyZWFkeV9pbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzODFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjcsNTM5LDU1MSw1NjYsNTc4LDU5Myw2MDgsNjI3LDY0Myw2NjUsNjg3LDcxMiw3MzEsNzQ3LDc2Myw3NzksNzk1LDgyMyw4NDcsODY4LDg5Miw5MTcsOTQxLDk3MiwxMDAzLDEwMjQsMTA0NSwxMDcwLDEwOTIsMTEyMCwxMTQyLDExNjQsMTE4MCwxMjA4LDEyMzMsMTI1MSwxMjcyLDEyOTMsMTMwOCwxMzI0LDEzMzksMTM1OF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODI4LDE5NjIsMjA2NSwyMTMxLDM1MDEsMzYzNywzODQ1LDM5NzQsMzk4OSw0MDA1LDQwMTAsNDMwOSw0MzM4LDQzNjAsNDM3Miw0Mzk5LDQ0MzksNDQ1MCw0NDcyLDQ0NzgsNDUwMyw0NTI0LDQ1MzcsNDU2Nyw0NTc1LDQ2MTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTEyXSwiZXJyb3JNZXNzYWdlIjoiZW1wdHlfbmFtZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMzddLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnQgYXBwcm92YWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTM1LDIwMzhdLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnRfYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5ODIsMzk5OCw0MjE0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBzaXplIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgxNCwxOTA5LDIwMTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkX2Ftb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MzddLCJlcnJvck1lc3NhZ2UiOiJpc3N1YW5jZV9kaXNhYmxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MDNdLCJlcnJvck1lc3NhZ2UiOiJub3RfYXV0aCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NzcsMTY5Nl0sImVycm9yTWVzc2FnZSI6Im5vdF9mb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0NDEsNDQ3NCw0NTA1LDQ2MTJdLCJlcnJvck1lc3NhZ2UiOiJub3Rfb3duZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTYwLDQ1NzFdLCJlcnJvck1lc3NhZ2UiOiJub3RfcGVuZGluZ19vd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MDAsMTc4OSwzNDA1XSwiZXJyb3JNZXNzYWdlIjoib25seV9vd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NDgsMTk3MCwyMDUxLDIwNzMsMjQ0OCwzMjE1LDMzMDQsMzQ1MiwzNDkwLDM1MDksMzU4MywzNjI2LDM2NDUsMzc0MiwzNzg4LDM4MzQsMzg1Myw0MDQ1LDQxNTEsNDE3NF0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUyOF0sImVycm9yTWVzc2FnZSI6InBlbmRpbmdfdHJhbnNmZXJfZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQxMyw0NDQ2LDQ1MTBdLCJlcnJvck1lc3NhZ2UiOiJ6ZXJvX2FkZHJlc3Nfbm90X2FsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRE15SURJS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdJbUZ5WXpnNFgyOGlJQ0owSWlBd2VEQXdNRElnSW1JaUlDSmhjbU14TkRFd1gzQWlJQ0poY21NeE5qUXpYMlJ2WTNNaUlEQjRPREFnSW1GeVl6ZzRYM0J2SWlBd2VEQXdJQ0poY21NNE9GOXZhU0lnSW1GeVl6RTBNVEJmYjNCaElpQXdlREF3TURBZ0ltRnlZekUxT1RSZmFYTnpJaUFpWVhKak1UUXhNRjlvY0Y5aElpQWlZWEpqTVRReE1GOXZjQ0lnSW1GeVl6RTJORE5mWkc5aklpQXdlREF3TkRJZ01IZ3dNU0F3ZURBd01ERWdNSGd3TURZeUlEQjRNREF3TmlBd2VHUTNabU0wWVRrNElEQjRNREF3TURBd01EQXdNREF3TURBd01DQXdlRFZqTWpkaU5HWmpJREI0TnprNE0yTXpOV01nTUhnME16VTFaREpoWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFMk5ETWdaWGgwWlc1a2N5QkJjbU14TlRrMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTBPUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREV4WTJJek5tWTFJREI0WWpFMlpEZGhPR01nTUhoaE4yTmlNelE0TWlBd2VHVmpZall6Tm1NNElEQjROalZpTVRZNE1tRWdNSGd3TVRNd05UazVZaUF3ZURFME1tSTFabU5pSURCNFpqZzRNemhsWWprZ01IZ3pNVGc0TW1KbVlTQXdlR0U1WTJOaE1UWm1JREI0TWpZMk5UazNZekFnTUhnek5XWTRNVE0xWmlBd2VHUmhOekF5TldJNUlEQjRNMll5TlRZM01UTWdNSGc1TldJMFpqbGxNeUF3ZURnd1kyTTBPV0ZpSURCNE1EYzVOakl4TmpVZ01IaGxOemc1TmpGa1lTQXdlR1prT1RRNE1HUTNJREI0WWpGaU1XUTJPV0VnTUhoak1XSmxaRGM0T1NBd2VETmlabVV4T0RNeklEQjROVGs1WTJReFlUVWdNSGcyWkdVNU5ERTJOaUF3ZURJNFpqQXlNMlEzSURCNE9UYzFNemd5WlRJZ01IZzJOVGRrTVRObFl5QXdlR0kyWVdVeFlUSTFJREI0T0RSbFl6RXpaRFVnTUhobFl6azVOakEwTVNBd2VEZ3laVFUzTTJNMElEQjROR0U1TmpobU9HWWdNSGhpTlRReU1qRXlOU0F3ZUdKaVlqTXhPV1l6SURCNE1EY3dNalkxTkdVZ01IaGtNREUxTnpJMFpTQXdlREF5T1dabFkyTXdJREI0TnpNME9UTXpOR1VnTUhoa1lqZGpPREpsWmlBd2VHWmtNbU15WXpabElEQjROREpoTldZd05qVWdNSGhoWkRSbU5qaGxZU0F2THlCdFpYUm9iMlFnSW1GeVl6RTJORE5mYzJWMFgyUnZZM1Z0Wlc1MEtHSjVkR1ZiWFN4emRISnBibWNzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnlZekUyTkROZloyVjBYMlJ2WTNWdFpXNTBLR0o1ZEdWYlhTa29jM1J5YVc1bkxHSjVkR1ZiWFN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKaGNtTXhOalF6WDNKbGJXOTJaVjlrYjJOMWJXVnVkQ2hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaVlYSmpNVFkwTTE5blpYUmZZV3hzWDJSdlkzVnRaVzUwY3lncFlubDBaVnRkVzEwaUxDQnRaWFJvYjJRZ0ltRnlZekUxT1RSZmMyVjBYMmx6YzNWaFlteGxLR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhKak1UVTVORjlwYzNOMVpTaGhaR1J5WlhOekxIVnBiblF5TlRZc1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ5WXpFMU9UUmZjbVZrWldWdFJuSnZiU2hoWkdSeVpYTnpMSFZwYm5ReU5UWXNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6RTFPVFJmY21Wa1pXVnRLSFZwYm5ReU5UWXNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6RTFPVFJmZEhKaGJuTm1aWEpmZDJsMGFGOWtZWFJoS0dGa1pISmxjM01zZFdsdWRESTFOaXhpZVhSbFcxMHBZbTl2YkNJc0lHMWxkR2h2WkNBaVlYSmpNVFU1TkY5MGNtRnVjMlpsY2w5bWNtOXRYM2RwZEdoZlpHRjBZU2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5peGllWFJsVzEwcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWVhKak1UVTVORjlwYzE5cGMzTjFZV0pzWlNncFltOXZiQ0lzSUcxbGRHaHZaQ0FpWVhKak1UUXhNRjlpWVd4aGJtTmxYMjltWDNCaGNuUnBkR2x2YmloaFpHUnlaWE56TEdGa1pISmxjM01wZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWVhKak1qQXdYM1J5WVc1elptVnlLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbGliMjlzSWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJpaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTml4aWVYUmxXMTBwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpWVhKak1UUXhNRjl3WVhKMGFYUnBiMjV6WDI5bUtHRmtaSEpsYzNNc2RXbHVkRFkwS1dGa1pISmxjM05iWFNJc0lHMWxkR2h2WkNBaVlYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNpaGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0poY21NeE5ERXdYMkYxZEdodmNtbDZaVjl2Y0dWeVlYUnZjaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDNKbGRtOXJaVjl2Y0dWeVlYUnZjaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJpaGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEdKNWRHVmJYU2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0poY21NeE5ERXdYMk5oYmw5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNG9ZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTml4aWVYUmxXMTBwS0dKNWRHVXNjM1J5YVc1bkxHRmtaSEpsYzNNcElpd2diV1YwYUc5a0lDSmhjbU14TkRFd1gyRjFkR2h2Y21sNlpWOXZjR1Z5WVhSdmNsOWllVjl3YjNKMGFXOXVLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2w5aWVWOXdiM0owYVc5dUtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbUZ5WXpFME1UQmZhWE56ZFdWZllubGZjR0Z5ZEdsMGFXOXVLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMkxHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0poY21NeE5ERXdYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjRvWVdSa2NtVnpjeXgxYVc1ME1qVTJMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI0b1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltSnZiM1J6ZEhKaGNDaGllWFJsVzEwc1lubDBaVnRkTEhWcGJuUTRMSFZwYm5ReU5UWXBZbTl2YkNJc0lHMWxkR2h2WkNBaVlYSmpNakF3WDI1aGJXVW9LV0o1ZEdWYk16SmRJaXdnYldWMGFHOWtJQ0poY21NeU1EQmZjM2x0WW05c0tDbGllWFJsV3poZElpd2diV1YwYUc5a0lDSmhjbU15TURCZlpHVmphVzFoYkhNb0tYVnBiblE0SWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmZEc5MFlXeFRkWEJ3Ykhrb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltRnlZekl3TUY5aVlXeGhibU5sVDJZb1lXUmtjbVZ6Y3lsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmZEhKaGJuTm1aWEpHY205dEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbUZ5WXpJd01GOWhjSEJ5YjNabEtHRmtaSEpsYzNNc2RXbHVkREkxTmlsaWIyOXNJaXdnYldWMGFHOWtJQ0poY21NeU1EQmZZV3hzYjNkaGJtTmxLR0ZrWkhKbGMzTXNZV1JrY21WemN5bDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmhjbU00T0Y5dmQyNWxjaWdwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpWVhKak9EaGZhWE5mYjNkdVpYSW9ZV1JrY21WemN5bGliMjlzSWl3Z2JXVjBhRzlrSUNKaGNtTTRPRjlwYm1sMGFXRnNhWHBsWDI5M2JtVnlLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaVlYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlZWEpqT0RoZmNtVnViM1Z1WTJWZmIzZHVaWEp6YUdsd0tDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTTRPRjkwY21GdWMyWmxjbDl2ZDI1bGNuTm9hWEJmY21WeGRXVnpkQ2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnlZemc0WDJGalkyVndkRjl2ZDI1bGNuTm9hWEFvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ5WXpnNFgyTmhibU5sYkY5dmQyNWxjbk5vYVhCZmNtVnhkV1Z6ZENncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZWEpqTVRZME0xOXpaWFJmWkc5amRXMWxiblJmY205MWRHVkFOU0J0WVdsdVgyRnlZekUyTkROZloyVjBYMlJ2WTNWdFpXNTBYM0p2ZFhSbFFEWWdiV0ZwYmw5aGNtTXhOalF6WDNKbGJXOTJaVjlrYjJOMWJXVnVkRjl5YjNWMFpVQTNJRzFoYVc1ZllYSmpNVFkwTTE5blpYUmZZV3hzWDJSdlkzVnRaVzUwYzE5eWIzVjBaVUE0SUcxaGFXNWZZWEpqTVRVNU5GOXpaWFJmYVhOemRXRmliR1ZmY205MWRHVkFPU0J0WVdsdVgyRnlZekUxT1RSZmFYTnpkV1ZmY205MWRHVkFNVEFnYldGcGJsOWhjbU14TlRrMFgzSmxaR1ZsYlVaeWIyMWZjbTkxZEdWQU1URWdiV0ZwYmw5aGNtTXhOVGswWDNKbFpHVmxiVjl5YjNWMFpVQXhNaUJ0WVdsdVgyRnlZekUxT1RSZmRISmhibk5tWlhKZmQybDBhRjlrWVhSaFgzSnZkWFJsUURFeklHMWhhVzVmWVhKak1UVTVORjkwY21GdWMyWmxjbDltY205dFgzZHBkR2hmWkdGMFlWOXliM1YwWlVBeE5DQnRZV2x1WDJGeVl6RTFPVFJmYVhOZmFYTnpkV0ZpYkdWZmNtOTFkR1ZBTVRVZ2JXRnBibDloY21NeE5ERXdYMkpoYkdGdVkyVmZiMlpmY0dGeWRHbDBhVzl1WDNKdmRYUmxRREUySUcxaGFXNWZZWEpqTWpBd1gzUnlZVzV6Wm1WeVgzSnZkWFJsUURFM0lHMWhhVzVmWVhKak1UUXhNRjkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZmNtOTFkR1ZBTVRnZ2JXRnBibDloY21NeE5ERXdYM0JoY25ScGRHbHZibk5mYjJaZmNtOTFkR1ZBTVRrZ2JXRnBibDloY21NeE5ERXdYMmx6WDI5d1pYSmhkRzl5WDNKdmRYUmxRREl3SUcxaGFXNWZZWEpqTVRReE1GOWhkWFJvYjNKcGVtVmZiM0JsY21GMGIzSmZjbTkxZEdWQU1qRWdiV0ZwYmw5aGNtTXhOREV3WDNKbGRtOXJaVjl2Y0dWeVlYUnZjbDl5YjNWMFpVQXlNaUJ0WVdsdVgyRnlZekUwTVRCZmIzQmxjbUYwYjNKZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVYM0p2ZFhSbFFESXpJRzFoYVc1ZllYSmpNVFF4TUY5allXNWZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1WDNKdmRYUmxRREkwSUcxaGFXNWZZWEpqTVRReE1GOWhkWFJvYjNKcGVtVmZiM0JsY21GMGIzSmZZbmxmY0c5eWRHbHZibDl5YjNWMFpVQXlOU0J0WVdsdVgyRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSmZZbmxmY0c5eWRHbHZibDl5YjNWMFpVQXlOaUJ0WVdsdVgyRnlZekUwTVRCZmFYTnpkV1ZmWW5sZmNHRnlkR2wwYVc5dVgzSnZkWFJsUURJM0lHMWhhVzVmWVhKak1UUXhNRjl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDNKdmRYUmxRREk0SUcxaGFXNWZZWEpqTVRReE1GOXZjR1Z5WVhSdmNsOXlaV1JsWlcxZllubGZjR0Z5ZEdsMGFXOXVYM0p2ZFhSbFFESTVJRzFoYVc1ZlltOXZkSE4wY21Gd1gzSnZkWFJsUURNd0lHMWhhVzVmWVhKak1qQXdYMjVoYldWZmNtOTFkR1ZBTXpFZ2JXRnBibDloY21NeU1EQmZjM2x0WW05c1gzSnZkWFJsUURNeUlHMWhhVzVmWVhKak1qQXdYMlJsWTJsdFlXeHpYM0p2ZFhSbFFETXpJRzFoYVc1ZllYSmpNakF3WDNSdmRHRnNVM1Z3Y0d4NVgzSnZkWFJsUURNMElHMWhhVzVmWVhKak1qQXdYMkpoYkdGdVkyVlBabDl5YjNWMFpVQXpOU0J0WVdsdVgyRnlZekl3TUY5MGNtRnVjMlpsY2taeWIyMWZjbTkxZEdWQU16WWdiV0ZwYmw5aGNtTXlNREJmWVhCd2NtOTJaVjl5YjNWMFpVQXpOeUJ0WVdsdVgyRnlZekl3TUY5aGJHeHZkMkZ1WTJWZmNtOTFkR1ZBTXpnZ2JXRnBibDloY21NNE9GOXZkMjVsY2w5eWIzVjBaVUF6T1NCdFlXbHVYMkZ5WXpnNFgybHpYMjkzYm1WeVgzSnZkWFJsUURRd0lHMWhhVzVmWVhKak9EaGZhVzVwZEdsaGJHbDZaVjl2ZDI1bGNsOXliM1YwWlVBME1TQnRZV2x1WDJGeVl6ZzRYM1J5WVc1elptVnlYMjkzYm1WeWMyaHBjRjl5YjNWMFpVQTBNaUJ0WVdsdVgyRnlZemc0WDNKbGJtOTFibU5sWDI5M2JtVnljMmhwY0Y5eWIzVjBaVUEwTXlCdFlXbHVYMkZ5WXpnNFgzUnlZVzV6Wm1WeVgyOTNibVZ5YzJocGNGOXlaWEYxWlhOMFgzSnZkWFJsUURRMElHMWhhVzVmWVhKak9EaGZZV05qWlhCMFgyOTNibVZ5YzJocGNGOXliM1YwWlVBME5TQnRZV2x1WDJGeVl6ZzRYMk5oYm1ObGJGOXZkMjVsY25Ob2FYQmZjbVZ4ZFdWemRGOXliM1YwWlVBME5nb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFMk5ETWdaWGgwWlc1a2N5QkJjbU14TlRrMElIc0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpPRGhmWTJGdVkyVnNYMjkzYm1WeWMyaHBjRjl5WlhGMVpYTjBYM0p2ZFhSbFFEUTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVEF6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdGeVl6ZzRYMk5oYm1ObGJGOXZkMjVsY25Ob2FYQmZjbVZ4ZFdWemRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTTRPRjloWTJObGNIUmZiM2R1WlhKemFHbHdYM0p2ZFhSbFFEUTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWVhKak9EaGZZV05qWlhCMFgyOTNibVZ5YzJocGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTTRPRjkwY21GdWMyWmxjbDl2ZDI1bGNuTm9hWEJmY21WeGRXVnpkRjl5YjNWMFpVQTBORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNVFkwTXlCbGVIUmxibVJ6SUVGeVl6RTFPVFFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZemc0WDNSeVlXNXpabVZ5WDI5M2JtVnljMmhwY0Y5eVpYRjFaWE4wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpnNFgzSmxibTkxYm1ObFgyOTNibVZ5YzJocGNGOXliM1YwWlVBME16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpnNFgzSmxibTkxYm1ObFgyOTNibVZ5YzJocGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTTRPRjkwY21GdWMyWmxjbDl2ZDI1bGNuTm9hWEJmY205MWRHVkFOREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8xT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUyTkRNZ1pYaDBaVzVrY3lCQmNtTXhOVGswSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU00T0Y5MGNtRnVjMlpsY2w5dmQyNWxjbk5vYVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak9EaGZhVzVwZEdsaGJHbDZaVjl2ZDI1bGNsOXliM1YwWlVBME1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UWTBNeUJsZUhSbGJtUnpJRUZ5WXpFMU9UUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6ZzRYMmx1YVhScFlXeHBlbVZmYjNkdVpYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpPRGhmYVhOZmIzZHVaWEpmY205MWRHVkFOREE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUyTkRNZ1pYaDBaVzVrY3lCQmNtTXhOVGswSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU00T0Y5cGMxOXZkMjVsY2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NNE9GOXZkMjVsY2w5eWIzVjBaVUF6T1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZemc0WDI5M2JtVnlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekl3TUY5aGJHeHZkMkZ1WTJWZmNtOTFkR1ZBTXpnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UYzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UWTBNeUJsZUhSbGJtUnpJRUZ5WXpFMU9UUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakUzTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNakF3WDJGc2JHOTNZVzVqWlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeU1EQmZZWEJ3Y205MlpWOXliM1YwWlVBek56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hOalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOalF6SUdWNGRHVnVaSE1nUVhKak1UVTVOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRZMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU15TURCZllYQndjbTkyWlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeU1EQmZkSEpoYm5ObVpYSkdjbTl0WDNKdmRYUmxRRE0yT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFME9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFMk5ETWdaWGgwWlc1a2N5QkJjbU14TlRrMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hORGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6SXdNRjkwY21GdWMyWmxja1p5YjIwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1qQXdYMkpoYkdGdVkyVlBabDl5YjNWMFpVQXpOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94TWpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU14TmpReklHVjRkR1Z1WkhNZ1FYSmpNVFU1TkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1USXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWTJGc2JITjFZaUJoY21NeU1EQmZZbUZzWVc1alpVOW1DaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekl3TUY5MGIzUmhiRk4xY0hCc2VWOXliM1YwWlVBek5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hNVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1qQXdYM1J2ZEdGc1UzVndjR3g1Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpJd01GOWtaV05wYldGc2MxOXliM1YwWlVBek16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1qQXdYMlJsWTJsdFlXeHpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekl3TUY5emVXMWliMnhmY205MWRHVkFNekk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNakF3WDNONWJXSnZiQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU15TURCZmJtRnRaVjl5YjNWMFpVQXpNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCaGNtTXlNREJmYm1GdFpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aWIyOTBjM1J5WVhCZmNtOTFkR1ZBTXpBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5qUXpJR1Y0ZEdWdVpITWdRWEpqTVRVNU5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdKdmIzUnpkSEpoY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeE5ERXdYMjl3WlhKaGRHOXlYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjVmY205MWRHVkFNams2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pReU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFMk5ETWdaWGgwWlc1a2N5QkJjbU14TlRrMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOREl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UUXhNRjl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDNKdmRYUmxRREk0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME1EZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5qUXpJR1Y0ZEdWdVpITWdRWEpqTVRVNU5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalF3T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNVFF4TUY5eVpXUmxaVzFmWW5sZmNHRnlkR2wwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6RTBNVEJmYVhOemRXVmZZbmxmY0dGeWRHbDBhVzl1WDNKdmRYUmxRREkzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek9ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5qUXpJR1Y0ZEdWdVpITWdRWEpqTVRVNU5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak00TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNVFF4TUY5cGMzTjFaVjlpZVY5d1lYSjBhWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2w5aWVWOXdiM0owYVc5dVgzSnZkWFJsUURJMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pOekVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOalF6SUdWNGRHVnVaSE1nUVhKak1UVTVOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNM01Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR05oYkd4emRXSWdZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjbDlpZVY5d2IzSjBhVzl1Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpFME1UQmZZWFYwYUc5eWFYcGxYMjl3WlhKaGRHOXlYMko1WDNCdmNuUnBiMjVmY205MWRHVkFNalU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNMU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFMk5ETWdaWGgwWlc1a2N5QkJjbU14TlRrMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNelU1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOREV3WDJGMWRHaHZjbWw2WlY5dmNHVnlZWFJ2Y2w5aWVWOXdiM0owYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDl5YjNWMFpVQXlORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRjMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTVRZME15QmxlSFJsYm1SeklFRnlZekUxT1RRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZiZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU14TkRFd1gyOXdaWEpoZEc5eVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDl5YjNWMFpVQXlNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRRMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTVRZME15QmxlSFJsYm1SeklFRnlZekUxT1RRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hORFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTBNVEJmYjNCbGNtRjBiM0pmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6RTBNVEJmY21WMmIydGxYMjl3WlhKaGRHOXlYM0p2ZFhSbFFESXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TXpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU14TmpReklHVjRkR1Z1WkhNZ1FYSmpNVFU1TkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXpOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1UUXhNRjl5WlhadmEyVmZiM0JsY21GMGIzSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNVFF4TUY5aGRYUm9iM0pwZW1WZmIzQmxjbUYwYjNKZmNtOTFkR1ZBTWpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXlPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6RTJORE1nWlhoMFpXNWtjeUJCY21NeE5UazBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRJNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU14TkRFd1gyRjFkR2h2Y21sNlpWOXZjR1Z5WVhSdmNnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgzSnZkWFJsUURJd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOalF6SUdWNGRHVnVaSE1nUVhKak1UVTVOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR05oYkd4emRXSWdZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU14TkRFd1gzQmhjblJwZEdsdmJuTmZiMlpmY205MWRHVkFNVGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFd053b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFMk5ETWdaWGgwWlc1a2N5QkJjbU14TlRrMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVEEzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOREV3WDNCaGNuUnBkR2x2Ym5OZmIyWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNVFF4TUY5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNWZjbTkxZEdWQU1UZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPamt6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNVFkwTXlCbGVIUmxibVJ6SUVGeVl6RTFPVFFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvNU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZWEpqTVRReE1GOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjRLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTWpBd1gzUnlZVzV6Wm1WeVgzSnZkWFJsUURFM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6RTJORE1nWlhoMFpXNWtjeUJCY21NeE5UazBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZekl3TUY5MGNtRnVjMlpsY2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeE5ERXdYMkpoYkdGdVkyVmZiMlpmY0dGeWRHbDBhVzl1WDNKdmRYUmxRREUyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFMk5ETWdaWGgwWlc1a2N5QkJjbU14TlRrMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTBNVEJmWW1Gc1lXNWpaVjl2Wmw5d1lYSjBhWFJwYjI0S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UVTVORjlwYzE5cGMzTjFZV0pzWlY5eWIzVjBaVUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TlRrMExtRnNaMjh1ZEhNNk9EWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdZWEpqTVRVNU5GOXBjMTlwYzNOMVlXSnNaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU14TlRrMFgzUnlZVzV6Wm1WeVgyWnliMjFmZDJsMGFGOWtZWFJoWDNKdmRYUmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFMk5ETWdaWGgwWlc1a2N5QkJjbU14TlRrMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTFPVFJmZEhKaGJuTm1aWEpmWm5KdmJWOTNhWFJvWDJSaGRHRUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNVFU1TkY5MGNtRnVjMlpsY2w5M2FYUm9YMlJoZEdGZmNtOTFkR1ZBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UWTBNeUJsZUhSbGJtUnpJRUZ5WXpFMU9UUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNVFU1TkY5MGNtRnVjMlpsY2w5M2FYUm9YMlJoZEdFS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UVTVORjl5WldSbFpXMWZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNVFkwTXlCbGVIUmxibVJ6SUVGeVl6RTFPVFFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZWEpqTVRVNU5GOXlaV1JsWlcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UVTVORjl5WldSbFpXMUdjbTl0WDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFMk5ETWdaWGgwWlc1a2N5QkJjbU14TlRrMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZORFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTFPVFJmY21Wa1pXVnRSbkp2YlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeE5UazBYMmx6YzNWbFgzSnZkWFJsUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6RTJORE1nWlhoMFpXNWtjeUJCY21NeE5UazBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZekUxT1RSZmFYTnpkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTVRVNU5GOXpaWFJmYVhOemRXRmliR1ZmY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU14TmpReklHVjRkR1Z1WkhNZ1FYSmpNVFU1TkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJoY21NeE5UazBYM05sZEY5cGMzTjFZV0pzWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeE5qUXpYMmRsZEY5aGJHeGZaRzlqZFcxbGJuUnpYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdGeVl6RTJORE5mWjJWMFgyRnNiRjlrYjJOMWJXVnVkSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTVRZME0xOXlaVzF2ZG1WZlpHOWpkVzFsYm5SZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5qUXpJR1Y0ZEdWdVpITWdRWEpqTVRVNU5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOalF6WDNKbGJXOTJaVjlrYjJOMWJXVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU14TmpRelgyZGxkRjlrYjJOMWJXVnVkRjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUyTkRNZ1pYaDBaVzVrY3lCQmNtTXhOVGswSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpFMk5ETmZaMlYwWDJSdlkzVnRaVzUwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpFMk5ETmZjMlYwWDJSdlkzVnRaVzUwWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTVRZME15QmxlSFJsYm1SeklFRnlZekUxT1RRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1UWTBNMTl6WlhSZlpHOWpkVzFsYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFEUTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUyTkRNZ1pYaDBaVzVrY3lCQmNtTXhOVGswSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOVE1LSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1gzQjFlV0ZmYkdsaUxtRnlZelF1WkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZllubDBaVjlzWlc1bmRHaGZhR1ZoWkNoaGNuSmhlVG9nWW5sMFpYTXNJRzVsZDE5cGRHVnRjMTlpZVhSbGN6b2dZbmwwWlhNc0lHNWxkMTlwZEdWdGMxOWpiM1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZZbmwwWlY5c1pXNW5kR2hmYUdWaFpEb0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNvS0lDQWdJR0o2WlhKdkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYzNkaGNBb0taSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWW5sMFpWOXNaVzVuZEdoZmFHVmhaRjltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lEd0tJQ0FnSUdKNklHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMko1ZEdWZmJHVnVaM1JvWDJobFlXUmZZV1owWlhKZlptOXlRRFVLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCeVpYQnNZV05sTXdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTkFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ013b2dJQ0FnWWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWllWFJsWDJ4bGJtZDBhRjlvWldGa1gyWnZjbDlvWldGa1pYSkFNZ29LWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZllubDBaVjlzWlc1bmRHaGZhR1ZoWkY5aFpuUmxjbDltYjNKQU5Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk9rRnlZekUyTkRNdVgyOXViSGxQZDI1bGNpZ3BJQzArSUhadmFXUTZDbDl2Ym14NVQzZHVaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWhjbU00T0Y5cGMxOXZkMjVsY2lodVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcEtTNXVZWFJwZG1VZ1BUMDlJSFJ5ZFdVc0lDZHZibXg1WDI5M2JtVnlKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWVhKak9EaGZhWE5mYjNkdVpYSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhsZmIzZHVaWElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02T2tGeVl6RTJORE11WVhKak1UWTBNMTl6WlhSZlpHOWpkVzFsYm5Rb2JtRnRaVG9nWW5sMFpYTXNJSFZ5YVRvZ1lubDBaWE1zSUdoaGMyZzZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGhjbU14TmpRelgzTmxkRjlrYjJOMWJXVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TXpRdE16VUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1UWTBNMTl6WlhSZlpHOWpkVzFsYm5Rb2JtRnRaVG9nWVhKak5DNUVlVzVoYldsalFubDBaWE1zSUhWeWFUb2dZWEpqTkM1VGRISXNJR2hoYzJnNklHRnlZelF1UkhsdVlXMXBZMEo1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhSb2FYTXVYMjl1YkhsUGQyNWxjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlGOXZibXg1VDNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVZVzFsTG1KNWRHVnpMbXhsYm1kMGFDQStJREFzSUNkbGJYQjBlVjl1WVcxbEp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJsYlhCMGVWOXVZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCamIyNXpkQ0J5WldNZ1BTQnVaWGNnWVhKak1UWTBNMTlrYjJOMWJXVnVkRjl5WldOdmNtUW9leUIxY21rc0lHaGhjMmdzSUhScGJXVnpkR0Z0Y0RvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNoSGJHOWlZV3d1Y205MWJtUXBJSDBwQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ01USWdMeThnTVRJS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREJqQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaRzlqZFcxbGJuUnpJRDBnUW05NFRXRndQR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpMQ0JoY21NeE5qUXpYMlJ2WTNWdFpXNTBYM0psWTI5eVpENG9leUJyWlhsUWNtVm1hWGc2SUNkaGNtTXhOalF6WDJSdll5Y2dmU2tLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0poY21NeE5qUXpYMlJ2WXlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QjBhR2x6TG1SdlkzVnRaVzUwY3lodVlXMWxLUzUyWVd4MVpTQTlJSEpsWXk1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QndkV0pzYVdNZ1pHOWpkVzFsYm5STFpYbHpJRDBnUW05NFBHRnlZelF1UkhsdVlXMXBZMEo1ZEdWelcxMCtLSHNnYTJWNU9pQW5ZWEpqTVRZME0xOWtiMk56SnlCOUtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVlYSmpNVFkwTTE5a2IyTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG1SdlkzVnRaVzUwUzJWNWN5NWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdGeVl6RTJORE5mYzJWMFgyUnZZM1Z0Wlc1MFgyVnNjMlZmWW05a2VVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUIwYUdsekxtUnZZM1Z0Wlc1MFMyVjVjeTUyWVd4MVpTQTlJRnR1WVcxbFhRb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z01IZ3dNREF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgySjVkR1ZmYkdWdVozUm9YMmhsWVdRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklIQjFZbXhwWXlCa2IyTjFiV1Z1ZEV0bGVYTWdQU0JDYjNnOFlYSmpOQzVFZVc1aGJXbGpRbmwwWlhOYlhUNG9leUJyWlhrNklDZGhjbU14TmpRelgyUnZZM01uSUgwcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKaGNtTXhOalF6WDJSdlkzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUIwYUdsekxtUnZZM1Z0Wlc1MFMyVjVjeTUyWVd4MVpTQTlJRnR1WVcxbFhRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaRzlqZFcxbGJuUkxaWGx6SUQwZ1FtOTRQR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpXMTArS0hzZ2EyVjVPaUFuWVhKak1UWTBNMTlrYjJOekp5QjlLUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlZWEpqTVRZME0xOWtiMk56SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z2RHaHBjeTVrYjJOMWJXVnVkRXRsZVhNdWRtRnNkV1VnUFNCYmJtRnRaVjBLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0NtRnlZekUyTkROZmMyVjBYMlJ2WTNWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR1Z0YVhRb0owUnZZM1Z0Wlc1MFZYQmtZWFJsWkNjc0lHNWxkeUJoY21NeE5qUXpYMlJ2WTNWdFpXNTBYM1Z3WkdGMFpXUmZaWFpsYm5Rb2V5QnVZVzFsTENCMWNta3NJR2hoYzJnZ2ZTa3BDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdOZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJREI0TURBd05nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TW1Sak1ETmpNellnTHk4Z2JXVjBhRzlrSUNKRWIyTjFiV1Z1ZEZWd1pHRjBaV1FvS0dKNWRHVmJYU3h6ZEhKcGJtY3NZbmwwWlZ0ZEtTa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2NtVjBjM1ZpQ2dwaGNtTXhOalF6WDNObGRGOWtiMk4xYldWdWRGOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUhCMVlteHBZeUJrYjJOMWJXVnVkRXRsZVhNZ1BTQkNiM2c4WVhKak5DNUVlVzVoYldsalFubDBaWE5iWFQ0b2V5QnJaWGs2SUNkaGNtTXhOalF6WDJSdlkzTW5JSDBwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0poY21NeE5qUXpYMlJ2WTNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QjBhR2x6TG1SdlkzVnRaVzUwUzJWNWN5NTJZV3gxWlNBOUlGc3VMaTUwYUdsekxtUnZZM1Z0Wlc1MFMyVjVjeTUyWVd4MVpTd2dibUZ0WlYwS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VEQXdNREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZllubDBaVjlzWlc1bmRHaGZhR1ZoWkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNvS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZZbmwwWlY5c1pXNW5kR2hmYUdWaFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdjSFZpYkdsaklHUnZZM1Z0Wlc1MFMyVjVjeUE5SUVKdmVEeGhjbU0wTGtSNWJtRnRhV05DZVhSbGMxdGRQaWg3SUd0bGVUb2dKMkZ5WXpFMk5ETmZaRzlqY3ljZ2ZTa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltRnlZekUyTkROZlpHOWpjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUhSb2FYTXVaRzlqZFcxbGJuUkxaWGx6TG5aaGJIVmxJRDBnV3k0dUxuUm9hWE11Wkc5amRXMWxiblJMWlhsekxuWmhiSFZsTENCdVlXMWxYUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCd2RXSnNhV01nWkc5amRXMWxiblJMWlhseklEMGdRbTk0UEdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6VzEwK0tIc2dhMlY1T2lBbllYSmpNVFkwTTE5a2IyTnpKeUI5S1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpWVhKak1UWTBNMTlrYjJOeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdkR2hwY3k1a2IyTjFiV1Z1ZEV0bGVYTXVkbUZzZFdVZ1BTQmJMaTR1ZEdocGN5NWtiMk4xYldWdWRFdGxlWE11ZG1Gc2RXVXNJRzVoYldWZENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCaUlHRnlZekUyTkROZmMyVjBYMlJ2WTNWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU13b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk9rRnlZekUyTkRNdVlYSmpNVFkwTTE5blpYUmZaRzlqZFcxbGJuUW9ibUZ0WlRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwaGNtTXhOalF6WDJkbGRGOWtiMk4xYldWdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZORGd0TkRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRZME0xOW5aWFJmWkc5amRXMWxiblFvYm1GdFpUb2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTXBPaUJoY21NeE5qUXpYMlJ2WTNWdFpXNTBYM0psWTI5eVpDQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklIQjFZbXhwWXlCa2IyTjFiV1Z1ZEhNZ1BTQkNiM2hOWVhBOFlYSmpOQzVFZVc1aGJXbGpRbmwwWlhNc0lHRnlZekUyTkROZlpHOWpkVzFsYm5SZmNtVmpiM0prUGloN0lHdGxlVkJ5WldacGVEb2dKMkZ5WXpFMk5ETmZaRzlqSnlCOUtRb2dJQ0FnWW5sMFpXTWdNVGNnTHk4Z0ltRnlZekUyTkROZlpHOWpJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtUnZZM1Z0Wlc1MGN5aHVZVzFsS1M1bGVHbHpkSE1zSUNkdWIzUmZabTkxYm1RbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1JmWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1SdlkzVnRaVzUwY3lodVlXMWxLUzUyWVd4MVpTNWpiM0I1S0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qcEJjbU14TmpRekxtRnlZekUyTkROZmNtVnRiM1psWDJSdlkzVnRaVzUwS0c1aGJXVTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGhjbU14TmpRelgzSmxiVzkyWlY5a2IyTjFiV1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk5UUXROVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFkwTTE5eVpXMXZkbVZmWkc5amRXMWxiblFvYm1GdFpUb2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z2RHaHBjeTVmYjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdYMjl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnY0hWaWJHbGpJR1J2WTNWdFpXNTBjeUE5SUVKdmVFMWhjRHhoY21NMExrUjVibUZ0YVdOQ2VYUmxjeXdnWVhKak1UWTBNMTlrYjJOMWJXVnVkRjl5WldOdmNtUStLSHNnYTJWNVVISmxabWw0T2lBbllYSmpNVFkwTTE5a2IyTW5JSDBwQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpWVhKak1UWTBNMTlrYjJNaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11Wkc5amRXMWxiblJ6S0c1aGJXVXBMbVY0YVhOMGN5d2dKMjV2ZEY5bWIzVnVaQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRGOW1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z1kyOXVjM1FnY0hKcGIzSWdQU0IwYUdsekxtUnZZM1Z0Wlc1MGN5aHVZVzFsS1M1MllXeDFaUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJSFJvYVhNdVpHOWpkVzFsYm5SektHNWhiV1VwTG1SbGJHVjBaU2dwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklHVnRhWFFvSjBSdlkzVnRaVzUwVW1WdGIzWmxaQ2NzSUc1bGR5QmhjbU14TmpRelgyUnZZM1Z0Wlc1MFgzSmxiVzkyWldSZlpYWmxiblFvZXlCdVlXMWxMQ0IxY21rNklIQnlhVzl5TG5WeWFTd2dhR0Z6YURvZ2NISnBiM0l1YUdGemFDQjlLU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOaUF2THlBMkNpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCaWVYUmxZeUF5TWlBdkx5QXdlREF3TURZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlXVTNZVFJtWVRBZ0x5OGdiV1YwYUc5a0lDSkViMk4xYldWdWRGSmxiVzkyWldRb0tHSjVkR1ZiWFN4emRISnBibWNzWW5sMFpWdGRLU2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pvNlFYSmpNVFkwTXk1aGNtTXhOalF6WDJkbGRGOWhiR3hmWkc5amRXMWxiblJ6S0NrZ0xUNGdZbmwwWlhNNkNtRnlZekUyTkROZloyVjBYMkZzYkY5a2IyTjFiV1Z1ZEhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QndkV0pzYVdNZ1pHOWpkVzFsYm5STFpYbHpJRDBnUW05NFBHRnlZelF1UkhsdVlXMXBZMEo1ZEdWelcxMCtLSHNnYTJWNU9pQW5ZWEpqTVRZME0xOWtiMk56SnlCOUtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVlYSmpNVFkwTTE5a2IyTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVpHOWpkVzFsYm5STFpYbHpMblpoYkhWbENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6bzZRWEpqTVRVNU5DNWZiMjVzZVU5M2JtVnlLQ2tnTFQ0Z2RtOXBaRG9LYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvNlFYSmpNVFU1TkM1ZmIyNXNlVTkzYm1WeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WVhKak9EaGZhWE5mYjNkdVpYSW9ibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU2t1Ym1GMGFYWmxJRDA5UFNCMGNuVmxMQ0FuYjI1c2VWOXZkMjVsY2ljcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlHRnlZemc0WDJselgyOTNibVZ5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVYMjkzYm1WeUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qcEJjbU14TlRrMExtRnlZekUxT1RSZmMyVjBYMmx6YzNWaFlteGxLR1pzWVdjNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwaGNtTXhOVGswWDNObGRGOXBjM04xWVdKc1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZNamN0TWpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRVNU5GOXpaWFJmYVhOemRXRmliR1VvWm14aFp6b2dZWEpqTkM1Q2IyOXNLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TlRrMExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklIUm9hWE11WDI5dWJIbFBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02T2tGeVl6RTFPVFF1WDI5dWJIbFBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6RTFPVFJmYVhOemRXRmliR1VnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtKdmIydytLSHNnYTJWNU9pQW5ZWEpqTVRVNU5GOXBjM01uSUgwcElDOHZJRlJ5ZFdVZ1BTQnBjM04xWVdKc1pRb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0ltRnlZekUxT1RSZmFYTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnZEdocGN5NWhjbU14TlRrMFgybHpjM1ZoWW14bExuWmhiSFZsSUQwZ1pteGhad29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem82UVhKak1UVTVOQzVoY21NeE5UazBYMmx6YzNWbEtIUnZPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQmllWFJsY3l3Z1pHRjBZVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbUZ5WXpFMU9UUmZhWE56ZFdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qTTBMVE0xQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUxT1RSZmFYTnpkV1VvZEc4NklHRnlZelF1UVdSa2NtVnpjeXdnWVcxdmRXNTBPaUJoY21NMExsVnBiblJPTWpVMkxDQmtZWFJoT2lCaGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUIwYUdsekxsOXZibXg1VDNkdVpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qcEJjbU14TlRrMExsOXZibXg1VDNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhiVzkxYm5RdWJtRjBhWFpsSUQ0Z01HNHNJQ2RwYm5aaGJHbGtYMkZ0YjNWdWRDY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VBb2dJQ0FnWWo0S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtYMkZ0YjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUxT1RSZmFYTnpkV0ZpYkdVZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrSnZiMncrS0hzZ2EyVjVPaUFuWVhKak1UVTVORjlwYzNNbklIMHBJQzh2SUZSeWRXVWdQU0JwYzNOMVlXSnNaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUwSUM4dklDSmhjbU14TlRrMFgybHpjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRnlZekUxT1RSZmFYTnpkV0ZpYkdVdWFHRnpWbUZzZFdVZ0ppWWdkR2hwY3k1aGNtTXhOVGswWDJsemMzVmhZbXhsTG5aaGJIVmxMbTVoZEdsMlpTQTlQVDBnZEhKMVpTd2dKMmx6YzNWaGJtTmxYMlJwYzJGaWJHVmtKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHRnlZekUxT1RSZmFYTnpkV1ZmWW05dmJGOW1ZV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFU1TkY5cGMzTjFZV0pzWlNBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFtOXZiRDRvZXlCclpYazZJQ2RoY21NeE5UazBYMmx6Y3ljZ2ZTa2dMeThnVkhKMVpTQTlJR2x6YzNWaFlteGxDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0ltRnlZekUxT1RSZmFYTnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVoY21NeE5UazBYMmx6YzNWaFlteGxMbWhoYzFaaGJIVmxJQ1ltSUhSb2FYTXVZWEpqTVRVNU5GOXBjM04xWVdKc1pTNTJZV3gxWlM1dVlYUnBkbVVnUFQwOUlIUnlkV1VzSUNkcGMzTjFZVzVqWlY5a2FYTmhZbXhsWkNjcENpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nWVhKak1UVTVORjlwYzNOMVpWOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDZ3BoY21NeE5UazBYMmx6YzNWbFgySnZiMnhmYldWeVoyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRnlZekUxT1RSZmFYTnpkV0ZpYkdVdWFHRnpWbUZzZFdVZ0ppWWdkR2hwY3k1aGNtTXhOVGswWDJsemMzVmhZbXhsTG5aaGJIVmxMbTVoZEdsMlpTQTlQVDBnZEhKMVpTd2dKMmx6YzNWaGJtTmxYMlJwYzJGaWJHVmtKeWtLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBjM04xWVc1alpWOWthWE5oWW14bFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdkR2hwY3k1aGNtTXhOREV3WDJsemMzVmxYMko1WDNCaGNuUnBkR2x2YmloMGJ5d2dibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BMQ0JoYlc5MWJuUXNJR1JoZEdFcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOREV3WDJsemMzVmxYMko1WDNCaGNuUnBkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z1pXMXBkQ2duU1hOemRXVW5MQ0J1WlhjZ1lYSmpNVFU1TkY5cGMzTjFaVjlsZG1WdWRDaDdJSFJ2TENCaGJXOTFiblFzSUdSaGRHRWdmU2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE9DQXZMeUF3ZURBd05ESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWXlaVGs1T0dGbUlDOHZJRzFsZEdodlpDQWlTWE56ZFdVb0tHRmtaSEpsYzNNc2RXbHVkREkxTml4aWVYUmxXMTBwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDbUZ5WXpFMU9UUmZhWE56ZFdWZlltOXZiRjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ1lYSmpNVFU1TkY5cGMzTjFaVjlpYjI5c1gyMWxjbWRsUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pwQmNtTXhOVGswTG1GeVl6RTFPVFJmY21Wa1pXVnRSbkp2YlNobWNtOXRPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQmllWFJsY3l3Z1pHRjBZVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbUZ5WXpFMU9UUmZjbVZrWldWdFJuSnZiVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TkRRdE5EVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1UVTVORjl5WldSbFpXMUdjbTl0S0daeWIyMDZJR0Z5WXpRdVFXUmtjbVZ6Y3l3Z1lXMXZkVzUwT2lCaGNtTTBMbFZwYm5ST01qVTJMQ0JrWVhSaE9pQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNeUF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWTI5dWMzUWdjMlZ1WkdWeUlEMGdibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QmhjM05sY25Rb2MyVnVaR1Z5SUQwOVBTQm1jbTl0SUh4OElIUm9hWE11WVhKak9EaGZhWE5mYjNkdVpYSW9jMlZ1WkdWeUtTNXVZWFJwZG1VZ1BUMDlJSFJ5ZFdVc0lDZHViM1JmWVhWMGFDY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1lYSmpNVFU1TkY5eVpXUmxaVzFHY205dFgySnZiMnhmZEhKMVpVQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJoY21NNE9GOXBjMTl2ZDI1bGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmllaUJoY21NeE5UazBYM0psWkdWbGJVWnliMjFmWW05dmJGOW1ZV3h6WlVBekNncGhjbU14TlRrMFgzSmxaR1ZsYlVaeWIyMWZZbTl2YkY5MGNuVmxRREk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9LWVhKak1UVTVORjl5WldSbFpXMUdjbTl0WDJKdmIyeGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHpaVzVrWlhJZ1BUMDlJR1p5YjIwZ2ZId2dkR2hwY3k1aGNtTTRPRjlwYzE5dmQyNWxjaWh6Wlc1a1pYSXBMbTVoZEdsMlpTQTlQVDBnZEhKMVpTd2dKMjV2ZEY5aGRYUm9KeWtLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1JmWVhWMGFBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6bzBPQW9nSUNBZ0x5OGdZWE56WlhKMEtHRnRiM1Z1ZEM1dVlYUnBkbVVnUGlBd2Jpd2dKMmx1ZG1Gc2FXUmZZVzF2ZFc1MEp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0JpUGdvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUmZZVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklIQjFZbXhwWXlCaVlXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlpHUnlaWE56TENCVmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RpSnlCOUtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVlpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW1Gc1lXNWpaWE1vWm5KdmJTa3VaWGhwYzNSeklDWW1JSFJvYVhNdVltRnNZVzVqWlhNb1puSnZiU2t1ZG1Gc2RXVXVibUYwYVhabElENDlJR0Z0YjNWdWRDNXVZWFJwZG1Vc0lDZHBibk4xWm1acFkybGxiblJmWW1Gc1lXNWpaU2NwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHRnlZekUxT1RSZmNtVmtaV1Z0Um5KdmJWOWliMjlzWDJaaGJITmxRRGNLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaVBqMEtJQ0FnSUdKNklHRnlZekUxT1RSZmNtVmtaV1Z0Um5KdmJWOWliMjlzWDJaaGJITmxRRGNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDZ3BoY21NeE5UazBYM0psWkdWbGJVWnliMjFmWW05dmJGOXRaWEpuWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW1Gc1lXNWpaWE1vWm5KdmJTa3VaWGhwYzNSeklDWW1JSFJvYVhNdVltRnNZVzVqWlhNb1puSnZiU2t1ZG1Gc2RXVXVibUYwYVhabElENDlJR0Z0YjNWdWRDNXVZWFJwZG1Vc0lDZHBibk4xWm1acFkybGxiblJmWW1Gc1lXNWpaU2NwQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzV6ZFdabWFXTnBaVzUwWDJKaGJHRnVZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUhSb2FYTXVZbUZzWVc1alpYTW9abkp2YlNrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmloMGFHbHpMbUpoYkdGdVkyVnpLR1p5YjIwcExuWmhiSFZsTG01aGRHbDJaU0F0SUdGdGIzVnVkQzV1WVhScGRtVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpTFFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR0o4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnY0hWaWJHbGpJSFJ2ZEdGc1UzVndjR3g1SUQwZ1IyeHZZbUZzVTNSaGRHVThWV2x1ZEU0eU5UWStLSHNnYTJWNU9pQW5kQ2NnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VGRYQndiSGt1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWgwYUdsekxuUnZkR0ZzVTNWd2NHeDVMblpoYkhWbExtNWhkR2wyWlNBdElHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSXRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCaWZBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QndkV0pzYVdNZ2RHOTBZV3hUZFhCd2JIa2dQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUakkxTmo0b2V5QnJaWGs2SUNkMEp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VGRYQndiSGt1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWgwYUdsekxuUnZkR0ZzVTNWd2NHeDVMblpoYkhWbExtNWhkR2wyWlNBdElHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1pXMXBkQ2duVW1Wa1pXVnRKeXdnYm1WM0lHRnlZekUxT1RSZmNtVmtaV1Z0WDJWMlpXNTBLSHNnWm5KdmJTd2dZVzF2ZFc1MExDQmtZWFJoSUgwcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNVGdnTHk4Z01IZ3dNRFF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeU15QXZMeUJ0WlhSb2IyUWdJbEpsWkdWbGJTZ29ZV1JrY21WemN5eDFhVzUwTWpVMkxHSjVkR1ZiWFNrcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LWVhKak1UVTVORjl5WldSbFpXMUdjbTl0WDJKdmIyeGZabUZzYzJWQU56b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUdGeVl6RTFPVFJmY21Wa1pXVnRSbkp2YlY5aWIyOXNYMjFsY21kbFFEZ0tDbUZ5WXpFMU9UUmZjbVZrWldWdFJuSnZiVjlpYjI5c1gyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJoY21NeE5UazBYM0psWkdWbGJVWnliMjFmWW05dmJGOXRaWEpuWlVBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvNlFYSmpNVFU1TkM1aGNtTXhOVGswWDNKbFpHVmxiU2hoYlc5MWJuUTZJR0o1ZEdWekxDQmtZWFJoT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWVhKak1UVTVORjl5WldSbFpXMDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPalUxTFRVMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnY0hWaWJHbGpJR0Z5WXpFMU9UUmZjbVZrWldWdEtHRnRiM1Z1ZERvZ1lYSmpOQzVWYVc1MFRqSTFOaXdnWkdGMFlUb2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z1kyOXVjM1FnWm5KdmJTQTlJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdZWE56WlhKMEtHRnRiM1Z1ZEM1dVlYUnBkbVVnUGlBd2Jpd2dKMmx1ZG1Gc2FXUmZZVzF2ZFc1MEp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0JpUGdvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUmZZVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklIQjFZbXhwWXlCaVlXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlpHUnlaWE56TENCVmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RpSnlCOUtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVlpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aVlXeGhibU5sY3lobWNtOXRLUzVsZUdsemRITWdKaVlnZEdocGN5NWlZV3hoYm1ObGN5aG1jbTl0S1M1MllXeDFaUzV1WVhScGRtVWdQajBnWVcxdmRXNTBMbTVoZEdsMlpTd2dKMmx1YzNWbVptbGphV1Z1ZEY5aVlXeGhibU5sSnlrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZWEpqTVRVNU5GOXlaV1JsWlcxZlltOXZiRjltWVd4elpVQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWo0OUNpQWdJQ0JpZWlCaGNtTXhOVGswWDNKbFpHVmxiVjlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwaGNtTXhOVGswWDNKbFpHVmxiVjlpYjI5c1gyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpWVd4aGJtTmxjeWhtY205dEtTNWxlR2x6ZEhNZ0ppWWdkR2hwY3k1aVlXeGhibU5sY3lobWNtOXRLUzUyWVd4MVpTNXVZWFJwZG1VZ1BqMGdZVzF2ZFc1MExtNWhkR2wyWlN3Z0oybHVjM1ZtWm1samFXVnVkRjlpWVd4aGJtTmxKeWtLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibk4xWm1acFkybGxiblJmWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnZEdocGN5NWlZV3hoYm1ObGN5aG1jbTl0S1M1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUk9NalUyS0hSb2FYTXVZbUZzWVc1alpYTW9abkp2YlNrdWRtRnNkV1V1Ym1GMGFYWmxJQzBnWVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkRzkwWVd4VGRYQndiSGtnUFNCSGJHOWlZV3hUZEdGMFpUeFZhVzUwVGpJMU5qNG9leUJyWlhrNklDZDBKeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkZOMWNIQnNlUzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5ST01qVTJLSFJvYVhNdWRHOTBZV3hUZFhCd2JIa3VkbUZzZFdVdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpMEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdKOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIQjFZbXhwWXlCMGIzUmhiRk4xY0hCc2VTQTlJRWRzYjJKaGJGTjBZWFJsUEZWcGJuUk9NalUyUGloN0lHdGxlVG9nSjNRbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkZOMWNIQnNlUzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5ST01qVTJLSFJvYVhNdWRHOTBZV3hUZFhCd2JIa3VkbUZzZFdVdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCbGJXbDBLQ2RTWldSbFpXMG5MQ0J1WlhjZ1lYSmpNVFU1TkY5eVpXUmxaVzFmWlhabGJuUW9leUJtY205dExDQmhiVzkxYm5Rc0lHUmhkR0VnZlNrcENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklERTRJQzh2SURCNE1EQTBNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01ESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTWpNZ0x5OGdiV1YwYUc5a0lDSlNaV1JsWlcwb0tHRmtaSEpsYzNNc2RXbHVkREkxTml4aWVYUmxXMTBwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDbUZ5WXpFMU9UUmZjbVZrWldWdFgySnZiMnhmWm1Gc2MyVkFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHRnlZekUxT1RSZmNtVmtaV1Z0WDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TlRrMExtRnNaMjh1ZEhNNk9rRnlZekUxT1RRdVlYSmpNVFU1TkY5MGNtRnVjMlpsY2w5M2FYUm9YMlJoZEdFb2RHODZJR0o1ZEdWekxDQmhiVzkxYm5RNklHSjVkR1Z6TENCa1lYUmhPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbUZ5WXpFMU9UUmZkSEpoYm5ObVpYSmZkMmwwYUY5a1lYUmhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem8yTmkwMk53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5UazBYM1J5WVc1elptVnlYM2RwZEdoZlpHRjBZU2gwYnpvZ1lYSmpOQzVCWkdSeVpYTnpMQ0JoYlc5MWJuUTZJR0Z5WXpRdVZXbHVkRTR5TlRZc0lHUmhkR0U2SUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6S1RvZ1lYSmpOQzVDYjI5c0lIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z1kyOXVjM1FnY21WeklEMGdkR2hwY3k1aGNtTXlNREJmZEhKaGJuTm1aWElvZEc4c0lHRnRiM1Z1ZENrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlHRnlZekl3TUY5MGNtRnVjMlpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvM01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbGN3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6bzZRWEpqTVRVNU5DNWhjbU14TlRrMFgzUnlZVzV6Wm1WeVgyWnliMjFmZDJsMGFGOWtZWFJoS0daeWIyMDZJR0o1ZEdWekxDQjBiem9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNc0lHUmhkR0U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVhKak1UVTVORjkwY21GdWMyWmxjbDltY205dFgzZHBkR2hmWkdGMFlUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZOelF0T0RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRVNU5GOTBjbUZ1YzJabGNsOW1jbTl0WDNkcGRHaGZaR0YwWVNnS0lDQWdJQzh2SUNBZ1puSnZiVG9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjBiem9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklHRnlZelF1VldsdWRFNHlOVFlzQ2lBZ0lDQXZMeUFnSUdSaGRHRTZJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpMQW9nSUNBZ0x5OGdLVG9nWVhKak5DNUNiMjlzSUhzS0lDQWdJSEJ5YjNSdklEUWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem80TVFvZ0lDQWdMeThnWTI5dWMzUWdjbVZ6SUQwZ2RHaHBjeTVoY21NeU1EQmZkSEpoYm5ObVpYSkdjbTl0S0daeWIyMHNJSFJ2TENCaGJXOTFiblFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUdGeVl6SXdNRjkwY21GdWMyWmxja1p5YjIwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TlRrMExtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklISmxkSFZ5YmlCeVpYTUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZPa0Z5WXpFMU9UUXVZWEpqTVRVNU5GOXBjMTlwYzNOMVlXSnNaU2dwSUMwK0lHSjVkR1Z6T2dwaGNtTXhOVGswWDJselgybHpjM1ZoWW14bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUxT1RSZmFYTnpkV0ZpYkdVZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrSnZiMncrS0hzZ2EyVjVPaUFuWVhKak1UVTVORjlwYzNNbklIMHBJQzh2SUZSeWRXVWdQU0JwYzNOMVlXSnNaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUwSUM4dklDSmhjbU14TlRrMFgybHpjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1aGNtTXhOVGswWDJsemMzVmhZbXhsTG5aaGJIVmxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPanBCY21NeE5ERXdMbUZ5WXpFME1UQmZZbUZzWVc1alpWOXZabDl3WVhKMGFYUnBiMjRvYUc5c1pHVnlPaUJpZVhSbGN5d2djR0Z5ZEdsMGFXOXVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbUZ5WXpFME1UQmZZbUZzWVc1alpWOXZabDl3WVhKMGFYUnBiMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pZNUxUY3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6RTBNVEJmWW1Gc1lXNWpaVjl2Wmw5d1lYSjBhWFJwYjI0b2FHOXNaR1Z5T2lCaGNtTTBMa0ZrWkhKbGMzTXNJSEJoY25ScGRHbHZiam9nWVhKak5DNUJaR1J5WlhOektUb2dZWEpqTkM1VmFXNTBUakkxTmlCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TnpFdE56UUtJQ0FnSUM4dklHTnZibk4wSUd0bGVTQTlJRzVsZHlCaGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTaDdDaUFnSUNBdkx5QWdJR2h2YkdSbGNqb2dhRzlzWkdWeUxBb2dJQ0FnTHk4Z0lDQndZWEowYVhScGIyNDZJSEJoY25ScGRHbHZiaXdLSUNBZ0lDOHZJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCd2RXSnNhV01nY0dGeWRHbDBhVzl1Y3lBOUlFSnZlRTFoY0R4aGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTd2dZWEpqTkM1VmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RoY21NeE5ERXdYM0FuSUgwcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKaGNtTXhOREV3WDNBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5CaGNuUnBkR2x2Ym5Nb2EyVjVLUzUyWVd4MVpRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPa0Z5WXpFME1UQXVZWEpqTWpBd1gzUnlZVzV6Wm1WeUtIUnZPaUJpZVhSbGN5d2dkbUZzZFdVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1lYSmpNakF3WDNSeVlXNXpabVZ5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvM09DMDNPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCdmRtVnljbWxrWlNCaGNtTXlNREJmZEhKaGJuTm1aWElvZEc4NklHRnlZelF1UVdSa2NtVnpjeXdnZG1Gc2RXVTZJR0Z5WXpRdVZXbHVkRTR5TlRZcE9pQmhjbU0wTGtKdmIyd2dld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qZ3hDaUFnSUNBdkx5QnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BMQW9nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPREF0T0RjS0lDQWdJQzh2SUhSb2FYTXVYM1J5WVc1elptVnlYM0JoY25ScGRHbHZiaWdLSUNBZ0lDOHZJQ0FnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3lncExBb2dJQ0FnTHk4Z0lDQjBieXdLSUNBZ0lDOHZJQ0FnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdwTEFvZ0lDQWdMeThnSUNCMllXeDFaU3dLSUNBZ0lDOHZJQ0FnYm1WM0lHRnlZelF1UkhsdVlXMXBZMEo1ZEdWektDa3NDaUFnSUNBdkx5QXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9LU3dLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPamd3TFRnM0NpQWdJQ0F2THlCMGFHbHpMbDkwY21GdWMyWmxjbDl3WVhKMGFYUnBiMjRvQ2lBZ0lDQXZMeUFnSUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tTd0tJQ0FnSUM4dklDQWdkRzhzQ2lBZ0lDQXZMeUFnSUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1N3S0lDQWdJQzh2SUNBZ2RtRnNkV1VzQ2lBZ0lDQXZMeUFnSUc1bGR5QmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5Z3BMQW9nSUNBZ0x5OGdLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJ1WlhjZ1lYSmpOQzVFZVc1aGJXbGpRbmwwWlhNb0tTd0tJQ0FnSUdKNWRHVmpJREV6SUM4dklEQjRNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvNE1DMDROd29nSUNBZ0x5OGdkR2hwY3k1ZmRISmhibk5tWlhKZmNHRnlkR2wwYVc5dUtBb2dJQ0FnTHk4Z0lDQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ2tzQ2lBZ0lDQXZMeUFnSUhSdkxBb2dJQ0FnTHk4Z0lDQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa3NDaUFnSUNBdkx5QWdJSFpoYkhWbExBb2dJQ0FnTHk4Z0lDQnVaWGNnWVhKak5DNUVlVzVoYldsalFubDBaWE1vS1N3S0lDQWdJQzh2SUNrS0lDQWdJR05oYkd4emRXSWdYM1J5WVc1elptVnlYM0JoY25ScGRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem80T0FvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVgzUnlZVzV6Wm1WeUtHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NJSFJ2TENCMllXeDFaU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjkwY21GdWMyWmxjZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem82UVhKak1UUXhNQzVoY21NeE5ERXdYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2Ymlod1lYSjBhWFJwYjI0NklHSjVkR1Z6TENCMGJ6b2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ1lubDBaWE1zSUdSaGRHRTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tZWEpqTVRReE1GOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2prekxUazVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6RTBNVEJmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dUtBb2dJQ0FnTHk4Z0lDQndZWEowYVhScGIyNDZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ2RHODZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCaGNtTTBMbFZwYm5ST01qVTJMQW9nSUNBZ0x5OGdJQ0JrWVhSaE9pQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5d0tJQ0FnSUM4dklDazZJR0Z5WXpRdVFXUmtjbVZ6Y3lCN0NpQWdJQ0J3Y205MGJ5QTBJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRBd0NpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSWdQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnYkdWMElISmxZMlZwZG1WeVVHRnlkR2wwYVc5dUlEMGdkR2hwY3k1ZmNtVmpaV2wyWlhKUVlYSjBhWFJwYjI0b2RHOHNJSEJoY25ScGRHbHZiaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCallXeHNjM1ZpSUY5eVpXTmxhWFpsY2xCaGNuUnBkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklIUm9hWE11WDNSeVlXNXpabVZ5WDNCaGNuUnBkR2x2YmloelpXNWtaWElzSUhCaGNuUnBkR2x2Yml3Z2RHOHNJSEpsWTJWcGRtVnlVR0Z5ZEdsMGFXOXVMQ0JoYlc5MWJuUXNJR1JoZEdFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdaR2xuSURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOTBjbUZ1YzJabGNsOXdZWEowYVhScGIyNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVEEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjbVZqWldsMlpYSlFZWEowYVhScGIyNEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPa0Z5WXpFME1UQXVZWEpqTVRReE1GOXdZWEowYVhScGIyNXpYMjltS0dodmJHUmxjam9nWW5sMFpYTXNJSEJoWjJVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1lYSmpNVFF4TUY5d1lYSjBhWFJwYjI1elgyOW1PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TURjdE1UQTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6RTBNVEJmY0dGeWRHbDBhVzl1YzE5dlppaG9iMnhrWlhJNklHRnlZelF1UVdSa2NtVnpjeXdnY0dGblpUb2dZWEpqTkM1VmFXNTBUalkwS1RvZ1lYSmpOQzVCWkdSeVpYTnpXMTBnZXdvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakV3T1FvZ0lDQWdMeThnWTI5dWMzUWdhMlY1SUQwZ2JtVjNJR0Z5WXpFME1UQmZTRzlzWkdsdVoxQmhjblJwZEdsdmJuTlFZV2RwYm1GMFpXUkxaWGtvZXlCb2IyeGtaWEk2SUdodmJHUmxjaXdnY0dGblpUb2djR0ZuWlNCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdhMlY1VUhKbFptbDRPaUFuWVhKak1UUXhNRjlvY0Y5aEp5d0tJQ0FnSUdKNWRHVmpJREUxSUM4dklDSmhjbU14TkRFd1gyaHdYMkVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE1UQUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NW9iMnhrWlhKUVlYSjBhWFJwYjI1elFXUmtjbVZ6YzJWektHdGxlU2t1WlhocGMzUnpLU0J5WlhSMWNtNGdXMTBLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHRnlZekUwTVRCZmNHRnlkR2wwYVc5dWMxOXZabDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpJREV6SUM4dklEQjRNREF3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncGhjbU14TkRFd1gzQmhjblJwZEdsdmJuTmZiMlpmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TVRFS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtaHZiR1JsY2xCaGNuUnBkR2x2Ym5OQlpHUnlaWE56WlhNb2EyVjVLUzUyWVd4MVpRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qcEJjbU14TkRFd0xtRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSW9hRzlzWkdWeU9pQmllWFJsY3l3Z2IzQmxjbUYwYjNJNklHSjVkR1Z6TENCd1lYSjBhWFJwYjI0NklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1lYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVEUwTFRFeE5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5ERXdYMmx6WDI5d1pYSmhkRzl5S0dodmJHUmxjam9nWVhKak5DNUJaR1J5WlhOekxDQnZjR1Z5WVhSdmNqb2dZWEpqTkM1QlpHUnlaWE56TENCd1lYSjBhWFJwYjI0NklHRnlZelF1UVdSa2NtVnpjeWs2SUdGeVl6UXVRbTl2YkNCN0NpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2RYQnVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRFMkNpQWdJQ0F2THlCcFppQW9iM0JsY21GMGIzSWdQVDA5SUdodmJHUmxjaWtnY21WMGRYSnVJRzVsZHlCaGNtTTBMa0p2YjJ3b2RISjFaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNBOVBRb2dJQ0FnWW5vZ1lYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnNE1Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbUZ5WXpFME1UQmZhWE5mYjNCbGNtRjBiM0pmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TVRjS0lDQWdJQzh2SUdOdmJuTjBJSE53WldOcFptbGpJRDBnYm1WM0lHRnlZekUwTVRCZlQzQmxjbUYwYjNKTFpYa29leUJvYjJ4a1pYSTZJR2h2YkdSbGNpd2diM0JsY21GMGIzSTZJRzl3WlhKaGRHOXlMQ0J3WVhKMGFYUnBiMjQ2SUhCaGNuUnBkR2x2YmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QndkV0pzYVdNZ2IzQmxjbUYwYjNKeklEMGdRbTk0VFdGd1BHRnlZekUwTVRCZlQzQmxjbUYwYjNKTFpYa3NJR0Z5WXpRdVFubDBaVDRvZXlCclpYbFFjbVZtYVhnNklDZGhjbU14TkRFd1gyOXdKeUI5S1NBdkx5QjJZV3gxWlNBOUlERWdZWFYwYUc5eWFYcGxaQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdJbUZ5WXpFME1UQmZiM0FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFeE9Bb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWIzQmxjbUYwYjNKektITndaV05wWm1saktTNWxlR2x6ZEhNZ0ppWWdkR2hwY3k1dmNHVnlZWFJ2Y25Nb2MzQmxZMmxtYVdNcExuWmhiSFZsTG01aGRHbDJaU0E5UFQwZ01Ta2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCaGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdKNklHRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXhPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJoY21NMExrSnZiMndvZEhKMVpTa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZzRNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ21GeVl6RTBNVEJmYVhOZmIzQmxjbUYwYjNKZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE1qRUtJQ0FnSUM4dklHTnZibk4wSUdkc2IySmhiRXRsZVNBOUlHNWxkeUJoY21NeE5ERXdYMDl3WlhKaGRHOXlTMlY1S0hzZ2FHOXNaR1Z5T2lCb2IyeGtaWElzSUc5d1pYSmhkRzl5T2lCdmNHVnlZWFJ2Y2l3Z2NHRnlkR2wwYVc5dU9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa2dmU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM0JsY21GMGIzSnpJRDBnUW05NFRXRndQR0Z5WXpFME1UQmZUM0JsY21GMGIzSkxaWGtzSUdGeVl6UXVRbmwwWlQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RoY21NeE5ERXdYMjl3SnlCOUtTQXZMeUIyWVd4MVpTQTlJREVnWVhWMGFHOXlhWHBsWkFvZ0lDQWdZbmwwWldNZ01UWWdMeThnSW1GeVl6RTBNVEJmYjNBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXlNZ29nSUNBZ0x5OGdhV1lnS0hSb2FYTXViM0JsY21GMGIzSnpLR2RzYjJKaGJFdGxlU2t1WlhocGMzUnpJQ1ltSUhSb2FYTXViM0JsY21GMGIzSnpLR2RzYjJKaGJFdGxlU2t1ZG1Gc2RXVXVibUYwYVhabElEMDlQU0F4S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJR0Z5WXpFME1UQmZhWE5mYjNCbGNtRjBiM0pmWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2w5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRJekNpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lHRnlZelF1UW05dmJDaDBjblZsS1FvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURnd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjbDloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakV5TlFvZ0lDQWdMeThnY21WMGRYSnVJRzVsZHlCaGNtTTBMa0p2YjJ3b1ptRnNjMlVwQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9rRnlZekUwTVRBdVlYSmpNVFF4TUY5aGRYUm9iM0pwZW1WZmIzQmxjbUYwYjNJb2FHOXNaR1Z5T2lCaWVYUmxjeXdnYjNCbGNtRjBiM0k2SUdKNWRHVnpMQ0J3WVhKMGFYUnBiMjQ2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoY21NeE5ERXdYMkYxZEdodmNtbDZaVjl2Y0dWeVlYUnZjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRJNExURXlPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOREV3WDJGMWRHaHZjbWw2WlY5dmNHVnlZWFJ2Y2lob2IyeGtaWEk2SUdGeVl6UXVRV1JrY21WemN5d2diM0JsY21GMGIzSTZJR0Z5WXpRdVFXUmtjbVZ6Y3l3Z2NHRnlkR2wwYVc5dU9pQmhjbU0wTGtGa1pISmxjM01wT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNekFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBJRDA5UFNCb2IyeGtaWElzSUNkUGJteDVJR2h2YkdSbGNpQmpZVzRnWVhWMGFHOXlhWHBsSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR2h2YkdSbGNpQmpZVzRnWVhWMGFHOXlhWHBsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFek1Rb2dJQ0FnTHk4Z1kyOXVjM1FnYTJWNUlEMGdibVYzSUdGeVl6RTBNVEJmVDNCbGNtRjBiM0pMWlhrb2V5Qm9iMnhrWlhJNklHaHZiR1JsY2l3Z2IzQmxjbUYwYjNJNklHOXdaWEpoZEc5eUxDQndZWEowYVhScGIyNDZJSEJoY25ScGRHbHZiaUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklIQjFZbXhwWXlCdmNHVnlZWFJ2Y25NZ1BTQkNiM2hOWVhBOFlYSmpNVFF4TUY5UGNHVnlZWFJ2Y2t0bGVTd2dZWEpqTkM1Q2VYUmxQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRnlZekUwTVRCZmIzQW5JSDBwSUM4dklIWmhiSFZsSUQwZ01TQmhkWFJvYjNKcGVtVmtDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlZWEpqTVRReE1GOXZjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE16SUtJQ0FnSUM4dklIUm9hWE11YjNCbGNtRjBiM0p6S0d0bGVTa3VkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNUNlWFJsS0RFcENpQWdJQ0JpZVhSbFl5QXhPU0F2THlBd2VEQXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pwQmNtTXhOREV3TG1GeVl6RTBNVEJmY21WMmIydGxYMjl3WlhKaGRHOXlLR2h2YkdSbGNqb2dZbmwwWlhNc0lHOXdaWEpoZEc5eU9pQmllWFJsY3l3Z2NHRnlkR2wwYVc5dU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1lYSmpNVFF4TUY5eVpYWnZhMlZmYjNCbGNtRjBiM0k2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFek5TMHhNellLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFF4TUY5eVpYWnZhMlZmYjNCbGNtRjBiM0lvYUc5c1pHVnlPaUJoY21NMExrRmtaSEpsYzNNc0lHOXdaWEpoZEc5eU9pQmhjbU0wTGtGa1pISmxjM01zSUhCaGNuUnBkR2x2YmpvZ1lYSmpOQzVCWkdSeVpYTnpLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UTTNDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQVDBnYUc5c1pHVnlMQ0FuVDI1c2VTQm9iMnhrWlhJZ1kyRnVJSEpsZG05clpTY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCb2IyeGtaWElnWTJGdUlISmxkbTlyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE16Z0tJQ0FnSUM4dklHTnZibk4wSUd0bGVTQTlJRzVsZHlCaGNtTXhOREV3WDA5d1pYSmhkRzl5UzJWNUtIc2dhRzlzWkdWeU9pQm9iMnhrWlhJc0lHOXdaWEpoZEc5eU9pQnZjR1Z5WVhSdmNpd2djR0Z5ZEdsMGFXOXVPaUJ3WVhKMGFYUnBiMjRnZlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QndkV0pzYVdNZ2IzQmxjbUYwYjNKeklEMGdRbTk0VFdGd1BHRnlZekUwTVRCZlQzQmxjbUYwYjNKTFpYa3NJR0Z5WXpRdVFubDBaVDRvZXlCclpYbFFjbVZtYVhnNklDZGhjbU14TkRFd1gyOXdKeUI5S1NBdkx5QjJZV3gxWlNBOUlERWdZWFYwYUc5eWFYcGxaQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdJbUZ5WXpFME1UQmZiM0FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE16a0tJQ0FnSUM4dklHbG1JQ2gwYUdsekxtOXdaWEpoZEc5eWN5aHJaWGtwTG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmhjbU14TkRFd1gzSmxkbTlyWlY5dmNHVnlZWFJ2Y2w5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRRd0NpQWdJQ0F2THlCMGFHbHpMbTl3WlhKaGRHOXljeWhyWlhrcExtUmxiR1YwWlNncENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NncGhjbU14TkRFd1gzSmxkbTlyWlY5dmNHVnlZWFJ2Y2w5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pwQmNtTXhOREV3TG1GeVl6RTBNVEJmYjNCbGNtRjBiM0pmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dUtHWnliMjA2SUdKNWRHVnpMQ0J3WVhKMGFYUnBiMjQ2SUdKNWRHVnpMQ0IwYnpvZ1lubDBaWE1zSUdGdGIzVnVkRG9nWW5sMFpYTXNJR1JoZEdFNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1lYSmpNVFF4TUY5dmNHVnlZWFJ2Y2w5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakUwTkMweE5URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1UUXhNRjl2Y0dWeVlYUnZjbDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI0b0NpQWdJQ0F2THlBZ0lHWnliMjA2SUdGeVl6UXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdjR0Z5ZEdsMGFXOXVPaUJoY21NMExrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIUnZPaUJoY21NMExrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1lYSmpOQzVWYVc1MFRqSTFOaXdLSUNBZ0lDOHZJQ0FnWkdGMFlUb2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTXNDaUFnSUNBdkx5QXBPaUJoY21NMExrRmtaSEpsYzNNZ2V3b2dJQ0FnY0hKdmRHOGdOU0F4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUdOdmJuTjBJSE5sYm1SbGNpQTlJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVFUwQ2lBZ0lDQXZMeUJzWlhRZ1lYVjBhRzl5YVhwbFpDQTlJSFJvYVhNdVlYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNpaG1jbTl0TENCelpXNWtaWElzSUhCaGNuUnBkR2x2YmlrdWJtRjBhWFpsSUQwOVBTQjBjblZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRVeUNpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSWdQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakUxTkFvZ0lDQWdMeThnYkdWMElHRjFkR2h2Y21sNlpXUWdQU0IwYUdsekxtRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSW9abkp2YlN3Z2MyVnVaR1Z5TENCd1lYSjBhWFJwYjI0cExtNWhkR2wyWlNBOVBUMGdkSEoxWlFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRTFOZ29nSUNBZ0x5OGdhV1lnS0NGaGRYUm9iM0pwZW1Wa0tTQjdDaUFnSUNCaWJub2dZWEpqTVRReE1GOXZjR1Z5WVhSdmNsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakUxT0FvZ0lDQWdMeThnWTI5dWMzUWdjRXRsZVNBOUlHNWxkeUJoY21NeE5ERXdYMDl3WlhKaGRHOXlVRzl5ZEdsdmJrdGxlU2g3SUdodmJHUmxjam9nWm5KdmJTd2diM0JsY21GMGIzSTZJSE5sYm1SbGNpd2djR0Z5ZEdsMGFXOXVJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCd2RXSnNhV01nYjNCbGNtRjBiM0pRYjNKMGFXOXVRV3hzYjNkaGJtTmxjeUE5SUVKdmVFMWhjRHhoY21NeE5ERXdYMDl3WlhKaGRHOXlVRzl5ZEdsdmJrdGxlU3dnWVhKak5DNVZhVzUwVGpJMU5qNG9leUJyWlhsUWNtVm1hWGc2SUNkaGNtTXhOREV3WDI5d1lTY2dmU2tLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0poY21NeE5ERXdYMjl3WVNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UVTVDaUFnSUNBdkx5QnBaaUFvZEdocGN5NXZjR1Z5WVhSdmNsQnZjblJwYjI1QmJHeHZkMkZ1WTJWektIQkxaWGtwTG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmhjbU14TkRFd1gyOXdaWEpoZEc5eVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVFl3Q2lBZ0lDQXZMeUJqYjI1emRDQnlaVzFoYVc1cGJtY2dQU0IwYUdsekxtOXdaWEpoZEc5eVVHOXlkR2x2YmtGc2JHOTNZVzVqWlhNb2NFdGxlU2t1ZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRTJNUW9nSUNBZ0x5OGdZWE56WlhKMEtISmxiV0ZwYm1sdVp5NXVZWFJwZG1VZ1BqMGdZVzF2ZFc1MExtNWhkR2wyWlN3Z0oxQnZjblJwYjI0Z1lXeHNiM2RoYm1ObElHVjRZMlZsWkdWa0p5a0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJRYjNKMGFXOXVJR0ZzYkc5M1lXNWpaU0JsZUdObFpXUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TmpJS0lDQWdJQzh2SUdGMWRHaHZjbWw2WldRZ1BTQjBjblZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakUyTlFvZ0lDQWdMeThnZEdocGN5NXZjR1Z5WVhSdmNsQnZjblJwYjI1QmJHeHZkMkZ1WTJWektIQkxaWGtwTG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1VldsdWRFNHlOVFlvY21WdFlXbHVhVzVuTG01aGRHbDJaU0F0SUdGdGIzVnVkQzV1WVhScGRtVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdJdENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbTk0WDNCMWRBb0tZWEpqTVRReE1GOXZjR1Z5WVhSdmNsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ013b0tZWEpqTVRReE1GOXZjR1Z5WVhSdmNsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVFk0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZWFYwYUc5eWFYcGxaQ3dnSjA1dmRDQmhkWFJvYjNKcGVtVmtJRzl3WlhKaGRHOXlKeWtLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9iM1FnWVhWMGFHOXlhWHBsWkNCdmNHVnlZWFJ2Y2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE5qa0tJQ0FnSUM4dklHeGxkQ0J5WldObGFYWmxjbEJoY25ScGRHbHZiaUE5SUhSb2FYTXVYM0psWTJWcGRtVnlVR0Z5ZEdsMGFXOXVLSFJ2TENCd1lYSjBhWFJwYjI0cENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZMkZzYkhOMVlpQmZjbVZqWldsMlpYSlFZWEowYVhScGIyNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVGN3Q2lBZ0lDQXZMeUIwYUdsekxsOTBjbUZ1YzJabGNsOXdZWEowYVhScGIyNG9abkp2YlN3Z2NHRnlkR2wwYVc5dUxDQjBieXdnY21WalpXbDJaWEpRWVhKMGFYUnBiMjRzSUdGdGIzVnVkQ3dnWkdGMFlTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1JwWnlBekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQmZkSEpoYm5ObVpYSmZjR0Z5ZEdsMGFXOXVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakUzTVFvZ0lDQWdMeThnY21WMGRYSnVJSEpsWTJWcGRtVnlVR0Z5ZEdsMGFXOXVDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPa0Z5WXpFME1UQXVZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dUtHWnliMjA2SUdKNWRHVnpMQ0J3WVhKMGFYUnBiMjQ2SUdKNWRHVnpMQ0IwYnpvZ1lubDBaWE1zSUdGdGIzVnVkRG9nWW5sMFpYTXNJR1JoZEdFNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1lYSmpNVFF4TUY5allXNWZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE56UXRNVGd4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUwTVRCZlkyRnVYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2YmlnS0lDQWdJQzh2SUNBZ1puSnZiVG9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQndZWEowYVhScGIyNDZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ2RHODZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCaGNtTTBMbFZwYm5ST01qVTJMQW9nSUNBZ0x5OGdJQ0JrWVhSaE9pQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5d0tJQ0FnSUM4dklDazZJR0Z5WXpFME1UQmZZMkZ1WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOXlaWFIxY200Z2V3b2dJQ0FnY0hKdmRHOGdOU0F4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lOVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5CaGNuUnBkR2x2Ym5Nb2JtVjNJR0Z5WXpFME1UQmZVR0Z5ZEdsMGFXOXVTMlY1S0hzZ2FHOXNaR1Z5T2lCb2IyeGtaWElzSUhCaGNuUnBkR2x2YmpvZ2NHRnlkR2wwYVc5dUlIMHBLUzVsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSEIxWW14cFl5QndZWEowYVhScGIyNXpJRDBnUW05NFRXRndQR0Z5WXpFME1UQmZVR0Z5ZEdsMGFXOXVTMlY1TENCaGNtTTBMbFZwYm5ST01qVTJQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRnlZekUwTVRCZmNDY2dmU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUZ5WXpFME1UQmZjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJMU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjR0Z5ZEdsMGFXOXVjeWh1WlhjZ1lYSmpNVFF4TUY5UVlYSjBhWFJwYjI1TFpYa29leUJvYjJ4a1pYSTZJR2h2YkdSbGNpd2djR0Z5ZEdsMGFXOXVPaUJ3WVhKMGFYUnBiMjRnZlNrcExtVjRhWE4wY3dvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakU0TWdvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TGw5MllXeHBaRkJoY25ScGRHbHZiaWhtY205dExDQndZWEowYVhScGIyNHBLU0I3Q2lBZ0lDQmlibm9nWVhKak1UUXhNRjlqWVc1ZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hPRE10TVRnM0NpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lHRnlZekUwTVRCZlkyRnVYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2Ymw5eVpYUjFjbTRvZXdvZ0lDQWdMeThnSUNCamIyUmxPaUJ1WlhjZ1lYSmpOQzVDZVhSbEtEQjROVEFwTEFvZ0lDQWdMeThnSUNCemRHRjBkWE02SUc1bGR5QmhjbU0wTGxOMGNpZ25VR0Z5ZEdsMGFXOXVJRzV2ZENCbGVHbHpkSE1uS1N3S0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhKUVlYSjBhWFJwYjI0NklHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tTd0tJQ0FnSUM4dklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVE15S0V0QlFVTkhRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkxSa0ZaVEZOUFVsVllTVEpNVUU1WlVVYzBNek5WUlVKVFdGRXlURlJQVWxwUktRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbUZ5WXpFME1UQmZZMkZ1WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRTVNQW9nSUNBZ0x5OGdkR2hwY3k1d1lYSjBhWFJwYjI1ektHNWxkeUJoY21NeE5ERXdYMUJoY25ScGRHbHZia3RsZVNoN0lHaHZiR1JsY2pvZ1puSnZiU3dnY0dGeWRHbDBhVzl1T2lCd1lYSjBhWFJwYjI0Z2ZTa3BMblpoYkhWbExtNWhkR2wyWlNBOElHRnRiM1Z1ZEM1dVlYUnBkbVVLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaVBBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hPRGt0TVRreENpQWdJQ0F2THlCcFppQW9DaUFnSUNBdkx5QWdJSFJvYVhNdWNHRnlkR2wwYVc5dWN5aHVaWGNnWVhKak1UUXhNRjlRWVhKMGFYUnBiMjVMWlhrb2V5Qm9iMnhrWlhJNklHWnliMjBzSUhCaGNuUnBkR2x2YmpvZ2NHRnlkR2wwYVc5dUlIMHBLUzUyWVd4MVpTNXVZWFJwZG1VZ1BDQmhiVzkxYm5RdWJtRjBhWFpsQ2lBZ0lDQXZMeUFwSUhzS0lDQWdJR0o2SUdGeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVGt5TFRFNU5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZmNtVjBkWEp1S0hzS0lDQWdJQzh2SUNBZ1kyOWtaVG9nYm1WM0lHRnlZelF1UW5sMFpTZ3dlRFV5S1N3S0lDQWdJQzh2SUNBZ2MzUmhkSFZ6T2lCdVpYY2dZWEpqTkM1VGRISW9KMGx1YzNWbVptbGphV1Z1ZENCaVlXeGhibU5sSnlrc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeVVHRnlkR2wwYVc5dU9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa3NDaUFnSUNBdkx5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklHSmhjMlV6TWloTFNVRkRSMEZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJTMFZUTTFSVVQxWlVSMDB5VEVST1JsTlhORFZDUVUxS1VWZFpXVXhQVFU1VFVTa0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BoY21NeE5ERXdYMk5oYmw5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hPVGtLSUNBZ0lDOHZJR2xtSUNoMGJ5QTlQVDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdwS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQTlQUW9nSUNBZ1lub2dZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU1EQXRNakEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUdGeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDl5WlhSMWNtNG9ld29nSUNBZ0x5OGdJQ0JqYjJSbE9pQnVaWGNnWVhKak5DNUNlWFJsS0RCNE5UY3BMQW9nSUNBZ0x5OGdJQ0J6ZEdGMGRYTTZJRzVsZHlCaGNtTTBMbE4wY2lnblNXNTJZV3hwWkNCeVpXTmxhWFpsY2ljcExBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNsQmhjblJwZEdsdmJqb2dibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QmlZWE5sTXpJb1N6UkJRMGRCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVWxGVXpOVVYwMUdWMGRUV2tKQlQwcFRWMGRhVEVwUFdsTllSU2tLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwaGNtTXhOREV3WDJOaGJsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TURnS0lDQWdJQzh2SUdOdmJuTjBJSE5sYm1SbGNrRmtaSElnUFNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TURrS0lDQWdJQzh2SUdsbUlDaHpaVzVrWlhKQlpHUnlJQ0U5UFNCbWNtOXRLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lDRTlDaUFnSUNCaWVpQmhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU1UQUtJQ0FnSUM4dklHeGxkQ0JoZFhSb2IzSnBlbVZrSUQwZ2RHaHBjeTVoY21NeE5ERXdYMmx6WDI5d1pYSmhkRzl5S0daeWIyMHNJSE5sYm1SbGNrRmtaSElzSUhCaGNuUnBkR2x2YmlrdWJtRjBhWFpsSUQwOVBTQjBjblZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOaGJHeHpkV0lnWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qRXhDaUFnSUNBdkx5QnBaaUFvSVdGMWRHaHZjbWw2WldRcElIc0tJQ0FnSUdKdWVpQmhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU1USUtJQ0FnSUM4dklHTnZibk4wSUhCTFpYa2dQU0J1WlhjZ1lYSmpNVFF4TUY5UGNHVnlZWFJ2Y2xCdmNuUnBiMjVMWlhrb2V5Qm9iMnhrWlhJNklHWnliMjBzSUc5d1pYSmhkRzl5T2lCelpXNWtaWEpCWkdSeUxDQndZWEowYVhScGIyNGdmU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUhCMVlteHBZeUJ2Y0dWeVlYUnZjbEJ2Y25ScGIyNUJiR3h2ZDJGdVkyVnpJRDBnUW05NFRXRndQR0Z5WXpFME1UQmZUM0JsY21GMGIzSlFiM0owYVc5dVMyVjVMQ0JoY21NMExsVnBiblJPTWpVMlBpaDdJR3RsZVZCeVpXWnBlRG9nSjJGeVl6RTBNVEJmYjNCaEp5QjlLUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbUZ5WXpFME1UQmZiM0JoSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU1UTUtJQ0FnSUM4dklHbG1JQ2gwYUdsekxtOXdaWEpoZEc5eVVHOXlkR2x2YmtGc2JHOTNZVzVqWlhNb2NFdGxlU2t1WlhocGMzUnpLU0I3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJR0o2SUdGeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFERXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakl4TkFvZ0lDQWdMeThnWTI5dWMzUWdjbVZ0WVdsdWFXNW5JRDBnZEdocGN5NXZjR1Z5WVhSdmNsQnZjblJwYjI1QmJHeHZkMkZ1WTJWektIQkxaWGtwTG5aaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNakUxQ2lBZ0lDQXZMeUJwWmlBb2NtVnRZV2x1YVc1bkxtNWhkR2wyWlNBK1BTQmhiVzkxYm5RdWJtRjBhWFpsS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0krUFFvZ0lDQWdZbm9nWVhKak1UUXhNRjlqWVc1ZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNakUyQ2lBZ0lDQXZMeUJoZFhSb2IzSnBlbVZrSUQwZ2RISjFaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb0tZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFNkNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdabkpoYldWZlluVnllU0F6Q2dwaGNtTXhOREV3WDJOaGJsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXhNem9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakl5TUFvZ0lDQWdMeThnYVdZZ0tDRmhkWFJvYjNKcGVtVmtLU0I3Q2lBZ0lDQmlibm9nWVhKak1UUXhNRjlqWVc1ZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNakl4TFRJeU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZmNtVjBkWEp1S0hzS0lDQWdJQzh2SUNBZ1kyOWtaVG9nYm1WM0lHRnlZelF1UW5sMFpTZ3dlRFU0S1N3S0lDQWdJQzh2SUNBZ2MzUmhkSFZ6T2lCdVpYY2dZWEpqTkM1VGRISW9KMDl3WlhKaGRHOXlJRzV2ZENCaGRYUm9iM0pwZW1Wa0p5a3NDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlVR0Z5ZEdsMGFXOXVPaUJ1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ2tzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVek1paE1RVUZEUjBGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCVEZVMk5FUkdUMHBSV0Vrek0xTkZRbGhITmpWQ1FVMUdNbGhKTWtSUVQwcFZXRlZhVEVVcENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSXlPUW9nSUNBZ0x5OGdiR1YwSUhKbFkyVnBkbVZ5VUdGeWRHbDBhVzl1SUQwZ2RHaHBjeTVmY21WalpXbDJaWEpRWVhKMGFYUnBiMjRvZEc4c0lIQmhjblJwZEdsdmJpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqWVd4c2MzVmlJRjl5WldObGFYWmxjbEJoY25ScGRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TXpFdE1qTTFDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJR0Z5WXpFME1UQmZZMkZ1WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOXlaWFIxY200b2V3b2dJQ0FnTHk4Z0lDQmpiMlJsT2lCdVpYY2dZWEpqTkM1Q2VYUmxLREI0TlRFcExBb2dJQ0FnTHk4Z0lDQnpkR0YwZFhNNklHNWxkeUJoY21NMExsTjBjaWduVTNWalkyVnpjeWNwTEFvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2xCaGNuUnBkR2x2YmpvZ2NtVmpaV2wyWlhKUVlYSjBhWFJwYjI0c0NpQWdJQ0F2THlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5URXdNREl6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qTXpDaUFnSUNBdkx5QnpkR0YwZFhNNklHNWxkeUJoY21NMExsTjBjaWduVTNWalkyVnpjeWNwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd056VXpOelUyTXpZek5qVTNNemN6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJek1TMHlNelVLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnWVhKak1UUXhNRjlqWVc1ZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVYM0psZEhWeWJpaDdDaUFnSUNBdkx5QWdJR052WkdVNklHNWxkeUJoY21NMExrSjVkR1VvTUhnMU1Ta3NDaUFnSUNBdkx5QWdJSE4wWVhSMWN6b2dibVYzSUdGeVl6UXVVM1J5S0NkVGRXTmpaWE56Snlrc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeVVHRnlkR2wwYVc5dU9pQnlaV05sYVhabGNsQmhjblJwZEdsdmJpd0tJQ0FnSUM4dklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem82UVhKak1UUXhNQzVmY21WalpXbDJaWEpRWVhKMGFYUnBiMjRvY21WalpXbDJaWEk2SUdKNWRHVnpMQ0J3WVhKMGFYUnBiMjQ2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWDNKbFkyVnBkbVZ5VUdGeWRHbDBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU5ETUtJQ0FnSUM4dklIQnliM1JsWTNSbFpDQmZjbVZqWldsMlpYSlFZWEowYVhScGIyNG9jbVZqWldsMlpYSTZJR0Z5WXpRdVFXUmtjbVZ6Y3l3Z2NHRnlkR2wwYVc5dU9pQmhjbU0wTGtGa1pISmxjM01wT2lCaGNtTTBMa0ZrWkhKbGMzTWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTBOQW9nSUNBZ0x5OGdiR1YwSUhKbFkyVnBkbVZ5VUdGeWRHbDBhVzl1SUQwZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3lncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU5EVUtJQ0FnSUM4dklHbG1JQ2gwYUdsekxuQmhjblJwZEdsdmJuTW9ibVYzSUdGeVl6RTBNVEJmVUdGeWRHbDBhVzl1UzJWNUtIc2dhRzlzWkdWeU9pQnlaV05sYVhabGNpd2djR0Z5ZEdsMGFXOXVPaUJ3WVhKMGFYUnBiMjRnZlNrcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdjSFZpYkdsaklIQmhjblJwZEdsdmJuTWdQU0JDYjNoTllYQThZWEpqTVRReE1GOVFZWEowYVhScGIyNUxaWGtzSUdGeVl6UXVWV2x1ZEU0eU5UWStLSHNnYTJWNVVISmxabWw0T2lBbllYSmpNVFF4TUY5d0p5QjlLUW9nSUNBZ1lubDBaV01nTmlBdkx5QWlZWEpqTVRReE1GOXdJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJME5Rb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWNHRnlkR2wwYVc5dWN5aHVaWGNnWVhKak1UUXhNRjlRWVhKMGFYUnBiMjVMWlhrb2V5Qm9iMnhrWlhJNklISmxZMlZwZG1WeUxDQndZWEowYVhScGIyNDZJSEJoY25ScGRHbHZiaUI5S1NrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJRjl5WldObGFYWmxjbEJoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NncGZjbVZqWldsMlpYSlFZWEowYVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lORGdLSUNBZ0lDOHZJSEpsZEhWeWJpQnlaV05sYVhabGNsQmhjblJwZEdsdmJnb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9rRnlZekUwTVRBdVgyRmtaRjl3WVhKMGFXTnBjR0YwYVc5dVgzUnZYMmh2YkdSbGNpaG9iMnhrWlhJNklHSjVkR1Z6TENCd1lYSjBhV05wY0dGMGFXOXVPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tYMkZrWkY5d1lYSjBhV05wY0dGMGFXOXVYM1J2WDJodmJHUmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TWpZMENpQWdJQ0F2THlCd2NtOTBaV04wWldRZ1gyRmtaRjl3WVhKMGFXTnBjR0YwYVc5dVgzUnZYMmh2YkdSbGNpaG9iMnhrWlhJNklHRnlZelF1UVdSa2NtVnpjeXdnY0dGeWRHbGphWEJoZEdsdmJqb2dZWEpqTkM1QlpHUnlaWE56S1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrZFhCdUlEUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnWkhWd2JpQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhRzlzWkdWeVVHRnlkR2wwYVc5dWMwTjFjbkpsYm5SUVlXZGxJRDBnUW05NFRXRndQR0Z5WXpRdVFXUmtjbVZ6Y3l3Z1lYSmpOQzVWYVc1MFRqWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRnlZekUwTVRCZmFIQmZjQ2NnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWVhKak1UUXhNRjlvY0Y5d0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lOallLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTVvYjJ4a1pYSlFZWEowYVhScGIyNXpRM1Z5Y21WdWRGQmhaMlVvYUc5c1pHVnlLUzVsZUdsemRITXBJSHNLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklGOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTJOd29nSUNBZ0x5OGdkR2hwY3k1b2IyeGtaWEpRWVhKMGFYUnBiMjV6UTNWeWNtVnVkRkJoWjJVb2FHOXNaR1Z5S1M1MllXeDFaU0E5SUhCaFoyVUtJQ0FnSUdaeVlXMWxYMlJwWnlBeE1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lOalVLSUNBZ0lDOHZJR3hsZENCd1lXZGxJRDBnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1FvZ0lDQWdZbmwwWldNZ01qUWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJMk53b2dJQ0FnTHk4Z2RHaHBjeTVvYjJ4a1pYSlFZWEowYVhScGIyNXpRM1Z5Y21WdWRGQmhaMlVvYUc5c1pHVnlLUzUyWVd4MVpTQTlJSEJoWjJVS0lDQWdJR0p2ZUY5d2RYUUtDbDloWkdSZmNHRnlkR2xqYVhCaGRHbHZibDkwYjE5b2IyeGtaWEpmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TmprS0lDQWdJQzh2SUdOdmJuTjBJR3hoYzNSUVlXZGxJRDBnZEdocGN5NW9iMnhrWlhKUVlYSjBhWFJwYjI1elEzVnljbVZ1ZEZCaFoyVW9hRzlzWkdWeUtTNTJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JREV3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJM01Bb2dJQ0FnTHk4Z2JHVjBJR1p2ZFc1a0lEMGdabUZzYzJVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TWpZMUNpQWdJQ0F2THlCc1pYUWdjR0ZuWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTmpRb01Da0tJQ0FnSUdKNWRHVmpJREkwSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lOekVLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR04xY2xCaFoyVWdQU0J3WVdkbE95QmpkWEpRWVdkbExtNWhkR2wyWlNBOElHeGhjM1JRWVdkbExtNWhkR2wyWlRzZ1kzVnlVR0ZuWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTmpRb1kzVnlVR0ZuWlM1dVlYUnBkbVVnS3lBeEtTa2dld29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDZ3BmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5WDNkb2FXeGxYM1J2Y0VBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lOekVLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR04xY2xCaFoyVWdQU0J3WVdkbE95QmpkWEpRWVdkbExtNWhkR2wyWlNBOElHeGhjM1JRWVdkbExtNWhkR2wyWlRzZ1kzVnlVR0ZuWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTmpRb1kzVnlVR0ZuWlM1dVlYUnBkbVVnS3lBeEtTa2dld29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBNENpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGtLSUNBZ0lEd0tJQ0FnSUdKNklGOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZZbXh2WTJ0QU1UQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNamN5TFRJM05Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0dGbmFXNWhkR1ZrUzJWNUlEMGdibVYzSUdGeVl6RTBNVEJmU0c5c1pHbHVaMUJoY25ScGRHbHZibk5RWVdkcGJtRjBaV1JMWlhrb2V3b2dJQ0FnTHk4Z0lDQm9iMnhrWlhJNklHaHZiR1JsY2l3S0lDQWdJQzh2SUNBZ2NHRm5aVG9nWTNWeVVHRm5aU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUd0bGVWQnlaV1pwZURvZ0oyRnlZekUwTVRCZmFIQmZZU2NzQ2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpWVhKak1UUXhNRjlvY0Y5aElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lOellLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTVvYjJ4a1pYSlFZWEowYVhScGIyNXpRV1JrY21WemMyVnpLSEJoWjJsdVlYUmxaRXRsZVNrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TnpjS0lDQWdJQzh2SUhSb2FYTXVhRzlzWkdWeVVHRnlkR2wwYVc5dWMwRmtaSEpsYzNObGN5aHdZV2RwYm1GMFpXUkxaWGtwTG5aaGJIVmxJRDBnVzNCaGNuUnBZMmx3WVhScGIyNWRDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QXdlREF3TURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtDbDloWkdSZmNHRnlkR2xqYVhCaGRHbHZibDkwYjE5b2IyeGtaWEpmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95T0RBS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG1OdmJuUmhhVzV6UVdSa2NtVnpjeWgwYUdsekxtaHZiR1JsY2xCaGNuUnBkR2x2Ym5OQlpHUnlaWE56WlhNb2NHRm5hVzVoZEdWa1MyVjVLUzUyWVd4MVpTd2djR0Z5ZEdsamFYQmhkR2x2YmlrcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNalUwQ2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUhZZ2IyWWdZU2tnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEY0tDbDloWkdSZmNHRnlkR2xqYVhCaGRHbHZibDkwYjE5b2IyeGtaWEpmWm05eVgyaGxZV1JsY2tBeE56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNalUwQ2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUhZZ2IyWWdZU2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JRGNLSUNBZ0lHWnlZVzFsWDJScFp5QTFDaUFnSUNBOENpQWdJQ0JpZWlCZllXUmtYM0JoY25ScFkybHdZWFJwYjI1ZmRHOWZhRzlzWkdWeVgyRm1kR1Z5WDJadmNrQXlNUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTndvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TlRVS0lDQWdJQzh2SUdsbUlDaDJJRDA5UFNCNEtTQnlaWFIxY200Z2RISjFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWW5vZ1gyRmtaRjl3WVhKMGFXTnBjR0YwYVc5dVgzUnZYMmh2YkdSbGNsOWhablJsY2w5cFpsOWxiSE5sUURJd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvS1gyRmtaRjl3WVhKMGFXTnBjR0YwYVc5dVgzUnZYMmh2YkdSbGNsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9rRnlZekUwTVRBdVkyOXVkR0ZwYm5OQlpHUnlaWE56UURJeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lPREFLSUNBZ0lDOHZJR2xtSUNoMGFHbHpMbU52Ym5SaGFXNXpRV1JrY21WemN5aDBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5CWkdSeVpYTnpaWE1vY0dGbmFXNWhkR1ZrUzJWNUtTNTJZV3gxWlN3Z2NHRnlkR2xqYVhCaGRHbHZiaWtwSUhzS0lDQWdJR0o2SUY5aFpHUmZjR0Z5ZEdsamFYQmhkR2x2Ymw5MGIxOW9iMnhrWlhKZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJNE1Rb2dJQ0FnTHk4Z1ptOTFibVFnUFNCMGNuVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMkNncGZZV1JrWDNCaGNuUnBZMmx3WVhScGIyNWZkRzlmYUc5c1pHVnlYMkpzYjJOclFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95T0RVS0lDQWdJQzh2SUdsbUlDZ2habTkxYm1RcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBMkNpQWdJQ0JpYm5vZ1gyRmtaRjl3WVhKMGFXTnBjR0YwYVc5dVgzUnZYMmh2YkdSbGNsOWhablJsY2w5cFpsOWxiSE5sUURFMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTROaTB5T0RrS0lDQWdJQzh2SUdOdmJuTjBJSEJoWjJsdVlYUmxaRXRsZVNBOUlHNWxkeUJoY21NeE5ERXdYMGh2YkdScGJtZFFZWEowYVhScGIyNXpVR0ZuYVc1aGRHVmtTMlY1S0hzS0lDQWdJQzh2SUNBZ2FHOXNaR1Z5T2lCb2IyeGtaWElzQ2lBZ0lDQXZMeUFnSUhCaFoyVTZJR3hoYzNSUVlXZGxMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnYTJWNVVISmxabWw0T2lBbllYSmpNVFF4TUY5b2NGOWhKeXdLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0poY21NeE5ERXdYMmh3WDJFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTVNQW9nSUNBZ0x5OGdZMjl1YzNRZ2FYUmxiWE5EYjNWdWRDQTlJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9kR2hwY3k1b2IyeGtaWEpRWVhKMGFYUnBiMjV6UVdSa2NtVnpjMlZ6S0hCaFoybHVZWFJsWkV0bGVTa3VkbUZzZFdVdWJHVnVaM1JvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU9URUtJQ0FnSUM4dklHbG1JQ2hwZEdWdGMwTnZkVzUwTG01aGRHbDJaU0E4SURFd0tTQjdDaUFnSUNCaWRHOXBDaUFnSUNCd2RYTm9hVzUwSURFd0lDOHZJREV3Q2lBZ0lDQThDaUFnSUNCaWVpQmZZV1JrWDNCaGNuUnBZMmx3WVhScGIyNWZkRzlmYUc5c1pHVnlYMlZzYzJWZlltOWtlVUF4TXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU9UUUtJQ0FnSUM4dklDNHVMblJvYVhNdWFHOXNaR1Z5VUdGeWRHbDBhVzl1YzBGa1pISmxjM05sY3lod1lXZHBibUYwWldSTFpYa3BMblpoYkhWbExBb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qa3pMVEk1TmdvZ0lDQWdMeThnZEdocGN5NW9iMnhrWlhKUVlYSjBhWFJwYjI1elFXUmtjbVZ6YzJWektIQmhaMmx1WVhSbFpFdGxlU2t1ZG1Gc2RXVWdQU0JiQ2lBZ0lDQXZMeUFnSUM0dUxuUm9hWE11YUc5c1pHVnlVR0Z5ZEdsMGFXOXVjMEZrWkhKbGMzTmxjeWh3WVdkcGJtRjBaV1JMWlhrcExuWmhiSFZsTEFvZ0lDQWdMeThnSUNCd1lYSjBhV05wY0dGMGFXOXVMQW9nSUNBZ0x5OGdYUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNamsxQ2lBZ0lDQXZMeUJ3WVhKMGFXTnBjR0YwYVc5dUxBb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z01IZ3dNREF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU9UTXRNamsyQ2lBZ0lDQXZMeUIwYUdsekxtaHZiR1JsY2xCaGNuUnBkR2x2Ym5OQlpHUnlaWE56WlhNb2NHRm5hVzVoZEdWa1MyVjVLUzUyWVd4MVpTQTlJRnNLSUNBZ0lDOHZJQ0FnTGk0dWRHaHBjeTVvYjJ4a1pYSlFZWEowYVhScGIyNXpRV1JrY21WemMyVnpLSEJoWjJsdVlYUmxaRXRsZVNrdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUhCaGNuUnBZMmx3WVhScGIyNHNDaUFnSUNBdkx5QmRDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0F2Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDZ3BmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFU2Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZaV3h6WlY5aWIyUjVRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU9UZ0tJQ0FnSUM4dklHTnZibk4wSUc1bGQweGhjM1JRWVdkbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaHNZWE4wVUdGblpTNXVZWFJwZG1VZ0t5QXhLUW9nSUNBZ1puSmhiV1ZmWkdsbklEa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJNU9Rb2dJQ0FnTHk4Z2RHaHBjeTVvYjJ4a1pYSlFZWEowYVhScGIyNXpRM1Z5Y21WdWRGQmhaMlVvYUc5c1pHVnlLUzUyWVd4MVpTQTlJRzVsZDB4aGMzUlFZV2RsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTXdNQzB6TURNS0lDQWdJQzh2SUdOdmJuTjBJRzVsZDFCaFoybHVZWFJsWkV0bGVTQTlJRzVsZHlCaGNtTXhOREV3WDBodmJHUnBibWRRWVhKMGFYUnBiMjV6VUdGbmFXNWhkR1ZrUzJWNUtIc0tJQ0FnSUM4dklDQWdhRzlzWkdWeU9pQm9iMnhrWlhJc0NpQWdJQ0F2THlBZ0lIQmhaMlU2SUc1bGQweGhjM1JRWVdkbExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak13TkFvZ0lDQWdMeThnZEdocGN5NW9iMnhrWlhKUVlYSjBhWFJwYjI1elFXUmtjbVZ6YzJWektHNWxkMUJoWjJsdVlYUmxaRXRsZVNrdWRtRnNkV1VnUFNCYmNHRnlkR2xqYVhCaGRHbHZibDBLSUNBZ0lHSjVkR1ZqSURJd0lDOHZJREI0TURBd01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJR3RsZVZCeVpXWnBlRG9nSjJGeVl6RTBNVEJmYUhCZllTY3NDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWlZWEpqTVRReE1GOW9jRjloSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXpBMENpQWdJQ0F2THlCMGFHbHpMbWh2YkdSbGNsQmhjblJwZEdsdmJuTkJaR1J5WlhOelpYTW9ibVYzVUdGbmFXNWhkR1ZrUzJWNUtTNTJZV3gxWlNBOUlGdHdZWEowYVdOcGNHRjBhVzl1WFFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LWDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2w5aFpuUmxjbDlwWmw5bGJITmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJM01Rb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ1kzVnlVR0ZuWlNBOUlIQmhaMlU3SUdOMWNsQmhaMlV1Ym1GMGFYWmxJRHdnYkdGemRGQmhaMlV1Ym1GMGFYWmxPeUJqZFhKUVlXZGxJRDBnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hqZFhKUVlXZGxMbTVoZEdsMlpTQXJJREVwS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnT0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCZllXUmtYM0JoY25ScFkybHdZWFJwYjI1ZmRHOWZhRzlzWkdWeVgzZG9hV3hsWDNSdmNFQXpDZ3BmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFNakE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTndvZ0lDQWdZaUJmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5WDJadmNsOW9aV0ZrWlhKQU1UY0tDbDloWkdSZmNHRnlkR2xqYVhCaGRHbHZibDkwYjE5b2IyeGtaWEpmWVdaMFpYSmZabTl5UURJeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lOVGNLSUNBZ0lDOHZJSEpsZEhWeWJpQm1ZV3h6WlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TWpnd0NpQWdJQ0F2THlCcFppQW9kR2hwY3k1amIyNTBZV2x1YzBGa1pISmxjM01vZEdocGN5NW9iMnhrWlhKUVlYSjBhWFJwYjI1elFXUmtjbVZ6YzJWektIQmhaMmx1WVhSbFpFdGxlU2t1ZG1Gc2RXVXNJSEJoY25ScFkybHdZWFJwYjI0cEtTQjdDaUFnSUNCaUlGOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qcEJjbU14TkRFd0xtTnZiblJoYVc1elFXUmtjbVZ6YzBBeU1nb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9rRnlZekUwTVRBdVgzUnlZVzV6Wm1WeVgzQmhjblJwZEdsdmJpaG1jbTl0T2lCaWVYUmxjeXdnWm5KdmJWQmhjblJwZEdsdmJqb2dZbmwwWlhNc0lIUnZPaUJpZVhSbGN5d2dkRzlRWVhKMGFYUnBiMjQ2SUdKNWRHVnpMQ0JoYlc5MWJuUTZJR0o1ZEdWekxDQmtZWFJoT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWDNSeVlXNXpabVZ5WDNCaGNuUnBkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16RTRMVE15TlFvZ0lDQWdMeThnY0hKdmRHVmpkR1ZrSUY5MGNtRnVjMlpsY2w5d1lYSjBhWFJwYjI0b0NpQWdJQ0F2THlBZ0lHWnliMjA2SUdGeVl6UXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdabkp2YlZCaGNuUnBkR2x2YmpvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0IwYnpvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0IwYjFCaGNuUnBkR2x2YmpvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJR0Z5WXpRdVZXbHVkRTR5TlRZc0NpQWdJQ0F2THlBZ0lHUmhkR0U2SUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6TEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBMklEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16STJDaUFnSUNBdkx5QmhjM05sY25Rb1lXMXZkVzUwTG01aGRHbDJaU0ErSURBc0lDZEpiblpoYkdsa0lHRnRiM1Z1ZENjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lHRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek1qZ0tJQ0FnSUM4dklHTnZibk4wSUdaeWIyMUxaWGtnUFNCdVpYY2dZWEpqTVRReE1GOVFZWEowYVhScGIyNUxaWGtvZXlCb2IyeGtaWEk2SUdaeWIyMHNJSEJoY25ScGRHbHZiam9nWm5KdmJWQmhjblJwZEdsdmJpQjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnY0hWaWJHbGpJSEJoY25ScGRHbHZibk1nUFNCQ2IzaE5ZWEE4WVhKak1UUXhNRjlRWVhKMGFYUnBiMjVMWlhrc0lHRnlZelF1VldsdWRFNHlOVFkrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOXdKeUI5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWVhKak1UUXhNRjl3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16STVDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXVjR0Z5ZEdsMGFXOXVjeWhtY205dFMyVjVLUzVsZUdsemRITXBJSHNLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklGOTBjbUZ1YzJabGNsOXdZWEowYVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTXpNQW9nSUNBZ0x5OGdkR2hwY3k1d1lYSjBhWFJwYjI1ektHWnliMjFMWlhrcExuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTR5TlRZb01Da0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW05NFgzQjFkQW9LWDNSeVlXNXpabVZ5WDNCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNek1nb2dJQ0FnTHk4Z2RHaHBjeTV3WVhKMGFYUnBiMjV6S0daeWIyMUxaWGtwTG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1VldsdWRFNHlOVFlvZEdocGN5NXdZWEowYVhScGIyNXpLR1p5YjIxTFpYa3BMblpoYkhWbExtNWhkR2wyWlNBdElHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaUxRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0o4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTXpOeTB6TkRNS0lDQWdJQzh2SUc1bGR5QmhjbU14TkRFd1gzQmhjblJwZEdsdmJsOTBjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJR1p5YjIwNklHWnliMjBzQ2lBZ0lDQXZMeUFnSUhSdk9pQjBieXdLSUNBZ0lDOHZJQ0FnY0dGeWRHbDBhVzl1T2lCbWNtOXRVR0Z5ZEdsMGFXOXVMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdaR0YwWVRvZ1pHRjBZU3dLSUNBZ0lDOHZJSDBwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzAyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EZ3lDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNek5TMHpORFFLSUNBZ0lDOHZJR1Z0YVhRb0NpQWdJQ0F2THlBZ0lDZFVjbUZ1YzJabGNpY3NDaUFnSUNBdkx5QWdJRzVsZHlCaGNtTXhOREV3WDNCaGNuUnBkR2x2Ymw5MGNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdabkp2YlRvZ1puSnZiU3dLSUNBZ0lDOHZJQ0FnSUNCMGJ6b2dkRzhzQ2lBZ0lDQXZMeUFnSUNBZ2NHRnlkR2wwYVc5dU9pQm1jbTl0VUdGeWRHbDBhVzl1TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHUmhkR0U2SUdSaGRHRXNDaUFnSUNBdkx5QWdJSDBwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01ESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNakEyWWpjNU5EQWdMeThnYldWMGFHOWtJQ0pVY21GdWMyWmxjaWdvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5peGllWFJsVzEwcEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak0wTndvZ0lDQWdMeThnYVdZZ0tIUnZVR0Z5ZEdsMGFXOXVJQ0U5UFNCbWNtOXRVR0Z5ZEdsMGFXOXVLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ0lUMEtJQ0FnSUdKNklGOTBjbUZ1YzJabGNsOXdZWEowYVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTTBPQW9nSUNBZ0x5OGdkR2hwY3k1ZllXUmtYM0JoY25ScFkybHdZWFJwYjI1ZmRHOWZhRzlzWkdWeUtIUnZMQ0IwYjFCaGNuUnBkR2x2YmlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpZV3hzYzNWaUlGOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSUtDbDkwY21GdWMyWmxjbDl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96TlRJS0lDQWdJQzh2SUdOdmJuTjBJSFJ2UzJWNUlEMGdibVYzSUdGeVl6RTBNVEJmVUdGeWRHbDBhVzl1UzJWNUtIc2dhRzlzWkdWeU9pQjBieXdnY0dGeWRHbDBhVzl1T2lCMGIxQmhjblJwZEdsdmJpQjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnY0hWaWJHbGpJSEJoY25ScGRHbHZibk1nUFNCQ2IzaE5ZWEE4WVhKak1UUXhNRjlRWVhKMGFYUnBiMjVMWlhrc0lHRnlZelF1VldsdWRFNHlOVFkrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOXdKeUI5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWVhKak1UUXhNRjl3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek5UTUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NXdZWEowYVhScGIyNXpLSFJ2UzJWNUtTNWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUY5MGNtRnVjMlpsY2w5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNMU5Bb2dJQ0FnTHk4Z2RHaHBjeTV3WVhKMGFYUnBiMjV6S0hSdlMyVjVLUzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5ST01qVTJLREFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSnZlRjl3ZFhRS0NsOTBjbUZ1YzJabGNsOXdZWEowYVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pOVFlLSUNBZ0lDOHZJSFJvYVhNdWNHRnlkR2wwYVc5dWN5aDBiMHRsZVNrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmloMGFHbHpMbkJoY25ScGRHbHZibk1vZEc5TFpYa3BMblpoYkhWbExtNWhkR2wyWlNBcklHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaUt3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0o4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qcEJjbU14TkRFd0xtRnlZekUwTVRCZllYVjBhRzl5YVhwbFgyOXdaWEpoZEc5eVgySjVYM0J2Y25ScGIyNG9hRzlzWkdWeU9pQmllWFJsY3l3Z2IzQmxjbUYwYjNJNklHSjVkR1Z6TENCd1lYSjBhWFJwYjI0NklHSjVkR1Z6TENCaGJXOTFiblE2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoY21NeE5ERXdYMkYxZEdodmNtbDZaVjl2Y0dWeVlYUnZjbDlpZVY5d2IzSjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek5Ua3RNelkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUwTVRCZllYVjBhRzl5YVhwbFgyOXdaWEpoZEc5eVgySjVYM0J2Y25ScGIyNG9DaUFnSUNBdkx5QWdJR2h2YkdSbGNqb2dZWEpqTkM1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCdmNHVnlZWFJ2Y2pvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0J3WVhKMGFYUnBiMjQ2SUdGeVl6UXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQmhjbU0wTGxWcGJuUk9NalUyTEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBMElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNelkyQ2lBZ0lDQXZMeUJoYzNObGNuUW9ibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0E5UFQwZ2FHOXNaR1Z5TENBblQyNXNlU0JvYjJ4a1pYSWdZMkZ1SUdGMWRHaHZjbWw2WlNCd2IzSjBhVzl1SnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR2h2YkdSbGNpQmpZVzRnWVhWMGFHOXlhWHBsSUhCdmNuUnBiMjRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXpZM0NpQWdJQ0F2THlCamIyNXpkQ0JyWlhrZ1BTQnVaWGNnWVhKak1UUXhNRjlQY0dWeVlYUnZjbEJ2Y25ScGIyNUxaWGtvZXlCb2IyeGtaWElzSUc5d1pYSmhkRzl5TENCd1lYSjBhWFJwYjI0Z2ZTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM0JsY21GMGIzSlFiM0owYVc5dVFXeHNiM2RoYm1ObGN5QTlJRUp2ZUUxaGNEeGhjbU14TkRFd1gwOXdaWEpoZEc5eVVHOXlkR2x2Ymt0bGVTd2dZWEpqTkM1VmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RoY21NeE5ERXdYMjl3WVNjZ2ZTa0tJQ0FnSUdKNWRHVmpJREV5SUM4dklDSmhjbU14TkRFd1gyOXdZU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek5qZ0tJQ0FnSUM4dklIUm9hWE11YjNCbGNtRjBiM0pRYjNKMGFXOXVRV3hzYjNkaGJtTmxjeWhyWlhrcExuWmhiSFZsSUQwZ1lXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9rRnlZekUwTVRBdVlYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNsOWllVjl3YjNKMGFXOXVLR2h2YkdSbGNqb2dZbmwwWlhNc0lHOXdaWEpoZEc5eU9pQmllWFJsY3l3Z2NHRnlkR2wwYVc5dU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSmZZbmxmY0c5eWRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXpjeExUTTNOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgySjVYM0J2Y25ScGIyNG9DaUFnSUNBdkx5QWdJR2h2YkdSbGNqb2dZWEpqTkM1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCdmNHVnlZWFJ2Y2pvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0J3WVhKMGFYUnBiMjQ2SUdGeVl6UXVRV1JrY21WemN5d0tJQ0FnSUM4dklDazZJR0Z5WXpRdVFtOXZiQ0I3Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTTNOd29nSUNBZ0x5OGdhV1lnS0c5d1pYSmhkRzl5SUQwOVBTQm9iMnhrWlhJcElISmxkSFZ5YmlCdVpYY2dZWEpqTkM1Q2IyOXNLSFJ5ZFdVcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdQVDBLSUNBZ0lHSjZJR0Z5WXpFME1UQmZhWE5mYjNCbGNtRjBiM0pmWW5sZmNHOXlkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGc0TUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncGhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlYMko1WDNCdmNuUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96TnpnS0lDQWdJQzh2SUdOdmJuTjBJR3RsZVNBOUlHNWxkeUJoY21NeE5ERXdYMDl3WlhKaGRHOXlVRzl5ZEdsdmJrdGxlU2g3SUdodmJHUmxjaXdnYjNCbGNtRjBiM0lzSUhCaGNuUnBkR2x2YmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJSEIxWW14cFl5QnZjR1Z5WVhSdmNsQnZjblJwYjI1QmJHeHZkMkZ1WTJWeklEMGdRbTk0VFdGd1BHRnlZekUwTVRCZlQzQmxjbUYwYjNKUWIzSjBhVzl1UzJWNUxDQmhjbU0wTGxWcGJuUk9NalUyUGloN0lHdGxlVkJ5WldacGVEb2dKMkZ5WXpFME1UQmZiM0JoSnlCOUtRb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0ltRnlZekUwTVRCZmIzQmhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96TnprS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1dmNHVnlZWFJ2Y2xCdmNuUnBiMjVCYkd4dmQyRnVZMlZ6S0d0bGVTa3VaWGhwYzNSektTQnlaWFIxY200Z2JtVjNJR0Z5WXpRdVFtOXZiQ2htWVd4elpTa0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdGeVl6RTBNVEJmYVhOZmIzQmxjbUYwYjNKZllubGZjRzl5ZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1EQUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2w5aWVWOXdiM0owYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16Z3dDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJR0Z5WXpRdVFtOXZiQ2gwYUdsekxtOXdaWEpoZEc5eVVHOXlkR2x2YmtGc2JHOTNZVzVqWlhNb2EyVjVLUzUyWVd4MVpTNXVZWFJwZG1VZ1BpQXdLUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUdJK0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9rRnlZekUwTVRBdVlYSmpNVFF4TUY5cGMzTjFaVjlpZVY5d1lYSjBhWFJwYjI0b2RHODZJR0o1ZEdWekxDQndZWEowYVhScGIyNDZJR0o1ZEdWekxDQmhiVzkxYm5RNklHSjVkR1Z6TENCa1lYUmhPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZWEpqTVRReE1GOXBjM04xWlY5aWVWOXdZWEowYVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak00TXkwek9Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1UUXhNRjlwYzNOMVpWOWllVjl3WVhKMGFYUnBiMjRvQ2lBZ0lDQXZMeUFnSUhSdk9pQmhjbU0wTGtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUhCaGNuUnBkR2x2YmpvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJR0Z5WXpRdVZXbHVkRTR5TlRZc0NpQWdJQ0F2THlBZ0lHUmhkR0U2SUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6TEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBMElEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16a3dDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVoY21NNE9GOXBjMTl2ZDI1bGNpaHVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBLUzV1WVhScGRtVWdQVDA5SUhSeWRXVXNJQ2R2Ym14NVgyOTNibVZ5SnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpPRGhmYVhOZmIzZHVaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIbGZiM2R1WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16a3hDaUFnSUNBdkx5QmhjM05sY25Rb1lXMXZkVzUwTG01aGRHbDJaU0ErSURBc0lDZEpiblpoYkdsa0lHRnRiM1Z1ZENjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lHRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek9UTUtJQ0FnSUM4dklHTnZibk4wSUhSdlMyVjVJRDBnYm1WM0lHRnlZekUwTVRCZlVHRnlkR2wwYVc5dVMyVjVLSHNnYUc5c1pHVnlPaUIwYnl3Z2NHRnlkR2wwYVc5dUlIMHBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSEIxWW14cFl5QndZWEowYVhScGIyNXpJRDBnUW05NFRXRndQR0Z5WXpFME1UQmZVR0Z5ZEdsMGFXOXVTMlY1TENCaGNtTTBMbFZwYm5ST01qVTJQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRnlZekUwTVRCZmNDY2dmU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUZ5WXpFME1UQmZjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNNU5Bb2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxuQmhjblJwZEdsdmJuTW9kRzlMWlhrcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWVhKak1UUXhNRjlwYzNOMVpWOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak01TlFvZ0lDQWdMeThnZEdocGN5NXdZWEowYVhScGIyNXpLSFJ2UzJWNUtTNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTWpVMktEQXBDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXprMkNpQWdJQ0F2THlCMGFHbHpMbDloWkdSZmNHRnlkR2xqYVhCaGRHbHZibDkwYjE5b2IyeGtaWElvZEc4c0lIQmhjblJwZEdsdmJpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqWVd4c2MzVmlJRjloWkdSZmNHRnlkR2xqYVhCaGRHbHZibDkwYjE5b2IyeGtaWElLQ21GeVl6RTBNVEJmYVhOemRXVmZZbmxmY0dGeWRHbDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXprNENpQWdJQ0F2THlCMGFHbHpMbkJoY25ScGRHbHZibk1vZEc5TFpYa3BMblpoYkhWbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0eU5UWW9kR2hwY3k1d1lYSjBhWFJwYjI1ektIUnZTMlY1S1M1MllXeDFaUzV1WVhScGRtVWdLeUJoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaXNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCaWZBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZbUZzWVc1alpYTWdQU0JDYjNoTllYQThRV1JrY21WemN5d2dWV2x1ZEU0eU5UWStLSHNnYTJWNVVISmxabWw0T2lBbllpY2dmU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRBd0NpQWdJQ0F2THlCcFppQW9JWFJvYVhNdVltRnNZVzVqWlhNb2RHOHBMbVY0YVhOMGN5a2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1lYSmpNVFF4TUY5cGMzTjFaVjlpZVY5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRd01Rb2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWgwYnlrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmlnd0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpYjNoZmNIVjBDZ3BoY21NeE5ERXdYMmx6YzNWbFgySjVYM0JoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalF3TXdvZ0lDQWdMeThnZEdocGN5NWlZV3hoYm1ObGN5aDBieWt1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWgwYUdsekxtSmhiR0Z1WTJWektIUnZLUzUyWVd4MVpTNXVZWFJwZG1VZ0t5QmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpc0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdKOENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjBiM1JoYkZOMWNIQnNlU0E5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTWpVMlBpaDdJR3RsZVRvZ0ozUW5JSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalF3TkFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkZOMWNIQnNlUzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5ST01qVTJLSFJvYVhNdWRHOTBZV3hUZFhCd2JIa3VkbUZzZFdVdWJtRjBhWFpsSUNzZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpc0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdKOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIQjFZbXhwWXlCMGIzUmhiRk4xY0hCc2VTQTlJRWRzYjJKaGJGTjBZWFJsUEZWcGJuUk9NalUyUGloN0lHdGxlVG9nSjNRbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTURRS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VGRYQndiSGt1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWgwYUdsekxuUnZkR0ZzVTNWd2NHeDVMblpoYkhWbExtNWhkR2wyWlNBcklHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME1EVUtJQ0FnSUM4dklHVnRhWFFvSjBsemMzVmxKeXdnYm1WM0lHRnlZekUwTVRCZmNHRnlkR2wwYVc5dVgybHpjM1ZsS0hzZ2RHOHNJSEJoY25ScGRHbHZiaXdnWVcxdmRXNTBMQ0JrWVhSaElIMHBLUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUF5TVNBdkx5QXdlREF3TmpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdaaE5EUXpZakZpSUM4dklHMWxkR2h2WkNBaVNYTnpkV1VvS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJMR0o1ZEdWYlhTa3BJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02T2tGeVl6RTBNVEF1WVhKak1UUXhNRjl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1S0hCaGNuUnBkR2x2YmpvZ1lubDBaWE1zSUdGdGIzVnVkRG9nWW5sMFpYTXNJR1JoZEdFNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwaGNtTXhOREV3WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUXdPQzAwTURrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRReE1GOXlaV1JsWlcxZllubGZjR0Z5ZEdsMGFXOXVLSEJoY25ScGRHbHZiam9nWVhKak5DNUJaR1J5WlhOekxDQmhiVzkxYm5RNklHRnlZelF1VldsdWRFNHlOVFlzSUdSaGRHRTZJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5ERXdDaUFnSUNBdkx5QmpiMjV6ZENCbWNtOXRJRDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTVRFS0lDQWdJQzh2SUdGemMyVnlkQ2hoYlc5MWJuUXVibUYwYVhabElENGdNQ3dnSjBsdWRtRnNhV1FnWVcxdmRXNTBKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaVBnb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnWVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalF4TWdvZ0lDQWdMeThnWTI5dWMzUWdabkp2YlV0bGVTQTlJRzVsZHlCaGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTaDdJR2h2YkdSbGNqb2dabkp2YlN3Z2NHRnlkR2wwYVc5dUlIMHBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUhCMVlteHBZeUJ3WVhKMGFYUnBiMjV6SUQwZ1FtOTRUV0Z3UEdGeVl6RTBNVEJmVUdGeWRHbDBhVzl1UzJWNUxDQmhjbU0wTGxWcGJuUk9NalUyUGloN0lHdGxlVkJ5WldacGVEb2dKMkZ5WXpFME1UQmZjQ2NnZlNrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1GeVl6RTBNVEJmY0NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5CaGNuUnBkR2x2Ym5Nb1puSnZiVXRsZVNrdVpYaHBjM1J6TENBblVHRnlkR2wwYVc5dUlHSmhiR0Z1WTJVZ2JXbHpjMmx1WnljcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhjblJwZEdsdmJpQmlZV3hoYm1ObElHMXBjM05wYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5ERTBDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV3WVhKMGFYUnBiMjV6S0daeWIyMUxaWGtwTG5aaGJIVmxMbTVoZEdsMlpTQStQU0JoYlc5MWJuUXVibUYwYVhabExDQW5TVzV6ZFdabWFXTnBaVzUwSUhCaGNuUnBkR2x2YmlCaVlXeGhibU5sSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzV6ZFdabWFXTnBaVzUwSUhCaGNuUnBkR2x2YmlCaVlXeGhibU5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pReE5Rb2dJQ0FnTHk4Z2RHaHBjeTV3WVhKMGFYUnBiMjV6S0daeWIyMUxaWGtwTG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1VldsdWRFNHlOVFlvZEdocGN5NXdZWEowYVhScGIyNXpLR1p5YjIxTFpYa3BMblpoYkhWbExtNWhkR2wyWlNBdElHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSXRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHSjhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUhCMVlteHBZeUJpWVd4aGJtTmxjeUE5SUVKdmVFMWhjRHhCWkdSeVpYTnpMQ0JWYVc1MFRqSTFOajRvZXlCclpYbFFjbVZtYVhnNklDZGlKeUI5S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWWlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUXhOd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW1Gc1lXNWpaWE1vWm5KdmJTa3VaWGhwYzNSeklDWW1JSFJvYVhNdVltRnNZVzVqWlhNb1puSnZiU2t1ZG1Gc2RXVXVibUYwYVhabElENDlJR0Z0YjNWdWRDNXVZWFJwZG1Vc0lDZEpibk4xWm1acFkybGxiblFnWW1Gc1lXNWpaU2NwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHRnlZekUwTVRCZmNtVmtaV1Z0WDJKNVgzQmhjblJwZEdsdmJsOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaVBqMEtJQ0FnSUdKNklHRnlZekUwTVRCZmNtVmtaV1Z0WDJKNVgzQmhjblJwZEdsdmJsOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDZ3BoY21NeE5ERXdYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjVmWW05dmJGOXRaWEpuWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KaGJHRnVZMlZ6S0daeWIyMHBMbVY0YVhOMGN5QW1KaUIwYUdsekxtSmhiR0Z1WTJWektHWnliMjBwTG5aaGJIVmxMbTVoZEdsMlpTQStQU0JoYlc5MWJuUXVibUYwYVhabExDQW5TVzV6ZFdabWFXTnBaVzUwSUdKaGJHRnVZMlVuS1FvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCaVlXeGhibU5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pReE9Bb2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWhtY205dEtTNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTWpVMktIUm9hWE11WW1Gc1lXNWpaWE1vWm5KdmJTa3VkbUZzZFdVdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdJdENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JpZkFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QndkV0pzYVdNZ2RHOTBZV3hUZFhCd2JIa2dQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUakkxTmo0b2V5QnJaWGs2SUNkMEp5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNVGtLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hUZFhCd2JIa3VkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpJMU5paDBhR2x6TG5SdmRHRnNVM1Z3Y0d4NUxuWmhiSFZsTG01aGRHbDJaU0F0SUdGdGIzVnVkQzV1WVhScGRtVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdJdENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JpZkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCd2RXSnNhV01nZEc5MFlXeFRkWEJ3YkhrZ1BTQkhiRzlpWVd4VGRHRjBaVHhWYVc1MFRqSTFOajRvZXlCclpYazZJQ2QwSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOREU1Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVTNWd2NHeDVMblpoYkhWbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0eU5UWW9kR2hwY3k1MGIzUmhiRk4xY0hCc2VTNTJZV3gxWlM1dVlYUnBkbVVnTFNCaGJXOTFiblF1Ym1GMGFYWmxLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRJd0NpQWdJQ0F2THlCbGJXbDBLQ2RTWldSbFpXMG5MQ0J1WlhjZ1lYSmpNVFF4TUY5d1lYSjBhWFJwYjI1ZmNtVmtaV1Z0S0hzZ1puSnZiU3dnY0dGeWRHbDBhVzl1TENCaGJXOTFiblFzSUdSaGRHRWdmU2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURJeElDOHZJREI0TURBMk1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNalVnTHk4Z2JXVjBhRzlrSUNKU1pXUmxaVzBvS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJMR0o1ZEdWYlhTa3BJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lISmxkSE4xWWdvS1lYSmpNVFF4TUY5eVpXUmxaVzFmWW5sZmNHRnlkR2wwYVc5dVgySnZiMnhmWm1Gc2MyVkFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHRnlZekUwTVRCZmNtVmtaV1Z0WDJKNVgzQmhjblJwZEdsdmJsOWliMjlzWDIxbGNtZGxRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPanBCY21NeE5ERXdMbUZ5WXpFME1UQmZiM0JsY21GMGIzSmZjbVZrWldWdFgySjVYM0JoY25ScGRHbHZiaWhtY205dE9pQmllWFJsY3l3Z2NHRnlkR2wwYVc5dU9pQmllWFJsY3l3Z1lXMXZkVzUwT2lCaWVYUmxjeXdnWkdGMFlUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtRnlZekUwTVRCZmIzQmxjbUYwYjNKZmNtVmtaV1Z0WDJKNVgzQmhjblJwZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOREl6TFRReU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5ERXdYMjl3WlhKaGRHOXlYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjRvQ2lBZ0lDQXZMeUFnSUdaeWIyMDZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ2NHRnlkR2wwYVc5dU9pQmhjbU0wTGtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nWVhKak5DNVZhVzUwVGpJMU5pd0tJQ0FnSUM4dklDQWdaR0YwWVRvZ1lYSmpOQzVFZVc1aGJXbGpRbmwwWlhNc0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklEUWdNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdSMWNHNGdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTXpBS0lDQWdJQzh2SUdOdmJuTjBJSE5sYm1SbGNpQTlJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZORE15Q2lBZ0lDQXZMeUJzWlhRZ1lYVjBhRzl5YVhwbFpDQTlJSFJvYVhNdVlYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNpaG1jbTl0TENCelpXNWtaWElzSUhCaGNuUnBkR2x2YmlrdWJtRjBhWFpsSUQwOVBTQjBjblZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRNd0NpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSWdQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalF6TWdvZ0lDQWdMeThnYkdWMElHRjFkR2h2Y21sNlpXUWdQU0IwYUdsekxtRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSW9abkp2YlN3Z2MyVnVaR1Z5TENCd1lYSjBhWFJwYjI0cExtNWhkR2wyWlNBOVBUMGdkSEoxWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpZV3hzYzNWaUlHRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUXpNd29nSUNBZ0x5OGdhV1lnS0NGaGRYUm9iM0pwZW1Wa0tTQjdDaUFnSUNCaWJub2dZWEpqTVRReE1GOXZjR1Z5WVhSdmNsOXlaV1JsWlcxZllubGZjR0Z5ZEdsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNelFLSUNBZ0lDOHZJR052Ym5OMElIQkxaWGtnUFNCdVpYY2dZWEpqTVRReE1GOVBjR1Z5WVhSdmNsQnZjblJwYjI1TFpYa29leUJvYjJ4a1pYSTZJR1p5YjIwc0lHOXdaWEpoZEc5eU9pQnpaVzVrWlhJc0lIQmhjblJwZEdsdmJpQjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnY0hWaWJHbGpJRzl3WlhKaGRHOXlVRzl5ZEdsdmJrRnNiRzkzWVc1alpYTWdQU0JDYjNoTllYQThZWEpqTVRReE1GOVBjR1Z5WVhSdmNsQnZjblJwYjI1TFpYa3NJR0Z5WXpRdVZXbHVkRTR5TlRZK0tIc2dhMlY1VUhKbFptbDRPaUFuWVhKak1UUXhNRjl2Y0dFbklIMHBDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWlZWEpqTVRReE1GOXZjR0VpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRek5Rb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWIzQmxjbUYwYjNKUWIzSjBhVzl1UVd4c2IzZGhibU5sY3lod1MyVjVLUzVsZUdsemRITXBJSHNLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1lYSmpNVFF4TUY5dmNHVnlZWFJ2Y2w5eVpXUmxaVzFmWW5sZmNHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME16WUtJQ0FnSUM4dklHTnZibk4wSUhKbGJXRnBibWx1WnlBOUlIUm9hWE11YjNCbGNtRjBiM0pRYjNKMGFXOXVRV3hzYjNkaGJtTmxjeWh3UzJWNUtTNTJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRNM0NpQWdJQ0F2THlCaGMzTmxjblFvY21WdFlXbHVhVzVuTG01aGRHbDJaU0ErUFNCaGJXOTFiblF1Ym1GMGFYWmxMQ0FuVUc5eWRHbHZiaUJoYkd4dmQyRnVZMlVnWlhoalpXVmtaV1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSStQUW9nSUNBZ1lYTnpaWEowSUM4dklGQnZjblJwYjI0Z1lXeHNiM2RoYm1ObElHVjRZMlZsWkdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUXpPQW9nSUNBZ0x5OGdZWFYwYUc5eWFYcGxaQ0E5SUhSeWRXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5ETTVDaUFnSUNBdkx5QjBhR2x6TG05d1pYSmhkRzl5VUc5eWRHbHZia0ZzYkc5M1lXNWpaWE1vY0V0bGVTa3VkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpJMU5paHlaVzFoYVc1cGJtY3VibUYwYVhabElDMGdZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaTBLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWIzaGZjSFYwQ2dwaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdabkpoYldWZlpHbG5JRFVLSUNBZ0lHWnlZVzFsWDJKMWNua2dOZ29LWVhKak1UUXhNRjl2Y0dWeVlYUnZjbDl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lHWnlZVzFsWDJScFp5QTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalEwTWdvZ0lDQWdMeThnWVhOelpYSjBLR0YxZEdodmNtbDZaV1FzSUNkT2IzUWdZWFYwYUc5eWFYcGxaQ0J2Y0dWeVlYUnZjaWNwQ2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdGMWRHaHZjbWw2WldRZ2IzQmxjbUYwYjNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5EUTBDaUFnSUNBdkx5QmpiMjV6ZENCbWNtOXRTMlY1SUQwZ2JtVjNJR0Z5WXpFME1UQmZVR0Z5ZEdsMGFXOXVTMlY1S0hzZ2FHOXNaR1Z5T2lCbWNtOXRMQ0J3WVhKMGFYUnBiMjRnZlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCd2RXSnNhV01nY0dGeWRHbDBhVzl1Y3lBOUlFSnZlRTFoY0R4aGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTd2dZWEpqTkM1VmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RoY21NeE5ERXdYM0FuSUgwcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKaGNtTXhOREV3WDNBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZORFExQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1d1lYSjBhWFJwYjI1ektHWnliMjFMWlhrcExtVjRhWE4wY3l3Z0oxQmhjblJwZEdsdmJpQmlZV3hoYm1ObElHMXBjM05wYm1jbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFZWEowYVhScGIyNGdZbUZzWVc1alpTQnRhWE56YVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUTBOZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11Y0dGeWRHbDBhVzl1Y3lobWNtOXRTMlY1S1M1MllXeDFaUzV1WVhScGRtVWdQajBnWVcxdmRXNTBMbTVoZEdsMlpTd2dKMGx1YzNWbVptbGphV1Z1ZENCd1lYSjBhWFJwYjI0Z1ltRnNZVzVqWlNjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0krUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCd1lYSjBhWFJwYjI0Z1ltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME5EY0tJQ0FnSUM4dklIUm9hWE11Y0dGeWRHbDBhVzl1Y3lobWNtOXRTMlY1S1M1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUk9NalUyS0hSb2FYTXVjR0Z5ZEdsMGFXOXVjeWhtY205dFMyVjVLUzUyWVd4MVpTNXVZWFJwZG1VZ0xTQmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlMUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdKOENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSEIxWW14cFl5QmlZV3hoYm1ObGN5QTlJRUp2ZUUxaGNEeEJaR1J5WlhOekxDQlZhVzUwVGpJMU5qNG9leUJyWlhsUWNtVm1hWGc2SUNkaUp5QjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTkRnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSmhiR0Z1WTJWektHWnliMjBwTG1WNGFYTjBjeUFtSmlCMGFHbHpMbUpoYkdGdVkyVnpLR1p5YjIwcExuWmhiSFZsTG01aGRHbDJaU0ErUFNCaGJXOTFiblF1Ym1GMGFYWmxMQ0FuU1c1emRXWm1hV05wWlc1MElHSmhiR0Z1WTJVbktRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJoY21NeE5ERXdYMjl3WlhKaGRHOXlYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjVmWW05dmJGOW1ZV3h6WlVBM0NpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZajQ5Q2lBZ0lDQmllaUJoY21NeE5ERXdYMjl3WlhKaGRHOXlYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjVmWW05dmJGOW1ZV3h6WlVBM0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvS1lYSmpNVFF4TUY5dmNHVnlZWFJ2Y2w5eVpXUmxaVzFmWW5sZmNHRnlkR2wwYVc5dVgySnZiMnhmYldWeVoyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRRNENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWlZV3hoYm1ObGN5aG1jbTl0S1M1bGVHbHpkSE1nSmlZZ2RHaHBjeTVpWVd4aGJtTmxjeWhtY205dEtTNTJZV3gxWlM1dVlYUnBkbVVnUGowZ1lXMXZkVzUwTG01aGRHbDJaU3dnSjBsdWMzVm1abWxqYVdWdWRDQmlZV3hoYm1ObEp5a0tJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdZbUZzWVc1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBORGtLSUNBZ0lDOHZJSFJvYVhNdVltRnNZVzVqWlhNb1puSnZiU2t1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWgwYUdsekxtSmhiR0Z1WTJWektHWnliMjBwTG5aaGJIVmxMbTVoZEdsMlpTQXRJR0Z0YjNWdWRDNXVZWFJwZG1VcENpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlMUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1lud0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnY0hWaWJHbGpJSFJ2ZEdGc1UzVndjR3g1SUQwZ1IyeHZZbUZzVTNSaGRHVThWV2x1ZEU0eU5UWStLSHNnYTJWNU9pQW5kQ2NnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRVd0NpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1VldsdWRFNHlOVFlvZEdocGN5NTBiM1JoYkZOMWNIQnNlUzUyWVd4MVpTNXVZWFJwZG1VZ0xTQmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlMUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1lud0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdjSFZpYkdsaklIUnZkR0ZzVTNWd2NHeDVJRDBnUjJ4dlltRnNVM1JoZEdVOFZXbHVkRTR5TlRZK0tIc2dhMlY1T2lBbmRDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRMU1Bb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGTjFjSEJzZVM1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUk9NalUyS0hSb2FYTXVkRzkwWVd4VGRYQndiSGt1ZG1Gc2RXVXVibUYwYVhabElDMGdZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUTFNUW9nSUNBZ0x5OGdaVzFwZENnblVtVmtaV1Z0Snl3Z2JtVjNJR0Z5WXpFME1UQmZjR0Z5ZEdsMGFXOXVYM0psWkdWbGJTaDdJR1p5YjIwc0lIQmhjblJwZEdsdmJpd2dZVzF2ZFc1MExDQmtZWFJoSUgwcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXlNU0F2THlBd2VEQXdOaklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURJMUlDOHZJRzFsZEdodlpDQWlVbVZrWldWdEtDaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTml4aWVYUmxXMTBwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDbUZ5WXpFME1UQmZiM0JsY21GMGIzSmZjbVZrWldWdFgySjVYM0JoY25ScGRHbHZibDlpYjI5c1gyWmhiSE5sUURjNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJoY21NeE5ERXdYMjl3WlhKaGRHOXlYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjVmWW05dmJGOXRaWEpuWlVBNENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WW05dmRITjBjbUZ3S0c1aGJXVTZJR0o1ZEdWekxDQnplVzFpYjJ3NklHSjVkR1Z6TENCa1pXTnBiV0ZzY3pvZ1lubDBaWE1zSUhSdmRHRnNVM1Z3Y0d4NU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtSnZiM1J6ZEhKaGNEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFOaTAxTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmliMjkwYzNSeVlYQW9ibUZ0WlRvZ1JIbHVZVzFwWTBKNWRHVnpMQ0J6ZVcxaWIydzZJRVI1Ym1GdGFXTkNlWFJsY3l3Z1pHVmphVzFoYkhNNklGVnBiblJPT0N3Z2RHOTBZV3hUZFhCd2JIazZJRlZwYm5ST01qVTJLVG9nUW05dmJDQjdDaUFnSUNCd2NtOTBieUEwSURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVFXUmtjbVZ6Y3l3Z0owOXViSGtnWkdWd2JHOTVaWElnYjJZZ2RHaHBjeUJ6YldGeWRDQmpiMjUwY21GamRDQmpZVzRnWTJGc2JDQmliMjkwYzNSeVlYQWdiV1YwYUc5a0p5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdSbGNHeHZlV1Z5SUc5bUlIUm9hWE1nYzIxaGNuUWdZMjl1ZEhKaFkzUWdZMkZ1SUdOaGJHd2dZbTl2ZEhOMGNtRndJRzFsZEdodlpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QmhjM05sY25Rb2JtRnRaUzV1WVhScGRtVXViR1Z1WjNSb0lENGdNQ3dnSjA1aGJXVWdiMllnZEdobElHRnpjMlYwSUcxMWMzUWdZbVVnYkc5dVoyVnlJRzl5SUdWeGRXRnNJSFJ2SURFZ1kyaGhjbUZqZEdWeUp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbUZ0WlNCdlppQjBhR1VnWVhOelpYUWdiWFZ6ZENCaVpTQnNiMjVuWlhJZ2IzSWdaWEYxWVd3Z2RHOGdNU0JqYUdGeVlXTjBaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWVhOelpYSjBLRzVoYldVdWJtRjBhWFpsTG14bGJtZDBhQ0E4UFNBek1pd2dKMDVoYldVZ2IyWWdkR2hsSUdGemMyVjBJRzExYzNRZ1ltVWdjMmh2Y25SbGNpQnZjaUJsY1hWaGJDQjBieUF6TWlCamFHRnlZV04wWlhKekp5a0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJPWVcxbElHOW1JSFJvWlNCaGMzTmxkQ0J0ZFhOMElHSmxJSE5vYjNKMFpYSWdiM0lnWlhGMVlXd2dkRzhnTXpJZ1kyaGhjbUZqZEdWeWN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QmhjM05sY25Rb2MzbHRZbTlzTG01aGRHbDJaUzVzWlc1bmRHZ2dQaUF3TENBblUzbHRZbTlzSUc5bUlIUm9aU0JoYzNObGRDQnRkWE4wSUdKbElHeHZibWRsY2lCdmNpQmxjWFZoYkNCMGJ5QXhJR05vWVhKaFkzUmxjaWNwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUZONWJXSnZiQ0J2WmlCMGFHVWdZWE56WlhRZ2JYVnpkQ0JpWlNCc2IyNW5aWElnYjNJZ1pYRjFZV3dnZEc4Z01TQmphR0Z5WVdOMFpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdZWE56WlhKMEtITjViV0p2YkM1dVlYUnBkbVV1YkdWdVozUm9JRHc5SURnc0lDZFRlVzFpYjJ3Z2IyWWdkR2hsSUdGemMyVjBJRzExYzNRZ1ltVWdjMmh2Y25SbGNpQnZjaUJsY1hWaGJDQjBieUE0SUdOb1lYSmhZM1JsY25NbktRb2dJQ0FnY0hWemFHbHVkQ0E0SUM4dklEZ0tJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVTNsdFltOXNJRzltSUhSb1pTQmhjM05sZENCdGRYTjBJR0psSUhOb2IzSjBaWElnYjNJZ1pYRjFZV3dnZEc4Z09DQmphR0Z5WVdOMFpYSnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjBiM1JoYkZOMWNIQnNlU0E5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTWpVMlBpaDdJR3RsZVRvZ0ozUW5JSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxuUnZkR0ZzVTNWd2NHeDVMbWhoYzFaaGJIVmxMQ0FuVkdocGN5QnRaWFJvYjJRZ1kyRnVJR0psSUdOaGJHeGxaQ0J2Ym14NUlHOXVZMlVuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZSb2FYTWdiV1YwYUc5a0lHTmhiaUJpWlNCallXeHNaV1FnYjI1c2VTQnZibU5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUhCMVlteHBZeUJ1WVcxbElEMGdSMnh2WW1Gc1UzUmhkR1U4UkhsdVlXMXBZMEo1ZEdWelBpaDdJR3RsZVRvZ0oyNG5JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbTRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUhSb2FYTXVibUZ0WlM1MllXeDFaU0E5SUc1aGJXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdjSFZpYkdsaklITjViV0p2YkNBOUlFZHNiMkpoYkZOMFlYUmxQRVI1Ym1GdGFXTkNlWFJsY3o0b2V5QnJaWGs2SUNkekp5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUIwYUdsekxuTjViV0p2YkM1MllXeDFaU0E5SUhONWJXSnZiQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkRzkwWVd4VGRYQndiSGtnUFNCSGJHOWlZV3hUZEdGMFpUeFZhVzUwVGpJMU5qNG9leUJyWlhrNklDZDBKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGTjFjSEJzZVM1MllXeDFaU0E5SUhSdmRHRnNVM1Z3Y0d4NUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklIQjFZbXhwWXlCa1pXTnBiV0ZzY3lBOUlFZHNiMkpoYkZOMFlYUmxQRlZwYm5ST09ENG9leUJyWlhrNklDZGtKeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0prSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCMGFHbHpMbVJsWTJsdFlXeHpMblpoYkhWbElEMGdaR1ZqYVcxaGJITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdZMjl1YzNRZ2MyVnVaR1Z5SUQwZ2JtVjNJRUZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdjSFZpYkdsaklHSmhiR0Z1WTJWeklEMGdRbTk0VFdGd1BFRmtaSEpsYzNNc0lGVnBiblJPTWpVMlBpaDdJR3RsZVZCeVpXWnBlRG9nSjJJbklIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmlJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCMGFHbHpMbUpoYkdGdVkyVnpLSE5sYm1SbGNpa3VkbUZzZFdVZ1BTQjBiM1JoYkZOMWNIQnNlUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TnpNS0lDQWdJQzh2SUdWdGFYUW9ibVYzSUdGeVl6SXdNRjlVY21GdWMyWmxjaWg3SUdaeWIyMDZJRzVsZHlCQlpHUnlaWE56S0Vkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3lrc0lIUnZPaUJ6Wlc1a1pYSXNJSFpoYkhWbE9pQjBiM1JoYkZOMWNIQnNlU0I5S1NrS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01qWWdMeThnYldWMGFHOWtJQ0poY21NeU1EQmZWSEpoYm5ObVpYSW9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJDYjI5c0tIUnlkV1VwQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0T0RBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvNlFYSmpNakF3TG1GeVl6SXdNRjl1WVcxbEtDa2dMVDRnWW5sMFpYTTZDbUZ5WXpJd01GOXVZVzFsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pNNUNpQWdJQ0F2THlCd2RXSnNhV01nYm1GdFpTQTlJRWRzYjJKaGJGTjBZWFJsUEVSNWJtRnRhV05DZVhSbGN6NG9leUJyWlhrNklDZHVKeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWliaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnVTNSaGRHbGpRbmwwWlhNOE16SStLSFJvYVhNdWJtRnRaUzUyWVd4MVpTNXVZWFJwZG1VcENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhOcGVtVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xtRnlZekl3TUY5emVXMWliMndvS1NBdFBpQmllWFJsY3pvS1lYSmpNakF3WDNONWJXSnZiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnY0hWaWJHbGpJSE41YldKdmJDQTlJRWRzYjJKaGJGTjBZWFJsUEVSNWJtRnRhV05DZVhSbGN6NG9leUJyWlhrNklDZHpKeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnVTNSaGRHbGpRbmwwWlhNOE9ENG9kR2hwY3k1emVXMWliMnd1ZG1Gc2RXVXVibUYwYVhabEtRb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ2dMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lITnBlbVVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem82UVhKak1qQXdMbUZ5WXpJd01GOWtaV05wYldGc2N5Z3BJQzArSUdKNWRHVnpPZ3BoY21NeU1EQmZaR1ZqYVcxaGJITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJSEIxWW14cFl5QmtaV05wYldGc2N5QTlJRWRzYjJKaGJGTjBZWFJsUEZWcGJuUk9PRDRvZXlCclpYazZJQ2RrSnlCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEIxYzJoaWVYUmxjeUFpWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRBMENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWtaV05wYldGc2N5NTJZV3gxWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WVhKak1qQXdYM1J2ZEdGc1UzVndjR3g1S0NrZ0xUNGdZbmwwWlhNNkNtRnlZekl3TUY5MGIzUmhiRk4xY0hCc2VUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdjSFZpYkdsaklIUnZkR0ZzVTNWd2NHeDVJRDBnUjJ4dlltRnNVM1JoZEdVOFZXbHVkRTR5TlRZK0tIc2dhMlY1T2lBbmRDY2dmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5SdmRHRnNVM1Z3Y0d4NUxuWmhiSFZsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVoY21NeU1EQmZZbUZzWVc1alpVOW1LRzkzYm1WeU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtRnlZekl3TUY5aVlXeGhibU5sVDJZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1USXpMVEV5TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU15TURCZlltRnNZVzVqWlU5bUtHOTNibVZ5T2lCQlpHUnlaWE56S1RvZ1lYSmpOQzVWYVc1MFRqSTFOaUI3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hNalVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5aVlXeGhibU5sVDJZb2IzZHVaWElwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1gySmhiR0Z1WTJWUFpnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qcEJjbU15TURBdVlYSmpNakF3WDNSeVlXNXpabVZ5Um5KdmJTaG1jbTl0T2lCaWVYUmxjeXdnZEc4NklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BoY21NeU1EQmZkSEpoYm5ObVpYSkdjbTl0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFME9DMHhORGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNakF3WDNSeVlXNXpabVZ5Um5KdmJTaG1jbTl0T2lCQlpHUnlaWE56TENCMGJ6b2dRV1JrY21WemN5d2dkbUZzZFdVNklHRnlZelF1VldsdWRFNHlOVFlwT2lCaGNtTTBMa0p2YjJ3Z2V3b2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRVd0NpQWdJQ0F2THlCamIyNXpkQ0J6Y0dWdVpHVnlJRDBnYm1WM0lFRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE5URUtJQ0FnSUM4dklHTnZibk4wSUhOd1pXNWtaWEpmWVd4c2IzZGhibU5sSUQwZ2RHaHBjeTVmWVd4c2IzZGhibU5sS0daeWIyMHNJSE53Wlc1a1pYSXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUY5aGJHeHZkMkZ1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE5USUtJQ0FnSUM4dklHRnpjMlZ5ZENoemNHVnVaR1Z5WDJGc2JHOTNZVzVqWlM1dVlYUnBkbVVnUGowZ2RtRnNkV1V1Ym1GMGFYWmxMQ0FuYVc1emRXWm1hV05wWlc1MElHRndjSEp2ZG1Gc0p5a0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5OMVptWnBZMmxsYm5RZ1lYQndjbTkyWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE5UTUtJQ0FnSUM4dklHTnZibk4wSUc1bGQxOXpjR1Z1WkdWeVgyRnNiRzkzWVc1alpTQTlJRzVsZHlCVmFXNTBUakkxTmloemNHVnVaR1Z5WDJGc2JHOTNZVzVqWlM1dVlYUnBkbVVnTFNCMllXeDFaUzV1WVhScGRtVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJdENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFMU5Bb2dJQ0FnTHk4Z2RHaHBjeTVmWVhCd2NtOTJaU2htY205dExDQnpjR1Z1WkdWeUxDQnVaWGRmYzNCbGJtUmxjbDloYkd4dmQyRnVZMlVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdYMkZ3Y0hKdmRtVUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTFOUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WDNSeVlXNXpabVZ5S0daeWIyMHNJSFJ2TENCMllXeDFaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDNSeVlXNXpabVZ5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVoY21NeU1EQmZZWEJ3Y205MlpTaHpjR1Z1WkdWeU9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVhKak1qQXdYMkZ3Y0hKdmRtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVFkxTFRFMk5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeU1EQmZZWEJ3Y205MlpTaHpjR1Z1WkdWeU9pQkJaR1J5WlhOekxDQjJZV3gxWlRvZ1lYSmpOQzVWYVc1MFRqSTFOaWs2SUVKdmIyd2dld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UWTNDaUFnSUNBdkx5QmpiMjV6ZENCdmQyNWxjaUE5SUc1bGR5QkJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UWTRDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVmWVhCd2NtOTJaU2h2ZDI1bGNpd2djM0JsYm1SbGNpd2dkbUZzZFdVcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQmZZWEJ3Y205MlpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qcEJjbU15TURBdVlYSmpNakF3WDJGc2JHOTNZVzVqWlNodmQyNWxjam9nWW5sMFpYTXNJSE53Wlc1a1pYSTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tZWEpqTWpBd1gyRnNiRzkzWVc1alpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hOemN0TVRjNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdMeThnY0hWaWJHbGpJR0Z5WXpJd01GOWhiR3h2ZDJGdVkyVW9iM2R1WlhJNklFRmtaSEpsYzNNc0lITndaVzVrWlhJNklFRmtaSEpsYzNNcE9pQmhjbU0wTGxWcGJuUk9NalUySUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakUzT1FvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVgyRnNiRzkzWVc1alpTaHZkMjVsY2l3Z2MzQmxibVJsY2lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOWhiR3h2ZDJGdVkyVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xsOWlZV3hoYm1ObFQyWW9iM2R1WlhJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1gySmhiR0Z1WTJWUFpqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hPRElLSUNBZ0lDOHZJSEJ5YjNSbFkzUmxaQ0JmWW1Gc1lXNWpaVTltS0c5M2JtVnlPaUJCWkdSeVpYTnpLVG9nVldsdWRFNHlOVFlnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSEIxWW14cFl5QmlZV3hoYm1ObGN5QTlJRUp2ZUUxaGNEeEJaR1J5WlhOekxDQlZhVzUwVGpJMU5qNG9leUJyWlhsUWNtVm1hWGc2SUNkaUp5QjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94T0RNS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1aVlXeGhibU5sY3lodmQyNWxjaWt1WlhocGMzUnpLU0J5WlhSMWNtNGdibVYzSUZWcGJuUk9NalUyS0RBcENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJmWW1Gc1lXNWpaVTltWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS1gySmhiR0Z1WTJWUFpsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UZzBDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVpWVd4aGJtTmxjeWh2ZDI1bGNpa3VkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WDNSeVlXNXpabVZ5S0hObGJtUmxjam9nWW5sMFpYTXNJSEpsWTJsd2FXVnVkRG9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGZkSEpoYm5ObVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGczQ2lBZ0lDQXZMeUJ3Y205MFpXTjBaV1FnWDNSeVlXNXpabVZ5S0hObGJtUmxjam9nUVdSa2NtVnpjeXdnY21WamFYQnBaVzUwT2lCQlpHUnlaWE56TENCaGJXOTFiblE2SUZWcGJuUk9NalUyS1RvZ1FtOXZiQ0I3Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hPRGdLSUNBZ0lDOHZJR052Ym5OMElITmxibVJsY2w5aVlXeGhibU5sSUQwZ2RHaHBjeTVmWW1Gc1lXNWpaVTltS0hObGJtUmxjaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyRnNiSE4xWWlCZlltRnNZVzVqWlU5bUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE9Ea0tJQ0FnSUM4dklHTnZibk4wSUhKbFkybHdhV1Z1ZEY5aVlXeGhibU5sSUQwZ2RHaHBjeTVmWW1Gc1lXNWpaVTltS0hKbFkybHdhV1Z1ZENrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMkZzYkhOMVlpQmZZbUZzWVc1alpVOW1DaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGt3Q2lBZ0lDQXZMeUJoYzNObGNuUW9jMlZ1WkdWeVgySmhiR0Z1WTJVdWJtRjBhWFpsSUQ0OUlHRnRiM1Z1ZEM1dVlYUnBkbVVzSUNkSmJuTjFabVpwWTJsbGJuUWdZbUZzWVc1alpTQmhkQ0IwYUdVZ2MyVnVaR1Z5SUdGalkyOTFiblFuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qkpibk4xWm1acFkybGxiblFnWW1Gc1lXNWpaU0JoZENCMGFHVWdjMlZ1WkdWeUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE9USUtJQ0FnSUM4dklHbG1JQ2h6Wlc1a1pYSWdJVDA5SUhKbFkybHdhV1Z1ZENrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ0U5Q2lBZ0lDQmllaUJmZEhKaGJuTm1aWEpmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGswQ2lBZ0lDQXZMeUIwYUdsekxtSmhiR0Z1WTJWektITmxibVJsY2lrdWRtRnNkV1VnUFNCdVpYY2dWV2x1ZEU0eU5UWW9jMlZ1WkdWeVgySmhiR0Z1WTJVdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJdENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z2NIVmliR2xqSUdKaGJHRnVZMlZ6SUQwZ1FtOTRUV0Z3UEVGa1pISmxjM01zSUZWcGJuUk9NalUyUGloN0lHdGxlVkJ5WldacGVEb2dKMkluSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hPVFFLSUNBZ0lDOHZJSFJvYVhNdVltRnNZVzVqWlhNb2MyVnVaR1Z5S1M1MllXeDFaU0E5SUc1bGR5QlZhVzUwVGpJMU5paHpaVzVrWlhKZlltRnNZVzVqWlM1dVlYUnBkbVVnTFNCaGJXOTFiblF1Ym1GMGFYWmxLUW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFNU5Rb2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWh5WldOcGNHbGxiblFwTG5aaGJIVmxJRDBnYm1WM0lGVnBiblJPTWpVMktISmxZMmx3YVdWdWRGOWlZV3hoYm1ObExtNWhkR2wyWlNBcklHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUt3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWW53S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z2NIVmliR2xqSUdKaGJHRnVZMlZ6SUQwZ1FtOTRUV0Z3UEVGa1pISmxjM01zSUZWcGJuUk9NalUyUGloN0lHdGxlVkJ5WldacGVEb2dKMkluSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hPVFVLSUNBZ0lDOHZJSFJvYVhNdVltRnNZVzVqWlhNb2NtVmphWEJwWlc1MEtTNTJZV3gxWlNBOUlHNWxkeUJWYVc1MFRqSTFOaWh5WldOcGNHbGxiblJmWW1Gc1lXNWpaUzV1WVhScGRtVWdLeUJoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9LWDNSeVlXNXpabVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94T1RjS0lDQWdJQzh2SUdWdGFYUW9ibVYzSUdGeVl6SXdNRjlVY21GdWMyWmxjaWg3SUdaeWIyMDZJSE5sYm1SbGNpd2dkRzg2SUhKbFkybHdhV1Z1ZEN3Z2RtRnNkV1U2SUdGdGIzVnVkQ0I5S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXlOaUF2THlCdFpYUm9iMlFnSW1GeVl6SXdNRjlVY21GdWMyWmxjaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakU1T0FvZ0lDQWdMeThnY21WMGRYSnVJRzVsZHlCQ2IyOXNLSFJ5ZFdVcENpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE9EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qcEJjbU15TURBdVgyRndjSEp2ZG1Gc1MyVjVLRzkzYm1WeU9pQmllWFJsY3l3Z2MzQmxibVJsY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwZllYQndjbTkyWVd4TFpYazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNakF3Q2lBZ0lDQXZMeUJ3Y205MFpXTjBaV1FnWDJGd2NISnZkbUZzUzJWNUtHOTNibVZ5T2lCQlpHUnlaWE56TENCemNHVnVaR1Z5T2lCQlpHUnlaWE56S1RvZ1UzUmhkR2xqUW5sMFpYTThNekkrSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakl3TVFvZ0lDQWdMeThnY21WMGRYSnVJRzVsZHlCVGRHRjBhV05DZVhSbGN6d3pNajRvYjNBdWMyaGhNalUyS0c5d0xtTnZibU5oZENodmQyNWxjaTVpZVhSbGN5d2djM0JsYm1SbGNpNWllWFJsY3lrcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdjMmw2WlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WDJGc2JHOTNZVzVqWlNodmQyNWxjam9nWW5sMFpYTXNJSE53Wlc1a1pYSTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tYMkZzYkc5M1lXNWpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem95TURRS0lDQWdJQzh2SUhCeWIzUmxZM1JsWkNCZllXeHNiM2RoYm1ObEtHOTNibVZ5T2lCQlpHUnlaWE56TENCemNHVnVaR1Z5T2lCQlpHUnlaWE56S1RvZ1ZXbHVkRTR5TlRZZ2V3b2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TWpBMUNpQWdJQ0F2THlCamIyNXpkQ0JyWlhrZ1BTQjBhR2x6TGw5aGNIQnliM1poYkV0bGVTaHZkMjVsY2l3Z2MzQmxibVJsY2lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOWhjSEJ5YjNaaGJFdGxlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEJ3Y205MllXeHpJRDBnUW05NFRXRndQRk4wWVhScFkwSjVkR1Z6UERNeVBpd2dRWEJ3Y205MllXeFRkSEoxWTNRK0tIc2dhMlY1VUhKbFptbDRPaUFuWVNjZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNakEyQ2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11WVhCd2NtOTJZV3h6S0d0bGVTa3VaWGhwYzNSektTQnlaWFIxY200Z2JtVjNJRlZwYm5ST01qVTJLREFwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQmZZV3hzYjNkaGJtTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LWDJGc2JHOTNZVzVqWlY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TWpBM0NpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWhjSEJ5YjNaaGJITW9hMlY1S1M1MllXeDFaUzVoY0hCeWIzWmhiRUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVmWVhCd2NtOTJaU2h2ZDI1bGNqb2dZbmwwWlhNc0lITndaVzVrWlhJNklHSjVkR1Z6TENCaGJXOTFiblE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWDJGd2NISnZkbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TWpFd0NpQWdJQ0F2THlCd2NtOTBaV04wWldRZ1gyRndjSEp2ZG1Vb2IzZHVaWEk2SUVGa1pISmxjM01zSUhOd1pXNWtaWEk2SUVGa1pISmxjM01zSUdGdGIzVnVkRG9nVldsdWRFNHlOVFlwT2lCQ2IyOXNJSHNLSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qSXhNUW9nSUNBZ0x5OGdZMjl1YzNRZ2EyVjVJRDBnZEdocGN5NWZZWEJ3Y205MllXeExaWGtvYjNkdVpYSXNJSE53Wlc1a1pYSXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJmWVhCd2NtOTJZV3hMWlhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveU1USXRNakUyQ2lBZ0lDQXZMeUJqYjI1emRDQmhjSEJ5YjNaaGJFSnZlRG9nUVhCd2NtOTJZV3hUZEhKMVkzUWdQU0J1WlhjZ1FYQndjbTkyWVd4VGRISjFZM1FvZXdvZ0lDQWdMeThnSUNCaGNIQnliM1poYkVGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0J2ZDI1bGNqb2diM2R1WlhJc0NpQWdJQ0F2THlBZ0lITndaVzVrWlhJNklITndaVzVrWlhJc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdjSFZpYkdsaklHRndjSEp2ZG1Gc2N5QTlJRUp2ZUUxaGNEeFRkR0YwYVdOQ2VYUmxjend6TWo0c0lFRndjSEp2ZG1Gc1UzUnlkV04wUGloN0lHdGxlVkJ5WldacGVEb2dKMkVuSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1FaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pJeE53b2dJQ0FnTHk4Z2RHaHBjeTVoY0hCeWIzWmhiSE1vYTJWNUtTNTJZV3gxWlNBOUlHRndjSEp2ZG1Gc1FtOTRMbU52Y0hrb0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakl4T0FvZ0lDQWdMeThnWlcxcGRDaHVaWGNnWVhKak1qQXdYMEZ3Y0hKdmRtRnNLSHNnYjNkdVpYSTZJRzkzYm1WeUxDQnpjR1Z1WkdWeU9pQnpjR1Z1WkdWeUxDQjJZV3gxWlRvZ1lXMXZkVzUwSUgwcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTVOamxtT0RZMUlDOHZJRzFsZEdodlpDQWlZWEpqTWpBd1gwRndjSEp2ZG1Gc0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1qRTVDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJRUp2YjJ3b2RISjFaU2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGc0TUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02T2tGeVl6ZzRMbDlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWElvS1NBdFBpQjJiMmxrT2dwZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklIQjFZbXhwWXlCcGJtbDBhV0ZzYVhwbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRbmwwWlQ0b2V5QnJaWGs2SUNkaGNtTTRPRjl2YVNjZ2ZTa2dMeThnTVNCcFppQnBibWwwYVdGc2FYcGxaQ0FvWlhod2JHbGphWFFnYjNJZ2FXMXdiR2xqYVhRcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ01URWdMeThnSW1GeVl6ZzRYMjlwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNW9ZWE5XWVd4MVpTQjhmQ0IwYUdsekxtbHVhWFJwWVd4cGVtVmtMblpoYkhWbExtNWhkR2wyWlNBOVBUMGdNQ2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dYMlZ1YzNWeVpVUmxabUYxYkhSUGQyNWxjbDlwWmw5aWIyUjVRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhVzVwZEdsaGJHbDZaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtKNWRHVStLSHNnYTJWNU9pQW5ZWEpqT0RoZmIya25JSDBwSUM4dklERWdhV1lnYVc1cGRHbGhiR2w2WldRZ0tHVjRjR3hwWTJsMElHOXlJR2x0Y0d4cFkybDBLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmhjbU00T0Y5dmFTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxtbHVhWFJwWVd4cGVtVmtMbWhoYzFaaGJIVmxJSHg4SUhSb2FYTXVhVzVwZEdsaGJHbDZaV1F1ZG1Gc2RXVXVibUYwYVhabElEMDlQU0F3S1NCN0NpQWdJQ0JpZEc5cENpQWdJQ0JpYm5vZ1gyVnVjM1Z5WlVSbFptRjFiSFJQZDI1bGNsOWhablJsY2w5cFpsOWxiSE5sUURVS0NsOWxibk4xY21WRVpXWmhkV3gwVDNkdVpYSmZhV1pmWW05a2VVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG05M2JtVnlMbWhoYzFaaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dYMlZ1YzNWeVpVUmxabUYxYkhSUGQyNWxjbDloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QndkV0pzYVdNZ2IzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZieWNnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnZEdocGN5NXZkMjVsY2k1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vUjJ4dlltRnNMbU55WldGMGIzSkJaR1J5WlhOektRb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tYMlZ1YzNWeVpVUmxabUYxYkhSUGQyNWxjbDloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdjSFZpYkdsaklHbHVhWFJwWVd4cGVtVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVDZVhSbFBpaDdJR3RsZVRvZ0oyRnlZemc0WDI5cEp5QjlLU0F2THlBeElHbG1JR2x1YVhScFlXeHBlbVZrSUNobGVIQnNhV05wZENCdmNpQnBiWEJzYVdOcGRDa0tJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmhjbU00T0Y5dmFTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QjBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVFubDBaU2d4S1FvZ0lDQWdZbmwwWldNZ01Ua2dMeThnTUhnd01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbDlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZPa0Z5WXpnNExtRnlZemc0WDI5M2JtVnlLQ2tnTFQ0Z1lubDBaWE02Q21GeVl6ZzRYMjkzYm1WeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIUm9hWE11WDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRjlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk9rRnlZemc0TG1GeVl6ZzRYMmx6WDI5M2JtVnlLSEYxWlhKNU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtRnlZemc0WDJselgyOTNibVZ5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TkRFdE5ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak9EaGZhWE5mYjNkdVpYSW9jWFZsY25rNklHRnlZelF1UVdSa2NtVnpjeWs2SUdGeVl6UXVRbTl2YkNCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUIwYUdsekxsOWxibk4xY21WRVpXWmhkV3gwVDNkdVpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2NIVmliR2xqSUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOG5JSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXViM2R1WlhJdWFHRnpWbUZzZFdVcElISmxkSFZ5YmlCdVpYY2dZWEpqTkM1Q2IyOXNLR1poYkhObEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdGeVl6ZzRYMmx6WDI5M2JtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3dNQW9nSUNBZ2NtVjBjM1ZpQ2dwaGNtTTRPRjlwYzE5dmQyNWxjbDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdjSFZpYkdsaklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGloN0lHdGxlVG9nSjJGeVl6ZzRYMjhuSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhKak9EaGZieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdhV1lnS0hSb2FYTXViM2R1WlhJdWRtRnNkV1VnUFQwOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tTa2djbVYwZFhKdUlHNWxkeUJoY21NMExrSnZiMndvWm1Gc2MyVXBDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnUFQwS0lDQWdJR0o2SUdGeVl6ZzRYMmx6WDI5M2JtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3dNQW9nSUNBZ2NtVjBjM1ZpQ2dwaGNtTTRPRjlwYzE5dmQyNWxjbDloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdjSFZpYkdsaklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGloN0lHdGxlVG9nSjJGeVl6ZzRYMjhuSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhKak9EaGZieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJoY21NMExrSnZiMndvZEdocGN5NXZkMjVsY2k1MllXeDFaU0E5UFQwZ2NYVmxjbmtwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qcEJjbU00T0M1aGNtTTRPRjlwYm1sMGFXRnNhWHBsWDI5M2JtVnlLRzVsZDE5dmQyNWxjam9nWW5sMFpYTXBJQzArSUhadmFXUTZDbUZ5WXpnNFgybHVhWFJwWVd4cGVtVmZiM2R1WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvMU1DMDFNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTTRPRjlwYm1sMGFXRnNhWHBsWDI5M2JtVnlLRzVsZDE5dmQyNWxjam9nWVhKak5DNUJaR1J5WlhOektUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhVzVwZEdsaGJHbDZaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtKNWRHVStLSHNnYTJWNU9pQW5ZWEpqT0RoZmIya25JSDBwSUM4dklERWdhV1lnYVc1cGRHbGhiR2w2WldRZ0tHVjRjR3hwWTJsMElHOXlJR2x0Y0d4cFkybDBLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmhjbU00T0Y5dmFTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmhjM05sY25Rb0lTaDBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xtaGhjMVpoYkhWbElDWW1JSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVdWJtRjBhWFpsSUQwOVBTQXhLU3dnSjJGc2NtVmhaSGxmYVc1cGRHbGhiR2w2WldRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWVhKak9EaGZhVzVwZEdsaGJHbDZaVjl2ZDI1bGNsOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhVzVwZEdsaGJHbDZaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtKNWRHVStLSHNnYTJWNU9pQW5ZWEpqT0RoZmIya25JSDBwSUM4dklERWdhV1lnYVc1cGRHbGhiR2w2WldRZ0tHVjRjR3hwWTJsMElHOXlJR2x0Y0d4cFkybDBLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmhjbU00T0Y5dmFTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1lYTnpaWEowS0NFb2RHaHBjeTVwYm1sMGFXRnNhWHBsWkM1b1lYTldZV3gxWlNBbUppQjBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xuWmhiSFZsTG01aGRHbDJaU0E5UFQwZ01Ta3NJQ2RoYkhKbFlXUjVYMmx1YVhScFlXeHBlbVZrSnlrS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZWEpqT0RoZmFXNXBkR2xoYkdsNlpWOXZkMjVsY2w5aWIyOXNYMlpoYkhObFFETUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENncGhjbU00T0Y5cGJtbDBhV0ZzYVhwbFgyOTNibVZ5WDJKdmIyeGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmhjM05sY25Rb0lTaDBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xtaGhjMVpoYkhWbElDWW1JSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVdWJtRjBhWFpsSUQwOVBTQXhLU3dnSjJGc2NtVmhaSGxmYVc1cGRHbGhiR2w2WldRbktRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR0ZzY21WaFpIbGZhVzVwZEdsaGJHbDZaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJoYzNObGNuUW9ibVYzWDI5M2JtVnlJQ0U5UFNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0Nrc0lDZDZaWEp2WDJGa1pISmxjM05mYm05MFgyRnNiRzkzWldRbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjZaWEp2WDJGa1pISmxjM05mYm05MFgyRnNiRzkzWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCd2RXSnNhV01nYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0ZrWkhKbGMzTStLSHNnYTJWNU9pQW5ZWEpqT0RoZmJ5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTQTlJRzVsZDE5dmQyNWxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJSEIxWW14cFl5QnBibWwwYVdGc2FYcGxaQ0E5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UW5sMFpUNG9leUJyWlhrNklDZGhjbU00T0Y5dmFTY2dmU2tnTHk4Z01TQnBaaUJwYm1sMGFXRnNhWHBsWkNBb1pYaHdiR2xqYVhRZ2IzSWdhVzF3YkdsamFYUXBDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlZWEpqT0RoZmIya2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdkR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNTJZV3gxWlNBOUlHNWxkeUJoY21NMExrSjVkR1VvTVNrS0lDQWdJR0o1ZEdWaklERTVJQzh2SURCNE1ERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ21GeVl6ZzRYMmx1YVhScFlXeHBlbVZmYjNkdVpYSmZZbTl2YkY5bVlXeHpaVUF6T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdZWEpqT0RoZmFXNXBkR2xoYkdsNlpWOXZkMjVsY2w5aWIyOXNYMjFsY21kbFFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNlFYSmpPRGd1WVhKak9EaGZkSEpoYm5ObVpYSmZiM2R1WlhKemFHbHdLRzVsZDE5dmQyNWxjam9nWW5sMFpYTXBJQzArSUhadmFXUTZDbUZ5WXpnNFgzUnlZVzV6Wm1WeVgyOTNibVZ5YzJocGNEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qVTRMVFU1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZemc0WDNSeVlXNXpabVZ5WDI5M2JtVnljMmhwY0NodVpYZGZiM2R1WlhJNklHRnlZelF1UVdSa2NtVnpjeWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z2RHaHBjeTVmWlc1emRYSmxSR1ZtWVhWc2RFOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdYMlZ1YzNWeVpVUmxabUYxYkhSUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOakVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBJRDA5UFNCMGFHbHpMbTkzYm1WeUxuWmhiSFZsTENBbmJtOTBYMjkzYm1WeUp5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCd2RXSnNhV01nYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0ZrWkhKbGMzTStLSHNnYTJWNU9pQW5ZWEpqT0RoZmJ5Y2dmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhjbU00T0Y5dklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCaGMzTmxjblFvYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NBOVBUMGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTd2dKMjV2ZEY5dmQyNWxjaWNwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkRjl2ZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklHRnpjMlZ5ZENodVpYZGZiM2R1WlhJZ0lUMDlJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9LU3dnSjNwbGNtOWZZV1JrY21WemMxOXViM1JmWVd4c2IzZGxaQ2NwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUhwbGNtOWZZV1JrY21WemMxOXViM1JmWVd4c2IzZGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnlMblpoYkhWbElEMGdibVYzWDI5M2JtVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdaVzFwZENodVpYY2dZWEpqT0RoZlQzZHVaWEp6YUdsd1ZISmhibk5tWlhKeVpXUW9leUJ3Y21WMmFXOTFjMTl2ZDI1bGNqb2djSEpsZG1sdmRYTXNJRzVsZDE5dmQyNWxjaUI5S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXlOeUF2THlCdFpYUm9iMlFnSW1GeVl6ZzRYMDkzYm1WeWMyaHBjRlJ5WVc1elptVnljbVZrS0dGa1pISmxjM01zWVdSa2NtVnpjeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02T2tGeVl6ZzRMbUZ5WXpnNFgzSmxibTkxYm1ObFgyOTNibVZ5YzJocGNDZ3BJQzArSUhadmFXUTZDbUZ5WXpnNFgzSmxibTkxYm1ObFgyOTNibVZ5YzJocGNEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QjBhR2x6TGw5bGJuTjFjbVZFWldaaGRXeDBUM2R1WlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJmWlc1emRYSmxSR1ZtWVhWc2RFOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnWVhOelpYSjBLRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnUFQwOUlIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0lDZHViM1JmYjNkdVpYSW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIQjFZbXhwWXlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXZKeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklHRnpjMlZ5ZENodVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcElEMDlQU0IwYUdsekxtOTNibVZ5TG5aaGJIVmxMQ0FuYm05MFgyOTNibVZ5SnlrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwWDI5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdjSFZpYkdsaklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGloN0lHdGxlVG9nSjJGeVl6ZzRYMjhuSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhKak9EaGZieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhjbU00T0Y5dklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklIUm9hWE11YjNkdVpYSXVkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk56UUtJQ0FnSUM4dklHVnRhWFFvYm1WM0lHRnlZemc0WDA5M2JtVnljMmhwY0ZKbGJtOTFibU5sWkNoN0lIQnlaWFpwYjNWelgyOTNibVZ5T2lCd2NtVjJhVzkxY3lCOUtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VETTBObUZoTVRZMklDOHZJRzFsZEdodlpDQWlZWEpqT0RoZlQzZHVaWEp6YUdsd1VtVnViM1Z1WTJWa0tHRmtaSEpsYzNNcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qcEJjbU00T0M1aGNtTTRPRjkwY21GdWMyWmxjbDl2ZDI1bGNuTm9hWEJmY21WeGRXVnpkQ2h3Wlc1a2FXNW5PaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZWEpqT0RoZmRISmhibk5tWlhKZmIzZHVaWEp6YUdsd1gzSmxjWFZsYzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvM09DMDNPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTTRPRjkwY21GdWMyWmxjbDl2ZDI1bGNuTm9hWEJmY21WeGRXVnpkQ2h3Wlc1a2FXNW5PaUJoY21NMExrRmtaSEpsYzNNcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZPREFLSUNBZ0lDOHZJSFJvYVhNdVgyVnVjM1Z5WlVSbFptRjFiSFJQZDI1bGNpZ3BDaUFnSUNCallXeHNjM1ZpSUY5bGJuTjFjbVZFWldaaGRXeDBUM2R1WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCaGMzTmxjblFvYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NBOVBUMGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTd2dKMjV2ZEY5dmQyNWxjaWNwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdjSFZpYkdsaklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGloN0lHdGxlVG9nSjJGeVl6ZzRYMjhuSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhKak9EaGZieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzRNUW9nSUNBZ0x5OGdZWE56WlhKMEtHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa2dQVDA5SUhSb2FYTXViM2R1WlhJdWRtRnNkV1VzSUNkdWIzUmZiM2R1WlhJbktRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNSZmIzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJoYzNObGNuUW9jR1Z1WkdsdVp5QWhQVDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdwTENBbmVtVnliMTloWkdSeVpYTnpYMjV2ZEY5aGJHeHZkMlZrSnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z2VtVnliMTloWkdSeVpYTnpYMjV2ZEY5aGJHeHZkMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnY0hWaWJHbGpJSEJsYm1ScGJtZFBkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl3YnljZ2ZTa2dMeThnYjNCMGFXOXVZV3dnZEhkdkxYTjBaWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSmhjbU00T0Y5d2J5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qZ3pDaUFnSUNBdkx5QnBaaUFvZEdocGN5NXdaVzVrYVc1blQzZHVaWEl1YUdGelZtRnNkV1VnSmlZZ2RHaHBjeTV3Wlc1a2FXNW5UM2R1WlhJdWRtRnNkV1VnSVQwOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tTa2dld29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1lYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3WDNKbGNYVmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdjSFZpYkdsaklIQmxibVJwYm1kUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXdieWNnZlNrZ0x5OGdiM0IwYVc5dVlXd2dkSGR2TFhOMFpYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKaGNtTTRPRjl3YnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnYVdZZ0tIUm9hWE11Y0dWdVpHbHVaMDkzYm1WeUxtaGhjMVpoYkhWbElDWW1JSFJvYVhNdWNHVnVaR2x1WjA5M2JtVnlMblpoYkhWbElDRTlQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ2twSUhzS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQWhQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUhCbGJtUnBibWRmZEhKaGJuTm1aWEpmWlhocGMzUnpDZ3BoY21NNE9GOTBjbUZ1YzJabGNsOXZkMjVsY25Ob2FYQmZjbVZ4ZFdWemRGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhCbGJtUnBibWRQZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRV1JrY21WemN6NG9leUJyWlhrNklDZGhjbU00T0Y5d2J5Y2dmU2tnTHk4Z2IzQjBhVzl1WVd3Z2RIZHZMWE4wWlhBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW1GeVl6ZzRYM0J2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUhSb2FYTXVjR1Z1WkdsdVowOTNibVZ5TG5aaGJIVmxJRDBnY0dWdVpHbHVad29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJR1Z0YVhRb2JtVjNJR0Z5WXpnNFgwOTNibVZ5YzJocGNGUnlZVzV6Wm1WeVVtVnhkV1Z6ZEdWa0tIc2djSEpsZG1sdmRYTmZiM2R1WlhJNklIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0lIQmxibVJwYm1kZmIzZHVaWEk2SUhCbGJtUnBibWNnZlNrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UWmlaakZtT1RFZ0x5OGdiV1YwYUc5a0lDSmhjbU00T0Y5UGQyNWxjbk5vYVhCVWNtRnVjMlpsY2xKbGNYVmxjM1JsWkNoaFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pwQmNtTTRPQzVoY21NNE9GOWhZMk5sY0hSZmIzZHVaWEp6YUdsd0tDa2dMVDRnZG05cFpEb0tZWEpqT0RoZllXTmpaWEIwWDI5M2JtVnljMmhwY0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2preUNpQWdJQ0F2THlCMGFHbHpMbDlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQmZaVzV6ZFhKbFJHVm1ZWFZzZEU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdjSFZpYkdsaklIQmxibVJwYm1kUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXdieWNnZlNrZ0x5OGdiM0IwYVc5dVlXd2dkSGR2TFhOMFpYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKaGNtTTRPRjl3YnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXdaVzVrYVc1blQzZHVaWEl1YUdGelZtRnNkV1VzSUNkdWIzUmZjR1Z1WkdsdVoxOXZkMjVsY2ljcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwWDNCbGJtUnBibWRmYjNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qazBDaUFnSUNBdkx5QmpiMjV6ZENCelpXNWtaWElnUFNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnY0hWaWJHbGpJSEJsYm1ScGJtZFBkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl3YnljZ2ZTa2dMeThnYjNCMGFXOXVZV3dnZEhkdkxYTjBaWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSmhjbU00T0Y5d2J5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hObGJtUmxjaUE5UFQwZ2RHaHBjeTV3Wlc1a2FXNW5UM2R1WlhJdWRtRnNkV1VzSUNkdWIzUmZjR1Z1WkdsdVoxOXZkMjVsY2ljcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNSZmNHVnVaR2x1WjE5dmQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qazNDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnlMblpoYkhWbElEMGdjMlZ1WkdWeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QndkV0pzYVdNZ2NHVnVaR2x1WjA5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpnNFgzQnZKeUI5S1NBdkx5QnZjSFJwYjI1aGJDQjBkMjh0YzNSbGNBb2dJQ0FnWW5sMFpXTWdPU0F2THlBaVlYSmpPRGhmY0c4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z2RHaHBjeTV3Wlc1a2FXNW5UM2R1WlhJdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUdWdGFYUW9ibVYzSUdGeVl6ZzRYMDkzYm1WeWMyaHBjRlJ5WVc1elptVnlRV05qWlhCMFpXUW9leUJ3Y21WMmFXOTFjMTl2ZDI1bGNqb2djSEpsZG1sdmRYTXNJRzVsZDE5dmQyNWxjam9nYzJWdVpHVnlJSDBwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobU4yVXpObUl6TnlBdkx5QnRaWFJvYjJRZ0ltRnlZemc0WDA5M2JtVnljMmhwY0ZSeVlXNXpabVZ5UVdOalpYQjBaV1FvWVdSa2NtVnpjeXhoWkdSeVpYTnpLU0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRBd0NpQWdJQ0F2THlCbGJXbDBLRzVsZHlCaGNtTTRPRjlQZDI1bGNuTm9hWEJVY21GdWMyWmxjbkpsWkNoN0lIQnlaWFpwYjNWelgyOTNibVZ5T2lCd2NtVjJhVzkxY3l3Z2JtVjNYMjkzYm1WeU9pQnpaVzVrWlhJZ2ZTa3BDaUFnSUNCaWVYUmxZeUF5TnlBdkx5QnRaWFJvYjJRZ0ltRnlZemc0WDA5M2JtVnljMmhwY0ZSeVlXNXpabVZ5Y21Wa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk9rRnlZemc0TG1GeVl6ZzRYMk5oYm1ObGJGOXZkMjVsY25Ob2FYQmZjbVZ4ZFdWemRDZ3BJQzArSUhadmFXUTZDbUZ5WXpnNFgyTmhibU5sYkY5dmQyNWxjbk5vYVhCZmNtVnhkV1Z6ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z2RHaHBjeTVmWlc1emRYSmxSR1ZtWVhWc2RFOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdYMlZ1YzNWeVpVUmxabUYxYkhSUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVEEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9ibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0E5UFQwZ2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlN3Z0oyNXZkRjl2ZDI1bGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2NIVmliR2xqSUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOG5JSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE1EWUtJQ0FnSUM4dklHRnpjMlZ5ZENodVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcElEMDlQU0IwYUdsekxtOTNibVZ5TG5aaGJIVmxMQ0FuYm05MFgyOTNibVZ5SnlrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwWDI5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdjSFZpYkdsaklIQmxibVJwYm1kUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXdieWNnZlNrZ0x5OGdiM0IwYVc5dVlXd2dkSGR2TFhOMFpYQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltRnlZemc0WDNCdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UQTNDaUFnSUNBdkx5QjBhR2x6TG5CbGJtUnBibWRQZDI1bGNpNTJZV3gxWlNBOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBUUFnQWlZY0JCVWZmSFVnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUhZWEpqT0RoZmJ3RjBBZ0FDQVdJSllYSmpNVFF4TUY5d0RHRnlZekUyTkROZlpHOWpjd0dBQ0dGeVl6ZzRYM0J2QVFBSVlYSmpPRGhmYjJrTFlYSmpNVFF4TUY5dmNHRUNBQUFMWVhKak1UVTVORjlwYzNNTVlYSmpNVFF4TUY5b2NGOWhDbUZ5WXpFME1UQmZiM0FMWVhKak1UWTBNMTlrYjJNQ0FFSUJBUUlBQVFJQVlnSUFCZ1RYL0VxWUNBQUFBQUFBQUFBQUJGd250UHdFZVlQRFhBUkRWZEt0TVJ0QkJJT0NLZ1FSeXpiMUJMRnRlb3dFcDhzMGdnVHN0amJJQkdXeGFDb0VBVEJabXdRVUsxL0xCUGlEanJrRU1ZZ3IrZ1NwektGdkJDWmxsOEFFTmZnVFh3VGFjQ1c1QkQ4bFp4TUVsYlQ1NHdTQXpFbXJCQWVXSVdVRTU0bGgyZ1Q5bElEWEJMR3gxcG9Fd2I3WGlRUTcvaGd6QkZtYzBhVUViZWxCWmdRbzhDUFhCSmRUZ3VJRVpYMFQ3QVMycmhvbEJJVHNFOVVFN0psZ1FRU0M1WFBFQkVxV2o0OEV0VUloSlFTN3N4bnpCQWNDWlU0RTBCVnlUZ1FDbit6QUJITkpNMDRFMjN5Qzd3VDlMQ3h1QkVLbDhHVUVyVTlvNmpZYUFJNHFBMEVETGdNZkF3OERBQUxyQXRZQ3hBS3JBbzhDZndKcEFsTUNOd0loQWdnQjh3SGVBYjhCb0FHSUFXOEJWd0ZDQVNvQkRnRCtBTzRBM2dET0FMc0FvZ0NNQUhZQVpnQlRBRVFBTlFBcEFCb0FEZ0FDSTBNeEdSUkVNUmhFaUEvbklrTXhHUlJFTVJoRWlBK29Ja014R1JSRU1SaEVOaG9CaUE5ZUlrTXhHUlJFTVJoRWlBODJJa014R1JSRU1SaEVOaG9CaUE4RElrTXhHUlJFTVJoRU5ob0JpQTdISWtNeEdSUkVNUmhFTmhvQmlBNk5LRXhRc0NKRE1Sa1VSREVZUklnT2RTaE1VTEFpUXpFWkZFUXhHRVEyR2dFMkdnS0lEV01vVEZDd0lrTXhHUlJFTVJoRU5ob0JOaG9DaUExQUtFeFFzQ0pETVJrVVJERVlSRFlhQVRZYUFqWWFBNGdNK1NoTVVMQWlRekVaRkVReEdFUTJHZ0dJRE4wb1RGQ3dJa014R1JSRU1SaEVpQXpJS0V4UXNDSkRNUmtVUkRFWVJJZ01zU2hNVUxBaVF6RVpGRVF4R0VTSURKRW9URkN3SWtNeEdSUkVNUmhFaUF4eUtFeFFzQ0pETVJrVVJERVlSRFlhQVRZYUFqWWFBellhQklnTUFDaE1VTEFpUXpFWkZFUXhHRVEyR2dFMkdnSTJHZ00yR2dTSUN4UWlRekVaRkVReEdFUTJHZ0UyR2dJMkdnT0lDbmNpUXpFWkZFUXhHRVEyR2dFMkdnSTJHZ00yR2dTSUNjc2lRekVaRkVReEdFUTJHZ0UyR2dJMkdnT0lDWDRvVEZDd0lrTXhHUlJFTVJoRU5ob0JOaG9DTmhvRE5ob0VpQWxKSWtNeEdSUkVNUmhFTmhvQk5ob0NOaG9ETmhvRU5ob0ZpQVgxS0V4UXNDSkRNUmtVUkRFWVJEWWFBVFlhQWpZYUF6WWFCRFlhQllnRmNDaE1VTEFpUXpFWkZFUXhHRVEyR2dFMkdnSTJHZ09JQlRZaVF6RVpGRVF4R0VRMkdnRTJHZ0kyR2dPSUJRZ2lRekVaRkVReEdFUTJHZ0UyR2dJMkdnT0lCSlFvVEZDd0lrTXhHUlJFTVJoRU5ob0JOaG9DaUFSaEtFeFFzQ0pETVJrVVJERVlSRFlhQVRZYUFqWWFBellhQklnRUtpaE1VTEFpUXpFWkZFUXhHRVEyR2dFMkdnS0lBL29vVEZDd0lrTXhHUlJFTVJoRU5ob0JOaG9DaUFQVktFeFFzQ0pETVJrVVJERVlSSWdEdnloTVVMQWlRekVaRkVReEdFUTJHZ0UyR2dJMkdnTTJHZ1NJQTVZb1RGQ3dJa014R1JSRU1SaEVOaG9CTmhvQ05ob0RpQU55S0V4UXNDSkRNUmtVUkRFWVJEWWFBVFlhQW9nQytTSkRNUmtVUkRFWVJEWWFBVFlhQWpZYUE0Z0NaU0pETVJrVVJERVlSRFlhQVRZYUFqWWFBNGdDQmlKRE1Sa1VSREVZUkRZYUFZZ0I2eUpETVJrVVJERVlSSWdCenloTVVMQWlRekVaRkVReEdFUTJHZ0dJQVY0aVF6RVpGRVF4R0VRMkdnR0lBVDhvVEZDd0lrTXhHUlJFTVJoRU5ob0JOaG9DTmhvRGlBQ0RJa014R1VEOHBURVlGRVFpUTRvREFZdjlJMWxKaS84SVRDVUxKUWhMQVJaWEJnSk9Bb3Y5SlVzQ1Vvdi9KUXV2VUl2OUZZdjlUd05QQWxKUWkvNVFUQ1VMU1NOTWl3T0xBZ3hCQUNPTEJFa1dWd1lDaXdHTEEwbE9CRThDWFVtTUFVc0JXU1VJQ0l3RUpRaU1BMEwvMVlzQWl3RlFqQUNKTVFDSUN4d2pVeUlTUkltS0F3Q0kvKytML1JWSlJESUdGb3YrRlVsT0FvRU1DQlpYQmdLQUFnQU1URkJNVUl2K1VJdi9VQ2NSaS8xUVNieElUTDhuQjcxRkFVQUFQaWNOaS8waWlQOUhKd2U4U0NjSFRMK0JCb3NBQ0VrV1Z3WUNKeFpNVUV5TEFRZ1dWd1lDVUl2OVVJditVSXYvVUNjRVRGQ0FCQzNBUERaTVVMQ0pKd2UrUkNjTmkvMGlpUDhGU1NOWlRGY0NBRXNCSlF0TEFSVlNUSWorOGljSHZFZ25CMHkvUXYrb2lnRUJKeEdMLzFCSnZVVUJSTDVFaVlvQkFJai9QQ2NSaS85UVNiMUZBVVJKdmtSTXZFaEpJMWxMQVNWWlN3SlBBa3NDVWtzQ0ZVOERUd05QQWxLTC94V0JCZ2hKRmxjR0FpY1dURkJMQXhWUEFnZ1dWd1lDVUl2L1VFOENVRXhRSndSTVVJQUVybnBQb0V4UXNJa25CNzVFaVRFQWlBbjdJMU1pRWtTSmlnRUFpUC92Snc2TC8yZUppZ01BaVAvamkvNkFBS1ZFSXljT1pVVUJRUUF4SXljT1pVUWpVeUlTUVFBbElrU0wvU21ML292L2lBWUhpLzJML2xBbkVsQ0wvMUFuQkV4UWdBVHk2Wml2VEZDd2lTTkMvOWlLQXdBak1RQkppLzBTUUFBTWl3R0lDWTBqVXlJU1FRQmlJa1NML29BQXBVUW5CWXY5VUVtTUFMMUZBVUVBU0lzQXZrU0wvcWRCQUQ0aVJJc0FTYjVFaS82aFNSVWtEa1FrcjB4TEFhdFBBa3kvSXl0bFJJditvVWtWSkE1RXF5dE1aNHY5aS81UUp4SlFpLzlRSndSTVVDY1hURkN3aVNOQy83OGpRditiaWdJQU1RQkppLzZBQUtWRUp3Vk1VRW05UlFGQkFFaUxBYjVFaS82blFRQStJa1NMQVVtK1JJditvVWtWSkE1RUpLOU1Td0dyVHdKTXZ5TXJaVVNML3FGSkZTUU9SS3NyVEdlTEFJditVQ2NTVUl2L1VDY0VURkFuRjB4UXNJa2pRdisvaWdNQmkvMkwvb2dBSTRtS0JBR0wvSXY5aS82SUIyZUpJeWNPWlVTSmlnSUJpLzZMLzFBbkJreFF2a1NKaWdJQk1RQXBpLzRwaS84bkRZZ0Q4REVBaS82TC80Z0hsb21LQkFFeEFJdjlpL3lJQXJoTWkveUwvVXNEaS82TC80Z0R6SW1LQWdHTC9vdi9VQ2NQVEZCSnZVVUJRQUFFSncxTWlZc0F2a1JNaVlvREFTTkhBb3YraS8wU1FRQUZKd2lNQUltTC9ZditVRW1NQUl2L1VDY1FURkJKakFHOVJRRkJBQStMQWI1RUZ5SVNRUUFGSndpTUFJbUxBQ2xRSnhCTVVFbU1BcjFGQVVFQUQ0c0N2a1FYSWhKQkFBVW5DSXdBaVNjS2pBQ0ppZ01BTVFDTC9SSkVpLzJML2xDTC8xQW5FRXhRSnhPL2lZb0RBREVBaS8wU1JJdjlpLzVRaS85UUp4Qk1VRW05UlFGQkFBU0xBTHhJaVlvRkFTTXhBSXY3TVFDTC9Jai9XQ05USWhKSEFrQUFNb3Y3aXdGUWkveFFKd3hNVUVtTUFMMUZBVUVBR1lzQVNiNUVTWXYrcDBRaWpBS0wvcUZKRlNRT1JDU3ZxNytMQW93RGl3TkVpLzJML0lnQm40djdpL3lML1VzRGkvNkwvNGdDc293QWlZb0ZBU05KZ0FCSmkvdUwvRkFuQmt4UVNiMUZBVUFBUG9BNVVBQWpBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUZGQmhjblJwZEdsdmJpQnViM1FnWlhocGMzUnpqQUNKaXdTK1JJditwRUVBUG9BNVVnQWpBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUZFbHVjM1ZtWm1samFXVnVkQ0JpWVd4aGJtTmxqQUNKaS8wcEVrRUFPb0ExVndBakFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUVsdWRtRnNhV1FnY21WalpXbDJaWEtNQUlreEFFbU1BSXY3RTBFQWhvdjdpd0NML0lqK0RpTlRJaEpKakFKSmpBTkFBQ3FMKzRzQVVJdjhVQ2NNVEZCSmpBRzlSUUdMQW93RFFRQVJpd0crUkl2K3AwRUFBeUtNQW9zQ2pBT0xBMEFBUVlBOFdBQWpBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUYwOXdaWEpoZEc5eUlHNXZkQ0JoZFhSb2IzSnBlbVZrakFDSmkvMkwvSWdBRm9BRFVRQWpURkNBQ1FBSFUzVmpZMlZ6YzFDTUFJbUtBZ0VwaS82TC8xQW5Ca3hRdlVVQlFRQUVpLytNQUlzQVRJbUtBZ0FqUndTQUFFY0VnQXhoY21NeE5ERXdYMmh3WDNDTC9sQkp2VVVCUUFBRml3b25HTCtMQ3I1TWpBSkVJNHdHSnhpTUFZc0JGMG1NQ0lzQ0YwbU1DUXhCQUUrTC9vc0JVQ2NQVEZCSmpBUzlSUUZBQUF3bkZJdi9VSXNFU2J4SVRMK0xCTDVNU1U0Q2pBQkVJMW1NQlNPTUI0c0hpd1VNUVFDSGl3QlhBZ0NMQnlRTEpGaUwveEpCQUcwaVFRQmZJb3dHaXdaQUFEaUwvb3NDVUNjUFRGQkpqQU8rUkNOWkZoZUJDZ3hCQUNHTEEwbStSRmNDQUNjVWkvOVFWd0lBVUVrVkpBb1dWd1lDVEZCTEFieEl2NG1MQ1NJSUZvc0tTd0cvaS81TVVDY1VpLzlRSnc5UEFsQkp2RWhNdjRtTENDSUlGb3dCUXY4N2l3Y2lDSXdIUXY5eEkwTC9oNG9HQUNOSmkvNkFBS1ZFaS9xTCsxQW5Ca3hRU2IxRkFVQUFCSXNDS2IrTEFrbStSSXYrb1VrVkpBNUVKSzlKakFDcnY0djZpL3hRaS90UWkvNVFnQUlBZ2xDTC8xQW5CRXhRZ0FRZ2EzbEFURkN3aS8yTCt4TkJBQWVML0l2OWlQNlhpL3lML1ZBbkJreFFTWXdCdlVVQlFBQUVpd0VwdjRzQlNiNUVpLzZnU1JVa0RrU0xBS3UvaVlvRUFERUFpL3dTUkl2OGkvMVFpLzVRSnd4TVVJdi92NG1LQXdFamkvNkwvUkpCQUFRbkNFeUppLzJML2xDTC8xQW5ERXhRU1l3QXZVVUJRQUFFSndwTWlZc0F2a1NBQUtVbkNpTlBBbFJNaVlvRUFDTkpNUUNJQTZzalV5SVNSSXYrZ0FDbFJJdjhpLzFRU1NjR1RGQkp2VVVCUUFBTGl3TXB2NHY4aS8ySS9lMkxBMG0rUkl2K29Fa1ZKQTVFSks5SmpBQ3J2eWNGaS94UVNZd0J2VVVCUUFBRWl3RXB2NHNCU2I1RWkvNmdTUlVrRGtTTEFFbE9BNnUvSXl0bFJJditvRWtWSkE1RXF5dE1aNHNDaS81UUp4VlFpLzlRSndSTVVJQUUra1E3RzB4UXNJbUtBd0F4QUl2K2dBQ2xSRW1ML1ZCSlRnSW5Ca3hRU2IxRkFVUkp2a1NML3FkRVNiNUVpLzZoU1JVa0RrUWtyMGxPQkt1L0p3Vk1VRW05UlFGQkFFV0xBcjVFaS82blFRQTdJa1NMQWttK1JJditvVWtWSkE1RWl3RkpUZ09ydnlNclpVU0wvcUZKRlNRT1JLc3JUR2VMQUl2K1VDY1ZVSXYvVUNjRVRGQW5HVXhRc0lralF2L0NpZ1FBSTBjRE1RQ0wvREVBaS8ySStrb2pVeUlTUndKQUFES0wvSXNFVUl2OVVDY01URkJKakFPOVJRRkJBQm1MQTBtK1JFbUwvcWRFSW93RmkvNmhTUlVrRGtRa3I2dS9pd1dNQm9zR1JJdjhpLzFRU1l3Qkp3Wk1VRW05UlFGRVNiNUVpLzZuUkVtK1JJditvVWtWSkE1RUpLOUpqQUNydnljRmkveFFTWXdDdlVVQlFRQkZpd0srUkl2K3AwRUFPeUpFaXdKSnZrU0wvcUZKRlNRT1JJc0FTVTREcTc4aksyVkVpLzZoU1JVa0RrU3JLMHhuaXdHTC9sQW5GVkNMLzFBbkJFeFFKeGxNVUxDSkkwTC93b29FQVRFQU1na1NSSXY4VndJQUZVbEVKQTVFaS8xWEFnQVZTVVNCQ0E1RUl5dGxSUUVVUklBQmJvdjhaNEFCYzR2OVp5dUwvMmVBQVdTTC9tY3hBQ2NGU3dGUWkvKy9NZ05NVUl2L1VDY2FURkN3SndpSkk0QUJibVZFVndJQVNSVWtFa1NKSTRBQmMyVkVWd0lBU1JXQkNCSkVpU09BQVdSbFJJa2pLMlZFaVlvQkFZdi9pQUJIaVlvREFURUFpLzFMQVlnQXQwbUwvNmRFaS8raFNSVWtEa1FrcjZ1TC9VNENpQURDU0l2OWkvNkwvNGdBTVltS0FnRXhBSXYraS8rSUFLdUppZ0lCaS82TC80Z0Fmb21LQVFFbkJZdi9VRW05UlFGQUFBTXBUSW1MQUw1RVRJbUtBd0dML1lqLzRFbUwvb2ovMmt5TC82ZEVpLzJML2hOQkFDbUxBSXYvb1VrVkpBNUVKSzlNU3dHckp3V0wvVkJNdjRzQmkvK2dTUlVrRGtTckp3V0wvbEJNdjR2OWkvNVFpLzlRSnhwTVVMQW5DSXdBaVlvQ0FZditpLzlRQVVrVkpCSkVpWW9DQVl2K2kvK0kvK2VBQVdGTVVFbTlSUUZBQUFNcFRJbUxBTDVFVndBZ1RJbUtBd0dML1l2K2lQL0ZpLytML1ZDTC9sQ0FBV0ZQQWxCTXY0djlpLzVRaS85UWdBUVphZmhsVEZDd0p3aUpJeWNMWlVVQlFRQUpJeWNMWlVRWFFBQVJJeXBsUlFGQUFBUXFNZ2xuSndzbkUyZUppUC9aSXlwbFJJbUtBUUdJLzg0akttVkZBVUFBQXljS2lTTXFaVVFwRWtFQUF5Y0tpU01xWlVTTC94SW5DaU5QQWxTSmlnRUFJeWNMWlVVQlFRQWRJeWNMWlVRWEloSkJBQklpRkVTTC95a1RSQ3FMLzJjbkN5Y1RaNGtqUXYvcmlnRUFpUDkyTVFBakttVkVFa1NML3lrVFJDTXFaVVFxaS85bmkvOVFKeHRNVUxDSmlQOVZNUUFqS21WRUVrUWpLbVZFS2lsbmdBUTBhcUZtVEZDd2lZb0JBSWovTmpFQUl5cGxSQkpFaS84cEUwUWpKd2xsUlFGQkFBa2pKd2xsUkNrVEZFUW5DWXYvWnlNcVpVU0wvMUNBQkJhL0g1Rk1VTENKaVA3K0l5Y0paVVVCUkRFQUl5Y0paVVJMQVJKRUl5cGxSQ3BMQW1jbkNTbG5URkNBQlBmamF6ZExBVkN3Snh0TVVMQ0ppUDdMTVFBakttVkVFa1FuQ1NsbmlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJEb2N1bWVudFVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGJ5dGVbXSxzdHJpbmcsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE2NDNfZG9jdW1lbnRfdXBkYXRlZF9ldmVudCIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJEb2N1bWVudFJlbW92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGJ5dGVbXSxzdHJpbmcsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE2NDNfZG9jdW1lbnRfcmVtb3ZlZF9ldmVudCIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJJc3N1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE0MTBfcGFydGl0aW9uX2lzc3VlIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Iklzc3VlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE1OTRfaXNzdWVfZXZlbnQiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE1OTRfcmVkZWVtX2V2ZW50IiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl90cmFuc2ZlciIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzIwMF9BcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlW10pIiwic3RydWN0IjoiYXJjMTQxMF9wYXJ0aXRpb25fcmVkZWVtIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzg4X093bmVyc2hpcFJlbm91bmNlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVyUmVxdWVzdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZW5kaW5nX293bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBUcmFuc2ZlckFjY2VwdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
