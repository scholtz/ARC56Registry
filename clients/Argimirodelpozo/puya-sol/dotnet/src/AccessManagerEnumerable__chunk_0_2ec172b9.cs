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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.AccessManagerEnumerable__chunk_0_2ec172b9
{


    //
    // @title AccessManagerEnumerable
    // @author Aave Labs
    // @notice Extension of AccessManager that tracks role members and their function selectors using EnumerableSet.
    // @dev Roles, target contracts, and function selectors assigned to `ADMIN_ROLE` are excluded from tracking.
    //
    public class AccessManagerEnumerable__chunk_0Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AccessManagerEnumerable__chunk_0Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWNjZXNzTWFuYWdlckVudW1lcmFibGVfX2NodW5rXzAiLCJkZXNjIjoiQHRpdGxlIEFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlXG4gQGF1dGhvciBBYXZlIExhYnNcbiBAbm90aWNlIEV4dGVuc2lvbiBvZiBBY2Nlc3NNYW5hZ2VyIHRoYXQgdHJhY2tzIHJvbGUgbWVtYmVycyBhbmQgdGhlaXIgZnVuY3Rpb24gc2VsZWN0b3JzIHVzaW5nIEVudW1lcmFibGVTZXQuXG4gQGRldiBSb2xlcywgdGFyZ2V0IGNvbnRyYWN0cywgYW5kIGZ1bmN0aW9uIHNlbGVjdG9ycyBhc3NpZ25lZCB0byBgQURNSU5fUk9MRWAgYXJlIGV4Y2x1ZGVkIGZyb20gdHJhY2tpbmcuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFkZHJlc3NTZXQiOlt7Im5hbWUiOiJfaW5uZXIiLCJ0eXBlIjoiU2V0In1dLCJCeXRlczMyU2V0IjpbeyJuYW1lIjoiX2lubmVyIiwidHlwZSI6IlNldCJ9XSwiUm9sZSI6W3sibmFtZSI6Im1lbWJlcnMiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYWRtaW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3VhcmRpYW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3JhbnREZWxheSIsInR5cGUiOiJ1aW50MTEyIn1dLCJTY2hlZHVsZSI6W3sibmFtZSI6InRpbWVwb2ludCIsInR5cGUiOiJ1aW50NDgifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MzIifV0sIlNldCI6W3sibmFtZSI6Il92YWx1ZXMiLCJ0eXBlIjoidWludDhbMzJdW10ifSx7Im5hbWUiOiJfcG9zaXRpb25zIiwidHlwZSI6ImJ5dGVbXSJ9XSwiVGFyZ2V0Q29uZmlnIjpbeyJuYW1lIjoiYWxsb3dlZFJvbGVzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImFkbWluRGVsYXkiLCJ0eXBlIjoidWludDExMiJ9LHsibmFtZSI6ImNsb3NlZCIsInR5cGUiOiJib29sIn1dLCJVaW50U2V0IjpbeyJuYW1lIjoiX2lubmVyIiwidHlwZSI6IlNldCJ9XSwiY2FuQ2FsbFJldHVybiI6W3sibmFtZSI6ImltbWVkaWF0ZSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZGVsYXkiLCJ0eXBlIjoidWludDY0In1dLCJnZXRBY2Nlc3NSZXR1cm4iOlt7Im5hbWUiOiJzaW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjdXJyZW50RGVsYXkiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGVuZGluZ0RlbGF5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVmZmVjdCIsInR5cGUiOiJ1aW50NjQifV0sImhhc1JvbGVSZXR1cm4iOlt7Im5hbWUiOiJpc01lbWJlciIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZXhlY3V0aW9uRGVsYXkiLCJ0eXBlIjoidWludDY0In1dLCJzY2hlZHVsZVJldHVybiI6W3sibmFtZSI6Im9wZXJhdGlvbklkIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoibm9uY2UiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fcG9zdEluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluaXRpYWxBZG1pbl8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9pbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZUNvdW50IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWRtaW5Sb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2luZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBZG1pblJvbGVDb3VudCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBZG1pblJvbGVzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZU1lbWJlciIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2luZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZU1lbWJlckNvdW50IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlTWVtYmVycyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3N0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50OFszMl1bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlT2ZBZG1pblJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluUm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2luZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlT2ZBZG1pblJvbGVDb3VudCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW5Sb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlc09mQWRtaW5Sb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pblJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVUYXJnZXQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9pbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVUYXJnZXRDb3VudCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZVRhcmdldHMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXJFbnVtZXJhYmxlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9zdGFydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9lbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDhbMzJdW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZVRhcmdldFNlbGVjdG9yIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyRW51bWVyYWJsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSb2xlVGFyZ2V0U2VsZWN0b3JDb3VudCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZVRhcmdldFNlbGVjdG9ycyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlckVudW1lcmFibGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDhbNF1bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJBRE1JTl9ST0xFIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJQVUJMSUNfUk9MRSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuQ2FsbCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsZWN0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsdWludDY0KSIsInN0cnVjdCI6ImNhbkNhbGxSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4cGlyYXRpb24iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pblNldGJhY2siLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzVGFyZ2V0Q2xvc2VkIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUYXJnZXRGdW5jdGlvblJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGVjdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUYXJnZXRBZG1pbkRlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVBZG1pbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVHdWFyZGlhbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVHcmFudERlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWNjZXNzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJnZXRBY2Nlc3NSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc1JvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQpIiwic3RydWN0IjoiaGFzUm9sZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGFiZWxSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFiZWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ3JhbnRSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4ZWN1dGlvbkRlbGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZVJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW5vdW5jZVJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyQ29uZmlybWF0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFJvbGVBZG1pbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFJvbGVHdWFyZGlhbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imd1YXJkaWFuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEdyYW50RGVsYXkiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdEZWxheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRUYXJnZXRGdW5jdGlvblJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDhbNF1bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGVjdG9ycyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFRhcmdldEFkbWluRGVsYXkiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3RGVsYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VGFyZ2V0Q2xvc2VkIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjbG9zZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U2NoZWR1bGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Tm9uY2UiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2NoZWR1bGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2hlbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVszMl0sdWludDY0KSIsInN0cnVjdCI6InNjaGVkdWxlUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXhlY3V0ZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuY2VsIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25zdW1lU2NoZWR1bGVkT3AiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoYXNoT3BlcmF0aW9uIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQXV0aG9yaXR5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBdXRob3JpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibXVsdGljYWxsIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElNdWx0aWNhbGwiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfX2RlbGVnYXRlX3VwZGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxODg2LDIwMThdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjMsNzE3LDc3OSw4MDMsODMyLDg1Niw4ODAsOTU0LDEwNDEsMTg0N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDQ+PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4Niw4MTAsODM5LDg2Myw4ODcsMTA0OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTAsNzU3LDc2Niw3NzMsNzk3LDgxOSw4MjYsODUwLDg3NCw5MDUsOTE2LDkzMiw5NDgsMTAwMywxMDE5LDEwNjQsMTA4MywxMTQyLDExNjEsMTE4MiwxMTg5LDEyMTYsMTI1MCwxMjY4LDE4MTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE1MCwxMTk3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI3NSwxMjk2LDEzMDQsMTM5OCwxNDgwLDE1MDEsMTUwOSwxNjAzLDE2NjQsMTc1Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjI0LDEyMzIsMTQ0MywxNDUxLDE2NDEsMTY0OSwxNjc3LDE2ODZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NTEyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODk0LDkzOSw5NzEsOTgwLDk4Nyw5OTYsMTAxMiwxMDI2LDEwMzUsMTA1NywxMDc2LDExMzEsMTIwOSwxMjQzLDEyNjEsMTI4NywxMzQ0LDEzODksMTQzNSwxNDYyLDE0NzMsMTQ5MiwxNTQ5LDE1OTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3VpbnQ4W10pW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMxMSwxMzUyLDE0MDUsMTUxNiwxNTU3LDE2MTAsMTY5MywxNzIzLDE3NjNdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNzIsMTU3NywxNzM5XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNWhjSEJ5YjNaaGJGOXdjbTluY21GdEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFZ016SWdPQ0F3SUZSTlVFeGZWVkpQVTE5TlFVbE9YMEZRVUY5SlJBb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlEQjRNREF3TWpBd01EUXdNREEyTURBd01EQXdNREFnTUhneE5URm1OMk0zTlRBd01EQXdNREF3TURBd01EQXdNREFnSWw5ZmIyZGZkbUZzZFdVaUlDSmZjbTlzWlhOVFpYUWlJQ0pmY205c1pWUnZWR0Z5WjJWMFUyVjBJaUFpWDNKdmJHVk5aVzFpWlhKVFpYUWlJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0lEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd01EQWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnWkhWd2JpQXpDaUFnSUNCd2RYTm9hVzUwSURRd09UWUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhOMGIzSmxJRFVLSUNBZ0lITjBiM0psSURBS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBNE1Bb2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJSEIxYzJoaWVYUmxjeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WkdNMVpUTTNPVGdnTHk4Z2JXVjBhRzlrSUNKZlgyUmxiR1ZuWVhSbFgzVndaR0YwWlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZYMTlrWld4bFoyRjBaVjkxY0dSaGRHVmZjbTkxZEdWQU5Bb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9Ua3daak13WVdVZ01IaGpabU0xT1Rnd1l5QXdlRFV3TkdWbVpqQXlJREI0WkRNMU5UWTBaRFVnTUhnNFl6UTJORFExWkNBd2VEaGlaVE15WXpZMklEQjRNMk0xWkdGa05HRWdNSGc1TXpObVltSTJZU0F3ZURSalpqaGpZakpsSURCNE5qRTJPREV3TmpRZ01IaGpabU0wT1RnNU9DQXdlR1UwTmpneU1EVXlJREI0TldGbU1HSmtNamNnTUhobU56TTNZV05tT0NBd2VHRXdNR0ptTkRNd0lEQjRNREk1WkRGaE9EUWdNSGhrWW1Zd09HVXhNQ0F3ZUdKbU0yUTJabUZpSURCNE5HTXdOR1l6WkRnZ01IZzJaR016TURNd05TQXdlR0ptTmpNM05qVmlJREI0WkRBM09UWTBNekVnTUhnNVpXRmhOVGN6WVNBd2VHTm1aakpsTmpJeElEQjRaRFEwTkRCbU5UY2dNSGc0TjJRMU5EVXdZaUF3ZURKak1HRmpaRGd4SURCNFpHRTNOVEJpTWpNZ01IZ3hNMlU1TWpnNE5pQXdlRE5rWW1NMlpEUXpJREI0T1RCbU5UaGxOelVnTUhobU1UQTJOamM1T1NBd2VEZzVNV016TnpSaElEQjRZelJrWlRFM01HSWdNSGhtTVRoaE9ETmhPQ0F3ZUdJMU1USTFOVFZqSURCNE1tUm1NREpoTWpjZ01IZ3lPRFEwWkdJNVpTQXdlRE0wTkdGbVpqUXdJREI0WkRrMllqaGhOMlFnTUhnd05tVmtZek15WlNBd2VHTTJaRFV4TlRKbElEQjRZV001WTJKaE1HVWdNSGc0TldRek9ESmxNU0F3ZURKaE16SmpaR1F4SURCNE0ySTFZMkV3T0RZZ01IZ3lZemd6Tmpaa09DQXdlRFkyT1dGak1EUmlJREI0TURRNU5URmpNamtnTUhoa1pEazRNamhrTlNBd2VEQTBPVEU1WVRJMklDOHZJRzFsZEdodlpDQWlYMTl3YjNOMFNXNXBkQ2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRkp2YkdVb2RXbHVkREkxTmlsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGSnZiR1ZEYjNWdWRDZ3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlaMlYwVW05c1pYTW9kV2x1ZERVeE1peDFhVzUwTlRFeUtYVnBiblEyTkZ0ZElpd2diV1YwYUc5a0lDSm5aWFJCWkcxcGJsSnZiR1VvZFdsdWRESTFOaWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEVGa2JXbHVVbTlzWlVOdmRXNTBLQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0puWlhSQlpHMXBibEp2YkdWektIVnBiblExTVRJc2RXbHVkRFV4TWlsMWFXNTBOalJiWFNJc0lHMWxkR2h2WkNBaVoyVjBVbTlzWlUxbGJXSmxjaWgxYVc1ME5qUXNkV2x1ZERJMU5pbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSm5aWFJTYjJ4bFRXVnRZbVZ5UTI5MWJuUW9kV2x1ZERZMEtYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltZGxkRkp2YkdWTlpXMWlaWEp6S0hWcGJuUTJOQ3gxYVc1ME1qVTJMSFZwYm5ReU5UWXBkV2x1ZERoYk16SmRXMTBpTENCdFpYUm9iMlFnSW1kbGRGSnZiR1ZQWmtGa2JXbHVVbTlzWlNoMWFXNTBOalFzZFdsdWRESTFOaWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEZKdmJHVlBaa0ZrYldsdVVtOXNaVU52ZFc1MEtIVnBiblEyTkNsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKblpYUlNiMnhsYzA5bVFXUnRhVzVTYjJ4bEtIVnBiblEyTkN4MWFXNTBOVEV5TEhWcGJuUTFNVElwZFdsdWREWTBXMTBpTENCdFpYUm9iMlFnSW1kbGRGSnZiR1ZVWVhKblpYUW9kV2x1ZERZMExIVnBiblF5TlRZcFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaVoyVjBVbTlzWlZSaGNtZGxkRU52ZFc1MEtIVnBiblEyTkNsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKblpYUlNiMnhsVkdGeVoyVjBjeWgxYVc1ME5qUXNkV2x1ZERJMU5peDFhVzUwTWpVMktYVnBiblE0V3pNeVhWdGRJaXdnYldWMGFHOWtJQ0puWlhSU2IyeGxWR0Z5WjJWMFUyVnNaV04wYjNJb2RXbHVkRFkwTEdGa1pISmxjM01zZFdsdWRESTFOaWxpZVhSbFd6UmRJaXdnYldWMGFHOWtJQ0puWlhSU2IyeGxWR0Z5WjJWMFUyVnNaV04wYjNKRGIzVnVkQ2gxYVc1ME5qUXNZV1JrY21WemN5bDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSm5aWFJTYjJ4bFZHRnlaMlYwVTJWc1pXTjBiM0p6S0hWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMU1USXNkV2x1ZERVeE1pbDFhVzUwT0ZzMFhWdGRJaXdnYldWMGFHOWtJQ0pCUkUxSlRsOVNUMHhGS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSWxCVlFreEpRMTlTVDB4RktDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTmhia05oYkd3b1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdKNWRHVmJORjBwS0dKdmIyd3NkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaWGh3YVhKaGRHbHZiaWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p0YVc1VFpYUmlZV05yS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1selZHRnlaMlYwUTJ4dmMyVmtLR0ZrWkhKbGMzTXBZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBWR0Z5WjJWMFJuVnVZM1JwYjI1U2IyeGxLR0ZrWkhKbGMzTXNZbmwwWlZzMFhTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRlJoY21kbGRFRmtiV2x1UkdWc1lYa29ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRkp2YkdWQlpHMXBiaWgxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJTYjJ4bFIzVmhjbVJwWVc0b2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFVtOXNaVWR5WVc1MFJHVnNZWGtvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwUVdOalpYTnpLSFZwYm5RMk5DeGhaR1J5WlhOektTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0pvWVhOU2IyeGxLSFZwYm5RMk5DeGhaR1J5WlhOektTaGliMjlzTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW14aFltVnNVbTlzWlNoMWFXNTBOalFzYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZHlZVzUwVW05c1pTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljbVYyYjJ0bFVtOXNaU2gxYVc1ME5qUXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXNXZkVzVqWlZKdmJHVW9kV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFVtOXNaVUZrYldsdUtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwVW05c1pVZDFZWEprYVdGdUtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwUjNKaGJuUkVaV3hoZVNoMWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRlJoY21kbGRFWjFibU4wYVc5dVVtOXNaU2hoWkdSeVpYTnpMSFZwYm5RNFd6UmRXMTBzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRlJoY21kbGRFRmtiV2x1UkdWc1lYa29ZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFZHRnlaMlYwUTJ4dmMyVmtLR0ZrWkhKbGMzTXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSVFkyaGxaSFZzWlNoaWVYUmxXek15WFNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRFNXZibU5sS0dKNWRHVmJNekpkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpYzJOb1pXUjFiR1VvWVdSa2NtVnpjeXhpZVhSbFcxMHNkV2x1ZERZMEtTaGllWFJsV3pNeVhTeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSmxlR1ZqZFhSbEtHRmtaSEpsYzNNc1lubDBaVnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWTJGdVkyVnNLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGllWFJsVzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKamIyNXpkVzFsVTJOb1pXUjFiR1ZrVDNBb1lXUmtjbVZ6Y3l4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlhR0Z6YUU5d1pYSmhkR2x2YmloaFpHUnlaWE56TEdGa1pISmxjM01zWW5sMFpWdGRLV0o1ZEdWYk16SmRJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVkJkWFJvYjNKcGRIa29ZV1JrY21WemN5eGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW0xMWJIUnBZMkZzYkNoaWVYUmxXMTFiWFNsaWVYUmxXMTFiWFNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWDE5d2IzTjBTVzVwZEY5eWIzVjBaVUEzSUcxaGFXNWZaMlYwVW05c1pWOXliM1YwWlVBNElHMWhhVzVmWjJWMFVtOXNaVU52ZFc1MFgzSnZkWFJsUURrZ2JXRnBibDluWlhSU2IyeGxjMTl5YjNWMFpVQXhNQ0J0WVdsdVgyZGxkRUZrYldsdVVtOXNaVjl5YjNWMFpVQXhNU0J0WVdsdVgyZGxkRUZrYldsdVVtOXNaVU52ZFc1MFgzSnZkWFJsUURFeUlHMWhhVzVmWjJWMFFXUnRhVzVTYjJ4bGMxOXliM1YwWlVBeE15QnRZV2x1WDJkbGRGSnZiR1ZOWlcxaVpYSmZjbTkxZEdWQU1UUWdiV0ZwYmw5blpYUlNiMnhsVFdWdFltVnlRMjkxYm5SZmNtOTFkR1ZBTVRVZ2JXRnBibDluWlhSU2IyeGxUV1Z0WW1WeWMxOXliM1YwWlVBeE5pQnRZV2x1WDJkbGRGSnZiR1ZQWmtGa2JXbHVVbTlzWlY5eWIzVjBaVUF4TnlCdFlXbHVYMmRsZEZKdmJHVlBaa0ZrYldsdVVtOXNaVU52ZFc1MFgzSnZkWFJsUURFNElHMWhhVzVmWjJWMFVtOXNaWE5QWmtGa2JXbHVVbTlzWlY5eWIzVjBaVUF4T1NCdFlXbHVYMmRsZEZKdmJHVlVZWEpuWlhSZmNtOTFkR1ZBTWpBZ2JXRnBibDluWlhSU2IyeGxWR0Z5WjJWMFEyOTFiblJmY205MWRHVkFNakVnYldGcGJsOW5aWFJTYjJ4bFZHRnlaMlYwYzE5eWIzVjBaVUF5TWlCdFlXbHVYMmRsZEZKdmJHVlVZWEpuWlhSVFpXeGxZM1J2Y2w5eWIzVjBaVUF5TXlCdFlXbHVYMmRsZEZKdmJHVlVZWEpuWlhSVFpXeGxZM1J2Y2tOdmRXNTBYM0p2ZFhSbFFESTBJRzFoYVc1ZloyVjBVbTlzWlZSaGNtZGxkRk5sYkdWamRHOXljMTl5YjNWMFpVQXlOU0J0WVdsdVgwRkVUVWxPWDFKUFRFVmZjbTkxZEdWQU1qWWdiV0ZwYmw5QlJFMUpUbDlTVDB4RlgzSnZkWFJsUURJMklHMWhhVzVmWTJGdVEyRnNiRjl5YjNWMFpVQXlPQ0J0WVdsdVgwRkVUVWxPWDFKUFRFVmZjbTkxZEdWQU1qWWdiV0ZwYmw5QlJFMUpUbDlTVDB4RlgzSnZkWFJsUURJMklHMWhhVzVmYVhOVVlYSm5aWFJEYkc5elpXUmZjbTkxZEdWQU16RWdiV0ZwYmw5blpYUlVZWEpuWlhSR2RXNWpkR2x2YmxKdmJHVmZjbTkxZEdWQU16SWdiV0ZwYmw5blpYUlVZWEpuWlhSQlpHMXBia1JsYkdGNVgzSnZkWFJsUURNeklHMWhhVzVmWjJWMFVtOXNaVUZrYldsdVgzSnZkWFJsUURNMElHMWhhVzVmWjJWMFVtOXNaVUZrYldsdVgzSnZkWFJsUURNMElHMWhhVzVmWjJWMFVtOXNaVUZrYldsdVgzSnZkWFJsUURNMElHMWhhVzVmWjJWMFFXTmpaWE56WDNKdmRYUmxRRE0zSUcxaGFXNWZhR0Z6VW05c1pWOXliM1YwWlVBek9DQnRZV2x1WDJ4aFltVnNVbTlzWlY5eWIzVjBaVUF6T1NCdFlXbHVYMmR5WVc1MFVtOXNaVjl5YjNWMFpVQTBNQ0J0WVdsdVgzSmxkbTlyWlZKdmJHVmZjbTkxZEdWQU5ERWdiV0ZwYmw5eVpYWnZhMlZTYjJ4bFgzSnZkWFJsUURReElHMWhhVzVmYzJWMFVtOXNaVUZrYldsdVgzSnZkWFJsUURReklHMWhhVzVmYzJWMFVtOXNaVUZrYldsdVgzSnZkWFJsUURReklHMWhhVzVmYzJWMFVtOXNaVUZrYldsdVgzSnZkWFJsUURReklHMWhhVzVmYzJWMFZHRnlaMlYwUm5WdVkzUnBiMjVTYjJ4bFgzSnZkWFJsUURRMklHMWhhVzVmYzJWMFZHRnlaMlYwUVdSdGFXNUVaV3hoZVY5eWIzVjBaVUEwTnlCdFlXbHVYM05sZEZSaGNtZGxkRU5zYjNObFpGOXliM1YwWlVBME9DQnRZV2x1WDJkbGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhsZmNtOTFkR1ZBTXpNZ2JXRnBibDluWlhSVVlYSm5aWFJCWkcxcGJrUmxiR0Y1WDNKdmRYUmxRRE16SUcxaGFXNWZjMk5vWldSMWJHVmZjbTkxZEdWQU5URWdiV0ZwYmw5bGVHVmpkWFJsWDNKdmRYUmxRRFV5SUcxaGFXNWZZMkZ1WTJWc1gzSnZkWFJsUURVeklHMWhhVzVmWTI5dWMzVnRaVk5qYUdWa2RXeGxaRTl3WDNKdmRYUmxRRFUwSUcxaGFXNWZhR0Z6YUU5d1pYSmhkR2x2Ymw5eWIzVjBaVUExTlNCdFlXbHVYM1Z3WkdGMFpVRjFkR2h2Y21sMGVWOXliM1YwWlVBMU5pQnRZV2x1WDIxMWJIUnBZMkZzYkY5eWIzVjBaVUExTndvZ0lDQWdaWEp5Q2dwdFlXbHVYMjExYkhScFkyRnNiRjl5YjNWMFpVQTFOem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDb0tJQ0FnSUdKMWNua2dNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdKMWNua2dNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKMWNua2dOUW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdKMWNua2dNd29LYldGcGJsOW1iM0pmYUdWaFpHVnlRRFl5T2dvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBMENpQWdJQ0E4Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJadmNrQTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTmdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTFDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdabTl5SUNoc1pXNHJLR3hsYml0MWFXNTBPRnRkS1Z0ZEtRb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWW5WeWVTQXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JpSUcxaGFXNWZabTl5WDJobFlXUmxja0EyTWdvS2JXRnBibDloWm5SbGNsOW1iM0pBTmpRNkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQajRLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzVndaR0YwWlVGMWRHaHZjbWwwZVY5eWIzVjBaVUExTmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYUdGemFFOXdaWEpoZEdsdmJsOXliM1YwWlVBMU5Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnZibk4xYldWVFkyaGxaSFZzWldSUGNGOXliM1YwWlVBMU5Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMkZ1WTJWc1gzSnZkWFJsUURVek9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJWNFpXTjFkR1ZmY205MWRHVkFOVEk2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjMk5vWldSMWJHVmZjbTkxZEdWQU5URTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZSaGNtZGxkRUZrYldsdVJHVnNZWGxmY205MWRHVkFNek02Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmMyVjBWR0Z5WjJWMFEyeHZjMlZrWDNKdmRYUmxRRFE0T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhsZmNtOTFkR1ZBTkRjNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaWFJVWVhKblpYUkdkVzVqZEdsdmJsSnZiR1ZmY205MWRHVkFORFk2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dORDQrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUlNiMnhsUVdSdGFXNWZjbTkxZEdWQU5ETTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNtVjJiMnRsVW05c1pWOXliM1YwWlVBME1Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmR5WVc1MFVtOXNaVjl5YjNWMFpVQTBNRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXNZV0psYkZKdmJHVmZjbTkxZEdWQU16azZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5b1lYTlNiMnhsWDNKdmRYUmxRRE00T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRFRmpZMlZ6YzE5eWIzVjBaVUF6TnpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsUVdSdGFXNWZjbTkxZEdWQU16UTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRlJoY21kbGRFWjFibU4wYVc5dVVtOXNaVjl5YjNWMFpVQXpNam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBMFBnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmx6VkdGeVoyVjBRMnh2YzJWa1gzSnZkWFJsUURNeE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDBGRVRVbE9YMUpQVEVWZmNtOTFkR1ZBTWpZNkNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMkZ1UTJGc2JGOXliM1YwWlVBeU9Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0EwUGdvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVW05c1pWUmhjbWRsZEZObGJHVmpkRzl5YzE5eWIzVjBaVUF5TlRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGSnZiR1ZVWVhKblpYUlRaV3hsWTNSdmNrTnZkVzUwWDNKdmRYUmxRREkwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGSnZiR1ZVWVhKblpYUlRaV3hsWTNSdmNsOXliM1YwWlVBeU16b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsVkdGeVoyVjBjMTl5YjNWMFpVQXlNam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVazlUWDAxQlNVNWZRVkJRWDBsRUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKZlgyOW5YM1poYkhWbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWDNKdmJHVlViMVJoY21kbGRGTmxkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREl3TURBME1EQXdOakF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnUlc1MWJXVnlZV0pzWlZObGRDNTJZV3gxWlhNS0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSU2IyeGxWR0Z5WjJWMFEyOTFiblJmY205MWRHVkFNakU2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVazlUWDAxQlNVNWZRVkJRWDBsRUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKZlgyOW5YM1poYkhWbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JwZEc5aUNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lsOXliMnhsVkc5VVlYSm5aWFJUWlhRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBeU1EQXdOREF3TURZd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCallXeHNjM1ZpSUVWdWRXMWxjbUZpYkdWVFpYUXViR1Z1WjNSb0NpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZKdmJHVlVZWEpuWlhSZmNtOTFkR1ZBTWpBNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlNUMU5mVFVGSlRsOUJVRkJmU1VRS0lDQWdJR0o1ZEdWalh6TWdMeThnSWw5ZmIyZGZkbUZzZFdVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVgzSnZiR1ZVYjFSaGNtZGxkRk5sZENJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURJd01EQTBNREF3TmpBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnUlc1MWJXVnlZV0pzWlZObGRDNWhkQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkp2YkdWelQyWkJaRzFwYmxKdmJHVmZjbTkxZEdWQU1UazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOVEV5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJTYjJ4bFQyWkJaRzFwYmxKdmJHVkRiM1Z1ZEY5eWIzVjBaVUF4T0RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsVDJaQlpHMXBibEp2YkdWZmNtOTFkR1ZBTVRjNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZKdmJHVk5aVzFpWlhKelgzSnZkWFJsUURFMk9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lHbHVkR01nTkNBdkx5QlVUVkJNWDFWU1QxTmZUVUZKVGw5QlVGQmZTVVFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbDlmYjJkZmRtRnNkV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUEySUM4dklDSmZjbTlzWlUxbGJXSmxjbE5sZENJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURJd01EQTBNREF3TmpBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1JXNTFiV1Z5WVdKc1pWTmxkQzUyWVd4MVpYTUtJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsVFdWdFltVnlRMjkxYm5SZmNtOTFkR1ZBTVRVNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpJRFFnTHk4Z1ZFMVFURjlWVWs5VFgwMUJTVTVmUVZCUVgwbEVDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmZYMjluWDNaaGJIVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCcGRHOWlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbDl5YjJ4bFRXVnRZbVZ5VTJWMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01qQXdNRFF3TURBMk1EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBMbXhsYm1kMGFBb2dJQ0FnY0c5d0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSU2IyeGxUV1Z0WW1WeVgzSnZkWFJsUURFME9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVazlUWDAxQlNVNWZRVkJRWDBsRUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKZlgyOW5YM1poYkhWbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lsOXliMnhsVFdWdFltVnlVMlYwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TWpBd01EUXdNREEyTURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJGYm5WdFpYSmhZbXhsVTJWMExtRjBDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBRV1J0YVc1U2IyeGxjMTl5YjNWMFpVQXhNem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREVXhNZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBRV1J0YVc1U2IyeGxRMjkxYm5SZmNtOTFkR1ZBTVRJNkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSQlpHMXBibEp2YkdWZmNtOTFkR1ZBTVRFNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVbTlzWlhOZmNtOTFkR1ZBTVRBNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5URXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOVEV5Q2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlVrOVRYMDFCU1U1ZlFWQlFYMGxFQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pmWDI5blgzWmhiSFZsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pmY205c1pYTlRaWFFpQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNakF3TURRd01EQTJNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBMblpoYkhWbGN5Z3pLVjh5Q2lBZ0lDQndiM0FLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNiMnhsUTI5MWJuUmZjbTkxZEdWQU9Ub0tJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZTVDFOZlRVRkpUbDlCVUZCZlNVUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lsOWZiMmRmZG1Gc2RXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lsOXliMnhsYzFObGRDSUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBeU1EQXdOREF3TURZd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrVnVkVzFsY21GaWJHVlRaWFF1YkdWdVozUm9LREVwWHpJS0lDQWdJSEJ2Y0FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVW05c1pWOXliM1YwWlVBNE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlVrOVRYMDFCU1U1ZlFWQlFYMGxFQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pmWDI5blgzWmhiSFZsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbDl5YjJ4bGMxTmxkQ0lLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXlNREF3TkRBd01EWXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVGYm5WdFpYSmhZbXhsVTJWMExtRjBLRElwWHpJS0lDQWdJSEJ2Y0FvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVgzSnZiR1Z6VTJWMElnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURJd01EQTBNREF3TmpBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVGYm5WdFpYSmhZbXhsVTJWMExtRjBLRElwWHpJS0lDQWdJSEJ2Y0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5ZlgzQnZjM1JKYm1sMFgzSnZkWFJsUURjNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZlpHVnNaV2RoZEdWZmRYQmtZWFJsWDNKdmRYUmxRRFE2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1ZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrVnVkVzFsY21GaWJHVlRaWFF1WDJ4bGJtZDBhQ2h6WlhRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE02Q2tWdWRXMWxjbUZpYkdWVFpYUXVYMnhsYm1kMGFEb0tJQ0FnSUhCeWIzUnZJREVnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVGYm5WdFpYSmhZbXhsVTJWMExsOWhkQ2h6WlhRNklHSjVkR1Z6TENCcGJtUmxlRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpMQ0JpZVhSbGN6b0tSVzUxYldWeVlXSnNaVk5sZEM1ZllYUTZDaUFnSUNCd2NtOTBieUF5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVJXNTFiV1Z5WVdKc1pWTmxkQzVmZG1Gc2RXVnpLRE1wS0hObGREb2dZbmwwWlhNc0lITjBZWEowT2lCaWVYUmxjeXdnWlc1a09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6T2dwRmJuVnRaWEpoWW14bFUyVjBMbDkyWVd4MVpYTTZDaUFnSUNCd2NtOTBieUF6SURJS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBMbDlzWlc1bmRHZ0tJQ0FnSUdaeVlXMWxYMkoxY25rZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJOWVhSb0xtMXBiZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnVFdGMGFDNXRhVzRLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtDa1Z1ZFcxbGNtRmliR1ZUWlhRdVgzWmhiSFZsYzE5M2FHbHNaVjkwYjNCQU16b0tJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0ErQ2lBZ0lDQmllaUJGYm5WdFpYSmhZbXhsVTJWMExsOTJZV3gxWlhOZllXWjBaWEpmZDJocGJHVkFOUW9nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEVUtJQ0FnSUdJZ1JXNTFiV1Z5WVdKc1pWTmxkQzVmZG1Gc2RXVnpYM2RvYVd4bFgzUnZjRUF6Q2dwRmJuVnRaWEpoWW14bFUyVjBMbDkyWVd4MVpYTmZZV1owWlhKZmQyaHBiR1ZBTlRvS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ2tWdWRXMWxjbUZpYkdWVFpYUXVYM1poYkhWbGMxOTNhR2xzWlY5MGIzQkFOam9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWWp3S0lDQWdJR0o2SUVWdWRXMWxjbUZpYkdWVFpYUXVYM1poYkhWbGMxOWhablJsY2w5M2FHbHNaVUE0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURFS0lDQWdJR0lyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHSWdSVzUxYldWeVlXSnNaVk5sZEM1ZmRtRnNkV1Z6WDNkb2FXeGxYM1J2Y0VBMkNncEZiblZ0WlhKaFlteGxVMlYwTGw5MllXeDFaWE5mWVdaMFpYSmZkMmhwYkdWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBMbXhsYm1kMGFDZ3hLVjh4S0hObGREb2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3pvS1JXNTFiV1Z5WVdKc1pWTmxkQzVzWlc1bmRHZzZDaUFnSUNCd2NtOTBieUF4SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCallXeHNjM1ZpSUVWdWRXMWxjbUZpYkdWVFpYUXVYMnhsYm1kMGFBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrVnVkVzFsY21GaWJHVlRaWFF1WVhRb01pbGZNU2h6WlhRNklHSjVkR1Z6TENCcGJtUmxlRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpMQ0JpZVhSbGN6b0tSVzUxYldWeVlXSnNaVk5sZEM1aGREb0tJQ0FnSUhCeWIzUnZJRElnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRVZ1ZFcxbGNtRmliR1ZUWlhRdVgyRjBDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwTGw5aGRBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHSW1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVJXNTFiV1Z5WVdKc1pWTmxkQzUyWVd4MVpYTW9NeWxmTVNoelpYUTZJR0o1ZEdWekxDQnpkR0Z5ZERvZ1lubDBaWE1zSUdWdVpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3pvS1JXNTFiV1Z5WVdKc1pWTmxkQzUyWVd4MVpYTTZDaUFnSUNCd2NtOTBieUF6SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJGYm5WdFpYSmhZbXhsVTJWMExsOTJZV3gxWlhNS0lDQWdJSEJ2Y0FvZ0lDQWdiRzloWkNBd0NpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhRdWJHVnVaM1JvS0RFcFh6SW9jMlYwT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE1zSUdKNWRHVnpPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBMbXhsYm1kMGFDZ3hLVjh5T2dvZ0lDQWdjSEp2ZEc4Z01TQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwTGw5c1pXNW5kR2dLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVGYm5WdFpYSmhZbXhsVTJWMExtRjBLRElwWHpJb2MyVjBPaUJpZVhSbGN5d2dhVzVrWlhnNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE02Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrVnVkVzFsY21GaWJHVlRaWFF1WVhRb01pbGZNam9LSUNBZ0lIQnliM1J2SURJZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBMbDloZEFvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtWdWRXMWxjbUZpYkdWVFpYUXVkbUZzZFdWektETXBYeklvYzJWME9pQmllWFJsY3l3Z2MzUmhjblE2SUdKNWRHVnpMQ0JsYm1RNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE02Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrVnVkVzFsY21GaWJHVlRaWFF1ZG1Gc2RXVnpLRE1wWHpJNkNpQWdJQ0J3Y205MGJ5QXpJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUd4bGJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwTGw5MllXeDFaWE1LSUNBZ0lIQnZjQW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrMWhkR2d1ZEdWeWJtRnllU2hqYjI1a2FYUnBiMjQ2SUhWcGJuUTJOQ3dnWVRvZ1lubDBaWE1zSUdJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1RXRjBhQzUwWlhKdVlYSjVPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbDRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxRMkZ6ZEM1MGIxVnBiblFLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaVhnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VUV0YwYUM1dGFXNG9ZVG9nWW5sMFpYTXNJR0k2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LVFdGMGFDNXRhVzQ2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpUEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1RXRjBhQzUwWlhKdVlYSjVDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVUWVdabFEyRnpkQzUwYjFWcGJuUW9Zam9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LVTJGbVpVTmhjM1F1ZEc5VmFXNTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JzYjJGa0lEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnSVFvZ0lDQWdJUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlQ0F3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjM2RoY0FvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzVqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRkFTQUlBQUFtQ3dRVkgzeDFDZ0FDQUFRQUJnQUFBQUFNRlI5OGRRQUFBQUFBQUFBQUNsOWZiMmRmZG1Gc2RXVUpYM0p2YkdWelUyVjBFRjl5YjJ4bFZHOVVZWEpuWlhSVFpYUU9YM0p2YkdWTlpXMWlaWEpUWlhRaEFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRFJVZmZIVUFBQUFBQUFBQUFBQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBVS8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vOGxnQUJIQTRHQUlLOUpOUVUxQURRQWdDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBZ0Z4QU5RQXhHRUFBRklBT1gxOWpkRzl5WDNCbGJtUnBibWNpWnlKRGdBVGNYamVZTmhvQWpnRUYvakVaRkVReEdFU0NNd1NaRHpDdUJNL0ZtQXdFVUU3L0FnVFRWV1RWQkl4R1JGMEVpK01zWmdROFhhMUtCSk0vdTJvRVRQakxMZ1JoYUJCa0JNL0VtSmdFNUdnZ1VnUmE4TDBuQlBjM3JQZ0VvQXYwTUFRQ25ScUVCTnZ3amhBRXZ6MXZxd1JNQlBQWUJHM0RBd1VFdjJOMld3VFFlV1F4Qko2cVZ6b0V6L0xtSVFUVVJBOVhCSWZWUlFzRUxBck5nUVRhZFFzakJCUHBLSVlFUGJ4dFF3U1E5WTUxQlBFR1o1a0VpUnczU2dURTNoY0xCUEdLZzZnRXRSSlZYQVF0OENvbkJDaEUyNTRFTkVyL1FBVFphNHA5QkFidHd5NEV4dFVWTGdTc25Mb09CSVhUZ3VFRUtqTE4wUVE3WEtDR0JDeURadGdFWnByQVN3UUVsUndwQk4yWUtOVUVCSkdhSmpZYUFJNHpCSUlFUkFRa0EvUUQ2UVBsQTlFRG9nTjFBendES2dNZkF3UUMxUUtvQW04Q1ZnSkVBaUlDQXdJREFnY0NBd0lEQWZJQjN3RHlBZFFCMUFIVUFaMEJpZ0YwQVYwQlRRRk5BVDBCUFFFOUFSMEJEUUQ5QVBJQThnRFRBTHNBbkFDR0FHY0FWd0FCQURZYUFVa2xXVWxGQm9FQ0MwVURTUlZGQWxjQ0FFVUZKVVVEU3dKTEJBeEJBQ2RMQWttQkFndExCa2xQQWxsSlN3VkpUZ1FTUkVzQkZWSWxXWUVDQ0FoRkF5SUlSUU5DLzlGTEFZRUNDRXNCRWtRb3NDSkROaG9CRlNNU1JEWWFBaFVqRWtRaVF6WWFBUlVqRWtRMkdnSVZJeEpFTmhvRFNTVlpnUUlJVEJVU1JDaXdJa00yR2dFVkl4SkVOaG9DU1NWWmdRSUlUQlVTUkNKRE5ob0JGU01TUkRZYUFoVWpFa1EyR2dOSkpWbUJBZ2hNRlJKRUtyQWlRellhQVJVakVrUTJHZ0pKSlZtQkFnaE1GUkpFS3JBaVF6WWFBUlVqRWtRMkdnSkpKVm1CQWdoTUZSSkVOaG9ERlNRU1JDcXdJa00yR2dFVkl4SkVLckFpUXpZYUFSVWpFa1EyR2dJVkloSkVJa00yR2dFVkl4SkVOaG9DRlNRU1JDSkROaG9CRlNNU1JEWWFBa2tsV1lFRUM0RUNDRXdWRWtRMkdnTVZKQkpFSWtNMkdnRVZKQkpFTmhvQ0ZTUVNSQ0pETmhvQkZTUVNSRFlhQWhVakVrUWlRellhQVJVa0VrUTJHZ0lWSXhKRU5ob0RGU1FTUkNKRE5ob0JGU1FTUkRZYUFra2xXWUVDQ0V3VkVrUWlRellhQVJVa0VrUTJHZ0lWSXhKRUp3aXdJa00yR2dFVkpCSkVOaG9DRlNNU1JJQWtGUjk4ZFFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFzQ0pETmhvQkZTUVNSQ3F3SWtNMkdnRVZJeEpFTmhvQ0ZZRUVFa1Fxc0NKRE5ob0JGU01TUklBRkZSOThkUUN3SWtNcXNDSkROaG9CRlNNU1JEWWFBaFVqRWtRMkdnTVZnUVFTUkNjSXNDSkROaG9CRlNRU1JEWWFBaFVqRWtRMkdnTVZnVUFTUkRZYUJCV0JRQkpFS0xBaVF6WWFBUlVrRWtRMkdnSVZJeEpFS0xBaVF6WWFBUlVrRWtRMkdnSVZJeEpFTmhvREZTTVNSQ2l3SWtNMkdnRkpGU1FTUkJjMkdnSkpGU01TUkRZYUEwa1ZJeEpFSVFRclpVZ1VSRThDRmdFbkJVeFF2aWxPQWsxT0FvZ0RFRWdvVEZDd0lrTTJHZ0ZKRlNRU1JCY2hCQ3RsU0JSRUZnRW5CVXhRdmlsT0FrMklBcUJJU1JVakRrUWpyNnNvVEZDd0lrTTJHZ0ZKRlNRU1JCYzJHZ0pKRlNNU1JDRUVLMlZJRkVSTUZnRW5CVXhRdmlsT0FrMU1pQUovU0NoTVVMQWlRellhQVJVa0VrUTJHZ0lWZ1VBU1JEWWFBeFdCUUJKRUtMQWlRellhQVJVa0VrUW9zQ0pETmhvQkZTUVNSRFlhQWhVakVrUXFzQ0pETmhvQlNSVWtFa1FYTmhvQ1NSVWpFa1EyR2dOSkZTTVNSQ0VFSzJWSUZFUlBBaFlCSndaTVVMNHBUZ0pOVGdLSUFrTklLRXhRc0NKRE5ob0JTUlVrRWtRWElRUXJaVWdVUkJZQkp3Wk1VTDRwVGdKTmlBSFRTRWtWSXc1RUk2K3JLRXhRc0NKRE5ob0JTUlVrRWtRWE5ob0NTUlVqRWtRaEJDdGxTQlJFVEJZQkp3Wk1VTDRwVGdKTlRJZ0Jza2dvVEZDd0lrTTJHZ0VWZ1VBU1JEWWFBaFdCUUJKRUtMQWlReWl3SWtNMkdnRVZJeEpFS3JBaVF6WWFBVWtWZ1VBU1JEWWFBa2tWZ1VBU1JDRUVLMlZJRkVRbkJMNHBUZ0pOVGdLSUFlUklOQUExQUNoTVVMQWlReUVFSzJWSUZFUW5CTDRwVGdKTmlBR2FTRWtWSXc1RUk2K3JLRXhRc0NKRE5ob0JTUlVqRWtRaEJDdGxTQlJFSks4bkJMNHBUZ0pOU3dLSUFZUklTd0ZNVUNjRXZpbE9BazFQQTRnQmMwaFBBa3hRRlNRSkpGZ29URkN3SWtNMkdnRVZJeEpFSWtNeEdZRUVFakVZRUVPS0FRS0wveVZaaS8rQkFsbUwvMDRDVWlWWkZvdi9pWW9DQWlTdmkvOVFTUlVrQ1Z1TC9pVlppLzZCQWxtTC9rNENVbGNDQUV3akN5TllpLzZKaWdNQ0pVbUwvWWovdVl6OWkvOU1pQUZOalArTC9vdi9pQUZFalA2TC95Y0hvSXYrb1NjSHFpVVdnQUlBQUNVa3IwbU1BWXNDVUVrVkpBbGJpd1VOUVFBYml3UkpKVmtpQ0JaWEJnQmNBQ2NKVUl3RWl3VWlDSXdGUXYvU2l3U01BSXNEaXdLa1FRQWppd0dMQTBsT0FsQkpGU1FKV3lNTGdRSUlpd0JNSndsZGpBQ0FBUUdnakFOQy85V0xBSXY5akFHTUFJbUtBUUtML3lWWmkvOFZpLzlPQWxLSS94eElpLytKaWdJQ0k2K0wvaVZaaS80VmkvNU9BbEpKaS8rSS94aElKd3FzU3dKTVVFeUwvNGovQ2tnbkNxeFBBa3hRRlNNSkkxaUwvb21LQXdLTC9TVlppLzBWaS8xT0FsS0wvb3YvaVA4S1NEUUFOUUNML1ltS0FRS0wveVZaaS84VmkvOU9BbEtJL3JOSWkvK0ppZ0lDaS80bFdZditGWXYrVGdKU2kvK0kvckpJaS82SmlnTUNpLzBsV1l2OUZZdjlUZ0pTaS82TC80ait2a2cwQURVQWkvMkppZ01CaS82TC82MkwvWWdBR0tNbkI2cUwvNjJKaWdJQmkvNkwvNlNML292L2lQL2NpWW9CQVRRQWkvOFVGSUlDQUFFQlR3Sk5URFVBaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlVST1NfTUFJTl9BUFBfSUQiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjoiQUFBQUFBQUFBQUE9In19LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
