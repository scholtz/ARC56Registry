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

namespace Arc56.Generated.satishccy.splitrix_algorand.Splitrix_fc6118a5
{


    public class SplitrixProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SplitrixProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Bill : AVMObjectType
            {
                public Algorand.Address Payer { get; set; }

                public ulong TotalAmount { get; set; }

                public Structs.BillDebtors[] Debtors { get; set; }

                public string Memo { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayer.From(Payer);
                    ret.AddRange(vPayer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAmount.From(TotalAmount);
                    ret.AddRange(vTotalAmount.Encode());
                    var arrDebtors = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.BillDebtors>(x => Structs.BillDebtors.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrDebtors.Value = (Debtors ?? Array.Empty<Structs.BillDebtors>()).ToList();
                    stringRef[ret.Count] = arrDebtors.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMemo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMemo.From(Memo);
                    stringRef[ret.Count] = vMemo.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Bill Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Bill();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayer = vPayer.ToValue();
                    if (valuePayer is Algorand.Address vPayerValue) { ret.Payer = vPayerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAmount = vTotalAmount.ToValue();
                    if (valueTotalAmount is ulong vTotalAmountValue) { ret.TotalAmount = vTotalAmountValue; }
                    var indexDebtors = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrDebtors = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.BillDebtors>(x => Structs.BillDebtors.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrDebtors.Decode(bytes.Skip(indexDebtors + prefixOffset).ToArray());
                    ret.Debtors = arrDebtors.Value.ToArray();
                    var indexMemo = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMemo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMemo.Decode(bytes.Skip(indexMemo + prefixOffset).ToArray());
                    var valueMemo = vMemo.ToValue();
                    if (valueMemo is string vMemoValue) { ret.Memo = vMemoValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Bill);
                }
                public bool Equals(Bill? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Bill left, Bill right)
                {
                    return EqualityComparer<Bill>.Default.Equals(left, right);
                }
                public static bool operator !=(Bill left, Bill right)
                {
                    return !(left == right);
                }

            }

            public class BillKey : AVMObjectType
            {
                public ulong GroupId { get; set; }

                public ulong BillId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroupId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGroupId.From(GroupId);
                    ret.AddRange(vGroupId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBillId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBillId.From(BillId);
                    ret.AddRange(vBillId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BillKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BillKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroupId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGroupId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGroupId = vGroupId.ToValue();
                    if (valueGroupId is ulong vGroupIdValue) { ret.GroupId = vGroupIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBillId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBillId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBillId = vBillId.ToValue();
                    if (valueBillId is ulong vBillIdValue) { ret.BillId = vBillIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BillKey);
                }
                public bool Equals(BillKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BillKey left, BillKey right)
                {
                    return EqualityComparer<BillKey>.Default.Equals(left, right);
                }
                public static bool operator !=(BillKey left, BillKey right)
                {
                    return !(left == right);
                }

            }

            public class Group : AVMObjectType
            {
                public Algorand.Address Admin { get; set; }

                public ulong BillCounter { get; set; }

                public Algorand.Address[] Members { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAdmin.From(Admin);
                    ret.AddRange(vAdmin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBillCounter = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBillCounter.From(BillCounter);
                    ret.AddRange(vBillCounter.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMembers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address[]");
                    vMembers.From(Members);
                    ret.AddRange(vMembers.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Group Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Group();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is Algorand.Address vAdminValue) { ret.Admin = vAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBillCounter = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBillCounter.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBillCounter = vBillCounter.ToValue();
                    if (valueBillCounter is ulong vBillCounterValue) { ret.BillCounter = vBillCounterValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMembers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address[]");
                    count = vMembers.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMembers = vMembers.ToValue();
                    if (valueMembers is Algorand.Address[] vMembersValue) { ret.Members = vMembersValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Group);
                }
                public bool Equals(Group? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Group left, Group right)
                {
                    return EqualityComparer<Group>.Default.Equals(left, right);
                }
                public static bool operator !=(Group left, Group right)
                {
                    return !(left == right);
                }

            }

            public class CreateBillArgDebtors : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CreateBillArgDebtors Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CreateBillArgDebtors();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CreateBillArgDebtors);
                }
                public bool Equals(CreateBillArgDebtors? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CreateBillArgDebtors left, CreateBillArgDebtors right)
                {
                    return EqualityComparer<CreateBillArgDebtors>.Default.Equals(left, right);
                }
                public static bool operator !=(CreateBillArgDebtors left, CreateBillArgDebtors right)
                {
                    return !(left == right);
                }

            }

            public class CreateBillArgPayersDebt : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CreateBillArgPayersDebt Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CreateBillArgPayersDebt();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CreateBillArgPayersDebt);
                }
                public bool Equals(CreateBillArgPayersDebt? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CreateBillArgPayersDebt left, CreateBillArgPayersDebt right)
                {
                    return EqualityComparer<CreateBillArgPayersDebt>.Default.Equals(left, right);
                }
                public static bool operator !=(CreateBillArgPayersDebt left, CreateBillArgPayersDebt right)
                {
                    return !(left == right);
                }

            }

            public class BillDebtors : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BillDebtors Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BillDebtors();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BillDebtors);
                }
                public bool Equals(BillDebtors? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BillDebtors left, BillDebtors right)
                {
                    return EqualityComparer<BillDebtors>.Default.Equals(left, right);
                }
                public static bool operator !=(BillDebtors left, BillDebtors right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class GroupCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 151, 74, 238, 234 };
                public const string Signature = "GroupCreated(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong GroupId { get; set; }

                public static GroupCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new GroupCreatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroupId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGroupId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGroupId = vGroupId.ToValue();
                    if (valueGroupId is ulong vGroupIdValue) { ret.GroupId = vGroupIdValue; }
                    return ret;

                }

            }

            public class BillChangedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 119, 148, 10, 184 };
                public const string Signature = "BillChanged((uint64,uint64))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.BillKey BillKey { get; set; }

                public static BillChangedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new BillChangedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    ret.BillKey = Structs.BillKey.Parse(queue.ToArray());
                    { var consumedBillKey = ret.BillKey.ToByteArray().Length; for (int i = 0; i < consumedBillKey && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="admin"> </param>
        /// <param name="members"> </param>
        public async Task<ulong> CreateGroup(Algorand.Address admin, Algorand.Address[] members, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 128, 2, 53 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var membersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); membersAbi.From(members);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi, membersAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateGroup_Transactions(Algorand.Address admin, Algorand.Address[] members, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 128, 2, 53 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var membersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); membersAbi.From(members);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi, membersAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="group_id"> </param>
        /// <param name="payer"> </param>
        /// <param name="total_amount"> </param>
        /// <param name="debtors"> CreateBillArgDebtors</param>
        /// <param name="memo"> </param>
        /// <param name="payers_debt"> CreateBillArgPayersDebt</param>
        public async Task<ulong> CreateBill(ulong group_id, Algorand.Address payer, ulong total_amount, Structs.CreateBillArgDebtors[] debtors, string memo, Structs.CreateBillArgPayersDebt[] payers_debt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 122, 98, 254 };
            var group_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); group_idAbi.From(group_id);
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var total_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_amountAbi.From(total_amount);
            var debtorsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CreateBillArgDebtors>(x => Structs.CreateBillArgDebtors.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; debtorsAbi.From(debtors);
            var memoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); memoAbi.From(memo);
            var payers_debtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CreateBillArgPayersDebt>(x => Structs.CreateBillArgPayersDebt.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; payers_debtAbi.From(payers_debt);

            var result = await base.CallApp(new List<object> { abiHandle, group_idAbi, payerAbi, total_amountAbi, debtorsAbi, memoAbi, payers_debtAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateBill_Transactions(ulong group_id, Algorand.Address payer, ulong total_amount, Structs.CreateBillArgDebtors[] debtors, string memo, Structs.CreateBillArgPayersDebt[] payers_debt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 122, 98, 254 };
            var group_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); group_idAbi.From(group_id);
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var total_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_amountAbi.From(total_amount);
            var debtorsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CreateBillArgDebtors>(x => Structs.CreateBillArgDebtors.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; debtorsAbi.From(debtors);
            var memoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); memoAbi.From(memo);
            var payers_debtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CreateBillArgPayersDebt>(x => Structs.CreateBillArgPayersDebt.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; payers_debtAbi.From(payers_debt);

            return await base.MakeTransactionList(new List<object> { abiHandle, group_idAbi, payerAbi, total_amountAbi, debtorsAbi, memoAbi, payers_debtAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="group_id"> </param>
        /// <param name="bill_id"> </param>
        /// <param name="sender_index"> </param>
        /// <param name="payment"> </param>
        public async Task SettleBill(PaymentTransaction payment, ulong group_id, ulong bill_id, ulong sender_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 171, 95, 106, 19 };
            var group_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); group_idAbi.From(group_id);
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);
            var sender_indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sender_indexAbi.From(sender_index);

            var result = await base.CallApp(new List<object> { abiHandle, group_idAbi, bill_idAbi, sender_indexAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SettleBill_Transactions(PaymentTransaction payment, ulong group_id, ulong bill_id, ulong sender_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 171, 95, 106, 19 };
            var group_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); group_idAbi.From(group_id);
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);
            var sender_indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sender_indexAbi.From(sender_index);

            return await base.MakeTransactionList(new List<object> { abiHandle, group_idAbi, bill_idAbi, sender_indexAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        /// <param name="group_id"> </param>
        public async Task GetGroup(ulong group_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 2, 112, 114 };
            var group_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); group_idAbi.From(group_id);

            var result = await base.SimApp(new List<object> { abiHandle, group_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetGroup_Transactions(ulong group_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 2, 112, 114 };
            var group_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); group_idAbi.From(group_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, group_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bill_key"> BillKey</param>
        public async Task GetBill(Structs.BillKey bill_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 131, 204, 237 };

            var result = await base.SimApp(new List<object> { abiHandle, bill_key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetBill_Transactions(Structs.BillKey bill_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 131, 204, 237 };

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="group_ids"> </param>
        public async Task GetGroups(ulong[] group_ids, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 172, 162, 116 };
            var group_idsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); group_idsAbi.From(group_ids);

            var result = await base.SimApp(new List<object> { abiHandle, group_idsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetGroups_Transactions(ulong[] group_ids, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 172, 162, 116 };
            var group_idsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); group_idsAbi.From(group_ids);

            return await base.MakeTransactionList(new List<object> { abiHandle, group_idsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bill_keys"> BillKey</param>
        public async Task GetBills(Structs.BillKey[] bill_keys, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 239, 50, 122 };
            var bill_keysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.BillKey>(x => Structs.BillKey.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; bill_keysAbi.From(bill_keys);

            var result = await base.SimApp(new List<object> { abiHandle, bill_keysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetBills_Transactions(Structs.BillKey[] bill_keys, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 239, 50, 122 };
            var bill_keysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.BillKey>(x => Structs.BillKey.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; bill_keysAbi.From(bill_keys);

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_keysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3BsaXRyaXgiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQmlsbCI6W3sibmFtZSI6InBheWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ0b3RhbF9hbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZGVidG9ycyIsInR5cGUiOiJCaWxsRGVidG9yc1tdIn0seyJuYW1lIjoibWVtbyIsInR5cGUiOiJzdHJpbmcifV0sIkJpbGxLZXkiOlt7Im5hbWUiOiJncm91cF9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiaWxsX2lkIiwidHlwZSI6InVpbnQ2NCJ9XSwiR3JvdXAiOlt7Im5hbWUiOiJhZG1pbiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYmlsbF9jb3VudGVyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1lbWJlcnMiLCJ0eXBlIjoiYWRkcmVzc1tdIn1dLCJDcmVhdGVCaWxsQXJnRGVidG9ycyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XSwiQ3JlYXRlQmlsbEFyZ1BheWVyc0RlYnQiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifV0sIkJpbGxEZWJ0b3JzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfZ3JvdXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZW1iZXJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ikdyb3VwQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJncm91cF9pZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9iaWxsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imdyb3VwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0KVtdIiwic3RydWN0IjoiQ3JlYXRlQmlsbEFyZ0RlYnRvcnMiLCJuYW1lIjoiZGVidG9ycyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiQ3JlYXRlQmlsbEFyZ1BheWVyc0RlYnQiLCJuYW1lIjoicGF5ZXJzX2RlYnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQmlsbENoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQmlsbEtleSIsIm5hbWUiOiJiaWxsX2tleSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldHRsZV9iaWxsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imdyb3VwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWxsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXJfaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkJpbGxDaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkJpbGxLZXkiLCJuYW1lIjoiYmlsbF9rZXkiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnYXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2dyb3VwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imdyb3VwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JpbGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQmlsbEtleSIsIm5hbWUiOiJiaWxsX2tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ncm91cHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJncm91cF9pZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYmlsbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJCaWxsS2V5IiwibmFtZSI6ImJpbGxfa2V5cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDg4XSwiZXJyb3JNZXNzYWdlIjoiQWRtaW4gbXVzdCBiZSBwcm92aWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2N10sImVycm9yTWVzc2FnZSI6IkF0IGxlYXN0IG9uZSBkZWJ0b3IgbXVzdCBiZSBwcm92aWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0MF0sImVycm9yTWVzc2FnZSI6IkF0IGxlYXN0IG9uZSB2YWxpZCBkZWJ0b3IgbXVzdCBiZSBwcm92aWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4Ml0sImVycm9yTWVzc2FnZSI6IkF0IGxlYXN0IHR3byBtZW1iZXJzIG11c3QgYmUgcHJvdmlkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzM0XSwiZXJyb3JNZXNzYWdlIjoiQmlsbCBkb2VzIG5vdCBleGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzFdLCJlcnJvck1lc3NhZ2UiOiJCaWxsIHBheWVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIzNV0sImVycm9yTWVzc2FnZSI6IkN1dG9mZiBleGNlZWRzIG5ldyBiaWxsIG9ibGlnYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDkyXSwiZXJyb3JNZXNzYWdlIjoiQ3V0b2ZmIGV4Y2VlZHMgcGVuZGluZyBkZWJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQyNF0sImVycm9yTWVzc2FnZSI6IkRlYnQgYWxyZWFkeSBwYWlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI2XSwiZXJyb3JNZXNzYWdlIjoiRGVidG9yIGlzIG5vdCBhIG1lbWJlciBvZiB0aGUgZ3JvdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDhdLCJlcnJvck1lc3NhZ2UiOiJHcm91cCBkb2VzIG5vdCBleGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMCw0MTIsNjE1LDYxNiw2MzYsNjY4LDY3Miw3MTUsNzE2LDc0OCw3OTQsODY4LDk5Nyw5OTksMTAxOSwxMDI0LDEwNzEsMTIxMiwxMjE0LDEzNDcsMTM5OSwxNDAyLDE2MzMsMTY3Nl0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA1OCwxMTk5XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBkZWJ0b3IgaW5kZXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzFdLCJlcnJvck1lc3NhZ2UiOiJNZW1vIG11c3QgYmUgcHJvdmlkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjIwXSwiZXJyb3JNZXNzYWdlIjoiTmV3IGJpbGwgZG9lcyBub3QgY29udGFpbiB0aGUgcGF5ZXIgZnJvbSBuZXR0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2LDE1MSwxNjYsMTgxLDE5NiwyMDUsMjM2LDI3MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5Ml0sImVycm9yTWVzc2FnZSI6IlBheWVyIGlzIG5vdCBhIG1lbWJlciBvZiB0aGUgZ3JvdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTRdLCJlcnJvck1lc3NhZ2UiOiJQYXllciBtdXN0IGJlIHByb3ZpZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1MV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSBzZW50IHRvIHRoZSBwYXllciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMTRdLCJlcnJvck1lc3NhZ2UiOiJSZWZlcmVuY2VkIGJpbGwgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzg4XSwiZXJyb3JNZXNzYWdlIjoiU2VuZGVyIGluZGV4IGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDEwXSwiZXJyb3JNZXNzYWdlIjoiU2VuZGVyIGlzIG5vdCBhIGRlYnRvciBmb3IgdGhpcyBiaWxsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODkwXSwiZXJyb3JNZXNzYWdlIjoiVG90YWwgYW1vdW50IGRvZXMgbm90IG1hdGNoIHRoZSBzdW0gb2YgdGhlIGRlYnRvcnMnIGFtb3VudHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTldLCJlcnJvck1lc3NhZ2UiOiJUb3RhbCBhbW91bnQgbXVzdCBiZSBncmVhdGVyIHRoYW4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOSwxNTQsMTY5LDE4NCwxOTksMjA4LDIzOSwyNzRdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTY0LDEwMTcsMTM0MCwxNTcwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5iaWxscyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdyb3VwX2NvdW50ZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc3LDE1NDZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdyb3VwcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjddLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzNCc2FYUnlhWGd1WTI5dWRISmhZM1F1VTNCc2FYUnlhWGd1WDE5aGJHZHZjSGxmWlc1MGNubHdiMmx1ZEY5M2FYUm9YMmx1YVhRb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEUTRJRFF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0ppYVd4c2N5SWdJbWR5YjNWd1gyTnZkVzUwWlhJaUlEQjRNREF3TURBd01EQXdNREF3TURBd01DQWlaM0p2ZFhCeklpQXdlRGMzT1RRd1lXSTRJREI0TVRVeFpqZGpOelVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdjMlZzWmk1bmNtOTFjRjlqYjNWdWRHVnlMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSm5jbTkxY0Y5amIzVnVkR1Z5SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUbzBNQW9nSUNBZ0x5OGdZMnhoYzNNZ1UzQnNhWFJ5YVhnb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURjeE9EQXdNak0xSURCNE1qWTNZVFl5Wm1VZ01IaGhZalZtTm1FeE15QXdlRE14TnpKallUbGtJREI0WldZd01qY3dOeklnTUhobVl6Z3pZMk5sWkNBd2VERmlZV05oTWpjMElEQjRZVGRsWmpNeU4yRWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZaM0p2ZFhBb1lXUmtjbVZ6Y3l4aFpHUnlaWE56VzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKamNtVmhkR1ZmWW1sc2JDaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFzS0dGa1pISmxjM01zZFdsdWREWTBLVnRkTEhOMGNtbHVaeXdvZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwVzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKelpYUjBiR1ZmWW1sc2JDaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3h3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJGektDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZaM0p2ZFhBb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5aWFXeHNLQ2gxYVc1ME5qUXNkV2x1ZERZMEtTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZaM0p2ZFhCektIVnBiblEyTkZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOWlhV3hzY3lnb2RXbHVkRFkwTEhWcGJuUTJOQ2xiWFNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWZlozSnZkWEJmY205MWRHVkFOU0J0WVdsdVgyTnlaV0YwWlY5aWFXeHNYM0p2ZFhSbFFEWWdiV0ZwYmw5elpYUjBiR1ZmWW1sc2JGOXliM1YwWlVBM0lHMWhhVzVmWjJGelgzSnZkWFJsUURnZ2JXRnBibDluWlhSZlozSnZkWEJmY205MWRHVkFPU0J0WVdsdVgyZGxkRjlpYVd4c1gzSnZkWFJsUURFd0lHMWhhVzVmWjJWMFgyZHliM1Z3YzE5eWIzVjBaVUF4TVNCdFlXbHVYMmRsZEY5aWFXeHNjMTl5YjNWMFpVQXhNZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QmpiR0Z6Y3lCVGNHeHBkSEpwZUNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmWW1sc2JITmZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNakk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlCamJHRnpjeUJUY0d4cGRISnBlQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qSXlPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjlpYVd4c2N3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZaM0p2ZFhCelgzSnZkWFJsUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qSXlNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG8wTUFvZ0lDQWdMeThnWTJ4aGMzTWdVM0JzYVhSeWFYZ29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveU1qTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZaM0p2ZFhCekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOWlhV3hzWDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pJeE9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUbzBNQW9nSUNBZ0x5OGdZMnhoYzNNZ1UzQnNhWFJ5YVhnb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG95TVRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWTJGc2JITjFZaUJuWlhSZlltbHNiQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmWjNKdmRYQmZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUb3lNVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TkRBS0lDQWdJQzh2SUdOc1lYTnpJRk53YkdsMGNtbDRLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk1qRTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMmR5YjNWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkaGMxOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qRTVOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUjBiR1ZmWW1sc2JGOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qRTNNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QmpiR0Z6Y3lCVGNHeHBkSEpwZUNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk1UY3lDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJ6WlhSMGJHVmZZbWxzYkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZZbWxzYkY5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pjM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TkRBS0lDQWdJQzh2SUdOc1lYTnpJRk53YkdsMGNtbDRLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpWOWlhV3hzQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOW5jbTkxY0Y5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TkRBS0lDQWdJQzh2SUdOc1lYTnpJRk53YkdsMGNtbDRLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpWOW5jbTkxY0FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJR05zWVhOeklGTndiR2wwY21sNEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTFDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6Y0d4cGRISnBlQzVqYjI1MGNtRmpkQzVUY0d4cGRISnBlQzVqYUdWamExOXRaVzFpWlhKZlpYaHBjM1J6S0cxbGJXSmxjbk02SUdKNWRHVnpMQ0J0WlcxaVpYSTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUXNJR0o1ZEdWek9ncGphR1ZqYTE5dFpXMWlaWEpmWlhocGMzUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPalE0TFRRNUNpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JR05vWldOclgyMWxiV0psY2w5bGVHbHpkSE1vYzJWc1ppd2diV1Z0WW1WeWN6b2dZWEpqTkM1RWVXNWhiV2xqUVhKeVlYbGJZWEpqTkM1QlpHUnlaWE56WFN3Z2JXVnRZbVZ5T2lCaGNtTTBMa0ZrWkhKbGMzTXBJQzArSUdKdmIydzZDaUFnSUNCd2NtOTBieUF5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z1ptOXlJRzBnYVc0Z2JXVnRZbVZ5Y3pvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWTJobFkydGZiV1Z0WW1WeVgyVjRhWE4wYzE5bWIzSmZhR1ZoWkdWeVFERTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJR1p2Y2lCdElHbHVJRzFsYldKbGNuTTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJRHdLSUNBZ0lHSjZJR05vWldOclgyMWxiV0psY2w5bGVHbHpkSE5mWVdaMFpYSmZabTl5UURZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z2FXWWdiU0E5UFNCdFpXMWlaWEk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5dFpXMWlaWEpmWlhocGMzUnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qVXlDaUFnSUNBdkx5QnlaWFIxY200Z1ZISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhKbGRITjFZZ29LWTJobFkydGZiV1Z0WW1WeVgyVjRhWE4wYzE5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZaUJqYUdWamExOXRaVzFpWlhKZlpYaHBjM1J6WDJadmNsOW9aV0ZrWlhKQU1Rb0tZMmhsWTJ0ZmJXVnRZbVZ5WDJWNGFYTjBjMTloWm5SbGNsOW1iM0pBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUVaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5Od2JHbDBjbWw0TG1OdmJuUnlZV04wTGxOd2JHbDBjbWw0TG1OeVpXRjBaVjluY205MWNDaGhaRzFwYmpvZ1lubDBaWE1zSUcxbGJXSmxjbk02SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWTNKbFlYUmxYMmR5YjNWd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qVTFMVFUyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdOeVpXRjBaVjluY205MWNDaHpaV3htTENCaFpHMXBiam9nWVhKak5DNUJaR1J5WlhOekxDQnRaVzFpWlhKek9pQmhjbU0wTGtSNWJtRnRhV05CY25KaGVWdGhjbU0wTGtGa1pISmxjM05kS1NBdFBpQmhjbU0wTGxWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z1ozSnZkWEJmYVdRZ1BTQnpaV3htTG1keWIzVndYMk52ZFc1MFpYSXVkbUZzZFdVS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVozSnZkWEJmWTI5MWJuUmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaM0p2ZFhCZlkyOTFiblJsY2lCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG8xT0FvZ0lDQWdMeThnYzJWc1ppNW5jbTkxY0Y5amIzVnVkR1Z5TG5aaGJIVmxJRDBnWjNKdmRYQmZhV1FnS3lBeENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTVNBdkx5QWlaM0p2ZFhCZlkyOTFiblJsY2lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklHNWxkMTl0WlcxaVpYSnpJRDBnWVhKak5DNUVlVzVoYldsalFYSnlZWGxiWVhKak5DNUJaR1J5WlhOelhTaGhaRzFwYmlrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01ERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZOakFLSUNBZ0lDOHZJR1p2Y2lCdElHbHVJRzFsYldKbGNuTTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtTnlaV0YwWlY5bmNtOTFjRjltYjNKZmFHVmhaR1Z5UURFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk5qQUtJQ0FnSUM4dklHWnZjaUJ0SUdsdUlHMWxiV0psY25NNkNpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lEd0tJQ0FnSUdKNklHTnlaV0YwWlY5bmNtOTFjRjloWm5SbGNsOW1iM0pBTndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnYVdZb2JTNXVZWFJwZG1VZ0lUMGdSMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeUJoYm1RZ2JtOTBJSE5sYkdZdVkyaGxZMnRmYldWdFltVnlYMlY0YVhOMGN5aHVaWGRmYldWdFltVnljeTVqYjNCNUtDa3NiU2twT2dvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZbm9nWTNKbFlYUmxYMmR5YjNWd1gyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdOaGJHeHpkV0lnWTJobFkydGZiV1Z0WW1WeVgyVjRhWE4wY3dvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSnVlaUJqY21WaGRHVmZaM0p2ZFhCZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUc1bGQxOXRaVzFpWlhKekxtRndjR1Z1WkNodEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDZ3BqY21WaGRHVmZaM0p2ZFhCZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFVLSUNBZ0lHSWdZM0psWVhSbFgyZHliM1Z3WDJadmNsOW9aV0ZrWlhKQU1Rb0tZM0psWVhSbFgyZHliM1Z3WDJGbWRHVnlYMlp2Y2tBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QmhjM05sY25RZ2JtVjNYMjFsYldKbGNuTXViR1Z1WjNSb0lENGdNU3dnSWtGMElHeGxZWE4wSUhSM2J5QnRaVzFpWlhKeklHMTFjM1FnWW1VZ2NISnZkbWxrWldRaUNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnUVhRZ2JHVmhjM1FnZEhkdklHMWxiV0psY25NZ2JYVnpkQ0JpWlNCd2NtOTJhV1JsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pZMENpQWdJQ0F2THlCaGMzTmxjblFnWVdSdGFXNHVibUYwYVhabElDRTlJRWRzYjJKaGJDNTZaWEp2WDJGa1pISmxjM01zSUNKQlpHMXBiaUJ0ZFhOMElHSmxJSEJ5YjNacFpHVmtJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV1J0YVc0Z2JYVnpkQ0JpWlNCd2NtOTJhV1JsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCelpXeG1MbWR5YjNWd2MxdG5jbTkxY0Y5cFpGMGdQU0JIY205MWNDaGhaRzFwYmoxaFpHMXBiaXhpYVd4c1gyTnZkVzUwWlhJOVlYSmpOQzVWU1c1ME5qUW9NQ2tzYldWdFltVnljejF1WlhkZmJXVnRZbVZ5Y3k1amIzQjVLQ2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TW1FS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVozSnZkWEJ6SWdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qWTJDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9SM0p2ZFhCRGNtVmhkR1ZrS0dkeWIzVndYMmxrUFdGeVl6UXVWVWx1ZERZMEtHZHliM1Z3WDJsa0tTa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVOelJoWldWbFlTQXZMeUJ0WlhSb2IyUWdJa2R5YjNWd1EzSmxZWFJsWkNoMWFXNTBOalFwSWdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DaG5jbTkxY0Y5cFpDa0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5Od2JHbDBjbWw0TG1OdmJuUnlZV04wTGxOd2JHbDBjbWw0TG1OeVpXRjBaVjlpYVd4c0tHZHliM1Z3WDJsa09pQmllWFJsY3l3Z2NHRjVaWEk2SUdKNWRHVnpMQ0IwYjNSaGJGOWhiVzkxYm5RNklHSjVkR1Z6TENCa1pXSjBiM0p6T2lCaWVYUmxjeXdnYldWdGJ6b2dZbmwwWlhNc0lIQmhlV1Z5YzE5a1pXSjBPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbU55WldGMFpWOWlhV3hzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pjM0xUZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR055WldGMFpWOWlhV3hzS0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ1ozSnZkWEJmYVdRNklHRnlZelF1VlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXVnlPaUJoY21NMExrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd4ZllXMXZkVzUwT2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JrWldKMGIzSnpPaUJoY21NMExrUjVibUZ0YVdOQmNuSmhlVnRFWldKMGIzSk5hVzVwYldGc1hTd0tJQ0FnSUM4dklDQWdJQ0J0Wlcxdk9pQmhjbU0wTGxOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCd1lYbGxjbk5mWkdWaWREb2dZWEpqTkM1RWVXNWhiV2xqUVhKeVlYbGJVR0Y1WlhKRVpXSjBYUW9nSUNBZ0x5OGdLU0F0UGlCaGNtTTBMbFZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJRFlnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjRzRnTndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEJ1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRvNE55MDRPQW9nSUNBZ0x5OGdJeUF0TFMwdElGWmhiR2xrWVhScGIyNXpJQzB0TFMwS0lDQWdJQzh2SUdGemMyVnlkQ0JuY205MWNGOXBaQzV1WVhScGRtVWdhVzRnYzJWc1ppNW5jbTkxY0hNc0lDSkhjbTkxY0NCa2IyVnpJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXROZ29nSUNBZ1luUnZhUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTXlBdkx5QWlaM0p2ZFhCeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVkeWIzVndJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk9Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbGxjaTV1WVhScGRtVWdJVDBnUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3l3Z0lsQmhlV1Z5SUcxMWMzUWdZbVVnY0hKdmRtbGtaV1FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsbGNpQnRkWE4wSUdKbElIQnliM1pwWkdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk9UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGIzUmhiRjloYlc5MWJuUWdQaUF3TENBaVZHOTBZV3dnWVcxdmRXNTBJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlQZ29nSUNBZ1lYTnpaWEowSUM4dklGUnZkR0ZzSUdGdGIzVnVkQ0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk9URUtJQ0FnSUM4dklHRnpjMlZ5ZENCa1pXSjBiM0p6TG14bGJtZDBhQ0ErSURBc0lDSkJkQ0JzWldGemRDQnZibVVnWkdWaWRHOXlJRzExYzNRZ1ltVWdjSEp2ZG1sa1pXUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1FYUWdiR1ZoYzNRZ2IyNWxJR1JsWW5SdmNpQnRkWE4wSUdKbElIQnliM1pwWkdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklHRnpjMlZ5ZENCdFpXMXZMbUo1ZEdWekxteGxibWQwYUNBK0lEQXNJQ0pOWlcxdklHMTFjM1FnWW1VZ2NISnZkbWxrWldRaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR3hsYmdvZ0lDQWdZWE56WlhKMElDOHZJRTFsYlc4Z2JYVnpkQ0JpWlNCd2NtOTJhV1JsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCbmNtOTFjQ0E5SUhObGJHWXVaM0p2ZFhCelcyZHliM1Z3WDJsa0xtNWhkR2wyWlYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaM0p2ZFhCeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1amFHVmphMTl0WlcxaVpYSmZaWGhwYzNSektHZHliM1Z3TG0xbGJXSmxjbk11WTI5d2VTZ3BMQ0J3WVhsbGNpa3NJQ0pRWVhsbGNpQnBjeUJ1YjNRZ1lTQnRaVzFpWlhJZ2IyWWdkR2hsSUdkeWIzVndJZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z05EQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdZMkZzYkhOMVlpQmphR1ZqYTE5dFpXMWlaWEpmWlhocGMzUnpDaUFnSUNCd2IzQUtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbGxjaUJwY3lCdWIzUWdZU0J0WlcxaVpYSWdiMllnZEdobElHZHliM1Z3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2hrWldKMGIzSnpMbXhsYm1kMGFDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0tZM0psWVhSbFgySnBiR3hmWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qazJDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb1pHVmlkRzl5Y3k1c1pXNW5kR2dwT2dvZ0lDQWdabkpoYldWZlpHbG5JREUzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVFFLSUNBZ0lEd0tJQ0FnSUdKNklHTnlaV0YwWlY5aWFXeHNYMkZtZEdWeVgyWnZja0EwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUdRZ1BTQmtaV0owYjNKelcybGRMbU52Y0hrb0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JREUzQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUEwTUFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh6SUM4dklEUXdDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG81T0FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVkyaGxZMnRmYldWdFltVnlYMlY0YVhOMGN5aG5jbTkxY0M1dFpXMWlaWEp6TG1OdmNIa29LU3dnWkM1a1pXSjBiM0lwTENBaVJHVmlkRzl5SUdseklHNXZkQ0JoSUcxbGJXSmxjaUJ2WmlCMGFHVWdaM0p2ZFhBaUNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVFlLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1kyaGxZMnRmYldWdFltVnlYMlY0YVhOMGN3b2dJQ0FnY0c5d0NpQWdJQ0JoYzNObGNuUWdMeThnUkdWaWRHOXlJR2x6SUc1dmRDQmhJRzFsYldKbGNpQnZaaUIwYUdVZ1ozSnZkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLR1JsWW5SdmNuTXViR1Z1WjNSb0tUb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREUzQ2lBZ0lDQmlJR055WldGMFpWOWlhV3hzWDJadmNsOW9aV0ZrWlhKQU1Rb0tZM0psWVhSbFgySnBiR3hmWVdaMFpYSmZabTl5UURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk1UQXdDaUFnSUNBdkx5QmpkWEp5Wlc1MFgySnBiR3hmYVdRZ1BTQm5jbTkxY0M1aWFXeHNYMk52ZFc1MFpYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBeE5Rb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBNElDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRBeUxURXdNd29nSUNBZ0x5OGdJeUF0TFMwdElFSjFhV3hrSUdSbFluUnZjbk1nYkdsemRDQXRMUzB0Q2lBZ0lDQXZMeUJrWldKMGIzSnpYMjVsZHlBOUlHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNVcwUmxZblJ2Y2wwb0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9aR1ZpZEc5eWN5NXNaVzVuZEdncE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVRjS0NtTnlaV0YwWlY5aWFXeHNYMlp2Y2w5b1pXRmtaWEpBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoa1pXSjBiM0p6TG14bGJtZDBhQ2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVGNLSUNBZ0lHWnlZVzFsWDJScFp5QXhOQW9nSUNBZ1BBb2dJQ0FnWW5vZ1kzSmxZWFJsWDJKcGJHeGZZV1owWlhKZlptOXlRREUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRBMUNpQWdJQ0F2THlCa0lEMGdaR1ZpZEc5eWMxdHBYUzVqYjNCNUtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF4TndvZ0lDQWdhVzUwWTE4eklDOHZJRFF3Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z05EQUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUb3hNRFlLSUNBZ0lDOHZJR2xtSUdRdVpHVmlkRzl5TG01aGRHbDJaU0FoUFNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOeklHRnVaQ0J1YjNRZ2MyVnNaaTVqYUdWamExOWtaV0owYjNKZlpYaHBjM1J6S0dSbFluUnZjbk5mYm1WM0xtTnZjSGtvS1N3Z1pDNWtaV0owYjNJcE9nb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUlDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFVLSUNBZ0lHSjZJR055WldGMFpWOWlhV3hzWDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLR1JsWW5SdmNuTXViR1Z1WjNSb0tUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgySjFjbmtnT1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dPQW9LWTNKbFlYUmxYMkpwYkd4ZlptOXlYMmhsWVdSbGNrQXlORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLR1JsWW5SdmNuTXViR1Z1WjNSb0tUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBNENpQWdJQ0JtY21GdFpWOWthV2NnT1FvZ0lDQWdQQW9nSUNBZ1lub2dZM0psWVhSbFgySnBiR3hmWVdaMFpYSmZabTl5UURJNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk56SUtJQ0FnSUM4dklHUWdQU0JrWldKMGIzSnpXMmxkTG1OdmNIa29LUW9nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnT0FvZ0lDQWdhVzUwWTE4eUlDOHZJRFE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z05EZ0tJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPamN6Q2lBZ0lDQXZMeUJwWmlCa0xtUmxZblJ2Y2lBOVBTQmtaV0owYjNJNkNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1BUMEtJQ0FnSUdKNklHTnlaV0YwWlY5aWFXeHNYMkZtZEdWeVgybG1YMlZzYzJWQU1qY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdjbVYwZFhKdUlGUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3BqY21WaGRHVmZZbWxzYkY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXpjR3hwZEhKcGVDNWpiMjUwY21GamRDNVRjR3hwZEhKcGVDNWphR1ZqYTE5a1pXSjBiM0pmWlhocGMzUnpRREk1T2dvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnYVdZZ1pDNWtaV0owYjNJdWJtRjBhWFpsSUNFOUlFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTWdZVzVrSUc1dmRDQnpaV3htTG1Ob1pXTnJYMlJsWW5SdmNsOWxlR2x6ZEhNb1pHVmlkRzl5YzE5dVpYY3VZMjl3ZVNncExDQmtMbVJsWW5SdmNpazZDaUFnSUNCaWJub2dZM0psWVhSbFgySnBiR3hmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPakV3TndvZ0lDQWdMeThnYVdZZ1pDNWtaV0owYjNJZ0lUMGdjR0Y1WlhJNkNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQWhQUW9nSUNBZ1lub2dZM0psWVhSbFgySnBiR3hmWld4elpWOWliMlI1UURFd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk1UQTRDaUFnSUNBdkx5QmtaV0owYjNKelgyNWxkeTVoY0hCbGJtUW9SR1ZpZEc5eUtHUmxZblJ2Y2oxa0xtUmxZblJ2Y2l3Z1lXMXZkVzUwUFdRdVlXMXZkVzUwTENCd1lXbGtQV0Z5WXpRdVZVbHVkRFkwS0RBcEtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ016SWdPQ0F2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBME9Bb2dJQ0FnTHdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0EwQ2dwamNtVmhkR1ZmWW1sc2JGOWhablJsY2w5cFpsOWxiSE5sUURFeE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1p5WVcxbFgySjFjbmtnTlFvS1kzSmxZWFJsWDJKcGJHeGZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoa1pXSjBiM0p6TG14bGJtZDBhQ2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVGNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFM0NpQWdJQ0JpSUdOeVpXRjBaVjlpYVd4c1gyWnZjbDlvWldGa1pYSkFOUW9LWTNKbFlYUmxYMkpwYkd4ZlpXeHpaVjlpYjJSNVFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPakV4TUMweE1URUtJQ0FnSUM4dklDTWdjR0Y1WlhJbmN5QnZkMjRnYzJoaGNtVWdhWE1nWTI5dWMybGtaWEpsWkNCbWRXeHNlU0J3WVdsa0NpQWdJQ0F2THlCa1pXSjBiM0p6WDI1bGR5NWhjSEJsYm1Rb1JHVmlkRzl5S0dSbFluUnZjajFrTG1SbFluUnZjaXdnWVcxdmRXNTBQV1F1WVcxdmRXNTBMQ0J3WVdsa1BXUXVZVzF2ZFc1MEtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ016SWdPQ0F2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTBPQW9nSUNBZ0x3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENpQWdJQ0JpSUdOeVpXRjBaVjlpYVd4c1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFS0NtTnlaV0YwWlY5aWFXeHNYMkZtZEdWeVgybG1YMlZzYzJWQU1qYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaGtaV0owYjNKekxteGxibWQwYUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnT0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ09Bb2dJQ0FnWWlCamNtVmhkR1ZmWW1sc2JGOW1iM0pmYUdWaFpHVnlRREkwQ2dwamNtVmhkR1ZmWW1sc2JGOWhablJsY2w5bWIzSkFNamc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TnpVS0lDQWdJQzh2SUhKbGRIVnliaUJHWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveE1EWUtJQ0FnSUM4dklHbG1JR1F1WkdWaWRHOXlMbTVoZEdsMlpTQWhQU0JIYkc5aVlXd3VlbVZ5YjE5aFpHUnlaWE56SUdGdVpDQnViM1FnYzJWc1ppNWphR1ZqYTE5a1pXSjBiM0pmWlhocGMzUnpLR1JsWW5SdmNuTmZibVYzTG1OdmNIa29LU3dnWkM1a1pXSjBiM0lwT2dvZ0lDQWdZaUJqY21WaGRHVmZZbWxzYkY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXpjR3hwZEhKcGVDNWpiMjUwY21GamRDNVRjR3hwZEhKcGVDNWphR1ZqYTE5a1pXSjBiM0pmWlhocGMzUnpRREk1Q2dwamNtVmhkR1ZmWW1sc2JGOWhablJsY2w5bWIzSkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCaGMzTmxjblFnWkdWaWRHOXljMTl1WlhjdWJHVnVaM1JvSUQ0Z01Dd2dJa0YwSUd4bFlYTjBJRzl1WlNCMllXeHBaQ0JrWldKMGIzSWdiWFZ6ZENCaVpTQndjbTkyYVdSbFpDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F4TUFvZ0lDQWdZWE56WlhKMElDOHZJRUYwSUd4bFlYTjBJRzl1WlNCMllXeHBaQ0JrWldKMGIzSWdiWFZ6ZENCaVpTQndjbTkyYVdSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qRXhOUzB4TVRZS0lDQWdJQzh2SUNNZ0xTMHRMU0JEYUdWamF5QjBiM1JoYkNCdFlYUmphR1Z6SUMwdExTMEtJQ0FnSUM4dklIUnZkR0ZzWDJGdGIzVnVkRjlqWVd4amRXeGhkR1ZrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdabkpoYldWZlluVnllU0F4TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pFeE53b2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0dSbFluUnZjbk5mYm1WM0xteGxibWQwYUNrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdabkpoYldWZlluVnllU0F4TndvS1kzSmxZWFJsWDJKcGJHeGZabTl5WDJobFlXUmxja0F4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveE1UY0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoa1pXSjBiM0p6WDI1bGR5NXNaVzVuZEdncE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFM0NpQWdJQ0JtY21GdFpWOWthV2NnTVRBS0lDQWdJRHdLSUNBZ0lHSjZJR055WldGMFpWOWlhV3hzWDJGbWRHVnlYMlp2Y2tBeE9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qRXhPQW9nSUNBZ0x5OGdlQ0E5SUdSbFluUnZjbk5mYm1WM1cybGRMbU52Y0hrb0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVGNLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRFE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z05EZ0tJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPakV4T1FvZ0lDQWdMeThnZEc5MFlXeGZZVzF2ZFc1MFgyTmhiR04xYkdGMFpXUWdQU0IwYjNSaGJGOWhiVzkxYm5SZlkyRnNZM1ZzWVhSbFpDQXJJSGd1WVcxdmRXNTBMbTVoZEdsMlpRb2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHWnlZVzFsWDJScFp5QXhNZ29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeE1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qRXhOd29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtHUmxZblJ2Y25OZmJtVjNMbXhsYm1kMGFDazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F4TndvZ0lDQWdZaUJqY21WaGRHVmZZbWxzYkY5bWIzSmZhR1ZoWkdWeVFERTFDZ3BqY21WaGRHVmZZbWxzYkY5aFpuUmxjbDltYjNKQU1UZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNVEl3Q2lBZ0lDQXZMeUJoYzNObGNuUWdkRzkwWVd4ZllXMXZkVzUwWDJOaGJHTjFiR0YwWldRZ1BUMGdkRzkwWVd4ZllXMXZkVzUwTENBaVZHOTBZV3dnWVcxdmRXNTBJR1J2WlhNZ2JtOTBJRzFoZEdOb0lIUm9aU0J6ZFcwZ2IyWWdkR2hsSUdSbFluUnZjbk1uSUdGdGIzVnVkSE1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVElLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHOTBZV3dnWVcxdmRXNTBJR1J2WlhNZ2JtOTBJRzFoZEdOb0lIUm9aU0J6ZFcwZ2IyWWdkR2hsSUdSbFluUnZjbk1uSUdGdGIzVnVkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG94TWpJdE1USXpDaUFnSUNBdkx5QWpJQzB0TFMwZ1UyRjJaU0J1WlhjZ1ltbHNiQ0F0TFMwdENpQWdJQ0F2THlCdVpYZGZZbWxzYkY5clpYa2dQU0JDYVd4c1MyVjVLR2R5YjNWd1gybGtQV2R5YjNWd1gybGtMQ0JpYVd4c1gybGtQV04xY25KbGJuUmZZbWxzYkY5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveE1qUXRNVEk1Q2lBZ0lDQXZMeUJ6Wld4bUxtSnBiR3h6VzI1bGQxOWlhV3hzWDJ0bGVWMGdQU0JDYVd4c0tBb2dJQ0FnTHk4Z0lDQWdJSEJoZVdWeVBYQmhlV1Z5TEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDJGdGIzVnVkRDEwYjNSaGJGOWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdaR1ZpZEc5eWN6MWtaV0owYjNKelgyNWxkeTVqYjNCNUtDa3NDaUFnSUNBdkx5QWdJQ0FnYldWdGJ6MXRaVzF2Q2lBZ0lDQXZMeUFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURKakNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwTkNBdkx5QTBOQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPakV5TkFvZ0lDQWdMeThnYzJWc1ppNWlhV3hzYzF0dVpYZGZZbWxzYkY5clpYbGRJRDBnUW1sc2JDZ0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnBiR3h6SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNVEkwTFRFeU9Rb2dJQ0FnTHk4Z2MyVnNaaTVpYVd4c2MxdHVaWGRmWW1sc2JGOXJaWGxkSUQwZ1FtbHNiQ2dLSUNBZ0lDOHZJQ0FnSUNCd1lYbGxjajF3WVhsbGNpd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOWhiVzkxYm5ROWRHOTBZV3hmWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFluUnZjbk05WkdWaWRHOXljMTl1WlhjdVkyOXdlU2dwTEFvZ0lDQWdMeThnSUNBZ0lHMWxiVzg5YldWdGJ3b2dJQ0FnTHk4Z0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk1UTXdDaUFnSUNBdkx5Qm5jbTkxY0M1aWFXeHNYMk52ZFc1MFpYSWdQU0JoY21NMExsVkpiblEyTkNoamRYSnlaVzUwWDJKcGJHeGZhV1F1Ym1GMGFYWmxJQ3NnTVNrS0lDQWdJR1p5WVcxbFgyUnBaeUF4TlFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRBd0NpQWdJQ0F2THlCamRYSnlaVzUwWDJKcGJHeGZhV1FnUFNCbmNtOTFjQzVpYVd4c1gyTnZkVzUwWlhJS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUb3hNekFLSUNBZ0lDOHZJR2R5YjNWd0xtSnBiR3hmWTI5MWJuUmxjaUE5SUdGeVl6UXVWVWx1ZERZMEtHTjFjbkpsYm5SZlltbHNiRjlwWkM1dVlYUnBkbVVnS3lBeEtRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXpNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPakV6TVFvZ0lDQWdMeThnYzJWc1ppNW5jbTkxY0hOYlozSnZkWEJmYVdRdWJtRjBhWFpsWFNBOUlHZHliM1Z3TG1OdmNIa29LUW9nSUNBZ1puSmhiV1ZmWkdsbklERXpDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pFek15MHhNelFLSUNBZ0lDOHZJQ01nTFMwdExTQlNaV3h2WVdRZ2JtVjNJR0pwYkd3Z2FXNTBieUJ0WlcxdmNua2dabTl5SUc1bGRIUnBibWNnZFhCa1lYUmxjeUF0TFMwdENpQWdJQ0F2THlCdVpYZGZZbWxzYkNBOUlITmxiR1l1WW1sc2JITmJibVYzWDJKcGJHeGZhMlY1WFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW1sc2JITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRNMkxURXpOd29nSUNBZ0x5OGdJeUF0TFMwdElFRndjR3g1SUc1bGRIUnBibWNnTFMwdExRb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hCaGVXVnljMTlrWldKMExteGxibWQwYUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlluVnllU0F4TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNVGNLQ21OeVpXRjBaVjlpYVd4c1gyWnZjbDlvWldGa1pYSkFNVGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRNMkxURXpOd29nSUNBZ0x5OGdJeUF0TFMwdElFRndjR3g1SUc1bGRIUnBibWNnTFMwdExRb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hCaGVXVnljMTlrWldKMExteGxibWQwYUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTVRjS0lDQWdJR1p5WVcxbFgyUnBaeUF4TVFvZ0lDQWdQQW9nSUNBZ1lub2dZM0psWVhSbFgySnBiR3hmWVdaMFpYSmZabTl5UURJeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk1UTTRDaUFnSUNBdkx5QndaQ0E5SUhCaGVXVnljMTlrWldKMFcybGRMbU52Y0hrb0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JREUzQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdOalFnTHk4Z05qUUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdOalFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPakUwTUMweE5ERUtJQ0FnSUM4dklDTWdWbUZzYVdSaGRHVWdZVzVrSUhWd1pHRjBaU0J2YkdRZ1ltbHNiQW9nSUNBZ0x5OGdiMnhrWDJKcGJHeGZhMlY1SUQwZ1FtbHNiRXRsZVNobmNtOTFjRjlwWkQxbmNtOTFjRjlwWkN3Z1ltbHNiRjlwWkQxd1pDNWlhV3hzWDJsa0tRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnT0NBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXROZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRReUNpQWdJQ0F2THlCaGMzTmxjblFnYjJ4a1gySnBiR3hmYTJWNUlHbHVJSE5sYkdZdVltbHNiSE1zSUNKU1pXWmxjbVZ1WTJWa0lHSnBiR3dnWkc5bGN5QnViM1FnWlhocGMzUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmlhV3hzY3lJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdVbVZtWlhKbGJtTmxaQ0JpYVd4c0lHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRRekNpQWdJQ0F2THlCdmJHUmZZbWxzYkNBOUlITmxiR1l1WW1sc2JITmJiMnhrWDJKcGJHeGZhMlY1WFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW1sc2JITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRRMENpQWdJQ0F2THlCaGMzTmxjblFnYjJ4a1gySnBiR3d1Y0dGNVpYSWdQVDBnY0dRdVltbHNiRjl3WVhsbGNpd2dJa0pwYkd3Z2NHRjVaWElnYldsemJXRjBZMmdpQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNaUF2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURnZ016SWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYVd4c0lIQmhlV1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRRMUNpQWdJQ0F2THlCaGMzTmxjblFnY0dRdWNHRjVaWEpmYVc1a1pYaGZhVzVmWW1sc2JGOWtaV0owYjNKekxtNWhkR2wyWlNBOElHOXNaRjlpYVd4c0xtUmxZblJ2Y25NdWJHVnVaM1JvTENBaVNXNTJZV3hwWkNCa1pXSjBiM0lnYVc1a1pYZ2lDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZMTh6SUM4dklEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTXlBdkx5QTBNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElEUXlJQzh2SURReUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBMENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQmtaV0owYjNJZ2FXNWtaWGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG94TkRjS0lDQWdJQzh2SUc5c1pGOWtaV0owYjNJZ1BTQnZiR1JmWW1sc2JDNWtaV0owYjNKelczQmtMbkJoZVdWeVgybHVaR1Y0WDJsdVgySnBiR3hmWkdWaWRHOXljeTV1WVhScGRtVmRMbU52Y0hrb0tRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGJuUmpYeklnTHk4Z05EZ0tJQ0FnSUNvS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTkRnS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdZM1YwYjJabUlEMGdjR1F1WVcxdmRXNTBYM1J2WDJOMWRHOW1aaTV1WVhScGRtVUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpYeklnTHk4Z05EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNVFE1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZM1YwYjJabUlEdzlJQ2h2YkdSZlpHVmlkRzl5TG1GdGIzVnVkQzV1WVhScGRtVWdMU0J2YkdSZlpHVmlkRzl5TG5CaGFXUXVibUYwYVhabEtTd2dJa04xZEc5bVppQmxlR05sWldSeklIQmxibVJwYm1jZ1pHVmlkQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElETXlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNeUF2THlBME1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNBdENpQWdJQ0JrYVdjZ01nb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJEZFhSdlptWWdaWGhqWldWa2N5QndaVzVrYVc1bklHUmxZblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG94TlRFdE1UVXlDaUFnSUNBdkx5QWpJRTFoY21zZ1kzVjBiMlptSUdGeklIQmhhV1FnYVc0Z2IyeGtJR0pwYkd3S0lDQWdJQzh2SUc5c1pGOWtaV0owYjNJdWNHRnBaQ0E5SUdGeVl6UXVWVWx1ZERZMEtHOXNaRjlrWldKMGIzSXVjR0ZwWkM1dVlYUnBkbVVnS3lCamRYUnZabVlwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUEwTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pFMU13b2dJQ0FnTHk4Z2IyeGtYMkpwYkd3dVpHVmlkRzl5YzF0d1pDNXdZWGxsY2w5cGJtUmxlRjlwYmw5aWFXeHNYMlJsWW5SdmNuTXVibUYwYVhabFhTQTlJRzlzWkY5a1pXSjBiM0l1WTI5d2VTZ3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjbVZ3YkdGalpUTUtJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkdsbklEVUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdScFp5QTFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUMwS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBME1pQXZMeUEwTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J5WlhCc1lXTmxNaUEwTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pFMU5Bb2dJQ0FnTHk4Z2MyVnNaaTVpYVd4c2MxdHZiR1JmWW1sc2JGOXJaWGxkSUQwZ2IyeGtYMkpwYkd3dVkyOXdlU2dwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklHRnlZelF1WlcxcGRDaENhV3hzUTJoaGJtZGxaQ2hpYVd4c1gydGxlVDF2YkdSZlltbHNiRjlyWlhrcEtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlCdFpYUm9iMlFnSWtKcGJHeERhR0Z1WjJWa0tDaDFhVzUwTmpRc2RXbHVkRFkwS1NraUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRVM0xURTFPQW9nSUNBZ0x5OGdJeUJTWldac1pXTjBJR04xZEc5bVppQnBiaUIwYUdVZ2JtVjNJR0pwYkd3Z0tIQmhlV1Z5SUcxMWMzUWdaWGhwYzNRZ2FXNGdibVYzSUdKcGJHd2daR1ZpZEc5eWN5a0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1pDNWtaV0owYjNKZmFXNWtaWGhmYVc1ZlkzVnljbVZ1ZEY5aWFXeHNMbTVoZEdsMlpTQThJRzVsZDE5aWFXeHNMbVJsWW5SdmNuTXViR1Z1WjNSb0xDQWlTVzUyWVd4cFpDQmtaV0owYjNJZ2FXNWtaWGdpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTlRZZ0x5OGdOVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z05EQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBME1pQXZMeUEwTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTlFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ1pHVmlkRzl5SUdsdVpHVjRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNVFU1Q2lBZ0lDQXZMeUJ1WkNBOUlHNWxkMTlpYVd4c0xtUmxZblJ2Y25OYmNHUXVaR1ZpZEc5eVgybHVaR1Y0WDJsdVgyTjFjbkpsYm5SZlltbHNiQzV1WVhScGRtVmRMbU52Y0hrb0tRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCcGJuUmpYeklnTHk4Z05EZ0tJQ0FnSUNvS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTkRnS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qRTJNQW9nSUNBZ0x5OGdZWE56WlhKMElHNWtMbVJsWW5SdmNpQTlQU0J3WkM1aWFXeHNYM0JoZVdWeUxDQWlUbVYzSUdKcGJHd2daRzlsY3lCdWIzUWdZMjl1ZEdGcGJpQjBhR1VnY0dGNVpYSWdabkp2YlNCdVpYUjBhVzVuSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbVYzSUdKcGJHd2daRzlsY3lCdWIzUWdZMjl1ZEdGcGJpQjBhR1VnY0dGNVpYSWdabkp2YlNCdVpYUjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRZeENpQWdJQ0F2THlCaGMzTmxjblFnYm1RdWNHRnBaQzV1WVhScGRtVWdLeUJqZFhSdlptWWdQRDBnYm1RdVlXMXZkVzUwTG01aGRHbDJaU3dnSWtOMWRHOW1aaUJsZUdObFpXUnpJRzVsZHlCaWFXeHNJRzlpYkdsbllYUnBiMjRpQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QTBNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCRGRYUnZabVlnWlhoalpXVmtjeUJ1WlhjZ1ltbHNiQ0J2WW14cFoyRjBhVzl1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRZeUNpQWdJQ0F2THlCdVpDNXdZV2xrSUQwZ1lYSmpOQzVWU1c1ME5qUW9ibVF1Y0dGcFpDNXVZWFJwZG1VZ0t5QmpkWFJ2Wm1ZcENpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUEwTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pFMk13b2dJQ0FnTHk4Z2JtVjNYMkpwYkd3dVpHVmlkRzl5YzF0d1pDNWtaV0owYjNKZmFXNWtaWGhmYVc1ZlkzVnljbVZ1ZEY5aWFXeHNMbTVoZEdsMlpWMGdQU0J1WkM1amIzQjVLQ2tLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTXdvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTBDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdaR2xuSURRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdMUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFF5SUM4dklEUXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lISmxjR3hoWTJVeUlEUXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUb3hNell0TVRNM0NpQWdJQ0F2THlBaklDMHRMUzBnUVhCd2JIa2dibVYwZEdsdVp5QXRMUzB0Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9jR0Y1WlhKelgyUmxZblF1YkdWdVozUm9LVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFM0NpQWdJQ0JpSUdOeVpXRjBaVjlpYVd4c1gyWnZjbDlvWldGa1pYSkFNVGtLQ21OeVpXRjBaVjlpYVd4c1gyRm1kR1Z5WDJadmNrQXlNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG94TmpVdE1UWTJDaUFnSUNBdkx5QWpJQzB0TFMwZ1UyRjJaU0IwYUdVZ2RYQmtZWFJsWkNCdVpYY2dZbWxzYkNBdExTMHRDaUFnSUNBdkx5QnpaV3htTG1KcGJHeHpXMjVsZDE5aWFXeHNYMnRsZVYwZ1BTQnVaWGRmWW1sc2JDNWpiM0I1S0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JRFlLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveE5qZ0tJQ0FnSUM4dklHRnlZelF1WlcxcGRDaENhV3hzUTJoaGJtZGxaQ2hpYVd4c1gydGxlVDF1WlhkZlltbHNiRjlyWlhrcEtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlCdFpYUm9iMlFnSWtKcGJHeERhR0Z1WjJWa0tDaDFhVzUwTmpRc2RXbHVkRFkwS1NraUNpQWdJQ0JtY21GdFpWOWthV2NnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveE5qa0tJQ0FnSUM4dklISmxkSFZ5YmlCamRYSnlaVzUwWDJKcGJHeGZhV1FLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emNHeHBkSEpwZUM1amIyNTBjbUZqZEM1VGNHeHBkSEpwZUM1elpYUjBiR1ZmWW1sc2JDaG5jbTkxY0Y5cFpEb2dZbmwwWlhNc0lHSnBiR3hmYVdRNklHSjVkR1Z6TENCelpXNWtaWEpmYVc1a1pYZzZJR0o1ZEdWekxDQndZWGx0Wlc1ME9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuTmxkSFJzWlY5aWFXeHNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPakUzTWkweE56TUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdjMlYwZEd4bFgySnBiR3dvYzJWc1ppd2daM0p2ZFhCZmFXUTZJR0Z5WXpRdVZVbHVkRFkwTENCaWFXeHNYMmxrT2lCaGNtTTBMbFZKYm5RMk5Dd2djMlZ1WkdWeVgybHVaR1Y0T2lCaGNtTTBMbFZKYm5RMk5Dd2djR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhKaGJuTmhZM1JwYjI0cElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QTBJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG94TnpRS0lDQWdJQzh2SUdKcGJHeGZhMlY1SUQwZ1FtbHNiRXRsZVNobmNtOTFjRjlwWkQxbmNtOTFjRjlwWkN3Z1ltbHNiRjlwWkQxaWFXeHNYMmxrS1FvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRjMUNpQWdJQ0F2THlCaGMzTmxjblFnWW1sc2JGOXJaWGtnYVc0Z2MyVnNaaTVpYVd4c2N5d2dJa0pwYkd3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYVd4c2N5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2FXeHNJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk1UYzJDaUFnSUNBdkx5QmlhV3hzSUQwZ2MyVnNaaTVpYVd4c2MxdGlhV3hzWDJ0bGVWMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW1sc2JITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRjM0NpQWdJQ0F2THlCaGMzTmxjblFnY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFNCaWFXeHNMbkJoZVdWeUxtNWhkR2wyWlN3Z0lsQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCelpXNTBJSFJ2SUhSb1pTQndZWGxsY2lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCelpXNTBJSFJ2SUhSb1pTQndZWGxsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pFM09Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJtUmxjbDlwYm1SbGVDNXVZWFJwZG1VZ1BDQmlhV3hzTG1SbFluUnZjbk11YkdWdVozUm9MQ0FpVTJWdVpHVnlJR2x1WkdWNElHbHpJRzkxZENCdlppQmliM1Z1WkhNaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0owYjJrS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnTkRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElEUXlJQzh2SURReUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklGTmxibVJsY2lCcGJtUmxlQ0JwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNVGM1Q2lBZ0lDQXZMeUJrWldKMGIzSWdQU0JpYVd4c0xtUmxZblJ2Y25OYmMyVnVaR1Z5WDJsdVpHVjRMbTVoZEdsMlpWMHVZMjl3ZVNncENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRFE0Q2lBZ0lDQXFDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QTBPQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveE9EQUtJQ0FnSUM4dklHRnpjMlZ5ZENCa1pXSjBiM0l1WkdWaWRHOXlMbTVoZEdsMlpTQTlQU0J3WVhsdFpXNTBMbk5sYm1SbGNpd2dJbE5sYm1SbGNpQnBjeUJ1YjNRZ1lTQmtaV0owYjNJZ1ptOXlJSFJvYVhNZ1ltbHNiQ0lLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNaUF2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRk5sYm1SbGNpQnBjeUJ1YjNRZ1lTQmtaV0owYjNJZ1ptOXlJSFJvYVhNZ1ltbHNiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPakU0TVFvZ0lDQWdMeThnWVcxdmRXNTBYM1J2WDNCaGVTQTlJR1JsWW5SdmNpNWhiVzkxYm5RdWJtRjBhWFpsSUMwZ1pHVmlkRzl5TG5CaGFXUXVibUYwYVhabENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYek1nTHk4Z05EQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDMEtJQ0FnSUdSMWNHNGdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwY21sNEwyTnZiblJ5WVdOMExuQjVPakU0TXdvZ0lDQWdMeThnWVhOelpYSjBJR0Z0YjNWdWRGOTBiMTl3WVhrZ1BpQXdMQ0FpUkdWaWRDQmhiSEpsWVdSNUlIQmhhV1FpQ2lBZ0lDQmhjM05sY25RZ0x5OGdSR1ZpZENCaGJISmxZV1I1SUhCaGFXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUb3hPRFlLSUNBZ0lDOHZJR0Z0YjNWdWRGOWhaR1JsWkNBOUlIQmhlVzFsYm5RdVlXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveE9EY0tJQ0FnSUM4dklHbG1JR0Z0YjNWdWRGOWhaR1JsWkNBK0lHRnRiM1Z1ZEY5MGIxOXdZWGs2Q2lBZ0lDQStDaUFnSUNCaWVpQnpaWFIwYkdWZlltbHNiRjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBNUNpQWdJQ0JtY21GdFpWOWlkWEo1SURFd0NncHpaWFIwYkdWZlltbHNiRjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNVGt3Q2lBZ0lDQXZMeUJ1WlhkZlpHVmlkRzl5TG5CaGFXUWdQU0JoY21NMExsVkpiblEyTkNoa1pXSjBiM0l1Y0dGcFpDNXVZWFJwZG1VZ0t5QmhiVzkxYm5SZllXUmtaV1FwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dPQW9nSUNBZ1puSmhiV1ZmWkdsbklERXdDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTndvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdOREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG94T1RFS0lDQWdJQzh2SUdKcGJHd3VaR1ZpZEc5eWMxdHpaVzVrWlhKZmFXNWtaWGd1Ym1GMGFYWmxYU0E5SUc1bGQxOWtaV0owYjNJdVkyOXdlU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdMUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFF5SUM4dklEUXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lISmxjR3hoWTJVeUlEUXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNVGt5Q2lBZ0lDQXZMeUJ6Wld4bUxtSnBiR3h6VzJKcGJHeGZhMlY1WFNBOUlHSnBiR3d1WTI5d2VTZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG94T1RNS0lDQWdJQzh2SUdGeVl6UXVaVzFwZENoQ2FXeHNRMmhoYm1kbFpDaGlhV3hzWDJ0bGVUMWlhV3hzWDJ0bGVTa3BDaUFnSUNCaWVYUmxZeUEwSUM4dklHMWxkR2h2WkNBaVFtbHNiRU5vWVc1blpXUW9LSFZwYm5RMk5DeDFhVzUwTmpRcEtTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5Od2JHbDBjbWw0TG1OdmJuUnlZV04wTGxOd2JHbDBjbWw0TGw5blpYUmZaM0p2ZFhBb1ozSnZkWEJmYVdRNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZloyVjBYMmR5YjNWd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qRTVPUzB5TURBS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdYMmRsZEY5bmNtOTFjQ2h6Wld4bUxDQm5jbTkxY0Y5cFpEb2dZWEpqTkM1VlNXNTBOalFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUb3lNREVLSUNBZ0lDOHZJR2xtSUdkeWIzVndYMmxrTG01aGRHbDJaU0JwYmlCelpXeG1MbWR5YjNWd2N6b0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5SdmFRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVozSnZkWEJ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dYMmRsZEY5bmNtOTFjRjlsYkhObFgySnZaSGxBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pJd01nb2dJQ0FnTHk4Z1ozSnZkWEFnUFNCelpXeG1MbWR5YjNWd2MxdG5jbTkxY0Y5cFpDNXVZWFJwZG1WZExtTnZjSGtvS1FvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1keWIzVndjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveU1ETUtJQ0FnSUM4dklHeHZaeWhuY205MWNDa0tJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ3BmWjJWMFgyZHliM1Z3WDJWc2MyVmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qSXdOUW9nSUNBZ0x5OGdiRzluS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdiRzluQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjM0JzYVhSeWFYZ3VZMjl1ZEhKaFkzUXVVM0JzYVhSeWFYZ3VYMmRsZEY5aWFXeHNLR0pwYkd4ZmEyVjVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbDluWlhSZlltbHNiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG95TURjdE1qQTRDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUY5blpYUmZZbWxzYkNoelpXeG1MQ0JpYVd4c1gydGxlVG9nUW1sc2JFdGxlU2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qSXdPUW9nSUNBZ0x5OGdhV1lnWW1sc2JGOXJaWGtnYVc0Z2MyVnNaaTVpYVd4c2N6b0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnBiR3h6SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmZaMlYwWDJKcGJHeGZaV3h6WlY5aWIyUjVRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG95TVRBS0lDQWdJQzh2SUdKcGJHd2dQU0J6Wld4bUxtSnBiR3h6VzJKcGJHeGZhMlY1WFM1amIzQjVLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpYVd4c2N5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG95TVRFS0lDQWdJQzh2SUd4dlp5aGlhV3hzS1FvZ0lDQWdiRzluQ2dwZloyVjBYMkpwYkd4ZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NsOW5aWFJmWW1sc2JGOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG95TVRNS0lDQWdJQzh2SUd4dlp5Z3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUd4dlp3b2dJQ0FnWWlCZloyVjBYMkpwYkd4ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTndiR2wwY21sNExtTnZiblJ5WVdOMExsTndiR2wwY21sNExtZGxkRjluY205MWNDaG5jbTkxY0Y5cFpEb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtZGxkRjluY205MWNEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUb3lNVFV0TWpFMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJuWlhSZlozSnZkWEFvYzJWc1ppd2daM0p2ZFhCZmFXUTZJR0Z5WXpRdVZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNakUzQ2lBZ0lDQXZMeUJ6Wld4bUxsOW5aWFJmWjNKdmRYQW9aM0p2ZFhCZmFXUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJkbGRGOW5jbTkxY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk53YkdsMGNtbDRMbU52Ym5SeVlXTjBMbE53YkdsMGNtbDRMbWRsZEY5aWFXeHNLR0pwYkd4ZmEyVjVPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0taMlYwWDJKcGJHdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNakU1TFRJeU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNBdkx5QmtaV1lnWjJWMFgySnBiR3dvYzJWc1ppd2dZbWxzYkY5clpYazZJRUpwYkd4TFpYa3BJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRISnBlQzlqYjI1MGNtRmpkQzV3ZVRveU1qRUtJQ0FnSUM4dklITmxiR1l1WDJkbGRGOWlhV3hzS0dKcGJHeGZhMlY1S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOW5aWFJmWW1sc2JBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBdE1Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5Od2JHbDBjbWw0TG1OdmJuUnlZV04wTGxOd2JHbDBjbWw0TG1kbGRGOW5jbTkxY0hNb1ozSnZkWEJmYVdSek9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1oyVjBYMmR5YjNWd2N6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUb3lNak10TWpJMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJuWlhSZlozSnZkWEJ6S0hObGJHWXNJR2R5YjNWd1gybGtjem9nWVhKak5DNUVlVzVoYldsalFYSnlZWGxiWVhKak5DNVZTVzUwTmpSZEtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvWjNKdmRYQmZhV1J6TG14bGJtZDBhQ2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbWRsZEY5bmNtOTFjSE5mWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qSXlOUW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtHZHliM1Z3WDJsa2N5NXNaVzVuZEdncE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJmWjNKdmRYQnpYMkZtZEdWeVgyWnZja0EwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSeWFYZ3ZZMjl1ZEhKaFkzUXVjSGs2TWpJMkNpQWdJQ0F2THlCbmNtOTFjRjlwWkNBOUlHZHliM1Z3WDJsa2MxdHBYUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY0hWemFHbHVkQ0E0SUM4dklEZ0tJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdPQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkSEpwZUM5amIyNTBjbUZqZEM1d2VUb3lNamNLSUNBZ0lDOHZJSE5sYkdZdVgyZGxkRjluY205MWNDaG5jbTkxY0Y5cFpDa0tJQ0FnSUdOaGJHeHpkV0lnWDJkbGRGOW5jbTkxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pJeU5Rb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0dkeWIzVndYMmxrY3k1c1pXNW5kR2dwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCblpYUmZaM0p2ZFhCelgyWnZjbDlvWldGa1pYSkFNUW9LWjJWMFgyZHliM1Z3YzE5aFpuUmxjbDltYjNKQU5Eb0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emNHeHBkSEpwZUM1amIyNTBjbUZqZEM1VGNHeHBkSEpwZUM1blpYUmZZbWxzYkhNb1ltbHNiRjlyWlhsek9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1oyVjBYMkpwYkd4ek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBjbWw0TDJOdmJuUnlZV04wTG5CNU9qSXlPUzB5TXpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5aWFXeHNjeWh6Wld4bUxDQmlhV3hzWDJ0bGVYTTZJR0Z5WXpRdVJIbHVZVzFwWTBGeWNtRjVXMEpwYkd4TFpYbGRLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUnlhWGd2WTI5dWRISmhZM1F1Y0hrNk1qTXhDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb1ltbHNiRjlyWlhsekxteGxibWQwYUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ21kbGRGOWlhV3hzYzE5bWIzSmZhR1ZoWkdWeVFERTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJ5YVhndlkyOXVkSEpoWTNRdWNIazZNak14Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9ZbWxzYkY5clpYbHpMbXhsYm1kMGFDazZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJRHdLSUNBZ0lHSjZJR2RsZEY5aWFXeHNjMTloWm5SbGNsOW1iM0pBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pJek1nb2dJQ0FnTHk4Z1ltbHNiRjlyWlhrZ1BTQmlhV3hzWDJ0bGVYTmJhVjB1WTI5d2VTZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBJREUySUM4dklERTJDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJREUySUM4dklERTJDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEhKcGVDOWpiMjUwY21GamRDNXdlVG95TXpNS0lDQWdJQzh2SUhObGJHWXVYMmRsZEY5aWFXeHNLR0pwYkd4ZmEyVjVLUW9nSUNBZ1kyRnNiSE4xWWlCZloyVjBYMkpwYkd3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMGNtbDRMMk52Ym5SeVlXTjBMbkI1T2pJek1Rb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0dKcGJHeGZhMlY1Y3k1c1pXNW5kR2dwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCblpYUmZZbWxzYkhOZlptOXlYMmhsWVdSbGNrQXhDZ3BuWlhSZlltbHNiSE5mWVdaMFpYSmZabTl5UURRNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRXdLQ1lHQldKcGJHeHpEV2R5YjNWd1gyTnZkVzUwWlhJSUFBQUFBQUFBQUFBR1ozSnZkWEJ6QkhlVUNyZ0VGUjk4ZFRFWVFBQURLU0puTVJ0QkFOK0NDQVJ4Z0FJMUJDWjZZdjRFcTE5cUV3UXhjc3FkQk84Q2NISUUvSVBNN1FRYnJLSjBCS2Z2TW5vMkdnQ09DQUNKQUdZQVJ3QStBQzhBSUFBUkFBSWlRekVaRkVReEdFUTJHZ0dJQmRzalF6RVpGRVF4R0VRMkdnR0lCYUVqUXpFWkZFUXhHRVEyR2dHSUJZY2pRekVaRkVReEdFUTJHZ0dJQlc4alF6RVpGRVF4R0VRalF6RVpGRVF4R0VRMkdnRTJHZ0kyR2dNeEZpTUpTVGdRSXhKRWlBUStJME14R1JSRU1SaEVOaG9CTmhvQ05ob0ROaG9FTmhvRk5ob0dpQUVKSndWTVVMQWpRekVaRkVReEdFUTJHZ0UyR2dLSUFFNG5CVXhRc0NORE1SbEEvMXN4R0JSRUkwT0tBZ0tML2lKWklvc0Jpd0FNUVFBa2kvNVhBZ0NMQVlFZ0M0RWdXSXYvRWtFQUNDT0wvazhEVHdPSml3RWpDSXdCUXYvVUlvditUd05QQTRtS0FnRWlSd0lwWlV4SlR3SkVJd2dwVEdlQUFnQUJpLzVRaS84aVdTS0xCWXNFREVFQVM0di9Wd0lBaXdXQklBdUJJRmhKakFBeUF4T0xBNHdCUVFBa2l3Tkppd0NJLzN4SVRJd0JRQUFWaXdOWEFnQ0xBRkJKRllFZ0NoWlhCZ0pNVUl3Qml3R01BNHNGSXdpTUJVTC9yWXNEU1NKWkl3MUVpLzR5QXhORWkvNHFVSUFDQUNwUVRGQ0xBaFlyU3dGUVNieElUd0svZ0FTWFN1N3FTd0ZRc0l3QWlZb0dBU0pIQjRBQVJ3U0wraGNXSzB4UVJ3SzlSUUZFaS9zeUF4TkVpL3dxcFVTTC9TSlpTVTRDUkl2K0ZVUytURWxQQWtSSkpWbExBUlZTU1l2N2lQN2ZTRVFpaXhHTERneEJBQ0NML1ZjQ0FJc1JTVTRDSlFzbFdGY0FJSXNRVElqK3ZVaEVJd2lNRVVMLzJJc1BWeUFJakFHQUFnQUFqQVFpakJHTEVZc09ERUVBcjR2OVZ3SUFpeEVsQ3lWWVNZd0NWd0FnU1l3RE1nTVRpd1NNQlVFQVZvc0VJbG1NQ1NLTUNJc0lpd2tNUVFCOGl3UlhBZ0NMQ0NRTEpGaFhBQ0NMQXhKQkFGOGppd1NNQlVBQUtZc0RpL3NUUVFBdWl3UlhBZ0NMQWxjZ0NJc0RURkFxVUZCSkZTUUtGbGNHQWt4UWpBU0xCSXdGaXdXTUJJc1JJd2lNRVVML2Q0c0VWd0lBaXdKWElBaUxBMHNCVUV4UVVFa1ZKQW9XVndZQ1RGQ01CRUwvem9zSUl3aU1DRUwvZkNKQy81V0xCQ0paU1l3S1JDS01EQ0tNRVlzUml3b01RUUFkaXdSWEFnQ0xFVWxPQWlRTEpGaUJJRnVMREFpTURDTUlqQkZDLzl1TERCYUwvS2hFaS9xTEFWQkpqQWVMKzR2OFVJQUNBQ3hRaXdSSlRnSVZnU3dJRmxjR0FsQk1VSXYrVUNoUEFsQkpqQUJKdkVoSlR3Sy9pdzlKZ1NCYkl3Z1dYQ0NMRFVtOFNFeS92a3lNQmtTTC95SlpqQXNpakJHTEVZc0xERUVCUEl2L1Z3SUFpeEZKVGdLQlFBdUJRRmhKVndBSWkvcE1VQ2hMQVZCSnZVVUJSRW0rUkVsWEFDQkxCRmNJSUV4TEFSSkVTd1FsVzBzQ0pWbExBNEVxV1VzRVN3SkxBbEpKSWxsTEJBMUVTVmNDQUU4RUpBdE1Td0VrV0VzSkpGdExBWUVnVzBzQ0pWdE1Td0VKU3dJUFJFc0JDQlpQQWt4Y0tFOENnUUlJVHdOTVR3SmRTd1VpU3dWWVN3WVZUd2RMQlU4Q1VreExBbEJNVUU4RFR3UUpUd0lWU3dLQktsa0lUQWtXVndZQ1hDcExBN3hJVHdOTXZ5Y0VUd05Rc0U4Q2dUaGJpd1pKSlZsTEFZRXFXVXNDU3dKTEFsSkpJbGxMQlExRVNWY0NBRThGSkF0TVN3RWtXRWxYQUNCUENCSkVTU1ZiVHdjSVN3R0JJRnRMQVE5RUZsd29USUVDQ0V4ZFN3TWlTd1JZU3dRVlR3VkxCRThDVWt4TEFsQk1VRThDVHdNSlR3SVZTd0tCS2xrSVRBa1dWd1lDWENxTUJpTUlqQkZDL3J5TEFFbThTSXNHdnljRWl3ZFFzSXNCakFDSmlnUUFpL3lML1ZCSktFeFFSd0s5UlFGRXZreEpUd0pFaS84NEIwc0JWd0FnRWtTTC9oZExBU1ZaU1U0Q1RnTkxBb0VxV1VsT0JFOERUd05QQWxKSlRnSkpJbGxMQWcxRVZ3SUFUQ1FMU1U0Q0pGaEhBbGNBSUl2L09BQVNSRW1CSUZ0TUpWdEpUZ0lKUndKRWkvODRDRWxQQWcxQkFBU0xDWXdLaXdpTENnZ1dpd2RNWENpTEJvRUNDSXNGVEU4Q1hZc0NTU0tMQTBsT0JWaExBUlZQQW9zRVNVNEVUd0pTVEVzRFVFeFFURThEQ1U4Q0ZVc0NnU3BaQ0V3SkZsY0dBbHdxaXdGSnZFaE12eWNFaXdCUXNJbUtBUUNML3hjV0sweFFTYjFGQVVFQUJvc0F2a1N3aVlBQXNJbUtBUUVvaS85UVNiMUZBVUVBQ1lzQXZrU3dpLzlNaVlBQXNFTC85b29CQUl2L2lQL0FpWW9CQUl2L2lQL1NqUCtKaWdFQWkvOGlXU0tMQVlzQURFRUFHb3YvVndJQWl3RkpUZ0tCQ0F1QkNGaUkvNUVqQ0l3QlF2L2VpWW9CQUl2L0lsa2lpd0dMQUF4QkFCdUwvMWNDQUlzQlNVNENnUkFMZ1JCWWlQK0JTQ01JakFGQy85MkoiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiR3JvdXBDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imdyb3VwX2lkIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJCaWxsQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJCaWxsS2V5IiwibmFtZSI6ImJpbGxfa2V5IiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
