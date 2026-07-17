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

namespace Arc56.Generated.scholtz.arc_1400.Arc1410_a1ba3825
{


    public class Arc1410Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc1410Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

        }

        public class Events
        {
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

            public class RedeemEvent
            {
                public static readonly byte[] Selector = new byte[4] { 92, 39, 180, 252 };
                public const string Signature = "Redeem((address,address,uint256,byte[]))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1410PartitionRedeem Field0 { get; set; }

                public static RedeemEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RedeemEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.Arc1410PartitionRedeem.Parse(eventData.Skip(indexField0).ToArray());
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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjMTQxMCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBcHByb3ZhbFN0cnVjdCI6W3sibmFtZSI6ImFwcHJvdmFsQW1vdW50IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic3BlbmRlciIsInR5cGUiOiJhZGRyZXNzIn1dLCJhcmMxNDEwX0hvbGRpbmdQYXJ0aXRpb25zUGFnaW5hdGVkS2V5IjpbeyJuYW1lIjoiaG9sZGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYWdlIiwidHlwZSI6InVpbnQ2NCJ9XSwiYXJjMTQxMF9PcGVyYXRvcktleSI6W3sibmFtZSI6ImhvbGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoib3BlcmF0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhcnRpdGlvbiIsInR5cGUiOiJhZGRyZXNzIn1dLCJhcmMxNDEwX09wZXJhdG9yUG9ydGlvbktleSI6W3sibmFtZSI6ImhvbGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoib3BlcmF0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhcnRpdGlvbiIsInR5cGUiOiJhZGRyZXNzIn1dLCJhcmMxNDEwX1BhcnRpdGlvbktleSI6W3sibmFtZSI6ImhvbGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicGFydGl0aW9uIiwidHlwZSI6ImFkZHJlc3MifV0sImFyYzE0MTBfY2FuX3RyYW5zZmVyX2J5X3BhcnRpdGlvbl9yZXR1cm4iOlt7Im5hbWUiOiJjb2RlIiwidHlwZSI6ImJ5dGUifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicmVjZWl2ZXJQYXJ0aXRpb24iLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiYXJjMTQxMF9wYXJ0aXRpb25faXNzdWUiOlt7Im5hbWUiOiJ0byIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicGFydGl0aW9uIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImRhdGEiLCJ0eXBlIjoiYnl0ZVtdIn1dLCJhcmMxNDEwX3BhcnRpdGlvbl9yZWRlZW0iOlt7Im5hbWUiOiJmcm9tIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYXJ0aXRpb24iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGF0YSIsInR5cGUiOiJieXRlW10ifV0sImFyYzE0MTBfcGFydGl0aW9uX3RyYW5zZmVyIjpbeyJuYW1lIjoiZnJvbSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidG8iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhcnRpdGlvbiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJkYXRhIiwidHlwZSI6ImJ5dGVbXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJhcmMxNDEwX2JhbGFuY2Vfb2ZfcGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob2xkZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfdHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl90cmFuc2ZlciIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX3RyYW5zZmVyX2J5X3BhcnRpdGlvbiIsImRlc2MiOiJUcmFuc2ZlciBhbiBhbW91bnQgb2YgdG9rZW5zIGZyb20gcGFydGl0aW9uIHRvIHJlY2VpdmVyLiBTZW5kZXIgbXVzdCBiZSBtc2cuc2VuZGVyIG9yIGF1dGhvcml6ZWQgb3BlcmF0b3IuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE0MTBfcGFydGl0aW9uX3RyYW5zZmVyIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX3BhcnRpdGlvbnNfb2YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFnZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfaXNfb3BlcmF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTQxMF9hdXRob3JpemVfb3BlcmF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfcmV2b2tlX29wZXJhdG9yIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob2xkZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX29wZXJhdG9yX3RyYW5zZmVyX2J5X3BhcnRpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlW10pIiwic3RydWN0IjoiYXJjMTQxMF9wYXJ0aXRpb25fdHJhbnNmZXIiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfY2FuX3RyYW5zZmVyX2J5X3BhcnRpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlLHN0cmluZyxhZGRyZXNzKSIsInN0cnVjdCI6ImFyYzE0MTBfY2FuX3RyYW5zZmVyX2J5X3BhcnRpdGlvbl9yZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX2F1dGhvcml6ZV9vcGVyYXRvcl9ieV9wb3J0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob2xkZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX2lzX29wZXJhdG9yX2J5X3BvcnRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTQxMF9pc3N1ZV9ieV9wYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJJc3N1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE0MTBfcGFydGl0aW9uX2lzc3VlIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX3JlZGVlbV9ieV9wYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlW10pIiwic3RydWN0IjoiYXJjMTQxMF9wYXJ0aXRpb25fcmVkZWVtIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX29wZXJhdG9yX3JlZGVlbV9ieV9wYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlZGVlbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE0MTBfcGFydGl0aW9uX3JlZGVlbSIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWNpbWFscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsU3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfbmFtZSIsImRlc2MiOiJSZXR1cm5zIHRoZSBuYW1lIG9mIHRoZSB0b2tlbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBuYW1lIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3N5bWJvbCIsImRlc2MiOiJSZXR1cm5zIHRoZSBzeW1ib2wgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbOF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc3ltYm9sIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2RlY2ltYWxzIiwiZGVzYyI6IlJldHVybnMgdGhlIGRlY2ltYWxzIG9mIHRoZSB0b2tlbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBkZWNpbWFscyBvZiB0aGUgdG9rZW4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF90b3RhbFN1cHBseSIsImRlc2MiOiJSZXR1cm5zIHRoZSB0b3RhbCBzdXBwbHkgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgdG90YWwgc3VwcGx5IG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2JhbGFuY2VPZiIsImRlc2MiOiJSZXR1cm5zIHRoZSBjdXJyZW50IGJhbGFuY2Ugb2YgdGhlIG93bmVyIG9mIHRoZSB0b2tlbiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIG93bmVyIG9mIHRoZSB0b2tlbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGN1cnJlbnQgYmFsYW5jZSBvZiB0aGUgaG9sZGVyIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3RyYW5zZmVyRnJvbSIsImRlc2MiOiJUcmFuc2ZlcnMgdG9rZW5zIGZyb20gc291cmNlIHRvIGRlc3RpbmF0aW9uIGFzIGFwcHJvdmVkIHNwZW5kZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjoiVGhlIHNvdXJjZSBvZiB0aGUgdHJhbnNmZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOiJUaGUgZGVzdGluYXRpb24gb2YgdGhlIHRyYW5zZmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjoiQW1vdW50IG9mIHRva2VucyB0byB0cmFuc2ZlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzIwMF9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF9hcHByb3ZlIiwiZGVzYyI6IkFwcHJvdmUgc3BlbmRlciBmb3IgYSB0b2tlbiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOiJXaG8gaXMgYWxsb3dlZCB0byB0YWtlIHRva2VucyBvbiBvd25lcidzIGJlaGFsZiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6IkFtb3VudCBvZiB0b2tlbnMgdG8gYmUgdGFrZW4gYnkgc3BlbmRlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfYWxsb3dhbmNlIiwiZGVzYyI6IlJldHVybnMgdGhlIGN1cnJlbnQgYWxsb3dhbmNlIG9mIHRoZSBzcGVuZGVyIG9mIHRoZSB0b2tlbnMgb2YgdGhlIG93bmVyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOiJPd25lcidzIGFjY291bnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6IldobyBpcyBhbGxvd2VkIHRvIHRha2UgdG9rZW5zIG9uIG93bmVyJ3MgYmVoYWxmIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgcmVtYWluaW5nIGFsbG93YW5jZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjODhfb3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9pc19vd25lciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVlcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9pbml0aWFsaXplX293bmVyIiwiZGVzYyI6IkV4cGxpY2l0IGluaXRpYWxpemF0aW9uIG92ZXJyaWRlIChjcmVhdGlvbiBncm91cCByZWNvbW1lbmRlZCkuIEZhaWxzIGlmIGFscmVhZHkgaW5pdGlhbGl6ZWQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjODhfdHJhbnNmZXJfb3duZXJzaGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9yZW5vdW5jZV9vd25lcnNoaXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzg4X093bmVyc2hpcFJlbm91bmNlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF90cmFuc2Zlcl9vd25lcnNoaXBfcmVxdWVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVuZGluZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjODhfT3duZXJzaGlwVHJhbnNmZXJSZXF1ZXN0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlbmRpbmdfb3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9hY2NlcHRfb3duZXJzaGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBUcmFuc2ZlckFjY2VwdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9jYW5jZWxfb3duZXJzaGlwX3JlcXVlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjo3fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMDU3LDExMzgsMTE4NywxMjE5LDEzNDMsMTQ4NSwxNjgwLDE4NjUsMTkyOCwxOTg2LDIwMDEsMjExOCwyMjA3LDIyOTAsMjM1NSwyMzkzLDI0NzksMjQ4NiwyNTE2LDI1MjksMjYzNywyNjg0LDI2OTEsMjcyNCwyNzM3LDMwMjEsMzE1M10sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTU0LDMxNTRdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MjQsMjczMl0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA0Ml0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIGF0IHRoZSBzZW5kZXIgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0ODMsMjY4OF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBwYXJ0aXRpb24gYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwOTMsMjMyMiwyNDYwXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBhbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODEwXSwiZXJyb3JNZXNzYWdlIjoiTmFtZSBvZiB0aGUgYXNzZXQgbXVzdCBiZSBsb25nZXIgb3IgZXF1YWwgdG8gMSBjaGFyYWN0ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODEzXSwiZXJyb3JNZXNzYWdlIjoiTmFtZSBvZiB0aGUgYXNzZXQgbXVzdCBiZSBzaG9ydGVyIG9yIGVxdWFsIHRvIDMyIGNoYXJhY3RlcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzcwLDI2NjRdLCJlcnJvck1lc3NhZ2UiOiJOb3QgYXV0aG9yaXplZCBvcGVyYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5OSw0MTEsNDIzLDQzOCw0NTAsNDY1LDQ4MCw0OTksNTE1LDUzNyw1NTksNTg0LDYwMyw2MTksNjM1LDY1MSw2NjcsNjk1LDcxOSw3NDAsNzY0LDc4OSw4MTMsODQ0LDg3NSw4OTYsOTE3LDk0Miw5NjQsOTkyLDEwMTRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODAyXSwiZXJyb3JNZXNzYWdlIjoiT25seSBkZXBsb3llciBvZiB0aGlzIHNtYXJ0IGNvbnRyYWN0IGNhbiBjYWxsIGJvb3RzdHJhcCBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjQ0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBob2xkZXIgY2FuIGF1dGhvcml6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMjldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGhvbGRlciBjYW4gYXV0aG9yaXplIHBvcnRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjY5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBob2xkZXIgY2FuIHJldm9rZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NzYsMjY4MV0sImVycm9yTWVzc2FnZSI6IlBhcnRpdGlvbiBiYWxhbmNlIG1pc3NpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzQ4LDI2NDJdLCJlcnJvck1lc3NhZ2UiOiJQb3J0aW9uIGFsbG93YW5jZSBleGNlZWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MjFdLCJlcnJvck1lc3NhZ2UiOiJTeW1ib2wgb2YgdGhlIGFzc2V0IG11c3QgYmUgbG9uZ2VyIG9yIGVxdWFsIHRvIDEgY2hhcmFjdGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgyNF0sImVycm9yTWVzc2FnZSI6IlN5bWJvbCBvZiB0aGUgYXNzZXQgbXVzdCBiZSBzaG9ydGVyIG9yIGVxdWFsIHRvIDggY2hhcmFjdGVycyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MzFdLCJlcnJvck1lc3NhZ2UiOiJUaGlzIG1ldGhvZCBjYW4gYmUgY2FsbGVkIG9ubHkgb25jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMTddLCJlcnJvck1lc3NhZ2UiOiJhbHJlYWR5X2luaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0MV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMiw0MTQsNDI2LDQ0MSw0NTMsNDY4LDQ4Myw1MDIsNTE4LDU0MCw1NjIsNTg3LDYwNiw2MjIsNjM4LDY1NCw2NzAsNjk4LDcyMiw3NDMsNzY3LDc5Miw4MTYsODQ3LDg3OCw4OTksOTIwLDk0NSw5NjcsOTk1LDEwMTddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQxMiwyNTQ4LDI3NTYsMjg4NCwyODk5LDI5MTQsMjkxOSwzMjE4LDMyNDcsMzI2OSwzMjgxLDMzMDgsMzM0OCwzMzU5LDMzODEsMzM4NywzNDEyLDM0MzMsMzQ0NiwzNDc2LDM0ODQsMzUxOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NDZdLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnQgYXBwcm92YWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODkyLDI5MDcsMzEyM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgc2l6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNTAsMzM4MywzNDE0LDM1MjFdLCJlcnJvck1lc3NhZ2UiOiJub3Rfb3duZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDY5LDM0ODBdLCJlcnJvck1lc3NhZ2UiOiJub3RfcGVuZGluZ19vd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMTZdLCJlcnJvck1lc3NhZ2UiOiJvbmx5X293bmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1OSwyMTI2LDIyMTUsMjM2MywyNDAxLDI0MjAsMjQ5NCwyNTM3LDI1NTYsMjY1MywyNjk5LDI3NDUsMjc2NCwyOTU0LDMwNjAsMzA4M10sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQzN10sImVycm9yTWVzc2FnZSI6InBlbmRpbmdfdHJhbnNmZXJfZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMyMiwzMzU1LDM0MTldLCJlcnJvck1lc3NhZ2UiOiJ6ZXJvX2FkZHJlc3Nfbm90X2FsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRE15SURnS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdJbUZ5WXpnNFgyOGlJQ0owSWlBaVlYSmpNVFF4TUY5d0lpQXdlRGd3SUNKaUlpQWlZWEpqT0RoZmNHOGlJREI0TURBZ0ltRnlZemc0WDI5cElpQWlZWEpqTVRReE1GOXZjR0VpSUNKaGNtTXhOREV3WDJod1gyRWlJQ0poY21NeE5ERXdYMjl3SWlBd2VEQXdNRElnTUhnd01TQXdlREF3TURFZ01IZ3dNRFl5SURCNE1EQXdNQ0F3ZURBd01EQXdNREF3TURBd01EQXdNREFnTUhnMVl6STNZalJtWXlBd2VEYzVPRE5qTXpWaklEQjRORE0xTldReVlXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREV3SUdWNGRHVnVaSE1nUVhKak1qQXdJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEF6T0FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURNMVpqZ3hNelZtSURCNFpHRTNNREkxWWprZ01IZ3paakkxTmpjeE15QXdlRGsxWWpSbU9XVXpJREI0T0RCall6UTVZV0lnTUhnd056azJNakUyTlNBd2VHVTNPRGsyTVdSaElEQjRabVE1TkRnd1pEY2dNSGhpTVdJeFpEWTVZU0F3ZUdNeFltVmtOemc1SURCNE0ySm1aVEU0TXpNZ01IZzFPVGxqWkRGaE5TQXdlRFprWlRrME1UWTJJREI0TWpobU1ESXpaRGNnTUhnNU56VXpPREpsTWlBd2VEWTFOMlF4TTJWaklEQjRZalpoWlRGaE1qVWdNSGc0TkdWak1UTmtOU0F3ZUdWak9UazJNRFF4SURCNE9ESmxOVGN6WXpRZ01IZzBZVGsyT0dZNFppQXdlR0kxTkRJeU1USTFJREI0WW1KaU16RTVaak1nTUhnd056QXlOalUwWlNBd2VHUXdNVFUzTWpSbElEQjRNREk1Wm1Wall6QWdNSGczTXpRNU16TTBaU0F3ZUdSaU4yTTRNbVZtSURCNFptUXlZekpqTm1VZ01IZzBNbUUxWmpBMk5TQXdlR0ZrTkdZMk9HVmhJQzh2SUcxbGRHaHZaQ0FpWVhKak1UUXhNRjlpWVd4aGJtTmxYMjltWDNCaGNuUnBkR2x2YmloaFpHUnlaWE56TEdGa1pISmxjM01wZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWVhKak1qQXdYM1J5WVc1elptVnlLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbGliMjlzSWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJpaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTml4aWVYUmxXMTBwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpWVhKak1UUXhNRjl3WVhKMGFYUnBiMjV6WDI5bUtHRmtaSEpsYzNNc2RXbHVkRFkwS1dGa1pISmxjM05iWFNJc0lHMWxkR2h2WkNBaVlYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNpaGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0poY21NeE5ERXdYMkYxZEdodmNtbDZaVjl2Y0dWeVlYUnZjaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDNKbGRtOXJaVjl2Y0dWeVlYUnZjaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJpaGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEdKNWRHVmJYU2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0poY21NeE5ERXdYMk5oYmw5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNG9ZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTml4aWVYUmxXMTBwS0dKNWRHVXNjM1J5YVc1bkxHRmtaSEpsYzNNcElpd2diV1YwYUc5a0lDSmhjbU14TkRFd1gyRjFkR2h2Y21sNlpWOXZjR1Z5WVhSdmNsOWllVjl3YjNKMGFXOXVLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2w5aWVWOXdiM0owYVc5dUtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbUZ5WXpFME1UQmZhWE56ZFdWZllubGZjR0Z5ZEdsMGFXOXVLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMkxHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0poY21NeE5ERXdYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjRvWVdSa2NtVnpjeXgxYVc1ME1qVTJMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI0b1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltSnZiM1J6ZEhKaGNDaGllWFJsVzEwc1lubDBaVnRkTEhWcGJuUTRMSFZwYm5ReU5UWXBZbTl2YkNJc0lHMWxkR2h2WkNBaVlYSmpNakF3WDI1aGJXVW9LV0o1ZEdWYk16SmRJaXdnYldWMGFHOWtJQ0poY21NeU1EQmZjM2x0WW05c0tDbGllWFJsV3poZElpd2diV1YwYUc5a0lDSmhjbU15TURCZlpHVmphVzFoYkhNb0tYVnBiblE0SWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmZEc5MFlXeFRkWEJ3Ykhrb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltRnlZekl3TUY5aVlXeGhibU5sVDJZb1lXUmtjbVZ6Y3lsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmZEhKaGJuTm1aWEpHY205dEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbUZ5WXpJd01GOWhjSEJ5YjNabEtHRmtaSEpsYzNNc2RXbHVkREkxTmlsaWIyOXNJaXdnYldWMGFHOWtJQ0poY21NeU1EQmZZV3hzYjNkaGJtTmxLR0ZrWkhKbGMzTXNZV1JrY21WemN5bDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmhjbU00T0Y5dmQyNWxjaWdwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpWVhKak9EaGZhWE5mYjNkdVpYSW9ZV1JrY21WemN5bGliMjlzSWl3Z2JXVjBhRzlrSUNKaGNtTTRPRjlwYm1sMGFXRnNhWHBsWDI5M2JtVnlLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaVlYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlZWEpqT0RoZmNtVnViM1Z1WTJWZmIzZHVaWEp6YUdsd0tDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTTRPRjkwY21GdWMyWmxjbDl2ZDI1bGNuTm9hWEJmY21WeGRXVnpkQ2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnlZemc0WDJGalkyVndkRjl2ZDI1bGNuTm9hWEFvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ5WXpnNFgyTmhibU5sYkY5dmQyNWxjbk5vYVhCZmNtVnhkV1Z6ZENncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZWEpqTVRReE1GOWlZV3hoYm1ObFgyOW1YM0JoY25ScGRHbHZibDl5YjNWMFpVQTFJRzFoYVc1ZllYSmpNakF3WDNSeVlXNXpabVZ5WDNKdmRYUmxRRFlnYldGcGJsOWhjbU14TkRFd1gzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDl5YjNWMFpVQTNJRzFoYVc1ZllYSmpNVFF4TUY5d1lYSjBhWFJwYjI1elgyOW1YM0p2ZFhSbFFEZ2diV0ZwYmw5aGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgzSnZkWFJsUURrZ2JXRnBibDloY21NeE5ERXdYMkYxZEdodmNtbDZaVjl2Y0dWeVlYUnZjbDl5YjNWMFpVQXhNQ0J0WVdsdVgyRnlZekUwTVRCZmNtVjJiMnRsWDI5d1pYSmhkRzl5WDNKdmRYUmxRREV4SUcxaGFXNWZZWEpqTVRReE1GOXZjR1Z5WVhSdmNsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmY205MWRHVkFNVElnYldGcGJsOWhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZmNtOTFkR1ZBTVRNZ2JXRnBibDloY21NeE5ERXdYMkYxZEdodmNtbDZaVjl2Y0dWeVlYUnZjbDlpZVY5d2IzSjBhVzl1WDNKdmRYUmxRREUwSUcxaGFXNWZZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjbDlpZVY5d2IzSjBhVzl1WDNKdmRYUmxRREUxSUcxaGFXNWZZWEpqTVRReE1GOXBjM04xWlY5aWVWOXdZWEowYVhScGIyNWZjbTkxZEdWQU1UWWdiV0ZwYmw5aGNtTXhOREV3WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI1ZmNtOTFkR1ZBTVRjZ2JXRnBibDloY21NeE5ERXdYMjl3WlhKaGRHOXlYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjVmY205MWRHVkFNVGdnYldGcGJsOWliMjkwYzNSeVlYQmZjbTkxZEdWQU1Ua2diV0ZwYmw5aGNtTXlNREJmYm1GdFpWOXliM1YwWlVBeU1DQnRZV2x1WDJGeVl6SXdNRjl6ZVcxaWIyeGZjbTkxZEdWQU1qRWdiV0ZwYmw5aGNtTXlNREJmWkdWamFXMWhiSE5mY205MWRHVkFNaklnYldGcGJsOWhjbU15TURCZmRHOTBZV3hUZFhCd2JIbGZjbTkxZEdWQU1qTWdiV0ZwYmw5aGNtTXlNREJmWW1Gc1lXNWpaVTltWDNKdmRYUmxRREkwSUcxaGFXNWZZWEpqTWpBd1gzUnlZVzV6Wm1WeVJuSnZiVjl5YjNWMFpVQXlOU0J0WVdsdVgyRnlZekl3TUY5aGNIQnliM1psWDNKdmRYUmxRREkySUcxaGFXNWZZWEpqTWpBd1gyRnNiRzkzWVc1alpWOXliM1YwWlVBeU55QnRZV2x1WDJGeVl6ZzRYMjkzYm1WeVgzSnZkWFJsUURJNElHMWhhVzVmWVhKak9EaGZhWE5mYjNkdVpYSmZjbTkxZEdWQU1qa2diV0ZwYmw5aGNtTTRPRjlwYm1sMGFXRnNhWHBsWDI5M2JtVnlYM0p2ZFhSbFFETXdJRzFoYVc1ZllYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3WDNKdmRYUmxRRE14SUcxaGFXNWZZWEpqT0RoZmNtVnViM1Z1WTJWZmIzZHVaWEp6YUdsd1gzSnZkWFJsUURNeUlHMWhhVzVmWVhKak9EaGZkSEpoYm5ObVpYSmZiM2R1WlhKemFHbHdYM0psY1hWbGMzUmZjbTkxZEdWQU16TWdiV0ZwYmw5aGNtTTRPRjloWTJObGNIUmZiM2R1WlhKemFHbHdYM0p2ZFhSbFFETTBJRzFoYVc1ZllYSmpPRGhmWTJGdVkyVnNYMjkzYm1WeWMyaHBjRjl5WlhGMVpYTjBYM0p2ZFhSbFFETTFDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UUXhNQ0JsZUhSbGJtUnpJRUZ5WXpJd01DQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZemc0WDJOaGJtTmxiRjl2ZDI1bGNuTm9hWEJmY21WeGRXVnpkRjl5YjNWMFpVQXpOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCaGNtTTRPRjlqWVc1alpXeGZiM2R1WlhKemFHbHdYM0psY1hWbGMzUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpPRGhmWVdOalpYQjBYMjkzYm1WeWMyaHBjRjl5YjNWMFpVQXpORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdGeVl6ZzRYMkZqWTJWd2RGOXZkMjVsY25Ob2FYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3WDNKbGNYVmxjM1JmY205MWRHVkFNek02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUwTVRBZ1pYaDBaVzVrY3lCQmNtTXlNREFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZemc0WDNSeVlXNXpabVZ5WDI5M2JtVnljMmhwY0Y5eVpYRjFaWE4wQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpnNFgzSmxibTkxYm1ObFgyOTNibVZ5YzJocGNGOXliM1YwWlVBek1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpnNFgzSmxibTkxYm1ObFgyOTNibVZ5YzJocGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTTRPRjkwY21GdWMyWmxjbDl2ZDI1bGNuTm9hWEJmY205MWRHVkFNekU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8xT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUwTVRBZ1pYaDBaVzVrY3lCQmNtTXlNREFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZemc0WDNSeVlXNXpabVZ5WDI5M2JtVnljMmhwY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NNE9GOXBibWwwYVdGc2FYcGxYMjkzYm1WeVgzSnZkWFJsUURNd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5ERXdJR1Y0ZEdWdVpITWdRWEpqTWpBd0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJoY21NNE9GOXBibWwwYVdGc2FYcGxYMjkzYm1WeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6ZzRYMmx6WDI5M2JtVnlYM0p2ZFhSbFFESTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREV3SUdWNGRHVnVaSE1nUVhKak1qQXdJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTTRPRjlwYzE5dmQyNWxjZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU00T0Y5dmQyNWxjbDl5YjNWMFpVQXlPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdGeVl6ZzRYMjkzYm1WeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6SXdNRjloYkd4dmQyRnVZMlZmY205MWRHVkFNamM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRjM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTVRReE1DQmxlSFJsYm1SeklFRnlZekl3TUNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UYzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWTJGc2JITjFZaUJoY21NeU1EQmZZV3hzYjNkaGJtTmxDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekl3TUY5aGNIQnliM1psWDNKdmRYUmxRREkyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFMk5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFME1UQWdaWGgwWlc1a2N5QkJjbU15TURBZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTJOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1qQXdYMkZ3Y0hKdmRtVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNakF3WDNSeVlXNXpabVZ5Um5KdmJWOXliM1YwWlVBeU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hORGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREV3SUdWNGRHVnVaSE1nUVhKak1qQXdJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZekl3TUY5MGNtRnVjMlpsY2taeWIyMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNakF3WDJKaGJHRnVZMlZQWmw5eWIzVjBaVUF5TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE1qTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5ERXdJR1Y0ZEdWdVpITWdRWEpqTWpBd0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hNak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCallXeHNjM1ZpSUdGeVl6SXdNRjlpWVd4aGJtTmxUMllLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTWpBd1gzUnZkR0ZzVTNWd2NHeDVYM0p2ZFhSbFFESXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakV4TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCaGNtTXlNREJmZEc5MFlXeFRkWEJ3YkhrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1qQXdYMlJsWTJsdFlXeHpYM0p2ZFhSbFFESXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCaGNtTXlNREJmWkdWamFXMWhiSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTWpBd1gzTjViV0p2YkY5eWIzVjBaVUF5TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvNU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmhjbU15TURCZmMzbHRZbTlzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpJd01GOXVZVzFsWDNKdmRYUmxRREl3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pneUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZekl3TUY5dVlXMWxDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySnZiM1J6ZEhKaGNGOXliM1YwWlVBeE9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzFOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6RTBNVEFnWlhoMFpXNWtjeUJCY21NeU1EQWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaWIyOTBjM1J5WVhBS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UUXhNRjl2Y0dWeVlYUnZjbDl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDNKdmRYUmxRREU0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME1qTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5ERXdJR1Y0ZEdWdVpITWdRWEpqTWpBd0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOREl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UUXhNRjl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDNKdmRYUmxRREUzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME1EZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5ERXdJR1Y0ZEdWdVpITWdRWEpqTWpBd0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOREE0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOREV3WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UUXhNRjlwYzNOMVpWOWllVjl3WVhKMGFYUnBiMjVmY205MWRHVkFNVFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNNE13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFME1UQWdaWGgwWlc1a2N5QkJjbU15TURBZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pPRE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTBNVEJmYVhOemRXVmZZbmxmY0dGeWRHbDBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpFME1UQmZhWE5mYjNCbGNtRjBiM0pmWW5sZmNHOXlkR2x2Ymw5eWIzVjBaVUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16Y3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UUXhNQ0JsZUhSbGJtUnpJRUZ5WXpJd01DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak0zTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNsOWllVjl3YjNKMGFXOXVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekUwTVRCZllYVjBhRzl5YVhwbFgyOXdaWEpoZEc5eVgySjVYM0J2Y25ScGIyNWZjbTkxZEdWQU1UUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak0xT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUwTVRBZ1pYaDBaVzVrY3lCQmNtTXlNREFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek5Ua0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpFME1UQmZZWFYwYUc5eWFYcGxYMjl3WlhKaGRHOXlYMko1WDNCdmNuUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgzSnZkWFJsUURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREV3SUdWNGRHVnVaSE1nUVhKak1qQXdJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRjMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI0S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UUXhNRjl2Y0dWeVlYUnZjbDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZmNtOTFkR1ZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRTBOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzFOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6RTBNVEFnWlhoMFpXNWtjeUJCY21NeU1EQWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TkRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZekUwTVRCZmIzQmxjbUYwYjNKZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekUwTVRCZmNtVjJiMnRsWDI5d1pYSmhkRzl5WDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE16VUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5ERXdJR1Y0ZEdWdVpITWdRWEpqTWpBd0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVE0xQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOREV3WDNKbGRtOXJaVjl2Y0dWeVlYUnZjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU14TkRFd1gyRjFkR2h2Y21sNlpWOXZjR1Z5WVhSdmNsOXliM1YwWlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVEk0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNVFF4TUNCbGVIUmxibVJ6SUVGeVl6SXdNQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFeU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZWEpqTVRReE1GOWhkWFJvYjNKcGVtVmZiM0JsY21GMGIzSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNsOXliM1YwWlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREV3SUdWNGRHVnVaSE1nUVhKak1qQXdJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRFMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekUwTVRCZmNHRnlkR2wwYVc5dWMxOXZabDl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TURjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU14TkRFd0lHVjRkR1Z1WkhNZ1FYSmpNakF3SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UQTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJoY21NeE5ERXdYM0JoY25ScGRHbHZibk5mYjJZS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UUXhNRjkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5ERXdJR1Y0ZEdWdVpITWdRWEpqTWpBd0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPVE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTBNVEJmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6SXdNRjkwY21GdWMyWmxjbDl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUwTVRBZ1pYaDBaVzVrY3lCQmNtTXlNREFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZWEpqTWpBd1gzUnlZVzV6Wm1WeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6RTBNVEJmWW1Gc1lXNWpaVjl2Wmw5d1lYSjBhWFJwYjI1ZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5ERXdJR1Y0ZEdWdVpITWdRWEpqTWpBd0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTBNVEJmWW1Gc1lXNWpaVjl2Wmw5d1lYSjBhWFJwYjI0S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFETTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUwTVRBZ1pYaDBaVzVrY3lCQmNtTXlNREFnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTBNZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qcEJjbU14TkRFd0xtRnlZekUwTVRCZlltRnNZVzVqWlY5dlpsOXdZWEowYVhScGIyNG9hRzlzWkdWeU9pQmllWFJsY3l3Z2NHRnlkR2wwYVc5dU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtRnlZekUwTVRCZlltRnNZVzVqWlY5dlpsOXdZWEowYVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalk1TFRjd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdMeThnY0hWaWJHbGpJR0Z5WXpFME1UQmZZbUZzWVc1alpWOXZabDl3WVhKMGFYUnBiMjRvYUc5c1pHVnlPaUJoY21NMExrRmtaSEpsYzNNc0lIQmhjblJwZEdsdmJqb2dZWEpqTkM1QlpHUnlaWE56S1RvZ1lYSmpOQzVWYVc1MFRqSTFOaUI3Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOekV0TnpRS0lDQWdJQzh2SUdOdmJuTjBJR3RsZVNBOUlHNWxkeUJoY21NeE5ERXdYMUJoY25ScGRHbHZia3RsZVNoN0NpQWdJQ0F2THlBZ0lHaHZiR1JsY2pvZ2FHOXNaR1Z5TEFvZ0lDQWdMeThnSUNCd1lYSjBhWFJwYjI0NklIQmhjblJwZEdsdmJpd0tJQ0FnSUM4dklIMHBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0Z5ZEdsMGFXOXVjeUE5SUVKdmVFMWhjRHhoY21NeE5ERXdYMUJoY25ScGRHbHZia3RsZVN3Z1lYSmpOQzVWYVc1MFRqSTFOajRvZXlCclpYbFFjbVZtYVhnNklDZGhjbU14TkRFd1gzQW5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poY21NeE5ERXdYM0FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbkJoY25ScGRHbHZibk1vYTJWNUtTNTJZV3gxWlFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9rRnlZekUwTVRBdVlYSmpNakF3WDNSeVlXNXpabVZ5S0hSdk9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVhKak1qQXdYM1J5WVc1elptVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8zT0MwM09Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJ2ZG1WeWNtbGtaU0JoY21NeU1EQmZkSEpoYm5ObVpYSW9kRzg2SUdGeVl6UXVRV1JrY21WemN5d2dkbUZzZFdVNklHRnlZelF1VldsdWRFNHlOVFlwT2lCaGNtTTBMa0p2YjJ3Z2V3b2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvNE1nb2dJQ0FnTHk4Z2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3lncExBb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9EQXRPRGNLSUNBZ0lDOHZJSFJvYVhNdVgzUnlZVzV6Wm1WeVgzQmhjblJwZEdsdmJpZ0tJQ0FnSUM4dklDQWdibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdwTEFvZ0lDQWdMeThnSUNCMGJ5d0tJQ0FnSUM4dklDQWdibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BMQW9nSUNBZ0x5OGdJQ0IyWVd4MVpTd0tJQ0FnSUM4dklDQWdibVYzSUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6S0Nrc0NpQWdJQ0F2THlBcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9EUUtJQ0FnSUM4dklHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tTd0tJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qZ3dMVGczQ2lBZ0lDQXZMeUIwYUdsekxsOTBjbUZ1YzJabGNsOXdZWEowYVhScGIyNG9DaUFnSUNBdkx5QWdJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1N3S0lDQWdJQzh2SUNBZ2RHOHNDaUFnSUNBdkx5QWdJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9LU3dLSUNBZ0lDOHZJQ0FnZG1Gc2RXVXNDaUFnSUNBdkx5QWdJRzVsZHlCaGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3lncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QnVaWGNnWVhKak5DNUVlVzVoYldsalFubDBaWE1vS1N3S0lDQWdJR0o1ZEdWaklERTNJQzh2SURCNE1EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem80TUMwNE53b2dJQ0FnTHk4Z2RHaHBjeTVmZEhKaGJuTm1aWEpmY0dGeWRHbDBhVzl1S0FvZ0lDQWdMeThnSUNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa3NDaUFnSUNBdkx5QWdJSFJ2TEFvZ0lDQWdMeThnSUNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0Nrc0NpQWdJQ0F2THlBZ0lIWmhiSFZsTEFvZ0lDQWdMeThnSUNCdVpYY2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTW9LU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gzUnlZVzV6Wm1WeVgzQmhjblJwZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzRPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WDNSeVlXNXpabVZ5S0c1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0lIUnZMQ0IyWVd4MVpTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOTBjbUZ1YzJabGNnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzZRWEpqTVRReE1DNWhjbU14TkRFd1gzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZiaWh3WVhKMGFYUnBiMjQ2SUdKNWRHVnpMQ0IwYnpvZ1lubDBaWE1zSUdGdGIzVnVkRG9nWW5sMFpYTXNJR1JoZEdFNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1lYSmpNVFF4TUY5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPamt6TFRrNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnY0hWaWJHbGpJR0Z5WXpFME1UQmZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1S0FvZ0lDQWdMeThnSUNCd1lYSjBhWFJwYjI0NklHRnlZelF1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnZEc4NklHRnlZelF1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUJoY21NMExsVnBiblJPTWpVMkxBb2dJQ0FnTHk4Z0lDQmtZWFJoT2lCaGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3l3S0lDQWdJQzh2SUNrNklHRnlZelF1UVdSa2NtVnpjeUI3Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVEF3Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdiR1YwSUhKbFkyVnBkbVZ5VUdGeWRHbDBhVzl1SUQwZ2RHaHBjeTVmY21WalpXbDJaWEpRWVhKMGFYUnBiMjRvZEc4c0lIQmhjblJwZEdsdmJpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqWVd4c2MzVmlJRjl5WldObGFYWmxjbEJoY25ScGRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUhSb2FYTXVYM1J5WVc1elptVnlYM0JoY25ScGRHbHZiaWh6Wlc1a1pYSXNJSEJoY25ScGRHbHZiaXdnZEc4c0lISmxZMlZwZG1WeVVHRnlkR2wwYVc5dUxDQmhiVzkxYm5Rc0lHUmhkR0VwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2w5d1lYSjBhWFJwYjI0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UQTBDaUFnSUNBdkx5QnlaWFIxY200Z2NtVmpaV2wyWlhKUVlYSjBhWFJwYjI0S0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9rRnlZekUwTVRBdVlYSmpNVFF4TUY5d1lYSjBhWFJwYjI1elgyOW1LR2h2YkdSbGNqb2dZbmwwWlhNc0lIQmhaMlU2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVhKak1UUXhNRjl3WVhKMGFYUnBiMjV6WDI5bU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNRGN0TVRBNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnY0hWaWJHbGpJR0Z5WXpFME1UQmZjR0Z5ZEdsMGFXOXVjMTl2Wmlob2IyeGtaWEk2SUdGeVl6UXVRV1JrY21WemN5d2djR0ZuWlRvZ1lYSmpOQzVWYVc1MFRqWTBLVG9nWVhKak5DNUJaR1J5WlhOelcxMGdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXdPUW9nSUNBZ0x5OGdZMjl1YzNRZ2EyVjVJRDBnYm1WM0lHRnlZekUwTVRCZlNHOXNaR2x1WjFCaGNuUnBkR2x2Ym5OUVlXZHBibUYwWldSTFpYa29leUJvYjJ4a1pYSTZJR2h2YkdSbGNpd2djR0ZuWlRvZ2NHRm5aU0I5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOW9jRjloSnl3S0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKaGNtTXhOREV3WDJod1gyRWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1b2IyeGtaWEpRWVhKMGFYUnBiMjV6UVdSa2NtVnpjMlZ6S0d0bGVTa3VaWGhwYzNSektTQnlaWFIxY200Z1cxMEtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdGeVl6RTBNVEJmY0dGeWRHbDBhVzl1YzE5dlpsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR0o1ZEdWaklERTNJQzh2SURCNE1EQXdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwaGNtTXhOREV3WDNCaGNuUnBkR2x2Ym5OZmIyWmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5CWkdSeVpYTnpaWE1vYTJWNUtTNTJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pwQmNtTXhOREV3TG1GeVl6RTBNVEJmYVhOZmIzQmxjbUYwYjNJb2FHOXNaR1Z5T2lCaWVYUmxjeXdnYjNCbGNtRjBiM0k2SUdKNWRHVnpMQ0J3WVhKMGFYUnBiMjQ2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1URTBMVEV4TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlLR2h2YkdSbGNqb2dZWEpqTkM1QlpHUnlaWE56TENCdmNHVnlZWFJ2Y2pvZ1lYSmpOQzVCWkdSeVpYTnpMQ0J3WVhKMGFYUnBiMjQ2SUdGeVl6UXVRV1JrY21WemN5azZJR0Z5WXpRdVFtOXZiQ0I3Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVEUyQ2lBZ0lDQXZMeUJwWmlBb2IzQmxjbUYwYjNJZ1BUMDlJR2h2YkdSbGNpa2djbVYwZFhKdUlHNWxkeUJoY21NMExrSnZiMndvZEhKMVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0E5UFFvZ0lDQWdZbm9nWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2w5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGc0TUFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NtRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNVGNLSUNBZ0lDOHZJR052Ym5OMElITndaV05wWm1saklEMGdibVYzSUdGeVl6RTBNVEJmVDNCbGNtRjBiM0pMWlhrb2V5Qm9iMnhrWlhJNklHaHZiR1JsY2l3Z2IzQmxjbUYwYjNJNklHOXdaWEpoZEc5eUxDQndZWEowYVhScGIyNDZJSEJoY25ScGRHbHZiaUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCd2RXSnNhV01nYjNCbGNtRjBiM0p6SUQwZ1FtOTRUV0Z3UEdGeVl6RTBNVEJmVDNCbGNtRjBiM0pMWlhrc0lHRnlZelF1UW5sMFpUNG9leUJyWlhsUWNtVm1hWGc2SUNkaGNtTXhOREV3WDI5d0p5QjlLU0F2THlCMllXeDFaU0E5SURFZ1lYVjBhRzl5YVhwbFpBb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0ltRnlZekUwTVRCZmIzQWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakV4T0FvZ0lDQWdMeThnYVdZZ0tIUm9hWE11YjNCbGNtRjBiM0p6S0hOd1pXTnBabWxqS1M1bGVHbHpkSE1nSmlZZ2RHaHBjeTV2Y0dWeVlYUnZjbk1vYzNCbFkybG1hV01wTG5aaGJIVmxMbTVoZEdsMlpTQTlQVDBnTVNrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJoY21NeE5ERXdYMmx6WDI5d1pYSmhkRzl5WDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdGeVl6RTBNVEJmYVhOZmIzQmxjbUYwYjNKZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFeE9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU0wTGtKdmIyd29kSEoxWlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnNE1Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbUZ5WXpFME1UQmZhWE5mYjNCbGNtRjBiM0pmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TWpFS0lDQWdJQzh2SUdOdmJuTjBJR2RzYjJKaGJFdGxlU0E5SUc1bGR5QmhjbU14TkRFd1gwOXdaWEpoZEc5eVMyVjVLSHNnYUc5c1pHVnlPaUJvYjJ4a1pYSXNJRzl3WlhKaGRHOXlPaUJ2Y0dWeVlYUnZjaXdnY0dGeWRHbDBhVzl1T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0NrZ2ZTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QndkV0pzYVdNZ2IzQmxjbUYwYjNKeklEMGdRbTk0VFdGd1BHRnlZekUwTVRCZlQzQmxjbUYwYjNKTFpYa3NJR0Z5WXpRdVFubDBaVDRvZXlCclpYbFFjbVZtYVhnNklDZGhjbU14TkRFd1gyOXdKeUI5S1NBdkx5QjJZV3gxWlNBOUlERWdZWFYwYUc5eWFYcGxaQW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbUZ5WXpFME1UQmZiM0FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFeU1nb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWIzQmxjbUYwYjNKektHZHNiMkpoYkV0bGVTa3VaWGhwYzNSeklDWW1JSFJvYVhNdWIzQmxjbUYwYjNKektHZHNiMkpoYkV0bGVTa3VkbUZzZFdVdWJtRjBhWFpsSUQwOVBTQXhLU0I3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSmZZV1owWlhKZmFXWmZaV3h6WlVBNENpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjbDloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUdGeVl6UXVRbTl2YkNoMGNuVmxLUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlRGd3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1lYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNsOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXlOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJoY21NMExrSnZiMndvWm1Gc2MyVXBDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem82UVhKak1UUXhNQzVoY21NeE5ERXdYMkYxZEdodmNtbDZaVjl2Y0dWeVlYUnZjaWhvYjJ4a1pYSTZJR0o1ZEdWekxDQnZjR1Z5WVhSdmNqb2dZbmwwWlhNc0lIQmhjblJwZEdsdmJqb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtRnlZekUwTVRCZllYVjBhRzl5YVhwbFgyOXdaWEpoZEc5eU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNamd0TVRJNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnY0hWaWJHbGpJR0Z5WXpFME1UQmZZWFYwYUc5eWFYcGxYMjl3WlhKaGRHOXlLR2h2YkdSbGNqb2dZWEpqTkM1QlpHUnlaWE56TENCdmNHVnlZWFJ2Y2pvZ1lYSmpOQzVCWkdSeVpYTnpMQ0J3WVhKMGFYUnBiMjQ2SUdGeVl6UXVRV1JrY21WemN5azZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFek1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMDlJR2h2YkdSbGNpd2dKMDl1YkhrZ2FHOXNaR1Z5SUdOaGJpQmhkWFJvYjNKcGVtVW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2FHOXNaR1Z5SUdOaGJpQmhkWFJvYjNKcGVtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVE14Q2lBZ0lDQXZMeUJqYjI1emRDQnJaWGtnUFNCdVpYY2dZWEpqTVRReE1GOVBjR1Z5WVhSdmNrdGxlU2g3SUdodmJHUmxjam9nYUc5c1pHVnlMQ0J2Y0dWeVlYUnZjam9nYjNCbGNtRjBiM0lzSUhCaGNuUnBkR2x2YmpvZ2NHRnlkR2wwYVc5dUlIMHBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8yTWdvZ0lDQWdMeThnY0hWaWJHbGpJRzl3WlhKaGRHOXljeUE5SUVKdmVFMWhjRHhoY21NeE5ERXdYMDl3WlhKaGRHOXlTMlY1TENCaGNtTTBMa0o1ZEdVK0tIc2dhMlY1VUhKbFptbDRPaUFuWVhKak1UUXhNRjl2Y0NjZ2ZTa2dMeThnZG1Gc2RXVWdQU0F4SUdGMWRHaHZjbWw2WldRS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKaGNtTXhOREV3WDI5d0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakV6TWdvZ0lDQWdMeThnZEdocGN5NXZjR1Z5WVhSdmNuTW9hMlY1S1M1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGtKNWRHVW9NU2tLSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPa0Z5WXpFME1UQXVZWEpqTVRReE1GOXlaWFp2YTJWZmIzQmxjbUYwYjNJb2FHOXNaR1Z5T2lCaWVYUmxjeXdnYjNCbGNtRjBiM0k2SUdKNWRHVnpMQ0J3WVhKMGFYUnBiMjQ2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoY21NeE5ERXdYM0psZG05clpWOXZjR1Z5WVhSdmNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVE0xTFRFek5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5ERXdYM0psZG05clpWOXZjR1Z5WVhSdmNpaG9iMnhrWlhJNklHRnlZelF1UVdSa2NtVnpjeXdnYjNCbGNtRjBiM0k2SUdGeVl6UXVRV1JrY21WemN5d2djR0Z5ZEdsMGFXOXVPaUJoY21NMExrRmtaSEpsYzNNcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TXpjS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwSUQwOVBTQm9iMnhrWlhJc0lDZFBibXg1SUdodmJHUmxjaUJqWVc0Z2NtVjJiMnRsSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR2h2YkdSbGNpQmpZVzRnY21WMmIydGxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakV6T0FvZ0lDQWdMeThnWTI5dWMzUWdhMlY1SUQwZ2JtVjNJR0Z5WXpFME1UQmZUM0JsY21GMGIzSkxaWGtvZXlCb2IyeGtaWEk2SUdodmJHUmxjaXdnYjNCbGNtRjBiM0k2SUc5d1pYSmhkRzl5TENCd1lYSjBhWFJwYjI0NklIQmhjblJwZEdsdmJpQjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUhCMVlteHBZeUJ2Y0dWeVlYUnZjbk1nUFNCQ2IzaE5ZWEE4WVhKak1UUXhNRjlQY0dWeVlYUnZja3RsZVN3Z1lYSmpOQzVDZVhSbFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJGeVl6RTBNVEJmYjNBbklIMHBJQzh2SUhaaGJIVmxJRDBnTVNCaGRYUm9iM0pwZW1Wa0NpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaVlYSmpNVFF4TUY5dmNDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakV6T1FvZ0lDQWdMeThnYVdZZ0tIUm9hWE11YjNCbGNtRjBiM0p6S0d0bGVTa3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdGeVl6RTBNVEJmY21WMmIydGxYMjl3WlhKaGRHOXlYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hOREFLSUNBZ0lDOHZJSFJvYVhNdWIzQmxjbUYwYjNKektHdGxlU2t1WkdWc1pYUmxLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLQ21GeVl6RTBNVEJmY21WMmIydGxYMjl3WlhKaGRHOXlYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPa0Z5WXpFME1UQXVZWEpqTVRReE1GOXZjR1Z5WVhSdmNsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjRvWm5KdmJUb2dZbmwwWlhNc0lIQmhjblJwZEdsdmJqb2dZbmwwWlhNc0lIUnZPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQmllWFJsY3l3Z1pHRjBZVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BoY21NeE5ERXdYMjl3WlhKaGRHOXlYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UUTBMVEUxTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TkRFd1gyOXdaWEpoZEc5eVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZiaWdLSUNBZ0lDOHZJQ0FnWm5KdmJUb2dZWEpqTkM1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCd1lYSjBhWFJwYjI0NklHRnlZelF1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnZEc4NklHRnlZelF1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUJoY21NMExsVnBiblJPTWpVMkxBb2dJQ0FnTHk4Z0lDQmtZWFJoT2lCaGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3l3S0lDQWdJQzh2SUNrNklHRnlZelF1UVdSa2NtVnpjeUI3Q2lBZ0lDQndjbTkwYnlBMUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRTFNZ29nSUNBZ0x5OGdZMjl1YzNRZ2MyVnVaR1Z5SUQwZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE5UUUtJQ0FnSUM4dklHeGxkQ0JoZFhSb2IzSnBlbVZrSUQwZ2RHaHBjeTVoY21NeE5ERXdYMmx6WDI5d1pYSmhkRzl5S0daeWIyMHNJSE5sYm1SbGNpd2djR0Z5ZEdsMGFXOXVLUzV1WVhScGRtVWdQVDA5SUhSeWRXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hOVElLSUNBZ0lDOHZJR052Ym5OMElITmxibVJsY2lBOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UVTBDaUFnSUNBdkx5QnNaWFFnWVhWMGFHOXlhWHBsWkNBOUlIUm9hWE11WVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2lobWNtOXRMQ0J6Wlc1a1pYSXNJSEJoY25ScGRHbHZiaWt1Ym1GMGFYWmxJRDA5UFNCMGNuVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOaGJHeHpkV0lnWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCa2RYQnVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRVMkNpQWdJQ0F2THlCcFppQW9JV0YxZEdodmNtbDZaV1FwSUhzS0lDQWdJR0p1ZWlCaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UVTRDaUFnSUNBdkx5QmpiMjV6ZENCd1MyVjVJRDBnYm1WM0lHRnlZekUwTVRCZlQzQmxjbUYwYjNKUWIzSjBhVzl1UzJWNUtIc2dhRzlzWkdWeU9pQm1jbTl0TENCdmNHVnlZWFJ2Y2pvZ2MyVnVaR1Z5TENCd1lYSjBhWFJwYjI0Z2ZTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJSEIxWW14cFl5QnZjR1Z5WVhSdmNsQnZjblJwYjI1QmJHeHZkMkZ1WTJWeklEMGdRbTk0VFdGd1BHRnlZekUwTVRCZlQzQmxjbUYwYjNKUWIzSjBhVzl1UzJWNUxDQmhjbU0wTGxWcGJuUk9NalUyUGloN0lHdGxlVkJ5WldacGVEb2dKMkZ5WXpFME1UQmZiM0JoSnlCOUtRb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0ltRnlZekUwTVRCZmIzQmhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TlRrS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG05d1pYSmhkRzl5VUc5eWRHbHZia0ZzYkc5M1lXNWpaWE1vY0V0bGVTa3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdGeVl6RTBNVEJmYjNCbGNtRjBiM0pmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE5qQUtJQ0FnSUM4dklHTnZibk4wSUhKbGJXRnBibWx1WnlBOUlIUm9hWE11YjNCbGNtRjBiM0pRYjNKMGFXOXVRV3hzYjNkaGJtTmxjeWh3UzJWNUtTNTJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRZeENpQWdJQ0F2THlCaGMzTmxjblFvY21WdFlXbHVhVzVuTG01aGRHbDJaU0ErUFNCaGJXOTFiblF1Ym1GMGFYWmxMQ0FuVUc5eWRHbHZiaUJoYkd4dmQyRnVZMlVnWlhoalpXVmtaV1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSStQUW9nSUNBZ1lYTnpaWEowSUM4dklGQnZjblJwYjI0Z1lXeHNiM2RoYm1ObElHVjRZMlZsWkdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRTJNZ29nSUNBZ0x5OGdZWFYwYUc5eWFYcGxaQ0E5SUhSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UWTFDaUFnSUNBdkx5QjBhR2x6TG05d1pYSmhkRzl5VUc5eWRHbHZia0ZzYkc5M1lXNWpaWE1vY0V0bGVTa3VkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpJMU5paHlaVzFoYVc1cGJtY3VibUYwYVhabElDMGdZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaTBLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWIzaGZjSFYwQ2dwaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdabkpoYldWZlluVnllU0F6Q2dwaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoaGRYUm9iM0pwZW1Wa0xDQW5UbTkwSUdGMWRHaHZjbWw2WldRZ2IzQmxjbUYwYjNJbktRb2dJQ0FnWVhOelpYSjBJQzh2SUU1dmRDQmhkWFJvYjNKcGVtVmtJRzl3WlhKaGRHOXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakUyT1FvZ0lDQWdMeThnYkdWMElISmxZMlZwZG1WeVVHRnlkR2wwYVc5dUlEMGdkR2hwY3k1ZmNtVmpaV2wyWlhKUVlYSjBhWFJwYjI0b2RHOHNJSEJoY25ScGRHbHZiaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCallXeHNjM1ZpSUY5eVpXTmxhWFpsY2xCaGNuUnBkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE56QUtJQ0FnSUM4dklIUm9hWE11WDNSeVlXNXpabVZ5WDNCaGNuUnBkR2x2YmlobWNtOXRMQ0J3WVhKMGFYUnBiMjRzSUhSdkxDQnlaV05sYVhabGNsQmhjblJwZEdsdmJpd2dZVzF2ZFc1MExDQmtZWFJoS1FvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2w5d1lYSjBhWFJwYjI0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UY3hDaUFnSUNBdkx5QnlaWFIxY200Z2NtVmpaV2wyWlhKUVlYSjBhWFJwYjI0S0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvNlFYSmpNVFF4TUM1aGNtTXhOREV3WDJOaGJsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjRvWm5KdmJUb2dZbmwwWlhNc0lIQmhjblJwZEdsdmJqb2dZbmwwWlhNc0lIUnZPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQmllWFJsY3l3Z1pHRjBZVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BoY21NeE5ERXdYMk5oYmw5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakUzTkMweE9ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1UUXhNRjlqWVc1ZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVLQW9nSUNBZ0x5OGdJQ0JtY205dE9pQmhjbU0wTGtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUhCaGNuUnBkR2x2YmpvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0IwYnpvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJR0Z5WXpRdVZXbHVkRTR5TlRZc0NpQWdJQ0F2THlBZ0lHUmhkR0U2SUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6TEFvZ0lDQWdMeThnS1RvZ1lYSmpNVFF4TUY5allXNWZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1WDNKbGRIVnliaUI3Q2lBZ0lDQndjbTkwYnlBMUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJMU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjR0Z5ZEdsMGFXOXVjeWh1WlhjZ1lYSmpNVFF4TUY5UVlYSjBhWFJwYjI1TFpYa29leUJvYjJ4a1pYSTZJR2h2YkdSbGNpd2djR0Z5ZEdsMGFXOXVPaUJ3WVhKMGFYUnBiMjRnZlNrcExtVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z2NIVmliR2xqSUhCaGNuUnBkR2x2Ym5NZ1BTQkNiM2hOWVhBOFlYSmpNVFF4TUY5UVlYSjBhWFJwYjI1TFpYa3NJR0Z5WXpRdVZXbHVkRTR5TlRZK0tIc2dhMlY1VUhKbFptbDRPaUFuWVhKak1UUXhNRjl3SnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlYSmpNVFF4TUY5d0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNalV4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1d1lYSjBhWFJwYjI1ektHNWxkeUJoY21NeE5ERXdYMUJoY25ScGRHbHZia3RsZVNoN0lHaHZiR1JsY2pvZ2FHOXNaR1Z5TENCd1lYSjBhWFJwYjI0NklIQmhjblJwZEdsdmJpQjlLU2t1WlhocGMzUnpDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UZ3lDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXVYM1poYkdsa1VHRnlkR2wwYVc5dUtHWnliMjBzSUhCaGNuUnBkR2x2YmlrcElIc0tJQ0FnSUdKdWVpQmhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFNE15MHhPRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnWVhKak1UUXhNRjlqWVc1ZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVYM0psZEhWeWJpaDdDaUFnSUNBdkx5QWdJR052WkdVNklHNWxkeUJoY21NMExrSjVkR1VvTUhnMU1Da3NDaUFnSUNBdkx5QWdJSE4wWVhSMWN6b2dibVYzSUdGeVl6UXVVM1J5S0NkUVlYSjBhWFJwYjI0Z2JtOTBJR1Y0YVhOMGN5Y3BMQW9nSUNBZ0x5OGdJQ0J5WldObGFYWmxjbEJoY25ScGRHbHZiam9nYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdwTEFvZ0lDQWdMeThnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE16SW9TMEZCUTBkQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVV0R1FWbE1VMDlTVlZoSk1reFFUbGxSUnpRek0xVkZRbE5ZVVRKTVZFOVNXbEVwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1lYSmpNVFF4TUY5allXNWZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRrd0NpQWdJQ0F2THlCMGFHbHpMbkJoY25ScGRHbHZibk1vYm1WM0lHRnlZekUwTVRCZlVHRnlkR2wwYVc5dVMyVjVLSHNnYUc5c1pHVnlPaUJtY205dExDQndZWEowYVhScGIyNDZJSEJoY25ScGRHbHZiaUI5S1NrdWRtRnNkV1V1Ym1GMGFYWmxJRHdnWVcxdmRXNTBMbTVoZEdsMlpRb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0k4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFNE9TMHhPVEVLSUNBZ0lDOHZJR2xtSUNnS0lDQWdJQzh2SUNBZ2RHaHBjeTV3WVhKMGFYUnBiMjV6S0c1bGR5QmhjbU14TkRFd1gxQmhjblJwZEdsdmJrdGxlU2g3SUdodmJHUmxjam9nWm5KdmJTd2djR0Z5ZEdsMGFXOXVPaUJ3WVhKMGFYUnBiMjRnZlNrcExuWmhiSFZsTG01aGRHbDJaU0E4SUdGdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUM4dklDa2dld29nSUNBZ1lub2dZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE9USXRNVGsyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUdGeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDl5WlhSMWNtNG9ld29nSUNBZ0x5OGdJQ0JqYjJSbE9pQnVaWGNnWVhKak5DNUNlWFJsS0RCNE5USXBMQW9nSUNBZ0x5OGdJQ0J6ZEdGMGRYTTZJRzVsZHlCaGNtTTBMbE4wY2lnblNXNXpkV1ptYVdOcFpXNTBJR0poYkdGdVkyVW5LU3dLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEpRWVhKMGFYUnBiMjQ2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1N3S0lDQWdJQzh2SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUTXlLRXRKUVVOSFFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGTFJWTXpWRlJQVmxSSFRUSk1SRTVHVTFjME5VSkJUVXBSVjFsWlRFOU5UbE5SS1FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NtRnlZekUwTVRCZlkyRnVYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFNU9Rb2dJQ0FnTHk4Z2FXWWdLSFJ2SUQwOVBTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa3BJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGNtTXhOREV3WDJOaGJsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakl3TUMweU1EUUtJQ0FnSUM4dklISmxkSFZ5YmlCdVpYY2dZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgzSmxkSFZ5YmloN0NpQWdJQ0F2THlBZ0lHTnZaR1U2SUc1bGR5QmhjbU0wTGtKNWRHVW9NSGcxTnlrc0NpQWdJQ0F2THlBZ0lITjBZWFIxY3pvZ2JtVjNJR0Z5WXpRdVUzUnlLQ2RKYm5aaGJHbGtJSEpsWTJWcGRtVnlKeWtzQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5VUdGeWRHbDBhVzl1T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0Nrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUdKaGMyVXpNaWhMTkVGRFIwRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlNVVlRNMVJYVFVaWFIxTmFRa0ZQU2xOWFIxcE1TazlhVTFoRktRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbUZ5WXpFME1UQmZZMkZ1WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSXdPQW9nSUNBZ0x5OGdZMjl1YzNRZ2MyVnVaR1Z5UVdSa2NpQTlJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSXdPUW9nSUNBZ0x5OGdhV1lnS0hObGJtUmxja0ZrWkhJZ0lUMDlJR1p5YjIwcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnSVQwS0lDQWdJR0o2SUdGeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFERTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakl4TUFvZ0lDQWdMeThnYkdWMElHRjFkR2h2Y21sNlpXUWdQU0IwYUdsekxtRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSW9abkp2YlN3Z2MyVnVaR1Z5UVdSa2Npd2djR0Z5ZEdsMGFXOXVLUzV1WVhScGRtVWdQVDA5SUhSeWRXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZMkZzYkhOMVlpQmhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TVRFS0lDQWdJQzh2SUdsbUlDZ2hZWFYwYUc5eWFYcGxaQ2tnZXdvZ0lDQWdZbTU2SUdGeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFERXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakl4TWdvZ0lDQWdMeThnWTI5dWMzUWdjRXRsZVNBOUlHNWxkeUJoY21NeE5ERXdYMDl3WlhKaGRHOXlVRzl5ZEdsdmJrdGxlU2g3SUdodmJHUmxjam9nWm5KdmJTd2diM0JsY21GMGIzSTZJSE5sYm1SbGNrRmtaSElzSUhCaGNuUnBkR2x2YmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdjSFZpYkdsaklHOXdaWEpoZEc5eVVHOXlkR2x2YmtGc2JHOTNZVzVqWlhNZ1BTQkNiM2hOWVhBOFlYSmpNVFF4TUY5UGNHVnlZWFJ2Y2xCdmNuUnBiMjVMWlhrc0lHRnlZelF1VldsdWRFNHlOVFkrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOXZjR0VuSUgwcENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaVlYSmpNVFF4TUY5dmNHRWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakl4TXdvZ0lDQWdMeThnYVdZZ0tIUm9hWE11YjNCbGNtRjBiM0pRYjNKMGFXOXVRV3hzYjNkaGJtTmxjeWh3UzJWNUtTNWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1lub2dZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qRTBDaUFnSUNBdkx5QmpiMjV6ZENCeVpXMWhhVzVwYm1jZ1BTQjBhR2x6TG05d1pYSmhkRzl5VUc5eWRHbHZia0ZzYkc5M1lXNWpaWE1vY0V0bGVTa3VkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU1UVUtJQ0FnSUM4dklHbG1JQ2h5WlcxaGFXNXBibWN1Ym1GMGFYWmxJRDQ5SUdGdGIzVnVkQzV1WVhScGRtVXBJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lqNDlDaUFnSUNCaWVpQmhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU1UWUtJQ0FnSUM4dklHRjFkR2h2Y21sNlpXUWdQU0IwY25WbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2dwaGNtTXhOREV3WDJOaGJsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXhNVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtDbUZ5WXpFME1UQmZZMkZ1WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURFek9nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qSXdDaUFnSUNBdkx5QnBaaUFvSVdGMWRHaHZjbWw2WldRcElIc0tJQ0FnSUdKdWVpQmhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU1qRXRNakkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUdGeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDl5WlhSMWNtNG9ld29nSUNBZ0x5OGdJQ0JqYjJSbE9pQnVaWGNnWVhKak5DNUNlWFJsS0RCNE5UZ3BMQW9nSUNBZ0x5OGdJQ0J6ZEdGMGRYTTZJRzVsZHlCaGNtTTBMbE4wY2lnblQzQmxjbUYwYjNJZ2JtOTBJR0YxZEdodmNtbDZaV1FuS1N3S0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhKUVlYSjBhWFJwYjI0NklHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tTd0tJQ0FnSUM4dklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVE15S0V4QlFVTkhRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRk1WVFkwUkVaUFNsRllTVE16VTBWQ1dFYzJOVUpCVFVZeVdFa3lSRkJQU2xWWVZWcE1SU2tLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwaGNtTXhOREV3WDJOaGJsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXhOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TWpJNUNpQWdJQ0F2THlCc1pYUWdjbVZqWldsMlpYSlFZWEowYVhScGIyNGdQU0IwYUdsekxsOXlaV05sYVhabGNsQmhjblJwZEdsdmJpaDBieXdnY0dGeWRHbDBhVzl1S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTmhiR3h6ZFdJZ1gzSmxZMlZwZG1WeVVHRnlkR2wwYVc5dUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSXpNUzB5TXpVS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1lYSmpNVFF4TUY5allXNWZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1WDNKbGRIVnliaWg3Q2lBZ0lDQXZMeUFnSUdOdlpHVTZJRzVsZHlCaGNtTTBMa0o1ZEdVb01IZzFNU2tzQ2lBZ0lDQXZMeUFnSUhOMFlYUjFjem9nYm1WM0lHRnlZelF1VTNSeUtDZFRkV05qWlhOekp5a3NDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlVR0Z5ZEdsMGFXOXVPaUJ5WldObGFYWmxjbEJoY25ScGRHbHZiaXdLSUNBZ0lDOHZJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTVRBd01qTUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TXpNS0lDQWdJQzh2SUhOMFlYUjFjem9nYm1WM0lHRnlZelF1VTNSeUtDZFRkV05qWlhOekp5a3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREEzTlRNM05UWXpOak0yTlRjek56TUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNak14TFRJek5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZmNtVjBkWEp1S0hzS0lDQWdJQzh2SUNBZ1kyOWtaVG9nYm1WM0lHRnlZelF1UW5sMFpTZ3dlRFV4S1N3S0lDQWdJQzh2SUNBZ2MzUmhkSFZ6T2lCdVpYY2dZWEpqTkM1VGRISW9KMU4xWTJObGMzTW5LU3dLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEpRWVhKMGFYUnBiMjQ2SUhKbFkyVnBkbVZ5VUdGeWRHbDBhVzl1TEFvZ0lDQWdMeThnZlNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qcEJjbU14TkRFd0xsOXlaV05sYVhabGNsQmhjblJwZEdsdmJpaHlaV05sYVhabGNqb2dZbmwwWlhNc0lIQmhjblJwZEdsdmJqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGZjbVZqWldsMlpYSlFZWEowYVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakkwTXdvZ0lDQWdMeThnY0hKdmRHVmpkR1ZrSUY5eVpXTmxhWFpsY2xCaGNuUnBkR2x2YmloeVpXTmxhWFpsY2pvZ1lYSmpOQzVCWkdSeVpYTnpMQ0J3WVhKMGFYUnBiMjQ2SUdGeVl6UXVRV1JrY21WemN5azZJR0Z5WXpRdVFXUmtjbVZ6Y3lCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TWpRMENpQWdJQ0F2THlCc1pYUWdjbVZqWldsMlpYSlFZWEowYVhScGIyNGdQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakkwTlFvZ0lDQWdMeThnYVdZZ0tIUm9hWE11Y0dGeWRHbDBhVzl1Y3lodVpYY2dZWEpqTVRReE1GOVFZWEowYVhScGIyNUxaWGtvZXlCb2IyeGtaWEk2SUhKbFkyVnBkbVZ5TENCd1lYSjBhWFJwYjI0NklIQmhjblJwZEdsdmJpQjlLU2t1WlhocGMzUnpLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCd2RXSnNhV01nY0dGeWRHbDBhVzl1Y3lBOUlFSnZlRTFoY0R4aGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTd2dZWEpqTkM1VmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RoY21NeE5ERXdYM0FuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaGNtTXhOREV3WDNBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNalExQ2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTV3WVhKMGFYUnBiMjV6S0c1bGR5QmhjbU14TkRFd1gxQmhjblJwZEdsdmJrdGxlU2g3SUdodmJHUmxjam9nY21WalpXbDJaWElzSUhCaGNuUnBkR2x2YmpvZ2NHRnlkR2wwYVc5dUlIMHBLUzVsZUdsemRITXBJSHNLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1gzSmxZMlZwZG1WeVVHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ2w5eVpXTmxhWFpsY2xCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJME9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbFkyVnBkbVZ5VUdGeWRHbDBhVzl1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem82UVhKak1UUXhNQzVmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5S0dodmJHUmxjam9nWW5sMFpYTXNJSEJoY25ScFkybHdZWFJwYjI0NklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZllXUmtYM0JoY25ScFkybHdZWFJwYjI1ZmRHOWZhRzlzWkdWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lOalFLSUNBZ0lDOHZJSEJ5YjNSbFkzUmxaQ0JmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5S0dodmJHUmxjam9nWVhKak5DNUJaR1J5WlhOekxDQndZWEowYVdOcGNHRjBhVzl1T2lCaGNtTTBMa0ZrWkhKbGMzTXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjRzRnTkFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEJ1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklIQjFZbXhwWXlCb2IyeGtaWEpRWVhKMGFYUnBiMjV6UTNWeWNtVnVkRkJoWjJVZ1BTQkNiM2hOWVhBOFlYSmpOQzVCWkdSeVpYTnpMQ0JoY21NMExsVnBiblJPTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuWVhKak1UUXhNRjlvY0Y5d0p5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmhjbU14TkRFd1gyaHdYM0FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJMk5nb2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxtaHZiR1JsY2xCaGNuUnBkR2x2Ym5ORGRYSnlaVzUwVUdGblpTaG9iMnhrWlhJcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2w5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TWpZM0NpQWdJQ0F2THlCMGFHbHpMbWh2YkdSbGNsQmhjblJwZEdsdmJuTkRkWEp5Wlc1MFVHRm5aU2hvYjJ4a1pYSXBMblpoYkhWbElEMGdjR0ZuWlFvZ0lDQWdabkpoYldWZlpHbG5JREV3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJMk5Rb2dJQ0FnTHk4Z2JHVjBJSEJoWjJVZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtEQXBDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNalkzQ2lBZ0lDQXZMeUIwYUdsekxtaHZiR1JsY2xCaGNuUnBkR2x2Ym5ORGRYSnlaVzUwVUdGblpTaG9iMnhrWlhJcExuWmhiSFZsSUQwZ2NHRm5aUW9nSUNBZ1ltOTRYM0IxZEFvS1gyRmtaRjl3WVhKMGFXTnBjR0YwYVc5dVgzUnZYMmh2YkdSbGNsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTJPUW9nSUNBZ0x5OGdZMjl1YzNRZ2JHRnpkRkJoWjJVZ1BTQjBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5EZFhKeVpXNTBVR0ZuWlNob2IyeGtaWElwTG5aaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ01UQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNZ29nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNamN3Q2lBZ0lDQXZMeUJzWlhRZ1ptOTFibVFnUFNCbVlXeHpaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lOalVLSUNBZ0lDOHZJR3hsZENCd1lXZGxJRDBnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1FvZ0lDQWdZbmwwWldNZ01UZ2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJM01Rb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ1kzVnlVR0ZuWlNBOUlIQmhaMlU3SUdOMWNsQmhaMlV1Ym1GMGFYWmxJRHdnYkdGemRGQmhaMlV1Ym1GMGFYWmxPeUJqZFhKUVlXZGxJRDBnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hqZFhKUVlXZGxMbTVoZEdsMlpTQXJJREVwS1NCN0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0NsOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZkMmhwYkdWZmRHOXdRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJM01Rb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ1kzVnlVR0ZuWlNBOUlIQmhaMlU3SUdOMWNsQmhaMlV1Ym1GMGFYWmxJRHdnYkdGemRGQmhaMlV1Ym1GMGFYWmxPeUJqZFhKUVlXZGxJRDBnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hqZFhKUVlXZGxMbTVoZEdsMlpTQXJJREVwS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGdLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ09Rb2dJQ0FnUEFvZ0lDQWdZbm9nWDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2w5aWJHOWphMEF4TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU56SXRNamMxQ2lBZ0lDQXZMeUJqYjI1emRDQndZV2RwYm1GMFpXUkxaWGtnUFNCdVpYY2dZWEpqTVRReE1GOUliMnhrYVc1blVHRnlkR2wwYVc5dWMxQmhaMmx1WVhSbFpFdGxlU2g3Q2lBZ0lDQXZMeUFnSUdodmJHUmxjam9nYUc5c1pHVnlMQW9nSUNBZ0x5OGdJQ0J3WVdkbE9pQmpkWEpRWVdkbExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdhMlY1VUhKbFptbDRPaUFuWVhKak1UUXhNRjlvY0Y5aEp5d0tJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmhjbU14TkRFd1gyaHdYMkVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJM05nb2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxtaHZiR1JsY2xCaGNuUnBkR2x2Ym5OQlpHUnlaWE56WlhNb2NHRm5hVzVoZEdWa1MyVjVLUzVsZUdsemRITXBJSHNLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklGOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTNOd29nSUNBZ0x5OGdkR2hwY3k1b2IyeGtaWEpRWVhKMGFYUnBiMjV6UVdSa2NtVnpjMlZ6S0hCaFoybHVZWFJsWkV0bGVTa3VkbUZzZFdVZ1BTQmJjR0Z5ZEdsamFYQmhkR2x2YmwwS0lDQWdJR0o1ZEdWaklERTFJQzh2SURCNE1EQXdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvS1gyRmtaRjl3WVhKMGFXTnBjR0YwYVc5dVgzUnZYMmh2YkdSbGNsOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTRNQW9nSUNBZ0x5OGdhV1lnS0hSb2FYTXVZMjl1ZEdGcGJuTkJaR1J5WlhOektIUm9hWE11YUc5c1pHVnlVR0Z5ZEdsMGFXOXVjMEZrWkhKbGMzTmxjeWh3WVdkcGJtRjBaV1JMWlhrcExuWmhiSFZsTENCd1lYSjBhV05wY0dGMGFXOXVLU2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU5UUUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdkaUJ2WmlCaEtTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTndvS1gyRmtaRjl3WVhKMGFXTnBjR0YwYVc5dVgzUnZYMmh2YkdSbGNsOW1iM0pmYUdWaFpHVnlRREUzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU5UUUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdkaUJ2WmlCaEtTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ053b2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJRHdLSUNBZ0lHSjZJRjloWkdSZmNHRnlkR2xqYVhCaGRHbHZibDkwYjE5b2IyeGtaWEpmWVdaMFpYSmZabTl5UURJeENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTFOUW9nSUNBZ0x5OGdhV1lnS0hZZ1BUMDlJSGdwSUhKbGRIVnliaUIwY25WbENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDA5Q2lBZ0lDQmllaUJmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFNakFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3BmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem82UVhKak1UUXhNQzVqYjI1MFlXbHVjMEZrWkhKbGMzTkFNakk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJNE1Bb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdVkyOXVkR0ZwYm5OQlpHUnlaWE56S0hSb2FYTXVhRzlzWkdWeVVHRnlkR2wwYVc5dWMwRmtaSEpsYzNObGN5aHdZV2RwYm1GMFpXUkxaWGtwTG5aaGJIVmxMQ0J3WVhKMGFXTnBjR0YwYVc5dUtTa2dld29nSUNBZ1lub2dYMkZrWkY5d1lYSjBhV05wY0dGMGFXOXVYM1J2WDJodmJHUmxjbDloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNamd4Q2lBZ0lDQXZMeUJtYjNWdVpDQTlJSFJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFlLQ2w5aFpHUmZjR0Z5ZEdsamFYQmhkR2x2Ymw5MGIxOW9iMnhrWlhKZllteHZZMnRBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTROUW9nSUNBZ0x5OGdhV1lnS0NGbWIzVnVaQ2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JRFlLSUNBZ0lHSnVlaUJmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TWpnMkxUSTRPUW9nSUNBZ0x5OGdZMjl1YzNRZ2NHRm5hVzVoZEdWa1MyVjVJRDBnYm1WM0lHRnlZekUwTVRCZlNHOXNaR2x1WjFCaGNuUnBkR2x2Ym5OUVlXZHBibUYwWldSTFpYa29ld29nSUNBZ0x5OGdJQ0JvYjJ4a1pYSTZJR2h2YkdSbGNpd0tJQ0FnSUM4dklDQWdjR0ZuWlRvZ2JHRnpkRkJoWjJVc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QnJaWGxRY21WbWFYZzZJQ2RoY21NeE5ERXdYMmh3WDJFbkxBb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltRnlZekUwTVRCZmFIQmZZU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TWprd0NpQWdJQ0F2THlCamIyNXpkQ0JwZEdWdGMwTnZkVzUwSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNoMGFHbHpMbWh2YkdSbGNsQmhjblJwZEdsdmJuTkJaR1J5WlhOelpYTW9jR0ZuYVc1aGRHVmtTMlY1S1M1MllXeDFaUzVzWlc1bmRHZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakk1TVFvZ0lDQWdMeThnYVdZZ0tHbDBaVzF6UTI5MWJuUXVibUYwYVhabElEd2dNVEFwSUhzS0lDQWdJR0owYjJrS0lDQWdJSEIxYzJocGJuUWdNVEFnTHk4Z01UQUtJQ0FnSUR3S0lDQWdJR0o2SUY5aFpHUmZjR0Z5ZEdsamFYQmhkR2x2Ymw5MGIxOW9iMnhrWlhKZlpXeHpaVjlpYjJSNVFERXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakk1TkFvZ0lDQWdMeThnTGk0dWRHaHBjeTVvYjJ4a1pYSlFZWEowYVhScGIyNXpRV1JrY21WemMyVnpLSEJoWjJsdVlYUmxaRXRsZVNrdWRtRnNkV1VzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95T1RNdE1qazJDaUFnSUNBdkx5QjBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5CWkdSeVpYTnpaWE1vY0dGbmFXNWhkR1ZrUzJWNUtTNTJZV3gxWlNBOUlGc0tJQ0FnSUM4dklDQWdMaTR1ZEdocGN5NW9iMnhrWlhKUVlYSjBhWFJwYjI1elFXUmtjbVZ6YzJWektIQmhaMmx1WVhSbFpFdGxlU2t1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJSEJoY25ScFkybHdZWFJwYjI0c0NpQWdJQ0F2THlCZENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU9UVUtJQ0FnSUM4dklIQmhjblJwWTJsd1lYUnBiMjRzQ2lBZ0lDQmllWFJsWXlBeE5TQXZMeUF3ZURBd01ERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakk1TXkweU9UWUtJQ0FnSUM4dklIUm9hWE11YUc5c1pHVnlVR0Z5ZEdsMGFXOXVjMEZrWkhKbGMzTmxjeWh3WVdkcGJtRjBaV1JMWlhrcExuWmhiSFZsSUQwZ1d3b2dJQ0FnTHk4Z0lDQXVMaTUwYUdsekxtaHZiR1JsY2xCaGNuUnBkR2x2Ym5OQlpHUnlaWE56WlhNb2NHRm5hVzVoZEdWa1MyVjVLUzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdjR0Z5ZEdsamFYQmhkR2x2Yml3S0lDQWdJQzh2SUYwS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0NsOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZZV1owWlhKZmFXWmZaV3h6WlVBeE5Ub0tJQ0FnSUhKbGRITjFZZ29LWDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2w5bGJITmxYMkp2WkhsQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakk1T0FvZ0lDQWdMeThnWTI5dWMzUWdibVYzVEdGemRGQmhaMlVnUFNCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0d4aGMzUlFZV2RsTG01aGRHbDJaU0FySURFcENpQWdJQ0JtY21GdFpWOWthV2NnT1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNams1Q2lBZ0lDQXZMeUIwYUdsekxtaHZiR1JsY2xCaGNuUnBkR2x2Ym5ORGRYSnlaVzUwVUdGblpTaG9iMnhrWlhJcExuWmhiSFZsSUQwZ2JtVjNUR0Z6ZEZCaFoyVUtJQ0FnSUdaeVlXMWxYMlJwWnlBeE1Bb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXpBd0xUTXdNd29nSUNBZ0x5OGdZMjl1YzNRZ2JtVjNVR0ZuYVc1aGRHVmtTMlY1SUQwZ2JtVjNJR0Z5WXpFME1UQmZTRzlzWkdsdVoxQmhjblJwZEdsdmJuTlFZV2RwYm1GMFpXUkxaWGtvZXdvZ0lDQWdMeThnSUNCb2IyeGtaWEk2SUdodmJHUmxjaXdLSUNBZ0lDOHZJQ0FnY0dGblpUb2dibVYzVEdGemRGQmhaMlVzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16QTBDaUFnSUNBdkx5QjBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5CWkdSeVpYTnpaWE1vYm1WM1VHRm5hVzVoZEdWa1MyVjVLUzUyWVd4MVpTQTlJRnR3WVhKMGFXTnBjR0YwYVc5dVhRb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z01IZ3dNREF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOW9jRjloSnl3S0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKaGNtTXhOREV3WDJod1gyRWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pNRFFLSUNBZ0lDOHZJSFJvYVhNdWFHOXNaR1Z5VUdGeWRHbDBhVzl1YzBGa1pISmxjM05sY3lodVpYZFFZV2RwYm1GMFpXUkxaWGtwTG5aaGJIVmxJRDBnVzNCaGNuUnBZMmx3WVhScGIyNWRDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNncGZZV1JrWDNCaGNuUnBZMmx3WVhScGIyNWZkRzlmYUc5c1pHVnlYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNamN4Q2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JqZFhKUVlXZGxJRDBnY0dGblpUc2dZM1Z5VUdGblpTNXVZWFJwZG1VZ1BDQnNZWE4wVUdGblpTNXVZWFJwZG1VN0lHTjFjbEJoWjJVZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtHTjFjbEJoWjJVdWJtRjBhWFpsSUNzZ01Ta3BJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QTRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQmlJRjloWkdSZmNHRnlkR2xqYVhCaGRHbHZibDkwYjE5b2IyeGtaWEpmZDJocGJHVmZkRzl3UURNS0NsOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZZV1owWlhKZmFXWmZaV3h6WlVBeU1Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBM0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQTNDaUFnSUNCaUlGOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZabTl5WDJobFlXUmxja0F4TndvS1gyRmtaRjl3WVhKMGFXTnBjR0YwYVc5dVgzUnZYMmh2YkdSbGNsOWhablJsY2w5bWIzSkFNakU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJMU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lPREFLSUNBZ0lDOHZJR2xtSUNoMGFHbHpMbU52Ym5SaGFXNXpRV1JrY21WemN5aDBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5CWkdSeVpYTnpaWE1vY0dGbmFXNWhkR1ZrUzJWNUtTNTJZV3gxWlN3Z2NHRnlkR2xqYVhCaGRHbHZiaWtwSUhzS0lDQWdJR0lnWDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2w5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02T2tGeVl6RTBNVEF1WTI5dWRHRnBibk5CWkdSeVpYTnpRREl5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem82UVhKak1UUXhNQzVmZEhKaGJuTm1aWEpmY0dGeWRHbDBhVzl1S0daeWIyMDZJR0o1ZEdWekxDQm1jbTl0VUdGeWRHbDBhVzl1T2lCaWVYUmxjeXdnZEc4NklHSjVkR1Z6TENCMGIxQmhjblJwZEdsdmJqb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ1lubDBaWE1zSUdSaGRHRTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGZkSEpoYm5ObVpYSmZjR0Z5ZEdsMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96TVRndE16STFDaUFnSUNBdkx5QndjbTkwWldOMFpXUWdYM1J5WVc1elptVnlYM0JoY25ScGRHbHZiaWdLSUNBZ0lDOHZJQ0FnWm5KdmJUb2dZWEpqTkM1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCbWNtOXRVR0Z5ZEdsMGFXOXVPaUJoY21NMExrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIUnZPaUJoY21NMExrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIUnZVR0Z5ZEdsMGFXOXVPaUJoY21NMExrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1lYSmpOQzVWYVc1MFRqSTFOaXdLSUNBZ0lDOHZJQ0FnWkdGMFlUb2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTXNDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRFlnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96TWpZS0lDQWdJQzh2SUdGemMyVnlkQ2hoYlc5MWJuUXVibUYwYVhabElENGdNQ3dnSjBsdWRtRnNhV1FnWVcxdmRXNTBKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaVBnb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnWVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak15T0FvZ0lDQWdMeThnWTI5dWMzUWdabkp2YlV0bGVTQTlJRzVsZHlCaGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTaDdJR2h2YkdSbGNqb2dabkp2YlN3Z2NHRnlkR2wwYVc5dU9pQm1jbTl0VUdGeWRHbDBhVzl1SUgwcENpQWdJQ0JtY21GdFpWOWthV2NnTFRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRnlkR2wwYVc5dWN5QTlJRUp2ZUUxaGNEeGhjbU14TkRFd1gxQmhjblJwZEdsdmJrdGxlU3dnWVhKak5DNVZhVzUwVGpJMU5qNG9leUJyWlhsUWNtVm1hWGc2SUNkaGNtTXhOREV3WDNBbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhjbU14TkRFd1gzQWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96TWprS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1d1lYSjBhWFJwYjI1ektHWnliMjFMWlhrcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWDNSeVlXNXpabVZ5WDNCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXpNd0NpQWdJQ0F2THlCMGFHbHpMbkJoY25ScGRHbHZibk1vWm5KdmJVdGxlU2t1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWd3S1FvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmliM2hmY0hWMENncGZkSEpoYm5ObVpYSmZjR0Z5ZEdsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNek15Q2lBZ0lDQXZMeUIwYUdsekxuQmhjblJwZEdsdmJuTW9abkp2YlV0bGVTa3VkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpJMU5paDBhR2x6TG5CaGNuUnBkR2x2Ym5Nb1puSnZiVXRsZVNrdWRtRnNkV1V1Ym1GMGFYWmxJQzBnWVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lud0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXpNM0xUTTBNd29nSUNBZ0x5OGdibVYzSUdGeVl6RTBNVEJmY0dGeWRHbDBhVzl1WDNSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ1puSnZiVG9nWm5KdmJTd0tJQ0FnSUM4dklDQWdkRzg2SUhSdkxBb2dJQ0FnTHk4Z0lDQndZWEowYVhScGIyNDZJR1p5YjIxUVlYSjBhWFJwYjI0c0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCa1lYUmhPaUJrWVhSaExBb2dJQ0FnTHk4Z2ZTa3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3T0RJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNek0xTFRNME5Bb2dJQ0FnTHk4Z1pXMXBkQ2dLSUNBZ0lDOHZJQ0FnSjFSeVlXNXpabVZ5Snl3S0lDQWdJQzh2SUNBZ2JtVjNJR0Z5WXpFME1UQmZjR0Z5ZEdsMGFXOXVYM1J5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCbWNtOXRPaUJtY205dExBb2dJQ0FnTHk4Z0lDQWdJSFJ2T2lCMGJ5d0tJQ0FnSUM4dklDQWdJQ0J3WVhKMGFYUnBiMjQ2SUdaeWIyMVFZWEowYVhScGIyNHNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWkdGMFlUb2daR0YwWVN3S0lDQWdJQzh2SUNBZ2ZTa3NDaUFnSUNBdkx5QXBDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QXdlREF3TURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1qQTJZamM1TkRBZ0x5OGdiV1YwYUc5a0lDSlVjbUZ1YzJabGNpZ29ZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTml4aWVYUmxXMTBwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTTBOd29nSUNBZ0x5OGdhV1lnS0hSdlVHRnlkR2wwYVc5dUlDRTlQU0JtY205dFVHRnlkR2wwYVc5dUtTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnSVQwS0lDQWdJR0o2SUY5MGNtRnVjMlpsY2w5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNME9Bb2dJQ0FnTHk4Z2RHaHBjeTVmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5S0hSdkxDQjBiMUJoY25ScGRHbHZiaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCallXeHNjM1ZpSUY5aFpHUmZjR0Z5ZEdsamFYQmhkR2x2Ymw5MGIxOW9iMnhrWlhJS0NsOTBjbUZ1YzJabGNsOXdZWEowYVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pOVElLSUNBZ0lDOHZJR052Ym5OMElIUnZTMlY1SUQwZ2JtVjNJR0Z5WXpFME1UQmZVR0Z5ZEdsMGFXOXVTMlY1S0hzZ2FHOXNaR1Z5T2lCMGJ5d2djR0Z5ZEdsMGFXOXVPaUIwYjFCaGNuUnBkR2x2YmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdjSFZpYkdsaklIQmhjblJwZEdsdmJuTWdQU0JDYjNoTllYQThZWEpqTVRReE1GOVFZWEowYVhScGIyNUxaWGtzSUdGeVl6UXVWV2x1ZEU0eU5UWStLSHNnYTJWNVVISmxabWw0T2lBbllYSmpNVFF4TUY5d0p5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZWEpqTVRReE1GOXdJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96TlRNS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1d1lYSjBhWFJwYjI1ektIUnZTMlY1S1M1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJRjkwY21GdWMyWmxjbDl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak0xTkFvZ0lDQWdMeThnZEdocGN5NXdZWEowYVhScGIyNXpLSFJ2UzJWNUtTNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTWpVMktEQXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdKdmVGOXdkWFFLQ2w5MGNtRnVjMlpsY2w5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek5UWUtJQ0FnSUM4dklIUm9hWE11Y0dGeWRHbDBhVzl1Y3loMGIwdGxlU2t1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWgwYUdsekxuQmhjblJwZEdsdmJuTW9kRzlMWlhrcExuWmhiSFZsTG01aGRHbDJaU0FySUdGdGIzVnVkQzV1WVhScGRtVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSjhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pwQmNtTXhOREV3TG1GeVl6RTBNVEJmWVhWMGFHOXlhWHBsWDI5d1pYSmhkRzl5WDJKNVgzQnZjblJwYjI0b2FHOXNaR1Z5T2lCaWVYUmxjeXdnYjNCbGNtRjBiM0k2SUdKNWRHVnpMQ0J3WVhKMGFYUnBiMjQ2SUdKNWRHVnpMQ0JoYlc5MWJuUTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGhjbU14TkRFd1gyRjFkR2h2Y21sNlpWOXZjR1Z5WVhSdmNsOWllVjl3YjNKMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96TlRrdE16WTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6RTBNVEJmWVhWMGFHOXlhWHBsWDI5d1pYSmhkRzl5WDJKNVgzQnZjblJwYjI0b0NpQWdJQ0F2THlBZ0lHaHZiR1JsY2pvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0J2Y0dWeVlYUnZjam9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQndZWEowYVhScGIyNDZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCaGNtTTBMbFZwYm5ST01qVTJMQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUEwSURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16WTJDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQVDBnYUc5c1pHVnlMQ0FuVDI1c2VTQm9iMnhrWlhJZ1kyRnVJR0YxZEdodmNtbDZaU0J3YjNKMGFXOXVKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHaHZiR1JsY2lCallXNGdZWFYwYUc5eWFYcGxJSEJ2Y25ScGIyNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNelkzQ2lBZ0lDQXZMeUJqYjI1emRDQnJaWGtnUFNCdVpYY2dZWEpqTVRReE1GOVBjR1Z5WVhSdmNsQnZjblJwYjI1TFpYa29leUJvYjJ4a1pYSXNJRzl3WlhKaGRHOXlMQ0J3WVhKMGFYUnBiMjRnZlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QndkV0pzYVdNZ2IzQmxjbUYwYjNKUWIzSjBhVzl1UVd4c2IzZGhibU5sY3lBOUlFSnZlRTFoY0R4aGNtTXhOREV3WDA5d1pYSmhkRzl5VUc5eWRHbHZia3RsZVN3Z1lYSmpOQzVWYVc1MFRqSTFOajRvZXlCclpYbFFjbVZtYVhnNklDZGhjbU14TkRFd1gyOXdZU2NnZlNrS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKaGNtTXhOREV3WDI5d1lTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96TmpnS0lDQWdJQzh2SUhSb2FYTXViM0JsY21GMGIzSlFiM0owYVc5dVFXeHNiM2RoYm1ObGN5aHJaWGtwTG5aaGJIVmxJRDBnWVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02T2tGeVl6RTBNVEF1WVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2w5aWVWOXdiM0owYVc5dUtHaHZiR1JsY2pvZ1lubDBaWE1zSUc5d1pYSmhkRzl5T2lCaWVYUmxjeXdnY0dGeWRHbDBhVzl1T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21GeVl6RTBNVEJmYVhOZmIzQmxjbUYwYjNKZllubGZjRzl5ZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNemN4TFRNM05nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5ERXdYMmx6WDI5d1pYSmhkRzl5WDJKNVgzQnZjblJwYjI0b0NpQWdJQ0F2THlBZ0lHaHZiR1JsY2pvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0J2Y0dWeVlYUnZjam9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQndZWEowYVhScGIyNDZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNrNklHRnlZelF1UW05dmJDQjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNM053b2dJQ0FnTHk4Z2FXWWdLRzl3WlhKaGRHOXlJRDA5UFNCb2IyeGtaWElwSUhKbGRIVnliaUJ1WlhjZ1lYSmpOQzVDYjI5c0tIUnlkV1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1BUMEtJQ0FnSUdKNklHRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSmZZbmxmY0c5eWRHbHZibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzRNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwaGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgySjVYM0J2Y25ScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pOemdLSUNBZ0lDOHZJR052Ym5OMElHdGxlU0E5SUc1bGR5QmhjbU14TkRFd1gwOXdaWEpoZEc5eVVHOXlkR2x2Ymt0bGVTaDdJR2h2YkdSbGNpd2diM0JsY21GMGIzSXNJSEJoY25ScGRHbHZiaUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklIQjFZbXhwWXlCdmNHVnlZWFJ2Y2xCdmNuUnBiMjVCYkd4dmQyRnVZMlZ6SUQwZ1FtOTRUV0Z3UEdGeVl6RTBNVEJmVDNCbGNtRjBiM0pRYjNKMGFXOXVTMlY1TENCaGNtTTBMbFZwYm5ST01qVTJQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRnlZekUwTVRCZmIzQmhKeUI5S1FvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW1GeVl6RTBNVEJmYjNCaElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pOemtLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTV2Y0dWeVlYUnZjbEJ2Y25ScGIyNUJiR3h2ZDJGdVkyVnpLR3RsZVNrdVpYaHBjM1J6S1NCeVpYUjFjbTRnYm1WM0lHRnlZelF1UW05dmJDaG1ZV3h6WlNrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR0Z5WXpFME1UQmZhWE5mYjNCbGNtRjBiM0pmWW5sZmNHOXlkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncGhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlYMko1WDNCdmNuUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96T0RBS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1lYSmpOQzVDYjI5c0tIUm9hWE11YjNCbGNtRjBiM0pRYjNKMGFXOXVRV3hzYjNkaGJtTmxjeWhyWlhrcExuWmhiSFZsTG01aGRHbDJaU0ErSURBcENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPanBCY21NeE5ERXdMbUZ5WXpFME1UQmZhWE56ZFdWZllubGZjR0Z5ZEdsMGFXOXVLSFJ2T2lCaWVYUmxjeXdnY0dGeWRHbDBhVzl1T2lCaWVYUmxjeXdnWVcxdmRXNTBPaUJpZVhSbGN5d2daR0YwWVRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21GeVl6RTBNVEJmYVhOemRXVmZZbmxmY0dGeWRHbDBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek9ETXRNemc1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUwTVRCZmFYTnpkV1ZmWW5sZmNHRnlkR2wwYVc5dUtBb2dJQ0FnTHk4Z0lDQjBiem9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQndZWEowYVhScGIyNDZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCaGNtTTBMbFZwYm5ST01qVTJMQW9nSUNBZ0x5OGdJQ0JrWVhSaE9pQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5d0tJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdOQ0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak01TUFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVlYSmpPRGhmYVhOZmIzZHVaWElvYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NrdWJtRjBhWFpsSUQwOVBTQjBjblZsTENBbmIyNXNlVjl2ZDI1bGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpnNFgybHpYMjkzYm1WeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZibXg1WDI5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak01TVFvZ0lDQWdMeThnWVhOelpYSjBLR0Z0YjNWdWRDNXVZWFJwZG1VZ1BpQXdMQ0FuU1c1MllXeHBaQ0JoYlc5MWJuUW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUdJK0NpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0JoYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNemt6Q2lBZ0lDQXZMeUJqYjI1emRDQjBiMHRsZVNBOUlHNWxkeUJoY21NeE5ERXdYMUJoY25ScGRHbHZia3RsZVNoN0lHaHZiR1JsY2pvZ2RHOHNJSEJoY25ScGRHbHZiaUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCd2RXSnNhV01nY0dGeWRHbDBhVzl1Y3lBOUlFSnZlRTFoY0R4aGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTd2dZWEpqTkM1VmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RoY21NeE5ERXdYM0FuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaGNtTXhOREV3WDNBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pPVFFLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTV3WVhKMGFYUnBiMjV6S0hSdlMyVjVLUzVsZUdsemRITXBJSHNLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHRnlZekUwTVRCZmFYTnpkV1ZmWW5sZmNHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek9UVUtJQ0FnSUM4dklIUm9hWE11Y0dGeWRHbDBhVzl1Y3loMGIwdGxlU2t1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWd3S1FvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTTVOZ29nSUNBZ0x5OGdkR2hwY3k1ZllXUmtYM0JoY25ScFkybHdZWFJwYjI1ZmRHOWZhRzlzWkdWeUtIUnZMQ0J3WVhKMGFYUnBiMjRwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyRnNiSE4xWWlCZllXUmtYM0JoY25ScFkybHdZWFJwYjI1ZmRHOWZhRzlzWkdWeUNncGhjbU14TkRFd1gybHpjM1ZsWDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTTVPQW9nSUNBZ0x5OGdkR2hwY3k1d1lYSjBhWFJwYjI1ektIUnZTMlY1S1M1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUk9NalUyS0hSb2FYTXVjR0Z5ZEdsMGFXOXVjeWgwYjB0bGVTa3VkbUZzZFdVdWJtRjBhWFpsSUNzZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdJckNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZbndLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z2NIVmliR2xqSUdKaGJHRnVZMlZ6SUQwZ1FtOTRUV0Z3UEVGa1pISmxjM01zSUZWcGJuUk9NalUyUGloN0lHdGxlVkJ5WldacGVEb2dKMkluSUgwcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKaUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUXdNQW9nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbUpoYkdGdVkyVnpLSFJ2S1M1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR0Z5WXpFME1UQmZhWE56ZFdWZllubGZjR0Z5ZEdsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNREVLSUNBZ0lDOHZJSFJvYVhNdVltRnNZVzVqWlhNb2RHOHBMblpoYkhWbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0eU5UWW9NQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1ltOTRYM0IxZEFvS1lYSmpNVFF4TUY5cGMzTjFaVjlpZVY5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME1ETUtJQ0FnSUM4dklIUm9hWE11WW1Gc1lXNWpaWE1vZEc4cExuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTR5TlRZb2RHaHBjeTVpWVd4aGJtTmxjeWgwYnlrdWRtRnNkV1V1Ym1GMGFYWmxJQ3NnWVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0lyQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmlmQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCd2RXSnNhV01nZEc5MFlXeFRkWEJ3YkhrZ1BTQkhiRzlpWVd4VGRHRjBaVHhWYVc1MFRqSTFOajRvZXlCclpYazZJQ2QwSnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME1EUUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFRkWEJ3YkhrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmloMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxMbTVoZEdsMlpTQXJJR0Z0YjNWdWRDNXVZWFJwZG1VcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0lyQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmlmQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkRzkwWVd4VGRYQndiSGtnUFNCSGJHOWlZV3hUZEdGMFpUeFZhVzUwVGpJMU5qNG9leUJyWlhrNklDZDBKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5EQTBDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNVM1Z3Y0d4NUxuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTR5TlRZb2RHaHBjeTUwYjNSaGJGTjFjSEJzZVM1MllXeDFaUzV1WVhScGRtVWdLeUJoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOREExQ2lBZ0lDQXZMeUJsYldsMEtDZEpjM04xWlNjc0lHNWxkeUJoY21NeE5ERXdYM0JoY25ScGRHbHZibDlwYzNOMVpTaDdJSFJ2TENCd1lYSjBhWFJwYjI0c0lHRnRiM1Z1ZEN3Z1pHRjBZU0I5S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01UWWdMeThnTUhnd01EWXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE15QXZMeUF3ZURBd01ESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRabUUwTkROaU1XSWdMeThnYldWMGFHOWtJQ0pKYzNOMVpTZ29ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZc1lubDBaVnRkS1NraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzZRWEpqTVRReE1DNWhjbU14TkRFd1gzSmxaR1ZsYlY5aWVWOXdZWEowYVhScGIyNG9jR0Z5ZEdsMGFXOXVPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQmllWFJsY3l3Z1pHRjBZVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbUZ5WXpFME1UQmZjbVZrWldWdFgySjVYM0JoY25ScGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRBNExUUXdPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOREV3WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI0b2NHRnlkR2wwYVc5dU9pQmhjbU0wTGtGa1pISmxjM01zSUdGdGIzVnVkRG9nWVhKak5DNVZhVzUwVGpJMU5pd2daR0YwWVRvZ1lYSmpOQzVFZVc1aGJXbGpRbmwwWlhNcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTVRBS0lDQWdJQzh2SUdOdmJuTjBJR1p5YjIwZ1BTQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUXhNUW9nSUNBZ0x5OGdZWE56WlhKMEtHRnRiM1Z1ZEM1dVlYUnBkbVVnUGlBd0xDQW5TVzUyWVd4cFpDQmhiVzkxYm5RbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0krQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQmhiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5ERXlDaUFnSUNBdkx5QmpiMjV6ZENCbWNtOXRTMlY1SUQwZ2JtVjNJR0Z5WXpFME1UQmZVR0Z5ZEdsMGFXOXVTMlY1S0hzZ2FHOXNaR1Z5T2lCbWNtOXRMQ0J3WVhKMGFYUnBiMjRnZlNrS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdjSFZpYkdsaklIQmhjblJwZEdsdmJuTWdQU0JDYjNoTllYQThZWEpqTVRReE1GOVFZWEowYVhScGIyNUxaWGtzSUdGeVl6UXVWV2x1ZEU0eU5UWStLSHNnYTJWNVVISmxabWw0T2lBbllYSmpNVFF4TUY5d0p5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZWEpqTVRReE1GOXdJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pReE13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjR0Z5ZEdsMGFXOXVjeWhtY205dFMyVjVLUzVsZUdsemRITXNJQ2RRWVhKMGFYUnBiMjRnWW1Gc1lXNWpaU0J0YVhOemFXNW5KeWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVUdGeWRHbDBhVzl1SUdKaGJHRnVZMlVnYldsemMybHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTVRRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuQmhjblJwZEdsdmJuTW9abkp2YlV0bGVTa3VkbUZzZFdVdWJtRjBhWFpsSUQ0OUlHRnRiM1Z1ZEM1dVlYUnBkbVVzSUNkSmJuTjFabVpwWTJsbGJuUWdjR0Z5ZEdsMGFXOXVJR0poYkdGdVkyVW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaVBqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdjR0Z5ZEdsMGFXOXVJR0poYkdGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOREUxQ2lBZ0lDQXZMeUIwYUdsekxuQmhjblJwZEdsdmJuTW9abkp2YlV0bGVTa3VkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpJMU5paDBhR2x6TG5CaGNuUnBkR2x2Ym5Nb1puSnZiVXRsZVNrdWRtRnNkV1V1Ym1GMGFYWmxJQzBnWVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWkwS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWW53S0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdjSFZpYkdsaklHSmhiR0Z1WTJWeklEMGdRbTk0VFdGd1BFRmtaSEpsYzNNc0lGVnBiblJPTWpVMlBpaDdJR3RsZVZCeVpXWnBlRG9nSjJJbklIMHBDaUFnSUNCaWVYUmxZeUEySUM4dklDSmlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRFM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWlZV3hoYm1ObGN5aG1jbTl0S1M1bGVHbHpkSE1nSmlZZ2RHaHBjeTVpWVd4aGJtTmxjeWhtY205dEtTNTJZV3gxWlM1dVlYUnBkbVVnUGowZ1lXMXZkVzUwTG01aGRHbDJaU3dnSjBsdWMzVm1abWxqYVdWdWRDQmlZV3hoYm1ObEp5a0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWVhKak1UUXhNRjl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0krUFFvZ0lDQWdZbm9nWVhKak1UUXhNRjl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtRnlZekUwTVRCZmNtVmtaV1Z0WDJKNVgzQmhjblJwZEdsdmJsOWliMjlzWDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pReE53b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbUZzWVc1alpYTW9abkp2YlNrdVpYaHBjM1J6SUNZbUlIUm9hWE11WW1Gc1lXNWpaWE1vWm5KdmJTa3VkbUZzZFdVdWJtRjBhWFpsSUQ0OUlHRnRiM1Z1ZEM1dVlYUnBkbVVzSUNkSmJuTjFabVpwWTJsbGJuUWdZbUZzWVc1alpTY3BDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBJR0poYkdGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOREU0Q2lBZ0lDQXZMeUIwYUdsekxtSmhiR0Z1WTJWektHWnliMjBwTG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1VldsdWRFNHlOVFlvZEdocGN5NWlZV3hoYm1ObGN5aG1jbTl0S1M1MllXeDFaUzV1WVhScGRtVWdMU0JoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaTBLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHSjhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUhCMVlteHBZeUIwYjNSaGJGTjFjSEJzZVNBOUlFZHNiMkpoYkZOMFlYUmxQRlZwYm5ST01qVTJQaWg3SUd0bGVUb2dKM1FuSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pReE9Rb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGTjFjSEJzZVM1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUk9NalUyS0hSb2FYTXVkRzkwWVd4VGRYQndiSGt1ZG1Gc2RXVXVibUYwYVhabElDMGdZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaTBLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHSjhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjBiM1JoYkZOMWNIQnNlU0E5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTWpVMlBpaDdJR3RsZVRvZ0ozUW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME1Ua0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFRkWEJ3YkhrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmloMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxMbTVoZEdsMlpTQXRJR0Z0YjNWdWRDNXVZWFJwZG1VcENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNakFLSUNBZ0lDOHZJR1Z0YVhRb0oxSmxaR1ZsYlNjc0lHNWxkeUJoY21NeE5ERXdYM0JoY25ScGRHbHZibDl5WldSbFpXMG9leUJtY205dExDQndZWEowYVhScGIyNHNJR0Z0YjNWdWRDd2daR0YwWVNCOUtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z01IZ3dNRFl5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VEQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01Ua2dMeThnYldWMGFHOWtJQ0pTWldSbFpXMG9LR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMkxHSjVkR1ZiWFNrcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LWVhKak1UUXhNRjl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDJKdmIyeGZabUZzYzJWQU16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdGeVl6RTBNVEJmY21Wa1pXVnRYMko1WDNCaGNuUnBkR2x2Ymw5aWIyOXNYMjFsY21kbFFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qcEJjbU14TkRFd0xtRnlZekUwTVRCZmIzQmxjbUYwYjNKZmNtVmtaV1Z0WDJKNVgzQmhjblJwZEdsdmJpaG1jbTl0T2lCaWVYUmxjeXdnY0dGeWRHbDBhVzl1T2lCaWVYUmxjeXdnWVcxdmRXNTBPaUJpZVhSbGN5d2daR0YwWVRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21GeVl6RTBNVEJmYjNCbGNtRjBiM0pmY21Wa1pXVnRYMko1WDNCaGNuUnBkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5ESXpMVFF5T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TkRFd1gyOXdaWEpoZEc5eVgzSmxaR1ZsYlY5aWVWOXdZWEowYVhScGIyNG9DaUFnSUNBdkx5QWdJR1p5YjIwNklHRnlZelF1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnY0dGeWRHbDBhVzl1T2lCaGNtTTBMa0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dZWEpqTkM1VmFXNTBUakkxTml3S0lDQWdJQzh2SUNBZ1pHRjBZVG9nWVhKak5DNUVlVzVoYldsalFubDBaWE1zQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURRZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNekFLSUNBZ0lDOHZJR052Ym5OMElITmxibVJsY2lBOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5ETXlDaUFnSUNBdkx5QnNaWFFnWVhWMGFHOXlhWHBsWkNBOUlIUm9hWE11WVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2lobWNtOXRMQ0J6Wlc1a1pYSXNJSEJoY25ScGRHbHZiaWt1Ym1GMGFYWmxJRDA5UFNCMGNuVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZORE13Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUXpNZ29nSUNBZ0x5OGdiR1YwSUdGMWRHaHZjbWw2WldRZ1BTQjBhR2x6TG1GeVl6RTBNVEJmYVhOZmIzQmxjbUYwYjNJb1puSnZiU3dnYzJWdVpHVnlMQ0J3WVhKMGFYUnBiMjRwTG01aGRHbDJaU0E5UFQwZ2RISjFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTBNVEJmYVhOZmIzQmxjbUYwYjNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRek13b2dJQ0FnTHk4Z2FXWWdLQ0ZoZFhSb2IzSnBlbVZrS1NCN0NpQWdJQ0JpYm5vZ1lYSmpNVFF4TUY5dmNHVnlZWFJ2Y2w5eVpXUmxaVzFmWW5sZmNHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME16UUtJQ0FnSUM4dklHTnZibk4wSUhCTFpYa2dQU0J1WlhjZ1lYSmpNVFF4TUY5UGNHVnlZWFJ2Y2xCdmNuUnBiMjVMWlhrb2V5Qm9iMnhrWlhJNklHWnliMjBzSUc5d1pYSmhkRzl5T2lCelpXNWtaWElzSUhCaGNuUnBkR2x2YmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdjSFZpYkdsaklHOXdaWEpoZEc5eVVHOXlkR2x2YmtGc2JHOTNZVzVqWlhNZ1BTQkNiM2hOWVhBOFlYSmpNVFF4TUY5UGNHVnlZWFJ2Y2xCdmNuUnBiMjVMWlhrc0lHRnlZelF1VldsdWRFNHlOVFkrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOXZjR0VuSUgwcENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaVlYSmpNVFF4TUY5dmNHRWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalF6TlFvZ0lDQWdMeThnYVdZZ0tIUm9hWE11YjNCbGNtRjBiM0pRYjNKMGFXOXVRV3hzYjNkaGJtTmxjeWh3UzJWNUtTNWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWVhKak1UUXhNRjl2Y0dWeVlYUnZjbDl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTXpZS0lDQWdJQzh2SUdOdmJuTjBJSEpsYldGcGJtbHVaeUE5SUhSb2FYTXViM0JsY21GMGIzSlFiM0owYVc5dVFXeHNiM2RoYm1ObGN5aHdTMlY1S1M1MllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZORE0zQ2lBZ0lDQXZMeUJoYzNObGNuUW9jbVZ0WVdsdWFXNW5MbTVoZEdsMlpTQStQU0JoYlc5MWJuUXVibUYwYVhabExDQW5VRzl5ZEdsdmJpQmhiR3h2ZDJGdVkyVWdaWGhqWldWa1pXUW5LUW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdJK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZCdmNuUnBiMjRnWVd4c2IzZGhibU5sSUdWNFkyVmxaR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRek9Bb2dJQ0FnTHk4Z1lYVjBhRzl5YVhwbFpDQTlJSFJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRNNUNpQWdJQ0F2THlCMGFHbHpMbTl3WlhKaGRHOXlVRzl5ZEdsdmJrRnNiRzkzWVc1alpYTW9jRXRsZVNrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmloeVpXMWhhVzVwYm1jdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpMEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpYjNoZmNIVjBDZ3BoY21NeE5ERXdYMjl3WlhKaGRHOXlYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05nb0tZWEpqTVRReE1GOXZjR1Z5WVhSdmNsOXlaV1JsWlcxZllubGZjR0Z5ZEdsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUTBNZ29nSUNBZ0x5OGdZWE56WlhKMEtHRjFkR2h2Y21sNlpXUXNJQ2RPYjNRZ1lYVjBhRzl5YVhwbFpDQnZjR1Z5WVhSdmNpY3BDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJR0YxZEdodmNtbDZaV1FnYjNCbGNtRjBiM0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRRMENpQWdJQ0F2THlCamIyNXpkQ0JtY205dFMyVjVJRDBnYm1WM0lHRnlZekUwTVRCZlVHRnlkR2wwYVc5dVMyVjVLSHNnYUc5c1pHVnlPaUJtY205dExDQndZWEowYVhScGIyNGdmU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0Z5ZEdsMGFXOXVjeUE5SUVKdmVFMWhjRHhoY21NeE5ERXdYMUJoY25ScGRHbHZia3RsZVN3Z1lYSmpOQzVWYVc1MFRqSTFOajRvZXlCclpYbFFjbVZtYVhnNklDZGhjbU14TkRFd1gzQW5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poY21NeE5ERXdYM0FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5EUTFDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV3WVhKMGFYUnBiMjV6S0daeWIyMUxaWGtwTG1WNGFYTjBjeXdnSjFCaGNuUnBkR2x2YmlCaVlXeGhibU5sSUcxcGMzTnBibWNuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYSjBhWFJwYjI0Z1ltRnNZVzVqWlNCdGFYTnphVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRME5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjR0Z5ZEdsMGFXOXVjeWhtY205dFMyVjVLUzUyWVd4MVpTNXVZWFJwZG1VZ1BqMGdZVzF2ZFc1MExtNWhkR2wyWlN3Z0owbHVjM1ZtWm1samFXVnVkQ0J3WVhKMGFYUnBiMjRnWW1Gc1lXNWpaU2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSStQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVjM1ZtWm1samFXVnVkQ0J3WVhKMGFYUnBiMjRnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTkRjS0lDQWdJQzh2SUhSb2FYTXVjR0Z5ZEdsMGFXOXVjeWhtY205dFMyVjVLUzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5ST01qVTJLSFJvYVhNdWNHRnlkR2wwYVc5dWN5aG1jbTl0UzJWNUtTNTJZV3gxWlM1dVlYUnBkbVVnTFNCaGJXOTFiblF1Ym1GMGFYWmxLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaUxRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0o4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklIQjFZbXhwWXlCaVlXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlpHUnlaWE56TENCVmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RpSnlCOUtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVlpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBORGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KaGJHRnVZMlZ6S0daeWIyMHBMbVY0YVhOMGN5QW1KaUIwYUdsekxtSmhiR0Z1WTJWektHWnliMjBwTG5aaGJIVmxMbTVoZEdsMlpTQStQU0JoYlc5MWJuUXVibUYwYVhabExDQW5TVzV6ZFdabWFXTnBaVzUwSUdKaGJHRnVZMlVuS1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmhjbU14TkRFd1gyOXdaWEpoZEc5eVgzSmxaR1ZsYlY5aWVWOXdZWEowYVhScGIyNWZZbTl2YkY5bVlXeHpaVUEzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lqNDlDaUFnSUNCaWVpQmhjbU14TkRFd1gyOXdaWEpoZEc5eVgzSmxaR1ZsYlY5aWVWOXdZWEowYVhScGIyNWZZbTl2YkY5bVlXeHpaVUEzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LWVhKak1UUXhNRjl2Y0dWeVlYUnZjbDl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDJKdmIyeGZiV1Z5WjJWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZORFE0Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aVlXeGhibU5sY3lobWNtOXRLUzVsZUdsemRITWdKaVlnZEdocGN5NWlZV3hoYm1ObGN5aG1jbTl0S1M1MllXeDFaUzV1WVhScGRtVWdQajBnWVcxdmRXNTBMbTVoZEdsMlpTd2dKMGx1YzNWbVptbGphV1Z1ZENCaVlXeGhibU5sSnlrS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1ltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME5Ea0tJQ0FnSUM4dklIUm9hWE11WW1Gc1lXNWpaWE1vWm5KdmJTa3VkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpJMU5paDBhR2x6TG1KaGJHRnVZMlZ6S0daeWIyMHBMblpoYkhWbExtNWhkR2wyWlNBdElHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaUxRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWW53S0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdjSFZpYkdsaklIUnZkR0ZzVTNWd2NHeDVJRDBnUjJ4dlltRnNVM1JoZEdVOFZXbHVkRTR5TlRZK0tIc2dhMlY1T2lBbmRDY2dmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZORFV3Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVTNWd2NHeDVMblpoYkhWbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0eU5UWW9kR2hwY3k1MGIzUmhiRk4xY0hCc2VTNTJZV3gxWlM1dVlYUnBkbVVnTFNCaGJXOTFiblF1Ym1GMGFYWmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaUxRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWW53S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSdmRHRnNVM1Z3Y0d4NUlEMGdSMnh2WW1Gc1UzUmhkR1U4VldsdWRFNHlOVFkrS0hzZ2EyVjVPaUFuZENjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalExTUFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkZOMWNIQnNlUzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5ST01qVTJLSFJvYVhNdWRHOTBZV3hUZFhCd2JIa3VkbUZzZFdVdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRMU1Rb2dJQ0FnTHk4Z1pXMXBkQ2duVW1Wa1pXVnRKeXdnYm1WM0lHRnlZekUwTVRCZmNHRnlkR2wwYVc5dVgzSmxaR1ZsYlNoN0lHWnliMjBzSUhCaGNuUnBkR2x2Yml3Z1lXMXZkVzUwTENCa1lYUmhJSDBwS1FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE5pQXZMeUF3ZURBd05qSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURFeklDOHZJREI0TURBd01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QnRaWFJvYjJRZ0lsSmxaR1ZsYlNnb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlzWW5sMFpWdGRLU2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjbVYwYzNWaUNncGhjbU14TkRFd1gyOXdaWEpoZEc5eVgzSmxaR1ZsYlY5aWVWOXdZWEowYVhScGIyNWZZbTl2YkY5bVlXeHpaVUEzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdZWEpqTVRReE1GOXZjR1Z5WVhSdmNsOXlaV1JsWlcxZllubGZjR0Z5ZEdsMGFXOXVYMkp2YjJ4ZmJXVnlaMlZBT0FvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem82UVhKak1qQXdMbUp2YjNSemRISmhjQ2h1WVcxbE9pQmllWFJsY3l3Z2MzbHRZbTlzT2lCaWVYUmxjeXdnWkdWamFXMWhiSE02SUdKNWRHVnpMQ0IwYjNSaGJGTjFjSEJzZVRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwaWIyOTBjM1J5WVhBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UWXROVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOXZkSE4wY21Gd0tHNWhiV1U2SUVSNWJtRnRhV05DZVhSbGN5d2djM2x0WW05c09pQkVlVzVoYldsalFubDBaWE1zSUdSbFkybHRZV3h6T2lCVmFXNTBUamdzSUhSdmRHRnNVM1Z3Y0d4NU9pQlZhVzUwVGpJMU5pazZJRUp2YjJ3Z2V3b2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2tGa1pISmxjM01zSUNkUGJteDVJR1JsY0d4dmVXVnlJRzltSUhSb2FYTWdjMjFoY25RZ1kyOXVkSEpoWTNRZ1kyRnVJR05oYkd3Z1ltOXZkSE4wY21Gd0lHMWxkR2h2WkNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JrWlhCc2IzbGxjaUJ2WmlCMGFHbHpJSE50WVhKMElHTnZiblJ5WVdOMElHTmhiaUJqWVd4c0lHSnZiM1J6ZEhKaGNDQnRaWFJvYjJRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0c1aGJXVXVibUYwYVhabExteGxibWQwYUNBK0lEQXNJQ2RPWVcxbElHOW1JSFJvWlNCaGMzTmxkQ0J0ZFhOMElHSmxJR3h2Ym1kbGNpQnZjaUJsY1hWaGJDQjBieUF4SUdOb1lYSmhZM1JsY2ljcENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFNWhiV1VnYjJZZ2RHaGxJR0Z6YzJWMElHMTFjM1FnWW1VZ2JHOXVaMlZ5SUc5eUlHVnhkV0ZzSUhSdklERWdZMmhoY21GamRHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVZVzFsTG01aGRHbDJaUzVzWlc1bmRHZ2dQRDBnTXpJc0lDZE9ZVzFsSUc5bUlIUm9aU0JoYzNObGRDQnRkWE4wSUdKbElITm9iM0owWlhJZ2IzSWdaWEYxWVd3Z2RHOGdNeklnWTJoaGNtRmpkR1Z5Y3ljcENpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbUZ0WlNCdlppQjBhR1VnWVhOelpYUWdiWFZ6ZENCaVpTQnphRzl5ZEdWeUlHOXlJR1Z4ZFdGc0lIUnZJRE15SUdOb1lYSmhZM1JsY25NS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hONWJXSnZiQzV1WVhScGRtVXViR1Z1WjNSb0lENGdNQ3dnSjFONWJXSnZiQ0J2WmlCMGFHVWdZWE56WlhRZ2JYVnpkQ0JpWlNCc2IyNW5aWElnYjNJZ1pYRjFZV3dnZEc4Z01TQmphR0Z5WVdOMFpYSW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJUZVcxaWIyd2diMllnZEdobElHRnpjMlYwSUcxMWMzUWdZbVVnYkc5dVoyVnlJRzl5SUdWeGRXRnNJSFJ2SURFZ1kyaGhjbUZqZEdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklHRnpjMlZ5ZENoemVXMWliMnd1Ym1GMGFYWmxMbXhsYm1kMGFDQThQU0E0TENBblUzbHRZbTlzSUc5bUlIUm9aU0JoYzNObGRDQnRkWE4wSUdKbElITm9iM0owWlhJZ2IzSWdaWEYxWVd3Z2RHOGdPQ0JqYUdGeVlXTjBaWEp6SnlrS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklGTjViV0p2YkNCdlppQjBhR1VnWVhOelpYUWdiWFZ6ZENCaVpTQnphRzl5ZEdWeUlHOXlJR1Z4ZFdGc0lIUnZJRGdnWTJoaGNtRmpkR1Z5Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCd2RXSnNhV01nZEc5MFlXeFRkWEJ3YkhrZ1BTQkhiRzlpWVd4VGRHRjBaVHhWYVc1MFRqSTFOajRvZXlCclpYazZJQ2QwSnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTUwYjNSaGJGTjFjSEJzZVM1b1lYTldZV3gxWlN3Z0oxUm9hWE1nYldWMGFHOWtJR05oYmlCaVpTQmpZV3hzWldRZ2IyNXNlU0J2Ym1ObEp5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlVhR2x6SUcxbGRHaHZaQ0JqWVc0Z1ltVWdZMkZzYkdWa0lHOXViSGtnYjI1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QndkV0pzYVdNZ2JtRnRaU0E5SUVkc2IySmhiRk4wWVhSbFBFUjVibUZ0YVdOQ2VYUmxjejRvZXlCclpYazZJQ2R1SnlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QjBhR2x6TG01aGJXVXVkbUZzZFdVZ1BTQnVZVzFsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUhCMVlteHBZeUJ6ZVcxaWIyd2dQU0JIYkc5aVlXeFRkR0YwWlR4RWVXNWhiV2xqUW5sMFpYTStLSHNnYTJWNU9pQW5jeWNnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2RHaHBjeTV6ZVcxaWIyd3VkbUZzZFdVZ1BTQnplVzFpYjJ3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSdmRHRnNVM1Z3Y0d4NUlEMGdSMnh2WW1Gc1UzUmhkR1U4VldsdWRFNHlOVFkrS0hzZ2EyVjVPaUFuZENjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOamNLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hUZFhCd2JIa3VkbUZzZFdVZ1BTQjBiM1JoYkZOMWNIQnNlUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1ZqYVcxaGJITWdQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUamcrS0hzZ2EyVjVPaUFuWkNjZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdkR2hwY3k1a1pXTnBiV0ZzY3k1MllXeDFaU0E5SUdSbFkybHRZV3h6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUdOdmJuTjBJSE5sYm1SbGNpQTlJRzVsZHlCQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUhCMVlteHBZeUJpWVd4aGJtTmxjeUE5SUVKdmVFMWhjRHhCWkdSeVpYTnpMQ0JWYVc1MFRqSTFOajRvZXlCclpYbFFjbVZtYVhnNklDZGlKeUI5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWWlJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdkR2hwY3k1aVlXeGhibU5sY3loelpXNWtaWElwTG5aaGJIVmxJRDBnZEc5MFlXeFRkWEJ3YkhrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QmxiV2wwS0c1bGR5QmhjbU15TURCZlZISmhibk5tWlhJb2V5Qm1jbTl0T2lCdVpYY2dRV1JrY21WemN5aEhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXBMQ0IwYnpvZ2MyVnVaR1Z5TENCMllXeDFaVG9nZEc5MFlXeFRkWEJ3YkhrZ2ZTa3BDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJREl3SUM4dklHMWxkR2h2WkNBaVlYSmpNakF3WDFSeVlXNXpabVZ5S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1FtOXZiQ2gwY25WbEtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEZ3dDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZPa0Z5WXpJd01DNWhjbU15TURCZmJtRnRaU2dwSUMwK0lHSjVkR1Z6T2dwaGNtTXlNREJmYm1GdFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdjSFZpYkdsaklHNWhiV1VnUFNCSGJHOWlZV3hUZEdGMFpUeEVlVzVoYldsalFubDBaWE0rS0hzZ2EyVjVPaUFuYmljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW00aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lGTjBZWFJwWTBKNWRHVnpQRE15UGloMGFHbHpMbTVoYldVdWRtRnNkV1V1Ym1GMGFYWmxLUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnphWHBsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVoY21NeU1EQmZjM2x0WW05c0tDa2dMVDRnWW5sMFpYTTZDbUZ5WXpJd01GOXplVzFpYjJ3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklIQjFZbXhwWXlCemVXMWliMndnUFNCSGJHOWlZV3hUZEdGMFpUeEVlVzVoYldsalFubDBaWE0rS0hzZ2EyVjVPaUFuY3ljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2prMENpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lGTjBZWFJwWTBKNWRHVnpQRGcrS0hSb2FYTXVjM2x0WW05c0xuWmhiSFZsTG01aGRHbDJaU2tLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnphWHBsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVoY21NeU1EQmZaR1ZqYVcxaGJITW9LU0F0UGlCaWVYUmxjem9LWVhKak1qQXdYMlJsWTJsdFlXeHpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1ZqYVcxaGJITWdQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUamcrS0hzZ2EyVjVPaUFuWkNjZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW1RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVaR1ZqYVcxaGJITXVkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvNlFYSmpNakF3TG1GeVl6SXdNRjkwYjNSaGJGTjFjSEJzZVNncElDMCtJR0o1ZEdWek9ncGhjbU15TURCZmRHOTBZV3hUZFhCd2JIazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjBiM1JoYkZOMWNIQnNlU0E5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTWpVMlBpaDdJR3RsZVRvZ0ozUW5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MGIzUmhiRk4xY0hCc2VTNTJZV3gxWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WVhKak1qQXdYMkpoYkdGdVkyVlBaaWh2ZDI1bGNqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGhjbU15TURCZlltRnNZVzVqWlU5bU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRXlNeTB4TWpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTWpBd1gySmhiR0Z1WTJWUFppaHZkMjVsY2pvZ1FXUmtjbVZ6Y3lrNklHRnlZelF1VldsdWRFNHlOVFlnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVEkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1ZlltRnNZVzVqWlU5bUtHOTNibVZ5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOWlZV3hoYm1ObFQyWUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xtRnlZekl3TUY5MGNtRnVjMlpsY2taeWIyMG9abkp2YlRvZ1lubDBaWE1zSUhSdk9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVhKak1qQXdYM1J5WVc1elptVnlSbkp2YlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE5EZ3RNVFE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekl3TUY5MGNtRnVjMlpsY2taeWIyMG9abkp2YlRvZ1FXUmtjbVZ6Y3l3Z2RHODZJRUZrWkhKbGMzTXNJSFpoYkhWbE9pQmhjbU0wTGxWcGJuUk9NalUyS1RvZ1lYSmpOQzVDYjI5c0lIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFMU1Bb2dJQ0FnTHk4Z1kyOXVjM1FnYzNCbGJtUmxjaUE5SUc1bGR5QkJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UVXhDaUFnSUNBdkx5QmpiMjV6ZENCemNHVnVaR1Z5WDJGc2JHOTNZVzVqWlNBOUlIUm9hWE11WDJGc2JHOTNZVzVqWlNobWNtOXRMQ0J6Y0dWdVpHVnlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCZllXeHNiM2RoYm1ObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UVXlDaUFnSUNBdkx5QmhjM05sY25Rb2MzQmxibVJsY2w5aGJHeHZkMkZ1WTJVdWJtRjBhWFpsSUQ0OUlIWmhiSFZsTG01aGRHbDJaU3dnSjJsdWMzVm1abWxqYVdWdWRDQmhjSEJ5YjNaaGJDY3BDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWo0OUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1emRXWm1hV05wWlc1MElHRndjSEp2ZG1Gc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UVXpDaUFnSUNBdkx5QmpiMjV6ZENCdVpYZGZjM0JsYm1SbGNsOWhiR3h2ZDJGdVkyVWdQU0J1WlhjZ1ZXbHVkRTR5TlRZb2MzQmxibVJsY2w5aGJHeHZkMkZ1WTJVdWJtRjBhWFpsSUMwZ2RtRnNkV1V1Ym1GMGFYWmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUxRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE5UUUtJQ0FnSUM4dklIUm9hWE11WDJGd2NISnZkbVVvWm5KdmJTd2djM0JsYm1SbGNpd2dibVYzWDNOd1pXNWtaWEpmWVd4c2IzZGhibU5sS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRjloY0hCeWIzWmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hOVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5MGNtRnVjMlpsY2lobWNtOXRMQ0IwYnl3Z2RtRnNkV1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WVhKak1qQXdYMkZ3Y0hKdmRtVW9jM0JsYm1SbGNqb2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21GeVl6SXdNRjloY0hCeWIzWmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakUyTlMweE5qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1qQXdYMkZ3Y0hKdmRtVW9jM0JsYm1SbGNqb2dRV1JrY21WemN5d2dkbUZzZFdVNklHRnlZelF1VldsdWRFNHlOVFlwT2lCQ2IyOXNJSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTJOd29nSUNBZ0x5OGdZMjl1YzNRZ2IzZHVaWElnUFNCdVpYY2dRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTJPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WDJGd2NISnZkbVVvYjNkdVpYSXNJSE53Wlc1a1pYSXNJSFpoYkhWbEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdYMkZ3Y0hKdmRtVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xtRnlZekl3TUY5aGJHeHZkMkZ1WTJVb2IzZHVaWEk2SUdKNWRHVnpMQ0J6Y0dWdVpHVnlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbUZ5WXpJd01GOWhiR3h2ZDJGdVkyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGMzTFRFM09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeU1EQmZZV3hzYjNkaGJtTmxLRzkzYm1WeU9pQkJaR1J5WlhOekxDQnpjR1Z1WkdWeU9pQkJaR1J5WlhOektUb2dZWEpqTkM1VmFXNTBUakkxTmlCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94TnprS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxsOWhiR3h2ZDJGdVkyVW9iM2R1WlhJc0lITndaVzVrWlhJcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQmZZV3hzYjNkaGJtTmxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZPa0Z5WXpJd01DNWZZbUZzWVc1alpVOW1LRzkzYm1WeU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsOWlZV3hoYm1ObFQyWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGd5Q2lBZ0lDQXZMeUJ3Y205MFpXTjBaV1FnWDJKaGJHRnVZMlZQWmlodmQyNWxjam9nUVdSa2NtVnpjeWs2SUZWcGJuUk9NalUySUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZbUZzWVc1alpYTWdQU0JDYjNoTllYQThRV1JrY21WemN5d2dWV2x1ZEU0eU5UWStLSHNnYTJWNVVISmxabWw0T2lBbllpY2dmU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRnekNpQWdJQ0F2THlCcFppQW9JWFJvYVhNdVltRnNZVzVqWlhNb2IzZHVaWElwTG1WNGFYTjBjeWtnY21WMGRYSnVJRzVsZHlCVmFXNTBUakkxTmlnd0tRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWDJKaGJHRnVZMlZQWmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWlZV3hoYm1ObFQyWmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTROQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WW1Gc1lXNWpaWE1vYjNkdVpYSXBMblpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvNlFYSmpNakF3TGw5MGNtRnVjMlpsY2loelpXNWtaWEk2SUdKNWRHVnpMQ0J5WldOcGNHbGxiblE2SUdKNWRHVnpMQ0JoYlc5MWJuUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tYM1J5WVc1elptVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakU0TndvZ0lDQWdMeThnY0hKdmRHVmpkR1ZrSUY5MGNtRnVjMlpsY2loelpXNWtaWEk2SUVGa1pISmxjM01zSUhKbFkybHdhV1Z1ZERvZ1FXUmtjbVZ6Y3l3Z1lXMXZkVzUwT2lCVmFXNTBUakkxTmlrNklFSnZiMndnZXdvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGc0Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhKZlltRnNZVzVqWlNBOUlIUm9hWE11WDJKaGJHRnVZMlZQWmloelpXNWtaWElwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTmhiR3h6ZFdJZ1gySmhiR0Z1WTJWUFpnb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UZzVDaUFnSUNBdkx5QmpiMjV6ZENCeVpXTnBjR2xsYm5SZlltRnNZVzVqWlNBOUlIUm9hWE11WDJKaGJHRnVZMlZQWmloeVpXTnBjR2xsYm5RcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdYMkpoYkdGdVkyVlBaZ29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakU1TUFvZ0lDQWdMeThnWVhOelpYSjBLSE5sYm1SbGNsOWlZV3hoYm1ObExtNWhkR2wyWlNBK1BTQmhiVzkxYm5RdWJtRjBhWFpsTENBblNXNXpkV1ptYVdOcFpXNTBJR0poYkdGdVkyVWdZWFFnZEdobElITmxibVJsY2lCaFkyTnZkVzUwSnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzV6ZFdabWFXTnBaVzUwSUdKaGJHRnVZMlVnWVhRZ2RHaGxJSE5sYm1SbGNpQmhZMk52ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1Ua3lDaUFnSUNBdkx5QnBaaUFvYzJWdVpHVnlJQ0U5UFNCeVpXTnBjR2xsYm5RcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0FoUFFvZ0lDQWdZbm9nWDNSeVlXNXpabVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakU1TkFvZ0lDQWdMeThnZEdocGN5NWlZV3hoYm1ObGN5aHpaVzVrWlhJcExuWmhiSFZsSUQwZ2JtVjNJRlZwYm5ST01qVTJLSE5sYm1SbGNsOWlZV3hoYm1ObExtNWhkR2wyWlNBdElHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUxRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdKOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklIQjFZbXhwWXlCaVlXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlpHUnlaWE56TENCVmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RpSnlCOUtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVlpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGswQ2lBZ0lDQXZMeUIwYUdsekxtSmhiR0Z1WTJWektITmxibVJsY2lrdWRtRnNkV1VnUFNCdVpYY2dWV2x1ZEU0eU5UWW9jMlZ1WkdWeVgySmhiR0Z1WTJVdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE9UVUtJQ0FnSUM4dklIUm9hWE11WW1Gc1lXNWpaWE1vY21WamFYQnBaVzUwS1M1MllXeDFaU0E5SUc1bGR5QlZhVzUwVGpJMU5paHlaV05wY0dsbGJuUmZZbUZzWVc1alpTNXVZWFJwZG1VZ0t5QmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpc0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdKOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklIQjFZbXhwWXlCaVlXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlpHUnlaWE56TENCVmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RpSnlCOUtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVlpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGsxQ2lBZ0lDQXZMeUIwYUdsekxtSmhiR0Z1WTJWektISmxZMmx3YVdWdWRDa3VkbUZzZFdVZ1BTQnVaWGNnVldsdWRFNHlOVFlvY21WamFYQnBaVzUwWDJKaGJHRnVZMlV1Ym1GMGFYWmxJQ3NnWVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLQ2w5MGNtRnVjMlpsY2w5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRrM0NpQWdJQ0F2THlCbGJXbDBLRzVsZHlCaGNtTXlNREJmVkhKaGJuTm1aWElvZXlCbWNtOXRPaUJ6Wlc1a1pYSXNJSFJ2T2lCeVpXTnBjR2xsYm5Rc0lIWmhiSFZsT2lCaGJXOTFiblFnZlNrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z2JXVjBhRzlrSUNKaGNtTXlNREJmVkhKaGJuTm1aWElvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94T1RnS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1FtOXZiQ2gwY25WbEtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEZ3dDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xsOWhjSEJ5YjNaaGJFdGxlU2h2ZDI1bGNqb2dZbmwwWlhNc0lITndaVzVrWlhJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1gyRndjSEp2ZG1Gc1MyVjVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakl3TUFvZ0lDQWdMeThnY0hKdmRHVmpkR1ZrSUY5aGNIQnliM1poYkV0bGVTaHZkMjVsY2pvZ1FXUmtjbVZ6Y3l3Z2MzQmxibVJsY2pvZ1FXUmtjbVZ6Y3lrNklGTjBZWFJwWTBKNWRHVnpQRE15UGlCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem95TURFS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1UzUmhkR2xqUW5sMFpYTThNekkrS0c5d0xuTm9ZVEkxTmlodmNDNWpiMjVqWVhRb2IzZHVaWEl1WW5sMFpYTXNJSE53Wlc1a1pYSXVZbmwwWlhNcEtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSE5wZW1VS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvNlFYSmpNakF3TGw5aGJHeHZkMkZ1WTJVb2IzZHVaWEk2SUdKNWRHVnpMQ0J6Y0dWdVpHVnlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbDloYkd4dmQyRnVZMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TWpBMENpQWdJQ0F2THlCd2NtOTBaV04wWldRZ1gyRnNiRzkzWVc1alpTaHZkMjVsY2pvZ1FXUmtjbVZ6Y3l3Z2MzQmxibVJsY2pvZ1FXUmtjbVZ6Y3lrNklGVnBiblJPTWpVMklIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pJd05Rb2dJQ0FnTHk4Z1kyOXVjM1FnYTJWNUlEMGdkR2hwY3k1ZllYQndjbTkyWVd4TFpYa29iM2R1WlhJc0lITndaVzVrWlhJcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQmZZWEJ3Y205MllXeExaWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnY0hWaWJHbGpJR0Z3Y0hKdmRtRnNjeUE5SUVKdmVFMWhjRHhUZEdGMGFXTkNlWFJsY3p3ek1qNHNJRUZ3Y0hKdmRtRnNVM1J5ZFdOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJFbklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakl3TmdvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG1Gd2NISnZkbUZzY3loclpYa3BMbVY0YVhOMGN5a2djbVYwZFhKdUlHNWxkeUJWYVc1MFRqSTFOaWd3S1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dYMkZzYkc5M1lXNWpaVjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2w5aGJHeHZkMkZ1WTJWZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pJd053b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZWEJ3Y205MllXeHpLR3RsZVNrdWRtRnNkV1V1WVhCd2NtOTJZV3hCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUlDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WDJGd2NISnZkbVVvYjNkdVpYSTZJR0o1ZEdWekxDQnpjR1Z1WkdWeU9pQmllWFJsY3l3Z1lXMXZkVzUwT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2w5aGNIQnliM1psT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pJeE1Bb2dJQ0FnTHk4Z2NISnZkR1ZqZEdWa0lGOWhjSEJ5YjNabEtHOTNibVZ5T2lCQlpHUnlaWE56TENCemNHVnVaR1Z5T2lCQlpHUnlaWE56TENCaGJXOTFiblE2SUZWcGJuUk9NalUyS1RvZ1FtOXZiQ0I3Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3lNVEVLSUNBZ0lDOHZJR052Ym5OMElHdGxlU0E5SUhSb2FYTXVYMkZ3Y0hKdmRtRnNTMlY1S0c5M2JtVnlMQ0J6Y0dWdVpHVnlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnWDJGd2NISnZkbUZzUzJWNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1qRXlMVEl4TmdvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3Y205MllXeENiM2c2SUVGd2NISnZkbUZzVTNSeWRXTjBJRDBnYm1WM0lFRndjSEp2ZG1Gc1UzUnlkV04wS0hzS0lDQWdJQzh2SUNBZ1lYQndjbTkyWVd4QmJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnYjNkdVpYSTZJRzkzYm1WeUxBb2dJQ0FnTHk4Z0lDQnpjR1Z1WkdWeU9pQnpjR1Z1WkdWeUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJSEIxWW14cFl5QmhjSEJ5YjNaaGJITWdQU0JDYjNoTllYQThVM1JoZEdsalFubDBaWE04TXpJK0xDQkJjSEJ5YjNaaGJGTjBjblZqZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RoSnlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKaElnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveU1UY0tJQ0FnSUM4dklIUm9hWE11WVhCd2NtOTJZV3h6S0d0bGVTa3VkbUZzZFdVZ1BTQmhjSEJ5YjNaaGJFSnZlQzVqYjNCNUtDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem95TVRnS0lDQWdJQzh2SUdWdGFYUW9ibVYzSUdGeVl6SXdNRjlCY0hCeWIzWmhiQ2g3SUc5M2JtVnlPaUJ2ZDI1bGNpd2djM0JsYm1SbGNqb2djM0JsYm1SbGNpd2dkbUZzZFdVNklHRnRiM1Z1ZENCOUtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hPVFk1WmpnMk5TQXZMeUJ0WlhSb2IyUWdJbUZ5WXpJd01GOUJjSEJ5YjNaaGJDaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTmlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qSXhPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJDYjI5c0tIUnlkV1VwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0T0RBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pwQmNtTTRPQzVmWlc1emRYSmxSR1ZtWVhWc2RFOTNibVZ5S0NrZ0xUNGdkbTlwWkRvS1gyVnVjM1Z5WlVSbFptRjFiSFJQZDI1bGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTVDaUFnSUNBdkx5QndkV0pzYVdNZ2FXNXBkR2xoYkdsNlpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0o1ZEdVK0tIc2dhMlY1T2lBbllYSmpPRGhmYjJrbklIMHBJQzh2SURFZ2FXWWdhVzVwZEdsaGJHbDZaV1FnS0dWNGNHeHBZMmwwSUc5eUlHbHRjR3hwWTJsMEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW1GeVl6ZzRYMjlwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNW9ZWE5XWVd4MVpTQjhmQ0IwYUdsekxtbHVhWFJwWVd4cGVtVmtMblpoYkhWbExtNWhkR2wyWlNBOVBUMGdNQ2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dYMlZ1YzNWeVpVUmxabUYxYkhSUGQyNWxjbDlwWmw5aWIyUjVRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhVzVwZEdsaGJHbDZaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtKNWRHVStLSHNnYTJWNU9pQW5ZWEpqT0RoZmIya25JSDBwSUM4dklERWdhV1lnYVc1cGRHbGhiR2w2WldRZ0tHVjRjR3hwWTJsMElHOXlJR2x0Y0d4cFkybDBLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltRnlZemc0WDI5cElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCcFppQW9JWFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVhR0Z6Vm1Gc2RXVWdmSHdnZEdocGN5NXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTNXVZWFJwZG1VZ1BUMDlJREFwSUhzS0lDQWdJR0owYjJrS0lDQWdJR0p1ZWlCZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvS1gyVnVjM1Z5WlVSbFptRjFiSFJQZDI1bGNsOXBabDlpYjJSNVFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdjSFZpYkdsaklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGloN0lHdGxlVG9nSjJGeVl6ZzRYMjhuSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhKak9EaGZieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11YjNkdVpYSXVhR0Z6Vm1Gc2RXVXBJSHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQmZaVzV6ZFhKbFJHVm1ZWFZzZEU5M2JtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIQjFZbXhwWXlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXZKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhKak9EaGZieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUIwYUdsekxtOTNibVZ5TG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNcENpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncGZaVzV6ZFhKbFJHVm1ZWFZzZEU5M2JtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTVDaUFnSUNBdkx5QndkV0pzYVdNZ2FXNXBkR2xoYkdsNlpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0o1ZEdVK0tIc2dhMlY1T2lBbllYSmpPRGhmYjJrbklIMHBJQzh2SURFZ2FXWWdhVzVwZEdsaGJHbDZaV1FnS0dWNGNHeHBZMmwwSUc5eUlHbHRjR3hwWTJsMEtRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaVlYSmpPRGhmYjJraUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2RHaHBjeTVwYm1sMGFXRnNhWHBsWkM1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGtKNWRHVW9NU2tLSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncGZaVzV6ZFhKbFJHVm1ZWFZzZEU5M2JtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qcEJjbU00T0M1aGNtTTRPRjl2ZDI1bGNpZ3BJQzArSUdKNWRHVnpPZ3BoY21NNE9GOXZkMjVsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCMGFHbHpMbDlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQmZaVzV6ZFhKbFJHVm1ZWFZzZEU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdjSFZpYkdsaklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGloN0lHdGxlVG9nSjJGeVl6ZzRYMjhuSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhKak9EaGZieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11YjNkdVpYSXVkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pwQmNtTTRPQzVoY21NNE9GOXBjMTl2ZDI1bGNpaHhkV1Z5ZVRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwaGNtTTRPRjlwYzE5dmQyNWxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPalF4TFRReUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdMeThnY0hWaWJHbGpJR0Z5WXpnNFgybHpYMjkzYm1WeUtIRjFaWEo1T2lCaGNtTTBMa0ZrWkhKbGMzTXBPaUJoY21NMExrSnZiMndnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdkR2hwY3k1ZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnWDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUhCMVlteHBZeUJ2ZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRV1JrY21WemN6NG9leUJyWlhrNklDZGhjbU00T0Y5dkp5QjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRnlZemc0WDI4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxtOTNibVZ5TG1oaGMxWmhiSFZsS1NCeVpYUjFjbTRnYm1WM0lHRnlZelF1UW05dmJDaG1ZV3h6WlNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJoY21NNE9GOXBjMTl2ZDI1bGNsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnd01Bb2dJQ0FnY21WMGMzVmlDZ3BoY21NNE9GOXBjMTl2ZDI1bGNsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2NIVmliR2xqSUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOG5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVWdQVDA5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1NrZ2NtVjBkWEp1SUc1bGR5QmhjbU0wTGtKdmIyd29abUZzYzJVcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdQVDBLSUNBZ0lHSjZJR0Z5WXpnNFgybHpYMjkzYm1WeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURBd0NpQWdJQ0J5WlhSemRXSUtDbUZ5WXpnNFgybHpYMjkzYm1WeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCd2RXSnNhV01nYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0ZrWkhKbGMzTStLSHNnYTJWNU9pQW5ZWEpqT0RoZmJ5Y2dmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhjbU00T0Y5dklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lHRnlZelF1UW05dmJDaDBhR2x6TG05M2JtVnlMblpoYkhWbElEMDlQU0J4ZFdWeWVTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnUFQwS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem82UVhKak9EZ3VZWEpqT0RoZmFXNXBkR2xoYkdsNlpWOXZkMjVsY2lodVpYZGZiM2R1WlhJNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwaGNtTTRPRjlwYm1sMGFXRnNhWHBsWDI5M2JtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOVEF0TlRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqT0RoZmFXNXBkR2xoYkdsNlpWOXZkMjVsY2lodVpYZGZiM2R1WlhJNklHRnlZelF1UVdSa2NtVnpjeWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdsdWFYUnBZV3hwZW1Wa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUNlWFJsUGloN0lHdGxlVG9nSjJGeVl6ZzRYMjlwSnlCOUtTQXZMeUF4SUdsbUlHbHVhWFJwWVd4cGVtVmtJQ2hsZUhCc2FXTnBkQ0J2Y2lCcGJYQnNhV05wZENrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0poY21NNE9GOXZhU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJoYzNObGNuUW9JU2gwYUdsekxtbHVhWFJwWVd4cGVtVmtMbWhoYzFaaGJIVmxJQ1ltSUhSb2FYTXVhVzVwZEdsaGJHbDZaV1F1ZG1Gc2RXVXVibUYwYVhabElEMDlQU0F4S1N3Z0oyRnNjbVZoWkhsZmFXNXBkR2xoYkdsNlpXUW5LUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1lYSmpPRGhmYVc1cGRHbGhiR2w2WlY5dmQyNWxjbDlpYjI5c1gyWmhiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCd2RXSnNhV01nYVc1cGRHbGhiR2w2WldRZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrSjVkR1UrS0hzZ2EyVjVPaUFuWVhKak9EaGZiMmtuSUgwcElDOHZJREVnYVdZZ2FXNXBkR2xoYkdsNlpXUWdLR1Y0Y0d4cFkybDBJRzl5SUdsdGNHeHBZMmwwS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbUZ5WXpnNFgyOXBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmhjM05sY25Rb0lTaDBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xtaGhjMVpoYkhWbElDWW1JSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVdWJtRjBhWFpsSUQwOVBTQXhLU3dnSjJGc2NtVmhaSGxmYVc1cGRHbGhiR2w2WldRbktRb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmllaUJoY21NNE9GOXBibWwwYVdGc2FYcGxYMjkzYm1WeVgySnZiMnhmWm1Gc2MyVkFNd29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbUZ5WXpnNFgybHVhWFJwWVd4cGVtVmZiM2R1WlhKZlltOXZiRjl0WlhKblpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hLSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVhR0Z6Vm1Gc2RXVWdKaVlnZEdocGN5NXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTNXVZWFJwZG1VZ1BUMDlJREVwTENBbllXeHlaV0ZrZVY5cGJtbDBhV0ZzYVhwbFpDY3BDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWVd4eVpXRmtlVjlwYm1sMGFXRnNhWHBsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkZmIzZHVaWElnSVQwOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tTd2dKM3BsY205ZllXUmtjbVZ6YzE5dWIzUmZZV3hzYjNkbFpDY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJSHBsY205ZllXUmtjbVZ6YzE5dWIzUmZZV3hzYjNkbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIQjFZbXhwWXlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXZKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhKak9EaGZieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUIwYUdsekxtOTNibVZ5TG5aaGJIVmxJRDBnYm1WM1gyOTNibVZ5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnY0hWaWJHbGpJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1Q2VYUmxQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOXBKeUI5S1NBdkx5QXhJR2xtSUdsdWFYUnBZV3hwZW1Wa0lDaGxlSEJzYVdOcGRDQnZjaUJwYlhCc2FXTnBkQ2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbUZ5WXpnNFgyOXBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNUNlWFJsS0RFcENpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBd2VEQXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dwaGNtTTRPRjlwYm1sMGFXRnNhWHBsWDI5M2JtVnlYMkp2YjJ4ZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJR0Z5WXpnNFgybHVhWFJwWVd4cGVtVmZiM2R1WlhKZlltOXZiRjl0WlhKblpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk9rRnlZemc0TG1GeVl6ZzRYM1J5WVc1elptVnlYMjkzYm1WeWMyaHBjQ2h1WlhkZmIzZHVaWEk2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoY21NNE9GOTBjbUZ1YzJabGNsOXZkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzFPQzAxT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU00T0Y5MGNtRnVjMlpsY2w5dmQyNWxjbk5vYVhBb2JtVjNYMjkzYm1WeU9pQmhjbU0wTGtGa1pISmxjM01wT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklIUm9hWE11WDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRjlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJoYzNObGNuUW9ibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0E5UFQwZ2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlN3Z0oyNXZkRjl2ZDI1bGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2NIVmliR2xqSUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOG5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMDlJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVXNJQ2R1YjNSZmIzZHVaWEluS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1JmYjNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNYMjkzYm1WeUlDRTlQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ2tzSUNkNlpYSnZYMkZrWkhKbGMzTmZibTkwWDJGc2JHOTNaV1FuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4eElDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCNlpYSnZYMkZrWkhKbGMzTmZibTkwWDJGc2JHOTNaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTQTlJRzVsZDE5dmQyNWxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJR1Z0YVhRb2JtVjNJR0Z5WXpnNFgwOTNibVZ5YzJocGNGUnlZVzV6Wm1WeWNtVmtLSHNnY0hKbGRtbHZkWE5mYjNkdVpYSTZJSEJ5WlhacGIzVnpMQ0J1WlhkZmIzZHVaWElnZlNrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNakVnTHk4Z2JXVjBhRzlrSUNKaGNtTTRPRjlQZDI1bGNuTm9hWEJVY21GdWMyWmxjbkpsWkNoaFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pwQmNtTTRPQzVoY21NNE9GOXlaVzV2ZFc1alpWOXZkMjVsY25Ob2FYQW9LU0F0UGlCMmIybGtPZ3BoY21NNE9GOXlaVzV2ZFc1alpWOXZkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzNNQW9nSUNBZ0x5OGdkR2hwY3k1ZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnWDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwSUQwOVBTQjBhR2x6TG05M2JtVnlMblpoYkhWbExDQW5ibTkwWDI5M2JtVnlKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QndkV0pzYVdNZ2IzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZieWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poY21NNE9GOXZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQVDBnZEdocGN5NXZkMjVsY2k1MllXeDFaU3dnSjI1dmRGOXZkMjVsY2ljcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZEY5dmQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnlMblpoYkhWbElEMGdibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QmxiV2wwS0c1bGR5QmhjbU00T0Y5UGQyNWxjbk5vYVhCU1pXNXZkVzVqWldRb2V5QndjbVYyYVc5MWMxOXZkMjVsY2pvZ2NISmxkbWx2ZFhNZ2ZTa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pORFpoWVRFMk5pQXZMeUJ0WlhSb2IyUWdJbUZ5WXpnNFgwOTNibVZ5YzJocGNGSmxibTkxYm1ObFpDaGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzZRWEpqT0RndVlYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3WDNKbGNYVmxjM1FvY0dWdVpHbHVaem9nWW5sMFpYTXBJQzArSUhadmFXUTZDbUZ5WXpnNFgzUnlZVzV6Wm1WeVgyOTNibVZ5YzJocGNGOXlaWEYxWlhOME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk56Z3ROemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3WDNKbGNYVmxjM1FvY0dWdVpHbHVaem9nWVhKak5DNUJaR1J5WlhOektUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUIwYUdsekxsOWxibk4xY21WRVpXWmhkV3gwVDNkdVpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMDlJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVXNJQ2R1YjNSZmIzZHVaWEluS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBJRDA5UFNCMGFHbHpMbTkzYm1WeUxuWmhiSFZsTENBbmJtOTBYMjkzYm1WeUp5a0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYm05MFgyOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnWVhOelpYSjBLSEJsYm1ScGJtY2dJVDA5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1N3Z0ozcGxjbTlmWVdSa2NtVnpjMTl1YjNSZllXeHNiM2RsWkNjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklIcGxjbTlmWVdSa2NtVnpjMTl1YjNSZllXeHNiM2RsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhCMVlteHBZeUJ3Wlc1a2FXNW5UM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmY0c4bklIMHBJQzh2SUc5d2RHbHZibUZzSUhSM2J5MXpkR1Z3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlZWEpqT0RoZmNHOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdhV1lnS0hSb2FYTXVjR1Z1WkdsdVowOTNibVZ5TG1oaGMxWmhiSFZsSUNZbUlIUm9hWE11Y0dWdVpHbHVaMDkzYm1WeUxuWmhiSFZsSUNFOVBTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa3BJSHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHRnlZemc0WDNSeVlXNXpabVZ5WDI5M2JtVnljMmhwY0Y5eVpYRjFaWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QndaVzVrYVc1blQzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZjRzhuSUgwcElDOHZJRzl3ZEdsdmJtRnNJSFIzYnkxemRHVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVlYSmpPRGhmY0c4aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02T0RNS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG5CbGJtUnBibWRQZDI1bGNpNW9ZWE5XWVd4MVpTQW1KaUIwYUdsekxuQmxibVJwYm1kUGQyNWxjaTUyWVd4MVpTQWhQVDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdwS1NCN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdJVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCd1pXNWthVzVuWDNSeVlXNXpabVZ5WDJWNGFYTjBjd29LWVhKak9EaGZkSEpoYm5ObVpYSmZiM2R1WlhKemFHbHdYM0psY1hWbGMzUmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklIQjFZbXhwWXlCd1pXNWthVzVuVDNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0ZrWkhKbGMzTStLSHNnYTJWNU9pQW5ZWEpqT0RoZmNHOG5JSDBwSUM4dklHOXdkR2x2Ym1Gc0lIUjNieTF6ZEdWd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKaGNtTTRPRjl3YnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCMGFHbHpMbkJsYm1ScGJtZFBkMjVsY2k1MllXeDFaU0E5SUhCbGJtUnBibWNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJsYldsMEtHNWxkeUJoY21NNE9GOVBkMjVsY25Ob2FYQlVjbUZ1YzJabGNsSmxjWFZsYzNSbFpDaDdJSEJ5WlhacGIzVnpYMjkzYm1WeU9pQjBhR2x6TG05M2JtVnlMblpoYkhWbExDQndaVzVrYVc1blgyOTNibVZ5T2lCd1pXNWthVzVuSUgwcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTJZbVl4WmpreElDOHZJRzFsZEdodlpDQWlZWEpqT0RoZlQzZHVaWEp6YUdsd1ZISmhibk5tWlhKU1pYRjFaWE4wWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNlFYSmpPRGd1WVhKak9EaGZZV05qWlhCMFgyOTNibVZ5YzJocGNDZ3BJQzArSUhadmFXUTZDbUZ5WXpnNFgyRmpZMlZ3ZEY5dmQyNWxjbk5vYVhBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNU1nb2dJQ0FnTHk4Z2RHaHBjeTVmWlc1emRYSmxSR1ZtWVhWc2RFOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdYMlZ1YzNWeVpVUmxabUYxYkhSUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QndaVzVrYVc1blQzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZjRzhuSUgwcElDOHZJRzl3ZEdsdmJtRnNJSFIzYnkxemRHVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVlYSmpPRGhmY0c4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNU13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjR1Z1WkdsdVowOTNibVZ5TG1oaGMxWmhiSFZsTENBbmJtOTBYM0JsYm1ScGJtZGZiM2R1WlhJbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZEY5d1pXNWthVzVuWDI5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzVOQW9nSUNBZ0x5OGdZMjl1YzNRZ2MyVnVaR1Z5SUQwZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhCMVlteHBZeUJ3Wlc1a2FXNW5UM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmY0c4bklIMHBJQzh2SUc5d2RHbHZibUZzSUhSM2J5MXpkR1Z3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlZWEpqT0RoZmNHOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoelpXNWtaWElnUFQwOUlIUm9hWE11Y0dWdVpHbHVaMDkzYm1WeUxuWmhiSFZsTENBbmJtOTBYM0JsYm1ScGJtZGZiM2R1WlhJbktRb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYm05MFgzQmxibVJwYm1kZmIzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTQTlJSE5sYm1SbGNnb2dJQ0FnWkdsbklESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdjSFZpYkdsaklIQmxibVJwYm1kUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXdieWNnZlNrZ0x5OGdiM0IwYVc5dVlXd2dkSGR2TFhOMFpYQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltRnlZemc0WDNCdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk9UZ0tJQ0FnSUM4dklIUm9hWE11Y0dWdVpHbHVaMDkzYm1WeUxuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3lncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCbGJXbDBLRzVsZHlCaGNtTTRPRjlQZDI1bGNuTm9hWEJVY21GdWMyWmxja0ZqWTJWd2RHVmtLSHNnY0hKbGRtbHZkWE5mYjNkdVpYSTZJSEJ5WlhacGIzVnpMQ0J1WlhkZmIzZHVaWEk2SUhObGJtUmxjaUI5S1NrS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpqZGxNelppTXpjZ0x5OGdiV1YwYUc5a0lDSmhjbU00T0Y5UGQyNWxjbk5vYVhCVWNtRnVjMlpsY2tGalkyVndkR1ZrS0dGa1pISmxjM01zWVdSa2NtVnpjeWtpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z1pXMXBkQ2h1WlhjZ1lYSmpPRGhmVDNkdVpYSnphR2x3VkhKaGJuTm1aWEp5WldRb2V5QndjbVYyYVc5MWMxOXZkMjVsY2pvZ2NISmxkbWx2ZFhNc0lHNWxkMTl2ZDI1bGNqb2djMlZ1WkdWeUlIMHBLUW9nSUNBZ1lubDBaV01nTWpFZ0x5OGdiV1YwYUc5a0lDSmhjbU00T0Y5UGQyNWxjbk5vYVhCVWNtRnVjMlpsY25KbFpDaGhaR1J5WlhOekxHRmtaSEpsYzNNcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qcEJjbU00T0M1aGNtTTRPRjlqWVc1alpXeGZiM2R1WlhKemFHbHdYM0psY1hWbGMzUW9LU0F0UGlCMmIybGtPZ3BoY21NNE9GOWpZVzVqWld4ZmIzZHVaWEp6YUdsd1gzSmxjWFZsYzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklIUm9hWE11WDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRjlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnWVhOelpYSjBLRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnUFQwOUlIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0lDZHViM1JmYjNkdVpYSW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIQjFZbXhwWXlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXZKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UQTJDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQVDBnZEdocGN5NXZkMjVsY2k1MllXeDFaU3dnSjI1dmRGOXZkMjVsY2ljcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZEY5dmQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QndaVzVrYVc1blQzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZjRzhuSUgwcElDOHZJRzl3ZEdsdmJtRnNJSFIzYnkxemRHVndDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmhjbU00T0Y5d2J5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRXdOd29nSUNBZ0x5OGdkR2hwY3k1d1pXNWthVzVuVDNkdVpYSXVkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQUFFZ0NDWVdCQlVmZkhVZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFIWVhKak9EaGZid0YwQ1dGeVl6RTBNVEJmY0FHQUFXSUlZWEpqT0RoZmNHOEJBQWhoY21NNE9GOXZhUXRoY21NeE5ERXdYMjl3WVF4aGNtTXhOREV3WDJod1gyRUtZWEpqTVRReE1GOXZjQUlBQWdFQkFnQUJBZ0JpQWdBQUNBQUFBQUFBQUFBQUJGd250UHdFZVlQRFhBUkRWZEt0TVJ0QkExK0NId1ExK0JOZkJOcHdKYmtFUHlWbkV3U1Z0UG5qQklETVNhc0VCNVloWlFUbmlXSGFCUDJVZ05jRXNiSFdtZ1RCdnRlSkJEditHRE1FV1p6UnBRUnQ2VUZtQkNqd0k5Y0VsMU9DNGdSbGZSUHNCTGF1R2lVRWhPd1QxUVRzbVdCQkJJTGxjOFFFU3BhUGp3UzFRaUVsQkx1ekdmTUVCd0psVGdUUUZYSk9CQUtmN01BRWMwa3pUZ1RiZklMdkJQMHNMRzRFUXFYd1pRU3RUMmpxTmhvQWpoOENhUUpUQWpjQ0lRSUlBZk1CM2dHL0FhQUJpQUZ2QVZjQlFnRXFBUTRBL2dEdUFONEF6Z0M3QUtJQWpBQjJBR1lBVXdCRUFEVUFLUUFhQUE0QUFpSkRNUmtVUkRFWVJJZ01JU05ETVJrVVJERVlSSWdMNGlORE1Sa1VSREVZUkRZYUFZZ0xtQ05ETVJrVVJERVlSSWdMY0NORE1Sa1VSREVZUkRZYUFZZ0xQU05ETVJrVVJERVlSRFlhQVlnTEFTTkRNUmtVUkRFWVJEWWFBWWdLeHloTVVMQWpRekVaRkVReEdFU0lDcThvVEZDd0kwTXhHUlJFTVJoRU5ob0JOaG9DaUFtZEtFeFFzQ05ETVJrVVJERVlSRFlhQVRZYUFvZ0plaWhNVUxBalF6RVpGRVF4R0VRMkdnRTJHZ0kyR2dPSUNUTW9URkN3STBNeEdSUkVNUmhFTmhvQmlBa1hLRXhRc0NORE1Sa1VSREVZUklnSkFpaE1VTEFqUXpFWkZFUXhHRVNJQ09zb1RGQ3dJME14R1JSRU1SaEVpQWpNS0V4UXNDTkRNUmtVUkRFWVJJZ0lyU2hNVUxBalF6RVpGRVF4R0VRMkdnRTJHZ0kyR2dNMkdnU0lDRHdvVEZDd0kwTXhHUlJFTVJoRU5ob0JOaG9DTmhvRE5ob0VpQWRRSTBNeEdSUkVNUmhFTmhvQk5ob0NOaG9EaUFhekkwTXhHUlJFTVJoRU5ob0JOaG9DTmhvRE5ob0VpQVlISTBNeEdSUkVNUmhFTmhvQk5ob0NOaG9EaUFXNktFeFFzQ05ETVJrVVJERVlSRFlhQVRZYUFqWWFBellhQklnRmhTTkRNUmtVUkRFWVJEWWFBVFlhQWpZYUF6WWFCRFlhQllnQ01TaE1VTEFqUXpFWkZFUXhHRVEyR2dFMkdnSTJHZ00yR2dRMkdnV0lBYXdvVEZDd0kwTXhHUlJFTVJoRU5ob0JOaG9DTmhvRGlBRnlJME14R1JSRU1SaEVOaG9CTmhvQ05ob0RpQUZFSTBNeEdSUkVNUmhFTmhvQk5ob0NOaG9EaUFEUUtFeFFzQ05ETVJrVVJERVlSRFlhQVRZYUFvZ0FuU2hNVUxBalF6RVpGRVF4R0VRMkdnRTJHZ0kyR2dNMkdnU0lBR1lvVEZDd0kwTXhHUlJFTVJoRU5ob0JOaG9DaUFBMktFeFFzQ05ETVJrVVJERVlSRFlhQVRZYUFvZ0FFU2hNVUxBalF6RVpRUDE4TVJnVVJDTkRpZ0lCaS82TC8xQW5CRXhRdmtTSmlnSUJNUUFwaS80cGkvOG5FWWdEOERFQWkvNkwvNGdIbEltS0JBRXhBSXY5aS95SUFyaE1pL3lML1VzRGkvNkwvNGdEekltS0FnR0wvb3YvVUNjTFRGQkp2VVVCUUFBRUp4Rk1pWXNBdmtSTWlZb0RBU0pIQW92K2kvMFNRUUFGSndXTUFJbUwvWXYrVUVtTUFJdi9VQ2NNVEZCSmpBRzlSUUZCQUErTEFiNUVGeU1TUVFBRkp3V01BSW1MQUNsUUp3eE1VRW1NQXIxRkFVRUFENHNDdmtRWEl4SkJBQVVuQll3QWlTY0lqQUNKaWdNQU1RQ0wvUkpFaS8yTC9sQ0wvMUFuREV4UUp3Ni9pWW9EQURFQWkvMFNSSXY5aS81UWkvOVFKd3hNVUVtOVJRRkJBQVNMQUx4SWlZb0ZBU0l4QUl2N01RQ0wvSWovV0NKVEl4SkhBa0FBTW92N2l3RlFpL3hRSndwTVVFbU1BTDFGQVVFQUdZc0FTYjVFU1l2K3AwUWpqQUtML3FGSkZTUU9SQ1N2cTcrTEFvd0Rpd05FaS8yTC9JZ0JuNHY3aS95TC9Vc0RpLzZMLzRnQ3Nvd0FpWW9GQVNKSmdBQkppL3VML0ZBbkJFeFFTYjFGQVVBQVBvQTVVQUFqQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFGRkJoY25ScGRHbHZiaUJ1YjNRZ1pYaHBjM1J6akFDSml3UytSSXYrcEVFQVBvQTVVZ0FqQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFGRWx1YzNWbVptbGphV1Z1ZENCaVlXeGhibU5sakFDSmkvMHBFa0VBT29BMVZ3QWpBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUVFbHVkbUZzYVdRZ2NtVmpaV2wyWlhLTUFJa3hBRW1NQUl2N0UwRUFob3Y3aXdDTC9JaitEaUpUSXhKSmpBSkpqQU5BQUNxTCs0c0FVSXY4VUNjS1RGQkpqQUc5UlFHTEFvd0RRUUFSaXdHK1JJditwMEVBQXlPTUFvc0NqQU9MQTBBQVFZQThXQUFqQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFGMDl3WlhKaGRHOXlJRzV2ZENCaGRYUm9iM0pwZW1Wa2pBQ0ppLzJML0lnQUZvQURVUUFqVEZDQUNRQUhVM1ZqWTJWemMxQ01BSW1LQWdFcGkvNkwvMUFuQkV4UXZVVUJRUUFFaS8rTUFJc0FUSW1LQWdBaVJ3U0FBRWNFZ0F4aGNtTXhOREV3WDJod1gzQ0wvbEJKdlVVQlFBQUZpd29uRXIrTENyNU1qQUpFSW93R0p4S01BWXNCRjBtTUNJc0NGMG1NQ1F4QkFFK0wvb3NCVUNjTFRGQkpqQVM5UlFGQUFBd25ENHYvVUlzRVNieElUTCtMQkw1TVNVNENqQUJFSWxtTUJTS01CNHNIaXdVTVFRQ0hpd0JYQWdDTEJ5UUxKRmlML3hKQkFHMGpRUUJmSTR3R2l3WkFBRGlML29zQ1VDY0xURkJKakFPK1JDSlpGaGVCQ2d4QkFDR0xBMG0rUkZjQ0FDY1BpLzlRVndJQVVFa1ZKQW9XVndZQ1RGQkxBYnhJdjRtTENTTUlGb3NLU3dHL2kvNU1VQ2NQaS85UUp3dFBBbEJKdkVoTXY0bUxDQ01JRm93QlF2ODdpd2NqQ0l3SFF2OXhJa0wvaDRvR0FDSkppLzZBQUtWRWkvcUwrMUFuQkV4UVNiMUZBVUFBQklzQ0tiK0xBa20rUkl2K29Va1ZKQTVFSks5SmpBQ3J2NHY2aS94UWkvdFFpLzVRZ0FJQWdsQ0wvMUFuRFV4UWdBUWdhM2xBVEZDd2kvMkwreE5CQUFlTC9JdjlpUDZYaS95TC9WQW5CRXhRU1l3QnZVVUJRQUFFaXdFcHY0c0JTYjVFaS82Z1NSVWtEa1NMQUt1L2lZb0VBREVBaS93U1JJdjhpLzFRaS81UUp3cE1VSXYvdjRtS0F3RWlpLzZML1JKQkFBUW5CVXlKaS8yTC9sQ0wvMUFuQ2t4UVNZd0F2VVVCUUFBRUp3aE1pWXNBdmtTQUFLVW5DQ0pQQWxSTWlZb0VBQ0pKTVFDSUE2a2lVeU1TUkl2K2dBQ2xSSXY4aS8xUVNTY0VURkJKdlVVQlFBQUxpd01wdjR2OGkvMkkvZTJMQTBtK1JJditvRWtWSkE1RUpLOUpqQUNydnljR2kveFFTWXdCdlVVQlFBQUVpd0VwdjRzQlNiNUVpLzZnU1JVa0RrU0xBRWxPQTZ1L0lpdGxSSXYrb0VrVkpBNUVxeXRNWjRzQ2kvNVFKeEJRaS85UUp3MU1VSUFFK2tRN0cweFFzSW1LQXdBeEFJditnQUNsUkVtTC9WQkpUZ0luQkV4UVNiMUZBVVJKdmtTTC9xZEVTYjVFaS82aFNSVWtEa1FrcjBsT0JLdS9Kd1pNVUVtOVJRRkJBRVdMQXI1RWkvNm5RUUE3STBTTEFrbStSSXYrb1VrVkpBNUVpd0ZKVGdPcnZ5SXJaVVNML3FGSkZTUU9SS3NyVEdlTEFJditVQ2NRVUl2L1VDY05URkFuRTB4UXNJa2lRdi9DaWdRQUlrY0RNUUNML0RFQWkvMkkra29pVXlNU1J3SkFBREtML0lzRVVJdjlVQ2NLVEZCSmpBTzlSUUZCQUJtTEEwbStSRW1ML3FkRUk0d0ZpLzZoU1JVa0RrUWtyNnUvaXdXTUJvc0dSSXY4aS8xUVNZd0JKd1JNVUVtOVJRRkVTYjVFaS82blJFbStSSXYrb1VrVkpBNUVKSzlKakFDcnZ5Y0dpL3hRU1l3Q3ZVVUJRUUJGaXdLK1JJditwMEVBT3lORWl3Skp2a1NML3FGSkZTUU9SSXNBU1U0RHE3OGlLMlZFaS82aFNSVWtEa1NySzB4bml3R0wvbEFuRUZDTC8xQW5EVXhRSnhOTVVMQ0pJa0wvd29vRUFURUFNZ2tTUkl2OFZ3SUFGVWxFSkE1RWkvMVhBZ0FWU1VRbERrUWlLMlZGQVJSRWdBRnVpL3huZ0FGemkvMW5LNHYvWjRBQlpJditaekVBSndaTEFWQ0wvNzh5QTB4UWkvOVFKeFJNVUxBbkJZa2lnQUZ1WlVSWEFnQkpGU1FTUklraWdBRnpaVVJYQWdCSkZTVVNSSWtpZ0FGa1pVU0pJaXRsUkltS0FRR0wvNGdBUjRtS0F3RXhBSXY5U3dHSUFMZEppLytuUkl2L29Va1ZKQTVFSksrcmkvMU9Bb2dBd2tpTC9ZditpLytJQURHSmlnSUJNUUNML292L2lBQ3JpWW9DQVl2K2kvK0lBSDZKaWdFQkp3YUwvMUJKdlVVQlFBQURLVXlKaXdDK1JFeUppZ01CaS8ySS8rQkppLzZJLzlwTWkvK25SSXY5aS80VFFRQXBpd0NMLzZGSkZTUU9SQ1N2VEVzQnF5Y0dpLzFRVEwrTEFZdi9vRWtWSkE1RXF5Y0dpLzVRVEwrTC9ZditVSXYvVUNjVVRGQ3dKd1dNQUltS0FnR0wvb3YvVUFGSkZTUVNSSW1LQWdHTC9vdi9pUC9uZ0FGaFRGQkp2VVVCUUFBREtVeUppd0MrUkZjQUlFeUppZ01CaS8yTC9vai94WXYvaS8xUWkvNVFnQUZoVHdKUVRMK0wvWXYrVUl2L1VJQUVHV240WlV4UXNDY0ZpU0luQ1dWRkFVRUFDU0luQ1dWRUYwQUFFU0lxWlVVQlFBQUVLaklKWnljSkp3NW5pWWovMlNJcVpVU0ppZ0VCaVAvT0lpcGxSUUZBQUFNbkNJa2lLbVZFS1JKQkFBTW5DSWtpS21WRWkvOFNKd2dpVHdKVWlZb0JBQ0luQ1dWRkFVRUFIU0luQ1dWRUZ5TVNRUUFTSXhSRWkvOHBFMFFxaS85bkp3a25EbWVKSWtMLzY0b0JBSWovZGpFQUlpcGxSQkpFaS84cEUwUWlLbVZFS292L1o0di9VQ2NWVEZDd2lZai9WVEVBSWlwbFJCSkVJaXBsUkNvcFo0QUVOR3FoWmt4UXNJbUtBUUNJL3pZeEFDSXFaVVFTUkl2L0tSTkVJaWNIWlVVQlFRQUpJaWNIWlVRcEV4UkVKd2VMLzJjaUttVkVpLzlRZ0FRV3Z4K1JURkN3aVlqKy9pSW5CMlZGQVVReEFDSW5CMlZFU3dFU1JDSXFaVVFxU3dKbkp3Y3BaMHhRZ0FUMzQyczNTd0ZRc0NjVlRGQ3dpWWoreXpFQUlpcGxSQkpFSndjcFo0az0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlW10pIiwic3RydWN0IjoiYXJjMTQxMF9wYXJ0aXRpb25fdHJhbnNmZXIiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjMjAwX1RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJJc3N1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE0MTBfcGFydGl0aW9uX2lzc3VlIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlZGVlbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE0MTBfcGFydGl0aW9uX3JlZGVlbSIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmMyMDBfQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzg4X093bmVyc2hpcFJlbm91bmNlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVyUmVxdWVzdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZW5kaW5nX293bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBUcmFuc2ZlckFjY2VwdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
