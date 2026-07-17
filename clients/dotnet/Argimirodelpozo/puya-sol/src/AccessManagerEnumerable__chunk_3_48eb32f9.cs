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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.AccessManagerEnumerable__chunk_3_48eb32f9
{


    //
    // @title AccessManagerEnumerable
    // @author Aave Labs
    // @notice Extension of AccessManager that tracks role members and their function selectors using EnumerableSet.
    // @dev Roles, target contracts, and function selectors assigned to `ADMIN_ROLE` are excluded from tracking.
    //
    public class AccessManagerEnumerable__chunk_3Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AccessManagerEnumerable__chunk_3Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class Bytes32Set : AVMObjectType
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

                public static Bytes32Set Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Bytes32Set();
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
                    return Equals(obj as Bytes32Set);
                }
                public bool Equals(Bytes32Set? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Bytes32Set left, Bytes32Set right)
                {
                    return EqualityComparer<Bytes32Set>.Default.Equals(left, right);
                }
                public static bool operator !=(Bytes32Set left, Bytes32Set right)
                {
                    return !(left == right);
                }

            }

            public class Role : AVMObjectType
            {
                public byte[] Members { get; set; }

                public ulong Admin { get; set; }

                public ulong Guardian { get; set; }

                public System.Numerics.BigInteger GrantDelay { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMembers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vMembers.From(Members);
                    ret.AddRange(vMembers.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAdmin.From(Admin);
                    ret.AddRange(vAdmin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGuardian = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGuardian.From(Guardian);
                    ret.AddRange(vGuardian.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGrantDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint112");
                    vGrantDelay.From(GrantDelay);
                    ret.AddRange(vGrantDelay.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Role Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Role();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMembers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vMembers.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMembers = vMembers.ToValue();
                    if (valueMembers is byte[] vMembersValue) { ret.Members = vMembersValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is ulong vAdminValue) { ret.Admin = vAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGuardian = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGuardian.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGuardian = vGuardian.ToValue();
                    if (valueGuardian is ulong vGuardianValue) { ret.Guardian = vGuardianValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGrantDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint112");
                    count = vGrantDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGrantDelay = vGrantDelay.ToValue();
                    if (valueGrantDelay is System.Numerics.BigInteger vGrantDelayValue) { ret.GrantDelay = vGrantDelayValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Role);
                }
                public bool Equals(Role? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Role left, Role right)
                {
                    return EqualityComparer<Role>.Default.Equals(left, right);
                }
                public static bool operator !=(Role left, Role right)
                {
                    return !(left == right);
                }

            }

            public class Schedule : AVMObjectType
            {
                public uint Timepoint { get; set; }

                public uint Nonce { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimepoint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint48");
                    vTimepoint.From(Timepoint);
                    ret.AddRange(vTimepoint.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
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

                public static Schedule Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Schedule();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimepoint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint48");
                    count = vTimepoint.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimepoint = vTimepoint.ToValue();
                    if (valueTimepoint is uint vTimepointValue) { ret.Timepoint = vTimepointValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNonce = vNonce.ToValue();
                    if (valueNonce is uint vNonceValue) { ret.Nonce = vNonceValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Schedule);
                }
                public bool Equals(Schedule? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Schedule left, Schedule right)
                {
                    return EqualityComparer<Schedule>.Default.Equals(left, right);
                }
                public static bool operator !=(Schedule left, Schedule right)
                {
                    return !(left == right);
                }

            }

            public class Set : AVMObjectType
            {
                public byte[][] Values { get; set; }

                public byte[] Positions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValues = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][]");
                    vValues.From(Values);
                    ret.AddRange(vValues.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPositions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vPositions.From(Positions);
                    ret.AddRange(vPositions.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPositions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vPositions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePositions = vPositions.ToValue();
                    if (valuePositions is byte[] vPositionsValue) { ret.Positions = vPositionsValue; }
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

            public class TargetConfig : AVMObjectType
            {
                public byte[] AllowedRoles { get; set; }

                public System.Numerics.BigInteger AdminDelay { get; set; }

                public bool Closed { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAllowedRoles = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vAllowedRoles.From(AllowedRoles);
                    ret.AddRange(vAllowedRoles.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdminDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint112");
                    vAdminDelay.From(AdminDelay);
                    ret.AddRange(vAdminDelay.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClosed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vClosed.From(Closed);
                    ret.AddRange(vClosed.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TargetConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TargetConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAllowedRoles = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vAllowedRoles.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAllowedRoles = vAllowedRoles.ToValue();
                    if (valueAllowedRoles is byte[] vAllowedRolesValue) { ret.AllowedRoles = vAllowedRolesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdminDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint112");
                    count = vAdminDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdminDelay = vAdminDelay.ToValue();
                    if (valueAdminDelay is System.Numerics.BigInteger vAdminDelayValue) { ret.AdminDelay = vAdminDelayValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClosed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vClosed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueClosed = vClosed.ToValue();
                    if (valueClosed is bool vClosedValue) { ret.Closed = vClosedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TargetConfig);
                }
                public bool Equals(TargetConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TargetConfig left, TargetConfig right)
                {
                    return EqualityComparer<TargetConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(TargetConfig left, TargetConfig right)
                {
                    return !(left == right);
                }

            }

            public class UintSet : AVMObjectType
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

                public static UintSet Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new UintSet();
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
                    return Equals(obj as UintSet);
                }
                public bool Equals(UintSet? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UintSet left, UintSet right)
                {
                    return EqualityComparer<UintSet>.Default.Equals(left, right);
                }
                public static bool operator !=(UintSet left, UintSet right)
                {
                    return !(left == right);
                }

            }

            public class CanCallReturn : AVMObjectType
            {
                public bool Immediate { get; set; }

                public ulong Delay { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vImmediate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vImmediate.From(Immediate);
                    ret.AddRange(vImmediate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDelay.From(Delay);
                    ret.AddRange(vDelay.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CanCallReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CanCallReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vImmediate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vImmediate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueImmediate = vImmediate.ToValue();
                    if (valueImmediate is bool vImmediateValue) { ret.Immediate = vImmediateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDelay = vDelay.ToValue();
                    if (valueDelay is ulong vDelayValue) { ret.Delay = vDelayValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CanCallReturn);
                }
                public bool Equals(CanCallReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CanCallReturn left, CanCallReturn right)
                {
                    return EqualityComparer<CanCallReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(CanCallReturn left, CanCallReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetAccessReturn : AVMObjectType
            {
                public ulong Since { get; set; }

                public ulong CurrentDelay { get; set; }

                public ulong PendingDelay { get; set; }

                public ulong Effect { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSince = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSince.From(Since);
                    ret.AddRange(vSince.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrentDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCurrentDelay.From(CurrentDelay);
                    ret.AddRange(vCurrentDelay.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPendingDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPendingDelay.From(PendingDelay);
                    ret.AddRange(vPendingDelay.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEffect = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEffect.From(Effect);
                    ret.AddRange(vEffect.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetAccessReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetAccessReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSince = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSince.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSince = vSince.ToValue();
                    if (valueSince is ulong vSinceValue) { ret.Since = vSinceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrentDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCurrentDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCurrentDelay = vCurrentDelay.ToValue();
                    if (valueCurrentDelay is ulong vCurrentDelayValue) { ret.CurrentDelay = vCurrentDelayValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPendingDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPendingDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePendingDelay = vPendingDelay.ToValue();
                    if (valuePendingDelay is ulong vPendingDelayValue) { ret.PendingDelay = vPendingDelayValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEffect = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEffect.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEffect = vEffect.ToValue();
                    if (valueEffect is ulong vEffectValue) { ret.Effect = vEffectValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetAccessReturn);
                }
                public bool Equals(GetAccessReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetAccessReturn left, GetAccessReturn right)
                {
                    return EqualityComparer<GetAccessReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetAccessReturn left, GetAccessReturn right)
                {
                    return !(left == right);
                }

            }

            public class HasRoleReturn : AVMObjectType
            {
                public bool IsMember { get; set; }

                public ulong ExecutionDelay { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsMember = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsMember.From(IsMember);
                    ret.AddRange(vIsMember.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExecutionDelay.From(ExecutionDelay);
                    ret.AddRange(vExecutionDelay.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static HasRoleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new HasRoleReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsMember = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsMember.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsMember = vIsMember.ToValue();
                    if (valueIsMember is bool vIsMemberValue) { ret.IsMember = vIsMemberValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExecutionDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExecutionDelay = vExecutionDelay.ToValue();
                    if (valueExecutionDelay is ulong vExecutionDelayValue) { ret.ExecutionDelay = vExecutionDelayValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as HasRoleReturn);
                }
                public bool Equals(HasRoleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(HasRoleReturn left, HasRoleReturn right)
                {
                    return EqualityComparer<HasRoleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(HasRoleReturn left, HasRoleReturn right)
                {
                    return !(left == right);
                }

            }

            public class ScheduleReturn : AVMObjectType
            {
                public byte[] OperationId { get; set; }

                public ulong Nonce { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperationId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vOperationId.From(OperationId);
                    ret.AddRange(vOperationId.Encode());
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

                public static ScheduleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ScheduleReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperationId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vOperationId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOperationId = vOperationId.ToValue();
                    if (valueOperationId is byte[] vOperationIdValue) { ret.OperationId = vOperationIdValue; }
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
                    return Equals(obj as ScheduleReturn);
                }
                public bool Equals(ScheduleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ScheduleReturn left, ScheduleReturn right)
                {
                    return EqualityComparer<ScheduleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ScheduleReturn left, ScheduleReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class OperationExecutedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 173, 61, 64, 221 };
                public const string Signature = "OperationExecuted(uint8[32],uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] OperationId { get; set; }
                public ulong Nonce { get; set; }

                public static OperationExecutedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OperationExecutedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperationId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOperationId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOperationId = vOperationId.ToValue();
                    if (valueOperationId is byte[] vOperationIdValue) { ret.OperationId = vOperationIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNonce = vNonce.ToValue();
                    if (valueNonce is ulong vNonceValue) { ret.Nonce = vNonceValue; }
                    return ret;

                }

            }

            public class RoleLabelEvent
            {
                public static readonly byte[] Selector = new byte[4] { 50, 139, 129, 111 };
                public const string Signature = "RoleLabel(uint64,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong RoleId { get; set; }
                public string Label { get; set; }

                public static RoleLabelEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RoleLabelEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoleId = vRoleId.ToValue();
                    if (valueRoleId is ulong vRoleIdValue) { ret.RoleId = vRoleIdValue; }
                    var indexLabel = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLabel.Decode(eventData.Skip(indexLabel).ToArray());
                    var valueLabel = vLabel.ToValue();
                    if (valueLabel is string vLabelValue) { ret.Label = vLabelValue; }
                    return ret;

                }

            }

            public class RoleGrantedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 157, 91, 141, 39 };
                public const string Signature = "RoleGranted(uint64,uint8[32],uint64,uint64,bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong RoleId { get; set; }
                public byte[] Account { get; set; }
                public ulong Delay { get; set; }
                public ulong Since { get; set; }
                public bool NewMember { get; set; }

                public static RoleGrantedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RoleGrantedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoleId = vRoleId.ToValue();
                    if (valueRoleId is ulong vRoleIdValue) { ret.RoleId = vRoleIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is byte[] vAccountValue) { ret.Account = vAccountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDelay = vDelay.ToValue();
                    if (valueDelay is ulong vDelayValue) { ret.Delay = vDelayValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSince = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSince.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSince = vSince.ToValue();
                    if (valueSince is ulong vSinceValue) { ret.Since = vSinceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewMember = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vNewMember.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewMember = vNewMember.ToValue();
                    if (valueNewMember is bool vNewMemberValue) { ret.NewMember = vNewMemberValue; }
                    return ret;

                }

            }

            public class RoleRevokedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 45, 137, 233, 7 };
                public const string Signature = "RoleRevoked(uint64,uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong RoleId { get; set; }
                public byte[] Account { get; set; }

                public static RoleRevokedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RoleRevokedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoleId = vRoleId.ToValue();
                    if (valueRoleId is ulong vRoleIdValue) { ret.RoleId = vRoleIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is byte[] vAccountValue) { ret.Account = vAccountValue; }
                    return ret;

                }

            }

            public class RoleAdminChangedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 253, 76, 248, 144 };
                public const string Signature = "RoleAdminChanged(uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong RoleId { get; set; }
                public ulong Admin { get; set; }

                public static RoleAdminChangedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RoleAdminChangedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoleId = vRoleId.ToValue();
                    if (valueRoleId is ulong vRoleIdValue) { ret.RoleId = vRoleIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is ulong vAdminValue) { ret.Admin = vAdminValue; }
                    return ret;

                }

            }

            public class RoleGuardianChangedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 107, 199, 135, 198 };
                public const string Signature = "RoleGuardianChanged(uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong RoleId { get; set; }
                public ulong Guardian { get; set; }

                public static RoleGuardianChangedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RoleGuardianChangedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoleId = vRoleId.ToValue();
                    if (valueRoleId is ulong vRoleIdValue) { ret.RoleId = vRoleIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGuardian = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGuardian.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGuardian = vGuardian.ToValue();
                    if (valueGuardian is ulong vGuardianValue) { ret.Guardian = vGuardianValue; }
                    return ret;

                }

            }

            public class RoleGrantDelayChangedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 173, 233, 83, 207 };
                public const string Signature = "RoleGrantDelayChanged(uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong RoleId { get; set; }
                public ulong Delay { get; set; }
                public ulong Since { get; set; }

                public static RoleGrantDelayChangedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RoleGrantDelayChangedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoleId = vRoleId.ToValue();
                    if (valueRoleId is ulong vRoleIdValue) { ret.RoleId = vRoleIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDelay = vDelay.ToValue();
                    if (valueDelay is ulong vDelayValue) { ret.Delay = vDelayValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSince = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSince.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSince = vSince.ToValue();
                    if (valueSince is ulong vSinceValue) { ret.Since = vSinceValue; }
                    return ret;

                }

            }

            public class TargetFunctionRoleUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 213, 73, 98, 151 };
                public const string Signature = "TargetFunctionRoleUpdated(uint8[32],uint8[4],uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Target { get; set; }
                public byte[] Selector { get; set; }
                public ulong RoleId { get; set; }

                public static TargetFunctionRoleUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new TargetFunctionRoleUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTarget = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTarget.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTarget = vTarget.ToValue();
                    if (valueTarget is byte[] vTargetValue) { ret.Target = vTargetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSelector = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[4]");
                    count = vSelector.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSelector = vSelector.ToValue();
                    if (valueSelector is byte[] vSelectorValue) { ret.Selector = vSelectorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoleId = vRoleId.ToValue();
                    if (valueRoleId is ulong vRoleIdValue) { ret.RoleId = vRoleIdValue; }
                    return ret;

                }

            }

            public class TargetAdminDelayUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 195, 161, 242, 33 };
                public const string Signature = "TargetAdminDelayUpdated(uint8[32],uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Target { get; set; }
                public ulong Delay { get; set; }
                public ulong Since { get; set; }

                public static TargetAdminDelayUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new TargetAdminDelayUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTarget = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTarget.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTarget = vTarget.ToValue();
                    if (valueTarget is byte[] vTargetValue) { ret.Target = vTargetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDelay = vDelay.ToValue();
                    if (valueDelay is ulong vDelayValue) { ret.Delay = vDelayValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSince = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSince.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSince = vSince.ToValue();
                    if (valueSince is ulong vSinceValue) { ret.Since = vSinceValue; }
                    return ret;

                }

            }

            public class TargetClosedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 206, 122, 101, 15 };
                public const string Signature = "TargetClosed(uint8[32],bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Target { get; set; }
                public bool Closed { get; set; }

                public static TargetClosedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new TargetClosedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTarget = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTarget.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTarget = vTarget.ToValue();
                    if (valueTarget is byte[] vTargetValue) { ret.Target = vTargetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClosed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vClosed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueClosed = vClosed.ToValue();
                    if (valueClosed is bool vClosedValue) { ret.Closed = vClosedValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="initialAdmin_"> </param>
        public async Task PostInit(Algorand.Address initialAdmin_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 15, 48, 174 };
            var initialAdmin_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); initialAdmin_Abi.From(initialAdmin_);

            var result = await base.CallApp(new List<object> { abiHandle, initialAdmin_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Algorand.Address initialAdmin_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 15, 48, 174 };
            var initialAdmin_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); initialAdmin_Abi.From(initialAdmin_);

            return await base.MakeTransactionList(new List<object> { abiHandle, initialAdmin_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="__arc4_index"> </param>
        public async Task<ulong> GetRole(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 197, 152, 12 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRole_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 197, 152, 12 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetRoleCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 78, 255, 2 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetRoleCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 78, 255, 2 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="start"> </param>
        /// <param name="end"> </param>
        public async Task<ulong[]> GetRoles(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 85, 100, 213 };

            var result = await base.SimApp(new List<object> { abiHandle, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetRoles_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 85, 100, 213 };

            return await base.MakeTransactionList(new List<object> { abiHandle, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="__arc4_index"> </param>
        public async Task<ulong> GetAdminRole(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 70, 68, 93 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAdminRole_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 70, 68, 93 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetAdminRoleCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 227, 44, 102 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetAdminRoleCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 227, 44, 102 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="start"> </param>
        /// <param name="end"> </param>
        public async Task<ulong[]> GetAdminRoles(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 93, 173, 74 };

            var result = await base.SimApp(new List<object> { abiHandle, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetAdminRoles_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 93, 173, 74 };

            return await base.MakeTransactionList(new List<object> { abiHandle, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="__arc4_index"> </param>
        public async Task<Algorand.Address> GetRoleMember(ulong roleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 63, 187, 106 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetRoleMember_Transactions(ulong roleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 63, 187, 106 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="roleId"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetRoleMemberCount(ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 248, 203, 46 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetRoleMemberCount_Transactions(ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 248, 203, 46 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="__arc4_start"> </param>
        /// <param name="__arc4_end"> </param>
        public async Task<byte[][]> GetRoleMembers(ulong roleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_start, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 104, 16, 100 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi, __arc4_start, __arc4_end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> GetRoleMembers_Transactions(ulong roleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_start, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 104, 16, 100 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, __arc4_start, __arc4_end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="adminRoleId"> </param>
        /// <param name="__arc4_index"> </param>
        public async Task<ulong> GetRoleOfAdminRole(ulong adminRoleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 196, 152, 152 };
            var adminRoleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminRoleIdAbi.From(adminRoleId);

            var result = await base.SimApp(new List<object> { abiHandle, adminRoleIdAbi, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRoleOfAdminRole_Transactions(ulong adminRoleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 196, 152, 152 };
            var adminRoleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminRoleIdAbi.From(adminRoleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminRoleIdAbi, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="adminRoleId"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetRoleOfAdminRoleCount(ulong adminRoleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 104, 32, 82 };
            var adminRoleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminRoleIdAbi.From(adminRoleId);

            var result = await base.SimApp(new List<object> { abiHandle, adminRoleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetRoleOfAdminRoleCount_Transactions(ulong adminRoleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 104, 32, 82 };
            var adminRoleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminRoleIdAbi.From(adminRoleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminRoleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="adminRoleId"> </param>
        /// <param name="start"> </param>
        /// <param name="end"> </param>
        public async Task<ulong[]> GetRolesOfAdminRole(ulong adminRoleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 240, 189, 39 };
            var adminRoleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminRoleIdAbi.From(adminRoleId);

            var result = await base.SimApp(new List<object> { abiHandle, adminRoleIdAbi, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetRolesOfAdminRole_Transactions(ulong adminRoleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 240, 189, 39 };
            var adminRoleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminRoleIdAbi.From(adminRoleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminRoleIdAbi, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="__arc4_index"> </param>
        public async Task<Algorand.Address> GetRoleTarget(ulong roleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 55, 172, 248 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetRoleTarget_Transactions(ulong roleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 55, 172, 248 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="roleId"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetRoleTargetCount(ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 11, 244, 48 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetRoleTargetCount_Transactions(ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 11, 244, 48 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="__arc4_start"> </param>
        /// <param name="__arc4_end"> </param>
        public async Task<byte[][]> GetRoleTargets(ulong roleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_start, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 157, 26, 132 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi, __arc4_start, __arc4_end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> GetRoleTargets_Transactions(ulong roleId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_start, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 157, 26, 132 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, __arc4_start, __arc4_end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="target"> </param>
        /// <param name="__arc4_index"> </param>
        public async Task<byte[]> GetRoleTargetSelector(ulong roleId, Algorand.Address target, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 240, 142, 16 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi, targetAbi, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetRoleTargetSelector_Transactions(ulong roleId, Algorand.Address target, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 240, 142, 16 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, targetAbi, __arc4_index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="target"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetRoleTargetSelectorCount(ulong roleId, Algorand.Address target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 61, 111, 171 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi, targetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetRoleTargetSelectorCount_Transactions(ulong roleId, Algorand.Address target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 61, 111, 171 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, targetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManagerEnumerable
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="target"> </param>
        /// <param name="start"> </param>
        /// <param name="end"> </param>
        public async Task<byte[][]> GetRoleTargetSelectors(ulong roleId, Algorand.Address target, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 4, 243, 216 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi, targetAbi, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> GetRoleTargetSelectors_Transactions(ulong roleId, Algorand.Address target, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 4, 243, 216 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, targetAbi, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> AdminRole(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 195, 3, 5 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AdminRole_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 195, 3, 5 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> PublicRole(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 99, 118, 91 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PublicRole_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 99, 118, 91 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="caller"> </param>
        /// <param name="target"> </param>
        /// <param name="selector"> </param>
        public async Task<Structs.CanCallReturn> CanCall(Algorand.Address caller, Algorand.Address target, byte[] selector, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 121, 100, 49 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var selectorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); selectorAbi.From(selector);

            var result = await base.SimApp(new List<object> { abiHandle, callerAbi, targetAbi, selectorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CanCallReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CanCall_Transactions(Algorand.Address caller, Algorand.Address target, byte[] selector, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 121, 100, 49 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var selectorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); selectorAbi.From(selector);

            return await base.MakeTransactionList(new List<object> { abiHandle, callerAbi, targetAbi, selectorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        public async Task<ulong> Expiration(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 170, 87, 58 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Expiration_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 170, 87, 58 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        public async Task<ulong> MinSetback(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 242, 230, 33 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MinSetback_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 242, 230, 33 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="target"> </param>
        public async Task<bool> IsTargetClosed(Algorand.Address target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 68, 15, 87 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            var result = await base.SimApp(new List<object> { abiHandle, targetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsTargetClosed_Transactions(Algorand.Address target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 68, 15, 87 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="selector"> </param>
        public async Task<ulong> GetTargetFunctionRole(Algorand.Address target, byte[] selector, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 213, 69, 11 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var selectorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); selectorAbi.From(selector);

            var result = await base.SimApp(new List<object> { abiHandle, targetAbi, selectorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTargetFunctionRole_Transactions(Algorand.Address target, byte[] selector, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 213, 69, 11 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var selectorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); selectorAbi.From(selector);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, selectorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="target"> </param>
        public async Task<ulong> GetTargetAdminDelay(Algorand.Address target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 10, 205, 129 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            var result = await base.SimApp(new List<object> { abiHandle, targetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTargetAdminDelay_Transactions(Algorand.Address target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 10, 205, 129 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        public async Task<ulong> GetRoleAdmin(ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 117, 11, 35 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRoleAdmin_Transactions(ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 117, 11, 35 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        public async Task<ulong> GetRoleGuardian(ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 233, 40, 134 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRoleGuardian_Transactions(ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 233, 40, 134 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        public async Task<ulong> GetRoleGrantDelay(ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 188, 109, 67 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRoleGrantDelay_Transactions(ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 188, 109, 67 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="account"> </param>
        public async Task<Structs.GetAccessReturn> GetAccess(ulong roleId, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 245, 142, 117 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetAccessReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAccess_Transactions(ulong roleId, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 245, 142, 117 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="account"> </param>
        public async Task<Structs.HasRoleReturn> HasRole(ulong roleId, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 6, 103, 153 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, roleIdAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.HasRoleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> HasRole_Transactions(ulong roleId, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 6, 103, 153 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="label"> </param>
        public async Task LabelRole(ulong roleId, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 28, 55, 74 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);

            var result = await base.CallApp(new List<object> { abiHandle, roleIdAbi, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LabelRole_Transactions(ulong roleId, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 28, 55, 74 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="account"> </param>
        /// <param name="executionDelay"> </param>
        public async Task GrantRole(ulong roleId, Algorand.Address account, ulong executionDelay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 222, 23, 11 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var executionDelayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); executionDelayAbi.From(executionDelay);

            var result = await base.CallApp(new List<object> { abiHandle, roleIdAbi, accountAbi, executionDelayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantRole_Transactions(ulong roleId, Algorand.Address account, ulong executionDelay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 222, 23, 11 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var executionDelayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); executionDelayAbi.From(executionDelay);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, accountAbi, executionDelayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="account"> </param>
        public async Task RevokeRole(ulong roleId, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 138, 131, 168 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleIdAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeRole_Transactions(ulong roleId, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 138, 131, 168 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="callerConfirmation"> </param>
        public async Task RenounceRole(ulong roleId, Algorand.Address callerConfirmation, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 18, 85, 92 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var callerConfirmationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerConfirmationAbi.From(callerConfirmation);

            var result = await base.CallApp(new List<object> { abiHandle, roleIdAbi, callerConfirmationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenounceRole_Transactions(ulong roleId, Algorand.Address callerConfirmation, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 18, 85, 92 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var callerConfirmationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerConfirmationAbi.From(callerConfirmation);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, callerConfirmationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="admin"> </param>
        public async Task SetRoleAdmin(ulong roleId, ulong admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 240, 42, 39 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, roleIdAbi, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetRoleAdmin_Transactions(ulong roleId, ulong admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 240, 42, 39 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="guardian"> </param>
        public async Task SetRoleGuardian(ulong roleId, ulong guardian, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 68, 219, 158 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var guardianAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); guardianAbi.From(guardian);

            var result = await base.CallApp(new List<object> { abiHandle, roleIdAbi, guardianAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetRoleGuardian_Transactions(ulong roleId, ulong guardian, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 68, 219, 158 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var guardianAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); guardianAbi.From(guardian);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, guardianAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="roleId"> </param>
        /// <param name="newDelay"> </param>
        public async Task SetGrantDelay(ulong roleId, ulong newDelay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 74, 255, 64 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var newDelayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newDelayAbi.From(newDelay);

            var result = await base.CallApp(new List<object> { abiHandle, roleIdAbi, newDelayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetGrantDelay_Transactions(ulong roleId, ulong newDelay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 74, 255, 64 };
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);
            var newDelayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newDelayAbi.From(newDelay);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleIdAbi, newDelayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="selectors"> </param>
        /// <param name="roleId"> </param>
        public async Task SetTargetFunctionRole(Algorand.Address target, byte[][] selectors, ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 107, 138, 125 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var selectorsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("uint8[4]"); selectorsAbi.From(selectors);
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            var result = await base.CallApp(new List<object> { abiHandle, targetAbi, selectorsAbi, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTargetFunctionRole_Transactions(Algorand.Address target, byte[][] selectors, ulong roleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 107, 138, 125 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var selectorsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("uint8[4]"); selectorsAbi.From(selectors);
            var roleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleIdAbi.From(roleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, selectorsAbi, roleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="newDelay"> </param>
        public async Task SetTargetAdminDelay(Algorand.Address target, ulong newDelay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 237, 195, 46 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var newDelayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newDelayAbi.From(newDelay);

            var result = await base.CallApp(new List<object> { abiHandle, targetAbi, newDelayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTargetAdminDelay_Transactions(Algorand.Address target, ulong newDelay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 237, 195, 46 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var newDelayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newDelayAbi.From(newDelay);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, newDelayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="closed"> </param>
        public async Task SetTargetClosed(Algorand.Address target, bool closed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 213, 21, 46 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var closedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); closedAbi.From(closed);

            var result = await base.CallApp(new List<object> { abiHandle, targetAbi, closedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTargetClosed_Transactions(Algorand.Address target, bool closed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 213, 21, 46 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var closedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); closedAbi.From(closed);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, closedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="id"> </param>
        public async Task<ulong> GetSchedule(byte[] id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 156, 186, 14 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); idAbi.From(id);

            var result = await base.SimApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetSchedule_Transactions(byte[] id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 156, 186, 14 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="id"> </param>
        public async Task<ulong> GetNonce(byte[] id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 211, 130, 225 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); idAbi.From(id);

            var result = await base.SimApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetNonce_Transactions(byte[] id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 211, 130, 225 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="data"> </param>
        /// <param name="when"> </param>
        public async Task<Structs.ScheduleReturn> Schedule(Algorand.Address target, byte[] data, ulong when, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 50, 205, 209 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);
            var whenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); whenAbi.From(when);

            var result = await base.CallApp(new List<object> { abiHandle, targetAbi, dataAbi, whenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ScheduleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Schedule_Transactions(Algorand.Address target, byte[] data, ulong when, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 50, 205, 209 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);
            var whenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); whenAbi.From(when);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, dataAbi, whenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="data"> </param>
        public async Task<ulong> Execute(Algorand.Address target, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 92, 160, 134 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, targetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Execute_Transactions(Algorand.Address target, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 92, 160, 134 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="caller"> </param>
        /// <param name="target"> </param>
        /// <param name="data"> </param>
        public async Task<ulong> Cancel(Algorand.Address caller, Algorand.Address target, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 131, 102, 216 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, callerAbi, targetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Cancel_Transactions(Algorand.Address caller, Algorand.Address target, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 131, 102, 216 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, callerAbi, targetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="caller"> </param>
        /// <param name="data"> </param>
        public async Task ConsumeScheduledOp(Algorand.Address caller, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 154, 192, 75 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, callerAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConsumeScheduledOp_Transactions(Algorand.Address caller, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 154, 192, 75 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, callerAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="caller"> </param>
        /// <param name="target"> </param>
        /// <param name="data"> </param>
        public async Task<byte[]> HashOperation(Algorand.Address caller, Algorand.Address target, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 149, 28, 41 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.SimApp(new List<object> { abiHandle, callerAbi, targetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> HashOperation_Transactions(Algorand.Address caller, Algorand.Address target, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 149, 28, 41 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, callerAbi, targetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManager
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="newAuthority"> </param>
        public async Task UpdateAuthority(Algorand.Address target, Algorand.Address newAuthority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 152, 40, 213 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var newAuthorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAuthorityAbi.From(newAuthority);

            var result = await base.CallApp(new List<object> { abiHandle, targetAbi, newAuthorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAuthority_Transactions(Algorand.Address target, Algorand.Address newAuthority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 152, 40, 213 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var newAuthorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAuthorityAbi.From(newAuthority);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, newAuthorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IMulticall
        ///</summary>
        /// <param name="data"> </param>
        public async Task<byte[][]> Multicall(byte[][] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 145, 154, 38 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> Multicall_Transactions(byte[][] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 145, 154, 38 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DelegateUpdate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 94, 55, 152 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DelegateUpdate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 94, 55, 152 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWNjZXNzTWFuYWdlckVudW1lcmFibGVfX2NodW5rXzMiLCJkZXNjIjoiQHRpdGxlIEFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlXG4gQGF1dGhvciBBYXZlIExhYnNcbiBAbm90aWNlIEV4dGVuc2lvbiBvZiBBY2Nlc3NNYW5hZ2VyIHRoYXQgdHJhY2tzIHJvbGUgbWVtYmVycyBhbmQgdGhlaXIgZnVuY3Rpb24gc2VsZWN0b3JzIHVzaW5nIEVudW1lcmFibGVTZXQuXG4gQGRldiBSb2xlcywgdGFyZ2V0IGNvbnRyYWN0cywgYW5kIGZ1bmN0aW9uIHNlbGVjdG9ycyBhc3NpZ25lZCB0byBgQURNSU5fUk9MRWAgYXJlIGV4Y2x1ZGVkIGZyb20gdHJhY2tpbmcuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFkZHJlc3NTZXQiOlt7Im5hbWUiOiJfaW5uZXIiLCJ0eXBlIjoiU2V0In1dLCJCeXRlczMyU2V0IjpbeyJuYW1lIjoiX2lubmVyIiwidHlwZSI6IlNldCJ9XSwiUm9sZSI6W3sibmFtZSI6Im1lbWJlcnMiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYWRtaW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3VhcmRpYW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3JhbnREZWxheSIsInR5cGUiOiJ1aW50MTEyIn1dLCJTY2hlZHVsZSI6W3sibmFtZSI6InRpbWVwb2ludCIsInR5cGUiOiJ1aW50NDgifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MzIifV0sIlNldCI6W3sibmFtZSI6Il92YWx1ZXMiLCJ0eXBlIjoidWludDhbMzJdW10ifSx7Im5hbWUiOiJfcG9zaXRpb25zIiwidHlwZSI6ImJ5dGVbXSJ9XSwiVGFyZ2V0Q29uZmlnIjpbeyJuYW1lIjoiYWxsb3dlZFJvbGVzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImFkbWluRGVsYXkiLCJ0eXBlIjoidWludDExMiJ9LHsibmFtZSI6ImNsb3NlZCIsInR5cGUiOiJib29sIn1dLCJVaW50U2V0IjpbeyJuYW1lIjoiX2lubmVyIiwidHlwZSI6IlNldCJ9XSwiY2FuQ2FsbFJldHVybiI6W3sibmFtZSI6ImltbWVkaWF0ZSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZGVsYXkiLCJ0eXBlIjoidWludDY0In1dLCJnZXRBY2Nlc3NSZXR1cm4iOlt7Im5hbWUiOiJzaW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjdXJyZW50RGVsYXkiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGVuZGluZ0RlbGF5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVmZmVjdCIsInR5cGUiOiJ1aW50NjQifV0sImhhc1JvbGVSZXR1cm4iOlt7Im5hbWUiOiJpc01lbWJlciIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZXhlY3V0aW9uRGVsYXkiLCJ0eXBlIjoidWludDY0In1dLCJzY2hlZHVsZVJldHVybiI6W3sibmFtZSI6Im9wZXJhdGlvbklkIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoibm9uY2UiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fcG9zdEluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluaXRpYWxBZG1pbl8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9pbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZUNvdW50IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWRtaW5Sb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2luZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBZG1pblJvbGVDb3VudCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBZG1pblJvbGVzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZU1lbWJlciIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2luZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZU1lbWJlckNvdW50IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlTWVtYmVycyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3N0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50OFszMl1bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlT2ZBZG1pblJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluUm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2luZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlT2ZBZG1pblJvbGVDb3VudCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW5Sb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlc09mQWRtaW5Sb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pblJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVUYXJnZXQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9pbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVUYXJnZXRDb3VudCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZVRhcmdldHMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9zdGFydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9lbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDhbMzJdW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZVRhcmdldFNlbGVjdG9yIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlVGFyZ2V0U2VsZWN0b3JDb3VudCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZVRhcmdldFNlbGVjdG9ycyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDhbNF1bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJBRE1JTl9ST0xFIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJQVUJMSUNfUk9MRSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuQ2FsbCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsZWN0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsdWludDY0KSIsInN0cnVjdCI6ImNhbkNhbGxSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4cGlyYXRpb24iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pblNldGJhY2siLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzVGFyZ2V0Q2xvc2VkIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUYXJnZXRGdW5jdGlvblJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGVjdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUYXJnZXRBZG1pbkRlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVBZG1pbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVHdWFyZGlhbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVHcmFudERlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWNjZXNzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJnZXRBY2Nlc3NSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc1JvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQpIiwic3RydWN0IjoiaGFzUm9sZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGFiZWxSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFiZWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik9wZXJhdGlvbkV4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVMYWJlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYWJlbCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdyYW50Um9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleGVjdXRpb25EZWxheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUdyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGF5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2luY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3TWVtYmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV2b2tlUm9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlUmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVub3VuY2VSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlckNvbmZpcm1hdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUm9sZVJldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFJvbGVBZG1pbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlQWRtaW5DaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Um9sZUd1YXJkaWFuIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3VhcmRpYW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik9wZXJhdGlvbkV4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVHdWFyZGlhbkNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3VhcmRpYW4iLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRHcmFudERlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3RGVsYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik9wZXJhdGlvbkV4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVHcmFudERlbGF5Q2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VGFyZ2V0RnVuY3Rpb25Sb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4WzRdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxlY3RvcnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0RnVuY3Rpb25Sb2xlVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGVjdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VGFyZ2V0QWRtaW5EZWxheSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdEZWxheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0QWRtaW5EZWxheVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsYXkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaW5jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFRhcmdldENsb3NlZCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xvc2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJUYXJnZXRDbG9zZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsb3NlZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFNjaGVkdWxlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldE5vbmNlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNjaGVkdWxlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndoZW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbMzJdLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJzY2hlZHVsZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbmNlbCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29uc3VtZVNjaGVkdWxlZE9wIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGFzaE9wZXJhdGlvbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUF1dGhvcml0eSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QXV0aG9yaXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibXVsdGljYWxsIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElNdWx0aWNhbGwiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfX2RlbGVnYXRlX3VwZGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMzU4LDQzODhdLCJlcnJvck1lc3NhZ2UiOiJBQkkgYm9vbCB2YWxpZGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ2MCwxNDY4LDE5MjYsMTkzNCwyNDYyLDI0NzAsMjQ3OCw0ODUyXSwiZXJyb3JNZXNzYWdlIjoiQUJJIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzczXSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlckJhZENvbmZpcm1hdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1MzNdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyRXhwaXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NDQsMjAzOSwyMDQ2LDIxNjksMjE3NiwyNDg5LDI2OTQsMjcwMCw0Mjc0XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlckxvY2tlZFJvbGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTI3XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlck5vdFJlYWR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxOV0sImVycm9yTWVzc2FnZSI6IkFjY2Vzc01hbmFnZXJOb3RTY2hlZHVsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDkzXSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlclVuYXV0aG9yaXplZEFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTU1XSwiZXJyb3JNZXNzYWdlIjoiU2FmZUNhc3RPdmVyZmxvd2VkVWludERvd25jYXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDgxOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9leGVjdXRpb25JZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjI0LDM0NDAsMzQ2MF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjUsMTAxOSwxMTIxLDExNDUsMTE3NCwxMTk4LDEyMjIsMTU1MiwyNjcxLDMyMzAsMzMwMiwzMzk0LDM2NTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzQyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTI4LDExNTIsMTE4MSwxMjA1LDEyMjksMjY3OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDUzLDEwNjEsMTEwOCwxMTE1LDExMzksMTE2MSwxMTY4LDExOTIsMTIxNiwxMjQ4LDEyODcsMTMzNCwxNDM2LDE1NDMsMjM2MCwyMzk2LDI0MzgsMjczMywyNzY1LDI3ODgsMjc5OSwyODE4LDI4NDMsMjg1MywyOTY5LDMwMDMsMzAyMSwzMTc0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MDcsMjg2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMjgsMzA0NiwzMDUzLDMwODIsMzEyOCwzMTYzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NzcsMjk4NSwzMTAyLDMxMTAsMzE0MCwzMTQ4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDUxMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMzYsMTQ0NCwxNTc2LDE5MDAsMTkxMCwyMDE0LDIwMjQsMjEzNywyMTQ3LDIzNTEsMjM4NywyNDIzLDI0NDYsMjY2MywyNzI2LDI3NTgsMjc3NywyOTYyLDI5OTYsMzAxNCwzMDM5LDMwNjQsMzA3NSwzMDk0LDMxMjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDEzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKGxlbit1aW50OFtdKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNjgsMTI1NSwxMjk0LDEzNTIsMTQ1MiwxNTg2LDE5MTgsMjAzMSwyMTYxLDIzNjcsMjQwMywyNDU0LDI2ODYsMjg3MSwyOTI3LDI5NTFdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MjUsMjUzNiwyNTQ5LDQxMjMsNDE2NCw0ODY0XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzU3LDM0MDBdLCJlcnJvck1lc3NhZ2UiOiJ1bmRlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNWhjSEJ5YjNaaGJGOXdjbTluY21GdEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURBZ016SWdNU0E0SURReU9UUTVOamN5T1RVZ1ZFMVFURjlWVWs5VFgwMUJTVTVmUVZCUVgwbEVJREk0TVRRM05EazNOamN4TURZMU5TQXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhOUW9nSUNBZ1lubDBaV05pYkc5amF5QWlYMTl2WjE5MllXeDFaU0lnTUhneE5URm1OMk0zTlNBd2VDQXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TURBd01DQXdlREF3TURJd01EQTBNREF3TmpBd01EQXdNREF3SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0TURFZ01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptSURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdNSGd3TURJd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ0lsOXdiM05wZEdsdmJuTWlJREI0TURBeE1UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SUNKZmNtOXNaWE1pSUNKZllXUnRhVzVTYjJ4bGMxTmxkQ0lnSWw5eWIyeGxjMU5sZENJZ01IZzFaamN6TmpNMk9EWTFOalEzTlRaak5qVTNNMlV6WWpCak5EUXlPVGhtWXpGak1UUTVZV1ppWmpSak9EazVObVppT1RJME1qZGhaVFF4WlRRMk5EbGlPVE0wWTJFME9UVTVPVEZpTnpnMU1tSTROVFVnSWw5elkyaGxaSFZzWlhNaUlDSmZkR0Z5WjJWMGN5SWdJbDl5YjJ4bFZHOVVZWEpuWlhSVWIxTmxiR1ZqZEc5eVUyVjBJaUFpWDNKdmJHVlViMVJoY21kbGRGTmxkQ0lnTUhnd01ESXdJQ0p0WlcxaVpYSnpJaUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUNBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3SUNKZmNtOXNaVTFsYldKbGNsTmxkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQnVJREV4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0lpQ2lBZ0lDQmtkWEJ1SURFd0NpQWdJQ0J3ZFhOb2FXNTBJRFF3T1RZS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSE4wYjNKbElEVUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREE0TUFvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lITjBiM0psSURBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lIQjFjMmhpZVhSbGN5QWlYMTlqZEc5eVgzQmxibVJwYm1jaUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaR00xWlRNM09UZ2dMeThnYldWMGFHOWtJQ0pmWDJSbGJHVm5ZWFJsWDNWd1pHRjBaU2dwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlgxOWtaV3hsWjJGMFpWOTFjR1JoZEdWZmNtOTFkR1ZBTkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T1Rrd1pqTXdZV1VnTUhoalptTTFPVGd3WXlBd2VEVXdOR1ZtWmpBeUlEQjRaRE0xTlRZMFpEVWdNSGc0WXpRMk5EUTFaQ0F3ZURoaVpUTXlZelkySURCNE0yTTFaR0ZrTkdFZ01IZzVNek5tWW1JMllTQXdlRFJqWmpoallqSmxJREI0TmpFMk9ERXdOalFnTUhoalptTTBPVGc1T0NBd2VHVTBOamd5TURVeUlEQjROV0ZtTUdKa01qY2dNSGhtTnpNM1lXTm1PQ0F3ZUdFd01HSm1ORE13SURCNE1ESTVaREZoT0RRZ01IaGtZbVl3T0dVeE1DQXdlR0ptTTJRMlptRmlJREI0TkdNd05HWXpaRGdnTUhnMlpHTXpNRE13TlNBd2VHSm1Oak0zTmpWaUlEQjRaREEzT1RZME16RWdNSGc1WldGaE5UY3pZU0F3ZUdObVpqSmxOakl4SURCNFpEUTBOREJtTlRjZ01IZzROMlExTkRVd1lpQXdlREpqTUdGalpEZ3hJREI0WkdFM05UQmlNak1nTUhneE0yVTVNamc0TmlBd2VETmtZbU0yWkRReklEQjRPVEJtTlRobE56VWdNSGhtTVRBMk5qYzVPU0F3ZURnNU1XTXpOelJoSURCNFl6UmtaVEUzTUdJZ01IaG1NVGhoT0ROaE9DQXdlR0kxTVRJMU5UVmpJREI0TW1SbU1ESmhNamNnTUhneU9EUTBaR0k1WlNBd2VETTBOR0ZtWmpRd0lEQjRaRGsyWWpoaE4yUWdNSGd3Tm1Wa1l6TXlaU0F3ZUdNMlpEVXhOVEpsSURCNFlXTTVZMkpoTUdVZ01IZzROV1F6T0RKbE1TQXdlREpoTXpKalpHUXhJREI0TTJJMVkyRXdPRFlnTUhneVl6Z3pOalprT0NBd2VEWTJPV0ZqTURSaUlEQjRNRFE1TlRGak1qa2dNSGhrWkRrNE1qaGtOU0F3ZURBME9URTVZVEkySUM4dklHMWxkR2h2WkNBaVgxOXdiM04wU1c1cGRDaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGSnZiR1VvZFdsdWRESTFOaWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEZKdmJHVkRiM1Z1ZENncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVoyVjBVbTlzWlhNb2RXbHVkRFV4TWl4MWFXNTBOVEV5S1hWcGJuUTJORnRkSWl3Z2JXVjBhRzlrSUNKblpYUkJaRzFwYmxKdmJHVW9kV2x1ZERJMU5pbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRUZrYldsdVVtOXNaVU52ZFc1MEtDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSm5aWFJCWkcxcGJsSnZiR1Z6S0hWcGJuUTFNVElzZFdsdWREVXhNaWwxYVc1ME5qUmJYU0lzSUcxbGRHaHZaQ0FpWjJWMFVtOXNaVTFsYldKbGNpaDFhVzUwTmpRc2RXbHVkREkxTmlsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKblpYUlNiMnhsVFdWdFltVnlRMjkxYm5Rb2RXbHVkRFkwS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1kbGRGSnZiR1ZOWlcxaVpYSnpLSFZwYm5RMk5DeDFhVzUwTWpVMkxIVnBiblF5TlRZcGRXbHVkRGhiTXpKZFcxMGlMQ0J0WlhSb2IyUWdJbWRsZEZKdmJHVlBaa0ZrYldsdVVtOXNaU2gxYVc1ME5qUXNkV2x1ZERJMU5pbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRkp2YkdWUFprRmtiV2x1VW05c1pVTnZkVzUwS0hWcGJuUTJOQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0puWlhSU2IyeGxjMDltUVdSdGFXNVNiMnhsS0hWcGJuUTJOQ3gxYVc1ME5URXlMSFZwYm5RMU1USXBkV2x1ZERZMFcxMGlMQ0J0WlhSb2IyUWdJbWRsZEZKdmJHVlVZWEpuWlhRb2RXbHVkRFkwTEhWcGJuUXlOVFlwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpWjJWMFVtOXNaVlJoY21kbGRFTnZkVzUwS0hWcGJuUTJOQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0puWlhSU2IyeGxWR0Z5WjJWMGN5aDFhVzUwTmpRc2RXbHVkREkxTml4MWFXNTBNalUyS1hWcGJuUTRXek15WFZ0ZElpd2diV1YwYUc5a0lDSm5aWFJTYjJ4bFZHRnlaMlYwVTJWc1pXTjBiM0lvZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbGllWFJsV3pSZElpd2diV1YwYUc5a0lDSm5aWFJTYjJ4bFZHRnlaMlYwVTJWc1pXTjBiM0pEYjNWdWRDaDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKblpYUlNiMnhsVkdGeVoyVjBVMlZzWldOMGIzSnpLSFZwYm5RMk5DeGhaR1J5WlhOekxIVnBiblExTVRJc2RXbHVkRFV4TWlsMWFXNTBPRnMwWFZ0ZElpd2diV1YwYUc5a0lDSkJSRTFKVGw5U1QweEZLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbEJWUWt4SlExOVNUMHhGS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1OaGJrTmhiR3dvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0o1ZEdWYk5GMHBLR0p2YjJ3c2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVpYaHdhWEpoZEdsdmJpZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSnRhVzVUWlhSaVlXTnJLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWx6VkdGeVoyVjBRMnh2YzJWa0tHRmtaSEpsYzNNcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFZHRnlaMlYwUm5WdVkzUnBiMjVTYjJ4bEtHRmtaSEpsYzNNc1lubDBaVnMwWFNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhrb1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGSnZiR1ZCWkcxcGJpaDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUlNiMnhsUjNWaGNtUnBZVzRvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwVW05c1pVZHlZVzUwUkdWc1lYa29kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBRV05qWlhOektIVnBiblEyTkN4aFpHUnlaWE56S1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm9ZWE5TYjJ4bEtIVnBiblEyTkN4aFpHUnlaWE56S1NoaWIyOXNMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbXhoWW1Wc1VtOXNaU2gxYVc1ME5qUXNjM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW1keVlXNTBVbTlzWlNoMWFXNTBOalFzWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVjJiMnRsVW05c1pTaDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p5Wlc1dmRXNWpaVkp2YkdVb2RXbHVkRFkwTEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljMlYwVW05c1pVRmtiV2x1S0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBVbTlzWlVkMVlYSmthV0Z1S0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBSM0poYm5SRVpXeGhlU2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGUmhjbWRsZEVaMWJtTjBhVzl1VW05c1pTaGhaR1J5WlhOekxIVnBiblE0V3pSZFcxMHNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhrb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwVkdGeVoyVjBRMnh2YzJWa0tHRmtaSEpsYzNNc1ltOXZiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJUWTJobFpIVnNaU2hpZVhSbFd6TXlYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEU1dmJtTmxLR0o1ZEdWYk16SmRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljMk5vWldSMWJHVW9ZV1JrY21WemN5eGllWFJsVzEwc2RXbHVkRFkwS1NoaWVYUmxXek15WFN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKbGVHVmpkWFJsS0dGa1pISmxjM01zWW5sMFpWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZMkZ1WTJWc0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWVYUmxXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqYjI1emRXMWxVMk5vWldSMWJHVmtUM0FvWVdSa2NtVnpjeXhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWFHRnphRTl3WlhKaGRHbHZiaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZbmwwWlZ0ZEtXSjVkR1ZiTXpKZElpd2diV1YwYUc5a0lDSjFjR1JoZEdWQmRYUm9iM0pwZEhrb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbTExYkhScFkyRnNiQ2hpZVhSbFcxMWJYU2xpZVhSbFcxMWJYU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZYMTl3YjNOMFNXNXBkRjl5YjNWMFpVQTNJRzFoYVc1ZloyVjBVbTlzWlY5eWIzVjBaVUE0SUcxaGFXNWZaMlYwVW05c1pVTnZkVzUwWDNKdmRYUmxRRGtnYldGcGJsOW5aWFJTYjJ4bGMxOXliM1YwWlVBeE1DQnRZV2x1WDJkbGRGSnZiR1ZmY205MWRHVkFPQ0J0WVdsdVgyZGxkRkp2YkdWRGIzVnVkRjl5YjNWMFpVQTVJRzFoYVc1ZloyVjBVbTlzWlhOZmNtOTFkR1ZBTVRBZ2JXRnBibDluWlhSU2IyeGxUV1Z0WW1WeVgzSnZkWFJsUURFMElHMWhhVzVmWjJWMFVtOXNaVTFsYldKbGNrTnZkVzUwWDNKdmRYUmxRREUxSUcxaGFXNWZaMlYwVW05c1pVMWxiV0psY25OZmNtOTFkR1ZBTVRZZ2JXRnBibDluWlhSU2IyeGxUMlpCWkcxcGJsSnZiR1ZmY205MWRHVkFNVGNnYldGcGJsOW5aWFJTYjJ4bFRXVnRZbVZ5UTI5MWJuUmZjbTkxZEdWQU1UVWdiV0ZwYmw5blpYUlNiMnhsYzA5bVFXUnRhVzVTYjJ4bFgzSnZkWFJsUURFNUlHMWhhVzVmWjJWMFVtOXNaVTFsYldKbGNsOXliM1YwWlVBeE5DQnRZV2x1WDJkbGRGSnZiR1ZOWlcxaVpYSkRiM1Z1ZEY5eWIzVjBaVUF4TlNCdFlXbHVYMmRsZEZKdmJHVk5aVzFpWlhKelgzSnZkWFJsUURFMklHMWhhVzVmWjJWMFVtOXNaVlJoY21kbGRGTmxiR1ZqZEc5eVgzSnZkWFJsUURJeklHMWhhVzVmWjJWMFVtOXNaVlJoY21kbGRGTmxiR1ZqZEc5eVEyOTFiblJmY205MWRHVkFNalFnYldGcGJsOW5aWFJTYjJ4bFZHRnlaMlYwVTJWc1pXTjBiM0p6WDNKdmRYUmxRREkxSUcxaGFXNWZRVVJOU1U1ZlVrOU1SVjl5YjNWMFpVQXlOaUJ0WVdsdVgxQlZRa3hKUTE5U1QweEZYM0p2ZFhSbFFESTNJRzFoYVc1ZlkyRnVRMkZzYkY5eWIzVjBaVUF5T0NCdFlXbHVYMlY0Y0dseVlYUnBiMjVmY205MWRHVkFNamtnYldGcGJsOWxlSEJwY21GMGFXOXVYM0p2ZFhSbFFESTVJRzFoYVc1ZmFYTlVZWEpuWlhSRGJHOXpaV1JmY205MWRHVkFNekVnYldGcGJsOW5aWFJVWVhKblpYUkdkVzVqZEdsdmJsSnZiR1ZmY205MWRHVkFNeklnYldGcGJsOW5aWFJVWVhKblpYUkJaRzFwYmtSbGJHRjVYM0p2ZFhSbFFETXpJRzFoYVc1ZloyVjBVbTlzWlVGa2JXbHVYM0p2ZFhSbFFETTBJRzFoYVc1ZloyVjBVbTlzWlVGa2JXbHVYM0p2ZFhSbFFETTBJRzFoYVc1ZloyVjBVbTlzWlVGa2JXbHVYM0p2ZFhSbFFETTBJRzFoYVc1ZloyVjBRV05qWlhOelgzSnZkWFJsUURNM0lHMWhhVzVmYUdGelVtOXNaVjl5YjNWMFpVQXpPQ0J0WVdsdVgyeGhZbVZzVW05c1pWOXliM1YwWlVBek9TQnRZV2x1WDJkeVlXNTBVbTlzWlY5eWIzVjBaVUEwTUNCdFlXbHVYM0psZG05clpWSnZiR1ZmY205MWRHVkFOREVnYldGcGJsOXlaVzV2ZFc1alpWSnZiR1ZmY205MWRHVkFORElnYldGcGJsOXpaWFJTYjJ4bFFXUnRhVzVmY205MWRHVkFORE1nYldGcGJsOXpaWFJTYjJ4bFIzVmhjbVJwWVc1ZmNtOTFkR1ZBTkRRZ2JXRnBibDl6WlhSSGNtRnVkRVJsYkdGNVgzSnZkWFJsUURRMUlHMWhhVzVmYzJWMFZHRnlaMlYwUm5WdVkzUnBiMjVTYjJ4bFgzSnZkWFJsUURRMklHMWhhVzVmYzJWMFZHRnlaMlYwUVdSdGFXNUVaV3hoZVY5eWIzVjBaVUEwTnlCdFlXbHVYM05sZEZSaGNtZGxkRU5zYjNObFpGOXliM1YwWlVBME9DQnRZV2x1WDJkbGRGTmphR1ZrZFd4bFgzSnZkWFJsUURRNUlHMWhhVzVmWjJWMFRtOXVZMlZmY205MWRHVkFOVEFnYldGcGJsOXpZMmhsWkhWc1pWOXliM1YwWlVBMU1TQnRZV2x1WDJWNFpXTjFkR1ZmY205MWRHVkFOVElnYldGcGJsOWpZVzVqWld4ZmNtOTFkR1ZBTlRNZ2JXRnBibDlqYjI1emRXMWxVMk5vWldSMWJHVmtUM0JmY205MWRHVkFOVFFnYldGcGJsOW9ZWE5vVDNCbGNtRjBhVzl1WDNKdmRYUmxRRFUxSUcxaGFXNWZkWEJrWVhSbFFYVjBhRzl5YVhSNVgzSnZkWFJsUURVMklHMWhhVzVmYlhWc2RHbGpZV3hzWDNKdmRYUmxRRFUzQ2lBZ0lDQmxjbklLQ20xaGFXNWZiWFZzZEdsallXeHNYM0p2ZFhSbFFEVTNPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFeENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDb0tJQ0FnSUdKMWNua2dOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdKMWNua2dNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKMWNua2dNaklLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJRGNLQ20xaGFXNWZabTl5WDJobFlXUmxja0EyTWpvS0lDQWdJR1JwWnlBMkNpQWdJQ0JrYVdjZ09Rb2dJQ0FnUEFvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5bWIzSkFOalFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURJekNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRGdLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJtYjNJZ0tHeGxiaXNvYkdWdUszVnBiblE0VzEwcFcxMHBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCaWRYSjVJRFlLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlEY0tJQ0FnSUdJZ2JXRnBibDltYjNKZmFHVmhaR1Z5UURZeUNncHRZV2x1WDJGbWRHVnlYMlp2Y2tBMk5Eb0tJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrUGdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkWEJrWVhSbFFYVjBhRzl5YVhSNVgzSnZkWFJsUURVMk9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR2x1ZEdNZ05TQXZMeUJVVFZCTVgxVlNUMU5mVFVGSlRsOUJVRkJmU1VRS0lDQWdJR0o1ZEdWalh6QWdMeThnSWw5ZmIyZGZkbUZzZFdVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR05oYkd4emRXSWdYMk5vWldOclFYVjBhRzl5YVhwbFpBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WTJSa1lUUmxZVFlnTHk4Z2JXVjBhRzlrSUNKelpYUkJkWFJvYjNKcGRIa29ZV1JrY21WemN5bDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW9ZWE5vVDNCbGNtRjBhVzl1WDNKdmRYUmxRRFUxT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTI5dWMzVnRaVk5qYUdWa2RXeGxaRTl3WDNKdmRYUmxRRFUwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5allXNWpaV3hmY205MWRHVkFOVE02Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaWGhsWTNWMFpWOXliM1YwWlVBMU1qb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elkyaGxaSFZzWlY5eWIzVjBaVUExTVRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBUbTl1WTJWZmNtOTFkR1ZBTlRBNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR2x1ZEdNZ05TQXZMeUJVVFZCTVgxVlNUMU5mVFVGSlRsOUJVRkJmU1VRS0lDQWdJR0o1ZEdWalh6QWdMeThnSWw5ZmIyZGZkbUZzZFdVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVGNnTHk4Z0lsOXpZMmhsWkhWc1pYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRETXlDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSVFkyaGxaSFZzWlY5eWIzVjBaVUEwT1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdhVzUwWXlBMUlDOHZJRlJOVUV4ZlZWSlBVMTlOUVVsT1gwRlFVRjlKUkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWDE5dloxOTJZV3gxWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhOeUF2THlBaVgzTmphR1ZrZFd4bGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ01DQTJDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnWDJselJYaHdhWEpsWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdhVzUwWXlBMklDOHZJREk0TVRRM05EazNOamN4TURZMU5Rb2dJQ0FnSmdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6WlhSVVlYSm5aWFJEYkc5elpXUmZjbTkxZEdWQU5EZzZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdsdWRHTWdOU0F2THlCVVRWQk1YMVZTVDFOZlRVRkpUbDlCVUZCZlNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lsOWZiMmRmZG1Gc2RXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRWFYwYUc5eWFYcGxaQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUVVKSklHSnZiMndnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdaR2xuSURFS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVGdnTHk4Z0lsOTBZWEpuWlhSeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURBeE1UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURFMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqWlRkaE5qVXdaaUF2THlCdFpYUm9iMlFnSWxSaGNtZGxkRU5zYjNObFpDaDFhVzUwT0Zzek1sMHNZbTl2YkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUlVZWEpuWlhSQlpHMXBia1JsYkdGNVgzSnZkWFJsUURRM09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpJRFVnTHk4Z1ZFMVFURjlWVWs5VFgwMUJTVTVmUVZCUVgwbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmZYMjluWDNaaGJIVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCallXeHNjM1ZpSUY5amFHVmphMEYxZEdodmNtbDZaV1FLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUEwSUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUVVKSklIWmhiR2xrWVhScGIyNEtJQ0FnSUdsdWRHTWdOQ0F2THlBME1qazBPVFkzTWprMUNpQWdJQ0FtQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGQ1NTQjJZV3hwWkdGMGFXOXVDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdaR2xuSURFS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVGdnTHk4Z0lsOTBZWEpuWlhSeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURBeE1UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBeE5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJRlJwYldVdWQybDBhRlZ3WkdGMFpRb2dJQ0FnY0c5d2JpQXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUF3ZURBd01URXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURJZ01UUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuZHBkR2hWY0dSaGRHVUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIQnZjQW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTXpZVEZtTWpJeElDOHZJRzFsZEdodlpDQWlWR0Z5WjJWMFFXUnRhVzVFWld4aGVWVndaR0YwWldRb2RXbHVkRGhiTXpKZExIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzJWMFZHRnlaMlYwUm5WdVkzUnBiMjVTYjJ4bFgzSnZkWFJsUURRMk9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTJDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVGNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1nb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRFErUGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHbHVkR01nTlNBdkx5QlVUVkJNWDFWU1QxTmZUVUZKVGw5QlVGQmZTVVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yUVhWMGFHOXlhWHBsWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lHSjFjbmtnTVRrS0NtMWhhVzVmZDJocGJHVmZkRzl3UURnM09nb2dJQ0FnWkdsbklEa0tJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXhPUW9nSUNBZ1lqNEtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOallLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1pHbG5JREU1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXhOZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhPQW9nSUNBZ1pIVndDaUFnSUNCemFHRXlOVFlLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZV3hzYjNkbFpGSnZiR1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNalFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR1JwWnlBeE5nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXhOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrTlRRNU5qSTVOeUF2THlCdFpYUm9iMlFnSWxSaGNtZGxkRVoxYm1OMGFXOXVVbTlzWlZWd1pHRjBaV1FvZFdsdWREaGJNekpkTEhWcGJuUTRXelJkTEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdYM1J5WVdOclVtOXNaUW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbDkwWVhKblpYUlViMU5sYkdWamRHOXlWRzlTYjJ4bElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNakFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFlLSUNBZ0lEMDlDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwYm14cGJtVmtYeTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbDkwY21GamExSnZiR1ZVWVhKblpYUlRaV3hsWTNSdmNrQXhORGdLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRMUNpQWdJQ0JrYVdjZ013b2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXpDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhPU0F2THlBaVgzSnZiR1ZVYjFSaGNtZGxkRlJ2VTJWc1pXTjBiM0pUWlhRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURJd01EQTBNREF3TmpBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhCMWMyaHBiblFnTWpnS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBMbkpsYlc5MlpRb2dJQ0FnY0c5d0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JqWVd4c2MzVmlJRVZ1ZFcxbGNtRmliR1ZUWlhRdWJHVnVaM1JvQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGdLSUNBZ0lHSTlQUW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUwTlFvZ0lDQWdaR2xuSURFeENpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJREl3SUM4dklDSmZjbTlzWlZSdlZHRnlaMlYwVTJWMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBeU1EQXdOREF3TURZd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VSVzUxYldWeVlXSnNaVk5sZEM1eVpXMXZkbVVvTWlsZk1Rb2dJQ0FnY0c5d0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhORFU2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFME53b2dJQ0FnWkdsbklERTVDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXhOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVGtnTHk4Z0lsOXliMnhsVkc5VVlYSm5aWFJVYjFObGJHVmpkRzl5VTJWMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBeU1EQXdOREF3TURZd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCd2RYTm9hVzUwSURJNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkdsbklESXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTmhiR3h6ZFdJZ1JXNTFiV1Z5WVdKc1pWTmxkQzVoWkdRS0lDQWdJSEJ2Y0FvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklESXdJQzh2SUNKZmNtOXNaVlJ2VkdGeVoyVjBVMlYwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF5TURBd05EQXdNRFl3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VSVzUxYldWeVlXSnNaVk5sZEM1aFpHUW9NaWxmTVFvZ0lDQWdjRzl3Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5EYzZDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHUnBaeUF5TUFvZ0lDQWdZbTk0WDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwYm14cGJtVmtYeTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbDkwY21GamExSnZiR1ZVWVhKblpYUlRaV3hsWTNSdmNrQXhORGc2Q2lBZ0lDQmthV2NnTVRnS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01Rb2dJQ0FnWWlzS0lDQWdJR0oxY25rZ01Ua0tJQ0FnSUdJZ2JXRnBibDkzYUdsc1pWOTBiM0JBT0RjS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOalk2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM05sZEVkeVlXNTBSR1ZzWVhsZmNtOTFkR1ZBTkRVNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR01nTlNBdkx5QlVUVkJNWDFWU1QxTmZUVUZKVGw5QlVGQmZTVVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yUVhWMGFHOXlhWHBsWkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dkbUZzYVdSaGRHbHZiZ29nSUNBZ2FXNTBZeUEwSUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNZS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1FVSkpJSFpoYkdsa1lYUnBiMjRLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QTNJQzh2SURFNE5EUTJOelEwTURjek56QTVOVFV4TmpFMUNpQWdJQ0E5UFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6YzAxaGJtRm5aWEpNYjJOclpXUlNiMnhsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKZmNtOXNaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEQXdNakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTVRnZ01UUUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuZHBkR2hWY0dSaGRHVUtJQ0FnSUhCdmNHNGdNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURBd01qQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNVGdnTVRRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG5kcGRHaFZjR1JoZEdVS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCdmNBb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdGa1pUazFNMk5tSUM4dklHMWxkR2h2WkNBaVVtOXNaVWR5WVc1MFJHVnNZWGxEYUdGdVoyVmtLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGSnZiR1ZIZFdGeVpHbGhibDl5YjNWMFpVQTBORG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnYVc1MFl5QTFJQzh2SUZSTlVFeGZWVkpQVTE5TlFVbE9YMEZRVUY5SlJBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVgxOXZaMTkyWVd4MVpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWTJGc2JITjFZaUJmWTJobFkydEJkWFJvYjNKcGVtVmtDaUFnSUNCa2FXY2dNUW9nSUNBZ0lRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZqWTJWemMwMWhibUZuWlhKTWIyTnJaV1JTYjJ4bENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QTNJQzh2SURFNE5EUTJOelEwTURjek56QTVOVFV4TmpFMUNpQWdJQ0E5UFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6YzAxaGJtRm5aWEpNYjJOclpXUlNiMnhsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaVgzSnZiR1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZ3dNREl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTWlBNENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F4T0NBeE5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJREl4SUM4dklEQjRNREF5TUFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJZbU0zT0Rkak5pQXZMeUJ0WlhSb2IyUWdJbEp2YkdWSGRXRnlaR2xoYmtOb1lXNW5aV1FvZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ1kyRnNiSE4xWWlCZmRISmhZMnRTYjJ4bENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGSnZiR1ZCWkcxcGJsOXliM1YwWlVBME16b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR0oxY25rZ01UVUtJQ0FnSUdsdWRHTWdOU0F2THlCVVRWQk1YMVZTVDFOZlRVRkpUbDlCVUZCZlNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lsOWZiMmRmZG1Gc2RXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRWFYwYUc5eWFYcGxaQW9nSUNBZ1pHbG5JREVLSUNBZ0lDRUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVRHOWphMlZrVW05c1pRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTWdOeUF2THlBeE9EUTBOamMwTkRBM016Y3dPVFUxTVRZeE5Rb2dJQ0FnUFQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNOTllXNWhaMlZ5VEc5amEyVmtVbTlzWlFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE9Bb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlYM0p2YkdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3TURJd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01UZ2dNVFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElERXdJRGdLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeU1TQXZMeUF3ZURBd01qQUtJQ0FnSUdScFp5QTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1RMFkyWTRPVEFnTHk4Z2JXVjBhRzlrSUNKU2IyeGxRV1J0YVc1RGFHRnVaMlZrS0hWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHTmhiR3h6ZFdJZ1gzUnlZV05yVW05c1pRb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTJOZ29nSUNBZ1pHbG5JREV3Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZMkNpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaVgyRmtiV2x1VW05c1pYTlRaWFFpQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdNakF3TURRd01EQTJNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURFeENpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBMbUZrWkNneUtWOHlDaUFnSUNCd2IzQUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJbDloWkcxcGJsSnZiR1Z6VTJWMElnb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWlYMkZrYldsdVVtOXNaWE5UWlhRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lIQjFjMmhpZVhSbGN5QWlYM0p2YkdWQlpHMXBibFJ2VW05c1pWTmxkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdNakF3TURRd01EQTJNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURFMENpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtWdWRXMWxjbUZpYkdWVFpYUXVZV1JrS0RJcFh6SUtJQ0FnSUhCdmNBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5qWUtDbTFoYVc1ZmNtVnViM1Z1WTJWU2IyeGxYM0p2ZFhSbFFEUXlPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQnBiblJqSURVZ0x5OGdWRTFRVEY5VlVrOVRYMDFCU1U1ZlFWQlFYMGxFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pmWDI5blgzWmhiSFZsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmtkWEFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUNFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV05qWlhOelRXRnVZV2RsY2tKaFpFTnZibVpwY20xaGRHbHZiZ29nSUNBZ1kyRnNiSE4xWWlCZmNtVjJiMnRsVW05c1pRb2dJQ0FnY0c5d0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKbGRtOXJaVkp2YkdWZmNtOTFkR1ZBTkRFNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdsdWRHTWdOU0F2THlCVVRWQk1YMVZTVDFOZlRVRkpUbDlCVUZCZlNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lsOWZiMmRmZG1Gc2RXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRWFYwYUc5eWFYcGxaQW9nSUNBZ1kyRnNiSE4xWWlCZmNtVjJiMnRsVW05c1pRb2dJQ0FnY0c5d0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkeVlXNTBVbTlzWlY5eWIzVjBaVUEwTURvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5SaklEVWdMeThnVkUxUVRGOVZVazlUWDAxQlNVNWZRVkJRWDBsRUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKZlgyOW5YM1poYkhWbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwRjFkR2h2Y21sNlpXUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVUpKSUhaaGJHbGtZWFJwYjI0S0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQW1DaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBME1qazBPVFkzTWprMUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZDU1NCMllXeHBaR0YwYVc5dUNpQWdJQ0JwYm5SaklEUWdMeThnTkRJNU5EazJOekk1TlFvZ0lDQWdKZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCUWtrZ2RtRnNhV1JoZEdsdmJnb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdNZ055QXZMeUF4T0RRME5qYzBOREEzTXpjd09UVTFNVFl4TlFvZ0lDQWdQVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQlkyTmxjM05OWVc1aFoyVnlURzlqYTJWa1VtOXNaUW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeU1pQXZMeUFpYldWdFltVnljeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFNUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBd0lEWUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXpDaUFnSUNCa2RYQUtJQ0FnSUNFS0lDQWdJR0oxY25rZ053b2dJQ0FnWW01NklHMWhhVzVmWld4elpWOWliMlI1UURFMk13b2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuUnBiV1Z6ZEdGdGNBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEWWdMeThnTWpneE5EYzBPVGMyTnpFd05qVTFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnT0FvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG5SdlJHVnNZWGtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCd2RYTm9hVzUwSURFMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0pwZEd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwT0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWlhoMGNtRmpkQ0F5SURZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERTVDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UWTBPZ29nSUNBZ1pHbG5JRGdLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pHbG5JRGtLSUNBZ0lITmxkR0pwZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHUnBaeUF5TmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEbGtOV0k0WkRJM0lDOHZJRzFsZEdodlpDQWlVbTlzWlVkeVlXNTBaV1FvZFdsdWREWTBMSFZwYm5RNFd6TXlYU3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR1JwWnlBeENpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTJOZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZmRISmhZMnRTYjJ4bENpQWdJQ0JrYVdjZ01qTUtJQ0FnSUdScFp5QTNDaUFnSUNCallXeHNjM1ZpSUY5MGNtRmphMUp2YkdWTlpXMWlaWElLSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUyTmdvS2JXRnBibDlsYkhObFgySnZaSGxBTVRZek9nb2dJQ0FnWkdsbklERTNDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNVFFLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmpZV3hzYzNWaUlGUnBiV1V1ZDJsMGFGVndaR0YwWlFvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBMklERTBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuZHBkR2hWY0dSaGRHVUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFkwQ2dwdFlXbHVYMnhoWW1Wc1VtOXNaVjl5YjNWMFpVQXpPVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdsdWRHTWdOU0F2THlCVVRWQk1YMVZTVDFOZlRVRkpUbDlCVUZCZlNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lsOWZiMmRmZG1Gc2RXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRWFYwYUc5eWFYcGxaQW9nSUNBZ1pHbG5JREVLSUNBZ0lDRUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVRHOWphMlZrVW05c1pRb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFl5QTNJQzh2SURFNE5EUTJOelEwTURjek56QTVOVFV4TmpFMUNpQWdJQ0E5UFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6YzAxaGJtRm5aWEpNYjJOclpXUlNiMnhsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURCaENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNekk0WWpneE5tWWdMeThnYldWMGFHOWtJQ0pTYjJ4bFRHRmlaV3dvZFdsdWREWTBMSE4wY21sdVp5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW9ZWE5TYjJ4bFgzSnZkWFJsUURNNE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBRV05qWlhOelgzSnZkWFJsUURNM09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHSjVkR1ZqSURJeklDOHZJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVW05c1pVRmtiV2x1WDNKdmRYUmxRRE0wT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSVVlYSm5aWFJCWkcxcGJrUmxiR0Y1WDNKdmRYUmxRRE16T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRlJoY21kbGRFWjFibU4wYVc5dVVtOXNaVjl5YjNWMFpVQXpNam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBMFBnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmx6VkdGeVoyVjBRMnh2YzJWa1gzSnZkWFJsUURNeE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJWNGNHbHlZWFJwYjI1ZmNtOTFkR1ZBTWprNkNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMkZ1UTJGc2JGOXliM1YwWlVBeU9Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVGNLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4T1FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lEUStDaUFnSUNCcGJuUmpJRFVnTHk4Z1ZFMVFURjlWVWs5VFgwMUJTVTVmUVZCUVgwbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmZYMjluWDNaaGJIVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCcGJuUmpJRFVnTHk4Z1ZFMVFURjlWVWs5VFgwMUJTVTVmUVZCUVgwbEVDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCQlpHUnlaWE56Q2lBZ0lDQndiM0FLSUNBZ0lEMDlDaUFnSUNCaWJub2diV0ZwYmw5cFpsOWliMlI1UURFeU9Rb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdZbnBsY204S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWpFS0lDQWdJRDA5Q2lBZ0lDQmllaUJ0WVdsdVgyVnNjMlZmWW05a2VVQXhNekFLQ20xaGFXNWZhV1pmWW05a2VVQXhNams2Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR1JwWnlBeE53b2dJQ0FnWTJGc2JITjFZaUJmYVhORmVHVmpkWFJwYm1jS0NtMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOHZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNWpZVzVEWVd4c1FERXpORG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpXeHpaVjlpYjJSNVFERXpNRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOHZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNWpZVzVEWVd4c1FERXpOQW9LYldGcGJsOVFWVUpNU1VOZlVrOU1SVjl5YjNWMFpVQXlOem9LSUNBZ0lHbHVkR01nTlNBdkx5QlVUVkJNWDFWU1QxTmZUVUZKVGw5QlVGQmZTVVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFabVptWm1abVptWm1abVptWm1abVpnb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDBGRVRVbE9YMUpQVEVWZmNtOTFkR1ZBTWpZNkNpQWdJQ0JwYm5SaklEVWdMeThnVkUxUVRGOVZVazlUWDAxQlNVNWZRVkJRWDBsRUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKZlgyOW5YM1poYkhWbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVW05c1pWUmhjbWRsZEZObGJHVmpkRzl5YzE5eWIzVjBaVUF5TlRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGSnZiR1ZVWVhKblpYUlRaV3hsWTNSdmNrTnZkVzUwWDNKdmRYUmxRREkwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGSnZiR1ZVWVhKblpYUlRaV3hsWTNSdmNsOXliM1YwWlVBeU16b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsVFdWdFltVnljMTl5YjNWMFpVQXhOam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsVFdWdFltVnlRMjkxYm5SZmNtOTFkR1ZBTVRVNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVbTlzWlUxbGJXSmxjbDl5YjNWMFpVQXhORG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQmllWFJsWXlBeU15QXZMeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZKdmJHVnpUMlpCWkcxcGJsSnZiR1ZmY205MWRHVkFNVGs2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSU2IyeGxUMlpCWkcxcGJsSnZiR1ZmY205MWRHVkFNVGM2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkp2YkdWelgzSnZkWFJsUURFd09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSU2IyeGxRMjkxYm5SZmNtOTFkR1ZBT1RvS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZKdmJHVmZjbTkxZEdWQU9Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlRBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYM0J2YzNSSmJtbDBYM0p2ZFhSbFFEYzZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZaR1ZzWldkaGRHVmZkWEJrWVhSbFgzSnZkWFJsUURRNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdWWEJrWVhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyRmtaQ2h6WlhRNklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJOQ3dnWW5sMFpYTTZDa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyRmtaRG9LSUNBZ0lIQnliM1J2SURJZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdSVzUxYldWeVlXSnNaVk5sZEM1ZlkyOXVkR0ZwYm5NS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0lDQWdJR0p1ZWlCRmJuVnRaWEpoWW14bFUyVjBMbDloWkdSZlpXeHpaVjlpYjJSNVFEWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUMwS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J5WlhCc1lXTmxNaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbDl3YjNOcGRHbHZibk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J5WlhSemRXSUtDa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyRmtaRjlsYkhObFgySnZaSGxBTmpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtWdWRXMWxjbUZpYkdWVFpYUXVYM0psYlc5MlpTaHpaWFE2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dZbmwwWlhNNkNrVnVkVzFsY21GaWJHVlRaWFF1WDNKbGJXOTJaVG9LSUNBZ0lIQnliM1J2SURJZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWW5sMFpXTmZNaUF2THlBaUlnb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0lsOXdiM05wZEdsdmJuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWW5vZ1JXNTFiV1Z5WVdKc1pWTmxkQzVmY21WdGIzWmxYMlZzYzJWZlltOWtlVUE0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNREVLSUNBZ0lHSStQUW9nSUNBZ1lYTnpaWEowSUM4dklIVnVaR1Z5Wm14dmR3b2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNUW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1ERUtJQ0FnSUdJK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUhWdVpHVnlabXh2ZHdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01Rb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZaUU5Q2lBZ0lDQmllaUJGYm5WdFpYSmhZbXhsVTJWMExsOXlaVzF2ZG1WZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J5WlhCc1lXTmxNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0F0Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjbVZ3YkdGalpUSWdNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWDNCdmMybDBhVzl1Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBMkNpQWdJQ0JpYjNoZmNIVjBDZ3BGYm5WdFpYSmhZbXhsVTJWMExsOXlaVzF2ZG1WZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHUnBaeUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdMUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lISmxjR3hoWTJVeUlESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NrVnVkVzFsY21GaWJHVlRaWFF1WDNKbGJXOTJaVjlsYkhObFgySnZaSGxBT0RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVGYm5WdFpYSmhZbXhsVTJWMExsOWpiMjUwWVdsdWN5aHpaWFE2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dZbmwwWlhNNkNrVnVkVzFsY21GaWJHVlRaWFF1WDJOdmJuUmhhVzV6T2dvZ0lDQWdjSEp2ZEc4Z01pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbDl3YjNOcGRHbHZibk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtWdWRXMWxjbUZpYkdWVFpYUXVYMnhsYm1kMGFDaHpaWFE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyeGxibWQwYURvS0lDQWdJSEJ5YjNSdklERWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwTG1Ga1pDZ3lLVjh3S0hObGREb2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwTENCaWVYUmxjeXdnWW5sMFpYTTZDa1Z1ZFcxbGNtRmliR1ZUWlhRdVlXUmtPZ29nSUNBZ2NISnZkRzhnTWlBekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUVWdWRXMWxjbUZpYkdWVFpYUXVYMkZrWkFvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHUjFjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRDNXlaVzF2ZG1Vb01pbGZNQ2h6WlhRNklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJOQ3dnWW5sMFpYTXNJR0o1ZEdWek9ncEZiblZ0WlhKaFlteGxVMlYwTG5KbGJXOTJaVG9LSUNBZ0lIQnliM1J2SURJZ013b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBMbDl5WlcxdmRtVUtJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JrZFhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrVnVkVzFsY21GaWJHVlRaWFF1YkdWdVozUm9LREVwWHpBb2MyVjBPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWek9ncEZiblZ0WlhKaFlteGxVMlYwTG14bGJtZDBhRG9LSUNBZ0lIQnliM1J2SURFZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHTmhiR3h6ZFdJZ1JXNTFiV1Z5WVdKc1pWTmxkQzVmYkdWdVozUm9DaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VSVzUxYldWeVlXSnNaVk5sZEM1aFpHUW9NaWxmTVNoelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE1zSUdKNWRHVnpPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBMbUZrWkNneUtWOHhPZ29nSUNBZ2NISnZkRzhnTWlBekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpSmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpZV3hzYzNWaUlFVnVkVzFsY21GaWJHVlRaWFF1WDJGa1pBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1IxY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVJXNTFiV1Z5WVdKc1pWTmxkQzV5WlcxdmRtVW9NaWxmTVNoelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE1zSUdKNWRHVnpPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBMbkpsYlc5MlpTZ3lLVjh4T2dvZ0lDQWdjSEp2ZEc4Z01pQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpnb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaUpnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqWVd4c2MzVmlJRVZ1ZFcxbGNtRmliR1ZUWlhRdVgzSmxiVzkyWlFvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHUjFjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRDNWhaR1FvTWlsZk1paHpaWFE2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dZbmwwWlhNc0lHSjVkR1Z6T2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwTG1Ga1pDZ3lLVjh5T2dvZ0lDQWdjSEp2ZEc4Z01pQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTmhiR3h6ZFdJZ1JXNTFiV1Z5WVdKc1pWTmxkQzVmWVdSa0NpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1SVlYTm9aWE11WldabWFXTnBaVzUwUzJWalkyRnJNalUyS0dFNklHSjVkR1Z6TENCaU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNraGhjMmhsY3k1bFptWnBZMmxsYm5STFpXTmpZV3N5TlRZNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxjR3hoWTJVeUlETXlDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMk5Bb2dJQ0FnYTJWalkyRnJNalUyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVOWVhSb0xuUmxjbTVoY25rb1kyOXVaR2wwYVc5dU9pQjFhVzUwTmpRc0lHRTZJR0o1ZEdWekxDQmlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDazFoZEdndWRHVnlibUZ5ZVRvS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKZUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR05oYkd4emRXSWdVMkZtWlVOaGMzUXVkRzlWYVc1MENpQWdJQ0JpS2dvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbDRLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGsxaGRHZ3ViV0Y0S0dFNklHSjVkR1Z6TENCaU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrMWhkR2d1YldGNE9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lqNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRTFoZEdndWRHVnlibUZ5ZVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVUyRm1aVU5oYzNRdWRHOVZhVzUwTkRnb2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q2xOaFptVkRZWE4wTG5SdlZXbHVkRFE0T2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1abVptWm1abVptWm1aZ29nSUNBZ1lqNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWVdabFEyRnpkRTkyWlhKbWJHOTNaV1JWYVc1MFJHOTNibU5oYzNRS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTWdOaUF2THlBeU9ERTBOelE1TnpZM01UQTJOVFVLSUNBZ0lDWUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMbE5oWm1WRFlYTjBMblJ2VldsdWRDaGlPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BUWVdabFEyRnpkQzUwYjFWcGJuUTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FoQ2lBZ0lDQWhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCemQyRndDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1VWFXMWxMblJwYldWemRHRnRjQ2dwSUMwK0lIVnBiblEyTkRvS1ZHbHRaUzUwYVcxbGMzUmhiWEE2Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZEWVhOMExuUnZWV2x1ZERRNENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNVVhVzFsTG5SdlJHVnNZWGtvWkhWeVlYUnBiMjQ2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q2xScGJXVXVkRzlFWld4aGVUb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1VWFXMWxMbDluWlhSR2RXeHNRWFFvYzJWc1pqb2dZbmwwWlhNc0lIUnBiV1Z3YjJsdWREb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncFVhVzFsTGw5blpYUkdkV3hzUVhRNkNpQWdJQ0J3Y205MGJ5QXlJRE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCVWFXMWxMblZ1Y0dGamF3b2dJQ0FnY0c5d2JpQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnVkdsdFpTNTFibkJoWTJzS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2NHOXdiaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzUxYm5CaFkyc0tJQ0FnSUhCdmNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnVkdsdFpTNTFibkJoWTJzS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOFBRb2dJQ0FnWW5vZ1ZHbHRaUzVmWjJWMFJuVnNiRUYwWDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NsUnBiV1V1WDJkbGRFWjFiR3hCZEY5MFpYSnVZWEo1WDIxbGNtZGxRRE02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnY21WMGMzVmlDZ3BVYVcxbExsOW5aWFJHZFd4c1FYUmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHSWdWR2x0WlM1ZloyVjBSblZzYkVGMFgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGxScGJXVXVaMlYwUm5Wc2JDaHpaV3htT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJORG9LVkdsdFpTNW5aWFJHZFd4c09nb2dJQ0FnY0hKdmRHOGdNU0F6Q2lBZ0lDQmpZV3hzYzNWaUlGUnBiV1V1ZEdsdFpYTjBZVzF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzVmWjJWMFJuVnNiRUYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1VWFXMWxMbWRsZENoelpXeG1PaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BVYVcxbExtZGxkRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRlJwYldVdVoyVjBSblZzYkFvZ0lDQWdjRzl3YmlBeUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNVVhVzFsTG5kcGRHaFZjR1JoZEdVb2MyVnNaam9nWW5sMFpYTXNJRzVsZDFaaGJIVmxPaUIxYVc1ME5qUXNJRzFwYmxObGRHSmhZMnM2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE1zSUhWcGJuUTJORG9LVkdsdFpTNTNhWFJvVlhCa1lYUmxPZ29nSUNBZ2NISnZkRzhnTXlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1blpYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0ErQ2lBZ0lDQmllaUJVYVcxbExuZHBkR2hWY0dSaGRHVmZaV3h6WlY5aWIyUjVRRElLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0NsUnBiV1V1ZDJsMGFGVndaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBeUNpQWdJQ0JqWVd4c2MzVmlJRTFoZEdndWJXRjRDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRTFoZEdndWJXRjRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0JqWVd4c2MzVmlJRlJwYldVdWRHbHRaWE4wWVcxd0NpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTmlBdkx5QXlPREUwTnpRNU56WTNNVEEyTlRVS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRlJwYldVdWNHRmphd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhSemRXSUtDbFJwYldVdWQybDBhRlZ3WkdGMFpWOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlGUnBiV1V1ZDJsMGFGVndaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVVYVcxbExuVnVjR0ZqYXloelpXeG1PaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBMQ0IxYVc1ME5qUXNJSFZwYm5RMk5Eb0tWR2x0WlM1MWJuQmhZMnM2Q2lBZ0lDQndjbTkwYnlBeElETUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZeUEwSUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldNZ01qUWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZeUEwSUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldNZ01qVWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdNZ05pQXZMeUF5T0RFME56UTVOelkzTVRBMk5UVUtJQ0FnSUNZS0lDQWdJSE4zWVhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMbFJwYldVdWNHRmpheWgyWVd4MVpVSmxabTl5WlRvZ2RXbHVkRFkwTENCMllXeDFaVUZtZEdWeU9pQjFhVzUwTmpRc0lHVm1abVZqZERvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1ZHbHRaUzV3WVdOck9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURJMUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURJMElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TUFvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRHOWlDaUFnSUNCaWZBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdVgzSmxkbTlyWlZKdmJHVW9jbTlzWlVsa09pQjFhVzUwTmpRc0lHRmpZMjkxYm5RNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNsOXlaWFp2YTJWU2IyeGxPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdNZ055QXZMeUF4T0RRME5qYzBOREEzTXpjd09UVTFNVFl4TlFvZ0lDQWdQVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQlkyTmxjM05OWVc1aFoyVnlURzlqYTJWa1VtOXNaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJQ0p0WlcxaVpYSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JsZUhSeVlXTjBJREFnTmdvZ0lDQWdZblJ2YVFvZ0lDQWdZbTU2SUY5eVpYWnZhMlZTYjJ4bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTndvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9LWDNKbGRtOXJaVkp2YkdWZllXWjBaWEpmYVc1c2FXNWxaRjh2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzVmY21WMmIydGxVbTlzWlY5ZmMzVndaWEpmTlRjM1FEZzZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW5vZ1gzSmxkbTlyWlZKdmJHVmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1gzUnlZV05yVW05c1pVMWxiV0psY2dvS1gzSmxkbTlyWlZKdmJHVmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnY21WMGMzVmlDZ3BmY21WMmIydGxVbTlzWlY5aFpuUmxjbDlwWmw5bGJITmxRRGM2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5WkRnNVpUa3dOeUF2THlCdFpYUm9iMlFnSWxKdmJHVlNaWFp2YTJWa0tIVnBiblEyTkN4MWFXNTBPRnN6TWwwcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0lnWDNKbGRtOXJaVkp2YkdWZllXWjBaWEpmYVc1c2FXNWxaRjh2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzVmY21WMmIydGxVbTlzWlY5ZmMzVndaWEpmTlRjM1FEZ0tDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1ZmRISmhZMnRTYjJ4bEtISnZiR1ZKWkRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwZmRISmhZMnRTYjJ4bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjZJRjkwY21GamExSnZiR1ZmYVdaZlltOWtlVUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR01nTnlBdkx5QXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhOUW9nSUNBZ1BUMEtJQ0FnSUdKNklGOTBjbUZqYTFKdmJHVmZZV1owWlhKZmFXWmZaV3h6WlVBekNncGZkSEpoWTJ0U2IyeGxYMmxtWDJKdlpIbEFNam9LSUNBZ0lISmxkSE4xWWdvS1gzUnlZV05yVW05c1pWOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaVgzSnZiR1Z6VTJWMElnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURJd01EQTBNREF3TmpBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBMbUZrWkNneUtWOHlDaUFnSUNCd2IzQUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJbDl5YjJ4bGMxTmxkQ0lLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldNZ01UVWdMeThnSWw5eWIyeGxjMU5sZENJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMa0ZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExsOTBjbUZqYTFKdmJHVk5aVzFpWlhJb2NtOXNaVWxrT2lCMWFXNTBOalFzSUdGalkyOTFiblE2SUdKNWRHVnpMQ0JuY21GdWRHVmtPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbDkwY21GamExSnZiR1ZOWlcxaVpYSTZDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1FVSkpJR0p2YjJ3Z2RtRnNhV1JoZEdsdmJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZWlCZmRISmhZMnRTYjJ4bFRXVnRZbVZ5WDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2wwYjJJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNallnTHk4Z0lsOXliMnhsVFdWdFltVnlVMlYwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF5TURBd05EQXdNRFl3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRDNWhaR1FvTWlsZk1Rb2dJQ0FnY0c5d0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tYM1J5WVdOclVtOXNaVTFsYldKbGNsOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FYUnZZZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeU5pQXZMeUFpWDNKdmJHVk5aVzFpWlhKVFpYUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01ESXdNREEwTURBd05qQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwTG5KbGJXOTJaU2d5S1Y4eENpQWdJQ0J3YjNBS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1WDJOb1pXTnJRWFYwYUc5eWFYcGxaQ2dwSUMwK0lIWnZhV1E2Q2w5amFHVmphMEYxZEdodmNtbDZaV1E2Q2lBZ0lDQndjbTkwYnlBd0lEQUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdYMjF6WjBSaGRHRUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUY5allXNURZV3hzVTJWc1pnb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRjl0YzJkRVlYUmhDaUFnSUNCallXeHNjM1ZpSUY5allXNURZV3hzVTJWc1pnb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NHOXdDaUFnSUNCaWJub2dYMk5vWldOclFYVjBhRzl5YVhwbFpGOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmlibm9nWDJOb1pXTnJRWFYwYUc5eWFYcGxaRjlsYkhObFgySnZaSGxBTXdvZ0lDQWdZMkZzYkhOMVlpQmZiWE5uUkdGMFlRb2dJQ0FnWTJGc2JITjFZaUJmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5NS0lDQWdJSEJ2Y0c0Z013b2dJQ0FnWlhKeUlDOHZJRUZqWTJWemMwMWhibUZuWlhKVmJtRjFkR2h2Y21sNlpXUkJZMk52ZFc1MENncGZZMmhsWTJ0QmRYUm9iM0pwZW1Wa1gyVnNjMlZmWW05a2VVQXpPZ29nSUNBZ1kyRnNiSE4xWWlCZmJYTm5SR0YwWVFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWXlBeE5pQXZMeUF3ZURWbU56TTJNelk0TmpVMk5EYzFObU0yTlRjelpUTmlNR00wTkRJNU9HWmpNV014TkRsaFptSm1OR000T1RrMlptSTVNalF5TjJGbE5ERmxORFkwT1dJNU16UmpZVFE1TlRrNU1XSTNPRFV5WWpnMU5Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURZS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQWhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpUV0Z1WVdkbGNrNXZkRk5qYUdWa2RXeGxaQW9nSUNBZ1kyRnNiSE4xWWlCVWFXMWxMblJwYldWemRHRnRjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVRtOTBVbVZoWkhrS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdYMmx6Ulhod2FYSmxaQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjMDFoYm1GblpYSkZlSEJwY21Wa0NpQWdJQ0JpZVhSbFl5QXhOaUF2THlBd2VEVm1Oek0yTXpZNE5qVTJORGMxTm1NMk5UY3paVE5pTUdNME5ESTVPR1pqTVdNeE5EbGhabUptTkdNNE9UazJabUk1TWpReU4yRmxOREZsTkRZME9XSTVNelJqWVRRNU5UazVNV0kzT0RVeVlqZzFOUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ05pQTBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01UWWdMeThnTUhnMVpqY3pOak0yT0RZMU5qUTNOVFpqTmpVM00yVXpZakJqTkRReU9UaG1ZekZqTVRRNVlXWmlaalJqT0RrNU5tWmlPVEkwTWpkaFpUUXhaVFEyTkRsaU9UTTBZMkUwT1RVNU9URmlOemcxTW1JNE5UVUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0ZrTTJRME1HUmtJQzh2SUcxbGRHaHZaQ0FpVDNCbGNtRjBhVzl1UlhobFkzVjBaV1FvZFdsdWREaGJNekpkTEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvS1gyTm9aV05yUVhWMGFHOXlhWHBsWkY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzVmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5Nb1pHRjBZVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJOQ3dnZFdsdWREWTBMQ0IxYVc1ME5qUTZDbDluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1Y3pvS0lDQWdJSEJ5YjNSdklERWdNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd05Bb2dJQ0FnWWp3S0lDQWdJR0o2SUY5blpYUkJaRzFwYmxKbGMzUnlhV04wYVc5dWMxOWhablJsY2w5cFpsOWxiSE5sUURJS0NsOW5aWFJCWkcxcGJsSmxjM1J5YVdOMGFXOXVjMTlwWmw5aWIyUjVRREU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhKbGRITjFZZ29LWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1elgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjM1ZpYzNSeWFXNW5JREFnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGcxTXpVMU1XSTRDaUFnSUNBOVBRb2dJQ0FnWW01NklGOW5aWFJCWkcxcGJsSmxjM1J5YVdOMGFXOXVjMTlwWmw5aWIyUjVRRGNLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pNR05oWlRFNE53b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCZloyVjBRV1J0YVc1U1pYTjBjbWxqZEdsdmJuTmZhV1pmWW05a2VVQTNDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5USTVOakk1TlRJS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1elgybG1YMkp2WkhsQU53b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdFMk5HUTVOV05sQ2lBZ0lDQTlQUW9nSUNBZ1ltNTZJRjluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1YzE5cFpsOWliMlI1UURjS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrTWpKaU5UazRPUW9nSUNBZ1BUMEtJQ0FnSUdKNklGOW5aWFJCWkcxcGJsSmxjM1J5YVdOMGFXOXVjMTloWm5SbGNsOXBabDlsYkhObFFEZ0tDbDluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1YzE5cFpsOWliMlI1UURjNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J5WlhSemRXSUtDbDluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1YzE5aFpuUmxjbDlwWmw5bGJITmxRRGc2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVGhtWmpFNE0yTUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1gyZGxkRUZrYldsdVVtVnpkSEpwWTNScGIyNXpYMmxtWDJKdlpIbEFOd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTJOMkprTXprMUNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUY5blpYUkJaRzFwYmxKbGMzUnlhV04wYVc5dWMxOXBabDlpYjJSNVFEY0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd09HUTJNVEl5WkFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5OZmFXWmZZbTlrZVVBM0NpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpWak5EY3hZVEFLSUNBZ0lEMDlDaUFnSUNCaWJub2dYMmRsZEVGa2JXbHVVbVZ6ZEhKcFkzUnBiMjV6WDJsbVgySnZaSGxBTndvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0kzWkRKaU1UWXlDaUFnSUNBOVBRb2dJQ0FnWW01NklGOW5aWFJCWkcxcGJsSmxjM1J5YVdOMGFXOXVjMTlwWmw5aWIyUjVRRGNLSUNBZ0lHSWdYMmRsZEVGa2JXbHVVbVZ6ZEhKcFkzUnBiMjV6WDJsbVgySnZaSGxBTVFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbDlqWVc1RFlXeHNVMlZzWmloallXeHNaWEk2SUdKNWRHVnpMQ0JrWVhSaE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZMExDQjFhVzUwTmpRNkNsOWpZVzVEWVd4c1UyVnNaam9LSUNBZ0lIQnliM1J2SURJZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBMENpQWdJQ0JpUEFvZ0lDQWdZbm9nWDJOaGJrTmhiR3hUWld4bVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ2NtVjBjM1ZpQ2dwZlkyRnVRMkZzYkZObGJHWmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCZlkyRnVRMkZzYkZObGJHWmZhV1pmWW05a2VVQTBDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQVDBLSUNBZ0lHSjZJRjlqWVc1RFlXeHNVMlZzWmw5aFpuUmxjbDlwWmw5bGJITmxRRFVLQ2w5allXNURZV3hzVTJWc1psOXBabDlpYjJSNVFEUTZDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemRXSnpkSEpwYm1jZ01DQTBDaUFnSUNCallXeHNjM1ZpSUY5cGMwVjRaV04xZEdsdVp3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhOMVlnb0tYMk5oYmtOaGJHeFRaV3htWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCZloyVjBRV1J0YVc1U1pYTjBjbWxqZEdsdmJuTUtJQ0FnSUhCdmNHNGdNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5blpYUkJaRzFwYmxKbGMzUnlhV04wYVc5dWN3b2dJQ0FnY0c5d2JpQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1ekNpQWdJQ0J3YjNCdUlETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTGw5cGMwVjRaV04xZEdsdVp5aDBZWEpuWlhRNklHSjVkR1Z6TENCelpXeGxZM1J2Y2pvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1gybHpSWGhsWTNWMGFXNW5PZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pmWlhobFkzVjBhVzl1U1dRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5bGVHVmpkWFJwYjI1SlpDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lpWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRWhoYzJobGN5NWxabVpwWTJsbGJuUkxaV05qWVdzeU5UWUtJQ0FnSUQwOUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1ZmFYTkZlSEJwY21Wa0tIUnBiV1Z3YjJsdWREb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbDlwYzBWNGNHbHlaV1E2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFl5QTJJQzh2SURJNE1UUTNORGszTmpjeE1EWTFOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dkbUZzYVdSaGRHbHZiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpJRFlnTHk4Z01qZ3hORGMwT1RjMk56RXdOalUxQ2lBZ0lDQW1DaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ0xURUtJQ0FnSUdsdWRHTWdOaUF2THlBeU9ERTBOelE1TnpZM01UQTJOVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1MGFXMWxjM1JoYlhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQajBLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbDl0YzJkRVlYUmhLQ2tnTFQ0Z1lubDBaWE02Q2w5dGMyZEVZWFJoT2dvZ0lDQWdjSEp2ZEc4Z01DQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd2JpQXhOQW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRjl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU5UQUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUEwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQStDaUFnSUNCaWVpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTnpvS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTVRNS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lENEtJQ0FnSUdKNklGOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBT1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TURvS0lDQWdJR1p5WVcxbFgyUnBaeUF4TXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFMENpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQStDaUFnSUNCaWVpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURFeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURFek9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE9Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE9Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ013b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU1Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTndvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ053b0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU5Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Rb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0ErQ2lBZ0lDQmllaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFESTNDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTRDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFESTRPZ29nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTJDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2NIVnphR2x1ZENBNUNpQWdJQ0ErQ2lBZ0lDQmllaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFETXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTVDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFETXhPZ29nSUNBZ1puSmhiV1ZmWkdsbklEWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTNDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnUGdvZ0lDQWdZbm9nWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXpNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVEFLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNelE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGdLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERXhDaUFnSUNBK0NpQWdJQ0JpZWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRE0yQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TVFvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TnpvS0lDQWdJR1p5WVcxbFgyUnBaeUE0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnT1FvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJSEIxYzJocGJuUWdNVElLSUNBZ0lENEtJQ0FnSUdKNklGOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTXprS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFeUNncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURRd09nb2dJQ0FnWm5KaGJXVmZaR2xuSURrS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeE1Bb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRNS0lDQWdJRDRLSUNBZ0lHSjZJRjl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU5ESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXpDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFEUXpPZ29nSUNBZ1puSmhiV1ZmWkdsbklERXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNVEVLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERTBDaUFnSUNBK0NpQWdJQ0JpZWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRFExQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TkFvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTmpvS0lDQWdJR1p5WVcxbFgyUnBaeUF4TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFeUNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0F4TlFvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME9Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UVUtDbDl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU5EazZDaUFnSUNCbWNtRnRaVjlrYVdjZ01USUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9LWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQTFNVG9LSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRFE0T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU5Ea0tDbDl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU5EVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdJZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTmdvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFEUXpDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFETTVPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlGOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTkRBS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTXpZNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbnBsY204S0lDQWdJR0lnWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXpOd29LWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXpNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURNMENncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURNd09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNekVLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNamM2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHSWdYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU9Bb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDIxbGNtZGxRREkxQ2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRREl4T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU1qSUtDbDl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU1UZzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdJZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF4T1FvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFERTJDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFERXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlGOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTVRNS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBT1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFERXdDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFEWTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdJZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUEzQ2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURRS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTlRBNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbnBsY204S0lDQWdJR0lnWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQTFNUW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzVqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBSUFDQUJDUC8vLy84UEFQLy8vLy8vL3ovLy8vLy8vLy8vLy84Qkpoc0tYMTl2WjE5MllXeDFaUVFWSDN4MUFBd1ZIM3gxQUFBQUFBQUFBQUFLQUFJQUJBQUdBQUFBQUNFQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQVJULy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy93b0FBQUFBQUFBQUFBQUFJZ0FnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFLWDNCdmMybDBhVzl1Y3hJQUVRQUFBQUFBQUFBQUFBQUFBQUFBQUFBR1gzSnZiR1Z6RGw5aFpHMXBibEp2YkdWelUyVjBDVjl5YjJ4bGMxTmxkQ3BmYzJOb1pXUjFiR1Z6NDdERVFwajhIQlNhKy9USW1XKzVKQ2V1UWVSa201Tk1wSldaRzNoU3VGVUtYM05qYUdWa2RXeGxjd2hmZEdGeVoyVjBjeHBmY205c1pWUnZWR0Z5WjJWMFZHOVRaV3hsWTNSdmNsTmxkQkJmY205c1pWUnZWR0Z5WjJWMFUyVjBBZ0FnQjIxbGJXSmxjbk1rRlI5OGRRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFQUFBQUFJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRQUFBQUFBQUFBQURsOXliMnhsVFdWdFltVnlVMlYwSWtjTEtrY0tnWUFncjBrMUJUVUFOQUNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FYRUExQURFWVFBQVVnQTVmWDJOMGIzSmZjR1Z1WkdsdVp5Um5KRU9BQk54ZU41ZzJHZ0NPQVFvZE1Sa1VSREVZUklJekJKa1BNSzRFejhXWURBUlFUdjhDQk5OVlpOVUVqRVpFWFFTTDR5eG1CRHhkclVvRWt6KzdhZ1JNK01zdUJHRm9FR1FFejhTWW1BVGthQ0JTQkZyd3ZTY0U5emVzK0FTZ0MvUXdCQUtkR29RRTIvQ09FQVMvUFcrckJFd0U4OWdFYmNNREJRUy9ZM1piQk5CNVpERUVucXBYT2dUUDh1WWhCTlJFRDFjRWg5VkZDd1FzQ3MyQkJOcDFDeU1FRStrb2hnUTl2RzFEQkpEMWpuVUU4UVpubVFTSkhEZEtCTVRlRndzRThZcURxQVMxRWxWY0JDM3dLaWNFS0VUYm5nUTBTdjlBQk5scmluMEVCdTNETGdURzFSVXVCS3ljdWc0RWhkT0M0UVFxTXMzUkJEdGNvSVlFTElObTJBUm1tc0JMQkFTVkhDa0UzWmdvMVFRRWtab21OaG9BampNSW9RaVdDSklJZmdpV0NKSUlmZ2crQ0RNSUdnaHNDRE1JVVFnK0NETUlHZ2dCQis4SHpRZkNCNm9IVWdkT0IwNEhQUWNxQng4SEZBY1VCeFFIQVFiaEJxRUZyZ1dOQldrRWt3UVlBNllDUHdIV0FYQUJRUUVhQVBzQTR3REVBSzRBandCWEFBRUFOaG9CU1NKWlNVVUxnUUlMUlFaSkZVVUNWd0lBUlJZaVJRZExCa3NKREVFQUowc0dTWUVDQzBzWFNVOENXVWxMQ0VsT0JCSkVTd0VWVWlKWmdRSUlDRVVHSkFoRkIwTC8wVXNFZ1FJSVN3RVNSQ213SkVNMkdnRkpGU01TUkRZYUFra1ZJeEpFSVFVb1pVZ1VSSWdOTkxGTWdSaGJnUWF5RUNLeUdTS3lBYklZZ0FUTjJrNm1zaHF5R3JNa1F6WWFBUlVqRWtRMkdnSVZJeEpFTmhvRFNTSlpnUUlJVEJVU1JDbXdKRU0yR2dFVkl4SkVOaG9DU1NKWmdRSUlUQlVTUkNSRE5ob0JGU01TUkRZYUFoVWpFa1EyR2dOSklsbUJBZ2hNRlJKRUs3QWtRellhQVJVakVrUTJHZ0pKSWxtQkFnaE1GUkpFSzdBa1F6WWFBUlVqRWtRMkdnSkpJbG1CQWdoTUZSSkVOaG9ERlNVU1JDdXdKRU0yR2dGSkZTTVNSQ0VGS0dWSUZFUUJKeEZNVUw0bkNFNENUWUVHV2lFRUdoWXBURkN3SkVNMkdnRkpGU01TUkNFRktHVklGRVFCSnhGTVVMNG5DRTRDVFZjQUJoZEppQTNLSWt4TklRWWFGaWxNVUxBa1F6WWFBVWtWSXhKRU5ob0NTUlVrRWtSSklsTWhCU2hsU0JSRWlBd1lKQTVFU3dFQkp4Sk1VRW0rSnd4T0FrMUpWd0lPU3dFaVdVc0NGVThEVGdKU1Z3SUFTUlVXVndZQ1RGQ0FBZ0FSVHdKUVN3TlFURkJMQWJ4SXYxQ0FCTTU2WlE5TVVMQWtRellhQVVrVkl4SkVOaG9DU1JVbEVrUVhJUVVvWlVnVVJJZ0x0RWtoQkE1RUlRUWFTU0VFRGtRaEJCcExBUUVuRWt4UVNiNG5ERTRDVFZjQ0Rrc0NJb2dLTEVZQ3ZpY01UZ0pOVndJT1N3RWlpQW9iVGdKSUZrd1dUZ0pRVEZDQUJNT2g4aUZNVUxBa1F6WWFBVWxGRUJVakVrUTJHZ0pKUlJGSklsbEpSUXlCQkF1QkFnaE1GUkpFTmhvRFNVVU9TUlVsRWtRWFJRTWhCU2hsU0JSRWlBc3VJaFpGRTBzSkZrc1RwVUVCSUNXdlN4TlFTUlVsQ1Z0TEVGY0NBRXlCQkF1QkJGaEpSUkpKQVlBTVlXeHNiM2RsWkZKdmJHVnpURkJMQkVsT0F4WkpSUmkvU3hCTVVFbExEMUNBQk5WSllwZE1VTEJMQVlnS1pBR0FGMTkwWVhKblpYUlViMU5sYkdWamRHOXlWRzlTYjJ4bFRGQkpSUlMrVEJjaVRFOENUVWxGQmhKQUFKMUxBMEVBVGtzREZrbEZEVXNQVUFFbkUweFFTYjRuQkU0Q1RZRWNyMHNUVEZDSUI0VklSUUZMQWJ4SVRFc0J2NGdIa0VncXFFRUFHMHNMQVNjVVRGQkp2aWNFVGdKTlN4Q0lCN1ZJUlFGTEFieEl2MHNDUVFCQVN4TkpTeEJKVGdOUUFTY1RURkJKdmljRVRnSk5nUnl2U3hWTVVJZ0hHVWhGQVVzQnZFaS9BU2NVVEZCSnZpY0VUZ0pOVHdLSUIwaElSUUZMQWJ4SXYwc1JTeFMvU3hJbkJxQkZFMEwrMXlSRE5ob0JTUlVsRWtSSkZ6WWFBa2tWSlJKRUZ5RUZLR1ZJRkVTSUNlSkpJUVFPUkNFRUdra2hCQTVFSVFRYVN3RWhCeElVUkV3V0FTY05URkJKdmljSlRnSk5WeElPU3dJaWlBaFRSZ0srSndsT0FrMVhFZzVMQVNLSUNFSk9Ba2dXVEJaT0FsQk1VSUFFcmVsVHoweFFzQ1JETmhvQlNSVWxFa1JKRnpZYUFra1ZKUkpFSVFVb1pVZ1VSSWdKY1VzQkZCUkVTd0VoQnhJVVJFc0JGZ0VuRFV4UVNiNG5DVTRDVFVsWEFnaExBVmNTRGtzQ0lsbExBeFZQQkU0Q1VsY0NBRWtWRmxjR0FreFFKeFZQQTFCTEJGQlBBbEJNVUVzQnZFaS9Ud0pNVUlBRWE4ZUh4a3hRc0lnSW9pUkROaG9CU1JVbEVrUkpGellhQWtrVkpSSkVTUmRKVGdORkR5RUZLR1ZJRkVTSUNPOUxBUlFVUkVzQklRY1NGRVJMQVJaSlJSSUJKdzFNVUVtK0p3bE9BazFKVnhJT1N3RlhDZ2hMQWlKWlN3TVZUd1JPQWxKWEFnQkpGUlpYQmdKTVVDY1ZTd1ZRVHdKUVR3SlFURkJMQWJ4SXYwOERURkNBQlAxTStKQk1VTENJQ0IxQi9vdExDa0graGljT3ZpY0VUZ0pOU3dzV1RFc0JpQVgyU0VVQkp3NjhTQ2NPVEw4QmdCTmZjbTlzWlVGa2JXbHVWRzlTYjJ4bFUyVjBURkJKdmljRVRnSk5TdzZJQmNkSVJRRkxBYnhJdjBMK096WWFBVWtWSlJKRUZ6WWFBa2tWSXhKRUlRVW9aVWdVUkVreEFCTVVSSWdIWDBna1F6WWFBVWtWSlJKRUZ6WWFBa2tWSXhKRUlRVW9aVWdVUklnSC9ZZ0hQa2drUXpZYUFVbEZEMGtWSlJKRUYwbEZCRFlhQWtsRkdVa1ZJeEpFTmhvRFNSVWxFa1FYSVFVb1pVZ1VSSWdIeWtraEJBNUVJUVFhU1NFRURrUWhCQnBKSVFRT1JDRUVHa1VLVENFSEVoUkVBU2NXVEZCSlJSTytKd3BPQWsxWEFBWVhTVVVEU1JSRkIwQUFZSWdGdkVraEJnNUVTd2lJQmJsSkZZRU9Ea1NCRHErclN3RVdTWk9CTUE1RVZ3SUdURkJMRTB5L1N3Z1dnQUVBSWtzSlZFOENGa3NRU3hwUVR3TlFURkJNVUlBRW5WdU5KMHhRc0VzQlFQMDlTd0pKaUFiR1N4ZExCNGdHNmtMOUxVc1JTYjRuQ2s0Q1RWY0dEa3NKU1U0RElvZ0Z1RVlDdmljS1RnSk5Wd1lPVENLSUJhaEZBVUwvbnpZYUFVa1ZKUkpFU1JjMkdnSkpJbG1CQWdoTEFSVVNSQ0VGS0dWSUZFU0lCdUpMQVJRVVJFd2hCeElVUkV5QUFnQUtVRXhRZ0FReWk0RnZURkN3SkVNMkdnRVZKUkpFTmhvQ0ZTTVNSSUFORlI5OGRRQUFBQUFBQUFBQUFMQWtRellhQVJVbEVrUTJHZ0lWSXhKRUp4ZXdKRU0yR2dFVkpSSkVLN0FrUXpZYUFSVWpFa1Fyc0NSRE5ob0JGU01TUkRZYUFoV0JCQkpFSzdBa1F6WWFBUlVqRWtTQUJSVWZmSFVBc0NSREs3QWtRellhQVVsRkZra1ZJeEpFTmhvQ1NVVVJGU01TUkRZYUEwbEZFeFdCQkJKRUlRVW9aVWdVUkNFRmNnaElFa0FBRFlFWXJ6SUlGbEJMRlJKQkFCZExEa3NSaUFkcmdBRUFJazhDVkNJV1VDbE1VTEFrUXlKQy8rd2hCU2hsU0JSRWdBd1ZIM3gxLy8vLy8vLy8vLyt3SkVNaEJTaGxTQlJFSzdBa1F6WWFBUlVsRWtRMkdnSVZJeEpFTmhvREZZRkFFa1EyR2dRVmdVQVNSQ213SkVNMkdnRVZKUkpFTmhvQ0ZTTVNSQ213SkVNMkdnRVZKUkpFTmhvQ0ZTTVNSRFlhQXhVakVrUXBzQ1JETmhvQkZTVVNSRFlhQWhVakVrUTJHZ01WSXhKRUtiQWtRellhQVJVbEVrUXBzQ1JETmhvQkZTVVNSRFlhQWhVakVrUW5GN0FrUXpZYUFSVWxFa1EyR2dJVmdVQVNSRFlhQXhXQlFCSkVLYkFrUXpZYUFSVWxFa1EyR2dJVkl4SkVLN0FrUXpZYUFSV0JRQkpFTmhvQ0ZZRkFFa1Fwc0NSREtiQWtRellhQVJVakVrUXJzQ1JETmhvQkZTTVNSQ1JETVJtQkJCSXhHQkJEaWdJQ2kvNkwvNGdCcFl6K1FBQjNpLzRpV1l2K2dRSlppLzVMQWtzQ1VvQUNBQUdMLzFCSlZ3SUFUQ0paU3dJaVdRZ1dWd1lBVHdKTVhBQk1VSXYrSWtzRVdFc0JVSXYrRll2K1N3UlBBbEpRU3dKUEJBbFBBaFZQQXdoTUNSWlhCZ0pjQWttTS9pSlppLzZCQWxtTC9rNENVaUpaRm92L0FTY0xURkJKdkVoTXZ5U0wvb2tpaS82SmlnSUNJa2NDS2ttTC93RW5DMHhRU2I0cVRnSk5TU3FwUVFFQ2l3WkpKd2FuUkNjRm9DY0dvU2NGcWttTUFvditJbGxKakFPTC9vRUNXVW1NQkl2K1RnSlNTWXdBSWxrV1NTY0dwMFFuQmFBbkJxRW5CYXBKakFHcFFRQnBKYTlKaXdGUVNSVWxDVnVMQUVsT0ExY0NBRXdqQ3lOWVRJc0NVRWtWSlFsYkl3dUJBZ2hQQWt4TEFsMkwvaUtMQTBsT0JGaExBVkNML2hXTC9vc0VTVTREVHdKU1R3Sk1VRXNCVHdRSlR3TVZUd01JVEFrV1Z3WUNYQUtNL2dFbkMweFFTYnhJaXdhL2kvNGlXWXYrZ1FKWmkvNUxBa3NDVWtrVkl3a2lURkpKSWxra0NSWlhCZ0JjQUl2K0lrc0VXRXNCVUl2K0ZZditTd1JQQWxKUVN3SlBCQWxQQWhWUEF3aE1DUlpYQmdKY0Fveitpd1c4U0NTTC9vd0JqQUNKSW92K2pBR01BSW1LQWdLTC93RW5DMHhRdmlwT0FrMHFxWXYraVlvQkFvdi9JbG1MLzRFQ1dZdi9UZ0pTSWxrV2kvK0ppZ0lEaS80aVdZditGWXYrVGdKU2kvK0kvaEpJaS81SmlZb0NBNHYrSWxtTC9oV0wvazRDVW92L2lQNkRTSXYrU1ltS0FRS0wveUpaaS84VmkvOU9BbEtJLzZWSWkvK0ppZ0lEaS80aVdZditGWXYrVGdKU0k2K0wveWNIckNjSHJGQkpGU01KSTFpSS9idElpLzVKaVlvQ0E0ditJbG1ML2hXTC9rNENVaU92aS84bkI2d25CNnhRU1JVakNTTllpUDRkU0l2K1NZbUtBZ09ML2lKWmkvNFZpLzVPQWxJanI0di9VRWtWSXdraldJajljVWlML2ttSmlnSUJOQUFqcjBtTC9sQkpGU01KSTFoUEFreGNBRXNCaS85UVNSVWpDU05ZWENCSlZ3QkFBazhDVEZCSkZTTUpJMWhYQUNCTU5RQ0ppZ01CaS82TC82MkwvWWdBTnFNbkJhcUwvNjJKaWdJQmkvNkwvNldML292L2lQL2NpWW9CQVl2L2dBYi8vLy8vLy8rbEZFUWxyNHYvVUVrVkpRbGJJUVlhaVlvQkFUUUFpLzhVRkNvbkJrOENUVXcxQUlreUJ4YUkvOG1KaWdFQmkvOFdpWW9DQXlxTC9vZ0Fxa1lEaS82SUFLTkpUZ05PQTBZQ2kvNklBSmRJVGdKSWkvNklBSTVHQWs0Q2kvOE9RUUFPSW93QUlvc0FURThGVHdWUEJZbUxBVXlNQUlzQ1RFTC82NG9CQTRqL3BJdi9USWovckltS0FRR0wvNGovNjBZQ2lZb0RBb3Y5aVAvdFNZditEVUVBUUlzQWkvNEpTU0VFRGtRbHI0di9GazhDRmtxSS95eExBMHhRVGdLSS95TlBBa3hRRlNVSld5RUVHb2ovVmdoSklRWU9SSXNBaS81TEFvZ0FQMHhQQW9raVF2L0dpZ0VESmE5SmkvOVFTUlVsQ1ZzaEJCcUwveWNZb2tzQ1RGQkpGU1VKV3lFRUdvdi9KeG1pVHdOTVVFa1ZKUWxiSVFZYVRFNENpWW9EQVl2L0ZpY1pveWNGcW92OUZpY1lveWNGcXF1TC9oYXJpWW9DQVNxTC9pRUhFaFJFaS84Qkp4Wk1VRW0rSndwT0FrMVhBQVlYUUFBUklvd0Fpd0JCQUFpTC9vdi9Jb2dBUlltTEFieElpLzRXaS85UWdBUXRpZWtIVEZDd0pJd0FRdi9aaWdFQWkvOUJBQWlML3lFSEVrRUFBWWtuRDc0bkJFNENUWXYvRm9qOTAwaEZBU2NQdkVnbkQweS9pWW9EQUl2L0pBNUVpLzlCQUIyTC9SWUJKeHBNVUVtK0p3Uk9BazJML29qOVZraEZBVXNCdkVpL2lZdjlGZ0VuR2t4UVNiNG5CRTRDVFl2K2lQMWhTRVVCU3dHOFNMK0ppZ0FBTVFDSUFaeExBVXlJQVFSSVRJZ0JrWWdBL0U0Q1NFQUFXWXNBUUFBSmlBR0FpQUJQUmdNQWlBRjNTQ2NRdmljSVRnSk5TVmNBQmhkTWdRWmFTd0VVRkVTSS9lcExBZ3dVUkV5SUFUZ1VSQ2NRdmljSVRnSk5Wd1lFZ0FZQUFBQUFBQUJNVUNjUVRMOFdnQVN0UFVEZFRGQ3dpWW9CQXlLTC94VVdnQUVFcEVFQUJpSkhBazhEaVl2L1VRQUVTWXdBZ0FTRk5WRzRFa0FBTUlzQWdBUXd5dUdIRWtBQUpJc0FnQVJTbGlsU0VrQUFHSXNBZ0FTbVRaWE9Fa0FBRElzQWdBVFNLMW1KRWtFQUJpUWlTVThEaVlzQWdBUVkveGc4RWtELzdvc0FnQVFXZTlPVkVrRC80b3NBZ0FRSTFoSXRFa0QvMW9zQWdBUWx4SEdnRWtEL3lvc0FnQVMzMHJGaUVrRC92a0wvYzRvQ0Fvdi9GUmFBQVFTa1FRQURJa21KTWdxTC9oSkFBQTJCR0s4eUNCWlFpLzRTUVFBTU1ncUwvMUVBQklnQUdpS0ppLytJL3kxR0E0di9pUDhtUmdPTC80ai9IMFlESWttSmlnSUJJb0FNWDJWNFpXTjFkR2x2Ymtsa1pVUWpyNHYrSndlc0p3ZXNVRWtWSXdraldJdi9pUHdjRW9tS0FRR0wveUVHRGtTTC95RUdHa21NL3lFR0RrU0kvSkdML3crSmlnQUJJa2NPTVJ0QkFWb3hHMEVCVGpZYUFJd0FNUnNrRFVFQlBUWWFBWXNBVEZDTURURWJnUUlOUVFFbk5ob0NpdzFNVUl3T01SdUJBdzFCQVJFMkdnT0xEa3hRakFFeEc0RUVEVUVBK3pZYUJJc0JURkNNQWpFYmdRVU5RUURsTmhvRml3Sk1VSXdETVJ1QkJnMUJBTTgyR2dhTEEweFFqQVF4RzRFSERVRUF1VFlhQjRzRVRGQ01CVEViSlExQkFLUTJHZ2lMQlV4UWpBWXhHNEVKRFVFQWpqWWFDWXNHVEZDTUJ6RWJnUW9OUVFCNE5ob0tpd2RNVUl3SU1SdUJDdzFCQUdJMkdndUxDRXhRakFreEc0RU1EVUVBVERZYURJc0pURkNNQ2pFYmdRME5RUUEyTmhvTml3cE1VSXdMTVJ1QkRnMUJBQ0EyR2c2TEMweFFqQXd4RzRFUERVRUFDallhRDRzTVRGQ01BSWtpcjBMLzlDS3ZRdi9lSXE5Qy84Z2lyMEwvc2lLdlF2K2NJcTlDLzRZaXIwTC9jQ0t2UXY5YUlxOUMvMFVpcjBML0x5S3ZRdjhaSXE5Qy93TWlyMEwrN1NLdlF2N1hJcTlDL3NFaXI0d0FRdjZ3SXE5Qy82WT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlTGFiZWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFiZWwiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVHcmFudGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld01lbWJlciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZVJldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUFkbWluQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUd1YXJkaWFuQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJndWFyZGlhbiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUdyYW50RGVsYXlDaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGF5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2luY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRhcmdldEZ1bmN0aW9uUm9sZVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxlY3RvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0QWRtaW5EZWxheVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsYXkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaW5jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0Q2xvc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjbG9zZWQiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnsiVVJPU19NQUlOX0FQUF9JRCI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOiJBQUFBQUFBQUFBQT0ifX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
