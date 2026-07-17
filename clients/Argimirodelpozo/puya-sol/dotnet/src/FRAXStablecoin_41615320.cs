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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.FRAXStablecoin_41615320
{


    public class FRAXStablecoinProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FRAXStablecoinProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AddressSet : AVMObjectType
            {
                public Structs.Set Inner { get; set; } = new Structs.Set();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Inner.ToByteArray();
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

                public static AddressSet Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AddressSet();
                    var indexInner = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Inner = Structs.Set.Parse(bytes.Skip(indexInner + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AddressSet);
                }
                public bool Equals(AddressSet? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AddressSet left, AddressSet right)
                {
                    return EqualityComparer<AddressSet>.Default.Equals(left, right);
                }
                public static bool operator !=(AddressSet left, AddressSet right)
                {
                    return !(left == right);
                }

            }

            public class RoleData : AVMObjectType
            {
                public Structs.AddressSet Members { get; set; } = new Structs.AddressSet();

                public byte[] AdminRole { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMembers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("AddressSet");
                    vMembers.From(Members);
                    ret.AddRange(vMembers.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdminRole = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vAdminRole.From(AdminRole);
                    ret.AddRange(vAdminRole.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RoleData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RoleData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMembers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("AddressSet");
                    count = vMembers.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMembers = vMembers.ToValue();
                    if (valueMembers is Structs.AddressSet vMembersValue) { ret.Members = vMembersValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdminRole = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vAdminRole.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdminRole = vAdminRole.ToValue();
                    if (valueAdminRole is byte[] vAdminRoleValue) { ret.AdminRole = vAdminRoleValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RoleData);
                }
                public bool Equals(RoleData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RoleData left, RoleData right)
                {
                    return EqualityComparer<RoleData>.Default.Equals(left, right);
                }
                public static bool operator !=(RoleData left, RoleData right)
                {
                    return !(left == right);
                }

            }

            public class Set : AVMObjectType
            {
                public byte[][] Values { get; set; }

                public byte[] Indexes { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValues = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][]");
                    vValues.From(Values);
                    ret.AddRange(vValues.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIndexes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vIndexes.From(Indexes);
                    ret.AddRange(vIndexes.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Set Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Set();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValues = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][]");
                    count = vValues.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValues = vValues.ToValue();
                    if (valueValues is byte[][] vValuesValue) { ret.Values = vValuesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIndexes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vIndexes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIndexes = vIndexes.ToValue();
                    if (valueIndexes is byte[] vIndexesValue) { ret.Indexes = vIndexesValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Set);
                }
                public bool Equals(Set? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Set left, Set right)
                {
                    return EqualityComparer<Set>.Default.Equals(left, right);
                }
                public static bool operator !=(Set left, Set right)
                {
                    return !(left == right);
                }

            }

            public class FraxInfoReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field4 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field5 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field6 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field7 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static FraxInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FraxInfoReturn();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    var vField4 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field4 = vField4;
                    var vField5 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field5 = vField5;
                    var vField6 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field6 = vField6;
                    var vField7 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field7 = vField7;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as FraxInfoReturn);
                }
                public bool Equals(FraxInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FraxInfoReturn left, FraxInfoReturn right)
                {
                    return EqualityComparer<FraxInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(FraxInfoReturn left, FraxInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class OwnerChangedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 99, 218, 219, 229 };
                public const string Signature = "OwnerChanged(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] OldOwner { get; set; }
                public byte[] NewOwner { get; set; }

                public static OwnerChangedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OwnerChangedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOldOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOldOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOldOwner = vOldOwner.ToValue();
                    if (valueOldOwner is byte[] vOldOwnerValue) { ret.OldOwner = vOldOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is byte[] vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

            public class RoleGrantedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 77, 144, 169, 61 };
                public const string Signature = "RoleGranted(uint8[32],uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Role { get; set; }
                public byte[] Account { get; set; }
                public byte[] Sender { get; set; }

                public static RoleGrantedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RoleGrantedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRole = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vRole.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRole = vRole.ToValue();
                    if (valueRole is byte[] vRoleValue) { ret.Role = vRoleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is byte[] vAccountValue) { ret.Account = vAccountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is byte[] vSenderValue) { ret.Sender = vSenderValue; }
                    return ret;

                }

            }

            public class TransferEvent
            {
                public static readonly byte[] Selector = new byte[4] { 154, 200, 211, 241 };
                public const string Signature = "Transfer(uint8[32],uint8[32],uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] From { get; set; }
                public byte[] To { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

                public static TransferEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new TransferEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is byte[] vFromValue) { ret.From = vFromValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is byte[] vToValue) { ret.To = vToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

            public class CollateralRatioRefreshedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 6, 54, 191, 41 };
                public const string Signature = "CollateralRatioRefreshed(uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 GlobalCollateralRatio { get; set; }

                public static CollateralRatioRefreshedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CollateralRatioRefreshedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGlobalCollateralRatio = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vGlobalCollateralRatio.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGlobalCollateralRatio = vGlobalCollateralRatio.ToValue();
                    if (valueGlobalCollateralRatio is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vGlobalCollateralRatioValue) { ret.GlobalCollateralRatio = vGlobalCollateralRatioValue; }
                    return ret;

                }

            }

            public class ApprovalEvent
            {
                public static readonly byte[] Selector = new byte[4] { 5, 13, 90, 144 };
                public const string Signature = "Approval(uint8[32],uint8[32],uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Owner { get; set; }
                public byte[] Spender { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

                public static ApprovalEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ApprovalEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is byte[] vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is byte[] vSpenderValue) { ret.Spender = vSpenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

            public class FraxBurnedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 215, 11, 162, 47 };
                public const string Signature = "FRAXBurned(uint8[32],uint8[32],uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] From { get; set; }
                public byte[] To { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public static FraxBurnedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FraxBurnedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is byte[] vFromValue) { ret.From = vFromValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is byte[] vToValue) { ret.To = vToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmountValue) { ret.Amount = vAmountValue; }
                    return ret;

                }

            }

            public class FraxMintedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 227, 203, 173, 145 };
                public const string Signature = "FRAXMinted(uint8[32],uint8[32],uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] From { get; set; }
                public byte[] To { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public static FraxMintedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FraxMintedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is byte[] vFromValue) { ret.From = vFromValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is byte[] vToValue) { ret.To = vToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmountValue) { ret.Amount = vAmountValue; }
                    return ret;

                }

            }

            public class PoolAddedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 88, 26, 29, 46 };
                public const string Signature = "PoolAdded(uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] PoolAddress { get; set; }

                public static PoolAddedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PoolAddedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vPoolAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolAddress = vPoolAddress.ToValue();
                    if (valuePoolAddress is byte[] vPoolAddressValue) { ret.PoolAddress = vPoolAddressValue; }
                    return ret;

                }

            }

            public class PoolRemovedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 11, 126, 217, 167 };
                public const string Signature = "PoolRemoved(uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] PoolAddress { get; set; }

                public static PoolRemovedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PoolRemovedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vPoolAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolAddress = vPoolAddress.ToValue();
                    if (valuePoolAddress is byte[] vPoolAddressValue) { ret.PoolAddress = vPoolAddressValue; }
                    return ret;

                }

            }

            public class RedemptionFeeSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 195, 223, 86, 92 };
                public const string Signature = "RedemptionFeeSet(uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 RedFee { get; set; }

                public static RedemptionFeeSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RedemptionFeeSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRedFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vRedFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRedFee = vRedFee.ToValue();
                    if (valueRedFee is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vRedFeeValue) { ret.RedFee = vRedFeeValue; }
                    return ret;

                }

            }

            public class MintingFeeSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 127, 91, 37, 100 };
                public const string Signature = "MintingFeeSet(uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 MinFee { get; set; }

                public static MintingFeeSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new MintingFeeSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vMinFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinFee = vMinFee.ToValue();
                    if (valueMinFee is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vMinFeeValue) { ret.MinFee = vMinFeeValue; }
                    return ret;

                }

            }

            public class FraxStepSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 184, 194, 35, 187 };
                public const string Signature = "FraxStepSet(uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewStep { get; set; }

                public static FraxStepSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FraxStepSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewStep = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewStep.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewStep = vNewStep.ToValue();
                    if (valueNewStep is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewStepValue) { ret.NewStep = vNewStepValue; }
                    return ret;

                }

            }

            public class PriceTargetSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 17, 253, 194, 242 };
                public const string Signature = "PriceTargetSet(uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewPriceTarget { get; set; }

                public static PriceTargetSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PriceTargetSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewPriceTarget = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewPriceTarget.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewPriceTarget = vNewPriceTarget.ToValue();
                    if (valueNewPriceTarget is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewPriceTargetValue) { ret.NewPriceTarget = vNewPriceTargetValue; }
                    return ret;

                }

            }

            public class RefreshCooldownSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 23, 163, 104, 146 };
                public const string Signature = "RefreshCooldownSet(uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewCooldown { get; set; }

                public static RefreshCooldownSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RefreshCooldownSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewCooldown.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewCooldown = vNewCooldown.ToValue();
                    if (valueNewCooldown is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewCooldownValue) { ret.NewCooldown = vNewCooldownValue; }
                    return ret;

                }

            }

            public class FxsAddressSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 57, 25, 120, 180 };
                public const string Signature = "FXSAddressSet(uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] FxsAddress { get; set; }

                public static FxsAddressSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FxsAddressSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFxsAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vFxsAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFxsAddress = vFxsAddress.ToValue();
                    if (valueFxsAddress is byte[] vFxsAddressValue) { ret.FxsAddress = vFxsAddressValue; }
                    return ret;

                }

            }

            public class EthusdOracleSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 151, 224, 224, 198 };
                public const string Signature = "ETHUSDOracleSet(uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] EthUsdConsumerAddress { get; set; }

                public static EthusdOracleSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new EthusdOracleSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEthUsdConsumerAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vEthUsdConsumerAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEthUsdConsumerAddress = vEthUsdConsumerAddress.ToValue();
                    if (valueEthUsdConsumerAddress is byte[] vEthUsdConsumerAddressValue) { ret.EthUsdConsumerAddress = vEthUsdConsumerAddressValue; }
                    return ret;

                }

            }

            public class TimelockSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 30, 92, 251, 130 };
                public const string Signature = "TimelockSet(uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] NewTimelock { get; set; }

                public static TimelockSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new TimelockSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewTimelock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewTimelock.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewTimelock = vNewTimelock.ToValue();
                    if (valueNewTimelock is byte[] vNewTimelockValue) { ret.NewTimelock = vNewTimelockValue; }
                    return ret;

                }

            }

            public class ControllerSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 183, 230, 5, 190 };
                public const string Signature = "ControllerSet(uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] ControllerAddress { get; set; }

                public static ControllerSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ControllerSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vControllerAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vControllerAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueControllerAddress = vControllerAddress.ToValue();
                    if (valueControllerAddress is byte[] vControllerAddressValue) { ret.ControllerAddress = vControllerAddressValue; }
                    return ret;

                }

            }

            public class PriceBandSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 246, 214, 245, 149 };
                public const string Signature = "PriceBandSet(uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 PriceBand { get; set; }

                public static PriceBandSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PriceBandSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceBand = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vPriceBand.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePriceBand = vPriceBand.ToValue();
                    if (valuePriceBand is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vPriceBandValue) { ret.PriceBand = vPriceBandValue; }
                    return ret;

                }

            }

            public class FraxethOracleSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 250, 81, 88, 207 };
                public const string Signature = "FRAXETHOracleSet(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] FraxOracleAddr { get; set; }
                public byte[] WethAddress { get; set; }

                public static FraxethOracleSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FraxethOracleSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFraxOracleAddr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vFraxOracleAddr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFraxOracleAddr = vFraxOracleAddr.ToValue();
                    if (valueFraxOracleAddr is byte[] vFraxOracleAddrValue) { ret.FraxOracleAddr = vFraxOracleAddrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWethAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vWethAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWethAddress = vWethAddress.ToValue();
                    if (valueWethAddress is byte[] vWethAddressValue) { ret.WethAddress = vWethAddressValue; }
                    return ret;

                }

            }

            public class FxsEthOracleSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 110, 191, 109, 87 };
                public const string Signature = "FXSEthOracleSet(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] FxsOracleAddr { get; set; }
                public byte[] WethAddress { get; set; }

                public static FxsEthOracleSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FxsEthOracleSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFxsOracleAddr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vFxsOracleAddr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFxsOracleAddr = vFxsOracleAddr.ToValue();
                    if (valueFxsOracleAddr is byte[] vFxsOracleAddrValue) { ret.FxsOracleAddr = vFxsOracleAddrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWethAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vWethAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWethAddress = vWethAddress.ToValue();
                    if (valueWethAddress is byte[] vWethAddressValue) { ret.WethAddress = vWethAddressValue; }
                    return ret;

                }

            }

            public class CollateralRatioToggledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 248, 137, 46, 108 };
                public const string Signature = "CollateralRatioToggled(bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public bool CollateralRatioPaused { get; set; }

                public static CollateralRatioToggledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CollateralRatioToggledEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateralRatioPaused = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCollateralRatioPaused.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCollateralRatioPaused = vCollateralRatioPaused.ToValue();
                    if (valueCollateralRatioPaused is bool vCollateralRatioPausedValue) { ret.CollateralRatioPaused = vCollateralRatioPausedValue; }
                    return ret;

                }

            }

            public class OwnerNominatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 195, 190, 123, 58 };
                public const string Signature = "OwnerNominated(uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] NewOwner { get; set; }

                public static OwnerNominatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OwnerNominatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is byte[] vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

            public class RoleRevokedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 217, 184, 166, 38 };
                public const string Signature = "RoleRevoked(uint8[32],uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Role { get; set; }
                public byte[] Account { get; set; }
                public byte[] Sender { get; set; }

                public static RoleRevokedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RoleRevokedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRole = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vRole.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRole = vRole.ToValue();
                    if (valueRole is byte[] vRoleValue) { ret.Role = vRoleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is byte[] vAccountValue) { ret.Account = vAccountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is byte[] vSenderValue) { ret.Sender = vSenderValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_name"> </param>
        /// <param name="_symbol"> </param>
        /// <param name="_creator_address"> </param>
        /// <param name="_timelock_address"> </param>
        public async Task PostInit(string _name, string _symbol, Algorand.Address _creator_address, Algorand.Address _timelock_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 236, 106, 88 };
            var _nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); _nameAbi.From(_name);
            var _symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); _symbolAbi.From(_symbol);
            var _creator_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _creator_addressAbi.From(_creator_address);
            var _timelock_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _timelock_addressAbi.From(_timelock_address);

            var result = await base.CallApp(new List<object> { abiHandle, _nameAbi, _symbolAbi, _creator_addressAbi, _timelock_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(string _name, string _symbol, Algorand.Address _creator_address, Algorand.Address _timelock_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 236, 106, 88 };
            var _nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); _nameAbi.From(_name);
            var _symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); _symbolAbi.From(_symbol);
            var _creator_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _creator_addressAbi.From(_creator_address);
            var _timelock_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _timelock_addressAbi.From(_timelock_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, _nameAbi, _symbolAbi, _creator_addressAbi, _timelock_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> FraxPrice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 160, 66, 104 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> FraxPrice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 160, 66, 104 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> FxsPrice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 75, 43, 207 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> FxsPrice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 75, 43, 207 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> EthUsdPrice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 87, 173, 162 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> EthUsdPrice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 87, 173, 162 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.FraxInfoReturn> FraxInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 221, 49, 191 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.FraxInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> FraxInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 221, 49, 191 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GlobalCollateralValue(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 196, 147, 137 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GlobalCollateralValue_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 196, 147, 137 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RefreshCollateralRatio(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 139, 136, 140 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RefreshCollateralRatio_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 139, 136, 140 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="b_address"> </param>
        /// <param name="b_amount"> </param>
        public async Task PoolBurnFrom(Algorand.Address b_address, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 b_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 193, 15, 254 };
            var b_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); b_addressAbi.From(b_address);

            var result = await base.CallApp(new List<object> { abiHandle, b_addressAbi, b_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PoolBurnFrom_Transactions(Algorand.Address b_address, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 b_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 193, 15, 254 };
            var b_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); b_addressAbi.From(b_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, b_addressAbi, b_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="m_address"> </param>
        /// <param name="m_amount"> </param>
        public async Task PoolMint(Algorand.Address m_address, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 m_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 50, 126, 40 };
            var m_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); m_addressAbi.From(m_address);

            var result = await base.CallApp(new List<object> { abiHandle, m_addressAbi, m_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PoolMint_Transactions(Algorand.Address m_address, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 m_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 50, 126, 40 };
            var m_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); m_addressAbi.From(m_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, m_addressAbi, m_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pool_address"> </param>
        public async Task AddPool(Algorand.Address pool_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 198, 23, 245 };
            var pool_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pool_addressAbi.From(pool_address);

            var result = await base.CallApp(new List<object> { abiHandle, pool_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddPool_Transactions(Algorand.Address pool_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 198, 23, 245 };
            var pool_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pool_addressAbi.From(pool_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, pool_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pool_address"> </param>
        public async Task RemovePool(Algorand.Address pool_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 100, 204, 179 };
            var pool_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pool_addressAbi.From(pool_address);

            var result = await base.CallApp(new List<object> { abiHandle, pool_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemovePool_Transactions(Algorand.Address pool_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 100, 204, 179 };
            var pool_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pool_addressAbi.From(pool_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, pool_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="red_fee"> </param>
        public async Task SetRedemptionFee(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 red_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 57, 208, 217 };

            var result = await base.CallApp(new List<object> { abiHandle, red_fee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetRedemptionFee_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 red_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 57, 208, 217 };

            return await base.MakeTransactionList(new List<object> { abiHandle, red_fee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="min_fee"> </param>
        public async Task SetMintingFee(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 min_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 113, 246, 81 };

            var result = await base.CallApp(new List<object> { abiHandle, min_fee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetMintingFee_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 min_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 113, 246, 81 };

            return await base.MakeTransactionList(new List<object> { abiHandle, min_fee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_new_step"> </param>
        public async Task SetFraxStep(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _new_step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 204, 238, 179 };

            var result = await base.CallApp(new List<object> { abiHandle, _new_step }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFraxStep_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _new_step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 204, 238, 179 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _new_step }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_new_price_target"> </param>
        public async Task SetPriceTarget(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _new_price_target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 194, 211, 255 };

            var result = await base.CallApp(new List<object> { abiHandle, _new_price_target }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPriceTarget_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _new_price_target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 194, 211, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _new_price_target }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_new_cooldown"> </param>
        public async Task SetRefreshCooldown(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _new_cooldown, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 99, 25, 217 };

            var result = await base.CallApp(new List<object> { abiHandle, _new_cooldown }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetRefreshCooldown_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _new_cooldown, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 99, 25, 217 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _new_cooldown }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_fxs_address"> </param>
        public async Task SetFxsAddress(Algorand.Address _fxs_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 219, 157, 18 };
            var _fxs_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _fxs_addressAbi.From(_fxs_address);

            var result = await base.CallApp(new List<object> { abiHandle, _fxs_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFxsAddress_Transactions(Algorand.Address _fxs_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 219, 157, 18 };
            var _fxs_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _fxs_addressAbi.From(_fxs_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, _fxs_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_eth_usd_consumer_address"> </param>
        public async Task SetEthusdOracle(Algorand.Address _eth_usd_consumer_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 31, 141, 194 };
            var _eth_usd_consumer_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _eth_usd_consumer_addressAbi.From(_eth_usd_consumer_address);

            var result = await base.CallApp(new List<object> { abiHandle, _eth_usd_consumer_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetEthusdOracle_Transactions(Algorand.Address _eth_usd_consumer_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 31, 141, 194 };
            var _eth_usd_consumer_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _eth_usd_consumer_addressAbi.From(_eth_usd_consumer_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, _eth_usd_consumer_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_timelock"> </param>
        public async Task SetTimelock(Algorand.Address new_timelock, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 251, 176, 139 };
            var new_timelockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_timelockAbi.From(new_timelock);

            var result = await base.CallApp(new List<object> { abiHandle, new_timelockAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTimelock_Transactions(Algorand.Address new_timelock, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 251, 176, 139 };
            var new_timelockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_timelockAbi.From(new_timelock);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_timelockAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_controller_address"> </param>
        public async Task SetController(Algorand.Address _controller_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 105, 126, 200 };
            var _controller_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _controller_addressAbi.From(_controller_address);

            var result = await base.CallApp(new List<object> { abiHandle, _controller_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetController_Transactions(Algorand.Address _controller_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 105, 126, 200 };
            var _controller_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _controller_addressAbi.From(_controller_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, _controller_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_price_band"> </param>
        public async Task SetPriceBand(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _price_band, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 252, 245, 221 };

            var result = await base.CallApp(new List<object> { abiHandle, _price_band }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPriceBand_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _price_band, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 252, 245, 221 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _price_band }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_frax_oracle_addr"> </param>
        /// <param name="_weth_address"> </param>
        public async Task SetFraxEthOracle(Algorand.Address _frax_oracle_addr, Algorand.Address _weth_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 180, 122, 220 };
            var _frax_oracle_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _frax_oracle_addrAbi.From(_frax_oracle_addr);
            var _weth_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _weth_addressAbi.From(_weth_address);

            var result = await base.CallApp(new List<object> { abiHandle, _frax_oracle_addrAbi, _weth_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFraxEthOracle_Transactions(Algorand.Address _frax_oracle_addr, Algorand.Address _weth_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 180, 122, 220 };
            var _frax_oracle_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _frax_oracle_addrAbi.From(_frax_oracle_addr);
            var _weth_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _weth_addressAbi.From(_weth_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, _frax_oracle_addrAbi, _weth_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_fxs_oracle_addr"> </param>
        /// <param name="_weth_address"> </param>
        public async Task SetFxsEthOracle(Algorand.Address _fxs_oracle_addr, Algorand.Address _weth_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 212, 180, 238 };
            var _fxs_oracle_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _fxs_oracle_addrAbi.From(_fxs_oracle_addr);
            var _weth_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _weth_addressAbi.From(_weth_address);

            var result = await base.CallApp(new List<object> { abiHandle, _fxs_oracle_addrAbi, _weth_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFxsEthOracle_Transactions(Algorand.Address _fxs_oracle_addr, Algorand.Address _weth_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 212, 180, 238 };
            var _fxs_oracle_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _fxs_oracle_addrAbi.From(_fxs_oracle_addr);
            var _weth_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _weth_addressAbi.From(_weth_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, _fxs_oracle_addrAbi, _weth_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ToggleCollateralRatio(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 203, 247, 73 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ToggleCollateralRatio_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 203, 247, 73 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_owner"> </param>
        public async Task NominateNewOwner(Algorand.Address _owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 211, 161, 3 };
            var _ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _ownerAbi.From(_owner);

            var result = await base.CallApp(new List<object> { abiHandle, _ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NominateNewOwner_Transactions(Algorand.Address _owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 211, 161, 3 };
            var _ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _ownerAbi.From(_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, _ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task AcceptOwnership(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 33, 214, 4 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AcceptOwnership_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 33, 214, 4 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Returns `true` if `account` has been granted `role`.
        ///</summary>
        /// <param name="role"> </param>
        /// <param name="account"> </param>
        public async Task<bool> HasRole(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 169, 16, 40 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasRole_Transactions(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 169, 16, 40 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Returns the number of accounts that have `role`. Can be used
        /// together with {getRoleMember} to enumerate all bearers of a role.
        ///</summary>
        /// <param name="role"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetRoleMemberCount(byte[] role, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 28, 75, 160 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);

            var result = await base.SimApp(new List<object> { abiHandle, roleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetRoleMemberCount_Transactions(byte[] role, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 28, 75, 160 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Returns one of the accounts that have `role`. `index` must be a
        /// value between 0 and {getRoleMemberCount}, non-inclusive.
        /// Role bearers are not sorted in any particular way, and their ordering may
        /// change at any point.
        /// WARNING: When using {getRoleMember} and {getRoleMemberCount}, make sure
        /// you perform all queries on the same block. See the following
        /// https://forum.openzeppelin.com/t/iterating-over-elements-on-enumerableset-in-openzeppelin-contracts/2296[forum post]
        /// for more information.
        ///</summary>
        /// <param name="role"> </param>
        /// <param name="index"> </param>
        public async Task<Algorand.Address> GetRoleMember(byte[] role, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 93, 127, 89 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);

            var result = await base.SimApp(new List<object> { abiHandle, roleAbi, index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetRoleMember_Transactions(byte[] role, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 93, 127, 89 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Returns the admin role that controls `role`. See {grantRole} and
        /// {revokeRole}.
        /// To change a role's admin, use {_setRoleAdmin}.
        ///</summary>
        /// <param name="role"> </param>
        public async Task<byte[]> GetRoleAdmin(byte[] role, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 40, 156, 125 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);

            var result = await base.SimApp(new List<object> { abiHandle, roleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetRoleAdmin_Transactions(byte[] role, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 40, 156, 125 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Grants `role` to `account`.
        /// If `account` had not been already granted `role`, emits a {RoleGranted}
        /// event.
        /// Requirements:
        /// - the caller must have ``role``'s admin role.
        ///</summary>
        /// <param name="role"> </param>
        /// <param name="account"> </param>
        public async Task GrantRole(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 28, 79, 24 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantRole_Transactions(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 28, 79, 24 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Revokes `role` from `account`.
        /// If `account` had been granted `role`, emits a {RoleRevoked} event.
        /// Requirements:
        /// - the caller must have ``role``'s admin role.
        ///</summary>
        /// <param name="role"> </param>
        /// <param name="account"> </param>
        public async Task RevokeRole(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 13, 96, 177 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeRole_Transactions(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 13, 96, 177 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Revokes `role` from the calling account.
        /// Roles are often managed via {grantRole} and {revokeRole}: this function's
        /// purpose is to provide a mechanism for accounts to lose their privileges
        /// if they are compromised (such as when a trusted device is misplaced).
        /// If the calling account had been granted `role`, emits a {RoleRevoked}
        /// event.
        /// Requirements:
        /// - the caller must be `account`.
        ///</summary>
        /// <param name="role"> </param>
        /// <param name="account"> </param>
        public async Task RenounceRole(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 73, 130, 237 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenounceRole_Transactions(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 73, 130, 237 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev See {IERC20-totalSupply}.
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> TotalSupply(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 250, 180, 101 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TotalSupply_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 250, 180, 101 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev See {IERC20-balanceOf}.
        ///</summary>
        /// <param name="account"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BalanceOf(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 186, 215, 204 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BalanceOf_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 186, 215, 204 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev See {IERC20-transfer}.
        /// Requirements:
        /// - `recipient` cannot be the zero address.
        /// - the caller must have a balance of at least `amount`.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        public async Task<bool> Transfer(Algorand.Address recipient, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 140, 152, 32 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Transfer_Transactions(Algorand.Address recipient, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 140, 152, 32 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev See {IERC20-allowance}.
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="spender"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Allowance(Algorand.Address owner, Algorand.Address spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 133, 77, 14 };
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

        public async Task<List<Transaction>> Allowance_Transactions(Algorand.Address owner, Algorand.Address spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 133, 77, 14 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev See {IERC20-approve}.
        /// Requirements:
        /// - `spender` cannot be the zero address.approve(address spender, uint256 amount)
        ///</summary>
        /// <param name="spender"> </param>
        /// <param name="amount"> </param>
        public async Task<bool> Approve(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 251, 106, 8 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Approve_Transactions(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 251, 106, 8 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev See {IERC20-transferFrom}.
        /// Emits an {Approval} event indicating the updated allowance. This is not
        /// required by the EIP. See the note at the beginning of {ERC20};
        /// Requirements:
        /// - `sender` and `recipient` cannot be the zero address.
        /// - `sender` must have a balance of at least `amount`.
        /// - the caller must have allowance for `sender`'s tokens of at least
        /// `amount`.
        ///</summary>
        /// <param name="sender"> </param>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        public async Task<bool> TransferFrom(Algorand.Address sender, Algorand.Address recipient, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 244, 31, 109 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, senderAbi, recipientAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TransferFrom_Transactions(Algorand.Address sender, Algorand.Address recipient, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 244, 31, 109 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, senderAbi, recipientAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Atomically increases the allowance granted to `spender` by the caller.
        /// This is an alternative to {approve} that can be used as a mitigation for
        /// problems described in {IERC20-approve}.
        /// Emits an {Approval} event indicating the updated allowance.
        /// Requirements:
        /// - `spender` cannot be the zero address.
        ///</summary>
        /// <param name="spender"> </param>
        /// <param name="addedValue"> </param>
        public async Task<bool> IncreaseAllowance(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 addedValue, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 156, 201, 121 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, addedValue }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IncreaseAllowance_Transactions(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 addedValue, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 156, 201, 121 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, addedValue }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Atomically decreases the allowance granted to `spender` by the caller.
        /// This is an alternative to {approve} that can be used as a mitigation for
        /// problems described in {IERC20-approve}.
        /// Emits an {Approval} event indicating the updated allowance.
        /// Requirements:
        /// - `spender` cannot be the zero address.
        /// - `spender` must have allowance for the caller of at least
        /// `subtractedValue`.
        ///</summary>
        /// <param name="spender"> </param>
        /// <param name="subtractedValue"> </param>
        public async Task<bool> DecreaseAllowance(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 subtractedValue, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 182, 219, 76 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, subtractedValue }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DecreaseAllowance_Transactions(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 subtractedValue, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 182, 219, 76 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, subtractedValue }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Destroys `amount` tokens from the caller.
        /// See {ERC20-_burn}.
        ///</summary>
        /// <param name="amount"> </param>
        public async Task Burn(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 80, 85, 39 };

            var result = await base.CallApp(new List<object> { abiHandle, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Burn_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 80, 85, 39 };

            return await base.MakeTransactionList(new List<object> { abiHandle, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Destroys `amount` tokens from `account`, deducting from the caller's
        /// allowance.
        /// See {ERC20-_burn} and {ERC20-allowance}.
        /// Requirements:
        /// - the caller must have allowance for `accounts`'s tokens of at least
        /// `amount`.
        ///</summary>
        /// <param name="account"> </param>
        /// <param name="amount"> </param>
        public async Task BurnFrom(Algorand.Address account, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 67, 117, 84 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BurnFrom_Transactions(Algorand.Address account, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 67, 117, 84 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> Symbol(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 91, 82, 184 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Symbol_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 91, 82, 184 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> Name(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 117, 6, 22 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Name_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 117, 6, 22 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> CreatorAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 74, 254, 94 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> CreatorAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 74, 254, 94 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> TimelockAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 60, 64, 13 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> TimelockAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 60, 64, 13 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> ControllerAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 46, 83, 46 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> ControllerAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 46, 83, 46 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> FxsAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 17, 57, 234 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> FxsAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 17, 57, 234 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> FraxEthOracleAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 159, 77, 147 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> FraxEthOracleAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 159, 77, 147 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> FxsEthOracleAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 197, 240, 47 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> FxsEthOracleAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 197, 240, 47 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> WethAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 122, 240, 218 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> WethAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 122, 240, 218 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> EthUsdConsumerAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 56, 102, 48 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> EthUsdConsumerAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 56, 102, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[][]> FraxPoolsArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 189, 210, 233 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> FraxPoolsArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 189, 210, 233 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GlobalCollateralRatio(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 203, 4, 167 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GlobalCollateralRatio_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 203, 4, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> RedemptionFee(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 5, 136, 217 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> RedemptionFee_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 5, 136, 217 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MintingFee(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 160, 211, 165 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> MintingFee_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 160, 211, 165 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> FraxStep(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 208, 83, 175 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> FraxStep_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 208, 83, 175 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> RefreshCooldown(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 52, 77, 149 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> RefreshCooldown_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 52, 77, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> PriceTarget(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 176, 7, 97 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> PriceTarget_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 176, 7, 97 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> PriceBand(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 211, 221, 217 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> PriceBand_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 211, 221, 217 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> DefaultAdminAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 252, 244, 66 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> DefaultAdminAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 252, 244, 66 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> CollateralRatioPaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 168, 170, 242 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CollateralRatioPaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 168, 170, 242 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> LastCallTime(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 195, 24, 213 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> LastCallTime_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 195, 24, 213 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///
        ///</summary>
        public async Task<Algorand.Address> NominatedOwner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 47, 53, 92 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> NominatedOwner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 47, 53, 92 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 3;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRlJBWFN0YWJsZWNvaW4iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWRkcmVzc1NldCI6W3sibmFtZSI6Il9pbm5lciIsInR5cGUiOiJTZXQifV0sIlJvbGVEYXRhIjpbeyJuYW1lIjoibWVtYmVycyIsInR5cGUiOiJBZGRyZXNzU2V0In0seyJuYW1lIjoiYWRtaW5Sb2xlIiwidHlwZSI6InVpbnQ4WzMyXSJ9XSwiU2V0IjpbeyJuYW1lIjoiX3ZhbHVlcyIsInR5cGUiOiJ1aW50OFszMl1bXSJ9LHsibmFtZSI6Il9pbmRleGVzIiwidHlwZSI6ImJ5dGVbXSJ9XSwiRnJheEluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJ1aW50MjU2In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fcG9zdEluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9zeW1ib2wiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfY3JlYXRvcl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX3RpbWVsb2NrX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlR3JhbnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnJheF9wcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZ4c19wcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV0aF91c2RfcHJpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmcmF4X2luZm8iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJGcmF4SW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2xvYmFsQ29sbGF0ZXJhbFZhbHVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVmcmVzaENvbGxhdGVyYWxSYXRpbyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29sbGF0ZXJhbFJhdGlvUmVmcmVzaGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnbG9iYWxfY29sbGF0ZXJhbF9yYXRpbyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBvb2xfYnVybl9mcm9tIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJBcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkZSQVhCdXJuZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBvb2xfbWludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibV9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibV9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRlJBWE1pbnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkUG9vbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQb29sQWRkZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbF9hZGRyZXNzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlUG9vbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQb29sUmVtb3ZlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sX2FkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRSZWRlbXB0aW9uRmVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRfZmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSZWRlbXB0aW9uRmVlU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRfZmVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0TWludGluZ0ZlZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluX2ZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTWludGluZ0ZlZVNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluX2ZlZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEZyYXhTdGVwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfbmV3X3N0ZXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkZyYXhTdGVwU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfc3RlcCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFByaWNlVGFyZ2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfbmV3X3ByaWNlX3RhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUHJpY2VUYXJnZXRTZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19wcmljZV90YXJnZXQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRSZWZyZXNoQ29vbGRvd24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9uZXdfY29vbGRvd24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlZnJlc2hDb29sZG93blNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2Nvb2xkb3duIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0RlhTQWRkcmVzcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2Z4c19hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJGWFNBZGRyZXNzU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9meHNfYWRkcmVzcyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEVUSFVTRE9yYWNsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2V0aF91c2RfY29uc3VtZXJfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRVRIVVNET3JhY2xlU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV0aF91c2RfY29uc3VtZXJfYWRkcmVzcyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFRpbWVsb2NrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfdGltZWxvY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRpbWVsb2NrU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld190aW1lbG9jayIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldENvbnRyb2xsZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9jb250cm9sbGVyX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbnRyb2xsZXJTZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udHJvbGxlcl9hZGRyZXNzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UHJpY2VCYW5kIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfcHJpY2VfYmFuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUHJpY2VCYW5kU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZV9iYW5kIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0RlJBWEV0aE9yYWNsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2ZyYXhfb3JhY2xlX2FkZHIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfd2V0aF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJGUkFYRVRIT3JhY2xlU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyYXhfb3JhY2xlX2FkZHIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3ZXRoX2FkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRGWFNFdGhPcmFjbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9meHNfb3JhY2xlX2FkZHIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfd2V0aF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJGWFNFdGhPcmFjbGVTZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnhzX29yYWNsZV9hZGRyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2V0aF9hZGRyZXNzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9nZ2xlQ29sbGF0ZXJhbFJhdGlvIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJDb2xsYXRlcmFsUmF0aW9Ub2dnbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb2xsYXRlcmFsX3JhdGlvX3BhdXNlZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5vbWluYXRlTmV3T3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9vd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJOb21pbmF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NlcHRPd25lcnNoaXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGFzUm9sZSIsImRlc2MiOiIgQGRldiBSZXR1cm5zIGB0cnVlYCBpZiBgYWNjb3VudGAgaGFzIGJlZW4gZ3JhbnRlZCBgcm9sZWAuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlTWVtYmVyQ291bnQiLCJkZXNjIjoiIEBkZXYgUmV0dXJucyB0aGUgbnVtYmVyIG9mIGFjY291bnRzIHRoYXQgaGF2ZSBgcm9sZWAuIENhbiBiZSB1c2VkXG4gdG9nZXRoZXIgd2l0aCB7Z2V0Um9sZU1lbWJlcn0gdG8gZW51bWVyYXRlIGFsbCBiZWFyZXJzIG9mIGEgcm9sZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZU1lbWJlciIsImRlc2MiOiIgQGRldiBSZXR1cm5zIG9uZSBvZiB0aGUgYWNjb3VudHMgdGhhdCBoYXZlIGByb2xlYC4gYGluZGV4YCBtdXN0IGJlIGFcbiB2YWx1ZSBiZXR3ZWVuIDAgYW5kIHtnZXRSb2xlTWVtYmVyQ291bnR9LCBub24taW5jbHVzaXZlLlxuIFJvbGUgYmVhcmVycyBhcmUgbm90IHNvcnRlZCBpbiBhbnkgcGFydGljdWxhciB3YXksIGFuZCB0aGVpciBvcmRlcmluZyBtYXlcbiBjaGFuZ2UgYXQgYW55IHBvaW50LlxuIFdBUk5JTkc6IFdoZW4gdXNpbmcge2dldFJvbGVNZW1iZXJ9IGFuZCB7Z2V0Um9sZU1lbWJlckNvdW50fSwgbWFrZSBzdXJlXG4geW91IHBlcmZvcm0gYWxsIHF1ZXJpZXMgb24gdGhlIHNhbWUgYmxvY2suIFNlZSB0aGUgZm9sbG93aW5nXG4gaHR0cHM6Ly9mb3J1bS5vcGVuemVwcGVsaW4uY29tL3QvaXRlcmF0aW5nLW92ZXItZWxlbWVudHMtb24tZW51bWVyYWJsZXNldC1pbi1vcGVuemVwcGVsaW4tY29udHJhY3RzLzIyOTZbZm9ydW0gcG9zdF1cbiBmb3IgbW9yZSBpbmZvcm1hdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlQWRtaW4iLCJkZXNjIjoiIEBkZXYgUmV0dXJucyB0aGUgYWRtaW4gcm9sZSB0aGF0IGNvbnRyb2xzIGByb2xlYC4gU2VlIHtncmFudFJvbGV9IGFuZFxuIHtyZXZva2VSb2xlfS5cbiBUbyBjaGFuZ2UgYSByb2xlJ3MgYWRtaW4sIHVzZSB7X3NldFJvbGVBZG1pbn0uIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJncmFudFJvbGUiLCJkZXNjIjoiIEBkZXYgR3JhbnRzIGByb2xlYCB0byBgYWNjb3VudGAuXG4gSWYgYGFjY291bnRgIGhhZCBub3QgYmVlbiBhbHJlYWR5IGdyYW50ZWQgYHJvbGVgLCBlbWl0cyBhIHtSb2xlR3JhbnRlZH1cbiBldmVudC5cbiBSZXF1aXJlbWVudHM6XG4gLSB0aGUgY2FsbGVyIG11c3QgaGF2ZSBgYHJvbGVgYCdzIGFkbWluIHJvbGUuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJvbGVHcmFudGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV2b2tlUm9sZSIsImRlc2MiOiIgQGRldiBSZXZva2VzIGByb2xlYCBmcm9tIGBhY2NvdW50YC5cbiBJZiBgYWNjb3VudGAgaGFkIGJlZW4gZ3JhbnRlZCBgcm9sZWAsIGVtaXRzIGEge1JvbGVSZXZva2VkfSBldmVudC5cbiBSZXF1aXJlbWVudHM6XG4gLSB0aGUgY2FsbGVyIG11c3QgaGF2ZSBgYHJvbGVgYCdzIGFkbWluIHJvbGUuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJvbGVSZXZva2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVub3VuY2VSb2xlIiwiZGVzYyI6IiBAZGV2IFJldm9rZXMgYHJvbGVgIGZyb20gdGhlIGNhbGxpbmcgYWNjb3VudC5cbiBSb2xlcyBhcmUgb2Z0ZW4gbWFuYWdlZCB2aWEge2dyYW50Um9sZX0gYW5kIHtyZXZva2VSb2xlfTogdGhpcyBmdW5jdGlvbidzXG4gcHVycG9zZSBpcyB0byBwcm92aWRlIGEgbWVjaGFuaXNtIGZvciBhY2NvdW50cyB0byBsb3NlIHRoZWlyIHByaXZpbGVnZXNcbiBpZiB0aGV5IGFyZSBjb21wcm9taXNlZCAoc3VjaCBhcyB3aGVuIGEgdHJ1c3RlZCBkZXZpY2UgaXMgbWlzcGxhY2VkKS5cbiBJZiB0aGUgY2FsbGluZyBhY2NvdW50IGhhZCBiZWVuIGdyYW50ZWQgYHJvbGVgLCBlbWl0cyBhIHtSb2xlUmV2b2tlZH1cbiBldmVudC5cbiBSZXF1aXJlbWVudHM6XG4gLSB0aGUgY2FsbGVyIG11c3QgYmUgYGFjY291bnRgLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSb2xlUmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvdGFsU3VwcGx5IiwiZGVzYyI6IiBAZGV2IFNlZSB7SUVSQzIwLXRvdGFsU3VwcGx5fS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJiYWxhbmNlT2YiLCJkZXNjIjoiIEBkZXYgU2VlIHtJRVJDMjAtYmFsYW5jZU9mfS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlciIsImRlc2MiOiIgQGRldiBTZWUge0lFUkMyMC10cmFuc2Zlcn0uXG4gUmVxdWlyZW1lbnRzOlxuIC0gYHJlY2lwaWVudGAgY2Fubm90IGJlIHRoZSB6ZXJvIGFkZHJlc3MuXG4gLSB0aGUgY2FsbGVyIG11c3QgaGF2ZSBhIGJhbGFuY2Ugb2YgYXQgbGVhc3QgYGFtb3VudGAuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFsbG93YW5jZSIsImRlc2MiOiIgQGRldiBTZWUge0lFUkMyMC1hbGxvd2FuY2V9LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwcm92ZSIsImRlc2MiOiIgQGRldiBTZWUge0lFUkMyMC1hcHByb3ZlfS5cbiBSZXF1aXJlbWVudHM6XG4gLSBgc3BlbmRlcmAgY2Fubm90IGJlIHRoZSB6ZXJvIGFkZHJlc3MuYXBwcm92ZShhZGRyZXNzIHNwZW5kZXIsIHVpbnQyNTYgYW1vdW50KSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXJGcm9tIiwiZGVzYyI6IiBAZGV2IFNlZSB7SUVSQzIwLXRyYW5zZmVyRnJvbX0uXG4gRW1pdHMgYW4ge0FwcHJvdmFsfSBldmVudCBpbmRpY2F0aW5nIHRoZSB1cGRhdGVkIGFsbG93YW5jZS4gVGhpcyBpcyBub3RcbiByZXF1aXJlZCBieSB0aGUgRUlQLiBTZWUgdGhlIG5vdGUgYXQgdGhlIGJlZ2lubmluZyBvZiB7RVJDMjB9O1xuIFJlcXVpcmVtZW50czpcbiAtIGBzZW5kZXJgIGFuZCBgcmVjaXBpZW50YCBjYW5ub3QgYmUgdGhlIHplcm8gYWRkcmVzcy5cbiAtIGBzZW5kZXJgIG11c3QgaGF2ZSBhIGJhbGFuY2Ugb2YgYXQgbGVhc3QgYGFtb3VudGAuXG4gLSB0aGUgY2FsbGVyIG11c3QgaGF2ZSBhbGxvd2FuY2UgZm9yIGBzZW5kZXJgJ3MgdG9rZW5zIG9mIGF0IGxlYXN0XG4gYGFtb3VudGAuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5jcmVhc2VBbGxvd2FuY2UiLCJkZXNjIjoiIEBkZXYgQXRvbWljYWxseSBpbmNyZWFzZXMgdGhlIGFsbG93YW5jZSBncmFudGVkIHRvIGBzcGVuZGVyYCBieSB0aGUgY2FsbGVyLlxuIFRoaXMgaXMgYW4gYWx0ZXJuYXRpdmUgdG8ge2FwcHJvdmV9IHRoYXQgY2FuIGJlIHVzZWQgYXMgYSBtaXRpZ2F0aW9uIGZvclxuIHByb2JsZW1zIGRlc2NyaWJlZCBpbiB7SUVSQzIwLWFwcHJvdmV9LlxuIEVtaXRzIGFuIHtBcHByb3ZhbH0gZXZlbnQgaW5kaWNhdGluZyB0aGUgdXBkYXRlZCBhbGxvd2FuY2UuXG4gUmVxdWlyZW1lbnRzOlxuIC0gYHNwZW5kZXJgIGNhbm5vdCBiZSB0aGUgemVybyBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZGVkVmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlY3JlYXNlQWxsb3dhbmNlIiwiZGVzYyI6IiBAZGV2IEF0b21pY2FsbHkgZGVjcmVhc2VzIHRoZSBhbGxvd2FuY2UgZ3JhbnRlZCB0byBgc3BlbmRlcmAgYnkgdGhlIGNhbGxlci5cbiBUaGlzIGlzIGFuIGFsdGVybmF0aXZlIHRvIHthcHByb3ZlfSB0aGF0IGNhbiBiZSB1c2VkIGFzIGEgbWl0aWdhdGlvbiBmb3JcbiBwcm9ibGVtcyBkZXNjcmliZWQgaW4ge0lFUkMyMC1hcHByb3ZlfS5cbiBFbWl0cyBhbiB7QXBwcm92YWx9IGV2ZW50IGluZGljYXRpbmcgdGhlIHVwZGF0ZWQgYWxsb3dhbmNlLlxuIFJlcXVpcmVtZW50czpcbiAtIGBzcGVuZGVyYCBjYW5ub3QgYmUgdGhlIHplcm8gYWRkcmVzcy5cbiAtIGBzcGVuZGVyYCBtdXN0IGhhdmUgYWxsb3dhbmNlIGZvciB0aGUgY2FsbGVyIG9mIGF0IGxlYXN0XG4gYHN1YnRyYWN0ZWRWYWx1ZWAuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3VidHJhY3RlZFZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXJuIiwiZGVzYyI6IiBAZGV2IERlc3Ryb3lzIGBhbW91bnRgIHRva2VucyBmcm9tIHRoZSBjYWxsZXIuXG4gU2VlIHtFUkMyMC1fYnVybn0uIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1cm5Gcm9tIiwiZGVzYyI6IiBAZGV2IERlc3Ryb3lzIGBhbW91bnRgIHRva2VucyBmcm9tIGBhY2NvdW50YCwgZGVkdWN0aW5nIGZyb20gdGhlIGNhbGxlcidzXG4gYWxsb3dhbmNlLlxuIFNlZSB7RVJDMjAtX2J1cm59IGFuZCB7RVJDMjAtYWxsb3dhbmNlfS5cbiBSZXF1aXJlbWVudHM6XG4gLSB0aGUgY2FsbGVyIG11c3QgaGF2ZSBhbGxvd2FuY2UgZm9yIGBhY2NvdW50c2AncyB0b2tlbnMgb2YgYXQgbGVhc3RcbiBgYW1vdW50YC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3ltYm9sIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdG9yX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0aW1lbG9ja19hZGRyZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29udHJvbGxlcl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnhzX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmcmF4X2V0aF9vcmFjbGVfYWRkcmVzcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZ4c19ldGhfb3JhY2xlX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3ZXRoX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJldGhfdXNkX2NvbnN1bWVyX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmcmF4X3Bvb2xzX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2xvYmFsX2NvbGxhdGVyYWxfcmF0aW8iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlbXB0aW9uX2ZlZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnRpbmdfZmVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnJheF9zdGVwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVmcmVzaF9jb29sZG93biIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByaWNlX3RhcmdldCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByaWNlX2JhbmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJERUZBVUxUX0FETUlOX0FERFJFU1MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb2xsYXRlcmFsX3JhdGlvX3BhdXNlZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imxhc3RfY2FsbF90aW1lIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub21pbmF0ZWRPd25lciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MjV9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ2MzldLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NDb250cm9sOiBjYW4gb25seSByZW5vdW5jZSByb2xlcyBmb3Igc2VsZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4NjddLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NDb250cm9sOiBzZW5kZXIgbXVzdCBiZSBhbiBhZG1pbiB0byBncmFudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2MTNdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NDb250cm9sOiBzZW5kZXIgbXVzdCBiZSBhbiBhZG1pbiB0byByZXZva2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTE3XSwiZXJyb3JNZXNzYWdlIjoiQWRkcmVzcyBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMTJdLCJlcnJvck1lc3NhZ2UiOiJBZGRyZXNzIG5vbmV4aXN0ZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY1Nl0sImVycm9yTWVzc2FnZSI6IkNvbGxhdGVyYWwgUmF0aW8gaGFzIGJlZW4gcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI4M10sImVycm9yTWVzc2FnZSI6IkVSQzIwOiBhcHByb3ZlIGZyb20gdGhlIHplcm8gYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyODhdLCJlcnJvck1lc3NhZ2UiOiJFUkMyMDogYXBwcm92ZSB0byB0aGUgemVybyBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE3OV0sImVycm9yTWVzc2FnZSI6IkVSQzIwOiBidXJuIGZyb20gdGhlIHplcm8gYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMzEsMjk4MF0sImVycm9yTWVzc2FnZSI6IkVSQzIwOiBtaW50IHRvIHRoZSB6ZXJvIGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDU2XSwiZXJyb3JNZXNzYWdlIjoiRVJDMjA6IHRyYW5zZmVyIGZyb20gdGhlIHplcm8gYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwNjFdLCJlcnJvck1lc3NhZ2UiOiJFUkMyMDogdHJhbnNmZXIgdG8gdGhlIHplcm8gYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2ODRdLCJlcnJvck1lc3NhZ2UiOiJFbnVtZXJhYmxlU2V0OiBpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYxOV0sImVycm9yTWVzc2FnZSI6IklOVkFMSUQgUFJJQ0UgQ0hPSUNFLiBOZWVkcyB0byBiZSBlaXRoZXIgMCAoRlJBWCkgb3IgMSAoRlhTKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2ODNdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHdhaXQgZm9yIHRoZSByZWZyZXNoIGNvb2xkb3duIHNpbmNlIGxhc3QgcmVmcmVzaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwOTUsMzE5MCwzMzc4LDM0NTIsMzUyNiwzNjAwLDM2NzQsMzc0NywzODE0LDM5MjIsMzk4OSw0MDU3LDQxMzgsNDI0NF0sImVycm9yTWVzc2FnZSI6Ik5vdCB0aGUgb3duZXIsIGNvbnRyb2xsZXIsIG9yIHRoZSBnb3Zlcm5hbmNlIHRpbWVsb2NrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg3NywyOTc1XSwiZXJyb3JNZXNzYWdlIjoiT25seSBmcmF4IHBvb2xzIGNhbiBjYWxsIHRoaXMgZnVuY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzUyXSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgY29udHJhY3Qgb3duZXIgbWF5IHBlcmZvcm0gdGhpcyBhY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDQyXSwiZXJyb3JNZXNzYWdlIjoiT3duZXIgYWRkcmVzcyBjYW5ub3QgYmUgMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MzZdLCJlcnJvck1lc3NhZ2UiOiJTYWZlTWF0aDogYWRkaXRpb24gb3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTI3XSwiZXJyb3JNZXNzYWdlIjoiU2FmZU1hdGg6IG11bHRpcGxpY2F0aW9uIG92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM4MF0sImVycm9yTWVzc2FnZSI6IllvdSBtdXN0IGJlIG5vbWluYXRlZCBiZWZvcmUgeW91IGNhbiBhY2NlcHQgb3duZXJzaGlwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA5MiwzMTAwLDMxOTUsMzc1MiwzODE5LDM5MjcsMzk5NCw0MTUzLDQyNTldLCJlcnJvck1lc3NhZ2UiOiJaZXJvIGFkZHJlc3MgZGV0ZWN0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDMzXSwiZXJyb3JNZXNzYWdlIjoiX19wb3N0SW5pdCBhbHJlYWR5IGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4ODksMTk3NV0sImVycm9yTWVzc2FnZSI6ImFzc2VydGlvbiBmYWlsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTI0LDMyODRdLCJlcnJvck1lc3NhZ2UiOiJib3ggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM4N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIERFRkFVTFRfQURNSU5fQUREUkVTUyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTM2LDI0OTcsMjk4NSw0NjQ5LDYyNDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfdG90YWxTdXBwbHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY1NCw0MzEzLDUzOThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBjb2xsYXRlcmFsX3JhdGlvX3BhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDg5LDMxODQsMzM3MiwzNDQ2LDM1MjAsMzU5NCwzNjY4LDM3NDEsMzgwOCwzOTE2LDM5ODMsNDA1MSw0MTMyLDQyMzgsNTE0OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGNvbnRyb2xsZXJfYWRkcmVzcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTI3LDIyMTUsNTEyN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIGNyZWF0b3JfYWRkcmVzcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjA0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgZXRoX3VzZF9jb25zdW1lcl9hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMTIsMjQxNiw1NDYxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgZXRoX3VzZF9wcmljZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM0MiwyNDQ2LDU0OTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBldGhfdXNkX3ByaWNlcl9kZWNpbWFscyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTY5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgZnJheEV0aE9yYWNsZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTcxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgZnJheF9ldGhfb3JhY2xlX2FkZHJlc3MgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIyMyw1Njc2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgZnJheF9wb29sc19hcnJheV9sZW5ndGggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcxMCwyNzYxLDI4MDAsMjgzMiw1MzExXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgZnJheF9zdGVwIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2MzBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBmeHNFdGhPcmFjbGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE2MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGZ4c19hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxODJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBmeHNfZXRoX29yYWNsZV9hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MDIsMjcwNSwyNzMyLDI3NTYsMjc5NSwyODI3LDUyNTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBnbG9iYWxfY29sbGF0ZXJhbF9yYXRpbyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjcyLDU0MTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBsYXN0X2NhbGxfdGltZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTEwLDUyOTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBtaW50aW5nX2ZlZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTA4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbmFtZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0Mzc1LDU0NDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBub21pbmF0ZWRPd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDY3LDMxNjIsMzM1MCwzNDI0LDM0OTgsMzU3MiwzNjQ2LDM3MTksMzc4NiwzODk0LDM5NjEsNDAyOSw0MTEwLDQyMTYsNDM1MCw0Mzg0LDU0MzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBvd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjkzLDI3ODEsNTM2OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHByaWNlX2JhbmQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY4OCwyNzc2LDUzNDldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBwcmljZV90YXJnZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUxNSw1MjczXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcmVkZW1wdGlvbl9mZWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY4MSw1MzMwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcmVmcmVzaF9jb29sZG93biBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDg5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc3ltYm9sIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMjYsMzA3OCwzMTczLDMzNjEsMzQzNSwzNTA5LDM1ODMsMzY1NywzNzMwLDM3OTcsMzkwNSwzOTcyLDQwNDAsNDEyMSw0MjI3LDUxMzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB0aW1lbG9ja19hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxOTMsNTU2NCw1NjI1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgd2V0aF9hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NDksMTU2NywxNzAwLDMyNzQsMzI5MSw1NzI3LDU3NjBdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5ODcsMjAwM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OTQsMjAxMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDIxLDIwMjksMjg1MCwyOTQ4LDMwNjEsMzE1NiwzNzEzLDM3ODAsMzg4OCwzOTU1LDQwOTYsNDEwNCw0MjAyLDQyMTAsNDM0NCw0NDEzLDQ0MjEsNDQ0NCw0NDg4LDQ1MzQsNDU2Miw0NTcwLDQ1ODMsNDU5MSw0NjI2LDQ2MzQsNDY3MSw0NzAzLDQ3MzEsNDczOSw0NzY0LDQ3OTIsNDgwMCw0ODk3LDQ5NDUsNTA0OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODU5LDI5NTcsMzM0NCwzNDE4LDM0OTIsMzU2NiwzNjQwLDQwMjMsNDQ5Niw0NzExLDQ3NzIsNDgwOCw0OTA1LDQ5NTMsNTAzMiw1MDU2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NDAsMzEzMF0sImVycm9yTWVzc2FnZSI6Im1heCBhcnJheSBsZW5ndGggZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzQwXSwiZXJyb3JNZXNzYWdlIjoibm8gYXZhaWxhYmxlIHNsb3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI3OSwyMjk3LDI0MDEsMjUzNywyNTUwLDI1NjIsMjU3NCwyNTg2LDI1OTgsMjYxMCwyNjIyLDI2NDAsMjczNywyOTE4LDMwMjAsMzM5MSwzNDY1LDM1MzksMzYxMywzNjg3LDQwNzAsNDQ3MSw0NjU0LDQ2ODYsNDc0Nyw1MjU5LDUyNzgsNTI5Nyw1MzE2LDUzMzUsNTM1NCw1MzczLDU0MjAsNjE1Myw2MjU4LDYzMTFdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREFnTXpJZ01TQXlJREV3TURBd01EQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ2dNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SURCNE1UVXhaamRqTnpVZ0ltOTNibVZ5SWlBaWRHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lJZ0ltTnZiblJ5YjJ4c1pYSmZZV1JrY21WemN5SWdJbWRzYjJKaGJGOWpiMnhzWVhSbGNtRnNYM0poZEdsdklpQXdlREF4SURCNE1EQXlNakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeU1EQXdOREF3TURZd01EQXdNREF3TUNBaVgzUnZkR0ZzVTNWd2NHeDVJaUFpWm5KaGVGOXpkR1Z3SWlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQ0FpWm5KaGVGOXdiMjlzYzE5aGNuSmhlU0lnSWw5eWIyeGxjeUlnSW5kbGRHaGZZV1JrY21WemN5SWdJbkJ5YVdObFgzUmhjbWRsZENJZ0luQnlhV05sWDJKaGJtUWlJQ0pmWW1Gc1lXNWpaWE1pSUNKZllXeHNiM2RoYm1ObGN5SWdJbTV2YldsdVlYUmxaRTkzYm1WeUlpQWlaWFJvWDNWelpGOXdjbWxqWlhJaUlDSmxkR2hmZFhOa1gzQnlhV05sY2w5a1pXTnBiV0ZzY3lJZ0ltTnlaV0YwYjNKZllXUmtjbVZ6Y3lJZ0luSmxabkpsYzJoZlkyOXZiR1J2ZDI0aUlDSmpiMnhzWVhSbGNtRnNYM0poZEdsdlgzQmhkWE5sWkNJZ01IZ3hOVEZtTjJNM05UZ3dJQ0p5WldSbGJYQjBhVzl1WDJabFpTSWdJbTFwYm5ScGJtZGZabVZsSWlBaWJHRnpkRjlqWVd4c1gzUnBiV1VpSUNKZmFXNWtaWGhsY3lJZ01IZ3lPRGt4T0RnMk1TQWlabkpoZUY5d2IyOXNjeUlnSW1aeVlYaEZkR2hQY21GamJHVWlJQ0ptZUhORmRHaFBjbUZqYkdVaUlDSnplVzFpYjJ3aUlDSnVZVzFsSWlBaVpuaHpYMkZrWkhKbGMzTWlJQ0ptY21GNFgyVjBhRjl2Y21GamJHVmZZV1JrY21WemN5SWdJbVo0YzE5bGRHaGZiM0poWTJ4bFgyRmtaSEpsYzNNaUlDSmxkR2hmZFhOa1gyTnZibk4xYldWeVgyRmtaSEpsYzNNaUlDSkVSVVpCVlV4VVgwRkVUVWxPWDBGRVJGSkZVMU1pSUNKbWNtRjRYM0J2YjJ4elgyRnljbUY1WDJ4bGJtZDBhQ0lnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JaUF3ZUdJeU5UUXdNalF4T0dGa05UVTFNREV6TWpFd016WTFZVFF5TW1ZNVpqRXlNRFppTW1Sa01EQTNNVGs1T1Roa1lqQTJaamhoTVdaaVpUQXhORFkwTVdJZ01IaGhOREptWXpSa09TQXdlREF5SURCNE1EQWdNSGd3TVdFM09EUXpOemxrT1Rsa1lqUXlNREF3TURBd0lDSkZVa015TURvZ1luVnliaUJoYlc5MWJuUWdaWGhqWldWa2N5QmhiR3h2ZDJGdVkyVWlJREI0TW1Rek1XWmpZalVnTUhnd01ESXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCaWVYUmxZeUE1SUM4dklDSmZkRzkwWVd4VGRYQndiSGtpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk15QXZMeUFpYjNkdVpYSWlDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREU1SUM4dklDSnViMjFwYm1GMFpXUlBkMjVsY2lJS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01qQWdMeThnSW1WMGFGOTFjMlJmY0hKcFkyVnlJZ29nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF5TVNBdkx5QWlaWFJvWDNWelpGOXdjbWxqWlhKZlpHVmphVzFoYkhNaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklETXlJQzh2SUNKbWNtRjRSWFJvVDNKaFkyeGxJZ29nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF6TXlBdkx5QWlabmh6UlhSb1QzSmhZMnhsSWdvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBek5DQXZMeUFpYzNsdFltOXNJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURNMUlDOHZJQ0p1WVcxbElnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREl5SUM4dklDSmpjbVZoZEc5eVgyRmtaSEpsYzNNaUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5ScGJXVnNiMk5yWDJGa1pISmxjM01pQ2lBZ0lDQmllWFJsWTE4eElDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU52Ym5SeWIyeHNaWEpmWVdSa2NtVnpjeUlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTXpZZ0x5OGdJbVo0YzE5aFpHUnlaWE56SWdvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBek55QXZMeUFpWm5KaGVGOWxkR2hmYjNKaFkyeGxYMkZrWkhKbGMzTWlDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRE00SUM4dklDSm1lSE5mWlhSb1gyOXlZV05zWlY5aFpHUnlaWE56SWdvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpZDJWMGFGOWhaR1J5WlhOeklnb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXpPU0F2THlBaVpYUm9YM1Z6WkY5amIyNXpkVzFsY2w5aFpHUnlaWE56SWdvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0puYkc5aVlXeGZZMjlzYkdGMFpYSmhiRjl5WVhScGJ5SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF5TmlBdkx5QWljbVZrWlcxd2RHbHZibDltWldVaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNamNnTHk4Z0ltMXBiblJwYm1kZlptVmxJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0ptY21GNFgzTjBaWEFpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01qTWdMeThnSW5KbFpuSmxjMmhmWTI5dmJHUnZkMjRpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01UVWdMeThnSW5CeWFXTmxYM1JoY21kbGRDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWljSEpwWTJWZlltRnVaQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBME1DQXZMeUFpUkVWR1FWVk1WRjlCUkUxSlRsOUJSRVJTUlZOVElnb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXlOQ0F2THlBaVkyOXNiR0YwWlhKaGJGOXlZWFJwYjE5d1lYVnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURJNElDOHZJQ0pzWVhOMFgyTmhiR3hmZEdsdFpTSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEwTVNBdkx5QWlabkpoZUY5d2IyOXNjMTloY25KaGVWOXNaVzVuZEdnaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEUXlJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMk9XVmpObUUxT0NBd2VHSXhZVEEwTWpZNElEQjRObU0wWWpKaVkyWWdNSGhoWXpVM1lXUmhNaUF3ZURoalpHUXpNV0ptSURCNE9XUmpORGt6T0RrZ01IaGhPRGhpT0RnNFl5QXdlR00zWXpFd1ptWmxJREI0TVRNek1qZGxNamdnTUhoaE1HTTJNVGRtTlNBd2VEQmxOalJqWTJJeklEQjRPRFl6T1dRd1pEa2dNSGhpTXpjeFpqWTFNU0F3ZURRM1kyTmxaV0l6SURCNFlqaGpNbVF6Wm1ZZ01IZ3lNVFl6TVRsa09TQXdlRFkzWkdJNVpERXlJREI0TnpBeFpqaGtZeklnTUhoaFlXWmlZakE0WWlBd2VHTm1OamszWldNNElEQjRZbVZtWTJZMVpHUWdNSGcxT0dJME4yRmtZeUF3ZUdVeFpEUmlOR1ZsSURCNE5UQmpZbVkzTkRrZ01IZ3pZV1F6WVRFd015QXdlR1ExTWpGa05qQTBJREI0TlRoaE9URXdNamdnTUhnd1pURmpOR0poTUNBd2VESTBOV1EzWmpVNUlEQjROamN5T0Rsak4yUWdNSGd4TkRGak5HWXhPQ0F3ZURnek1HUTJNR0l4SURCNE9XVTBPVGd5WldRZ01IZzNPV1poWWpRMk5TQXdlRGd6WW1Ga04yTmpJREI0TVRrNFl6azRNakFnTUhnMVpEZzFOR1F3WlNBd2VHWmhabUkyWVRBNElEQjRObVJtTkRGbU5tUWdNSGhsT1Rsall6azNPU0F3ZURkbFlqWmtZalJqSURCNFpqRTFNRFUxTWpjZ01IaGtNelF6TnpVMU5DQXdlREF3TldJMU1tSTRJREI0TVRrM05UQTJNVFlnTUhoaVpEUmhabVUxWlNBd2VEUXlNMk0wTURCa0lEQjRNREV5WlRVek1tVWdNSGd5TWpFeE16bGxZU0F3ZURoaE9XWTBaRGt6SURCNE56SmpOV1l3TW1ZZ01IZzRPRGRoWmpCa1lTQXdlRGhsTXpnMk5qTXdJREI0T0RkaVpHUXlaVGtnTUhoak1tTmlNRFJoTnlBd2VHRTVNRFU0T0dRNUlEQjROak5oTUdRellUVWdNSGhqTldRd05UTmhaaUF3ZUdVeU16UTBaRGsxSURCNFlqaGlNREEzTmpFZ01IZzFNMlF6WkdSa09TQXdlREZrWm1ObU5EUXlJREI0T0dSaE9HRmhaaklnTUhnNVpXTXpNVGhrTlNBd2VHSXhZbUppTUdFNElEQjROMlF5WmpNMU5XTWdMeThnYldWMGFHOWtJQ0pmWDNCdmMzUkpibWwwS0hOMGNtbHVaeXh6ZEhKcGJtY3NZV1JrY21WemN5eGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1aeVlYaGZjSEpwWTJVb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltWjRjMTl3Y21salpTZ3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlaWFJvWDNWelpGOXdjbWxqWlNncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVpuSmhlRjlwYm1adktDa29kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLU0lzSUcxbGRHaHZaQ0FpWjJ4dlltRnNRMjlzYkdGMFpYSmhiRlpoYkhWbEtDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSnlaV1p5WlhOb1EyOXNiR0YwWlhKaGJGSmhkR2x2S0NsMmIybGtJaXdnYldWMGFHOWtJQ0p3YjI5c1gySjFjbTVmWm5KdmJTaGhaR1J5WlhOekxIVnBiblF5TlRZcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY0c5dmJGOXRhVzUwS0dGa1pISmxjM01zZFdsdWRESTFOaWwyYjJsa0lpd2diV1YwYUc5a0lDSmhaR1JRYjI5c0tHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WdGIzWmxVRzl2YkNoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEZKbFpHVnRjSFJwYjI1R1pXVW9kV2x1ZERJMU5pbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUk5hVzUwYVc1blJtVmxLSFZwYm5ReU5UWXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBSbkpoZUZOMFpYQW9kV2x1ZERJMU5pbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUlFjbWxqWlZSaGNtZGxkQ2gxYVc1ME1qVTJLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRkpsWm5KbGMyaERiMjlzWkc5M2JpaDFhVzUwTWpVMktYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRFWllVMEZrWkhKbGMzTW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUkZWRWhWVTBSUGNtRmpiR1VvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJVYVcxbGJHOWpheWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRU52Ym5SeWIyeHNaWElvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJRY21salpVSmhibVFvZFdsdWRESTFOaWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJHVWtGWVJYUm9UM0poWTJ4bEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSR1dGTkZkR2hQY21GamJHVW9ZV1JrY21WemN5eGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5SdloyZHNaVU52Ykd4aGRHVnlZV3hTWVhScGJ5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWJtOXRhVzVoZEdWT1pYZFBkMjVsY2loaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZqWTJWd2RFOTNibVZ5YzJocGNDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWFHRnpVbTlzWlNoaWVYUmxXek15WFN4aFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZEZKdmJHVk5aVzFpWlhKRGIzVnVkQ2hpZVhSbFd6TXlYU2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0puWlhSU2IyeGxUV1Z0WW1WeUtHSjVkR1ZiTXpKZExIVnBiblF5TlRZcFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaVoyVjBVbTlzWlVGa2JXbHVLR0o1ZEdWYk16SmRLV0o1ZEdWYk16SmRJaXdnYldWMGFHOWtJQ0puY21GdWRGSnZiR1VvWW5sMFpWc3pNbDBzWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaWFp2YTJWU2IyeGxLR0o1ZEdWYk16SmRMR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVnViM1Z1WTJWU2IyeGxLR0o1ZEdWYk16SmRMR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWRHOTBZV3hUZFhCd2JIa29LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbUpoYkdGdVkyVlBaaWhoWkdSeVpYTnpLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJblJ5WVc1elptVnlLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbGliMjlzSWl3Z2JXVjBhRzlrSUNKaGJHeHZkMkZ1WTJVb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1Gd2NISnZkbVVvWVdSa2NtVnpjeXgxYVc1ME1qVTJLV0p2YjJ3aUxDQnRaWFJvYjJRZ0luUnlZVzV6Wm1WeVJuSnZiU2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbGliMjlzSWl3Z2JXVjBhRzlrSUNKcGJtTnlaV0Z6WlVGc2JHOTNZVzVqWlNoaFpHUnlaWE56TEhWcGJuUXlOVFlwWW05dmJDSXNJRzFsZEdodlpDQWlaR1ZqY21WaGMyVkJiR3h2ZDJGdVkyVW9ZV1JrY21WemN5eDFhVzUwTWpVMktXSnZiMndpTENCdFpYUm9iMlFnSW1KMWNtNG9kV2x1ZERJMU5pbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaWRYSnVSbkp2YlNoaFpHUnlaWE56TEhWcGJuUXlOVFlwZG05cFpDSXNJRzFsZEdodlpDQWljM2x0WW05c0tDbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltNWhiV1VvS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWTNKbFlYUnZjbDloWkdSeVpYTnpLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0owYVcxbGJHOWphMTloWkdSeVpYTnpLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0pqYjI1MGNtOXNiR1Z5WDJGa1pISmxjM01vS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW1aNGMxOWhaR1J5WlhOektDbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSm1jbUY0WDJWMGFGOXZjbUZqYkdWZllXUmtjbVZ6Y3lncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaVpuaHpYMlYwYUY5dmNtRmpiR1ZmWVdSa2NtVnpjeWdwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpZDJWMGFGOWhaR1J5WlhOektDbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSmxkR2hmZFhOa1gyTnZibk4xYldWeVgyRmtaSEpsYzNNb0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0ltWnlZWGhmY0c5dmJITmZZWEp5WVhrb0tXSjVkR1ZiTXpKZFcxMGlMQ0J0WlhSb2IyUWdJbWRzYjJKaGJGOWpiMnhzWVhSbGNtRnNYM0poZEdsdktDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSnlaV1JsYlhCMGFXOXVYMlpsWlNncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWJXbHVkR2x1WjE5bVpXVW9LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbVp5WVhoZmMzUmxjQ2dwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpY21WbWNtVnphRjlqYjI5c1pHOTNiaWdwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpY0hKcFkyVmZkR0Z5WjJWMEtDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSndjbWxqWlY5aVlXNWtLQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0pFUlVaQlZVeFVYMEZFVFVsT1gwRkVSRkpGVTFNb0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0ltTnZiR3hoZEdWeVlXeGZjbUYwYVc5ZmNHRjFjMlZrS0NsaWIyOXNJaXdnYldWMGFHOWtJQ0pzWVhOMFgyTmhiR3hmZEdsdFpTZ3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWliM2R1WlhJb0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0ltNXZiV2x1WVhSbFpFOTNibVZ5S0NsaFpHUnlaWE56SWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1gxOXdiM04wU1c1cGRDQm1jbUY0WDNCeWFXTmxJR1o0YzE5d2NtbGpaU0JsZEdoZmRYTmtYM0J5YVdObElHWnlZWGhmYVc1bWJ5Qm5iRzlpWVd4RGIyeHNZWFJsY21Gc1ZtRnNkV1VnY21WbWNtVnphRU52Ykd4aGRHVnlZV3hTWVhScGJ5QndiMjlzWDJKMWNtNWZabkp2YlNCd2IyOXNYMjFwYm5RZ1lXUmtVRzl2YkNCeVpXMXZkbVZRYjI5c0lITmxkRkpsWkdWdGNIUnBiMjVHWldVZ2MyVjBUV2x1ZEdsdVowWmxaU0J6WlhSR2NtRjRVM1JsY0NCelpYUlFjbWxqWlZSaGNtZGxkQ0J6WlhSU1pXWnlaWE5vUTI5dmJHUnZkMjRnYzJWMFJsaFRRV1JrY21WemN5QnpaWFJGVkVoVlUwUlBjbUZqYkdVZ2MyVjBWR2x0Wld4dlkyc2djMlYwUTI5dWRISnZiR3hsY2lCelpYUlFjbWxqWlVKaGJtUWdjMlYwUmxKQldFVjBhRTl5WVdOc1pTQnpaWFJHV0ZORmRHaFBjbUZqYkdVZ2RHOW5aMnhsUTI5c2JHRjBaWEpoYkZKaGRHbHZJRzV2YldsdVlYUmxUbVYzVDNkdVpYSWdZV05qWlhCMFQzZHVaWEp6YUdsd0lHaGhjMUp2YkdVZ1oyVjBVbTlzWlUxbGJXSmxja052ZFc1MElHZGxkRkp2YkdWTlpXMWlaWElnWjJWMFVtOXNaVUZrYldsdUlHZHlZVzUwVW05c1pTQnlaWFp2YTJWU2IyeGxJSEpsYm05MWJtTmxVbTlzWlNCMGIzUmhiRk4xY0hCc2VTQmlZV3hoYm1ObFQyWWdkSEpoYm5ObVpYSWdZV3hzYjNkaGJtTmxJR0Z3Y0hKdmRtVWdkSEpoYm5ObVpYSkdjbTl0SUdsdVkzSmxZWE5sUVd4c2IzZGhibU5sSUdSbFkzSmxZWE5sUVd4c2IzZGhibU5sSUdKMWNtNGdZblZ5YmtaeWIyMGdjM2x0WW05c0lHNWhiV1VnWTNKbFlYUnZjbDloWkdSeVpYTnpJSFJwYldWc2IyTnJYMkZrWkhKbGMzTWdZMjl1ZEhKdmJHeGxjbDloWkdSeVpYTnpJR1o0YzE5aFpHUnlaWE56SUdaeVlYaGZaWFJvWDI5eVlXTnNaVjloWkdSeVpYTnpJR1o0YzE5bGRHaGZiM0poWTJ4bFgyRmtaSEpsYzNNZ2QyVjBhRjloWkdSeVpYTnpJR1YwYUY5MWMyUmZZMjl1YzNWdFpYSmZZV1JrY21WemN5Qm1jbUY0WDNCdmIyeHpYMkZ5Y21GNUlHZHNiMkpoYkY5amIyeHNZWFJsY21Gc1gzSmhkR2x2SUhKbFpHVnRjSFJwYjI1ZlptVmxJRzFwYm5ScGJtZGZabVZsSUdaeVlYaGZjM1JsY0NCeVpXWnlaWE5vWDJOdmIyeGtiM2R1SUhCeWFXTmxYM1JoY21kbGRDQndjbWxqWlY5aVlXNWtJRVJGUmtGVlRGUmZRVVJOU1U1ZlFVUkVVa1ZUVXlCamIyeHNZWFJsY21Gc1gzSmhkR2x2WDNCaGRYTmxaQ0JzWVhOMFgyTmhiR3hmZEdsdFpTQnZkMjVsY2lCdWIyMXBibUYwWldSUGQyNWxjZ29nSUNBZ1pYSnlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSVzUxYldWeVlXSnNaVk5sZEM1ZllXUmtLSE5sZERvZ1lubDBaWE1zSUhaaGJIVmxPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBMQ0JpZVhSbGN6b0tSVzUxYldWeVlXSnNaVk5sZEM1ZllXUmtPZ29nSUNBZ2NISnZkRzhnTWlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwTGw5amIyNTBZV2x1Y3dvZ0lDQWdabkpoYldWZlluVnllU0F0TWdvZ0lDQWdZbTU2SUVWdWRXMWxjbUZpYkdWVFpYUXVYMkZrWkY5bGJITmxYMkp2WkhsQU5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFnTHk4Z2IyNGdaWEp5YjNJNklHMWhlQ0JoY25KaGVTQnNaVzVuZEdnZ1pYaGpaV1ZrWldRS0lDQWdJSEJ2Y0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF5T1NBdkx5QWlYMmx1WkdWNFpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnlaWFJ6ZFdJS0NrVnVkVzFsY21GaWJHVlRaWFF1WDJGa1pGOWxiSE5sWDJKdlpIbEFORG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhRdVgzSmxiVzkyWlNoelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE02Q2tWdWRXMWxjbUZpYkdWVFpYUXVYM0psYlc5MlpUb0tJQ0FnSUhCeWIzUnZJRElnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklESTVJQzh2SUNKZmFXNWtaWGhsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQmllaUJGYm5WdFpYSmhZbXhsVTJWMExsOXlaVzF2ZG1WZlpXeHpaVjlpYjJSNVFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNUW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0x3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREVLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J5WlhCc1lXTmxNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUhCdmNBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURFS0lDQWdJR0lyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklESTVJQzh2SUNKZmFXNWtaWGhsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhKbGRITjFZZ29LUlc1MWJXVnlZV0pzWlZObGRDNWZjbVZ0YjNabFgyVnNjMlZmWW05a2VVQXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyTnZiblJoYVc1ektITmxkRG9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZMExDQmllWFJsY3pvS1JXNTFiV1Z5WVdKc1pWTmxkQzVmWTI5dWRHRnBibk02Q2lBZ0lDQndjbTkwYnlBeUlESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF5T1NBdkx5QWlYMmx1WkdWNFpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyeGxibWQwYUNoelpYUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN5d2dZbmwwWlhNNkNrVnVkVzFsY21GaWJHVlRaWFF1WDJ4bGJtZDBhRG9LSUNBZ0lIQnliM1J2SURFZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdkNpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrVnVkVzFsY21GaWJHVlRaWFF1WDJGMEtITmxkRG9nWW5sMFpYTXNJR2x1WkdWNE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6T2dwRmJuVnRaWEpoWW14bFUyVjBMbDloZERvS0lDQWdJSEJ5YjNSdklESWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWo0S0lDQWdJR0Z6YzJWeWRDQXZMeUJGYm5WdFpYSmhZbXhsVTJWME9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJXNTFiV1Z5WVdKc1pWTmxkQzVoWkdRb01pbGZNQ2h6WlhRNklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJOQ3dnWW5sMFpYTXNJR0o1ZEdWek9ncEZiblZ0WlhKaFlteGxVMlYwTG1Ga1pEb0tJQ0FnSUhCeWIzUnZJRElnTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJGYm5WdFpYSmhZbXhsVTJWMExsOWhaR1FLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCa2RYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhRdWNtVnRiM1psS0RJcFh6QW9jMlYwT2lCaWVYUmxjeXdnZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUXNJR0o1ZEdWekxDQmllWFJsY3pvS1JXNTFiV1Z5WVdKc1pWTmxkQzV5WlcxdmRtVTZDaUFnSUNCd2NtOTBieUF5SURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnUlc1MWJXVnlZV0pzWlZObGRDNWZjbVZ0YjNabENpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBMbU52Ym5SaGFXNXpLRElwWHpBb2MyVjBPaUJpZVhSbGN5d2dkbUZzZFdVNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRc0lHSjVkR1Z6T2dwRmJuVnRaWEpoWW14bFUyVjBMbU52Ym5SaGFXNXpPZ29nSUNBZ2NISnZkRzhnTWlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUVWdWRXMWxjbUZpYkdWVFpYUXVYMk52Ym5SaGFXNXpDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSVzUxYldWeVlXSnNaVk5sZEM1c1pXNW5kR2dvTVNsZk1DaHpaWFE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDa1Z1ZFcxbGNtRmliR1ZUWlhRdWJHVnVaM1JvT2dvZ0lDQWdjSEp2ZEc4Z01TQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwTGw5c1pXNW5kR2dLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVGYm5WdFpYSmhZbXhsVTJWMExtRjBLRElwWHpBb2MyVjBPaUJpZVhSbGN5d2dhVzVrWlhnNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE02Q2tWdWRXMWxjbUZpYkdWVFpYUXVZWFE2Q2lBZ0lDQndjbTkwYnlBeUlESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1JXNTFiV1Z5WVdKc1pWTmxkQzVmWVhRS0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1VFlXWmxUV0YwYUM1aFpHUW9ZVG9nWW5sMFpYTXNJR0k2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LVTJGbVpVMWhkR2d1WVdSa09nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpc0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWVdabFRXRjBhRG9nWVdSa2FYUnBiMjRnYjNabGNtWnNiM2NLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGxOaFptVk5ZWFJvTG5OMVlpZ3lLU2hoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwVFlXWmxUV0YwYUM1emRXSTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbE5oWm1WTllYUm9PaUJ6ZFdKMGNtRmpkR2x2YmlCdmRtVnlabXh2ZHlJS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1VTJGbVpVMWhkR2d1YzNWaUtETXBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVUWVdabFRXRjBhQzV6ZFdJb015a29ZVG9nWW5sMFpYTXNJR0k2SUdKNWRHVnpMQ0JsY25KdmNrMWxjM05oWjJVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VVMkZtWlUxaGRHZ3VjM1ZpS0RNcE9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lqdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWEowYVc5dUlHWmhhV3hsWkFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVUyRm1aVTFoZEdndWJYVnNLR0U2SUdKNWRHVnpMQ0JpT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2xOaFptVk5ZWFJvTG0xMWJEb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJRk5oWm1WTllYUm9MbTExYkY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCeVpYUnpkV0lLQ2xOaFptVk5ZWFJvTG0xMWJGOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZaW9LSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaUx3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWVdabFRXRjBhRG9nYlhWc2RHbHdiR2xqWVhScGIyNGdiM1psY21ac2IzY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMbE5oWm1WTllYUm9MbVJwZGlneUtTaGhPaUJpZVhSbGN5d2dZam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BUWVdabFRXRjBhQzVrYVhZNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsTmhabVZOWVhSb09pQmthWFpwYzJsdmJpQmllU0I2WlhKdklnb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1VFlXWmxUV0YwYUM1a2FYWW9NeWtLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGxOaFptVk5ZWFJvTG1ScGRpZ3pLU2hoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1zSUdWeWNtOXlUV1Z6YzJGblpUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVUWVdabFRXRjBhQzVrYVhZb015azZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25ScGIyNGdabUZwYkdWa0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaThLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaU1FWaFRkR0ZpYkdWamIybHVMbDlmY0c5emRFbHVhWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwZlgzQnZjM1JKYm1sME9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdZbmwwWldNZ05ESWdMeThnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmZYM0J2YzNSSmJtbDBJR0ZzY21WaFpIa2dZMkZzYkdWa0NpQWdJQ0JpZVhSbFl5QTBNaUF2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmllWFJsWTE4eElDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGQyNWxjaUJoWkdSeVpYTnpJR05oYm01dmRDQmlaU0F3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdScFp5QXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklHSmhjMlV6TWlneVRFZFFSa1ZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZwbGNtOGdZV1JrY21WemN5QmtaWFJsWTNSbFpBb2dJQ0FnWW5sMFpXTWdNelVnTHk4Z0ltNWhiV1VpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF6TkNBdkx5QWljM2x0WW05c0lnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01qSWdMeThnSW1OeVpXRjBiM0pmWVdSa2NtVnpjeUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnBiV1ZzYjJOclgyRmtaSEpsYzNNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdYMmR5WVc1MFVtOXNaUW9nSUNBZ1lubDBaV01nTkRBZ0x5OGdJa1JGUmtGVlRGUmZRVVJOU1U1ZlFVUkVVa1ZUVXlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWpJZ0x5OGdJbU55WldGMGIzSmZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1kzSmxZWFJ2Y2w5aFpHUnlaWE56SUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWtNeU1Eb2diV2x1ZENCMGJ5QjBhR1VnZW1WeWJ5QmhaR1J5WlhOekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpWDNSdmRHRnNVM1Z3Y0d4NUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCZmRHOTBZV3hUZFhCd2JIa2daWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTBOeUF2THlBd2VEQXhZVGM0TkRNM09XUTVPV1JpTkRJd01EQXdNREFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndVlXUmtDaUFnSUNCaWVYUmxZeUE1SUM4dklDSmZkRzkwWVd4VGRYQndiSGtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKZlltRnNZVzVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JpZVhSbFl5QTBOeUF2THlBd2VEQXhZVGM0TkRNM09XUTVPV1JpTkRJd01EQXdNREFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndVlXUmtDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVdFM09EUXpOemxrT1Rsa1lqUXlNREF3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRE13SUM4dklHMWxkR2h2WkNBaVZISmhibk5tWlhJb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU1pQXZMeUFpWTNKbFlYUnZjbDloWkdSeVpYTnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmpjbVZoZEc5eVgyRmtaSEpsYzNNZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWXlBME15QXZMeUF3ZUdJeU5UUXdNalF4T0dGa05UVTFNREV6TWpFd016WTFZVFF5TW1ZNVpqRXlNRFppTW1Sa01EQTNNVGs1T1Roa1lqQTJaamhoTVdaaVpUQXhORFkwTVdJS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVaM0poYm5SU2IyeGxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUdKNWRHVmpJRFF6SUM4dklEQjRZakkxTkRBeU5ERTRZV1ExTlRVd01UTXlNVEF6TmpWaE5ESXlaamxtTVRJd05tSXlaR1F3TURjeE9UazVPR1JpTURabU9HRXhabUpsTURFME5qUXhZZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1bmNtRnVkRkp2YkdVS0lDQWdJSEIxYzJocGJuUWdNalV3TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW1aeVlYaGZjM1JsY0NJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTmlBdkx5QWlaMnh2WW1Gc1gyTnZiR3hoZEdWeVlXeGZjbUYwYVc4aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhCMWMyaHBiblFnTXpZd01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNak1nTHk4Z0luSmxabkpsYzJoZlkyOXZiR1J2ZDI0aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0luQnlhV05sWDNSaGNtZGxkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQndkWE5vYVc1MElEVXdNREFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0p3Y21salpWOWlZVzVrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R1VrRllVM1JoWW14bFkyOXBiaTVtY21GNFgzQnlhV05sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1puSmhlRjl3Y21salpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJRzl5WVdOc1pWOXdjbWxqWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHVWtGWVUzUmhZbXhsWTI5cGJpNW1lSE5mY0hKcFkyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BtZUhOZmNISnBZMlU2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1kyRnNiSE4xWWlCdmNtRmpiR1ZmY0hKcFkyVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJsSkJXRk4wWVdKc1pXTnZhVzR1WlhSb1gzVnpaRjl3Y21salpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVYwYUY5MWMyUmZjSEpwWTJVNkNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdJbVYwYUY5MWMyUmZjSEpwWTJWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCbGRHaGZkWE5rWDNCeWFXTmxjaUJsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRFEwSUM4dklHMWxkR2h2WkNBaVoyVjBUR0YwWlhOMFVISnBZMlVvS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01Rb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURJeElDOHZJQ0psZEdoZmRYTmtYM0J5YVdObGNsOWtaV05wYldGc2N5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1pYUm9YM1Z6WkY5d2NtbGpaWEpmWkdWamFXMWhiSE1nWlhocGMzUnpDaUFnSUNCcGRHOWlDZ3BsZEdoZmRYTmtYM0J5YVdObFgzZG9hV3hsWDNSdmNFQXpPZ29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBnb2dJQ0FnWW5vZ1pYUm9YM1Z6WkY5d2NtbGpaVjloWm5SbGNsOTNhR2xzWlVBM0NpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01Rb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nWlhSb1gzVnpaRjl3Y21salpWOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWWlvS0lDQWdJR0oxY25rZ013b0taWFJvWDNWelpGOXdjbWxqWlY5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqSURRMUlDOHZJREI0TURJS0lDQWdJR0l2Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR0lxQ2lBZ0lDQmlkWEo1SURJS0lDQWdJR0lnWlhSb1gzVnpaRjl3Y21salpWOTNhR2xzWlY5MGIzQkFNd29LWlhSb1gzVnpaRjl3Y21salpWOWhablJsY2w5M2FHbHNaVUEzT2dvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2FXNTBZeUEwSUM4dklERXdNREF3TURBS0lDQWdJR2wwYjJJS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3ViWFZzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNWthWFlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVpuSmhlRjlwYm1adlczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tabkpoZUY5cGJtWnZPZ29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklESXdJQzh2SUNKbGRHaGZkWE5rWDNCeWFXTmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2daWFJvWDNWelpGOXdjbWxqWlhJZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBME5DQXZMeUJ0WlhSb2IyUWdJbWRsZEV4aGRHVnpkRkJ5YVdObEtDbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREVLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUdsMGIySUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXlNU0F2THlBaVpYUm9YM1Z6WkY5d2NtbGpaWEpmWkdWamFXMWhiSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR1YwYUY5MWMyUmZjSEpwWTJWeVgyUmxZMmx0WVd4eklHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvS1puSmhlRjlwYm1adlgzZG9hV3hsWDNSdmNFQXpPZ29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBnb2dJQ0FnWW5vZ1puSmhlRjlwYm1adlgyRm1kR1Z5WDNkb2FXeGxRRGNLSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF4Q2lBZ0lDQmlKZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQm1jbUY0WDJsdVptOWZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUdJcUNpQWdJQ0JpZFhKNUlETUtDbVp5WVhoZmFXNW1iMTloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpJRFExSUM4dklEQjRNRElLSUNBZ0lHSXZDaUFnSUNCaWRYSjVJREVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSXFDaUFnSUNCaWRYSjVJRElLSUNBZ0lHSWdabkpoZUY5cGJtWnZYM2RvYVd4bFgzUnZjRUF6Q2dwbWNtRjRYMmx1Wm05ZllXWjBaWEpmZDJocGJHVkFOem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUc5eVlXTnNaVjl3Y21salpRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR05oYkd4emRXSWdiM0poWTJ4bFgzQnlhV05sQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlYM1J2ZEdGc1UzVndjR3g1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmZEc5MFlXeFRkWEJ3YkhrZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlaMnh2WW1Gc1gyTnZiR3hoZEdWeVlXeGZjbUYwYVc4aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdkc2IySmhiRjlqYjJ4c1lYUmxjbUZzWDNKaGRHbHZJR1Y0YVhOMGN3b2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R1VrRllVM1JoWW14bFkyOXBiaTVuYkc5aVlXeERiMnhzWVhSbGNtRnNWbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU55QXZMeUFpYldsdWRHbHVaMTltWldVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUcxcGJuUnBibWRmWm1WbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURJMklDOHZJQ0p5WldSbGJYQjBhVzl1WDJabFpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2NtVmtaVzF3ZEdsdmJsOW1aV1VnWlhocGMzUnpDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1dGRXd0tJQ0FnSUdScFp5QXhNQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUdScFp5QTNDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBNENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURjS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1pHbG5JRElLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUExQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdScFp5QXlDaUFnSUNCaWZBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkdsbklESUtJQ0FnSUdKOENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaU1FWaFRkR0ZpYkdWamIybHVMbWRzYjJKaGJFTnZiR3hoZEdWeVlXeFdZV3gxWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZHNiMkpoYkVOdmJHeGhkR1Z5WVd4V1lXeDFaVG9LSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVoyeHZZbUZzUTI5c2JHRjBaWEpoYkZaaGJIVmxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG5KbFpuSmxjMmhEYjJ4c1lYUmxjbUZzVW1GMGFXOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldaeVpYTm9RMjlzYkdGMFpYSmhiRkpoZEdsdk9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklESTBJQzh2SUNKamIyeHNZWFJsY21Gc1gzSmhkR2x2WDNCaGRYTmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjlzYkdGMFpYSmhiRjl5WVhScGIxOXdZWFZ6WldRZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyOXNiR0YwWlhKaGJDQlNZWFJwYnlCb1lYTWdZbVZsYmlCd1lYVnpaV1FLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUc5eVlXTnNaVjl3Y21salpRb2dJQ0FnWkhWd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXlPQ0F2THlBaWJHRnpkRjlqWVd4c1gzUnBiV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR3hoYzNSZlkyRnNiRjkwYVcxbElHVjRhWE4wY3dvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURJeklDOHZJQ0p5WldaeVpYTm9YMk52YjJ4a2IzZHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnlaV1p5WlhOb1gyTnZiMnhrYjNkdUlHVjRhWE4wY3dvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUWFZ6ZENCM1lXbDBJR1p2Y2lCMGFHVWdjbVZtY21WemFDQmpiMjlzWkc5M2JpQnphVzVqWlNCc1lYTjBJSEpsWm5KbGMyZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaWNISnBZMlZmZEdGeVoyVjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QndjbWxqWlY5MFlYSm5aWFFnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0luQnlhV05sWDJKaGJtUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIQnlhV05sWDJKaGJtUWdaWGhwYzNSekNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbUZrWkFvZ0lDQWdZajRLSUNBZ0lHSjZJSEpsWm5KbGMyaERiMnhzWVhSbGNtRnNVbUYwYVc5ZlpXeHpaVjlpYjJSNVFEWUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKbmJHOWlZV3hmWTI5c2JHRjBaWEpoYkY5eVlYUnBieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2daMnh2WW1Gc1gyTnZiR3hoZEdWeVlXeGZjbUYwYVc4Z1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbVp5WVhoZmMzUmxjQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dabkpoZUY5emRHVndJR1Y0YVhOMGN3b2dJQ0FnWWp3OUNpQWdJQ0JpZWlCeVpXWnlaWE5vUTI5c2JHRjBaWEpoYkZKaGRHbHZYMlZzYzJWZlltOWtlVUEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTmlBdkx5QWlaMnh2WW1Gc1gyTnZiR3hoZEdWeVlXeGZjbUYwYVc4aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tjbVZtY21WemFFTnZiR3hoZEdWeVlXeFNZWFJwYjE5aFpuUmxjbDlwWmw5bGJITmxRREV5T2dvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ01qZ2dMeThnSW14aGMzUmZZMkZzYkY5MGFXMWxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSm5iRzlpWVd4ZlkyOXNiR0YwWlhKaGJGOXlZWFJwYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWjJ4dlltRnNYMk52Ykd4aGRHVnlZV3hmY21GMGFXOGdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURZek5tSm1NamtnTHk4Z2JXVjBhRzlrSUNKRGIyeHNZWFJsY21Gc1VtRjBhVzlTWldaeVpYTm9aV1FvZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2NtVm1jbVZ6YUVOdmJHeGhkR1Z5WVd4U1lYUnBiMTlsYkhObFgySnZaSGxBTkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0puYkc5aVlXeGZZMjlzYkdGMFpYSmhiRjl5WVhScGJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1oyeHZZbUZzWDJOdmJHeGhkR1Z5WVd4ZmNtRjBhVzhnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0ltWnlZWGhmYzNSbGNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1puSmhlRjl6ZEdWd0lHVjRhWE4wY3dvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXpkV0lLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbWRzYjJKaGJGOWpiMnhzWVhSbGNtRnNYM0poZEdsdklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdJZ2NtVm1jbVZ6YUVOdmJHeGhkR1Z5WVd4U1lYUnBiMTloWm5SbGNsOXBabDlsYkhObFFERXlDZ3B5WldaeVpYTm9RMjlzYkdGMFpYSmhiRkpoZEdsdlgyVnNjMlZmWW05a2VVQTJPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSndjbWxqWlY5MFlYSm5aWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEJ5YVdObFgzUmhjbWRsZENCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWljSEpwWTJWZlltRnVaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djSEpwWTJWZlltRnVaQ0JsZUdsemRITUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YzNWaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWo0S0lDQWdJR0o2SUhKbFpuSmxjMmhEYjJ4c1lYUmxjbUZzVW1GMGFXOWZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1kc2IySmhiRjlqYjJ4c1lYUmxjbUZzWDNKaGRHbHZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qm5iRzlpWVd4ZlkyOXNiR0YwWlhKaGJGOXlZWFJwYnlCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlabkpoZUY5emRHVndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qm1jbUY0WDNOMFpYQWdaWGhwYzNSekNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbUZrWkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdZME1qUXdDaUFnSUNCaVBqMEtJQ0FnSUdKNklISmxabkpsYzJoRGIyeHNZWFJsY21Gc1VtRjBhVzlmWld4elpWOWliMlI1UURrS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01EQXdDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEySUM4dklDSm5iRzlpWVd4ZlkyOXNiR0YwWlhKaGJGOXlZWFJwYnlJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpSUhKbFpuSmxjMmhEYjJ4c1lYUmxjbUZzVW1GMGFXOWZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb0tjbVZtY21WemFFTnZiR3hoZEdWeVlXeFNZWFJwYjE5bGJITmxYMkp2WkhsQU9Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKbmJHOWlZV3hmWTI5c2JHRjBaWEpoYkY5eVlYUnBieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2daMnh2WW1Gc1gyTnZiR3hoZEdWeVlXeGZjbUYwYVc4Z1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbVp5WVhoZmMzUmxjQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dabkpoZUY5emRHVndJR1Y0YVhOMGN3b2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVoWkdRS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1kc2IySmhiRjlqYjJ4c1lYUmxjbUZzWDNKaGRHbHZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSWdjbVZtY21WemFFTnZiR3hoZEdWeVlXeFNZWFJwYjE5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVjRzl2YkY5aWRYSnVYMlp5YjIxYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdiMjlzWDJKMWNtNWZabkp2YlRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNekVnTHk4Z0ltWnlZWGhmY0c5dmJITWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQm1jbUY0SUhCdmIyeHpJR05oYmlCallXeHNJSFJvYVhNZ1puVnVZM1JwYjI0S0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTJGc2JITjFZaUJmWW5WeWJnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBaVgyRnNiRzkzWVc1alpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSjVkR1ZqSURRNElDOHZJQ0pGVWtNeU1Eb2dZblZ5YmlCaGJXOTFiblFnWlhoalpXVmtjeUJoYkd4dmQyRnVZMlVpQ2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMbE5oWm1WTllYUm9Mbk4xWWlnektRb2dJQ0FnWkdsbklEUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1gyRndjSEp2ZG1VS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0UwTnpOaU5tSm1JQzh2SUcxbGRHaHZaQ0FpUmxKQldFSjFjbTVsWkNoaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaU1FWaFRkR0ZpYkdWamIybHVMbkJ2YjJ4ZmJXbHVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CdmIyeGZiV2x1ZERvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNekVnTHk4Z0ltWnlZWGhmY0c5dmJITWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQm1jbUY0SUhCdmIyeHpJR05oYmlCallXeHNJSFJvYVhNZ1puVnVZM1JwYjI0S0lDQWdJR1JwWnlBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVa015TURvZ2JXbHVkQ0IwYnlCMGFHVWdlbVZ5YnlCaFpHUnlaWE56Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlYM1J2ZEdGc1UzVndjR3g1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmZEc5MFlXeFRkWEJ3YkhrZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNWhaR1FLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbDkwYjNSaGJGTjFjSEJzZVNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QWlYMkpoYkdGdVkyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndVlXUmtDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTXpBZ0x5OGdiV1YwYUc5a0lDSlVjbUZ1YzJabGNpaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTmlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WlRreU9XTTJNMllnTHk4Z2JXVjBhRzlrSUNKR1VrRllUV2x1ZEdWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJsSkJXRk4wWVdKc1pXTnZhVzR1WVdSa1VHOXZiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Ga1pGQnZiMnc2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2diM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJR0ZrWkZCdmIyeGZZbTl2YkY5MGNuVmxRRFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGFXMWxiRzlqYTE5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYVcxbGJHOWphMTloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCaFpHUlFiMjlzWDJKdmIyeGZkSEoxWlVBMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZMjl1ZEhKdmJHeGxjbDloWkdSeVpYTnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmpiMjUwY205c2JHVnlYMkZrWkhKbGMzTWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbm9nWVdSa1VHOXZiRjlpYjI5c1gyWmhiSE5sUURVS0NtRmtaRkJ2YjJ4ZlltOXZiRjkwY25WbFFEUTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb0tZV1JrVUc5dmJGOWliMjlzWDIxbGNtZGxRRFk2Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUhSb1pTQnZkMjVsY2l3Z1kyOXVkSEp2Ykd4bGNpd2diM0lnZEdobElHZHZkbVZ5Ym1GdVkyVWdkR2x0Wld4dlkyc0tJQ0FnSUdSMWNHNGdNZ29nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnV21WeWJ5QmhaR1J5WlhOeklHUmxkR1ZqZEdWa0NpQWdJQ0JrZFhBS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNekVnTHk4Z0ltWnlZWGhmY0c5dmJITWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdSa2NtVnpjeUJoYkhKbFlXUjVJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSm1jbUY0WDNCdmIyeHpYMkZ5Y21GNUlnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHSnZlQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFnTHk4Z2IyNGdaWEp5YjNJNklHMWhlQ0JoY25KaGVTQnNaVzVuZEdnZ1pYaGpaV1ZrWldRS0lDQWdJSEJ2Y0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WmpoaVptTmlZamtnTHk4Z2JXVjBhRzlrSUNKUWIyOXNRV1JrWldRb1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tZV1JrVUc5dmJGOWliMjlzWDJaaGJITmxRRFU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQmhaR1JRYjI5c1gySnZiMnhmYldWeVoyVkFOZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxuSmxiVzkyWlZCdmIyeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlcxdmRtVlFiMjlzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW05M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2djbVZ0YjNabFVHOXZiRjlpYjI5c1gzUnlkV1ZBTkFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnBiV1ZzYjJOclgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhScGJXVnNiMk5yWDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklISmxiVzkyWlZCdmIyeGZZbTl2YkY5MGNuVmxRRFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKamIyNTBjbTlzYkdWeVgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJuUnliMnhzWlhKZllXUmtjbVZ6Y3lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWVpQnlaVzF2ZG1WUWIyOXNYMkp2YjJ4ZlptRnNjMlZBTlFvS2NtVnRiM1psVUc5dmJGOWliMjlzWDNSeWRXVkFORG9LSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3B5WlcxdmRtVlFiMjlzWDJKdmIyeGZiV1Z5WjJWQU5qb0tJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUWdkR2hsSUc5M2JtVnlMQ0JqYjI1MGNtOXNiR1Z5TENCdmNpQjBhR1VnWjI5MlpYSnVZVzVqWlNCMGFXMWxiRzlqYXdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmFaWEp2SUdGa1pISmxjM01nWkdWMFpXTjBaV1FLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ016RWdMeThnSW1aeVlYaGZjRzl2YkhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaR1J5WlhOeklHNXZibVY0YVhOMFpXNTBDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCaWRYSjVJRE1LQ25KbGJXOTJaVkJ2YjJ4ZmQyaHBiR1ZmZEc5d1FEYzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOREVnTHk4Z0ltWnlZWGhmY0c5dmJITmZZWEp5WVhsZmJHVnVaM1JvSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJtY21GNFgzQnZiMnh6WDJGeWNtRjVYMnhsYm1kMGFDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBekNpQWdJQ0JpUGdvZ0lDQWdZbm9nY21WdGIzWmxVRzl2YkY5aFpuUmxjbDkzYUdsc1pVQXhNUW9nSUNBZ1kyRnNiSE4xWWlCZmNIVjVZVjlzYVdJdWJXVnRMbTVsZDE5emJHOTBDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhOMGIzSmxjd29nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbVp5WVhoZmNHOXZiSE5mWVhKeVlYa2lDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpZV3hzYzNWaUlGOXdkWGxoWDJ4cFlpNXRaVzB1Ym1WM1gzTnNiM1FLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZEc5eVpYTUtJQ0FnSUhOM1lYQUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkdsbklEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lHeHZZV1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTBDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaWVpQnlaVzF2ZG1WUWIyOXNYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSm1jbUY0WDNCdmIyeHpYMkZ5Y21GNUlnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHSnZlQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnY21Wd2JHRmpaVE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F2Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpWm5KaGVGOXdiMjlzYzE5aGNuSmhlU0lLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldNZ01USWdMeThnSW1aeVlYaGZjRzl2YkhOZllYSnlZWGtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENncHlaVzF2ZG1WUWIyOXNYMkZtZEdWeVgzZG9hV3hsUURFeE9nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpUZGlOVGN5T1RnZ0x5OGdiV1YwYUc5a0lDSlFiMjlzVW1WdGIzWmxaQ2hoWkdSeVpYTnpLU0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2NtVnRiM1psVUc5dmJGOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnWkdsbklESUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNUW9nSUNBZ1lpc0tJQ0FnSUdKMWNua2dNd29nSUNBZ1lpQnlaVzF2ZG1WUWIyOXNYM2RvYVd4bFgzUnZjRUEzQ2dweVpXMXZkbVZRYjI5c1gySnZiMnhmWm1Gc2MyVkFOVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlISmxiVzkyWlZCdmIyeGZZbTl2YkY5dFpYSm5aVUEyQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVjMlYwVW1Wa1pXMXdkR2x2YmtabFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZKbFpHVnRjSFJwYjI1R1pXVTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nYzJWMFVtVmtaVzF3ZEdsdmJrWmxaVjlpYjI5c1gzUnlkV1ZBTkFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnBiV1ZzYjJOclgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhScGJXVnNiMk5yWDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklITmxkRkpsWkdWdGNIUnBiMjVHWldWZlltOXZiRjkwY25WbFFEUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pqYjI1MGNtOXNiR1Z5WDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052Ym5SeWIyeHNaWEpmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpZWlCelpYUlNaV1JsYlhCMGFXOXVSbVZsWDJKdmIyeGZabUZzYzJWQU5Rb0tjMlYwVW1Wa1pXMXdkR2x2YmtabFpWOWliMjlzWDNSeWRXVkFORG9LSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3B6WlhSU1pXUmxiWEIwYVc5dVJtVmxYMkp2YjJ4ZmJXVnlaMlZBTmpvS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNRZ2RHaGxJRzkzYm1WeUxDQmpiMjUwY205c2JHVnlMQ0J2Y2lCMGFHVWdaMjkyWlhKdVlXNWpaU0IwYVcxbGJHOWphd29nSUNBZ1lubDBaV01nTWpZZ0x5OGdJbkpsWkdWdGNIUnBiMjVmWm1WbElnb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqTTJSbU5UWTFZeUF2THlCdFpYUm9iMlFnSWxKbFpHVnRjSFJwYjI1R1pXVlRaWFFvZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2MyVjBVbVZrWlcxd2RHbHZia1psWlY5aWIyOXNYMlpoYkhObFFEVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCelpYUlNaV1JsYlhCMGFXOXVSbVZsWDJKdmIyeGZiV1Z5WjJWQU5nb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG5ObGRFMXBiblJwYm1kR1pXVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSTmFXNTBhVzVuUm1WbE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2diM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSE5sZEUxcGJuUnBibWRHWldWZlltOXZiRjkwY25WbFFEUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0owYVcxbGJHOWphMTloWkdSeVpYTnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBhVzFsYkc5amExOWhaR1J5WlhOeklHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ6WlhSTmFXNTBhVzVuUm1WbFgySnZiMnhmZEhKMVpVQTBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWTI5dWRISnZiR3hsY2w5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjI1MGNtOXNiR1Z5WDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW5vZ2MyVjBUV2x1ZEdsdVowWmxaVjlpYjI5c1gyWmhiSE5sUURVS0NuTmxkRTFwYm5ScGJtZEdaV1ZmWW05dmJGOTBjblZsUURRNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvS2MyVjBUV2x1ZEdsdVowWmxaVjlpYjI5c1gyMWxjbWRsUURZNkNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElIUm9aU0J2ZDI1bGNpd2dZMjl1ZEhKdmJHeGxjaXdnYjNJZ2RHaGxJR2R2ZG1WeWJtRnVZMlVnZEdsdFpXeHZZMnNLSUNBZ0lHSjVkR1ZqSURJM0lDOHZJQ0p0YVc1MGFXNW5YMlpsWlNJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROMlkxWWpJMU5qUWdMeThnYldWMGFHOWtJQ0pOYVc1MGFXNW5SbVZsVTJWMEtIVnBiblF5TlRZcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk5sZEUxcGJuUnBibWRHWldWZlltOXZiRjltWVd4elpVQTFPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2MyVjBUV2x1ZEdsdVowWmxaVjlpYjI5c1gyMWxjbWRsUURZS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R1VrRllVM1JoWW14bFkyOXBiaTV6WlhSR2NtRjRVM1JsY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRVp5WVhoVGRHVndPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhObGRFWnlZWGhUZEdWd1gySnZiMnhmZEhKMVpVQTBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkR2x0Wld4dlkydGZZV1JrY21WemN5QmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nYzJWMFJuSmhlRk4wWlhCZlltOXZiRjkwY25WbFFEUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pqYjI1MGNtOXNiR1Z5WDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052Ym5SeWIyeHNaWEpmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpZWlCelpYUkdjbUY0VTNSbGNGOWliMjlzWDJaaGJITmxRRFVLQ25ObGRFWnlZWGhUZEdWd1gySnZiMnhmZEhKMVpVQTBPZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtDbk5sZEVaeVlYaFRkR1Z3WDJKdmIyeGZiV1Z5WjJWQU5qb0tJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUWdkR2hsSUc5M2JtVnlMQ0JqYjI1MGNtOXNiR1Z5TENCdmNpQjBhR1VnWjI5MlpYSnVZVzVqWlNCMGFXMWxiRzlqYXdvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW1aeVlYaGZjM1JsY0NJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZamhqTWpJelltSWdMeThnYldWMGFHOWtJQ0pHY21GNFUzUmxjRk5sZENoMWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHpaWFJHY21GNFUzUmxjRjlpYjI5c1gyWmhiSE5sUURVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ6WlhSR2NtRjRVM1JsY0Y5aWIyOXNYMjFsY21kbFFEWUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1elpYUlFjbWxqWlZSaGNtZGxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGQnlhV05sVkdGeVoyVjBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhObGRGQnlhV05sVkdGeVoyVjBYMkp2YjJ4ZmRISjFaVUEwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2MyVjBVSEpwWTJWVVlYSm5aWFJmWW05dmJGOTBjblZsUURRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmpiMjUwY205c2JHVnlYMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiblJ5YjJ4c1pYSmZZV1JrY21WemN5QmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmllaUJ6WlhSUWNtbGpaVlJoY21kbGRGOWliMjlzWDJaaGJITmxRRFVLQ25ObGRGQnlhV05sVkdGeVoyVjBYMkp2YjJ4ZmRISjFaVUEwT2dvZ0lDQWdhVzUwWTE4eUlDOHZJREVLQ25ObGRGQnlhV05sVkdGeVoyVjBYMkp2YjJ4ZmJXVnlaMlZBTmpvS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNRZ2RHaGxJRzkzYm1WeUxDQmpiMjUwY205c2JHVnlMQ0J2Y2lCMGFHVWdaMjkyWlhKdVlXNWpaU0IwYVcxbGJHOWphd29nSUNBZ1lubDBaV01nTVRVZ0x5OGdJbkJ5YVdObFgzUmhjbWRsZENJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVEZtWkdNeVpqSWdMeThnYldWMGFHOWtJQ0pRY21salpWUmhjbWRsZEZObGRDaDFhVzUwTWpVMktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B6WlhSUWNtbGpaVlJoY21kbGRGOWliMjlzWDJaaGJITmxRRFU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnpaWFJRY21salpWUmhjbWRsZEY5aWIyOXNYMjFsY21kbFFEWUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1elpYUlNaV1p5WlhOb1EyOXZiR1J2ZDI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJTWldaeVpYTm9RMjl2YkdSdmQyNDZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nYzJWMFVtVm1jbVZ6YUVOdmIyeGtiM2R1WDJKdmIyeGZkSEoxWlVBMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlkR2x0Wld4dlkydGZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2djMlYwVW1WbWNtVnphRU52YjJ4a2IzZHVYMkp2YjJ4ZmRISjFaVUEwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVkyOXVkSEp2Ykd4bGNsOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCamIyNTBjbTlzYkdWeVgyRmtaSEpsYzNNZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lub2djMlYwVW1WbWNtVnphRU52YjJ4a2IzZHVYMkp2YjJ4ZlptRnNjMlZBTlFvS2MyVjBVbVZtY21WemFFTnZiMnhrYjNkdVgySnZiMnhmZEhKMVpVQTBPZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtDbk5sZEZKbFpuSmxjMmhEYjI5c1pHOTNibDlpYjI5c1gyMWxjbWRsUURZNkNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElIUm9aU0J2ZDI1bGNpd2dZMjl1ZEhKdmJHeGxjaXdnYjNJZ2RHaGxJR2R2ZG1WeWJtRnVZMlVnZEdsdFpXeHZZMnNLSUNBZ0lHSjVkR1ZqSURJeklDOHZJQ0p5WldaeVpYTm9YMk52YjJ4a2IzZHVJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE4yRXpOamc1TWlBdkx5QnRaWFJvYjJRZ0lsSmxabkpsYzJoRGIyOXNaRzkzYmxObGRDaDFhVzUwTWpVMktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B6WlhSU1pXWnlaWE5vUTI5dmJHUnZkMjVmWW05dmJGOW1ZV3h6WlVBMU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYzJWMFVtVm1jbVZ6YUVOdmIyeGtiM2R1WDJKdmIyeGZiV1Z5WjJWQU5nb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG5ObGRFWllVMEZrWkhKbGMzTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSR1dGTkJaR1J5WlhOek9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUc5M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCelpYUkdXRk5CWkdSeVpYTnpYMkp2YjJ4ZmRISjFaVUEwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2MyVjBSbGhUUVdSa2NtVnpjMTlpYjI5c1gzUnlkV1ZBTkFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiblJ5YjJ4c1pYSmZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1kyOXVkSEp2Ykd4bGNsOWhaR1J5WlhOeklHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSjZJSE5sZEVaWVUwRmtaSEpsYzNOZlltOXZiRjltWVd4elpVQTFDZ3B6WlhSR1dGTkJaR1J5WlhOelgySnZiMnhmZEhKMVpVQTBPZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtDbk5sZEVaWVUwRmtaSEpsYzNOZlltOXZiRjl0WlhKblpVQTJPZ29nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0IwYUdVZ2IzZHVaWElzSUdOdmJuUnliMnhzWlhJc0lHOXlJSFJvWlNCbmIzWmxjbTVoYm1ObElIUnBiV1ZzYjJOckNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRnBsY204Z1lXUmtjbVZ6Y3lCa1pYUmxZM1JsWkFvZ0lDQWdZbmwwWldNZ016WWdMeThnSW1aNGMxOWhaR1J5WlhOeklnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lPV0UwT0RReU1TQXZMeUJ0WlhSb2IyUWdJa1pZVTBGa1pISmxjM05UWlhRb1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjMlYwUmxoVFFXUmtjbVZ6YzE5aWIyOXNYMlpoYkhObFFEVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCelpYUkdXRk5CWkdSeVpYTnpYMkp2YjJ4ZmJXVnlaMlZBTmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaU1FWaFRkR0ZpYkdWamIybHVMbk5sZEVWVVNGVlRSRTl5WVdOc1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEVWVVNGVlRSRTl5WVdOc1pUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdmQyNWxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2MyVjBSVlJJVlZORVQzSmhZMnhsWDJKdmIyeGZkSEoxWlVBMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlkR2x0Wld4dlkydGZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2djMlYwUlZSSVZWTkVUM0poWTJ4bFgySnZiMnhmZEhKMVpVQTBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWTI5dWRISnZiR3hsY2w5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjI1MGNtOXNiR1Z5WDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW5vZ2MyVjBSVlJJVlZORVQzSmhZMnhsWDJKdmIyeGZabUZzYzJWQU5Rb0tjMlYwUlZSSVZWTkVUM0poWTJ4bFgySnZiMnhmZEhKMVpVQTBPZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtDbk5sZEVWVVNGVlRSRTl5WVdOc1pWOWliMjlzWDIxbGNtZGxRRFk2Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUhSb1pTQnZkMjVsY2l3Z1kyOXVkSEp2Ykd4bGNpd2diM0lnZEdobElHZHZkbVZ5Ym1GdVkyVWdkR2x0Wld4dlkyc0tJQ0FnSUdSMWNHNGdNZ29nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnV21WeWJ5QmhaR1J5WlhOeklHUmxkR1ZqZEdWa0NpQWdJQ0JpZVhSbFl5QXpPU0F2THlBaVpYUm9YM1Z6WkY5amIyNXpkVzFsY2w5aFpHUnlaWE56SWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXlNQ0F2THlBaVpYUm9YM1Z6WkY5d2NtbGpaWElpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR1ZqWVdRNFpEQWdMeThnYldWMGFHOWtJQ0puWlhSRVpXTnBiV0ZzY3lncGRXbHVkRFkwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWXlBeU1TQXZMeUFpWlhSb1gzVnpaRjl3Y21salpYSmZaR1ZqYVcxaGJITWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPV1ZoWXpVMFlUVWdMeThnYldWMGFHOWtJQ0pGVkVoVlUwUlBjbUZqYkdWVFpYUW9ZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYzJWMFJWUklWVk5FVDNKaFkyeGxYMkp2YjJ4ZlptRnNjMlZBTlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSE5sZEVWVVNGVlRSRTl5WVdOc1pWOWliMjlzWDIxbGNtZGxRRFlLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHVWtGWVUzUmhZbXhsWTI5cGJpNXpaWFJVYVcxbGJHOWphMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGUnBiV1ZzYjJOck9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUc5M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCelpYUlVhVzFsYkc5amExOWliMjlzWDNSeWRXVkFOQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5ScGJXVnNiMk5yWDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJwYldWc2IyTnJYMkZrWkhKbGMzTWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhObGRGUnBiV1ZzYjJOclgySnZiMnhmZEhKMVpVQTBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWTI5dWRISnZiR3hsY2w5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjI1MGNtOXNiR1Z5WDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW5vZ2MyVjBWR2x0Wld4dlkydGZZbTl2YkY5bVlXeHpaVUExQ2dwelpYUlVhVzFsYkc5amExOWliMjlzWDNSeWRXVkFORG9LSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3B6WlhSVWFXMWxiRzlqYTE5aWIyOXNYMjFsY21kbFFEWTZDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJSFJvWlNCdmQyNWxjaXdnWTI5dWRISnZiR3hsY2l3Z2IzSWdkR2hsSUdkdmRtVnlibUZ1WTJVZ2RHbHRaV3h2WTJzS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdXbVZ5YnlCaFpHUnlaWE56SUdSbGRHVmpkR1ZrQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0owYVcxbGJHOWphMTloWkdSeVpYTnpJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrT1ROa1lUUmtPU0F2THlCdFpYUm9iMlFnSWxScGJXVnNiMk5yVTJWMEtHRmtaSEpsYzNNcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk5sZEZScGJXVnNiMk5yWDJKdmIyeGZabUZzYzJWQU5Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUhObGRGUnBiV1ZzYjJOclgySnZiMnhmYldWeVoyVkFOZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxuTmxkRU52Ym5SeWIyeHNaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkRiMjUwY205c2JHVnlPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQnpaWFJEYjI1MGNtOXNiR1Z5WDJKdmIyeGZkSEoxWlVBMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlkR2x0Wld4dlkydGZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2djMlYwUTI5dWRISnZiR3hsY2w5aWIyOXNYM1J5ZFdWQU5Bb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU52Ym5SeWIyeHNaWEpmWVdSa2NtVnpjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjl1ZEhKdmJHeGxjbDloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0o2SUhObGRFTnZiblJ5YjJ4c1pYSmZZbTl2YkY5bVlXeHpaVUExQ2dwelpYUkRiMjUwY205c2JHVnlYMkp2YjJ4ZmRISjFaVUEwT2dvZ0lDQWdhVzUwWTE4eUlDOHZJREVLQ25ObGRFTnZiblJ5YjJ4c1pYSmZZbTl2YkY5dFpYSm5aVUEyT2dvZ0lDQWdZWE56WlhKMElDOHZJRTV2ZENCMGFHVWdiM2R1WlhJc0lHTnZiblJ5YjJ4c1pYSXNJRzl5SUhSb1pTQm5iM1psY201aGJtTmxJSFJwYldWc2IyTnJDaUFnSUNCa2RYQnVJRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZwbGNtOGdZV1JrY21WemN5QmtaWFJsWTNSbFpBb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVkyOXVkSEp2Ykd4bGNsOWhaR1J5WlhOeklnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGhOakF5TVRJMk15QXZMeUJ0WlhSb2IyUWdJa052Ym5SeWIyeHNaWEpUWlhRb1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjMlYwUTI5dWRISnZiR3hsY2w5aWIyOXNYMlpoYkhObFFEVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCelpYUkRiMjUwY205c2JHVnlYMkp2YjJ4ZmJXVnlaMlZBTmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaU1FWaFRkR0ZpYkdWamIybHVMbk5sZEZCeWFXTmxRbUZ1WkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRkJ5YVdObFFtRnVaRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUc5M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCelpYUlFjbWxqWlVKaGJtUmZZbTl2YkY5MGNuVmxRRFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGFXMWxiRzlqYTE5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYVcxbGJHOWphMTloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCelpYUlFjbWxqWlVKaGJtUmZZbTl2YkY5MGNuVmxRRFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKamIyNTBjbTlzYkdWeVgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJuUnliMnhzWlhKZllXUmtjbVZ6Y3lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWVpQnpaWFJRY21salpVSmhibVJmWW05dmJGOW1ZV3h6WlVBMUNncHpaWFJRY21salpVSmhibVJmWW05dmJGOTBjblZsUURRNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvS2MyVjBVSEpwWTJWQ1lXNWtYMkp2YjJ4ZmJXVnlaMlZBTmpvS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNRZ2RHaGxJRzkzYm1WeUxDQmpiMjUwY205c2JHVnlMQ0J2Y2lCMGFHVWdaMjkyWlhKdVlXNWpaU0IwYVcxbGJHOWphd29nSUNBZ1lubDBaV01nTVRZZ0x5OGdJbkJ5YVdObFgySmhibVFpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWTJaRFptTlRrMUlDOHZJRzFsZEdodlpDQWlVSEpwWTJWQ1lXNWtVMlYwS0hWcGJuUXlOVFlwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuTmxkRkJ5YVdObFFtRnVaRjlpYjI5c1gyWmhiSE5sUURVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ6WlhSUWNtbGpaVUpoYm1SZlltOXZiRjl0WlhKblpVQTJDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dWMyVjBSbEpCV0VWMGFFOXlZV05zWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRVpTUVZoRmRHaFBjbUZqYkdVNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nYzJWMFJsSkJXRVYwYUU5eVlXTnNaVjlpYjI5c1gzUnlkV1ZBTkFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnBiV1ZzYjJOclgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhScGJXVnNiMk5yWDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklITmxkRVpTUVZoRmRHaFBjbUZqYkdWZlltOXZiRjkwY25WbFFEUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pqYjI1MGNtOXNiR1Z5WDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052Ym5SeWIyeHNaWEpmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpZWlCelpYUkdVa0ZZUlhSb1QzSmhZMnhsWDJKdmIyeGZabUZzYzJWQU5Rb0tjMlYwUmxKQldFVjBhRTl5WVdOc1pWOWliMjlzWDNSeWRXVkFORG9LSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3B6WlhSR1VrRllSWFJvVDNKaFkyeGxYMkp2YjJ4ZmJXVnlaMlZBTmpvS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNRZ2RHaGxJRzkzYm1WeUxDQmpiMjUwY205c2JHVnlMQ0J2Y2lCMGFHVWdaMjkyWlhKdVlXNWpaU0IwYVcxbGJHOWphd29nSUNBZ1pHbG5JREVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNBaFBRb2dJQ0FnWW5vZ2MyVjBSbEpCV0VWMGFFOXlZV05zWlY5aWIyOXNYMlpoYkhObFFEa0tJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ6WlhSR1VrRllSWFJvVDNKaFkyeGxYMkp2YjJ4ZlptRnNjMlZBT1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLQ25ObGRFWlNRVmhGZEdoUGNtRmpiR1ZmWW05dmJGOXRaWEpuWlVBeE1Eb0tJQ0FnSUdGemMyVnlkQ0F2THlCYVpYSnZJR0ZrWkhKbGMzTWdaR1YwWldOMFpXUUtJQ0FnSUdKNWRHVmpJRE0zSUM4dklDSm1jbUY0WDJWMGFGOXZjbUZqYkdWZllXUmtjbVZ6Y3lJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF6TWlBdkx5QWlabkpoZUVWMGFFOXlZV05zWlNJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0luZGxkR2hmWVdSa2NtVnpjeUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWmhORFF5TXpkbUlDOHZJRzFsZEdodlpDQWlSbEpCV0VWVVNFOXlZV05zWlZObGRDaGhaR1J5WlhOekxHRmtaSEpsYzNNcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk5sZEVaU1FWaEZkR2hQY21GamJHVmZZbTl2YkY5bVlXeHpaVUE1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdjMlYwUmxKQldFVjBhRTl5WVdOc1pWOWliMjlzWDIxbGNtZGxRREV3Q2dwelpYUkdVa0ZZUlhSb1QzSmhZMnhsWDJKdmIyeGZabUZzYzJWQU5Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUhObGRFWlNRVmhGZEdoUGNtRmpiR1ZmWW05dmJGOXRaWEpuWlVBMkNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJsSkJXRk4wWVdKc1pXTnZhVzR1YzJWMFJsaFRSWFJvVDNKaFkyeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFJsaFRSWFJvVDNKaFkyeGxPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2IzZHVaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklITmxkRVpZVTBWMGFFOXlZV05zWlY5aWIyOXNYM1J5ZFdWQU5Bb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblJwYldWc2IyTnJYMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnBiV1ZzYjJOclgyRmtaSEpsYzNNZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSE5sZEVaWVUwVjBhRTl5WVdOc1pWOWliMjlzWDNSeWRXVkFOQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1OdmJuUnliMnhzWlhKZllXUmtjbVZ6Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWTI5dWRISnZiR3hsY2w5aFpHUnlaWE56SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKNklITmxkRVpZVTBWMGFFOXlZV05zWlY5aWIyOXNYMlpoYkhObFFEVUtDbk5sZEVaWVUwVjBhRTl5WVdOc1pWOWliMjlzWDNSeWRXVkFORG9LSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3B6WlhSR1dGTkZkR2hQY21GamJHVmZZbTl2YkY5dFpYSm5aVUEyT2dvZ0lDQWdZWE56WlhKMElDOHZJRTV2ZENCMGFHVWdiM2R1WlhJc0lHTnZiblJ5YjJ4c1pYSXNJRzl5SUhSb1pTQm5iM1psY201aGJtTmxJSFJwYldWc2IyTnJDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUNFOUNpQWdJQ0JpZWlCelpYUkdXRk5GZEdoUGNtRmpiR1ZmWW05dmJGOW1ZV3h6WlVBNUNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQWhQUW9nSUNBZ1lub2djMlYwUmxoVFJYUm9UM0poWTJ4bFgySnZiMnhmWm1Gc2MyVkFPUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtDbk5sZEVaWVUwVjBhRTl5WVdOc1pWOWliMjlzWDIxbGNtZGxRREV3T2dvZ0lDQWdZWE56WlhKMElDOHZJRnBsY204Z1lXUmtjbVZ6Y3lCa1pYUmxZM1JsWkFvZ0lDQWdZbmwwWldNZ016Z2dMeThnSW1aNGMxOWxkR2hmYjNKaFkyeGxYMkZrWkhKbGMzTWlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ016TWdMeThnSW1aNGMwVjBhRTl5WVdOc1pTSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJbmRsZEdoZllXUmtjbVZ6Y3lJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGt4TlRrek1XWXhJQzh2SUcxbGRHaHZaQ0FpUmxoVFJYUm9UM0poWTJ4bFUyVjBLR0ZrWkhKbGMzTXNZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYzJWMFJsaFRSWFJvVDNKaFkyeGxYMkp2YjJ4ZlptRnNjMlZBT1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSE5sZEVaWVUwVjBhRTl5WVdOc1pWOWliMjlzWDIxbGNtZGxRREV3Q2dwelpYUkdXRk5GZEdoUGNtRmpiR1ZmWW05dmJGOW1ZV3h6WlVBMU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYzJWMFJsaFRSWFJvVDNKaFkyeGxYMkp2YjJ4ZmJXVnlaMlZBTmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaU1FWaFRkR0ZpYkdWamIybHVMblJ2WjJkc1pVTnZiR3hoZEdWeVlXeFNZWFJwYjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnZaMmRzWlVOdmJHeGhkR1Z5WVd4U1lYUnBiem9LSUNBZ0lHSjVkR1ZqSURReklDOHZJREI0WWpJMU5EQXlOREU0WVdRMU5UVXdNVE15TVRBek5qVmhOREl5WmpsbU1USXdObUl5WkdRd01EY3hPVGs1T0dSaU1EWm1PR0V4Wm1KbE1ERTBOalF4WWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1b1lYTlNiMnhsQ2lBZ0lDQmhjM05sY25RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU5DQXZMeUFpWTI5c2JHRjBaWEpoYkY5eVlYUnBiMTl3WVhWelpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiR3hoZEdWeVlXeGZjbUYwYVc5ZmNHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWW5sMFpXTWdNalFnTHk4Z0ltTnZiR3hoZEdWeVlXeGZjbUYwYVc5ZmNHRjFjMlZrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QTBOaUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdZNE9Ea3laVFpqSUM4dklHMWxkR2h2WkNBaVEyOXNiR0YwWlhKaGJGSmhkR2x2Vkc5bloyeGxaQ2hpYjI5c0tTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dWJtOXRhVzVoZEdWT1pYZFBkMjVsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtNXZiV2x1WVhSbFRtVjNUM2R1WlhJNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RHaGxJR052Ym5SeVlXTjBJRzkzYm1WeUlHMWhlU0J3WlhKbWIzSnRJSFJvYVhNZ1lXTjBhVzl1Q2lBZ0lDQmllWFJsWXlBeE9TQXZMeUFpYm05dGFXNWhkR1ZrVDNkdVpYSWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0l5T0RFeU1UaGhJQzh2SUcxbGRHaHZaQ0FpVDNkdVpYSk9iMjFwYm1GMFpXUW9ZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxtRmpZMlZ3ZEU5M2JtVnljMmhwY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmpZMlZ3ZEU5M2JtVnljMmhwY0RvS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QWlibTl0YVc1aGRHVmtUM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUc1dmJXbHVZWFJsWkU5M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnV1c5MUlHMTFjM1FnWW1VZ2JtOXRhVzVoZEdWa0lHSmxabTl5WlNCNWIzVWdZMkZ1SUdGalkyVndkQ0J2ZDI1bGNuTm9hWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYjNkdVpYSWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtNbU5qWmpJNU1DQXZMeUJ0WlhSb2IyUWdJazkzYm1WeVEyaGhibWRsWkNoaFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR0o1ZEdWalh6TWdMeThnSW05M2JtVnlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURFNUlDOHZJQ0p1YjIxcGJtRjBaV1JQZDI1bGNpSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG1oaGMxSnZiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwb1lYTlNiMnhsT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dWFHRnpVbTlzWlFvZ0lDQWdZbmwwWldNZ05EWWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVaMlYwVW05c1pVMWxiV0psY2tOdmRXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFVtOXNaVTFsYldKbGNrTnZkVzUwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKZmNtOXNaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dNREl5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESXdNREEwTURBd05qQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JqWVd4c2MzVmlJRVZ1ZFcxbGNtRmliR1ZUWlhRdWJHVnVaM1JvQ2lBZ0lDQndiM0FLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVoyVjBVbTlzWlUxbGJXSmxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGSnZiR1ZOWlcxaVpYSTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdjM2RoY0FvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaVgzSnZiR1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNREF5TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNREF3TkRBd01EWXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJGYm5WdFpYSmhZbXhsVTJWMExtRjBDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1blpYUlNiMnhsUVdSdGFXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSU2IyeGxRV1J0YVc0NkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0lsOXliMnhsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlREF3TWpJd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNakF3TURRd01EQTJNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXlJRE15Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVaM0poYm5SU2IyeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjNKaGJuUlNiMnhsT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVozSmhiblJTYjJ4bENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJsSkJXRk4wWVdKc1pXTnZhVzR1Y21WMmIydGxVbTlzWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxkbTlyWlZKdmJHVTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnWkdsbklERUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbDl5YjJ4bGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURBd01qSXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWpBd01EUXdNREEyTURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F5SURNeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxtaGhjMUp2YkdVS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTkRiMjUwY205c09pQnpaVzVrWlhJZ2JYVnpkQ0JpWlNCaGJpQmhaRzFwYmlCMGJ5QnlaWFp2YTJVS0lDQWdJR05oYkd4emRXSWdYM0psZG05clpWSnZiR1VLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHVWtGWVUzUmhZbXhsWTI5cGJpNXlaVzV2ZFc1alpWSnZiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXNXZkVzVqWlZKdmJHVTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnWkhWd0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6YzBOdmJuUnliMnc2SUdOaGJpQnZibXg1SUhKbGJtOTFibU5sSUhKdmJHVnpJR1p2Y2lCelpXeG1DaUFnSUNCallXeHNjM1ZpSUY5eVpYWnZhMlZTYjJ4bENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJsSkJXRk4wWVdKc1pXTnZhVzR1ZEc5MFlXeFRkWEJ3YkhsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBiM1JoYkZOMWNIQnNlVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSmZkRzkwWVd4VGRYQndiSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjkwYjNSaGJGTjFjSEJzZVNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVltRnNZVzVqWlU5bVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbUZzWVc1alpVOW1PZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0pmWW1Gc1lXNWpaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHVWtGWVUzUmhZbXhsWTI5cGJpNTBjbUZ1YzJabGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ5WVc1elptVnlPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdYM1J5WVc1elptVnlDaUFnSUNCaWVYUmxZeUF5TlNBdkx5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxtRnNiRzkzWVc1alpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZzYkc5M1lXNWpaVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG1Gc2JHOTNZVzVqWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHVWtGWVUzUmhZbXhsWTI5cGJpNWhjSEJ5YjNabFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWEJ3Y205MlpUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOWhjSEJ5YjNabENpQWdJQ0JpZVhSbFl5QXlOU0F2THlBd2VERTFNV1kzWXpjMU9EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG5SeVlXNXpabVZ5Um5KdmJWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ5WVc1elptVnlSbkp2YlRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRjkwY21GdWMyWmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklESUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QWlYMkZzYkc5M1lXNWpaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNRekl3T2lCMGNtRnVjMlpsY2lCaGJXOTFiblFnWlhoalpXVmtjeUJoYkd4dmQyRnVZMlVpQ2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMbE5oWm1WTllYUm9Mbk4xWWlnektRb2dJQ0FnWTJGc2JITjFZaUJmWVhCd2NtOTJaUW9nSUNBZ1lubDBaV01nTWpVZ0x5OGdNSGd4TlRGbU4yTTNOVGd3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHVWtGWVUzUmhZbXhsWTI5cGJpNXBibU55WldGelpVRnNiRzkzWVc1alpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx1WTNKbFlYTmxRV3hzYjNkaGJtTmxPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBaVgyRnNiRzkzWVc1alpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbUZrWkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJmWVhCd2NtOTJaUW9nSUNBZ1lubDBaV01nTWpVZ0x5OGdNSGd4TlRGbU4yTTNOVGd3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHVWtGWVUzUmhZbXhsWTI5cGJpNWtaV055WldGelpVRnNiRzkzWVc1alpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsWTNKbFlYTmxRV3hzYjNkaGJtTmxPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBaVgyRnNiRzkzWVc1alpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWU1F6SXdPaUJrWldOeVpXRnpaV1FnWVd4c2IzZGhibU5sSUdKbGJHOTNJSHBsY204aUNpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGxOaFptVk5ZWFJvTG5OMVlpZ3pLUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQmZZWEJ3Y205MlpRb2dJQ0FnWW5sMFpXTWdNalVnTHk4Z01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1aWRYSnVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW5WeWJqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCZlluVnliZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxtSjFjbTVHY205dFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZblZ5YmtaeWIyMDZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdaR2xuSURFS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVlXeHNiM2RoYm1ObENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW5sMFpXTWdORGdnTHk4Z0lrVlNRekl3T2lCaWRYSnVJR0Z0YjNWdWRDQmxlR05sWldSeklHRnNiRzkzWVc1alpTSUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVUyRm1aVTFoZEdndWMzVmlLRE1wQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRjloY0hCeWIzWmxDaUFnSUNCallXeHNjM1ZpSUY5aWRYSnVDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dWMzbHRZbTlzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MzbHRZbTlzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURNMElDOHZJQ0p6ZVcxaWIyd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITjViV0p2YkNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dWJtRnRaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q201aGJXVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNelVnTHk4Z0ltNWhiV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzVoYldVZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxtTnlaV0YwYjNKZllXUmtjbVZ6YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwYjNKZllXUmtjbVZ6Y3pvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU1pQXZMeUFpWTNKbFlYUnZjbDloWkdSeVpYTnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmpjbVZoZEc5eVgyRmtaSEpsYzNNZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVkR2x0Wld4dlkydGZZV1JrY21WemMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJwYldWc2IyTnJYMkZrWkhKbGMzTTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1amIyNTBjbTlzYkdWeVgyRmtaSEpsYzNOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMjUwY205c2JHVnlYMkZrWkhKbGMzTTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVkyOXVkSEp2Ykd4bGNsOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCamIyNTBjbTlzYkdWeVgyRmtaSEpsYzNNZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVabmh6WDJGa1pISmxjM05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbWVITmZZV1JrY21WemN6b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXpOaUF2THlBaVpuaHpYMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHWjRjMTloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG1aeVlYaGZaWFJvWDI5eVlXTnNaVjloWkdSeVpYTnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWm5KaGVGOWxkR2hmYjNKaFkyeGxYMkZrWkhKbGMzTTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNemNnTHk4Z0ltWnlZWGhmWlhSb1gyOXlZV05zWlY5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJtY21GNFgyVjBhRjl2Y21GamJHVmZZV1JrY21WemN5QmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R1VrRllVM1JoWW14bFkyOXBiaTVtZUhOZlpYUm9YMjl5WVdOc1pWOWhaR1J5WlhOelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tabmh6WDJWMGFGOXZjbUZqYkdWZllXUmtjbVZ6Y3pvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBek9DQXZMeUFpWm5oelgyVjBhRjl2Y21GamJHVmZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1puaHpYMlYwYUY5dmNtRmpiR1ZmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1M1pYUm9YMkZrWkhKbGMzTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzWlhSb1gyRmtaSEpsYzNNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UUWdMeThnSW5kbGRHaGZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2QyVjBhRjloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG1WMGFGOTFjMlJmWTI5dWMzVnRaWEpmWVdSa2NtVnpjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WMGFGOTFjMlJmWTI5dWMzVnRaWEpmWVdSa2NtVnpjem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF6T1NBdkx5QWlaWFJvWDNWelpGOWpiMjV6ZFcxbGNsOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCbGRHaGZkWE5rWDJOdmJuTjFiV1Z5WDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVpuSmhlRjl3YjI5c2MxOWhjbkpoZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtWnlZWGhmY0c5dmJITmZZWEp5WVhrNkNpQWdJQ0JqWVd4c2MzVmlJRjl3ZFhsaFgyeHBZaTV0WlcwdWJtVjNYM05zYjNRS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdjM1J2Y21WekNpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaVpuSmhlRjl3YjI5c2MxOWhjbkpoZVNJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOaGJHeHpkV0lnWDNCMWVXRmZiR2xpTG0xbGJTNXVaWGRmYzJ4dmRBb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjBiM0psY3dvZ0lDQWdjM2RoY0FvZ0lDQWdjMlZzWldOMENpQWdJQ0JzYjJGa2N3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxtZHNiMkpoYkY5amIyeHNZWFJsY21Gc1gzSmhkR2x2VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyeHZZbUZzWDJOdmJHeGhkR1Z5WVd4ZmNtRjBhVzg2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlaMnh2WW1Gc1gyTnZiR3hoZEdWeVlXeGZjbUYwYVc4aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdkc2IySmhiRjlqYjJ4c1lYUmxjbUZzWDNKaGRHbHZJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R1VrRllVM1JoWW14bFkyOXBiaTV5WldSbGJYQjBhVzl1WDJabFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWkdWdGNIUnBiMjVmWm1WbE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklESTJJQzh2SUNKeVpXUmxiWEIwYVc5dVgyWmxaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djbVZrWlcxd2RHbHZibDltWldVZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxtMXBiblJwYm1kZlptVmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldsdWRHbHVaMTltWldVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01qY2dMeThnSW0xcGJuUnBibWRmWm1WbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdGFXNTBhVzVuWDJabFpTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVabkpoZUY5emRHVndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWm5KaGVGOXpkR1Z3T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0ptY21GNFgzTjBaWEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR1p5WVhoZmMzUmxjQ0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJsSkJXRk4wWVdKc1pXTnZhVzR1Y21WbWNtVnphRjlqYjI5c1pHOTNibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFpuSmxjMmhmWTI5dmJHUnZkMjQ2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWpNZ0x5OGdJbkpsWm5KbGMyaGZZMjl2YkdSdmQyNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklISmxabkpsYzJoZlkyOXZiR1J2ZDI0Z1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxuQnlhV05sWDNSaGNtZGxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CeWFXTmxYM1JoY21kbGREb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaWNISnBZMlZmZEdGeVoyVjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QndjbWxqWlY5MFlYSm5aWFFnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG5CeWFXTmxYMkpoYm1SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdjbWxqWlY5aVlXNWtPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUySUM4dklDSndjbWxqWlY5aVlXNWtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QndjbWxqWlY5aVlXNWtJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R1VrRllVM1JoWW14bFkyOXBiaTVFUlVaQlZVeFVYMEZFVFVsT1gwRkVSRkpGVTFOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncEVSVVpCVlV4VVgwRkVUVWxPWDBGRVJGSkZVMU02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkRBZ0x5OGdJa1JGUmtGVlRGUmZRVVJOU1U1ZlFVUkVVa1ZUVXlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUkVWR1FWVk1WRjlCUkUxSlRsOUJSRVJTUlZOVElHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaU1FWaFRkR0ZpYkdWamIybHVMbU52Ykd4aGRHVnlZV3hmY21GMGFXOWZjR0YxYzJWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMjlzYkdGMFpYSmhiRjl5WVhScGIxOXdZWFZ6WldRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01qUWdMeThnSW1OdmJHeGhkR1Z5WVd4ZmNtRjBhVzlmY0dGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmpiMnhzWVhSbGNtRnNYM0poZEdsdlgzQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqSURRMklDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxteGhjM1JmWTJGc2JGOTBhVzFsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JHRnpkRjlqWVd4c1gzUnBiV1U2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWpnZ0x5OGdJbXhoYzNSZlkyRnNiRjkwYVcxbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCc1lYTjBYMk5oYkd4ZmRHbHRaU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJsSkJXRk4wWVdKc1pXTnZhVzR1YjNkdVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2ZDI1bGNqb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2diM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVibTl0YVc1aGRHVmtUM2R1WlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHViMjFwYm1GMFpXUlBkMjVsY2pvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE9TQXZMeUFpYm05dGFXNWhkR1ZrVDNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHNXZiV2x1WVhSbFpFOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxtOXlZV05zWlY5d2NtbGpaU2hqYUc5cFkyVTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbTl5WVdOc1pWOXdjbWxqWlRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURJd0lDOHZJQ0psZEdoZmRYTmtYM0J5YVdObGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1pYUm9YM1Z6WkY5d2NtbGpaWElnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUEwTkNBdkx5QnRaWFJvYjJRZ0ltZGxkRXhoZEdWemRGQnlhV05sS0NsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1ERUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR2wwYjJJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU1TQXZMeUFpWlhSb1gzVnpaRjl3Y21salpYSmZaR1ZqYVcxaGJITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHVjBhRjkxYzJSZmNISnBZMlZ5WDJSbFkybHRZV3h6SUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29LYjNKaFkyeGxYM0J5YVdObFgzZG9hV3hsWDNSdmNFQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJK0NpQWdJQ0JpZWlCdmNtRmpiR1ZmY0hKcFkyVmZZV1owWlhKZmQyaHBiR1ZBTmdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TVFvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lub2diM0poWTJ4bFgzQnlhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JpS2dvZ0lDQWdabkpoYldWZlluVnllU0F5Q2dwdmNtRmpiR1ZmY0hKcFkyVmZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR0o1ZEdWaklEUTFJQzh2SURCNE1ESUtJQ0FnSUdJdkNpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHSXFDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUdJZ2IzSmhZMnhsWDNCeWFXTmxYM2RvYVd4bFgzUnZjRUF5Q2dwdmNtRmpiR1ZmY0hKcFkyVmZZV1owWlhKZmQyaHBiR1ZBTmpvS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXRkV3dLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1ScGRnb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0p1ZWlCdmNtRmpiR1ZmY0hKcFkyVmZaV3h6WlY5aWIyUjVRRGtLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaWQyVjBhRjloWkdSeVpYTnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjNaWFJvWDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNeklnTHk4Z0ltWnlZWGhGZEdoUGNtRmpiR1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR1p5WVhoRmRHaFBjbUZqYkdVZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBME9TQXZMeUJ0WlhSb2IyUWdJbU52Ym5OMWJIUW9ZV1JrY21WemN5eDFhVzUwTWpVMktYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLQ205eVlXTnNaVjl3Y21salpWOWhablJsY2w5cFpsOWxiSE5sUURFME9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtMTFiQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3B2Y21GamJHVmZjSEpwWTJWZlpXeHpaVjlpYjJSNVFEazZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWxPVmtGTVNVUWdVRkpKUTBVZ1EwaFBTVU5GTGlCT1pXVmtjeUIwYnlCaVpTQmxhWFJvWlhJZ01DQW9SbEpCV0NrZ2IzSWdNU0FvUmxoVEtRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0ozWlhSb1gyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhkbGRHaGZZV1JrY21WemN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBek15QXZMeUFpWm5oelJYUm9UM0poWTJ4bElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCbWVITkZkR2hQY21GamJHVWdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QTBPU0F2THlCdFpYUm9iMlFnSW1OdmJuTjFiSFFvWVdSa2NtVnpjeXgxYVc1ME1qVTJLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR0lnYjNKaFkyeGxYM0J5YVdObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R1VrRllVM1JoWW14bFkyOXBiaTVuYkc5aVlXeERiMnhzWVhSbGNtRnNWbUZzZFdVb0tTQXRQaUJpZVhSbGN6b0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVaMnh2WW1Gc1EyOXNiR0YwWlhKaGJGWmhiSFZsT2dvZ0lDQWdjSEp2ZEc4Z01DQXhDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0Nnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHVWtGWVUzUmhZbXhsWTI5cGJpNW5iRzlpWVd4RGIyeHNZWFJsY21Gc1ZtRnNkV1ZmZDJocGJHVmZkRzl3UURFNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05ERWdMeThnSW1aeVlYaGZjRzl2YkhOZllYSnlZWGxmYkdWdVozUm9JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qm1jbUY0WDNCdmIyeHpYMkZ5Y21GNVgyeGxibWQwYUNCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaVBnb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVoyeHZZbUZzUTI5c2JHRjBaWEpoYkZaaGJIVmxYMkZtZEdWeVgzZG9hV3hsUURZS0lDQWdJR05oYkd4emRXSWdYM0IxZVdGZmJHbGlMbTFsYlM1dVpYZGZjMnh2ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQnpkRzl5WlhNS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKbWNtRjRYM0J2YjJ4elgyRnljbUY1SWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTJGc2JITjFZaUJmY0hWNVlWOXNhV0l1YldWdExtNWxkMTl6Ykc5MENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzUnZjbVZ6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNiMkZrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0FoUFFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJsSkJXRk4wWVdKc1pXTnZhVzR1WjJ4dlltRnNRMjlzYkdGMFpYSmhiRlpoYkhWbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1kyRnNiSE4xWWlCZmNIVjVZVjlzYVdJdWJXVnRMbTVsZDE5emJHOTBDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhOMGIzSmxjd29nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbVp5WVhoZmNHOXZiSE5mWVhKeVlYa2lDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpZV3hzYzNWaUlGOXdkWGxoWDJ4cFlpNXRaVzB1Ym1WM1gzTnNiM1FLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZEc5eVpYTUtJQ0FnSUhOM1lYQUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2JHOWhaSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaakZpTjJWa1pEZ2dMeThnYldWMGFHOWtJQ0pqYjJ4c1lYUkViMnhzWVhKQ1lXeGhibU5sS0NsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1aFpHUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVaMnh2WW1Gc1EyOXNiR0YwWlhKaGJGWmhiSFZsWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREVLSUNBZ0lHSXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVoyeHZZbUZzUTI5c2JHRjBaWEpoYkZaaGJIVmxYM2RvYVd4bFgzUnZjRUF4Q2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1bmJHOWlZV3hEYjJ4c1lYUmxjbUZzVm1Gc2RXVmZZV1owWlhKZmQyaHBiR1ZBTmpvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaU1FWaFRkR0ZpYkdWamIybHVMbWhoYzFKdmJHVW9jbTlzWlRvZ1lubDBaWE1zSUdGalkyOTFiblE2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG1oaGMxSnZiR1U2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlYM0p2YkdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TURBeU1qQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF5TURBd05EQXdNRFl3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUVWdWRXMWxjbUZpYkdWVFpYUXVZMjl1ZEdGcGJuTUtJQ0FnSUhCdmNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVozSmhiblJTYjJ4bEtISnZiR1U2SUdKNWRHVnpMQ0JoWTJOdmRXNTBPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1UmxKQldGTjBZV0pzWldOdmFXNHVaM0poYm5SU2IyeGxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0lsOXliMnhsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlREF3TWpJd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNakF3TURRd01EQTJNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXlJRE15Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWlNRVmhUZEdGaWJHVmpiMmx1TG1oaGMxSnZiR1VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNORGIyNTBjbTlzT2lCelpXNWtaWElnYlhWemRDQmlaU0JoYmlCaFpHMXBiaUIwYnlCbmNtRnVkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJkeVlXNTBVbTlzWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJsSkJXRk4wWVdKc1pXTnZhVzR1WDJkeVlXNTBVbTlzWlNoeWIyeGxPaUJpZVhSbGN5d2dZV05qYjNWdWREb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNsOW5jbUZ1ZEZKdmJHVTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaVgzSnZiR1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dNREl5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESXdNREEwTURBd05qQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdSVzUxYldWeVlXSnNaVk5sZEM1aFpHUUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5vZ1gyZHlZVzUwVW05c1pWOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WWpkbVptVmlaamdnTHk4Z2JXVjBhRzlrSUNKU2IyeGxSM0poYm5SbFpDaGllWFJsV3pNeVhTeGhaR1J5WlhOekxHRmtaSEpsYzNNcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tDbDluY21GdWRGSnZiR1ZmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlREF3TWpJd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNakF3TURRd01EQTJNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXlJRE15Q2lBZ0lDQmllWFJsWXlBMU1DQXZMeUF3ZURBd01qSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVgzSmxkbTlyWlZKdmJHVW9jbTlzWlRvZ1lubDBaWE1zSUdGalkyOTFiblE2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BmY21WMmIydGxVbTlzWlRvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0pmY205c1pYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURBd01qSXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWpBd01EUXdNREEyTURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBMbkpsYlc5MlpRb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpZWlCZmNtVjJiMnRsVW05c1pWOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURaalpURXpPR0lnTHk4Z2JXVjBhRzlrSUNKU2IyeGxVbVYyYjJ0bFpDaGllWFJsV3pNeVhTeGhaR1J5WlhOekxHRmtaSEpsYzNNcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tDbDl5WlhadmEyVlNiMnhsWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd3TURJeU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREl3TURBME1EQXdOakF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF6TWdvZ0lDQWdZbmwwWldNZ05UQWdMeThnTUhnd01ESXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1pTUVZoVGRHRmliR1ZqYjJsdUxtRnNiRzkzWVc1alpTaHZkMjVsY2pvZ1lubDBaWE1zSUhOd1pXNWtaWEk2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJsSkJXRk4wWVdKc1pXTnZhVzR1WVd4c2IzZGhibU5sT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFNElDOHZJQ0pmWVd4c2IzZGhibU5sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdVa0ZZVTNSaFlteGxZMjlwYmk1ZmRISmhibk5tWlhJb2MyVnVaR1Z5T2lCaWVYUmxjeXdnY21WamFYQnBaVzUwT2lCaWVYUmxjeXdnWVcxdmRXNTBPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tYM1J5WVc1elptVnlPZ29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNRekl3T2lCMGNtRnVjMlpsY2lCbWNtOXRJSFJvWlNCNlpYSnZJR0ZrWkhKbGMzTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpETWpBNklIUnlZVzV6Wm1WeUlIUnZJSFJvWlNCNlpYSnZJR0ZrWkhKbGMzTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QWlYMkpoYkdGdVkyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNRekl3T2lCMGNtRnVjMlpsY2lCaGJXOTFiblFnWlhoalpXVmtjeUJpWVd4aGJtTmxJZ29nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNVRZV1psVFdGMGFDNXpkV0lvTXlrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpWDJKaGJHRnVZMlZ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtRmtaQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZkFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXpNQ0F2THlCdFpYUm9iMlFnSWxSeVlXNXpabVZ5S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R1VrRllVM1JoWW14bFkyOXBiaTVmWW5WeWJpaGhZMk52ZFc1ME9pQmllWFJsY3l3Z1lXMXZkVzUwT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWDJKMWNtNDZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSkRNakE2SUdKMWNtNGdabkp2YlNCMGFHVWdlbVZ5YnlCaFpHUnlaWE56Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UY2dMeThnSWw5aVlXeGhibU5sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWtNeU1Eb2dZblZ5YmlCaGJXOTFiblFnWlhoalpXVmtjeUJpWVd4aGJtTmxJZ29nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNVRZV1psVFdGMGFDNXpkV0lvTXlrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSmZkRzkwWVd4VGRYQndiSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjkwYjNSaGJGTjFjSEJzZVNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1emRXSUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0lsOTBiM1JoYkZOMWNIQnNlU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTXpBZ0x5OGdiV1YwYUc5a0lDSlVjbUZ1YzJabGNpaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTmlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbEpCV0ZOMFlXSnNaV052YVc0dVgyRndjSEp2ZG1Vb2IzZHVaWEk2SUdKNWRHVnpMQ0J6Y0dWdVpHVnlPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1gyRndjSEp2ZG1VNkNpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnUlZKRE1qQTZJR0Z3Y0hKdmRtVWdabkp2YlNCMGFHVWdlbVZ5YnlCaFpHUnlaWE56Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1F6SXdPaUJoY0hCeWIzWmxJSFJ2SUhSb1pTQjZaWEp2SUdGa1pISmxjM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE9DQXZMeUFpWDJGc2JHOTNZVzVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVGhsTURrME5qRWdMeThnYldWMGFHOWtJQ0pCY0hCeWIzWmhiQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdYM0IxZVdGZmJHbGlMbTFsYlM1dVpYZGZjMnh2ZENncElDMCtJSFZwYm5RMk5Eb0tYM0IxZVdGZmJHbGlMbTFsYlM1dVpYZGZjMnh2ZERvS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnWW1sMGJHVnVDaUFnSUNCc2IyRmtJREFLSUNBZ0lIQjFjMmhwYm5RZ01qVTJDaUFnSUNCa2FXY2dNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE5sZEdKcGRDQXZMeUJ2YmlCbGNuSnZjam9nYm04Z1lYWmhhV3hoWW14bElITnNiM1J6Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHVWtGWVUzUmhZbXhsWTI5cGJpNWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGQUNBQkFzQ0VQU1l6QUNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVFWSDN4MUJXOTNibVZ5RUhScGJXVnNiMk5yWDJGa1pISmxjM01TWTI5dWRISnZiR3hsY2w5aFpHUnlaWE56RjJkc2IySmhiRjlqYjJ4c1lYUmxjbUZzWDNKaGRHbHZBUUVzQUNJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDQUFRQUJnQUFBQUFNWDNSdmRHRnNVM1Z3Y0d4NUNXWnlZWGhmYzNSbGNDRUJBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUVpuSmhlRjl3YjI5c2MxOWhjbkpoZVFaZmNtOXNaWE1NZDJWMGFGOWhaR1J5WlhOekRIQnlhV05sWDNSaGNtZGxkQXB3Y21salpWOWlZVzVrQ1Y5aVlXeGhibU5sY3d0ZllXeHNiM2RoYm1ObGN3NXViMjFwYm1GMFpXUlBkMjVsY2c1bGRHaGZkWE5rWDNCeWFXTmxjaGRsZEdoZmRYTmtYM0J5YVdObGNsOWtaV05wYldGc2N3OWpjbVZoZEc5eVgyRmtaSEpsYzNNUWNtVm1jbVZ6YUY5amIyOXNaRzkzYmhkamIyeHNZWFJsY21Gc1gzSmhkR2x2WDNCaGRYTmxaQVVWSDN4MWdBNXlaV1JsYlhCMGFXOXVYMlpsWlF0dGFXNTBhVzVuWDJabFpRNXNZWE4wWDJOaGJHeGZkR2x0WlFoZmFXNWtaWGhsY3dRb2tZaGhDbVp5WVhoZmNHOXZiSE1OWm5KaGVFVjBhRTl5WVdOc1pReG1lSE5GZEdoUGNtRmpiR1VHYzNsdFltOXNCRzVoYldVTFpuaHpYMkZrWkhKbGMzTVhabkpoZUY5bGRHaGZiM0poWTJ4bFgyRmtaSEpsYzNNV1puaHpYMlYwYUY5dmNtRmpiR1ZmWVdSa2NtVnpjeGhsZEdoZmRYTmtYMk52Ym5OMWJXVnlYMkZrWkhKbGMzTVZSRVZHUVZWTVZGOUJSRTFKVGw5QlJFUlNSVk5URjJaeVlYaGZjRzl2YkhOZllYSnlZWGxmYkdWdVozUm9EbDlmWTNSdmNsOXdaVzVrYVc1bklMSlVBa0dLMVZVQk1oQTJXa0l2bnhJR3N0MEFjWm1ZMndiNG9mdmdGR1FiQktRdnhOa0JBZ0VBQ3dHbmhEZWRtZHRDQUFBQUpFVlNRekl3T2lCaWRYSnVJR0Z0YjNWdWRDQmxlR05sWldSeklHRnNiRzkzWVc1alpRUXRNZnkxQWdBaWdDQi8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vL3pVQU1SaEFBSFVuQ1Nobkt5bG5KeE1wWnljVUtXY25GU0puSnlBcFp5Y2hLV2NuSWlobkp5TW9aeWNXS1djbkJDbG5Kd1VwWnlja0tXY25KU2xuSnlZcFp5Y09LV2NuSnlsbkp3WW9aeWNhS0djbkd5aG5Kd29vWnljWEtHY25EeWhuSnhBb1p5Y29LV2NuR0NKbkp4d29aeWNwSW1jbktpUm5KRU14R1JSRU1SaEVna0lFYWV4cVdBU3hvRUpvQkd4TEs4OEVyRmV0b2dTTTNURy9CSjNFazRrRXFJdUlqQVRId1EvK0JCTXlmaWdFb01ZWDlRUU9aTXl6QklZNTBOa0VzM0gyVVFSSHpPNnpCTGpDMC84RUlXTVoyUVJuMjUwU0JIQWZqY0lFcXZ1d2l3VFBhWDdJQkw3ODlkMEVXTFI2M0FUaDFMVHVCRkRMOTBrRU90T2hBd1RWSWRZRUJGaXBFQ2dFRGh4TG9BUWtYWDlaQkdjb25IMEVGQnhQR0FTRERXQ3hCSjVKZ3UwRWVmcTBaUVNEdXRmTUJCbU1tQ0FFWFlWTkRnVDYrMm9JQkczMEgyMEU2WnpKZVFSK3R0dE1CUEZRVlNjRTAwTjFWQVFBVzFLNEJCbDFCaFlFdlVyK1hnUkNQRUFOQkFFdVV5NEVJaEU1NmdTS24wMlRCSExGOEM4RWlIcncyZ1NPT0dZd0JJZTkwdWtFd3NzRXB3U3BCWWpaQkdPZzA2VUV4ZEJUcndUaU5FMlZCTGl3QjJFRVU5UGQyUVFkL1BSQ0JJMm9xdklFbnNNWTFRU3h1N0NvQkgwdk5WdzJHZ0NPUWdKQkEySURkQU9HQSs0RXpBVGRCWjRHQUFaeEJzNEhpd2ZWQ0I4SWFRaXpDUDBKUUFtc0NlOEtNZ3A4Q3VZTFVBdDBDNVFMdVF2WURBUU1NZ3hPREdNTWpneW9ETHNNMnd6M0RSZ05OQTJkRGMwT0pBNDBEbUFPY3c2R0RwRU9uQTZuRHJJT3ZRN0lEdE1PM2c4RkR4Z1BLdzgrRDFFUFpBOTNENG9QbFErbUQ3a1B3d0NLQWdLTC9vdi9pQUREalA1QUFDbUwvaUpaaS80bFdZditUZ0pTSlNKWVNZdi9VRWdWSXdvV2kvOEJKeDFNVUVtOFNFeS9KSXYraVNLTC9vbUtBZ0tML3dFbkhVeFFTYjRvVGdKTlNTaXBRUUJ6aXdFbkM2QW5CNkVuQzZxTC9pSlppLzRsV1l2K1RnSlNKU0pZU1JWSkl3b1dKd3VnSndlaEp3dXFnUWl2U1U4Q1VFa1ZnUWdKV3lNTFN3Tk1JMWhNU3dSUVNSV0JDQWxiSXd0TEEweExBbDFJVHdNbkI2Qk1BU2NkVEZCSnZFaE12eU1KSWt4U1NJc0F2RWdraS81UEEwOERpU0tML2s4RFR3T0ppZ0lDaS84Qkp4MU1VTDRvVGdKTktLbUwvb21LQVFLTC95SlppLzhsV1l2L1RnSlNKU0pZRlNNS0Zvdi9pWW9DQW92K0lsbUwvaVZaaS81T0FsSWxJbGhKRlNNS0Zvdi9wVVNCQ0srTC8xQkpGWUVJQ1ZzakN5TllpLzZKaWdJRGkvNGlXWXYrRll2K1RnSlNpLytJL3NKSWkvNUppWW9DQTR2K0lsbUwvaFdML2s0Q1Vvdi9pUDdsU0l2K1NZbUtBZ0tML2lKWmkvNFZpLzVPQWxLTC80ai9YVWlML29tS0FRS0wveUpaaS84VmkvOU9BbEtJLzF0SWkvK0ppZ0lDaS80aVdZditGWXYrVGdKU2kvK0kvMTFJaS82SmlnSUJpLzZMLzZCSmkvNm5SSW1LQWdHTC9vdi9nQjVUWVdabFRXRjBhRG9nYzNWaWRISmhZM1JwYjI0Z2IzWmxjbVpzYjNlSUFBR0ppZ01CaS82TC9hWkVpLzBuQzZDTC9xRW5DNnFKaWdJQmkvNG9xRUVBQXlJV2lZditpLytqU1l2K29vdi9xRVNKaWdJQmkvNkwvNEFhVTJGbVpVMWhkR2c2SUdScGRtbHphVzl1SUdKNUlIcGxjbStJQUFHSmlnTUJpLzRvcFVTTC9Zditvb2syR2dGSklsa2xDRXNCRlJKRVZ3SUFOaG9DU1NKWkpRaExBUlVTUkZjQ0FEWWFBMGtWSXhKRU5ob0VTUlVqRWtRbkttUkVKeW9pWjBzQktSTkVLMHNDWjRBazBzenlrQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVN3SlFzRWtwRTBRbkkwOEVaeWNpVHdObkp4WlBBbWNuQkV4bktURUFpQTZ1SnlneEFHY2lKeFpsUkVrcEUwUWlKd2xsUkNjdmlQN0NKd2xNWjBrQkp4Rk1VRW0rS0U0Q1RTY3ZpUDZ0U3dHOFNMOHBURkNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBR25oRGVkbWR0Q0FBQUFVQ2NlVEZDd0lpY1daVVFuSzB5SURpVWlKd1JsUkNjclRJZ09Hb0hFRXhZbkNreG5JUVFXSndaTEFXZUJrQndXSnhkTVp5Y1BUR2VCaUNjV0p4Qk1aeVJESW9nTWFFa1ZJdzVFSTYrcktreFFzQ1JESklnTVZra1ZJdzVFSTYrcktreFFzQ1JEc1NJbkZHVkVnUmhiZ1FheUVDS3lHU0t5QWJJWUp5eXlHck1uQjRFS0ZpSW5GV1ZFRmtrb3BVRUFIMGtuQjZ3b3FVRUFCMHNDU3dLalJRTkpKeTJpUlFGTEFVbWpSUUpDLzl1MFBsY0VBQ0VFRm9qK0Zrc0RpUDRzU1JVakRrUWpyNnNxVEZDd0pFT3hJaWNVWlVTQkdGdUJCcklRSXJJWklySUJzaGduTExJYXN5Y0hnUW9XSWljVlpVUVdTU2lsUVFBZlNTY0hyQ2lwUVFBSFN3SkxBcU5GQTBrbkxhSkZBVXNCU2FORkFrTC8yeUtJQzVJa2lBdU9JaWNKWlVRaUp3WmxSSWdNVnlJbkcyVkVJaWNhWlVTMFBsY0VBQ0VFRm9qOWowc0tpUDJsU3djVkl3NUVJNjlQQ0VzQnEwc0lGU01PUkU4SVN3S3JVRXNIRlNNT1JFOEhTd0tyVUVzR0ZTTU9SRThHU3dLclVFc0ZGU01PUkU4RlN3S3JVRXNFRlNNT1JFOEVTd0tyVUVzREZTTU9SRThEU3dLclVFc0NGU01PUkU0Q3ExQXFURkN3SkVPSUM5VkpGU01PUkNPdnF5cE1VTEFrUXlJbkdHVkVGRVFpaUFybVNUSUhGaWNMb0NJbkhHVkVvU2NMcWlJbkYyVkVwMFFpSnc5bFJDSW5FR1ZFaVB5WHBVRUFSeUluQm1WRUlpY0taVVNtUVFBbEloWW5Ca3huTWdjV0p4eE1aeUluQm1WRVNSVWpEa1FqcjZ1QUJBWTJ2eWxNVUxBa1F5SW5CbVZFSWljS1pVU0kvR0VuQmt4blF2L05JaWNQWlVRaUp4QmxSSWo4VFVzQnBVSC91aUluQm1WRUlpY0taVVNJL0N5QUF3OUNRS2RCQUFvaEJCWW5Ca3huUXYrYUlpY0daVVFpSndwbFJJajhEQ2NHVEdkQy80WTJHZ0ZKRlNNU1JEWWFBa2tWU1NNU1JERUFBU2NmVEZDK1RCY2lURThDVFNRU1JFc0NTd0tJRE5jeEFFc0RNUUJRQVNjU1RGQytLRTRDVFVzREp6Q0krL3hMQkU0Q2lBMGdJdzVFSTYrck1RQlBBa3hRVEZDQUJLUnp0cjlNVUxBa1F6WWFBVWtWSXhKRU5ob0NTUlZKSXhKRU1RQUJKeDlNVUw1TUZ5Sk1Ud0pOSkJKRVN3SXBFMFFpSndsbFJFc0NpUHR4SndsTVowc0NBU2NSVEZCSnZpaE9BazFMQTRqN1cwc0J2RWkvSXc1RUk2K3JLVXNDVUVzQlVDY2VURkN3TVFCUEFsQk1VSUFFNlNuR1AweFFzQ1JETmhvQlNSVWpFa1F4QUNJclpVUVNRQUFXTVFBaUp3UmxSQkpBQUFzeEFDSW5CV1ZFRWtFQU1TUkVSd0lwRTBSSkFTY2ZURkJKdmt3WElreFBBazBVUkNRV3Z5Y012a1FsSWxoTEFWQklnQVQ0djh1NVRGQ3dKRU1pUXYvTUlpZzJHZ0ZKRlNNU1JERUFJaXRsUkJKQUFCWXhBQ0luQkdWRUVrQUFDekVBSWljRlpVUVNRUUNQSkVSSEFpa1RSQUVuSDB4UVNiNU1GeUpNVHdKTkpCSkV2RWdpRmtVRElpY3BaVVFXU3dPbFFRQlBpQXdXU1NnL0p3eStUQ1VpV0lnTUNVbFBBajlNVFlFSXIwc0VVRWtWZ1FnSlcwdytUQ01MU1VVRUkxaExBUkpCQUNrbkRMNUVKU0pZU3dJcFhVa1ZJd29XVndZQ1RGQW5ETHhJSnd4TXY0QUU1N1Z5bUVzQlVMQWtRMHNDSndlZ1JRTkMvNDhpUXY5dU5ob0JTUlZKSXhKRU1RQWlLMlZFRWtBQUZqRUFJaWNFWlVRU1FBQUxNUUFpSndWbFJCSkJBQjBrUkNjYVN3SkpUZ0puU3dFakRrUWpyNnVBQk1QZlZseE1VTEFrUXlKQy8rQTJHZ0ZKRlVrakVrUXhBQ0lyWlVRU1FBQVdNUUFpSndSbFJCSkFBQXN4QUNJbkJXVkVFa0VBSFNSRUp4dExBa2xPQW1kTEFTTU9SQ092cTRBRWYxc2xaRXhRc0NSRElrTC80RFlhQVVrVlNTTVNSREVBSWl0bFJCSkFBQll4QUNJbkJHVkVFa0FBQ3pFQUlpY0ZaVVFTUVFBZEpFUW5Da3NDU1U0Q1owc0JJdzVFSTYrcmdBUzR3aU83VEZDd0pFTWlRdi9nTmhvQlNSVkpJeEpFTVFBaUsyVkVFa0FBRmpFQUlpY0VaVVFTUUFBTE1RQWlKd1ZsUkJKQkFCMGtSQ2NQU3dKSlRnSm5Td0VqRGtRanI2dUFCQkg5d3ZKTVVMQWtReUpDLytBMkdnRkpGVWtqRWtReEFDSXJaVVFTUUFBV01RQWlKd1JsUkJKQUFBc3hBQ0luQldWRUVrRUFIU1JFSnhkTEFrbE9BbWRMQVNNT1JDT3ZxNEFFRjZOb2treFFzQ1JESWtMLzREWWFBVWtWSXhKRU1RQWlLMlZFRWtBQUZqRUFJaWNFWlVRU1FBQUxNUUFpSndWbFJCSkJBQmNrUkVjQ0tSTkVKeVJMQVdlQUJDbWtoQ0ZNVUxBa1F5SkMvK1kyR2dGSkZTTVNSREVBSWl0bFJCSkFBQll4QUNJbkJHVkVFa0FBQ3pFQUlpY0ZaVVFTUVFCQUpFUkhBaWtUUkNjblN3Rm5KeFJMQVdleFNZRVlXNEVHc2hBaXNoa2lzZ0d5R0lBRURzclkwTElhczdRK1Z3UUFGeWNWVEdlQUJKNnNWS1ZNVUxBa1F5SkMvNzAyR2dGSkZTTVNSREVBSWl0bFJCSkFBQll4QUNJbkJHVkVFa0FBQ3pFQUlpY0ZaVVFTUVFBWEpFUkhBaWtUUkNjRVN3Rm5nQVRaUGFUWlRGQ3dKRU1pUXYvbU5ob0JTUlVqRWtReEFDSXJaVVFTUUFBV01RQWlKd1JsUkJKQUFBc3hBQ0luQldWRUVrRUFGeVJFUndJcEUwUW5CVXNCWjRBRXBnSVNZMHhRc0NSRElrTC81allhQVVrVlNTTVNSREVBSWl0bFJCSkFBQll4QUNJbkJHVkVFa0FBQ3pFQUlpY0ZaVVFTUVFBZEpFUW5FRXNDU1U0Q1owc0JJdzVFSTYrcmdBVDIxdldWVEZDd0pFTWlRdi9nTmhvQlNSVWpFa1EyR2dKSkZTTVNSREVBSWl0bFJCSkFBQll4QUNJbkJHVkVFa0FBQ3pFQUlpY0ZaVVFTUVFBMkpFUkxBU2tUUVFBcFNTa1RRUUFqSkVRbkpVc0NTVTRDWnljZ1N3Rm5KdzVMQWtsT0FtZFFnQVJxUkNOL1RGQ3dKRU1pUXYvYUlrTC94ellhQVVrVkl4SkVOaG9DU1JVakVrUXhBQ0lyWlVRU1FBQVdNUUFpSndSbFJCSkFBQXN4QUNJbkJXVkVFa0VBTmlSRVN3RXBFMEVBS1VrcEUwRUFJeVJFSnlaTEFrbE9BbWNuSVVzQlp5Y09Td0pKVGdKblVJQUVrVmt4OFV4UXNDUkRJa0wvMmlKQy84Y25LekVBaUFYaFJDSW5HR1ZFRkNjWVN3Rm5KeTRpVHdKVWdBVDRpUzVzVEZDd0pFTTJHZ0ZKRlNNU1JERUFJaXRsUkJKRUp4TkxBV2VBQkxLQklZcE1VTEFrUXpFQUlpY1RaVVJNU3dFU1JDSXJaVVJMQVZDQUJOTE04cEJNVUxBclRHY25FeWxuSkVNMkdnRkpGU01TUkRZYUFra1ZJeEpFaUFWc0p5NGlUd0pVS2t4UXNDUkROaG9CU1JVakVrUUJKdzFNVUw0bkNFNENUVWtpV1VzQkZWS0k5WUJJU1JVakRrUWpyNnNxVEZDd0pFTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRVRBRW5EVXhRdmljSVRnSk5TU0paU3dFVlVreUk5V0JJS2t4UXNDUkROaG9CU1JVakVrUUJKdzFNVUw0bkNFNENUVmNDSUNwTVVMQWtRellhQVVrVkl4SkVOaG9DU1JVakVrU0lCUFVrUXpZYUFVa1ZJeEpFTmhvQ1NSVWpFa1JMQVFFbkRVeFF2aWNJVGdKTlZ3SWdNUUNJQkxCRWlBVTRKRU0yR2dGSkZTTVNSRFlhQWtrVkl4SkVTVEVBRWtTSUJSNGtReUluQ1dWRVNSVWpEa1FqcjZzcVRGQ3dKRU0yR2dGSkZTTVNSQUVuRVV4UXZpaE9BazFKRlNNT1JDT3ZxeXBNVUxBa1F6WWFBVWtWSXhKRU5ob0NTUlVqRWtReEFFNENpQVV5Snhtd0pFTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRWlBVUhTUlVqRGtRanI2c3FURkN3SkVNMkdnRkpGU01TUkRZYUFra1ZJeEpFTVFCT0FvZ0YyQ2Nac0NSRE5ob0JTUlVqRWtRMkdnSkpGU01TUkRZYUEwa1ZJeEpFU3dKUEFrc0NpQVRQTVFCTEFqRUFVQUVuRWt4UXZpaE9BazFQQW9Bb1JWSkRNakE2SUhSeVlXNXpabVZ5SUdGdGIzVnVkQ0JsZUdObFpXUnpJR0ZzYkc5M1lXNWpaWWowUjRnRmJ5Y1pzQ1JETmhvQlNSVWpFa1EyR2dKSkZTTVNSREVBU1VzRFVBRW5Fa3hRdmloT0FrMVBBb2p6NFV4T0FvZ0ZQeWNac0NSRE5ob0JTUlVqRWtRMkdnSkpGU01TUkRFQVNVc0RVQUVuRWt4UXZpaE9BazFQQW9BbFJWSkRNakE2SUdSbFkzSmxZWE5sWkNCaGJHeHZkMkZ1WTJVZ1ltVnNiM2NnZW1WeWI0anp3MHhPQW9nRTZDY1pzQ1JETmhvQlNSVWpFa1F4QUV5SUJHMGtRellhQVVrVkl4SkVOaG9DU1JVakVrUkxBVEVBaUFQR1N3RW5NSWp6aWtzQ01RQlBBb2dFcklnRVFTUkRJaWNpWlVSSkZSWlhCZ0pNVUNwTVVMQWtReUluSTJWRVNSVVdWd1lDVEZBcVRGQ3dKRU1pSnhabFJDcE1VTEFrUXlJbkJHVkVLa3hRc0NSRElpY0ZaVVFxVEZDd0pFTWlKeVJsUkNwTVVMQWtReUluSldWRUtreFFzQ1JESWljbVpVUXFURkN3SkVNaUp3NWxSQ3BNVUxBa1F5SW5KMlZFS2t4UXNDUkRpQVJhU1NnL0p3eStUQ1VpV0lnRVRVbFBBajlNVFQ1SkZTTUtGbGNHQWt4UUtreFFzQ1JESWljR1pVUkpGU01PUkNPdnF5cE1VTEFrUXlJbkdtVkVTUlVqRGtRanI2c3FURkN3SkVNaUp4dGxSRWtWSXc1RUk2K3JLa3hRc0NSRElpY0taVVJKRlNNT1JDT3ZxeXBNVUxBa1F5SW5GMlZFU1JVakRrUWpyNnNxVEZDd0pFTWlKdzlsUkVrVkl3NUVJNityS2t4UXNDUkRJaWNRWlVSSkZTTU9SQ092cXlwTVVMQWtReUluS0dWRUtreFFzQ1JESWljWVpVUW5MaUpQQWxRcVRGQ3dKRU1pSnh4bFJFa1ZJdzVFSTYrcktreFFzQ1JESWl0bFJDcE1VTEFrUXlJbkUyVkVLa3hRc0NSRGlnRUJJa214SWljVVpVU0JHRnVCQnJJUUlySVpJcklCc2hnbkxMSWFzeWNIZ1FvV0lpY1ZaVVFXaXdRb3BVRUFJWXNFSndlc0tLbEJBQWVMQW9zRG80d0Npd1FuTGFLTUJJc0RTYU9NQTBMLzJMUStWd1FBSVFRV1NZd0JpUEhEaXdLSThkbU1BSXYvUUFBNHNTSW5EbVZFSWljZ1pVU0JHRnVCQnJJUUlySVpJcklCc2hnbk1iSWFzaHFMQWJJYXM3UStWd1FBaXdDTEFZanhoa3lJOFoyTUFJbUwveVFTUkxFaUp3NWxSQ0luSVdWRWdSaGJnUWF5RUNLeUdTS3lBYklZSnpHeUdySWFpd0d5R3JPMFBsY0VBRUwvd0lvQUFTZ2lGa2tpSnlsbFJCYUxBcVZCQUh5SUFvRkpLRDhuREw1TUpTSllpQUowU1U4Q1AweE5nUWl2aXdKUVNSV0JDQWxiVEQ1TUl3dEpqQUFqV0NrVFFRQkJzWWdDVDBrb1B5Y012a3dsSWxpSUFrSkpUd0kvVEUwK2l3QWpXSUVZVzRFR3NoQWlzaGtpc2dHeUdJQUU4YmZ0MkxJYXM3UStWd1FBaXdGTWlQQjhqQUdMQWljSG9Jd0NRdjk0aXdHTUFJbUtBZ0dML2dFbkRVeFF2aWNJVGdKTlNTSlpTd0VWVW92L2lQQUpTSW1LQWdDTC9nRW5EVXhRdmljSVRnSk5Wd0lnTVFDSS84cEVpLzZMLzRnQUFZbUtBZ0NML2dFbkRVeFFTYjRuQ0U0Q1RVa2lXVXNCRlZLTC80anZsMGhNUVFBU01RQ0wvb3YvVUV4UWdBUzMvK3Y0VEZDd2l3Qkp2aWNJVGdKTlZ3SWdKekpNVUlzQlVFc0J2RWkvaVlvQ0FJditBU2NOVEZCSnZpY0lUZ0pOU1NKWlN3RVZVb3YvaU85alNFeEJBQkl4QUl2K2kvOVFURkNBQkFiT0U0dE1VTENMQUVtK0p3aE9BazFYQWlBbk1reFFpd0ZRU3dHOFNMK0ppZ0lCaS82TC8xQUJKeEpNVUw0b1RnSk5pWW9EQUl2OUtSTkVpLzRwRTBTTC9RRW5FVXhRU2I0b1RnSk5pLytBSmtWU1F6SXdPaUIwY21GdWMyWmxjaUJoYlc5MWJuUWdaWGhqWldWa2N5QmlZV3hoYm1ObGlPOXhTd0c4U0wrTC9nRW5FVXhRU2I0b1RnSk5pLytJN3lGTEFieEl2NHYvRlNNT1JDT3ZpLytyaS8yTC9sQk1VQ2NlVEZDd2lZb0NBSXYrS1JORWkvNEJKeEZNVUVtK0tFNENUWXYvZ0NKRlVrTXlNRG9nWW5WeWJpQmhiVzkxYm5RZ1pYaGpaV1ZrY3lCaVlXeGhibU5saU83L1N3RzhTTDhpSndsbFJJdi9pTzdGSndsTVo0di9GU01PUkNPdmkvK3JpLzRwVUV4UUp4NU1VTENKaWdNQWkvMHBFMFNML2lrVFJJdjlpLzVRU1FFbkVreFFTYnhJaS8rL2kvOFZJdzVFSTYrTC82dFFnQVFZNEpSaFRGQ3dpVFFBa3pRQWdZQUNTd0lKSWxRMUFJaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJPd25lckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUdyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ29sbGF0ZXJhbFJhdGlvUmVmcmVzaGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnbG9iYWxfY29sbGF0ZXJhbF9yYXRpbyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJGUkFYQnVybmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkZSQVhNaW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUG9vbEFkZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xfYWRkcmVzcyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUG9vbFJlbW92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbF9hZGRyZXNzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSZWRlbXB0aW9uRmVlU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRfZmVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJNaW50aW5nRmVlU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5fZmVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJGcmF4U3RlcFNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3N0ZXAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlByaWNlVGFyZ2V0U2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcHJpY2VfdGFyZ2V0IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSZWZyZXNoQ29vbGRvd25TZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19jb29sZG93biIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRlhTQWRkcmVzc1NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfZnhzX2FkZHJlc3MiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkVUSFVTRE9yYWNsZVNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldGhfdXNkX2NvbnN1bWVyX2FkZHJlc3MiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRpbWVsb2NrU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld190aW1lbG9jayIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ29udHJvbGxlclNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb250cm9sbGVyX2FkZHJlc3MiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlByaWNlQmFuZFNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VfYmFuZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRlJBWEVUSE9yYWNsZVNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcmF4X29yYWNsZV9hZGRyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2V0aF9hZGRyZXNzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJGWFNFdGhPcmFjbGVTZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnhzX29yYWNsZV9hZGRyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2V0aF9hZGRyZXNzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJDb2xsYXRlcmFsUmF0aW9Ub2dnbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb2xsYXRlcmFsX3JhdGlvX3BhdXNlZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3duZXJOb21pbmF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVSZXZva2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
