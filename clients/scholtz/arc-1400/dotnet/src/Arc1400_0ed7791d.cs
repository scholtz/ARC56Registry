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

namespace Arc56.Generated.scholtz.arc_1400.Arc1400_0ed7791d
{


    public class Arc1400Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc1400Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class Arc1644ControllerChangedEvent : AVMObjectType
            {
                public Algorand.Address Old { get; set; }

                public Algorand.Address Neu { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOld = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOld.From(Old);
                    ret.AddRange(vOld.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNeu = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vNeu.From(Neu);
                    ret.AddRange(vNeu.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1644ControllerChangedEvent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1644ControllerChangedEvent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOld = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOld.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOld = vOld.ToValue();
                    if (valueOld is Algorand.Address vOldValue) { ret.Old = vOldValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNeu = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vNeu.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNeu = vNeu.ToValue();
                    if (valueNeu is Algorand.Address vNeuValue) { ret.Neu = vNeuValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1644ControllerChangedEvent);
                }
                public bool Equals(Arc1644ControllerChangedEvent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1644ControllerChangedEvent left, Arc1644ControllerChangedEvent right)
                {
                    return EqualityComparer<Arc1644ControllerChangedEvent>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1644ControllerChangedEvent left, Arc1644ControllerChangedEvent right)
                {
                    return !(left == right);
                }

            }

            public class Arc1644ControllerRedeemEvent : AVMObjectType
            {
                public Algorand.Address Controller { get; set; }

                public Algorand.Address From { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte Code { get; set; }

                public byte[] OperatorData { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vController = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vController.From(Controller);
                    ret.AddRange(vController.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vFrom.From(From);
                    ret.AddRange(vFrom.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte");
                    vCode.From(Code);
                    ret.AddRange(vCode.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperatorData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vOperatorData.From(OperatorData);
                    ret.AddRange(vOperatorData.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1644ControllerRedeemEvent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1644ControllerRedeemEvent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vController = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vController.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueController = vController.ToValue();
                    if (valueController is Algorand.Address vControllerValue) { ret.Controller = vControllerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is Algorand.Address vFromValue) { ret.From = vFromValue; }
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte");
                    count = vCode.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCode = vCode.ToValue();
                    if (valueCode is byte vCodeValue) { ret.Code = vCodeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperatorData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vOperatorData.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOperatorData = vOperatorData.ToValue();
                    if (valueOperatorData is byte[] vOperatorDataValue) { ret.OperatorData = vOperatorDataValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1644ControllerRedeemEvent);
                }
                public bool Equals(Arc1644ControllerRedeemEvent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1644ControllerRedeemEvent left, Arc1644ControllerRedeemEvent right)
                {
                    return EqualityComparer<Arc1644ControllerRedeemEvent>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1644ControllerRedeemEvent left, Arc1644ControllerRedeemEvent right)
                {
                    return !(left == right);
                }

            }

            public class Arc1644ControllerTransferEvent : AVMObjectType
            {
                public Algorand.Address Controller { get; set; }

                public Algorand.Address From { get; set; }

                public Algorand.Address To { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte Code { get; set; }

                public byte[] Data { get; set; }

                public byte[] OperatorData { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vController = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vController.From(Controller);
                    ret.AddRange(vController.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vFrom.From(From);
                    ret.AddRange(vFrom.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTo.From(To);
                    ret.AddRange(vTo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte");
                    vCode.From(Code);
                    ret.AddRange(vCode.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vData.From(Data);
                    ret.AddRange(vData.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperatorData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vOperatorData.From(OperatorData);
                    ret.AddRange(vOperatorData.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc1644ControllerTransferEvent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc1644ControllerTransferEvent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vController = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vController.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueController = vController.ToValue();
                    if (valueController is Algorand.Address vControllerValue) { ret.Controller = vControllerValue; }
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
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte");
                    count = vCode.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCode = vCode.ToValue();
                    if (valueCode is byte vCodeValue) { ret.Code = vCodeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vData.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueData = vData.ToValue();
                    if (valueData is byte[] vDataValue) { ret.Data = vDataValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperatorData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vOperatorData.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOperatorData = vOperatorData.ToValue();
                    if (valueOperatorData is byte[] vOperatorDataValue) { ret.OperatorData = vOperatorDataValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc1644ControllerTransferEvent);
                }
                public bool Equals(Arc1644ControllerTransferEvent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc1644ControllerTransferEvent left, Arc1644ControllerTransferEvent right)
                {
                    return EqualityComparer<Arc1644ControllerTransferEvent>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc1644ControllerTransferEvent left, Arc1644ControllerTransferEvent right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
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

            public class ControllerChangedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 64, 156, 197, 112 };
                public const string Signature = "ControllerChanged((address,address))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1644ControllerChangedEvent Field0 { get; set; }

                public static ControllerChangedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ControllerChangedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    ret.Field0 = Structs.Arc1644ControllerChangedEvent.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

            }

            public class ControllerTransferEvent
            {
                public static readonly byte[] Selector = new byte[4] { 52, 110, 167, 149 };
                public const string Signature = "ControllerTransfer((address,address,address,uint256,byte,byte[],byte[]))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1644ControllerTransferEvent Field0 { get; set; }

                public static ControllerTransferEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ControllerTransferEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.Arc1644ControllerTransferEvent.Parse(eventData.Skip(indexField0).ToArray());
                    return ret;

                }

            }

            public class ControllerRedeemEvent
            {
                public static readonly byte[] Selector = new byte[4] { 13, 238, 20, 245 };
                public const string Signature = "ControllerRedeem((address,address,uint256,byte,byte[]))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.Arc1644ControllerRedeemEvent Field0 { get; set; }

                public static ControllerRedeemEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ControllerRedeemEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.Arc1644ControllerRedeemEvent.Parse(eventData.Skip(indexField0).ToArray());
                    return ret;

                }

            }

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
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="symbol"> </param>
        /// <param name="decimals"> </param>
        /// <param name="totalSupply"> </param>
        /// <param name="owner"> </param>
        /// <param name="controller"> </param>
        /// <param name="controllable"> </param>
        /// <param name="requireJustification"> </param>
        /// <param name="minControllerActionInterval"> </param>
        public async Task<bool> Bootstrap1400(byte[] name, byte[] symbol, byte decimals, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalSupply, Algorand.Address owner, Algorand.Address controller, bool controllable, bool requireJustification, ulong minControllerActionInterval, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 231, 65, 171 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); symbolAbi.From(symbol);
            var decimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); decimalsAbi.From(decimals);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var controllerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); controllerAbi.From(controller);
            var controllableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); controllableAbi.From(controllable);
            var requireJustificationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); requireJustificationAbi.From(requireJustification);
            var minControllerActionIntervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minControllerActionIntervalAbi.From(minControllerActionInterval);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, symbolAbi, decimalsAbi, totalSupply, ownerAbi, controllerAbi, controllableAbi, requireJustificationAbi, minControllerActionIntervalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Bootstrap1400_Transactions(byte[] name, byte[] symbol, byte decimals, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalSupply, Algorand.Address owner, Algorand.Address controller, bool controllable, bool requireJustification, ulong minControllerActionInterval, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 231, 65, 171 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); symbolAbi.From(symbol);
            var decimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); decimalsAbi.From(decimals);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var controllerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); controllerAbi.From(controller);
            var controllableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); controllableAbi.From(controllable);
            var requireJustificationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); requireJustificationAbi.From(requireJustification);
            var minControllerActionIntervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minControllerActionIntervalAbi.From(minControllerActionInterval);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, symbolAbi, decimalsAbi, totalSupply, ownerAbi, controllerAbi, controllableAbi, requireJustificationAbi, minControllerActionIntervalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_controller"> </param>
        public async Task Arc1644SetController(Algorand.Address new_controller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 84, 114, 208 };
            var new_controllerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_controllerAbi.From(new_controller);

            var result = await base.CallApp(new List<object> { abiHandle, new_controllerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1644SetController_Transactions(Algorand.Address new_controller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 84, 114, 208 };
            var new_controllerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_controllerAbi.From(new_controller);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_controllerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="flag"> </param>
        public async Task Arc1644SetControllable(bool flag, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 121, 4, 164 };
            var flagAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); flagAbi.From(flag);

            var result = await base.CallApp(new List<object> { abiHandle, flagAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1644SetControllable_Transactions(bool flag, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 121, 4, 164 };
            var flagAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); flagAbi.From(flag);

            return await base.MakeTransactionList(new List<object> { abiHandle, flagAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="flag"> </param>
        public async Task Arc1644SetRequireJustification(bool flag, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 244, 248, 97 };
            var flagAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); flagAbi.From(flag);

            var result = await base.CallApp(new List<object> { abiHandle, flagAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1644SetRequireJustification_Transactions(bool flag, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 244, 248, 97 };
            var flagAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); flagAbi.From(flag);

            return await base.MakeTransactionList(new List<object> { abiHandle, flagAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="interval"> </param>
        public async Task Arc1644SetMinActionInterval(ulong interval, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 189, 45, 52 };
            var intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); intervalAbi.From(interval);

            var result = await base.CallApp(new List<object> { abiHandle, intervalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc1644SetMinActionInterval_Transactions(ulong interval, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 189, 45, 52 };
            var intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); intervalAbi.From(interval);

            return await base.MakeTransactionList(new List<object> { abiHandle, intervalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Arc1644IsControllable(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 111, 45, 14 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc1644IsControllable_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 111, 45, 14 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        /// <param name="data"> </param>
        /// <param name="operator_data"> </param>
        public async Task<ulong> Arc1644ControllerTransfer(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, byte[] operator_data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 92, 122, 23 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);
            var operator_dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); operator_dataAbi.From(operator_data);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, toAbi, amount, dataAbi, operator_dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc1644ControllerTransfer_Transactions(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] data, byte[] operator_data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 92, 122, 23 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);
            var operator_dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); operator_dataAbi.From(operator_data);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, toAbi, amount, dataAbi, operator_dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="amount"> </param>
        /// <param name="operator_data"> </param>
        public async Task<ulong> Arc1644ControllerRedeem(Algorand.Address from, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] operator_data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 122, 110, 24 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var operator_dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); operator_dataAbi.From(operator_data);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, amount, operator_dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc1644ControllerRedeem_Transactions(Algorand.Address from, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, byte[] operator_data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 122, 110, 24 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var operator_dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); operator_dataAbi.From(operator_data);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, amount, operator_dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjMTQwMCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBcHByb3ZhbFN0cnVjdCI6W3sibmFtZSI6ImFwcHJvdmFsQW1vdW50IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic3BlbmRlciIsInR5cGUiOiJhZGRyZXNzIn1dLCJhcmMxNDEwX0hvbGRpbmdQYXJ0aXRpb25zUGFnaW5hdGVkS2V5IjpbeyJuYW1lIjoiaG9sZGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYWdlIiwidHlwZSI6InVpbnQ2NCJ9XSwiYXJjMTQxMF9PcGVyYXRvcktleSI6W3sibmFtZSI6ImhvbGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoib3BlcmF0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhcnRpdGlvbiIsInR5cGUiOiJhZGRyZXNzIn1dLCJhcmMxNDEwX09wZXJhdG9yUG9ydGlvbktleSI6W3sibmFtZSI6ImhvbGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoib3BlcmF0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhcnRpdGlvbiIsInR5cGUiOiJhZGRyZXNzIn1dLCJhcmMxNDEwX1BhcnRpdGlvbktleSI6W3sibmFtZSI6ImhvbGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicGFydGl0aW9uIiwidHlwZSI6ImFkZHJlc3MifV0sImFyYzE0MTBfY2FuX3RyYW5zZmVyX2J5X3BhcnRpdGlvbl9yZXR1cm4iOlt7Im5hbWUiOiJjb2RlIiwidHlwZSI6ImJ5dGUifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicmVjZWl2ZXJQYXJ0aXRpb24iLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiYXJjMTQxMF9wYXJ0aXRpb25faXNzdWUiOlt7Im5hbWUiOiJ0byIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicGFydGl0aW9uIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImRhdGEiLCJ0eXBlIjoiYnl0ZVtdIn1dLCJhcmMxNDEwX3BhcnRpdGlvbl9yZWRlZW0iOlt7Im5hbWUiOiJmcm9tIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYXJ0aXRpb24iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGF0YSIsInR5cGUiOiJieXRlW10ifV0sImFyYzE0MTBfcGFydGl0aW9uX3RyYW5zZmVyIjpbeyJuYW1lIjoiZnJvbSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidG8iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhcnRpdGlvbiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJkYXRhIiwidHlwZSI6ImJ5dGVbXSJ9XSwiYXJjMTU5NF9pc3N1ZV9ldmVudCI6W3sibmFtZSI6InRvIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImRhdGEiLCJ0eXBlIjoiYnl0ZVtdIn1dLCJhcmMxNTk0X3JlZGVlbV9ldmVudCI6W3sibmFtZSI6ImZyb20iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGF0YSIsInR5cGUiOiJieXRlW10ifV0sImFyYzE2NDNfZG9jdW1lbnRfcmVjb3JkIjpbeyJuYW1lIjoidXJpIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6Imhhc2giLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoidGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9XSwiYXJjMTY0M19kb2N1bWVudF9yZW1vdmVkX2V2ZW50IjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJ1cmkiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiaGFzaCIsInR5cGUiOiJieXRlW10ifV0sImFyYzE2NDNfZG9jdW1lbnRfdXBkYXRlZF9ldmVudCI6W3sibmFtZSI6Im5hbWUiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoidXJpIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6Imhhc2giLCJ0eXBlIjoiYnl0ZVtdIn1dLCJhcmMxNjQ0X2NvbnRyb2xsZXJfY2hhbmdlZF9ldmVudCI6W3sibmFtZSI6Im9sZCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibmV1IiwidHlwZSI6ImFkZHJlc3MifV0sImFyYzE2NDRfY29udHJvbGxlcl9yZWRlZW1fZXZlbnQiOlt7Im5hbWUiOiJjb250cm9sbGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmcm9tIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImNvZGUiLCJ0eXBlIjoiYnl0ZSJ9LHsibmFtZSI6Im9wZXJhdG9yX2RhdGEiLCJ0eXBlIjoiYnl0ZVtdIn1dLCJhcmMxNjQ0X2NvbnRyb2xsZXJfdHJhbnNmZXJfZXZlbnQiOlt7Im5hbWUiOiJjb250cm9sbGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmcm9tIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ0byIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJjb2RlIiwidHlwZSI6ImJ5dGUifSx7Im5hbWUiOiJkYXRhIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6Im9wZXJhdG9yX2RhdGEiLCJ0eXBlIjoiYnl0ZVtdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzeW1ib2wiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVjaW1hbHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbFN1cHBseSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjMjAwX1RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9vdHN0cmFwMTQwMCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzeW1ib2wiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVjaW1hbHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbFN1cHBseSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udHJvbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnRyb2xsYWJsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVpcmVKdXN0aWZpY2F0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5Db250cm9sbGVyQWN0aW9uSW50ZXJ2YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzIwMF9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjODhfT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE2NDRfc2V0X2NvbnRyb2xsZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19jb250cm9sbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJDb250cm9sbGVyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzKSIsInN0cnVjdCI6ImFyYzE2NDRfY29udHJvbGxlcl9jaGFuZ2VkX2V2ZW50IiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNjQ0X3NldF9jb250cm9sbGFibGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZsYWciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTY0NF9zZXRfcmVxdWlyZV9qdXN0aWZpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmbGFnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE2NDRfc2V0X21pbl9hY3Rpb25faW50ZXJ2YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJ2YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTY0NF9pc19jb250cm9sbGFibGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE2NDRfY29udHJvbGxlcl90cmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRvcl9kYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbnRyb2xsZXJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlLGJ5dGVbXSxieXRlW10pIiwic3RydWN0IjoiYXJjMTY0NF9jb250cm9sbGVyX3RyYW5zZmVyX2V2ZW50IiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNjQ0X2NvbnRyb2xsZXJfcmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRvcl9kYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbnRyb2xsZXJSZWRlZW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGUsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE2NDRfY29udHJvbGxlcl9yZWRlZW1fZXZlbnQiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE2NDNfc2V0X2RvY3VtZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVyaSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRG9jdW1lbnRVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihieXRlW10sc3RyaW5nLGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNjQzX2RvY3VtZW50X3VwZGF0ZWRfZXZlbnQiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE2NDNfZ2V0X2RvY3VtZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxieXRlW10sdWludDY0KSIsInN0cnVjdCI6ImFyYzE2NDNfZG9jdW1lbnRfcmVjb3JkIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNjQzX3JlbW92ZV9kb2N1bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJEb2N1bWVudFJlbW92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGJ5dGVbXSxzdHJpbmcsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE2NDNfZG9jdW1lbnRfcmVtb3ZlZF9ldmVudCIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTY0M19nZXRfYWxsX2RvY3VtZW50cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNTk0X3NldF9pc3N1YWJsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmxhZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNTk0X2lzc3VlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiSXNzdWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl9pc3N1ZSIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJJc3N1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNTk0X2lzc3VlX2V2ZW50IiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNTk0X3JlZGVlbUZyb20iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlZGVlbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNTk0X3JlZGVlbV9ldmVudCIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTU5NF9yZWRlZW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE1OTRfcmVkZWVtX2V2ZW50IiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNTk0X3RyYW5zZmVyX3dpdGhfZGF0YSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl90cmFuc2ZlciIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNTk0X3RyYW5zZmVyX2Zyb21fd2l0aF9kYXRhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzIwMF9BcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjMjAwX1RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTU5NF9pc19pc3N1YWJsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfYmFsYW5jZV9vZl9wYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF90cmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE0MTBfcGFydGl0aW9uX3RyYW5zZmVyIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzIwMF9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfdHJhbnNmZXJfYnlfcGFydGl0aW9uIiwiZGVzYyI6IlRyYW5zZmVyIGFuIGFtb3VudCBvZiB0b2tlbnMgZnJvbSBwYXJ0aXRpb24gdG8gcmVjZWl2ZXIuIFNlbmRlciBtdXN0IGJlIG1zZy5zZW5kZXIgb3IgYXV0aG9yaXplZCBvcGVyYXRvci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlW10pIiwic3RydWN0IjoiYXJjMTQxMF9wYXJ0aXRpb25fdHJhbnNmZXIiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfcGFydGl0aW9uc19vZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9sZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYWdlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTQxMF9pc19vcGVyYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9sZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX2F1dGhvcml6ZV9vcGVyYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9sZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTQxMF9yZXZva2Vfb3BlcmF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfb3BlcmF0b3JfdHJhbnNmZXJfYnlfcGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl90cmFuc2ZlciIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMTQxMF9jYW5fdHJhbnNmZXJfYnlfcGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGUsc3RyaW5nLGFkZHJlc3MpIiwic3RydWN0IjoiYXJjMTQxMF9jYW5fdHJhbnNmZXJfYnlfcGFydGl0aW9uX3JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfYXV0aG9yaXplX29wZXJhdG9yX2J5X3BvcnRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfaXNfb3BlcmF0b3JfYnlfcG9ydGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9sZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMxNDEwX2lzc3VlX2J5X3BhcnRpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Iklzc3VlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlW10pIiwic3RydWN0IjoiYXJjMTQxMF9wYXJ0aXRpb25faXNzdWUiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfcmVkZWVtX2J5X3BhcnRpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGl0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSZWRlZW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl9yZWRlZW0iLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzE0MTBfb3BlcmF0b3JfcmVkZWVtX2J5X3BhcnRpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDI1NixieXRlW10pIiwic3RydWN0IjoiYXJjMTQxMF9wYXJ0aXRpb25fcmVkZWVtIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfbmFtZSIsImRlc2MiOiJSZXR1cm5zIHRoZSBuYW1lIG9mIHRoZSB0b2tlbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBuYW1lIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3N5bWJvbCIsImRlc2MiOiJSZXR1cm5zIHRoZSBzeW1ib2wgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbOF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc3ltYm9sIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2RlY2ltYWxzIiwiZGVzYyI6IlJldHVybnMgdGhlIGRlY2ltYWxzIG9mIHRoZSB0b2tlbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBkZWNpbWFscyBvZiB0aGUgdG9rZW4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF90b3RhbFN1cHBseSIsImRlc2MiOiJSZXR1cm5zIHRoZSB0b3RhbCBzdXBwbHkgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgdG90YWwgc3VwcGx5IG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2JhbGFuY2VPZiIsImRlc2MiOiJSZXR1cm5zIHRoZSBjdXJyZW50IGJhbGFuY2Ugb2YgdGhlIG93bmVyIG9mIHRoZSB0b2tlbiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIG93bmVyIG9mIHRoZSB0b2tlbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGN1cnJlbnQgYmFsYW5jZSBvZiB0aGUgaG9sZGVyIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3RyYW5zZmVyRnJvbSIsImRlc2MiOiJUcmFuc2ZlcnMgdG9rZW5zIGZyb20gc291cmNlIHRvIGRlc3RpbmF0aW9uIGFzIGFwcHJvdmVkIHNwZW5kZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjoiVGhlIHNvdXJjZSBvZiB0aGUgdHJhbnNmZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOiJUaGUgZGVzdGluYXRpb24gb2YgdGhlIHRyYW5zZmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjoiQW1vdW50IG9mIHRva2VucyB0byB0cmFuc2ZlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzIwMF9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF9hcHByb3ZlIiwiZGVzYyI6IkFwcHJvdmUgc3BlbmRlciBmb3IgYSB0b2tlbiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOiJXaG8gaXMgYWxsb3dlZCB0byB0YWtlIHRva2VucyBvbiBvd25lcidzIGJlaGFsZiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6IkFtb3VudCBvZiB0b2tlbnMgdG8gYmUgdGFrZW4gYnkgc3BlbmRlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfYWxsb3dhbmNlIiwiZGVzYyI6IlJldHVybnMgdGhlIGN1cnJlbnQgYWxsb3dhbmNlIG9mIHRoZSBzcGVuZGVyIG9mIHRoZSB0b2tlbnMgb2YgdGhlIG93bmVyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOiJPd25lcidzIGFjY291bnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6IldobyBpcyBhbGxvd2VkIHRvIHRha2UgdG9rZW5zIG9uIG93bmVyJ3MgYmVoYWxmIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgcmVtYWluaW5nIGFsbG93YW5jZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjODhfb3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9pc19vd25lciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVlcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9pbml0aWFsaXplX293bmVyIiwiZGVzYyI6IkV4cGxpY2l0IGluaXRpYWxpemF0aW9uIG92ZXJyaWRlIChjcmVhdGlvbiBncm91cCByZWNvbW1lbmRlZCkuIEZhaWxzIGlmIGFscmVhZHkgaW5pdGlhbGl6ZWQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjODhfdHJhbnNmZXJfb3duZXJzaGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9yZW5vdW5jZV9vd25lcnNoaXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzg4X093bmVyc2hpcFJlbm91bmNlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF90cmFuc2Zlcl9vd25lcnNoaXBfcmVxdWVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVuZGluZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjODhfT3duZXJzaGlwVHJhbnNmZXJSZXF1ZXN0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlbmRpbmdfb3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9hY2NlcHRfb3duZXJzaGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBUcmFuc2ZlckFjY2VwdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM4OF9jYW5jZWxfb3duZXJzaGlwX3JlcXVlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoxM30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjYzMCwyNjgzLDI3MDMsMjc4MiwyOTMxLDI5NDQsMzAzNCwzMDQ3LDMxNTAsMzIzMSwzMjgwLDMzMTIsMzQzNiwzNTc4LDM3NzMsMzk1OCw0MDIxLDQwNzksNDA5NCw0MjExLDQzMDAsNDM4Myw0NDQ4LDQ0ODYsNDU3Miw0NTc5LDQ2MDksNDYyMiw0NzMwLDQ3NzcsNDc4NCw0ODE3LDQ4MzAsNTAzMCw1MTYyXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNDcsNTE2M10sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYxNyw0ODI1XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDUxXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGJhbGFuY2UgYXQgdGhlIHNlbmRlciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU3Niw0NzgxXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IHBhcnRpdGlvbiBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE4Niw0NDE1LDQ1NTNdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MzJdLCJlcnJvck1lc3NhZ2UiOiJOYW1lIG9mIHRoZSBhc3NldCBtdXN0IGJlIGxvbmdlciBvciBlcXVhbCB0byAxIGNoYXJhY3RlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MzVdLCJlcnJvck1lc3NhZ2UiOiJOYW1lIG9mIHRoZSBhc3NldCBtdXN0IGJlIHNob3J0ZXIgb3IgZXF1YWwgdG8gMzIgY2hhcmFjdGVycyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0NjMsNDc1N10sImVycm9yTWVzc2FnZSI6Ik5vdCBhdXRob3JpemVkIG9wZXJhdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ4LDY2MCw2NzIsNjg3LDY5OSw3MTQsNzI5LDc0OCw3NjQsNzg2LDgwOCw4MzMsODUyLDg2OCw4ODQsOTAwLDkxNiw5NDAsOTYxLDk4NSwxMDEwLDEwMzQsMTA2NSwxMDk2LDExMTcsMTEzOCwxMTYzLDExODUsMTIxMywxMjM1LDEyNTcsMTI3MywxMzAxLDEzMjYsMTM0NCwxMzY1LDEzODYsMTQwMSwxNDE3LDE0MzIsMTQ1MSwxNDcyLDE0OTcsMTUyOCwxNTQ0LDE1NTksMTU3NCwxNTg5LDE2MDQsMTY0N10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MjRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGRlcGxveWVyIG9mIHRoaXMgc21hcnQgY29udHJhY3QgY2FuIGNhbGwgYm9vdHN0cmFwIG1ldGhvZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMzddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGhvbGRlciBjYW4gYXV0aG9yaXplIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMyMl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgaG9sZGVyIGNhbiBhdXRob3JpemUgcG9ydGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNjJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGhvbGRlciBjYW4gcmV2b2tlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU2OSw0Nzc0XSwiZXJyb3JNZXNzYWdlIjoiUGFydGl0aW9uIGJhbGFuY2UgbWlzc2luZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0NDEsNDczNV0sImVycm9yTWVzc2FnZSI6IlBvcnRpb24gYWxsb3dhbmNlIGV4Y2VlZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg0M10sImVycm9yTWVzc2FnZSI6IlN5bWJvbCBvZiB0aGUgYXNzZXQgbXVzdCBiZSBsb25nZXIgb3IgZXF1YWwgdG8gMSBjaGFyYWN0ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODQ3XSwiZXJyb3JNZXNzYWdlIjoiU3ltYm9sIG9mIHRoZSBhc3NldCBtdXN0IGJlIHNob3J0ZXIgb3IgZXF1YWwgdG8gOCBjaGFyYWN0ZXJzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg1NF0sImVycm9yTWVzc2FnZSI6IlRoaXMgbWV0aG9kIGNhbiBiZSBjYWxsZWQgb25seSBvbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTMyNl0sImVycm9yTWVzc2FnZSI6ImFscmVhZHlfaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjgwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUxLDY2Myw2NzUsNjkwLDcwMiw3MTcsNzMyLDc1MSw3NjcsNzg5LDgxMSw4MzYsODU1LDg3MSw4ODcsOTAzLDkxOSw5NDMsOTY0LDk4OCwxMDEzLDEwMzcsMTA2OCwxMDk5LDExMjAsMTE0MSwxMTY2LDExODgsMTIxNiwxMjM4LDEyNjAsMTI3NiwxMzA0LDEzMjksMTM0NywxMzY4LDEzODksMTQwNCwxNDIwLDE0MzUsMTQ1NCwxNDc1LDE1MDAsMTUzMSwxNTQ3LDE1NjIsMTU3NywxNTkyLDE2MDcsMTY1MF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTc0LDE5OTAsMjAyMSwyMDUwLDIwNjgsMjA3NCwyMTEzLDIxODgsMjIzOSwyNDQ1LDI4MzIsMjk2NiwzMDY5LDMxMzUsNDUwNSw0NjQxLDQ4NDksNDg5Miw0OTA3LDQ5MjMsNDkyOCw1MjI3LDUyNTYsNTI3OCw1MjkwLDUzMTcsNTM1Nyw1MzY4LDUzOTAsNTM5Niw1NDIxLDU0NDIsNTQ1NSw1NDg1LDU0OTMsNTUyOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OTldLCJlcnJvck1lc3NhZ2UiOiJjb250cm9sbGVyX2Rpc2FibGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUxNl0sImVycm9yTWVzc2FnZSI6ImVtcHR5X25hbWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjk5LDI0MjBdLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTU1XSwiZXJyb3JNZXNzYWdlIjoiaW5zdWZmaWNpZW50IGFwcHJvdmFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkzOSwzMDQyXSwiZXJyb3JNZXNzYWdlIjoiaW5zdWZmaWNpZW50X2JhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTAwLDQ5MTYsNTEzMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgc2l6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MTgsMjkxMywzMDE5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZF9hbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODQxXSwiZXJyb3JNZXNzYWdlIjoiaXNzdWFuY2VfZGlzYWJsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDM1XSwiZXJyb3JNZXNzYWdlIjoianVzdGlmaWNhdGlvbl9yZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NjddLCJlcnJvck1lc3NhZ2UiOiJub19jb250cm9sbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkwN10sImVycm9yTWVzc2FnZSI6Im5vdF9hdXRoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk3Nl0sImVycm9yTWVzc2FnZSI6Im5vdF9jb250cm9sbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY4MSwyNzAwXSwiZXJyb3JNZXNzYWdlIjoibm90X2ZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM1OSw1MzkyLDU0MjMsNTUzMF0sImVycm9yTWVzc2FnZSI6Im5vdF9vd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0NzgsNTQ4OV0sImVycm9yTWVzc2FnZSI6Im5vdF9wZW5kaW5nX293bmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk1OSwyNTA0LDI3OTMsNDQwOV0sImVycm9yTWVzc2FnZSI6Im9ubHlfb3duZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzA3LDIzMzMsMjQyOCwyNDUzLDI5NTIsMjk3NCwzMDU1LDMwNzcsMzQ1Miw0MjE5LDQzMDgsNDQ1Niw0NDk0LDQ1MTMsNDU4Nyw0NjMwLDQ2NDksNDc0Niw0NzkyLDQ4MzgsNDg1Nyw0OTYzLDUwNjksNTA5Ml0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ0Nl0sImVycm9yTWVzc2FnZSI6InBlbmRpbmdfdHJhbnNmZXJfZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA4NF0sImVycm9yTWVzc2FnZSI6InJhdGVfbGltaXRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyODldLCJlcnJvck1lc3NhZ2UiOiJzYW1lX2FkZHIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzMxLDUzNjQsNTQyOF0sImVycm9yTWVzc2FnZSI6Inplcm9fYWRkcmVzc19ub3RfYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0F3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ0ltRnlZemc0WDI4aUlDSjBJaUFpWWlJZ0ltRnlZekUyTkRSZlkzUnliR1Z1SWlBd2VEQXdNRElnTUhnNE1DQWlZWEpqTVRReE1GOXdJaUFpWVhKak1UWTBORjlqZEhKc0lpQWlZWEpqTVRZME0xOWtiMk56SWlBaVlYSmpPRGhmY0c4aUlEQjRNREFnSW1GeVl6ZzRYMjlwSWlBd2VEQXdNREF3TURBd01EQXdNREF3TURBZ0ltRnlZekUxT1RSZmFYTnpJaUFpWVhKak1UWTBORjl0WTJGcElpQWlZWEpqTVRReE1GOXZjR0VpSUNKaGNtTXhOalEwWDNKcWRYTjBJaUFpWVhKak1UWTBORjlzWTJGeUlpQXdlREF3TURBZ0ltRnlZekUwTVRCZmFIQmZZU0lnSW1GeVl6RTBNVEJmYjNBaUlDSmhjbU14TmpRelgyUnZZeUlnTUhnd01EUXlJREI0TURFZ01IZ3dNREF4SURCNE1EQTJNaUF3ZURjNU9ETmpNelZqSURCNE1EQXdOaUF3ZUdRM1ptTTBZVGs0SURCNE5XTXlOMkkwWm1NZ01IZzBNelUxWkRKaFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1EQXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UUXdNQ0JsZUhSbGJtUnpJRUZ5WXpFMk5EUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRFUzQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T1RjMU16Z3laVElnTUhoaE5HVTNOREZoWWlBd2VEQTBOVFEzTW1Rd0lEQjROMlEzT1RBMFlUUWdNSGhsTm1ZMFpqZzJNU0F3ZURKbFltUXlaRE0wSURCNFpXVTJaakprTUdVZ01IZ3haRFZqTjJFeE55QXdlR1UxTjJFMlpURTRJREI0TVRGallqTTJaalVnTUhoaU1UWmtOMkU0WXlBd2VHRTNZMkl6TkRneUlEQjRaV05pTmpNMll6Z2dNSGcyTldJeE5qZ3lZU0F3ZURBeE16QTFPVGxpSURCNE1UUXlZalZtWTJJZ01IaG1PRGd6T0dWaU9TQXdlRE14T0RneVltWmhJREI0WVRsalkyRXhObVlnTUhneU5qWTFPVGRqTUNBd2VETTFaamd4TXpWbUlEQjRaR0UzTURJMVlqa2dNSGd6WmpJMU5qY3hNeUF3ZURrMVlqUm1PV1V6SURCNE9EQmpZelE1WVdJZ01IZ3dOemsyTWpFMk5TQXdlR1UzT0RrMk1XUmhJREI0Wm1RNU5EZ3daRGNnTUhoaU1XSXhaRFk1WVNBd2VHTXhZbVZrTnpnNUlEQjRNMkptWlRFNE16TWdNSGcxT1RsalpERmhOU0F3ZURaa1pUazBNVFkySURCNE1qaG1NREl6WkRjZ01IZzJOVGRrTVRObFl5QXdlR0kyWVdVeFlUSTFJREI0T0RSbFl6RXpaRFVnTUhobFl6azVOakEwTVNBd2VEZ3laVFUzTTJNMElEQjROR0U1TmpobU9HWWdNSGhpTlRReU1qRXlOU0F3ZUdKaVlqTXhPV1l6SURCNE1EY3dNalkxTkdVZ01IaGtNREUxTnpJMFpTQXdlREF5T1dabFkyTXdJREI0TnpNME9UTXpOR1VnTUhoa1lqZGpPREpsWmlBd2VHWmtNbU15WXpabElEQjROREpoTldZd05qVWdNSGhoWkRSbU5qaGxZU0F2THlCdFpYUm9iMlFnSW1KdmIzUnpkSEpoY0NoaWVYUmxXMTBzWW5sMFpWdGRMSFZwYm5RNExIVnBiblF5TlRZcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWW05dmRITjBjbUZ3TVRRd01DaGllWFJsVzEwc1lubDBaVnRkTEhWcGJuUTRMSFZwYm5ReU5UWXNZV1JrY21WemN5eGhaR1J5WlhOekxHSnZiMndzWW05dmJDeDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWVhKak1UWTBORjl6WlhSZlkyOXVkSEp2Ykd4bGNpaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6RTJORFJmYzJWMFgyTnZiblJ5YjJ4c1lXSnNaU2hpYjI5c0tYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6RTJORFJmYzJWMFgzSmxjWFZwY21WZmFuVnpkR2xtYVdOaGRHbHZiaWhpYjI5c0tYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6RTJORFJmYzJWMFgyMXBibDloWTNScGIyNWZhVzUwWlhKMllXd29kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6RTJORFJmYVhOZlkyOXVkSEp2Ykd4aFlteGxLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbUZ5WXpFMk5EUmZZMjl1ZEhKdmJHeGxjbDkwY21GdWMyWmxjaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5peGllWFJsVzEwc1lubDBaVnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWVhKak1UWTBORjlqYjI1MGNtOXNiR1Z5WDNKbFpHVmxiU2hoWkdSeVpYTnpMSFZwYm5ReU5UWXNZbmwwWlZ0ZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVlYSmpNVFkwTTE5elpYUmZaRzlqZFcxbGJuUW9ZbmwwWlZ0ZExITjBjbWx1Wnl4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlZWEpqTVRZME0xOW5aWFJmWkc5amRXMWxiblFvWW5sMFpWdGRLU2h6ZEhKcGJtY3NZbmwwWlZ0ZExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltRnlZekUyTkROZmNtVnRiM1psWDJSdlkzVnRaVzUwS0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjbU14TmpRelgyZGxkRjloYkd4ZlpHOWpkVzFsYm5SektDbGllWFJsVzExYlhTSXNJRzFsZEdodlpDQWlZWEpqTVRVNU5GOXpaWFJmYVhOemRXRmliR1VvWW05dmJDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTXhOVGswWDJsemMzVmxLR0ZrWkhKbGMzTXNkV2x1ZERJMU5peGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhKak1UVTVORjl5WldSbFpXMUdjbTl0S0dGa1pISmxjM01zZFdsdWRESTFOaXhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaVlYSmpNVFU1TkY5eVpXUmxaVzBvZFdsdWRESTFOaXhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaVlYSmpNVFU1TkY5MGNtRnVjMlpsY2w5M2FYUm9YMlJoZEdFb1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEdKNWRHVmJYU2xpYjI5c0lpd2diV1YwYUc5a0lDSmhjbU14TlRrMFgzUnlZVzV6Wm1WeVgyWnliMjFmZDJsMGFGOWtZWFJoS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJMR0o1ZEdWYlhTbGliMjlzSWl3Z2JXVjBhRzlrSUNKaGNtTXhOVGswWDJselgybHpjM1ZoWW14bEtDbGliMjlzSWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDJKaGJHRnVZMlZmYjJaZmNHRnlkR2wwYVc5dUtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmZEhKaGJuTm1aWElvWVdSa2NtVnpjeXgxYVc1ME1qVTJLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltRnlZekUwTVRCZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMkxHSjVkR1ZiWFNsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDNCaGNuUnBkR2x2Ym5OZmIyWW9ZV1JrY21WemN5eDFhVzUwTmpRcFlXUmtjbVZ6YzF0ZElpd2diV1YwYUc5a0lDSmhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOektXSnZiMndpTENCdFpYUm9iMlFnSW1GeVl6RTBNVEJmWVhWMGFHOXlhWHBsWDI5d1pYSmhkRzl5S0dGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnlZekUwTVRCZmNtVjJiMnRsWDI5d1pYSmhkRzl5S0dGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnlZekUwTVRCZmIzQmxjbUYwYjNKZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZc1lubDBaVnRkS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW1GeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZiaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMkxHSjVkR1ZiWFNrb1lubDBaU3h6ZEhKcGJtY3NZV1JrY21WemN5a2lMQ0J0WlhSb2IyUWdJbUZ5WXpFME1UQmZZWFYwYUc5eWFYcGxYMjl3WlhKaGRHOXlYMko1WDNCdmNuUnBiMjRvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgySjVYM0J2Y25ScGIyNG9ZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWVhKak1UUXhNRjlwYzNOMVpWOWllVjl3WVhKMGFYUnBiMjRvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6RTBNVEJmY21Wa1pXVnRYMko1WDNCaGNuUnBkR2x2YmloaFpHUnlaWE56TEhWcGJuUXlOVFlzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnlZekUwTVRCZmIzQmxjbUYwYjNKZmNtVmtaV1Z0WDJKNVgzQmhjblJwZEdsdmJpaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTml4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlZWEpqTWpBd1gyNWhiV1VvS1dKNWRHVmJNekpkSWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmYzNsdFltOXNLQ2xpZVhSbFd6aGRJaXdnYldWMGFHOWtJQ0poY21NeU1EQmZaR1ZqYVcxaGJITW9LWFZwYm5RNElpd2diV1YwYUc5a0lDSmhjbU15TURCZmRHOTBZV3hUZFhCd2JIa29LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbUZ5WXpJd01GOWlZV3hoYm1ObFQyWW9ZV1JrY21WemN5bDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmhjbU15TURCZmRISmhibk5tWlhKR2NtOXRLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMktXSnZiMndpTENCdFpYUm9iMlFnSW1GeVl6SXdNRjloY0hCeWIzWmxLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbGliMjlzSWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmWVd4c2IzZGhibU5sS0dGa1pISmxjM01zWVdSa2NtVnpjeWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0poY21NNE9GOXZkMjVsY2lncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaVlYSmpPRGhmYVhOZmIzZHVaWElvWVdSa2NtVnpjeWxpYjI5c0lpd2diV1YwYUc5a0lDSmhjbU00T0Y5cGJtbDBhV0ZzYVhwbFgyOTNibVZ5S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlZWEpqT0RoZmRISmhibk5tWlhKZmIzZHVaWEp6YUdsd0tHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhKak9EaGZjbVZ1YjNWdVkyVmZiM2R1WlhKemFHbHdLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjbU00T0Y5MGNtRnVjMlpsY2w5dmQyNWxjbk5vYVhCZmNtVnhkV1Z6ZENoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ5WXpnNFgyRmpZMlZ3ZEY5dmQyNWxjbk5vYVhBb0tYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6ZzRYMk5oYm1ObGJGOXZkMjVsY25Ob2FYQmZjbVZ4ZFdWemRDZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWW05dmRITjBjbUZ3WDNKdmRYUmxRRFVnYldGcGJsOWliMjkwYzNSeVlYQXhOREF3WDNKdmRYUmxRRFlnYldGcGJsOWhjbU14TmpRMFgzTmxkRjlqYjI1MGNtOXNiR1Z5WDNKdmRYUmxRRGNnYldGcGJsOWhjbU14TmpRMFgzTmxkRjlqYjI1MGNtOXNiR0ZpYkdWZmNtOTFkR1ZBT0NCdFlXbHVYMkZ5WXpFMk5EUmZjMlYwWDNKbGNYVnBjbVZmYW5WemRHbG1hV05oZEdsdmJsOXliM1YwWlVBNUlHMWhhVzVmWVhKak1UWTBORjl6WlhSZmJXbHVYMkZqZEdsdmJsOXBiblJsY25aaGJGOXliM1YwWlVBeE1DQnRZV2x1WDJGeVl6RTJORFJmYVhOZlkyOXVkSEp2Ykd4aFlteGxYM0p2ZFhSbFFERXhJRzFoYVc1ZllYSmpNVFkwTkY5amIyNTBjbTlzYkdWeVgzUnlZVzV6Wm1WeVgzSnZkWFJsUURFeUlHMWhhVzVmWVhKak1UWTBORjlqYjI1MGNtOXNiR1Z5WDNKbFpHVmxiVjl5YjNWMFpVQXhNeUJ0WVdsdVgyRnlZekUyTkROZmMyVjBYMlJ2WTNWdFpXNTBYM0p2ZFhSbFFERTBJRzFoYVc1ZllYSmpNVFkwTTE5blpYUmZaRzlqZFcxbGJuUmZjbTkxZEdWQU1UVWdiV0ZwYmw5aGNtTXhOalF6WDNKbGJXOTJaVjlrYjJOMWJXVnVkRjl5YjNWMFpVQXhOaUJ0WVdsdVgyRnlZekUyTkROZloyVjBYMkZzYkY5a2IyTjFiV1Z1ZEhOZmNtOTFkR1ZBTVRjZ2JXRnBibDloY21NeE5UazBYM05sZEY5cGMzTjFZV0pzWlY5eWIzVjBaVUF4T0NCdFlXbHVYMkZ5WXpFMU9UUmZhWE56ZFdWZmNtOTFkR1ZBTVRrZ2JXRnBibDloY21NeE5UazBYM0psWkdWbGJVWnliMjFmY205MWRHVkFNakFnYldGcGJsOWhjbU14TlRrMFgzSmxaR1ZsYlY5eWIzVjBaVUF5TVNCdFlXbHVYMkZ5WXpFMU9UUmZkSEpoYm5ObVpYSmZkMmwwYUY5a1lYUmhYM0p2ZFhSbFFESXlJRzFoYVc1ZllYSmpNVFU1TkY5MGNtRnVjMlpsY2w5bWNtOXRYM2RwZEdoZlpHRjBZVjl5YjNWMFpVQXlNeUJ0WVdsdVgyRnlZekUxT1RSZmFYTmZhWE56ZFdGaWJHVmZjbTkxZEdWQU1qUWdiV0ZwYmw5aGNtTXhOREV3WDJKaGJHRnVZMlZmYjJaZmNHRnlkR2wwYVc5dVgzSnZkWFJsUURJMUlHMWhhVzVmWVhKak1qQXdYM1J5WVc1elptVnlYM0p2ZFhSbFFESTJJRzFoYVc1ZllYSmpNVFF4TUY5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNWZjbTkxZEdWQU1qY2diV0ZwYmw5aGNtTXhOREV3WDNCaGNuUnBkR2x2Ym5OZmIyWmZjbTkxZEdWQU1qZ2diV0ZwYmw5aGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgzSnZkWFJsUURJNUlHMWhhVzVmWVhKak1UUXhNRjloZFhSb2IzSnBlbVZmYjNCbGNtRjBiM0pmY205MWRHVkFNekFnYldGcGJsOWhjbU14TkRFd1gzSmxkbTlyWlY5dmNHVnlZWFJ2Y2w5eWIzVjBaVUF6TVNCdFlXbHVYMkZ5WXpFME1UQmZiM0JsY21GMGIzSmZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1WDNKdmRYUmxRRE15SUcxaGFXNWZZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgzSnZkWFJsUURNeklHMWhhVzVmWVhKak1UUXhNRjloZFhSb2IzSnBlbVZmYjNCbGNtRjBiM0pmWW5sZmNHOXlkR2x2Ymw5eWIzVjBaVUF6TkNCdFlXbHVYMkZ5WXpFME1UQmZhWE5mYjNCbGNtRjBiM0pmWW5sZmNHOXlkR2x2Ymw5eWIzVjBaVUF6TlNCdFlXbHVYMkZ5WXpFME1UQmZhWE56ZFdWZllubGZjR0Z5ZEdsMGFXOXVYM0p2ZFhSbFFETTJJRzFoYVc1ZllYSmpNVFF4TUY5eVpXUmxaVzFmWW5sZmNHRnlkR2wwYVc5dVgzSnZkWFJsUURNM0lHMWhhVzVmWVhKak1UUXhNRjl2Y0dWeVlYUnZjbDl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDNKdmRYUmxRRE00SUcxaGFXNWZZWEpqTWpBd1gyNWhiV1ZmY205MWRHVkFNemtnYldGcGJsOWhjbU15TURCZmMzbHRZbTlzWDNKdmRYUmxRRFF3SUcxaGFXNWZZWEpqTWpBd1gyUmxZMmx0WVd4elgzSnZkWFJsUURReElHMWhhVzVmWVhKak1qQXdYM1J2ZEdGc1UzVndjR3g1WDNKdmRYUmxRRFF5SUcxaGFXNWZZWEpqTWpBd1gySmhiR0Z1WTJWUFpsOXliM1YwWlVBME15QnRZV2x1WDJGeVl6SXdNRjkwY21GdWMyWmxja1p5YjIxZmNtOTFkR1ZBTkRRZ2JXRnBibDloY21NeU1EQmZZWEJ3Y205MlpWOXliM1YwWlVBME5TQnRZV2x1WDJGeVl6SXdNRjloYkd4dmQyRnVZMlZmY205MWRHVkFORFlnYldGcGJsOWhjbU00T0Y5dmQyNWxjbDl5YjNWMFpVQTBOeUJ0WVdsdVgyRnlZemc0WDJselgyOTNibVZ5WDNKdmRYUmxRRFE0SUcxaGFXNWZZWEpqT0RoZmFXNXBkR2xoYkdsNlpWOXZkMjVsY2w5eWIzVjBaVUEwT1NCdFlXbHVYMkZ5WXpnNFgzUnlZVzV6Wm1WeVgyOTNibVZ5YzJocGNGOXliM1YwWlVBMU1DQnRZV2x1WDJGeVl6ZzRYM0psYm05MWJtTmxYMjkzYm1WeWMyaHBjRjl5YjNWMFpVQTFNU0J0WVdsdVgyRnlZemc0WDNSeVlXNXpabVZ5WDI5M2JtVnljMmhwY0Y5eVpYRjFaWE4wWDNKdmRYUmxRRFV5SUcxaGFXNWZZWEpqT0RoZllXTmpaWEIwWDI5M2JtVnljMmhwY0Y5eWIzVjBaVUExTXlCdFlXbHVYMkZ5WXpnNFgyTmhibU5sYkY5dmQyNWxjbk5vYVhCZmNtVnhkV1Z6ZEY5eWIzVjBaVUExTkFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEWXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNREF1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNVFF3TUNCbGVIUmxibVJ6SUVGeVl6RTJORFFnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NNE9GOWpZVzVqWld4ZmIzZHVaWEp6YUdsd1gzSmxjWFZsYzNSZmNtOTFkR1ZBTlRRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdZWEpqT0RoZlkyRnVZMlZzWDI5M2JtVnljMmhwY0Y5eVpYRjFaWE4wQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpnNFgyRmpZMlZ3ZEY5dmQyNWxjbk5vYVhCZmNtOTFkR1ZBTlRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmhjbU00T0Y5aFkyTmxjSFJmYjNkdVpYSnphR2x3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpnNFgzUnlZVzV6Wm1WeVgyOTNibVZ5YzJocGNGOXlaWEYxWlhOMFgzSnZkWFJsUURVeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk56Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFME1EQWdaWGgwWlc1a2N5QkJjbU14TmpRMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJoY21NNE9GOTBjbUZ1YzJabGNsOXZkMjVsY25Ob2FYQmZjbVZ4ZFdWemRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTTRPRjl5Wlc1dmRXNWpaVjl2ZDI1bGNuTm9hWEJmY205MWRHVkFOVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCaGNtTTRPRjl5Wlc1dmRXNWpaVjl2ZDI1bGNuTm9hWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqT0RoZmRISmhibk5tWlhKZmIzZHVaWEp6YUdsd1gzSnZkWFJsUURVd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFME1EQWdaWGgwWlc1a2N5QkJjbU14TmpRMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJoY21NNE9GOTBjbUZ1YzJabGNsOXZkMjVsY25Ob2FYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpPRGhmYVc1cGRHbGhiR2w2WlY5dmQyNWxjbDl5YjNWMFpVQTBPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXdNQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREF3SUdWNGRHVnVaSE1nUVhKak1UWTBOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpPRGhmYVc1cGRHbGhiR2w2WlY5dmQyNWxjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU00T0Y5cGMxOXZkMjVsY2w5eWIzVjBaVUEwT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU14TkRBd0lHVjRkR1Z1WkhNZ1FYSmpNVFkwTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR05oYkd4emRXSWdZWEpqT0RoZmFYTmZiM2R1WlhJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak9EaGZiM2R1WlhKZmNtOTFkR1ZBTkRjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmhjbU00T0Y5dmQyNWxjZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU15TURCZllXeHNiM2RoYm1ObFgzSnZkWFJsUURRMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTNOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1EQXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UUXdNQ0JsZUhSbGJtUnpJRUZ5WXpFMk5EUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakUzTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNakF3WDJGc2JHOTNZVzVqWlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeU1EQmZZWEJ3Y205MlpWOXliM1YwWlVBME5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hOalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5EQXdMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6RTBNREFnWlhoMFpXNWtjeUJCY21NeE5qUTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94TmpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZekl3TUY5aGNIQnliM1psQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpJd01GOTBjbUZ1YzJabGNrWnliMjFmY205MWRHVkFORFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRRNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU14TkRBd0lHVjRkR1Z1WkhNZ1FYSmpNVFkwTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UUTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJoY21NeU1EQmZkSEpoYm5ObVpYSkdjbTl0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpJd01GOWlZV3hoYm1ObFQyWmZjbTkxZEdWQU5ETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXdNQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREF3SUdWNGRHVnVaSE1nUVhKak1UWTBOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRJekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU15TURCZlltRnNZVzVqWlU5bUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6SXdNRjkwYjNSaGJGTjFjSEJzZVY5eWIzVjBaVUEwTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE1USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdZWEpqTWpBd1gzUnZkR0ZzVTNWd2NHeDVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekl3TUY5a1pXTnBiV0ZzYzE5eWIzVjBaVUEwTVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE1ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdZWEpqTWpBd1gyUmxZMmx0WVd4ekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6SXdNRjl6ZVcxaWIyeGZjbTkxZEdWQU5EQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZPVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1qQXdYM041YldKdmJBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTXlNREJmYm1GdFpWOXliM1YwWlVBek9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJoY21NeU1EQmZibUZ0WlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeE5ERXdYMjl3WlhKaGRHOXlYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjVmY205MWRHVkFNemc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pReU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTVRRd01DQmxlSFJsYm1SeklFRnlZekUyTkRRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTBNVEJmYjNCbGNtRjBiM0pmY21Wa1pXVnRYMko1WDNCaGNuUnBkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeE5ERXdYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjVmY205MWRHVkFNemM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRd09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTVRRd01DQmxlSFJsYm1SeklFRnlZekUyTkRRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNRGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTBNVEJmY21Wa1pXVnRYMko1WDNCaGNuUnBkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeE5ERXdYMmx6YzNWbFgySjVYM0JoY25ScGRHbHZibDl5YjNWMFpVQXpOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXpnekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU14TkRBd0lHVjRkR1Z1WkhNZ1FYSmpNVFkwTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTTRNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1UUXhNRjlwYzNOMVpWOWllVjl3WVhKMGFYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjbDlpZVY5d2IzSjBhVzl1WDNKdmRYUmxRRE0xT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek56RUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFME1EQWdaWGgwWlc1a2N5QkJjbU14TmpRMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNemN4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgySjVYM0J2Y25ScGIyNEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNVFF4TUY5aGRYUm9iM0pwZW1WZmIzQmxjbUYwYjNKZllubGZjRzl5ZEdsdmJsOXliM1YwWlVBek5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNelU1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXdNQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREF3SUdWNGRHVnVaSE1nUVhKak1UWTBOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNMU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZWEpqTVRReE1GOWhkWFJvYjNKcGVtVmZiM0JsY21GMGIzSmZZbmxmY0c5eWRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI1ZmNtOTFkR1ZBTXpNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1EQXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UUXdNQ0JsZUhSbGJtUnpJRUZ5WXpFMk5EUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TnpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZekUwTVRCZlkyRnVYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2YmdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeE5ERXdYMjl3WlhKaGRHOXlYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2Ymw5eWIzVjBaVUF6TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UUTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRRd01DNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5EQXdJR1Y0ZEdWdVpITWdRWEpqTVRZME5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakUwTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNVFF4TUY5dmNHVnlZWFJ2Y2w5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNVFF4TUY5eVpYWnZhMlZmYjNCbGNtRjBiM0pmY205MWRHVkFNekU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTVRRd01DQmxlSFJsYm1SeklFRnlZekUyTkRRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNelVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTBNVEJmY21WMmIydGxYMjl3WlhKaGRHOXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekUwTVRCZllYVjBhRzl5YVhwbFgyOXdaWEpoZEc5eVgzSnZkWFJsUURNd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNamdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5EQXdMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6RTBNREFnWlhoMFpXNWtjeUJCY21NeE5qUTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRJNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU14TkRFd1gyRjFkR2h2Y21sNlpWOXZjR1Z5WVhSdmNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgzSnZkWFJsUURJNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5EQXdMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6RTBNREFnWlhoMFpXNWtjeUJCY21NeE5qUTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRFMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekUwTVRCZmNHRnlkR2wwYVc5dWMxOXZabDl5YjNWMFpVQXlPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU14TkRBd0lHVjRkR1Z1WkhNZ1FYSmpNVFkwTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXdOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1UUXhNRjl3WVhKMGFYUnBiMjV6WDI5bUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6RTBNVEJmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgzSnZkWFJsUURJM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzVNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1EQXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UUXdNQ0JsZUhSbGJtUnpJRUZ5WXpFMk5EUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem81TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNVFF4TUY5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNakF3WDNSeVlXNXpabVZ5WDNKdmRYUmxRREkyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTVRRd01DQmxlSFJsYm1SeklFRnlZekUyTkRRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1qQXdYM1J5WVc1elptVnlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekUwTVRCZlltRnNZVzVqWlY5dlpsOXdZWEowYVhScGIyNWZjbTkxZEdWQU1qVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXdNQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREF3SUdWNGRHVnVaSE1nUVhKak1UWTBOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU14TkRFd1gySmhiR0Z1WTJWZmIyWmZjR0Z5ZEdsMGFXOXVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekUxT1RSZmFYTmZhWE56ZFdGaWJHVmZjbTkxZEdWQU1qUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdGeVl6RTFPVFJmYVhOZmFYTnpkV0ZpYkdVS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UVTVORjkwY21GdWMyWmxjbDltY205dFgzZHBkR2hmWkdGMFlWOXliM1YwWlVBeU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5EQXdMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6RTBNREFnWlhoMFpXNWtjeUJCY21NeE5qUTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZekUxT1RSZmRISmhibk5tWlhKZlpuSnZiVjkzYVhSb1gyUmhkR0VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTVRVNU5GOTBjbUZ1YzJabGNsOTNhWFJvWDJSaGRHRmZjbTkxZEdWQU1qSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXdNQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREF3SUdWNGRHVnVaSE1nUVhKak1UWTBOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU14TlRrMFgzUnlZVzV6Wm1WeVgzZHBkR2hmWkdGMFlRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTXhOVGswWDNKbFpHVmxiVjl5YjNWMFpVQXlNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREF3TG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUwTURBZ1pYaDBaVzVrY3lCQmNtTXhOalEwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TlRrMExtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpFMU9UUmZjbVZrWldWdENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6RTFPVFJmY21Wa1pXVnRSbkp2YlY5eWIzVjBaVUF5TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TlRrMExtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpFME1EQWdaWGgwWlc1a2N5QkJjbU14TmpRMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZORFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6RTFPVFJmY21Wa1pXVnRSbkp2YlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeE5UazBYMmx6YzNWbFgzSnZkWFJsUURFNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1EQXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UUXdNQ0JsZUhSbGJtUnpJRUZ5WXpFMk5EUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNVFU1TkY5cGMzTjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU14TlRrMFgzTmxkRjlwYzNOMVlXSnNaVjl5YjNWMFpVQXhPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREF3TG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUwTURBZ1pYaDBaVzVrY3lCQmNtTXhOalEwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TlRrMExtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpFMU9UUmZjMlYwWDJsemMzVmhZbXhsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpFMk5ETmZaMlYwWDJGc2JGOWtiMk4xYldWdWRITmZjbTkxZEdWQU1UYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdGeVl6RTJORE5mWjJWMFgyRnNiRjlrYjJOMWJXVnVkSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTVRZME0xOXlaVzF2ZG1WZlpHOWpkVzFsYm5SZmNtOTFkR1ZBTVRZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRRd01DNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeE5EQXdJR1Y0ZEdWdVpITWdRWEpqTVRZME5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOalF6WDNKbGJXOTJaVjlrYjJOMWJXVnVkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU14TmpRelgyZGxkRjlrYjJOMWJXVnVkRjl5YjNWMFpVQXhOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREF3TG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZekUwTURBZ1pYaDBaVzVrY3lCQmNtTXhOalEwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpFMk5ETmZaMlYwWDJSdlkzVnRaVzUwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpFMk5ETmZjMlYwWDJSdlkzVnRaVzUwWDNKdmRYUmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTVRRd01DQmxlSFJsYm1SeklFRnlZekUyTkRRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1UWTBNMTl6WlhSZlpHOWpkVzFsYm5RS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UWTBORjlqYjI1MGNtOXNiR1Z5WDNKbFpHVmxiVjl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TVRVNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU14TkRBd0lHVjRkR1Z1WkhNZ1FYSmpNVFkwTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qRTFPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1UWTBORjlqYjI1MGNtOXNiR1Z5WDNKbFpHVmxiUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU14TmpRMFgyTnZiblJ5YjJ4c1pYSmZkSEpoYm5ObVpYSmZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPakV5TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNREF1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNVFF3TUNCbGVIUmxibVJ6SUVGeVl6RTJORFFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE1qUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpFMk5EUmZZMjl1ZEhKdmJHeGxjbDkwY21GdWMyWmxjZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU14TmpRMFgybHpYMk52Ym5SeWIyeHNZV0pzWlY5eWIzVjBaVUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk1URXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpFMk5EUmZhWE5mWTI5dWRISnZiR3hoWW14bENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6RTJORFJmYzJWMFgyMXBibDloWTNScGIyNWZhVzUwWlhKMllXeGZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPakV3TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNREF1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNVFF3TUNCbGVIUmxibVJ6SUVGeVl6RTJORFFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpFMk5EUmZjMlYwWDIxcGJsOWhZM1JwYjI1ZmFXNTBaWEoyWVd3S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UWTBORjl6WlhSZmNtVnhkV2x5WlY5cWRYTjBhV1pwWTJGMGFXOXVYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPams1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXdNQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREF3SUdWNGRHVnVaSE1nUVhKak1UWTBOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU14TmpRMFgzTmxkRjl5WlhGMWFYSmxYMnAxYzNScFptbGpZWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UWTBORjl6WlhSZlkyOXVkSEp2Ykd4aFlteGxYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXdNQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXhOREF3SUdWNGRHVnVaSE1nUVhKak1UWTBOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU14TmpRMFgzTmxkRjlqYjI1MGNtOXNiR0ZpYkdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1UWTBORjl6WlhSZlkyOXVkSEp2Ykd4bGNsOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1EQXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UUXdNQ0JsZUhSbGJtUnpJRUZ5WXpFMk5EUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORFF1WVd4bmJ5NTBjem8zTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNVFkwTkY5elpYUmZZMjl1ZEhKdmJHeGxjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWliMjkwYzNSeVlYQXhOREF3WDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pJMkxUTTJDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOXZkSE4wY21Gd01UUXdNQ2dLSUNBZ0lDOHZJQ0FnYm1GdFpUb2dSSGx1WVcxcFkwSjVkR1Z6TEFvZ0lDQWdMeThnSUNCemVXMWliMnc2SUVSNWJtRnRhV05DZVhSbGN5d0tJQ0FnSUM4dklDQWdaR1ZqYVcxaGJITTZJRlZwYm5ST09Dd0tJQ0FnSUM4dklDQWdkRzkwWVd4VGRYQndiSGs2SUZWcGJuUk9NalUyTEFvZ0lDQWdMeThnSUNCdmQyNWxjam9nUVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWTI5dWRISnZiR3hsY2pvZ1FXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1kyOXVkSEp2Ykd4aFlteGxPaUJDYjI5c0xBb2dJQ0FnTHk4Z0lDQnlaWEYxYVhKbFNuVnpkR2xtYVdOaGRHbHZiam9nUW05dmJDd0tJQ0FnSUM4dklDQWdiV2x1UTI5dWRISnZiR3hsY2tGamRHbHZia2x1ZEdWeWRtRnNPaUJWYVc1MFRqWTBMQW9nSUNBZ0x5OGdLVG9nUW05dmJDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5EQXdMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6RTBNREFnWlhoMFpXNWtjeUJCY21NeE5qUTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGdLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREF3TG1Gc1oyOHVkSE02TWpZdE16WUtJQ0FnSUM4dklIQjFZbXhwWXlCaWIyOTBjM1J5WVhBeE5EQXdLQW9nSUNBZ0x5OGdJQ0J1WVcxbE9pQkVlVzVoYldsalFubDBaWE1zQ2lBZ0lDQXZMeUFnSUhONWJXSnZiRG9nUkhsdVlXMXBZMEo1ZEdWekxBb2dJQ0FnTHk4Z0lDQmtaV05wYldGc2N6b2dWV2x1ZEU0NExBb2dJQ0FnTHk4Z0lDQjBiM1JoYkZOMWNIQnNlVG9nVldsdWRFNHlOVFlzQ2lBZ0lDQXZMeUFnSUc5M2JtVnlPaUJCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JqYjI1MGNtOXNiR1Z5T2lCQlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCamIyNTBjbTlzYkdGaWJHVTZJRUp2YjJ3c0NpQWdJQ0F2THlBZ0lISmxjWFZwY21WS2RYTjBhV1pwWTJGMGFXOXVPaUJDYjI5c0xBb2dJQ0FnTHk4Z0lDQnRhVzVEYjI1MGNtOXNiR1Z5UVdOMGFXOXVTVzUwWlhKMllXdzZJRlZwYm5ST05qUXNDaUFnSUNBdkx5QXBPaUJDYjI5c0lIc0tJQ0FnSUdOaGJHeHpkV0lnWW05dmRITjBjbUZ3TVRRd01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aWIyOTBjM1J5WVhCZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklHOTJaWEp5YVdSbElHSnZiM1J6ZEhKaGNDaHVZVzFsT2lCRWVXNWhiV2xqUW5sMFpYTXNJSE41YldKdmJEb2dSSGx1WVcxcFkwSjVkR1Z6TENCa1pXTnBiV0ZzY3pvZ1ZXbHVkRTQ0TENCMGIzUmhiRk4xY0hCc2VUb2dWV2x1ZEU0eU5UWXBPaUJDYjI5c0lIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1EQXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1UUXdNQ0JsZUhSbGJtUnpJRUZ5WXpFMk5EUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNREF1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnYjNabGNuSnBaR1VnWW05dmRITjBjbUZ3S0c1aGJXVTZJRVI1Ym1GdGFXTkNlWFJsY3l3Z2MzbHRZbTlzT2lCRWVXNWhiV2xqUW5sMFpYTXNJR1JsWTJsdFlXeHpPaUJWYVc1MFRqZ3NJSFJ2ZEdGc1UzVndjR3g1T2lCVmFXNTBUakkxTmlrNklFSnZiMndnZXdvZ0lDQWdZMkZzYkhOMVlpQmliMjkwYzNSeVlYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRFUzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTVRRd01DQmxlSFJsYm1SeklFRnlZekUyTkRRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUEyTVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmZjSFY1WVY5c2FXSXVZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWllWFJsWDJ4bGJtZDBhRjlvWldGa0tHRnljbUY1T2lCaWVYUmxjeXdnYm1WM1gybDBaVzF6WDJKNWRHVnpPaUJpZVhSbGN5d2dibVYzWDJsMFpXMXpYMk52ZFc1ME9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWW5wbGNtOEtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDZ3BrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5aWVYUmxYMnhsYm1kMGFGOW9aV0ZrWDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2daSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWW5sMFpWOXNaVzVuZEdoZmFHVmhaRjloWm5SbGNsOW1iM0pBTlFvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNCaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMko1ZEdWZmJHVnVaM1JvWDJobFlXUmZabTl5WDJobFlXUmxja0F5Q2dwa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWllWFJsWDJ4bGJtZDBhRjlvWldGa1gyRm1kR1Z5WDJadmNrQTFPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1EQXVZV3huYnk1MGN6bzZRWEpqTVRRd01DNWliMjkwYzNSeVlYQW9ibUZ0WlRvZ1lubDBaWE1zSUhONWJXSnZiRG9nWW5sMFpYTXNJR1JsWTJsdFlXeHpPaUJpZVhSbGN5d2dkRzkwWVd4VGRYQndiSGs2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWW05dmRITjBjbUZ3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2IzWmxjbkpwWkdVZ1ltOXZkSE4wY21Gd0tHNWhiV1U2SUVSNWJtRnRhV05DZVhSbGN5d2djM2x0WW05c09pQkVlVzVoYldsalFubDBaWE1zSUdSbFkybHRZV3h6T2lCVmFXNTBUamdzSUhSdmRHRnNVM1Z3Y0d4NU9pQlZhVzUwVGpJMU5pazZJRUp2YjJ3Z2V3b2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSWdQU0J1WlhjZ1FXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pveE15MHlNd29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WW05dmRITjBjbUZ3TVRRd01DZ0tJQ0FnSUM4dklDQWdibUZ0WlN3S0lDQWdJQzh2SUNBZ2MzbHRZbTlzTEFvZ0lDQWdMeThnSUNCa1pXTnBiV0ZzY3l3S0lDQWdJQzh2SUNBZ2RHOTBZV3hUZFhCd2JIa3NDaUFnSUNBdkx5QWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQnVaWGNnUW05dmJDaDBjblZsS1N3S0lDQWdJQzh2SUNBZ2JtVjNJRUp2YjJ3b2RISjFaU2tzQ2lBZ0lDQXZMeUFnSUc1bGR5QlZhVzUwVGpZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JrYVdjZ05Bb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCdVpYY2dRbTl2YkNoMGNuVmxLU3dLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGc0TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2JtVjNJRUp2YjJ3b2RISjFaU2tzQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREF3TG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUc1bGR5QlZhVzUwVGpZMEtEQXBMQW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXdNQzVoYkdkdkxuUnpPakV6TFRJekNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWliMjkwYzNSeVlYQXhOREF3S0FvZ0lDQWdMeThnSUNCdVlXMWxMQW9nSUNBZ0x5OGdJQ0J6ZVcxaWIyd3NDaUFnSUNBdkx5QWdJR1JsWTJsdFlXeHpMQW9nSUNBZ0x5OGdJQ0IwYjNSaGJGTjFjSEJzZVN3S0lDQWdJQzh2SUNBZ2MyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUc1bGR5QkNiMjlzS0hSeWRXVXBMQW9nSUNBZ0x5OGdJQ0J1WlhjZ1FtOXZiQ2gwY25WbEtTd0tJQ0FnSUM4dklDQWdibVYzSUZWcGJuUk9OalFvTUNrc0NpQWdJQ0F2THlBcENpQWdJQ0JqWVd4c2MzVmlJR0p2YjNSemRISmhjREUwTURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk9rRnlZekUwTURBdVltOXZkSE4wY21Gd01UUXdNQ2h1WVcxbE9pQmllWFJsY3l3Z2MzbHRZbTlzT2lCaWVYUmxjeXdnWkdWamFXMWhiSE02SUdKNWRHVnpMQ0IwYjNSaGJGTjFjSEJzZVRvZ1lubDBaWE1zSUc5M2JtVnlPaUJpZVhSbGN5d2dZMjl1ZEhKdmJHeGxjam9nWW5sMFpYTXNJR052Ym5SeWIyeHNZV0pzWlRvZ1lubDBaWE1zSUhKbGNYVnBjbVZLZFhOMGFXWnBZMkYwYVc5dU9pQmllWFJsY3l3Z2JXbHVRMjl1ZEhKdmJHeGxja0ZqZEdsdmJrbHVkR1Z5ZG1Gc09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtSnZiM1J6ZEhKaGNERTBNREE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pJMkxUTTJDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOXZkSE4wY21Gd01UUXdNQ2dLSUNBZ0lDOHZJQ0FnYm1GdFpUb2dSSGx1WVcxcFkwSjVkR1Z6TEFvZ0lDQWdMeThnSUNCemVXMWliMnc2SUVSNWJtRnRhV05DZVhSbGN5d0tJQ0FnSUM4dklDQWdaR1ZqYVcxaGJITTZJRlZwYm5ST09Dd0tJQ0FnSUM4dklDQWdkRzkwWVd4VGRYQndiSGs2SUZWcGJuUk9NalUyTEFvZ0lDQWdMeThnSUNCdmQyNWxjam9nUVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWTI5dWRISnZiR3hsY2pvZ1FXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1kyOXVkSEp2Ykd4aFlteGxPaUJDYjI5c0xBb2dJQ0FnTHk4Z0lDQnlaWEYxYVhKbFNuVnpkR2xtYVdOaGRHbHZiam9nUW05dmJDd0tJQ0FnSUM4dklDQWdiV2x1UTI5dWRISnZiR3hsY2tGamRHbHZia2x1ZEdWeWRtRnNPaUJWYVc1MFRqWTBMQW9nSUNBZ0x5OGdLVG9nUW05dmJDQjdDaUFnSUNCd2NtOTBieUE1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNc0lDZFBibXg1SUdSbGNHeHZlV1Z5SUc5bUlIUm9hWE1nYzIxaGNuUWdZMjl1ZEhKaFkzUWdZMkZ1SUdOaGJHd2dZbTl2ZEhOMGNtRndJRzFsZEdodlpDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCa1pYQnNiM2xsY2lCdlppQjBhR2x6SUhOdFlYSjBJR052Ym5SeVlXTjBJR05oYmlCallXeHNJR0p2YjNSemRISmhjQ0J0WlhSb2IyUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5EQXdMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVZVzFsTG01aGRHbDJaUzVzWlc1bmRHZ2dQaUF3TENBblRtRnRaU0J2WmlCMGFHVWdZWE56WlhRZ2JYVnpkQ0JpWlNCc2IyNW5aWElnYjNJZ1pYRjFZV3dnZEc4Z01TQmphR0Z5WVdOMFpYSW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDVDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJPWVcxbElHOW1JSFJvWlNCaGMzTmxkQ0J0ZFhOMElHSmxJR3h2Ym1kbGNpQnZjaUJsY1hWaGJDQjBieUF4SUdOb1lYSmhZM1JsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0c1aGJXVXVibUYwYVhabExteGxibWQwYUNBOFBTQXpNaXdnSjA1aGJXVWdiMllnZEdobElHRnpjMlYwSUcxMWMzUWdZbVVnYzJodmNuUmxjaUJ2Y2lCbGNYVmhiQ0IwYnlBek1pQmphR0Z5WVdOMFpYSnpKeWtLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCT1lXMWxJRzltSUhSb1pTQmhjM05sZENCdGRYTjBJR0psSUhOb2IzSjBaWElnYjNJZ1pYRjFZV3dnZEc4Z016SWdZMmhoY21GamRHVnljd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNREF1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnWVhOelpYSjBLSE41YldKdmJDNXVZWFJwZG1VdWJHVnVaM1JvSUQ0Z01Dd2dKMU41YldKdmJDQnZaaUIwYUdVZ1lYTnpaWFFnYlhWemRDQmlaU0JzYjI1blpYSWdiM0lnWlhGMVlXd2dkRzhnTVNCamFHRnlZV04wWlhJbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwNENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRlVzFpYjJ3Z2IyWWdkR2hsSUdGemMyVjBJRzExYzNRZ1ltVWdiRzl1WjJWeUlHOXlJR1Z4ZFdGc0lIUnZJREVnWTJoaGNtRmpkR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCaGMzTmxjblFvYzNsdFltOXNMbTVoZEdsMlpTNXNaVzVuZEdnZ1BEMGdPQ3dnSjFONWJXSnZiQ0J2WmlCMGFHVWdZWE56WlhRZ2JYVnpkQ0JpWlNCemFHOXlkR1Z5SUc5eUlHVnhkV0ZzSUhSdklEZ2dZMmhoY21GamRHVnljeWNwQ2lBZ0lDQndkWE5vYVc1MElEZ2dMeThnT0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRlVzFpYjJ3Z2IyWWdkR2hsSUdGemMyVjBJRzExYzNRZ1ltVWdjMmh2Y25SbGNpQnZjaUJsY1hWaGJDQjBieUE0SUdOb1lYSmhZM1JsY25NS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSdmRHRnNVM1Z3Y0d4NUlEMGdSMnh2WW1Gc1UzUmhkR1U4VldsdWRFNHlOVFkrS0hzZ2EyVjVPaUFuZENjZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1EQXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdZWE56WlhKMEtDRjBhR2x6TG5SdmRHRnNVM1Z3Y0d4NUxtaGhjMVpoYkhWbExDQW5WR2hwY3lCdFpYUm9iMlFnWTJGdUlHSmxJR05oYkd4bFpDQnZibXg1SUc5dVkyVW5LUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRlJvYVhNZ2JXVjBhRzlrSUdOaGJpQmlaU0JqWVd4c1pXUWdiMjVzZVNCdmJtTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXdNQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUIwYUdsekxtRnlZemc0WDJsdWFYUnBZV3hwZW1WZmIzZHVaWElvYm1WM0lFRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3BJQzh2SUhObGRDQjBhR1VnYjNkdVpYSWdZWFFnYzNSaGNuUWdkRzhnYVc1cGRHbGhiR2w2WlhJc0lHRjBJSFJvWlNCbGJtUWdZMmhoYm1kbElHbDBJSFJ2SUhSb1pTQnlaWEYxWlhOMFpXUWdiM2R1WlhJZ1puSnZiU0J3WVhKaGJXVjBaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWVhKak9EaGZhVzVwZEdsaGJHbDZaVjl2ZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QndkV0pzYVdNZ2JtRnRaU0E5SUVkc2IySmhiRk4wWVhSbFBFUjVibUZ0YVdOQ2VYUmxjejRvZXlCclpYazZJQ2R1SnlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1EQXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdkR2hwY3k1dVlXMWxMblpoYkhWbElEMGdibUZ0WlFvZ0lDQWdabkpoYldWZlpHbG5JQzA1Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCd2RXSnNhV01nYzNsdFltOXNJRDBnUjJ4dlltRnNVM1JoZEdVOFJIbHVZVzFwWTBKNWRHVnpQaWg3SUd0bGVUb2dKM01uSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5NaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRRd01DNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QjBhR2x6TG5ONWJXSnZiQzUyWVd4MVpTQTlJSE41YldKdmJBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QndkV0pzYVdNZ2RHOTBZV3hUZFhCd2JIa2dQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUakkxTmo0b2V5QnJaWGs2SUNkMEp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREF3TG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VGRYQndiSGt1ZG1Gc2RXVWdQU0IwYjNSaGJGTjFjSEJzZVFvZ0lDQWdabkpoYldWZlpHbG5JQzAyQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCd2RXSnNhV01nWkdWamFXMWhiSE1nUFNCSGJHOWlZV3hUZEdGMFpUeFZhVzUwVGpnK0tIc2dhMlY1T2lBblpDY2dmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREF3TG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUhSb2FYTXVaR1ZqYVcxaGJITXVkbUZzZFdVZ1BTQmtaV05wYldGc2N3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwM0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUxT1RSZmFYTnpkV0ZpYkdVZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrSnZiMncrS0hzZ2EyVjVPaUFuWVhKak1UVTVORjlwYzNNbklIMHBJQzh2SUZSeWRXVWdQU0JwYzNOMVlXSnNaUW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJbUZ5WXpFMU9UUmZhWE56SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2RHaHBjeTVoY21NeE5UazBYMmx6YzNWaFlteGxMblpoYkhWbElEMGdibVYzSUVKdmIyd29kSEoxWlNrS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnNE1Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5EQXdMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR052Ym5OMElITmxibVJsY2lBOUlHNWxkeUJCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSEIxWW14cFl5QmlZV3hoYm1ObGN5QTlJRUp2ZUUxaGNEeEJaR1J5WlhOekxDQlZhVzUwVGpJMU5qNG9leUJyWlhsUWNtVm1hWGc2SUNkaUp5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklIUm9hWE11WW1Gc1lXNWpaWE1vYzJWdVpHVnlLUzUyWVd4MVpTQTlJSFJ2ZEdGc1UzVndjR3g1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFlLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklHVnRhWFFvYm1WM0lHRnlZekl3TUY5VWNtRnVjMlpsY2loN0lHWnliMjA2SUc1bGR5QkJaR1J5WlhOektFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5a3NJSFJ2T2lCelpXNWtaWElzSUhaaGJIVmxPaUIwYjNSaGJGTjFjSEJzZVNCOUtTa0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRZS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNamdnTHk4Z2JXVjBhRzlrSUNKaGNtTXlNREJmVkhKaGJuTm1aWElvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5qUTBYMk52Ym5SeWIyeHNaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak1UWTBORjlqZEhKc0p5QjlLUW9nSUNBZ1lubDBaV01nT1NBdkx5QWlZWEpqTVRZME5GOWpkSEpzSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2RHaHBjeTVoY21NeE5qUTBYMk52Ym5SeWIyeHNaWEl1ZG1Gc2RXVWdQU0JqYjI1MGNtOXNiR1Z5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1UWTBORjlqYjI1MGNtOXNiR0ZpYkdVZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrSnZiMncrS0hzZ2EyVjVPaUFuWVhKak1UWTBORjlqZEhKc1pXNG5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0poY21NeE5qUTBYMk4wY214bGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5EQXdMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJSFJvYVhNdVlYSmpNVFkwTkY5amIyNTBjbTlzYkdGaWJHVXVkbUZzZFdVZ1BTQmpiMjUwY205c2JHRmliR1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5qUTBYM0psY1hWcGNtVktkWE4wYVdacFkyRjBhVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1Q2IyOXNQaWg3SUd0bGVUb2dKMkZ5WXpFMk5EUmZjbXAxYzNRbklIMHBDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QWlZWEpqTVRZME5GOXlhblZ6ZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklIUm9hWE11WVhKak1UWTBORjl5WlhGMWFYSmxTblZ6ZEdsbWFXTmhkR2x2Ymk1MllXeDFaU0E5SUhKbGNYVnBjbVZLZFhOMGFXWnBZMkYwYVc5dUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFkwTkY5c1lYTjBRMjl1ZEhKdmJHeGxja0ZqZEdsdmJsSnZkVzVrSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1VmFXNTBUalkwUGloN0lHdGxlVG9nSjJGeVl6RTJORFJmYkdOaGNpY2dmU2tnTHk4Z2IzQjBhVzl1WVd3Z2NtRjBaU0JzYVcxcGRDQjBjbUZqYTJsdVp3b2dJQ0FnWW5sMFpXTWdNVGtnTHk4Z0ltRnlZekUyTkRSZmJHTmhjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREF3TG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUhSb2FYTXVZWEpqTVRZME5GOXNZWE4wUTI5dWRISnZiR3hsY2tGamRHbHZibEp2ZFc1a0xuWmhiSFZsSUQwZ2JtVjNJRlZwYm5ST05qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5qUTBYMjFwYmtOdmJuUnliMnhzWlhKQlkzUnBiMjVKYm5SbGNuWmhiQ0E5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1VldsdWRFNDJORDRvZXlCclpYazZJQ2RoY21NeE5qUTBYMjFqWVdrbklIMHBDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlZWEpqTVRZME5GOXRZMkZwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTURBdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z2RHaHBjeTVoY21NeE5qUTBYMjFwYmtOdmJuUnliMnhzWlhKQlkzUnBiMjVKYm5SbGNuWmhiQzUyWVd4MVpTQTlJRzFwYmtOdmJuUnliMnhzWlhKQlkzUnBiMjVKYm5SbGNuWmhiQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNREF1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnYVdZZ0tGUjRiaTV6Wlc1a1pYSWdJVDA5SUc5M2JtVnlMbTVoZEdsMlpTa2dld29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0FoUFFvZ0lDQWdZbm9nWW05dmRITjBjbUZ3TVRRd01GOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRBd0xtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklIUm9hWE11WVhKak9EaGZkSEpoYm5ObVpYSmZiM2R1WlhKemFHbHdLRzkzYm1WeUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpnNFgzUnlZVzV6Wm1WeVgyOTNibVZ5YzJocGNBb0tZbTl2ZEhOMGNtRndNVFF3TUY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF3TUM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lFSnZiMndvZEhKMVpTa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZzRNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORFF1WVd4bmJ5NTBjem82UVhKak1UWTBOQzVmYjI1c2VVOTNibVZ5S0NrZ0xUNGdkbTlwWkRvS1gyOXViSGxQZDI1bGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUTBMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1GeVl6ZzRYMmx6WDI5M2JtVnlLRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtwTG01aGRHbDJaU0E5UFQwZ2RISjFaU3dnSjI5dWJIbGZiM2R1WlhJbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMkZzYkhOMVlpQmhjbU00T0Y5cGMxOXZkMjVsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlVjl2ZDI1bGNnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6bzZRWEpqTVRZME5DNWZiMjVzZVVOdmJuUnliMnhzWlhJb0tTQXRQaUIyYjJsa09ncGZiMjVzZVVOdmJuUnliMnhzWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFkwTkY5amIyNTBjbTlzYkdWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUJaR1J5WlhOelBpaDdJR3RsZVRvZ0oyRnlZekUyTkRSZlkzUnliQ2NnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0poY21NeE5qUTBYMk4wY213aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVoY21NeE5qUTBYMk52Ym5SeWIyeHNaWEl1YUdGelZtRnNkV1VzSUNkdWIxOWpiMjUwY205c2JHVnlKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIxOWpiMjUwY205c2JHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0E5UFQwZ2RHaHBjeTVoY21NeE5qUTBYMk52Ym5SeWIyeHNaWEl1ZG1Gc2RXVXNJQ2R1YjNSZlkyOXVkSEp2Ykd4bGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFkwTkY5amIyNTBjbTlzYkdWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUJaR1J5WlhOelBpaDdJR3RsZVRvZ0oyRnlZekUyTkRSZlkzUnliQ2NnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0poY21NeE5qUTBYMk4wY213aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMDlJSFJvYVhNdVlYSmpNVFkwTkY5amIyNTBjbTlzYkdWeUxuWmhiSFZsTENBbmJtOTBYMk52Ym5SeWIyeHNaWEluS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1JmWTI5dWRISnZiR3hsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6RTJORFJmWTI5dWRISnZiR3hoWW14bElEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUNiMjlzUGloN0lHdGxlVG9nSjJGeVl6RTJORFJmWTNSeWJHVnVKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUZ5WXpFMk5EUmZZM1J5YkdWdUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WVhKak1UWTBORjlqYjI1MGNtOXNiR0ZpYkdVdWFHRnpWbUZzZFdVZ0ppWWdkR2hwY3k1aGNtTXhOalEwWDJOdmJuUnliMnhzWVdKc1pTNTJZV3gxWlM1dVlYUnBkbVVnUFQwOUlIUnlkV1VzSUNkamIyNTBjbTlzYkdWeVgyUnBjMkZpYkdWa0p5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUY5dmJteDVRMjl1ZEhKdmJHeGxjbDlpYjI5c1gyWmhiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOalEwWDJOdmJuUnliMnhzWVdKc1pTQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRbTl2YkQ0b2V5QnJaWGs2SUNkaGNtTXhOalEwWDJOMGNteGxiaWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0poY21NeE5qUTBYMk4wY214bGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZWEpqTVRZME5GOWpiMjUwY205c2JHRmliR1V1YUdGelZtRnNkV1VnSmlZZ2RHaHBjeTVoY21NeE5qUTBYMk52Ym5SeWIyeHNZV0pzWlM1MllXeDFaUzV1WVhScGRtVWdQVDA5SUhSeWRXVXNJQ2RqYjI1MGNtOXNiR1Z5WDJScGMyRmliR1ZrSnlrS0lDQWdJR2RsZEdKcGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmllaUJmYjI1c2VVTnZiblJ5YjJ4c1pYSmZZbTl2YkY5bVlXeHpaVUF6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LWDI5dWJIbERiMjUwY205c2JHVnlYMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUZ5WXpFMk5EUmZZMjl1ZEhKdmJHeGhZbXhsTG1oaGMxWmhiSFZsSUNZbUlIUm9hWE11WVhKak1UWTBORjlqYjI1MGNtOXNiR0ZpYkdVdWRtRnNkV1V1Ym1GMGFYWmxJRDA5UFNCMGNuVmxMQ0FuWTI5dWRISnZiR3hsY2w5a2FYTmhZbXhsWkNjcENpQWdJQ0JoYzNObGNuUWdMeThnWTI5dWRISnZiR3hsY2w5a2FYTmhZbXhsWkFvZ0lDQWdjbVYwYzNWaUNncGZiMjVzZVVOdmJuUnliMnhzWlhKZlltOXZiRjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1gyOXViSGxEYjI1MGNtOXNiR1Z5WDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk9rRnlZekUyTkRRdVgyTm9aV05yU25WemRHbG1hV05oZEdsdmJpaHZjR1Z5WVhSdmNsOWtZWFJoT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWDJOb1pXTnJTblZ6ZEdsbWFXTmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklIQnliM1JsWTNSbFpDQmZZMmhsWTJ0S2RYTjBhV1pwWTJGMGFXOXVLRzl3WlhKaGRHOXlYMlJoZEdFNklHRnlZelF1UkhsdVlXMXBZMEo1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5qUTBYM0psY1hWcGNtVktkWE4wYVdacFkyRjBhVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1Q2IyOXNQaWg3SUd0bGVUb2dKMkZ5WXpFMk5EUmZjbXAxYzNRbklIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVGdnTHk4Z0ltRnlZekUyTkRSZmNtcDFjM1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCcFppQW9kR2hwY3k1aGNtTXhOalEwWDNKbGNYVnBjbVZLZFhOMGFXWnBZMkYwYVc5dUxtaGhjMVpoYkhWbElDWW1JSFJvYVhNdVlYSmpNVFkwTkY5eVpYRjFhWEpsU25WemRHbG1hV05oZEdsdmJpNTJZV3gxWlM1dVlYUnBkbVVnUFQwOUlIUnlkV1VwSUhzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJRjlqYUdWamEwcDFjM1JwWm1sallYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRZME5GOXlaWEYxYVhKbFNuVnpkR2xtYVdOaGRHbHZiaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UW05dmJENG9leUJyWlhrNklDZGhjbU14TmpRMFgzSnFkWE4wSnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTRJQzh2SUNKaGNtTXhOalEwWDNKcWRYTjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QnBaaUFvZEdocGN5NWhjbU14TmpRMFgzSmxjWFZwY21WS2RYTjBhV1pwWTJGMGFXOXVMbWhoYzFaaGJIVmxJQ1ltSUhSb2FYTXVZWEpqTVRZME5GOXlaWEYxYVhKbFNuVnpkR2xtYVdOaGRHbHZiaTUyWVd4MVpTNXVZWFJwZG1VZ1BUMDlJSFJ5ZFdVcElIc0tJQ0FnSUdkbGRHSnBkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JpZWlCZlkyaGxZMnRLZFhOMGFXWnBZMkYwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pvMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0c5d1pYSmhkRzl5WDJSaGRHRXVibUYwYVhabExteGxibWQwYUNBK0lEQXNJQ2RxZFhOMGFXWnBZMkYwYVc5dVgzSmxjWFZwY21Wa0p5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR3hsYmdvZ0lDQWdZWE56WlhKMElDOHZJR3AxYzNScFptbGpZWFJwYjI1ZmNtVnhkV2x5WldRS0NsOWphR1ZqYTBwMWMzUnBabWxqWVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6bzZRWEpqTVRZME5DNWZjbUYwWlV4cGJXbDBLQ2tnTFQ0Z2RtOXBaRG9LWDNKaGRHVk1hVzFwZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOalEwWDIxcGJrTnZiblJ5YjJ4c1pYSkJZM1JwYjI1SmJuUmxjblpoYkNBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVZXbHVkRTQyTkQ0b2V5QnJaWGs2SUNkaGNtTXhOalEwWDIxallXa25JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdJbUZ5WXpFMk5EUmZiV05oYVNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklIUm9hWE11WVhKak1UWTBORjl0YVc1RGIyNTBjbTlzYkdWeVFXTjBhVzl1U1c1MFpYSjJZV3d1YUdGelZtRnNkV1VnSmlZS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TmpBdE5qRUtJQ0FnSUM4dklIUm9hWE11WVhKak1UWTBORjl0YVc1RGIyNTBjbTlzYkdWeVFXTjBhVzl1U1c1MFpYSjJZV3d1YUdGelZtRnNkV1VnSmlZS0lDQWdJQzh2SUhSb2FYTXVZWEpqTVRZME5GOXRhVzVEYjI1MGNtOXNiR1Z5UVdOMGFXOXVTVzUwWlhKMllXd3VkbUZzZFdVdWJtRjBhWFpsSUQ0Z01HNEtJQ0FnSUdKNklGOXlZWFJsVEdsdGFYUmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFkwTkY5dGFXNURiMjUwY205c2JHVnlRV04wYVc5dVNXNTBaWEoyWVd3Z1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExsVnBiblJPTmpRK0tIc2dhMlY1T2lBbllYSmpNVFkwTkY5dFkyRnBKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0poY21NeE5qUTBYMjFqWVdraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2RHaHBjeTVoY21NeE5qUTBYMjFwYmtOdmJuUnliMnhzWlhKQlkzUnBiMjVKYm5SbGNuWmhiQzUyWVd4MVpTNXVZWFJwZG1VZ1BpQXdiZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORFF1WVd4bmJ5NTBjem8yTUMwMk1Rb2dJQ0FnTHk4Z2RHaHBjeTVoY21NeE5qUTBYMjFwYmtOdmJuUnliMnhzWlhKQlkzUnBiMjVKYm5SbGNuWmhiQzVvWVhOV1lXeDFaU0FtSmdvZ0lDQWdMeThnZEdocGN5NWhjbU14TmpRMFgyMXBia052Ym5SeWIyeHNaWEpCWTNScGIyNUpiblJsY25aaGJDNTJZV3gxWlM1dVlYUnBkbVVnUGlBd2Jnb2dJQ0FnWW5vZ1gzSmhkR1ZNYVcxcGRGOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOalEwWDJ4aGMzUkRiMjUwY205c2JHVnlRV04wYVc5dVVtOTFibVFnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGxWcGJuUk9OalErS0hzZ2EyVjVPaUFuWVhKak1UWTBORjlzWTJGeUp5QjlLU0F2THlCdmNIUnBiMjVoYkNCeVlYUmxJR3hwYldsMElIUnlZV05yYVc1bkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01Ua2dMeThnSW1GeVl6RTJORFJmYkdOaGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUTBMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJR2xtSUNoMGFHbHpMbUZ5WXpFMk5EUmZiR0Z6ZEVOdmJuUnliMnhzWlhKQlkzUnBiMjVTYjNWdVpDNW9ZWE5XWVd4MVpTa2dld29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1gzSmhkR1ZNYVcxcGRGOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOalEwWDJ4aGMzUkRiMjUwY205c2JHVnlRV04wYVc5dVVtOTFibVFnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGxWcGJuUk9OalErS0hzZ2EyVjVPaUFuWVhKak1UWTBORjlzWTJGeUp5QjlLU0F2THlCdmNIUnBiMjVoYkNCeVlYUmxJR3hwYldsMElIUnlZV05yYVc1bkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01Ua2dMeThnSW1GeVl6RTJORFJmYkdOaGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QmpiMjV6ZENCc1lYTjBJRDBnZEdocGN5NWhjbU14TmpRMFgyeGhjM1JEYjI1MGNtOXNiR1Z5UVdOMGFXOXVVbTkxYm1RdWRtRnNkV1V1Ym1GMGFYWmxDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRZME5GOXRhVzVEYjI1MGNtOXNiR1Z5UVdOMGFXOXVTVzUwWlhKMllXd2dQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMbFZwYm5ST05qUStLSHNnYTJWNU9pQW5ZWEpqTVRZME5GOXRZMkZwSnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKaGNtTXhOalEwWDIxallXa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdZMjl1YzNRZ2JXbHVSMkZ3SUQwZ2RHaHBjeTVoY21NeE5qUTBYMjFwYmtOdmJuUnliMnhzWlhKQlkzUnBiMjVKYm5SbGNuWmhiQzUyWVd4MVpTNXVZWFJwZG1VS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHTnZibk4wSUdOMWNuSmxiblFnUFNCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0Vkc2IySmhiQzV5YjNWdVpDa3VibUYwYVhabENpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklHRnpjMlZ5ZENoamRYSnlaVzUwSUQ0OUlHeGhjM1FnS3lCdGFXNUhZWEFzSUNkeVlYUmxYMnhwYldsMFpXUW5LUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCeVlYUmxYMnhwYldsMFpXUUtDbDl5WVhSbFRHbHRhWFJmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORFF1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnZEdocGN5NWhjbU14TmpRMFgyeGhjM1JEYjI1MGNtOXNiR1Z5UVdOMGFXOXVVbTkxYm1RdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0Vkc2IySmhiQzV5YjNWdVpDa0tJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUyTkRSZmJHRnpkRU52Ym5SeWIyeHNaWEpCWTNScGIyNVNiM1Z1WkNBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVZXbHVkRTQyTkQ0b2V5QnJaWGs2SUNkaGNtTXhOalEwWDJ4allYSW5JSDBwSUM4dklHOXdkR2x2Ym1Gc0lISmhkR1VnYkdsdGFYUWdkSEpoWTJ0cGJtY0tJQ0FnSUdKNWRHVmpJREU1SUM4dklDSmhjbU14TmpRMFgyeGpZWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCMGFHbHpMbUZ5WXpFMk5EUmZiR0Z6ZEVOdmJuUnliMnhzWlhKQlkzUnBiMjVTYjNWdVpDNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTmpRb1IyeHZZbUZzTG5KdmRXNWtLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ2w5eVlYUmxUR2x0YVhSZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pvNlFYSmpNVFkwTkM1aGNtTXhOalEwWDNObGRGOWpiMjUwY205c2JHVnlLRzVsZDE5amIyNTBjbTlzYkdWeU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1lYSmpNVFkwTkY5elpYUmZZMjl1ZEhKdmJHeGxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TnpRdE56VUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1UWTBORjl6WlhSZlkyOXVkSEp2Ykd4bGNpaHVaWGRmWTI5dWRISnZiR3hsY2pvZ1lYSmpOQzVCWkdSeVpYTnpLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCMGFHbHpMbDl2Ym14NVQzZHVaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQmZiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRZME5GOWpiMjUwY205c2JHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpFMk5EUmZZM1J5YkNjZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKaGNtTXhOalEwWDJOMGNtd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPamMzQ2lBZ0lDQXZMeUJqYjI1emRDQnZiR1FnUFNCMGFHbHpMbUZ5WXpFMk5EUmZZMjl1ZEhKdmJHeGxjaTVvWVhOV1lXeDFaU0EvSUhSb2FYTXVZWEpqTVRZME5GOWpiMjUwY205c2JHVnlMblpoYkhWbElEb2dibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCaGNtTXhOalEwWDNObGRGOWpiMjUwY205c2JHVnlYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUyTkRSZlkyOXVkSEp2Ykd4bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRV1JrY21WemN6NG9leUJyWlhrNklDZGhjbU14TmpRMFgyTjBjbXduSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpWVhKak1UWTBORjlqZEhKc0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvS1lYSmpNVFkwTkY5elpYUmZZMjl1ZEhKdmJHeGxjbDkwWlhKdVlYSjVYMjFsY21kbFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRZME5GOWpiMjUwY205c2JHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpFMk5EUmZZM1J5YkNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltRnlZekUyTkRSZlkzUnliQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUhSb2FYTXVZWEpqTVRZME5GOWpiMjUwY205c2JHVnlMblpoYkhWbElEMGdibVYzWDJOdmJuUnliMnhzWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOalEwWDJOdmJuUnliMnhzWVdKc1pTQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRbTl2YkQ0b2V5QnJaWGs2SUNkaGNtTXhOalEwWDJOMGNteGxiaWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0poY21NeE5qUTBYMk4wY214bGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUTBMbUZzWjI4dWRITTZOemtLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTVoY21NeE5qUTBYMk52Ym5SeWIyeHNZV0pzWlM1b1lYTldZV3gxWlNrZ2V3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdGeVl6RTJORFJmYzJWMFgyTnZiblJ5YjJ4c1pYSmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFkwTkY5amIyNTBjbTlzYkdGaWJHVWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0p2YjJ3K0tIc2dhMlY1T2lBbllYSmpNVFkwTkY5amRISnNaVzRuSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaGNtTXhOalEwWDJOMGNteGxiaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSb2FYTXVZWEpqTVRZME5GOWpiMjUwY205c2JHRmliR1V1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVDYjI5c0tIUnlkV1VwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0T0RBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncGhjbU14TmpRMFgzTmxkRjlqYjI1MGNtOXNiR1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02T0RJS0lDQWdJQzh2SUdWdGFYUW9KME52Ym5SeWIyeHNaWEpEYUdGdVoyVmtKeXdnYm1WM0lHRnlZekUyTkRSZlkyOXVkSEp2Ykd4bGNsOWphR0Z1WjJWa1gyVjJaVzUwS0hzZ2IyeGtMQ0J1WlhVNklHNWxkMTlqYjI1MGNtOXNiR1Z5SUgwcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnME1EbGpZelUzTUNBdkx5QnRaWFJvYjJRZ0lrTnZiblJ5YjJ4c1pYSkRhR0Z1WjJWa0tDaGhaR1J5WlhOekxHRmtaSEpsYzNNcEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ21GeVl6RTJORFJmYzJWMFgyTnZiblJ5YjJ4c1pYSmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6bzNOd29nSUNBZ0x5OGdZMjl1YzNRZ2IyeGtJRDBnZEdocGN5NWhjbU14TmpRMFgyTnZiblJ5YjJ4c1pYSXVhR0Z6Vm1Gc2RXVWdQeUIwYUdsekxtRnlZekUyTkRSZlkyOXVkSEp2Ykd4bGNpNTJZV3gxWlNBNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZaUJoY21NeE5qUTBYM05sZEY5amIyNTBjbTlzYkdWeVgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02T2tGeVl6RTJORFF1WVhKak1UWTBORjl6WlhSZlkyOXVkSEp2Ykd4aFlteGxLR1pzWVdjNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwaGNtTXhOalEwWDNObGRGOWpiMjUwY205c2JHRmliR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pnMUxUZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6RTJORFJmYzJWMFgyTnZiblJ5YjJ4c1lXSnNaU2htYkdGbk9pQmhjbU0wTGtKdmIyd3BPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z2RHaHBjeTVmYjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdYMjl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORFF1WVd4bmJ5NTBjem80T1FvZ0lDQWdMeThnYVdZZ0tHWnNZV2N1Ym1GMGFYWmxJRDA5UFNCbVlXeHpaU2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmlibm9nWVhKak1UWTBORjl6WlhSZlkyOXVkSEp2Ykd4aFlteGxYMlZzYzJWZlltOWtlVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1UWTBORjlqYjI1MGNtOXNiR0ZpYkdVZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrSnZiMncrS0hzZ2EyVjVPaUFuWVhKak1UWTBORjlqZEhKc1pXNG5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0poY21NeE5qUTBYMk4wY214bGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUTBMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJSFJvYVhNdVlYSmpNVFkwTkY5amIyNTBjbTlzYkdGaWJHVXVkbUZzZFdVZ1BTQm1iR0ZuQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwaGNtTXhOalEwWDNObGRGOWpiMjUwY205c2JHRmliR1ZmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ2NtVjBjM1ZpQ2dwaGNtTXhOalEwWDNObGRGOWpiMjUwY205c2JHRmliR1ZmWld4elpWOWliMlI1UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFkwTkY5amIyNTBjbTlzYkdGaWJHVWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0p2YjJ3K0tIc2dhMlY1T2lBbllYSmpNVFkwTkY5amRISnNaVzRuSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWVhKak1UWTBORjlqZEhKc1pXNGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPamt6Q2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11WVhKak1UWTBORjlqYjI1MGNtOXNiR0ZpYkdVdWFHRnpWbUZzZFdVZ2ZId2dkR2hwY3k1aGNtTXhOalEwWDJOdmJuUnliMnhzWVdKc1pTNTJZV3gxWlM1dVlYUnBkbVVnUFQwOUlIUnlkV1VwSUhzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJR0Z5WXpFMk5EUmZjMlYwWDJOdmJuUnliMnhzWVdKc1pWOXBabDlpYjJSNVFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUTBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TmpRMFgyTnZiblJ5YjJ4c1lXSnNaU0E5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UW05dmJENG9leUJyWlhrNklDZGhjbU14TmpRMFgyTjBjbXhsYmljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaGNtTXhOalEwWDJOMGNteGxiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6bzVNd29nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbUZ5WXpFMk5EUmZZMjl1ZEhKdmJHeGhZbXhsTG1oaGMxWmhiSFZsSUh4OElIUm9hWE11WVhKak1UWTBORjlqYjI1MGNtOXNiR0ZpYkdVdWRtRnNkV1V1Ym1GMGFYWmxJRDA5UFNCMGNuVmxLU0I3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZWEpqTVRZME5GOXpaWFJmWTI5dWRISnZiR3hoWW14bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvS1lYSmpNVFkwTkY5elpYUmZZMjl1ZEhKdmJHeGhZbXhsWDJsbVgySnZaSGxBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOalEwWDJOdmJuUnliMnhzWVdKc1pTQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRbTl2YkQ0b2V5QnJaWGs2SUNkaGNtTXhOalEwWDJOMGNteGxiaWNnZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1GeVl6RTJORFJmWTNSeWJHVnVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORFF1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnZEdocGN5NWhjbU14TmpRMFgyTnZiblJ5YjJ4c1lXSnNaUzUyWVd4MVpTQTlJR1pzWVdjS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk9rRnlZekUyTkRRdVlYSmpNVFkwTkY5elpYUmZjbVZ4ZFdseVpWOXFkWE4wYVdacFkyRjBhVzl1S0dac1lXYzZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGhjbU14TmpRMFgzTmxkRjl5WlhGMWFYSmxYMnAxYzNScFptbGpZWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qazVMVEV3TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TmpRMFgzTmxkRjl5WlhGMWFYSmxYMnAxYzNScFptbGpZWFJwYjI0b1pteGhaem9nWVhKak5DNUNiMjlzS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUTBMbUZzWjI4dWRITTZNVEF4Q2lBZ0lDQXZMeUIwYUdsekxsOXZibXg1VDNkdVpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCZmIyNXNlVTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFkwTkY5eVpYRjFhWEpsU25WemRHbG1hV05oZEdsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRbTl2YkQ0b2V5QnJaWGs2SUNkaGNtTXhOalEwWDNKcWRYTjBKeUI5S1FvZ0lDQWdZbmwwWldNZ01UZ2dMeThnSW1GeVl6RTJORFJmY21wMWMzUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnZEdocGN5NWhjbU14TmpRMFgzSmxjWFZwY21WS2RYTjBhV1pwWTJGMGFXOXVMblpoYkhWbElEMGdabXhoWndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pvNlFYSmpNVFkwTkM1aGNtTXhOalEwWDNObGRGOXRhVzVmWVdOMGFXOXVYMmx1ZEdWeWRtRnNLR2x1ZEdWeWRtRnNPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZWEpqTVRZME5GOXpaWFJmYldsdVgyRmpkR2x2Ymw5cGJuUmxjblpoYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk1UQTFMVEV3TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TmpRMFgzTmxkRjl0YVc1ZllXTjBhVzl1WDJsdWRHVnlkbUZzS0dsdWRHVnlkbUZzT2lCaGNtTTBMbFZwYm5ST05qUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklIUm9hWE11WDI5dWJIbFBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRjl2Ym14NVQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5qUTBYMjFwYmtOdmJuUnliMnhzWlhKQlkzUnBiMjVKYm5SbGNuWmhiQ0E5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1VldsdWRFNDJORDRvZXlCclpYazZJQ2RoY21NeE5qUTBYMjFqWVdrbklIMHBDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlZWEpqTVRZME5GOXRZMkZwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE1EZ0tJQ0FnSUM4dklIUm9hWE11WVhKak1UWTBORjl0YVc1RGIyNTBjbTlzYkdWeVFXTjBhVzl1U1c1MFpYSjJZV3d1ZG1Gc2RXVWdQU0JwYm5SbGNuWmhiQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORFF1WVd4bmJ5NTBjem82UVhKak1UWTBOQzVoY21NeE5qUTBYMmx6WDJOdmJuUnliMnhzWVdKc1pTZ3BJQzArSUdKNWRHVnpPZ3BoY21NeE5qUTBYMmx6WDJOdmJuUnliMnhzWVdKc1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUTBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TmpRMFgyTnZiblJ5YjJ4c1lXSnNaU0E5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UW05dmJENG9leUJyWlhrNklDZGhjbU14TmpRMFgyTjBjbXhsYmljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaGNtTXhOalEwWDJOMGNteGxiaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCMGFHbHpMbUZ5WXpFMk5EUmZZMjl1ZEhKdmJHeGhZbXhsTG1oaGMxWmhiSFZsSUNZbUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pFeE5TMHhNVFlLSUNBZ0lDOHZJSFJvYVhNdVlYSmpNVFkwTkY5amIyNTBjbTlzYkdGaWJHVXVhR0Z6Vm1Gc2RXVWdKaVlLSUNBZ0lDOHZJSFJvYVhNdVlYSmpNVFkwTkY5amIyNTBjbTlzYkdGaWJHVXVkbUZzZFdVdWJtRjBhWFpsSUQwOVBTQjBjblZsSUNZbUNpQWdJQ0JpZWlCaGNtTXhOalEwWDJselgyTnZiblJ5YjJ4c1lXSnNaVjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUTBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TmpRMFgyTnZiblJ5YjJ4c1lXSnNaU0E5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UW05dmJENG9leUJyWlhrNklDZGhjbU14TmpRMFgyTjBjbXhsYmljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaGNtTXhOalEwWDJOMGNteGxiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6b3hNVFlLSUNBZ0lDOHZJSFJvYVhNdVlYSmpNVFkwTkY5amIyNTBjbTlzYkdGaWJHVXVkbUZzZFdVdWJtRjBhWFpsSUQwOVBTQjBjblZsSUNZbUNpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE1UVXRNVEUyQ2lBZ0lDQXZMeUIwYUdsekxtRnlZekUyTkRSZlkyOXVkSEp2Ykd4aFlteGxMbWhoYzFaaGJIVmxJQ1ltQ2lBZ0lDQXZMeUIwYUdsekxtRnlZekUyTkRSZlkyOXVkSEp2Ykd4aFlteGxMblpoYkhWbExtNWhkR2wyWlNBOVBUMGdkSEoxWlNBbUpnb2dJQ0FnWW5vZ1lYSmpNVFkwTkY5cGMxOWpiMjUwY205c2JHRmliR1ZmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRZME5GOWpiMjUwY205c2JHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpFMk5EUmZZM1J5YkNjZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKaGNtTXhOalEwWDJOMGNtd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPakV4TndvZ0lDQWdMeThnZEdocGN5NWhjbU14TmpRMFgyTnZiblJ5YjJ4c1pYSXVhR0Z6Vm1Gc2RXVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk1URTFMVEV4TndvZ0lDQWdMeThnZEdocGN5NWhjbU14TmpRMFgyTnZiblJ5YjJ4c1lXSnNaUzVvWVhOV1lXeDFaU0FtSmdvZ0lDQWdMeThnZEdocGN5NWhjbU14TmpRMFgyTnZiblJ5YjJ4c1lXSnNaUzUyWVd4MVpTNXVZWFJwZG1VZ1BUMDlJSFJ5ZFdVZ0ppWUtJQ0FnSUM4dklIUm9hWE11WVhKak1UWTBORjlqYjI1MGNtOXNiR1Z5TG1oaGMxWmhiSFZsQ2lBZ0lDQmllaUJoY21NeE5qUTBYMmx6WDJOdmJuUnliMnhzWVdKc1pWOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNneGJpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJSEpsZEhOMVlnb0tZWEpqTVRZME5GOXBjMTlqYjI1MGNtOXNiR0ZpYkdWZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE1qRUtJQ0FnSUM4dklISmxkSFZ5YmlCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RCdUtRb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qcEJjbU14TmpRMExtRnlZekUyTkRSZlkyOXVkSEp2Ykd4bGNsOTBjbUZ1YzJabGNpaG1jbTl0T2lCaWVYUmxjeXdnZEc4NklHSjVkR1Z6TENCaGJXOTFiblE2SUdKNWRHVnpMQ0JrWVhSaE9pQmllWFJsY3l3Z2IzQmxjbUYwYjNKZlpHRjBZVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BoY21NeE5qUTBYMk52Ym5SeWIyeHNaWEpmZEhKaGJuTm1aWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pFeU5DMHhNekVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFkwTkY5amIyNTBjbTlzYkdWeVgzUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQm1jbTl0T2lCaGNtTTBMa0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJSFJ2T2lCaGNtTTBMa0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dZWEpqTkM1VmFXNTBUakkxTml3S0lDQWdJQzh2SUNBZ1pHRjBZVG9nWVhKak5DNUVlVzVoYldsalFubDBaWE1zQ2lBZ0lDQXZMeUFnSUc5d1pYSmhkRzl5WDJSaGRHRTZJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpMQW9nSUNBZ0x5OGdLVG9nWVhKak5DNVZhVzUwVGpZMElIc0tJQ0FnSUhCeWIzUnZJRFVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE16SUtJQ0FnSUM4dklIUm9hWE11WDI5dWJIbERiMjUwY205c2JHVnlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyOXViSGxEYjI1MGNtOXNiR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pFek13b2dJQ0FnTHk4Z2RHaHBjeTVmWTJobFkydEtkWE4wYVdacFkyRjBhVzl1S0c5d1pYSmhkRzl5WDJSaGRHRXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJTblZ6ZEdsbWFXTmhkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE16UUtJQ0FnSUM4dklIUm9hWE11WDNKaGRHVk1hVzFwZENncENpQWdJQ0JqWVd4c2MzVmlJRjl5WVhSbFRHbHRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TVRNMkNpQWdJQ0F2THlCaGMzTmxjblFvWm5KdmJTQWhQVDBnZEc4c0lDZHpZVzFsWDJGa1pISW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnYzJGdFpWOWhaR1J5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pFek53b2dJQ0FnTHk4Z1kyOXVjM1FnWm5KdmJVSmhiQ0E5SUhSb2FYTXVYMkpoYkdGdVkyVlBaaWhtY205dEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JqWVd4c2MzVmlJRjlpWVd4aGJtTmxUMllLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TVRNNENpQWdJQ0F2THlCaGMzTmxjblFvWm5KdmJVSmhiQzV1WVhScGRtVWdQajBnWVcxdmRXNTBMbTVoZEdsMlpTd2dKMmx1YzNWbVptbGphV1Z1ZENjcENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzV6ZFdabWFXTnBaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pFME1Bb2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWhtY205dEtTNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTWpVMktHWnliMjFDWVd3dWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lpMEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWZBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QndkV0pzYVdNZ1ltRnNZVzVqWlhNZ1BTQkNiM2hOWVhBOFFXUmtjbVZ6Y3l3Z1ZXbHVkRTR5TlRZK0tIc2dhMlY1VUhKbFptbDRPaUFuWWljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORFF1WVd4bmJ5NTBjem94TkRBS0lDQWdJQzh2SUhSb2FYTXVZbUZzWVc1alpYTW9abkp2YlNrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmlobWNtOXRRbUZzTG01aGRHbDJaU0F0SUdGdGIzVnVkQzV1WVhScGRtVXBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pFME1Rb2dJQ0FnTHk4Z1kyOXVjM1FnZEc5Q1lXd2dQU0IwYUdsekxsOWlZV3hoYm1ObFQyWW9kRzhwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTmhiR3h6ZFdJZ1gySmhiR0Z1WTJWUFpnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6b3hORElLSUNBZ0lDOHZJSFJvYVhNdVltRnNZVzVqWlhNb2RHOHBMblpoYkhWbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0eU5UWW9kRzlDWVd3dWJtRjBhWFpsSUNzZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lpc0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdKOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklIQjFZbXhwWXlCaVlXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlpHUnlaWE56TENCVmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RpSnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPakUwTWdvZ0lDQWdMeThnZEdocGN5NWlZV3hoYm1ObGN5aDBieWt1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWgwYjBKaGJDNXVZWFJwZG1VZ0t5QmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5EUXVZV3huYnk1MGN6b3hORGNLSUNBZ0lDOHZJR052Ym5SeWIyeHNaWEk2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pFME5pMHhOVFFLSUNBZ0lDOHZJRzVsZHlCaGNtTXhOalEwWDJOdmJuUnliMnhzWlhKZmRISmhibk5tWlhKZlpYWmxiblFvZXdvZ0lDQWdMeThnSUNCamIyNTBjbTlzYkdWeU9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0JtY205dExBb2dJQ0FnTHk4Z0lDQjBieXdLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0JqYjJSbExBb2dJQ0FnTHk4Z0lDQmtZWFJoTEFvZ0lDQWdMeThnSUNCdmNHVnlZWFJ2Y2w5a1lYUmhMQW9nSUNBZ0x5OGdmU2tzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QmpiMjV6ZENCRFQwUkZYMU5WUTBORlUxTWdQU0J1WlhjZ1lYSmpOQzVDZVhSbEtEQjROVEVwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE5EWXRNVFUwQ2lBZ0lDQXZMeUJ1WlhjZ1lYSmpNVFkwTkY5amIyNTBjbTlzYkdWeVgzUnlZVzV6Wm1WeVgyVjJaVzUwS0hzS0lDQWdJQzh2SUNBZ1kyOXVkSEp2Ykd4bGNqb2dibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnWm5KdmJTd0tJQ0FnSUM4dklDQWdkRzhzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWTI5a1pTd0tJQ0FnSUM4dklDQWdaR0YwWVN3S0lDQWdJQzh2SUNBZ2IzQmxjbUYwYjNKZlpHRjBZU3dLSUNBZ0lDOHZJSDBwTEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EZzFDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFek15QXZMeUF4TXpNS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE5EUXRNVFUxQ2lBZ0lDQXZMeUJsYldsMEtBb2dJQ0FnTHk4Z0lDQW5RMjl1ZEhKdmJHeGxjbFJ5WVc1elptVnlKeXdLSUNBZ0lDOHZJQ0FnYm1WM0lHRnlZekUyTkRSZlkyOXVkSEp2Ykd4bGNsOTBjbUZ1YzJabGNsOWxkbVZ1ZENoN0NpQWdJQ0F2THlBZ0lDQWdZMjl1ZEhKdmJHeGxjam9nYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQm1jbTl0TEFvZ0lDQWdMeThnSUNBZ0lIUnZMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCamIyUmxMQW9nSUNBZ0x5OGdJQ0FnSUdSaGRHRXNDaUFnSUNBdkx5QWdJQ0FnYjNCbGNtRjBiM0pmWkdGMFlTd0tJQ0FnSUM4dklDQWdmU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pORFpsWVRjNU5TQXZMeUJ0WlhSb2IyUWdJa052Ym5SeWIyeHNaWEpVY21GdWMyWmxjaWdvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5peGllWFJsTEdKNWRHVmJYU3hpZVhSbFcxMHBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pFMU5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvWTI5a1pTNXVZWFJwZG1VcENpQWdJQ0J3ZFhOb2FXNTBJRGd4SUM4dklEZ3hDaUFnSUNCcGRHOWlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBOQzVoYkdkdkxuUnpPanBCY21NeE5qUTBMbUZ5WXpFMk5EUmZZMjl1ZEhKdmJHeGxjbDl5WldSbFpXMG9abkp2YlRvZ1lubDBaWE1zSUdGdGIzVnVkRG9nWW5sMFpYTXNJRzl3WlhKaGRHOXlYMlJoZEdFNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1lYSmpNVFkwTkY5amIyNTBjbTlzYkdWeVgzSmxaR1ZsYlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk1UVTVMVEUyTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TmpRMFgyTnZiblJ5YjJ4c1pYSmZjbVZrWldWdEtBb2dJQ0FnTHk4Z0lDQm1jbTl0T2lCaGNtTTBMa0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dZWEpqTkM1VmFXNTBUakkxTml3S0lDQWdJQzh2SUNBZ2IzQmxjbUYwYjNKZlpHRjBZVG9nWVhKak5DNUVlVzVoYldsalFubDBaWE1zQ2lBZ0lDQXZMeUFwT2lCaGNtTTBMbFZwYm5ST05qUWdld29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qRTJOUW9nSUNBZ0x5OGdkR2hwY3k1ZmIyNXNlVU52Ym5SeWIyeHNaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQmZiMjVzZVVOdmJuUnliMnhzWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk1UWTJDaUFnSUNBdkx5QjBhR2x6TGw5amFHVmphMHAxYzNScFptbGpZWFJwYjI0b2IzQmxjbUYwYjNKZlpHRjBZU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCZlkyaGxZMnRLZFhOMGFXWnBZMkYwYVc5dUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qRTJOd29nSUNBZ0x5OGdkR2hwY3k1ZmNtRjBaVXhwYldsMEtDa0tJQ0FnSUdOaGJHeHpkV0lnWDNKaGRHVk1hVzFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE5qZ0tJQ0FnSUM4dklHTnZibk4wSUdaeWIyMUNZV3dnUFNCMGFHbHpMbDlpWVd4aGJtTmxUMllvWm5KdmJTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTJGc2JITjFZaUJmWW1Gc1lXNWpaVTltQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pFMk9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0daeWIyMUNZV3d1Ym1GMGFYWmxJRDQ5SUdGdGIzVnVkQzV1WVhScGRtVXNJQ2RwYm5OMVptWnBZMmxsYm5RbktRb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0krUFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1YzNWbVptbGphV1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE56QUtJQ0FnSUM4dklIUm9hWE11WW1Gc1lXNWpaWE1vWm5KdmJTa3VkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpJMU5paG1jbTl0UW1Gc0xtNWhkR2wyWlNBdElHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSXRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdjSFZpYkdsaklHSmhiR0Z1WTJWeklEMGdRbTk0VFdGd1BFRmtaSEpsYzNNc0lGVnBiblJPTWpVMlBpaDdJR3RsZVZCeVpXWnBlRG9nSjJJbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmlJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalEwTG1Gc1oyOHVkSE02TVRjd0NpQWdJQ0F2THlCMGFHbHpMbUpoYkdGdVkyVnpLR1p5YjIwcExuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTR5TlRZb1puSnZiVUpoYkM1dVlYUnBkbVVnTFNCaGJXOTFiblF1Ym1GMGFYWmxLUW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCd2RXSnNhV01nZEc5MFlXeFRkWEJ3YkhrZ1BTQkhiRzlpWVd4VGRHRjBaVHhWYVc1MFRqSTFOajRvZXlCclpYazZJQ2QwSnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE56RUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFRkWEJ3YkhrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmloMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxMbTVoZEdsMlpTQXRJR0Z0YjNWdWRDNXVZWFJwZG1VcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmlmQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkRzkwWVd4VGRYQndiSGtnUFNCSGJHOWlZV3hUZEdGMFpUeFZhVzUwVGpJMU5qNG9leUJyWlhrNklDZDBKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRMExtRnNaMjh1ZEhNNk1UY3hDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNVM1Z3Y0d4NUxuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTR5TlRZb2RHaHBjeTUwYjNSaGJGTjFjSEJzZVM1MllXeDFaUzV1WVhScGRtVWdMU0JoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUTBMbUZzWjI4dWRITTZNVGMyQ2lBZ0lDQXZMeUJqYjI1MGNtOXNiR1Z5T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRRdVlXeG5ieTUwY3pveE56VXRNVGd4Q2lBZ0lDQXZMeUJ1WlhjZ1lYSmpNVFkwTkY5amIyNTBjbTlzYkdWeVgzSmxaR1ZsYlY5bGRtVnVkQ2g3Q2lBZ0lDQXZMeUFnSUdOdmJuUnliMnhzWlhJNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJR1p5YjIwc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1kyOWtaU3dLSUNBZ0lDOHZJQ0FnYjNCbGNtRjBiM0pmWkdGMFlTd0tJQ0FnSUM4dklIMHBMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTkM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCamIyNXpkQ0JEVDBSRlgxTlZRME5GVTFNZ1BTQnVaWGNnWVhKak5DNUNlWFJsS0RCNE5URXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORFF1WVd4bmJ5NTBjem94TnpVdE1UZ3hDaUFnSUNBdkx5QnVaWGNnWVhKak1UWTBORjlqYjI1MGNtOXNiR1Z5WDNKbFpHVmxiVjlsZG1WdWRDaDdDaUFnSUNBdkx5QWdJR052Ym5SeWIyeHNaWEk2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lHWnliMjBzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWTI5a1pTd0tJQ0FnSUM4dklDQWdiM0JsY21GMGIzSmZaR0YwWVN3S0lDQWdJQzh2SUgwcExBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFl6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qRTNNeTB4T0RJS0lDQWdJQzh2SUdWdGFYUW9DaUFnSUNBdkx5QWdJQ2REYjI1MGNtOXNiR1Z5VW1Wa1pXVnRKeXdLSUNBZ0lDOHZJQ0FnYm1WM0lHRnlZekUyTkRSZlkyOXVkSEp2Ykd4bGNsOXlaV1JsWlcxZlpYWmxiblFvZXdvZ0lDQWdMeThnSUNBZ0lHTnZiblJ5YjJ4c1pYSTZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1puSnZiU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1kyOWtaU3dLSUNBZ0lDOHZJQ0FnSUNCdmNHVnlZWFJ2Y2w5a1lYUmhMQW9nSUNBZ0x5OGdJQ0I5S1N3S0lDQWdJQzh2SUNrS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01EQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREJrWldVeE5HWTFJQzh2SUcxbGRHaHZaQ0FpUTI5dWRISnZiR3hsY2xKbFpHVmxiU2dvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXNZbmwwWlN4aWVYUmxXMTBwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME5DNWhiR2R2TG5Sek9qRTRNd29nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJoY21NMExsVnBiblJPTmpRb1kyOWtaUzV1WVhScGRtVXBDaUFnSUNCd2RYTm9hVzUwSURneElDOHZJRGd4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pwQmNtTXhOalF6TGw5dmJteDVUM2R1WlhJb0tTQXRQaUIyYjJsa09ncHpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPanBCY21NeE5qUXpMbDl2Ym14NVQzZHVaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWhjbU00T0Y5cGMxOXZkMjVsY2lodVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcEtTNXVZWFJwZG1VZ1BUMDlJSFJ5ZFdVc0lDZHZibXg1WDI5M2JtVnlKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWVhKak9EaGZhWE5mYjNkdVpYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhsZmIzZHVaWElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02T2tGeVl6RTJORE11WVhKak1UWTBNMTl6WlhSZlpHOWpkVzFsYm5Rb2JtRnRaVG9nWW5sMFpYTXNJSFZ5YVRvZ1lubDBaWE1zSUdoaGMyZzZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGhjbU14TmpRelgzTmxkRjlrYjJOMWJXVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TXpRdE16VUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1UWTBNMTl6WlhSZlpHOWpkVzFsYm5Rb2JtRnRaVG9nWVhKak5DNUVlVzVoYldsalFubDBaWE1zSUhWeWFUb2dZWEpqTkM1VGRISXNJR2hoYzJnNklHRnlZelF1UkhsdVlXMXBZMEo1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhSb2FYTXVYMjl1YkhsUGQyNWxjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZPa0Z5WXpFMk5ETXVYMjl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnWVhOelpYSjBLRzVoYldVdVlubDBaWE11YkdWdVozUm9JRDRnTUN3Z0oyVnRjSFI1WDI1aGJXVW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUdWdGNIUjVYMjVoYldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHTnZibk4wSUhKbFl5QTlJRzVsZHlCaGNtTXhOalF6WDJSdlkzVnRaVzUwWDNKbFkyOXlaQ2g3SUhWeWFTd2dhR0Z6YUN3Z2RHbHRaWE4wWVcxd09pQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtFZHNiMkpoYkM1eWIzVnVaQ2tnZlNrS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjSFZ6YUdsdWRDQXhNaUF2THlBeE1nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TUdNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUhCMVlteHBZeUJrYjJOMWJXVnVkSE1nUFNCQ2IzaE5ZWEE4WVhKak5DNUVlVzVoYldsalFubDBaWE1zSUdGeVl6RTJORE5mWkc5amRXMWxiblJmY21WamIzSmtQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRnlZekUyTkROZlpHOWpKeUI5S1FvZ0lDQWdZbmwwWldNZ01qTWdMeThnSW1GeVl6RTJORE5mWkc5aklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJSFJvYVhNdVpHOWpkVzFsYm5SektHNWhiV1VwTG5aaGJIVmxJRDBnY21WakxtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJSEIxWW14cFl5QmtiMk4xYldWdWRFdGxlWE1nUFNCQ2IzZzhZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTmJYVDRvZXlCclpYazZJQ2RoY21NeE5qUXpYMlJ2WTNNbklIMHBDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlZWEpqTVRZME0xOWtiMk56SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxtUnZZM1Z0Wlc1MFMyVjVjeTVsZUdsemRITXBJSHNLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHRnlZekUyTkROZmMyVjBYMlJ2WTNWdFpXNTBYMlZzYzJWZlltOWtlVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMGFHbHpMbVJ2WTNWdFpXNTBTMlY1Y3k1MllXeDFaU0E5SUZ0dVlXMWxYUW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdNSGd3TURBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMko1ZEdWZmJHVnVaM1JvWDJobFlXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJSEIxWW14cFl5QmtiMk4xYldWdWRFdGxlWE1nUFNCQ2IzZzhZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTmJYVDRvZXlCclpYazZJQ2RoY21NeE5qUXpYMlJ2WTNNbklIMHBDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlZWEpqTVRZME0xOWtiMk56SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z2RHaHBjeTVrYjJOMWJXVnVkRXRsZVhNdWRtRnNkV1VnUFNCYmJtRnRaVjBLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2NIVmliR2xqSUdSdlkzVnRaVzUwUzJWNWN5QTlJRUp2ZUR4aGNtTTBMa1I1Ym1GdGFXTkNlWFJsYzF0ZFBpaDdJR3RsZVRvZ0oyRnlZekUyTkROZlpHOWpjeWNnZlNrS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKaGNtTXhOalF6WDJSdlkzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUIwYUdsekxtUnZZM1Z0Wlc1MFMyVjVjeTUyWVd4MVpTQTlJRnR1WVcxbFhRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9LWVhKak1UWTBNMTl6WlhSZlpHOWpkVzFsYm5SZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z1pXMXBkQ2duUkc5amRXMWxiblJWY0dSaGRHVmtKeXdnYm1WM0lHRnlZekUyTkROZlpHOWpkVzFsYm5SZmRYQmtZWFJsWkY5bGRtVnVkQ2g3SUc1aGJXVXNJSFZ5YVN3Z2FHRnphQ0I5S1NrS0lDQWdJSEIxYzJocGJuUWdOaUF2THlBMkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWW5sMFpXTWdNamtnTHk4Z01IZ3dNREEyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3laR013TTJNek5pQXZMeUJ0WlhSb2IyUWdJa1J2WTNWdFpXNTBWWEJrWVhSbFpDZ29ZbmwwWlZ0ZExITjBjbWx1Wnl4aWVYUmxXMTBwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDbUZ5WXpFMk5ETmZjMlYwWDJSdlkzVnRaVzUwWDJWc2MyVmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdjSFZpYkdsaklHUnZZM1Z0Wlc1MFMyVjVjeUE5SUVKdmVEeGhjbU0wTGtSNWJtRnRhV05DZVhSbGMxdGRQaWg3SUd0bGVUb2dKMkZ5WXpFMk5ETmZaRzlqY3ljZ2ZTa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSmhjbU14TmpRelgyUnZZM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCMGFHbHpMbVJ2WTNWdFpXNTBTMlY1Y3k1MllXeDFaU0E5SUZzdUxpNTBhR2x6TG1SdlkzVnRaVzUwUzJWNWN5NTJZV3gxWlN3Z2JtRnRaVjBLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmllWFJsWXlBeU1DQXZMeUF3ZURBd01EQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWW5sMFpWOXNaVzVuZEdoZmFHVmhaQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZllubDBaVjlzWlc1bmRHaGZhR1ZoWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2NIVmliR2xqSUdSdlkzVnRaVzUwUzJWNWN5QTlJRUp2ZUR4aGNtTTBMa1I1Ym1GdGFXTkNlWFJsYzF0ZFBpaDdJR3RsZVRvZ0oyRnlZekUyTkROZlpHOWpjeWNnZlNrS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKaGNtTXhOalF6WDJSdlkzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUIwYUdsekxtUnZZM1Z0Wlc1MFMyVjVjeTUyWVd4MVpTQTlJRnN1TGk1MGFHbHpMbVJ2WTNWdFpXNTBTMlY1Y3k1MllXeDFaU3dnYm1GdFpWMEtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnY0hWaWJHbGpJR1J2WTNWdFpXNTBTMlY1Y3lBOUlFSnZlRHhoY21NMExrUjVibUZ0YVdOQ2VYUmxjMXRkUGloN0lHdGxlVG9nSjJGeVl6RTJORE5mWkc5amN5Y2dmU2tLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0poY21NeE5qUXpYMlJ2WTNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QjBhR2x6TG1SdlkzVnRaVzUwUzJWNWN5NTJZV3gxWlNBOUlGc3VMaTUwYUdsekxtUnZZM1Z0Wlc1MFMyVjVjeTUyWVd4MVpTd2dibUZ0WlYwS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdJZ1lYSmpNVFkwTTE5elpYUmZaRzlqZFcxbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBekNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pvNlFYSmpNVFkwTXk1aGNtTXhOalF6WDJkbGRGOWtiMk4xYldWdWRDaHVZVzFsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21GeVl6RTJORE5mWjJWMFgyUnZZM1Z0Wlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6bzBPQzAwT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TmpRelgyZGxkRjlrYjJOMWJXVnVkQ2h1WVcxbE9pQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5azZJR0Z5WXpFMk5ETmZaRzlqZFcxbGJuUmZjbVZqYjNKa0lIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z2NIVmliR2xqSUdSdlkzVnRaVzUwY3lBOUlFSnZlRTFoY0R4aGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3l3Z1lYSmpNVFkwTTE5a2IyTjFiV1Z1ZEY5eVpXTnZjbVErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRZME0xOWtiMk1uSUgwcENpQWdJQ0JpZVhSbFl5QXlNeUF2THlBaVlYSmpNVFkwTTE5a2IyTWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTJORE11WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVpHOWpkVzFsYm5SektHNWhiV1VwTG1WNGFYTjBjeXdnSjI1dmRGOW1iM1Z1WkNjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkRjltYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Wkc5amRXMWxiblJ6S0c1aGJXVXBMblpoYkhWbExtTnZjSGtvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk9rRnlZekUyTkRNdVlYSmpNVFkwTTE5eVpXMXZkbVZmWkc5amRXMWxiblFvYm1GdFpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtRnlZekUyTkROZmNtVnRiM1psWDJSdlkzVnRaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUyTkRNdVlXeG5ieTUwY3pvMU5DMDFOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOalF6WDNKbGJXOTJaVjlrYjJOMWJXVnVkQ2h1WVcxbE9pQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCMGFHbHpMbDl2Ym14NVQzZHVaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPanBCY21NeE5qUXpMbDl2Ym14NVQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOalF6TG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUhCMVlteHBZeUJrYjJOMWJXVnVkSE1nUFNCQ2IzaE5ZWEE4WVhKak5DNUVlVzVoYldsalFubDBaWE1zSUdGeVl6RTJORE5mWkc5amRXMWxiblJmY21WamIzSmtQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRnlZekUyTkROZlpHOWpKeUI5S1FvZ0lDQWdZbmwwWldNZ01qTWdMeThnSW1GeVl6RTJORE5mWkc5aklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5qUXpMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1SdlkzVnRaVzUwY3lodVlXMWxLUzVsZUdsemRITXNJQ2R1YjNSZlptOTFibVFuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUmZabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklHTnZibk4wSUhCeWFXOXlJRDBnZEdocGN5NWtiMk4xYldWdWRITW9ibUZ0WlNrdWRtRnNkV1V1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UWTBNeTVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUIwYUdsekxtUnZZM1Z0Wlc1MGN5aHVZVzFsS1M1a1pXeGxkR1VvS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRZME15NWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QmxiV2wwS0NkRWIyTjFiV1Z1ZEZKbGJXOTJaV1FuTENCdVpYY2dZWEpqTVRZME0xOWtiMk4xYldWdWRGOXlaVzF2ZG1Wa1gyVjJaVzUwS0hzZ2JtRnRaU3dnZFhKcE9pQndjbWx2Y2k1MWNta3NJR2hoYzJnNklIQnlhVzl5TG1oaGMyZ2dmU2twQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z05nb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV01nTWprZ0x5OGdNSGd3TURBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TURBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHRmxOMkUwWm1Fd0lDOHZJRzFsZEdodlpDQWlSRzlqZFcxbGJuUlNaVzF2ZG1Wa0tDaGllWFJsVzEwc2MzUnlhVzVuTEdKNWRHVmJYU2twSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TmpRekxtRnNaMjh1ZEhNNk9rRnlZekUyTkRNdVlYSmpNVFkwTTE5blpYUmZZV3hzWDJSdlkzVnRaVzUwY3lncElDMCtJR0o1ZEdWek9ncGhjbU14TmpRelgyZGxkRjloYkd4ZlpHOWpkVzFsYm5Sek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMk5ETXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdjSFZpYkdsaklHUnZZM1Z0Wlc1MFMyVjVjeUE5SUVKdmVEeGhjbU0wTGtSNWJtRnRhV05DZVhSbGMxdGRQaWg3SUd0bGVUb2dKMkZ5WXpFMk5ETmZaRzlqY3ljZ2ZTa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSmhjbU14TmpRelgyUnZZM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFkwTXk1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWtiMk4xYldWdWRFdGxlWE11ZG1Gc2RXVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPanBCY21NeE5UazBMbDl2Ym14NVQzZHVaWElvS1NBdFBpQjJiMmxrT2dwemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qcEJjbU14TlRrMExsOXZibXg1VDNkdVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aGNtTTRPRjlwYzE5dmQyNWxjaWh1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwS1M1dVlYUnBkbVVnUFQwOUlIUnlkV1VzSUNkdmJteDVYMjkzYm1WeUp5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdZWEpqT0RoZmFYTmZiM2R1WlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGxmYjNkdVpYSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZPa0Z5WXpFMU9UUXVZWEpqTVRVNU5GOXpaWFJmYVhOemRXRmliR1VvWm14aFp6b2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtRnlZekUxT1RSZmMyVjBYMmx6YzNWaFlteGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem95TnkweU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5UazBYM05sZEY5cGMzTjFZV0pzWlNobWJHRm5PaUJoY21NMExrSnZiMndwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdkR2hwY3k1ZmIyNXNlVTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvNlFYSmpNVFU1TkM1ZmIyNXNlVTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFU1TkY5cGMzTjFZV0pzWlNBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFtOXZiRDRvZXlCclpYazZJQ2RoY21NeE5UazBYMmx6Y3ljZ2ZTa2dMeThnVkhKMVpTQTlJR2x6YzNWaFlteGxDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWlZWEpqTVRVNU5GOXBjM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCMGFHbHpMbUZ5WXpFMU9UUmZhWE56ZFdGaWJHVXVkbUZzZFdVZ1BTQm1iR0ZuQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pwQmNtTXhOVGswTG1GeVl6RTFPVFJmYVhOemRXVW9kRzg2SUdKNWRHVnpMQ0JoYlc5MWJuUTZJR0o1ZEdWekxDQmtZWFJoT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWVhKak1UVTVORjlwYzNOMVpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZNelF0TXpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRVNU5GOXBjM04xWlNoMGJ6b2dZWEpqTkM1QlpHUnlaWE56TENCaGJXOTFiblE2SUdGeVl6UXVWV2x1ZEU0eU5UWXNJR1JoZEdFNklHRnlZelF1UkhsdVlXMXBZMEo1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhSb2FYTXVYMjl1YkhsUGQyNWxjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZPa0Z5WXpFMU9UUXVYMjl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnWVhOelpYSjBLR0Z0YjNWdWRDNXVZWFJwZG1VZ1BpQXdiaXdnSjJsdWRtRnNhV1JmWVcxdmRXNTBKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaVBnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1JmWVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRVNU5GOXBjM04xWVdKc1pTQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRbTl2YkQ0b2V5QnJaWGs2SUNkaGNtTXhOVGswWDJsemN5Y2dmU2tnTHk4Z1ZISjFaU0E5SUdsemMzVmhZbXhsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJbUZ5WXpFMU9UUmZhWE56SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZWEpqTVRVNU5GOXBjM04xWVdKc1pTNW9ZWE5XWVd4MVpTQW1KaUIwYUdsekxtRnlZekUxT1RSZmFYTnpkV0ZpYkdVdWRtRnNkV1V1Ym1GMGFYWmxJRDA5UFNCMGNuVmxMQ0FuYVhOemRXRnVZMlZmWkdsellXSnNaV1FuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZWEpqTVRVNU5GOXBjM04xWlY5aWIyOXNYMlpoYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TlRrMFgybHpjM1ZoWW14bElEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUNiMjlzUGloN0lHdGxlVG9nSjJGeVl6RTFPVFJmYVhOekp5QjlLU0F2THlCVWNuVmxJRDBnYVhOemRXRmliR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWlZWEpqTVRVNU5GOXBjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1GeVl6RTFPVFJmYVhOemRXRmliR1V1YUdGelZtRnNkV1VnSmlZZ2RHaHBjeTVoY21NeE5UazBYMmx6YzNWaFlteGxMblpoYkhWbExtNWhkR2wyWlNBOVBUMGdkSEoxWlN3Z0oybHpjM1ZoYm1ObFgyUnBjMkZpYkdWa0p5a0tJQ0FnSUdkbGRHSnBkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGNtTXhOVGswWDJsemMzVmxYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ21GeVl6RTFPVFJmYVhOemRXVmZZbTl2YkY5dFpYSm5aVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZWEpqTVRVNU5GOXBjM04xWVdKc1pTNW9ZWE5XWVd4MVpTQW1KaUIwYUdsekxtRnlZekUxT1RSZmFYTnpkV0ZpYkdVdWRtRnNkV1V1Ym1GMGFYWmxJRDA5UFNCMGNuVmxMQ0FuYVhOemRXRnVZMlZmWkdsellXSnNaV1FuS1FvZ0lDQWdZWE56WlhKMElDOHZJR2x6YzNWaGJtTmxYMlJwYzJGaWJHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUIwYUdsekxtRnlZekUwTVRCZmFYTnpkV1ZmWW5sZmNHRnlkR2wwYVc5dUtIUnZMQ0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ2tzSUdGdGIzVnVkQ3dnWkdGMFlTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlHRnlZekUwTVRCZmFYTnpkV1ZmWW5sZmNHRnlkR2wwYVc5dUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QmxiV2wwS0NkSmMzTjFaU2NzSUc1bGR5QmhjbU14TlRrMFgybHpjM1ZsWDJWMlpXNTBLSHNnZEc4c0lHRnRiM1Z1ZEN3Z1pHRjBZU0I5S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklESTBJQzh2SURCNE1EQTBNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBd01ESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaakpsT1RrNFlXWWdMeThnYldWMGFHOWtJQ0pKYzNOMVpTZ29ZV1JrY21WemN5eDFhVzUwTWpVMkxHSjVkR1ZiWFNrcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LWVhKak1UVTVORjlwYzNOMVpWOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQmhjbU14TlRrMFgybHpjM1ZsWDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TlRrMExtRnNaMjh1ZEhNNk9rRnlZekUxT1RRdVlYSmpNVFU1TkY5eVpXUmxaVzFHY205dEtHWnliMjA2SUdKNWRHVnpMQ0JoYlc5MWJuUTZJR0o1ZEdWekxDQmtZWFJoT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWVhKak1UVTVORjl5WldSbFpXMUdjbTl0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvME5DMDBOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOVGswWDNKbFpHVmxiVVp5YjIwb1puSnZiVG9nWVhKak5DNUJaR1J5WlhOekxDQmhiVzkxYm5RNklHRnlZelF1VldsdWRFNHlOVFlzSUdSaGRHRTZJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSWdQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHpaVzVrWlhJZ1BUMDlJR1p5YjIwZ2ZId2dkR2hwY3k1aGNtTTRPRjlwYzE5dmQyNWxjaWh6Wlc1a1pYSXBMbTVoZEdsMlpTQTlQVDBnZEhKMVpTd2dKMjV2ZEY5aGRYUm9KeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQmhjbU14TlRrMFgzSmxaR1ZsYlVaeWIyMWZZbTl2YkY5MGNuVmxRRElLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCallXeHNjM1ZpSUdGeVl6ZzRYMmx6WDI5M2JtVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdGeVl6RTFPVFJmY21Wa1pXVnRSbkp2YlY5aWIyOXNYMlpoYkhObFFETUtDbUZ5WXpFMU9UUmZjbVZrWldWdFJuSnZiVjlpYjI5c1gzUnlkV1ZBTWpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwaGNtTXhOVGswWDNKbFpHVmxiVVp5YjIxZlltOXZiRjl0WlhKblpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnWVhOelpYSjBLSE5sYm1SbGNpQTlQVDBnWm5KdmJTQjhmQ0IwYUdsekxtRnlZemc0WDJselgyOTNibVZ5S0hObGJtUmxjaWt1Ym1GMGFYWmxJRDA5UFNCMGNuVmxMQ0FuYm05MFgyRjFkR2duS1FvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZEY5aGRYUm9DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZVzF2ZFc1MExtNWhkR2wyWlNBK0lEQnVMQ0FuYVc1MllXeHBaRjloYlc5MWJuUW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUdJK0NpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaRjloYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdjSFZpYkdsaklHSmhiR0Z1WTJWeklEMGdRbTk0VFdGd1BFRmtaSEpsYzNNc0lGVnBiblJPTWpVMlBpaDdJR3RsZVZCeVpXWnBlRG9nSjJJbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmlJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aVlXeGhibU5sY3lobWNtOXRLUzVsZUdsemRITWdKaVlnZEdocGN5NWlZV3hoYm1ObGN5aG1jbTl0S1M1MllXeDFaUzV1WVhScGRtVWdQajBnWVcxdmRXNTBMbTVoZEdsMlpTd2dKMmx1YzNWbVptbGphV1Z1ZEY5aVlXeGhibU5sSnlrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZWEpqTVRVNU5GOXlaV1JsWlcxR2NtOXRYMkp2YjJ4ZlptRnNjMlZBTndvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSStQUW9nSUNBZ1lub2dZWEpqTVRVNU5GOXlaV1JsWlcxR2NtOXRYMkp2YjJ4ZlptRnNjMlZBTndvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ21GeVl6RTFPVFJmY21Wa1pXVnRSbkp2YlY5aWIyOXNYMjFsY21kbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aVlXeGhibU5sY3lobWNtOXRLUzVsZUdsemRITWdKaVlnZEdocGN5NWlZV3hoYm1ObGN5aG1jbTl0S1M1MllXeDFaUzV1WVhScGRtVWdQajBnWVcxdmRXNTBMbTVoZEdsMlpTd2dKMmx1YzNWbVptbGphV1Z1ZEY5aVlXeGhibU5sSnlrS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5OMVptWnBZMmxsYm5SZlltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWhtY205dEtTNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTWpVMktIUm9hWE11WW1Gc1lXNWpaWE1vWm5KdmJTa3VkbUZzZFdVdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdJdENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCd2RXSnNhV01nZEc5MFlXeFRkWEJ3YkhrZ1BTQkhiRzlpWVd4VGRHRjBaVHhWYVc1MFRqSTFOajRvZXlCclpYazZJQ2QwSnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGTjFjSEJzZVM1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUk9NalUyS0hSb2FYTXVkRzkwWVd4VGRYQndiSGt1ZG1Gc2RXVXVibUYwYVhabElDMGdZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaTBLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHSjhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjBiM1JoYkZOMWNIQnNlU0E5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTWpVMlBpaDdJR3RsZVRvZ0ozUW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUxT1RRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGTjFjSEJzZVM1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUk9NalUyS0hSb2FYTXVkRzkwWVd4VGRYQndiSGt1ZG1Gc2RXVXVibUYwYVhabElDMGdZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmxiV2wwS0NkU1pXUmxaVzBuTENCdVpYY2dZWEpqTVRVNU5GOXlaV1JsWlcxZlpYWmxiblFvZXlCbWNtOXRMQ0JoYlc5MWJuUXNJR1JoZEdFZ2ZTa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUF5TkNBdkx5QXdlREF3TkRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNREF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklETXdJQzh2SUcxbGRHaHZaQ0FpVW1Wa1pXVnRLQ2hoWkdSeVpYTnpMSFZwYm5ReU5UWXNZbmwwWlZ0ZEtTa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2NtVjBjM1ZpQ2dwaGNtTXhOVGswWDNKbFpHVmxiVVp5YjIxZlltOXZiRjltWVd4elpVQTNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1lYSmpNVFU1TkY5eVpXUmxaVzFHY205dFgySnZiMnhmYldWeVoyVkFPQW9LWVhKak1UVTVORjl5WldSbFpXMUdjbTl0WDJKdmIyeGZabUZzYzJWQU16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdGeVl6RTFPVFJmY21Wa1pXVnRSbkp2YlY5aWIyOXNYMjFsY21kbFFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qcEJjbU14TlRrMExtRnlZekUxT1RSZmNtVmtaV1Z0S0dGdGIzVnVkRG9nWW5sMFpYTXNJR1JoZEdFNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwaGNtTXhOVGswWDNKbFpHVmxiVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TlRVdE5UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1UVTVORjl5WldSbFpXMG9ZVzF2ZFc1ME9pQmhjbU0wTGxWcGJuUk9NalUyTENCa1lYUmhPaUJoY21NMExrUjVibUZ0YVdOQ2VYUmxjeWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QmpiMjV6ZENCbWNtOXRJRDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZVzF2ZFc1MExtNWhkR2wyWlNBK0lEQnVMQ0FuYVc1MllXeHBaRjloYlc5MWJuUW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUdJK0NpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaRjloYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdjSFZpYkdsaklHSmhiR0Z1WTJWeklEMGdRbTk0VFdGd1BFRmtaSEpsYzNNc0lGVnBiblJPTWpVMlBpaDdJR3RsZVZCeVpXWnBlRG9nSjJJbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSmhiR0Z1WTJWektHWnliMjBwTG1WNGFYTjBjeUFtSmlCMGFHbHpMbUpoYkdGdVkyVnpLR1p5YjIwcExuWmhiSFZsTG01aGRHbDJaU0ErUFNCaGJXOTFiblF1Ym1GMGFYWmxMQ0FuYVc1emRXWm1hV05wWlc1MFgySmhiR0Z1WTJVbktRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJoY21NeE5UazBYM0psWkdWbGJWOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaVBqMEtJQ0FnSUdKNklHRnlZekUxT1RSZmNtVmtaV1Z0WDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtRnlZekUxT1RSZmNtVmtaV1Z0WDJKdmIyeGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5UazBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KaGJHRnVZMlZ6S0daeWIyMHBMbVY0YVhOMGN5QW1KaUIwYUdsekxtSmhiR0Z1WTJWektHWnliMjBwTG5aaGJIVmxMbTVoZEdsMlpTQStQU0JoYlc5MWJuUXVibUYwYVhabExDQW5hVzV6ZFdabWFXTnBaVzUwWDJKaGJHRnVZMlVuS1FvZ0lDQWdZWE56WlhKMElDOHZJR2x1YzNWbVptbGphV1Z1ZEY5aVlXeGhibU5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCMGFHbHpMbUpoYkdGdVkyVnpLR1p5YjIwcExuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTR5TlRZb2RHaHBjeTVpWVd4aGJtTmxjeWhtY205dEtTNTJZV3gxWlM1dVlYUnBkbVVnTFNCaGJXOTFiblF1Ym1GMGFYWmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWkwS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JpZkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUhCMVlteHBZeUIwYjNSaGJGTjFjSEJzZVNBOUlFZHNiMkpoYkZOMFlYUmxQRlZwYm5ST01qVTJQaWg3SUd0bGVUb2dKM1FuSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1VldsdWRFNHlOVFlvZEdocGN5NTBiM1JoYkZOMWNIQnNlUzUyWVd4MVpTNXVZWFJwZG1VZ0xTQmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlMUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1lud0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdjSFZpYkdsaklIUnZkR0ZzVTNWd2NHeDVJRDBnUjJ4dlltRnNVM1JoZEdVOFZXbHVkRTR5TlRZK0tIc2dhMlY1T2lBbmRDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1VldsdWRFNHlOVFlvZEdocGN5NTBiM1JoYkZOMWNIQnNlUzUyWVd4MVpTNXVZWFJwZG1VZ0xTQmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TlRrMExtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklHVnRhWFFvSjFKbFpHVmxiU2NzSUc1bGR5QmhjbU14TlRrMFgzSmxaR1ZsYlY5bGRtVnVkQ2g3SUdaeWIyMHNJR0Z0YjNWdWRDd2daR0YwWVNCOUtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNalFnTHk4Z01IZ3dNRFF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1EQXdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBek1DQXZMeUJ0WlhSb2IyUWdJbEpsWkdWbGJTZ29ZV1JrY21WemN5eDFhVzUwTWpVMkxHSjVkR1ZiWFNrcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LWVhKak1UVTVORjl5WldSbFpXMWZZbTl2YkY5bVlXeHpaVUF6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdZWEpqTVRVNU5GOXlaV1JsWlcxZlltOXZiRjl0WlhKblpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6bzZRWEpqTVRVNU5DNWhjbU14TlRrMFgzUnlZVzV6Wm1WeVgzZHBkR2hmWkdGMFlTaDBiem9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNc0lHUmhkR0U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVhKak1UVTVORjkwY21GdWMyWmxjbDkzYVhSb1gyUmhkR0U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pZMkxUWTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6RTFPVFJmZEhKaGJuTm1aWEpmZDJsMGFGOWtZWFJoS0hSdk9pQmhjbU0wTGtGa1pISmxjM01zSUdGdGIzVnVkRG9nWVhKak5DNVZhVzUwVGpJMU5pd2daR0YwWVRvZ1lYSmpOQzVFZVc1aGJXbGpRbmwwWlhNcE9pQmhjbU0wTGtKdmIyd2dld29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QmpiMjV6ZENCeVpYTWdQU0IwYUdsekxtRnlZekl3TUY5MGNtRnVjMlpsY2loMGJ5d2dZVzF2ZFc1MEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdZWEpqTWpBd1gzUnlZVzV6Wm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRVNU5DNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QnlaWFIxY200Z2NtVnpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPanBCY21NeE5UazBMbUZ5WXpFMU9UUmZkSEpoYm5ObVpYSmZabkp2YlY5M2FYUm9YMlJoZEdFb1puSnZiVG9nWW5sMFpYTXNJSFJ2T2lCaWVYUmxjeXdnWVcxdmRXNTBPaUJpZVhSbGN5d2daR0YwWVRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwaGNtTXhOVGswWDNSeVlXNXpabVZ5WDJaeWIyMWZkMmwwYUY5a1lYUmhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem8zTkMwNE1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5UazBYM1J5WVc1elptVnlYMlp5YjIxZmQybDBhRjlrWVhSaEtBb2dJQ0FnTHk4Z0lDQm1jbTl0T2lCaGNtTTBMa0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJSFJ2T2lCaGNtTTBMa0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dZWEpqTkM1VmFXNTBUakkxTml3S0lDQWdJQzh2SUNBZ1pHRjBZVG9nWVhKak5DNUVlVzVoYldsalFubDBaWE1zQ2lBZ0lDQXZMeUFwT2lCaGNtTTBMa0p2YjJ3Z2V3b2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFU1TkM1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCamIyNXpkQ0J5WlhNZ1BTQjBhR2x6TG1GeVl6SXdNRjkwY21GdWMyWmxja1p5YjIwb1puSnZiU3dnZEc4c0lHRnRiM1Z1ZENrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1lYSmpNakF3WDNSeVlXNXpabVZ5Um5KdmJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFMU9UUXVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdjbVYwZFhKdUlISmxjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTFPVFF1WVd4bmJ5NTBjem82UVhKak1UVTVOQzVoY21NeE5UazBYMmx6WDJsemMzVmhZbXhsS0NrZ0xUNGdZbmwwWlhNNkNtRnlZekUxT1RSZmFYTmZhWE56ZFdGaWJHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UVTVOQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRVNU5GOXBjM04xWVdKc1pTQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRbTl2YkQ0b2V5QnJaWGs2SUNkaGNtTXhOVGswWDJsemN5Y2dmU2tnTHk4Z1ZISjFaU0E5SUdsemMzVmhZbXhsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJbUZ5WXpFMU9UUmZhWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOVGswTG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtRnlZekUxT1RSZmFYTnpkV0ZpYkdVdWRtRnNkV1VLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02T2tGeVl6RTBNVEF1WVhKak1UUXhNRjlpWVd4aGJtTmxYMjltWDNCaGNuUnBkR2x2Ymlob2IyeGtaWEk2SUdKNWRHVnpMQ0J3WVhKMGFYUnBiMjQ2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVhKak1UUXhNRjlpWVd4aGJtTmxYMjltWDNCaGNuUnBkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5qa3ROekFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFF4TUY5aVlXeGhibU5sWDI5bVgzQmhjblJwZEdsdmJpaG9iMnhrWlhJNklHRnlZelF1UVdSa2NtVnpjeXdnY0dGeWRHbDBhVzl1T2lCaGNtTTBMa0ZrWkhKbGMzTXBPaUJoY21NMExsVnBiblJPTWpVMklIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvM01TMDNOQW9nSUNBZ0x5OGdZMjl1YzNRZ2EyVjVJRDBnYm1WM0lHRnlZekUwTVRCZlVHRnlkR2wwYVc5dVMyVjVLSHNLSUNBZ0lDOHZJQ0FnYUc5c1pHVnlPaUJvYjJ4a1pYSXNDaUFnSUNBdkx5QWdJSEJoY25ScGRHbHZiam9nY0dGeWRHbDBhVzl1TEFvZ0lDQWdMeThnZlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklIQjFZbXhwWXlCd1lYSjBhWFJwYjI1eklEMGdRbTk0VFdGd1BHRnlZekUwTVRCZlVHRnlkR2wwYVc5dVMyVjVMQ0JoY21NMExsVnBiblJPTWpVMlBpaDdJR3RsZVZCeVpXWnBlRG9nSjJGeVl6RTBNVEJmY0NjZ2ZTa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltRnlZekUwTVRCZmNDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWNHRnlkR2wwYVc5dWN5aHJaWGtwTG5aaGJIVmxDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem82UVhKak1UUXhNQzVoY21NeU1EQmZkSEpoYm5ObVpYSW9kRzg2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGhjbU15TURCZmRISmhibk5tWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qYzRMVGM1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHOTJaWEp5YVdSbElHRnlZekl3TUY5MGNtRnVjMlpsY2loMGJ6b2dZWEpqTkM1QlpHUnlaWE56TENCMllXeDFaVG9nWVhKak5DNVZhVzUwVGpJMU5pazZJR0Z5WXpRdVFtOXZiQ0I3Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJ1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ2tzQ2lBZ0lDQmllWFJsWTE4eElDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem80TUMwNE53b2dJQ0FnTHk4Z2RHaHBjeTVmZEhKaGJuTm1aWEpmY0dGeWRHbDBhVzl1S0FvZ0lDQWdMeThnSUNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa3NDaUFnSUNBdkx5QWdJSFJ2TEFvZ0lDQWdMeThnSUNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0Nrc0NpQWdJQ0F2THlBZ0lIWmhiSFZsTEFvZ0lDQWdMeThnSUNCdVpYY2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTW9LU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem80TkFvZ0lDQWdMeThnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdwTEFvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02T0RBdE9EY0tJQ0FnSUM4dklIUm9hWE11WDNSeVlXNXpabVZ5WDNCaGNuUnBkR2x2YmlnS0lDQWdJQzh2SUNBZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BMQW9nSUNBZ0x5OGdJQ0IwYnl3S0lDQWdJQzh2SUNBZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3lncExBb2dJQ0FnTHk4Z0lDQjJZV3gxWlN3S0lDQWdJQzh2SUNBZ2JtVjNJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUc1bGR5QmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5Z3BMQW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdNSGd3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qZ3dMVGczQ2lBZ0lDQXZMeUIwYUdsekxsOTBjbUZ1YzJabGNsOXdZWEowYVhScGIyNG9DaUFnSUNBdkx5QWdJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1N3S0lDQWdJQzh2SUNBZ2RHOHNDaUFnSUNBdkx5QWdJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9LU3dLSUNBZ0lDOHZJQ0FnZG1Gc2RXVXNDaUFnSUNBdkx5QWdJRzVsZHlCaGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3lncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTJGc2JITjFZaUJmZEhKaGJuTm1aWEpmY0dGeWRHbDBhVzl1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pnNENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWZkSEpoYm5ObVpYSW9ibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dnZEc4c0lIWmhiSFZsS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDNSeVlXNXpabVZ5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pwQmNtTXhOREV3TG1GeVl6RTBNVEJmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dUtIQmhjblJwZEdsdmJqb2dZbmwwWlhNc0lIUnZPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQmllWFJsY3l3Z1pHRjBZVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BoY21NeE5ERXdYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9UTXRPVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFF4TUY5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNG9DaUFnSUNBdkx5QWdJSEJoY25ScGRHbHZiam9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjBiem9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklHRnlZelF1VldsdWRFNHlOVFlzQ2lBZ0lDQXZMeUFnSUdSaGRHRTZJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpMQW9nSUNBZ0x5OGdLVG9nWVhKak5DNUJaR1J5WlhOeklIc0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE1EQUtJQ0FnSUM4dklHTnZibk4wSUhObGJtUmxjaUE5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRBeUNpQWdJQ0F2THlCc1pYUWdjbVZqWldsMlpYSlFZWEowYVhScGIyNGdQU0IwYUdsekxsOXlaV05sYVhabGNsQmhjblJwZEdsdmJpaDBieXdnY0dGeWRHbDBhVzl1S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTmhiR3h6ZFdJZ1gzSmxZMlZwZG1WeVVHRnlkR2wwYVc5dUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXdNd29nSUNBZ0x5OGdkR2hwY3k1ZmRISmhibk5tWlhKZmNHRnlkR2wwYVc5dUtITmxibVJsY2l3Z2NHRnlkR2wwYVc5dUxDQjBieXdnY21WalpXbDJaWEpRWVhKMGFYUnBiMjRzSUdGdGIzVnVkQ3dnWkdGMFlTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JrYVdjZ013b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdYM1J5WVc1elptVnlYM0JoY25ScGRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TURRS0lDQWdJQzh2SUhKbGRIVnliaUJ5WldObGFYWmxjbEJoY25ScGRHbHZiZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem82UVhKak1UUXhNQzVoY21NeE5ERXdYM0JoY25ScGRHbHZibk5mYjJZb2FHOXNaR1Z5T2lCaWVYUmxjeXdnY0dGblpUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGhjbU14TkRFd1gzQmhjblJwZEdsdmJuTmZiMlk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFd055MHhNRGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpNVFF4TUY5d1lYSjBhWFJwYjI1elgyOW1LR2h2YkdSbGNqb2dZWEpqTkM1QlpHUnlaWE56TENCd1lXZGxPaUJoY21NMExsVnBiblJPTmpRcE9pQmhjbU0wTGtGa1pISmxjM05iWFNCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRBNUNpQWdJQ0F2THlCamIyNXpkQ0JyWlhrZ1BTQnVaWGNnWVhKak1UUXhNRjlJYjJ4a2FXNW5VR0Z5ZEdsMGFXOXVjMUJoWjJsdVlYUmxaRXRsZVNoN0lHaHZiR1JsY2pvZ2FHOXNaR1Z5TENCd1lXZGxPaUJ3WVdkbElIMHBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJyWlhsUWNtVm1hWGc2SUNkaGNtTXhOREV3WDJod1gyRW5MQW9nSUNBZ1lubDBaV01nTWpFZ0x5OGdJbUZ5WXpFME1UQmZhSEJmWVNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXhNQW9nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbWh2YkdSbGNsQmhjblJwZEdsdmJuTkJaR1J5WlhOelpYTW9hMlY1S1M1bGVHbHpkSE1wSUhKbGRIVnliaUJiWFFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dZWEpqTVRReE1GOXdZWEowYVhScGIyNXpYMjltWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ1lubDBaV01nTWpBZ0x5OGdNSGd3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbUZ5WXpFME1UQmZjR0Z5ZEdsMGFXOXVjMTl2Wmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFeE1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVhRzlzWkdWeVVHRnlkR2wwYVc5dWMwRmtaSEpsYzNObGN5aHJaWGtwTG5aaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPa0Z5WXpFME1UQXVZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjaWhvYjJ4a1pYSTZJR0o1ZEdWekxDQnZjR1Z5WVhSdmNqb2dZbmwwWlhNc0lIQmhjblJwZEdsdmJqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TVRRdE1URTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6RTBNVEJmYVhOZmIzQmxjbUYwYjNJb2FHOXNaR1Z5T2lCaGNtTTBMa0ZrWkhKbGMzTXNJRzl3WlhKaGRHOXlPaUJoY21NMExrRmtaSEpsYzNNc0lIQmhjblJwZEdsdmJqb2dZWEpqTkM1QlpHUnlaWE56S1RvZ1lYSmpOQzVDYjI5c0lIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE1UWUtJQ0FnSUM4dklHbG1JQ2h2Y0dWeVlYUnZjaUE5UFQwZ2FHOXNaR1Z5S1NCeVpYUjFjbTRnYm1WM0lHRnlZelF1UW05dmJDaDBjblZsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lEMDlDaUFnSUNCaWVpQmhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEZ3dDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2w5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFeE53b2dJQ0FnTHk4Z1kyOXVjM1FnYzNCbFkybG1hV01nUFNCdVpYY2dZWEpqTVRReE1GOVBjR1Z5WVhSdmNrdGxlU2g3SUdodmJHUmxjam9nYUc5c1pHVnlMQ0J2Y0dWeVlYUnZjam9nYjNCbGNtRjBiM0lzSUhCaGNuUnBkR2x2YmpvZ2NHRnlkR2wwYVc5dUlIMHBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOaklLSUNBZ0lDOHZJSEIxWW14cFl5QnZjR1Z5WVhSdmNuTWdQU0JDYjNoTllYQThZWEpqTVRReE1GOVBjR1Z5WVhSdmNrdGxlU3dnWVhKak5DNUNlWFJsUGloN0lHdGxlVkJ5WldacGVEb2dKMkZ5WXpFME1UQmZiM0FuSUgwcElDOHZJSFpoYkhWbElEMGdNU0JoZFhSb2IzSnBlbVZrQ2lBZ0lDQmllWFJsWXlBeU1pQXZMeUFpWVhKak1UUXhNRjl2Y0NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1URTRDaUFnSUNBdkx5QnBaaUFvZEdocGN5NXZjR1Z5WVhSdmNuTW9jM0JsWTJsbWFXTXBMbVY0YVhOMGN5QW1KaUIwYUdsekxtOXdaWEpoZEc5eWN5aHpjR1ZqYVdacFl5a3VkbUZzZFdVdWJtRjBhWFpsSUQwOVBTQXhLU0I3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjbDloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVEU1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUdGeVl6UXVRbTl2YkNoMGNuVmxLUW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlRGd3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1lYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNsOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXlNUW9nSUNBZ0x5OGdZMjl1YzNRZ1oyeHZZbUZzUzJWNUlEMGdibVYzSUdGeVl6RTBNVEJmVDNCbGNtRjBiM0pMWlhrb2V5Qm9iMnhrWlhJNklHaHZiR1JsY2l3Z2IzQmxjbUYwYjNJNklHOXdaWEpoZEc5eUxDQndZWEowYVhScGIyNDZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9LU0I5S1FvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUhCMVlteHBZeUJ2Y0dWeVlYUnZjbk1nUFNCQ2IzaE5ZWEE4WVhKak1UUXhNRjlQY0dWeVlYUnZja3RsZVN3Z1lYSmpOQzVDZVhSbFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJGeVl6RTBNVEJmYjNBbklIMHBJQzh2SUhaaGJIVmxJRDBnTVNCaGRYUm9iM0pwZW1Wa0NpQWdJQ0JpZVhSbFl5QXlNaUF2THlBaVlYSmpNVFF4TUY5dmNDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVEl5Q2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTV2Y0dWeVlYUnZjbk1vWjJ4dlltRnNTMlY1S1M1bGVHbHpkSE1nSmlZZ2RHaHBjeTV2Y0dWeVlYUnZjbk1vWjJ4dlltRnNTMlY1S1M1MllXeDFaUzV1WVhScGRtVWdQVDA5SURFcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2w5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE1qTUtJQ0FnSUM4dklISmxkSFZ5YmlCdVpYY2dZWEpqTkM1Q2IyOXNLSFJ5ZFdVcENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE9EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BoY21NeE5ERXdYMmx6WDI5d1pYSmhkRzl5WDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRJMUNpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lHRnlZelF1UW05dmJDaG1ZV3h6WlNrS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE1EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzZRWEpqTVRReE1DNWhjbU14TkRFd1gyRjFkR2h2Y21sNlpWOXZjR1Z5WVhSdmNpaG9iMnhrWlhJNklHSjVkR1Z6TENCdmNHVnlZWFJ2Y2pvZ1lubDBaWE1zSUhCaGNuUnBkR2x2YmpvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21GeVl6RTBNVEJmWVhWMGFHOXlhWHBsWDI5d1pYSmhkRzl5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE1qZ3RNVEk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUwTVRCZllYVjBhRzl5YVhwbFgyOXdaWEpoZEc5eUtHaHZiR1JsY2pvZ1lYSmpOQzVCWkdSeVpYTnpMQ0J2Y0dWeVlYUnZjam9nWVhKak5DNUJaR1J5WlhOekxDQndZWEowYVhScGIyNDZJR0Z5WXpRdVFXUmtjbVZ6Y3lrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakV6TUFvZ0lDQWdMeThnWVhOelpYSjBLRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnUFQwOUlHaHZiR1JsY2l3Z0owOXViSGtnYUc5c1pHVnlJR05oYmlCaGRYUm9iM0pwZW1VbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnYUc5c1pHVnlJR05oYmlCaGRYUm9iM0pwZW1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QmpiMjV6ZENCclpYa2dQU0J1WlhjZ1lYSmpNVFF4TUY5UGNHVnlZWFJ2Y2t0bGVTaDdJR2h2YkdSbGNqb2dhRzlzWkdWeUxDQnZjR1Z5WVhSdmNqb2diM0JsY21GMGIzSXNJSEJoY25ScGRHbHZiam9nY0dGeWRHbDBhVzl1SUgwcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdjSFZpYkdsaklHOXdaWEpoZEc5eWN5QTlJRUp2ZUUxaGNEeGhjbU14TkRFd1gwOXdaWEpoZEc5eVMyVjVMQ0JoY21NMExrSjVkR1UrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOXZjQ2NnZlNrZ0x5OGdkbUZzZFdVZ1BTQXhJR0YxZEdodmNtbDZaV1FLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJQ0poY21NeE5ERXdYMjl3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXpNZ29nSUNBZ0x5OGdkR2hwY3k1dmNHVnlZWFJ2Y25Nb2EyVjVLUzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMa0o1ZEdVb01Ta0tJQ0FnSUdKNWRHVmpJREkxSUM4dklEQjRNREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9rRnlZekUwTVRBdVlYSmpNVFF4TUY5eVpYWnZhMlZmYjNCbGNtRjBiM0lvYUc5c1pHVnlPaUJpZVhSbGN5d2diM0JsY21GMGIzSTZJR0o1ZEdWekxDQndZWEowYVhScGIyNDZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGhjbU14TkRFd1gzSmxkbTlyWlY5dmNHVnlZWFJ2Y2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1UTTFMVEV6TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU14TkRFd1gzSmxkbTlyWlY5dmNHVnlZWFJ2Y2lob2IyeGtaWEk2SUdGeVl6UXVRV1JrY21WemN5d2diM0JsY21GMGIzSTZJR0Z5WXpRdVFXUmtjbVZ6Y3l3Z2NHRnlkR2wwYVc5dU9pQmhjbU0wTGtGa1pISmxjM01wT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBJRDA5UFNCb2IyeGtaWElzSUNkUGJteDVJR2h2YkdSbGNpQmpZVzRnY21WMmIydGxKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHaHZiR1JsY2lCallXNGdjbVYyYjJ0bENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXpPQW9nSUNBZ0x5OGdZMjl1YzNRZ2EyVjVJRDBnYm1WM0lHRnlZekUwTVRCZlQzQmxjbUYwYjNKTFpYa29leUJvYjJ4a1pYSTZJR2h2YkdSbGNpd2diM0JsY21GMGIzSTZJRzl3WlhKaGRHOXlMQ0J3WVhKMGFYUnBiMjQ2SUhCaGNuUnBkR2x2YmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOaklLSUNBZ0lDOHZJSEIxWW14cFl5QnZjR1Z5WVhSdmNuTWdQU0JDYjNoTllYQThZWEpqTVRReE1GOVBjR1Z5WVhSdmNrdGxlU3dnWVhKak5DNUNlWFJsUGloN0lHdGxlVkJ5WldacGVEb2dKMkZ5WXpFME1UQmZiM0FuSUgwcElDOHZJSFpoYkhWbElEMGdNU0JoZFhSb2IzSnBlbVZrQ2lBZ0lDQmllWFJsWXlBeU1pQXZMeUFpWVhKak1UUXhNRjl2Y0NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRXpPUW9nSUNBZ0x5OGdhV1lnS0hSb2FYTXViM0JsY21GMGIzSnpLR3RsZVNrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJR0Z5WXpFME1UQmZjbVYyYjJ0bFgyOXdaWEpoZEc5eVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE5EQUtJQ0FnSUM4dklIUm9hWE11YjNCbGNtRjBiM0p6S0d0bGVTa3VaR1ZzWlhSbEtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtDbUZ5WXpFME1UQmZjbVYyYjJ0bFgyOXdaWEpoZEc5eVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk9rRnlZekUwTVRBdVlYSmpNVFF4TUY5dmNHVnlZWFJ2Y2w5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNG9abkp2YlRvZ1lubDBaWE1zSUhCaGNuUnBkR2x2YmpvZ1lubDBaWE1zSUhSdk9pQmllWFJsY3l3Z1lXMXZkVzUwT2lCaWVYUmxjeXdnWkdGMFlUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGhjbU14TkRFd1gyOXdaWEpoZEc5eVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRRMExURTFNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJpZ0tJQ0FnSUM4dklDQWdabkp2YlRvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0J3WVhKMGFYUnBiMjQ2SUdGeVl6UXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdkRzg2SUdGeVl6UXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQmhjbU0wTGxWcGJuUk9NalUyTEFvZ0lDQWdMeThnSUNCa1lYUmhPaUJoY21NMExrUjVibUZ0YVdOQ2VYUmxjeXdLSUNBZ0lDOHZJQ2s2SUdGeVl6UXVRV1JrY21WemN5QjdDaUFnSUNCd2NtOTBieUExSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z1kyOXVjM1FnYzJWdVpHVnlJRDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TlRRS0lDQWdJQzh2SUd4bGRDQmhkWFJvYjNKcGVtVmtJRDBnZEdocGN5NWhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlLR1p5YjIwc0lITmxibVJsY2l3Z2NHRnlkR2wwYVc5dUtTNXVZWFJwZG1VZ1BUMDlJSFJ5ZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveE5USUtJQ0FnSUM4dklHTnZibk4wSUhObGJtUmxjaUE5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRVMENpQWdJQ0F2THlCc1pYUWdZWFYwYUc5eWFYcGxaQ0E5SUhSb2FYTXVZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjaWhtY205dExDQnpaVzVrWlhJc0lIQmhjblJwZEdsdmJpa3VibUYwYVhabElEMDlQU0IwY25WbENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR05oYkd4emRXSWdZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVFUyQ2lBZ0lDQXZMeUJwWmlBb0lXRjFkR2h2Y21sNlpXUXBJSHNLSUNBZ0lHSnVlaUJoY21NeE5ERXdYMjl3WlhKaGRHOXlYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRVNENpQWdJQ0F2THlCamIyNXpkQ0J3UzJWNUlEMGdibVYzSUdGeVl6RTBNVEJmVDNCbGNtRjBiM0pRYjNKMGFXOXVTMlY1S0hzZ2FHOXNaR1Z5T2lCbWNtOXRMQ0J2Y0dWeVlYUnZjam9nYzJWdVpHVnlMQ0J3WVhKMGFYUnBiMjRnZlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklIQjFZbXhwWXlCdmNHVnlZWFJ2Y2xCdmNuUnBiMjVCYkd4dmQyRnVZMlZ6SUQwZ1FtOTRUV0Z3UEdGeVl6RTBNVEJmVDNCbGNtRjBiM0pRYjNKMGFXOXVTMlY1TENCaGNtTTBMbFZwYm5ST01qVTJQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRnlZekUwTVRCZmIzQmhKeUI5S1FvZ0lDQWdZbmwwWldNZ01UY2dMeThnSW1GeVl6RTBNVEJmYjNCaElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3hOVGtLSUNBZ0lDOHZJR2xtSUNoMGFHbHpMbTl3WlhKaGRHOXlVRzl5ZEdsdmJrRnNiRzkzWVc1alpYTW9jRXRsZVNrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJR0Z5WXpFME1UQmZiM0JsY21GMGIzSmZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TmpBS0lDQWdJQzh2SUdOdmJuTjBJSEpsYldGcGJtbHVaeUE5SUhSb2FYTXViM0JsY21GMGIzSlFiM0owYVc5dVFXeHNiM2RoYm1ObGN5aHdTMlY1S1M1MllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVFl4Q2lBZ0lDQXZMeUJoYzNObGNuUW9jbVZ0WVdsdWFXNW5MbTVoZEdsMlpTQStQU0JoYlc5MWJuUXVibUYwYVhabExDQW5VRzl5ZEdsdmJpQmhiR3h2ZDJGdVkyVWdaWGhqWldWa1pXUW5LUW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdJK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZCdmNuUnBiMjRnWVd4c2IzZGhibU5sSUdWNFkyVmxaR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pFMk1nb2dJQ0FnTHk4Z1lYVjBhRzl5YVhwbFpDQTlJSFJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRZMUNpQWdJQ0F2THlCMGFHbHpMbTl3WlhKaGRHOXlVRzl5ZEdsdmJrRnNiRzkzWVc1alpYTW9jRXRsZVNrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmloeVpXMWhhVzVwYm1jdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpMEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpYjNoZmNIVjBDZ3BoY21NeE5ERXdYMjl3WlhKaGRHOXlYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDZ3BoY21NeE5ERXdYMjl3WlhKaGRHOXlYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TmpnS0lDQWdJQzh2SUdGemMyVnlkQ2hoZFhSb2IzSnBlbVZrTENBblRtOTBJR0YxZEdodmNtbDZaV1FnYjNCbGNtRjBiM0luS1FvZ0lDQWdZWE56WlhKMElDOHZJRTV2ZENCaGRYUm9iM0pwZW1Wa0lHOXdaWEpoZEc5eUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRTJPUW9nSUNBZ0x5OGdiR1YwSUhKbFkyVnBkbVZ5VUdGeWRHbDBhVzl1SUQwZ2RHaHBjeTVmY21WalpXbDJaWEpRWVhKMGFYUnBiMjRvZEc4c0lIQmhjblJwZEdsdmJpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqWVd4c2MzVmlJRjl5WldObGFYWmxjbEJoY25ScGRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94TnpBS0lDQWdJQzh2SUhSb2FYTXVYM1J5WVc1elptVnlYM0JoY25ScGRHbHZiaWhtY205dExDQndZWEowYVhScGIyNHNJSFJ2TENCeVpXTmxhWFpsY2xCaGNuUnBkR2x2Yml3Z1lXMXZkVzUwTENCa1lYUmhLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWkdsbklETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjkwY21GdWMyWmxjbDl3WVhKMGFYUnBiMjRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRjeENpQWdJQ0F2THlCeVpYUjFjbTRnY21WalpXbDJaWEpRWVhKMGFYUnBiMjRLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem82UVhKak1UUXhNQzVoY21NeE5ERXdYMk5oYmw5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNG9abkp2YlRvZ1lubDBaWE1zSUhCaGNuUnBkR2x2YmpvZ1lubDBaWE1zSUhSdk9pQmllWFJsY3l3Z1lXMXZkVzUwT2lCaWVYUmxjeXdnWkdGMFlUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGhjbU14TkRFd1gyTmhibDkwY21GdWMyWmxjbDlpZVY5d1lYSjBhWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qRTNOQzB4T0RFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dUtBb2dJQ0FnTHk4Z0lDQm1jbTl0T2lCaGNtTTBMa0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJSEJoY25ScGRHbHZiam9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjBiem9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklHRnlZelF1VldsdWRFNHlOVFlzQ2lBZ0lDQXZMeUFnSUdSaGRHRTZJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpMQW9nSUNBZ0x5OGdLVG9nWVhKak1UUXhNRjlqWVc1ZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVYM0psZEhWeWJpQjdDaUFnSUNCd2NtOTBieUExSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakkxTVFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWNHRnlkR2wwYVc5dWN5aHVaWGNnWVhKak1UUXhNRjlRWVhKMGFYUnBiMjVMWlhrb2V5Qm9iMnhrWlhJNklHaHZiR1JsY2l3Z2NHRnlkR2wwYVc5dU9pQndZWEowYVhScGIyNGdmU2twTG1WNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnY0hWaWJHbGpJSEJoY25ScGRHbHZibk1nUFNCQ2IzaE5ZWEE4WVhKak1UUXhNRjlRWVhKMGFYUnBiMjVMWlhrc0lHRnlZelF1VldsdWRFNHlOVFkrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOXdKeUI5S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWVhKak1UUXhNRjl3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qVXhDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV3WVhKMGFYUnBiMjV6S0c1bGR5QmhjbU14TkRFd1gxQmhjblJwZEdsdmJrdGxlU2g3SUdodmJHUmxjam9nYUc5c1pHVnlMQ0J3WVhKMGFYUnBiMjQ2SUhCaGNuUnBkR2x2YmlCOUtTa3VaWGhwYzNSekNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TVRneUNpQWdJQ0F2THlCcFppQW9JWFJvYVhNdVgzWmhiR2xrVUdGeWRHbDBhVzl1S0daeWIyMHNJSEJoY25ScGRHbHZiaWtwSUhzS0lDQWdJR0p1ZWlCaGNtTXhOREV3WDJOaGJsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakU0TXkweE9EY0tJQ0FnSUM4dklISmxkSFZ5YmlCdVpYY2dZWEpqTVRReE1GOWpZVzVmZEhKaGJuTm1aWEpmWW5sZmNHRnlkR2wwYVc5dVgzSmxkSFZ5YmloN0NpQWdJQ0F2THlBZ0lHTnZaR1U2SUc1bGR5QmhjbU0wTGtKNWRHVW9NSGcxTUNrc0NpQWdJQ0F2THlBZ0lITjBZWFIxY3pvZ2JtVjNJR0Z5WXpRdVUzUnlLQ2RRWVhKMGFYUnBiMjRnYm05MElHVjRhWE4wY3ljcExBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNsQmhjblJwZEdsdmJqb2dibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QmlZWE5sTXpJb1MwRkJRMGRCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVXRHUVZsTVUwOVNWVmhKTWt4UVRsbFJSelF6TTFWRlFsTllVVEpNVkU5U1dsRXBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWVhKak1UUXhNRjlqWVc1ZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNVGt3Q2lBZ0lDQXZMeUIwYUdsekxuQmhjblJwZEdsdmJuTW9ibVYzSUdGeVl6RTBNVEJmVUdGeWRHbDBhVzl1UzJWNUtIc2dhRzlzWkdWeU9pQm1jbTl0TENCd1lYSjBhWFJwYjI0NklIQmhjblJwZEdsdmJpQjlLU2t1ZG1Gc2RXVXVibUYwYVhabElEd2dZVzF2ZFc1MExtNWhkR2wyWlFvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSThDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakU0T1MweE9URUtJQ0FnSUM4dklHbG1JQ2dLSUNBZ0lDOHZJQ0FnZEdocGN5NXdZWEowYVhScGIyNXpLRzVsZHlCaGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTaDdJR2h2YkdSbGNqb2dabkp2YlN3Z2NHRnlkR2wwYVc5dU9pQndZWEowYVhScGIyNGdmU2twTG5aaGJIVmxMbTVoZEdsMlpTQThJR0Z0YjNWdWRDNXVZWFJwZG1VS0lDQWdJQzh2SUNrZ2V3b2dJQ0FnWW5vZ1lYSmpNVFF4TUY5allXNWZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem94T1RJdE1UazJDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJR0Z5WXpFME1UQmZZMkZ1WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOXlaWFIxY200b2V3b2dJQ0FnTHk4Z0lDQmpiMlJsT2lCdVpYY2dZWEpqTkM1Q2VYUmxLREI0TlRJcExBb2dJQ0FnTHk4Z0lDQnpkR0YwZFhNNklHNWxkeUJoY21NMExsTjBjaWduU1c1emRXWm1hV05wWlc1MElHSmhiR0Z1WTJVbktTd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSlFZWEowYVhScGIyNDZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9LU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdZbUZ6WlRNeUtFdEpRVU5IUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZMUlZNelZGUlBWbFJIVFRKTVJFNUdVMWMwTlVKQlRVcFJWMWxaVEU5TlRsTlJLUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ21GeVl6RTBNVEJmWTJGdVgzUnlZVzV6Wm1WeVgySjVYM0JoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakU1T1FvZ0lDQWdMeThnYVdZZ0tIUnZJRDA5UFNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0NrcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJRDA5Q2lBZ0lDQmllaUJoY21NeE5ERXdYMk5oYmw5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSXdNQzB5TURRS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1lYSmpNVFF4TUY5allXNWZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1WDNKbGRIVnliaWg3Q2lBZ0lDQXZMeUFnSUdOdlpHVTZJRzVsZHlCaGNtTTBMa0o1ZEdVb01IZzFOeWtzQ2lBZ0lDQXZMeUFnSUhOMFlYUjFjem9nYm1WM0lHRnlZelF1VTNSeUtDZEpiblpoYkdsa0lISmxZMlZwZG1WeUp5a3NDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlVR0Z5ZEdsMGFXOXVPaUJ1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ2tzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVek1paExORUZEUjBGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCU1VWVE0xUlhUVVpYUjFOYVFrRlBTbE5YUjFwTVNrOWFVMWhGS1FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NtRnlZekUwTVRCZlkyRnVYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJd09Bb2dJQ0FnTHk4Z1kyOXVjM1FnYzJWdVpHVnlRV1JrY2lBOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJd09Rb2dJQ0FnTHk4Z2FXWWdLSE5sYm1SbGNrRmtaSElnSVQwOUlHWnliMjBwSUhzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdJVDBLSUNBZ0lHSjZJR0Z5WXpFME1UQmZZMkZ1WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURFMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSXhNQW9nSUNBZ0x5OGdiR1YwSUdGMWRHaHZjbWw2WldRZ1BTQjBhR2x6TG1GeVl6RTBNVEJmYVhOZmIzQmxjbUYwYjNJb1puSnZiU3dnYzJWdVpHVnlRV1JrY2l3Z2NHRnlkR2wwYVc5dUtTNXVZWFJwZG1VZ1BUMDlJSFJ5ZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyRnNiSE4xWWlCaGNtTXhOREV3WDJselgyOXdaWEpoZEc5eUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lNVEVLSUNBZ0lDOHZJR2xtSUNnaFlYVjBhRzl5YVhwbFpDa2dld29nSUNBZ1ltNTZJR0Z5WXpFME1UQmZZMkZ1WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURFekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSXhNZ29nSUNBZ0x5OGdZMjl1YzNRZ2NFdGxlU0E5SUc1bGR5QmhjbU14TkRFd1gwOXdaWEpoZEc5eVVHOXlkR2x2Ymt0bGVTaDdJR2h2YkdSbGNqb2dabkp2YlN3Z2IzQmxjbUYwYjNJNklITmxibVJsY2tGa1pISXNJSEJoY25ScGRHbHZiaUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvMk13b2dJQ0FnTHk4Z2NIVmliR2xqSUc5d1pYSmhkRzl5VUc5eWRHbHZia0ZzYkc5M1lXNWpaWE1nUFNCQ2IzaE5ZWEE4WVhKak1UUXhNRjlQY0dWeVlYUnZjbEJ2Y25ScGIyNUxaWGtzSUdGeVl6UXVWV2x1ZEU0eU5UWStLSHNnYTJWNVVISmxabWw0T2lBbllYSmpNVFF4TUY5dmNHRW5JSDBwQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpWVhKak1UUXhNRjl2Y0dFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSXhNd29nSUNBZ0x5OGdhV1lnS0hSb2FYTXViM0JsY21GMGIzSlFiM0owYVc5dVFXeHNiM2RoYm1ObGN5aHdTMlY1S1M1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ013b2dJQ0FnWW5vZ1lYSmpNVFF4TUY5allXNWZkSEpoYm5ObVpYSmZZbmxmY0dGeWRHbDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TWpFMENpQWdJQ0F2THlCamIyNXpkQ0J5WlcxaGFXNXBibWNnUFNCMGFHbHpMbTl3WlhKaGRHOXlVRzl5ZEdsdmJrRnNiRzkzWVc1alpYTW9jRXRsZVNrdWRtRnNkV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TVRVS0lDQWdJQzh2SUdsbUlDaHlaVzFoYVc1cGJtY3VibUYwYVhabElENDlJR0Z0YjNWdWRDNXVZWFJwZG1VcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWo0OUNpQWdJQ0JpZWlCaGNtTXhOREV3WDJOaGJsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TVRZS0lDQWdJQzh2SUdGMWRHaHZjbWw2WldRZ1BTQjBjblZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDZ3BoY21NeE5ERXdYMk5oYmw5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0NtRnlZekUwTVRCZlkyRnVYM1J5WVc1elptVnlYMko1WDNCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRREV6T2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TWpJd0NpQWdJQ0F2THlCcFppQW9JV0YxZEdodmNtbDZaV1FwSUhzS0lDQWdJR0p1ZWlCaGNtTXhOREV3WDJOaGJsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXhOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TWpFdE1qSTFDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJR0Z5WXpFME1UQmZZMkZ1WDNSeVlXNXpabVZ5WDJKNVgzQmhjblJwZEdsdmJsOXlaWFIxY200b2V3b2dJQ0FnTHk4Z0lDQmpiMlJsT2lCdVpYY2dZWEpqTkM1Q2VYUmxLREI0TlRncExBb2dJQ0FnTHk4Z0lDQnpkR0YwZFhNNklHNWxkeUJoY21NMExsTjBjaWduVDNCbGNtRjBiM0lnYm05MElHRjFkR2h2Y21sNlpXUW5LU3dLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEpRWVhKMGFYUnBiMjQ2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1N3S0lDQWdJQzh2SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUTXlLRXhCUVVOSFFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGTVZUWTBSRVpQU2xGWVNUTXpVMFZDV0VjMk5VSkJUVVl5V0VreVJGQlBTbFZZVlZwTVJTa0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BoY21NeE5ERXdYMk5oYmw5MGNtRnVjMlpsY2w5aWVWOXdZWEowYVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNakk1Q2lBZ0lDQXZMeUJzWlhRZ2NtVmpaV2wyWlhKUVlYSjBhWFJwYjI0Z1BTQjBhR2x6TGw5eVpXTmxhWFpsY2xCaGNuUnBkR2x2YmloMGJ5d2djR0Z5ZEdsMGFXOXVLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOaGJHeHpkV0lnWDNKbFkyVnBkbVZ5VUdGeWRHbDBhVzl1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJek1TMHlNelVLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnWVhKak1UUXhNRjlqWVc1ZmRISmhibk5tWlhKZllubGZjR0Z5ZEdsMGFXOXVYM0psZEhWeWJpaDdDaUFnSUNBdkx5QWdJR052WkdVNklHNWxkeUJoY21NMExrSjVkR1VvTUhnMU1Ta3NDaUFnSUNBdkx5QWdJSE4wWVhSMWN6b2dibVYzSUdGeVl6UXVVM1J5S0NkVGRXTmpaWE56Snlrc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeVVHRnlkR2wwYVc5dU9pQnlaV05sYVhabGNsQmhjblJwZEdsdmJpd0tJQ0FnSUM4dklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFNVEF3TWpNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lNek1LSUNBZ0lDOHZJSE4wWVhSMWN6b2dibVYzSUdGeVl6UXVVM1J5S0NkVGRXTmpaWE56Snlrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQTNOVE0zTlRZek5qTTJOVGN6TnpNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qTXhMVEl6TlFvZ0lDQWdMeThnY21WMGRYSnVJRzVsZHlCaGNtTXhOREV3WDJOaGJsOTBjbUZ1YzJabGNsOWllVjl3WVhKMGFYUnBiMjVmY21WMGRYSnVLSHNLSUNBZ0lDOHZJQ0FnWTI5a1pUb2dibVYzSUdGeVl6UXVRbmwwWlNnd2VEVXhLU3dLSUNBZ0lDOHZJQ0FnYzNSaGRIVnpPaUJ1WlhjZ1lYSmpOQzVUZEhJb0oxTjFZMk5sYzNNbktTd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSlFZWEowYVhScGIyNDZJSEpsWTJWcGRtVnlVR0Z5ZEdsMGFXOXVMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pwQmNtTXhOREV3TGw5eVpXTmxhWFpsY2xCaGNuUnBkR2x2YmloeVpXTmxhWFpsY2pvZ1lubDBaWE1zSUhCaGNuUnBkR2x2YmpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwZmNtVmpaV2wyWlhKUVlYSjBhWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTBNd29nSUNBZ0x5OGdjSEp2ZEdWamRHVmtJRjl5WldObGFYWmxjbEJoY25ScGRHbHZiaWh5WldObGFYWmxjam9nWVhKak5DNUJaR1J5WlhOekxDQndZWEowYVhScGIyNDZJR0Z5WXpRdVFXUmtjbVZ6Y3lrNklHRnlZelF1UVdSa2NtVnpjeUI3Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNalEwQ2lBZ0lDQXZMeUJzWlhRZ2NtVmpaV2wyWlhKUVlYSjBhWFJwYjI0Z1BTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTBOUW9nSUNBZ0x5OGdhV1lnS0hSb2FYTXVjR0Z5ZEdsMGFXOXVjeWh1WlhjZ1lYSmpNVFF4TUY5UVlYSjBhWFJwYjI1TFpYa29leUJvYjJ4a1pYSTZJSEpsWTJWcGRtVnlMQ0J3WVhKMGFYUnBiMjQ2SUhCaGNuUnBkR2x2YmlCOUtTa3VaWGhwYzNSektTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0Z5ZEdsMGFXOXVjeUE5SUVKdmVFMWhjRHhoY21NeE5ERXdYMUJoY25ScGRHbHZia3RsZVN3Z1lYSmpOQzVWYVc1MFRqSTFOajRvZXlCclpYbFFjbVZtYVhnNklDZGhjbU14TkRFd1gzQW5JSDBwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0poY21NeE5ERXdYM0FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qUTFDaUFnSUNBdkx5QnBaaUFvZEdocGN5NXdZWEowYVhScGIyNXpLRzVsZHlCaGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTaDdJR2h2YkdSbGNqb2djbVZqWldsMlpYSXNJSEJoY25ScGRHbHZiam9nY0dGeWRHbDBhVzl1SUgwcEtTNWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWDNKbFkyVnBkbVZ5VUdGeWRHbDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtDbDl5WldObGFYWmxjbEJoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakkwT0FvZ0lDQWdMeThnY21WMGRYSnVJSEpsWTJWcGRtVnlVR0Z5ZEdsMGFXOXVDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzZRWEpqTVRReE1DNWZZV1JrWDNCaGNuUnBZMmx3WVhScGIyNWZkRzlmYUc5c1pHVnlLR2h2YkdSbGNqb2dZbmwwWlhNc0lIQmhjblJwWTJsd1lYUnBiMjQ2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BmWVdSa1gzQmhjblJwWTJsd1lYUnBiMjVmZEc5ZmFHOXNaR1Z5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU5qUUtJQ0FnSUM4dklIQnliM1JsWTNSbFpDQmZZV1JrWDNCaGNuUnBZMmx3WVhScGIyNWZkRzlmYUc5c1pHVnlLR2h2YkdSbGNqb2dZWEpqTkM1QlpHUnlaWE56TENCd1lYSjBhV05wY0dGMGFXOXVPaUJoY21NMExrRmtaSEpsYzNNcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNHNGdOQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQnVJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhCMVlteHBZeUJvYjJ4a1pYSlFZWEowYVhScGIyNXpRM1Z5Y21WdWRGQmhaMlVnUFNCQ2IzaE5ZWEE4WVhKak5DNUJaR1J5WlhOekxDQmhjbU0wTGxWcGJuUk9OalErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOW9jRjl3SnlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKaGNtTXhOREV3WDJod1gzQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakkyTmdvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5EZFhKeVpXNTBVR0ZuWlNob2IyeGtaWElwTG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dYMkZrWkY5d1lYSjBhV05wY0dGMGFXOXVYM1J2WDJodmJHUmxjbDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNalkzQ2lBZ0lDQXZMeUIwYUdsekxtaHZiR1JsY2xCaGNuUnBkR2x2Ym5ORGRYSnlaVzUwVUdGblpTaG9iMnhrWlhJcExuWmhiSFZsSUQwZ2NHRm5aUW9nSUNBZ1puSmhiV1ZmWkdsbklERXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakkyTlFvZ0lDQWdMeThnYkdWMElIQmhaMlVnUFNCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcENpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qWTNDaUFnSUNBdkx5QjBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5EZFhKeVpXNTBVR0ZuWlNob2IyeGtaWElwTG5aaGJIVmxJRDBnY0dGblpRb2dJQ0FnWW05NFgzQjFkQW9LWDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2w5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJMk9Rb2dJQ0FnTHk4Z1kyOXVjM1FnYkdGemRGQmhaMlVnUFNCMGFHbHpMbWh2YkdSbGNsQmhjblJwZEdsdmJuTkRkWEp5Wlc1MFVHRm5aU2hvYjJ4a1pYSXBMblpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTVRBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qY3dDaUFnSUNBdkx5QnNaWFFnWm05MWJtUWdQU0JtWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU5qVUtJQ0FnSUM4dklHeGxkQ0J3WVdkbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DZ3dLUW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakkzTVFvZ0lDQWdMeThnWm05eUlDaHNaWFFnWTNWeVVHRm5aU0E5SUhCaFoyVTdJR04xY2xCaFoyVXVibUYwYVhabElEd2diR0Z6ZEZCaFoyVXVibUYwYVhabE95QmpkWEpRWVdkbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaGpkWEpRWVdkbExtNWhkR2wyWlNBcklERXBLU0I3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLQ2w5aFpHUmZjR0Z5ZEdsamFYQmhkR2x2Ymw5MGIxOW9iMnhrWlhKZmQyaHBiR1ZmZEc5d1FETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakkzTVFvZ0lDQWdMeThnWm05eUlDaHNaWFFnWTNWeVVHRm5aU0E5SUhCaFoyVTdJR04xY2xCaFoyVXVibUYwYVhabElEd2diR0Z6ZEZCaFoyVXVibUYwYVhabE95QmpkWEpRWVdkbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaGpkWEpRWVdkbExtNWhkR2wyWlNBcklERXBLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnT1FvZ0lDQWdQQW9nSUNBZ1lub2dYMkZrWkY5d1lYSjBhV05wY0dGMGFXOXVYM1J2WDJodmJHUmxjbDlpYkc5amEwQXhNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TnpJdE1qYzFDaUFnSUNBdkx5QmpiMjV6ZENCd1lXZHBibUYwWldSTFpYa2dQU0J1WlhjZ1lYSmpNVFF4TUY5SWIyeGthVzVuVUdGeWRHbDBhVzl1YzFCaFoybHVZWFJsWkV0bGVTaDdDaUFnSUNBdkx5QWdJR2h2YkdSbGNqb2dhRzlzWkdWeUxBb2dJQ0FnTHk4Z0lDQndZV2RsT2lCamRYSlFZV2RsTEFvZ0lDQWdMeThnZlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOW9jRjloSnl3S0lDQWdJR0o1ZEdWaklESXhJQzh2SUNKaGNtTXhOREV3WDJod1gyRWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakkzTmdvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5CWkdSeVpYTnpaWE1vY0dGbmFXNWhkR1ZrUzJWNUtTNWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUY5aFpHUmZjR0Z5ZEdsamFYQmhkR2x2Ymw5MGIxOW9iMnhrWlhKZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJM053b2dJQ0FnTHk4Z2RHaHBjeTVvYjJ4a1pYSlFZWEowYVhScGIyNXpRV1JrY21WemMyVnpLSEJoWjJsdVlYUmxaRXRsZVNrdWRtRnNkV1VnUFNCYmNHRnlkR2xqYVhCaGRHbHZibDBLSUNBZ0lHSjVkR1ZqSURJMklDOHZJREI0TURBd01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9LWDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2w5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJNE1Bb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdVkyOXVkR0ZwYm5OQlpHUnlaWE56S0hSb2FYTXVhRzlzWkdWeVVHRnlkR2wwYVc5dWMwRmtaSEpsYzNObGN5aHdZV2RwYm1GMFpXUkxaWGtwTG5aaGJIVmxMQ0J3WVhKMGFXTnBjR0YwYVc5dUtTa2dld29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TlRRS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2RpQnZaaUJoS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgySjFjbmtnTlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOd29LWDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2w5bWIzSmZhR1ZoWkdWeVFERTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95TlRRS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2RpQnZaaUJoS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTndvZ0lDQWdabkpoYldWZlpHbG5JRFVLSUNBZ0lEd0tJQ0FnSUdKNklGOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZZV1owWlhKZlptOXlRREl4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBM0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJMU5Rb2dJQ0FnTHk4Z2FXWWdLSFlnUFQwOUlIZ3BJSEpsZEhWeWJpQjBjblZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNCaWVpQmZZV1JrWDNCaGNuUnBZMmx3WVhScGIyNWZkRzlmYUc5c1pHVnlYMkZtZEdWeVgybG1YMlZzYzJWQU1qQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENncGZZV1JrWDNCaGNuUnBZMmx3WVhScGIyNWZkRzlmYUc5c1pHVnlYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzZRWEpqTVRReE1DNWpiMjUwWVdsdWMwRmtaSEpsYzNOQU1qSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakk0TUFvZ0lDQWdMeThnYVdZZ0tIUm9hWE11WTI5dWRHRnBibk5CWkdSeVpYTnpLSFJvYVhNdWFHOXNaR1Z5VUdGeWRHbDBhVzl1YzBGa1pISmxjM05sY3lod1lXZHBibUYwWldSTFpYa3BMblpoYkhWbExDQndZWEowYVdOcGNHRjBhVzl1S1NrZ2V3b2dJQ0FnWW5vZ1gyRmtaRjl3WVhKMGFXTnBjR0YwYVc5dVgzUnZYMmh2YkdSbGNsOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qZ3hDaUFnSUNBdkx5Qm1iM1Z1WkNBOUlIUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEWUtDbDloWkdSZmNHRnlkR2xqYVhCaGRHbHZibDkwYjE5b2IyeGtaWEpmWW14dlkydEFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pJNE5Rb2dJQ0FnTHk4Z2FXWWdLQ0ZtYjNWdVpDa2dld29nSUNBZ1puSmhiV1ZmWkdsbklEWUtJQ0FnSUdKdWVpQmZZV1JrWDNCaGNuUnBZMmx3WVhScGIyNWZkRzlmYUc5c1pHVnlYMkZtZEdWeVgybG1YMlZzYzJWQU1UVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNamcyTFRJNE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0dGbmFXNWhkR1ZrUzJWNUlEMGdibVYzSUdGeVl6RTBNVEJmU0c5c1pHbHVaMUJoY25ScGRHbHZibk5RWVdkcGJtRjBaV1JMWlhrb2V3b2dJQ0FnTHk4Z0lDQm9iMnhrWlhJNklHaHZiR1JsY2l3S0lDQWdJQzh2SUNBZ2NHRm5aVG9nYkdGemRGQmhaMlVzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCclpYbFFjbVZtYVhnNklDZGhjbU14TkRFd1gyaHdYMkVuTEFvZ0lDQWdZbmwwWldNZ01qRWdMeThnSW1GeVl6RTBNVEJmYUhCZllTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNamt3Q2lBZ0lDQXZMeUJqYjI1emRDQnBkR1Z0YzBOdmRXNTBJRDBnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2gwYUdsekxtaHZiR1JsY2xCaGNuUnBkR2x2Ym5OQlpHUnlaWE56WlhNb2NHRm5hVzVoZEdWa1MyVjVLUzUyWVd4MVpTNXNaVzVuZEdncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTVNUW9nSUNBZ0x5OGdhV1lnS0dsMFpXMXpRMjkxYm5RdWJtRjBhWFpsSUR3Z01UQXBJSHNLSUNBZ0lHSjBiMmtLSUNBZ0lIQjFjMmhwYm5RZ01UQWdMeThnTVRBS0lDQWdJRHdLSUNBZ0lHSjZJRjloWkdSZmNHRnlkR2xqYVhCaGRHbHZibDkwYjE5b2IyeGtaWEpmWld4elpWOWliMlI1UURFekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTVOQW9nSUNBZ0x5OGdMaTR1ZEdocGN5NW9iMnhrWlhKUVlYSjBhWFJwYjI1elFXUmtjbVZ6YzJWektIQmhaMmx1WVhSbFpFdGxlU2t1ZG1Gc2RXVXNDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3lPVE10TWprMkNpQWdJQ0F2THlCMGFHbHpMbWh2YkdSbGNsQmhjblJwZEdsdmJuTkJaR1J5WlhOelpYTW9jR0ZuYVc1aGRHVmtTMlY1S1M1MllXeDFaU0E5SUZzS0lDQWdJQzh2SUNBZ0xpNHVkR2hwY3k1b2IyeGtaWEpRWVhKMGFYUnBiMjV6UVdSa2NtVnpjMlZ6S0hCaFoybHVZWFJsWkV0bGVTa3VkbUZzZFdVc0NpQWdJQ0F2THlBZ0lIQmhjblJwWTJsd1lYUnBiMjRzQ2lBZ0lDQXZMeUJkQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem95T1RVS0lDQWdJQzh2SUhCaGNuUnBZMmx3WVhScGIyNHNDaUFnSUNCaWVYUmxZeUF5TmlBdkx5QXdlREF3TURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTVNeTB5T1RZS0lDQWdJQzh2SUhSb2FYTXVhRzlzWkdWeVVHRnlkR2wwYVc5dWMwRmtaSEpsYzNObGN5aHdZV2RwYm1GMFpXUkxaWGtwTG5aaGJIVmxJRDBnV3dvZ0lDQWdMeThnSUNBdUxpNTBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5CWkdSeVpYTnpaWE1vY0dGbmFXNWhkR1ZrUzJWNUtTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ2NHRnlkR2xqYVhCaGRHbHZiaXdLSUNBZ0lDOHZJRjBLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUM4S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLQ2w5aFpHUmZjR0Z5ZEdsamFYQmhkR2x2Ymw5MGIxOW9iMnhrWlhKZllXWjBaWEpmYVdaZlpXeHpaVUF4TlRvS0lDQWdJSEpsZEhOMVlnb0tYMkZrWkY5d1lYSjBhV05wY0dGMGFXOXVYM1J2WDJodmJHUmxjbDlsYkhObFgySnZaSGxBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qSTVPQW9nSUNBZ0x5OGdZMjl1YzNRZ2JtVjNUR0Z6ZEZCaFoyVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLR3hoYzNSUVlXZGxMbTVoZEdsMlpTQXJJREVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dPUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qazVDaUFnSUNBdkx5QjBhR2x6TG1odmJHUmxjbEJoY25ScGRHbHZibk5EZFhKeVpXNTBVR0ZuWlNob2IyeGtaWElwTG5aaGJIVmxJRDBnYm1WM1RHRnpkRkJoWjJVS0lDQWdJR1p5WVcxbFgyUnBaeUF4TUFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNekF3TFRNd013b2dJQ0FnTHk4Z1kyOXVjM1FnYm1WM1VHRm5hVzVoZEdWa1MyVjVJRDBnYm1WM0lHRnlZekUwTVRCZlNHOXNaR2x1WjFCaGNuUnBkR2x2Ym5OUVlXZHBibUYwWldSTFpYa29ld29nSUNBZ0x5OGdJQ0JvYjJ4a1pYSTZJR2h2YkdSbGNpd0tJQ0FnSUM4dklDQWdjR0ZuWlRvZ2JtVjNUR0Z6ZEZCaFoyVXNDaUFnSUNBdkx5QjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXpBMENpQWdJQ0F2THlCMGFHbHpMbWh2YkdSbGNsQmhjblJwZEdsdmJuTkJaR1J5WlhOelpYTW9ibVYzVUdGbmFXNWhkR1ZrUzJWNUtTNTJZV3gxWlNBOUlGdHdZWEowYVdOcGNHRjBhVzl1WFFvZ0lDQWdZbmwwWldNZ01qWWdMeThnTUhnd01EQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnYTJWNVVISmxabWw0T2lBbllYSmpNVFF4TUY5b2NGOWhKeXdLSUNBZ0lHSjVkR1ZqSURJeElDOHZJQ0poY21NeE5ERXdYMmh3WDJFaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek1EUUtJQ0FnSUM4dklIUm9hWE11YUc5c1pHVnlVR0Z5ZEdsMGFXOXVjMEZrWkhKbGMzTmxjeWh1WlhkUVlXZHBibUYwWldSTFpYa3BMblpoYkhWbElEMGdXM0JoY25ScFkybHdZWFJwYjI1ZENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dwZllXUmtYM0JoY25ScFkybHdZWFJwYjI1ZmRHOWZhRzlzWkdWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk1qY3hDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQmpkWEpRWVdkbElEMGdjR0ZuWlRzZ1kzVnlVR0ZuWlM1dVlYUnBkbVVnUENCc1lYTjBVR0ZuWlM1dVlYUnBkbVU3SUdOMWNsQmhaMlVnUFNCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0dOMWNsQmhaMlV1Ym1GMGFYWmxJQ3NnTVNrcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCaUlGOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSmZkMmhwYkdWZmRHOXdRRE1LQ2w5aFpHUmZjR0Z5ZEdsamFYQmhkR2x2Ymw5MGIxOW9iMnhrWlhKZllXWjBaWEpmYVdaZlpXeHpaVUF5TURvS0lDQWdJR1p5WVcxbFgyUnBaeUEzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBM0NpQWdJQ0JpSUY5aFpHUmZjR0Z5ZEdsamFYQmhkR2x2Ymw5MGIxOW9iMnhrWlhKZlptOXlYMmhsWVdSbGNrQXhOd29LWDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2w5aFpuUmxjbDltYjNKQU1qRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPakkxTndvZ0lDQWdMeThnY21WMGRYSnVJR1poYkhObENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pveU9EQUtJQ0FnSUM4dklHbG1JQ2gwYUdsekxtTnZiblJoYVc1elFXUmtjbVZ6Y3loMGFHbHpMbWh2YkdSbGNsQmhjblJwZEdsdmJuTkJaR1J5WlhOelpYTW9jR0ZuYVc1aGRHVmtTMlY1S1M1MllXeDFaU3dnY0dGeWRHbGphWEJoZEdsdmJpa3BJSHNLSUNBZ0lHSWdYMkZrWkY5d1lYSjBhV05wY0dGMGFXOXVYM1J2WDJodmJHUmxjbDloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPa0Z5WXpFME1UQXVZMjl1ZEdGcGJuTkJaR1J5WlhOelFESXlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzZRWEpqTVRReE1DNWZkSEpoYm5ObVpYSmZjR0Z5ZEdsMGFXOXVLR1p5YjIwNklHSjVkR1Z6TENCbWNtOXRVR0Z5ZEdsMGFXOXVPaUJpZVhSbGN5d2dkRzg2SUdKNWRHVnpMQ0IwYjFCaGNuUnBkR2x2YmpvZ1lubDBaWE1zSUdGdGIzVnVkRG9nWW5sMFpYTXNJR1JoZEdFNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZmRISmhibk5tWlhKZmNHRnlkR2wwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pNVGd0TXpJMUNpQWdJQ0F2THlCd2NtOTBaV04wWldRZ1gzUnlZVzV6Wm1WeVgzQmhjblJwZEdsdmJpZ0tJQ0FnSUM4dklDQWdabkp2YlRvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JtY205dFVHRnlkR2wwYVc5dU9pQmhjbU0wTGtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUhSdk9pQmhjbU0wTGtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUhSdlVHRnlkR2wwYVc5dU9pQmhjbU0wTGtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nWVhKak5DNVZhVzUwVGpJMU5pd0tJQ0FnSUM4dklDQWdaR0YwWVRvZ1lYSmpOQzVFZVc1aGJXbGpRbmwwWlhNc0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklEWWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pNallLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhiVzkxYm5RdWJtRjBhWFpsSUQ0Z01Dd2dKMGx1ZG1Gc2FXUWdZVzF2ZFc1MEp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0JpUGdvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdZVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTXlPQW9nSUNBZ0x5OGdZMjl1YzNRZ1puSnZiVXRsZVNBOUlHNWxkeUJoY21NeE5ERXdYMUJoY25ScGRHbHZia3RsZVNoN0lHaHZiR1JsY2pvZ1puSnZiU3dnY0dGeWRHbDBhVzl1T2lCbWNtOXRVR0Z5ZEdsMGFXOXVJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCd2RXSnNhV01nY0dGeWRHbDBhVzl1Y3lBOUlFSnZlRTFoY0R4aGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTd2dZWEpqTkM1VmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RoY21NeE5ERXdYM0FuSUgwcENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKaGNtTXhOREV3WDNBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pNamtLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTV3WVhKMGFYUnBiMjV6S0daeWIyMUxaWGtwTG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dYM1J5WVc1elptVnlYM0JoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNek13Q2lBZ0lDQXZMeUIwYUdsekxuQmhjblJwZEdsdmJuTW9abkp2YlV0bGVTa3VkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpJMU5pZ3dLUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaWIzaGZjSFYwQ2dwZmRISmhibk5tWlhKZmNHRnlkR2wwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16TXlDaUFnSUNBdkx5QjBhR2x6TG5CaGNuUnBkR2x2Ym5Nb1puSnZiVXRsZVNrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmloMGFHbHpMbkJoY25ScGRHbHZibk1vWm5KdmJVdGxlU2t1ZG1Gc2RXVXVibUYwYVhabElDMGdZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSXRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWW53S0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNek0zTFRNME13b2dJQ0FnTHk4Z2JtVjNJR0Z5WXpFME1UQmZjR0Z5ZEdsMGFXOXVYM1J5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnWm5KdmJUb2dabkp2YlN3S0lDQWdJQzh2SUNBZ2RHODZJSFJ2TEFvZ0lDQWdMeThnSUNCd1lYSjBhWFJwYjI0NklHWnliMjFRWVhKMGFYUnBiMjRzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0JrWVhSaE9pQmtZWFJoTEFvZ0lDQWdMeThnZlNrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdPRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16TTFMVE0wTkFvZ0lDQWdMeThnWlcxcGRDZ0tJQ0FnSUM4dklDQWdKMVJ5WVc1elptVnlKeXdLSUNBZ0lDOHZJQ0FnYm1WM0lHRnlZekUwTVRCZmNHRnlkR2wwYVc5dVgzUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0JtY205dE9pQm1jbTl0TEFvZ0lDQWdMeThnSUNBZ0lIUnZPaUIwYnl3S0lDQWdJQzh2SUNBZ0lDQndZWEowYVhScGIyNDZJR1p5YjIxUVlYSjBhWFJwYjI0c0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdaR0YwWVRvZ1pHRjBZU3dLSUNBZ0lDOHZJQ0FnZlNrc0NpQWdJQ0F2THlBcENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1EQXdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5TURaaU56azBNQ0F2THlCdFpYUm9iMlFnSWxSeVlXNXpabVZ5S0NoaFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJMR0o1ZEdWYlhTa3BJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXpRM0NpQWdJQ0F2THlCcFppQW9kRzlRWVhKMGFYUnBiMjRnSVQwOUlHWnliMjFRWVhKMGFYUnBiMjRwSUhzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQWhQUW9nSUNBZ1lub2dYM1J5WVc1elptVnlYM0JoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNelE0Q2lBZ0lDQXZMeUIwYUdsekxsOWhaR1JmY0dGeWRHbGphWEJoZEdsdmJsOTBiMTlvYjJ4a1pYSW9kRzhzSUhSdlVHRnlkR2wwYVc5dUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR05oYkd4emRXSWdYMkZrWkY5d1lYSjBhV05wY0dGMGFXOXVYM1J2WDJodmJHUmxjZ29LWDNSeVlXNXpabVZ5WDNCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNMU1nb2dJQ0FnTHk4Z1kyOXVjM1FnZEc5TFpYa2dQU0J1WlhjZ1lYSmpNVFF4TUY5UVlYSjBhWFJwYjI1TFpYa29leUJvYjJ4a1pYSTZJSFJ2TENCd1lYSjBhWFJwYjI0NklIUnZVR0Z5ZEdsMGFXOXVJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCd2RXSnNhV01nY0dGeWRHbDBhVzl1Y3lBOUlFSnZlRTFoY0R4aGNtTXhOREV3WDFCaGNuUnBkR2x2Ymt0bGVTd2dZWEpqTkM1VmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RoY21NeE5ERXdYM0FuSUgwcENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKaGNtTXhOREV3WDNBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTTFNd29nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbkJoY25ScGRHbHZibk1vZEc5TFpYa3BMbVY0YVhOMGN5a2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1gzUnlZVzV6Wm1WeVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16VTBDaUFnSUNBdkx5QjBhR2x6TG5CaGNuUnBkR2x2Ym5Nb2RHOUxaWGtwTG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1VldsdWRFNHlOVFlvTUNrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZbTk0WDNCMWRBb0tYM1J5WVc1elptVnlYM0JoY25ScGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPak0xTmdvZ0lDQWdMeThnZEdocGN5NXdZWEowYVhScGIyNXpLSFJ2UzJWNUtTNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTWpVMktIUm9hWE11Y0dGeWRHbDBhVzl1Y3loMGIwdGxlU2t1ZG1Gc2RXVXVibUYwYVhabElDc2dZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSXJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW53S0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZPa0Z5WXpFME1UQXVZWEpqTVRReE1GOWhkWFJvYjNKcGVtVmZiM0JsY21GMGIzSmZZbmxmY0c5eWRHbHZiaWhvYjJ4a1pYSTZJR0o1ZEdWekxDQnZjR1Z5WVhSdmNqb2dZbmwwWlhNc0lIQmhjblJwZEdsdmJqb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21GeVl6RTBNVEJmWVhWMGFHOXlhWHBsWDI5d1pYSmhkRzl5WDJKNVgzQnZjblJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTTFPUzB6TmpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTVRReE1GOWhkWFJvYjNKcGVtVmZiM0JsY21GMGIzSmZZbmxmY0c5eWRHbHZiaWdLSUNBZ0lDOHZJQ0FnYUc5c1pHVnlPaUJoY21NMExrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHOXdaWEpoZEc5eU9pQmhjbU0wTGtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUhCaGNuUnBkR2x2YmpvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJR0Z5WXpRdVZXbHVkRTR5TlRZc0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklEUWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem96TmpZS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwSUQwOVBTQm9iMnhrWlhJc0lDZFBibXg1SUdodmJHUmxjaUJqWVc0Z1lYVjBhRzl5YVhwbElIQnZjblJwYjI0bktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnYUc5c1pHVnlJR05oYmlCaGRYUm9iM0pwZW1VZ2NHOXlkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek5qY0tJQ0FnSUM4dklHTnZibk4wSUd0bGVTQTlJRzVsZHlCaGNtTXhOREV3WDA5d1pYSmhkRzl5VUc5eWRHbHZia3RsZVNoN0lHaHZiR1JsY2l3Z2IzQmxjbUYwYjNJc0lIQmhjblJwZEdsdmJpQjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUhCMVlteHBZeUJ2Y0dWeVlYUnZjbEJ2Y25ScGIyNUJiR3h2ZDJGdVkyVnpJRDBnUW05NFRXRndQR0Z5WXpFME1UQmZUM0JsY21GMGIzSlFiM0owYVc5dVMyVjVMQ0JoY21NMExsVnBiblJPTWpVMlBpaDdJR3RsZVZCeVpXWnBlRG9nSjJGeVl6RTBNVEJmYjNCaEp5QjlLUW9nSUNBZ1lubDBaV01nTVRjZ0x5OGdJbUZ5WXpFME1UQmZiM0JoSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTTJPQW9nSUNBZ0x5OGdkR2hwY3k1dmNHVnlZWFJ2Y2xCdmNuUnBiMjVCYkd4dmQyRnVZMlZ6S0d0bGVTa3VkbUZzZFdVZ1BTQmhiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzZRWEpqTVRReE1DNWhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlYMko1WDNCdmNuUnBiMjRvYUc5c1pHVnlPaUJpZVhSbGN5d2diM0JsY21GMGIzSTZJR0o1ZEdWekxDQndZWEowYVhScGIyNDZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjbDlpZVY5d2IzSjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek56RXRNemMyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekUwTVRCZmFYTmZiM0JsY21GMGIzSmZZbmxmY0c5eWRHbHZiaWdLSUNBZ0lDOHZJQ0FnYUc5c1pHVnlPaUJoY21NMExrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHOXdaWEpoZEc5eU9pQmhjbU0wTGtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUhCaGNuUnBkR2x2YmpvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdLVG9nWVhKak5DNUNiMjlzSUhzS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZNemMzQ2lBZ0lDQXZMeUJwWmlBb2IzQmxjbUYwYjNJZ1BUMDlJR2h2YkdSbGNpa2djbVYwZFhKdUlHNWxkeUJoY21NMExrSnZiMndvZEhKMVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0E5UFFvZ0lDQWdZbm9nWVhKak1UUXhNRjlwYzE5dmNHVnlZWFJ2Y2w5aWVWOXdiM0owYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURnd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbUZ5WXpFME1UQmZhWE5mYjNCbGNtRjBiM0pmWW5sZmNHOXlkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNM09Bb2dJQ0FnTHk4Z1kyOXVjM1FnYTJWNUlEMGdibVYzSUdGeVl6RTBNVEJmVDNCbGNtRjBiM0pRYjNKMGFXOXVTMlY1S0hzZ2FHOXNaR1Z5TENCdmNHVnlZWFJ2Y2l3Z2NHRnlkR2wwYVc5dUlIMHBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnY0hWaWJHbGpJRzl3WlhKaGRHOXlVRzl5ZEdsdmJrRnNiRzkzWVc1alpYTWdQU0JDYjNoTllYQThZWEpqTVRReE1GOVBjR1Z5WVhSdmNsQnZjblJwYjI1TFpYa3NJR0Z5WXpRdVZXbHVkRTR5TlRZK0tIc2dhMlY1VUhKbFptbDRPaUFuWVhKak1UUXhNRjl2Y0dFbklIMHBDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QWlZWEpqTVRReE1GOXZjR0VpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pNM09Rb2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxtOXdaWEpoZEc5eVVHOXlkR2x2YmtGc2JHOTNZVzVqWlhNb2EyVjVLUzVsZUdsemRITXBJSEpsZEhWeWJpQnVaWGNnWVhKak5DNUNiMjlzS0daaGJITmxLUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1lYSmpNVFF4TUY5cGMxOXZjR1Z5WVhSdmNsOWllVjl3YjNKMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZ3dNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwaGNtTXhOREV3WDJselgyOXdaWEpoZEc5eVgySjVYM0J2Y25ScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pPREFLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnWVhKak5DNUNiMjlzS0hSb2FYTXViM0JsY21GMGIzSlFiM0owYVc5dVFXeHNiM2RoYm1ObGN5aHJaWGtwTG5aaGJIVmxMbTVoZEdsMlpTQStJREFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzZRWEpqTVRReE1DNWhjbU14TkRFd1gybHpjM1ZsWDJKNVgzQmhjblJwZEdsdmJpaDBiem9nWW5sMFpYTXNJSEJoY25ScGRHbHZiam9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNc0lHUmhkR0U2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoY21NeE5ERXdYMmx6YzNWbFgySjVYM0JoY25ScGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXpnekxUTTRPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXhOREV3WDJsemMzVmxYMko1WDNCaGNuUnBkR2x2YmlnS0lDQWdJQzh2SUNBZ2RHODZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ2NHRnlkR2wwYVc5dU9pQmhjbU0wTGtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nWVhKak5DNVZhVzUwVGpJMU5pd0tJQ0FnSUM4dklDQWdaR0YwWVRvZ1lYSmpOQzVFZVc1aGJXbGpRbmwwWlhNc0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklEUWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pPVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1GeVl6ZzRYMmx6WDI5M2JtVnlLRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtwTG01aGRHbDJaU0E5UFQwZ2RISjFaU3dnSjI5dWJIbGZiM2R1WlhJbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMkZzYkhOMVlpQmhjbU00T0Y5cGMxOXZkMjVsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlVjl2ZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6b3pPVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhiVzkxYm5RdWJtRjBhWFpsSUQ0Z01Dd2dKMGx1ZG1Gc2FXUWdZVzF2ZFc1MEp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0JpUGdvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdZVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qTTVNd29nSUNBZ0x5OGdZMjl1YzNRZ2RHOUxaWGtnUFNCdVpYY2dZWEpqTVRReE1GOVFZWEowYVhScGIyNUxaWGtvZXlCb2IyeGtaWEk2SUhSdkxDQndZWEowYVhScGIyNGdmU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnY0hWaWJHbGpJSEJoY25ScGRHbHZibk1nUFNCQ2IzaE5ZWEE4WVhKak1UUXhNRjlRWVhKMGFYUnBiMjVMWlhrc0lHRnlZelF1VldsdWRFNHlOVFkrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZWEpqTVRReE1GOXdKeUI5S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWVhKak1UUXhNRjl3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk16azBDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXVjR0Z5ZEdsMGFXOXVjeWgwYjB0bGVTa3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCaGNtTXhOREV3WDJsemMzVmxYMko1WDNCaGNuUnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TXprMUNpQWdJQ0F2THlCMGFHbHpMbkJoY25ScGRHbHZibk1vZEc5TFpYa3BMblpoYkhWbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0eU5UWW9NQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek9UWUtJQ0FnSUM4dklIUm9hWE11WDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2loMGJ5d2djR0Z5ZEdsMGFXOXVLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOaGJHeHpkV0lnWDJGa1pGOXdZWEowYVdOcGNHRjBhVzl1WDNSdlgyaHZiR1JsY2dvS1lYSmpNVFF4TUY5cGMzTjFaVjlpZVY5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvek9UZ0tJQ0FnSUM4dklIUm9hWE11Y0dGeWRHbDBhVzl1Y3loMGIwdGxlU2t1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWgwYUdsekxuQmhjblJwZEdsdmJuTW9kRzlMWlhrcExuWmhiSFZsTG01aGRHbDJaU0FySUdGdGIzVnVkQzV1WVhScGRtVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHSjhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUhCMVlteHBZeUJpWVd4aGJtTmxjeUE5SUVKdmVFMWhjRHhCWkdSeVpYTnpMQ0JWYVc1MFRqSTFOajRvZXlCclpYbFFjbVZtYVhnNklDZGlKeUI5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWWlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME1EQUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NWlZV3hoYm1ObGN5aDBieWt1WlhocGMzUnpLU0I3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQmhjbU14TkRFd1gybHpjM1ZsWDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5EQXhDaUFnSUNBdkx5QjBhR2x6TG1KaGJHRnVZMlZ6S0hSdktTNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTWpVMktEQXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdKdmVGOXdkWFFLQ21GeVl6RTBNVEJmYVhOemRXVmZZbmxmY0dGeWRHbDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRBekNpQWdJQ0F2THlCMGFHbHpMbUpoYkdGdVkyVnpLSFJ2S1M1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUk9NalUyS0hSb2FYTXVZbUZzWVc1alpYTW9kRzhwTG5aaGJIVmxMbTVoZEdsMlpTQXJJR0Z0YjNWdWRDNXVZWFJwZG1VcENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlLd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1lud0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnY0hWaWJHbGpJSFJ2ZEdGc1UzVndjR3g1SUQwZ1IyeHZZbUZzVTNSaGRHVThWV2x1ZEU0eU5UWStLSHNnYTJWNU9pQW5kQ2NnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRBMENpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1VldsdWRFNHlOVFlvZEdocGN5NTBiM1JoYkZOMWNIQnNlUzUyWVd4MVpTNXVZWFJwZG1VZ0t5QmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlLd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1lud0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdjSFZpYkdsaklIUnZkR0ZzVTNWd2NHeDVJRDBnUjJ4dlltRnNVM1JoZEdVOFZXbHVkRTR5TlRZK0tIc2dhMlY1T2lBbmRDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRd05Bb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGTjFjSEJzZVM1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUk9NalUyS0hSb2FYTXVkRzkwWVd4VGRYQndiSGt1ZG1Gc2RXVXVibUYwYVhabElDc2dZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUXdOUW9nSUNBZ0x5OGdaVzFwZENnblNYTnpkV1VuTENCdVpYY2dZWEpqTVRReE1GOXdZWEowYVhScGIyNWZhWE56ZFdVb2V5QjBieXdnY0dGeWRHbDBhVzl1TENCaGJXOTFiblFzSUdSaGRHRWdmU2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURJM0lDOHZJREI0TURBMk1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3TURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptRTBORE5pTVdJZ0x5OGdiV1YwYUc5a0lDSkpjM04xWlNnb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlzWW5sMFpWdGRLU2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvNlFYSmpNVFF4TUM1aGNtTXhOREV3WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI0b2NHRnlkR2wwYVc5dU9pQmllWFJsY3l3Z1lXMXZkVzUwT2lCaWVYUmxjeXdnWkdGMFlUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtRnlZekUwTVRCZmNtVmtaV1Z0WDJKNVgzQmhjblJwZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOREE0TFRRd09Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeE5ERXdYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjRvY0dGeWRHbDBhVzl1T2lCaGNtTTBMa0ZrWkhKbGMzTXNJR0Z0YjNWdWREb2dZWEpqTkM1VmFXNTBUakkxTml3Z1pHRjBZVG9nWVhKak5DNUVlVzVoYldsalFubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNVEFLSUNBZ0lDOHZJR052Ym5OMElHWnliMjBnUFNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pReE1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dGdGIzVnVkQzV1WVhScGRtVWdQaUF3TENBblNXNTJZV3hwWkNCaGJXOTFiblFuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHSStDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkNCaGJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRFeUNpQWdJQ0F2THlCamIyNXpkQ0JtY205dFMyVjVJRDBnYm1WM0lHRnlZekUwTVRCZlVHRnlkR2wwYVc5dVMyVjVLSHNnYUc5c1pHVnlPaUJtY205dExDQndZWEowYVhScGIyNGdmU2tLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z2NIVmliR2xqSUhCaGNuUnBkR2x2Ym5NZ1BTQkNiM2hOWVhBOFlYSmpNVFF4TUY5UVlYSjBhWFJwYjI1TFpYa3NJR0Z5WXpRdVZXbHVkRTR5TlRZK0tIc2dhMlY1VUhKbFptbDRPaUFuWVhKak1UUXhNRjl3SnlCOUtRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVlYSmpNVFF4TUY5d0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalF4TXdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWNHRnlkR2wwYVc5dWN5aG1jbTl0UzJWNUtTNWxlR2x6ZEhNc0lDZFFZWEowYVhScGIyNGdZbUZzWVc1alpTQnRhWE56YVc1bkp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Z5ZEdsMGFXOXVJR0poYkdGdVkyVWdiV2x6YzJsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5CaGNuUnBkR2x2Ym5Nb1puSnZiVXRsZVNrdWRtRnNkV1V1Ym1GMGFYWmxJRDQ5SUdGdGIzVnVkQzV1WVhScGRtVXNJQ2RKYm5OMVptWnBZMmxsYm5RZ2NHRnlkR2wwYVc5dUlHSmhiR0Z1WTJVbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ2NHRnlkR2wwYVc5dUlHSmhiR0Z1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5ERTFDaUFnSUNBdkx5QjBhR2x6TG5CaGNuUnBkR2x2Ym5Nb1puSnZiVXRsZVNrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmloMGFHbHpMbkJoY25ScGRHbHZibk1vWm5KdmJVdGxlU2t1ZG1Gc2RXVXVibUYwYVhabElDMGdZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaTBLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdZbndLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z2NIVmliR2xqSUdKaGJHRnVZMlZ6SUQwZ1FtOTRUV0Z3UEVGa1pISmxjM01zSUZWcGJuUk9NalUyUGloN0lHdGxlVkJ5WldacGVEb2dKMkluSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZOREUzQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aVlXeGhibU5sY3lobWNtOXRLUzVsZUdsemRITWdKaVlnZEdocGN5NWlZV3hoYm1ObGN5aG1jbTl0S1M1MllXeDFaUzV1WVhScGRtVWdQajBnWVcxdmRXNTBMbTVoZEdsMlpTd2dKMGx1YzNWbVptbGphV1Z1ZENCaVlXeGhibU5sSnlrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZWEpqTVRReE1GOXlaV1JsWlcxZllubGZjR0Z5ZEdsMGFXOXVYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSStQUW9nSUNBZ1lub2dZWEpqTVRReE1GOXlaV1JsWlcxZllubGZjR0Z5ZEdsMGFXOXVYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ21GeVl6RTBNVEJmY21Wa1pXVnRYMko1WDNCaGNuUnBkR2x2Ymw5aWIyOXNYMjFsY21kbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalF4TndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltRnNZVzVqWlhNb1puSnZiU2t1WlhocGMzUnpJQ1ltSUhSb2FYTXVZbUZzWVc1alpYTW9abkp2YlNrdWRtRnNkV1V1Ym1GMGFYWmxJRDQ5SUdGdGIzVnVkQzV1WVhScGRtVXNJQ2RKYm5OMVptWnBZMmxsYm5RZ1ltRnNZVzVqWlNjcENpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElHSmhiR0Z1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5ERTRDaUFnSUNBdkx5QjBhR2x6TG1KaGJHRnVZMlZ6S0daeWIyMHBMblpoYkhWbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0eU5UWW9kR2hwY3k1aVlXeGhibU5sY3lobWNtOXRLUzUyWVd4MVpTNXVZWFJwZG1VZ0xTQmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpMEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdKOENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjBiM1JoYkZOMWNIQnNlU0E5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTWpVMlBpaDdJR3RsZVRvZ0ozUW5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalF4T1FvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkZOMWNIQnNlUzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5ST01qVTJLSFJvYVhNdWRHOTBZV3hUZFhCd2JIa3VkbUZzZFdVdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpMEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdKOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIQjFZbXhwWXlCMGIzUmhiRk4xY0hCc2VTQTlJRWRzYjJKaGJGTjBZWFJsUEZWcGJuUk9NalUyUGloN0lHdGxlVG9nSjNRbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTVRrS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VGRYQndiSGt1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqSTFOaWgwYUdsekxuUnZkR0ZzVTNWd2NHeDVMblpoYkhWbExtNWhkR2wyWlNBdElHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME1qQUtJQ0FnSUM4dklHVnRhWFFvSjFKbFpHVmxiU2NzSUc1bGR5QmhjbU14TkRFd1gzQmhjblJwZEdsdmJsOXlaV1JsWlcwb2V5Qm1jbTl0TENCd1lYSjBhWFJwYjI0c0lHRnRiM1Z1ZEN3Z1pHRjBZU0I5S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01qY2dMeThnTUhnd01EWXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUF6TVNBdkx5QnRaWFJvYjJRZ0lsSmxaR1ZsYlNnb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlzWW5sMFpWdGRLU2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjbVYwYzNWaUNncGhjbU14TkRFd1gzSmxaR1ZsYlY5aWVWOXdZWEowYVhScGIyNWZZbTl2YkY5bVlXeHpaVUF6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdZWEpqTVRReE1GOXlaV1JsWlcxZllubGZjR0Z5ZEdsMGFXOXVYMkp2YjJ4ZmJXVnlaMlZBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02T2tGeVl6RTBNVEF1WVhKak1UUXhNRjl2Y0dWeVlYUnZjbDl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1S0daeWIyMDZJR0o1ZEdWekxDQndZWEowYVhScGIyNDZJR0o1ZEdWekxDQmhiVzkxYm5RNklHSjVkR1Z6TENCa1lYUmhPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZWEpqTVRReE1GOXZjR1Z5WVhSdmNsOXlaV1JsWlcxZllubGZjR0Z5ZEdsMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTWpNdE5ESTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6RTBNVEJmYjNCbGNtRjBiM0pmY21Wa1pXVnRYMko1WDNCaGNuUnBkR2x2YmlnS0lDQWdJQzh2SUNBZ1puSnZiVG9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQndZWEowYVhScGIyNDZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCaGNtTTBMbFZwYm5ST01qVTJMQW9nSUNBZ0x5OGdJQ0JrWVhSaE9pQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5d0tJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdOQ0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndiaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRek1Bb2dJQ0FnTHk4Z1kyOXVjM1FnYzJWdVpHVnlJRDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTXpJS0lDQWdJQzh2SUd4bGRDQmhkWFJvYjNKcGVtVmtJRDBnZEdocGN5NWhjbU14TkRFd1gybHpYMjl3WlhKaGRHOXlLR1p5YjIwc0lITmxibVJsY2l3Z2NHRnlkR2wwYVc5dUtTNXVZWFJwZG1VZ1BUMDlJSFJ5ZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME16QUtJQ0FnSUM4dklHTnZibk4wSUhObGJtUmxjaUE5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRNeUNpQWdJQ0F2THlCc1pYUWdZWFYwYUc5eWFYcGxaQ0E5SUhSb2FYTXVZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjaWhtY205dExDQnpaVzVrWlhJc0lIQmhjblJwZEdsdmJpa3VibUYwYVhabElEMDlQU0IwY25WbENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR05oYkd4emRXSWdZWEpqTVRReE1GOXBjMTl2Y0dWeVlYUnZjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZORE16Q2lBZ0lDQXZMeUJwWmlBb0lXRjFkR2h2Y21sNlpXUXBJSHNLSUNBZ0lHSnVlaUJoY21NeE5ERXdYMjl3WlhKaGRHOXlYM0psWkdWbGJWOWllVjl3WVhKMGFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalF6TkFvZ0lDQWdMeThnWTI5dWMzUWdjRXRsZVNBOUlHNWxkeUJoY21NeE5ERXdYMDl3WlhKaGRHOXlVRzl5ZEdsdmJrdGxlU2g3SUdodmJHUmxjam9nWm5KdmJTd2diM0JsY21GMGIzSTZJSE5sYm1SbGNpd2djR0Z5ZEdsMGFXOXVJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCd2RXSnNhV01nYjNCbGNtRjBiM0pRYjNKMGFXOXVRV3hzYjNkaGJtTmxjeUE5SUVKdmVFMWhjRHhoY21NeE5ERXdYMDl3WlhKaGRHOXlVRzl5ZEdsdmJrdGxlU3dnWVhKak5DNVZhVzUwVGpJMU5qNG9leUJyWlhsUWNtVm1hWGc2SUNkaGNtTXhOREV3WDI5d1lTY2dmU2tLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0poY21NeE5ERXdYMjl3WVNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5ETTFDaUFnSUNBdkx5QnBaaUFvZEdocGN5NXZjR1Z5WVhSdmNsQnZjblJwYjI1QmJHeHZkMkZ1WTJWektIQkxaWGtwTG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmhjbU14TkRFd1gyOXdaWEpoZEc5eVgzSmxaR1ZsYlY5aWVWOXdZWEowYVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUXpOZ29nSUNBZ0x5OGdZMjl1YzNRZ2NtVnRZV2x1YVc1bklEMGdkR2hwY3k1dmNHVnlZWFJ2Y2xCdmNuUnBiMjVCYkd4dmQyRnVZMlZ6S0hCTFpYa3BMblpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME16Y0tJQ0FnSUM4dklHRnpjMlZ5ZENoeVpXMWhhVzVwYm1jdWJtRjBhWFpsSUQ0OUlHRnRiM1Z1ZEM1dVlYUnBkbVVzSUNkUWIzSjBhVzl1SUdGc2JHOTNZVzVqWlNCbGVHTmxaV1JsWkNjcENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVRzl5ZEdsdmJpQmhiR3h2ZDJGdVkyVWdaWGhqWldWa1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZORE00Q2lBZ0lDQXZMeUJoZFhSb2IzSnBlbVZrSUQwZ2RISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBNemtLSUNBZ0lDOHZJSFJvYVhNdWIzQmxjbUYwYjNKUWIzSjBhVzl1UVd4c2IzZGhibU5sY3lod1MyVjVLUzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5ST01qVTJLSEpsYldGcGJtbHVaeTV1WVhScGRtVWdMU0JoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpTFFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSnZlRjl3ZFhRS0NtRnlZekUwTVRCZmIzQmxjbUYwYjNKZmNtVmtaV1Z0WDJKNVgzQmhjblJwZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdabkpoYldWZlluVnllU0EyQ2dwaGNtTXhOREV3WDI5d1pYSmhkRzl5WDNKbFpHVmxiVjlpZVY5d1lYSjBhWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdabkpoYldWZlpHbG5JRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXhOREV3TG1Gc1oyOHVkSE02TkRReUNpQWdJQ0F2THlCaGMzTmxjblFvWVhWMGFHOXlhWHBsWkN3Z0owNXZkQ0JoZFhSb2IzSnBlbVZrSUc5d1pYSmhkRzl5SnlrS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNRZ1lYVjBhRzl5YVhwbFpDQnZjR1Z5WVhSdmNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpFME1UQXVZV3huYnk1MGN6bzBORFFLSUNBZ0lDOHZJR052Ym5OMElHWnliMjFMWlhrZ1BTQnVaWGNnWVhKak1UUXhNRjlRWVhKMGFYUnBiMjVMWlhrb2V5Qm9iMnhrWlhJNklHWnliMjBzSUhCaGNuUnBkR2x2YmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklIQjFZbXhwWXlCd1lYSjBhWFJwYjI1eklEMGdRbTk0VFdGd1BHRnlZekUwTVRCZlVHRnlkR2wwYVc5dVMyVjVMQ0JoY21NMExsVnBiblJPTWpVMlBpaDdJR3RsZVZCeVpXWnBlRG9nSjJGeVl6RTBNVEJmY0NjZ2ZTa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltRnlZekUwTVRCZmNDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6RTBNVEF1WVd4bmJ5NTBjem8wTkRVS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuQmhjblJwZEdsdmJuTW9abkp2YlV0bGVTa3VaWGhwYzNSekxDQW5VR0Z5ZEdsMGFXOXVJR0poYkdGdVkyVWdiV2x6YzJsdVp5Y3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRkJoY25ScGRHbHZiaUJpWVd4aGJtTmxJRzFwYzNOcGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZORFEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1d1lYSjBhWFJwYjI1ektHWnliMjFMWlhrcExuWmhiSFZsTG01aGRHbDJaU0ErUFNCaGJXOTFiblF1Ym1GMGFYWmxMQ0FuU1c1emRXWm1hV05wWlc1MElIQmhjblJwZEdsdmJpQmlZV3hoYm1ObEp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWo0OUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElIQmhjblJwZEdsdmJpQmlZV3hoYm1ObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTVRReE1DNWhiR2R2TG5Sek9qUTBOd29nSUNBZ0x5OGdkR2hwY3k1d1lYSjBhWFJwYjI1ektHWnliMjFMWlhrcExuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTR5TlRZb2RHaHBjeTV3WVhKMGFYUnBiMjV6S0daeWIyMUxaWGtwTG5aaGJIVmxMbTVoZEdsMlpTQXRJR0Z0YjNWdWRDNXVZWFJwZG1VcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lud0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnY0hWaWJHbGpJR0poYkdGdVkyVnpJRDBnUW05NFRXRndQRUZrWkhKbGMzTXNJRlZwYm5ST01qVTJQaWg3SUd0bGVWQnlaV1pwZURvZ0oySW5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ppSWdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNVFF4TUM1aGJHZHZMblJ6T2pRME9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbUZzWVc1alpYTW9abkp2YlNrdVpYaHBjM1J6SUNZbUlIUm9hWE11WW1Gc1lXNWpaWE1vWm5KdmJTa3VkbUZzZFdVdWJtRjBhWFpsSUQ0OUlHRnRiM1Z1ZEM1dVlYUnBkbVVzSUNkSmJuTjFabVpwWTJsbGJuUWdZbUZzWVc1alpTY3BDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdGeVl6RTBNVEJmYjNCbGNtRjBiM0pmY21Wa1pXVnRYMko1WDNCaGNuUnBkR2x2Ymw5aWIyOXNYMlpoYkhObFFEY0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpUGowS0lDQWdJR0o2SUdGeVl6RTBNVEJmYjNCbGNtRjBiM0pmY21Wa1pXVnRYMko1WDNCaGNuUnBkR2x2Ymw5aWIyOXNYMlpoYkhObFFEY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENncGhjbU14TkRFd1gyOXdaWEpoZEc5eVgzSmxaR1ZsYlY5aWVWOXdZWEowYVhScGIyNWZZbTl2YkY5dFpYSm5aVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME5EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUpoYkdGdVkyVnpLR1p5YjIwcExtVjRhWE4wY3lBbUppQjBhR2x6TG1KaGJHRnVZMlZ6S0daeWIyMHBMblpoYkhWbExtNWhkR2wyWlNBK1BTQmhiVzkxYm5RdWJtRjBhWFpsTENBblNXNXpkV1ptYVdOcFpXNTBJR0poYkdGdVkyVW5LUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVjM1ZtWm1samFXVnVkQ0JpWVd4aGJtTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1UUXhNQzVoYkdkdkxuUnpPalEwT1FvZ0lDQWdMeThnZEdocGN5NWlZV3hoYm1ObGN5aG1jbTl0S1M1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUk9NalUyS0hSb2FYTXVZbUZzWVc1alpYTW9abkp2YlNrdWRtRnNkV1V1Ym1GMGFYWmxJQzBnWVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmlmQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCd2RXSnNhV01nZEc5MFlXeFRkWEJ3YkhrZ1BTQkhiRzlpWVd4VGRHRjBaVHhWYVc1MFRqSTFOajRvZXlCclpYazZJQ2QwSnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekUwTVRBdVlXeG5ieTUwY3pvME5UQUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFRkWEJ3YkhrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUakkxTmloMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxMbTVoZEdsMlpTQXRJR0Z0YjNWdWRDNXVZWFJwZG1VcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmlmQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkRzkwWVd4VGRYQndiSGtnUFNCSGJHOWlZV3hUZEdGMFpUeFZhVzUwVGpJMU5qNG9leUJyWlhrNklDZDBKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU14TkRFd0xtRnNaMjh1ZEhNNk5EVXdDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNVM1Z3Y0d4NUxuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTR5TlRZb2RHaHBjeTUwYjNSaGJGTjFjSEJzZVM1MllXeDFaUzV1WVhScGRtVWdMU0JoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeE5ERXdMbUZzWjI4dWRITTZORFV4Q2lBZ0lDQXZMeUJsYldsMEtDZFNaV1JsWlcwbkxDQnVaWGNnWVhKak1UUXhNRjl3WVhKMGFYUnBiMjVmY21Wa1pXVnRLSHNnWm5KdmJTd2djR0Z5ZEdsMGFXOXVMQ0JoYlc5MWJuUXNJR1JoZEdFZ2ZTa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJREkzSUM4dklEQjRNREEyTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ016RWdMeThnYldWMGFHOWtJQ0pTWldSbFpXMG9LR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMkxHSjVkR1ZiWFNrcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LWVhKak1UUXhNRjl2Y0dWeVlYUnZjbDl5WldSbFpXMWZZbmxmY0dGeWRHbDBhVzl1WDJKdmIyeGZabUZzYzJWQU56b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdGeVl6RTBNVEJmYjNCbGNtRjBiM0pmY21Wa1pXVnRYMko1WDNCaGNuUnBkR2x2Ymw5aWIyOXNYMjFsY21kbFFEZ0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk9rRnlZekl3TUM1aGNtTXlNREJmYm1GdFpTZ3BJQzArSUdKNWRHVnpPZ3BoY21NeU1EQmZibUZ0WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUc1aGJXVWdQU0JIYkc5aVlXeFRkR0YwWlR4RWVXNWhiV2xqUW5sMFpYTStLSHNnYTJWNU9pQW5iaWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbTRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPamcwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUZOMFlYUnBZMEo1ZEdWelBETXlQaWgwYUdsekxtNWhiV1V1ZG1Gc2RXVXVibUYwYVhabEtRb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCemFYcGxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZPa0Z5WXpJd01DNWhjbU15TURCZmMzbHRZbTlzS0NrZ0xUNGdZbmwwWlhNNkNtRnlZekl3TUY5emVXMWliMnc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUhCMVlteHBZeUJ6ZVcxaWIyd2dQU0JIYkc5aVlXeFRkR0YwWlR4RWVXNWhiV2xqUW5sMFpYTStLSHNnYTJWNU9pQW5jeWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUZOMFlYUnBZMEo1ZEdWelBEZytLSFJvYVhNdWMzbHRZbTlzTG5aaGJIVmxMbTVoZEdsMlpTa0tJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnphWHBsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVoY21NeU1EQmZaR1ZqYVcxaGJITW9LU0F0UGlCaWVYUmxjem9LWVhKak1qQXdYMlJsWTJsdFlXeHpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1ZqYVcxaGJITWdQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUamcrS0hzZ2EyVjVPaUFuWkNjZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW1RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVaR1ZqYVcxaGJITXVkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvNlFYSmpNakF3TG1GeVl6SXdNRjkwYjNSaGJGTjFjSEJzZVNncElDMCtJR0o1ZEdWek9ncGhjbU15TURCZmRHOTBZV3hUZFhCd2JIazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjBiM1JoYkZOMWNIQnNlU0E5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTWpVMlBpaDdJR3RsZVRvZ0ozUW5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MGIzUmhiRk4xY0hCc2VTNTJZV3gxWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WVhKak1qQXdYMkpoYkdGdVkyVlBaaWh2ZDI1bGNqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGhjbU15TURCZlltRnNZVzVqWlU5bU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRXlNeTB4TWpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTWpBd1gySmhiR0Z1WTJWUFppaHZkMjVsY2pvZ1FXUmtjbVZ6Y3lrNklHRnlZelF1VldsdWRFNHlOVFlnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVEkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1ZlltRnNZVzVqWlU5bUtHOTNibVZ5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOWlZV3hoYm1ObFQyWUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xtRnlZekl3TUY5MGNtRnVjMlpsY2taeWIyMG9abkp2YlRvZ1lubDBaWE1zSUhSdk9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVhKak1qQXdYM1J5WVc1elptVnlSbkp2YlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE5EZ3RNVFE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekl3TUY5MGNtRnVjMlpsY2taeWIyMG9abkp2YlRvZ1FXUmtjbVZ6Y3l3Z2RHODZJRUZrWkhKbGMzTXNJSFpoYkhWbE9pQmhjbU0wTGxWcGJuUk9NalUyS1RvZ1lYSmpOQzVDYjI5c0lIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFMU1Bb2dJQ0FnTHk4Z1kyOXVjM1FnYzNCbGJtUmxjaUE5SUc1bGR5QkJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UVXhDaUFnSUNBdkx5QmpiMjV6ZENCemNHVnVaR1Z5WDJGc2JHOTNZVzVqWlNBOUlIUm9hWE11WDJGc2JHOTNZVzVqWlNobWNtOXRMQ0J6Y0dWdVpHVnlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCZllXeHNiM2RoYm1ObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UVXlDaUFnSUNBdkx5QmhjM05sY25Rb2MzQmxibVJsY2w5aGJHeHZkMkZ1WTJVdWJtRjBhWFpsSUQ0OUlIWmhiSFZsTG01aGRHbDJaU3dnSjJsdWMzVm1abWxqYVdWdWRDQmhjSEJ5YjNaaGJDY3BDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWo0OUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1emRXWm1hV05wWlc1MElHRndjSEp2ZG1Gc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UVXpDaUFnSUNBdkx5QmpiMjV6ZENCdVpYZGZjM0JsYm1SbGNsOWhiR3h2ZDJGdVkyVWdQU0J1WlhjZ1ZXbHVkRTR5TlRZb2MzQmxibVJsY2w5aGJHeHZkMkZ1WTJVdWJtRjBhWFpsSUMwZ2RtRnNkV1V1Ym1GMGFYWmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUxRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE5UUUtJQ0FnSUM4dklIUm9hWE11WDJGd2NISnZkbVVvWm5KdmJTd2djM0JsYm1SbGNpd2dibVYzWDNOd1pXNWtaWEpmWVd4c2IzZGhibU5sS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRjloY0hCeWIzWmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hOVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5MGNtRnVjMlpsY2lobWNtOXRMQ0IwYnl3Z2RtRnNkV1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WVhKak1qQXdYMkZ3Y0hKdmRtVW9jM0JsYm1SbGNqb2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21GeVl6SXdNRjloY0hCeWIzWmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakUyTlMweE5qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1qQXdYMkZ3Y0hKdmRtVW9jM0JsYm1SbGNqb2dRV1JrY21WemN5d2dkbUZzZFdVNklHRnlZelF1VldsdWRFNHlOVFlwT2lCQ2IyOXNJSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTJOd29nSUNBZ0x5OGdZMjl1YzNRZ2IzZHVaWElnUFNCdVpYY2dRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTJPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WDJGd2NISnZkbVVvYjNkdVpYSXNJSE53Wlc1a1pYSXNJSFpoYkhWbEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdYMkZ3Y0hKdmRtVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xtRnlZekl3TUY5aGJHeHZkMkZ1WTJVb2IzZHVaWEk2SUdKNWRHVnpMQ0J6Y0dWdVpHVnlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbUZ5WXpJd01GOWhiR3h2ZDJGdVkyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGMzTFRFM09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeU1EQmZZV3hzYjNkaGJtTmxLRzkzYm1WeU9pQkJaR1J5WlhOekxDQnpjR1Z1WkdWeU9pQkJaR1J5WlhOektUb2dZWEpqTkM1VmFXNTBUakkxTmlCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94TnprS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxsOWhiR3h2ZDJGdVkyVW9iM2R1WlhJc0lITndaVzVrWlhJcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQmZZV3hzYjNkaGJtTmxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZPa0Z5WXpJd01DNWZZbUZzWVc1alpVOW1LRzkzYm1WeU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsOWlZV3hoYm1ObFQyWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGd5Q2lBZ0lDQXZMeUJ3Y205MFpXTjBaV1FnWDJKaGJHRnVZMlZQWmlodmQyNWxjam9nUVdSa2NtVnpjeWs2SUZWcGJuUk9NalUySUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZbUZzWVc1alpYTWdQU0JDYjNoTllYQThRV1JrY21WemN5d2dWV2x1ZEU0eU5UWStLSHNnYTJWNVVISmxabWw0T2lBbllpY2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRnekNpQWdJQ0F2THlCcFppQW9JWFJvYVhNdVltRnNZVzVqWlhNb2IzZHVaWElwTG1WNGFYTjBjeWtnY21WMGRYSnVJRzVsZHlCVmFXNTBUakkxTmlnd0tRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWDJKaGJHRnVZMlZQWmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWlZV3hoYm1ObFQyWmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTROQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WW1Gc1lXNWpaWE1vYjNkdVpYSXBMblpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvNlFYSmpNakF3TGw5MGNtRnVjMlpsY2loelpXNWtaWEk2SUdKNWRHVnpMQ0J5WldOcGNHbGxiblE2SUdKNWRHVnpMQ0JoYlc5MWJuUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tYM1J5WVc1elptVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakU0TndvZ0lDQWdMeThnY0hKdmRHVmpkR1ZrSUY5MGNtRnVjMlpsY2loelpXNWtaWEk2SUVGa1pISmxjM01zSUhKbFkybHdhV1Z1ZERvZ1FXUmtjbVZ6Y3l3Z1lXMXZkVzUwT2lCVmFXNTBUakkxTmlrNklFSnZiMndnZXdvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGc0Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhKZlltRnNZVzVqWlNBOUlIUm9hWE11WDJKaGJHRnVZMlZQWmloelpXNWtaWElwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTmhiR3h6ZFdJZ1gySmhiR0Z1WTJWUFpnb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UZzVDaUFnSUNBdkx5QmpiMjV6ZENCeVpXTnBjR2xsYm5SZlltRnNZVzVqWlNBOUlIUm9hWE11WDJKaGJHRnVZMlZQWmloeVpXTnBjR2xsYm5RcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdYMkpoYkdGdVkyVlBaZ29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakU1TUFvZ0lDQWdMeThnWVhOelpYSjBLSE5sYm1SbGNsOWlZV3hoYm1ObExtNWhkR2wyWlNBK1BTQmhiVzkxYm5RdWJtRjBhWFpsTENBblNXNXpkV1ptYVdOcFpXNTBJR0poYkdGdVkyVWdZWFFnZEdobElITmxibVJsY2lCaFkyTnZkVzUwSnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzV6ZFdabWFXTnBaVzUwSUdKaGJHRnVZMlVnWVhRZ2RHaGxJSE5sYm1SbGNpQmhZMk52ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1Ua3lDaUFnSUNBdkx5QnBaaUFvYzJWdVpHVnlJQ0U5UFNCeVpXTnBjR2xsYm5RcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0FoUFFvZ0lDQWdZbm9nWDNSeVlXNXpabVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakU1TkFvZ0lDQWdMeThnZEdocGN5NWlZV3hoYm1ObGN5aHpaVzVrWlhJcExuWmhiSFZsSUQwZ2JtVjNJRlZwYm5ST01qVTJLSE5sYm1SbGNsOWlZV3hoYm1ObExtNWhkR2wyWlNBdElHRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUxRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdKOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklIQjFZbXhwWXlCaVlXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlpHUnlaWE56TENCVmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RpSnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGswQ2lBZ0lDQXZMeUIwYUdsekxtSmhiR0Z1WTJWektITmxibVJsY2lrdWRtRnNkV1VnUFNCdVpYY2dWV2x1ZEU0eU5UWW9jMlZ1WkdWeVgySmhiR0Z1WTJVdWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE9UVUtJQ0FnSUM4dklIUm9hWE11WW1Gc1lXNWpaWE1vY21WamFYQnBaVzUwS1M1MllXeDFaU0E5SUc1bGR5QlZhVzUwVGpJMU5paHlaV05wY0dsbGJuUmZZbUZzWVc1alpTNXVZWFJwZG1VZ0t5QmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpc0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdKOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklIQjFZbXhwWXlCaVlXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlpHUnlaWE56TENCVmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RpSnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVGsxQ2lBZ0lDQXZMeUIwYUdsekxtSmhiR0Z1WTJWektISmxZMmx3YVdWdWRDa3VkbUZzZFdVZ1BTQnVaWGNnVldsdWRFNHlOVFlvY21WamFYQnBaVzUwWDJKaGJHRnVZMlV1Ym1GMGFYWmxJQ3NnWVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLQ2w5MGNtRnVjMlpsY2w5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRrM0NpQWdJQ0F2THlCbGJXbDBLRzVsZHlCaGNtTXlNREJmVkhKaGJuTm1aWElvZXlCbWNtOXRPaUJ6Wlc1a1pYSXNJSFJ2T2lCeVpXTnBjR2xsYm5Rc0lIWmhiSFZsT2lCaGJXOTFiblFnZlNrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNamdnTHk4Z2JXVjBhRzlrSUNKaGNtTXlNREJmVkhKaGJuTm1aWElvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94T1RnS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1FtOXZiQ2gwY25WbEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEZ3dDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xsOWhjSEJ5YjNaaGJFdGxlU2h2ZDI1bGNqb2dZbmwwWlhNc0lITndaVzVrWlhJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1gyRndjSEp2ZG1Gc1MyVjVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakl3TUFvZ0lDQWdMeThnY0hKdmRHVmpkR1ZrSUY5aGNIQnliM1poYkV0bGVTaHZkMjVsY2pvZ1FXUmtjbVZ6Y3l3Z2MzQmxibVJsY2pvZ1FXUmtjbVZ6Y3lrNklGTjBZWFJwWTBKNWRHVnpQRE15UGlCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem95TURFS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1UzUmhkR2xqUW5sMFpYTThNekkrS0c5d0xuTm9ZVEkxTmlodmNDNWpiMjVqWVhRb2IzZHVaWEl1WW5sMFpYTXNJSE53Wlc1a1pYSXVZbmwwWlhNcEtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSE5wZW1VS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvNlFYSmpNakF3TGw5aGJHeHZkMkZ1WTJVb2IzZHVaWEk2SUdKNWRHVnpMQ0J6Y0dWdVpHVnlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbDloYkd4dmQyRnVZMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TWpBMENpQWdJQ0F2THlCd2NtOTBaV04wWldRZ1gyRnNiRzkzWVc1alpTaHZkMjVsY2pvZ1FXUmtjbVZ6Y3l3Z2MzQmxibVJsY2pvZ1FXUmtjbVZ6Y3lrNklGVnBiblJPTWpVMklIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pJd05Rb2dJQ0FnTHk4Z1kyOXVjM1FnYTJWNUlEMGdkR2hwY3k1ZllYQndjbTkyWVd4TFpYa29iM2R1WlhJc0lITndaVzVrWlhJcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQmZZWEJ3Y205MllXeExaWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnY0hWaWJHbGpJR0Z3Y0hKdmRtRnNjeUE5SUVKdmVFMWhjRHhUZEdGMGFXTkNlWFJsY3p3ek1qNHNJRUZ3Y0hKdmRtRnNVM1J5ZFdOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJFbklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakl3TmdvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG1Gd2NISnZkbUZzY3loclpYa3BMbVY0YVhOMGN5a2djbVYwZFhKdUlHNWxkeUJWYVc1MFRqSTFOaWd3S1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dYMkZzYkc5M1lXNWpaVjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2w5aGJHeHZkMkZ1WTJWZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pJd053b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZWEJ3Y205MllXeHpLR3RsZVNrdWRtRnNkV1V1WVhCd2NtOTJZV3hCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUlDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WDJGd2NISnZkbVVvYjNkdVpYSTZJR0o1ZEdWekxDQnpjR1Z1WkdWeU9pQmllWFJsY3l3Z1lXMXZkVzUwT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2w5aGNIQnliM1psT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pJeE1Bb2dJQ0FnTHk4Z2NISnZkR1ZqZEdWa0lGOWhjSEJ5YjNabEtHOTNibVZ5T2lCQlpHUnlaWE56TENCemNHVnVaR1Z5T2lCQlpHUnlaWE56TENCaGJXOTFiblE2SUZWcGJuUk9NalUyS1RvZ1FtOXZiQ0I3Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3lNVEVLSUNBZ0lDOHZJR052Ym5OMElHdGxlU0E5SUhSb2FYTXVYMkZ3Y0hKdmRtRnNTMlY1S0c5M2JtVnlMQ0J6Y0dWdVpHVnlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnWDJGd2NISnZkbUZzUzJWNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1qRXlMVEl4TmdvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3Y205MllXeENiM2c2SUVGd2NISnZkbUZzVTNSeWRXTjBJRDBnYm1WM0lFRndjSEp2ZG1Gc1UzUnlkV04wS0hzS0lDQWdJQzh2SUNBZ1lYQndjbTkyWVd4QmJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnYjNkdVpYSTZJRzkzYm1WeUxBb2dJQ0FnTHk4Z0lDQnpjR1Z1WkdWeU9pQnpjR1Z1WkdWeUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJSEIxWW14cFl5QmhjSEJ5YjNaaGJITWdQU0JDYjNoTllYQThVM1JoZEdsalFubDBaWE04TXpJK0xDQkJjSEJ5YjNaaGJGTjBjblZqZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RoSnlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKaElnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveU1UY0tJQ0FnSUM4dklIUm9hWE11WVhCd2NtOTJZV3h6S0d0bGVTa3VkbUZzZFdVZ1BTQmhjSEJ5YjNaaGJFSnZlQzVqYjNCNUtDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem95TVRnS0lDQWdJQzh2SUdWdGFYUW9ibVYzSUdGeVl6SXdNRjlCY0hCeWIzWmhiQ2g3SUc5M2JtVnlPaUJ2ZDI1bGNpd2djM0JsYm1SbGNqb2djM0JsYm1SbGNpd2dkbUZzZFdVNklHRnRiM1Z1ZENCOUtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hPVFk1WmpnMk5TQXZMeUJ0WlhSb2IyUWdJbUZ5WXpJd01GOUJjSEJ5YjNaaGJDaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTmlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qSXhPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJDYjI5c0tIUnlkV1VwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0T0RBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pwQmNtTTRPQzVmWlc1emRYSmxSR1ZtWVhWc2RFOTNibVZ5S0NrZ0xUNGdkbTlwWkRvS1gyVnVjM1Z5WlVSbFptRjFiSFJQZDI1bGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTVDaUFnSUNBdkx5QndkV0pzYVdNZ2FXNXBkR2xoYkdsNlpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0o1ZEdVK0tIc2dhMlY1T2lBbllYSmpPRGhmYjJrbklIMHBJQzh2SURFZ2FXWWdhVzVwZEdsaGJHbDZaV1FnS0dWNGNHeHBZMmwwSUc5eUlHbHRjR3hwWTJsMEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKaGNtTTRPRjl2YVNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCcFppQW9JWFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVhR0Z6Vm1Gc2RXVWdmSHdnZEdocGN5NXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTNXVZWFJwZG1VZ1BUMDlJREFwSUhzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJRjlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWEpmYVdaZlltOWtlVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnY0hWaWJHbGpJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1Q2VYUmxQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOXBKeUI5S1NBdkx5QXhJR2xtSUdsdWFYUnBZV3hwZW1Wa0lDaGxlSEJzYVdOcGRDQnZjaUJwYlhCc2FXTnBkQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlZWEpqT0RoZmIya2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHbG1JQ2doZEdocGN5NXBibWwwYVdGc2FYcGxaQzVvWVhOV1lXeDFaU0I4ZkNCMGFHbHpMbWx1YVhScFlXeHBlbVZrTG5aaGJIVmxMbTVoZEdsMlpTQTlQVDBnTUNrZ2V3b2dJQ0FnWW5SdmFRb2dJQ0FnWW01NklGOWxibk4xY21WRVpXWmhkV3gwVDNkdVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBMUNncGZaVzV6ZFhKbFJHVm1ZWFZzZEU5M2JtVnlYMmxtWDJKdlpIbEFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1dmQyNWxjaTVvWVhOV1lXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJRjlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdjSFZpYkdsaklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGloN0lHdGxlVG9nSjJGeVl6ZzRYMjhuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUhSb2FYTXViM2R1WlhJdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0Vkc2IySmhiQzVqY21WaGRHOXlRV1JrY21WemN5a0tJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbDlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJSEIxWW14cFl5QnBibWwwYVdGc2FYcGxaQ0E5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UW5sMFpUNG9leUJyWlhrNklDZGhjbU00T0Y5dmFTY2dmU2tnTHk4Z01TQnBaaUJwYm1sMGFXRnNhWHBsWkNBb1pYaHdiR2xqYVhRZ2IzSWdhVzF3YkdsamFYUXBDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlZWEpqT0RoZmIya2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdkR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNTJZV3gxWlNBOUlHNWxkeUJoY21NMExrSjVkR1VvTVNrS0lDQWdJR0o1ZEdWaklESTFJQzh2SURCNE1ERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3BmWlc1emRYSmxSR1ZtWVhWc2RFOTNibVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPanBCY21NNE9DNWhjbU00T0Y5dmQyNWxjaWdwSUMwK0lHSjVkR1Z6T2dwaGNtTTRPRjl2ZDI1bGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QjBhR2x6TGw5bGJuTjFjbVZFWldaaGRXeDBUM2R1WlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJmWlc1emRYSmxSR1ZtWVhWc2RFOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnY0hWaWJHbGpJRzkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUJaR1J5WlhOelBpaDdJR3RsZVRvZ0oyRnlZemc0WDI4bklIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlYSmpPRGhmYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qcEJjbU00T0M1aGNtTTRPRjlwYzE5dmQyNWxjaWh4ZFdWeWVUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGhjbU00T0Y5cGMxOXZkMjVsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pReExUUXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6ZzRYMmx6WDI5M2JtVnlLSEYxWlhKNU9pQmhjbU0wTGtGa1pISmxjM01wT2lCaGNtTTBMa0p2YjJ3Z2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnZEdocGN5NWZaVzV6ZFhKbFJHVm1ZWFZzZEU5M2JtVnlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyVnVjM1Z5WlVSbFptRjFiSFJQZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIQjFZbXhwWXlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXZKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbTkzYm1WeUxtaGhjMVpoYkhWbEtTQnlaWFIxY200Z2JtVjNJR0Z5WXpRdVFtOXZiQ2htWVd4elpTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCaGNtTTRPRjlwYzE5dmQyNWxjbDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNREFLSUNBZ0lISmxkSE4xWWdvS1lYSmpPRGhmYVhOZmIzZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR2xtSUNoMGFHbHpMbTkzYm1WeUxuWmhiSFZsSUQwOVBTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa3BJSEpsZEhWeWJpQnVaWGNnWVhKak5DNUNiMjlzS0daaGJITmxLUW9nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGNtTTRPRjlwYzE5dmQyNWxjbDloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNREFLSUNBZ0lISmxkSE4xWWdvS1lYSmpPRGhmYVhOZmIzZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnWVhKak5DNUNiMjlzS0hSb2FYTXViM2R1WlhJdWRtRnNkV1VnUFQwOUlIRjFaWEo1S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQTlQUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzZRWEpqT0RndVlYSmpPRGhmYVc1cGRHbGhiR2w2WlY5dmQyNWxjaWh1WlhkZmIzZHVaWEk2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoY21NNE9GOXBibWwwYVdGc2FYcGxYMjkzYm1WeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk5UQXROVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpPRGhmYVc1cGRHbGhiR2w2WlY5dmQyNWxjaWh1WlhkZmIzZHVaWEk2SUdGeVl6UXVRV1JrY21WemN5azZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnY0hWaWJHbGpJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1Q2VYUmxQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOXBKeUI5S1NBdkx5QXhJR2xtSUdsdWFYUnBZV3hwZW1Wa0lDaGxlSEJzYVdOcGRDQnZjaUJwYlhCc2FXTnBkQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlZWEpqT0RoZmIya2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdZWE56WlhKMEtDRW9kR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNW9ZWE5XWVd4MVpTQW1KaUIwYUdsekxtbHVhWFJwWVd4cGVtVmtMblpoYkhWbExtNWhkR2wyWlNBOVBUMGdNU2tzSUNkaGJISmxZV1I1WDJsdWFYUnBZV3hwZW1Wa0p5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdGeVl6ZzRYMmx1YVhScFlXeHBlbVZmYjNkdVpYSmZZbTl2YkY5bVlXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnY0hWaWJHbGpJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1Q2VYUmxQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOXBKeUI5S1NBdkx5QXhJR2xtSUdsdWFYUnBZV3hwZW1Wa0lDaGxlSEJzYVdOcGRDQnZjaUJwYlhCc2FXTnBkQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlZWEpqT0RoZmIya2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHRnpjMlZ5ZENnaEtIUm9hWE11YVc1cGRHbGhiR2w2WldRdWFHRnpWbUZzZFdVZ0ppWWdkR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNTJZV3gxWlM1dVlYUnBkbVVnUFQwOUlERXBMQ0FuWVd4eVpXRmtlVjlwYm1sMGFXRnNhWHBsWkNjcENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHSjZJR0Z5WXpnNFgybHVhWFJwWVd4cGVtVmZiM2R1WlhKZlltOXZiRjltWVd4elpVQXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0tZWEpqT0RoZmFXNXBkR2xoYkdsNlpWOXZkMjVsY2w5aWIyOXNYMjFsY21kbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdZWE56WlhKMEtDRW9kR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNW9ZWE5XWVd4MVpTQW1KaUIwYUdsekxtbHVhWFJwWVd4cGVtVmtMblpoYkhWbExtNWhkR2wyWlNBOVBUMGdNU2tzSUNkaGJISmxZV1I1WDJsdWFYUnBZV3hwZW1Wa0p5a0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYkhKbFlXUjVYMmx1YVhScFlXeHBlbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnWVhOelpYSjBLRzVsZDE5dmQyNWxjaUFoUFQwZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3lncExDQW5lbVZ5YjE5aFpHUnlaWE56WDI1dmRGOWhiR3h2ZDJWa0p5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdlbVZ5YjE5aFpHUnlaWE56WDI1dmRGOWhiR3h2ZDJWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2NIVmliR2xqSUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOG5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poY21NNE9GOXZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOVFFLSUNBZ0lDOHZJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVWdQU0J1WlhkZmIzZHVaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhVzVwZEdsaGJHbDZaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtKNWRHVStLSHNnYTJWNU9pQW5ZWEpqT0RoZmIya25JSDBwSUM4dklERWdhV1lnYVc1cGRHbGhiR2w2WldRZ0tHVjRjR3hwWTJsMElHOXlJR2x0Y0d4cFkybDBLUW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbUZ5WXpnNFgyOXBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNUNlWFJsS0RFcENpQWdJQ0JpZVhSbFl5QXlOU0F2THlBd2VEQXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dwaGNtTTRPRjlwYm1sMGFXRnNhWHBsWDI5M2JtVnlYMkp2YjJ4ZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJR0Z5WXpnNFgybHVhWFJwWVd4cGVtVmZiM2R1WlhKZlltOXZiRjl0WlhKblpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk9rRnlZemc0TG1GeVl6ZzRYM1J5WVc1elptVnlYMjkzYm1WeWMyaHBjQ2h1WlhkZmIzZHVaWEk2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoY21NNE9GOTBjbUZ1YzJabGNsOXZkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzFPQzAxT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU00T0Y5MGNtRnVjMlpsY2w5dmQyNWxjbk5vYVhBb2JtVjNYMjkzYm1WeU9pQmhjbU0wTGtGa1pISmxjM01wT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklIUm9hWE11WDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRjlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJoYzNObGNuUW9ibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0E5UFQwZ2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlN3Z0oyNXZkRjl2ZDI1bGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2NIVmliR2xqSUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOG5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMDlJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVXNJQ2R1YjNSZmIzZHVaWEluS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1JmYjNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNYMjkzYm1WeUlDRTlQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ2tzSUNkNlpYSnZYMkZrWkhKbGMzTmZibTkwWDJGc2JHOTNaV1FuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4eElDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCNlpYSnZYMkZrWkhKbGMzTmZibTkwWDJGc2JHOTNaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTQTlJRzVsZDE5dmQyNWxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJR1Z0YVhRb2JtVjNJR0Z5WXpnNFgwOTNibVZ5YzJocGNGUnlZVzV6Wm1WeWNtVmtLSHNnY0hKbGRtbHZkWE5mYjNkdVpYSTZJSEJ5WlhacGIzVnpMQ0J1WlhkZmIzZHVaWElnZlNrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNeklnTHk4Z2JXVjBhRzlrSUNKaGNtTTRPRjlQZDI1bGNuTm9hWEJVY21GdWMyWmxjbkpsWkNoaFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pwQmNtTTRPQzVoY21NNE9GOXlaVzV2ZFc1alpWOXZkMjVsY25Ob2FYQW9LU0F0UGlCMmIybGtPZ3BoY21NNE9GOXlaVzV2ZFc1alpWOXZkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzNNQW9nSUNBZ0x5OGdkR2hwY3k1ZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnWDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwSUQwOVBTQjBhR2x6TG05M2JtVnlMblpoYkhWbExDQW5ibTkwWDI5M2JtVnlKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QndkV0pzYVdNZ2IzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZieWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poY21NNE9GOXZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQVDBnZEdocGN5NXZkMjVsY2k1MllXeDFaU3dnSjI1dmRGOXZkMjVsY2ljcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZEY5dmQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnlMblpoYkhWbElEMGdibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QmxiV2wwS0c1bGR5QmhjbU00T0Y5UGQyNWxjbk5vYVhCU1pXNXZkVzVqWldRb2V5QndjbVYyYVc5MWMxOXZkMjVsY2pvZ2NISmxkbWx2ZFhNZ2ZTa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pORFpoWVRFMk5pQXZMeUJ0WlhSb2IyUWdJbUZ5WXpnNFgwOTNibVZ5YzJocGNGSmxibTkxYm1ObFpDaGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzZRWEpqT0RndVlYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3WDNKbGNYVmxjM1FvY0dWdVpHbHVaem9nWW5sMFpYTXBJQzArSUhadmFXUTZDbUZ5WXpnNFgzUnlZVzV6Wm1WeVgyOTNibVZ5YzJocGNGOXlaWEYxWlhOME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk56Z3ROemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3WDNKbGNYVmxjM1FvY0dWdVpHbHVaem9nWVhKak5DNUJaR1J5WlhOektUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUIwYUdsekxsOWxibk4xY21WRVpXWmhkV3gwVDNkdVpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMDlJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVXNJQ2R1YjNSZmIzZHVaWEluS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBJRDA5UFNCMGFHbHpMbTkzYm1WeUxuWmhiSFZsTENBbmJtOTBYMjkzYm1WeUp5a0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYm05MFgyOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnWVhOelpYSjBLSEJsYm1ScGJtY2dJVDA5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1N3Z0ozcGxjbTlmWVdSa2NtVnpjMTl1YjNSZllXeHNiM2RsWkNjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklIcGxjbTlmWVdSa2NtVnpjMTl1YjNSZllXeHNiM2RsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhCMVlteHBZeUJ3Wlc1a2FXNW5UM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmY0c4bklIMHBJQzh2SUc5d2RHbHZibUZzSUhSM2J5MXpkR1Z3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUZ5WXpnNFgzQnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZPRE1LSUNBZ0lDOHZJR2xtSUNoMGFHbHpMbkJsYm1ScGJtZFBkMjVsY2k1b1lYTldZV3gxWlNBbUppQjBhR2x6TG5CbGJtUnBibWRQZDI1bGNpNTJZV3gxWlNBaFBUMGdibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmhjbU00T0Y5MGNtRnVjMlpsY2w5dmQyNWxjbk5vYVhCZmNtVnhkV1Z6ZEY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR1Z1WkdsdVowOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGloN0lHdGxlVG9nSjJGeVl6ZzRYM0J2SnlCOUtTQXZMeUJ2Y0hScGIyNWhiQ0IwZDI4dGMzUmxjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmhjbU00T0Y5d2J5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWNHVnVaR2x1WjA5M2JtVnlMbWhoYzFaaGJIVmxJQ1ltSUhSb2FYTXVjR1Z1WkdsdVowOTNibVZ5TG5aaGJIVmxJQ0U5UFNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0NrcElIc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0FoUFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklIQmxibVJwYm1kZmRISmhibk5tWlhKZlpYaHBjM1J6Q2dwaGNtTTRPRjkwY21GdWMyWmxjbDl2ZDI1bGNuTm9hWEJmY21WeGRXVnpkRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdjSFZpYkdsaklIQmxibVJwYm1kUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXdieWNnZlNrZ0x5OGdiM0IwYVc5dVlXd2dkSGR2TFhOMFpYQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmhjbU00T0Y5d2J5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QjBhR2x6TG5CbGJtUnBibWRQZDI1bGNpNTJZV3gxWlNBOUlIQmxibVJwYm1jS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCd2RXSnNhV01nYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0ZrWkhKbGMzTStLSHNnYTJWNU9pQW5ZWEpqT0RoZmJ5Y2dmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhjbU00T0Y5dklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pnM0NpQWdJQ0F2THlCbGJXbDBLRzVsZHlCaGNtTTRPRjlQZDI1bGNuTm9hWEJVY21GdWMyWmxjbEpsY1hWbGMzUmxaQ2g3SUhCeVpYWnBiM1Z6WDI5M2JtVnlPaUIwYUdsekxtOTNibVZ5TG5aaGJIVmxMQ0J3Wlc1a2FXNW5YMjkzYm1WeU9pQndaVzVrYVc1bklIMHBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUyWW1ZeFpqa3hJQzh2SUcxbGRHaHZaQ0FpWVhKak9EaGZUM2R1WlhKemFHbHdWSEpoYm5ObVpYSlNaWEYxWlhOMFpXUW9ZV1JrY21WemN5eGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzZRWEpqT0RndVlYSmpPRGhmWVdOalpYQjBYMjkzYm1WeWMyaHBjQ2dwSUMwK0lIWnZhV1E2Q21GeVl6ZzRYMkZqWTJWd2RGOXZkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdkR2hwY3k1ZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnWDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhCMVlteHBZeUJ3Wlc1a2FXNW5UM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmY0c4bklIMHBJQzh2SUc5d2RHbHZibUZzSUhSM2J5MXpkR1Z3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUZ5WXpnNFgzQnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZPVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5CbGJtUnBibWRQZDI1bGNpNW9ZWE5XWVd4MVpTd2dKMjV2ZEY5d1pXNWthVzVuWDI5M2JtVnlKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUmZjR1Z1WkdsdVoxOXZkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02T1RRS0lDQWdJQzh2SUdOdmJuTjBJSE5sYm1SbGNpQTlJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QndkV0pzYVdNZ2NHVnVaR2x1WjA5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpnNFgzQnZKeUI5S1NBdkx5QnZjSFJwYjI1aGJDQjBkMjh0YzNSbGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKaGNtTTRPRjl3YnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem81TlFvZ0lDQWdMeThnWVhOelpYSjBLSE5sYm1SbGNpQTlQVDBnZEdocGN5NXdaVzVrYVc1blQzZHVaWEl1ZG1Gc2RXVXNJQ2R1YjNSZmNHVnVaR2x1WjE5dmQyNWxjaWNwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1JmY0dWdVpHbHVaMTl2ZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIQjFZbXhwWXlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXZKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlYSmpPRGhmYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2prM0NpQWdJQ0F2THlCMGFHbHpMbTkzYm1WeUxuWmhiSFZsSUQwZ2MyVnVaR1Z5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCd2RXSnNhV01nY0dWdVpHbHVaMDkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUJaR1J5WlhOelBpaDdJR3RsZVRvZ0oyRnlZemc0WDNCdkp5QjlLU0F2THlCdmNIUnBiMjVoYkNCMGQyOHRjM1JsY0FvZ0lDQWdZbmwwWldNZ01URWdMeThnSW1GeVl6ZzRYM0J2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUhSb2FYTXVjR1Z1WkdsdVowOTNibVZ5TG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPams1Q2lBZ0lDQXZMeUJsYldsMEtHNWxkeUJoY21NNE9GOVBkMjVsY25Ob2FYQlVjbUZ1YzJabGNrRmpZMlZ3ZEdWa0tIc2djSEpsZG1sdmRYTmZiM2R1WlhJNklIQnlaWFpwYjNWekxDQnVaWGRmYjNkdVpYSTZJSE5sYm1SbGNpQjlLU2tLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WmpkbE16WmlNemNnTHk4Z2JXVjBhRzlrSUNKaGNtTTRPRjlQZDI1bGNuTm9hWEJVY21GdWMyWmxja0ZqWTJWd2RHVmtLR0ZrWkhKbGMzTXNZV1JrY21WemN5a2lDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnWlcxcGRDaHVaWGNnWVhKak9EaGZUM2R1WlhKemFHbHdWSEpoYm5ObVpYSnlaV1FvZXlCd2NtVjJhVzkxYzE5dmQyNWxjam9nY0hKbGRtbHZkWE1zSUc1bGQxOXZkMjVsY2pvZ2MyVnVaR1Z5SUgwcEtRb2dJQ0FnWW5sMFpXTWdNeklnTHk4Z2JXVjBhRzlrSUNKaGNtTTRPRjlQZDI1bGNuTm9hWEJVY21GdWMyWmxjbkpsWkNoaFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pwQmNtTTRPQzVoY21NNE9GOWpZVzVqWld4ZmIzZHVaWEp6YUdsd1gzSmxjWFZsYzNRb0tTQXRQaUIyYjJsa09ncGhjbU00T0Y5allXNWpaV3hmYjNkdVpYSnphR2x3WDNKbGNYVmxjM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem94TURVS0lDQWdJQzh2SUhSb2FYTXVYMlZ1YzNWeVpVUmxabUYxYkhSUGQyNWxjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlGOWxibk4xY21WRVpXWmhkV3gwVDNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRXdOZ29nSUNBZ0x5OGdZWE56WlhKMEtHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa2dQVDA5SUhSb2FYTXViM2R1WlhJdWRtRnNkV1VzSUNkdWIzUmZiM2R1WlhJbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUhCMVlteHBZeUJ2ZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRV1JrY21WemN6NG9leUJyWlhrNklDZGhjbU00T0Y5dkp5QjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRnlZemc0WDI4aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRBMkNpQWdJQ0F2THlCaGMzTmxjblFvYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NBOVBUMGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTd2dKMjV2ZEY5dmQyNWxjaWNwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkRjl2ZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklIQjFZbXhwWXlCd1pXNWthVzVuVDNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0ZrWkhKbGMzTStLSHNnYTJWNU9pQW5ZWEpqT0RoZmNHOG5JSDBwSUM4dklHOXdkR2x2Ym1Gc0lIUjNieTF6ZEdWd0NpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaVlYSmpPRGhmY0c4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklIUm9hWE11Y0dWdVpHbHVaMDkzYm1WeUxuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3lncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBQUVnQWlZaEJCVWZmSFVnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUhZWEpqT0RoZmJ3RjBBV0lPWVhKak1UWTBORjlqZEhKc1pXNENBQUlCZ0FsaGNtTXhOREV3WDNBTVlYSmpNVFkwTkY5amRISnNER0Z5WXpFMk5ETmZaRzlqY3doaGNtTTRPRjl3YndFQUNHRnlZemc0WDI5cENBQUFBQUFBQUFBQUMyRnlZekUxT1RSZmFYTnpER0Z5WXpFMk5EUmZiV05oYVF0aGNtTXhOREV3WDI5d1lRMWhjbU14TmpRMFgzSnFkWE4wREdGeVl6RTJORFJmYkdOaGNnSUFBQXhoY21NeE5ERXdYMmh3WDJFS1lYSmpNVFF4TUY5dmNBdGhjbU14TmpRelgyUnZZd0lBUWdFQkFnQUJBZ0JpQkhtRHcxd0NBQVlFMS94S21BUmNKN1Q4QkVOVjBxMHhHMEVGYW9JeUJKZFRndUlFcE9kQnF3UUVWSExRQkgxNUJLUUU1dlQ0WVFRdXZTMDBCTzV2TFE0RUhWeDZGd1RsZW00WUJCSExOdlVFc1cxNmpBU255elNDQk95Mk5zZ0VaYkZvS2dRQk1GbWJCQlFyWDhzRStJT091UVF4aUN2NkJLbk1vVzhFSm1XWHdBUTErQk5mQk5wd0pia0VQeVZuRXdTVnRQbmpCSURNU2FzRUI1WWhaUVRuaVdIYUJQMlVnTmNFc2JIV21nVEJ2dGVKQkR2K0dETUVXWnpScFFSdDZVRm1CQ2p3STljRVpYMFQ3QVMycmhvbEJJVHNFOVVFN0psZ1FRU0M1WFBFQkVxV2o0OEV0VUloSlFTN3N4bnpCQWNDWlU0RTBCVnlUZ1FDbit6QUJITkpNMDRFMjN5Qzd3VDlMQ3h1QkVLbDhHVUVyVTlvNmpZYUFJNHlBK2tEdmdPdkE2QURrUU9DQTNJRFV3TTZBeVVERWdNREF2TUM1QUxQQXJvQ3FBS1BBbk1DWXdKTkFqY0NHd0lGQWV3QjF3SENBYU1CaEFGc0FWTUJPd0VtQVE0QS9nRHVBTjRBemdDN0FLSUFqQUIyQUdZQVV3QkVBRFVBS1FBYUFBNEFBaUpETVJrVVJERVlSSWdUQVNORE1Sa1VSREVZUklnU3dpTkRNUmtVUkRFWVJEWWFBWWdTZUNORE1Sa1VSREVZUklnU1VDTkRNUmtVUkRFWVJEWWFBWWdTSFNORE1Sa1VSREVZUkRZYUFZZ1I0U05ETVJrVVJERVlSRFlhQVlnUnB5aE1VTEFqUXpFWkZFUXhHRVNJRVk4b1RGQ3dJME14R1JSRU1SaEVOaG9CTmhvQ2lCQjlLRXhRc0NORE1Sa1VSREVZUkRZYUFUWWFBb2dRV2loTVVMQWpRekVaRkVReEdFUTJHZ0UyR2dJMkdnT0lFQk1vVEZDd0kwTXhHUlJFTVJoRU5ob0JpQS8zS0V4UXNDTkRNUmtVUkRFWVJJZ1A0aWhNVUxBalF6RVpGRVF4R0VTSUQ4c29URkN3STBNeEdSUkVNUmhFaUErcktFeFFzQ05ETVJrVVJERVlSSWdQakNoTVVMQWpRekVaRkVReEdFUTJHZ0UyR2dJMkdnTTJHZ1NJRHFBalF6RVpGRVF4R0VRMkdnRTJHZ0kyR2dPSURnTWpRekVaRkVReEdFUTJHZ0UyR2dJMkdnTTJHZ1NJRFZjalF6RVpGRVF4R0VRMkdnRTJHZ0kyR2dPSURRb29URkN3STBNeEdSUkVNUmhFTmhvQk5ob0NOaG9ETmhvRWlBelZJME14R1JSRU1SaEVOaG9CTmhvQ05ob0ROaG9FTmhvRmlBbUJLRXhRc0NORE1Sa1VSREVZUkRZYUFUWWFBallhQXpZYUJEWWFCWWdJL0NoTVVMQWpRekVaRkVReEdFUTJHZ0UyR2dJMkdnT0lDTUlqUXpFWkZFUXhHRVEyR2dFMkdnSTJHZ09JQ0pRalF6RVpGRVF4R0VRMkdnRTJHZ0kyR2dPSUNDQW9URkN3STBNeEdSUkVNUmhFTmhvQk5ob0NpQWZ0S0V4UXNDTkRNUmtVUkRFWVJEWWFBVFlhQWpZYUF6WWFCSWdIdGloTVVMQWpRekVaRkVReEdFUTJHZ0UyR2dLSUI0WW9URkN3STBNeEdSUkVNUmhFTmhvQk5ob0NpQWRoS0V4UXNDTkRNUmtVUkRFWVJJZ0hTeWhNVUxBalF6RVpGRVF4R0VRMkdnRTJHZ0kyR2dNMkdnU0lCeUlvVEZDd0kwTXhHUlJFTVJoRU5ob0JOaG9DTmhvRGlBYitLRXhRc0NORE1Sa1VSREVZUkRZYUFUWWFBb2dHaFNORE1Sa1VSREVZUkRZYUFUWWFBallhQTRnRjhTTkRNUmtVUkRFWVJEWWFBVFlhQWpZYUE0Z0ZraU5ETVJrVVJERVlSRFlhQVlnRmR5TkRNUmtVUkRFWVJJZ0ZXeWhNVUxBalF6RVpGRVF4R0VRMkdnR0lCT29qUXpFWkZFUXhHRVEyR2dHSUJNc29URkN3STBNeEdSUkVNUmhFTmhvQk5ob0NOaG9EaUFRUEkwTXhHUlJFTVJoRU5ob0JOaG9DTmhvRGlBT05LRXhRc0NORE1Sa1VSREVZUkRZYUFUWWFBallhQXpZYUJEWWFCWWdDN3loTVVMQWpRekVaRkVReEdFU0lBck1vVEZDd0kwTXhHUlJFTVJoRU5ob0JpQUtVSTBNeEdSUkVNUmhFTmhvQmlBSjVJME14R1JSRU1SaEVOaG9CaUFJOEkwTXhHUlJFTVJoRU5ob0JpQUh1STBNeEdSUkVNUmhFTmhvQk5ob0NOaG9ETmhvRU5ob0ZOaG9HTmhvSE5ob0lOaG9KaUFDeUtFeFFzQ05ETVJrVVJERVlSRFlhQVRZYUFqWWFBellhQklnQWZDaE1VTEFqUXpFWlFQdjJNUmdVUkNORGlnTUJpLzBpV1VtTC93aE1KUXNsQ0VzQkZsY0dBazRDaS8wbFN3SlNpLzhsQzY5UWkvMFZpLzFQQTA4Q1VsQ0wvbEJNSlF0SklreUxBNHNDREVFQUk0c0VTUlpYQmdLTEFZc0RTVTRFVHdKZFNZd0JTd0ZaSlFnSWpBUWxDSXdEUXYvVml3Q0xBVkNNQUltS0JBRXhBSXY4aS8yTC9vdi9Td1JQQlNjSFNTY09pQUFCaVlvSkFURUFNZ2tTUkl2M1Z3SUFGVWxFSkE1RWkvaFhBZ0FWU1VTQkNBNUVJaXRsUlFFVVJERUFpQTF4Z0FGdWkvZG5nQUZ6aS9obks0djZaNEFCWkl2NVp5Y1BKd2RuTVFBbkJFc0JVSXY2dnpJRFRGQ0wrbEFuSEV4UXNDY0ppL3huSndXTC9XY25Fb3YrWnljVEp3NW5KeENMLzJjeEFJdjdFMEVBQll2N2lBMUhKd2VKTVFDSURPY2lVeU1TUklraUp3bGxSUUZFTVFBaUp3bGxSQkpFSWljRlpVVUJRUUFQSWljRlpVUWlVeU1TUVFBREkwU0pJa0wvK29vQkFDSW5FbVZGQVVFQUV5SW5FbVZFSWxNakVrRUFCNHYvVndJQUZVU0pJaWNRWlVVQlFRQXVJaWNRWlVRWFFRQWxJaWNUWlVVQlFRQVZJaWNUWlVRWElpY1FaVVFYTWdZV0YwNENDQTlFTWdZV0p4Tk1aNG1LQVFBaWlQOXFJaWNKWlVVQlFRQXBJaWNKWlVTTUFDY0ppLzluSWljRlpVVUJRQUFGSndVbkIyZUxBSXYvVUlBRVFKekZjRXhRc0lrcGpBQkMvOWlLQVFDSS95eUwveUpUUUFBR0p3V0wvMmVKSWljRlpVVUJRUUFNSWljRlpVUWlVeU1TUWYvcUp3V0wvMmVKaWdFQWlQNytKeEtMLzJlSmlnRUFpUDd5SnhDTC8yZUpJaWNGWlVVQlFRQWdJaWNGWlVRaVV5TVNRUUFVSWljSlpVVUJRUUFMZ0FnQUFBQUFBQUFBQVlrbkRvbUtCUUdJL3NXTC80ais3SWovQ1l2N2kvd1RSSXY3aUFxYVNZdjlwMFNML2FGSkZTUU9SQ1N2VEVzQnF5Y0VpL3RRVEwrTC9JZ0tlNHY5b0VrVkpBNUVxeWNFaS94UVRMOHhBSXY3VUl2OFVJdjlVSUFCVVZDQUFnQ0ZVSXYrRllHRkFRZ1dWd1lDVUl2K1VJdi9VQ2NHVEZDQUJEUnVwNVZNVUxDQlVSYUppZ01CaVA1R2kvK0kvbTJJL29xTC9ZZ0tJVW1ML3FkRWkvNmhTUlVrRGtRa3IweExBYXNuQkl2OVVFeS9JaXRsUkl2K29Va1ZKQTVFcXl0TVp6RUFpLzFRaS81UWdBRlJVSUFDQUdOUWkvOVFKd1pNVUlBRURlNFU5VXhRc0lGUkZva3hBSWdLeGlKVEl4SkVpWW9EQUlqLzc0djlGVWxFTWdZV2kvNFZTVTRDZ1F3SUZsY0dBb0FDQUF4TVVFeFFpLzVRaS85UUp4ZUwvVkJKdkVoTXZ5Y0t2VVVCUUFBK0p4U0wvU09JL0lZbkNyeElKd3BNdjRFR2l3QUlTUlpYQmdJbkhVeFFUSXNCQ0JaWEJnSlFpLzFRaS81UWkvOVFKd1pNVUlBRUxjQThOa3hRc0lrbkNyNUVKeFNML1NPSS9FUkpJbGxNVndJQVN3RWxDMHNCRlZKTWlQd3hKd3E4U0NjS1RMOUMvNmlLQVFFbkY0di9VRW05UlFGRXZrU0ppZ0VBaVA4OEp4ZUwvMUJKdlVVQlJFbStSRXk4U0VraVdVc0JKVmxMQWs4Q1N3SlNTd0lWVHdOUEEwOENVb3YvRllFR0NFa1dWd1lDSngxTVVFc0RGVThDQ0JaWEJnSlFpLzlRVHdKUVRGQW5Ca3hRZ0FTdWVrK2dURkN3aVNjS3ZrU0pNUUNJQ2FVaVV5TVNSSW1LQVFDSS8rOG5ENHYvWjRtS0F3Q0kvK09ML29BQXBVUWlKdzlsUlFGQkFERWlKdzlsUkNKVEl4SkJBQ1VqUkl2OUtZditpLytJQmdlTC9ZditVQ2NZVUl2L1VDY0dURkNBQlBMcG1LOU1VTENKSWtMLzJJb0RBQ0l4QUVtTC9SSkFBQXlMQVlnSk55SlRJeEpCQUdJalJJditnQUNsUkNjRWkvMVFTWXdBdlVVQlFRQklpd0MrUkl2K3AwRUFQaU5FaXdCSnZrU0wvcUZKRlNRT1JDU3ZURXNCcTA4Q1RMOGlLMlZFaS82aFNSVWtEa1NySzB4bmkvMkwvbEFuR0ZDTC8xQW5Ca3hRSng1TVVMQ0pJa0wvdnlKQy81dUtBZ0F4QUVtTC9vQUFwVVFuQkV4UVNiMUZBVUVBU0lzQnZrU0wvcWRCQUQ0alJJc0JTYjVFaS82aFNSVWtEa1FrcjB4TEFhdFBBa3kvSWl0bFJJditvVWtWSkE1RXF5dE1aNHNBaS81UUp4aFFpLzlRSndaTVVDY2VURkN3aVNKQy83K0tBd0dML1l2K2lBQWppWW9FQVl2OGkvMkwvb2dIRVlraUp3OWxSSW1LQWdHTC9vdi9VQ2NJVEZDK1JJbUtBZ0V4QUNtTC9pbUwveWNVaUFQd01RQ0wvb3YvaUFkQWlZb0VBVEVBaS8yTC9JZ0N1RXlML0l2OVN3T0wvb3YvaUFQTWlZb0NBWXYraS85UUp4Vk1VRW05UlFGQUFBUW5GRXlKaXdDK1JFeUppZ01CSWtjQ2kvNkwvUkpCQUFVbkI0d0FpWXY5aS81UVNZd0FpLzlRSnhaTVVFbU1BYjFGQVVFQUQ0c0J2a1FYSXhKQkFBVW5CNHdBaVlzQUtWQW5Ga3hRU1l3Q3ZVVUJRUUFQaXdLK1JCY2pFa0VBQlNjSGpBQ0pKd3lNQUltS0F3QXhBSXY5RWtTTC9ZditVSXYvVUNjV1RGQW5HYitKaWdNQU1RQ0wvUkpFaS8yTC9sQ0wvMUFuRmt4UVNiMUZBVUVBQklzQXZFaUppZ1VCSWpFQWkvc3hBSXY4aVA5WUlsTWpFa2NDUUFBeWkvdUxBVkNML0ZBbkVVeFFTWXdBdlVVQlFRQVppd0JKdmtSSmkvNm5SQ09NQW92K29Va1ZKQTVFSksrcnY0c0NqQU9MQTBTTC9ZdjhpQUdmaS91TC9JdjlTd09ML292L2lBS3lqQUNKaWdVQklrbUFBRW1MKzR2OFVDY0lURkJKdlVVQlFBQStnRGxRQUNNQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFVVUdGeWRHbDBhVzl1SUc1dmRDQmxlR2x6ZEhPTUFJbUxCTDVFaS82a1FRQStnRGxTQUNNQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFVU1c1emRXWm1hV05wWlc1MElHSmhiR0Z1WTJXTUFJbUwvU2tTUVFBNmdEVlhBQ01BQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVFTVzUyWVd4cFpDQnlaV05sYVhabGNvd0FpVEVBU1l3QWkvc1RRUUNHaS91TEFJdjhpUDRPSWxNakVrbU1Ba21NQTBBQUtvdjdpd0JRaS94UUp4Rk1VRW1NQWIxRkFZc0NqQU5CQUJHTEFiNUVpLzZuUVFBREk0d0Npd0tNQTRzRFFBQkJnRHhZQUNNQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFYVDNCbGNtRjBiM0lnYm05MElHRjFkR2h2Y21sNlpXU01BSW1ML1l2OGlBQVdnQU5SQUNOTVVJQUpBQWRUZFdOalpYTnpVSXdBaVlvQ0FTbUwvb3YvVUNjSVRGQzlSUUZCQUFTTC80d0Fpd0JNaVlvQ0FDSkhCSUFBUndTQURHRnlZekUwTVRCZmFIQmZjSXYrVUVtOVJRRkFBQVdMQ2ljT3Y0c0t2a3lNQWtRaWpBWW5Eb3dCaXdFWFNZd0lpd0lYU1l3SkRFRUFUNHYraXdGUUp4Vk1VRW1NQkwxRkFVQUFEQ2NhaS85UWl3Ukp2RWhNdjRzRXZreEpUZ0tNQUVRaVdZd0ZJb3dIaXdlTEJReEJBSWVMQUZjQ0FJc0hKQXNrV0l2L0VrRUFiU05CQUY4ampBYUxCa0FBT0l2K2l3SlFKeFZNVUVtTUE3NUVJbGtXRjRFS0RFRUFJWXNEU2I1RVZ3SUFKeHFMLzFCWEFnQlFTUlVrQ2haWEJnSk1VRXNCdkVpL2lZc0pJd2dXaXdwTEFiK0wva3hRSnhxTC8xQW5GVThDVUVtOFNFeS9pWXNJSXdnV2pBRkMvenVMQnlNSWpBZEMvM0VpUXYrSGlnWUFJa21ML29BQXBVU0wrb3Y3VUNjSVRGQkp2VVVCUUFBRWl3SXB2NHNDU2I1RWkvNmhTUlVrRGtRa3IwbU1BS3UvaS9xTC9GQ0wrMUNML2xDQUFnQ0NVSXYvVUNjR1RGQ0FCQ0JyZVVCTVVMQ0wvWXY3RTBFQUI0djhpLzJJL3BlTC9JdjlVQ2NJVEZCSmpBRzlSUUZBQUFTTEFTbS9pd0ZKdmtTTC9xQkpGU1FPUklzQXE3K0ppZ1FBTVFDTC9CSkVpL3lML1ZDTC9sQW5FVXhRaS8rL2lZb0RBU0tML292OUVrRUFCQ2NIVEltTC9ZditVSXYvVUNjUlRGQkpqQUM5UlFGQUFBUW5ERXlKaXdDK1JJQUFwU2NNSWs4Q1ZFeUppZ1FBSWtreEFJZ0RWU0pUSXhKRWkvNkFBS1ZFaS95TC9WQkpKd2hNVUVtOVJRRkFBQXVMQXltL2kveUwvWWo5N1lzRFNiNUVpLzZnU1JVa0RrUWtyMG1NQUt1L0p3U0wvRkJKakFHOVJRRkFBQVNMQVNtL2l3Rkp2a1NML3FCSkZTUU9SSXNBU1U0RHE3OGlLMlZFaS82Z1NSVWtEa1NySzB4bml3S0wvbEFuRzFDTC8xQW5Ca3hRZ0FUNlJEc2JURkN3aVlvREFERUFpLzZBQUtWRVNZdjlVRWxPQWljSVRGQkp2VVVCUkVtK1JJditwMFJKdmtTTC9xRkpGU1FPUkNTdlNVNEVxNzhuQkV4UVNiMUZBVUVBUllzQ3ZrU0wvcWRCQURzalJJc0NTYjVFaS82aFNSVWtEa1NMQVVsT0E2dS9JaXRsUkl2K29Va1ZKQTVFcXl0TVo0c0FpLzVRSnh0UWkvOVFKd1pNVUNjZlRGQ3dpU0pDLzhLS0JBQWlSd014QUl2OE1RQ0wvWWo2U2lKVEl4SkhBa0FBTW92OGl3UlFpLzFRSnhGTVVFbU1BNzFGQVVFQUdZc0RTYjVFU1l2K3AwUWpqQVdML3FGSkZTUU9SQ1N2cTcrTEJZd0dpd1pFaS95TC9WQkpqQUVuQ0V4UVNiMUZBVVJKdmtTTC9xZEVTYjVFaS82aFNSVWtEa1FrcjBtTUFLdS9Kd1NML0ZCSmpBSzlSUUZCQUVXTEFyNUVpLzZuUVFBN0kwU0xBa20rUkl2K29Va1ZKQTVFaXdCSlRnT3J2eUlyWlVTTC9xRkpGU1FPUktzclRHZUxBWXYrVUNjYlVJdi9VQ2NHVEZBbkgweFFzSWtpUXYvQ0lvQUJibVZFVndJQVNSVWtFa1NKSW9BQmMyVkVWd0lBU1JXQkNCSkVpU0tBQVdSbFJJa2lLMlZFaVlvQkFZdi9pQUJIaVlvREFURUFpLzFMQVlnQXQwbUwvNmRFaS8raFNSVWtEa1FrcjZ1TC9VNENpQURDU0l2OWkvNkwvNGdBTVltS0FnRXhBSXYraS8rSUFLdUppZ0lCaS82TC80Z0Fmb21LQVFFbkJJdi9VRW05UlFGQUFBTXBUSW1MQUw1RVRJbUtBd0dML1lqLzRFbUwvb2ovMmt5TC82ZEVpLzJML2hOQkFDbUxBSXYvb1VrVkpBNUVKSzlNU3dHckp3U0wvVkJNdjRzQmkvK2dTUlVrRGtTckp3U0wvbEJNdjR2OWkvNVFpLzlRSnh4TVVMQW5CNHdBaVlvQ0FZditpLzlRQVVrVkpCSkVpWW9DQVl2K2kvK0kvK2VBQVdGTVVFbTlSUUZBQUFNcFRJbUxBTDVFVndBZ1RJbUtBd0dML1l2K2lQL0ZpLytML1ZDTC9sQ0FBV0ZQQWxCTXY0djlpLzVRaS85UWdBUVphZmhsVEZDd0p3ZUpJaWNOWlVVQlFRQUpJaWNOWlVRWFFBQVJJaXBsUlFGQUFBUXFNZ2xuSncwbkdXZUppUC9aSWlwbFJJbUtBUUdJLzg0aUttVkZBVUFBQXljTWlTSXFaVVFwRWtFQUF5Y01pU0lxWlVTTC94SW5EQ0pQQWxTSmlnRUFJaWNOWlVVQlFRQWRJaWNOWlVRWEl4SkJBQklqRkVTTC95a1RSQ3FMLzJjbkRTY1paNGtpUXYvcmlnRUFpUDkyTVFBaUttVkVFa1NML3lrVFJDSXFaVVFxaS85bmkvOVFKeUJNVUxDSmlQOVZNUUFpS21WRUVrUWlLbVZFS2lsbmdBUTBhcUZtVEZDd2lZb0JBSWovTmpFQUlpcGxSQkpFaS84cEUwUWlKd3RsUlFGQkFBa2lKd3RsUkNrVEZFUW5DNHYvWnlJcVpVU0wvMUNBQkJhL0g1Rk1VTENKaVA3K0lpY0xaVVVCUkRFQUlpY0xaVVJMQVJKRUlpcGxSQ3BMQW1jbkN5bG5URkNBQlBmamF6ZExBVkN3SnlCTVVMQ0ppUDdMTVFBaUttVkVFa1FuQ3lsbmlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNvbnRyb2xsZXJDaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MpIiwic3RydWN0IjoiYXJjMTY0NF9jb250cm9sbGVyX2NoYW5nZWRfZXZlbnQiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ29udHJvbGxlclRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGUsYnl0ZVtdLGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNjQ0X2NvbnRyb2xsZXJfdHJhbnNmZXJfZXZlbnQiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ29udHJvbGxlclJlZGVlbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZSxieXRlW10pIiwic3RydWN0IjoiYXJjMTY0NF9jb250cm9sbGVyX3JlZGVlbV9ldmVudCIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJEb2N1bWVudFVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGJ5dGVbXSxzdHJpbmcsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE2NDNfZG9jdW1lbnRfdXBkYXRlZF9ldmVudCIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJEb2N1bWVudFJlbW92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGJ5dGVbXSxzdHJpbmcsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE2NDNfZG9jdW1lbnRfcmVtb3ZlZF9ldmVudCIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJJc3N1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE0MTBfcGFydGl0aW9uX2lzc3VlIiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Iklzc3VlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE1OTRfaXNzdWVfZXZlbnQiLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE1OTRfcmVkZWVtX2V2ZW50IiwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyx1aW50MjU2LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJhcmMxNDEwX3BhcnRpdGlvbl90cmFuc2ZlciIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmMyMDBfQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlZGVlbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQyNTYsYnl0ZVtdKSIsInN0cnVjdCI6ImFyYzE0MTBfcGFydGl0aW9uX3JlZGVlbSIsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBSZW5vdW5jZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBUcmFuc2ZlclJlcXVlc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVuZGluZ19vd25lciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjODhfT3duZXJzaGlwVHJhbnNmZXJBY2NlcHRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
