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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.AccessManager_70acc03b
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWNjZXNzTWFuYWdlciIsImRlc2MiOiIgQGRldiBBY2Nlc3NNYW5hZ2VyIGlzIGEgY2VudHJhbCBjb250cmFjdCB0byBzdG9yZSB0aGUgcGVybWlzc2lvbnMgb2YgYSBzeXN0ZW0uXG4gQSBzbWFydCBjb250cmFjdCB1bmRlciB0aGUgY29udHJvbCBvZiBhbiBBY2Nlc3NNYW5hZ2VyIGluc3RhbmNlIGlzIGtub3duIGFzIGEgdGFyZ2V0LCBhbmQgd2lsbCBpbmhlcml0IGZyb20gdGhlXG4ge0FjY2Vzc01hbmFnZWR9IGNvbnRyYWN0LCBiZSBjb25uZWN0ZWQgdG8gdGhpcyBjb250cmFjdCBhcyBpdHMgbWFuYWdlciBhbmQgaW1wbGVtZW50IHRoZSB7QWNjZXNzTWFuYWdlZC1yZXN0cmljdGVkfVxuIG1vZGlmaWVyIG9uIGEgc2V0IG9mIGZ1bmN0aW9ucyBzZWxlY3RlZCB0byBiZSBwZXJtaXNzaW9uZWQuIE5vdGUgdGhhdCBhbnkgZnVuY3Rpb24gd2l0aG91dCB0aGlzIHNldHVwIHdvbid0IGJlXG4gZWZmZWN0aXZlbHkgcmVzdHJpY3RlZC5cbiBUaGUgcmVzdHJpY3Rpb24gcnVsZXMgZm9yIHN1Y2ggZnVuY3Rpb25zIGFyZSBkZWZpbmVkIGluIHRlcm1zIG9mIFwicm9sZXNcIiBpZGVudGlmaWVkIGJ5IGFuIGB1aW50NjRgIGFuZCBzY29wZWRcbiBieSB0YXJnZXQgKGBhZGRyZXNzYCkgYW5kIGZ1bmN0aW9uIHNlbGVjdG9ycyAoYGJ5dGVzNGApLiBUaGVzZSByb2xlcyBhcmUgc3RvcmVkIGluIHRoaXMgY29udHJhY3QgYW5kIGNhbiBiZVxuIGNvbmZpZ3VyZWQgYnkgYWRtaW5zIChgQURNSU5fUk9MRWAgbWVtYmVycykgYWZ0ZXIgYSBkZWxheSAoc2VlIHtnZXRUYXJnZXRBZG1pbkRlbGF5fSkuXG4gRm9yIGVhY2ggdGFyZ2V0IGNvbnRyYWN0LCBhZG1pbnMgY2FuIGNvbmZpZ3VyZSB0aGUgZm9sbG93aW5nIHdpdGhvdXQgYW55IGRlbGF5OlxuICogVGhlIHRhcmdldCdzIHtBY2Nlc3NNYW5hZ2VkLWF1dGhvcml0eX0gdmlhIHt1cGRhdGVBdXRob3JpdHl9LlxuICogQ2xvc2Ugb3Igb3BlbiBhIHRhcmdldCB2aWEge3NldFRhcmdldENsb3NlZH0ga2VlcGluZyB0aGUgcGVybWlzc2lvbnMgaW50YWN0LlxuICogVGhlIHJvbGVzIHRoYXQgYXJlIGFsbG93ZWQgKG9yIGRpc2FsbG93ZWQpIHRvIGNhbGwgYSBnaXZlbiBmdW5jdGlvbiAoaWRlbnRpZmllZCBieSBpdHMgc2VsZWN0b3IpIHRocm91Z2gge3NldFRhcmdldEZ1bmN0aW9uUm9sZX0uXG4gQnkgZGVmYXVsdCBldmVyeSBhZGRyZXNzIGlzIG1lbWJlciBvZiB0aGUgYFBVQkxJQ19ST0xFYCBhbmQgZXZlcnkgdGFyZ2V0IGZ1bmN0aW9uIGlzIHJlc3RyaWN0ZWQgdG8gdGhlIGBBRE1JTl9ST0xFYCB1bnRpbCBjb25maWd1cmVkIG90aGVyd2lzZS5cbiBBZGRpdGlvbmFsbHksIGVhY2ggcm9sZSBoYXMgdGhlIGZvbGxvd2luZyBjb25maWd1cmF0aW9uIG9wdGlvbnMgcmVzdHJpY3RlZCB0byB0aGlzIG1hbmFnZXIncyBhZG1pbnM6XG4gKiBBIHJvbGUncyBhZG1pbiByb2xlIHZpYSB7c2V0Um9sZUFkbWlufSB3aG8gY2FuIGdyYW50IG9yIHJldm9rZSByb2xlcy5cbiAqIEEgcm9sZSdzIGd1YXJkaWFuIHJvbGUgdmlhIHtzZXRSb2xlR3VhcmRpYW59IHdobydzIGFsbG93ZWQgdG8gY2FuY2VsIG9wZXJhdGlvbnMuXG4gKiBBIGRlbGF5IGluIHdoaWNoIGEgcm9sZSB0YWtlcyBlZmZlY3QgYWZ0ZXIgYmVpbmcgZ3JhbnRlZCB0aHJvdWdoIHtzZXRHcmFudERlbGF5fS5cbiAqIEEgZGVsYXkgb2YgYW55IHRhcmdldCdzIGFkbWluIGFjdGlvbiB2aWEge3NldFRhcmdldEFkbWluRGVsYXl9LlxuICogQSByb2xlIGxhYmVsIGZvciBkaXNjb3ZlcmFiaWxpdHkgcHVycG9zZXMgd2l0aCB7bGFiZWxSb2xlfS5cbiBBbnkgYWNjb3VudCBjYW4gYmUgYWRkZWQgYW5kIHJlbW92ZWQgaW50byBhbnkgbnVtYmVyIG9mIHRoZXNlIHJvbGVzIGJ5IHVzaW5nIHRoZSB7Z3JhbnRSb2xlfSBhbmQge3Jldm9rZVJvbGV9IGZ1bmN0aW9uc1xuIHJlc3RyaWN0ZWQgdG8gZWFjaCByb2xlJ3MgYWRtaW4gKHNlZSB7Z2V0Um9sZUFkbWlufSkuXG4gU2luY2UgYWxsIHRoZSBwZXJtaXNzaW9ucyBvZiB0aGUgbWFuYWdlZCBzeXN0ZW0gY2FuIGJlIG1vZGlmaWVkIGJ5IHRoZSBhZG1pbnMgb2YgdGhpcyBpbnN0YW5jZSwgaXQgaXMgZXhwZWN0ZWQgdGhhdFxuIHRoZXkgd2lsbCBiZSBoaWdobHkgc2VjdXJlZCAoZS5nLiwgYSBtdWx0aXNpZyBvciBhIHdlbGwtY29uZmlndXJlZCBEQU8pLlxuIE5PVEU6IFRoaXMgY29udHJhY3QgaW1wbGVtZW50cyBhIGZvcm0gb2YgdGhlIHtJQXV0aG9yaXR5fSBpbnRlcmZhY2UsIGJ1dCB7Y2FuQ2FsbH0gaGFzIGFkZGl0aW9uYWwgcmV0dXJuIGRhdGEgc28gaXRcbiBkb2Vzbid0IGluaGVyaXQgYElBdXRob3JpdHlgLiBJdCBpcyBob3dldmVyIGNvbXBhdGlibGUgd2l0aCB0aGUgYElBdXRob3JpdHlgIGludGVyZmFjZSBzaW5jZSB0aGUgZmlyc3QgMzIgYnl0ZXMgb2ZcbiB0aGUgcmV0dXJuIGRhdGEgYXJlIGEgYm9vbGVhbiBhcyBleHBlY3RlZCBieSB0aGF0IGludGVyZmFjZS5cbiBOT1RFOiBTeXN0ZW1zIHRoYXQgaW1wbGVtZW50IG90aGVyIGFjY2VzcyBjb250cm9sIG1lY2hhbmlzbXMgKGZvciBleGFtcGxlIHVzaW5nIHtPd25hYmxlfSkgY2FuIGJlIHBhaXJlZCB3aXRoIGFuXG4ge0FjY2Vzc01hbmFnZXJ9IGJ5IHRyYW5zZmVycmluZyBwZXJtaXNzaW9ucyAob3duZXJzaGlwIGluIHRoZSBjYXNlIG9mIHtPd25hYmxlfSkgZGlyZWN0bHkgdG8gdGhlIHtBY2Nlc3NNYW5hZ2VyfS5cbiBVc2VycyB3aWxsIGJlIGFibGUgdG8gaW50ZXJhY3Qgd2l0aCB0aGVzZSBjb250cmFjdHMgdGhyb3VnaCB0aGUge2V4ZWN1dGV9IGZ1bmN0aW9uLCBmb2xsb3dpbmcgdGhlIGFjY2VzcyBydWxlc1xuIHJlZ2lzdGVyZWQgaW4gdGhlIHtBY2Nlc3NNYW5hZ2VyfS4gS2VlcCBpbiBtaW5kIHRoYXQgaW4gdGhhdCBjb250ZXh0LCB0aGUgbXNnLnNlbmRlciBzZWVuIGJ5IHJlc3RyaWN0ZWQgZnVuY3Rpb25zXG4gd2lsbCBiZSB7QWNjZXNzTWFuYWdlcn0gaXRzZWxmLlxuIFdBUk5JTkc6IFdoZW4gZ3JhbnRpbmcgcGVybWlzc2lvbnMgb3ZlciBhbiB7T3duYWJsZX0gb3Ige0FjY2Vzc0NvbnRyb2x9IGNvbnRyYWN0IHRvIGFuIHtBY2Nlc3NNYW5hZ2VyfSwgYmUgdmVyeVxuIG1pbmRmdWwgb2YgdGhlIGRhbmdlciBhc3NvY2lhdGVkIHdpdGggZnVuY3Rpb25zIHN1Y2ggYXMge093bmFibGUtcmVub3VuY2VPd25lcnNoaXB9IG9yXG4ge0FjY2Vzc0NvbnRyb2wtcmVub3VuY2VSb2xlfS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUm9sZSI6W3sibmFtZSI6Im1lbWJlcnMiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYWRtaW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3VhcmRpYW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3JhbnREZWxheSIsInR5cGUiOiJ1aW50MTEyIn1dLCJTY2hlZHVsZSI6W3sibmFtZSI6InRpbWVwb2ludCIsInR5cGUiOiJ1aW50NDgifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MzIifV0sIlRhcmdldENvbmZpZyI6W3sibmFtZSI6ImFsbG93ZWRSb2xlcyIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJhZG1pbkRlbGF5IiwidHlwZSI6InVpbnQxMTIifSx7Im5hbWUiOiJjbG9zZWQiLCJ0eXBlIjoiYm9vbCJ9XSwiY2FuQ2FsbFJldHVybiI6W3sibmFtZSI6ImltbWVkaWF0ZSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZGVsYXkiLCJ0eXBlIjoidWludDY0In1dLCJnZXRBY2Nlc3NSZXR1cm4iOlt7Im5hbWUiOiJzaW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjdXJyZW50RGVsYXkiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGVuZGluZ0RlbGF5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVmZmVjdCIsInR5cGUiOiJ1aW50NjQifV0sImhhc1JvbGVSZXR1cm4iOlt7Im5hbWUiOiJpc01lbWJlciIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZXhlY3V0aW9uRGVsYXkiLCJ0eXBlIjoidWludDY0In1dLCJzY2hlZHVsZVJldHVybiI6W3sibmFtZSI6Im9wZXJhdGlvbklkIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoibm9uY2UiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fcG9zdEluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluaXRpYWxBZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUm9sZUdyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGF5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2luY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3TWVtYmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuQ2FsbCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsZWN0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsdWludDY0KSIsInN0cnVjdCI6ImNhbkNhbGxSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4cGlyYXRpb24iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pblNldGJhY2siLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzVGFyZ2V0Q2xvc2VkIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUYXJnZXRGdW5jdGlvblJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGVjdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUYXJnZXRBZG1pbkRlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVBZG1pbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVHdWFyZGlhbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVHcmFudERlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWNjZXNzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJnZXRBY2Nlc3NSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc1JvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQpIiwic3RydWN0IjoiaGFzUm9sZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGFiZWxSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFiZWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik9wZXJhdGlvbkV4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVMYWJlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYWJlbCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdyYW50Um9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleGVjdXRpb25EZWxheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUdyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGF5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2luY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3TWVtYmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV2b2tlUm9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlUmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVub3VuY2VSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlckNvbmZpcm1hdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUm9sZVJldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFJvbGVBZG1pbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlQWRtaW5DaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Um9sZUd1YXJkaWFuIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3VhcmRpYW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik9wZXJhdGlvbkV4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVHdWFyZGlhbkNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3VhcmRpYW4iLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRHcmFudERlbGF5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3RGVsYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik9wZXJhdGlvbkV4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVHcmFudERlbGF5Q2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VGFyZ2V0RnVuY3Rpb25Sb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4WzRdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxlY3RvcnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0RnVuY3Rpb25Sb2xlVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGVjdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VGFyZ2V0QWRtaW5EZWxheSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdEZWxheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0QWRtaW5EZWxheVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsYXkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaW5jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFRhcmdldENsb3NlZCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xvc2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJUYXJnZXRDbG9zZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsb3NlZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFNjaGVkdWxlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldE5vbmNlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNjaGVkdWxlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndoZW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbMzJdLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJzY2hlZHVsZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25TY2hlZHVsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjaGVkdWxlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuY2VsIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3BlcmF0aW9uQ2FuY2VsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbnN1bWVTY2hlZHVsZWRPcCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGFzaE9wZXJhdGlvbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUF1dGhvcml0eSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQWNjZXNzTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QXV0aG9yaXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPcGVyYXRpb25FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiQURNSU5fUk9MRSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUFVCTElDX1JPTEUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im11bHRpY2FsbCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTXVsdGljYWxsIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMDIxXSwiZXJyb3JNZXNzYWdlIjoiQUJJIGJvb2wgdmFsaWRhdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NzMsMjE0NiwyMTU0LDI0MjAsMjQyOCwyOTU1LDQ2NzIsNDY4NSw1NjM1XSwiZXJyb3JNZXNzYWdlIjoiQUJJIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzkzXSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlckFscmVhZHlTY2hlZHVsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODM2XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlckJhZENvbmZpcm1hdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5ODldLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyRXhwaXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNjldLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VySW52YWxpZEluaXRpYWxBZG1pbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MzksMjU1OCwyNTY0LDI2OTgsMjcwNCwzMDMxLDMwMzYsNDY5OSw0ODUzXSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlckxvY2tlZFJvbGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTgzXSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlck5vdFJlYWR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1OSw0OTc1XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlck5vdFNjaGVkdWxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxNjddLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyVW5hdXRob3JpemVkQWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MTEsMTcwOSwxNzE4XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlclVuYXV0aG9yaXplZENhbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzk3XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlclVuYXV0aG9yaXplZENhbmNlbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNDFdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NNYW5hZ2VyVW5hdXRob3JpemVkQ29uc3VtZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MThdLCJlcnJvck1lc3NhZ2UiOiJBZGRyZXNzRW1wdHlDb2RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUyNF0sImVycm9yTWVzc2FnZSI6IkZhaWxlZENhbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDY5XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50QmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NDBdLCJlcnJvck1lc3NhZ2UiOiJTYWZlQ2FzdE92ZXJmbG93ZWRVaW50RG93bmNhc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzM2XSwiZXJyb3JNZXNzYWdlIjoiX19wb3N0SW5pdCBhbHJlYWR5IGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NTMsNDEwNyw1NTE4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX2V4ZWN1dGlvbklkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMzJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwMF0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg5LDc0MywxMTM3LDExNzMsMTI4NSwxNDY1LDE2MzAsMjI1MSwzMDAyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjY0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQ1LDExODEsMTI5MywxNDczLDE2MzgsMzAwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDUyLDEwNjIsMTEyMywxMTMxLDExNjcsMTI2OSwxMjc5LDE0NTksMTYyMSwxOTE1LDE5NjUsMTk4NSwyMTEyLDIyNDIsMjgxMywyODcwLDI5MjEsMzA3OCwzMTEzLDMyMDEsMzIxOSwzMjQ2LDMyODksMzI5NywzMzMyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMjgsMzMwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NTEsMjEyMCwyMjc1LDIzODMsMjM5NCwyNTIzLDI1MzYsMjY2MywyNjc2LDI4MDAsMjg1NywyOTA4LDI5MjksMjk5MCwzMDY5LDMxMDQsMzE0NCwzMTYzLDMxODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3VpbnQ4W10pW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzc4LDk4NywxMDIxLDEwNzUsMTE5OSwxMzExLDE2NjcsMTkyOCwyMDEzLDIxMzYsMjI5MSwyNDEwLDI1NDksMjY4OSwyODI2LDI4ODMsMjk0NSwzMDIyLDQwNjYsNDE4NCw0MjA2LDQyMzEsNDI3Nyw0MzEzLDQzNTYsNDM5NCw0NDMyLDQ0NzYsNDU5Myw0OTE0LDUwMzldLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MDYsMTgyNywxODQyLDM5MDgsMzk0OSw0NzM0LDQ3NDUsNDc1OCw1NjUzXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjg3XSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNeklnT0NBME1qazBPVFkzTWprMUlESTRNVFEzTkRrM05qY3hNRFkxTlNBeE9EUTBOamMwTkRBM016Y3dPVFUxTVRZeE5Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlEQjRJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SUNKZmNtOXNaWE1pSURCNE1EQXlNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnSWw5elkyaGxaSFZzWlhNaUlDSmZaWGhsWTNWMGFXOXVTV1FpSUNKZmRHRnlaMlYwY3lJZ01IZ3dNREV4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdNSGd3TUNBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQ0FpWDE5amRHOXlYM0JsYm1ScGJtY2lJREI0TURBd01DQXdlREF4SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQWliV1Z0WW1WeWN5SWdNSGd3TkNBd2VEQXdNREF3TURBd01EQXdNQ0FpWVd4c2IzZGxaRkp2YkdWeklpQXdlREF3TWpBZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TUNBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQnVJREU1Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0lpQ2lBZ0lDQmtkWEJ1SURFMUNpQWdJQ0J3ZFhOb2FXNTBJRFF3T1RZS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSE4wYjNKbElEVUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREE0TUFvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lITjBiM0psSURBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0pmWDJOMGIzSmZjR1Z1WkdsdVp5SUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc1T1RCbU16QmhaU0F3ZUdRd056azJORE14SURCNE9XVmhZVFUzTTJFZ01IaGpabVl5WlRZeU1TQXdlR1EwTkRRd1pqVTNJREI0T0Rka05UUTFNR0lnTUhneVl6QmhZMlE0TVNBd2VHUmhOelV3WWpJeklEQjRNVE5sT1RJNE9EWWdNSGd6WkdKak5tUTBNeUF3ZURrd1pqVTRaVGMxSURCNFpqRXdOalkzT1RrZ01IZzRPVEZqTXpjMFlTQXdlR00wWkdVeE56QmlJREI0WmpFNFlUZ3pZVGdnTUhoaU5URXlOVFUxWXlBd2VESmtaakF5WVRJM0lEQjRNamcwTkdSaU9XVWdNSGd6TkRSaFptWTBNQ0F3ZUdRNU5tSTRZVGRrSURCNE1EWmxaR016TW1VZ01IaGpObVExTVRVeVpTQXdlR0ZqT1dOaVlUQmxJREI0T0RWa016Z3laVEVnTUhneVlUTXlZMlJrTVNBd2VETmlOV05oTURnMklEQjRNbU00TXpZMlpEZ2dNSGcyTmpsaFl6QTBZaUF3ZURBME9UVXhZekk1SURCNFpHUTVPREk0WkRVZ01IZzJaR016TURNd05TQXdlR0ptTmpNM05qVmlJREI0TURRNU1UbGhNallnTHk4Z2JXVjBhRzlrSUNKZlgzQnZjM1JKYm1sMEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJGdVEyRnNiQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZbmwwWlZzMFhTa29ZbTl2YkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKbGVIQnBjbUYwYVc5dUtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltMXBibE5sZEdKaFkyc29LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlhWE5VWVhKblpYUkRiRzl6WldRb1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0puWlhSVVlYSm5aWFJHZFc1amRHbHZibEp2YkdVb1lXUmtjbVZ6Y3l4aWVYUmxXelJkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFZHRnlaMlYwUVdSdGFXNUVaV3hoZVNoaFpHUnlaWE56S1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFVtOXNaVUZrYldsdUtIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGSnZiR1ZIZFdGeVpHbGhiaWgxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJTYjJ4bFIzSmhiblJFWld4aGVTaDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUkJZMk5sYzNNb2RXbHVkRFkwTEdGa1pISmxjM01wS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltaGhjMUp2YkdVb2RXbHVkRFkwTEdGa1pISmxjM01wS0dKdmIyd3NkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWliR0ZpWld4U2IyeGxLSFZwYm5RMk5DeHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjNKaGJuUlNiMnhsS0hWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpYWnZhMlZTYjJ4bEtIVnBiblEyTkN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYm05MWJtTmxVbTlzWlNoMWFXNTBOalFzWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJTYjJ4bFFXUnRhVzRvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUlNiMnhsUjNWaGNtUnBZVzRvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUkhjbUZ1ZEVSbGJHRjVLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFZHRnlaMlYwUm5WdVkzUnBiMjVTYjJ4bEtHRmtaSEpsYzNNc2RXbHVkRGhiTkYxYlhTeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFZHRnlaMlYwUVdSdGFXNUVaV3hoZVNoaFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJVWVhKblpYUkRiRzl6WldRb1lXUmtjbVZ6Y3l4aWIyOXNLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRk5qYUdWa2RXeGxLR0o1ZEdWYk16SmRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwVG05dVkyVW9ZbmwwWlZzek1sMHBkV2x1ZERZMElpd2diV1YwYUc5a0lDSnpZMmhsWkhWc1pTaGhaR1J5WlhOekxHSjVkR1ZiWFN4MWFXNTBOalFwS0dKNWRHVmJNekpkTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1WNFpXTjFkR1VvWVdSa2NtVnpjeXhpZVhSbFcxMHBkV2x1ZERZMElpd2diV1YwYUc5a0lDSmpZVzVqWld3b1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU52Ym5OMWJXVlRZMmhsWkhWc1pXUlBjQ2hoWkdSeVpYTnpMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKb1lYTm9UM0JsY21GMGFXOXVLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGllWFJsVzEwcFlubDBaVnN6TWwwaUxDQnRaWFJvYjJRZ0luVndaR0YwWlVGMWRHaHZjbWwwZVNoaFpHUnlaWE56TEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlRVVJOU1U1ZlVrOU1SU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pRVlVKTVNVTmZVazlNUlNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKdGRXeDBhV05oYkd3b1lubDBaVnRkVzEwcFlubDBaVnRkVzEwaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDE5ZmNHOXpkRWx1YVhSZmNtOTFkR1ZBTlNCdFlXbHVYMk5oYmtOaGJHeGZjbTkxZEdWQU5pQnRZV2x1WDJWNGNHbHlZWFJwYjI1ZmNtOTFkR1ZBTnlCdFlXbHVYMjFwYmxObGRHSmhZMnRmY205MWRHVkFPQ0J0WVdsdVgybHpWR0Z5WjJWMFEyeHZjMlZrWDNKdmRYUmxRRGtnYldGcGJsOW5aWFJVWVhKblpYUkdkVzVqZEdsdmJsSnZiR1ZmY205MWRHVkFNVEFnYldGcGJsOW5aWFJVWVhKblpYUkJaRzFwYmtSbGJHRjVYM0p2ZFhSbFFERXhJRzFoYVc1ZloyVjBVbTlzWlVGa2JXbHVYM0p2ZFhSbFFERXlJRzFoYVc1ZloyVjBVbTlzWlVkMVlYSmthV0Z1WDNKdmRYUmxRREV6SUcxaGFXNWZaMlYwVW05c1pVZHlZVzUwUkdWc1lYbGZjbTkxZEdWQU1UUWdiV0ZwYmw5blpYUkJZMk5sYzNOZmNtOTFkR1ZBTVRVZ2JXRnBibDlvWVhOU2IyeGxYM0p2ZFhSbFFERTJJRzFoYVc1ZmJHRmlaV3hTYjJ4bFgzSnZkWFJsUURFM0lHMWhhVzVmWjNKaGJuUlNiMnhsWDNKdmRYUmxRREU0SUcxaGFXNWZjbVYyYjJ0bFVtOXNaVjl5YjNWMFpVQXhPU0J0WVdsdVgzSmxibTkxYm1ObFVtOXNaVjl5YjNWMFpVQXlNQ0J0WVdsdVgzTmxkRkp2YkdWQlpHMXBibDl5YjNWMFpVQXlNU0J0WVdsdVgzTmxkRkp2YkdWSGRXRnlaR2xoYmw5eWIzVjBaVUF5TWlCdFlXbHVYM05sZEVkeVlXNTBSR1ZzWVhsZmNtOTFkR1ZBTWpNZ2JXRnBibDl6WlhSVVlYSm5aWFJHZFc1amRHbHZibEp2YkdWZmNtOTFkR1ZBTWpRZ2JXRnBibDl6WlhSVVlYSm5aWFJCWkcxcGJrUmxiR0Y1WDNKdmRYUmxRREkxSUcxaGFXNWZjMlYwVkdGeVoyVjBRMnh2YzJWa1gzSnZkWFJsUURJMklHMWhhVzVmWjJWMFUyTm9aV1IxYkdWZmNtOTFkR1ZBTWpjZ2JXRnBibDluWlhST2IyNWpaVjl5YjNWMFpVQXlPQ0J0WVdsdVgzTmphR1ZrZFd4bFgzSnZkWFJsUURJNUlHMWhhVzVmWlhobFkzVjBaVjl5YjNWMFpVQXpNQ0J0WVdsdVgyTmhibU5sYkY5eWIzVjBaVUF6TVNCdFlXbHVYMk52Ym5OMWJXVlRZMmhsWkhWc1pXUlBjRjl5YjNWMFpVQXpNaUJ0WVdsdVgyaGhjMmhQY0dWeVlYUnBiMjVmY205MWRHVkFNek1nYldGcGJsOTFjR1JoZEdWQmRYUm9iM0pwZEhsZmNtOTFkR1ZBTXpRZ2JXRnBibDlCUkUxSlRsOVNUMHhGWDNKdmRYUmxRRE0xSUcxaGFXNWZVRlZDVEVsRFgxSlBURVZmY205MWRHVkFNellnYldGcGJsOXRkV3gwYVdOaGJHeGZjbTkxZEdWQU16Y0tJQ0FnSUdWeWNnb0tiV0ZwYmw5dGRXeDBhV05oYkd4ZmNtOTFkR1ZBTXpjNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVFVLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS2dvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZblZ5ZVNBek5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ01UQUtDbTFoYVc1ZlptOXlYMmhsWVdSbGNrQTBNam9LSUNBZ0lHUnBaeUE1Q2lBZ0lDQmthV2NnTVRNS0lDQWdJRHdLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmWm05eVFEUTBDaUFnSUNCa2FXY2dPUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF6TlFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTVDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdabTl5SUNoc1pXNHJLR3hsYml0MWFXNTBPRnRkS1Z0ZEtRb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWW5WeWVTQTNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeE1Bb2dJQ0FnWWlCdFlXbHVYMlp2Y2w5b1pXRmtaWEpBTkRJS0NtMWhhVzVmWVdaMFpYSmZabTl5UURRME9nb2dJQ0FnWkdsbklEVUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDQrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURRMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURRM09nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmllWFJsWXlBeE15QXZMeUF3ZURBd01EQUtJQ0FnSUdKMWNua2dNellLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJREUxQ2dwdFlXbHVYM2RvYVd4bFgzUnZjRUEwT0RvS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnWkdsbklERXpDaUFnSUNBOENpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURVd0NpQWdJQ0JrYVdjZ016VUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCaWVtVnlid29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VEQXdNREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdOaGJHeHpkV0lnWDNKbFkyRnNZM1ZzWVhSbFgyaGxZV1JmWm05eVgyVnNaVzFsYm5SelgzZHBkR2hmWW5sMFpWOXNaVzVuZEdoZmFHVmhaQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREUyQ2lBZ0lDQmlkWEo1SURNMkNpQWdJQ0JpSUcxaGFXNWZkMmhwYkdWZmRHOXdRRFE0Q2dwdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURVd09nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWW5WeWVTQXlPUW9nSUNBZ1pHbG5JRE0xQ2lBZ0lDQmlkWEo1SURJekNncHRZV2x1WDNkb2FXeGxYM1J2Y0VBMU1Ub0tJQ0FnSUdScFp5QXhNZ29nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JREk1Q2lBZ0lDQmlQZ29nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQTFNd29nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeU9Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeU5Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURFS0lDQWdJSE4xWW5OMGNtbHVaeUF3SURJS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmtkWEF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJQ3NLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR0o1ZEdWaklERXpJQzh2SURCNE1EQXdNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCZmNtVmpZV3hqZFd4aGRHVmZhR1ZoWkY5bWIzSmZaV3hsYldWdWRITmZkMmwwYUY5aWVYUmxYMnhsYm1kMGFGOW9aV0ZrQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ01qUUtJQ0FnSUdKNWRHVmpJREUwSUM4dklEQjRNREVLSUNBZ0lHSXJDaUFnSUNCaWRYSjVJREk1Q2lBZ0lDQmlJRzFoYVc1ZmQyaHBiR1ZmZEc5d1FEVXhDZ3B0WVdsdVgyRm1kR1Z5WDNkb2FXeGxRRFV6T2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQmthV2NnTWpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFORFk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFORGNLQ20xaGFXNWZVRlZDVEVsRFgxSlBURVZmY205MWRHVkFNelk2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURVM0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURVNE9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOV1ptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFUzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFU0Q2dwdFlXbHVYMEZFVFVsT1gxSlBURVZmY205MWRHVkFNelU2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURZeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURZek9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFl5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFl6Q2dwdFlXbHVYM1Z3WkdGMFpVRjFkR2h2Y21sMGVWOXliM1YwWlVBek5Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREkyQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURZM0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURZNE9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTBGMWRHaHZjbWw2WldRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WTJSa1lUUmxZVFlnTHk4Z2JXVjBhRzlrSUNKelpYUkJkWFJvYjNKcGRIa29ZV1JrY21WemN5bDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QXlOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5qYzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qZ0tDbTFoYVc1ZmFHRnphRTl3WlhKaGRHbHZibDl5YjNWMFpVQXpNem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHTmhiR3h6ZFdJZ2FHRnphRTl3WlhKaGRHbHZiZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpiMjV6ZFcxbFUyTm9aV1IxYkdWa1QzQmZjbTkxZEdWQU16STZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNelFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZblZ5ZVNBek1Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTNOQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTNOVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpaRFV4TTJSaE5TQXZMeUJ0WlhSb2IyUWdJbWx6UTI5dWMzVnRhVzVuVTJOb1pXUjFiR1ZrVDNBb0tXSjVkR1ZiTkYwaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURobVlqTTJNRE0zQ2lBZ0lDQWhQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjMDFoYm1GblpYSlZibUYxZEdodmNtbDZaV1JEYjI1emRXMWxDaUFnSUNCa2FXY2dNek1LSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF6TWdvZ0lDQWdZMkZzYkhOMVlpQm9ZWE5vVDNCbGNtRjBhVzl1Q2lBZ0lDQmpZV3hzYzNWaUlGOWpiMjV6ZFcxbFUyTm9aV1IxYkdWa1QzQUtJQ0FnSUhCdmNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGMwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGMxQ2dwdFlXbHVYMk5oYm1ObGJGOXliM1YwWlVBek1Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXpOQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREl4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0oxY25rZ016RUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOemtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFPREE2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU53b2dJQ0FnWkdsbklETXhDaUFnSUNCa2RYQUtJQ0FnSUhOMVluTjBjbWx1WnlBd0lEUUtJQ0FnSUdKMWNua2dNalFLSUNBZ0lHUnBaeUF6TkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrYVdjZ01qTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQm9ZWE5vVDNCbGNtRjBhVzl1Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpjS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVgzTmphR1ZrZFd4bGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE13Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXdJRFlLSUNBZ0lHSjBiMmtLSUNBZ0lDRUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVRtOTBVMk5vWldSMWJHVmtDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZ3pDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkdsbklESTJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ2FHRnpVbTlzWlFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWpFS0lDQWdJR1JwWnlBeU5Bb2dJQ0FnWTJGc2JITjFZaUJuWlhSVVlYSm5aWFJHZFc1amRHbHZibEp2YkdVS0lDQWdJR05oYkd4emRXSWdaMlYwVW05c1pVZDFZWEprYVdGdUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJR2hoYzFKdmJHVUtJQ0FnSUhCdmNBb2dJQ0FnWW5WeWVTQXhNQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE0TXdvZ0lDQWdaR2xuSURnS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVZXNWhkWFJvYjNKcGVtVmtRMkZ1WTJWc0NncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFPRE02Q2lBZ0lDQmthV2NnTWpZS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdOaUEwQ2lBZ0lDQmllWFJsWXlBeE9DQXZMeUF3ZURBd01EQXdNREF3TURBd01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXpNZ29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNalVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TnpNMllXWTBZV01nTHk4Z2JXVjBhRzlrSUNKUGNHVnlZWFJwYjI1RFlXNWpaV3hsWkNoMWFXNTBPRnN6TWwwc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5SaklEUWdMeThnTkRJNU5EazJOekk1TlFvZ0lDQWdKZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURjNU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURnd0NncHRZV2x1WDJWNFpXTjFkR1ZmY205MWRHVkFNekE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ016TUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBek5nb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklETUtJQ0FnSUdOaGJHeHpkV0lnWDJOaGJrTmhiR3hGZUhSbGJtUmxaQW9nSUNBZ2NHOXdDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRjlqWVc1RFlXeHNSWGgwWlc1a1pXUUtJQ0FnSUdKMWNua2dOUW9nSUNBZ2NHOXdDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRGczQ2lBZ0lDQmthV2NnTWdvZ0lDQWdJUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjMDFoYm1GblpYSlZibUYxZEdodmNtbDZaV1JEWVd4c0NncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFPRGM2Q2lBZ0lDQmthV2NnTXpJS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnWkdsbklETXlDaUFnSUNCallXeHNjM1ZpSUdoaGMyaFBjR1Z5WVhScGIyNEtJQ0FnSUdKMWNua2dNalFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJRGNLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmlibm9nYldGcGJsOXBabDlpYjJSNVFEZzVDaUFnSUNCa2FXY2dNak1LSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVMk5vWldSMWJHVUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTVNQW9LYldGcGJsOXBabDlpYjJSNVFEZzVPZ29nSUNBZ1pHbG5JREl6Q2lBZ0lDQmpZV3hzYzNWaUlGOWpiMjV6ZFcxbFUyTm9aV1IxYkdWa1QzQUtJQ0FnSUdKMWNua2dOd29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURrd09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSWw5bGVHVmpkWFJwYjI1SlpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkWEo1SURNeENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYMlY0WldOMWRHbHZia2xrSUdWNGFYTjBjd29nSUNBZ1pHbG5JRE13Q2lBZ0lDQnpkV0p6ZEhKcGJtY2dNQ0EwQ2lBZ0lDQmthV2NnTWpBS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdYMmhoYzJoRmVHVmpkWFJwYjI1SlpBb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVgyVjRaV04xZEdsdmJrbGtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBT1RJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBT1RNNkNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdScFp5QXpNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRUZrWkhKbGMzTXVablZ1WTNScGIyNURZV3hzVjJsMGFGWmhiSFZsQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbDlsZUdWamRYUnBiMjVKWkNJS0lDQWdJR1JwWnlBek1Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEa3lPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEa3pDZ3B0WVdsdVgzTmphR1ZrZFd4bFgzSnZkWFJsUURJNU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVGtLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZblZ5ZVNBek1Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1luVnllU0F4Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURrM0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURrNE9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdNZ05TQXZMeUF5T0RFME56UTVOelkzTVRBMk5UVUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUVVKSklIWmhiR2xrWVhScGIyNEtJQ0FnSUdsdWRHTWdOU0F2THlBeU9ERTBOelE1TnpZM01UQTJOVFVLSUNBZ0lDWUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ016VUtJQ0FnSUdScFp5QXlNUW9nSUNBZ1pHbG5JRE16Q2lBZ0lDQmpZV3hzYzNWaUlGOWpZVzVEWVd4c1JYaDBaVzVrWldRS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExuUnBiV1Z6ZEdGdGNBb2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE9Rb2dJQ0FnYVc1MFl5QTFJQzh2SURJNE1UUTNORGszTmpjeE1EWTFOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdJUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjMDFoYm1GblpYSlZibUYxZEdodmNtbDZaV1JEWVd4c0NpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQXdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXhOZ29nSUNBZ1BBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZqWTJWemMwMWhibUZuWlhKVmJtRjFkR2h2Y21sNlpXUkRZV3hzQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQXdPZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKNlpYSnZDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JREUzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEF5Q2lBZ0lDQmpZV3hzYzNWaUlFMWhkR2d1YldGNENpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlFMWhkR2d1YldGNENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTWdOU0F2THlBeU9ERTBOelE1TnpZM01UQTJOVFVLSUNBZ0lDWUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1pHbG5JRE15Q2lBZ0lDQmthV2NnTWpBS0lDQWdJR1JwWnlBek1nb2dJQ0FnWTJGc2JITjFZaUJvWVhOb1QzQmxjbUYwYVc5dUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qVUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTmlBdkx5QWlYM05qYUdWa2RXeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJNENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F3SURZS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UWXpDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyRnNiSE4xWWlCZmFYTkZlSEJwY21Wa0NpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpUV0Z1WVdkbGNrRnNjbVZoWkhsVFkyaGxaSFZzWldRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOak02Q2lBZ0lDQmthV2NnTWpZS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXpNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJSEIxYzJocGJuUWdOREk1TkRrMk56STVOZ29nSUNBZ0pRb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0EySURRS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0pwZEd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwT0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnBkR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0EwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTUNBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWkdsbklESTJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ016VUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREl5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd056SUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREl3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdZNFlqYzNPVEZoSUM4dklHMWxkR2h2WkNBaVQzQmxjbUYwYVc5dVUyTm9aV1IxYkdWa0tIVnBiblE0V3pNeVhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc1lubDBaVnRkS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5SaklEUWdMeThnTkRJNU5EazJOekk1TlFvZ0lDQWdKZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU9UYzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU9UZ0tDbTFoYVc1ZloyVjBUbTl1WTJWZmNtOTFkR1ZBTWpnNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qa0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEEwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV3TlRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1pHbG5JREkzQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklEWWdMeThnSWw5elkyaGxaSFZzWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERNeUNpQWdJQ0JwYm5SaklEUWdMeThnTkRJNU5EazJOekk1TlFvZ0lDQWdKZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFd05Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1EVUtDbTFoYVc1ZloyVjBVMk5vWldSMWJHVmZjbTkxZEdWQU1qYzZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdOaGJHeHpkV0lnWjJWMFUyTm9aV1IxYkdVS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzJWMFZHRnlaMlYwUTJ4dmMyVmtYM0p2ZFhSbFFESTJPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREl4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZFhKNUlERXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV4TVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TVRJNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yUVhWMGFHOXlhWHBsWkFvZ0lDQWdaR2xuSURFeENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJRa2tnWW05dmJDQjJZV3hwWkdGMGFXOXVDaUFnSUNCa2FXY2dNVGtLSUNBZ0lHUjFjQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0pmZEdGeVoyVjBjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE1EQXhNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeUlERTBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF4TVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5TVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdObE4yRTJOVEJtSUM4dklHMWxkR2h2WkNBaVZHRnlaMlYwUTJ4dmMyVmtLSFZwYm5RNFd6TXlYU3hpYjI5c0tTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRFeE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFeE1nb0tiV0ZwYmw5elpYUlVZWEpuWlhSQlpHMXBia1JsYkdGNVgzSnZkWFJsUURJMU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmlkWEo1SURnS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1URTJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXhOem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWTJGc2JITjFZaUJmWTJobFkydEJkWFJvYjNKcGVtVmtDaUFnSUNCa2FXY2dOd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCUWtrZ2RtRnNhV1JoZEdsdmJnb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUEwSUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUVVKSklIWmhiR2xrWVhScGIyNEtJQ0FnSUdsdWRHTWdOQ0F2THlBME1qazBPVFkzTWprMUNpQWdJQ0FtQ2lBZ0lDQmthV2NnTWpBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUE0SUM4dklDSmZkR0Z5WjJWMGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJREI0TURBeE1UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBeE5Bb2dJQ0FnWTJGc2JITjFZaUJ0YVc1VFpYUmlZV05yQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG5kcGRHaFZjR1JoZEdVS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlREF3TVRFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JsZUhSeVlXTjBJRElnTVRRS0lDQWdJR05oYkd4emRXSWdiV2x1VTJWMFltRmphd29nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzUzYVhSb1ZYQmtZWFJsQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J3YjNBS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqTTJFeFpqSXlNU0F2THlCdFpYUm9iMlFnSWxSaGNtZGxkRUZrYldsdVJHVnNZWGxWY0dSaGRHVmtLSFZwYm5RNFd6TXlYU3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRFMk9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFeE53b0tiV0ZwYmw5elpYUlVZWEpuWlhSR2RXNWpkR2x2YmxKdmJHVmZjbTkxZEdWQU1qUTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNakFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTJDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTkQ0K0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1qRUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1USXlPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwRjFkR2h2Y21sNlpXUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZFhKNUlESTVDZ3B0WVdsdVgzZG9hV3hsWDNSdmNFQXhNak02Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeU9Rb2dJQ0FnWWo0S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmQyaHBiR1ZBTVRJMUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeU9Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeU1nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhPU0F2THlBaVlXeHNiM2RsWkZKdmJHVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWkdsbklESXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa05UUTVOakk1TnlBdkx5QnRaWFJvYjJRZ0lsUmhjbWRsZEVaMWJtTjBhVzl1VW05c1pWVndaR0YwWldRb2RXbHVkRGhiTXpKZExIVnBiblE0V3pSZExIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z01IZ3dNUW9nSUNBZ1lpc0tJQ0FnSUdKMWNua2dNamtLSUNBZ0lHSWdiV0ZwYmw5M2FHbHNaVjkwYjNCQU1USXpDZ3B0WVdsdVgyRm1kR1Z5WDNkb2FXeGxRREV5TlRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhNakU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVEl5Q2dwdFlXbHVYM05sZEVkeVlXNTBSR1ZzWVhsZmNtOTFkR1ZBTWpNNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQTRDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV5T1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TXpBNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yUVhWMGFHOXlhWHBsWkFvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1FVSkpJSFpoYkdsa1lYUnBiMjRLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFRkNTU0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ0pnb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTJJQzh2SURFNE5EUTJOelEwTURjek56QTVOVFV4TmpFMUNpQWdJQ0E5UFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6YzAxaGJtRm5aWEpNYjJOclpXUlNiMnhsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklEUWdMeThnSWw5eWIyeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQXlNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F4T0NBeE5Bb2dJQ0FnWTJGc2JITjFZaUJ0YVc1VFpYUmlZV05yQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG5kcGRHaFZjR1JoZEdVS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ01UZ2dNVFFLSUNBZ0lHTmhiR3h6ZFdJZ2JXbHVVMlYwWW1GamF3b2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVkdsdFpTNTNhWFJvVlhCa1lYUmxDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF5TUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WVdSbE9UVXpZMllnTHk4Z2JXVjBhRzlrSUNKU2IyeGxSM0poYm5SRVpXeGhlVU5vWVc1blpXUW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhNams2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVE13Q2dwdFlXbHVYM05sZEZKdmJHVkhkV0Z5WkdsaGJsOXliM1YwWlVBeU1qb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01Ua0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFek5Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE16VTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR05oYkd4emRXSWdYMk5vWldOclFYVjBhRzl5YVhwbFpBb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnSVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6YzAxaGJtRm5aWEpNYjJOclpXUlNiMnhsQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTmlBdkx5QXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhOUW9nSUNBZ1BUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVRHOWphMlZrVW05c1pRb2dJQ0FnYVhSdllnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmZjbTlzWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeUlEZ0tJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURFNElERTBDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdNSGd3TURJd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmthV2NnTVRrS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5tSmpOemczWXpZZ0x5OGdiV1YwYUc5a0lDSlNiMnhsUjNWaGNtUnBZVzVEYUdGdVoyVmtLSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TXpRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRNMUNncHRZV2x1WDNObGRGSnZiR1ZCWkcxcGJsOXliM1YwWlVBeU1Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01Ua0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFek9Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5EQTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR05oYkd4emRXSWdYMk5vWldOclFYVjBhRzl5YVhwbFpBb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnSVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6YzAxaGJtRm5aWEpNYjJOclpXUlNiMnhsQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTmlBdkx5QXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhOUW9nSUNBZ1BUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVRHOWphMlZrVW05c1pRb2dJQ0FnYVhSdllnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmZjbTlzWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeE9DQXhOQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01UQWdPQW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURJd0lDOHZJREI0TURBeU1Bb2dJQ0FnWkdsbklESXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdaR2xuSURFNUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWmtOR05tT0Rrd0lDOHZJRzFsZEdodlpDQWlVbTlzWlVGa2JXbHVRMmhoYm1kbFpDaDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVE01T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUwTUFvS2JXRnBibDl5Wlc1dmRXNWpaVkp2YkdWZmNtOTFkR1ZBTWpBNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJRFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F6TXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5EUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UUTFPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTXpJS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBaFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZqWTJWemMwMWhibUZuWlhKQ1lXUkRiMjVtYVhKdFlYUnBiMjRLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOXlaWFp2YTJWU2IyeGxDaUFnSUNCd2IzQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TkRRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRRMUNncHRZV2x1WDNKbGRtOXJaVkp2YkdWZmNtOTFkR1ZBTVRrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJRFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F6TmdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5Ea0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UVXdPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwRjFkR2h2Y21sNlpXUUtJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNelVLSUNBZ0lHTmhiR3h6ZFdJZ1gzSmxkbTlyWlZKdmJHVUtJQ0FnSUhCdmNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREUwT1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TlRBS0NtMWhhVzVmWjNKaGJuUlNiMnhsWDNKdmRYUmxRREU0T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNellLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ01URUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVFUwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUxTlRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1kyRnNiSE4xWWlCZlkyaGxZMnRCZFhSb2IzSnBlbVZrQ2lBZ0lDQmthV2NnTVRBS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1FVSkpJSFpoYkdsa1lYUnBiMjRLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJR2RsZEZKdmJHVkhjbUZ1ZEVSbGJHRjVDaUFnSUNCa2FXY2dNemNLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJmWjNKaGJuUlNiMnhsQ2lBZ0lDQndiM0FLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5UUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UVTFDZ3B0WVdsdVgyeGhZbVZzVW05c1pWOXliM1YwWlVBeE56b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01Ua0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRVNUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFMk1Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdZMkZzYkhOMVlpQmZZMmhsWTJ0QmRYUm9iM0pwZW1Wa0NpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0FoQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXTmpaWE56VFdGdVlXZGxja3h2WTJ0bFpGSnZiR1VLSUNBZ0lHbHVkR01nTmlBdkx5QXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhOUW9nSUNBZ1BUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTk5ZVzVoWjJWeVRHOWphMlZrVW05c1pRb2dJQ0FnWkdsbklERTRDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREJoQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pNamhpT0RFMlppQXZMeUJ0WlhSb2IyUWdJbEp2YkdWTVlXSmxiQ2gxYVc1ME5qUXNjM1J5YVc1bktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRVNU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFMk1Bb0tiV0ZwYmw5b1lYTlNiMnhsWDNKdmRYUmxRREUyT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JqWVd4c2MzVmlJR2hoYzFKdmJHVUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRUZqWTJWemMxOXliM1YwWlVBeE5Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1kyRnNiSE4xWWlCblpYUkJZMk5sYzNNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVbTlzWlVkeVlXNTBSR1ZzWVhsZmNtOTFkR1ZBTVRRNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCallXeHNjM1ZpSUdkbGRGSnZiR1ZIY21GdWRFUmxiR0Y1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZKdmJHVkhkV0Z5WkdsaGJsOXliM1YwWlVBeE16b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVbTlzWlVkMVlYSmthV0Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZKdmJHVkJaRzFwYmw5eWIzVjBaVUF4TWpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFVtOXNaVUZrYldsdUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhsZmNtOTFkR1ZBTVRFNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR05oYkd4emRXSWdaMlYwVkdGeVoyVjBRV1J0YVc1RVpXeGhlUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJVWVhKblpYUkdkVzVqZEdsdmJsSnZiR1ZmY205MWRHVkFNVEE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURRK0NpQWdJQ0JqWVd4c2MzVmlJR2RsZEZSaGNtZGxkRVoxYm1OMGFXOXVVbTlzWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlwYzFSaGNtZGxkRU5zYjNObFpGOXliM1YwWlVBNU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JqWVd4c2MzVmlJR2x6VkdGeVoyVjBRMnh2YzJWa0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYldsdVUyVjBZbUZqYTE5eWIzVjBaVUE0T2dvZ0lDQWdZMkZzYkhOMVlpQnRhVzVUWlhSaVlXTnJDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyVjRjR2x5WVhScGIyNWZjbTkxZEdWQU56b0tJQ0FnSUdOaGJHeHpkV0lnWlhod2FYSmhkR2x2YmdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqWVc1RFlXeHNYM0p2ZFhSbFFEWTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dORDRLSUNBZ0lHTmhiR3h6ZFdJZ1kyRnVRMkZzYkFvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWDE5d2IzTjBTVzVwZEY5eWIzVjBaVUExT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklGOWZjRzl6ZEVsdWFYUWdZV3h5WldGa2VTQmpZV3hzWldRS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlYM1JoY21kbGRITWlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR0p2ZUY5amNtVmhkR1VLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlYM0p2YkdWeklnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lsOXpZMmhsWkhWc1pYTWlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR0p2ZUY5amNtVmhkR1VLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlYMlY0WldOMWRHbHZia2xrSWdvZ0lDQWdZbmwwWldNZ01UVWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QXhOU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUQwOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV05qWlhOelRXRnVZV2RsY2tsdWRtRnNhV1JKYm1sMGFXRnNRV1J0YVc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndDaUFnSUNCallXeHNjM1ZpSUY5bmNtRnVkRkp2YkdVS0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJRjl3ZFhsaFgyeHBZaTVoY21NMExsOXlaV05oYkdOMWJHRjBaVjlvWldGa1gyWnZjbDlsYkdWdFpXNTBjMTkzYVhSb1gySjVkR1ZmYkdWdVozUm9YMmhsWVdRb1lYSnlZWGxmYUdWaFpGOWhibVJmZEdGcGJEb2dZbmwwWlhNc0lHeGxibWQwYURvZ2RXbHVkRFkwTENCemRHRnlkRjloZEY5cGJtUmxlRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LWDNKbFkyRnNZM1ZzWVhSbFgyaGxZV1JmWm05eVgyVnNaVzFsYm5SelgzZHBkR2hmWW5sMFpWOXNaVzVuZEdoZmFHVmhaRG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDb0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjMlZzWldOMENpQWdJQ0J6ZDJGd0NncGZjbVZqWVd4amRXeGhkR1ZmYUdWaFpGOW1iM0pmWld4bGJXVnVkSE5mZDJsMGFGOWllWFJsWDJ4bGJtZDBhRjlvWldGa1gyWnZjbDlvWldGa1pYSkFNVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnUEFvZ0lDQWdZbm9nWDNKbFkyRnNZM1ZzWVhSbFgyaGxZV1JmWm05eVgyVnNaVzFsYm5SelgzZHBkR2hmWW5sMFpWOXNaVzVuZEdoZmFHVmhaRjloWm5SbGNsOW1iM0pBTkFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SUMwekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWWlCZmNtVmpZV3hqZFd4aGRHVmZhR1ZoWkY5bWIzSmZaV3hsYldWdWRITmZkMmwwYUY5aWVYUmxYMnhsYm1kMGFGOW9aV0ZrWDJadmNsOW9aV0ZrWlhKQU1Rb0tYM0psWTJGc1kzVnNZWFJsWDJobFlXUmZabTl5WDJWc1pXMWxiblJ6WDNkcGRHaGZZbmwwWlY5c1pXNW5kR2hmYUdWaFpGOWhablJsY2w5bWIzSkFORG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhJdWMyOXNMa0ZrWkhKbGMzTXVablZ1WTNScGIyNURZV3hzVjJsMGFGWmhiSFZsS0hSaGNtZGxkRG9nWW5sMFpYTXNJR1JoZEdFNklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BCWkdSeVpYTnpMbVoxYm1OMGFXOXVRMkZzYkZkcGRHaFdZV3gxWlRvS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBRbUZzWVc1alpRb2dJQ0FnY0c5d0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0k4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBRbUZzWVc1alpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMkZzYkhOMVlpQk1iM2RNWlhabGJFTmhiR3d1WTJGc2JFNXZVbVYwZFhKdUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRndjSEp2ZG1Gc1VISnZaM0poYlFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllaUJCWkdSeVpYTnpMbVoxYm1OMGFXOXVRMkZzYkZkcGRHaFdZV3gxWlY5bGJITmxYMkp2WkhsQU5nb2dJQ0FnWTJGc2JITjFZaUJNYjNkTVpYWmxiRU5oYkd3dWNtVjBkWEp1UkdGMFlWTnBlbVVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWJub2dRV1JrY21WemN5NW1kVzVqZEdsdmJrTmhiR3hYYVhSb1ZtRnNkV1ZmYVdaZlltOWtlVUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNCaVBnb2dJQ0FnWW5vZ1FXUmtjbVZ6Y3k1bWRXNWpkR2x2YmtOaGJHeFhhWFJvVm1Gc2RXVmZaV3h6WlY5aWIyUjVRRFlLQ2tGa1pISmxjM011Wm5WdVkzUnBiMjVEWVd4c1YybDBhRlpoYkhWbFgybG1YMkp2WkhsQU5Ub0tJQ0FnSUdOaGJHeHpkV0lnVEc5M1RHVjJaV3hEWVd4c0xuSmxkSFZ5YmtSaGRHRUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BCWkdSeVpYTnpMbVoxYm1OMGFXOXVRMkZzYkZkcGRHaFdZV3gxWlY5bGJITmxYMkp2WkhsQU5qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV1JrY21WemMwVnRjSFI1UTI5a1pRb2dJQ0FnWTJGc2JITjFZaUJNYjNkTVpYWmxiRU5oYkd3dWNtVjBkWEp1UkdGMFlWTnBlbVVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaGMzTmxjblFnTHk4Z1JtRnBiR1ZrUTJGc2JBb2dJQ0FnWWlCTWIzZE1aWFpsYkVOaGJHd3VZblZpWW14bFVtVjJaWEowQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeUxuTnZiQzVJWVhOb1pYTXVaV1ptYVdOcFpXNTBTMlZqWTJGck1qVTJLR0U2SUdKNWRHVnpMQ0JpT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2toaGMyaGxjeTVsWm1acFkybGxiblJMWldOallXc3lOVFk2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUd4dllXUWdNQW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhKbGNHeGhZMlV5SURNeUNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EyTkFvZ0lDQWdhMlZqWTJGck1qVTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEl1YzI5c0xreHZkMHhsZG1Wc1EyRnNiQzVqWVd4c1RtOVNaWFIxY200b015a29kR0Z5WjJWME9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpMQ0JrWVhSaE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncE1iM2RNWlhabGJFTmhiR3d1WTJGc2JFNXZVbVYwZFhKdU9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQnNiMkZrSURBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5TUFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNpNXpiMnd1VEc5M1RHVjJaV3hEWVd4c0xuSmxkSFZ5YmtSaGRHRlRhWHBsS0NrZ0xUNGdZbmwwWlhNNkNreHZkMHhsZG1Wc1EyRnNiQzV5WlhSMWNtNUVZWFJoVTJsNlpUb0tJQ0FnSUd4dllXUWdNQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlMbk52YkM1TWIzZE1aWFpsYkVOaGJHd3VjbVYwZFhKdVJHRjBZU2dwSUMwK0lHSjVkR1Z6T2dwTWIzZE1aWFpsYkVOaGJHd3VjbVYwZFhKdVJHRjBZVG9LSUNBZ0lHeHZZV1FnTUFvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjbVZ3YkdGalpUTUtJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lNQW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsY0d4aFkyVXlJRFkwQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEl1YzI5c0xreHZkMHhsZG1Wc1EyRnNiQzVpZFdKaWJHVlNaWFpsY25Rb01Da29LU0F0UGlCMmIybGtPZ3BNYjNkTVpYWmxiRU5oYkd3dVluVmlZbXhsVW1WMlpYSjBPZ29nSUNBZ1pYSnlJQzh2SUhKbGRtVnlkQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2k1emIyd3VUV0YwYUM1MFpYSnVZWEo1S0dOdmJtUnBkR2x2YmpvZ2RXbHVkRFkwTENCaE9pQmllWFJsY3l3Z1lqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncE5ZWFJvTG5SbGNtNWhjbms2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpWGdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZEWVhOMExuUnZWV2x1ZEFvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlYZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeUxuTnZiQzVOWVhSb0xtMWhlQ2hoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwTllYUm9MbTFoZURvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJK0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvTG5SbGNtNWhjbmtLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNpNXpiMnd1VTJGbVpVTmhjM1F1ZEc5VmFXNTBORGdvZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbE5oWm1WRFlYTjBMblJ2VldsdWREUTRPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdabVptWm1abVptWm1abVpnb2dJQ0FnWWo0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRZV1psUTJGemRFOTJaWEptYkc5M1pXUlZhVzUwUkc5M2JtTmhjM1FLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdNZ05TQXZMeUF5T0RFME56UTVOelkzTVRBMk5UVUtJQ0FnSUNZS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxjaTV6YjJ3dVUyRm1aVU5oYzNRdWRHOVZhVzUwS0dJNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNsTmhabVZEWVhOMExuUnZWV2x1ZERvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDRUtJQ0FnSUNFS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJR0o1ZEdWaklERTBJQzh2SURCNE1ERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J6ZDJGd0NpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhJdWMyOXNMbFJwYldVdWRHbHRaWE4wWVcxd0tDa2dMVDRnZFdsdWREWTBPZ3BVYVcxbExuUnBiV1Z6ZEdGdGNEb0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVTmhjM1F1ZEc5VmFXNTBORGdLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNpNXpiMnd1VkdsdFpTNTBiMFJsYkdGNUtHUjFjbUYwYVc5dU9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncFVhVzFsTG5SdlJHVnNZWGs2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5TG5OdmJDNVVhVzFsTGw5blpYUkdkV3hzUVhRb2MyVnNaam9nWW5sMFpYTXNJSFJwYldWd2IybHVkRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BVYVcxbExsOW5aWFJHZFd4c1FYUTZDaUFnSUNCd2NtOTBieUF5SURNS0lDQWdJR0o1ZEdWalh6RWdMeThnSWlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG5WdWNHRmphd29nSUNBZ2NHOXdiaUF6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzUxYm5CaFkyc0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1MWJuQmhZMnNLSUNBZ0lIQnZjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzUxYm5CaFkyc0tJQ0FnSUhCdmNHNGdNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQThQUW9nSUNBZ1lub2dWR2x0WlM1ZloyVjBSblZzYkVGMFgzUmxjbTVoY25sZlptRnNjMlZBTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbFJwYldVdVgyZGxkRVoxYkd4QmRGOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2NtVjBjM1ZpQ2dwVWFXMWxMbDluWlhSR2RXeHNRWFJmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR0lnVkdsdFpTNWZaMlYwUm5Wc2JFRjBYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxjaTV6YjJ3dVZHbHRaUzVuWlhSR2RXeHNLSE5sYkdZNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwT2dwVWFXMWxMbWRsZEVaMWJHdzZDaUFnSUNCd2NtOTBieUF4SURNS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1MGFXMWxjM1JoYlhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTGw5blpYUkdkV3hzUVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxjaTV6YjJ3dVZHbHRaUzVuWlhRb2MyVnNaam9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LVkdsdFpTNW5aWFE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJVYVcxbExtZGxkRVoxYkd3S0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5TG5OdmJDNVVhVzFsTG5kcGRHaFZjR1JoZEdVb2MyVnNaam9nWW5sMFpYTXNJRzVsZDFaaGJIVmxPaUIxYVc1ME5qUXNJRzFwYmxObGRHSmhZMnM2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE1zSUhWcGJuUTJORG9LVkdsdFpTNTNhWFJvVlhCa1lYUmxPZ29nSUNBZ2NISnZkRzhnTXlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1blpYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0ErQ2lBZ0lDQmllaUJVYVcxbExuZHBkR2hWY0dSaGRHVmZaV3h6WlY5aWIyUjVRRElLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0NsUnBiV1V1ZDJsMGFGVndaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBeUNpQWdJQ0JqWVd4c2MzVmlJRTFoZEdndWJXRjRDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRTFoZEdndWJXRjRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0JqWVd4c2MzVmlJRlJwYldVdWRHbHRaWE4wWVcxd0NpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTlNBdkx5QXlPREUwTnpRNU56WTNNVEEyTlRVS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRlJwYldVdWNHRmphd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhSemRXSUtDbFJwYldVdWQybDBhRlZ3WkdGMFpWOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlGUnBiV1V1ZDJsMGFGVndaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhJdWMyOXNMbFJwYldVdWRXNXdZV05yS0hObGJHWTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncFVhVzFsTG5WdWNHRmphem9LSUNBZ0lIQnliM1J2SURFZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBeU1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBeU1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWXlBMUlDOHZJREk0TVRRM05EazNOamN4TURZMU5Rb2dJQ0FnSmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5TG5OdmJDNVVhVzFsTG5CaFkyc29kbUZzZFdWQ1pXWnZjbVU2SUhWcGJuUTJOQ3dnZG1Gc2RXVkJablJsY2pvZ2RXbHVkRFkwTENCbFptWmxZM1E2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q2xScGJXVXVjR0ZqYXpvS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUF5TWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTWpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRHOWlDaUFnSUNCaWZBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5TG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5TG1OaGJrTmhiR3dvWTJGc2JHVnlPaUJpZVhSbGN5d2dkR0Z5WjJWME9pQmllWFJsY3l3Z2MyVnNaV04wYjNJNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRc0lIVnBiblEyTkRvS1kyRnVRMkZzYkRvS0lDQWdJSEJ5YjNSdklETWdNZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlJZ29nSUNBZ1pIVndDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2dZMkZ1UTJGc2JGOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3BqWVc1RFlXeHNYM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlHbHpWR0Z5WjJWMFEyeHZjMlZrQ2lBZ0lDQmllaUJqWVc1RFlXeHNYMlZzYzJWZlltOWtlVUExQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NtVjBjM1ZpQ2dwallXNURZV3hzWDJWc2MyVmZZbTlrZVVBMU9nb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCallXNURZV3hzWDJsbVgySnZaSGxBTndvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1lucGxjbThLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUQwOUNpQWdJQ0JpZWlCallXNURZV3hzWDJWc2MyVmZZbTlrZVVBNENncGpZVzVEWVd4c1gybG1YMkp2WkhsQU56b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKZlpYaGxZM1YwYVc5dVNXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOWxlR1ZqZFhScGIyNUpaQ0JsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjlvWVhOb1JYaGxZM1YwYVc5dVNXUUtJQ0FnSUQwOUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEpsZEhOMVlnb0tZMkZ1UTJGc2JGOWxiSE5sWDJKdlpIbEFPRG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUdkbGRGUmhjbWRsZEVaMWJtTjBhVzl1VW05c1pRb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR05oYkd4emRXSWdhR0Z6VW05c1pRb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR05oYkd4emRXSWdhR0Z6VW05c1pRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J3YjNBS0lDQWdJR0o2SUdOaGJrTmhiR3hmZEdWeWJtRnllVjltWVd4elpVQXhNQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnSVFvZ0lDQWdabkpoYldWZlluVnllU0F4Q2dwallXNURZV3hzWDNSbGNtNWhjbmxmYldWeVoyVkFNVEU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY21WMGMzVmlDZ3BqWVc1RFlXeHNYM1JsY201aGNubGZabUZzYzJWQU1UQTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJqWVc1RFlXeHNYM1JsY201aGNubGZiV1Z5WjJWQU1URUtDbU5oYmtOaGJHeGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWTJGdVEyRnNiRjkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEl1YzI5c0xrRmpZMlZ6YzAxaGJtRm5aWEl1Wlhod2FYSmhkR2x2YmlncElDMCtJSFZwYm5RMk5Eb0taWGh3YVhKaGRHbHZiam9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJsZUhCcGNtRjBhVzl1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtVjRjR2x5WVhScGIyNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBek9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQndkWE5vYVc1MElEWXdORGd3TUFvZ0lDQWdjbVYwYzNWaUNncGxlSEJwY21GMGFXOXVYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdWNGNHbHlZWFJwYjI1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeUxuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeUxtMXBibE5sZEdKaFkyc29LU0F0UGlCMWFXNTBOalE2Q20xcGJsTmxkR0poWTJzNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXbHVVMlYwWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0YVc1VFpYUmlZV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnY0hWemFHbHVkQ0EwTXpJd01EQUtJQ0FnSUhKbGRITjFZZ29LYldsdVUyVjBZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnRhVzVUWlhSaVlXTnJYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxjaTV6YjJ3dVFXTmpaWE56VFdGdVlXZGxjaTVwYzFSaGNtZGxkRU5zYjNObFpDaDBZWEpuWlhRNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNtbHpWR0Z5WjJWMFEyeHZjMlZrT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2dhWE5VWVhKblpYUkRiRzl6WldSZmRHVnlibUZ5ZVY5bVlXeHpaVUF5Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0thWE5VWVhKblpYUkRiRzl6WldSZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nT0NBdkx5QWlYM1JoY21kbGRITWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd01ERXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2NIVnphR2x1ZENBeE1qZ0tJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCeVpYUnpkV0lLQ21selZHRnlaMlYwUTJ4dmMyVmtYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdselZHRnlaMlYwUTJ4dmMyVmtYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxjaTV6YjJ3dVFXTmpaWE56VFdGdVlXZGxjaTVuWlhSVVlYSm5aWFJHZFc1amRHbHZibEp2YkdVb2RHRnlaMlYwT2lCaWVYUmxjeXdnYzJWc1pXTjBiM0k2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q21kbGRGUmhjbWRsZEVaMWJtTjBhVzl1VW05c1pUb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUdkbGRGUmhjbWRsZEVaMWJtTjBhVzl1VW05c1pWOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3BuWlhSVVlYSm5aWFJHZFc1amRHbHZibEp2YkdWZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRrZ0x5OGdJbUZzYkc5M1pXUlNiMnhsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J5WlhSemRXSUtDbWRsZEZSaGNtZGxkRVoxYm1OMGFXOXVVbTlzWlY5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQm5aWFJVWVhKblpYUkdkVzVqZEdsdmJsSnZiR1ZmZEdWeWJtRnllVjl0WlhKblpVQXpDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5TG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5TG1kbGRGUmhjbWRsZEVGa2JXbHVSR1ZzWVhrb2RHRnlaMlYwT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwblpYUlVZWEpuWlhSQlpHMXBia1JsYkdGNU9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nWjJWMFZHRnlaMlYwUVdSdGFXNUVaV3hoZVY5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncG5aWFJVWVhKblpYUkJaRzFwYmtSbGJHRjVYM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklEZ2dMeThnSWw5MFlYSm5aWFJ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRNREF4TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF4TkFvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG1kbGRBb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lISmxkSE4xWWdvS1oyVjBWR0Z5WjJWMFFXUnRhVzVFWld4aGVWOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJuWlhSVVlYSm5aWFJCWkcxcGJrUmxiR0Y1WDNSbGNtNWhjbmxmYldWeVoyVkFNd29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRV05qWlhOelRXRnVZV2RsY2k1emIyd3VRV05qWlhOelRXRnVZV2RsY2k1blpYUlNiMnhsUVdSdGFXNG9jbTlzWlVsa09pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0taMlYwVW05c1pVRmtiV2x1T2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2daMlYwVW05c1pVRmtiV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtZGxkRkp2YkdWQlpHMXBibDkwWlhKdVlYSjVYMjFsY21kbFFETTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKZmNtOXNaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNREl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J5WlhSemRXSUtDbWRsZEZKdmJHVkJaRzFwYmw5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQm5aWFJTYjJ4bFFXUnRhVzVmZEdWeWJtRnllVjl0WlhKblpVQXpDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5TG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5TG1kbGRGSnZiR1ZIZFdGeVpHbGhiaWh5YjJ4bFNXUTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BuWlhSU2IyeGxSM1ZoY21ScFlXNDZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCblpYUlNiMnhsUjNWaGNtUnBZVzVmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS1oyVjBVbTlzWlVkMVlYSmthV0Z1WDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lsOXliMnhsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCeVpYUnpkV0lLQ21kbGRGSnZiR1ZIZFdGeVpHbGhibDkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCblpYUlNiMnhsUjNWaGNtUnBZVzVmZEdWeWJtRnllVjl0WlhKblpVQXpDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5TG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5TG1kbGRGSnZiR1ZIY21GdWRFUmxiR0Y1S0hKdmJHVkpaRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q21kbGRGSnZiR1ZIY21GdWRFUmxiR0Y1T2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2daMlYwVW05c1pVZHlZVzUwUkdWc1lYbGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LWjJWMFVtOXNaVWR5WVc1MFJHVnNZWGxmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVgzSnZiR1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREF5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBeE9DQXhOQW9nSUNBZ1kyRnNiSE4xWWlCVWFXMWxMbWRsZEFvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUhKbGRITjFZZ29LWjJWMFVtOXNaVWR5WVc1MFJHVnNZWGxmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1oyVjBVbTlzWlVkeVlXNTBSR1ZzWVhsZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeUxuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeUxtZGxkRUZqWTJWemN5aHliMnhsU1dRNklIVnBiblEyTkN3Z1lXTmpiM1Z1ZERvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJORG9LWjJWMFFXTmpaWE56T2dvZ0lDQWdjSEp2ZEc4Z01pQTBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2daMlYwUVdOalpYTnpYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ21kbGRFRmpZMlZ6YzE5MFpYSnVZWEo1WDIxbGNtZGxRRE02Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWliV1Z0WW1WeWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTJDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURZZ01UUUtJQ0FnSUdOaGJHeHpkV0lnVkdsdFpTNW5aWFJHZFd4c0NpQWdJQ0J3YjNCdUlETUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNVFFLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzVuWlhSR2RXeHNDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQndiM0J1SURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURZZ01UUUtJQ0FnSUdOaGJHeHpkV0lnVkdsdFpTNW5aWFJHZFd4c0NpQWdJQ0J3YjNBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCdmNBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JsZUhSeVlXTjBJRFlnTVRRS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1blpYUkdkV3hzQ2lBZ0lDQndiM0J1SURJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdNZ05TQXZMeUF5T0RFME56UTVOelkzTVRBMk5UVUtJQ0FnSUNZS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQW1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQW1DaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2x1ZEdNZ05TQXZMeUF5T0RFME56UTVOelkzTVRBMk5UVUtJQ0FnSUNZS0lDQWdJSEpsZEhOMVlnb0taMlYwUVdOalpYTnpYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdkbGRFRmpZMlZ6YzE5MFpYSnVZWEo1WDIxbGNtZGxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhJdWMyOXNMa0ZqWTJWemMwMWhibUZuWlhJdWFHRnpVbTlzWlNoeWIyeGxTV1E2SUhWcGJuUTJOQ3dnWVdOamIzVnVkRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BvWVhOU2IyeGxPZ29nSUNBZ2NISnZkRzhnTWlBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNJaUNpQWdJQ0JrZFhBS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCb1lYTlNiMnhsWDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtaGhjMUp2YkdWZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTWdOaUF2THlBeE9EUTBOamMwTkRBM016Y3dPVFUxTVRZeE5Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdoaGMxSnZiR1ZmWld4elpWOWliMlI1UURVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxkSE4xWWdvS2FHRnpVbTlzWlY5bGJITmxYMkp2WkhsQU5Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJR2RsZEVGalkyVnpjd29nSUNBZ2NHOXdiaUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFFXTmpaWE56Q2lBZ0lDQndiM0J1SURJS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjRzl3Q2lBZ0lDQmllaUJvWVhOU2IyeGxYMkp2YjJ4ZlptRnNjMlZBT0FvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG5ScGJXVnpkR0Z0Y0FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lENDlDaUFnSUNCaWVpQm9ZWE5TYjJ4bFgySnZiMnhmWm1Gc2MyVkFPQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtDbWhoYzFKdmJHVmZZbTl2YkY5dFpYSm5aVUE1T2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY21WMGMzVmlDZ3BvWVhOU2IyeGxYMkp2YjJ4ZlptRnNjMlZBT0RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJR2hoYzFKdmJHVmZZbTl2YkY5dFpYSm5aVUE1Q2dwb1lYTlNiMnhsWDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHaGhjMUp2YkdWZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlCWTJObGMzTk5ZVzVoWjJWeUxuTnZiQzVCWTJObGMzTk5ZVzVoWjJWeUxsOW5jbUZ1ZEZKdmJHVW9jbTlzWlVsa09pQjFhVzUwTmpRc0lHRmpZMjkxYm5RNklHSjVkR1Z6TENCbmNtRnVkRVJsYkdGNU9pQjFhVzUwTmpRc0lHVjRaV04xZEdsdmJrUmxiR0Y1T2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1gyZHlZVzUwVW05c1pUb0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dkbUZzYVdSaGRHbHZiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdabkpoYldWZlluVnllU0F0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dkbUZzYVdSaGRHbHZiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdabkpoYldWZlluVnllU0F0TVFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnBiblJqSURZZ0x5OGdNVGcwTkRZM05EUXdOek0zTURrMU5URTJNVFVLSUNBZ0lEMDlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpUV0Z1WVdkbGNreHZZMnRsWkZKdmJHVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWliV1Z0WW1WeWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElEQWdOZ29nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNBaENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWJub2dYMmR5WVc1MFVtOXNaVjlsYkhObFgySnZaSGxBTkFvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG5ScGJXVnpkR0Z0Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOU0F2THlBeU9ERTBOelE1TnpZM01UQTJOVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG5SdlJHVnNZWGtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCd2RYTm9hVzUwSURFMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0pwZEd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwT0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWlhoMGNtRmpkQ0F5SURZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENncGZaM0poYm5SU2IyeGxYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEbGtOV0k0WkRJM0lDOHZJRzFsZEdodlpDQWlVbTlzWlVkeVlXNTBaV1FvZFdsdWREWTBMSFZwYm5RNFd6TXlYU3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tYMmR5WVc1MFVtOXNaVjlsYkhObFgySnZaSGxBTkRvS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0EySURFMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmpZV3hzYzNWaUlGUnBiV1V1ZDJsMGFGVndaR0YwWlFvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURZZ01UUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR05oYkd4emRXSWdWR2x0WlM1M2FYUm9WWEJrWVhSbENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ1gyZHlZVzUwVW05c1pWOWhablJsY2w5cFpsOWxiSE5sUURVS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSXVYM0psZG05clpWSnZiR1VvY205c1pVbGtPaUIxYVc1ME5qUXNJR0ZqWTI5MWJuUTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbDl5WlhadmEyVlNiMnhsT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTWdOaUF2THlBeE9EUTBOamMwTkRBM016Y3dPVFUxTVRZeE5Rb2dJQ0FnUFQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNOTllXNWhaMlZ5VEc5amEyVmtVbTlzWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKdFpXMWlaWEp6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTUNBMkNpQWdJQ0JpZEc5cENpQWdJQ0JpYm5vZ1gzSmxkbTlyWlZKdmJHVmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncGZjbVYyYjJ0bFVtOXNaVjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3laRGc1WlRrd055QXZMeUJ0WlhSb2IyUWdJbEp2YkdWU1pYWnZhMlZrS0hWcGJuUTJOQ3gxYVc1ME9Gc3pNbDBwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGalkyVnpjMDFoYm1GblpYSXVjMjlzTGtGalkyVnpjMDFoYm1GblpYSXVaMlYwVTJOb1pXUjFiR1VvYVdRNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNtZGxkRk5qYUdWa2RXeGxPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ1oyVjBVMk5vWldSMWJHVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LWjJWMFUyTm9aV1IxYkdWZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTmlBdkx5QWlYM05qYUdWa2RXeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EyQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gybHpSWGh3YVhKbFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJSE5sYkdWamRBb2dJQ0FnYVc1MFl5QTFJQzh2SURJNE1UUTNORGszTmpjeE1EWTFOUW9nSUNBZ0pnb2dJQ0FnY21WMGMzVmlDZ3BuWlhSVFkyaGxaSFZzWlY5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQm5aWFJUWTJobFpIVnNaVjkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEl1YzI5c0xrRmpZMlZ6YzAxaGJtRm5aWEl1WDJOdmJuTjFiV1ZUWTJobFpIVnNaV1JQY0NodmNHVnlZWFJwYjI1SlpEb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tYMk52Ym5OMWJXVlRZMmhsWkhWc1pXUlBjRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lsOXpZMmhsWkhWc1pYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEWUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTXpJS0lDQWdJR1JwWnlBeENpQWdJQ0FoQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXTmpaWE56VFdGdVlXZGxjazV2ZEZOamFHVmtkV3hsWkFvZ0lDQWdZMkZzYkhOMVlpQlVhVzFsTG5ScGJXVnpkR0Z0Y0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQlkyTmxjM05OWVc1aFoyVnlUbTkwVW1WaFpIa0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWDJselJYaHdhWEpsWkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6YzAxaGJtRm5aWEpGZUhCcGNtVmtDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ05pQTBDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QXdlREF3TURBd01EQXdNREF3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdGa00yUTBNR1JrSUM4dklHMWxkR2h2WkNBaVQzQmxjbUYwYVc5dVJYaGxZM1YwWldRb2RXbHVkRGhiTXpKZExIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUJZMk5sYzNOTllXNWhaMlZ5TG5OdmJDNUJZMk5sYzNOTllXNWhaMlZ5TG1oaGMyaFBjR1Z5WVhScGIyNG9ZMkZzYkdWeU9pQmllWFJsY3l3Z2RHRnlaMlYwT2lCaWVYUmxjeXdnWkdGMFlUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG9ZWE5vVDNCbGNtRjBhVzl1T2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2dhR0Z6YUU5d1pYSmhkR2x2Ymw5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncG9ZWE5vVDNCbGNtRjBhVzl1WDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBMk1Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NIVnphR2x1ZENBek1Rb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdNekVLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnTHdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JyWldOallXc3lOVFlLSUNBZ0lISmxkSE4xWWdvS2FHRnphRTl3WlhKaGRHbHZibDkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCb1lYTm9UM0JsY21GMGFXOXVYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxjaTV6YjJ3dVFXTmpaWE56VFdGdVlXZGxjaTVmWTJobFkydEJkWFJvYjNKcGVtVmtLQ2tnTFQ0Z2RtOXBaRG9LWDJOb1pXTnJRWFYwYUc5eWFYcGxaRG9LSUNBZ0lIQnliM1J2SURBZ01Bb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOXRjMmRFWVhSaENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJmWTJGdVEyRnNiRk5sYkdZS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQmZiWE5uUkdGMFlRb2dJQ0FnWTJGc2JITjFZaUJmWTJGdVEyRnNiRk5sYkdZS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCdmNBb2dJQ0FnWW01NklGOWphR1ZqYTBGMWRHaHZjbWw2WldSZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1ltNTZJRjlqYUdWamEwRjFkR2h2Y21sNlpXUmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lHTmhiR3h6ZFdJZ1gyMXpaMFJoZEdFS0lDQWdJR05oYkd4emRXSWdYMmRsZEVGa2JXbHVVbVZ6ZEhKcFkzUnBiMjV6Q2lBZ0lDQndiM0J1SURNS0lDQWdJR1Z5Y2lBdkx5QkJZMk5sYzNOTllXNWhaMlZ5Vlc1aGRYUm9iM0pwZW1Wa1FXTmpiM1Z1ZEFvS1gyTm9aV05yUVhWMGFHOXlhWHBsWkY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCallXeHNjM1ZpSUY5dGMyZEVZWFJoQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQm9ZWE5vVDNCbGNtRjBhVzl1Q2lBZ0lDQmpZV3hzYzNWaUlGOWpiMjV6ZFcxbFUyTm9aV1IxYkdWa1QzQUtJQ0FnSUhCdmNBb0tYMk5vWldOclFYVjBhRzl5YVhwbFpGOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRmpZMlZ6YzAxaGJtRm5aWEl1YzI5c0xrRmpZMlZ6YzAxaGJtRm5aWEl1WDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1ektHUmhkR0U2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5NNkNpQWdJQ0J3Y205MGJ5QXhJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNVGNnTHk4Z01IZ3dOQW9nSUNBZ1lqd0tJQ0FnSUdKNklGOW5aWFJCWkcxcGJsSmxjM1J5YVdOMGFXOXVjMTloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjbVYwYzNWaUNncGZaMlYwUVdSdGFXNVNaWE4wY21samRHbHZibk5mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemRXSnpkSEpwYm1jZ01DQTBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EVXpOVFV4WWpnS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1elgybG1YMkp2WkhsQU53b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNd1kyRmxNVGczQ2lBZ0lDQTlQUW9nSUNBZ1ltNTZJRjluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1YzE5cFpsOWliMlI1UURjS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTWprMk1qazFNZ29nSUNBZ1BUMEtJQ0FnSUdKdWVpQmZaMlYwUVdSdGFXNVNaWE4wY21samRHbHZibk5mYVdaZlltOWtlVUEzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZVFkwWkRrMVkyVUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1gyZGxkRUZrYldsdVVtVnpkSEpwWTNScGIyNXpYMmxtWDJKdlpIbEFOd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHUXlNbUkxT1RnNUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1elgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvS1gyZGxkRUZrYldsdVVtVnpkSEpwWTNScGIyNXpYMmxtWDJKdlpIbEFOem9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxkSE4xWWdvS1gyZGxkRUZrYldsdVVtVnpkSEpwWTNScGIyNXpYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE9HWm1NVGd6WXdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5OZmFXWmZZbTlrZVVBeE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMk4ySmtNemsxQ2lBZ0lDQTlQUW9nSUNBZ1ltNTZJRjluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1YzE5cFpsOWliMlI1UURFeENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURoa05qRXlNbVFLSUNBZ0lEMDlDaUFnSUNCaWVpQmZaMlYwUVdSdGFXNVNaWE4wY21samRHbHZibk5mWVdaMFpYSmZhV1pmWld4elpVQXhNZ29LWDJkbGRFRmtiV2x1VW1WemRISnBZM1JwYjI1elgybG1YMkp2WkhsQU1URTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOMVluTjBjbWx1WnlBMElETTJDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFZHRnlaMlYwUVdSdGFXNUVaV3hoZVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NtVjBjM1ZpQ2dwZloyVjBRV1J0YVc1U1pYTjBjbWxqZEdsdmJuTmZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneU5XTTBOekZoTUFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5OZmFXWmZZbTlrZVVBeE5Bb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdJM1pESmlNVFl5Q2lBZ0lDQTlQUW9nSUNBZ1lub2dYMmRsZEVGa2JXbHVVbVZ6ZEhKcFkzUnBiMjV6WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLQ2w5blpYUkJaRzFwYmxKbGMzUnlhV04wYVc5dWMxOXBabDlpYjJSNVFERTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemRXSnpkSEpwYm1jZ05DQXpOZ29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWTJGc2JITjFZaUJuWlhSU2IyeGxRV1J0YVc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J5WlhSemRXSUtDbDluWlhSQlpHMXBibEpsYzNSeWFXTjBhVzl1YzE5aFpuUmxjbDlwWmw5bGJITmxRREUxT2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRlJoY21kbGRFWjFibU4wYVc5dVVtOXNaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNpNXpiMnd1UVdOalpYTnpUV0Z1WVdkbGNpNWZZMkZ1UTJGc2JFVjRkR1Z1WkdWa0tHTmhiR3hsY2pvZ1lubDBaWE1zSUhSaGNtZGxkRG9nWW5sMFpYTXNJR1JoZEdFNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRc0lIVnBiblEyTkRvS1gyTmhia05oYkd4RmVIUmxibVJsWkRvS0lDQWdJSEJ5YjNSdklETWdNZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlJZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1BUMEtJQ0FnSUdKdWVpQmZZMkZ1UTJGc2JFVjRkR1Z1WkdWa1gybG1YMkp2WkhsQU1nb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdZbnBsY204S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lEMDlDaUFnSUNCaWVpQmZZMkZ1UTJGc2JFVjRkR1Z1WkdWa1gyVnNjMlZmWW05a2VVQXpDZ3BmWTJGdVEyRnNiRVY0ZEdWdVpHVmtYMmxtWDJKdlpIbEFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5allXNURZV3hzVTJWc1pnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWpZVzVEWVd4c1JYaDBaVzVrWldSZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNVGNnTHk4Z01IZ3dOQW9nSUNBZ1lqd0tJQ0FnSUdKNklGOWpZVzVEWVd4c1JYaDBaVzVrWldSZmRHVnlibUZ5ZVY5bVlXeHpaVUExQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0tYMk5oYmtOaGJHeEZlSFJsYm1SbFpGOTBaWEp1WVhKNVgyMWxjbWRsUURZNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCeVpYUnpkV0lLQ2w5allXNURZV3hzUlhoMFpXNWtaV1JmZEdWeWJtRnllVjltWVd4elpVQTFPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemRXSnpkSEpwYm1jZ01DQTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlHTmhia05oYkd3S0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZaUJmWTJGdVEyRnNiRVY0ZEdWdVpHVmtYM1JsY201aGNubGZiV1Z5WjJWQU5nb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlFXTmpaWE56VFdGdVlXZGxjaTV6YjJ3dVFXTmpaWE56VFdGdVlXZGxjaTVmWTJGdVEyRnNiRk5sYkdZb1kyRnNiR1Z5T2lCaWVYUmxjeXdnWkdGMFlUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncGZZMkZ1UTJGc2JGTmxiR1k2Q2lBZ0lDQndjbTkwYnlBeUlESUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lpSUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJREUzSUM4dklEQjRNRFFLSUNBZ0lHSThDaUFnSUNCaWVpQmZZMkZ1UTJGc2JGTmxiR1pmWVdaMFpYSmZhV1pmWld4elpVQXlDZ3BmWTJGdVEyRnNiRk5sYkdaZmFXWmZZbTlrZVVBeE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1gyTmhia05oYkd4VFpXeG1YMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1gyTmhia05oYkd4VFpXeG1YMmxtWDJKdlpIbEFOQW9nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJRDA5Q2lBZ0lDQmllaUJmWTJGdVEyRnNiRk5sYkdaZllXWjBaWEpmYVdaZlpXeHpaVUExQ2dwZlkyRnVRMkZzYkZObGJHWmZhV1pmWW05a2VVQTBPZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MzVmljM1J5YVc1bklEQWdOQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lsOWxlR1ZqZFhScGIyNUpaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYMlY0WldOMWRHbHZia2xrSUdWNGFYTjBjd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQmZhR0Z6YUVWNFpXTjFkR2x2Ymtsa0NpQWdJQ0E5UFFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2w5allXNURZV3hzVTJWc1psOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdYMmRsZEVGa2JXbHVVbVZ6ZEhKcFkzUnBiMjV6Q2lBZ0lDQndiM0J1SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQmZaMlYwUVdSdGFXNVNaWE4wY21samRHbHZibk1LSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJmWjJWMFFXUnRhVzVTWlhOMGNtbGpkR2x2Ym5NS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JpYm5vZ1gyTmhia05oYkd4VFpXeG1YMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdOaGJHeHpkV0lnYVhOVVlYSm5aWFJEYkc5elpXUUtJQ0FnSUdKdWVpQmZZMkZ1UTJGc2JGTmxiR1pmYVdaZlltOWtlVUF4Q2dwZlkyRnVRMkZzYkZObGJHWmZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlHaGhjMUp2YkdVS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlHaGhjMUp2YkdVS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjRzl3Q2lBZ0lDQmllaUJmWTJGdVEyRnNiRk5sYkdaZmFXWmZZbTlrZVVBeENpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndNZ29nSUNBZ1kyRnNiSE4xWWlCTllYUm9MbTFoZUFvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCTllYUm9MbTFoZUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5SaklEUWdMeThnTkRJNU5EazJOekk1TlFvZ0lDQWdKZ29nSUNBZ1pIVndDaUFnSUNBaENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5QlkyTmxjM05OWVc1aFoyVnlMbk52YkM1QlkyTmxjM05OWVc1aFoyVnlMbDlwYzBWNGNHbHlaV1FvZEdsdFpYQnZhVzUwT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1gybHpSWGh3YVhKbFpEb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqSURVZ0x5OGdNamd4TkRjME9UYzJOekV3TmpVMUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZDU1NCMllXeHBaR0YwYVc5dUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdNZ05TQXZMeUF5T0RFME56UTVOelkzTVRBMk5UVUtJQ0FnSUNZS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRFS0lDQWdJR05oYkd4emRXSWdaWGh3YVhKaGRHbHZiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05TQXZMeUF5T0RFME56UTVOelkzTVRBMk5UVUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHTmhiR3h6ZFdJZ1ZHbHRaUzUwYVcxbGMzUmhiWEFLSUNBZ0lEdzlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhJdWMyOXNMa0ZqWTJWemMwMWhibUZuWlhJdVgyaGhjMmhGZUdWamRYUnBiMjVKWkNoMFlYSm5aWFE2SUdKNWRHVnpMQ0J6Wld4bFkzUnZjam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BmYUdGemFFVjRaV04xZEdsdmJrbGtPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWaklESXpJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lpWUtJQ0FnSUdKNWRHVmpJREl6SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUVoaGMyaGxjeTVsWm1acFkybGxiblJMWldOallXc3lOVFlLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVdOalpYTnpUV0Z1WVdkbGNpNXpiMnd1UVdOalpYTnpUV0Z1WVdkbGNpNWZiWE5uUkdGMFlTZ3BJQzArSUdKNWRHVnpPZ3BmYlhOblJHRjBZVG9LSUNBZ0lIQnliM1J2SURBZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z01UUUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURVd0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1Bnb2dJQ0FnWW5vZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUEyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDIxbGNtZGxRRGM2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREV6Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBK0NpQWdJQ0JpZWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNVEE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F4TkFvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1Bnb2dJQ0FnWW5vZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TXpvS0lDQWdJR1p5WVcxbFgyUnBaeUF4TkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lENEtJQ0FnSUdKNklGOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTVRVS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTVRZNkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lENEtJQ0FnSUdKNklGOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTVRnS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTVRrNkNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lENEtJQ0FnSUdKNklGOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTWpFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURZS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTWpJNkNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lENEtJQ0FnSUdKNklGOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTWpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURjS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTWpVNkNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURVS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU53b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ09Bb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnT1FvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek1Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ09Rb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBek1Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ053b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJRDRLSUNBZ0lHSjZJRjl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU16TUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXdDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFETTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEY0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTRDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2NIVnphR2x1ZENBeE1Rb2dJQ0FnUGdvZ0lDQWdZbm9nWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXpOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVEVLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNemM2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dPQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGtLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERXlDaUFnSUNBK0NpQWdJQ0JpZWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRE01Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TWdvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTURvS0lDQWdJR1p5WVcxbFgyUnBaeUE1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTVRBS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJREV6Q2lBZ0lDQStDaUFnSUNCaWVpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURReUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE13b0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBME16b0tJQ0FnSUdaeVlXMWxYMlJwWnlBeE1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERXhDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2NIVnphR2x1ZENBeE5Bb2dJQ0FnUGdvZ0lDQWdZbm9nWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQTBOUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVFFLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFORFk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVEVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F4TWdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJSEIxYzJocGJuUWdNVFVLSUNBZ0lENEtJQ0FnSUdKNklGOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTkRnS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFMUNncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURRNU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtDbDl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU5URTZDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQTBPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURRNUNncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURRMU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFORFlLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFOREk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHSWdYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBME13b0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDIxbGNtZGxRRFF3Q2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRE0yT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU16Y0tDbDl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU16TTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdJZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TkFvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TURvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFETXhDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFESTNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlGOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTWpnS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTWpRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbnBsY204S0lDQWdJR0lnWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXlOUW9LWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXlNVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURJeUNncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURFNE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNVGtLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNVFU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHSWdYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5nb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDIxbGNtZGxRREV6Q2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRGs2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHSWdYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1Bb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFOd29LWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdJZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUEwQ2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRRFV3T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU5URUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZqWTJWemMwMWhibUZuWlhJdWMyOXNMa0ZqWTJWemMwMWhibUZuWlhJdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFIQUFFZ0NQLy8vLzhQLy8vLy8vLy9QLy8vLy8vLy8vLy8vd0VtR0FRVkgzeDFBQW9BQUFBQUFBQUFBQUFBRkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJsOXliMnhsY3lJQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ2w5elkyaGxaSFZzWlhNTVgyVjRaV04xZEdsdmJrbGtDRjkwWVhKblpYUnpFZ0FSQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUVBSVFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQTVmWDJOMGIzSmZjR1Z1WkdsdVp3SUFBQUVCSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCMjFsYldKbGNuTUJCQVlBQUFBQUFBQU1ZV3hzYjNkbFpGSnZiR1Z6QWdBZ0lBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUFBQUFBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUUFBQUFBQUFBQUFGUC8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vSWtjVEtVY1BnWUFncjBrMUJUVUFOQUNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FYRUExQURFWVFBQUdKd3dqWnlORE1Sa1VSREVZUklJaEJKa1BNSzRFMEhsa01RU2VxbGM2Qk0veTVpRUUxRVFQVndTSDFVVUxCQ3dLellFRTJuVUxJd1FUNlNpR0JEMjhiVU1Fa1BXT2RRVHhCbWVaQklrY04wb0V4TjRYQ3dUeGlvT29CTFVTVlZ3RUxmQXFKd1FvUk51ZUJEUksvMEFFMld1S2ZRUUc3Y011Qk1iVkZTNEVySnk2RGdTRjA0TGhCQ295emRFRU8xeWdoZ1FzZzJiWUJHYWF3RXNFQkpVY0tRVGRtQ2pWQkczREF3VUV2Mk4yV3dRRWtab21OaG9BamlFS1Vnb25DaDBLRXduOENlRUp6d204Q2FrSmxnbHVDVXNJK1FpcUNIY0lQZ2V5QnlZR21nWU9CWXdGRFFUN0JNY0RvUUwrQWtFQjJ3R3hBV2dCUmdFa0FBRUFOaG9CU1NKWlNVVVBnUUlMUlFkSkZVVURWd0lBUlNJaVJRcExDVXNOREVFQUowc0pTWUVDQzBzalNVOENXVWxMQ1VsT0JCSkVTd0VWVWlKWmdRSUlDRVVISXdoRkNrTC8wVXNGZ1FJSVN3SVNSREVXUVFESU1SWWpDVGdJRkVRbkRVVWtJa1VQU3c1TERReEJBRDlMSTBraVdVbUJBZ3VCQWdoTEFvRUNTd0pTZ1FLdlVFc0RGVThFVHdOUEFsSW5EVkJRVENNSVNSWlhCZ0JPQWlLSUNlZFFTdzhqQ0VVUVJTUkMvN2twUlIxTEkwVVhTd3dXU3gybFFRQmJOQUExQUNXdlN4MUpUZ0pRU1JVbENWdExHRWxPQWlKWlN3RU5SRXNCVVFBQ1NSZFBBMWNDQUVzRGdRSUxTd0ZNV1VwWlN3RUlnUUlJU3dJaVR3TlNKdzFRU3dJVlRFNERVbEJNVHdPSUNYdFFSUmduRHFCRkhVTC9uQ2hMRjFDd0kwTWlRdjg2TVJaQkFCa3hGaU1KT0FnVVJJQU1GUjk4ZGYvLy8vLy8vLy8vc0NORElrTC82VEVXUVFBWk1SWWpDVGdJRkVTQURCVWZmSFVBQUFBQUFBQUFBTEFqUXlKQy8razJHZ0ZKUlJVVkpCSkVOaG9DU1VVYUZTUVNSREVXUVFBc01SWWpDVGdJRkVTSUQ4NnhTeE9CR0Z1QkJySVFJcklaSXJJQnNoaUFCTTNhVHFheUdrc1lzaHF6STBNaVF2L1dOaG9CU1JVa0VrUTJHZ0pKRlNRU1JEWWFBMGtpV1lFQ0NFc0JGUkpFVndJQWlBOGdLRXhRc0NORE5ob0JTVVVpRlNRU1JEWWFBa2tpV1lFQ0NFc0JGUkpFVndJQVJSOHhGa0VBUURFV0l3azRDQlJFTVFDeFNZRVlXNEVHc2hBaXNoa2lzZ0d5R0lBRXpWRTlwYklhczdRK1Z3UUFnQVNQczJBM0V4UkVTeUZNU3lDSURyNklEbTFJSTBNaVF2L0NOaG9CU1VVaUZTUVNSRFlhQWtsRkZSVWtFa1EyR2dOSklsbUJBZ2hMQVJVU1JGY0NBRVVmTVJaQkFJMHhGaU1KT0FnVVJERUFTVVViU3g5SlVRQUVSUmhMSWtsT0Frc1hUd0tJRG1kSlJSc0JKd1pNVUVsRkhyNHFUZ0pOVndBR0Z4UVVSQk5CQUNJaVN4cEpUZ0tJRElOSVRFc1ZTeGlJQzBDSUM3Sk1pQXh6U0VVS1FBQURTd2hFU3hwSnZpcE9BazFYQmdRbkVreFFURXNCdjRFR1dra1dTeGxNVUlBRWMycjByRXhRc0NFRUdoWW9URkN3STBNaVF2OTFOaG9CU1VVVlNSVWtFa1EyR2dKSklsbUJBZ2hMQVJVU1JGY0NBRWxGSVRFQVNVVWtTVXNEU3dPSUR6ZElUZ05PQW9nUEwwVUZTRUFBQlVzQ0ZCUkVTeUJMRkVzZ2lBMnZSUmdpUlFkTEFrQUFDRXNYaUEwalFRQUhTeGVJRFVwRkJ5SW5CMlZNUlI5RVN4NVJBQVJMRkV5SUQvNG5CMHhuTVJaQkFDSXhGaU1KT0FnV1N4UkxJRThDaUFkS1NDY0hTeDVuU3dZaEJCb1dLRXhRc0NORElrTC80RFlhQVVsRkZSVWtFa1EyR2dKSlJSTkpJbG1CQWdoTEFSVVNSRmNDQUVVZk5ob0RTUlVsRWtRWFJRRXhGa0VBOGpFV0l3azRDQlJFUndJaEJRNUVJUVVhU1VVQ01RQkpSU05MRlVzaGlBNXdSUUdJQ0IxTEFRaEpSUk1oQlE1RUZCUkVRUUFHU1VzUURCUkVKYTlMQVJaTEVSWktpQWU2U3dOTVVFNENpQWV4VHdKTVVCVWxDVnNoQlJwRkFVc2dTeFJMSUlnTXZrbEZHUUVuQmt4UVNVVWN2aXBPQWsxWEFBWVhTVVVHUVFBR1N3U0lEdnBFU3hwSnZpcE9BazFKZ1FaYUl3aUJnSUNBZ0JBWVRGY0dCRXNERmttVGdUQU9SRWxYQWdaUEFsQkxBaFpKa3lRT1JFbFhCQVJQQWxjQUJreFFUd1JNdjBzYVNVNERURkJNVUVzalVFc1dVSUFDQUhKUVN4UlFnQVQ0dDNrYVRGQ3dUQ0VFR2haUUtFeFFzQ05ESWtML0VEWWFBVWxGSFJVa0VrUXhGa0VBSVRFV0l3azRDQlJFU3hzQkp3Wk1VTDRxVGdKTmdRWmFJUVFhRmloTVVMQWpReUpDLytFMkdnRkpGU1FTUklnTGNoWW9URkN3STBNMkdnRkpSUlVWSkJKRU5ob0NTVVVUU1JVakVrUWlVMFVNTVJaQkFGMHhGaU1KT0FnVVJJZ01KRXNMSXc1RVN4TkpBU2NJVEZCSnZpY0pUZ0pOU1ZjQ0Rrc0JJbGxMQWhWUEEwNENVbGNDQUVrVkZsY0dBa3hRZ0FJQUVVOENVRXNWU1U0RFVFeFFTd0s4U0U4Q1RMOVFnQVRPZW1VUFRGQ3dJME1pUXYrbE5ob0JTVVVWRlNRU1JEWWFBa2tWSlJKRUYwVUlNUlpCQUdReEZpTUpPQWdVUklnTHFVc0hTU0VFRGtRaEJCcEpJUVFPUkNFRUdrc1VTVTRDQVNjSVRGQkp2aWNKVGdKTlZ3SU9pQWZkU3dOTWlBYWhSZ0srSndsT0FrMVhBZzZJQjhsTEFreUlCbzFPQWtnV1RCWk9BbEJNVUlBRXc2SHlJVXhRc0NORElrTC9uallhQVVsRkZCVWtFa1EyR2dKSlJSWkpJbGxKUlJDQkJBdUJBZ2hNRlJKRU5ob0RTVVVTU1JVbEVrUVhSUVF4RmtFQVZURVdJd2s0Q0JSRWlBc09JaFpGSFVzTkZrc2RwVUVBT3lXdlN4MUpUZ0pRU1JVbENWdExGbGNDQUV5QkJBdUJCRmhKQVNjVFRGQkxCaGEvU3hSTVVFc1NVSUFFMVVsaWwweFFzQ2NPb0VVZFF2KzhJME1pUXYrdE5ob0JTVVVVU1JVbEVrUVhSUVEyR2dKSkZTVVNSQmRGQ0RFV1FRQnFNUllqQ1RnSUZFU0lDcGRMQjBraEJBNUVJUVFhU1NFRURrUWhCQnBMQkVraEJoSVVSQllCSndSTVVFbStKd1ZPQWsxWEVnNklCc2RMQTB5SUJZdEdBcjRuQlU0Q1RWY1NEb2dHczBzQ1RJZ0ZkMDRDU0JaTUZrc1VUd0pRVEZDQUJLM3BVODlNVUxBalF5SkMvNWcyR2dGSlJSUkpGU1VTUkJkRkJEWWFBa2xGRXhVbEVrUXhGa0VBYXpFV0l3azRDQlJFaUFvTVN3TkpGQlJFU1NFR0VoUkVGZ0VuQkV4UVNiNG5CVTRDVFVsWEFnaExBVmNTRGtzQ0lsbExBeFZQQkU0Q1VsY0NBRWtWRmxjR0FreFFKeFJQQTFCTEZVbE9BMUJQQTFCTVVFc0N2RWhQQWt5L1N4Tk1VSUFFYThlSHhreFFzQ05ESWtML2x6WWFBVWxGRkVrVkpSSkVGMFVFTmhvQ1NVVVRGU1VTUkRFV1FRQnJNUllqQ1RnSUZFU0lDWUJMQTBrVUZFUkpJUVlTRkVRV0FTY0VURkJKdmljRlRnSk5TVmNTRGtzQlZ3b0lTd0lpV1VzREZVOEVUZ0pTVndJQVNSVVdWd1lDVEZBbkZFc1dTVTREVUU4RFVFOERVRXhRU3dLOFNFOENUTDlMRTB4UWdBVDlUUGlRVEZDd0kwTWlRditYTmhvQlNSVWxFa1FYUlFRMkdnSkpSU0VWSkJKRU1SWkJBQnN4RmlNSk9BZ1VSREVBU3lCSlR3SVRGRVJMQkV5SUI5RklJME1pUXYvbk5ob0JTUlVsRWtRWFJRUTJHZ0pKUlNRVkpCSkVNUlpCQUJVeEZpTUpPQWdVUklnSXZrc0RTeU9JQjU1SUkwTWlRdi90TmhvQlNSVWxFa1FYUlFRMkdnSkpSU1FWSkJKRU5ob0RTUlVsRWtRWFJRc3hGa0VBSmpFV0l3azRDQlJFaUFpQVN3cEpJUVFPUkNFRUdrc0VTWWdGckVzbFRFOERpQWFiU0NORElrTC8zRFlhQVVsRkZFa1ZKUkpFRjBVRU5ob0NTVVVUU1NKWmdRSUlUQlVTUkRFV1FRQXJNUllqQ1RnSUZFU0lDRE5MQTBrVUZFUWhCaElVUkVzU2dBSUFDbEJMRWxDQUJES0xnVzlNVUxBalF5SkMvOWMyR2dGSkZTVVNSQmMyR2dKSkZTUVNSSWdGMWljS0lrOERWRXdXVUNoTVVMQWpRellhQVVrVkpSSkVGellhQWtrVkpCSkVpQVZBVHdNV1R3TVdVRThDRmxCTUZsQW9URkN3STBNMkdnRkpGU1VTUkJlSUJQUVdLRXhRc0NORE5ob0JTUlVsRWtRWGlBUzdGaWhNVUxBalF6WWFBVWtWSlJKRUY0Z0VnaFlvVEZDd0kwTTJHZ0ZKRlNRU1JJZ0VSUllvVEZDd0kwTTJHZ0ZKRlNRU1JEWWFBa2tWZ1FRU1JJZ0VCaFlvVEZDd0kwTTJHZ0ZKRlNRU1JJZ0R4aWNLSWs4Q1ZDaE1VTEFqUTRnRG9SWW9URkN3STBPSUE0RVdLRXhRc0NORE5ob0JTUlVrRWtRMkdnSkpGU1FTUkRZYUEwa1ZnUVFTUklnQzR5Y0tJazhEVkV3V1VDaE1VTEFqUXpZYUFVa1ZKQkpFSnd4a1JDY01JbWNuQ0lFQ3VVZ25CSUVDdVVnbkJvRUN1VWduQnljUFowa25EeElVUkNKTUlrbUlCUWRJSTBPS0F3R0wvb0VDQzBtTC80RUNDNHY5U3dGWlR3Sk1pLzlOVElzQ2l3QU1RUUFsaXdGSkZsY0dBSXY5aXdKSlRnUlBBbDFKalAxTEFWbUJBZ2dJakFHQkFnaU1Ba0wvMDR2OWpBQ0ppZ01CTWdwekFFZ1dpLytrRkVTTC9Zdi9pLzZJQUdwSmkvMkJHRnR5QUVoTVFRQVhpQUNIS2FWQUFBbUxBUlVXS2FWQkFBYUlBSHlNQUltTEFCUkVpQUJzS2FWRVFnQ2ZpZ0lCTkFBa3IwbUwvbEJKRlNRSkpGaFBBa3hjQUVzQmkvOVFTUlVrQ1NSWVhDQkpWd0JBQWs4Q1RGQkpGU1FKSkZoWEFDQk1OUUNKaWdNQk5BQWxyNHYvZ0FFZ29DY0xxa3NCVEZCSkZTVUpXMHlMLzFCSkZTVUpXMHNDVGdKWVhBQTFBQ09KTkFBMUFDbUpOQUFscjBzQlYwQWdURXNCVUVrVkpRbGJKSzlQQTA4Q0p3OWRTd0tBQVNDZ0p3dXFUd0pNVUVrVkpBa2tXRnhBTlFDSkFJb0RBWXYraS8rdGkvMklBRGFqSnd1cWkvK3RpWW9DQVl2K2kvK2xpLzZMLzRqLzNJbUtBUUdMLzRBRy8vLy8vLy8vcFJSRUphK0wvMUJKRlNVSld5RUZHb21LQVFFMEFJdi9GQlFwSnc1UEFrMU1OUUNKTWdjV2lQL0ppWW9CQVl2L0ZvbUtBZ01waS82SUFLcEdBNHYraUFDalNVNERUZ05HQW92K2lBQ1hTRTRDU0l2K2lBQ09SZ0pPQW92L0RrRUFEaUtNQUNLTEFFeFBCVThGVHdXSml3Rk1qQUNMQWt4Qy8rdUtBUU9JLzZTTC8weUkvNnlKaWdFQmkvK0kvK3RHQW9tS0F3S0wvWWovN1VtTC9nMUJBRUNMQUl2K0NVa2hCQTVFSmErTC94WlBBaFpLaVA4c1N3Tk1VRTRDaVA4alR3Sk1VQlVsQ1ZzaEJCcUkvMVlJU1NFRkRrU0xBSXYrU3dLSUFEOU1Ud0tKSWtML3hvb0JBeVd2U1l2L1VFa1ZKUWxiSVFRYWkvOG5GYUpMQWt4UVNSVWxDVnNoQkJxTC95Y1dvazhEVEZCSkZTVUpXeUVGR2t4T0FvbUtBd0dML3hZbkZxTW5DNnFML1JZbkZhTW5DNnFyaS80V3E0bUtBd0lwU1RFV1FRQnRNUllqQ1RnSUZFU0wvb2dBa0VFQUJ5SkpUd05QQTRreUNvdjlFa0FBRFlFWXJ6SUlGbENML1JKQkFCTWlKd2RsUkl2K2kvK0lCZ2dTSWs4RFR3T0ppLzZMLzRnQWhVbUwvWWdCdVVoTWkvMklBYktNQUVoQkFBMkxBRWtVakFHTEFVNERUZ0tKSW93QklrTC84aUpDLzVVeEZrRUFEVEVXSXdrNENCUkVnWUQxSklraVF2LzFNUlpCQUEweEZpTUpPQWdVUklHQXJ4cUpJa0wvOVlvQkFURVdRUUFpTVJZakNUZ0lGRVNML3dFbkNFeFF2aWNKVGdKTmdZQUJVeWNLSWs4Q1ZDSlRpU0pDLytDS0FnRXhGa0VBR0RFV0l3azRDQlJFaS84Qkp4Tk1VTDVNRnlKTVR3Sk5pU0pDLytxS0FRRXhGa0VBSHpFV0l3azRDQlJFaS84Qkp3aE1VTDRuQ1U0Q1RWY0NEb2orTkNFRUdva2lRdi9qaWdFQk1SWkJBQm94RmlNSk9BZ1VSSXYvRmdFbkJFeFF2aWNGVGdKTmdRSmJpU0pDLytpS0FRRXhGa0VBR2pFV0l3azRDQlJFaS84V0FTY0VURkMrSndWT0FrMkJDbHVKSWtMLzZJb0JBVEVXUVFBZ01SWWpDVGdJRkVTTC94WUJKd1JNVUw0bkJVNENUVmNTRG9qOXZDRUVHb2tpUXYvaWlnSUVNUlpCQUdjeEZpTUpPQWdVUkl2L0FTY1FURkJKdml0T0FrMUpWd0FHRjB4WEJnNkkvWDVHQTBzQnZpdE9BazFYQmc2SS9XOU9BMFlDU3dLK0swNENUVmNHRG9qOVhraE9Ba2hQQTc0clRnSk5Wd1lPaVAxTlJnSk1JUVVhVENFRUdrOENJUVFhVHdNaEJScUpJa0wvbTRvQ0FpbEpNUlpCQUVveEZpTUpPQWdVUkl2K0lRWVNRUUFISXlKUEEwOERpWXYraS8rSS8yVkdBMG1NQVl2K2kvK0kvMWxHQW93QVNFRUFGSWo4bjRzQkQwRUFDeU9MQUNFRUdrOERUd09KSWtMLzhpSkMvN2lLQkFHTC9pRUVEa1NML2lFRUdveitpLzhoQkE1RWkvOGhCQnFNLzR2OElRWVNGRVNML1FFbkVFeFFTYjRyVGdKTlZ3QUdGMGtVVGdKQUFGU0kvRWVML2doSklRVU9SSXYvaVB4QlNSV0JEZzVFZ1E2dnEwc0JGa21UZ1RBT1JGY0NCa3hRVHdKTXY0di9GaWNLSW9zQVNVNEVWSXY4Rms4RUZreUwvVkJQQTFCTVVFeFFnQVNkVzQwblRGQ3dUSWxKdml0T0FrMVhCZzZML3lLSS9GVkdBcjRyVGdKTlZ3WU9pLzhpaVB4RlJRRkMvN1NLQWdHTC9pRUdFaFJFaS84Qkp4Qk1VRW0rSzA0Q1RWY0FCaGRBQUFNaVRJbUxBTHhJaS80V2kvOVFnQVF0aWVrSFRGQ3dJMHlKaWdFQk1SWkJBQ014RmlNSk9BZ1VSSXYvQVNjR1RGQytLazRDVFZjQUJoZEppQUswSWt4TklRVWFpU0pDLzkrS0FRR0wvd0VuQmt4UVNiNHFUZ0pOU1ZjQUJoZE1nUVphU3dFVUZFU0krMHRMQWd3VVJFeUlBbjhVUkVzQnZpcE9BazFYQmdRbkVreFFUd0pNdjBrV2kvOU1VSUFFclQxQTNVeFFzSW1LQXdFeEZrRUFXVEVXSXdrNENCUkVpLzJML2xBa3IweUFJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCZ1VJdi9GVWtXVHdOTVVFa1ZKQWtrV0lFZnI0di9URkJQQW9FZkNDUUtKQXNpVEZoUVVBS0pJa0wvcVlvQUFERUFTWWdDSjBzQlRJZ0JRMGhNaUFJY2lBRTdUZ0pJUUFBZWl3RkFBQW1JQWd1SUFCUkdBd0F5Q29nQ0FJc0FUZ0tJLzJTSS94TklpWW9CQXlLTC94VVdKeEdrUVFBR0lrY0NUd09KaS85UkFBUkpqQUNBQklVMVViZ1NRQUF3aXdDQUJEREs0WWNTUUFBa2l3Q0FCRktXS1ZJU1FBQVlpd0NBQktaTmxjNFNRQUFNaXdDQUJOSXJXWWtTUVFBR0l5SkpUd09KaXdDQUJCai9HRHdTUUFBWWl3Q0FCQlo3MDVVU1FBQU1pd0NBQkFqV0VpMFNRUUFTaS85UkJDUlhBQ0NJKy80aklrOENUd09KaXdDQUJDWEVjYUFTUUFBTWl3Q0FCTGZTc1dJU1FRQVVpLzlSQkNSWEFDQ0JHRnVJKy93alRDSlBBNGt5Q29zQWlQdWdJa3dpVHdPSmlnTUNLVElLaS80U1FBQU5nUml2TWdnV1VJditFa0VBQ292OWkvK0lBQ3RQQW9tTC94VVdKeEdrUVFBS0lvd0FJb3NBVEU4Q2lZdi9VUUFFaS8yTC9rOENpUHFBVEl3QVF2L21pZ0lDS1VjQ2kvOFZGaWNScEVFQUJ5SkpqQUdNQUlreUNvditFa0FBRFlFWXJ6SUlGbENML2hKQkFCZ3lDb3YvVVFBRUlpY0haVVJPQW9nQWh4SWlqQUdNQUltTC80aitvVVlDaS8rSS9wcElqQUpJaS8rSS9wR01BVVlDUUFBSU1ncUkrcnhBLzZpTEFrbUwvb2o4R1VoTWkvNkkvQktNQUVoQi81TWxyNHNCRm9zQUZrcUkrSjFMQTB4UVRnS0krSlJQQWt4UUZTVUpXeUVFR2trVWpBQ01BWW1LQVFHTC95RUZEa1NML3lFRkdvei9pUG8raS84SVNTRUZEa1NJK0tVT2lZb0NBU1N2aS80bkY2d25GNnhRU1JVa0NTUllpLytJOTVTSmlnQUJJa2NPTVJ0QkFWb3hHMEVCVGpZYUFJd0FNUnNqRFVFQlBUWWFBWXNBVEZDTURURWJnUUlOUVFFbk5ob0NpdzFNVUl3T01SdUJBdzFCQVJFMkdnT0xEa3hRakFFeEc0RUVEVUVBK3pZYUJJc0JURkNNQWpFYmdRVU5RUURsTmhvRml3Sk1VSXdETVJ1QkJnMUJBTTgyR2dhTEEweFFqQVF4RzRFSERVRUF1VFlhQjRzRVRGQ01CVEViSlExQkFLUTJHZ2lMQlV4UWpBWXhHNEVKRFVFQWpqWWFDWXNHVEZDTUJ6RWJnUW9OUVFCNE5ob0tpd2RNVUl3SU1SdUJDdzFCQUdJMkdndUxDRXhRakFreEc0RU1EVUVBVERZYURJc0pURkNNQ2pFYmdRME5RUUEyTmhvTml3cE1VSXdMTVJ1QkRnMUJBQ0EyR2c2TEMweFFqQXd4RzRFUERVRUFDallhRDRzTVRGQ01BSWtpcjBMLzlDS3ZRdi9lSXE5Qy84Z2lyMEwvc2lLdlF2K2NJcTlDLzRZaXIwTC9jQ0t2UXY5YUlxOUMvMFVpcjBML0x5S3ZRdjhaSXE5Qy93TWlyMEwrN1NLdlF2N1hJcTlDL3NFaXI0d0FRdjZ3SXE5Qy82WT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJSb2xlR3JhbnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsYXkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaW5jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdNZW1iZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik9wZXJhdGlvbkV4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdGlvbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVMYWJlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYWJlbCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZVJldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUFkbWluQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUd1YXJkaWFuQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJndWFyZGlhbiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUm9sZUdyYW50RGVsYXlDaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGF5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2luY2UiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRhcmdldEZ1bmN0aW9uUm9sZVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxlY3RvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGVJZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0QWRtaW5EZWxheVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsYXkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaW5jZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVGFyZ2V0Q2xvc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjbG9zZWQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik9wZXJhdGlvblNjaGVkdWxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NoZWR1bGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJPcGVyYXRpb25DYW5jZWxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb25JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
