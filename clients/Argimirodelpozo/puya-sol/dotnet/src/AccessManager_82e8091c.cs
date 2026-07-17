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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.AccessManager_82e8091c
{


    //
    //  @dev AccessManager is a central contract to store the permissions of a system.
    // A smart contract under the control of an AccessManager instance is known as a target, and will inherit from the
    // {AccessManaged} contract, be connected to this contract as its manager and implement the {AccessManaged-restricted}
    // modifier on a set of functions selected to be permissioned. Note that any function without this setup won't be
    // effectively restricted.
    // The restriction rules for such functions are defined in terms of "roles" identified by an `uint64` and scoped
    // by target (`address`) and function selectors (`bytes4`). These roles are stored in this contract and can be
    // configured by admins (`ADMIN_ROLE` members) after a delay (see {getTargetAdminDelay}).
    // For each target contract, admins can configure the following without any delay:
    // * The target's {AccessManaged-authority} via {updateAuthority}.
    // * Close or open a target via {setTargetClosed} keeping the permissions intact.
    // * The roles that are allowed (or disallowed) to call a given function (identified by its selector) through {setTargetFunctionRole}.
    // By default every address is member of the `PUBLIC_ROLE` and every target function is restricted to the `ADMIN_ROLE` until configured otherwise.
    // Additionally, each role has the following configuration options restricted to this manager's admins:
    // * A role's admin role via {setRoleAdmin} who can grant or revoke roles.
    // * A role's guardian role via {setRoleGuardian} who's allowed to cancel operations.
    // * A delay in which a role takes effect after being granted through {setGrantDelay}.
    // * A delay of any target's admin action via {setTargetAdminDelay}.
    // * A role label for discoverability purposes with {labelRole}.
    // Any account can be added and removed into any number of these roles by using the {grantRole} and {revokeRole} functions
    // restricted to each role's admin (see {getRoleAdmin}).
    // Since all the permissions of the managed system can be modified by the admins of this instance, it is expected that
    // they will be highly secured (e.g., a multisig or a well-configured DAO).
    // NOTE: This contract implements a form of the {IAuthority} interface, but {canCall} has additional return data so it
    // doesn't inherit `IAuthority`. It is however compatible with the `IAuthority` interface since the first 32 bytes of
    // the return data are a boolean as expected by that interface.
    // NOTE: Systems that implement other access control mechanisms (for example using {Ownable}) can be paired with an
    // {AccessManager} by transferring permissions (ownership in the case of {Ownable}) directly to the {AccessManager}.
    // Users will be able to interact with these contracts through the {execute} function, following the access rules
    // registered in the {AccessManager}. Keep in mind that in that context, the msg.sender seen by restricted functions
    // will be {AccessManager} itself.
    // WARNING: When granting permissions over an {Ownable} or {AccessControl} contract to an {AccessManager}, be very
    // mindful of the danger associated with functions such as {Ownable-renounceOwnership} or
    // {AccessControl-renounceRole}.
    //
    public class AccessManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AccessManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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
        /// <param name="initialAdmin"> </param>
        public async Task PostInit(Algorand.Address initialAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 15, 48, 174 };
            var initialAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); initialAdminAbi.From(initialAdmin);

            var result = await base.CallApp(new List<object> { abiHandle, initialAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Algorand.Address initialAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 15, 48, 174 };
            var initialAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); initialAdminAbi.From(initialAdmin);

            return await base.MakeTransactionList(new List<object> { abiHandle, initialAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWNjZXNzTWFuYWdlciIsImRlc2MiOiIgQGRldiBBY2Nlc3NNYW5hZ2VyIGlzIGEgY2VudHJhbCBjb250cmFjdCB0byBzdG9yZSB0aGUgcGVybWlzc2lvbnMgb2YgYSBzeXN0ZW0uXG4gQSBzbWFydCBjb250cmFjdCB1bmRlciB0aGUgY29udHJvbCBvZiBhbiBBY2Nlc3NNYW5hZ2VyIGluc3RhbmNlIGlzIGtub3duIGFzIGEgdGFyZ2V0LCBhbmQgd2lsbCBpbmhlcml0IGZyb20gdGhlXG4ge0FjY2Vzc01hbmFnZWR9IGNvbnRyYWN0LCBiZSBjb25uZWN0ZWQgdG8gdGhpcyBjb250cmFjdCBhcyBpdHMgbWFuYWdlciBhbmQgaW1wbGVtZW50IHRoZSB7QWNjZXNzTWFuYWdlZC1yZXN0cmljdGVkfVxuIG1vZGlmaWVyIG9uIGEgc2V0IG9mIGZ1bmN0aW9ucyBzZWxlY3RlZCB0byBiZSBwZXJtaXNzaW9uZWQuIE5vdGUgdGhhdCBhbnkgZnVuY3Rpb24gd2l0aG91dCB0aGlzIHNldHVwIHdvbid0IGJlXG4gZWZmZWN0aXZlbHkgcmVzdHJpY3RlZC5cbiBUaGUgcmVzdHJpY3Rpb24gcnVsZXMgZm9yIHN1Y2ggZnVuY3Rpb25zIGFyZSBkZWZpbmVkIGluIHRlcm1zIG9mIFwicm9sZXNcIiBpZGVudGlmaWVkIGJ5IGFuIGB1aW50NjRgIGFuZCBzY29wZWRcbiBieSB0YXJnZXQgKGBhZGRyZXNzYCkgYW5kIGZ1bmN0aW9uIHNlbGVjdG9ycyAoYGJ5dGVzNGApLiBUaGVzZSByb2xlcyBhcmUgc3RvcmVkIGluIHRoaXMgY29udHJhY3QgYW5kIGNhbiBiZVxuIGNvbmZpZ3VyZWQgYnkgYWRtaW5zIChgQURNSU5fUk9MRWAgbWVtYmVycykgYWZ0ZXIgYSBkZWxheSAoc2VlIHtnZXRUYXJnZXRBZG1pbkRlbGF5fSkuXG4gRm9yIGVhY2ggdGFyZ2V0IGNvbnRyYWN0LCBhZG1pbnMgY2FuIGNvbmZpZ3VyZSB0aGUgZm9sbG93aW5nIHdpdGhvdXQgYW55IGRlbGF5OlxuICogVGhlIHRhcmdldCdzIHtBY2Nlc3NNYW5hZ2VkLWF1dGhvcml0eX0gdmlhIHt1cGRhdGVBdXRob3JpdHl9LlxuICogQ2xvc2Ugb3Igb3BlbiBhIHRhcmdldCB2aWEge3NldFRhcmdldENsb3NlZH0ga2VlcGluZyB0aGUgcGVybWlzc2lvbnMgaW50YWN0LlxuICogVGhlIHJvbGVzIHRoYXQgYXJlIGFsbG93ZWQgKG9yIGRpc2FsbG93ZWQpIHRvIGNhbGwgYSBnaXZlbiBmdW5jdGlvbiAoaWRlbnRpZmllZCBieSBpdHMgc2VsZWN0b3IpIHRocm91Z2gge3NldFRhcmdldEZ1bmN0aW9uUm9sZX0uXG4gQnkgZGVmYXVsdCBldmVyeSBhZGRyZXNzIGlzIG1lbWJlciBvZiB0aGUgYFBVQkxJQ19ST0xFYCBhbmQgZXZlcnkgdGFyZ2V0IGZ1bmN0aW9uIGlzIHJlc3RyaWN0ZWQgdG8gdGhlIGBBRE1JTl9ST0xFYCB1bnRpbCBjb25maWd1cmVkIG90aGVyd2lzZS5cbiBBZGRpdGlvbmFsbHksIGVhY2ggcm9sZSBoYXMgdGhlIGZvbGxvd2luZyBjb25maWd1cmF0aW9uIG9wdGlvbnMgcmVzdHJpY3RlZCB0byB0aGlzIG1hbmFnZXIncyBhZG1pbnM6XG4gKiBBIHJvbGUncyBhZG1pbiByb2xlIHZpYSB7c2V0Um9sZUFkbWlufSB3aG8gY2FuIGdyYW50IG9yIHJldm9rZSByb2xlcy5cbiAqIEEgcm9sZSdzIGd1YXJkaWFuIHJvbGUgdmlhIHtzZXRSb2xlR3VhcmRpYW59IHdobydzIGFsbG93ZWQgdG8gY2FuY2VsIG9wZXJhdGlvbnMuXG4gKiBBIGRlbGF5IGluIHdoaWNoIGEgcm9sZSB0YWtlcyBlZmZlY3QgYWZ0ZXIgYmVpbmcgZ3JhbnRlZCB0aHJvdWdoIHtzZXRHcmFudERlbGF5fS5cbiAqIEEgZGVsYXkgb2YgYW55IHRhcmdldCdzIGFkbWluIGFjdGlvbiB2aWEge3NldFRhcmdldEFkbWluRGVsYXl9LlxuICogQSByb2xlIGxhYmVsIGZvciBkaXNjb3ZlcmFiaWxpdHkgcHVycG9zZXMgd2l0aCB7bGFiZWxSb2xlfS5cbiBBbnkgYWNjb3VudCBjYW4gYmUgYWRkZWQgYW5kIHJlbW92ZWQgaW50byBhbnkgbnVtYmVyIG9mIHRoZXNlIHJvbGVzIGJ5IHVzaW5nIHRoZSB7Z3JhbnRSb2xlfSBhbmQge3Jldm9rZVJvbGV9IGZ1bmN0aW9uc1xuIHJlc3RyaWN0ZWQgdG8gZWFjaCByb2xlJ3MgYWRtaW4gKHNlZSB7Z2V0Um9sZUFkbWlufSkuXG4gU2luY2UgYWxsIHRoZSBwZXJtaXNzaW9ucyBvZiB0aGUgbWFuYWdlZCBzeXN0ZW0gY2FuIGJlIG1vZGlmaWVkIGJ5IHRoZSBhZG1pbnMgb2YgdGhpcyBpbnN0YW5jZSwgaXQgaXMgZXhwZWN0ZWQgdGhhdFxuIHRoZXkgd2lsbCBiZSBoaWdobHkgc2VjdXJlZCAoZS5nLiwgYSBtdWx0aXNpZyBvciBhIHdlbGwtY29uZmlndXJlZCBEQU8pLlxuIE5PVEU6IFRoaXMgY29udHJhY3QgaW1wbGVtZW50cyBhIGZvcm0gb2YgdGhlIHtJQXV0aG9yaXR5fSBpbnRlcmZhY2UsIGJ1dCB7Y2FuQ2FsbH0gaGFzIGFkZGl0aW9uYWwgcmV0dXJuIGRhdGEgc28gaXRcbiBkb2Vzbid0IGluaGVyaXQgYElBdXRob3JpdHlgLiBJdCBpcyBob3dldmVyIGNvbXBhdGlibGUgd2l0aCB0aGUgYElBdXRob3JpdHlgIGludGVyZmFjZSBzaW5jZSB0aGUgZmlyc3QgMzIgYnl0ZXMgb2ZcbiB0aGUgcmV0dXJuIGRhdGEgYXJlIGEgYm9vbGVhbiBhcyBleHBlY3RlZCBieSB0aGF0IGludGVyZmFjZS5cbiBOT1RFOiBTeXN0ZW1zIHRoYXQgaW1wbGVtZW50IG90aGVyIGFjY2VzcyBjb250cm9sIG1lY2hhbmlzbXMgKGZvciBleGFtcGxlIHVzaW5nIHtPd25hYmxlfSkgY2FuIGJlIHBhaXJlZCB3aXRoIGFuXG4ge0FjY2Vzc01hbmFnZXJ9IGJ5IHRyYW5zZmVycmluZyBwZXJtaXNzaW9ucyAob3duZXJzaGlwIGluIHRoZSBjYXNlIG9mIHtPd25hYmxlfSkgZGlyZWN0bHkgdG8gdGhlIHtBY2Nlc3NNYW5hZ2VyfS5cbiBVc2VycyB3aWxsIGJlIGFibGUgdG8gaW50ZXJhY3Qgd2l0aCB0aGVzZSBjb250cmFjdHMgdGhyb3VnaCB0aGUge2V4ZWN1dGV9IGZ1bmN0aW9uLCBmb2xsb3dpbmcgdGhlIGFjY2VzcyBydWxlc1xuIHJlZ2lzdGVyZWQgaW4gdGhlIHtBY2Nlc3NNYW5hZ2VyfS4gS2VlcCBpbiBtaW5kIHRoYXQgaW4gdGhhdCBjb250ZXh0LCB0aGUgbXNnLnNlbmRlciBzZWVuIGJ5IHJlc3RyaWN0ZWQgZnVuY3Rpb25zXG4gd2lsbCBiZSB7QWNjZXNzTWFuYWdlcn0gaXRzZWxmLlxuIFdBUk5JTkc6IFdoZW4gZ3JhbnRpbmcgcGVybWlzc2lvbnMgb3ZlciBhbiB7T3duYWJsZX0gb3Ige0FjY2Vzc0NvbnRyb2x9IGNvbnRyYWN0IHRvIGFuIHtBY2Nlc3NNYW5hZ2VyfSwgYmUgdmVyeVxuIG1pbmRmdWwgb2YgdGhlIGRhbmdlciBhc3NvY2lhdGVkIHdpdGggZnVuY3Rpb25zIHN1Y2ggYXMge093bmFibGUtcmVub3VuY2VPd25lcnNoaXB9IG9yXG4ge0FjY2Vzc0NvbnRyb2wtcmVub3VuY2VSb2xlfS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUm9sZSI6W3sibmFtZSI6Im1lbWJlcnMiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYWRtaW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3VhcmRpYW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3JhbnREZWxheSIsInR5cGUiOiJ1aW50MTEyIn1dLCJTY2hlZHVsZSI6W3sibmFtZSI6InRpbWVwb2ludCIsInR5cGUiOiJ1aW50NDgifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MzIifV0sIlRhcmdldENvbmZpZyI6W3sibmFtZSI6ImFsbG93ZWRSb2xlcyIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJhZG1pbkRlbGF5IiwidHlwZSI6InVpbnQxMTIifSx7Im5hbWUiOiJjbG9zZWQiLCJ0eXBlIjoiYm9vbCJ9XSwiY2FuQ2FsbFJldHVybiI6W3sibmFtZSI6ImltbWVkaWF0ZSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZGVsYXkiLCJ0eXBlIjoidWludDY0In1dLCJnZXRBY2Nlc3NSZXR1cm4iOlt7Im5hbWUiOiJzaW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjdXJyZW50RGVsYXkiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGVuZGluZ0RlbGF5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVmZmVjdCIsInR5cGUiOiJ1aW50NjQifV0sImhhc1JvbGVSZXR1cm4iOlt7Im5hbWUiOiJpc01lbWJlciIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZXhlY3V0aW9uRGVsYXkiLCJ0eXBlIjoidWludDY0In1dLCJzY2hlZHVsZVJldHVybiI6W3sibmFtZSI6Im9wZXJhdGlvbklkIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoibm9uY2UiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fcG9zdEluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluaXRpYWxBZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUm9sZUdyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGF5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2luY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3TWVtYmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuQ2FsbCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsZWN0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsdWludDY0KSIsInN0cnVjdCI6ImNhbkNhbGxSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4cGlyYXRpb24iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pblNldGJhY2siLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzVGFyZ2V0Q2xvc2VkIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUYXJnZXRGdW5jdGlvblJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGVjdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUYXJnZXRBZG1pbkRlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVBZG1pbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVHdWFyZGlhbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVHcmFudERlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWNjZXNzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJnZXRBY2Nlc3NSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc1JvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQpIiwic3RydWN0IjoiaGFzUm9sZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGFiZWxSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFiZWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik9wZXJhdGlvbkV4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVMYWJlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYWJlbCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdyYW50Um9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleGVjdXRpb25EZWxheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUdyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGF5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2luY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3TWVtYmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV2b2tlUm9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlUmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVub3VuY2VSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlckNvbmZpcm1hdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUm9sZVJldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFJvbGVBZG1pbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlQWRtaW5DaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Um9sZUd1YXJkaWFuIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3VhcmRpYW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik9wZXJhdGlvbkV4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVHdWFyZGlhbkNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3VhcmRpYW4iLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRHcmFudERlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3RGVsYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik9wZXJhdGlvbkV4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVHcmFudERlbGF5Q2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VGFyZ2V0RnVuY3Rpb25Sb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4WzRdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxlY3RvcnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0RnVuY3Rpb25Sb2xlVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGVjdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VGFyZ2V0QWRtaW5EZWxheSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdEZWxheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0QWRtaW5EZWxheVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsYXkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaW5jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFRhcmdldENsb3NlZCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xvc2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJUYXJnZXRDbG9zZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsb3NlZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFNjaGVkdWxlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldE5vbmNlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNjaGVkdWxlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndoZW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbMzJdLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJzY2hlZHVsZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25TY2hlZHVsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjaGVkdWxlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuY2VsIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uQ2FuY2VsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbnN1bWVTY2hlZHVsZWRPcCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGFzaE9wZXJhdGlvbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUF1dGhvcml0eSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QXV0aG9yaXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiQURNSU5fUk9MRSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUFVCTElDX1JPTEUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im11bHRpY2FsbCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTXVsdGljYWxsIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMDIxXSwiZXJyb3JNZXNzYWdlIjoiQUJJIGJvb2wgdmFsaWRhdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NzMsMjE0NiwyMTU0LDI0MjAsMjQyOCwyOTU1LDQ2NzIsNDY4NSw1NjM1XSwiZXJyb3JNZXNzYWdlIjoiQUJJIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzkzXSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlckFscmVhZHlTY2hlZHVsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODM2XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlckJhZENvbmZpcm1hdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5ODldLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyRXhwaXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNjldLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VySW52YWxpZEluaXRpYWxBZG1pbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MzksMjU1OCwyNTY0LDI2OTgsMjcwNCwzMDMxLDMwMzYsNDY5OSw0ODUzXSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlckxvY2tlZFJvbGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTgzXSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlck5vdFJlYWR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1OSw0OTc1XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlck5vdFNjaGVkdWxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxNjddLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyVW5hdXRob3JpemVkQWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MTEsMTcwOSwxNzE4XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlclVuYXV0aG9yaXplZENhbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzk3XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlclVuYXV0aG9yaXplZENhbmNlbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNDFdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyVW5hdXRob3JpemVkQ29uc3VtZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MThdLCJlcnJvck1lc3NhZ2UiOiJBZGRyZXNzRW1wdHlDb2RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUyNF0sImVycm9yTWVzc2FnZSI6IkZhaWxlZENhbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDY5XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50QmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NDBdLCJlcnJvck1lc3NhZ2UiOiJTYWZlQ2FzdE92ZXJmbG93ZWRVaW50RG93bmNhc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzM2XSwiZXJyb3JNZXNzYWdlIjoiX19wb3N0SW5pdCBhbHJlYWR5IGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NTMsNDEwNyw1NTE4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX2V4ZWN1dGlvbklkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMzJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwMF0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg5LDc0MywxMTM3LDExNzMsMTI4NSwxNDY1LDE2MzAsMjI1MSwzMDAyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjY0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQ1LDExODEsMTI5MywxNDczLDE2MzgsMzAwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDUyLDEwNjIsMTEyMywxMTMxLDExNjcsMTI2OSwxMjc5LDE0NTksMTYyMSwxOTE1LDE5NjUsMTk4NSwyMTEyLDIyNDIsMjgxMywyODcwLDI5MjEsMzA3OCwzMTEzLDMyMDEsMzIxOSwzMjQ2LDMyODksMzI5NywzMzMyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMjgsMzMwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NTEsMjEyMCwyMjc1LDIzODMsMjM5NCwyNTIzLDI1MzYsMjY2MywyNjc2LDI4MDAsMjg1NywyOTA4LDI5MjksMjk5MCwzMDY5LDMxMDQsMzE0NCwzMTYzLDMxODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3VpbnQ4W10pW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzc4LDk4NywxMDIxLDEwNzUsMTE5OSwxMzExLDE2NjcsMTkyOCwyMDEzLDIxMzYsMjI5MSwyNDEwLDI1NDksMjY4OSwyODI2LDI4ODMsMjk0NSwzMDIyLDQwNjYsNDE4NCw0MjA2LDQyMzEsNDI3Nyw0MzEzLDQzNTYsNDM5NCw0NDMyLDQ0NzYsNDU5Myw0OTE0LDUwMzldLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MDYsMTgyNywxODQyLDM5MDgsMzk0OSw0NzM0LDQ3NDUsNDc1OCw1NjUzXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjg3XSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlMbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRE15SURnZ05ESTVORGsyTnpJNU5TQXlPREUwTnpRNU56WTNNVEEyTlRVZ01UZzBORFkzTkRRd056TTNNRGsxTlRFMk1UVUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05TQXdlQ0F3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0lEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUNBaVgzSnZiR1Z6SWlBd2VEQXdNakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SUNKZmMyTm9aV1IxYkdWeklpQWlYMlY0WldOMWRHbHZia2xrSWlBaVgzUmhjbWRsZEhNaUlEQjRNREF4TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0TURBZ01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JaUF3ZURBd01EQWdNSGd3TVNBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdJbTFsYldKbGNuTWlJREI0TURRZ01IZ3dNREF3TURBd01EQXdNREFnSW1Gc2JHOTNaV1JTYjJ4bGN5SWdNSGd3TURJd0lEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNQ0F3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBZ01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndiaUF4T1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpSWdvZ0lDQWdaSFZ3YmlBeE5Rb2dJQ0FnY0hWemFHbHVkQ0EwTURrMkNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0J6ZEc5eVpTQTFDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnNiMkZrSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3T0RBS0lDQWdJSEpsY0d4aFkyVXlJRFkwQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T1Rrd1pqTXdZV1VnTUhoa01EYzVOalF6TVNBd2VEbGxZV0UxTnpOaElEQjRZMlptTW1VMk1qRWdNSGhrTkRRME1HWTFOeUF3ZURnM1pEVTBOVEJpSURCNE1tTXdZV05rT0RFZ01IaGtZVGMxTUdJeU15QXdlREV6WlRreU9EZzJJREI0TTJSaVl6WmtORE1nTUhnNU1HWTFPR1UzTlNBd2VHWXhNRFkyTnprNUlEQjRPRGt4WXpNM05HRWdNSGhqTkdSbE1UY3dZaUF3ZUdZeE9HRTRNMkU0SURCNFlqVXhNalUxTldNZ01IZ3laR1l3TW1FeU55QXdlREk0TkRSa1lqbGxJREI0TXpRMFlXWm1OREFnTUhoa09UWmlPR0UzWkNBd2VEQTJaV1JqTXpKbElEQjRZelprTlRFMU1tVWdNSGhoWXpsalltRXdaU0F3ZURnMVpETTRNbVV4SURCNE1tRXpNbU5rWkRFZ01IZ3pZalZqWVRBNE5pQXdlREpqT0RNMk5tUTRJREI0TmpZNVlXTXdOR0lnTUhnd05EazFNV015T1NBd2VHUmtPVGd5T0dRMUlEQjRObVJqTXpBek1EVWdNSGhpWmpZek56WTFZaUF3ZURBME9URTVZVEkySUM4dklHMWxkR2h2WkNBaVgxOXdiM04wU1c1cGRDaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1OaGJrTmhiR3dvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0o1ZEdWYk5GMHBLR0p2YjJ3c2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVpYaHdhWEpoZEdsdmJpZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSnRhVzVUWlhSaVlXTnJLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWx6VkdGeVoyVjBRMnh2YzJWa0tHRmtaSEpsYzNNcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFZHRnlaMlYwUm5WdVkzUnBiMjVTYjJ4bEtHRmtaSEpsYzNNc1lubDBaVnMwWFNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhrb1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGSnZiR1ZCWkcxcGJpaDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUlNiMnhsUjNWaGNtUnBZVzRvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwVW05c1pVZHlZVzUwUkdWc1lYa29kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBRV05qWlhOektIVnBiblEyTkN4aFpHUnlaWE56S1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm9ZWE5TYjJ4bEtIVnBiblEyTkN4aFpHUnlaWE56S1NoaWIyOXNMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbXhoWW1Wc1VtOXNaU2gxYVc1ME5qUXNjM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW1keVlXNTBVbTlzWlNoMWFXNTBOalFzWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVjJiMnRsVW05c1pTaDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p5Wlc1dmRXNWpaVkp2YkdVb2RXbHVkRFkwTEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljMlYwVW05c1pVRmtiV2x1S0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBVbTlzWlVkMVlYSmthV0Z1S0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBSM0poYm5SRVpXeGhlU2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGUmhjbWRsZEVaMWJtTjBhVzl1VW05c1pTaGhaR1J5WlhOekxIVnBiblE0V3pSZFcxMHNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhrb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwVkdGeVoyVjBRMnh2YzJWa0tHRmtaSEpsYzNNc1ltOXZiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJUWTJobFpIVnNaU2hpZVhSbFd6TXlYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEU1dmJtTmxLR0o1ZEdWYk16SmRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljMk5vWldSMWJHVW9ZV1JrY21WemN5eGllWFJsVzEwc2RXbHVkRFkwS1NoaWVYUmxXek15WFN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKbGVHVmpkWFJsS0dGa1pISmxjM01zWW5sMFpWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZMkZ1WTJWc0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWVYUmxXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqYjI1emRXMWxVMk5vWldSMWJHVmtUM0FvWVdSa2NtVnpjeXhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWFHRnphRTl3WlhKaGRHbHZiaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZbmwwWlZ0ZEtXSjVkR1ZiTXpKZElpd2diV1YwYUc5a0lDSjFjR1JoZEdWQmRYUm9iM0pwZEhrb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJa0ZFVFVsT1gxSlBURVVvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpVUZWQ1RFbERYMUpQVEVVb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWJYVnNkR2xqWVd4c0tHSjVkR1ZiWFZ0ZEtXSjVkR1ZiWFZ0ZElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5ZlgzQnZjM1JKYm1sMFgzSnZkWFJsUURVZ2JXRnBibDlqWVc1RFlXeHNYM0p2ZFhSbFFEWWdiV0ZwYmw5bGVIQnBjbUYwYVc5dVgzSnZkWFJsUURjZ2JXRnBibDl0YVc1VFpYUmlZV05yWDNKdmRYUmxRRGdnYldGcGJsOXBjMVJoY21kbGRFTnNiM05sWkY5eWIzVjBaVUE1SUcxaGFXNWZaMlYwVkdGeVoyVjBSblZ1WTNScGIyNVNiMnhsWDNKdmRYUmxRREV3SUcxaGFXNWZaMlYwVkdGeVoyVjBRV1J0YVc1RVpXeGhlVjl5YjNWMFpVQXhNU0J0WVdsdVgyZGxkRkp2YkdWQlpHMXBibDl5YjNWMFpVQXhNaUJ0WVdsdVgyZGxkRkp2YkdWSGRXRnlaR2xoYmw5eWIzVjBaVUF4TXlCdFlXbHVYMmRsZEZKdmJHVkhjbUZ1ZEVSbGJHRjVYM0p2ZFhSbFFERTBJRzFoYVc1ZloyVjBRV05qWlhOelgzSnZkWFJsUURFMUlHMWhhVzVmYUdGelVtOXNaVjl5YjNWMFpVQXhOaUJ0WVdsdVgyeGhZbVZzVW05c1pWOXliM1YwWlVBeE55QnRZV2x1WDJkeVlXNTBVbTlzWlY5eWIzVjBaVUF4T0NCdFlXbHVYM0psZG05clpWSnZiR1ZmY205MWRHVkFNVGtnYldGcGJsOXlaVzV2ZFc1alpWSnZiR1ZmY205MWRHVkFNakFnYldGcGJsOXpaWFJTYjJ4bFFXUnRhVzVmY205MWRHVkFNakVnYldGcGJsOXpaWFJTYjJ4bFIzVmhjbVJwWVc1ZmNtOTFkR1ZBTWpJZ2JXRnBibDl6WlhSSGNtRnVkRVJsYkdGNVgzSnZkWFJsUURJeklHMWhhVzVmYzJWMFZHRnlaMlYwUm5WdVkzUnBiMjVTYjJ4bFgzSnZkWFJsUURJMElHMWhhVzVmYzJWMFZHRnlaMlYwUVdSdGFXNUVaV3hoZVY5eWIzVjBaVUF5TlNCdFlXbHVYM05sZEZSaGNtZGxkRU5zYjNObFpGOXliM1YwWlVBeU5pQnRZV2x1WDJkbGRGTmphR1ZrZFd4bFgzSnZkWFJsUURJM0lHMWhhVzVmWjJWMFRtOXVZMlZmY205MWRHVkFNamdnYldGcGJsOXpZMmhsWkhWc1pWOXliM1YwWlVBeU9TQnRZV2x1WDJWNFpXTjFkR1ZmY205MWRHVkFNekFnYldGcGJsOWpZVzVqWld4ZmNtOTFkR1ZBTXpFZ2JXRnBibDlqYjI1emRXMWxVMk5vWldSMWJHVmtUM0JmY205MWRHVkFNeklnYldGcGJsOW9ZWE5vVDNCbGNtRjBhVzl1WDNKdmRYUmxRRE16SUcxaGFXNWZkWEJrWVhSbFFYVjBhRzl5YVhSNVgzSnZkWFJsUURNMElHMWhhVzVmUVVSTlNVNWZVazlNUlY5eWIzVjBaVUF6TlNCdFlXbHVYMUJWUWt4SlExOVNUMHhGWDNKdmRYUmxRRE0ySUcxaGFXNWZiWFZzZEdsallXeHNYM0p2ZFhSbFFETTNDaUFnSUNCbGNuSUtDbTFoYVc1ZmJYVnNkR2xqWVd4c1gzSnZkWFJsUURNM09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNvS0lDQWdJR0oxY25rZ053b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR0oxY25rZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0oxY25rZ016UUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlERXdDZ3B0WVdsdVgyWnZjbDlvWldGa1pYSkFOREk2Q2lBZ0lDQmthV2NnT1FvZ0lDQWdaR2xuSURFekNpQWdJQ0E4Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJadmNrQTBOQW9nSUNBZ1pHbG5JRGtLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTXpVS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dPUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR1p2Y2lBb2JHVnVLeWhzWlc0cmRXbHVkRGhiWFNsYlhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUdKMWNua2dOd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01UQUtJQ0FnSUdJZ2JXRnBibDltYjNKZmFHVmhaR1Z5UURReUNncHRZV2x1WDJGbWRHVnlYMlp2Y2tBME5Eb0tJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrUGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME5nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBME56b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdZbmwwWldNZ01UTWdMeThnTUhnd01EQXdDaUFnSUNCaWRYSjVJRE0yQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0F4TlFvS2JXRnBibDkzYUdsc1pWOTBiM0JBTkRnNkNpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdScFp5QXhNd29nSUNBZ1BBb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOTNhR2xzWlVBMU1Bb2dJQ0FnWkdsbklETTFDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1lucGxjbThLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z01IZ3dNREF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUY5eVpXTmhiR04xYkdGMFpWOW9aV0ZrWDJadmNsOWxiR1Z0Wlc1MGMxOTNhWFJvWDJKNWRHVmZiR1Z1WjNSb1gyaGxZV1FLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4TmdvZ0lDQWdZblZ5ZVNBek5nb2dJQ0FnWWlCdFlXbHVYM2RvYVd4bFgzUnZjRUEwT0FvS2JXRnBibDloWm5SbGNsOTNhR2xzWlVBMU1Eb0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdKMWNua2dNamtLSUNBZ0lHUnBaeUF6TlFvZ0lDQWdZblZ5ZVNBeU13b0tiV0ZwYmw5M2FHbHNaVjkwYjNCQU5URTZDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF5T1FvZ0lDQWdZajRLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmZDJocGJHVkFOVE1LSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01qa0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZFdKemRISnBibWNnTUNBeUNpQWdJQ0JrZFhBS0lDQWdJR0owYjJrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaSFZ3TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0FyQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VEQXdNREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1gzSmxZMkZzWTNWc1lYUmxYMmhsWVdSZlptOXlYMlZzWlcxbGJuUnpYM2RwZEdoZllubDBaVjlzWlc1bmRHaGZhR1ZoWkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlESTBDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QXdlREF4Q2lBZ0lDQmlLd29nSUNBZ1luVnllU0F5T1FvZ0lDQWdZaUJ0WVdsdVgzZG9hV3hsWDNSdmNFQTFNUW9LYldGcGJsOWhablJsY2w5M2FHbHNaVUExTXpvS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdaR2xuSURJekNpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFEyT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFEzQ2dwdFlXbHVYMUJWUWt4SlExOVNUMHhGWDNKdmRYUmxRRE0yT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU53b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU9Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelZtWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTnpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExT0FvS2JXRnBibDlCUkUxSlRsOVNUMHhGWDNKdmRYUmxRRE0xT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyTWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEyTXdvS2JXRnBibDkxY0dSaGRHVkJkWFJvYjNKcGRIbGZjbTkxZEdWQU16UTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNakVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TmdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk53b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk9Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdZMkZzYkhOMVlpQmZZMmhsWTJ0QmRYUm9iM0pwZW1Wa0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQmthV2NnTVRrS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdOa1pHRTBaV0UySUM4dklHMWxkR2h2WkNBaWMyVjBRWFYwYUc5eWFYUjVLR0ZrWkhKbGMzTXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dNalFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEWTNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWTRDZ3B0WVdsdVgyaGhjMmhQY0dWeVlYUnBiMjVmY205MWRHVkFNek02Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpZV3hzYzNWaUlHaGhjMmhQY0dWeVlYUnBiMjRLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMjl1YzNWdFpWTmphR1ZrZFd4bFpFOXdYM0p2ZFhSbFFETXlPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE0wQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0oxY25rZ016RUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOelFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOelU2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZMlExTVROa1lUVWdMeThnYldWMGFHOWtJQ0pwYzBOdmJuTjFiV2x1WjFOamFHVmtkV3hsWkU5d0tDbGllWFJsV3pSZElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNFptSXpOakF6TndvZ0lDQWdJVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQlkyTmxjM05OWVc1aFoyVnlWVzVoZFhSb2IzSnBlbVZrUTI5dWMzVnRaUW9nSUNBZ1pHbG5JRE16Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTXpJS0lDQWdJR05oYkd4emRXSWdhR0Z6YUU5d1pYSmhkR2x2YmdvZ0lDQWdZMkZzYkhOMVlpQmZZMjl1YzNWdFpWTmphR1ZrZFd4bFpFOXdDaUFnSUNCd2IzQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEzTkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEzTlFvS2JXRnBibDlqWVc1alpXeGZjbTkxZEdWQU16RTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNelFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZFhKNUlETXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGM1Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGd3T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qY0tJQ0FnSUdScFp5QXpNUW9nSUNBZ1pIVndDaUFnSUNCemRXSnpkSEpwYm1jZ01DQTBDaUFnSUNCaWRYSjVJREkwQ2lBZ0lDQmthV2NnTXpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkdsbklESXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdhR0Z6YUU5d1pYSmhkR2x2YmdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJM0NpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lsOXpZMmhsWkhWc1pYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F6TUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EyQ2lBZ0lDQmlkRzlwQ2lBZ0lDQWhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpUV0Z1WVdkbGNrNXZkRk5qYUdWa2RXeGxaQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTRNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdScFp5QXlOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlHaGhjMUp2YkdVS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJeENpQWdJQ0JrYVdjZ01qUUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFZHRnlaMlYwUm5WdVkzUnBiMjVTYjJ4bENpQWdJQ0JqWVd4c2MzVmlJR2RsZEZKdmJHVkhkV0Z5WkdsaGJnb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJvWVhOU2IyeGxDaUFnSUNCd2IzQUtJQ0FnSUdKMWNua2dNVEFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RNS0lDQWdJR1JwWnlBNENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpUV0Z1WVdkbGNsVnVZWFYwYUc5eWFYcGxaRU5oYm1ObGJBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRGd6T2dvZ0lDQWdaR2xuSURJMkNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JsZUhSeVlXTjBJRFlnTkFvZ0lDQWdZbmwwWldNZ01UZ2dMeThnTUhnd01EQXdNREF3TURBd01EQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNeklLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JREkxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURjek5tRm1OR0ZqSUM4dklHMWxkR2h2WkNBaVQzQmxjbUYwYVc5dVEyRnVZMlZzWldRb2RXbHVkRGhiTXpKZExIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBM09Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNE1Bb0tiV0ZwYmw5bGVHVmpkWFJsWDNKdmRYUmxRRE13T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlETXpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ016WUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUY5allXNURZV3hzUlhoMFpXNWtaV1FLSUNBZ0lIQnZjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJmWTJGdVEyRnNiRVY0ZEdWdVpHVmtDaUFnSUNCaWRYSjVJRFVLSUNBZ0lIQnZjQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE0TndvZ0lDQWdaR2xuSURJS0lDQWdJQ0VLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQlkyTmxjM05OWVc1aFoyVnlWVzVoZFhSb2IzSnBlbVZrUTJGc2JBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRGczT2dvZ0lDQWdaR2xuSURNeUNpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdScFp5QXpNZ29nSUNBZ1kyRnNiSE4xWWlCb1lYTm9UM0JsY21GMGFXOXVDaUFnSUNCaWRYSjVJREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbTU2SUcxaGFXNWZhV1pmWW05a2VVQTRPUW9nSUNBZ1pHbG5JREl6Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRk5qYUdWa2RXeGxDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFPVEFLQ20xaGFXNWZhV1pmWW05a2VVQTRPVG9LSUNBZ0lHUnBaeUF5TXdvZ0lDQWdZMkZzYkhOMVlpQmZZMjl1YzNWdFpWTmphR1ZrZFd4bFpFOXdDaUFnSUNCaWRYSjVJRGNLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNU1Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKZlpYaGxZM1YwYVc5dVNXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdZblZ5ZVNBek1Rb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjlsZUdWamRYUnBiMjVKWkNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF6TUFvZ0lDQWdjM1ZpYzNSeWFXNW5JREFnTkFvZ0lDQWdaR2xuSURJd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRjlvWVhOb1JYaGxZM1YwYVc5dVNXUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lsOWxlR1ZqZFhScGIyNUpaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURreUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURrek9nb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklESXdDaUFnSUNCa2FXY2dNeklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJCWkdSeVpYTnpMbVoxYm1OMGFXOXVRMkZzYkZkcGRHaFdZV3gxWlFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pmWlhobFkzVjBhVzl1U1dRaUNpQWdJQ0JrYVdjZ016QUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCa2FXY2dOZ29nSUNBZ2FXNTBZeUEwSUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNZS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTVNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTVNd29LYldGcGJsOXpZMmhsWkhWc1pWOXliM1YwWlVBeU9Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREU1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0oxY25rZ016RUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNU53b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNU9Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5SaklEVWdMeThnTWpneE5EYzBPVGMyTnpFd05qVTFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGQ1NTQjJZV3hwWkdGMGFXOXVDaUFnSUNCcGJuUmpJRFVnTHk4Z01qZ3hORGMwT1RjMk56RXdOalUxQ2lBZ0lDQW1DaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlETTFDaUFnSUNCa2FXY2dNakVLSUNBZ0lHUnBaeUF6TXdvZ0lDQWdZMkZzYkhOMVlpQmZZMkZ1UTJGc2JFVjRkR1Z1WkdWa0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUdOaGJHeHpkV0lnVkdsdFpTNTBhVzFsYzNSaGJYQUtJQ0FnSUdScFp5QXhDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01Ua0tJQ0FnSUdsdWRHTWdOU0F2THlBeU9ERTBOelE1TnpZM01UQTJOVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJQ0VLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQlkyTmxjM05OWVc1aFoyVnlWVzVoZFhSb2IzSnBlbVZrUTJGc2JBb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXdNQW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dNVFlLSUNBZ0lEd0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVZXNWhkWFJvYjNKcGVtVmtRMkZzYkFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXdNRG9LSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF4TndvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3TWdvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvTG0xaGVBb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvTG0xaGVBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFVnTHk4Z01qZ3hORGMwT1RjMk56RXdOalUxQ2lBZ0lDQW1DaUFnSUNCaWRYSjVJREVLSUNBZ0lHUnBaeUF6TWdvZ0lDQWdaR2xuSURJd0NpQWdJQ0JrYVdjZ016SUtJQ0FnSUdOaGJHeHpkV0lnYUdGemFFOXdaWEpoZEdsdmJnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESTFDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbDl6WTJobFpIVnNaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU9Bb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTUNBMkNpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05nb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTJNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHTmhiR3h6ZFdJZ1gybHpSWGh3YVhKbFpBb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjMDFoYm1GblpYSkJiSEpsWVdSNVUyTm9aV1IxYkdWa0NncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFl6T2dvZ0lDQWdaR2xuSURJMkNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNeklLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0J3ZFhOb2FXNTBJRFF5T1RRNU5qY3lPVFlLSUNBZ0lDVUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTmlBMENpQWdJQ0JrYVdjZ013b2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYVhSc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkRnS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlhWFJzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wSURBZ05nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdScFp5QXlOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EY3lDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobU9HSTNOemt4WVNBdkx5QnRaWFJvYjJRZ0lrOXdaWEpoZEdsdmJsTmphR1ZrZFd4bFpDaDFhVzUwT0Zzek1sMHNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBPRnN6TWwwc2RXbHVkRGhiTXpKZExHSjVkR1ZiWFNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEazNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEazRDZ3B0WVdsdVgyZGxkRTV2Ym1ObFgzSnZkWFJsUURJNE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESTVDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV3TkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TURVNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHUnBaeUF5TndvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKZmMyTm9aV1IxYkdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5Rek1nb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1EUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UQTFDZ3B0WVdsdVgyZGxkRk5qYUdWa2RXeGxYM0p2ZFhSbFFESTNPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCallXeHNjM1ZpSUdkbGRGTmphR1ZrZFd4bENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGUmhjbWRsZEVOc2IzTmxaRjl5YjNWMFpVQXlOam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFNUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TVRFS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRFeU9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTBGMWRHaHZjbWw2WldRS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVUpKSUdKdmIyd2dkbUZzYVdSaGRHbHZiZ29nSUNBZ1pHbG5JREU1Q2lBZ0lDQmtkWEFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWDNSaGNtZGxkSE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEQXdNVEV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01pQXhOQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TVRFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWpFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoalpUZGhOalV3WmlBdkx5QnRaWFJvYjJRZ0lsUmhjbWRsZEVOc2IzTmxaQ2gxYVc1ME9Gc3pNbDBzWW05dmJDa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFeE1Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1USUtDbTFoYVc1ZmMyVjBWR0Z5WjJWMFFXUnRhVzVFWld4aGVWOXliM1YwWlVBeU5Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBNENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXhOZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNVGM2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRWFYwYUc5eWFYcGxaQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUEwSUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUVVKSklIWmhiR2xrWVhScGIyNEtJQ0FnSUdsdWRHTWdOQ0F2THlBME1qazBPVFkzTWprMUNpQWdJQ0FtQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGQ1NTQjJZV3hwWkdGMGFXOXVDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdaR2xuSURJd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nT0NBdkx5QWlYM1JoY21kbGRITWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURBd01URXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURJZ01UUUtJQ0FnSUdOaGJHeHpkV0lnYldsdVUyVjBZbUZqYXdvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1M2FYUm9WWEJrWVhSbENpQWdJQ0J3YjNCdUlESUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3TURFeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F5SURFMENpQWdJQ0JqWVd4c2MzVmlJRzFwYmxObGRHSmhZMnNLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGUnBiV1V1ZDJsMGFGVndaR0YwWlFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY0c5d0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WXpOaE1XWXlNakVnTHk4Z2JXVjBhRzlrSUNKVVlYSm5aWFJCWkcxcGJrUmxiR0Y1VlhCa1lYUmxaQ2gxYVc1ME9Gc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFeE5qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1UY0tDbTFoYVc1ZmMyVjBWR0Z5WjJWMFJuVnVZM1JwYjI1U2IyeGxYM0p2ZFhSbFFESTBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREl3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhOZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURRK1Bnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmlkWEo1SURRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1USXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXlNam9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWTJGc2JITjFZaUJmWTJobFkydEJkWFJvYjNKcGVtVmtDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5WeWVTQXlPUW9LYldGcGJsOTNhR2xzWlY5MGIzQkFNVEl6T2dvZ0lDQWdaR2xuSURFekNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01qa0tJQ0FnSUdJK0NpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURFeU5Rb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01qa0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01qSUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrZFhBS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVGtnTHk4Z0ltRnNiRzkzWldSU2IyeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURZS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdScFp5QXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVRnS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpEVTBPVFl5T1RjZ0x5OGdiV1YwYUc5a0lDSlVZWEpuWlhSR2RXNWpkR2x2YmxKdmJHVlZjR1JoZEdWa0tIVnBiblE0V3pNeVhTeDFhVzUwT0ZzMFhTeDFhVzUwTmpRcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdKNWRHVmpJREUwSUM4dklEQjRNREVLSUNBZ0lHSXJDaUFnSUNCaWRYSjVJREk1Q2lBZ0lDQmlJRzFoYVc1ZmQyaHBiR1ZmZEc5d1FERXlNd29LYldGcGJsOWhablJsY2w5M2FHbHNaVUF4TWpVNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEl4T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV5TWdvS2JXRnBibDl6WlhSSGNtRnVkRVJsYkdGNVgzSnZkWFJsUURJek9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmlkWEo1SURRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dPQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TWprS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRNd09nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTBGMWRHaHZjbWw2WldRS0lDQWdJR1JwWnlBM0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFRkNTU0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ0pnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEUWdMeThnTkRJNU5EazJOekk1TlFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJRa2tnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOaUF2THlBeE9EUTBOamMwTkRBM016Y3dPVFUxTVRZeE5Rb2dJQ0FnUFQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNOTllXNWhaMlZ5VEc5amEyVmtVbTlzWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKZmNtOXNaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXdNakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTVRnZ01UUUtJQ0FnSUdOaGJHeHpkV0lnYldsdVUyVjBZbUZqYXdvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1M2FYUm9WWEJrWVhSbENpQWdJQ0J3YjNCdUlESUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURJd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElERTRJREUwQ2lBZ0lDQmpZV3hzYzNWaUlHMXBibE5sZEdKaFkyc0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZScGJXVXVkMmwwYUZWd1pHRjBaUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjRzl3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTWpBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdGa1pUazFNMk5tSUM4dklHMWxkR2h2WkNBaVVtOXNaVWR5WVc1MFJHVnNZWGxEYUdGdVoyVmtLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEk1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV6TUFvS2JXRnBibDl6WlhSU2IyeGxSM1ZoY21ScFlXNWZjbTkxZEdWQU1qSTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNakFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ05Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTVDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE16UUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UTTFPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwRjFkR2h2Y21sNlpXUUtJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUNFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNOTllXNWhaMlZ5VEc5amEyVmtVbTlzWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURZZ0x5OGdNVGcwTkRZM05EUXdOek0zTURrMU5URTJNVFVLSUNBZ0lEMDlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpUV0Z1WVdkbGNreHZZMnRsWkZKdmJHVUtJQ0FnSUdsMGIySUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTkNBdkx5QWlYM0p2YkdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURJd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01pQTRDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeE9DQXhOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURJd0lDOHZJREI0TURBeU1Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeU1Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdaR2xuSURFNUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWmlZemM0TjJNMklDOHZJRzFsZEdodlpDQWlVbTlzWlVkMVlYSmthV0Z1UTJoaGJtZGxaQ2gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRNME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFek5Rb0tiV0ZwYmw5elpYUlNiMnhsUVdSdGFXNWZjbTkxZEdWQU1qRTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNakFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ05Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTVDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE16a0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UUXdPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwRjFkR2h2Y21sNlpXUUtJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUNFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNOTllXNWhaMlZ5VEc5amEyVmtVbTlzWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURZZ0x5OGdNVGcwTkRZM05EUXdOek0zTURrMU5URTJNVFVLSUNBZ0lEMDlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpUV0Z1WVdkbGNreHZZMnRsWkZKdmJHVUtJQ0FnSUdsMGIySUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTkNBdkx5QWlYM0p2YkdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURJd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01UZ2dNVFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElERXdJRGdLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeU1DQXZMeUF3ZURBd01qQUtJQ0FnSUdScFp5QXlNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR1JwWnlBeE9Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1aRFJqWmpnNU1DQXZMeUJ0WlhSb2IyUWdJbEp2YkdWQlpHMXBia05vWVc1blpXUW9kV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV6T1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TkRBS0NtMWhhVzVmY21WdWIzVnVZMlZTYjJ4bFgzSnZkWFJsUURJd09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1luVnllU0EwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXpNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UUTBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTBOVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURNeUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0lUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVFtRmtRMjl1Wm1seWJXRjBhVzl1Q2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQmZjbVYyYjJ0bFVtOXNaUW9nSUNBZ2NHOXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRRME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFME5Rb0tiV0ZwYmw5eVpYWnZhMlZTYjJ4bFgzSnZkWFJsUURFNU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1luVnllU0EwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXpZS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UUTVDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTFNRG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWTJGc2JITjFZaUJmWTJobFkydEJkWFJvYjNKcGVtVmtDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRE0xQ2lBZ0lDQmpZV3hzYzNWaUlGOXlaWFp2YTJWU2IyeGxDaUFnSUNCd2IzQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TkRrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRVd0NncHRZV2x1WDJkeVlXNTBVbTlzWlY5eWIzVjBaVUF4T0RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE0yQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JpZFhKNUlERXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREUxTkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TlRVNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yUVhWMGFHOXlhWHBsWkFvZ0lDQWdaR2xuSURFd0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFRkNTU0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ0pnb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJuWlhSU2IyeGxSM0poYm5SRVpXeGhlUW9nSUNBZ1pHbG5JRE0zQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOaGJHeHpkV0lnWDJkeVlXNTBVbTlzWlFvZ0lDQWdjRzl3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UVTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTFOUW9LYldGcGJsOXNZV0psYkZKdmJHVmZjbTkxZEdWQU1UYzZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNakFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ05Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFMU9Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5qQTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR05oYkd4emRXSWdYMk5vWldOclFYVjBhRzl5YVhwbFpBb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnSVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6YzAxaGJtRm5aWEpNYjJOclpXUlNiMnhsQ2lBZ0lDQnBiblJqSURZZ0x5OGdNVGcwTkRZM05EUXdOek0zTURrMU5URTJNVFVLSUNBZ0lEMDlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpUV0Z1WVdkbGNreHZZMnRsWkZKdmJHVUtJQ0FnSUdScFp5QXhPQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3WVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNekk0WWpneE5tWWdMeThnYldWMGFHOWtJQ0pTYjJ4bFRHRmlaV3dvZFdsdWREWTBMSE4wY21sdVp5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFMU9Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5qQUtDbTFoYVc1ZmFHRnpVbTlzWlY5eWIzVjBaVUF4TmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnWTJGc2JITjFZaUJvWVhOU2IyeGxDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJCWTJObGMzTmZjbTkxZEdWQU1UVTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBRV05qWlhOekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkp2YkdWSGNtRnVkRVJsYkdGNVgzSnZkWFJsUURFME9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1kyRnNiSE4xWWlCblpYUlNiMnhsUjNKaGJuUkVaV3hoZVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSU2IyeGxSM1ZoY21ScFlXNWZjbTkxZEdWQU1UTTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRkp2YkdWSGRXRnlaR2xoYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSU2IyeGxRV1J0YVc1ZmNtOTFkR1ZBTVRJNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCallXeHNjM1ZpSUdkbGRGSnZiR1ZCWkcxcGJnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlVZWEpuWlhSQlpHMXBia1JsYkdGNVgzSnZkWFJsUURFeE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JqWVd4c2MzVmlJR2RsZEZSaGNtZGxkRUZrYldsdVJHVnNZWGtLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVkdGeVoyVjBSblZ1WTNScGIyNVNiMnhsWDNKdmRYUmxRREV3T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBMFBnb2dJQ0FnWTJGc2JITjFZaUJuWlhSVVlYSm5aWFJHZFc1amRHbHZibEp2YkdVS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYVhOVVlYSm5aWFJEYkc5elpXUmZjbTkxZEdWQU9Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnWTJGc2JITjFZaUJwYzFSaGNtZGxkRU5zYjNObFpBb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDIxcGJsTmxkR0poWTJ0ZmNtOTFkR1ZBT0RvS0lDQWdJR05oYkd4emRXSWdiV2x1VTJWMFltRmphd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWxlSEJwY21GMGFXOXVYM0p2ZFhSbFFEYzZDaUFnSUNCallXeHNjM1ZpSUdWNGNHbHlZWFJwYjI0S0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJGdVEyRnNiRjl5YjNWMFpVQTJPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRFErQ2lBZ0lDQmpZV3hzYzNWaUlHTmhia05oYkd3S0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITmxkR0pwZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZmNHOXpkRWx1YVhSZmNtOTFkR1ZBTlRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdZbmwwWldNZ01USWdMeThnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmZYM0J2YzNSSmJtbDBJR0ZzY21WaFpIa2dZMkZzYkdWa0NpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbDkwWVhKblpYUnpJZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbDl5YjJ4bGN5SUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSmZjMk5vWldSMWJHVnpJZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbDlsZUdWamRYUnBiMjVKWkNJS0lDQWdJR0o1ZEdWaklERTFJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBOVBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZqWTJWemMwMWhibUZuWlhKSmJuWmhiR2xrU1c1cGRHbGhiRUZrYldsdUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZlozSmhiblJTYjJ4bENpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WVhKak5DNWZjbVZqWVd4amRXeGhkR1ZmYUdWaFpGOW1iM0pmWld4bGJXVnVkSE5mZDJsMGFGOWllWFJsWDJ4bGJtZDBhRjlvWldGa0tHRnljbUY1WDJobFlXUmZZVzVrWDNSaGFXdzZJR0o1ZEdWekxDQnNaVzVuZEdnNklIVnBiblEyTkN3Z2MzUmhjblJmWVhSZmFXNWtaWGc2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q2w5eVpXTmhiR04xYkdGMFpWOW9aV0ZrWDJadmNsOWxiR1Z0Wlc1MGMxOTNhWFJvWDJKNWRHVmZiR1Z1WjNSb1gyaGxZV1E2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXFDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5sYkdWamRBb2dJQ0FnYzNkaGNBb0tYM0psWTJGc1kzVnNZWFJsWDJobFlXUmZabTl5WDJWc1pXMWxiblJ6WDNkcGRHaGZZbmwwWlY5c1pXNW5kR2hmYUdWaFpGOW1iM0pmYUdWaFpHVnlRREU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUR3S0lDQWdJR0o2SUY5eVpXTmhiR04xYkdGMFpWOW9aV0ZrWDJadmNsOWxiR1Z0Wlc1MGMxOTNhWFJvWDJKNWRHVmZiR1Z1WjNSb1gyaGxZV1JmWVdaMFpYSmZabTl5UURRS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjbVZ3YkdGalpUTUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBdE13b2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdJZ1gzSmxZMkZzWTNWc1lYUmxYMmhsWVdSZlptOXlYMlZzWlcxbGJuUnpYM2RwZEdoZllubDBaVjlzWlc1bmRHaGZhR1ZoWkY5bWIzSmZhR1ZoWkdWeVFERUtDbDl5WldOaGJHTjFiR0YwWlY5b1pXRmtYMlp2Y2w5bGJHVnRaVzUwYzE5M2FYUm9YMko1ZEdWZmJHVnVaM1JvWDJobFlXUmZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNXpiMnd1UVdSa2NtVnpjeTVtZFc1amRHbHZia05oYkd4WGFYUm9WbUZzZFdVb2RHRnlaMlYwT2lCaWVYUmxjeXdnWkdGMFlUb2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2tGa1pISmxjM011Wm5WdVkzUnBiMjVEWVd4c1YybDBhRlpoYkhWbE9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JDWVd4aGJtTmxDaUFnSUNCd2IzQUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWp3S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5Qkpibk4xWm1acFkybGxiblJDWVd4aGJtTmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqWVd4c2MzVmlJRXh2ZDB4bGRtVnNRMkZzYkM1allXeHNUbTlTWlhSMWNtNEtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRWEJ3Y205MllXeFFjbTluY21GdENpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0o2SUVGa1pISmxjM011Wm5WdVkzUnBiMjVEWVd4c1YybDBhRlpoYkhWbFgyVnNjMlZmWW05a2VVQTJDaUFnSUNCallXeHNjM1ZpSUV4dmQweGxkbVZzUTJGc2JDNXlaWFIxY201RVlYUmhVMmw2WlFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHSnVlaUJCWkdSeVpYTnpMbVoxYm1OMGFXOXVRMkZzYkZkcGRHaFdZV3gxWlY5cFpsOWliMlI1UURVS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWVpQkJaR1J5WlhOekxtWjFibU4wYVc5dVEyRnNiRmRwZEdoV1lXeDFaVjlsYkhObFgySnZaSGxBTmdvS1FXUmtjbVZ6Y3k1bWRXNWpkR2x2YmtOaGJHeFhhWFJvVm1Gc2RXVmZhV1pmWW05a2VVQTFPZ29nSUNBZ1kyRnNiSE4xWWlCTWIzZE1aWFpsYkVOaGJHd3VjbVYwZFhKdVJHRjBZUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2tGa1pISmxjM011Wm5WdVkzUnBiMjVEWVd4c1YybDBhRlpoYkhWbFgyVnNjMlZmWW05a2VVQTJPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkdSeVpYTnpSVzF3ZEhsRGIyUmxDaUFnSUNCallXeHNjM1ZpSUV4dmQweGxkbVZzUTJGc2JDNXlaWFIxY201RVlYUmhVMmw2WlFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkdZV2xzWldSRFlXeHNDaUFnSUNCaUlFeHZkMHhsZG1Wc1EyRnNiQzVpZFdKaWJHVlNaWFpsY25RS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1SVlYTm9aWE11WldabWFXTnBaVzUwUzJWalkyRnJNalUyS0dFNklHSjVkR1Z6TENCaU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNraGhjMmhsY3k1bFptWnBZMmxsYm5STFpXTmpZV3N5TlRZNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxjR3hoWTJVeUlETXlDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMk5Bb2dJQ0FnYTJWalkyRnJNalUyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVNYjNkTVpYWmxiRU5oYkd3dVkyRnNiRTV2VW1WMGRYSnVLRE1wS0hSaGNtZGxkRG9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3l3Z1pHRjBZVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LVEc5M1RHVjJaV3hEWVd4c0xtTmhiR3hPYjFKbGRIVnliam9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnYkc5aFpDQXdDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1qQUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNU1iM2RNWlhabGJFTmhiR3d1Y21WMGRYSnVSR0YwWVZOcGVtVW9LU0F0UGlCaWVYUmxjem9LVEc5M1RHVjJaV3hEWVd4c0xuSmxkSFZ5YmtSaGRHRlRhWHBsT2dvZ0lDQWdiRzloWkNBd0NpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVNYjNkTVpYWmxiRU5oYkd3dWNtVjBkWEp1UkdGMFlTZ3BJQzArSUdKNWRHVnpPZ3BNYjNkTVpYWmxiRU5oYkd3dWNtVjBkWEp1UkdGMFlUb0tJQ0FnSUd4dllXUWdNQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKNlpYSnZDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKNWRHVmpJREUxSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneU1Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklERXhJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1TWIzZE1aWFpsYkVOaGJHd3VZblZpWW14bFVtVjJaWEowS0RBcEtDa2dMVDRnZG05cFpEb0tURzkzVEdWMlpXeERZV3hzTG1KMVltSnNaVkpsZG1WeWREb0tJQ0FnSUdWeWNpQXZMeUJ5WlhabGNuUUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNU5ZWFJvTG5SbGNtNWhjbmtvWTI5dVpHbDBhVzl1T2lCMWFXNTBOalFzSUdFNklHSjVkR1Z6TENCaU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrMWhkR2d1ZEdWeWJtRnllVG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0plQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVU5oYzNRdWRHOVZhVzUwQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSmVDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVOWVhSb0xtMWhlQ2hoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwTllYUm9MbTFoZURvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJK0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvTG5SbGNtNWhjbmtLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGxOaFptVkRZWE4wTG5SdlZXbHVkRFE0S0haaGJIVmxPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BUWVdabFEyRnpkQzUwYjFWcGJuUTBPRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVptWm1abVptWm1abVptWUtJQ0FnSUdJK0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdVMkZtWlVOaGMzUlBkbVZ5Wm14dmQyVmtWV2x1ZEVSdmQyNWpZWE4wQ2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5SaklEVWdMeThnTWpneE5EYzBPVGMyTnpFd05qVTFDaUFnSUNBbUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNVRZV1psUTJGemRDNTBiMVZwYm5Rb1lqb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tVMkZtWlVOaGMzUXVkRzlWYVc1ME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQnNiMkZrSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdJUW9nSUNBZ0lRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z01IZ3dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhOM1lYQUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGxScGJXVXVkR2x0WlhOMFlXMXdLQ2tnTFQ0Z2RXbHVkRFkwT2dwVWFXMWxMblJwYldWemRHRnRjRG9LSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVU5oYzNRdWRHOVZhVzUwTkRnS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xsUnBiV1V1ZEc5RVpXeGhlU2hrZFhKaGRHbHZiam9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LVkdsdFpTNTBiMFJsYkdGNU9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGxScGJXVXVYMmRsZEVaMWJHeEJkQ2h6Wld4bU9pQmllWFJsY3l3Z2RHbHRaWEJ2YVc1ME9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpRNkNsUnBiV1V1WDJkbGRFWjFiR3hCZERvS0lDQWdJSEJ5YjNSdklESWdNd29nSUNBZ1lubDBaV05mTVNBdkx5QWlJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUZScGJXVXVkVzV3WVdOckNpQWdJQ0J3YjNCdUlETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuVnVjR0ZqYXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqYjNabGNpQXpDaUFnSUNCd2IzQnVJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCVWFXMWxMblZ1Y0dGamF3b2dJQ0FnY0c5d0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuVnVjR0ZqYXdvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUR3OUNpQWdJQ0JpZWlCVWFXMWxMbDluWlhSR2RXeHNRWFJmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1ZHbHRaUzVmWjJWMFJuVnNiRUYwWDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0J5WlhSemRXSUtDbFJwYldVdVgyZGxkRVoxYkd4QmRGOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1lpQlVhVzFsTGw5blpYUkdkV3hzUVhSZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNXpiMnd1VkdsdFpTNW5aWFJHZFd4c0tITmxiR1k2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BVYVcxbExtZGxkRVoxYkd3NkNpQWdJQ0J3Y205MGJ5QXhJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzUwYVcxbGMzUmhiWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVWFXMWxMbDluWlhSR2RXeHNRWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGxScGJXVXVaMlYwS0hObGJHWTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbFJwYldVdVoyVjBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1blpYUkdkV3hzQ2lBZ0lDQndiM0J1SURJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xsUnBiV1V1ZDJsMGFGVndaR0YwWlNoelpXeG1PaUJpZVhSbGN5d2dibVYzVm1Gc2RXVTZJSFZwYm5RMk5Dd2diV2x1VTJWMFltRmphem9nZFdsdWREWTBLU0F0UGlCaWVYUmxjeXdnZFdsdWREWTBPZ3BVYVcxbExuZHBkR2hWY0dSaGRHVTZDaUFnSUNCd2NtOTBieUF6SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG1kbGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJRDRLSUNBZ0lHSjZJRlJwYldVdWQybDBhRlZ3WkdGMFpWOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvS1ZHbHRaUzUzYVhSb1ZYQmtZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0RJS0lDQWdJR05oYkd4emRXSWdUV0YwYUM1dFlYZ0tJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdUV0YwYUM1dFlYZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZeUEwSUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNZS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1MGFXMWxjM1JoYlhBS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUExSUM4dklESTRNVFEzTkRrM05qY3hNRFkxTlFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1d1lXTnJDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEpsZEhOMVlnb0tWR2x0WlM1M2FYUm9WWEJrWVhSbFgyVnNjMlZmWW05a2VVQXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1ZHbHRaUzUzYVhSb1ZYQmtZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMbFJwYldVdWRXNXdZV05yS0hObGJHWTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncFVhVzFsTG5WdWNHRmphem9LSUNBZ0lIQnliM1J2SURFZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBeU1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBeU1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWXlBMUlDOHZJREk0TVRRM05EazNOamN4TURZMU5Rb2dJQ0FnSmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VWR2x0WlM1d1lXTnJLSFpoYkhWbFFtVm1iM0psT2lCMWFXNTBOalFzSUhaaGJIVmxRV1owWlhJNklIVnBiblEyTkN3Z1pXWm1aV04wT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwVWFXMWxMbkJoWTJzNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTWpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURJeElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TUFvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZbndLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lud0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMa0ZqWTJWemMwMWhibUZuWlhJdVkyRnVRMkZzYkNoallXeHNaWEk2SUdKNWRHVnpMQ0IwWVhKblpYUTZJR0o1ZEdWekxDQnpaV3hsWTNSdmNqb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncGpZVzVEWVd4c09nb2dJQ0FnY0hKdmRHOGdNeUF5Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJqWVc1RFlXeHNYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ21OaGJrTmhiR3hmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdhWE5VWVhKblpYUkRiRzl6WldRS0lDQWdJR0o2SUdOaGJrTmhiR3hmWld4elpWOWliMlI1UURVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnlaWFJ6ZFdJS0NtTmhia05oYkd4ZlpXeHpaVjlpYjJSNVFEVTZDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNBOVBRb2dJQ0FnWW01NklHTmhia05oYkd4ZmFXWmZZbTlrZVVBM0NpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1BUMEtJQ0FnSUdKNklHTmhia05oYkd4ZlpXeHpaVjlpYjJSNVFEZ0tDbU5oYmtOaGJHeGZhV1pmWW05a2VVQTNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lsOWxlR1ZqZFhScGIyNUpaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYMlY0WldOMWRHbHZia2xrSUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJoaGMyaEZlR1ZqZFhScGIyNUpaQW9nSUNBZ1BUMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY21WMGMzVmlDZ3BqWVc1RFlXeHNYMlZzYzJWZlltOWtlVUE0T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBWR0Z5WjJWMFJuVnVZM1JwYjI1U2IyeGxDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTJGc2JITjFZaUJvWVhOU2IyeGxDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTJGc2JITjFZaUJvWVhOU2IyeGxDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhCdmNBb2dJQ0FnWW5vZ1kyRnVRMkZzYkY5MFpYSnVZWEo1WDJaaGJITmxRREV3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNBaENpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0NtTmhia05oYkd4ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TVRvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCeVpYUnpkV0lLQ21OaGJrTmhiR3hmZEdWeWJtRnllVjltWVd4elpVQXhNRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdOaGJrTmhiR3hmZEdWeWJtRnllVjl0WlhKblpVQXhNUW9LWTJGdVEyRnNiRjkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCallXNURZV3hzWDNSbGNtNWhjbmxmYldWeVoyVkFNd29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMa0ZqWTJWemMwMWhibUZuWlhJdVpYaHdhWEpoZEdsdmJpZ3BJQzArSUhWcGJuUTJORG9LWlhod2FYSmhkR2x2YmpvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCbGVIQnBjbUYwYVc5dVgzUmxjbTVoY25sZlptRnNjMlZBTWdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbVY0Y0dseVlYUnBiMjVmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0J3ZFhOb2FXNTBJRFl3TkRnd01Bb2dJQ0FnY21WMGMzVmlDZ3BsZUhCcGNtRjBhVzl1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHVjRjR2x5WVhScGIyNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVFXTmpaWE56VFdGdVlXZGxjaTV0YVc1VFpYUmlZV05yS0NrZ0xUNGdkV2x1ZERZME9ncHRhVzVUWlhSaVlXTnJPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFwYmxObGRHSmhZMnRmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXbHVVMlYwWW1GamExOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lIQjFjMmhwYm5RZ05ETXlNREF3Q2lBZ0lDQnlaWFJ6ZFdJS0NtMXBibE5sZEdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldsdVUyVjBZbUZqYTE5MFpYSnVZWEo1WDIxbGNtZGxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhKRmJuVnRaWEpoWW14bExuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeUxtbHpWR0Z5WjJWMFEyeHZjMlZrS0hSaGNtZGxkRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LYVhOVVlYSm5aWFJEYkc5elpXUTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCcGMxUmhjbWRsZEVOc2IzTmxaRjkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwcGMxUmhjbWRsZEVOc2IzTmxaRjkwWlhKdVlYSjVYMjFsY21kbFFETTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKZmRHRnlaMlYwY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlREF3TVRFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J3ZFhOb2FXNTBJREV5T0FvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSEpsZEhOMVlnb0thWE5VWVhKblpYUkRiRzl6WldSZmRHVnlibUZ5ZVY5bVlXeHpaVUF5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdhWE5VWVhKblpYUkRiRzl6WldSZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeVJXNTFiV1Z5WVdKc1pTNXpiMnd1UVdOalpYTnpUV0Z1WVdkbGNpNW5aWFJVWVhKblpYUkdkVzVqZEdsdmJsSnZiR1VvZEdGeVoyVjBPaUJpZVhSbGN5d2djMlZzWldOMGIzSTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbWRsZEZSaGNtZGxkRVoxYm1OMGFXOXVVbTlzWlRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJR2RsZEZSaGNtZGxkRVoxYm1OMGFXOXVVbTlzWlY5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncG5aWFJVWVhKblpYUkdkVzVqZEdsdmJsSnZiR1ZmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVGtnTHk4Z0ltRnNiRzkzWldSU2IyeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnlaWFJ6ZFdJS0NtZGxkRlJoY21kbGRFWjFibU4wYVc5dVVtOXNaVjkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCblpYUlVZWEpuWlhSR2RXNWpkR2x2YmxKdmJHVmZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVFXTmpaWE56VFdGdVlXZGxjaTVuWlhSVVlYSm5aWFJCWkcxcGJrUmxiR0Y1S0hSaGNtZGxkRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LWjJWMFZHRnlaMlYwUVdSdGFXNUVaV3hoZVRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJR2RsZEZSaGNtZGxkRUZrYldsdVJHVnNZWGxmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS1oyVjBWR0Z5WjJWMFFXUnRhVzVFWld4aGVWOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0pmZEdGeVoyVjBjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEQXdNVEV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElESWdNVFFLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzVuWlhRS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQW1DaUFnSUNCeVpYUnpkV0lLQ21kbGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhsZmRHVnlibUZ5ZVY5bVlXeHpaVUF5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdaMlYwVkdGeVoyVjBRV1J0YVc1RVpXeGhlVjkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5TG1kbGRGSnZiR1ZCWkcxcGJpaHliMnhsU1dRNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncG5aWFJTYjJ4bFFXUnRhVzQ2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQm5aWFJTYjJ4bFFXUnRhVzVmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS1oyVjBVbTlzWlVGa2JXbHVYM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklEUWdMeThnSWw5eWIyeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXdNakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEpsZEhOMVlnb0taMlYwVW05c1pVRmtiV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHZGxkRkp2YkdWQlpHMXBibDkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5TG1kbGRGSnZiR1ZIZFdGeVpHbGhiaWh5YjJ4bFNXUTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BuWlhSU2IyeGxSM1ZoY21ScFlXNDZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCblpYUlNiMnhsUjNWaGNtUnBZVzVmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS1oyVjBVbTlzWlVkMVlYSmthV0Z1WDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lsOXliMnhsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCeVpYUnpkV0lLQ21kbGRGSnZiR1ZIZFdGeVpHbGhibDkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCblpYUlNiMnhsUjNWaGNtUnBZVzVmZEdWeWJtRnllVjl0WlhKblpVQXpDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VRV05qWlhOelRXRnVZV2RsY2k1blpYUlNiMnhsUjNKaGJuUkVaV3hoZVNoeWIyeGxTV1E2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwblpYUlNiMnhsUjNKaGJuUkVaV3hoZVRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJR2RsZEZKdmJHVkhjbUZ1ZEVSbGJHRjVYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ21kbGRGSnZiR1ZIY21GdWRFUmxiR0Y1WDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lsOXliMnhsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ01UZ2dNVFFLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzVuWlhRS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQW1DaUFnSUNCeVpYUnpkV0lLQ21kbGRGSnZiR1ZIY21GdWRFUmxiR0Y1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHZGxkRkp2YkdWSGNtRnVkRVJsYkdGNVgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSXVaMlYwUVdOalpYTnpLSEp2YkdWSlpEb2dkV2x1ZERZMExDQmhZMk52ZFc1ME9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwT2dwblpYUkJZMk5sYzNNNkNpQWdJQ0J3Y205MGJ5QXlJRFFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJuWlhSQlkyTmxjM05mZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS1oyVjBRV05qWlhOelgzUmxjbTVoY25sZmJXVnlaMlZBTXpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0p0WlcxaVpYSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRFlLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ05pQXhOQW9nSUNBZ1kyRnNiSE4xWWlCVWFXMWxMbWRsZEVaMWJHd0tJQ0FnSUhCdmNHNGdNd29nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdOaUF4TkFvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG1kbGRFWjFiR3dLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnWkdsbklESUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ05pQXhOQW9nSUNBZ1kyRnNiSE4xWWlCVWFXMWxMbWRsZEVaMWJHd0tJQ0FnSUhCdmNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NHOXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTmlBeE5Bb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExtZGxkRVoxYkd3S0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFl5QTFJQzh2SURJNE1UUTNORGszTmpjeE1EWTFOUW9nSUNBZ0pnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVc1MFl5QTFJQzh2SURJNE1UUTNORGszTmpjeE1EWTFOUW9nSUNBZ0pnb2dJQ0FnY21WMGMzVmlDZ3BuWlhSQlkyTmxjM05mZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1oyVjBRV05qWlhOelgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNrVnVkVzFsY21GaWJHVXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSXVhR0Z6VW05c1pTaHliMnhsU1dRNklIVnBiblEyTkN3Z1lXTmpiM1Z1ZERvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z2RXbHVkRFkwT2dwb1lYTlNiMnhsT2dvZ0lDQWdjSEp2ZEc4Z01pQXlDaUFnSUNCaWVYUmxZMTh4SUM4dklDSWlDaUFnSUNCa2RYQUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQm9ZWE5TYjJ4bFgzUmxjbTVoY25sZlptRnNjMlZBTWdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbWhoYzFKdmJHVmZkR1Z5Ym1GeWVWOXRaWEpuWlVBek9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR01nTmlBdkx5QXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhOUW9nSUNBZ1BUMEtJQ0FnSUdKNklHaGhjMUp2YkdWZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEpsZEhOMVlnb0thR0Z6VW05c1pWOWxiSE5sWDJKdlpIbEFOVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUdkbGRFRmpZMlZ6Y3dvZ0lDQWdjRzl3YmlBekNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBRV05qWlhOekNpQWdJQ0J3YjNCdUlESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY0c5d0NpQWdJQ0JpZWlCb1lYTlNiMnhsWDJKdmIyeGZabUZzYzJWQU9Bb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuUnBiV1Z6ZEdGdGNBb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJRDQ5Q2lBZ0lDQmllaUJvWVhOU2IyeGxYMkp2YjJ4ZlptRnNjMlZBT0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ21oaGMxSnZiR1ZmWW05dmJGOXRaWEpuWlVBNU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQW1DaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NtVjBjM1ZpQ2dwb1lYTlNiMnhsWDJKdmIyeGZabUZzYzJWQU9Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdoaGMxSnZiR1ZmWW05dmJGOXRaWEpuWlVBNUNncG9ZWE5TYjJ4bFgzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJR2hoYzFKdmJHVmZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVFXTmpaWE56VFdGdVlXZGxjaTVmWjNKaGJuUlNiMnhsS0hKdmJHVkpaRG9nZFdsdWREWTBMQ0JoWTJOdmRXNTBPaUJpZVhSbGN5d2daM0poYm5SRVpXeGhlVG9nZFdsdWREWTBMQ0JsZUdWamRYUnBiMjVFWld4aGVUb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbDluY21GdWRGSnZiR1U2Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVUpKSUhaaGJHbGtZWFJwYjI0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUdaeVlXMWxYMkoxY25rZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVUpKSUhaaGJHbGtZWFJwYjI0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUdaeVlXMWxYMkoxY25rZ0xURUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnYVc1MFl5QTJJQzh2SURFNE5EUTJOelEwTURjek56QTVOVFV4TmpFMUNpQWdJQ0E5UFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6YzAxaGJtRm5aWEpNYjJOclpXUlNiMnhsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UWWdMeThnSW0xbGJXSmxjbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F3SURZS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdJUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTU2SUY5bmNtRnVkRkp2YkdWZlpXeHpaVjlpYjJSNVFEUUtJQ0FnSUdOaGJHeHpkV0lnVkdsdFpTNTBhVzFsYzNSaGJYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURVZ0x5OGdNamd4TkRjME9UYzJOekV3TmpVMUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnVkdsdFpTNTBiMFJsYkdGNUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdjSFZ6YUdsdWRDQXhOQW9nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWFYUnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05EZ0tJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ01pQTJDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9LWDJkeVlXNTBVbTlzWlY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQnpaWFJpYVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc1WkRWaU9HUXlOeUF2THlCdFpYUm9iMlFnSWxKdmJHVkhjbUZ1ZEdWa0tIVnBiblEyTkN4MWFXNTBPRnN6TWwwc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c0tTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2w5bmNtRnVkRkp2YkdWZlpXeHpaVjlpYjJSNVFEUTZDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ05pQXhOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuZHBkR2hWY0dSaGRHVUtJQ0FnSUhCdmNHNGdNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQTJJREUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUZScGJXVXVkMmwwYUZWd1pHRjBaUW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJRjluY21GdWRGSnZiR1ZmWVdaMFpYSmZhV1pmWld4elpVQTFDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VRV05qWlhOelRXRnVZV2RsY2k1ZmNtVjJiMnRsVW05c1pTaHliMnhsU1dRNklIVnBiblEyTkN3Z1lXTmpiM1Z1ZERvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1gzSmxkbTlyWlZKdmJHVTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWXlBMklDOHZJREU0TkRRMk56UTBNRGN6TnpBNU5UVXhOakUxQ2lBZ0lDQTlQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjMDFoYm1GblpYSk1iMk5yWldSU2IyeGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRZZ0x5OGdJbTFsYldKbGNuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXdJRFlLSUNBZ0lHSjBiMmtLSUNBZ0lHSnVlaUJmY21WMmIydGxVbTlzWlY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2w5eVpYWnZhMlZTYjJ4bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURKa09EbGxPVEEzSUM4dklHMWxkR2h2WkNBaVVtOXNaVkpsZG05clpXUW9kV2x1ZERZMExIVnBiblE0V3pNeVhTa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2tWdWRXMWxjbUZpYkdVdWMyOXNMa0ZqWTJWemMwMWhibUZuWlhJdVoyVjBVMk5vWldSMWJHVW9hV1E2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q21kbGRGTmphR1ZrZFd4bE9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nWjJWMFUyTm9aV1IxYkdWZmRHVnlibUZ5ZVY5bVlXeHpaVUF5Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0taMlYwVTJOb1pXUjFiR1ZmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVgzTmphR1ZrZFd4bGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ01DQTJDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnWDJselJYaHdhWEpsWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdhVzUwWXlBMUlDOHZJREk0TVRRM05EazNOamN4TURZMU5Rb2dJQ0FnSmdvZ0lDQWdjbVYwYzNWaUNncG5aWFJUWTJobFpIVnNaVjkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCblpYUlRZMmhsWkhWc1pWOTBaWEp1WVhKNVgyMWxjbWRsUURNS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlMbDlqYjI1emRXMWxVMk5vWldSMWJHVmtUM0FvYjNCbGNtRjBhVzl1U1dRNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNsOWpiMjV6ZFcxbFUyTm9aV1IxYkdWa1QzQTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKZmMyTm9aV1IxYkdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMkNpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRE15Q2lBZ0lDQmthV2NnTVFvZ0lDQWdJUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjMDFoYm1GblpYSk9iM1JUWTJobFpIVnNaV1FLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzUwYVcxbGMzUmhiWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpUV0Z1WVdkbGNrNXZkRkpsWVdSNUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRjlwYzBWNGNHbHlaV1FLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQlkyTmxjM05OWVc1aFoyVnlSWGh3YVhKbFpBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURZZ05Bb2dJQ0FnWW5sMFpXTWdNVGdnTHk4Z01IZ3dNREF3TURBd01EQXdNREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhoWkROa05EQmtaQ0F2THlCdFpYUm9iMlFnSWs5d1pYSmhkR2x2YmtWNFpXTjFkR1ZrS0hWcGJuUTRXek15WFN4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxja1Z1ZFcxbGNtRmliR1V1YzI5c0xrRmpZMlZ6YzAxaGJtRm5aWEl1YUdGemFFOXdaWEpoZEdsdmJpaGpZV3hzWlhJNklHSjVkR1Z6TENCMFlYSm5aWFE2SUdKNWRHVnpMQ0JrWVhSaE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtaGhjMmhQY0dWeVlYUnBiMjQ2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQm9ZWE5vVDNCbGNtRjBhVzl1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtaGhjMmhQY0dWeVlYUnBiMjVmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURZd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCd2RYTm9hVzUwSURNeENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdsdWRDQXpNUW9nSUNBZ0t3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0F2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3RsWTJOaGF6STFOZ29nSUNBZ2NtVjBjM1ZpQ2dwb1lYTm9UM0JsY21GMGFXOXVYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdoaGMyaFBjR1Z5WVhScGIyNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVFXTmpaWE56VFdGdVlXZGxjaTVmWTJobFkydEJkWFJvYjNKcGVtVmtLQ2tnTFQ0Z2RtOXBaRG9LWDJOb1pXTnJRWFYwYUc5eWFYcGxaRG9LSUNBZ0lIQnliM1J2SURBZ01Bb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOXRjMmRFWVhSaENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJmWTJGdVEyRnNiRk5sYkdZS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQmZiWE5uUkdGMFlRb2dJQ0FnWTJGc2JITjFZaUJmWTJGdVEyRnNiRk5sYkdZS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCdmNBb2dJQ0FnWW01NklGOWphR1ZqYTBGMWRHaHZjbWw2WldSZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1ltNTZJRjlqYUdWamEwRjFkR2h2Y21sNlpXUmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lHTmhiR3h6ZFdJZ1gyMXpaMFJoZEdFS0lDQWdJR05oYkd4emRXSWdYMmRsZEVGa2JXbHVVbVZ6ZEhKcFkzUnBiMjV6Q2lBZ0lDQndiM0J1SURNS0lDQWdJR1Z5Y2lBdkx5QkJZMk5sYzNOTllXNWhaMlZ5Vlc1aGRYUm9iM0pwZW1Wa1FXTmpiM1Z1ZEFvS1gyTm9aV05yUVhWMGFHOXlhWHBsWkY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCallXeHNjM1ZpSUY5dGMyZEVZWFJoQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQm9ZWE5vVDNCbGNtRjBhVzl1Q2lBZ0lDQmpZV3hzYzNWaUlGOWpiMjV6ZFcxbFUyTm9aV1IxYkdWa1QzQUtJQ0FnSUhCdmNBb0tYMk5vWldOclFYVjBhRzl5YVhwbFpGOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5TGw5blpYUkJaRzFwYmxKbGMzUnlhV04wYVc5dWN5aGtZWFJoT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJORG9LWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1ek9nb2dJQ0FnY0hKdmRHOGdNU0F6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJREUzSUM4dklEQjRNRFFLSUNBZ0lHSThDaUFnSUNCaWVpQmZaMlYwUVdSdGFXNVNaWE4wY21samRHbHZibk5mWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd2JpQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEpsZEhOMVlnb0tYMmRsZEVGa2JXbHVVbVZ6ZEhKcFkzUnBiMjV6WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MzVmljM1J5YVc1bklEQWdOQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZzFNelUxTVdJNENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUY5blpYUkJaRzFwYmxKbGMzUnlhV04wYVc5dWMxOXBabDlpYjJSNVFEY0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnek1HTmhaVEU0TndvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5OZmFXWmZZbTlrZVVBM0NpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRJNU5qSTVOVElLSUNBZ0lEMDlDaUFnSUNCaWJub2dYMmRsZEVGa2JXbHVVbVZ6ZEhKcFkzUnBiMjV6WDJsbVgySnZaSGxBTndvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0UyTkdRNU5XTmxDaUFnSUNBOVBRb2dJQ0FnWW01NklGOW5aWFJCWkcxcGJsSmxjM1J5YVdOMGFXOXVjMTlwWmw5aWIyUjVRRGNLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtNakppTlRrNE9Rb2dJQ0FnUFQwS0lDQWdJR0o2SUY5blpYUkJaRzFwYmxKbGMzUnlhV04wYVc5dWMxOWhablJsY2w5cFpsOWxiSE5sUURnS0NsOW5aWFJCWkcxcGJsSmxjM1J5YVdOMGFXOXVjMTlwWmw5aWIyUjVRRGM2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnlaWFJ6ZFdJS0NsOW5aWFJCWkcxcGJsSmxjM1J5YVdOMGFXOXVjMTloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UaG1aakU0TTJNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1elgybG1YMkp2WkhsQU1URUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5qZGlaRE01TlFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5OZmFXWmZZbTlrZVVBeE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBNFpEWXhNakprQ2lBZ0lDQTlQUW9nSUNBZ1lub2dYMmRsZEVGa2JXbHVVbVZ6ZEhKcFkzUnBiMjV6WDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ2w5blpYUkJaRzFwYmxKbGMzUnlhV04wYVc5dWMxOXBabDlpYjJSNVFERXhPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemRXSnpkSEpwYm1jZ05DQXpOZ29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCallXeHNjM1ZpSUdkbGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxkSE4xWWdvS1gyZGxkRUZrYldsdVVtVnpkSEpwWTNScGIyNXpYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1qVmpORGN4WVRBS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1elgybG1YMkp2WkhsQU1UUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaU4yUXlZakUyTWdvZ0lDQWdQVDBLSUNBZ0lHSjZJRjluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1YzE5aFpuUmxjbDlwWmw5bGJITmxRREUxQ2dwZloyVjBRV1J0YVc1U1pYTjBjbWxqZEdsdmJuTmZhV1pmWW05a2VVQXhORG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MzVmljM1J5YVc1bklEUWdNellLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFVtOXNaVUZrYldsdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY21WMGMzVmlDZ3BmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5OZllXWjBaWEpmYVdaZlpXeHpaVUF4TlRvS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZMkZzYkhOMVlpQm5aWFJVWVhKblpYUkdkVzVqZEdsdmJsSnZiR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSkZiblZ0WlhKaFlteGxMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlMbDlqWVc1RFlXeHNSWGgwWlc1a1pXUW9ZMkZzYkdWeU9pQmllWFJsY3l3Z2RHRnlaMlYwT2lCaWVYUmxjeXdnWkdGMFlUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncGZZMkZ1UTJGc2JFVjRkR1Z1WkdWa09nb2dJQ0FnY0hKdmRHOGdNeUF5Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0lpQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJRjlqWVc1RFlXeHNSWGgwWlc1a1pXUmZhV1pmWW05a2VVQXlDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQVDBLSUNBZ0lHSjZJRjlqWVc1RFlXeHNSWGgwWlc1a1pXUmZaV3h6WlY5aWIyUjVRRE1LQ2w5allXNURZV3hzUlhoMFpXNWtaV1JmYVdaZlltOWtlVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1gyTmhia05oYkd4VFpXeG1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEpsZEhOMVlnb0tYMk5oYmtOaGJHeEZlSFJsYm1SbFpGOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QXdlREEwQ2lBZ0lDQmlQQW9nSUNBZ1lub2dYMk5oYmtOaGJHeEZlSFJsYm1SbFpGOTBaWEp1WVhKNVgyWmhiSE5sUURVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BmWTJGdVEyRnNiRVY0ZEdWdVpHVmtYM1JsY201aGNubGZiV1Z5WjJWQU5qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxkSE4xWWdvS1gyTmhia05oYkd4RmVIUmxibVJsWkY5MFpYSnVZWEo1WDJaaGJITmxRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITjFZbk4wY21sdVp5QXdJRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdZMkZ1UTJGc2JBb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpSUY5allXNURZV3hzUlhoMFpXNWtaV1JmZEdWeWJtRnllVjl0WlhKblpVQTJDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VRV05qWlhOelRXRnVZV2RsY2k1ZlkyRnVRMkZzYkZObGJHWW9ZMkZzYkdWeU9pQmllWFJsY3l3Z1pHRjBZVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BmWTJGdVEyRnNiRk5sYkdZNkNpQWdJQ0J3Y205MGJ5QXlJRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJaUlLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJREI0TURRS0lDQWdJR0k4Q2lBZ0lDQmllaUJmWTJGdVEyRnNiRk5sYkdaZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2dwZlkyRnVRMkZzYkZObGJHWmZhV1pmWW05a2VVQXhPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tYMk5oYmtOaGJHeFRaV3htWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lEMDlDaUFnSUNCaWJub2dYMk5oYmtOaGJHeFRaV3htWDJsbVgySnZaSGxBTkFvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1lucGxjbThLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUQwOUNpQWdJQ0JpZWlCZlkyRnVRMkZzYkZObGJHWmZZV1owWlhKZmFXWmZaV3h6WlVBMUNncGZZMkZ1UTJGc2JGTmxiR1pmYVdaZlltOWtlVUEwT2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjM1ZpYzNSeWFXNW5JREFnTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbDlsZUdWamRYUnBiMjVKWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWDJWNFpXTjFkR2x2Ymtsa0lHVjRhWE4wY3dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJmYUdGemFFVjRaV04xZEdsdmJrbGtDaUFnSUNBOVBRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWpZVzVEWVd4c1UyVnNabDloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1ekNpQWdJQ0J3YjNCdUlESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5NS0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCZloyVjBRV1J0YVc1U1pYTjBjbWxqZEdsdmJuTUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnY0c5d2JpQXlDaUFnSUNCaWJub2dYMk5oYmtOaGJHeFRaV3htWDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHTmhiR3h6ZFdJZ2FYTlVZWEpuWlhSRGJHOXpaV1FLSUNBZ0lHSnVlaUJmWTJGdVEyRnNiRk5sYkdaZmFXWmZZbTlrZVVBeENncGZZMkZ1UTJGc2JGTmxiR1pmWVdaMFpYSmZhV1pmWld4elpVQTRPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqWVd4c2MzVmlJR2hoYzFKdmJHVUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqWVd4c2MzVmlJR2hoYzFKdmJHVUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY0c5d0NpQWdJQ0JpZWlCZlkyRnVRMkZzYkZObGJHWmZhV1pmWW05a2VVQXhDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3TWdvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvTG0xaGVBb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvTG0xaGVBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdaSFZ3Q2lBZ0lDQWhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VRV05qWlhOelRXRnVZV2RsY2k1ZmFYTkZlSEJwY21Wa0tIUnBiV1Z3YjJsdWREb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbDlwYzBWNGNHbHlaV1E2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFl5QTFJQzh2SURJNE1UUTNORGszTmpjeE1EWTFOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dkbUZzYVdSaGRHbHZiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpJRFVnTHk4Z01qZ3hORGMwT1RjMk56RXdOalUxQ2lBZ0lDQW1DaUFnSUNCbWNtRnRaVjlpZFhKNUlDMHhDaUFnSUNCallXeHNjM1ZpSUdWNGNHbHlZWFJwYjI0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFVnTHk4Z01qZ3hORGMwT1RjMk56RXdOalUxQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JqWVd4c2MzVmlJRlJwYldVdWRHbHRaWE4wWVcxd0NpQWdJQ0E4UFFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlSVzUxYldWeVlXSnNaUzV6YjJ3dVFXTmpaWE56VFdGdVlXZGxjaTVmYUdGemFFVjRaV04xZEdsdmJrbGtLSFJoY21kbGREb2dZbmwwWlhNc0lITmxiR1ZqZEc5eU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsOW9ZWE5vUlhobFkzVjBhVzl1U1dRNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lubDBaV01nTWpNZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpSmdvZ0lDQWdZbmwwWldNZ01qTWdMeThnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaUpnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdTR0Z6YUdWekxtVm1abWxqYVdWdWRFdGxZMk5oYXpJMU5nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5Ulc1MWJXVnlZV0pzWlM1emIyd3VRV05qWlhOelRXRnVZV2RsY2k1ZmJYTm5SR0YwWVNncElDMCtJR0o1ZEdWek9ncGZiWE5uUkdGMFlUb0tJQ0FnSUhCeWIzUnZJREFnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjRzRnTVRRS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRFV3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtDbDl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU5Eb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUGdvZ0lDQWdZbm9nWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFEYzZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERXpDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0ErQ2lBZ0lDQmllaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFEa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtDbDl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU1UQTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01UTUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhOQW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnUGdvZ0lDQWdZbm9nWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXhNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29LWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXhNem9LSUNBZ0lHWnlZVzFsWDJScFp5QXhOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUQ0S0lDQWdJR0o2SUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNVFVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNVFk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEVUtJQ0FnSUQ0S0lDQWdJR0o2SUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNVGdLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNVGs2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUQ0S0lDQWdJR0o2SUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNakVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNakk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEY0tJQ0FnSUQ0S0lDQWdJR0o2SUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNalU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFVLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1Bnb2dJQ0FnWW5vZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TndvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nT0FvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF5T0RvS0lDQWdJR1p5WVcxbFgyUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTmdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ1Bnb2dJQ0FnWW5vZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nT1FvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TVRvS0lDQWdJR1p5WVcxbFgyUnBaeUEyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTndvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lENEtJQ0FnSUdKNklGOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTXpNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFd0NncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURNME9nb2dJQ0FnWm5KaGJXVmZaR2xuSURjS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBNENpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0F4TVFvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01URUtDbDl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU16YzZDaUFnSUNCbWNtRnRaVjlrYVdjZ09Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEa0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURFeUNpQWdJQ0ErQ2lBZ0lDQmllaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFETTVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhNZ29LWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQTBNRG9LSUNBZ0lHWnlZVzFsWDJScFp5QTVDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNVEFLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERXpDaUFnSUNBK0NpQWdJQ0JpZWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRFF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TXdvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTXpvS0lDQWdJR1p5WVcxbFgyUnBaeUF4TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFeENpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0F4TkFvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME5Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UUUtDbDl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU5EWTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01URUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhNZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ01UVUtJQ0FnSUQ0S0lDQWdJR0o2SUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFORGdLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREUxQ2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDIxbGNtZGxRRFE1T2dvZ0lDQWdabkpoYldWZlpHbG5JREV5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTlRFNkNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME9Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDIxbGNtZGxRRFE1Q2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRFExT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU5EWUtDbDl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU5ESTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdJZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTXdvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF6T1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFEUXdDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFETTJPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlGOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTXpjS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTXpNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbnBsY204S0lDQWdJR0lnWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXpOQW9LWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXpNRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURNeENncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURJM09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNamdLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNalE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHSWdYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU5Rb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU1Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDIxbGNtZGxRREl5Q2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRREU0T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU1Ua0tDbDl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU1UVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdJZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TmdvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFERXpDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFEazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdJZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TUFvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUEyT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU53b0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0lnWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQTBDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFEVXdPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlGOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTlRFSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEpGYm5WdFpYSmhZbXhsTG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5TG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUhBQUVnQ1AvLy8vOFAvLy8vLy8vL1AvLy8vLy8vLy8vLy93RW1HQVFWSDN4MUFBb0FBQUFBQUFBQUFBQUFGQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQmw5eWIyeGxjeUlBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDbDl6WTJobFpIVnNaWE1NWDJWNFpXTjFkR2x2Ymtsa0NGOTBZWEpuWlhSekVnQVJBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUFJUUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBNWZYMk4wYjNKZmNHVnVaR2x1WndJQUFBRUJJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUIyMWxiV0psY25NQkJBWUFBQUFBQUFBTVlXeHNiM2RsWkZKdmJHVnpBZ0FnSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFQUFBQUFJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRQUFBQUFBQUFBQUZQLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy9Ja2NUS1VjUGdZQWdyMGsxQlRVQU5BQ0FJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDQVhFQTFBREVZUUFBR0p3d2paeU5ETVJrVVJERVlSSUloQkprUE1LNEUwSGxrTVFTZXFsYzZCTS95NWlFRTFFUVBWd1NIMVVVTEJDd0t6WUVFMm5VTEl3UVQ2U2lHQkQyOGJVTUVrUFdPZFFUeEJtZVpCSWtjTjBvRXhONFhDd1R4aW9Pb0JMVVNWVndFTGZBcUp3UW9STnVlQkRSSy8wQUUyV3VLZlFRRzdjTXVCTWJWRlM0RXJKeTZEZ1NGMDRMaEJDb3l6ZEVFTzF5Z2hnUXNnMmJZQkdhYXdFc0VCSlVjS1FUZG1DalZCRzNEQXdVRXYyTjJXd1FFa1pvbU5ob0FqaUVLVWdvbkNoMEtFd244Q2VFSnp3bThDYWtKbGdsdUNVc0krUWlxQ0hjSVBnZXlCeVlHbWdZT0JZd0ZEUVQ3Qk1jRG9RTCtBa0VCMndHeEFXZ0JSZ0VrQUFFQU5ob0JTU0paU1VVUGdRSUxSUWRKRlVVRFZ3SUFSU0lpUlFwTENVc05ERUVBSjBzSlNZRUNDMHNqU1U4Q1dVbExDVWxPQkJKRVN3RVZVaUpaZ1FJSUNFVUhJd2hGQ2tMLzBVc0ZnUUlJU3dJU1JERVdRUURJTVJZakNUZ0lGRVFuRFVVa0lrVVBTdzVMRFF4QkFEOUxJMGtpV1VtQkFndUJBZ2hMQW9FQ1N3SlNnUUt2VUVzREZVOEVUd05QQWxJbkRWQlFUQ01JU1JaWEJnQk9BaUtJQ2VkUVN3OGpDRVVRUlNSQy83a3BSUjFMSTBVWFN3d1dTeDJsUVFCYk5BQTFBQ1d2U3gxSlRnSlFTUlVsQ1Z0TEdFbE9BaUpaU3dFTlJFc0JVUUFDU1JkUEExY0NBRXNEZ1FJTFN3Rk1XVXBaU3dFSWdRSUlTd0lpVHdOU0p3MVFTd0lWVEU0RFVsQk1Ud09JQ1h0UVJSZ25EcUJGSFVML25DaExGMUN3STBNaVF2ODZNUlpCQUJreEZpTUpPQWdVUklBTUZSOThkZi8vLy8vLy8vLy9zQ05ESWtMLzZURVdRUUFaTVJZakNUZ0lGRVNBREJVZmZIVUFBQUFBQUFBQUFMQWpReUpDLytrMkdnRkpSUlVWSkJKRU5ob0NTVVVhRlNRU1JERVdRUUFzTVJZakNUZ0lGRVNJRDg2eFN4T0JHRnVCQnJJUUlySVpJcklCc2hpQUJNM2FUcWF5R2tzWXNocXpJME1pUXYvV05ob0JTUlVrRWtRMkdnSkpGU1FTUkRZYUEwa2lXWUVDQ0VzQkZSSkVWd0lBaUE4Z0tFeFFzQ05ETmhvQlNVVWlGU1FTUkRZYUFra2lXWUVDQ0VzQkZSSkVWd0lBUlI4eEZrRUFRREVXSXdrNENCUkVNUUN4U1lFWVc0RUdzaEFpc2hraXNnR3lHSUFFelZFOXBiSWFzN1ErVndRQWdBU1BzMkEzRXhSRVN5Rk1TeUNJRHI2SURtMUlJME1pUXYvQ05ob0JTVVVpRlNRU1JEWWFBa2xGRlJVa0VrUTJHZ05KSWxtQkFnaExBUlVTUkZjQ0FFVWZNUlpCQUkweEZpTUpPQWdVUkRFQVNVVWJTeDlKVVFBRVJSaExJa2xPQWtzWFR3S0lEbWRKUlJzQkp3Wk1VRWxGSHI0cVRnSk5Wd0FHRnhRVVJCTkJBQ0lpU3hwSlRnS0lESU5JVEVzVlN4aUlDMENJQzdKTWlBeHpTRVVLUUFBRFN3aEVTeHBKdmlwT0FrMVhCZ1FuRWt4UVRFc0J2NEVHV2trV1N4bE1VSUFFYzJyMHJFeFFzQ0VFR2hZb1RGQ3dJME1pUXY5MU5ob0JTVVVWU1JVa0VrUTJHZ0pKSWxtQkFnaExBUlVTUkZjQ0FFbEZJVEVBU1VVa1NVc0RTd09JRHpkSVRnTk9Bb2dQTDBVRlNFQUFCVXNDRkJSRVN5QkxGRXNnaUEydlJSZ2lSUWRMQWtBQUNFc1hpQTBqUVFBSFN4ZUlEVXBGQnlJbkIyVk1SUjlFU3g1UkFBUkxGRXlJRC80bkIweG5NUlpCQUNJeEZpTUpPQWdXU3hSTElFOENpQWRLU0NjSFN4NW5Td1loQkJvV0tFeFFzQ05ESWtMLzREWWFBVWxGRlJVa0VrUTJHZ0pKUlJOSklsbUJBZ2hMQVJVU1JGY0NBRVVmTmhvRFNSVWxFa1FYUlFFeEZrRUE4akVXSXdrNENCUkVSd0loQlE1RUlRVWFTVVVDTVFCSlJTTkxGVXNoaUE1d1JRR0lDQjFMQVFoSlJSTWhCUTVFRkJSRVFRQUdTVXNRREJSRUphOUxBUlpMRVJaS2lBZTZTd05NVUU0Q2lBZXhUd0pNVUJVbENWc2hCUnBGQVVzZ1N4UkxJSWdNdmtsRkdRRW5Ca3hRU1VVY3ZpcE9BazFYQUFZWFNVVUdRUUFHU3dTSUR2cEVTeHBKdmlwT0FrMUpnUVphSXdpQmdJQ0FnQkFZVEZjR0JFc0RGa21UZ1RBT1JFbFhBZ1pQQWxCTEFoWkpreVFPUkVsWEJBUlBBbGNBQmt4UVR3Uk12MHNhU1U0RFRGQk1VRXNqVUVzV1VJQUNBSEpRU3hSUWdBVDR0M2thVEZDd1RDRUVHaFpRS0V4UXNDTkRJa0wvRURZYUFVbEZIUlVrRWtReEZrRUFJVEVXSXdrNENCUkVTeHNCSndaTVVMNHFUZ0pOZ1FaYUlRUWFGaWhNVUxBalF5SkMvK0UyR2dGSkZTUVNSSWdMY2hZb1RGQ3dJME0yR2dGSlJSVVZKQkpFTmhvQ1NVVVRTUlVqRWtRaVUwVU1NUlpCQUYweEZpTUpPQWdVUklnTUpFc0xJdzVFU3hOSkFTY0lURkJKdmljSlRnSk5TVmNDRGtzQklsbExBaFZQQTA0Q1VsY0NBRWtWRmxjR0FreFFnQUlBRVU4Q1VFc1ZTVTREVUV4UVN3SzhTRThDVEw5UWdBVE9lbVVQVEZDd0kwTWlRditsTmhvQlNVVVZGU1FTUkRZYUFra1ZKUkpFRjBVSU1SWkJBR1F4RmlNSk9BZ1VSSWdMcVVzSFNTRUVEa1FoQkJwSklRUU9SQ0VFR2tzVVNVNENBU2NJVEZCSnZpY0pUZ0pOVndJT2lBZmRTd05NaUFhaFJnSytKd2xPQWsxWEFnNklCOGxMQWt5SUJvMU9Ba2dXVEJaT0FsQk1VSUFFdzZIeUlVeFFzQ05ESWtML25qWWFBVWxGRkJVa0VrUTJHZ0pKUlJaSklsbEpSUkNCQkF1QkFnaE1GUkpFTmhvRFNVVVNTUlVsRWtRWFJRUXhGa0VBVlRFV0l3azRDQlJFaUFzT0loWkZIVXNORmtzZHBVRUFPeVd2U3gxSlRnSlFTUlVsQ1Z0TEZsY0NBRXlCQkF1QkJGaEpBU2NUVEZCTEJoYS9TeFJNVUVzU1VJQUUxVWxpbDB4UXNDY09vRVVkUXYrOEkwTWlRdit0TmhvQlNVVVVTUlVsRWtRWFJRUTJHZ0pKRlNVU1JCZEZDREVXUVFCcU1SWWpDVGdJRkVTSUNwZExCMGtoQkE1RUlRUWFTU0VFRGtRaEJCcExCRWtoQmhJVVJCWUJKd1JNVUVtK0p3Vk9BazFYRWc2SUJzZExBMHlJQll0R0FyNG5CVTRDVFZjU0RvZ0dzMHNDVElnRmQwNENTQlpNRmtzVVR3SlFURkNBQkszcFU4OU1VTEFqUXlKQy81ZzJHZ0ZKUlJSSkZTVVNSQmRGQkRZYUFrbEZFeFVsRWtReEZrRUFhekVXSXdrNENCUkVpQW9NU3dOSkZCUkVTU0VHRWhSRUZnRW5CRXhRU2I0bkJVNENUVWxYQWdoTEFWY1NEa3NDSWxsTEF4VlBCRTRDVWxjQ0FFa1ZGbGNHQWt4UUp4UlBBMUJMRlVsT0ExQlBBMUJNVUVzQ3ZFaFBBa3kvU3hOTVVJQUVhOGVIeGt4UXNDTkRJa0wvbHpZYUFVbEZGRWtWSlJKRUYwVUVOaG9DU1VVVEZTVVNSREVXUVFCck1SWWpDVGdJRkVTSUNZQkxBMGtVRkVSSklRWVNGRVFXQVNjRVRGQkp2aWNGVGdKTlNWY1NEa3NCVndvSVN3SWlXVXNERlU4RVRnSlNWd0lBU1JVV1Z3WUNURkFuRkVzV1NVNERVRThEVUU4RFVFeFFTd0s4U0U4Q1RMOUxFMHhRZ0FUOVRQaVFURkN3STBNaVF2K1hOaG9CU1JVbEVrUVhSUVEyR2dKSlJTRVZKQkpFTVJaQkFCc3hGaU1KT0FnVVJERUFTeUJKVHdJVEZFUkxCRXlJQjlGSUkwTWlRdi9uTmhvQlNSVWxFa1FYUlFRMkdnSkpSU1FWSkJKRU1SWkJBQlV4RmlNSk9BZ1VSSWdJdmtzRFN5T0lCNTVJSTBNaVF2L3ROaG9CU1JVbEVrUVhSUVEyR2dKSlJTUVZKQkpFTmhvRFNSVWxFa1FYUlFzeEZrRUFKakVXSXdrNENCUkVpQWlBU3dwSklRUU9SQ0VFR2tzRVNZZ0ZyRXNsVEU4RGlBYWJTQ05ESWtMLzNEWWFBVWxGRkVrVkpSSkVGMFVFTmhvQ1NVVVRTU0paZ1FJSVRCVVNSREVXUVFBck1SWWpDVGdJRkVTSUNETkxBMGtVRkVRaEJoSVVSRXNTZ0FJQUNsQkxFbENBQkRLTGdXOU1VTEFqUXlKQy85YzJHZ0ZKRlNVU1JCYzJHZ0pKRlNRU1JJZ0YxaWNLSWs4RFZFd1dVQ2hNVUxBalF6WWFBVWtWSlJKRUZ6WWFBa2tWSkJKRWlBVkFUd01XVHdNV1VFOENGbEJNRmxBb1RGQ3dJME0yR2dGSkZTVVNSQmVJQlBRV0tFeFFzQ05ETmhvQlNSVWxFa1FYaUFTN0ZpaE1VTEFqUXpZYUFVa1ZKUkpFRjRnRWdoWW9URkN3STBNMkdnRkpGU1FTUklnRVJSWW9URkN3STBNMkdnRkpGU1FTUkRZYUFra1ZnUVFTUklnRUJoWW9URkN3STBNMkdnRkpGU1FTUklnRHhpY0tJazhDVkNoTVVMQWpRNGdEb1JZb1RGQ3dJME9JQTRFV0tFeFFzQ05ETmhvQlNSVWtFa1EyR2dKSkZTUVNSRFlhQTBrVmdRUVNSSWdDNHljS0lrOERWRXdXVUNoTVVMQWpRellhQVVrVkpCSkVKd3hrUkNjTUltY25DSUVDdVVnbkJJRUN1VWduQm9FQ3VVZ25CeWNQWjBrbkR4SVVSQ0pNSWttSUJRZElJME9LQXdHTC9vRUNDMG1MLzRFQ0M0djlTd0ZaVHdKTWkvOU5USXNDaXdBTVFRQWxpd0ZKRmxjR0FJdjlpd0pKVGdSUEFsMUpqUDFMQVZtQkFnZ0lqQUdCQWdpTUFrTC8wNHY5akFDSmlnTUJNZ3B6QUVnV2kvK2tGRVNML1l2L2kvNklBR3BKaS8yQkdGdHlBRWhNUVFBWGlBQ0hLYVZBQUFtTEFSVVdLYVZCQUFhSUFIeU1BSW1MQUJSRWlBQnNLYVZFUWdDZmlnSUJOQUFrcjBtTC9sQkpGU1FKSkZoUEFreGNBRXNCaS85UVNSVWtDU1JZWENCSlZ3QkFBazhDVEZCSkZTUUpKRmhYQUNCTU5RQ0ppZ01CTkFBbHI0di9nQUVnb0NjTHFrc0JURkJKRlNVSlcweUwvMUJKRlNVSlcwc0NUZ0pZWEFBMUFDT0pOQUExQUNtSk5BQWxyMHNCVjBBZ1RFc0JVRWtWSlFsYkpLOVBBMDhDSnc5ZFN3S0FBU0NnSnd1cVR3Sk1VRWtWSkFra1dGeEFOUUNKQUlvREFZditpLyt0aS8ySUFEYWpKd3VxaS8rdGlZb0NBWXYraS8rbGkvNkwvNGovM0ltS0FRR0wvNEFHLy8vLy8vLy9wUlJFSmErTC8xQkpGU1VKV3lFRkdvbUtBUUUwQUl2L0ZCUXBKdzVQQWsxTU5RQ0pNZ2NXaVAvSmlZb0JBWXYvRm9tS0FnTXBpLzZJQUtwR0E0ditpQUNqU1U0RFRnTkdBb3YraUFDWFNFNENTSXYraUFDT1JnSk9Bb3YvRGtFQURpS01BQ0tMQUV4UEJVOEZUd1dKaXdGTWpBQ0xBa3hDLyt1S0FRT0kvNlNMLzB5SS82eUppZ0VCaS8rSS8rdEdBb21LQXdLTC9Zai83VW1ML2cxQkFFQ0xBSXYrQ1VraEJBNUVKYStML3haUEFoWktpUDhzU3dOTVVFNENpUDhqVHdKTVVCVWxDVnNoQkJxSS8xWUlTU0VGRGtTTEFJditTd0tJQUQ5TVR3S0pJa0wveG9vQkF5V3ZTWXYvVUVrVkpRbGJJUVFhaS84bkZhSkxBa3hRU1JVbENWc2hCQnFML3ljV29rOERURkJKRlNVSld5RUZHa3hPQW9tS0F3R0wveFluRnFNbkM2cUwvUlluRmFNbkM2cXJpLzRXcTRtS0F3SXBTVEVXUVFCdE1SWWpDVGdJRkVTTC9vZ0FrRUVBQnlKSlR3TlBBNGt5Q292OUVrQUFEWUVZcnpJSUZsQ0wvUkpCQUJNaUp3ZGxSSXYraS8rSUJnZ1NJazhEVHdPSmkvNkwvNGdBaFVtTC9ZZ0J1VWhNaS8ySUFiS01BRWhCQUEyTEFFa1VqQUdMQVU0RFRnS0pJb3dCSWtMLzhpSkMvNVV4RmtFQURURVdJd2s0Q0JSRWdZRDFKSWtpUXYvMU1SWkJBQTB4RmlNSk9BZ1VSSUdBcnhxSklrTC85WW9CQVRFV1FRQWlNUllqQ1RnSUZFU0wvd0VuQ0V4UXZpY0pUZ0pOZ1lBQlV5Y0tJazhDVkNKVGlTSkMvK0NLQWdFeEZrRUFHREVXSXdrNENCUkVpLzhCSnhOTVVMNU1GeUpNVHdKTmlTSkMvK3FLQVFFeEZrRUFIekVXSXdrNENCUkVpLzhCSndoTVVMNG5DVTRDVFZjQ0RvaitOQ0VFR29raVF2L2ppZ0VCTVJaQkFCb3hGaU1KT0FnVVJJdi9GZ0VuQkV4UXZpY0ZUZ0pOZ1FKYmlTSkMvK2lLQVFFeEZrRUFHakVXSXdrNENCUkVpLzhXQVNjRVRGQytKd1ZPQWsyQkNsdUpJa0wvNklvQkFURVdRUUFnTVJZakNUZ0lGRVNML3hZQkp3Uk1VTDRuQlU0Q1RWY1NEb2o5dkNFRUdva2lRdi9paWdJRU1SWkJBR2N4RmlNSk9BZ1VSSXYvQVNjUVRGQkp2aXRPQWsxSlZ3QUdGMHhYQmc2SS9YNUdBMHNCdml0T0FrMVhCZzZJL1c5T0EwWUNTd0srSzA0Q1RWY0dEb2o5WGtoT0FraFBBNzRyVGdKTlZ3WU9pUDFOUmdKTUlRVWFUQ0VFR2s4Q0lRUWFUd01oQlJxSklrTC9tNG9DQWlsSk1SWkJBRW94RmlNSk9BZ1VSSXYrSVFZU1FRQUhJeUpQQTA4RGlZditpLytJLzJWR0EwbU1BWXYraS8rSS8xbEdBb3dBU0VFQUZJajhuNHNCRDBFQUN5T0xBQ0VFR2s4RFR3T0pJa0wvOGlKQy83aUtCQUdML2lFRURrU0wvaUVFR296K2kvOGhCQTVFaS84aEJCcU0vNHY4SVFZU0ZFU0wvUUVuRUV4UVNiNHJUZ0pOVndBR0Ywa1VUZ0pBQUZTSS9FZUwvZ2hKSVFVT1JJdi9pUHhCU1JXQkRnNUVnUTZ2cTBzQkZrbVRnVEFPUkZjQ0JreFFUd0pNdjR2L0ZpY0tJb3NBU1U0RVZJdjhGazhFRmt5TC9WQlBBMUJNVUV4UWdBU2RXNDBuVEZDd1RJbEp2aXRPQWsxWEJnNkwveUtJL0ZWR0FyNHJUZ0pOVndZT2kvOGlpUHhGUlFGQy83U0tBZ0dML2lFR0VoUkVpLzhCSnhCTVVFbStLMDRDVFZjQUJoZEFBQU1pVEltTEFMeElpLzRXaS85UWdBUXRpZWtIVEZDd0kweUppZ0VCTVJaQkFDTXhGaU1KT0FnVVJJdi9BU2NHVEZDK0trNENUVmNBQmhkSmlBSzBJa3hOSVFVYWlTSkMvOStLQVFHTC93RW5Ca3hRU2I0cVRnSk5TVmNBQmhkTWdRWmFTd0VVRkVTSSswdExBZ3dVUkV5SUFuOFVSRXNCdmlwT0FrMVhCZ1FuRWt4UVR3Sk12MGtXaS85TVVJQUVyVDFBM1V4UXNJbUtBd0V4RmtFQVdURVdJd2s0Q0JSRWkvMkwvbEFrcjB5QUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJnVUl2L0ZVa1dUd05NVUVrVkpBa2tXSUVmcjR2L1RGQlBBb0VmQ0NRS0pBc2lURmhRVUFLSklrTC9xWW9BQURFQVNZZ0NKMHNCVElnQlEwaE1pQUljaUFFN1RnSklRQUFlaXdGQUFBbUlBZ3VJQUJSR0F3QXlDb2dDQUlzQVRnS0kvMlNJL3hOSWlZb0JBeUtML3hVV0p4R2tRUUFHSWtjQ1R3T0ppLzlSQUFSSmpBQ0FCSVUxVWJnU1FBQXdpd0NBQkRESzRZY1NRQUFraXdDQUJGS1dLVklTUUFBWWl3Q0FCS1pObGM0U1FBQU1pd0NBQk5JcldZa1NRUUFHSXlKSlR3T0ppd0NBQkJqL0dEd1NRQUFZaXdDQUJCWjcwNVVTUUFBTWl3Q0FCQWpXRWkwU1FRQVNpLzlSQkNSWEFDQ0krLzRqSWs4Q1R3T0ppd0NBQkNYRWNhQVNRQUFNaXdDQUJMZlNzV0lTUVFBVWkvOVJCQ1JYQUNDQkdGdUkrL3dqVENKUEE0a3lDb3NBaVB1Z0lrd2lUd09KaWdNQ0tUSUtpLzRTUUFBTmdSaXZNZ2dXVUl2K0VrRUFDb3Y5aS8rSUFDdFBBb21ML3hVV0p4R2tRUUFLSW93QUlvc0FURThDaVl2L1VRQUVpLzJML2s4Q2lQcUFUSXdBUXYvbWlnSUNLVWNDaS84VkZpY1JwRUVBQnlKSmpBR01BSWt5Q292K0VrQUFEWUVZcnpJSUZsQ0wvaEpCQUJneUNvdi9VUUFFSWljSFpVUk9Bb2dBaHhJaWpBR01BSW1MLzRqK29VWUNpLytJL3BwSWpBSklpLytJL3BHTUFVWUNRQUFJTWdxSStyeEEvNmlMQWttTC9vajhHVWhNaS82SS9CS01BRWhCLzVNbHI0c0JGb3NBRmtxSStKMUxBMHhRVGdLSStKUlBBa3hRRlNVSld5RUVHa2tVakFDTUFZbUtBUUdML3lFRkRrU0wveUVGR296L2lQbytpLzhJU1NFRkRrU0krS1VPaVlvQ0FTU3ZpLzRuRjZ3bkY2eFFTUlVrQ1NSWWkvK0k5NVNKaWdBQklrY09NUnRCQVZveEcwRUJUallhQUl3QU1Sc2pEVUVCUFRZYUFZc0FURkNNRFRFYmdRSU5RUUVuTmhvQ2l3MU1VSXdPTVJ1QkF3MUJBUkUyR2dPTERreFFqQUV4RzRFRURVRUErellhQklzQlRGQ01BakViZ1FVTlFRRGxOaG9GaXdKTVVJd0RNUnVCQmcxQkFNODJHZ2FMQTB4UWpBUXhHNEVIRFVFQXVUWWFCNHNFVEZDTUJURWJKUTFCQUtRMkdnaUxCVXhRakFZeEc0RUpEVUVBampZYUNZc0dURkNNQnpFYmdRb05RUUI0TmhvS2l3ZE1VSXdJTVJ1QkN3MUJBR0kyR2d1TENFeFFqQWt4RzRFTURVRUFURFlhRElzSlRGQ01DakViZ1EwTlFRQTJOaG9OaXdwTVVJd0xNUnVCRGcxQkFDQTJHZzZMQzB4UWpBd3hHNEVQRFVFQUNqWWFENHNNVEZDTUFJa2lyMEwvOUNLdlF2L2VJcTlDLzhnaXIwTC9zaUt2UXYrY0lxOUMvNFlpcjBML2NDS3ZRdjlhSXE5Qy8wVWlyMEwvTHlLdlF2OFpJcTlDL3dNaXIwTCs3U0t2UXY3WElxOUMvc0VpcjR3QVF2NndJcTlDLzZZPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IlJvbGVHcmFudGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld01lbWJlciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUxhYmVsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxhYmVsIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlUmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlQWRtaW5DaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlR3VhcmRpYW5DaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imd1YXJkaWFuIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlR3JhbnREZWxheUNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsYXkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaW5jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0RnVuY3Rpb25Sb2xlVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGVjdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJUYXJnZXRBZG1pbkRlbGF5VXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJUYXJnZXRDbG9zZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsb3NlZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3BlcmF0aW9uU2NoZWR1bGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY2hlZHVsZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik9wZXJhdGlvbkNhbmNlbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
