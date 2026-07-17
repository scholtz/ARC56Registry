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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.AccessManagerEnumerable_578e9b36
{


    //
    // @title AccessManagerEnumerable
    // @author Aave Labs
    // @notice Extension of AccessManager that tracks role members and their function selectors using EnumerableSet.
    // @dev Roles, target contracts, and function selectors assigned to `ADMIN_ROLE` are excluded from tracking.
    //
    public class AccessManagerEnumerableProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AccessManagerEnumerableProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class OperationScheduledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 248, 183, 121, 26 };
                public const string Signature = "OperationScheduled(uint8[32],uint64,uint64,uint8[32],uint8[32],byte[])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] OperationId { get; set; }
                public ulong Nonce { get; set; }
                public ulong Schedule { get; set; }
                public byte[] Caller { get; set; }
                public byte[] Target { get; set; }
                public byte[] Data { get; set; }

                public static OperationScheduledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OperationScheduledEvent();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSchedule = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSchedule.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSchedule = vSchedule.ToValue();
                    if (valueSchedule is ulong vScheduleValue) { ret.Schedule = vScheduleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCaller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCaller = vCaller.ToValue();
                    if (valueCaller is byte[] vCallerValue) { ret.Caller = vCallerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTarget = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTarget.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTarget = vTarget.ToValue();
                    if (valueTarget is byte[] vTargetValue) { ret.Target = vTargetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vData.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueData = vData.ToValue();
                    if (valueData is byte[] vDataValue) { ret.Data = vDataValue; }
                    return ret;

                }

            }

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

            public class OperationCanceledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 115, 106, 244, 172 };
                public const string Signature = "OperationCanceled(uint8[32],uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] OperationId { get; set; }
                public ulong Nonce { get; set; }

                public static OperationCanceledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OperationCanceledEvent();
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

        protected override ulong? ExtraProgramPages { get; set; } = 3;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJkZXNjIjoiQHRpdGxlIEFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlXG4gQGF1dGhvciBBYXZlIExhYnNcbiBAbm90aWNlIEV4dGVuc2lvbiBvZiBBY2Nlc3NNYW5hZ2VyIHRoYXQgdHJhY2tzIHJvbGUgbWVtYmVycyBhbmQgdGhlaXIgZnVuY3Rpb24gc2VsZWN0b3JzIHVzaW5nIEVudW1lcmFibGVTZXQuXG4gQGRldiBSb2xlcywgdGFyZ2V0IGNvbnRyYWN0cywgYW5kIGZ1bmN0aW9uIHNlbGVjdG9ycyBhc3NpZ25lZCB0byBgQURNSU5fUk9MRWAgYXJlIGV4Y2x1ZGVkIGZyb20gdHJhY2tpbmcuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFkZHJlc3NTZXQiOlt7Im5hbWUiOiJfaW5uZXIiLCJ0eXBlIjoiU2V0In1dLCJCeXRlczMyU2V0IjpbeyJuYW1lIjoiX2lubmVyIiwidHlwZSI6IlNldCJ9XSwiUm9sZSI6W3sibmFtZSI6Im1lbWJlcnMiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYWRtaW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3VhcmRpYW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3JhbnREZWxheSIsInR5cGUiOiJ1aW50MTEyIn1dLCJTY2hlZHVsZSI6W3sibmFtZSI6InRpbWVwb2ludCIsInR5cGUiOiJ1aW50NDgifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MzIifV0sIlNldCI6W3sibmFtZSI6Il92YWx1ZXMiLCJ0eXBlIjoidWludDhbMzJdW10ifSx7Im5hbWUiOiJfcG9zaXRpb25zIiwidHlwZSI6ImJ5dGVbXSJ9XSwiVGFyZ2V0Q29uZmlnIjpbeyJuYW1lIjoiYWxsb3dlZFJvbGVzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImFkbWluRGVsYXkiLCJ0eXBlIjoidWludDExMiJ9LHsibmFtZSI6ImNsb3NlZCIsInR5cGUiOiJib29sIn1dLCJVaW50U2V0IjpbeyJuYW1lIjoiX2lubmVyIiwidHlwZSI6IlNldCJ9XSwiY2FuQ2FsbFJldHVybiI6W3sibmFtZSI6ImltbWVkaWF0ZSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZGVsYXkiLCJ0eXBlIjoidWludDY0In1dLCJnZXRBY2Nlc3NSZXR1cm4iOlt7Im5hbWUiOiJzaW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjdXJyZW50RGVsYXkiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGVuZGluZ0RlbGF5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVmZmVjdCIsInR5cGUiOiJ1aW50NjQifV0sImhhc1JvbGVSZXR1cm4iOlt7Im5hbWUiOiJpc01lbWJlciIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZXhlY3V0aW9uRGVsYXkiLCJ0eXBlIjoidWludDY0In1dLCJzY2hlZHVsZVJldHVybiI6W3sibmFtZSI6Im9wZXJhdGlvbklkIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoibm9uY2UiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fcG9zdEluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluaXRpYWxBZG1pbl8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJvbGVHcmFudGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld01lbWJlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVDb3VudCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlcyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFkbWluUm9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9pbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWRtaW5Sb2xlQ291bnQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWRtaW5Sb2xlcyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVNZW1iZXIiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9pbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVNZW1iZXJDb3VudCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZU1lbWJlcnMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9zdGFydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9lbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDhbMzJdW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZU9mQWRtaW5Sb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pblJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9pbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZU9mQWRtaW5Sb2xlQ291bnQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluUm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZXNPZkFkbWluUm9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW5Sb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlVGFyZ2V0IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlVGFyZ2V0Q291bnQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVUYXJnZXRzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfc3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfZW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ4WzMyXVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVUYXJnZXRTZWxlY3RvciIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2luZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZVRhcmdldFNlbGVjdG9yQ291bnQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVUYXJnZXRTZWxlY3RvcnMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ4WzRdW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiQURNSU5fUk9MRSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUFVCTElDX1JPTEUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbkNhbGwiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGVjdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iihib29sLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJjYW5DYWxsUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleHBpcmF0aW9uIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtaW5TZXRiYWNrIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc1RhcmdldENsb3NlZCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VGFyZ2V0RnVuY3Rpb25Sb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxlY3RvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VGFyZ2V0QWRtaW5EZWxheSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlQWRtaW4iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlR3VhcmRpYW4iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlR3JhbnREZWxheSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFjY2VzcyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiZ2V0QWNjZXNzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoYXNSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsdWludDY0KSIsInN0cnVjdCI6Imhhc1JvbGVSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxhYmVsUm9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxhYmVsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdyYW50Um9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleGVjdXRpb25EZWxheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVub3VuY2VSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlckNvbmZpcm1hdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRSb2xlQWRtaW4iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRSb2xlR3VhcmRpYW4iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJndWFyZGlhbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRHcmFudERlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3RGVsYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VGFyZ2V0RnVuY3Rpb25Sb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4WzRdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxlY3RvcnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRUYXJnZXRBZG1pbkRlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0RlbGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFRhcmdldENsb3NlZCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xvc2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFNjaGVkdWxlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldE5vbmNlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNjaGVkdWxlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndoZW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbMzJdLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJzY2hlZHVsZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25TY2hlZHVsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjaGVkdWxlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuY2VsIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uQ2FuY2VsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbnN1bWVTY2hlZHVsZWRPcCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGFzaE9wZXJhdGlvbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUF1dGhvcml0eSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QXV0aG9yaXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im11bHRpY2FsbCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTXVsdGljYWxsIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19kZWxlZ2F0ZV91cGRhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDkwMl0sImVycm9yTWVzc2FnZSI6IkFCSSBib29sIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODIxLDczMjRdLCJlcnJvck1lc3NhZ2UiOiJBQkkgdmFsaWRhdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NDJdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyQWxyZWFkeVNjaGVkdWxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3NDhdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyRXhwaXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3ODVdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VySW52YWxpZEluaXRpYWxBZG1pbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3NDJdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyTm90UmVhZHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTA0LDY3MzRdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyTm90U2NoZWR1bGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY1OCwxODU3LDE4NjZdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyVW5hdXRob3JpemVkQ2FsbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NDJdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyVW5hdXRob3JpemVkQ2FuY2VsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM4NV0sImVycm9yTWVzc2FnZSI6IkFjY2Vzc01hbmFnZXJVbmF1dGhvcml6ZWRDb25zdW1lIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE0OF0sImVycm9yTWVzc2FnZSI6IkFkZHJlc3NFbXB0eUNvZGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTU1XSwiZXJyb3JNZXNzYWdlIjoiRmFpbGVkQ2FsbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwOTddLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnRCYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkwN10sImVycm9yTWVzc2FnZSI6IlNhZmVDYXN0T3ZlcmZsb3dlZFVpbnREb3duY2FzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2MTJdLCJlcnJvck1lc3NhZ2UiOiJfX3Bvc3RJbml0IGFscmVhZHkgY2FsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcwMCw3MTY3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX2V4ZWN1dGlvbklkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0MTYsNTQzNl0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyMV0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTA5LDk2MywxMjgwLDEzMTcsMTQyOSwxNjEyLDE3NzgsMjI3MywyNzQ0LDUyMDMsNTI3NSw1MzcwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE1MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjgzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjg4LDEzMjUsMTQzNywxNjIwLDE3ODYsMjc1MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjAzLDEyMTAsMTI2NiwxMjc0LDEzMTEsMTQxMywxNDIzLDE2MDYsMTc2OSwyMDYzLDIxMjUsMjE0MywyMjA1LDIyNjcsMjU0NSwyNjA3LDI2NjksMjgxNiwyODQ5LDMwMzcsMzA1NiwzMDg0LDMxNjgsMzE3NiwzMzE2LDM0MjIsMzQ5NCw0NjA4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNjUsMzE4NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MDEsMzU4MCwzNTg3LDM3MjUsMzk0OCw0MDIyLDQwMjksNDE2Nyw0MzU3LDQ1NDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMyNCwzMzMyLDM3OTgsMzgwNiw0MjMzLDQyNDEsNDQxOSw0NDI3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDUxMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OTksMjIxMiwyMjkwLDIzNTIsMjM1OSwyNDE0LDI0MjEsMjQ3NiwyNDgzLDI1MzgsMjYwMCwyNjYyLDI2NzYsMjczOCwyODA3LDI4NDIsMjkzNSwyOTk3LDMwMTcsMzMwOSwzNDE1LDM0ODcsMzU3MywzNjU5LDM3MTgsMzc5MCwzODgyLDM5NDEsNDAxNSw0MTAxLDQxNjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3VpbnQ4W10pW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTk4LDEzNDMsMTQ1NSwxODE1LDY3OTldLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NTQsMTk3NywxOTkyLDQ4MjgsNDgzOCw0ODUxLDYwNzcsNjExOCw3MzQyXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODU0XSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTMzMyw1Mzc2XSwiZXJyb3JNZXNzYWdlIjoidW5kZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzVoY0hCeWIzWmhiRjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklEQWdNU0F6TWlBNElGUk5VRXhmVlZKUFUxOVBVa05JWDBGUVVGOUpSQ0F5T0RFME56UTVOelkzTVRBMk5UVWdOREk1TkRrMk56STVOU0JVVFZCTVgxVlNUMU5mVTFSUFVrRkhSVjlCVUZCZlNVUUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJQ0pmWDI5blgzTmxibVJsY2lJZ0lsOWZiMmRmZG1Gc2RXVWlJREI0TmpFM1pHRTBNV1FnTUhneE5URm1OMk0zTlNBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQ0F3ZURBeElEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnTUhnMVpqY3lObVkyWXpZMU5HUTJOVFprTmpJMk5UY3lOVE0yTlRjMFlXWTFOVGN3WmpWaE1UZ3hNR0kzWVdZM09HTmhaalJpWXpjd1lUWTJNR1l3WkdZMU1XVTBNbUpoWmpreFpEUmtaVFZpTWpNeU9HUmxNR1U0TTJSbVl5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZZ0lsOWxlR1ZqZFhScGIyNUpaQ0lnSWw5elkyaGxaSFZzWlhNaUlEQjRNREFnSWw5d2IzTnBkR2x2Ym5NaUlDSmZYMk4wYjNKZmNHVnVaR2x1WnlJZ01IZ3dNREF3SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQ0F3ZURBMElEQjRZMlpqTlRrNE1HTWdNSGcxTURSbFptWXdNaUF3ZURoak5EWTBORFZrSURCNE9HSmxNekpqTmpZZ01IZzVNek5tWW1JMllTQXdlRFJqWmpoallqSmxJREI0TmpFMk9ERXdOalFnTUhoalptTTBPVGc1T0NBd2VHVTBOamd5TURVeUlEQjRaamN6TjJGalpqZ2dNSGhoTURCaVpqUXpNQ0F3ZURBeU9XUXhZVGcwSURCNFpHSm1NRGhsTVRBZ01IaGlaak5rTm1aaFlpQXdlRFprWXpNd016QTFJREI0WW1ZMk16YzJOV0lnTUhoa01EYzVOalF6TVNBd2VEbGxZV0UxTnpOaElEQjRZMlptTW1VMk1qRWdNSGhrTkRRME1HWTFOeUF3ZURnM1pEVTBOVEJpSURCNE1tTXdZV05rT0RFZ01IaGtZVGMxTUdJeU15QXdlREV6WlRreU9EZzJJREI0TTJSaVl6WmtORE1nTUhnNU1HWTFPR1UzTlNBd2VHWXhNRFkyTnprNUlEQjRPRGt4WXpNM05HRWdNSGhqTkdSbE1UY3dZaUF3ZUdZeE9HRTRNMkU0SURCNFlqVXhNalUxTldNZ01IZ3laR1l3TW1FeU55QXdlREk0TkRSa1lqbGxJREI0TXpRMFlXWm1OREFnTUhoa09UWmlPR0UzWkNBd2VEQTJaV1JqTXpKbElEQjRZelprTlRFMU1tVWdNSGhoWXpsalltRXdaU0F3ZURnMVpETTRNbVV4SURCNFpHUTVPREk0WkRVZ01IZ3dNREF3TURBd01EQXdNREFnTUhnd01EQXlNREF3TkRBd01EWXdNREF3TURBd01DQXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREFnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3YmlBeE13b2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlERXlDaUFnSUNCd2RYTm9hVzUwSURRd09UWUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhOMGIzSmxJRFVLSUNBZ0lITjBiM0psSURBS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBNE1Bb2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa1l6VmxNemM1T0NBdkx5QnRaWFJvYjJRZ0lsOWZaR1ZzWldkaGRHVmZkWEJrWVhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlmWDJSbGJHVm5ZWFJsWDNWd1pHRjBaVjl5YjNWMFpVQTBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEazVNR1l6TUdGbElDOHZJRzFsZEdodlpDQWlYMTl3YjNOMFNXNXBkQ2hoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0JpZVhSbFl5QXhPQ0F2THlCdFpYUm9iMlFnSW1kbGRGSnZiR1VvZFdsdWRESTFOaWwxYVc1ME5qUWlDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QnRaWFJvYjJRZ0ltZGxkRkp2YkdWRGIzVnVkQ2dwZFdsdWRESTFOaUlLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1F6TlRVMk5HUTFJQzh2SUcxbGRHaHZaQ0FpWjJWMFVtOXNaWE1vZFdsdWREVXhNaXgxYVc1ME5URXlLWFZwYm5RMk5GdGRJZ29nSUNBZ1lubDBaV01nTWpBZ0x5OGdiV1YwYUc5a0lDSm5aWFJCWkcxcGJsSnZiR1VvZFdsdWRESTFOaWwxYVc1ME5qUWlDaUFnSUNCaWVYUmxZeUF5TVNBdkx5QnRaWFJvYjJRZ0ltZGxkRUZrYldsdVVtOXNaVU52ZFc1MEtDbDFhVzUwTWpVMklnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE0yTTFaR0ZrTkdFZ0x5OGdiV1YwYUc5a0lDSm5aWFJCWkcxcGJsSnZiR1Z6S0hWcGJuUTFNVElzZFdsdWREVXhNaWwxYVc1ME5qUmJYU0lLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJRzFsZEdodlpDQWlaMlYwVW05c1pVMWxiV0psY2loMWFXNTBOalFzZFdsdWRESTFOaWxoWkdSeVpYTnpJZ29nSUNBZ1lubDBaV01nTWpNZ0x5OGdiV1YwYUc5a0lDSm5aWFJTYjJ4bFRXVnRZbVZ5UTI5MWJuUW9kV2x1ZERZMEtYVnBiblF5TlRZaUNpQWdJQ0JpZVhSbFl5QXlOQ0F2THlCdFpYUm9iMlFnSW1kbGRGSnZiR1ZOWlcxaVpYSnpLSFZwYm5RMk5DeDFhVzUwTWpVMkxIVnBiblF5TlRZcGRXbHVkRGhiTXpKZFcxMGlDaUFnSUNCaWVYUmxZeUF5TlNBdkx5QnRaWFJvYjJRZ0ltZGxkRkp2YkdWUFprRmtiV2x1VW05c1pTaDFhVzUwTmpRc2RXbHVkREkxTmlsMWFXNTBOalFpQ2lBZ0lDQmllWFJsWXlBeU5pQXZMeUJ0WlhSb2IyUWdJbWRsZEZKdmJHVlBaa0ZrYldsdVVtOXNaVU52ZFc1MEtIVnBiblEyTkNsMWFXNTBNalUySWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TldGbU1HSmtNamNnTHk4Z2JXVjBhRzlrSUNKblpYUlNiMnhsYzA5bVFXUnRhVzVTYjJ4bEtIVnBiblEyTkN4MWFXNTBOVEV5TEhWcGJuUTFNVElwZFdsdWREWTBXMTBpQ2lBZ0lDQmllWFJsWXlBeU55QXZMeUJ0WlhSb2IyUWdJbWRsZEZKdmJHVlVZWEpuWlhRb2RXbHVkRFkwTEhWcGJuUXlOVFlwWVdSa2NtVnpjeUlLSUNBZ0lHSjVkR1ZqSURJNElDOHZJRzFsZEdodlpDQWlaMlYwVW05c1pWUmhjbWRsZEVOdmRXNTBLSFZwYm5RMk5DbDFhVzUwTWpVMklnb2dJQ0FnWW5sMFpXTWdNamtnTHk4Z2JXVjBhRzlrSUNKblpYUlNiMnhsVkdGeVoyVjBjeWgxYVc1ME5qUXNkV2x1ZERJMU5peDFhVzUwTWpVMktYVnBiblE0V3pNeVhWdGRJZ29nSUNBZ1lubDBaV01nTXpBZ0x5OGdiV1YwYUc5a0lDSm5aWFJTYjJ4bFZHRnlaMlYwVTJWc1pXTjBiM0lvZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbGllWFJsV3pSZElnb2dJQ0FnWW5sMFpXTWdNekVnTHk4Z2JXVjBhRzlrSUNKblpYUlNiMnhsVkdGeVoyVjBVMlZzWldOMGIzSkRiM1Z1ZENoMWFXNTBOalFzWVdSa2NtVnpjeWwxYVc1ME1qVTJJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROR013TkdZelpEZ2dMeThnYldWMGFHOWtJQ0puWlhSU2IyeGxWR0Z5WjJWMFUyVnNaV04wYjNKektIVnBiblEyTkN4aFpHUnlaWE56TEhWcGJuUTFNVElzZFdsdWREVXhNaWwxYVc1ME9GczBYVnRkSWdvZ0lDQWdZbmwwWldNZ016SWdMeThnYldWMGFHOWtJQ0pCUkUxSlRsOVNUMHhGS0NsMWFXNTBOalFpQ2lBZ0lDQmllWFJsWXlBek15QXZMeUJ0WlhSb2IyUWdJbEJWUWt4SlExOVNUMHhGS0NsMWFXNTBOalFpQ2lBZ0lDQmllWFJsWXlBek5DQXZMeUJ0WlhSb2IyUWdJbU5oYmtOaGJHd29ZV1JrY21WemN5eGhaR1J5WlhOekxHSjVkR1ZiTkYwcEtHSnZiMndzZFdsdWREWTBLU0lLSUNBZ0lHSjVkR1ZqSURNMUlDOHZJRzFsZEdodlpDQWlaWGh3YVhKaGRHbHZiaWdwZFdsdWREWTBJZ29nSUNBZ1lubDBaV01nTXpZZ0x5OGdiV1YwYUc5a0lDSnRhVzVUWlhSaVlXTnJLQ2wxYVc1ME5qUWlDaUFnSUNCaWVYUmxZeUF6TnlBdkx5QnRaWFJvYjJRZ0ltbHpWR0Z5WjJWMFEyeHZjMlZrS0dGa1pISmxjM01wWW05dmJDSUtJQ0FnSUdKNWRHVmpJRE00SUM4dklHMWxkR2h2WkNBaVoyVjBWR0Z5WjJWMFJuVnVZM1JwYjI1U2IyeGxLR0ZrWkhKbGMzTXNZbmwwWlZzMFhTbDFhVzUwTmpRaUNpQWdJQ0JpZVhSbFl5QXpPU0F2THlCdFpYUm9iMlFnSW1kbGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhrb1lXUmtjbVZ6Y3lsMWFXNTBOalFpQ2lBZ0lDQmllWFJsWXlBME1DQXZMeUJ0WlhSb2IyUWdJbWRsZEZKdmJHVkJaRzFwYmloMWFXNTBOalFwZFdsdWREWTBJZ29nSUNBZ1lubDBaV01nTkRFZ0x5OGdiV1YwYUc5a0lDSm5aWFJTYjJ4bFIzVmhjbVJwWVc0b2RXbHVkRFkwS1hWcGJuUTJOQ0lLSUNBZ0lHSjVkR1ZqSURReUlDOHZJRzFsZEdodlpDQWlaMlYwVW05c1pVZHlZVzUwUkdWc1lYa29kV2x1ZERZMEtYVnBiblEyTkNJS0lDQWdJR0o1ZEdWaklEUXpJQzh2SUcxbGRHaHZaQ0FpWjJWMFFXTmpaWE56S0hWcGJuUTJOQ3hoWkdSeVpYTnpLU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdZbmwwWldNZ05EUWdMeThnYldWMGFHOWtJQ0pvWVhOU2IyeGxLSFZwYm5RMk5DeGhaR1J5WlhOektTaGliMjlzTEhWcGJuUTJOQ2tpQ2lBZ0lDQmllWFJsWXlBME5TQXZMeUJ0WlhSb2IyUWdJbXhoWW1Wc1VtOXNaU2gxYVc1ME5qUXNjM1J5YVc1bktYWnZhV1FpQ2lBZ0lDQmllWFJsWXlBME5pQXZMeUJ0WlhSb2IyUWdJbWR5WVc1MFVtOXNaU2gxYVc1ME5qUXNZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lHSjVkR1ZqSURRM0lDOHZJRzFsZEdodlpDQWljbVYyYjJ0bFVtOXNaU2gxYVc1ME5qUXNZV1JrY21WemN5bDJiMmxrSWdvZ0lDQWdZbmwwWldNZ05EZ2dMeThnYldWMGFHOWtJQ0p5Wlc1dmRXNWpaVkp2YkdVb2RXbHVkRFkwTEdGa1pISmxjM01wZG05cFpDSUtJQ0FnSUdKNWRHVmpJRFE1SUM4dklHMWxkR2h2WkNBaWMyVjBVbTlzWlVGa2JXbHVLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lHSjVkR1ZqSURVd0lDOHZJRzFsZEdodlpDQWljMlYwVW05c1pVZDFZWEprYVdGdUtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUdKNWRHVmpJRFV4SUM4dklHMWxkR2h2WkNBaWMyVjBSM0poYm5SRVpXeGhlU2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQmllWFJsWXlBMU1pQXZMeUJ0WlhSb2IyUWdJbk5sZEZSaGNtZGxkRVoxYm1OMGFXOXVVbTlzWlNoaFpHUnlaWE56TEhWcGJuUTRXelJkVzEwc2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCaWVYUmxZeUExTXlBdkx5QnRaWFJvYjJRZ0luTmxkRlJoY21kbGRFRmtiV2x1UkdWc1lYa29ZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lHSjVkR1ZqSURVMElDOHZJRzFsZEdodlpDQWljMlYwVkdGeVoyVjBRMnh2YzJWa0tHRmtaSEpsYzNNc1ltOXZiQ2wyYjJsa0lnb2dJQ0FnWW5sMFpXTWdOVFVnTHk4Z2JXVjBhRzlrSUNKblpYUlRZMmhsWkhWc1pTaGllWFJsV3pNeVhTbDFhVzUwTmpRaUNpQWdJQ0JpZVhSbFl5QTFOaUF2THlCdFpYUm9iMlFnSW1kbGRFNXZibU5sS0dKNWRHVmJNekpkS1hWcGJuUTJOQ0lLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd5WVRNeVkyUmtNU0F3ZUROaU5XTmhNRGcySURCNE1tTTRNelkyWkRnZ01IZzJOamxoWXpBMFlpQXdlREEwT1RVeFl6STVJQzh2SUcxbGRHaHZaQ0FpYzJOb1pXUjFiR1VvWVdSa2NtVnpjeXhpZVhSbFcxMHNkV2x1ZERZMEtTaGllWFJsV3pNeVhTeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSmxlR1ZqZFhSbEtHRmtaSEpsYzNNc1lubDBaVnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWTJGdVkyVnNLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGllWFJsVzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKamIyNXpkVzFsVTJOb1pXUjFiR1ZrVDNBb1lXUmtjbVZ6Y3l4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlhR0Z6YUU5d1pYSmhkR2x2YmloaFpHUnlaWE56TEdGa1pISmxjM01zWW5sMFpWdGRLV0o1ZEdWYk16SmRJZ29nSUNBZ1lubDBaV01nTlRjZ0x5OGdiV1YwYUc5a0lDSjFjR1JoZEdWQmRYUm9iM0pwZEhrb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dORGt4T1dFeU5pQXZMeUJ0WlhSb2IyUWdJbTExYkhScFkyRnNiQ2hpZVhSbFcxMWJYU2xpZVhSbFcxMWJYU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZYMTl3YjNOMFNXNXBkRjl5YjNWMFpVQTNJRzFoYVc1ZloyVjBVbTlzWlY5eWIzVjBaVUE0SUcxaGFXNWZaMlYwVW05c1pVTnZkVzUwWDNKdmRYUmxRRGtnYldGcGJsOW5aWFJTYjJ4bGMxOXliM1YwWlVBeE1DQnRZV2x1WDJkbGRFRmtiV2x1VW05c1pWOXliM1YwWlVBeE1TQnRZV2x1WDJkbGRFRmtiV2x1VW05c1pVTnZkVzUwWDNKdmRYUmxRREV5SUcxaGFXNWZaMlYwUVdSdGFXNVNiMnhsYzE5eWIzVjBaVUF4TXlCdFlXbHVYMmRsZEZKdmJHVk5aVzFpWlhKZmNtOTFkR1ZBTVRRZ2JXRnBibDluWlhSU2IyeGxUV1Z0WW1WeVEyOTFiblJmY205MWRHVkFNVFVnYldGcGJsOW5aWFJTYjJ4bFRXVnRZbVZ5YzE5eWIzVjBaVUF4TmlCdFlXbHVYMmRsZEZKdmJHVlBaa0ZrYldsdVVtOXNaVjl5YjNWMFpVQXhOeUJ0WVdsdVgyZGxkRkp2YkdWUFprRmtiV2x1VW05c1pVTnZkVzUwWDNKdmRYUmxRREU0SUcxaGFXNWZaMlYwVW05c1pYTlBaa0ZrYldsdVVtOXNaVjl5YjNWMFpVQXhPU0J0WVdsdVgyZGxkRkp2YkdWVVlYSm5aWFJmY205MWRHVkFNakFnYldGcGJsOW5aWFJTYjJ4bFZHRnlaMlYwUTI5MWJuUmZjbTkxZEdWQU1qRWdiV0ZwYmw5blpYUlNiMnhsVkdGeVoyVjBjMTl5YjNWMFpVQXlNaUJ0WVdsdVgyZGxkRkp2YkdWVVlYSm5aWFJUWld4bFkzUnZjbDl5YjNWMFpVQXlNeUJ0WVdsdVgyZGxkRkp2YkdWVVlYSm5aWFJUWld4bFkzUnZja052ZFc1MFgzSnZkWFJsUURJMElHMWhhVzVmWjJWMFVtOXNaVlJoY21kbGRGTmxiR1ZqZEc5eWMxOXliM1YwWlVBeU5TQnRZV2x1WDBGRVRVbE9YMUpQVEVWZmNtOTFkR1ZBTWpZZ2JXRnBibDlRVlVKTVNVTmZVazlNUlY5eWIzVjBaVUF5TnlCdFlXbHVYMk5oYmtOaGJHeGZjbTkxZEdWQU1qZ2diV0ZwYmw5bGVIQnBjbUYwYVc5dVgzSnZkWFJsUURJNUlHMWhhVzVmYldsdVUyVjBZbUZqYTE5eWIzVjBaVUF6TUNCdFlXbHVYMmx6VkdGeVoyVjBRMnh2YzJWa1gzSnZkWFJsUURNeElHMWhhVzVmWjJWMFZHRnlaMlYwUm5WdVkzUnBiMjVTYjJ4bFgzSnZkWFJsUURNeUlHMWhhVzVmWjJWMFZHRnlaMlYwUVdSdGFXNUVaV3hoZVY5eWIzVjBaVUF6TXlCdFlXbHVYMmRsZEZKdmJHVkJaRzFwYmw5eWIzVjBaVUF6TkNCdFlXbHVYMmRsZEZKdmJHVkhkV0Z5WkdsaGJsOXliM1YwWlVBek5TQnRZV2x1WDJkbGRGSnZiR1ZIY21GdWRFUmxiR0Y1WDNKdmRYUmxRRE0ySUcxaGFXNWZaMlYwUVdOalpYTnpYM0p2ZFhSbFFETTNJRzFoYVc1ZmFHRnpVbTlzWlY5eWIzVjBaVUF6T0NCdFlXbHVYMnhoWW1Wc1VtOXNaVjl5YjNWMFpVQXpPU0J0WVdsdVgyZHlZVzUwVW05c1pWOXliM1YwWlVBME1DQnRZV2x1WDNKbGRtOXJaVkp2YkdWZmNtOTFkR1ZBTkRFZ2JXRnBibDl5Wlc1dmRXNWpaVkp2YkdWZmNtOTFkR1ZBTkRJZ2JXRnBibDl6WlhSU2IyeGxRV1J0YVc1ZmNtOTFkR1ZBTkRNZ2JXRnBibDl6WlhSU2IyeGxSM1ZoY21ScFlXNWZjbTkxZEdWQU5EUWdiV0ZwYmw5elpYUkhjbUZ1ZEVSbGJHRjVYM0p2ZFhSbFFEUTFJRzFoYVc1ZmMyVjBWR0Z5WjJWMFJuVnVZM1JwYjI1U2IyeGxYM0p2ZFhSbFFEUTJJRzFoYVc1ZmMyVjBWR0Z5WjJWMFFXUnRhVzVFWld4aGVWOXliM1YwWlVBME55QnRZV2x1WDNObGRGUmhjbWRsZEVOc2IzTmxaRjl5YjNWMFpVQTBPQ0J0WVdsdVgyZGxkRk5qYUdWa2RXeGxYM0p2ZFhSbFFEUTVJRzFoYVc1ZloyVjBUbTl1WTJWZmNtOTFkR1ZBTlRBZ2JXRnBibDl6WTJobFpIVnNaVjl5YjNWMFpVQTFNU0J0WVdsdVgyVjRaV04xZEdWZmNtOTFkR1ZBTlRJZ2JXRnBibDlqWVc1alpXeGZjbTkxZEdWQU5UTWdiV0ZwYmw5amIyNXpkVzFsVTJOb1pXUjFiR1ZrVDNCZmNtOTFkR1ZBTlRRZ2JXRnBibDlvWVhOb1QzQmxjbUYwYVc5dVgzSnZkWFJsUURVMUlHMWhhVzVmZFhCa1lYUmxRWFYwYUc5eWFYUjVYM0p2ZFhSbFFEVTJJRzFoYVc1ZmJYVnNkR2xqWVd4c1gzSnZkWFJsUURVM0NpQWdJQ0JsY25JS0NtMWhhVzVmYlhWc2RHbGpZV3hzWDNKdmRYUmxRRFUzT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXpDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ29LSUNBZ0lHSjFjbmtnTndvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjFjbmtnTWpZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlkWEo1SURFd0NncHRZV2x1WDJadmNsOW9aV0ZrWlhKQU5qSTZDaUFnSUNCa2FXY2dPUW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQThDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMlp2Y2tBMk5Bb2dJQ0FnWkdsbklEa0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXFDaUFnSUNCa2FXY2dNamNLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ09Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHWnZjaUFvYkdWdUt5aHNaVzRyZFdsdWREaGJYU2xiWFNrS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR0oxY25rZ053b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJR0lnYldGcGJsOW1iM0pmYUdWaFpHVnlRRFl5Q2dwdFlXbHVYMkZtZEdWeVgyWnZja0EyTkRvS0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyTmdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEyTnpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdNSGd3TURBd0NpQWdJQ0JpZFhKNUlESTNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhNZ29LYldGcGJsOTNhR2xzWlY5MGIzQkFOamc2Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnUEFvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5M2FHbHNaVUEzTUFvZ0lDQWdaR2xuSURJMkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZbmwwWldNZ01UVWdMeThnTUhnd01EQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJRjl5WldOaGJHTjFiR0YwWlY5b1pXRmtYMlp2Y2w5bGJHVnRaVzUwYzE5M2FYUm9YMko1ZEdWZmJHVnVaM1JvWDJobFlXUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhNd29nSUNBZ1luVnllU0F5TndvZ0lDQWdZaUJ0WVdsdVgzZG9hV3hsWDNSdmNFQTJPQW9LYldGcGJsOWhablJsY2w5M2FHbHNaVUEzTURvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdZblZ5ZVNBeU1nb2dJQ0FnWkdsbklESTJDaUFnSUNCaWRYSjVJREUzQ2dwdFlXbHVYM2RvYVd4bFgzUnZjRUEzTVRvS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklESXlDaUFnSUNCaVBnb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOTNhR2xzWlVBM013b2dJQ0FnYkc5aFpDQXdDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF5TWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JREVLSUNBZ0lITjFZbk4wY21sdVp5QXdJRElLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2RYQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lDc0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHSjVkR1ZqSURFMUlDOHZJREI0TURBd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJmY21WallXeGpkV3hoZEdWZmFHVmhaRjltYjNKZlpXeGxiV1Z1ZEhOZmQybDBhRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTVRnS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01Rb2dJQ0FnWWlzS0lDQWdJR0oxY25rZ01qSUtJQ0FnSUdJZ2JXRnBibDkzYUdsc1pWOTBiM0JBTnpFS0NtMWhhVzVmWVdaMFpYSmZkMmhwYkdWQU56TTZDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUdScFp5QXhOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk5qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk53b0tiV0ZwYmw5MWNHUmhkR1ZCZFhSb2IzSnBkSGxmY205MWRHVkFOVFk2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQmpZV3hzYzNWaUlGOWZkWEp2YzE5bWIzSjNZWEprWDNaaGJIVmxDaUFnSUNCallXeHNjM1ZpSUY5ZmRYSnZjMTl2WjE5elpYUjFjQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYVc1MFl5QTBJQzh2SUZSTlVFeGZWVkpQVTE5UFVrTklYMEZRVUY5SlJBb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh6SUM4dklHMWxkR2h2WkNBaVpHbHpjR0YwWTJnb0tXSjVkR1ZiWFNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCaWVYUmxZeUExTnlBdkx5QnRaWFJvYjJRZ0luVndaR0YwWlVGMWRHaHZjbWwwZVNoaFpHUnlaWE56TEdGa1pISmxjM01wZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZYMjluWDNObGJtUmxjaUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWDE5dloxOTJZV3gxWlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlvWVhOb1QzQmxjbUYwYVc5dVgzSnZkWFJsUURVMU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTJGc2JITjFZaUJvWVhOb1QzQmxjbUYwYVc5dUNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOdmJuTjFiV1ZUWTJobFpIVnNaV1JQY0Y5eWIzVjBaVUExTkRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU5nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWRYSjVJREkwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURneENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURneU9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdOa05URXpaR0UxSUM4dklHMWxkR2h2WkNBaWFYTkRiMjV6ZFcxcGJtZFRZMmhsWkhWc1pXUlBjQ2dwWW5sMFpWczBYU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPR1ppTXpZd016Y0tJQ0FnSUNFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV05qWlhOelRXRnVZV2RsY2xWdVlYVjBhRzl5YVhwbFpFTnZibk4xYldVS0lDQWdJR1JwWnlBeU5Rb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESTFDaUFnSUNCallXeHNjM1ZpSUdoaGMyaFBjR1Z5WVhScGIyNEtJQ0FnSUdOaGJHeHpkV0lnWDJOdmJuTjFiV1ZUWTJobFpIVnNaV1JQY0FvZ0lDQWdjRzl3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU9ERTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU9ESUtDbTFoYVc1ZlkyRnVZMlZzWDNKdmRYUmxRRFV6T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJMkNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UWUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1luVnllU0F5TkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNE5nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNE56b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREl3Q2lBZ0lDQmthV2NnTWpRS0lDQWdJR1IxY0FvZ0lDQWdjM1ZpYzNSeWFXNW5JREFnTkFvZ0lDQWdZblZ5ZVNBeE9Bb2dJQ0FnWkdsbklESTJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUdoaGMyaFBjR1Z5WVhScGIyNEtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNUW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWDNOamFHVmtkV3hsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXpDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBd0lEWUtJQ0FnSUdKMGIya0tJQ0FnSUNFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNOTllXNWhaMlZ5VG05MFUyTm9aV1IxYkdWa0NpQWdJQ0FoUFFvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURrd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaR2xuSURFNUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnYUdGelVtOXNaUW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJVWVhKblpYUkdkVzVqZEdsdmJsSnZiR1VLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVbTlzWlVkMVlYSmthV0Z1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlHaGhjMUp2YkdVS0lDQWdJSEJ2Y0FvZ0lDQWdZblZ5ZVNBeE1Bb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTVNQW9nSUNBZ1pHbG5JRGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNOTllXNWhaMlZ5Vlc1aGRYUm9iM0pwZW1Wa1EyRnVZMlZzQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU9UQTZDaUFnSUNCa2FXY2dNVGtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ05pQTBDaUFnSUNCaWVYUmxZeUExT0NBdkx5QXdlREF3TURBd01EQXdNREF3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5Rek1nb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROek0yWVdZMFlXTWdMeThnYldWMGFHOWtJQ0pQY0dWeVlYUnBiMjVEWVc1alpXeGxaQ2gxYVc1ME9Gc3pNbDBzZFdsdWREWTBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqSURZZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ0pnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGcyT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGczQ2dwdFlXbHVYMlY0WldOMWRHVmZjbTkxZEdWQU5USTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVFlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5T0FvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURNS0lDQWdJR05oYkd4emRXSWdYMk5oYmtOaGJHeEZlSFJsYm1SbFpBb2dJQ0FnY0c5d0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOWpZVzVEWVd4c1JYaDBaVzVrWldRS0lDQWdJR0oxY25rZ05nb2dJQ0FnY0c5d0NpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEazBDaUFnSUNCa2FXY2dNd29nSUNBZ0lRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZqWTJWemMwMWhibUZuWlhKVmJtRjFkR2h2Y21sNlpXUkRZV3hzQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU9UUTZDaUFnSUNCa2FXY2dNalFLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdaR2xuSURJMUNpQWdJQ0JqWVd4c2MzVmlJR2hoYzJoUGNHVnlZWFJwYjI0S0lDQWdJR0oxY25rZ01UZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlEY0tJQ0FnSUdScFp5QXpDaUFnSUNCaWJub2diV0ZwYmw5cFpsOWliMlI1UURrMkNpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFUyTm9aV1IxYkdVS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNU53b0tiV0ZwYmw5cFpsOWliMlI1UURrMk9nb2dJQ0FnWkdsbklERTNDaUFnSUNCallXeHNjM1ZpSUY5amIyNXpkVzFsVTJOb1pXUjFiR1ZrVDNBS0lDQWdJR0oxY25rZ053b0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRGszT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0pmWlhobFkzVjBhVzl1U1dRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0F5TkFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOWxlR1ZqZFhScGIyNUpaQ0JsZUdsemRITUtJQ0FnSUdScFp5QXlNd29nSUNBZ2MzVmljM1J5YVc1bklEQWdOQW9nSUNBZ1pHbG5JREUxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOW9ZWE5vUlhobFkzVjBhVzl1U1dRS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKZlpYaGxZM1YwYVc5dVNXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUE1T1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TURBNkNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdScFp5QXlOUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRUZrWkhKbGMzTXVablZ1WTNScGIyNURZV3hzVjJsMGFGWmhiSFZsQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0pmWlhobFkzVjBhVzl1U1dRaUNpQWdJQ0JrYVdjZ01qTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCa2FXY2dOZ29nSUNBZ2FXNTBZeUEySUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNZS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTVPVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNREFLQ20xaGFXNWZjMk5vWldSMWJHVmZjbTkxZEdWQU5URTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVFlLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZFhKNUlESTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmlkWEo1SURFS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UQTBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXdOVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpJRFVnTHk4Z01qZ3hORGMwT1RjMk56RXdOalUxQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFRkNTU0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQnBiblJqSURVZ0x5OGdNamd4TkRjME9UYzJOekV3TmpVMUNpQWdJQ0FtQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREkzQ2lBZ0lDQmthV2NnTVRZS0lDQWdJR1JwWnlBeU5nb2dJQ0FnWTJGc2JITjFZaUJmWTJGdVEyRnNiRVY0ZEdWdVpHVmtDaUFnSUNCaWRYSjVJREVLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzUwYVcxbGMzUmhiWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVFlLSUNBZ0lHbHVkR01nTlNBdkx5QXlPREUwTnpRNU56WTNNVEEyTlRVS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUNFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNOTllXNWhaMlZ5Vlc1aGRYUm9iM0pwZW1Wa1EyRnNiQW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV3TndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTVRNS0lDQWdJRHdLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQlkyTmxjM05OWVc1aFoyVnlWVzVoZFhSb2IzSnBlbVZrUTJGc2JBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV3TnpvS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd01nb2dJQ0FnWTJGc2JITjFZaUJOWVhSb0xtMWhlQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJOWVhSb0xtMWhlQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqSURVZ0x5OGdNamd4TkRjME9UYzJOekV3TmpVMUNpQWdJQ0FtQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR1JwWnlBeU5Bb2dJQ0FnWkdsbklERTFDaUFnSUNCa2FXY2dNalVLSUNBZ0lHTmhiR3h6ZFdJZ2FHRnphRTl3WlhKaGRHbHZiZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREU1Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKZmMyTm9aV1IxYkdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNakVLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElEQWdOZ29nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFlLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVRBS0lDQWdJR1JwWnlBMENpQWdJQ0JqWVd4c2MzVmlJRjlwYzBWNGNHbHlaV1FLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNOTllXNWhaMlZ5UVd4eVpXRmtlVk5qYUdWa2RXeGxaQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeE1Eb0tJQ0FnSUdScFp5QXhPUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERNeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ2NIVnphR2x1ZENBME1qazBPVFkzTWprMkNpQWdJQ0FsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEWWdOQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1ltbDBiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01pQTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW1sMGJHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRDQXdJRFlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmthV2NnTWpBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5TndvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREEzTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaamhpTnpjNU1XRWdMeThnYldWMGFHOWtJQ0pQY0dWeVlYUnBiMjVUWTJobFpIVnNaV1FvZFdsdWREaGJNekpkTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3hpZVhSbFcxMHBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR01nTmlBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRBMUNncHRZV2x1WDJkbGRFNXZibU5sWDNKdmRYUmxRRFV3T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZlptOXlkMkZ5WkY5MllXeDFaUW9nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mYjJkZmMyVjBkWEFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZTVDFOZlQxSkRTRjlCVUZCZlNVUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTXlBdkx5QnRaWFJvYjJRZ0ltUnBjM0JoZEdOb0tDbGllWFJsVzEwaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1lubDBaV01nTlRZZ0x5OGdiV1YwYUc5a0lDSm5aWFJPYjI1alpTaGllWFJsV3pNeVhTbDFhVzUwTmpRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ01UQWdNQW9nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMTl2WjE5elpXNWtaWElpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWalh6SWdMeThnSWw5ZmIyZGZkbUZzZFdVaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFUyTm9aV1IxYkdWZmNtOTFkR1ZBTkRrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR05oYkd4emRXSWdaMlYwVTJOb1pXUjFiR1VLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjMlYwVkdGeVoyVjBRMnh2YzJWa1gzSnZkWFJsUURRNE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCallXeHNjM1ZpSUY5ZmRYSnZjMTltYjNKM1lYSmtYM1poYkhWbENpQWdJQ0JqWVd4c2MzVmlJRjlmZFhKdmMxOXZaMTl6WlhSMWNBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdhVzUwWXlBMElDOHZJRlJOVUV4ZlZWSlBVMTlQVWtOSVgwRlFVRjlKUkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpWkdsemNHRjBZMmdvS1dKNWRHVmJYU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZVhSbFl5QTFOQ0F2THlCdFpYUm9iMlFnSW5ObGRGUmhjbWRsZEVOc2IzTmxaQ2hoWkdSeVpYTnpMR0p2YjJ3cGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmWDI5blgzTmxibVJsY2lJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVgxOXZaMTkyWVd4MVpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUlVZWEpuWlhSQlpHMXBia1JsYkdGNVgzSnZkWFJsUURRM09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHTmhiR3h6ZFdJZ1gxOTFjbTl6WDJadmNuZGhjbVJmZG1Gc2RXVUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMjluWDNObGRIVndDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVazlUWDA5U1EwaGZRVkJRWDBsRUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKa2FYTndZWFJqYUNncFlubDBaVnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdKNWRHVmpJRFV6SUM4dklHMWxkR2h2WkNBaWMyVjBWR0Z5WjJWMFFXUnRhVzVFWld4aGVTaGhaR1J5WlhOekxIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDlmYjJkZmMyVnVaR1Z5SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKZlgyOW5YM1poYkhWbElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGUmhjbWRsZEVaMWJtTjBhVzl1VW05c1pWOXliM1YwWlVBME5qb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBMFBqNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmpZV3hzYzNWaUlGOWZkWEp2YzE5bWIzSjNZWEprWDNaaGJIVmxDaUFnSUNCallXeHNjM1ZpSUY5ZmRYSnZjMTl2WjE5elpYUjFjQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnYVc1MFl5QTBJQzh2SUZSTlVFeGZWVkpQVTE5UFVrTklYMEZRVUY5SlJBb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh6SUM4dklHMWxkR2h2WkNBaVpHbHpjR0YwWTJnb0tXSjVkR1ZiWFNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCaWVYUmxZeUExTWlBdkx5QnRaWFJvYjJRZ0luTmxkRlJoY21kbGRFWjFibU4wYVc5dVVtOXNaU2hoWkdSeVpYTnpMSFZwYm5RNFd6UmRXMTBzZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjMlYwUjNKaGJuUkVaV3hoZVY5eWIzVjBaVUEwTlRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZlptOXlkMkZ5WkY5MllXeDFaUW9nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mYjJkZmMyVjBkWEFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZTVDFOZlQxSkRTRjlCVUZCZlNVUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTXlBdkx5QnRaWFJvYjJRZ0ltUnBjM0JoZEdOb0tDbGllWFJsVzEwaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1lubDBaV01nTlRFZ0x5OGdiV1YwYUc5a0lDSnpaWFJIY21GdWRFUmxiR0Y1S0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZlgyOW5YM05sYm1SbGNpSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlYMTl2WjE5MllXeDFaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaWFJTYjJ4bFIzVmhjbVJwWVc1ZmNtOTFkR1ZBTkRRNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyWnZjbmRoY21SZmRtRnNkV1VLSUNBZ0lHTmhiR3h6ZFdJZ1gxOTFjbTl6WDI5blgzTmxkSFZ3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCcGJuUmpJRFFnTHk4Z1ZFMVFURjlWVWs5VFgwOVNRMGhmUVZCUVgwbEVDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdiV1YwYUc5a0lDSmthWE53WVhSamFDZ3BZbmwwWlZ0ZElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHSjVkR1ZqSURVd0lDOHZJRzFsZEdodlpDQWljMlYwVW05c1pVZDFZWEprYVdGdUtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZYMjluWDNObGJtUmxjaUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWDE5dloxOTJZV3gxWlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6WlhSU2IyeGxRV1J0YVc1ZmNtOTFkR1ZBTkRNNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyWnZjbmRoY21SZmRtRnNkV1VLSUNBZ0lHTmhiR3h6ZFdJZ1gxOTFjbTl6WDI5blgzTmxkSFZ3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCcGJuUmpJRFFnTHk4Z1ZFMVFURjlWVWs5VFgwOVNRMGhmUVZCUVgwbEVDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdiV1YwYUc5a0lDSmthWE53WVhSamFDZ3BZbmwwWlZ0ZElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHSjVkR1ZqSURRNUlDOHZJRzFsZEdodlpDQWljMlYwVW05c1pVRmtiV2x1S0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZlgyOW5YM05sYm1SbGNpSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlYMTl2WjE5MllXeDFaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaVzV2ZFc1alpWSnZiR1ZmY205MWRHVkFOREk2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnWTJGc2JITjFZaUJmWDNWeWIzTmZabTl5ZDJGeVpGOTJZV3gxWlFvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZmIyZGZjMlYwZFhBS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHbHVkR01nTkNBdkx5QlVUVkJNWDFWU1QxTmZUMUpEU0Y5QlVGQmZTVVFLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk15QXZMeUJ0WlhSb2IyUWdJbVJwYzNCaGRHTm9LQ2xpZVhSbFcxMGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdZbmwwWldNZ05EZ2dMeThnYldWMGFHOWtJQ0p5Wlc1dmRXNWpaVkp2YkdVb2RXbHVkRFkwTEdGa1pISmxjM01wZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZYMjluWDNObGJtUmxjaUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWDE5dloxOTJZV3gxWlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WlhadmEyVlNiMnhsWDNKdmRYUmxRRFF4T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMlp2Y25kaGNtUmZkbUZzZFdVS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyOW5YM05sZEhWd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlVrOVRYMDlTUTBoZlFWQlFYMGxFQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6TWdMeThnYldWMGFHOWtJQ0prYVhOd1lYUmphQ2dwWW5sMFpWdGRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR0o1ZEdWaklEUTNJQzh2SUcxbGRHaHZaQ0FpY21WMmIydGxVbTlzWlNoMWFXNTBOalFzWVdSa2NtVnpjeWwyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOWZiMmRmYzJWdVpHVnlJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmWDI5blgzWmhiSFZsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmR5WVc1MFVtOXNaVjl5YjNWMFpVQTBNRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mWm05eWQyRnlaRjkyWVd4MVpRb2dJQ0FnWTJGc2JITjFZaUJmWDNWeWIzTmZiMmRmYzJWMGRYQUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlNUMU5mVDFKRFNGOUJVRkJmU1VRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSW1ScGMzQmhkR05vS0NsaWVYUmxXMTBpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTWdORFlnTHk4Z2JXVjBhRzlrSUNKbmNtRnVkRkp2YkdVb2RXbHVkRFkwTEdGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZiR0ZpWld4U2IyeGxYM0p2ZFhSbFFETTVPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMlp2Y25kaGNtUmZkbUZzZFdVS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyOW5YM05sZEhWd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlVrOVRYMDlTUTBoZlFWQlFYMGxFQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6TWdMeThnYldWMGFHOWtJQ0prYVhOd1lYUmphQ2dwWW5sMFpWdGRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR0o1ZEdWaklEUTFJQzh2SUcxbGRHaHZaQ0FpYkdGaVpXeFNiMnhsS0hWcGJuUTJOQ3h6ZEhKcGJtY3BkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZlgyOW5YM05sYm1SbGNpSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlYMTl2WjE5MllXeDFaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW9ZWE5TYjJ4bFgzSnZkWFJsUURNNE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCallXeHNjM1ZpSUdoaGMxSnZiR1VLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEVGalkyVnpjMTl5YjNWMFpVQXpOem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JqWVd4c2MzVmlJRjlmZFhKdmMxOW1iM0ozWVhKa1gzWmhiSFZsQ2lBZ0lDQmpZV3hzYzNWaUlGOWZkWEp2YzE5dloxOXpaWFIxY0FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2FXNTBZeUEwSUM4dklGUk5VRXhmVlZKUFUxOVBVa05JWDBGUVVGOUpSQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eklDOHZJRzFsZEdodlpDQWlaR2x6Y0dGMFkyZ29LV0o1ZEdWYlhTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmllWFJsWXlBME15QXZMeUJ0WlhSb2IyUWdJbWRsZEVGalkyVnpjeWgxYVc1ME5qUXNZV1JrY21WemN5a29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjRzRnTXdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDE5dloxOXpaVzVrWlhJaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lsOWZiMmRmZG1Gc2RXVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaWGgwY21GamRDQXhNQ0E0Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdWNGRISmhZM1FnTVRnZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdNallnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRE0wSURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsUjNKaGJuUkVaV3hoZVY5eWIzVjBaVUF6TmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCallXeHNjM1ZpSUY5ZmRYSnZjMTltYjNKM1lYSmtYM1poYkhWbENpQWdJQ0JqWVd4c2MzVmlJRjlmZFhKdmMxOXZaMTl6WlhSMWNBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdhVzUwWXlBMElDOHZJRlJOVUV4ZlZWSlBVMTlQVWtOSVgwRlFVRjlKUkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpWkdsemNHRjBZMmdvS1dKNWRHVmJYU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZVhSbFl5QTBNaUF2THlCdFpYUm9iMlFnSW1kbGRGSnZiR1ZIY21GdWRFUmxiR0Y1S0hWcGJuUTJOQ2wxYVc1ME5qUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdNVEFnTUFvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDE5dloxOXpaVzVrWlhJaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lsOWZiMmRmZG1Gc2RXVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVbTlzWlVkMVlYSmthV0Z1WDNKdmRYUmxRRE0xT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWTJGc2JITjFZaUJuWlhSU2IyeGxSM1ZoY21ScFlXNEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVbTlzWlVGa2JXbHVYM0p2ZFhSbFFETTBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMkZzYkhOMVlpQm5aWFJTYjJ4bFFXUnRhVzRLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVkdGeVoyVjBRV1J0YVc1RVpXeGhlVjl5YjNWMFpVQXpNem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1kyRnNiSE4xWWlCblpYUlVZWEpuWlhSQlpHMXBia1JsYkdGNUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGUmhjbWRsZEVaMWJtTjBhVzl1VW05c1pWOXliM1YwWlVBek1qb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dORDRLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBWR0Z5WjJWMFJuVnVZM1JwYjI1U2IyeGxDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgybHpWR0Z5WjJWMFEyeHZjMlZrWDNKdmRYUmxRRE14T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQmpZV3hzYzNWaUlHbHpWR0Z5WjJWMFEyeHZjMlZrQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZiV2x1VTJWMFltRmphMTl5YjNWMFpVQXpNRG9LSUNBZ0lHTmhiR3h6ZFdJZ1gxOTFjbTl6WDJadmNuZGhjbVJmZG1Gc2RXVUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMjluWDNObGRIVndDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVazlUWDA5U1EwaGZRVkJRWDBsRUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKa2FYTndZWFJqYUNncFlubDBaVnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdKNWRHVmpJRE0ySUM4dklHMWxkR2h2WkNBaWJXbHVVMlYwWW1GamF5Z3BkV2x1ZERZMElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTVRBZ01Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaWGh3YVhKaGRHbHZibDl5YjNWMFpVQXlPVG9LSUNBZ0lHTmhiR3h6ZFdJZ1pYaHdhWEpoZEdsdmJnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5allXNURZV3hzWDNKdmRYUmxRREk0T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURRK0NpQWdJQ0JqWVd4c2MzVmlJR05oYmtOaGJHd0tJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxQlZRa3hKUTE5U1QweEZYM0p2ZFhSbFFESTNPZ29nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mWm05eWQyRnlaRjkyWVd4MVpRb2dJQ0FnWTJGc2JITjFZaUJmWDNWeWIzTmZiMmRmYzJWMGRYQUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlNUMU5mVDFKRFNGOUJVRkJmU1VRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSW1ScGMzQmhkR05vS0NsaWVYUmxXMTBpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTWdNek1nTHk4Z2JXVjBhRzlrSUNKUVZVSk1TVU5mVWs5TVJTZ3BkV2x1ZERZMElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTVRBZ01Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZRVVJOU1U1ZlVrOU1SVjl5YjNWMFpVQXlOam9LSUNBZ0lHTmhiR3h6ZFdJZ1gxOTFjbTl6WDJadmNuZGhjbVJmZG1Gc2RXVUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMjluWDNObGRIVndDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVazlUWDA5U1EwaGZRVkJRWDBsRUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKa2FYTndZWFJqYUNncFlubDBaVnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdKNWRHVmpJRE15SUM4dklHMWxkR2h2WkNBaVFVUk5TVTVmVWs5TVJTZ3BkV2x1ZERZMElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTVRBZ01Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVW05c1pWUmhjbWRsZEZObGJHVmpkRzl5YzE5eWIzVjBaVUF5TlRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMlp2Y25kaGNtUmZkbUZzZFdVS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyOW5YM05sZEhWd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlVrOVRYMDlTUTBoZlFWQlFYMGxFQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6TWdMeThnYldWMGFHOWtJQ0prYVhOd1lYUmphQ2dwWW5sMFpWdGRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdRd01USmtaRE5rSUM4dklHMWxkR2h2WkNBaVoyVjBVbTlzWlZSaGNtZGxkRk5sYkdWamRHOXljeWgxYVc1ME5qUXNZV1JrY21WemN5eGlhV2QxYVc1MExHSnBaM1ZwYm5RcGRXbHVkRGhiTkYxYlhTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTVRBZ01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVW05c1pWUmhjbWRsZEZObGJHVmpkRzl5UTI5MWJuUmZjbTkxZEdWQU1qUTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZlptOXlkMkZ5WkY5MllXeDFaUW9nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mYjJkZmMyVjBkWEFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZTVDFOZlQxSkRTRjlCVUZCZlNVUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTXlBdkx5QnRaWFJvYjJRZ0ltUnBjM0JoZEdOb0tDbGllWFJsVzEwaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1lubDBaV01nTXpFZ0x5OGdiV1YwYUc5a0lDSm5aWFJTYjJ4bFZHRnlaMlYwVTJWc1pXTjBiM0pEYjNWdWRDaDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQXhNQ0F3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmWDI5blgzTmxibVJsY2lJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVgxOXZaMTkyWVd4MVpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsVkdGeVoyVjBVMlZzWldOMGIzSmZjbTkxZEdWQU1qTTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mWm05eWQyRnlaRjkyWVd4MVpRb2dJQ0FnWTJGc2JITjFZaUJmWDNWeWIzTmZiMmRmYzJWMGRYQUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlNUMU5mVDFKRFNGOUJVRkJmU1VRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSW1ScGMzQmhkR05vS0NsaWVYUmxXMTBpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTWdNekFnTHk4Z2JXVjBhRzlrSUNKblpYUlNiMnhsVkdGeVoyVjBVMlZzWldOMGIzSW9kV2x1ZERZMExHRmtaSEpsYzNNc2RXbHVkREkxTmlsaWVYUmxXelJkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQXhNQ0F3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmWDI5blgzTmxibVJsY2lJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVgxOXZaMTkyWVd4MVpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsVkdGeVoyVjBjMTl5YjNWMFpVQXlNam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCallXeHNjM1ZpSUY5ZmRYSnZjMTltYjNKM1lYSmtYM1poYkhWbENpQWdJQ0JqWVd4c2MzVmlJRjlmZFhKdmMxOXZaMTl6WlhSMWNBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdhVzUwWXlBMElDOHZJRlJOVUV4ZlZWSlBVMTlQVWtOSVgwRlFVRjlKUkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpWkdsemNHRjBZMmdvS1dKNWRHVmJYU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZVhSbFl5QXlPU0F2THlCdFpYUm9iMlFnSW1kbGRGSnZiR1ZVWVhKblpYUnpLSFZwYm5RMk5DeDFhVzUwTWpVMkxIVnBiblF5TlRZcGRXbHVkRGhiTXpKZFcxMGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURFd0lEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOWZiMmRmYzJWdVpHVnlJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmWDI5blgzWmhiSFZsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZKdmJHVlVZWEpuWlhSRGIzVnVkRjl5YjNWMFpVQXlNVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JqWVd4c2MzVmlJRjlmZFhKdmMxOW1iM0ozWVhKa1gzWmhiSFZsQ2lBZ0lDQmpZV3hzYzNWaUlGOWZkWEp2YzE5dloxOXpaWFIxY0FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2FXNTBZeUEwSUM4dklGUk5VRXhmVlZKUFUxOVBVa05JWDBGUVVGOUpSQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eklDOHZJRzFsZEdodlpDQWlaR2x6Y0dGMFkyZ29LV0o1ZEdWYlhTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmllWFJsWXlBeU9DQXZMeUJ0WlhSb2IyUWdJbWRsZEZKdmJHVlVZWEpuWlhSRGIzVnVkQ2gxYVc1ME5qUXBkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQXhNQ0F3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmWDI5blgzTmxibVJsY2lJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVgxOXZaMTkyWVd4MVpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsVkdGeVoyVjBYM0p2ZFhSbFFESXdPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lHTmhiR3h6ZFdJZ1gxOTFjbTl6WDJadmNuZGhjbVJmZG1Gc2RXVUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMjluWDNObGRIVndDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVazlUWDA5U1EwaGZRVkJRWDBsRUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKa2FYTndZWFJqYUNncFlubDBaVnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdKNWRHVmpJREkzSUM4dklHMWxkR2h2WkNBaVoyVjBVbTlzWlZSaGNtZGxkQ2gxYVc1ME5qUXNkV2x1ZERJMU5pbGhaR1J5WlhOeklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0F4TUNBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZlgyOW5YM05sYm1SbGNpSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlYMTl2WjE5MllXeDFaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJTYjJ4bGMwOW1RV1J0YVc1U2IyeGxYM0p2ZFhSbFFERTVPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5URXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZlptOXlkMkZ5WkY5MllXeDFaUW9nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mYjJkZmMyVjBkWEFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZTVDFOZlQxSkRTRjlCVUZCZlNVUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTXlBdkx5QnRaWFJvYjJRZ0ltUnBjM0JoZEdOb0tDbGllWFJsVzEwaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRZV1k1TlRBeU56QWdMeThnYldWMGFHOWtJQ0puWlhSU2IyeGxjMDltUVdSdGFXNVNiMnhsS0hWcGJuUTJOQ3hpYVdkMWFXNTBMR0pwWjNWcGJuUXBkV2x1ZERZMFcxMGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURFd0lEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOWZiMmRmYzJWdVpHVnlJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmWDI5blgzWmhiSFZsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZKdmJHVlBaa0ZrYldsdVVtOXNaVU52ZFc1MFgzSnZkWFJsUURFNE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHTmhiR3h6ZFdJZ1gxOTFjbTl6WDJadmNuZGhjbVJmZG1Gc2RXVUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMjluWDNObGRIVndDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVazlUWDA5U1EwaGZRVkJRWDBsRUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKa2FYTndZWFJqYUNncFlubDBaVnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdKNWRHVmpJREkySUM4dklHMWxkR2h2WkNBaVoyVjBVbTlzWlU5bVFXUnRhVzVTYjJ4bFEyOTFiblFvZFdsdWREWTBLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdNVEFnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDE5dloxOXpaVzVrWlhJaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lsOWZiMmRmZG1Gc2RXVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVbTlzWlU5bVFXUnRhVzVTYjJ4bFgzSnZkWFJsUURFM09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMlp2Y25kaGNtUmZkbUZzZFdVS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyOW5YM05sZEhWd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlVrOVRYMDlTUTBoZlFWQlFYMGxFQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6TWdMeThnYldWMGFHOWtJQ0prYVhOd1lYUmphQ2dwWW5sMFpWdGRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR0o1ZEdWaklESTFJQzh2SUcxbGRHaHZaQ0FpWjJWMFVtOXNaVTltUVdSdGFXNVNiMnhsS0hWcGJuUTJOQ3gxYVc1ME1qVTJLWFZwYm5RMk5DSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTVRBZ01Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVW05c1pVMWxiV0psY25OZmNtOTFkR1ZBTVRZNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZlptOXlkMkZ5WkY5MllXeDFaUW9nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mYjJkZmMyVjBkWEFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZTVDFOZlQxSkRTRjlCVUZCZlNVUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTXlBdkx5QnRaWFJvYjJRZ0ltUnBjM0JoZEdOb0tDbGllWFJsVzEwaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1lubDBaV01nTWpRZ0x5OGdiV1YwYUc5a0lDSm5aWFJTYjJ4bFRXVnRZbVZ5Y3loMWFXNTBOalFzZFdsdWRESTFOaXgxYVc1ME1qVTJLWFZwYm5RNFd6TXlYVnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQXhNQ0F3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmWDI5blgzTmxibVJsY2lJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVgxOXZaMTkyWVd4MVpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsVFdWdFltVnlRMjkxYm5SZmNtOTFkR1ZBTVRVNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mWm05eWQyRnlaRjkyWVd4MVpRb2dJQ0FnWTJGc2JITjFZaUJmWDNWeWIzTmZiMmRmYzJWMGRYQUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlNUMU5mVDFKRFNGOUJVRkJmU1VRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSW1ScGMzQmhkR05vS0NsaWVYUmxXMTBpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTWdNak1nTHk4Z2JXVjBhRzlrSUNKblpYUlNiMnhsVFdWdFltVnlRMjkxYm5Rb2RXbHVkRFkwS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTVRBZ01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVW05c1pVMWxiV0psY2w5eWIzVjBaVUF4TkRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JqWVd4c2MzVmlJRjlmZFhKdmMxOW1iM0ozWVhKa1gzWmhiSFZsQ2lBZ0lDQmpZV3hzYzNWaUlGOWZkWEp2YzE5dloxOXpaWFIxY0FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2FXNTBZeUEwSUM4dklGUk5VRXhmVlZKUFUxOVBVa05JWDBGUVVGOUpSQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eklDOHZJRzFsZEdodlpDQWlaR2x6Y0dGMFkyZ29LV0o1ZEdWYlhTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmllWFJsWXlBeU1pQXZMeUJ0WlhSb2IyUWdJbWRsZEZKdmJHVk5aVzFpWlhJb2RXbHVkRFkwTEhWcGJuUXlOVFlwWVdSa2NtVnpjeUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ01UQWdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMTl2WjE5elpXNWtaWElpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWalh6SWdMeThnSWw5ZmIyZGZkbUZzZFdVaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFFXUnRhVzVTYjJ4bGMxOXliM1YwWlVBeE16b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOVEV5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERVeE1nb2dJQ0FnWTJGc2JITjFZaUJmWDNWeWIzTmZabTl5ZDJGeVpGOTJZV3gxWlFvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZmIyZGZjMlYwZFhBS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHbHVkR01nTkNBdkx5QlVUVkJNWDFWU1QxTmZUMUpEU0Y5QlVGQmZTVVFLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk15QXZMeUJ0WlhSb2IyUWdJbVJwYzNCaGRHTm9LQ2xpZVhSbFcxMGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpFM016TmlOallnTHk4Z2JXVjBhRzlrSUNKblpYUkJaRzFwYmxKdmJHVnpLR0pwWjNWcGJuUXNZbWxuZFdsdWRDbDFhVzUwTmpSYlhTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTVRBZ01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwUVdSdGFXNVNiMnhsUTI5MWJuUmZjbTkxZEdWQU1USTZDaUFnSUNCallXeHNjM1ZpSUY5ZmRYSnZjMTltYjNKM1lYSmtYM1poYkhWbENpQWdJQ0JqWVd4c2MzVmlJRjlmZFhKdmMxOXZaMTl6WlhSMWNBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWXlBMElDOHZJRlJOVUV4ZlZWSlBVMTlQVWtOSVgwRlFVRjlKUkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpWkdsemNHRjBZMmdvS1dKNWRHVmJYU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZVhSbFl5QXlNU0F2THlCdFpYUm9iMlFnSW1kbGRFRmtiV2x1VW05c1pVTnZkVzUwS0NsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdNVEFnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDE5dloxOXpaVzVrWlhJaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lsOWZiMmRmZG1Gc2RXVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBRV1J0YVc1U2IyeGxYM0p2ZFhSbFFERXhPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnWTJGc2JITjFZaUJmWDNWeWIzTmZabTl5ZDJGeVpGOTJZV3gxWlFvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZmIyZGZjMlYwZFhBS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHbHVkR01nTkNBdkx5QlVUVkJNWDFWU1QxTmZUMUpEU0Y5QlVGQmZTVVFLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk15QXZMeUJ0WlhSb2IyUWdJbVJwYzNCaGRHTm9LQ2xpZVhSbFcxMGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdZbmwwWldNZ01qQWdMeThnYldWMGFHOWtJQ0puWlhSQlpHMXBibEp2YkdVb2RXbHVkREkxTmlsMWFXNTBOalFpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTVRBZ01Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVW05c1pYTmZjbTkxZEdWQU1UQTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMlp2Y25kaGNtUmZkbUZzZFdVS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyOW5YM05sZEhWd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlVrOVRYMDlTUTBoZlFWQlFYMGxFQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6TWdMeThnYldWMGFHOWtJQ0prYVhOd1lYUmphQ2dwWW5sMFpWdGRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNNE1Ua3pNMlF6SUM4dklHMWxkR2h2WkNBaVoyVjBVbTlzWlhNb1ltbG5kV2x1ZEN4aWFXZDFhVzUwS1hWcGJuUTJORnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQXhNQ0F3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmWDI5blgzTmxibVJsY2lJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVgxOXZaMTkyWVd4MVpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsUTI5MWJuUmZjbTkxZEdWQU9Ub0tJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMlp2Y25kaGNtUmZkbUZzZFdVS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyOW5YM05sZEhWd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlVrOVRYMDlTUTBoZlFWQlFYMGxFQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6TWdMeThnYldWMGFHOWtJQ0prYVhOd1lYUmphQ2dwWW5sMFpWdGRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR0o1ZEdWaklERTVJQzh2SUcxbGRHaHZaQ0FpWjJWMFVtOXNaVU52ZFc1MEtDbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTVRBZ01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOXZaMTl6Wlc1a1pYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVW05c1pWOXliM1YwWlVBNE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZlptOXlkMkZ5WkY5MllXeDFaUW9nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mYjJkZmMyVjBkWEFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZTVDFOZlQxSkRTRjlCVUZCZlNVUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTXlBdkx5QnRaWFJvYjJRZ0ltUnBjM0JoZEdOb0tDbGllWFJsVzEwaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1lubDBaV01nTVRnZ0x5OGdiV1YwYUc5a0lDSm5aWFJTYjJ4bEtIVnBiblF5TlRZcGRXbHVkRFkwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURFd0lEQUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOWZiMmRmYzJWdVpHVnlJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmWDI5blgzWmhiSFZsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMTlmY0c5emRFbHVhWFJmY205MWRHVkFOem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklGOWZjRzl6ZEVsdWFYUWdZV3h5WldGa2VTQmpZV3hzWldRS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSmZkR0Z5WjJWMGN5SUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsOXliMnhsY3lJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaVgzTmphR1ZrZFd4bGN5SUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsOXliMnhsVFdWdFltVnlVMlYwSWdvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0J3YjNBS0lDQWdJSEIxYzJoaWVYUmxjeUFpWDNKdmJHVkJaRzFwYmxSdlVtOXNaVk5sZENJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnY0c5d0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWw5eWIyeGxWRzlVWVhKblpYUlRaWFFpQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pmZEdGeVoyVjBWRzlUWld4bFkzUnZjbFJ2VW05c1pTSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsOXliMnhsVkc5VVlYSm5aWFJVYjFObGJHVmpkRzl5VTJWMElnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSmZaWGhsWTNWMGFXOXVTV1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJRDA5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXTmpaWE56VFdGdVlXZGxja2x1ZG1Gc2FXUkpibWwwYVdGc1FXUnRhVzRLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p0WlcxaVpYSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpFS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJREUySUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURBZ05nb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEUUtJQ0FnSUdSMWNBb2dJQ0FnSVFvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JpYm5vZ2JXRnBibDlsYkhObFgySnZaSGxBTVRFMENpQWdJQ0JqWVd4c2MzVmlJRlJwYldVdWRHbHRaWE4wWVcxd0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05TQXZMeUF5T0RFME56UTVOelkzTVRBMk5UVUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUZScGJXVXVkRzlFWld4aGVRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSEIxYzJocGJuUWdNVFFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1ltbDBiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmxlSFJ5WVdOMElESWdOZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWpFS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVRVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnYzJWMFltbDBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01qUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc1WkRWaU9HUXlOeUF2THlCdFpYUm9iMlFnSWxKdmJHVkhjbUZ1ZEdWa0tIVnBiblEyTkN4MWFXNTBPRnN6TWwwc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c0tTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCa2FXY2dNZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpJS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJRa2tnWW05dmJDQjJZV3hwWkdGMGFXOXVDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltNTZJRzFoYVc1ZlpXeHpaVjlpYjJSNVFERXlNUW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlRFZtTnpJMlpqWmpOalUwWkRZMU5tUTJNalkxTnpJMU16WTFOelJoWmpVMU56Qm1OV0V4T0RFd1lqZGhaamM0WTJGbU5HSmpOekJoTmpZd1pqQmtaalV4WlRReVltRm1PVEZrTkdSbE5XSXlNekk0WkdVd1pUZ3paR1pqQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QTFPU0F2THlBd2VEQXdNREl3TURBME1EQXdOakF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBeU1Rb2dJQ0FnWTJGc2JITjFZaUJGYm5WdFpYSmhZbXhsVTJWMExtRmtaQW9nSUNBZ2NHOXdDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGcxWmpjeU5tWTJZelkxTkdRMk5UWmtOakkyTlRjeU5UTTJOVGMwWVdZMU5UY3daalZoTVRneE1HSTNZV1kzT0dOaFpqUmlZemN3WVRZMk1HWXdaR1kxTVdVME1tSmhaamt4WkRSa1pUVmlNak15T0dSbE1HVTRNMlJtWXdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE5XWTNNalptTm1NMk5UUmtOalUyWkRZeU5qVTNNalV6TmpVM05HRm1OVFUzTUdZMVlURTRNVEJpTjJGbU56aGpZV1kwWW1NM01HRTJOakJtTUdSbU5URmxOREppWVdZNU1XUTBaR1UxWWpJek1qaGtaVEJsT0ROa1ptTUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1qSTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyVnNjMlZmWW05a2VVQXhNakU2Q2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TldZM01qWm1ObU0yTlRSa05qVTJaRFl5TmpVM01qVXpOalUzTkdGbU5UVTNNR1kxWVRFNE1UQmlOMkZtTnpoallXWTBZbU0zTUdFMk5qQm1NR1JtTlRGbE5ESmlZV1k1TVdRMFpHVTFZakl6TWpoa1pUQmxPRE5rWm1NS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFU1SUM4dklEQjRNREF3TWpBd01EUXdNREEyTURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklESXhDaUFnSUNCallXeHNjM1ZpSUVWdWRXMWxjbUZpYkdWVFpYUXVjbVZ0YjNabENpQWdJQ0J3YjNBS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VEVm1OekkyWmpaak5qVTBaRFkxTm1RMk1qWTFOekkxTXpZMU56UmhaalUxTnpCbU5XRXhPREV3WWpkaFpqYzRZMkZtTkdKak56QmhOall3WmpCa1pqVXhaVFF5WW1GbU9URmtOR1JsTldJeU16STRaR1V3WlRnelpHWmpDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGcxWmpjeU5tWTJZelkxTkdRMk5UWmtOakkyTlRjeU5UTTJOVGMwWVdZMU5UY3daalZoTVRneE1HSTNZV1kzT0dOaFpqUmlZemN3WVRZMk1HWXdaR1kxTVdVME1tSmhaamt4WkRSa1pUVmlNak15T0dSbE1HVTRNMlJtWXdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USXlDZ3B0WVdsdVgyVnNjMlZmWW05a2VVQXhNVFE2Q2lBZ0lDQmthV2NnTVRrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTmlBeE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG5kcGRHaFZjR1JoZEdVS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ05pQXhOQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuZHBkR2hWY0dSaGRHVUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEUxQ2dwdFlXbHVYMTlmWkdWc1pXZGhkR1ZmZFhCa1lYUmxYM0p2ZFhSbFFEUTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJRjl3ZFhsaFgyeHBZaTVoY21NMExsOXlaV05oYkdOMWJHRjBaVjlvWldGa1gyWnZjbDlsYkdWdFpXNTBjMTkzYVhSb1gySjVkR1ZmYkdWdVozUm9YMmhsWVdRb1lYSnlZWGxmYUdWaFpGOWhibVJmZEdGcGJEb2dZbmwwWlhNc0lHeGxibWQwYURvZ2RXbHVkRFkwTENCemRHRnlkRjloZEY5cGJtUmxlRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LWDNKbFkyRnNZM1ZzWVhSbFgyaGxZV1JmWm05eVgyVnNaVzFsYm5SelgzZHBkR2hmWW5sMFpWOXNaVzVuZEdoZmFHVmhaRG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDb0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjMlZzWldOMENpQWdJQ0J6ZDJGd0NncGZjbVZqWVd4amRXeGhkR1ZmYUdWaFpGOW1iM0pmWld4bGJXVnVkSE5mZDJsMGFGOWllWFJsWDJ4bGJtZDBhRjlvWldGa1gyWnZjbDlvWldGa1pYSkFNVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnUEFvZ0lDQWdZbm9nWDNKbFkyRnNZM1ZzWVhSbFgyaGxZV1JmWm05eVgyVnNaVzFsYm5SelgzZHBkR2hmWW5sMFpWOXNaVzVuZEdoZmFHVmhaRjloWm5SbGNsOW1iM0pBTkFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SUMwekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWWlCZmNtVmpZV3hqZFd4aGRHVmZhR1ZoWkY5bWIzSmZaV3hsYldWdWRITmZkMmwwYUY5aWVYUmxYMnhsYm1kMGFGOW9aV0ZrWDJadmNsOW9aV0ZrWlhKQU1Rb0tYM0psWTJGc1kzVnNZWFJsWDJobFlXUmZabTl5WDJWc1pXMWxiblJ6WDNkcGRHaGZZbmwwWlY5c1pXNW5kR2hmYUdWaFpGOWhablJsY2w5bWIzSkFORG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVCWkdSeVpYTnpMbVoxYm1OMGFXOXVRMkZzYkZkcGRHaFdZV3gxWlNoMFlYSm5aWFE2SUdKNWRHVnpMQ0JrWVhSaE9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LUVdSa2NtVnpjeTVtZFc1amRHbHZia05oYkd4WGFYUm9WbUZzZFdVNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUpoYkdGdVkyVUtJQ0FnSUhCdmNBb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpUEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVjM1ZtWm1samFXVnVkRUpoYkdGdVkyVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdURzkzVEdWMlpXeERZV3hzTG1OaGJHeE9iMUpsZEhWeWJnb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJjSEJ5YjNaaGJGQnliMmR5WVcwS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbm9nUVdSa2NtVnpjeTVtZFc1amRHbHZia05oYkd4WGFYUm9WbUZzZFdWZlpXeHpaVjlpYjJSNVFEWUtJQ0FnSUdOaGJHeHpkV0lnVEc5M1RHVjJaV3hEWVd4c0xuSmxkSFZ5YmtSaGRHRlRhWHBsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHSStDaUFnSUNCaWJub2dRV1JrY21WemN5NW1kVzVqZEdsdmJrTmhiR3hYYVhSb1ZtRnNkV1ZmYVdaZlltOWtlVUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUdJK0NpQWdJQ0JpZWlCQlpHUnlaWE56TG1aMWJtTjBhVzl1UTJGc2JGZHBkR2hXWVd4MVpWOWxiSE5sWDJKdlpIbEFOZ29LUVdSa2NtVnpjeTVtZFc1amRHbHZia05oYkd4WGFYUm9WbUZzZFdWZmFXWmZZbTlrZVVBMU9nb2dJQ0FnWTJGc2JITjFZaUJNYjNkTVpYWmxiRU5oYkd3dWNtVjBkWEp1UkdGMFlRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDa0ZrWkhKbGMzTXVablZ1WTNScGIyNURZV3hzVjJsMGFGWmhiSFZsWDJWc2MyVmZZbTlrZVVBMk9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaR1J5WlhOelJXMXdkSGxEYjJSbENpQWdJQ0JqWVd4c2MzVmlJRXh2ZDB4bGRtVnNRMkZzYkM1eVpYUjFjbTVFWVhSaFUybDZaUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaVBnb2dJQ0FnWVhOelpYSjBJQzh2SUVaaGFXeGxaRU5oYkd3S0lDQWdJR0lnVEc5M1RHVjJaV3hEWVd4c0xtSjFZbUpzWlZKbGRtVnlkQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyRmtaQ2h6WlhRNklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJOQ3dnWW5sMFpYTTZDa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyRmtaRG9LSUNBZ0lIQnliM1J2SURJZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdSVzUxYldWeVlXSnNaVk5sZEM1ZlkyOXVkR0ZwYm5NS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0lDQWdJR0p1ZWlCRmJuVnRaWEpoWW14bFUyVjBMbDloWkdSZlpXeHpaVjlpYjJSNVFEWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUMwS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J5WlhCc1lXTmxNaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbDl3YjNOcGRHbHZibk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J5WlhSemRXSUtDa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyRmtaRjlsYkhObFgySnZaSGxBTmpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtWdWRXMWxjbUZpYkdWVFpYUXVYM0psYlc5MlpTaHpaWFE2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dZbmwwWlhNNkNrVnVkVzFsY21GaWJHVlRaWFF1WDNKbGJXOTJaVG9LSUNBZ0lIQnliM1J2SURJZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z01nb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaVgzQnZjMmwwYVc5dWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nUlc1MWJXVnlZV0pzWlZObGRDNWZjbVZ0YjNabFgyVnNjMlZmWW05a2VVQTRDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1ERUtJQ0FnSUdJK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUhWdVpHVnlabXh2ZHdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01Rb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURFS0lDQWdJR0krUFFvZ0lDQWdZWE56WlhKMElDOHZJSFZ1WkdWeVpteHZkd29nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TVFvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lpRTlDaUFnSUNCaWVpQkZiblZ0WlhKaFlteGxVMlYwTGw5eVpXMXZkbVZmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnlaWEJzWVdObE15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQXRDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2NtVndiR0ZqWlRJZ01nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBdE1nb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlYM0J2YzJsMGFXOXVjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUEyQ2lBZ0lDQmliM2hmY0hWMENncEZiblZ0WlhKaFlteGxVMlYwTGw5eVpXMXZkbVZmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdScFp5QTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ0xRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhKbGNHeGhZMlV5SURJS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUExQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2tWdWRXMWxjbUZpYkdWVFpYUXVYM0psYlc5MlpWOWxiSE5sWDJKdlpIbEFPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwTGw5amIyNTBZV2x1Y3loelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE02Q2tWdWRXMWxjbUZpYkdWVFpYUXVYMk52Ym5SaGFXNXpPZ29nSUNBZ2NISnZkRzhnTWlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0lsOXdiM05wZEdsdmJuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwTG1Ga1pDZ3lLVjh4S0hObGREb2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwTENCaWVYUmxjeXdnWW5sMFpYTTZDa1Z1ZFcxbGNtRmliR1ZUWlhRdVlXUmtPZ29nSUNBZ2NISnZkRzhnTWlBekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpSmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpZV3hzYzNWaUlFVnVkVzFsY21GaWJHVlRaWFF1WDJGa1pBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1IxY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVJXNTFiV1Z5WVdKc1pWTmxkQzV5WlcxdmRtVW9NaWxmTVNoelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE1zSUdKNWRHVnpPZ3BGYm5WdFpYSmhZbXhsVTJWMExuSmxiVzkyWlRvS0lDQWdJSEJ5YjNSdklESWdNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lpWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTJGc2JITjFZaUJGYm5WdFpYSmhZbXhsVTJWMExsOXlaVzF2ZG1VS0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmtkWEFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtoaGMyaGxjeTVsWm1acFkybGxiblJMWldOallXc3lOVFlvWVRvZ1lubDBaWE1zSUdJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1NHRnphR1Z6TG1WbVptbGphV1Z1ZEV0bFkyTmhhekkxTmpvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NtVndiR0ZqWlRJZ016SUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURZMENpQWdJQ0JyWldOallXc3lOVFlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSE4zWVhBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMa3h2ZDB4bGRtVnNRMkZzYkM1allXeHNUbTlTWlhSMWNtNG9NeWtvZEdGeVoyVjBPaUJpZVhSbGN5d2dkbUZzZFdVNklHSjVkR1Z6TENCa1lYUmhPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BNYjNkTVpYWmxiRU5oYkd3dVkyRnNiRTV2VW1WMGRYSnVPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0JzYjJGa0lEQUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneU1Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVRHOTNUR1YyWld4RFlXeHNMbkpsZEhWeWJrUmhkR0ZUYVhwbEtDa2dMVDRnWW5sMFpYTTZDa3h2ZDB4bGRtVnNRMkZzYkM1eVpYUjFjbTVFWVhSaFUybDZaVG9LSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNU1iM2RNWlhabGJFTmhiR3d1Y21WMGRYSnVSR0YwWVNncElDMCtJR0o1ZEdWek9ncE1iM2RNWlhabGJFTmhiR3d1Y21WMGRYSnVSR0YwWVRvS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREl3Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNaUEyTkFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VURzkzVEdWMlpXeERZV3hzTG1KMVltSnNaVkpsZG1WeWRDZ3dLU2dwSUMwK0lIWnZhV1E2Q2t4dmQweGxkbVZzUTJGc2JDNWlkV0ppYkdWU1pYWmxjblE2Q2lBZ0lDQmxjbklnTHk4Z2NtVjJaWEowQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNXpiMnd1VFdGMGFDNTBaWEp1WVhKNUtHTnZibVJwZEdsdmJqb2dkV2x1ZERZMExDQmhPaUJpZVhSbGN5d2dZam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BOWVhSb0xuUmxjbTVoY25rNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaVhnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WRFlYTjBMblJ2VldsdWRBb2dJQ0FnWWlvS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0plQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1TllYUm9MbTFoZUNoaE9pQmllWFJsY3l3Z1lqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncE5ZWFJvTG0xaGVEb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSStDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJOWVhSb0xuUmxjbTVoY25rS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xsTmhabVZEWVhOMExuUnZWV2x1ZERRNEtIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwVFlXWmxRMkZ6ZEM1MGIxVnBiblEwT0RvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1abVptWm1abVptWm1abVlLSUNBZ0lHSStDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVTJGbVpVTmhjM1JQZG1WeVpteHZkMlZrVldsdWRFUnZkMjVqWVhOMENpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFVnTHk4Z01qZ3hORGMwT1RjMk56RXdOalUxQ2lBZ0lDQW1DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVUWVdabFEyRnpkQzUwYjFWcGJuUW9Zam9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LVTJGbVpVTmhjM1F1ZEc5VmFXNTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JzYjJGa0lEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnSVFvZ0lDQWdJUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCemQyRndDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1VWFXMWxMblJwYldWemRHRnRjQ2dwSUMwK0lIVnBiblEyTkRvS1ZHbHRaUzUwYVcxbGMzUmhiWEE2Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZEWVhOMExuUnZWV2x1ZERRNENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNVVhVzFsTG5SdlJHVnNZWGtvWkhWeVlYUnBiMjQ2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q2xScGJXVXVkRzlFWld4aGVUb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1VWFXMWxMbDluWlhSR2RXeHNRWFFvYzJWc1pqb2dZbmwwWlhNc0lIUnBiV1Z3YjJsdWREb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncFVhVzFsTGw5blpYUkdkV3hzUVhRNkNpQWdJQ0J3Y205MGJ5QXlJRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUZScGJXVXVkVzV3WVdOckNpQWdJQ0J3YjNCdUlETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuVnVjR0ZqYXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqYjNabGNpQXpDaUFnSUNCd2IzQnVJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCVWFXMWxMblZ1Y0dGamF3b2dJQ0FnY0c5d0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuVnVjR0ZqYXdvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUR3OUNpQWdJQ0JpZWlCVWFXMWxMbDluWlhSR2RXeHNRWFJmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1ZHbHRaUzVmWjJWMFJuVnNiRUYwWDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0J5WlhSemRXSUtDbFJwYldVdVgyZGxkRVoxYkd4QmRGOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1lpQlVhVzFsTGw5blpYUkdkV3hzUVhSZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNXpiMnd1VkdsdFpTNW5aWFJHZFd4c0tITmxiR1k2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BVYVcxbExtZGxkRVoxYkd3NkNpQWdJQ0J3Y205MGJ5QXhJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzUwYVcxbGMzUmhiWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVWFXMWxMbDluWlhSR2RXeHNRWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGxScGJXVXVaMlYwS0hObGJHWTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbFJwYldVdVoyVjBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1blpYUkdkV3hzQ2lBZ0lDQndiM0J1SURJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xsUnBiV1V1ZDJsMGFGVndaR0YwWlNoelpXeG1PaUJpZVhSbGN5d2dibVYzVm1Gc2RXVTZJSFZwYm5RMk5Dd2diV2x1VTJWMFltRmphem9nZFdsdWREWTBLU0F0UGlCaWVYUmxjeXdnZFdsdWREWTBPZ3BVYVcxbExuZHBkR2hWY0dSaGRHVTZDaUFnSUNCd2NtOTBieUF6SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG1kbGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJRDRLSUNBZ0lHSjZJRlJwYldVdWQybDBhRlZ3WkdGMFpWOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURZZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvS1ZHbHRaUzUzYVhSb1ZYQmtZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0RJS0lDQWdJR05oYkd4emRXSWdUV0YwYUM1dFlYZ0tJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdUV0YwYUM1dFlYZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZeUEySUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNZS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1MGFXMWxjM1JoYlhBS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUExSUM4dklESTRNVFEzTkRrM05qY3hNRFkxTlFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1d1lXTnJDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEpsZEhOMVlnb0tWR2x0WlM1M2FYUm9WWEJrWVhSbFgyVnNjMlZmWW05a2VVQXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1ZHbHRaUzUzYVhSb1ZYQmtZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMbFJwYldVdWRXNXdZV05yS0hObGJHWTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncFVhVzFsTG5WdWNHRmphem9LSUNBZ0lIQnliM1J2SURFZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFlnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBMk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFlnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBMk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWXlBMUlDOHZJREk0TVRRM05EazNOamN4TURZMU5Rb2dJQ0FnSmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VWR2x0WlM1d1lXTnJLSFpoYkhWbFFtVm1iM0psT2lCMWFXNTBOalFzSUhaaGJIVmxRV1owWlhJNklIVnBiblEyTkN3Z1pXWm1aV04wT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwVWFXMWxMbkJoWTJzNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTmpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTmpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSjhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGIySUtJQ0FnSUdKOENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1allXNURZV3hzS0dOaGJHeGxjam9nWW5sMFpYTXNJSFJoY21kbGREb2dZbmwwWlhNc0lITmxiR1ZqZEc5eU9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZMExDQjFhVzUwTmpRNkNtTmhia05oYkd3NkNpQWdJQ0J3Y205MGJ5QXpJRElLSUNBZ0lHTmhiR3h6ZFdJZ1gxOTFjbTl6WDJadmNuZGhjbVJmZG1Gc2RXVUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMjluWDNObGRIVndDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVazlUWDA5U1EwaGZRVkJRWDBsRUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKa2FYTndZWFJqYUNncFlubDBaVnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdKNWRHVmpJRE0wSUM4dklHMWxkR2h2WkNBaVkyRnVRMkZzYkNoaFpHUnlaWE56TEdGa1pISmxjM01zWW5sMFpWczBYU2tvWW05dmJDeDFhVzUwTmpRcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0F4TUNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ2NIVnphR2x1ZENBeE1Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOWZiMmRmYzJWdVpHVnlJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmWDI5blgzWmhiSFZsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzVsZUhCcGNtRjBhVzl1S0NrZ0xUNGdkV2x1ZERZME9ncGxlSEJwY21GMGFXOXVPZ29nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mWm05eWQyRnlaRjkyWVd4MVpRb2dJQ0FnWTJGc2JITjFZaUJmWDNWeWIzTmZiMmRmYzJWMGRYQUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlNUMU5mVDFKRFNGOUJVRkJmU1VRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSW1ScGMzQmhkR05vS0NsaWVYUmxXMTBpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTWdNelVnTHk4Z2JXVjBhRzlrSUNKbGVIQnBjbUYwYVc5dUtDbDFhVzUwTmpRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0F4TUNBd0NpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZlgyOW5YM05sYm1SbGNpSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlYMTl2WjE5MllXeDFaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNXpiMnd1UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVhWE5VWVhKblpYUkRiRzl6WldRb2RHRnlaMlYwT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwcGMxUmhjbWRsZEVOc2IzTmxaRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWTJGc2JITjFZaUJmWDNWeWIzTmZabTl5ZDJGeVpGOTJZV3gxWlFvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZmIyZGZjMlYwZFhBS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHbHVkR01nTkNBdkx5QlVUVkJNWDFWU1QxTmZUMUpEU0Y5QlVGQmZTVVFLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk15QXZMeUJ0WlhSb2IyUWdJbVJwYzNCaGRHTm9LQ2xpZVhSbFcxMGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdZbmwwWldNZ016Y2dMeThnYldWMGFHOWtJQ0pwYzFSaGNtZGxkRU5zYjNObFpDaGhaR1J5WlhOektXSnZiMndpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTVRBZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmWDI5blgzTmxibVJsY2lJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVgxOXZaMTkyWVd4MVpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdVoyVjBWR0Z5WjJWMFJuVnVZM1JwYjI1U2IyeGxLSFJoY21kbGREb2dZbmwwWlhNc0lITmxiR1ZqZEc5eU9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncG5aWFJVWVhKblpYUkdkVzVqZEdsdmJsSnZiR1U2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMlp2Y25kaGNtUmZkbUZzZFdVS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyOW5YM05sZEhWd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlVrOVRYMDlTUTBoZlFWQlFYMGxFQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6TWdMeThnYldWMGFHOWtJQ0prYVhOd1lYUmphQ2dwWW5sMFpWdGRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR0o1ZEdWaklETTRJQzh2SUcxbGRHaHZaQ0FpWjJWMFZHRnlaMlYwUm5WdVkzUnBiMjVTYjJ4bEtHRmtaSEpsYzNNc1lubDBaVnMwWFNsMWFXNTBOalFpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElERXdJREFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDlmYjJkZmMyVnVaR1Z5SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKZlgyOW5YM1poYkhWbElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1blpYUlVZWEpuWlhSQlpHMXBia1JsYkdGNUtIUmhjbWRsZERvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1oyVjBWR0Z5WjJWMFFXUnRhVzVFWld4aGVUb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdZMkZzYkhOMVlpQmZYM1Z5YjNOZlptOXlkMkZ5WkY5MllXeDFaUW9nSUNBZ1kyRnNiSE4xWWlCZlgzVnliM05mYjJkZmMyVjBkWEFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZTVDFOZlQxSkRTRjlCVUZCZlNVUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTXlBdkx5QnRaWFJvYjJRZ0ltUnBjM0JoZEdOb0tDbGllWFJsVzEwaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1lubDBaV01nTXprZ0x5OGdiV1YwYUc5a0lDSm5aWFJVWVhKblpYUkJaRzFwYmtSbGJHRjVLR0ZrWkhKbGMzTXBkV2x1ZERZMElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElERXdJREFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDlmYjJkZmMyVnVaR1Z5SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKZlgyOW5YM1poYkhWbElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1blpYUlNiMnhsUVdSdGFXNG9jbTlzWlVsa09pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0taMlYwVW05c1pVRmtiV2x1T2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCallXeHNjM1ZpSUY5ZmRYSnZjMTltYjNKM1lYSmtYM1poYkhWbENpQWdJQ0JqWVd4c2MzVmlJRjlmZFhKdmMxOXZaMTl6WlhSMWNBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdhVzUwWXlBMElDOHZJRlJOVUV4ZlZWSlBVMTlQVWtOSVgwRlFVRjlKUkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpWkdsemNHRjBZMmdvS1dKNWRHVmJYU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZVhSbFl5QTBNQ0F2THlCdFpYUm9iMlFnSW1kbGRGSnZiR1ZCWkcxcGJpaDFhVzUwTmpRcGRXbHVkRFkwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURFd0lEQUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOWZiMmRmYzJWdVpHVnlJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmWDI5blgzWmhiSFZsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzVuWlhSU2IyeGxSM1ZoY21ScFlXNG9jbTlzWlVsa09pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0taMlYwVW05c1pVZDFZWEprYVdGdU9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQmpZV3hzYzNWaUlGOWZkWEp2YzE5bWIzSjNZWEprWDNaaGJIVmxDaUFnSUNCallXeHNjM1ZpSUY5ZmRYSnZjMTl2WjE5elpYUjFjQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYVc1MFl5QTBJQzh2SUZSTlVFeGZWVkpQVTE5UFVrTklYMEZRVUY5SlJBb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh6SUM4dklHMWxkR2h2WkNBaVpHbHpjR0YwWTJnb0tXSjVkR1ZiWFNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCaWVYUmxZeUEwTVNBdkx5QnRaWFJvYjJRZ0ltZGxkRkp2YkdWSGRXRnlaR2xoYmloMWFXNTBOalFwZFdsdWREWTBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJREV3SURBS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5ZmIyZGZjMlZ1WkdWeUlnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmZYMjluWDNaaGJIVmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNW9ZWE5TYjJ4bEtISnZiR1ZKWkRvZ2RXbHVkRFkwTENCaFkyTnZkVzUwT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwTENCMWFXNTBOalE2Q21oaGMxSnZiR1U2Q2lBZ0lDQndjbTkwYnlBeUlESUtJQ0FnSUdOaGJHeHpkV0lnWDE5MWNtOXpYMlp2Y25kaGNtUmZkbUZzZFdVS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyOW5YM05sZEhWd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlVrOVRYMDlTUTBoZlFWQlFYMGxFQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6TWdMeThnYldWMGFHOWtJQ0prYVhOd1lYUmphQ2dwWW5sMFpWdGRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR0o1ZEdWaklEUTBJQzh2SUcxbGRHaHZaQ0FpYUdGelVtOXNaU2gxYVc1ME5qUXNZV1JrY21WemN5a29ZbTl2YkN4MWFXNTBOalFwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQXhNQ0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnY0hWemFHbHVkQ0F4TVFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5ZmIyZGZjMlZ1WkdWeUlnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmZYMjluWDNaaGJIVmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNW5aWFJUWTJobFpIVnNaU2hwWkRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1oyVjBVMk5vWldSMWJHVTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR05oYkd4emRXSWdYMTkxY205elgyWnZjbmRoY21SZmRtRnNkV1VLSUNBZ0lHTmhiR3h6ZFdJZ1gxOTFjbTl6WDI5blgzTmxkSFZ3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCcGJuUmpJRFFnTHk4Z1ZFMVFURjlWVWs5VFgwOVNRMGhmUVZCUVgwbEVDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdiV1YwYUc5a0lDSmthWE53WVhSamFDZ3BZbmwwWlZ0ZElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHSjVkR1ZqSURVMUlDOHZJRzFsZEdodlpDQWlaMlYwVTJOb1pXUjFiR1VvWW5sMFpWc3pNbDBwZFdsdWREWTBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJREV3SURBS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5ZmIyZGZjMlZ1WkdWeUlnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmZYMjluWDNaaGJIVmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNWZZMjl1YzNWdFpWTmphR1ZrZFd4bFpFOXdLRzl3WlhKaGRHbHZia2xrT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwZlkyOXVjM1Z0WlZOamFHVmtkV3hsWkU5d09nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01URWdMeThnSWw5elkyaGxaSFZzWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURZS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQWhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpUV0Z1WVdkbGNrNXZkRk5qYUdWa2RXeGxaQW9nSUNBZ1kyRnNiSE4xWWlCVWFXMWxMblJwYldWemRHRnRjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVRtOTBVbVZoWkhrS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdYMmx6Ulhod2FYSmxaQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjMDFoYm1GblpYSkZlSEJwY21Wa0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTmlBMENpQWdJQ0JpZVhSbFl5QTFPQ0F2THlBd2VEQXdNREF3TURBd01EQXdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0ZrTTJRME1HUmtJQzh2SUcxbGRHaHZaQ0FpVDNCbGNtRjBhVzl1UlhobFkzVjBaV1FvZFdsdWREaGJNekpkTEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YUdGemFFOXdaWEpoZEdsdmJpaGpZV3hzWlhJNklHSjVkR1Z6TENCMFlYSm5aWFE2SUdKNWRHVnpMQ0JrWVhSaE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtaGhjMmhQY0dWeVlYUnBiMjQ2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQm9ZWE5vVDNCbGNtRjBhVzl1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtaGhjMmhQY0dWeVlYUnBiMjVmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURZd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCd2RYTm9hVzUwSURNeENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdsdWRDQXpNUW9nSUNBZ0t3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0F2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3RsWTJOaGF6STFOZ29nSUNBZ2NtVjBjM1ZpQ2dwb1lYTm9UM0JsY21GMGFXOXVYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdoaGMyaFBjR1Z5WVhScGIyNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1WDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1ektHUmhkR0U2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5NNkNpQWdJQ0J3Y205MGJ5QXhJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNVGNnTHk4Z01IZ3dOQW9nSUNBZ1lqd0tJQ0FnSUdKNklGOW5aWFJCWkcxcGJsSmxjM1J5YVdOMGFXOXVjMTloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjbVYwYzNWaUNncGZaMlYwUVdSdGFXNVNaWE4wY21samRHbHZibk5mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemRXSnpkSEpwYm1jZ01DQTBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EVXpOVFV4WWpnS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1elgybG1YMkp2WkhsQU53b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNd1kyRmxNVGczQ2lBZ0lDQTlQUW9nSUNBZ1ltNTZJRjluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1YzE5cFpsOWliMlI1UURjS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTWprMk1qazFNZ29nSUNBZ1BUMEtJQ0FnSUdKdWVpQmZaMlYwUVdSdGFXNVNaWE4wY21samRHbHZibk5mYVdaZlltOWtlVUEzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZVFkwWkRrMVkyVUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1gyZGxkRUZrYldsdVVtVnpkSEpwWTNScGIyNXpYMmxtWDJKdlpIbEFOd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHUXlNbUkxT1RnNUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1elgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvS1gyZGxkRUZrYldsdVVtVnpkSEpwWTNScGIyNXpYMmxtWDJKdlpIbEFOem9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxkSE4xWWdvS1gyZGxkRUZrYldsdVVtVnpkSEpwWTNScGIyNXpYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE9HWm1NVGd6WXdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5OZmFXWmZZbTlrZVVBeE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMk4ySmtNemsxQ2lBZ0lDQTlQUW9nSUNBZ1ltNTZJRjluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1YzE5cFpsOWliMlI1UURFeENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURoa05qRXlNbVFLSUNBZ0lEMDlDaUFnSUNCaWVpQmZaMlYwUVdSdGFXNVNaWE4wY21samRHbHZibk5mWVdaMFpYSmZhV1pmWld4elpVQXhNZ29LWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1elgybG1YMkp2WkhsQU1URTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOMVluTjBjbWx1WnlBMElETTJDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFZHRnlaMlYwUVdSdGFXNUVaV3hoZVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NtVjBjM1ZpQ2dwZloyVjBRV1J0YVc1U1pYTjBjbWxqZEdsdmJuTmZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneU5XTTBOekZoTUFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5OZmFXWmZZbTlrZVVBeE5Bb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdJM1pESmlNVFl5Q2lBZ0lDQTlQUW9nSUNBZ1lub2dYMmRsZEVGa2JXbHVVbVZ6ZEhKcFkzUnBiMjV6WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLQ2w5blpYUkJaRzFwYmxKbGMzUnlhV04wYVc5dWMxOXBabDlpYjJSNVFERTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemRXSnpkSEpwYm1jZ05DQXpOZ29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWTJGc2JITjFZaUJuWlhSU2IyeGxRV1J0YVc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J5WlhSemRXSUtDbDluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1YzE5aFpuUmxjbDlwWmw5bGJITmxRREUxT2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRlJoY21kbGRFWjFibU4wYVc5dVVtOXNaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbDlqWVc1RFlXeHNSWGgwWlc1a1pXUW9ZMkZzYkdWeU9pQmllWFJsY3l3Z2RHRnlaMlYwT2lCaWVYUmxjeXdnWkdGMFlUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncGZZMkZ1UTJGc2JFVjRkR1Z1WkdWa09nb2dJQ0FnY0hKdmRHOGdNeUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHUjFjRzRnTXdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJmWTJGdVEyRnNiRVY0ZEdWdVpHVmtYMmxtWDJKdlpIbEFNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJRDA5Q2lBZ0lDQmllaUJmWTJGdVEyRnNiRVY0ZEdWdVpHVmtYMlZzYzJWZlltOWtlVUF6Q2dwZlkyRnVRMkZzYkVWNGRHVnVaR1ZrWDJsbVgySnZaSGxBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUF3ZURBMENpQWdJQ0JpUEFvZ0lDQWdZbm9nWDJOaGJrTmhiR3hGZUhSbGJtUmxaRjloWm5SbGNsOXBabDlsYkhObFFEa0tDbDlqWVc1RFlXeHNSWGgwWlc1a1pXUmZhV1pmWW05a2VVQTRPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb0tYMk5oYmtOaGJHeEZlSFJsYm1SbFpGOWhablJsY2w5cGJteHBibVZrWHk5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTGw5allXNURZV3hzVTJWc1prQXhPRG9LSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2w5allXNURZV3hzUlhoMFpXNWtaV1JmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQmZZMkZ1UTJGc2JFVjRkR1Z1WkdWa1gybG1YMkp2WkhsQU1URUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR0o2WlhKdkNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQTlQUW9nSUNBZ1lub2dYMk5oYmtOaGJHeEZlSFJsYm1SbFpGOWhablJsY2w5cFpsOWxiSE5sUURFeUNncGZZMkZ1UTJGc2JFVjRkR1Z1WkdWa1gybG1YMkp2WkhsQU1URTZDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemRXSnpkSEpwYm1jZ01DQTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0lsOWxlR1ZqZFhScGIyNUpaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYMlY0WldOMWRHbHZia2xrSUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdYMmhoYzJoRmVHVmpkWFJwYjI1SlpBb2dJQ0FnUFQwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRjlqWVc1RFlXeHNSWGgwWlc1a1pXUmZZV1owWlhKZmFXNXNhVzVsWkY4dmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1ZlkyRnVRMkZzYkZObGJHWkFNVGdLQ2w5allXNURZV3hzUlhoMFpXNWtaV1JmWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCZloyVjBRV1J0YVc1U1pYTjBjbWxqZEdsdmJuTUtJQ0FnSUhCdmNHNGdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5blpYUkJaRzFwYmxKbGMzUnlhV04wYVc5dWN3b2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOW5aWFJCWkcxcGJsSmxjM1J5YVdOMGFXOXVjd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCd2IzQnVJRElLSUNBZ0lHSnVlaUJmWTJGdVEyRnNiRVY0ZEdWdVpHVmtYMkZtZEdWeVgybG1YMlZzYzJWQU1UVUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCallXeHNjM1ZpSUdselZHRnlaMlYwUTJ4dmMyVmtDaUFnSUNCaWJub2dYMk5oYmtOaGJHeEZlSFJsYm1SbFpGOXBabDlpYjJSNVFEZ0tDbDlqWVc1RFlXeHNSWGgwWlc1a1pXUmZZV1owWlhKZmFXWmZaV3h6WlVBeE5Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMkZzYkhOMVlpQm9ZWE5TYjJ4bENpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMkZzYkhOMVlpQm9ZWE5TYjJ4bENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEJ2Y0FvZ0lDQWdZbm9nWDJOaGJrTmhiR3hGZUhSbGJtUmxaRjlwWmw5aWIyUjVRRGdLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBeUNpQWdJQ0JqWVd4c2MzVmlJRTFoZEdndWJXRjRDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRTFoZEdndWJXRjRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR01nTmlBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0JrZFhBS0lDQWdJQ0VLSUNBZ0lITjNZWEFLSUNBZ0lHSWdYMk5oYmtOaGJHeEZlSFJsYm1SbFpGOWhablJsY2w5cGJteHBibVZrWHk5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTGw5allXNURZV3hzVTJWc1prQXhPQW9LWDJOaGJrTmhiR3hGZUhSbGJtUmxaRjlsYkhObFgySnZaSGxBTXpvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUF3ZURBMENpQWdJQ0JpUEFvZ0lDQWdZbm9nWDJOaGJrTmhiR3hGZUhSbGJtUmxaRjkwWlhKdVlYSjVYMlpoYkhObFFEVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwZlkyRnVRMkZzYkVWNGRHVnVaR1ZrWDNSbGNtNWhjbmxmYldWeVoyVkFOam9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnY21WMGMzVmlDZ3BmWTJGdVEyRnNiRVY0ZEdWdVpHVmtYM1JsY201aGNubGZabUZzYzJWQU5Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzNWaWMzUnlhVzVuSURBZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCallXNURZV3hzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHSWdYMk5oYmtOaGJHeEZlSFJsYm1SbFpGOTBaWEp1WVhKNVgyMWxjbWRsUURZS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzVmYVhORmVIQnBjbVZrS0hScGJXVndiMmx1ZERvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNsOXBjMFY0Y0dseVpXUTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWXlBMUlDOHZJREk0TVRRM05EazNOamN4TURZMU5Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCUWtrZ2RtRnNhV1JoZEdsdmJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5SaklEVWdMeThnTWpneE5EYzBPVGMyTnpFd05qVTFDaUFnSUNBbUNpQWdJQ0JtY21GdFpWOWlkWEo1SUMweENpQWdJQ0JqWVd4c2MzVmlJR1Y0Y0dseVlYUnBiMjRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEVWdMeThnTWpneE5EYzBPVGMyTnpFd05qVTFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmpZV3hzYzNWaUlGUnBiV1V1ZEdsdFpYTjBZVzF3Q2lBZ0lDQThQUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNXpiMnd1UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVYMmhoYzJoRmVHVmpkWFJwYjI1SlpDaDBZWEpuWlhRNklHSjVkR1Z6TENCelpXeGxZM1J2Y2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwZmFHRnphRVY0WldOMWRHbHZia2xrT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ1lubDBaV01nT1NBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR0ltQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCSVlYTm9aWE11WldabWFXTnBaVzUwUzJWalkyRnJNalUyQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzVmWDNWeWIzTmZabTl5ZDJGeVpGOTJZV3gxWlNncElDMCtJSFp2YVdRNkNsOWZkWEp2YzE5bWIzSjNZWEprWDNaaGJIVmxPZ29nSUNBZ2NISnZkRzhnTUNBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCZlgzVnliM05mWm05eWQyRnlaRjkyWVd4MVpWOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtDbDlmZFhKdmMxOW1iM0ozWVhKa1gzWmhiSFZsWDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWVpQmZYM1Z5YjNOZlptOXlkMkZ5WkY5MllXeDFaVjloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdNZ055QXZMeUJVVFZCTVgxVlNUMU5mVTFSUFVrRkhSVjlCVUZCZlNVUUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lIQnZjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LWDE5MWNtOXpYMlp2Y25kaGNtUmZkbUZzZFdWZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdjbVYwYzNWaUNncGZYM1Z5YjNOZlptOXlkMkZ5WkY5MllXeDFaVjkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpSUY5ZmRYSnZjMTltYjNKM1lYSmtYM1poYkhWbFgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbDlmZFhKdmMxOXZaMTl6WlhSMWNDZ3BJQzArSUhadmFXUTZDbDlmZFhKdmMxOXZaMTl6WlhSMWNEb0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOWZiMmRmYzJWdVpHVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQmZYM1Z5YjNOZmIyZGZjMlYwZFhCZmRHVnlibUZ5ZVY5bVlXeHpaVUF5Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tYMTkxY205elgyOW5YM05sZEhWd1gzUmxjbTVoY25sZmJXVnlaMlZBTXpvS0lDQWdJR0o1ZEdWalh6SWdMeThnSWw5ZmIyZGZkbUZzZFdVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ3BmWDNWeWIzTmZiMmRmYzJWMGRYQmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWDE5MWNtOXpYMjluWDNObGRIVndYM1JsY201aGNubGZiV1Z5WjJWQU13bz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFJQUFFZ0NBRC8vLy8vLy84Ly8vLy8vdzhBSmo0Z0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFMWDE5dloxOXpaVzVrWlhJS1gxOXZaMTkyWVd4MVpRUmhmYVFkQkJVZmZIVWhBUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRRUtBQUFBQUFBQUFBQUFBQzVmY205c1pVMWxiV0psY2xObGRLOVZjUFdoZ1F0Njk0eXZTOGNLWmc4TjlSNUN1dmtkVGVXeU1vM2c2RDM4RlAvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vL0RGOWxlR1ZqZFhScGIyNUpaQXBmYzJOb1pXUjFiR1Z6QVFBS1gzQnZjMmwwYVc5dWN3NWZYMk4wYjNKZmNHVnVaR2x1WndJQUFCUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUVFQk0vRm1Bd0VVRTcvQWdTTVJrUmRCSXZqTEdZRWt6KzdhZ1JNK01zdUJHRm9FR1FFejhTWW1BVGthQ0JTQlBjM3JQZ0VvQXYwTUFRQ25ScUVCTnZ3amhBRXZ6MXZxd1J0d3dNRkJMOWpkbHNFMEhsa01RU2VxbGM2Qk0veTVpRUUxRVFQVndTSDFVVUxCQ3dLellFRTJuVUxJd1FUNlNpR0JEMjhiVU1Fa1BXT2RRVHhCbWVaQklrY04wb0V4TjRYQ3dUeGlvT29CTFVTVlZ3RUxmQXFKd1FvUk51ZUJEUksvMEFFMld1S2ZRUUc3Y011Qk1iVkZTNEVySnk2RGdTRjA0TGhCTjJZS05VR0FBQUFBQUFBQ2dBQ0FBUUFCZ0FBQUFBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRQUFBQUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJBQUFBQUFBQUFBQWlSdzJBQUVjTWdZQWdyMGsxQlRVQU5BQ0FJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDQVhFQTFBREVZUUFBR0p3NGpaeU5EZ0FUY1hqZVlOaG9BamdFUkFURVpGRVF4R0VTQUJKa1BNSzRuRWljVGdBVFRWV1RWSnhRbkZZQUVQRjJ0U2ljV0p4Y25HQ2NaSnhxQUJGcnd2U2NuR3ljY0p4MG5IaWNmZ0FSTUJQUFlKeUFuSVNjaUp5TW5KQ2NsSnlZbkp5Y29KeWtuS2ljckp5d25MU2N1Snk4bk1DY3hKekluTXljMEp6VW5OaWMzSnppQ0JRUXFNczNSQkR0Y29JWUVMSU5tMkFSbW1zQkxCQVNWSENrbk9ZQUVCSkdhSmpZYUFJNHpEbThPTWc0RERiVU5lQTFKRFBzTXN3eDREQ0lMMkF1ZEMwRUsrUXErQ21nS0VnbktDV0FKTHdqK0NOSUl4d2lXQ0g0SVlnaFBDRHNJSndmcUI0MEhhUWNsQnRrR213WmRCaDhGNFFXakJVNEZFQVRTQkw4RWdnTlpBclVCOVFHUEFXUUJKZ0FCQURZYUFVa2lXVWxGRFlFQ0MwVUhTUlZGQTFjQ0FFVWFJa1VLU3dsTEN3eEJBQ2RMQ1VtQkFndExHMGxQQWxsSlN3bEpUZ1FTUkVzQkZWSWlXWUVDQ0FoRkJ5TUlSUXBDLzlGTEJZRUNDRXNDRWtReEZrRUF5akVXSXdrNENCUkVKdzlGR3lKRkRFc0xTd3NNUVFBL1N4cEpJbGxKZ1FJTGdRSUlTd0tCQWtzQ1VvRUNyMUJMQXhWUEJFOERUd0pTSnc5UVVFd2pDRWtXVndZQVRnSWlpQTluVUVzTUl3aEZEVVViUXYrNWdBQkZGa3NhUlJGTENoWkxGcVZCQUZzMEFEVUFKYTlMRmtsT0FsQkpGU1VKVzBzU1NVNENJbGxMQVExRVN3RlJBQUpKRjA4RFZ3SUFTd09CQWd0TEFVeFpTbGxMQVFpQkFnaExBaUpQQTFJbkQxQkxBaFZNVGdOU1VFeFBBNGdPK2xCRkVpY0dvRVVXUXYrY0p3UkxFVkN3STBNaVF2ODROaG9CRlNRU1JEWWFBaFVrRWtTSUdCQ0lHRDZ4TmhvQk5ob0NJUVNCQnJJUUlySVpJcklCc2hncnNob25PYklhVExJYXNocXpLU2huS2lKbkkwTTJHZ0ZKRlNRU1JEWWFBa2tWSkJKRU5ob0RTU0paZ1FJSVN3RVZFa1JYQWdDSUZYRW5CRXhRc0NORE5ob0JTVVVhRlNRU1JEWWFBa2tpV1lFQ0NFc0JGUkpFVndJQVJSZ3hGa0VBUURFV0l3azRDQlJFTVFDeFNZRVlXNEVHc2hBaXNoa2lzZ0d5R0lBRXpWRTlwYklhczdRK1Z3UUFnQVNQczJBM0V4UkVTeGxNU3htSUZRNklGTHRJSTBNaVF2L0NOaG9CU1VVYUZTUVNSRFlhQWtsRkVCVWtFa1EyR2dOSklsbUJBZ2hMQVJVU1JGY0NBRVVZTVJaQkFKQXhGaU1KT0FnVVJERUFTVVVVU3hoSlVRQUVSUkpMR2tsT0Frc1NUd0tJRkxkSlJSVUJKd3RNVUVsRkY3NG5CMDRDVFZjQUJoY1VGRVFUUVFBaUlrc1RTVTRDaUJQUVNFeExFRXNTaUJMNWlCT1NUSWdUd0VoRkNrQUFBMHNJUkVzVFNiNG5CMDRDVFZjR0JDYzZURkJNU3dHL2dRWmFTUlpMRTB4UWdBUnphdlNzVEZDd0lRWWFGaWNFVEZDd0kwTWlRdjl5TmhvQlNVVVFTUlVrRWtRMkdnSkpJbG1CQWdoTEFSVVNSRmNDQUVsRkdqRUFTVVVjU1VzRFN3T0lGVWhJVGdOT0FvZ1ZRRVVHU0VBQUJVc0RGQlJFU3hoTEQwc1ppQlA4UlJJaVJRZExBMEFBQ0VzUmlCTnJRUUFIU3hHSUU1VkZCeUluQ21WTVJSaEVTeGRSQUFSTEQweUlGZ1FuQ2t4bk1SWkJBQ014RmlNSk9BZ1dTdzlMR1U4Q2lBMFRTQ2NLU3hkblN3WWhCaG9XSndSTVVMQWpReUpDLzk4MkdnRkpSUkFWSkJKRU5ob0NTVVVQU1NKWmdRSUlTd0VWRWtSWEFnQkZHRFlhQTBrVkpSSkVGMFVCTVJaQkFQVXhGaU1KT0FnVVJFY0NJUVVPUkNFRkdrbEZBakVBU1VVYlN4QkxHb2dVZ0VVQmlCQUJTd0VJU1VVUUlRVU9SQlFVUkVFQUJrbExEUXdVUkNXdlN3RVdTdzRXU29nUG5Vc0RURkJPQW9nUGxFOENURkFWSlFsYklRVWFSUUZMR0VzUFN4bUlFd3BKUlJNQkp3dE1VRWxGRmI0bkIwNENUVmNBQmhkSlJRWkJBQVpMQklnVS9rUkxFMG0rSndkT0FrMUpnUVphSXdpQmdJQ0FnQkFZVEZjR0JFc0RGa21UZ1RBT1JFbFhBZ1pQQWxCTEFoWkpreVFPUkVsWEJBUlBBbGNBQmt4UVR3Uk12MHNVU1U0RFRGQk1VRXNiVUVzUlVJQUNBSEpRU3hCUWdBVDR0M2thVEZDd1RDRUdHaFpRSndSTVVMQWpReUpDL3cwMkdnRVZKQkpFaUJTN2lCVHBzVFlhQVNFRWdRYXlFQ0t5R1NLeUFiSVlLN0lhSnppeUdySWFzN1ErVndvQUZ5a29aeW9pWnhZbkJFeFFzQ05ETmhvQlNSVWtFa1NJRWEwV0p3Uk1VTEFqUXpZYUFSVWtFa1EyR2dJVkl4SkVpQlJraUJTU3NUWWFBVFlhQWlFRWdRYXlFQ0t5R1NLeUFiSVlLN0lhSnpheUdreXlHcklhc3lrb1p5b2laeU5ETmhvQkZTUVNSRFlhQWhVbEVrU0lGQ2FJRkZTeE5ob0JOaG9DSVFTQkJySVFJcklaSXJJQnNoZ3JzaG9uTmJJYVRMSWFzaHF6S1NobktpSm5JME0yR2dFVkpCSkVOaG9DU1NKWmdRUUxnUUlJVEJVU1JEWWFBeFVsRWtTSUU5aUlGQWF4TmhvQk5ob0NOaG9ESVFTQkJySVFJcklaSXJJQnNoZ3JzaG9uTkxJYVR3S3lHa3l5R3JJYXN5a29aeW9pWnlORE5ob0JGU1VTUkRZYUFoVWxFa1NJRTVPSUU4R3hOaG9CTmhvQ0lRU0JCcklRSXJJWklySUJzaGdyc2hvbk03SWFUTElhc2hxektTaG5LaUpuSTBNMkdnRVZKUkpFTmhvQ0ZTVVNSSWdUVllnVGc3RTJHZ0UyR2dJaEJJRUdzaEFpc2hraXNnR3lHQ3V5R2ljeXNocE1zaHF5R3JNcEtHY3FJbWNqUXpZYUFSVWxFa1EyR2dJVkpSSkVpQk1YaUJORnNUWWFBVFlhQWlFRWdRYXlFQ0t5R1NLeUFiSVlLN0lhSnpHeUdreXlHcklhc3lrb1p5b2laeU5ETmhvQkZTVVNSRFlhQWhVa0VrU0lFdG1JRXdleE5ob0JOaG9DSVFTQkJySVFJcklaSXJJQnNoZ3JzaG9uTUxJYVRMSWFzaHF6S1NobktpSm5JME0yR2dFVkpSSkVOaG9DRlNRU1JJZ1NtNGdTeWJFMkdnRTJHZ0loQklFR3NoQWlzaGtpc2dHeUdDdXlHaWN2c2hwTXNocXlHck1wS0djcUltY2pRellhQVJVbEVrUTJHZ0lWSkJKRU5ob0RGU1VTUklnU1ZvZ1NoTEUyR2dFMkdnSTJHZ01oQklFR3NoQWlzaGtpc2dHeUdDdXlHaWN1c2hwUEFySWFUTElhc2hxektTaG5LaUpuSTBNMkdnRVZKUkpFTmhvQ1NTSlpnUUlJVEJVU1JJZ1NDNGdTT2JFMkdnRTJHZ0loQklFR3NoQWlzaGtpc2dHeUdDdXlHaWN0c2hwTXNocXlHck1wS0djcUltY2pRellhQVVrVkpSSkVGellhQWtrVkpCSkVpQTY2Snd3aVR3TlVUQlpRSndSTVVMQWpRellhQVJVbEVrUTJHZ0lWSkJKRWlCR3BpQkhYc1RZYUFUWWFBaUVFZ1FheUVDS3lHU0t5QWJJWUs3SWFKeXV5R2t5eUdySWFzN1ErUndNcEtHY3FJbWRQQTFjS0NFOERWeElJVUU4Q1Z4b0lVRXhYSWdoUUp3Uk1VTEFqUXpZYUFSVWxFa1NJRVZPSUVZR3hOaG9CSVFTQkJySVFJcklaSXJJQnNoZ3JzaG9uS3JJYXNocXp0RDVYQ2dBWEtTaG5LaUpuRmljRVRGQ3dJME0yR2dGSkZTVVNSQmVJRGRJV0p3Uk1VTEFqUXpZYUFVa1ZKUkpFRjRnTmpCWW5CRXhRc0NORE5ob0JTUlVrRWtTSURVY1dKd1JNVUxBalF6WWFBVWtWSkJKRU5ob0NTUldCQkJKRWlBenpGaWNFVEZDd0kwTTJHZ0ZKRlNRU1JJZ01xeWNNSWs4Q1ZDY0VURkN3STBPSUVLNklFTnl4SVFTQkJySVFJcklaSXJJQnNoZ3JzaG9uSkxJYXM3UStWd29BRnlrb1p5b2laeFluQkV4UXNDTkRpQXhBRmljRVRGQ3dJME0yR2dGSkZTUVNSRFlhQWtrVkpCSkVOaG9EU1JXQkJCSkVpQXZWSnd3aVR3TlVUQlpRSndSTVVMQWpRNGdRUm9nUWRMRWhCSUVHc2hBaXNoa2lzZ0d5R0N1eUdpY2hzaHF6dEQ1WENnQVhLU2huS2lKbkZpY0VURkN3STBPSUVCV0lFRU94SVFTQkJySVFJcklaSXJJQnNoZ3JzaG9uSUxJYXM3UStWd29BRnlrb1p5b2laeFluQkV4UXNDTkROaG9CRlNVU1JEWWFBaFVrRWtRMkdnTVZnVUFTUkRZYUJCV0JRQkpFaUEvR2lBLzBzVFlhQVRZYUFqWWFBellhQkNFRWdRYXlFQ0t5R1NLeUFiSVlLN0lhZ0FUUUV0MDlzaHBQQTdJYVR3S3lHa3l5R3JJYXM3UStWd29BS1NobktpSm5Kd1JNVUxBalF6WWFBUlVsRWtRMkdnSVZKQkpFaUE5c2lBK2FzVFlhQVRZYUFpRUVnUWF5RUNLeUdTS3lBYklZSzdJYUp4K3lHa3l5R3JJYXM3UStWd29BS1NobktpSm5Kd1JNVUxBalF6WWFBUlVsRWtRMkdnSVZKQkpFTmhvREZTUVNSSWdQSFlnUFM3RTJHZ0UyR2dJMkdnTWhCSUVHc2hBaXNoa2lzZ0d5R0N1eUdpY2VzaHBQQXJJYVRMSWFzaHF6dEQ1WENnQXBLR2NxSW1jbkJFeFFzQ05ETmhvQkZTVVNSRFlhQWhVa0VrUTJHZ01WSkJKRWlBN0hpQTcxc1RZYUFUWWFBallhQXlFRWdRYXlFQ0t5R1NLeUFiSVlLN0lhSngyeUdrOENzaHBNc2hxeUdyTzBQbGNLQUNrb1p5b2laeWNFVEZDd0kwTTJHZ0VWSlJKRWlBNS9pQTZ0c1RZYUFTRUVnUWF5RUNLeUdTS3lBYklZSzdJYUp4eXlHcklhczdRK1Z3b0FLU2huS2lKbkp3Uk1VTEFqUXpZYUFSVWxFa1EyR2dJVkpCSkVpQTQ5aUE1cnNUWWFBVFlhQWlFRWdRYXlFQ0t5R1NLeUFiSVlLN0lhSnh1eUdreXlHcklhczdRK1Z3b0FLU2huS2lKbkp3Uk1VTEFqUXpZYUFSVWxFa1EyR2dJVmdVQVNSRFlhQXhXQlFCSkVpQTNzaUE0YXNUWWFBVFlhQWpZYUF5RUVnUWF5RUNLeUdTS3lBYklZSzdJYWdBU3ZsUUp3c2hwUEFySWFUTElhc2hxenRENVhDZ0FwS0djcUltY25CRXhRc0NORE5ob0JGU1VTUklnTm9JZ056ckUyR2dFaEJJRUdzaEFpc2hraXNnR3lHQ3V5R2ljYXNocXlHck8wUGxjS0FDa29aeW9pWnljRVRGQ3dJME0yR2dFVkpSSkVOaG9DRlNRU1JJZ05Yb2dOakxFMkdnRTJHZ0loQklFR3NoQWlzaGtpc2dHeUdDdXlHaWNac2hwTXNocXlHck8wUGxjS0FCY3BLR2NxSW1jV0p3Uk1VTEFqUXpZYUFSVWxFa1EyR2dJVkpCSkVOaG9ERlNRU1JJZ05EWWdOTzdFMkdnRTJHZ0kyR2dNaEJJRUdzaEFpc2hraXNnR3lHQ3V5R2ljWXNocFBBcklhVExJYXNocXp0RDVYQ2dBcEtHY3FJbWNuQkV4UXNDTkROaG9CRlNVU1JJZ014WWdNODdFMkdnRWhCSUVHc2hBaXNoa2lzZ0d5R0N1eUdpY1hzaHF5R3JPMFBsY0tBQ2tvWnlvaVp5Y0VURkN3STBNMkdnRVZKUkpFTmhvQ0ZTUVNSSWdNZzRnTXNiRTJHZ0UyR2dJaEJJRUdzaEFpc2hraXNnR3lHQ3V5R2ljV3NocE1zaHF5R3JPMFBsY0tBQ2tvWnlvaVp5Y0VURkN3STBNMkdnRVZnVUFTUkRZYUFoV0JRQkpFaUF3NWlBeG5zVFlhQVRZYUFpRUVnUWF5RUNLeUdTS3lBYklZSzdJYWdBUWhjenRtc2hwTXNocXlHck8wUGxjS0FDa29aeW9pWnljRVRGQ3dJME9JQy91SURDbXhJUVNCQnJJUUlySVpJcklCc2hncnNob25GYklhczdRK1Z3b0FLU2huS2lKbkp3Uk1VTEFqUXpZYUFSVWtFa1NJQzhXSUMvT3hOaG9CSVFTQkJySVFJcklaSXJJQnNoZ3JzaG9uRkxJYXNocXp0RDVYQ2dBWEtTaG5LaUpuRmljRVRGQ3dJME0yR2dFVmdVQVNSRFlhQWhXQlFCSkVpQXQvaUF1dHNUWWFBVFlhQWlFRWdRYXlFQ0t5R1NLeUFiSVlLN0lhZ0FRNEdUUFRzaHBNc2hxeUdyTzBQbGNLQUNrb1p5b2laeWNFVEZDd0kwT0lDMEdJQzIreElRU0JCcklRSXJJWklySUJzaGdyc2hvbkU3SWFzN1ErVndvQUtTaG5LaUpuSndSTVVMQWpRellhQVJVa0VrU0lDd3VJQ3pteE5ob0JJUVNCQnJJUUlySVpJcklCc2hncnNob25Fcklhc2hxenRENVhDZ0FYS1NobktpSm5GaWNFVEZDd0kwTTJHZ0ZKUlJaSkZTUVNSQ2NPWkVRbkRpSm5nQWhmZEdGeVoyVjBjNEVDdVVpQUJsOXliMnhsYzRFQ3VVZ25DNEVDdVVpQURsOXliMnhsVFdWdFltVnlVMlYwZ1FLNVNJQVRYM0p2YkdWQlpHMXBibFJ2VW05c1pWTmxkSUVDdVVpQUVGOXliMnhsVkc5VVlYSm5aWFJUWlhTQkFybElnQmRmZEdGeVoyVjBWRzlUWld4bFkzUnZjbFJ2VW05c1pZRUN1VWlBR2w5eWIyeGxWRzlVWVhKblpYUlViMU5sYkdWamRHOXlVMlYwZ1FLNVNDY0tLR2RKS0JJVVJBR0FCMjFsYldKbGNuTk1VRWxGRmI0bkVFNENUVmNBQmhkSlJRUkpGRVVKUUFDTWlBUmVTU0VGRGtRaWlBUmNTUldCRGc1RWdRNnZxMHNCRmttVGdUQU9SRmNDQmt4UVN4Vk12eUlXSnd3aVN3dFVUd0lXU3dKTEdGQlBBMUJNVUV4UWdBU2RXNDBuVEZDd1N3SkFBQ0pMQnlNT1JFc0NRQUFhSndpK0p6dE9BazFMRllnQ3RraEZBU2NJdkVnbkNFeS9JME1uQ0w0bk8wNENUVXNWaUFMRVNFVUJKd2k4U0NjSVRMOUMvK05MRTBtK0p4Qk9BazFYQmc0aVNZZ0VNMFlDdmljUVRnSk5Wd1lPSWttSUJDTkZBVUwvZGpFWmdRUVNNUmdRUTRvREFZditnUUlMU1l2L2dRSUxpLzFMQVZsUEFreUwvMDFNaXdLTEFBeEJBQ1dMQVVrV1Z3WUFpLzJMQWtsT0JFOENYVW1NL1VzQldZRUNDQWlNQVlFQ0NJd0NRdi9UaS8yTUFJbUtBd0V5Q25NQVNCYUwvNlFVUkl2OWkvK0wvb2dDaFVtTC9ZRVlXM0lBU0V4QkFCbUlBcUtBQUtWQUFBcUxBUlVXZ0FDbFFRQUdpQUtXakFDSml3QVVSSWdDaFlBQXBVUkNBcmVLQWdLTC9vdi9pQUdvalA1QUFIZUwvaUpaaS82QkFsbUwva3NDU3dKU2dBSUFBWXYvVUVsWEFnQk1JbGxMQWlKWkNCWlhCZ0JQQWt4Y0FFeFFpLzRpU3dSWVN3RlFpLzRWaS81TEJFOENVbEJMQWs4RUNVOENGVThEQ0V3SkZsY0dBbHdDU1l6K0lsbUwvb0VDV1l2K1RnSlNJbGtXaS84Qkp3MU1VRW04U0V5L0k0ditpU0tML29tS0FnSWlSd0tBQUVtTC93RW5EVXhRU2I2QUFFNENUVW1BQUtsQkFRS0xCa2tuQnFkRUp3V2dKd2FoSndXcVNZd0NpLzRpV1VtTUE0ditnUUpaU1l3RWkvNU9BbEpKakFBaVdSWkpKd2FuUkNjRm9DY0dvU2NGcWttTUFhbEJBR2tscjBtTEFWQkpGU1VKVzRzQVNVNERWd0lBVENRTEpGaE1pd0pRU1JVbENWc2tDNEVDQ0U4Q1RFc0NYWXYrSW9zRFNVNEVXRXNCVUl2K0ZZditpd1JKVGdOUEFsSlBBa3hRU3dGUEJBbFBBeFZQQXdoTUNSWlhCZ0pjQW96K0FTY05URkJKdkVpTEJyK0wvaUpaaS82QkFsbUwva3NDU3dKU1NSVWtDU0pNVWtraVdTTUpGbGNHQUZ3QWkvNGlTd1JZU3dGUWkvNFZpLzVMQkU4Q1VsQkxBazhFQ1U4Q0ZVOERDRXdKRmxjR0Fsd0NqUDZMQmJ4SUk0ditqQUdNQUlraWkvNk1BWXdBaVlvQ0Fvdi9BU2NOVEZDK2dBQk9BazJBQUttTC9vbUtBZ09ML2lKWmkvNFZpLzVPQWxJa3I0di9Kd21zSndtc1VFa1ZKQWtrV0lqK0ZVaUwva21KaWdJRGkvNGlXWXYrRll2K1RnSlNKSytML3ljSnJDY0pyRkJKRlNRSkpGaUkvbmRJaS81SmlZb0NBVFFBSks5SmkvNVFTUlVrQ1NSWVR3Sk1YQUJMQVl2L1VFa1ZKQWtrV0Z3Z1NWY0FRQUpQQWt4UVNSVWtDU1JZVndBZ1REVUFpWW9EQVRRQUphK0wvNEFCSUtBbkJhcExBVXhRU1JVbENWdE1pLzlRU1JVbENWdExBazRDV0Z3QU5RQWppVFFBTlFDQUFJazBBQ1d2U3dGWFFDQk1Td0ZRU1JVbENWc2tyMDhEVHdJb1hVc0NnQUVnb0NjRnFrOENURkJKRlNRSkpGaGNRRFVBaVFDS0F3R0wvb3Yvcll2OWlBQTJveWNGcW92L3JZbUtBZ0dML292L3BZditpLytJLzl5SmlnRUJpLytBQnYvLy8vLy8vNlVVUkNXdmkvOVFTUlVsQ1ZzaEJScUppZ0VCTkFDTC94UVVnQUFuQms4Q1RVdzFBSWt5QnhhSS84aUppZ0VCaS84V2lZb0NBNEFBaS82SUFLcEdBNHYraUFDalNVNERUZ05HQW92K2lBQ1hTRTRDU0l2K2lBQ09SZ0pPQW92L0RrRUFEaUtNQUNLTEFFeFBCVThGVHdXSml3Rk1qQUNMQWt4Qy8rdUtBUU9JLzZPTC8weUkvNnVKaWdFQmkvK0kvK3RHQW9tS0F3S0wvWWovN1VtTC9nMUJBRUNMQUl2K0NVa2hCZzVFSmErTC94WlBBaFpLaVA4cVN3Tk1VRTRDaVA4aFR3Sk1VQlVsQ1ZzaEJocUkvMVVJU1NFRkRrU0xBSXYrU3dLSUFEOU1Ud0tKSWtML3hvb0JBeVd2U1l2L1VFa1ZKUWxiSVFZYWkvOG5QS0pMQWt4UVNSVWxDVnNoQmhxTC95YzlvazhEVEZCSkZTVUpXeUVGR2t4T0FvbUtBd0dML3hZblBhTW5CYXFML1JZblBLTW5CYXFyaS80V3E0bUtBd0tJQkg2SUJLeXhOaG9CTmhvQ05ob0RJUVNCQnJJUUlySVpJcklCc2hncnNob25JcklhVHdLeUdreXlHcklhczdRK1Z3b0JJbE1pRTdRK2dRdGJLU2huS2lKbmlZZ0VPb2dFYUxFaEJJRUdzaEFpc2hraXNnR3lHQ3V5R2ljanNocXp0RDVYQ2dBWEtTaG5LaUpuaVlvQkFZZ0VEWWdFTzdFMkdnRWhCSUVHc2hBaXNoa2lzZ0d5R0N1eUdpY2xzaHF5R3JPMFBsY0tBQ0pUSWhNcEtHY3FJbWVKaWdJQmlBUFlpQVFHc1RZYUFUWWFBaUVFZ1FheUVDS3lHU0t5QWJJWUs3SWFKeWF5R2t5eUdySWFzN1ErVndvQUZ5a29aeW9pWjRtS0FRR0lBNkNJQTg2eE5ob0JJUVNCQnJJUUlySVpJcklCc2hncnNob25KN0lhc2hxenRENVhDZ0FYS1NobktpSm5pWW9CQVlnRGJvZ0RuTEUyR2dFaEJJRUdzaEFpc2hraXNnR3lHQ3V5R2ljb3NocXlHck8wUGxjS0FCY3BLR2NxSW1lSmlnRUJpQU04aUFOcXNUWWFBU0VFZ1FheUVDS3lHU0t5QWJJWUs3SWFKeW15R3JJYXM3UStWd29BRnlrb1p5b2laNG1LQWdLSUF3cUlBeml4TmhvQk5ob0NJUVNCQnJJUUlySVpJcklCc2hncnNob25MTElhVExJYXNocXp0RDVYQ2dFaVV5SVR0RDZCQzFzcEtHY3FJbWVKaWdFQmlBTEtpQUw0c1RZYUFTRUVnUWF5RUNLeUdTS3lBYklZSzdJYUp6ZXlHcklhczdRK1Z3b0FGeWtvWnlvaVo0bUtBUUdML3dFbkMweFFTYjRuQjA0Q1RVbFhBQVlYVElFR1drc0JGQlJFaVB6a1N3SU1GRVJNaUFJNUZFUkxBYjRuQjA0Q1RWY0dCQ2M2VEZCUEFreS9TUmFMLzB4UWdBU3RQVURkVEZDd2lZb0RBVEVXUVFCWk1SWWpDVGdJRkVTTC9ZditVQ1N2VElBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBR0JRaS84VlNSWlBBMHhRU1JVa0NTUllnUit2aS85TVVFOENnUjhJSkFva0N5Sk1XRkJRQW9raVF2K3BpZ0VESW92L0ZSWW5FYVJCQUFZaVJ3SlBBNG1MLzFFQUJFbU1BSUFFaFRWUnVCSkFBRENMQUlBRU1NcmhoeEpBQUNTTEFJQUVVcFlwVWhKQUFCaUxBSUFFcGsyVnpoSkFBQXlMQUlBRTBpdFppUkpCQUFZaklrbFBBNG1MQUlBRUdQOFlQQkpBQUJpTEFJQUVGbnZUbFJKQUFBeUxBSUFFQ05ZU0xSSkJBQktMLzFFRUpGY0FJSWo5dUNNaVR3SlBBNG1MQUlBRUpjUnhvQkpBQUF5TEFJQUV0OUt4WWhKQkFCU0wvMUVFSkZjQUlJRVlXNGo5dlNOTUlrOERpVElLaXdDSS9VWWlUQ0pQQTRtS0F3S0FBRWNETWdxTC9oSkFBQTJCR0s4eUNCWlFpLzRTUVFDZmkvOFZGaWNScEVFQUJ5SkpqQUdNQUlreUNvdjlFa0FBRFlFWXJ6SUlGbENML1JKQkFCb3lDb3oraS85UkFBUWlKd3BsUkl2K1R3S0lBSzBTSWtML3pJdi9pUDdVUmdLTC80ait6VWlNQWtpTC80ait4SXdCUmdKQUFBZ3lDb2o4amtEL3Bvc0NTWXY5aVAyR1NFeUwvWWo5ZjR3QVNFSC9rU1d2aXdFV2l3QVdTb2o2bzBzRFRGQk9Bb2o2bWs4Q1RGQVZKUWxiSVFZYVNSUk1Rdjl0aS84VkZpY1JwRUVBQ3lLTUF5S0xBNHdBakFHSmkvOVJBQVNML1l2K1R3S0krN3hNakFOQy8rV0tBUUdML3lFRkRrU0wveUVGR296L2lQdnFpLzhJU1NFRkRrU0krb1FPaVlvQ0FTU3ZpLzRuQ2F3bkNheFFTUlVrQ1NSWWkvK0krWEtKaWdBQWdBQXhGa0VBSVRFV0l3azRDSXdBaXdCQkFCT3hJUWR5Q0VnanNoQ3lCeUt5QVlzQXNnaXppU0tNQUVMLzRTa3hBR2N4RmtFQUNqRVdJd2s0Q0NwTVo0a2lRdi80IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiUm9sZUdyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGF5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2luY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3TWVtYmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJPcGVyYXRpb25TY2hlZHVsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjaGVkdWxlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3BlcmF0aW9uQ2FuY2VsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJVUk9TX09SQ0hfQVBQX0lEIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6IkFBQUFBQUFBQUFBPSJ9LCJVUk9TX1NUT1JBR0VfQVBQX0lEIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6IkFBQUFBQUFBQUFBPSJ9fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
