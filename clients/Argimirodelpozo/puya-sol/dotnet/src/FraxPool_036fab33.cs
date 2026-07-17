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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.FraxPool_036fab33
{


    public class FraxPoolProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FraxPoolProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class MintingToggledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 101, 10, 116, 134 };
                public const string Signature = "MintingToggled(bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public bool Toggled { get; set; }

                public static MintingToggledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new MintingToggledEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vToggled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vToggled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueToggled = vToggled.ToValue();
                    if (valueToggled is bool vToggledValue) { ret.Toggled = vToggledValue; }
                    return ret;

                }

            }

            public class RedeemingToggledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 239, 236, 219, 150 };
                public const string Signature = "RedeemingToggled(bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public bool Toggled { get; set; }

                public static RedeemingToggledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RedeemingToggledEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vToggled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vToggled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueToggled = vToggled.ToValue();
                    if (valueToggled is bool vToggledValue) { ret.Toggled = vToggledValue; }
                    return ret;

                }

            }

            public class RecollateralizeToggledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 197, 234, 105, 57 };
                public const string Signature = "RecollateralizeToggled(bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public bool Toggled { get; set; }

                public static RecollateralizeToggledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RecollateralizeToggledEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vToggled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vToggled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueToggled = vToggled.ToValue();
                    if (valueToggled is bool vToggledValue) { ret.Toggled = vToggledValue; }
                    return ret;

                }

            }

            public class BuybackToggledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 23, 186, 109, 183 };
                public const string Signature = "BuybackToggled(bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public bool Toggled { get; set; }

                public static BuybackToggledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new BuybackToggledEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vToggled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vToggled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueToggled = vToggled.ToValue();
                    if (valueToggled is bool vToggledValue) { ret.Toggled = vToggledValue; }
                    return ret;

                }

            }

            public class CollateralPriceToggledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 21, 61, 96, 222 };
                public const string Signature = "CollateralPriceToggled(bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public bool Toggled { get; set; }

                public static CollateralPriceToggledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CollateralPriceToggledEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vToggled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vToggled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueToggled = vToggled.ToValue();
                    if (valueToggled is bool vToggledValue) { ret.Toggled = vToggledValue; }
                    return ret;

                }

            }

            public class PoolParametersSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 8, 95, 9, 181 };
                public const string Signature = "PoolParametersSet(uint256,uint256,uint256,uint256,uint256,uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewCeiling { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewBonusRate { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewRedemptionDelay { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewMintFee { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewRedeemFee { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewBuybackFee { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewRecollatFee { get; set; }

                public static PoolParametersSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PoolParametersSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewCeiling = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewCeiling.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewCeiling = vNewCeiling.ToValue();
                    if (valueNewCeiling is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewCeilingValue) { ret.NewCeiling = vNewCeilingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewBonusRate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewBonusRate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewBonusRate = vNewBonusRate.ToValue();
                    if (valueNewBonusRate is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewBonusRateValue) { ret.NewBonusRate = vNewBonusRateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewRedemptionDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewRedemptionDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewRedemptionDelay = vNewRedemptionDelay.ToValue();
                    if (valueNewRedemptionDelay is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewRedemptionDelayValue) { ret.NewRedemptionDelay = vNewRedemptionDelayValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewMintFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewMintFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewMintFee = vNewMintFee.ToValue();
                    if (valueNewMintFee is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewMintFeeValue) { ret.NewMintFee = vNewMintFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewRedeemFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewRedeemFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewRedeemFee = vNewRedeemFee.ToValue();
                    if (valueNewRedeemFee is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewRedeemFeeValue) { ret.NewRedeemFee = vNewRedeemFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewBuybackFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewBuybackFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewBuybackFee = vNewBuybackFee.ToValue();
                    if (valueNewBuybackFee is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewBuybackFeeValue) { ret.NewBuybackFee = vNewBuybackFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewRecollatFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewRecollatFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewRecollatFee = vNewRecollatFee.ToValue();
                    if (valueNewRecollatFee is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewRecollatFeeValue) { ret.NewRecollatFee = vNewRecollatFeeValue; }
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
        /// <param name="_frax_contract_address"> </param>
        /// <param name="_fxs_contract_address"> </param>
        /// <param name="_collateral_address"> </param>
        /// <param name="_creator_address"> </param>
        /// <param name="_timelock_address"> </param>
        /// <param name="_pool_ceiling"> </param>
        public async Task PostInit(Algorand.Address _frax_contract_address, Algorand.Address _fxs_contract_address, Algorand.Address _collateral_address, Algorand.Address _creator_address, Algorand.Address _timelock_address, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _pool_ceiling, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 54, 28, 195 };
            var _frax_contract_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _frax_contract_addressAbi.From(_frax_contract_address);
            var _fxs_contract_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _fxs_contract_addressAbi.From(_fxs_contract_address);
            var _collateral_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _collateral_addressAbi.From(_collateral_address);
            var _creator_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _creator_addressAbi.From(_creator_address);
            var _timelock_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _timelock_addressAbi.From(_timelock_address);

            var result = await base.CallApp(new List<object> { abiHandle, _frax_contract_addressAbi, _fxs_contract_addressAbi, _collateral_addressAbi, _creator_addressAbi, _timelock_addressAbi, _pool_ceiling }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Algorand.Address _frax_contract_address, Algorand.Address _fxs_contract_address, Algorand.Address _collateral_address, Algorand.Address _creator_address, Algorand.Address _timelock_address, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _pool_ceiling, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 54, 28, 195 };
            var _frax_contract_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _frax_contract_addressAbi.From(_frax_contract_address);
            var _fxs_contract_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _fxs_contract_addressAbi.From(_fxs_contract_address);
            var _collateral_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _collateral_addressAbi.From(_collateral_address);
            var _creator_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _creator_addressAbi.From(_creator_address);
            var _timelock_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _timelock_addressAbi.From(_timelock_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, _frax_contract_addressAbi, _fxs_contract_addressAbi, _collateral_addressAbi, _creator_addressAbi, _timelock_addressAbi, _pool_ceiling }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> CollatDollarBalance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 183, 237, 216 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> CollatDollarBalance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 183, 237, 216 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> AvailableExcessCollatDv(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 1, 26, 83 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> AvailableExcessCollatDv_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 1, 26, 83 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetCollateralPrice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 225, 43, 172 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetCollateralPrice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 225, 43, 172 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_collateral_weth_oracle_address"> </param>
        /// <param name="_weth_address"> </param>
        public async Task SetCollatEthOracle(Algorand.Address _collateral_weth_oracle_address, Algorand.Address _weth_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 45, 33, 221 };
            var _collateral_weth_oracle_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _collateral_weth_oracle_addressAbi.From(_collateral_weth_oracle_address);
            var _weth_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _weth_addressAbi.From(_weth_address);

            var result = await base.CallApp(new List<object> { abiHandle, _collateral_weth_oracle_addressAbi, _weth_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetCollatEthOracle_Transactions(Algorand.Address _collateral_weth_oracle_address, Algorand.Address _weth_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 45, 33, 221 };
            var _collateral_weth_oracle_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _collateral_weth_oracle_addressAbi.From(_collateral_weth_oracle_address);
            var _weth_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _weth_addressAbi.From(_weth_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, _collateral_weth_oracle_addressAbi, _weth_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="collateral_amount"> </param>
        /// <param name="FRAX_out_min"> </param>
        public async Task Mint1T1Frax(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 collateral_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 121, 52, 135 };

            var result = await base.CallApp(new List<object> { abiHandle, collateral_amount, FRAX_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Mint1T1Frax_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 collateral_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 121, 52, 135 };

            return await base.MakeTransactionList(new List<object> { abiHandle, collateral_amount, FRAX_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fxs_amount_d18"> </param>
        /// <param name="FRAX_out_min"> </param>
        public async Task MintAlgorithmicFrax(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 fxs_amount_d18, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 196, 26, 194 };

            var result = await base.CallApp(new List<object> { abiHandle, fxs_amount_d18, FRAX_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MintAlgorithmicFrax_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 fxs_amount_d18, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 196, 26, 194 };

            return await base.MakeTransactionList(new List<object> { abiHandle, fxs_amount_d18, FRAX_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="collateral_amount"> </param>
        /// <param name="fxs_amount"> </param>
        /// <param name="FRAX_out_min"> </param>
        public async Task MintFractionalFrax(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 collateral_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 fxs_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 240, 192, 253 };

            var result = await base.CallApp(new List<object> { abiHandle, collateral_amount, fxs_amount, FRAX_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MintFractionalFrax_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 collateral_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 fxs_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 240, 192, 253 };

            return await base.MakeTransactionList(new List<object> { abiHandle, collateral_amount, fxs_amount, FRAX_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="FRAX_amount"> </param>
        /// <param name="COLLATERAL_out_min"> </param>
        public async Task Redeem1T1Frax(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 COLLATERAL_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 205, 236, 37 };

            var result = await base.CallApp(new List<object> { abiHandle, FRAX_amount, COLLATERAL_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Redeem1T1Frax_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 COLLATERAL_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 205, 236, 37 };

            return await base.MakeTransactionList(new List<object> { abiHandle, FRAX_amount, COLLATERAL_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="FRAX_amount"> </param>
        /// <param name="FXS_out_min"> </param>
        /// <param name="COLLATERAL_out_min"> </param>
        public async Task RedeemFractionalFrax(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FXS_out_min, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 COLLATERAL_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 49, 174, 182 };

            var result = await base.CallApp(new List<object> { abiHandle, FRAX_amount, FXS_out_min, COLLATERAL_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RedeemFractionalFrax_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FXS_out_min, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 COLLATERAL_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 49, 174, 182 };

            return await base.MakeTransactionList(new List<object> { abiHandle, FRAX_amount, FXS_out_min, COLLATERAL_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="FRAX_amount"> </param>
        /// <param name="FXS_out_min"> </param>
        public async Task RedeemAlgorithmicFrax(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FXS_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 7, 39, 106 };

            var result = await base.CallApp(new List<object> { abiHandle, FRAX_amount, FXS_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RedeemAlgorithmicFrax_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FRAX_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FXS_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 7, 39, 106 };

            return await base.MakeTransactionList(new List<object> { abiHandle, FRAX_amount, FXS_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CollectRedemption(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 7, 154, 94 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CollectRedemption_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 7, 154, 94 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="collateral_amount"> </param>
        /// <param name="FXS_out_min"> </param>
        public async Task RecollateralizeFrax(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 collateral_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FXS_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 23, 107, 241 };

            var result = await base.CallApp(new List<object> { abiHandle, collateral_amount, FXS_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecollateralizeFrax_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 collateral_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FXS_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 23, 107, 241 };

            return await base.MakeTransactionList(new List<object> { abiHandle, collateral_amount, FXS_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="FXS_amount"> </param>
        /// <param name="COLLATERAL_out_min"> </param>
        public async Task BuyBackFxs(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FXS_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 COLLATERAL_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 237, 165, 88 };

            var result = await base.CallApp(new List<object> { abiHandle, FXS_amount, COLLATERAL_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BuyBackFxs_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FXS_amount, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 COLLATERAL_out_min, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 237, 165, 88 };

            return await base.MakeTransactionList(new List<object> { abiHandle, FXS_amount, COLLATERAL_out_min }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ToggleMinting(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 243, 176, 248 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ToggleMinting_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 243, 176, 248 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ToggleRedeeming(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 203, 211, 53 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ToggleRedeeming_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 203, 211, 53 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ToggleRecollateralize(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 139, 223, 201 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ToggleRecollateralize_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 139, 223, 201 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ToggleBuyBack(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 177, 165, 162 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ToggleBuyBack_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 177, 165, 162 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_new_price"> </param>
        public async Task ToggleCollateralPrice(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _new_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 82, 185, 164 };

            var result = await base.CallApp(new List<object> { abiHandle, _new_price }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ToggleCollateralPrice_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _new_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 82, 185, 164 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _new_price }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_ceiling"> </param>
        /// <param name="new_bonus_rate"> </param>
        /// <param name="new_redemption_delay"> </param>
        /// <param name="new_mint_fee"> </param>
        /// <param name="new_redeem_fee"> </param>
        /// <param name="new_buyback_fee"> </param>
        /// <param name="new_recollat_fee"> </param>
        public async Task SetPoolParameters(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_ceiling, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_bonus_rate, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_redemption_delay, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_mint_fee, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_redeem_fee, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_buyback_fee, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_recollat_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 170, 142, 221 };

            var result = await base.CallApp(new List<object> { abiHandle, new_ceiling, new_bonus_rate, new_redemption_delay, new_mint_fee, new_redeem_fee, new_buyback_fee, new_recollat_fee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPoolParameters_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_ceiling, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_bonus_rate, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_redemption_delay, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_mint_fee, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_redeem_fee, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_buyback_fee, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 new_recollat_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 170, 142, 221 };

            return await base.MakeTransactionList(new List<object> { abiHandle, new_ceiling, new_bonus_rate, new_redemption_delay, new_mint_fee, new_redeem_fee, new_buyback_fee, new_recollat_fee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///
        ///</summary>
        public async Task<Algorand.Address> CollatEthOracleAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 87, 36, 230 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> CollatEthOracleAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 87, 36, 230 };

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
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BuybackFee(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 78, 12, 150 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BuybackFee_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 78, 12, 150 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> RecollatFee(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 24, 221, 27 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> RecollatFee_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 24, 221, 27 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> UnclaimedPoolCollateral(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 50, 141, 171 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> UnclaimedPoolCollateral_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 50, 141, 171 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> UnclaimedPoolFxs(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 102, 125, 156 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> UnclaimedPoolFxs_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 102, 125, 156 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> PoolCeiling(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 239, 247, 48 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> PoolCeiling_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 239, 247, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> PausedPrice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 97, 54, 252 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> PausedPrice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 97, 54, 252 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BonusRate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 118, 175, 181 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BonusRate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 118, 175, 181 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> RedemptionDelay(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 254, 66, 178 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> RedemptionDelay_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 254, 66, 178 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> MintPaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 212, 244, 54 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MintPaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 212, 244, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> RedeemPaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 238, 145, 198 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RedeemPaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 238, 145, 198 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> RecollateralizePaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 28, 235, 96 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecollateralizePaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 28, 235, 96 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> BuyBackPaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 153, 64, 60 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyBackPaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 153, 64, 60 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> CollateralPricePaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 24, 217, 130 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CollateralPricePaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 24, 217, 130 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRnJheFBvb2wiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWRkcmVzc1NldCI6W3sibmFtZSI6Il9pbm5lciIsInR5cGUiOiJTZXQifV0sIlJvbGVEYXRhIjpbeyJuYW1lIjoibWVtYmVycyIsInR5cGUiOiJBZGRyZXNzU2V0In0seyJuYW1lIjoiYWRtaW5Sb2xlIiwidHlwZSI6InVpbnQ4WzMyXSJ9XSwiU2V0IjpbeyJuYW1lIjoiX3ZhbHVlcyIsInR5cGUiOiJ1aW50OFszMl1bXSJ9LHsibmFtZSI6Il9pbmRleGVzIiwidHlwZSI6ImJ5dGVbXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJfX3Bvc3RJbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfZnJheF9jb250cmFjdF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2Z4c19jb250cmFjdF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2NvbGxhdGVyYWxfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9jcmVhdG9yX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfdGltZWxvY2tfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9wb29sX2NlaWxpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlR3JhbnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbGxhdERvbGxhckJhbGFuY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhdmFpbGFibGVFeGNlc3NDb2xsYXREViIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldENvbGxhdGVyYWxQcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldENvbGxhdEVUSE9yYWNsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2NvbGxhdGVyYWxfd2V0aF9vcmFjbGVfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il93ZXRoX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWludDF0MUZSQVgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbGxhdGVyYWxfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiRlJBWF9vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnRBbGdvcml0aG1pY0ZSQVgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZ4c19hbW91bnRfZDE4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiRlJBWF9vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnRGcmFjdGlvbmFsRlJBWCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29sbGF0ZXJhbF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmeHNfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiRlJBWF9vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZGVlbTF0MUZSQVgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IkZSQVhfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiQ09MTEFURVJBTF9vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZGVlbUZyYWN0aW9uYWxGUkFYIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJGUkFYX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IkZYU19vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiQ09MTEFURVJBTF9vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZGVlbUFsZ29yaXRobWljRlJBWCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiRlJBWF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJGWFNfb3V0X21pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb2xsZWN0UmVkZW1wdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvbGxhdGVyYWxpemVGUkFYIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb2xsYXRlcmFsX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IkZYU19vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eUJhY2tGWFMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IkZYU19hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJDT0xMQVRFUkFMX291dF9taW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9nZ2xlTWludGluZyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTWludGluZ1RvZ2dsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZ2dsZWQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2dnbGVSZWRlZW1pbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlZGVlbWluZ1RvZ2dsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZ2dsZWQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2dnbGVSZWNvbGxhdGVyYWxpemUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlY29sbGF0ZXJhbGl6ZVRvZ2dsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZ2dsZWQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2dnbGVCdXlCYWNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJCdXliYWNrVG9nZ2xlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9nZ2xlZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvZ2dsZUNvbGxhdGVyYWxQcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX25ld19wcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29sbGF0ZXJhbFByaWNlVG9nZ2xlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9nZ2xlZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFBvb2xQYXJhbWV0ZXJzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfY2VpbGluZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19ib251c19yYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3JlZGVtcHRpb25fZGVsYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfbWludF9mZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcmVkZWVtX2ZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19idXliYWNrX2ZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19yZWNvbGxhdF9mZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlBvb2xQYXJhbWV0ZXJzU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfY2VpbGluZyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfYm9udXNfcmF0ZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcmVkZW1wdGlvbl9kZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfbWludF9mZWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3JlZGVlbV9mZWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2J1eWJhY2tfZmVlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19yZWNvbGxhdF9mZWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRUaW1lbG9jayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3RpbWVsb2NrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUaW1lbG9ja1NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfdGltZWxvY2siLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub21pbmF0ZU5ld093bmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfb3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyTm9taW5hdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWNjZXB0T3duZXJzaGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc1JvbGUiLCJkZXNjIjoiIEBkZXYgUmV0dXJucyBgdHJ1ZWAgaWYgYGFjY291bnRgIGhhcyBiZWVuIGdyYW50ZWQgYHJvbGVgLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZU1lbWJlckNvdW50IiwiZGVzYyI6IiBAZGV2IFJldHVybnMgdGhlIG51bWJlciBvZiBhY2NvdW50cyB0aGF0IGhhdmUgYHJvbGVgLiBDYW4gYmUgdXNlZFxuIHRvZ2V0aGVyIHdpdGgge2dldFJvbGVNZW1iZXJ9IHRvIGVudW1lcmF0ZSBhbGwgYmVhcmVycyBvZiBhIHJvbGUuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVNZW1iZXIiLCJkZXNjIjoiIEBkZXYgUmV0dXJucyBvbmUgb2YgdGhlIGFjY291bnRzIHRoYXQgaGF2ZSBgcm9sZWAuIGBpbmRleGAgbXVzdCBiZSBhXG4gdmFsdWUgYmV0d2VlbiAwIGFuZCB7Z2V0Um9sZU1lbWJlckNvdW50fSwgbm9uLWluY2x1c2l2ZS5cbiBSb2xlIGJlYXJlcnMgYXJlIG5vdCBzb3J0ZWQgaW4gYW55IHBhcnRpY3VsYXIgd2F5LCBhbmQgdGhlaXIgb3JkZXJpbmcgbWF5XG4gY2hhbmdlIGF0IGFueSBwb2ludC5cbiBXQVJOSU5HOiBXaGVuIHVzaW5nIHtnZXRSb2xlTWVtYmVyfSBhbmQge2dldFJvbGVNZW1iZXJDb3VudH0sIG1ha2Ugc3VyZVxuIHlvdSBwZXJmb3JtIGFsbCBxdWVyaWVzIG9uIHRoZSBzYW1lIGJsb2NrLiBTZWUgdGhlIGZvbGxvd2luZ1xuIGh0dHBzOi8vZm9ydW0ub3BlbnplcHBlbGluLmNvbS90L2l0ZXJhdGluZy1vdmVyLWVsZW1lbnRzLW9uLWVudW1lcmFibGVzZXQtaW4tb3BlbnplcHBlbGluLWNvbnRyYWN0cy8yMjk2W2ZvcnVtIHBvc3RdXG4gZm9yIG1vcmUgaW5mb3JtYXRpb24uIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZUFkbWluIiwiZGVzYyI6IiBAZGV2IFJldHVybnMgdGhlIGFkbWluIHJvbGUgdGhhdCBjb250cm9scyBgcm9sZWAuIFNlZSB7Z3JhbnRSb2xlfSBhbmRcbiB7cmV2b2tlUm9sZX0uXG4gVG8gY2hhbmdlIGEgcm9sZSdzIGFkbWluLCB1c2Uge19zZXRSb2xlQWRtaW59LiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ3JhbnRSb2xlIiwiZGVzYyI6IiBAZGV2IEdyYW50cyBgcm9sZWAgdG8gYGFjY291bnRgLlxuIElmIGBhY2NvdW50YCBoYWQgbm90IGJlZW4gYWxyZWFkeSBncmFudGVkIGByb2xlYCwgZW1pdHMgYSB7Um9sZUdyYW50ZWR9XG4gZXZlbnQuXG4gUmVxdWlyZW1lbnRzOlxuIC0gdGhlIGNhbGxlciBtdXN0IGhhdmUgYGByb2xlYGAncyBhZG1pbiByb2xlLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSb2xlR3JhbnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZVJvbGUiLCJkZXNjIjoiIEBkZXYgUmV2b2tlcyBgcm9sZWAgZnJvbSBgYWNjb3VudGAuXG4gSWYgYGFjY291bnRgIGhhZCBiZWVuIGdyYW50ZWQgYHJvbGVgLCBlbWl0cyBhIHtSb2xlUmV2b2tlZH0gZXZlbnQuXG4gUmVxdWlyZW1lbnRzOlxuIC0gdGhlIGNhbGxlciBtdXN0IGhhdmUgYGByb2xlYGAncyBhZG1pbiByb2xlLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSb2xlUmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbm91bmNlUm9sZSIsImRlc2MiOiIgQGRldiBSZXZva2VzIGByb2xlYCBmcm9tIHRoZSBjYWxsaW5nIGFjY291bnQuXG4gUm9sZXMgYXJlIG9mdGVuIG1hbmFnZWQgdmlhIHtncmFudFJvbGV9IGFuZCB7cmV2b2tlUm9sZX06IHRoaXMgZnVuY3Rpb24nc1xuIHB1cnBvc2UgaXMgdG8gcHJvdmlkZSBhIG1lY2hhbmlzbSBmb3IgYWNjb3VudHMgdG8gbG9zZSB0aGVpciBwcml2aWxlZ2VzXG4gaWYgdGhleSBhcmUgY29tcHJvbWlzZWQgKHN1Y2ggYXMgd2hlbiBhIHRydXN0ZWQgZGV2aWNlIGlzIG1pc3BsYWNlZCkuXG4gSWYgdGhlIGNhbGxpbmcgYWNjb3VudCBoYWQgYmVlbiBncmFudGVkIGByb2xlYCwgZW1pdHMgYSB7Um9sZVJldm9rZWR9XG4gZXZlbnQuXG4gUmVxdWlyZW1lbnRzOlxuIC0gdGhlIGNhbGxlciBtdXN0IGJlIGBhY2NvdW50YC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUm9sZVJldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb2xsYXRfZXRoX29yYWNsZV9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWludGluZ19mZWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlbXB0aW9uX2ZlZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eWJhY2tfZmVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb2xsYXRfZmVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5jbGFpbWVkUG9vbENvbGxhdGVyYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bmNsYWltZWRQb29sRlhTIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicG9vbF9jZWlsaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2VkUHJpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib251c19yYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVkZW1wdGlvbl9kZWxheSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnRQYXVzZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlZW1QYXVzZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvbGxhdGVyYWxpemVQYXVzZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlCYWNrUGF1c2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29sbGF0ZXJhbFByaWNlUGF1c2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub21pbmF0ZWRPd25lciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo2LCJieXRlcyI6MjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzY2MTBdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NDb250cm9sOiBjYW4gb25seSByZW5vdW5jZSByb2xlcyBmb3Igc2VsZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyODldLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NDb250cm9sOiBzZW5kZXIgbXVzdCBiZSBhbiBhZG1pbiB0byBncmFudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1ODRdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NDb250cm9sOiBzZW5kZXIgbXVzdCBiZSBhbiBhZG1pbiB0byByZXZva2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTY4XSwiZXJyb3JNZXNzYWdlIjoiQnV5YmFjayBpcyBwYXVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzU2LDQ3ODRdLCJlcnJvck1lc3NhZ2UiOiJDb2xsYXRlcmFsIHJhdGlvIG11c3QgYmUgMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5NzBdLCJlcnJvck1lc3NhZ2UiOiJDb2xsYXRlcmFsIHJhdGlvIG11c3QgYmUgPT0gMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMjVdLCJlcnJvck1lc3NhZ2UiOiJDb2xsYXRlcmFsIHJhdGlvIG11c3QgYmUgPj0gMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NzgsNDMwOF0sImVycm9yTWVzc2FnZSI6IkNvbGxhdGVyYWwgcmF0aW8gbmVlZHMgdG8gYmUgYmV0d2VlbiAuMDAwMDAxIGFuZCAuOTk5OTk5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzNF0sImVycm9yTWVzc2FnZSI6IkVudW1lcmFibGVTZXQ6IGluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDQxLDMyOTgsMzUwOV0sImVycm9yTWVzc2FnZSI6Ik1pbnRpbmcgaXMgcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk5Nl0sImVycm9yTWVzc2FnZSI6Ik11c3Qgd2FpdCBmb3IgcmVkZW1wdGlvbl9kZWxheSBibG9ja3MgYmVmb3JlIGNvbGxlY3RpbmcgcmVkZW1wdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MDRdLCJlcnJvck1lc3NhZ2UiOiJObyBleGNlc3MgY29sbGF0ZXJhbCB0byBidXkgYmFjayEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODA5XSwiZXJyb3JNZXNzYWdlIjoiTm90IGVub3VnaCBGWFMgaW5wdXR0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTAyLDQ1MDFdLCJlcnJvck1lc3NhZ2UiOiJOb3QgZW5vdWdoIGNvbGxhdGVyYWwgaW4gcG9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OTUsNjA4OSw2MjgxXSwiZXJyb3JNZXNzYWdlIjoiTm90IG93bmVyIG9yIHRpbWVsb2NrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjMyMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGNvbnRyYWN0IG93bmVyIG1heSBwZXJmb3JtIHRoaXMgYWN0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI3MV0sImVycm9yTWVzc2FnZSI6Ik93bmVyIGFkZHJlc3MgY2Fubm90IGJlIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjMyXSwiZXJyb3JNZXNzYWdlIjoiUG9vbCBjZWlsaW5nIHJlYWNoZWQsIG5vIG1vcmUgRlJBWCBjYW4gYmUgbWludGVkIHdpdGggdGhpcyBjb2xsYXRlcmFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE5Nl0sImVycm9yTWVzc2FnZSI6IlJlY29sbGF0ZXJhbGl6ZSBpcyBwYXVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTM2LDQyMzksNDcyN10sImVycm9yTWVzc2FnZSI6IlJlZGVlbWluZyBpcyBwYXVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDQ2XSwiZXJyb3JNZXNzYWdlIjoiU2FmZU1hdGg6IGFkZGl0aW9uIG92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEzN10sImVycm9yTWVzc2FnZSI6IlNhZmVNYXRoOiBtdWx0aXBsaWNhdGlvbiBvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMTYsMzM5MSwzODAzLDQxMDgsNDg4MCw1NDgyLDU3MzVdLCJlcnJvck1lc3NhZ2UiOiJTbGlwcGFnZSBsaW1pdCByZWFjaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxNl0sImVycm9yTWVzc2FnZSI6IlNsaXBwYWdlIGxpbWl0IHJlYWNoZWQgW0ZYU10iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTA3XSwiZXJyb3JNZXNzYWdlIjoiU2xpcHBhZ2UgbGltaXQgcmVhY2hlZCBbY29sbGF0ZXJhbF0iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTMxXSwiZXJyb3JNZXNzYWdlIjoiWW91IGFyZSB0cnlpbmcgdG8gYnV5IGJhY2sgbW9yZSB0aGFuIHRoZSBleGNlc3MhIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM0OV0sImVycm9yTWVzc2FnZSI6IllvdSBtdXN0IGJlIG5vbWluYXRlZCBiZWZvcmUgeW91IGNhbiBhY2NlcHQgb3duZXJzaGlwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM0OV0sImVycm9yTWVzc2FnZSI6Ilplcm8gYWRkcmVzcyBkZXRlY3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNzldLCJlcnJvck1lc3NhZ2UiOiJbUG9vbCdzIENsb3NlZF06IENlaWxpbmcgcmVhY2hlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNjBdLCJlcnJvck1lc3NhZ2UiOiJfX3Bvc3RJbml0IGFscmVhZHkgY2FsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA5OSwyMTg1XSwiZXJyb3JNZXNzYWdlIjoiYXNzZXJ0aW9uIGZhaWxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NTUsMzA5NywzMjQ5LDMzMDQsMzUxNSwzODgzLDM5NDIsNDE3OSw0MjQ1LDQ2MzEsNDczMyw0OTAwLDUyNTEsNTU3NCw2OTMzLDcwODVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBGUkFYIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0MTEsMzgyOCw0Njc0LDQ5NDMsNTA1MCw1NTE1LDU3NTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBGWFMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ1NCw2NzgzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgYm9udXNfcmF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTY2LDU5MTMsNjg3Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGJ1eUJhY2tQYXVzZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY2Miw2NjY5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgYnV5YmFja19mZWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc2MCw3MTkwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgY29sbGF0RXRoT3JhY2xlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2MjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBjb2xsYXRfZXRoX29yYWNsZV9hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MTUsNTk1Nyw1OTcwLDY4ODksNzA2Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGNvbGxhdGVyYWxQcmljZVBhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDAxLDI1MjgsMjgxNSwzMTMzLDMyMjEsMzU4NiwzODU3LDQwNjEsNDQ2MCw1MDY3LDU0ODcsNTc4M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIGNvbGxhdGVyYWxfdG9rZW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAzOSwzMjk2LDM1MDcsNTgwNSw2ODIxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbWludFBhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTk0LDMzNjksMzc4MSw2NjMxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbWludGluZ19mZWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU2NCwyNjk2LDI4NTEsMzA0OSwzNjQ3LDM5NzgsNDM4NCw1MjA0LDU0MDAsNTY4Niw3MTI2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbWlzc2luZ19kZWNpbWFscyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzQ0LDY5MTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBub21pbmF0ZWRPd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTg5LDYwODMsNjI3NSw2MzE5LDYzNTQsNjkwNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIG93bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MjYsNjc2NCw3MDc2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcGF1c2VkUHJpY2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE3NywzNjMwLDY3NDVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBwb29sX2NlaWxpbmcgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ2Miw2Njg4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcmVjb2xsYXRfZmVlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxOTQsNTg3Nyw2ODU1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcmVjb2xsYXRlcmFsaXplUGF1c2VkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5MzQsNDIzNyw0NzI1LDU4NDEsNjgzOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHJlZGVlbVBhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTg4LDY4MDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayByZWRlbXB0aW9uX2RlbGF5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMzcsNDMyNCw0NzkyLDY2NTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayByZWRlbXB0aW9uX2ZlZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDUyLDI0NjMsMjQ3NCwyNDg1LDI0OTYsMjk3OCw2MDcyLDYyNjRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB0aW1lbG9ja19hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MTMsMjkwMCwzMTY0LDM2MTcsNDA5Miw0NDkxLDUxMDksNjcwN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHVuY2xhaW1lZFBvb2xDb2xsYXRlcmFsIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1ODcsNDg1MSw1MTU2LDY3MjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB1bmNsYWltZWRQb29sRlhTIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NDEsNzE3MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHdldGhfYWRkcmVzcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDk2LDE1MTQsMTY1MF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIwOCwyMjE4LDIyMjgsMjIzNiwyMjQ2LDI5NjMsMjk3MSw2MjU3LDYzMTIsNjM4NCw2MzkyLDY0MTUsNjQ1OSw2NTA1LDY1MzMsNjU0MSw2NTU0LDY1NjIsNjU5Nyw2NjA1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNTYsMzAyNiwzMDM0LDMyODMsMzI5MSwzNDg1LDM0OTQsMzUwMiwzOTIxLDM5MjksNDIxNiw0MjI0LDQyMzIsNDcxMiw0NzIwLDUxODEsNTE4OSw1NTUxLDU1NjEsNTk0NCw2MDExLDYwMjAsNjAyOSw2MDM4LDYwNDcsNjA1Niw2MDY1LDY0NjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM4N10sImVycm9yTWVzc2FnZSI6Im1heCBhcnJheSBsZW5ndGggZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjQwLDI5MjksMjk0NiwzNzAwLDM3MTMsMzcyMiwzNzMyLDM3NDcsNTYwMiw1NjIwLDU2MzEsNTY0MCw2MTUwLDYxNjIsNjE3Miw2MTgyLDYxOTIsNjIwMiw2MjEyLDY0NDIsNjYzNiw2NjU1LDY2NzQsNjY5Myw2NzEyLDY3MzEsNjc1MCw2NzY5LDY3ODgsNjgwN10sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREFnTXpJZ01TQTJJREV3TURBd01EQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ2dNSGd3TVNBd2VERTFNV1kzWXpjMUlEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQ0FpUmxKQldDSWdJbU52Ykd4aGRHVnlZV3hmZEc5clpXNGlJQ0p0YVhOemFXNW5YMlJsWTJsdFlXeHpJaUFpZFc1amJHRnBiV1ZrVUc5dmJFTnZiR3hoZEdWeVlXd2lJQ0owYVcxbGJHOWphMTloWkdSeVpYTnpJaUF3ZURCaElEQjRNRElnTUhnd01DQXdlREF3TWpJd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNakF3TURRd01EQTJNREF3TURBd01EQWdJbTkzYm1WeUlpQWlSbGhUSWlBaWRXNWpiR0ZwYldWa1VHOXZiRVpZVXlJZ01IaGxZek0yTkdVek5DQWlYM0p2YkdWeklpQWliV2x1ZEZCaGRYTmxaQ0lnSW5KbFpHVmxiVkJoZFhObFpDSWdJbU52Ykd4aGRHVnlZV3hRY21salpWQmhkWE5sWkNJZ01IZ3daalF5TkRBZ0luSmxaR1ZsYlVOdmJHeGhkR1Z5WVd4Q1lXeGhibU5sY3lJZ0luSmxaR1ZsYlVaWVUwSmhiR0Z1WTJWeklpQWliV2x1ZEdsdVoxOW1aV1VpSUNKeVpXUmxiWEIwYVc5dVgyWmxaU0lnSW5CdmIyeGZZMlZwYkdsdVp5SWdJbkJoZFhObFpGQnlhV05sSWlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQ0F3ZURnelltRmtOMk5qSURCNE1UTXpNamRsTWpnZ01IZzJZelJpTW1KalppQXdlR00zWXpFd1ptWmxJQ0p1YjIxcGJtRjBaV1JQZDI1bGNpSWdJbkpsWTI5c2JHRjBaWEpoYkdsNlpWQmhkWE5sWkNJZ0ltSjFlVUpoWTJ0UVlYVnpaV1FpSUNKamIyeHNZWFJGZEdoUGNtRmpiR1VpSUNKM1pYUm9YMkZrWkhKbGMzTWlJQ0ppZFhsaVlXTnJYMlpsWlNJZ0luSmxZMjlzYkdGMFgyWmxaU0lnSW1KdmJuVnpYM0poZEdVaUlDSnlaV1JsYlhCMGFXOXVYMlJsYkdGNUlpQWlYMmx1WkdWNFpYTWlJQ0pzWVhOMFVtVmtaV1Z0WldRaUlDSmpiMnhzWVhSZlpYUm9YMjl5WVdOc1pWOWhaR1J5WlhOeklpQWlYMTlqZEc5eVgzQmxibVJwYm1jaUlDSmpiMnhzWVhSbGNtRnNYMkZrWkhKbGMzTWlJQ0ptY21GNFgyTnZiblJ5WVdOMFgyRmtaSEpsYzNNaUlDSm1lSE5mWTI5dWRISmhZM1JmWVdSa2NtVnpjeUlnTUhoak5qVTFNekl4T0RWbFpEY3dZakpsT1RrNU5ETXpaVEpsT1daaFl6RXlOR1V3T0ROaFkySXhNMlZqTVRnellUUmxNRFU1TkRSa1lUQTNPVEl6TXpkaUlEQjRZVGcwWVRVek9EbGhaRFF4WmpsaFlXSXdPRE14WWpBeFpUVXpPRFJqWVdVM05tVTNZVGRtWkRBNU1UTXhZekl3Tm1abU56a3lOMk15TURGak16ZzFOeUF3ZURneE1UaGxaV0kxTWpNeFlUVm1aVFF3TURoaE5UVmlOakk0TmpCbU5tRXdaR0kwWmpaak0yRmpNRFJtT0RFME1Ua3lOMkU1WWpObVpXUmtPRFprTW1ZZ01IZ3hNRE5rWVRjNVptWXpOelUxWm1ZM1lURTNZVFUxTjJReU9HSTNNMlF6TjJOaU5HUmxNR0l6WXpOall6QXlabUUyWXpRNFpHWXdaak0xTURjeFptSm1JREI0WW1JeVl6WTRZamhrWXpWaVkyTmtaREkxTXpZek1EY3dPREJoTnpnMk5XRTNaVEV6TTJKbU5UUmxNekZrTkdRME5qTmlNV0kzTkRsaU5HSmpaakkyWkNBd2VHRmpOVGRoWkdFeUlEQjRNbVF6TVdaallqVWdNSGczT1daaFlqUTJOU0F3ZURsa1l6UTVNemc1SURCNE1EQXlNZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZbmwwWldOZk15QXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBek15QXZMeUFpYm05dGFXNWhkR1ZrVDNkdVpYSWlDaUFnSUNCaWVYUmxZMTh6SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiR3hoZEdWeVlXeGZkRzlyWlc0aUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEUTJJQzh2SUNKamIyeHNZWFJsY21Gc1gyRmtaSEpsYzNNaUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEUTNJQzh2SUNKbWNtRjRYMk52Ym5SeVlXTjBYMkZrWkhKbGMzTWlDaUFnSUNCaWVYUmxZMTh6SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFE0SUM4dklDSm1lSE5mWTI5dWRISmhZM1JmWVdSa2NtVnpjeUlLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkR2x0Wld4dlkydGZZV1JrY21WemN5SUtJQ0FnSUdKNWRHVmpYek1nTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0lrWllVeUlLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlSbEpCV0NJS0lDQWdJR0o1ZEdWalh6TWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ016WWdMeThnSW1OdmJHeGhkRVYwYUU5eVlXTnNaU0lLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTkRRZ0x5OGdJbU52Ykd4aGRGOWxkR2hmYjNKaFkyeGxYMkZrWkhKbGMzTWlDaUFnSUNCaWVYUmxZMTh6SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRE0zSUM4dklDSjNaWFJvWDJGa1pISmxjM01pQ2lBZ0lDQmllWFJsWTE4eklDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURJMElDOHZJQ0p0YVc1MGFXNW5YMlpsWlNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXlOU0F2THlBaWNtVmtaVzF3ZEdsdmJsOW1aV1VpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ016Z2dMeThnSW1KMWVXSmhZMnRmWm1WbElnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRE01SUM4dklDSnlaV052Ykd4aGRGOW1aV1VpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZFc1amJHRnBiV1ZrVUc5dmJFTnZiR3hoZEdWeVlXd2lDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJblZ1WTJ4aGFXMWxaRkJ2YjJ4R1dGTWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTmlBdkx5QWliV2x6YzJsdVoxOWtaV05wYldGc2N5SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNallnTHk4Z0luQnZiMnhmWTJWcGJHbHVaeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01qY2dMeThnSW5CaGRYTmxaRkJ5YVdObElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhCMWMyaHBiblFnTnpVd01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOREFnTHk4Z0ltSnZiblZ6WDNKaGRHVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFF4SUM4dklDSnlaV1JsYlhCMGFXOXVYMlJsYkdGNUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREU0SUM4dklDSnRhVzUwVUdGMWMyVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QWljbVZrWldWdFVHRjFjMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBek5DQXZMeUFpY21WamIyeHNZWFJsY21Gc2FYcGxVR0YxYzJWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXpOU0F2THlBaVluVjVRbUZqYTFCaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdJbU52Ykd4aGRHVnlZV3hRY21salpWQmhkWE5sWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ05EVWdMeThnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURabE16WXhZMk16SURCNFpqRmlOMlZrWkRnZ01IaGxZakF4TVdFMU15QXdlRGM0WlRFeVltRmpJREI0TnpVeVpESXhaR1FnTUhneVpqYzVNelE0TnlBd2VEaGlZelF4WVdNeUlEQjRZbUptTUdNd1ptUWdNSGhoTTJOa1pXTXlOU0F3ZURkaE16RmhaV0kySURCNE0ySXdOekkzTm1FZ01IZ3dOakEzT1dFMVpTQXdlREJsTVRjMlltWXhJREI0TkRWbFpHRTFOVGdnTUhneVkyWXpZakJtT0NBd2VHWmxZMkprTXpNMUlEQjRNelk0WW1SbVl6a2dNSGcwT1dJeFlUVmhNaUF3ZUdJNU5USmlPV0UwSURCNE9UTmhZVGhsWkdRZ01IaGhZV1ppWWpBNFlpQXdlRE5oWkROaE1UQXpJREI0WkRVeU1XUTJNRFFnTUhnMU9HRTVNVEF5T0NBd2VEQmxNV00wWW1Fd0lEQjRNalExWkRkbU5Ua2dNSGcyTnpJNE9XTTNaQ0F3ZURFME1XTTBaakU0SURCNE9ETXdaRFl3WWpFZ01IZzVaVFE1T0RKbFpDQXdlRFU1TlRjeU5HVTJJREI0TmpOaE1HUXpZVFVnTUhoaE9UQTFPRGhrT1NBd2VERmlOR1V3WXprMklEQjRZV1l4T0dSa01XSWdNSGcxTWpNeU9HUmhZaUF3ZUdKbU5qWTNaRGxqSURCNFpEZGxabVkzTXpBZ01IZ3hPRFl4TXpabVl5QXdlRGsyTnpaaFptSTFJREI0TWpCbVpUUXlZaklnTUhoaU4yUTBaalF6TmlBd2VEY3haV1U1TVdNMklEQjRNbUl4WTJWaU5qQWdNSGd6WXprNU5EQXpZeUF3ZURCbE1UaGtPVGd5SURCNFlqRmlZbUl3WVRnZ01IZzNaREptTXpVMVl5QXZMeUJ0WlhSb2IyUWdJbDlmY0c5emRFbHVhWFFvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlNncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVlYWmhhV3hoWW14bFJYaGpaWE56UTI5c2JHRjBSRllvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1kbGRFTnZiR3hoZEdWeVlXeFFjbWxqWlNncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWMyVjBRMjlzYkdGMFJWUklUM0poWTJ4bEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p0YVc1ME1YUXhSbEpCV0NoMWFXNTBNalUyTEhWcGJuUXlOVFlwZG05cFpDSXNJRzFsZEdodlpDQWliV2x1ZEVGc1oyOXlhWFJvYldsalJsSkJXQ2gxYVc1ME1qVTJMSFZwYm5ReU5UWXBkbTlwWkNJc0lHMWxkR2h2WkNBaWJXbHVkRVp5WVdOMGFXOXVZV3hHVWtGWUtIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsWkdWbGJURjBNVVpTUVZnb2RXbHVkREkxTml4MWFXNTBNalUyS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsWkdWbGJVWnlZV04wYVc5dVlXeEdVa0ZZS0hWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxaR1ZsYlVGc1oyOXlhWFJvYldsalJsSkJXQ2gxYVc1ME1qVTJMSFZwYm5ReU5UWXBkbTlwWkNJc0lHMWxkR2h2WkNBaVkyOXNiR1ZqZEZKbFpHVnRjSFJwYjI0b0tYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFkyOXNiR0YwWlhKaGJHbDZaVVpTUVZnb2RXbHVkREkxTml4MWFXNTBNalUyS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUoxZVVKaFkydEdXRk1vZFdsdWRESTFOaXgxYVc1ME1qVTJLWFp2YVdRaUxDQnRaWFJvYjJRZ0luUnZaMmRzWlUxcGJuUnBibWNvS1hadmFXUWlMQ0J0WlhSb2IyUWdJblJ2WjJkc1pWSmxaR1ZsYldsdVp5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHOW5aMnhsVW1WamIyeHNZWFJsY21Gc2FYcGxLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBiMmRuYkdWQ2RYbENZV05yS0NsMmIybGtJaXdnYldWMGFHOWtJQ0owYjJkbmJHVkRiMnhzWVhSbGNtRnNVSEpwWTJVb2RXbHVkREkxTmlsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSUWIyOXNVR0Z5WVcxbGRHVnljeWgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEZScGJXVnNiMk5yS0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlibTl0YVc1aGRHVk9aWGRQZDI1bGNpaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1GalkyVndkRTkzYm1WeWMyaHBjQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlhR0Z6VW05c1pTaGllWFJsV3pNeVhTeGhaR1J5WlhOektXSnZiMndpTENCdFpYUm9iMlFnSW1kbGRGSnZiR1ZOWlcxaVpYSkRiM1Z1ZENoaWVYUmxXek15WFNsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKblpYUlNiMnhsVFdWdFltVnlLR0o1ZEdWYk16SmRMSFZwYm5ReU5UWXBZV1JrY21WemN5SXNJRzFsZEdodlpDQWlaMlYwVW05c1pVRmtiV2x1S0dKNWRHVmJNekpkS1dKNWRHVmJNekpkSWl3Z2JXVjBhRzlrSUNKbmNtRnVkRkp2YkdVb1lubDBaVnN6TWwwc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhadmEyVlNiMnhsS0dKNWRHVmJNekpkTEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljbVZ1YjNWdVkyVlNiMnhsS0dKNWRHVmJNekpkTEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlZMjlzYkdGMFgyVjBhRjl2Y21GamJHVmZZV1JrY21WemN5Z3BZV1JrY21WemN5SXNJRzFsZEdodlpDQWliV2x1ZEdsdVoxOW1aV1VvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW5KbFpHVnRjSFJwYjI1ZlptVmxLQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0ppZFhsaVlXTnJYMlpsWlNncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWNtVmpiMnhzWVhSZlptVmxLQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0oxYm1Oc1lXbHRaV1JRYjI5c1EyOXNiR0YwWlhKaGJDZ3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlkVzVqYkdGcGJXVmtVRzl2YkVaWVV5Z3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWljRzl2YkY5alpXbHNhVzVuS0NsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKd1lYVnpaV1JRY21salpTZ3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlZbTl1ZFhOZmNtRjBaU2dwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpY21Wa1pXMXdkR2x2Ymw5a1pXeGhlU2dwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpYldsdWRGQmhkWE5sWkNncFltOXZiQ0lzSUcxbGRHaHZaQ0FpY21Wa1pXVnRVR0YxYzJWa0tDbGliMjlzSWl3Z2JXVjBhRzlrSUNKeVpXTnZiR3hoZEdWeVlXeHBlbVZRWVhWelpXUW9LV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltSjFlVUpoWTJ0UVlYVnpaV1FvS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbU52Ykd4aGRHVnlZV3hRY21salpWQmhkWE5sWkNncFltOXZiQ0lzSUcxbGRHaHZaQ0FpYjNkdVpYSW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbTV2YldsdVlYUmxaRTkzYm1WeUtDbGhaR1J5WlhOeklnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dYMTl3YjNOMFNXNXBkQ0JqYjJ4c1lYUkViMnhzWVhKQ1lXeGhibU5sSUdGMllXbHNZV0pzWlVWNFkyVnpjME52Ykd4aGRFUldJR2RsZEVOdmJHeGhkR1Z5WVd4UWNtbGpaU0J6WlhSRGIyeHNZWFJGVkVoUGNtRmpiR1VnYldsdWRERjBNVVpTUVZnZ2JXbHVkRUZzWjI5eWFYUm9iV2xqUmxKQldDQnRhVzUwUm5KaFkzUnBiMjVoYkVaU1FWZ2djbVZrWldWdE1YUXhSbEpCV0NCeVpXUmxaVzFHY21GamRHbHZibUZzUmxKQldDQnlaV1JsWlcxQmJHZHZjbWwwYUcxcFkwWlNRVmdnWTI5c2JHVmpkRkpsWkdWdGNIUnBiMjRnY21WamIyeHNZWFJsY21Gc2FYcGxSbEpCV0NCaWRYbENZV05yUmxoVElIUnZaMmRzWlUxcGJuUnBibWNnZEc5bloyeGxVbVZrWldWdGFXNW5JSFJ2WjJkc1pWSmxZMjlzYkdGMFpYSmhiR2w2WlNCMGIyZG5iR1ZDZFhsQ1lXTnJJSFJ2WjJkc1pVTnZiR3hoZEdWeVlXeFFjbWxqWlNCelpYUlFiMjlzVUdGeVlXMWxkR1Z5Y3lCelpYUlVhVzFsYkc5amF5QnViMjFwYm1GMFpVNWxkMDkzYm1WeUlHRmpZMlZ3ZEU5M2JtVnljMmhwY0NCb1lYTlNiMnhsSUdkbGRGSnZiR1ZOWlcxaVpYSkRiM1Z1ZENCblpYUlNiMnhsVFdWdFltVnlJR2RsZEZKdmJHVkJaRzFwYmlCbmNtRnVkRkp2YkdVZ2NtVjJiMnRsVW05c1pTQnlaVzV2ZFc1alpWSnZiR1VnWTI5c2JHRjBYMlYwYUY5dmNtRmpiR1ZmWVdSa2NtVnpjeUJ0YVc1MGFXNW5YMlpsWlNCeVpXUmxiWEIwYVc5dVgyWmxaU0JpZFhsaVlXTnJYMlpsWlNCeVpXTnZiR3hoZEY5bVpXVWdkVzVqYkdGcGJXVmtVRzl2YkVOdmJHeGhkR1Z5WVd3Z2RXNWpiR0ZwYldWa1VHOXZiRVpZVXlCd2IyOXNYMk5sYVd4cGJtY2djR0YxYzJWa1VISnBZMlVnWW05dWRYTmZjbUYwWlNCeVpXUmxiWEIwYVc5dVgyUmxiR0Y1SUcxcGJuUlFZWFZ6WldRZ2NtVmtaV1Z0VUdGMWMyVmtJSEpsWTI5c2JHRjBaWEpoYkdsNlpWQmhkWE5sWkNCaWRYbENZV05yVUdGMWMyVmtJR052Ykd4aGRHVnlZV3hRY21salpWQmhkWE5sWkNCdmQyNWxjaUJ1YjIxcGJtRjBaV1JQZDI1bGNnb2dJQ0FnWlhKeUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJXNTFiV1Z5WVdKc1pWTmxkQzVmWVdSa0tITmxkRG9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZMExDQmllWFJsY3pvS1JXNTFiV1Z5WVdKc1pWTmxkQzVmWVdSa09nb2dJQ0FnY0hKdmRHOGdNaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBMbDlqYjI1MFlXbHVjd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNZ29nSUNBZ1ltNTZJRVZ1ZFcxbGNtRmliR1ZUWlhRdVgyRmtaRjlsYkhObFgySnZaSGxBTkFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZENBdkx5QnZiaUJsY25KdmNqb2diV0Y0SUdGeWNtRjVJR3hsYm1kMGFDQmxlR05sWldSbFpBb2dJQ0FnY0c5d0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURReUlDOHZJQ0pmYVc1a1pYaGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEpsZEhOMVlnb0tSVzUxYldWeVlXSnNaVk5sZEM1ZllXUmtYMlZzYzJWZlltOWtlVUEwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRDNWZjbVZ0YjNabEtITmxkRG9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZMExDQmllWFJsY3pvS1JXNTFiV1Z5WVdKc1pWTmxkQzVmY21WdGIzWmxPZ29nSUNBZ2NISnZkRzhnTWlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdORElnTHk4Z0lsOXBibVJsZUdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUVWdWRXMWxjbUZpYkdWVFpYUXVYM0psYlc5MlpWOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdKNWRHVmpJREk0SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV01nTWpnZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUM4S0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklESTRJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTWdNamdnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjbVZ3YkdGalpUTWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlLd29nSUNBZ2MzZGhjQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBME1pQXZMeUFpWDJsdVpHVjRaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J5WlhSemRXSUtDa1Z1ZFcxbGNtRmliR1ZUWlhRdVgzSmxiVzkyWlY5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwTGw5amIyNTBZV2x1Y3loelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE02Q2tWdWRXMWxjbUZpYkdWVFpYUXVYMk52Ym5SaGFXNXpPZ29nSUNBZ2NISnZkRzhnTWlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdORElnTHk4Z0lsOXBibVJsZUdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwTGw5c1pXNW5kR2dvYzJWME9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6T2dwRmJuVnRaWEpoWW14bFUyVjBMbDlzWlc1bmRHZzZDaUFnSUNCd2NtOTBieUF4SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXZDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyRjBLSE5sZERvZ1lubDBaWE1zSUdsdVpHVjRPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWek9ncEZiblZ0WlhKaFlteGxVMlYwTGw5aGREb0tJQ0FnSUhCeWIzUnZJRElnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0x3b2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpUGdvZ0lDQWdZWE56WlhKMElDOHZJRVZ1ZFcxbGNtRmliR1ZUWlhRNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBMbUZrWkNneUtWOHdLSE5sZERvZ1lubDBaWE1zSUhaaGJIVmxPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBMQ0JpZVhSbGN5d2dZbmwwWlhNNkNrVnVkVzFsY21GaWJHVlRaWFF1WVdSa09nb2dJQ0FnY0hKdmRHOGdNaUF6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRVZ1ZFcxbGNtRmliR1ZUWlhRdVgyRmtaQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdSMWNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSVzUxYldWeVlXSnNaVk5sZEM1eVpXMXZkbVVvTWlsZk1DaHpaWFE2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dZbmwwWlhNc0lHSjVkR1Z6T2dwRmJuVnRaWEpoWW14bFUyVjBMbkpsYlc5MlpUb0tJQ0FnSUhCeWIzUnZJRElnTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJGYm5WdFpYSmhZbXhsVTJWMExsOXlaVzF2ZG1VS0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmtkWEFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtWdWRXMWxjbUZpYkdWVFpYUXVZMjl1ZEdGcGJuTW9NaWxmTUNoelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE02Q2tWdWRXMWxjbUZpYkdWVFpYUXVZMjl1ZEdGcGJuTTZDaUFnSUNCd2NtOTBieUF5SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnUlc1MWJXVnlZV0pzWlZObGRDNWZZMjl1ZEdGcGJuTUtJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwTG14bGJtZDBhQ2d4S1Y4d0tITmxkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpMQ0JpZVhSbGN6b0tSVzUxYldWeVlXSnNaVk5sZEM1c1pXNW5kR2c2Q2lBZ0lDQndjbTkwYnlBeElESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpZV3hzYzNWaUlFVnVkVzFsY21GaWJHVlRaWFF1WDJ4bGJtZDBhQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhRdVlYUW9NaWxmTUNoelpYUTZJR0o1ZEdWekxDQnBibVJsZURvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6TENCaWVYUmxjem9LUlc1MWJXVnlZV0pzWlZObGRDNWhkRG9LSUNBZ0lIQnliM1J2SURJZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBMbDloZEFvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzVEdsaWNtRnllUzVqWVd4alRXbHVkREYwTVVaU1FWZ29ZMjlzWDNCeWFXTmxPaUJpZVhSbGN5d2dZMjlzYkdGMFpYSmhiRjloYlc5MWJuUmZaREU0T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2taeVlYaFFiMjlzVEdsaWNtRnllUzVqWVd4alRXbHVkREYwTVVaU1FWZzZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtMTFiQW9nSUNBZ2FXNTBZeUEwSUM4dklERXdNREF3TURBS0lDQWdJR2wwYjJJS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VaR2wyQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkV4cFluSmhjbmt1WTJGc1kwMXBiblJCYkdkdmNtbDBhRzFwWTBaU1FWZ29abmh6WDNCeWFXTmxYM1Z6WkRvZ1lubDBaWE1zSUdaNGMxOWhiVzkxYm5SZlpERTRPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDa1p5WVhoUWIyOXNUR2xpY21GeWVTNWpZV3hqVFdsdWRFRnNaMjl5YVhSb2JXbGpSbEpCV0RvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YlhWc0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNUR2xpY21GeWVTNWpZV3hqVFdsdWRFWnlZV04wYVc5dVlXeEdVa0ZZS0hCaGNtRnRjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpMQ0JpZVhSbGN5d2dZbmwwWlhNNkNrWnlZWGhRYjI5c1RHbGljbUZ5ZVM1allXeGpUV2x1ZEVaeVlXTjBhVzl1WVd4R1VrRllPZ29nSUNBZ2NISnZkRzhnTVNBekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXRkV3dLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVrYVhZS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3ViWFZzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01USTRJRE15Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtUnBkZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWMzVmlDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXRkV3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1ScGRnb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1aFpHUUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyeE1hV0p5WVhKNUxtTmhiR05TWldSbFpXMHhkREZHVWtGWUtHTnZiRjl3Y21salpWOTFjMlE2SUdKNWRHVnpMQ0JHVWtGWVgyRnRiM1Z1ZERvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwR2NtRjRVRzl2YkV4cFluSmhjbmt1WTJGc1kxSmxaR1ZsYlRGME1VWlNRVmc2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWJYVnNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WkdsMkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJFeHBZbkpoY25rdVkyRnNZMEoxZVVKaFkydEdXRk1vY0dGeVlXMXpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWek9ncEdjbUY0VUc5dmJFeHBZbkpoY25rdVkyRnNZMEoxZVVKaFkydEdXRk02Q2lBZ0lDQndjbTkwYnlBeElESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0krQ2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnWlhoalpYTnpJR052Ykd4aGRHVnlZV3dnZEc4Z1luVjVJR0poWTJzaENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXRkV3dLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVrYVhZS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaVBEMEtJQ0FnSUdGemMyVnlkQ0F2THlCWmIzVWdZWEpsSUhSeWVXbHVaeUIwYnlCaWRYa2dZbUZqYXlCdGIzSmxJSFJvWVc0Z2RHaGxJR1Y0WTJWemN5RUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YlhWc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VaR2wyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzVEdsaWNtRnllUzVqWVd4alVtVmpiMnhzWVhSbGNtRnNhWHBsUmxKQldFbHVibVZ5S0dOdmJHeGhkR1Z5WVd4ZllXMXZkVzUwT2lCaWVYUmxjeXdnWTI5c1gzQnlhV05sT2lCaWVYUmxjeXdnWjJ4dlltRnNYMk52Ykd4aGRGOTJZV3gxWlRvZ1lubDBaWE1zSUdaeVlYaGZkRzkwWVd4ZmMzVndjR3g1T2lCaWVYUmxjeXdnWjJ4dlltRnNYMk52Ykd4aGRHVnlZV3hmY21GMGFXODZJR0o1ZEdWektTQXRQaUJpZVhSbGN5d2dZbmwwWlhNNkNrWnlZWGhRYjI5c1RHbGljbUZ5ZVM1allXeGpVbVZqYjJ4c1lYUmxjbUZzYVhwbFJsSkJXRWx1Ym1WeU9nb2dJQ0FnY0hKdmRHOGdOU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1dGRXd0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WkdsMkNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1dGRXd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVrYVhZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtMTFiQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3ViWFZzQ2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xuTjFZZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lqdzlDaUFnSUNCaWVpQkdjbUY0VUc5dmJFeHBZbkpoY25rdVkyRnNZMUpsWTI5c2JHRjBaWEpoYkdsNlpVWlNRVmhKYm01bGNsOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtDa1p5WVhoUWIyOXNUR2xpY21GeWVTNWpZV3hqVW1WamIyeHNZWFJsY21Gc2FYcGxSbEpCV0VsdWJtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3ViWFZzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndVpHbDJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnY21WMGMzVmlDZ3BHY21GNFVHOXZiRXhwWW5KaGNua3VZMkZzWTFKbFkyOXNiR0YwWlhKaGJHbDZaVVpTUVZoSmJtNWxjbDlsYkhObFgySnZaSGxBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmlJRVp5WVhoUWIyOXNUR2xpY21GeWVTNWpZV3hqVW1WamIyeHNZWFJsY21Gc2FYcGxSbEpCV0VsdWJtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xsTmhabVZOWVhSb0xtRmtaQ2hoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwVFlXWmxUV0YwYUM1aFpHUTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlLd29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdJK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZOaFptVk5ZWFJvT2lCaFpHUnBkR2x2YmlCdmRtVnlabXh2ZHdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVUyRm1aVTFoZEdndWMzVmlLRElwS0dFNklHSjVkR1Z6TENCaU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsTmhabVZOWVhSb0xuTjFZam9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJoaWVYUmxjeUFpVTJGbVpVMWhkR2c2SUhOMVluUnlZV04wYVc5dUlHOTJaWEptYkc5M0lnb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1VFlXWmxUV0YwYUM1emRXSW9NeWtLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGxOaFptVk5ZWFJvTG5OMVlpZ3pLU2hoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1zSUdWeWNtOXlUV1Z6YzJGblpUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVUWVdabFRXRjBhQzV6ZFdJb015azZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmlQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25ScGIyNGdabUZwYkdWa0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0o1ZEdWaklESTRJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpTFFvZ0lDQWdZbmwwWldNZ01qZ2dMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNVRZV1psVFdGMGFDNXRkV3dvWVRvZ1lubDBaWE1zSUdJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1UyRm1aVTFoZEdndWJYVnNPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nVTJGbVpVMWhkR2d1YlhWc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lISmxkSE4xWWdvS1UyRm1aVTFoZEdndWJYVnNYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpS2dvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSXZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZOaFptVk5ZWFJvT2lCdGRXeDBhWEJzYVdOaGRHbHZiaUJ2ZG1WeVpteHZkd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1VTJGbVpVMWhkR2d1WkdsMktESXBLR0U2SUdKNWRHVnpMQ0JpT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2xOaFptVk5ZWFJvTG1ScGRqb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhpZVhSbGN5QWlVMkZtWlUxaGRHZzZJR1JwZG1semFXOXVJR0o1SUhwbGNtOGlDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xsTmhabVZOWVhSb0xtUnBkaWd6S1FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVUyRm1aVTFoZEdndVpHbDJLRE1wS0dFNklHSjVkR1Z6TENCaU9pQmllWFJsY3l3Z1pYSnliM0pOWlhOellXZGxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGxOaFptVk5ZWFJvTG1ScGRpZ3pLVG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUGdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWeWRHbHZiaUJtWVdsc1pXUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpTHdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVZISmhibk5tWlhKSVpXeHdaWEl1YzJGbVpWUnlZVzV6Wm1WeUtIUnZhMlZ1T2lCaWVYUmxjeXdnZEc4NklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbFJ5WVc1elptVnlTR1ZzY0dWeUxuTmhabVZVY21GdWMyWmxjam9LSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VWSEpoYm5ObVpYSklaV3h3WlhJdWMyRm1aVlJ5WVc1elptVnlSbkp2YlNoMGIydGxiam9nWW5sMFpYTXNJR1p5YjIwNklHSjVkR1Z6TENCMGJ6b2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LVkhKaGJuTm1aWEpJWld4d1pYSXVjMkZtWlZSeVlXNXpabVZ5Um5KdmJUb0tJQ0FnSUhCeWIzUnZJRFFnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJuSmhlRkJ2YjJ3dVgxOXdiM04wU1c1cGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbDlmY0c5emRFbHVhWFE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCaWVYUmxZeUEwTlNBdkx5QWlYMTlqZEc5eVgzQmxibVJwYm1jaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUY5ZmNHOXpkRWx1YVhRZ1lXeHlaV0ZrZVNCallXeHNaV1FLSUNBZ0lHSjVkR1ZqSURRMUlDOHZJQ0pmWDJOMGIzSmZjR1Z1WkdsdVp5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdJVDBLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZWE56WlhKMElDOHZJRTkzYm1WeUlHRmtaSEpsYzNNZ1kyRnVibTkwSUdKbElEQUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSnZkMjVsY2lJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY0hWemFHSjVkR1Z6SUdKaGMyVXpNaWd5VEVkUVJrVkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQktRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdKNWRHVmpYek1nTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0FoUFFvZ0lDQWdZbm9nWDE5d2IzTjBTVzVwZEY5aWIyOXNYMlpoYkhObFFEY0tJQ0FnSUdScFp5QTBDaUFnSUNCaWVYUmxZMTh6SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnSVQwS0lDQWdJR0o2SUY5ZmNHOXpkRWx1YVhSZlltOXZiRjltWVd4elpVQTNDaUFnSUNCa2FXY2dNd29nSUNBZ1lubDBaV05mTXlBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUNFOUNpQWdJQ0JpZWlCZlgzQnZjM1JKYm1sMFgySnZiMnhmWm1Gc2MyVkFOd29nSUNBZ1pIVndDaUFnSUNCaWVpQmZYM0J2YzNSSmJtbDBYMkp2YjJ4ZlptRnNjMlZBTndvZ0lDQWdaR2xuSURJS0lDQWdJR0o1ZEdWalh6TWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQWhQUW9nSUNBZ1lub2dYMTl3YjNOMFNXNXBkRjlpYjI5c1gyWmhiSE5sUURjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dwZlgzQnZjM1JKYm1sMFgySnZiMnhmYldWeVoyVkFPRG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QmFaWEp2SUdGa1pISmxjM01nWkdWMFpXTjBaV1FLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJa1pTUVZnaUNpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJa1pZVXlJS0lDQWdJR1JwWnlBMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEwTnlBdkx5QWlabkpoZUY5amIyNTBjbUZqZEY5aFpHUnlaWE56SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEUTRJQzh2SUNKbWVITmZZMjl1ZEhKaFkzUmZZV1JrY21WemN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEwTmlBdkx5QWlZMjlzYkdGMFpYSmhiRjloWkdSeVpYTnpJZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5ScGJXVnNiMk5yWDJGa1pISmxjM01pQ2lBZ0lDQmthV2NnTkFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1OdmJHeGhkR1Z5WVd4ZmRHOXJaVzRpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01qWWdMeThnSW5CdmIyeGZZMlZwYkdsdVp5SUtJQ0FnSUdScFp5QXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1OdmJHeGhkR1Z5WVd4ZmRHOXJaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052Ykd4aGRHVnlZV3hmZEc5clpXNGdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHSTROemM1WldVM0lDOHZJRzFsZEdodlpDQWlaR1ZqYVcxaGJITW9LWFZwYm5RMk5DSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2NIVnphR2x1ZENBeE9Bb2dJQ0FnYVhSdllnb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXpkV0lLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbTFwYzNOcGJtZGZaR1ZqYVcxaGJITWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWDJkeVlXNTBVbTlzWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblJwYldWc2IyTnJYMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnBiV1ZzYjJOclgyRmtaSEpsYzNNZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWXlBME9TQXZMeUF3ZUdNMk5UVXpNakU0TldWa056QmlNbVU1T1RrME16TmxNbVU1Wm1Gak1USTBaVEE0TTJGallqRXpaV014T0ROaE5HVXdOVGswTkdSaE1EYzVNak16TjJJS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1WjNKaGJuUlNiMnhsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkR2x0Wld4dlkydGZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqSURVd0lDOHZJREI0WVRnMFlUVXpPRGxoWkRReFpqbGhZV0l3T0RNeFlqQXhaVFV6T0RSallXVTNObVUzWVRkbVpEQTVNVE14WXpJd05tWm1Oemt5TjJNeU1ERmpNemcxTndvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHY21GNFVHOXZiQzVuY21GdWRGSnZiR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSjBhVzFsYkc5amExOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGFXMWxiRzlqYTE5aFpHUnlaWE56SUdWNGFYTjBjd29nSUNBZ1lubDBaV01nTlRFZ0x5OGdNSGc0TVRFNFpXVmlOVEl6TVdFMVptVTBNREE0WVRVMVlqWXlPRFl3WmpaaE1HUmlOR1kyWXpOaFl6QTBaamd4TkRFNU1qZGhPV0l6Wm1Wa1pEZzJaREptQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbWR5WVc1MFVtOXNaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luUnBiV1ZzYjJOclgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhScGJXVnNiMk5yWDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNCaWVYUmxZeUExTWlBdkx5QXdlREV3TTJSaE56bG1aak0zTlRWbVpqZGhNVGRoTlRVM1pESTRZamN6WkRNM1kySTBaR1V3WWpOak0yTmpNREptWVRaak5EaGtaakJtTXpVd056Rm1ZbVlLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VaM0poYm5SU2IyeGxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWRHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUdKNWRHVmpJRFV6SUM4dklEQjRZbUl5WXpZNFlqaGtZelZpWTJOa1pESTFNell6TURjd09EQmhOemcyTldFM1pURXpNMkptTlRSbE16RmtOR1EwTmpOaU1XSTNORGxpTkdKalpqSTJaQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNW5jbUZ1ZEZKdmJHVUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbDlmY0c5emRFbHVhWFJmWW05dmJGOW1ZV3h6WlVBM09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWDE5d2IzTjBTVzVwZEY5aWIyOXNYMjFsY21kbFFEZ0tDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNWpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURFeUNpQWdJQ0JpZVhSbFl5QXlNQ0F2THlBaVkyOXNiR0YwWlhKaGJGQnlhV05sVUdGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmpiMnhzWVhSbGNtRnNVSEpwWTJWUVlYVnpaV1FnWlhocGMzUnpDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdOdmJHeGhkRVJ2Ykd4aGNrSmhiR0Z1WTJWZlpXeHpaVjlpYjJSNVFEa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWTI5c2JHRjBaWEpoYkY5MGIydGxiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjlzYkdGMFpYSmhiRjkwYjJ0bGJpQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNamtnTHk4Z2JXVjBhRzlrSUNKaVlXeGhibU5sVDJZb1lXUmtjbVZ6Y3lsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlkWEo1SURZS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd1lRb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltMXBjM05wYm1kZlpHVmphVzFoYkhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0F4TUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHMXBjM05wYm1kZlpHVmphVzFoYkhNZ1pYaHBjM1J6Q2dwamIyeHNZWFJFYjJ4c1lYSkNZV3hoYm1ObFgzZG9hV3hsWDNSdmNFQTBPZ29nSUNBZ1pHbG5JRGdLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWVpQmpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxYMkZtZEdWeVgzZG9hV3hsUURnS0lDQWdJR1JwWnlBNENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUdOdmJHeGhkRVJ2Ykd4aGNrSmhiR0Z1WTJWZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaR2xuSURFeUNpQWdJQ0JpS2dvZ0lDQWdZblZ5ZVNBMkNncGpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUdScFp5QTRDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF5Q2lBZ0lDQmlMd29nSUNBZ1luVnllU0E1Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR1IxY0FvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTVRJS0lDQWdJR0lnWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlY5M2FHbHNaVjkwYjNCQU5Bb0tZMjlzYkdGMFJHOXNiR0Z5UW1Gc1lXNWpaVjloWm5SbGNsOTNhR2xzWlVBNE9nb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblZ1WTJ4aGFXMWxaRkJ2YjJ4RGIyeHNZWFJsY21Gc0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMWJtTnNZV2x0WldSUWIyOXNRMjlzYkdGMFpYSmhiQ0JsZUdsemRITUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YzNWaUNpQWdJQ0JrYVdjZ05nb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV0ZFd3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU55QXZMeUFpY0dGMWMyVmtVSEpwWTJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhCaGRYTmxaRkJ5YVdObElHVjRhWE4wY3dvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXRkV3dLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbVJwZGdvS1kyOXNiR0YwUkc5c2JHRnlRbUZzWVc1alpWOWhablJsY2w5cGJteHBibVZrWHk5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xtTnZiR3hoZEVSdmJHeGhja0poYkdGdVkyVkFNak02Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlY5bGJITmxYMkp2WkhsQU9Ub0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pHVWtGWUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCR1VrRllJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUExTkNBdkx5QnRaWFJvYjJRZ0ltVjBhRjkxYzJSZmNISnBZMlVvS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpZFhKNUlEVUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZ3dZUW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbTFwYzNOcGJtZGZaR1ZqYVcxaGJITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2diV2x6YzJsdVoxOWtaV05wYldGc2N5QmxlR2x6ZEhNS0NtTnZiR3hoZEVSdmJHeGhja0poYkdGdVkyVmZkMmhwYkdWZmRHOXdRREV4T2dvZ0lDQWdaR2xuSURjS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0krQ2lBZ0lDQmllaUJqYjJ4c1lYUkViMnhzWVhKQ1lXeGhibU5sWDJGbWRHVnlYM2RvYVd4bFFERTFDaUFnSUNCa2FXY2dOd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlKZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQmpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UUUtJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHSXFDaUFnSUNCaWRYSjVJRFVLQ21OdmJHeGhkRVJ2Ykd4aGNrSmhiR0Z1WTJWZllXWjBaWEpmYVdaZlpXeHpaVUF4TkRvS0lDQWdJR1JwWnlBM0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBd2VEQXlDaUFnSUNCaUx3b2dJQ0FnWW5WeWVTQTRDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHUjFjQW9nSUNBZ1lpb0tJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHSWdZMjlzYkdGMFJHOXNiR0Z5UW1Gc1lXNWpaVjkzYUdsc1pWOTBiM0JBTVRFS0NtTnZiR3hoZEVSdmJHeGhja0poYkdGdVkyVmZZV1owWlhKZmQyaHBiR1ZBTVRVNkNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTXpjZ0x5OGdJbmRsZEdoZllXUmtjbVZ6Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZDJWMGFGOWhaR1J5WlhOeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbmwwWldNZ01qRWdMeThnTUhnd1pqUXlOREFLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmlLZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNellnTHk4Z0ltTnZiR3hoZEVWMGFFOXlZV05zWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWTI5c2JHRjBSWFJvVDNKaFkyeGxJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUExTlNBdkx5QnRaWFJvYjJRZ0ltTnZibk4xYkhRb1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2FXNTBZeUEwSUM4dklERXdNREF3TURBS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV0ZFd3S0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VaR2wyQ2lBZ0lDQmlkWEo1SURNS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZMjlzYkdGMFpYSmhiRjkwYjJ0bGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1kyOXNiR0YwWlhKaGJGOTBiMnRsYmlCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ01qa2dMeThnYldWMGFHOWtJQ0ppWVd4aGJtTmxUMllvWVdSa2NtVnpjeWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhDaUFnSUNCaWRYSjVJRFFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3WVFvZ0lDQWdZblZ5ZVNBeE1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW0xcGMzTnBibWRmWkdWamFXMWhiSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5WeWVTQTRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYldsemMybHVaMTlrWldOcGJXRnNjeUJsZUdsemRITUtDbU52Ykd4aGRFUnZiR3hoY2tKaGJHRnVZMlZmZDJocGJHVmZkRzl3UURFNE9nb2dJQ0FnWkdsbklEWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJK0NpQWdJQ0JpZWlCamIyeHNZWFJFYjJ4c1lYSkNZV3hoYm1ObFgyRm1kR1Z5WDNkb2FXeGxRREl5Q2lBZ0lDQmthV2NnTmdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpSmdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQmllaUJqYjJ4c1lYUkViMnhzWVhKQ1lXeGhibU5sWDJGbWRHVnlYMmxtWDJWc2MyVkFNakVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR0lxQ2lBZ0lDQmlkWEo1SURRS0NtTnZiR3hoZEVSdmJHeGhja0poYkdGdVkyVmZZV1owWlhKZmFXWmZaV3h6WlVBeU1Ub0tJQ0FnSUdScFp5QTJDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF5Q2lBZ0lDQmlMd29nSUNBZ1luVnllU0EzQ2lBZ0lDQmthV2NnT1FvZ0lDQWdaSFZ3Q2lBZ0lDQmlLZ29nSUNBZ1luVnllU0F4TUFvZ0lDQWdZaUJqYjJ4c1lYUkViMnhzWVhKQ1lXeGhibU5sWDNkb2FXeGxYM1J2Y0VBeE9Bb0tZMjlzYkdGMFJHOXNiR0Z5UW1Gc1lXNWpaVjloWm5SbGNsOTNhR2xzWlVBeU1qb0tJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0oxYm1Oc1lXbHRaV1JRYjI5c1EyOXNiR0YwWlhKaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dnWlhocGMzUnpDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnWkdsbklEUUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YlhWc0NpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV0ZFd3S0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbVJwZGdvZ0lDQWdZaUJqYjJ4c1lYUkViMnhzWVhKQ1lXeGhibU5sWDJGbWRHVnlYMmx1YkdsdVpXUmZMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1WTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlVBeU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xtRjJZV2xzWVdKc1pVVjRZMlZ6YzBOdmJHeGhkRVJXVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYWmhhV3hoWW14bFJYaGpaWE56UTI5c2JHRjBSRlk2Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbUYyWVdsc1lXSnNaVVY0WTJWemMwTnZiR3hoZEVSV0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzTG1kbGRFTnZiR3hoZEdWeVlXeFFjbWxqWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRU52Ykd4aGRHVnlZV3hRY21salpUb0tJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJuSmhlRkJ2YjJ3dVoyVjBRMjlzYkdGMFpYSmhiRkJ5YVdObENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzTG5ObGRFTnZiR3hoZEVWVVNFOXlZV05zWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRU52Ykd4aGRFVlVTRTl5WVdOc1pUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkR2x0Wld4dlkydGZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2djMlYwUTI5c2JHRjBSVlJJVDNKaFkyeGxYMkp2YjJ4ZmRISjFaVUF6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmllaUJ6WlhSRGIyeHNZWFJGVkVoUGNtRmpiR1ZmWW05dmJGOW1ZV3h6WlVBMENncHpaWFJEYjJ4c1lYUkZWRWhQY21GamJHVmZZbTl2YkY5MGNuVmxRRE02Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9LYzJWMFEyOXNiR0YwUlZSSVQzSmhZMnhsWDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUWdiM2R1WlhJZ2IzSWdkR2x0Wld4dlkyc0tJQ0FnSUdKNWRHVmpJRFEwSUM4dklDSmpiMnhzWVhSZlpYUm9YMjl5WVdOc1pWOWhaR1J5WlhOeklnb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURNMklDOHZJQ0pqYjJ4c1lYUkZkR2hQY21GamJHVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTXpjZ0x5OGdJbmRsZEdoZllXUmtjbVZ6Y3lJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjMlYwUTI5c2JHRjBSVlJJVDNKaFkyeGxYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSE5sZEVOdmJHeGhkRVZVU0U5eVlXTnNaVjlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1dGFXNTBNWFF4UmxKQldGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTFwYm5ReGRERkdVa0ZZT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE9DQXZMeUFpYldsdWRGQmhkWE5sWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYldsdWRGQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCTmFXNTBhVzVuSUdseklIQmhkWE5sWkFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE1HRUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKdGFYTnphVzVuWDJSbFkybHRZV3h6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ0YVhOemFXNW5YMlJsWTJsdFlXeHpJR1Y0YVhOMGN3b0tiV2x1ZERGME1VWlNRVmhmZDJocGJHVmZkRzl3UURJNkNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0krQ2lBZ0lDQmllaUJ0YVc1ME1YUXhSbEpCV0Y5aFpuUmxjbDkzYUdsc1pVQTJDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1lpWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWW5vZ2JXbHVkREYwTVVaU1FWaGZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUdJcUNpQWdJQ0JpZFhKNUlETUtDbTFwYm5ReGRERkdVa0ZZWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TWdvZ0lDQWdZaThLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZaUJ0YVc1ME1YUXhSbEpCV0Y5M2FHbHNaVjkwYjNCQU1nb0tiV2x1ZERGME1VWlNRVmhmWVdaMFpYSmZkMmhwYkdWQU5qb0tJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNCaUtnb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJa1pTUVZnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVaU1FWZ2daWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJREUySUM4dklHMWxkR2h2WkNBaVoyeHZZbUZzWDJOdmJHeGhkR1Z5WVd4ZmNtRjBhVzhvS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdKNWRHVmpJREl4SUM4dklEQjRNR1kwTWpRd0NpQWdJQ0JpUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYjJ4c1lYUmxjbUZzSUhKaGRHbHZJRzExYzNRZ1ltVWdQajBnTVFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmpiMnhzWVhSbGNtRnNYM1J2YTJWdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCamIyeHNZWFJsY21Gc1gzUnZhMlZ1SUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBeU9TQXZMeUJ0WlhSb2IyUWdJbUpoYkdGdVkyVlBaaWhoWkdSeVpYTnpLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkVzVqYkdGcGJXVmtVRzl2YkVOdmJHeGhkR1Z5WVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhWdVkyeGhhVzFsWkZCdmIyeERiMnhzWVhSbGNtRnNJR1Y0YVhOMGN3b2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV6ZFdJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbUZrWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURJMklDOHZJQ0p3YjI5c1gyTmxhV3hwYm1jaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhCdmIyeGZZMlZwYkdsdVp5QmxlR2x6ZEhNS0lDQWdJR0k4UFFvZ0lDQWdZWE56WlhKMElDOHZJRnRRYjI5c0ozTWdRMnh2YzJWa1hUb2dRMlZwYkdsdVp5QnlaV0ZqYUdWa0NpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzTG1kbGRFTnZiR3hoZEdWeVlXeFFjbWxqWlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQkdjbUY0VUc5dmJFeHBZbkpoY25rdVkyRnNZMDFwYm5ReGRERkdVa0ZZQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TURBd01Bb2dJQ0FnYVhSdllnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklESTBJQzh2SUNKdGFXNTBhVzVuWDJabFpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2JXbHVkR2x1WjE5bVpXVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV6ZFdJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1dGRXd0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WkdsMkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklERUtJQ0FnSUdJOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZOc2FYQndZV2RsSUd4cGJXbDBJSEpsWVdOb1pXUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKamIyeHNZWFJsY21Gc1gzUnZhMlZ1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjJ4c1lYUmxjbUZzWDNSdmEyVnVJR1Y0YVhOMGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyRnNiSE4xWWlCVWNtRnVjMlpsY2tobGJIQmxjaTV6WVdabFZISmhibk5tWlhKR2NtOXRDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSWtaU1FWZ2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFWlNRVmdnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURNd0lDOHZJRzFsZEdodlpDQWljRzl2YkY5dGFXNTBLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1dGFXNTBRV3huYjNKcGRHaHRhV05HVWtGWVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiV2x1ZEVGc1oyOXlhWFJvYldsalJsSkJXRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbTFwYm5SUVlYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzFwYm5SUVlYVnpaV1FnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVFdsdWRHbHVaeUJwY3lCd1lYVnpaV1FLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKR1VrRllJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkdVa0ZZSUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURNeElDOHZJRzFsZEdodlpDQWlabmh6WDNCeWFXTmxLQ2wxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJRzFsZEdodlpDQWlaMnh2WW1Gc1gyTnZiR3hoZEdWeVlXeGZjbUYwYVc4b0tYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFTnZiR3hoZEdWeVlXd2djbUYwYVc4Z2JYVnpkQ0JpWlNBd0NpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJHY21GNFVHOXZiRXhwWW5KaGNua3VZMkZzWTAxcGJuUkJiR2R2Y21sMGFHMXBZMFpTUVZnS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01EQXdDaUFnSUNCcGRHOWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNalFnTHk4Z0ltMXBiblJwYm1kZlptVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnRhVzUwYVc1blgyWmxaU0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtMTFiQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR0k4UFFvZ0lDQWdZWE56WlhKMElDOHZJRk5zYVhCd1lXZGxJR3hwYldsMElISmxZV05vWldRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWlSbGhUSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJHV0ZNZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWaklETXlJQzh2SUcxbGRHaHZaQ0FpY0c5dmJGOWlkWEp1WDJaeWIyMG9ZV1JrY21WemN5eDFhVzUwTWpVMktYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNekFnTHk4Z2JXVjBhRzlrSUNKd2IyOXNYMjFwYm5Rb1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbTFwYm5SR2NtRmpkR2x2Ym1Gc1JsSkJXRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xcGJuUkdjbUZqZEdsdmJtRnNSbEpCV0RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREU0SUM4dklDSnRhVzUwVUdGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnRhVzUwVUdGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTFwYm5ScGJtY2dhWE1nY0dGMWMyVmtDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpUmxKQldDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1JsSkJXQ0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF6TVNBdkx5QnRaWFJvYjJRZ0ltWjRjMTl3Y21salpTZ3BkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJREUySUM4dklHMWxkR2h2WkNBaVoyeHZZbUZzWDJOdmJHeGhkR1Z5WVd4ZmNtRjBhVzhvS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTWdNakVnTHk4Z01IZ3daalF5TkRBS0lDQWdJR0k4Q2lBZ0lDQmllaUJ0YVc1MFJuSmhZM1JwYjI1aGJFWlNRVmhmWW05dmJGOW1ZV3h6WlVBMkNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0krQ2lBZ0lDQmllaUJ0YVc1MFJuSmhZM1JwYjI1aGJFWlNRVmhmWW05dmJGOW1ZV3h6WlVBMkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvS2JXbHVkRVp5WVdOMGFXOXVZV3hHVWtGWVgySnZiMnhmYldWeVoyVkFOem9LSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiMnhzWVhSbGNtRnNJSEpoZEdsdklHNWxaV1J6SUhSdklHSmxJR0psZEhkbFpXNGdMakF3TURBd01TQmhibVFnTGprNU9UazVPUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKamIyeHNZWFJsY21Gc1gzUnZhMlZ1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjJ4c1lYUmxjbUZzWDNSdmEyVnVJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF5T1NBdkx5QnRaWFJvYjJRZ0ltSmhiR0Z1WTJWUFppaGhaR1J5WlhOektYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFZ1WTJ4aGFXMWxaRkJ2YjJ4RGIyeHNZWFJsY21Gc0lHVjRhWE4wY3dvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXpkV0lLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtRmtaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREkySUM4dklDSndiMjlzWDJObGFXeHBibWNpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEJ2YjJ4ZlkyVnBiR2x1WnlCbGVHbHpkSE1LSUNBZ0lHSThQUW9nSUNBZ1lYTnpaWEowSUM4dklGQnZiMndnWTJWcGJHbHVaeUJ5WldGamFHVmtMQ0J1YnlCdGIzSmxJRVpTUVZnZ1kyRnVJR0psSUcxcGJuUmxaQ0IzYVhSb0lIUm9hWE1nWTI5c2JHRjBaWEpoYkFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpZFhKNUlEY0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZ3dZUW9nSUNBZ1luVnllU0E1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWliV2x6YzJsdVoxOWtaV05wYldGc2N5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkWEo1SURrS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnRhWE56YVc1blgyUmxZMmx0WVd4eklHVjRhWE4wY3dvS2JXbHVkRVp5WVdOMGFXOXVZV3hHVWtGWVgzZG9hV3hsWDNSdmNFQTVPZ29nSUNBZ1pHbG5JRGNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWVpQnRhVzUwUm5KaFkzUnBiMjVoYkVaU1FWaGZZV1owWlhKZmQyaHBiR1ZBTVRNS0lDQWdJR1JwWnlBM0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUcxcGJuUkdjbUZqZEdsdmJtRnNSbEpCV0Y5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQmthV2NnTmdvZ0lDQWdaR2xuSURrS0lDQWdJR0lxQ2lBZ0lDQmlkWEo1SURjS0NtMXBiblJHY21GamRHbHZibUZzUmxKQldGOWhablJsY2w5cFpsOWxiSE5sUURFeU9nb2dJQ0FnWkdsbklEY0tJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjRNRElLSUNBZ0lHSXZDaUFnSUNCaWRYSjVJRGdLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmtkWEFLSUNBZ0lHSXFDaUFnSUNCaWRYSjVJRGtLSUNBZ0lHSWdiV2x1ZEVaeVlXTjBhVzl1WVd4R1VrRllYM2RvYVd4bFgzUnZjRUE1Q2dwdGFXNTBSbkpoWTNScGIyNWhiRVpTUVZoZllXWjBaWEpmZDJocGJHVkFNVE02Q2lBZ0lDQmthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnT0FvZ0lDQWdZaW9LSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VaMlYwUTI5c2JHRjBaWEpoYkZCeWFXTmxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JrYVdjZ013b2dJQ0FnWW53S0lDQWdJR1JwWnlBNENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTVDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlmQW9nSUNBZ1pHbG5JRGdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUExQ2lBZ0lDQmlmQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR05oYkd4emRXSWdSbkpoZUZCdmIyeE1hV0p5WVhKNUxtTmhiR05OYVc1MFJuSmhZM1JwYjI1aGJFWlNRVmdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQkdjbUY0VUc5dmJFeHBZbkpoY25rdVkyRnNZMDFwYm5SR2NtRmpkR2x2Ym1Gc1JsSkJXQW9nSUNBZ2NHOXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01qUWdMeThnSW0xcGJuUnBibWRmWm1WbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdGFXNTBhVzVuWDJabFpTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9Mbk4xWWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG0xMWJBb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVrYVhZS0lDQWdJR1JwWnlBM0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWp3OUNpQWdJQ0JoYzNObGNuUWdMeThnVTJ4cGNIQmhaMlVnYkdsdGFYUWdjbVZoWTJobFpBb2dJQ0FnWkdsbklERUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZanc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdWdWIzVm5hQ0JHV0ZNZ2FXNXdkWFIwWldRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pHV0ZNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVaWVV5QmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNeklnTHk4Z2JXVjBhRzlrSUNKd2IyOXNYMkoxY201ZlpuSnZiU2hoWkdSeVpYTnpMSFZwYm5ReU5UWXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWTI5c2JHRjBaWEpoYkY5MGIydGxiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjlzYkdGMFpYSmhiRjkwYjJ0bGJpQmxlR2x6ZEhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOaGJHeHpkV0lnVkhKaGJuTm1aWEpJWld4d1pYSXVjMkZtWlZSeVlXNXpabVZ5Um5KdmJRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlSbEpCV0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUmxKQldDQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNekFnTHk4Z2JXVjBhRzlrSUNKd2IyOXNYMjFwYm5Rb1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldsdWRFWnlZV04wYVc5dVlXeEdVa0ZZWDJKdmIyeGZabUZzYzJWQU5qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUcxcGJuUkdjbUZqZEdsdmJtRnNSbEpCV0Y5aWIyOXNYMjFsY21kbFFEY0tDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNXlaV1JsWlcweGRERkdVa0ZZVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmtaV1Z0TVhReFJsSkJXRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRrZ0x5OGdJbkpsWkdWbGJWQmhkWE5sWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21Wa1pXVnRVR0YxYzJWa0lHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGSmxaR1ZsYldsdVp5QnBjeUJ3WVhWelpXUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pHVWtGWUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCR1VrRllJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QnRaWFJvYjJRZ0ltZHNiMkpoYkY5amIyeHNZWFJsY21Gc1gzSmhkR2x2S0NsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCaWVYUmxZeUF5TVNBdkx5QXdlREJtTkRJME1Bb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUWdMeThnUTI5c2JHRjBaWEpoYkNCeVlYUnBieUJ0ZFhOMElHSmxJRDA5SURFS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEQmhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJXbHpjMmx1WjE5a1pXTnBiV0ZzY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYldsemMybHVaMTlrWldOcGJXRnNjeUJsZUdsemRITUtDbkpsWkdWbGJURjBNVVpTUVZoZmQyaHBiR1ZmZEc5d1FETTZDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJK0NpQWdJQ0JpZWlCeVpXUmxaVzB4ZERGR1VrRllYMkZtZEdWeVgzZG9hV3hsUURjS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpSmdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQmllaUJ5WldSbFpXMHhkREZHVWtGWVgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JpS2dvZ0lDQWdZblZ5ZVNBekNncHlaV1JsWlcweGRERkdVa0ZZWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TWdvZ0lDQWdZaThLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZaUJ5WldSbFpXMHhkREZHVWtGWVgzZG9hV3hsWDNSdmNFQXpDZ3B5WldSbFpXMHhkREZHVWtGWVgyRm1kR1Z5WDNkb2FXeGxRRGM2Q2lBZ0lDQmthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNWthWFlLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VaMlYwUTI5c2JHRjBaWEpoYkZCeWFXTmxDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUVaeVlYaFFiMjlzVEdsaWNtRnllUzVqWVd4alVtVmtaV1Z0TVhReFJsSkJXQW9nSUNBZ2FXNTBZeUEwSUM4dklERXdNREF3TURBS0lDQWdJR2wwYjJJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU5TQXZMeUFpY21Wa1pXMXdkR2x2Ymw5bVpXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklISmxaR1Z0Y0hScGIyNWZabVZsSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWMzVmlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3ViWFZzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtUnBkZ29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKamIyeHNZWFJsY21Gc1gzUnZhMlZ1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjJ4c1lYUmxjbUZzWDNSdmEyVnVJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF5T1NBdkx5QnRaWFJvYjJRZ0ltSmhiR0Z1WTJWUFppaGhaR1J5WlhOektYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFZ1WTJ4aGFXMWxaRkJ2YjJ4RGIyeHNZWFJsY21Gc0lHVjRhWE4wY3dvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VjM1ZpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdWdWIzVm5hQ0JqYjJ4c1lYUmxjbUZzSUdsdUlIQnZiMndLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZanc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMnhwY0hCaFoyVWdiR2x0YVhRZ2NtVmhZMmhsWkFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeU1pQXZMeUFpY21Wa1pXVnRRMjlzYkdGMFpYSmhiRUpoYkdGdVkyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtRmtaQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF5TWlBdkx5QWljbVZrWldWdFEyOXNiR0YwWlhKaGJFSmhiR0Z1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNWhaR1FLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblZ1WTJ4aGFXMWxaRkJ2YjJ4RGIyeHNZWFJsY21Gc0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYVhSdllnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QTBNeUF2THlBaWJHRnpkRkpsWkdWbGJXVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pHVWtGWUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCR1VrRllJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF6TWlBdkx5QnRaWFJvYjJRZ0luQnZiMnhmWW5WeWJsOW1jbTl0S0dGa1pISmxjM01zZFdsdWRESTFOaWwyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNXlaV1JsWlcxR2NtRmpkR2x2Ym1Gc1JsSkJXRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFpHVmxiVVp5WVdOMGFXOXVZV3hHVWtGWU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z05nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFNUlDOHZJQ0p5WldSbFpXMVFZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhKbFpHVmxiVkJoZFhObFpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaV1JsWlcxcGJtY2dhWE1nY0dGMWMyVmtDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpUmxKQldDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1JsSkJXQ0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF6TVNBdkx5QnRaWFJvYjJRZ0ltWjRjMTl3Y21salpTZ3BkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJREUySUM4dklHMWxkR2h2WkNBaVoyeHZZbUZzWDJOdmJHeGhkR1Z5WVd4ZmNtRjBhVzhvS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTWdNakVnTHk4Z01IZ3daalF5TkRBS0lDQWdJR0k4Q2lBZ0lDQmllaUJ5WldSbFpXMUdjbUZqZEdsdmJtRnNSbEpCV0Y5aWIyOXNYMlpoYkhObFFEWUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWo0S0lDQWdJR0o2SUhKbFpHVmxiVVp5WVdOMGFXOXVZV3hHVWtGWVgySnZiMnhmWm1Gc2MyVkFOZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtDbkpsWkdWbGJVWnlZV04wYVc5dVlXeEdVa0ZZWDJKdmIyeGZiV1Z5WjJWQU56b0tJQ0FnSUdGemMyVnlkQ0F2THlCRGIyeHNZWFJsY21Gc0lISmhkR2x2SUc1bFpXUnpJSFJ2SUdKbElHSmxkSGRsWlc0Z0xqQXdNREF3TVNCaGJtUWdMams1T1RrNU9Rb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1blpYUkRiMnhzWVhSbGNtRnNVSEpwWTJVS0lDQWdJR0oxY25rZ09Bb2dJQ0FnYVc1MFl5QTBJQzh2SURFd01EQXdNREFLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWpVZ0x5OGdJbkpsWkdWdGNIUnBiMjVmWm1WbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCeVpXUmxiWEIwYVc5dVgyWmxaU0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnWkdsbklEWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YlhWc0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVrYVhZS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5Bb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV0ZFd3S0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbVJwZGdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXpkV0lLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWJYVnNDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUdKMWNua2dOd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlkWEo1SURrS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd1lRb2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltMXBjM05wYm1kZlpHVmphVzFoYkhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHMXBjM05wYm1kZlpHVmphVzFoYkhNZ1pYaHBjM1J6Q2dweVpXUmxaVzFHY21GamRHbHZibUZzUmxKQldGOTNhR2xzWlY5MGIzQkFPRG9LSUNBZ0lHUnBaeUE1Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lub2djbVZrWldWdFJuSmhZM1JwYjI1aGJFWlNRVmhmWVdaMFpYSmZkMmhwYkdWQU1USUtJQ0FnSUdScFp5QTVDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSW1DaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdKNklISmxaR1ZsYlVaeVlXTjBhVzl1WVd4R1VrRllYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtJQ0FnSUdScFp5QTRDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHSXFDaUFnSUNCaWRYSjVJRGtLQ25KbFpHVmxiVVp5WVdOMGFXOXVZV3hHVWtGWVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFNkNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3dNZ29nSUNBZ1lpOEtJQ0FnSUdKMWNua2dNVEFLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaSFZ3Q2lBZ0lDQmlLZ29nSUNBZ1luVnllU0F4TVFvZ0lDQWdZaUJ5WldSbFpXMUdjbUZqZEdsdmJtRnNSbEpCV0Y5M2FHbHNaVjkwYjNCQU9Bb0tjbVZrWldWdFJuSmhZM1JwYjI1aGJFWlNRVmhmWVdaMFpYSmZkMmhwYkdWQU1USTZDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtUnBkZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWJYVnNDaUFnSUNCa2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtUnBkZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1dGRXd0tJQ0FnSUdScFp5QTRDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1ScGRnb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pqYjJ4c1lYUmxjbUZzWDNSdmEyVnVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmpiMnhzWVhSbGNtRnNYM1J2YTJWdUlHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXlPU0F2THlCdFpYUm9iMlFnSW1KaGJHRnVZMlZQWmloaFpHUnlaWE56S1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZFc1amJHRnBiV1ZrVUc5dmJFTnZiR3hoZEdWeVlXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIVnVZMnhoYVcxbFpGQnZiMnhEYjJ4c1lYUmxjbUZzSUdWNGFYTjBjd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWMzVmlDaUFnSUNCa2FXY2dNZ29nSUNBZ1lqNDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJR1Z1YjNWbmFDQmpiMnhzWVhSbGNtRnNJR2x1SUhCdmIyd0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dNZ29nSUNBZ1lqdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1UyeHBjSEJoWjJVZ2JHbHRhWFFnY21WaFkyaGxaQ0JiWTI5c2JHRjBaWEpoYkYwS0lDQWdJR1JwWnlBMUNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCaVBEMEtJQ0FnSUdGemMyVnlkQ0F2THlCVGJHbHdjR0ZuWlNCc2FXMXBkQ0J5WldGamFHVmtJRnRHV0ZOZENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklESXlJQzh2SUNKeVpXUmxaVzFEYjJ4c1lYUmxjbUZzUW1Gc1lXNWpaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VZV1JrQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJQ0p5WldSbFpXMURiMnhzWVhSbGNtRnNRbUZzWVc1alpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbUZrWkFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZFc1amJHRnBiV1ZrVUc5dmJFTnZiR3hoZEdWeVlXd2lDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF5TXlBdkx5QWljbVZrWldWdFJsaFRRbUZzWVc1alpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndVlXUmtDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJREl6SUM4dklDSnlaV1JsWlcxR1dGTkNZV3hoYm1ObGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpZFc1amJHRnBiV1ZrVUc5dmJFWllVeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkVzVqYkdGcGJXVmtVRzl2YkVaWVV5QmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbUZrWkFvZ0lDQWdZbmwwWldNZ01UVWdMeThnSW5WdVkyeGhhVzFsWkZCdmIyeEdXRk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdaMnh2WW1Gc0lGSnZkVzVrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURReklDOHZJQ0pzWVhOMFVtVmtaV1Z0WldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pHVWtGWUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCR1VrRllJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF6TWlBdkx5QnRaWFJvYjJRZ0luQnZiMnhmWW5WeWJsOW1jbTl0S0dGa1pISmxjM01zZFdsdWRESTFOaWwyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UUWdMeThnSWtaWVV5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1JsaFRJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF6TUNBdkx5QnRaWFJvYjJRZ0luQnZiMnhmYldsdWRDaGhaR1J5WlhOekxIVnBiblF5TlRZcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVpXUmxaVzFHY21GamRHbHZibUZzUmxKQldGOWliMjlzWDJaaGJITmxRRFk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnlaV1JsWlcxR2NtRmpkR2x2Ym1Gc1JsSkJXRjlpYjI5c1gyMWxjbWRsUURjS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1eVpXUmxaVzFCYkdkdmNtbDBhRzFwWTBaU1FWaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldSbFpXMUJiR2R2Y21sMGFHMXBZMFpTUVZnNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTVJQzh2SUNKeVpXUmxaVzFRWVhWelpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklISmxaR1ZsYlZCaGRYTmxaQ0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWldSbFpXMXBibWNnYVhNZ2NHRjFjMlZrQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVJsSkJXQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSbEpCV0NCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBek1TQXZMeUJ0WlhSb2IyUWdJbVo0YzE5d2NtbGpaU2dwZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJRzFsZEdodlpDQWlaMnh2WW1Gc1gyTnZiR3hoZEdWeVlXeGZjbUYwYVc4b0tYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFTnZiR3hoZEdWeVlXd2djbUYwYVc4Z2JYVnpkQ0JpWlNBd0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREkxSUM4dklDSnlaV1JsYlhCMGFXOXVYMlpsWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21Wa1pXMXdkR2x2Ymw5bVpXVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV6ZFdJS0lDQWdJR1JwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbTExYkFvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VaR2wyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtMTFiQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNak1nTHk4Z0luSmxaR1ZsYlVaWVUwSmhiR0Z1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1Ga1pBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXlNeUF2THlBaWNtVmtaV1Z0UmxoVFFtRnNZVzVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJblZ1WTJ4aGFXMWxaRkJ2YjJ4R1dGTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIVnVZMnhoYVcxbFpGQnZiMnhHV0ZNZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNWhaR1FLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0oxYm1Oc1lXbHRaV1JRYjI5c1JsaFRJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUEwTXlBdkx5QWliR0Z6ZEZKbFpHVmxiV1ZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSThQUW9nSUNBZ1lYTnpaWEowSUM4dklGTnNhWEJ3WVdkbElHeHBiV2wwSUhKbFlXTm9aV1FLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKR1VrRllJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkdVa0ZZSUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBek1pQXZMeUJ0WlhSb2IyUWdJbkJ2YjJ4ZlluVnlibDltY205dEtHRmtaSEpsYzNNc2RXbHVkREkxTmlsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0lrWllVeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSbGhUSUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBek1DQXZMeUJ0WlhSb2IyUWdJbkJ2YjJ4ZmJXbHVkQ2hoWkdSeVpYTnpMSFZwYm5ReU5UWXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJuSmhlRkJ2YjJ3dVkyOXNiR1ZqZEZKbFpHVnRjSFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMnhzWldOMFVtVmtaVzF3ZEdsdmJqb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ05ETWdMeThnSW14aGMzUlNaV1JsWlcxbFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOREVnTHk4Z0luSmxaR1Z0Y0hScGIyNWZaR1ZzWVhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhKbFpHVnRjSFJwYjI1ZlpHVnNZWGtnWlhocGMzUnpDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1Ga1pBb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JwZEc5aUNpQWdJQ0JpUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMElIZGhhWFFnWm05eUlISmxaR1Z0Y0hScGIyNWZaR1ZzWVhrZ1lteHZZMnR6SUdKbFptOXlaU0JqYjJ4c1pXTjBhVzVuSUhKbFpHVnRjSFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2wwYjJJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01qTWdMeThnSW5KbFpHVmxiVVpZVTBKaGJHRnVZMlZ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0krQ2lBZ0lDQmlibm9nWTI5c2JHVmpkRkpsWkdWdGNIUnBiMjVmYVdaZlltOWtlVUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTkFvS1kyOXNiR1ZqZEZKbFpHVnRjSFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeU1pQXZMeUFpY21Wa1pXVnRRMjlzYkdGMFpYSmhiRUpoYkdGdVkyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWJub2dZMjlzYkdWamRGSmxaR1Z0Y0hScGIyNWZhV1pmWW05a2VVQTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOUW9LWTI5c2JHVmpkRkpsWkdWdGNIUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ1pHbG5JRElLSUNBZ0lHSjZJR052Ykd4bFkzUlNaV1JsYlhCMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU53b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKR1dGTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFWllVeUJsZUdsemRITUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBMUNpQWdJQ0JqWVd4c2MzVmlJRlJ5WVc1elptVnlTR1ZzY0dWeUxuTmhabVZVY21GdWMyWmxjZ29LWTI5c2JHVmpkRkpsWkdWdGNIUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjZJR052Ykd4bFkzUlNaV1JsYlhCMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1OdmJHeGhkR1Z5WVd4ZmRHOXJaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052Ykd4aGRHVnlZV3hmZEc5clpXNGdaWGhwYzNSekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTmdvZ0lDQWdZMkZzYkhOMVlpQlVjbUZ1YzJabGNraGxiSEJsY2k1ellXWmxWSEpoYm5ObVpYSUtDbU52Ykd4bFkzUlNaV1JsYlhCMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU9Ub0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU52Ykd4bFkzUlNaV1JsYlhCMGFXOXVYMmxtWDJKdlpIbEFORG9LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTWpJZ0x5OGdJbkpsWkdWbGJVTnZiR3hoZEdWeVlXeENZV3hoYm1ObGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF5TWlBdkx5QWljbVZrWldWdFEyOXNiR0YwWlhKaGJFSmhiR0Z1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0oxYm1Oc1lXbHRaV1JRYjI5c1EyOXNiR0YwWlhKaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZaUJqYjJ4c1pXTjBVbVZrWlcxd2RHbHZibDloWm5SbGNsOXBabDlsYkhObFFEVUtDbU52Ykd4bFkzUlNaV1JsYlhCMGFXOXVYMmxtWDJKdlpIbEFNam9LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTWpNZ0x5OGdJbkpsWkdWbGJVWllVMEpoYkdGdVkyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURJeklDOHZJQ0p5WldSbFpXMUdXRk5DWVd4aGJtTmxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1JwWnlBeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0luVnVZMnhoYVcxbFpGQnZiMnhHV0ZNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhWdVkyeGhhVzFsWkZCdmIyeEdXRk1nWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0luVnVZMnhoYVcxbFpGQnZiMnhHV0ZNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR0oxY25rZ013b2dJQ0FnWWlCamIyeHNaV04wVW1Wa1pXMXdkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHY21GNFVHOXZiQzV5WldOdmJHeGhkR1Z5WVd4cGVtVkdVa0ZZVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmpiMnhzWVhSbGNtRnNhWHBsUmxKQldEb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlEVUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNelFnTHk4Z0luSmxZMjlzYkdGMFpYSmhiR2w2WlZCaGRYTmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djbVZqYjJ4c1lYUmxjbUZzYVhwbFVHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZKbFkyOXNiR0YwWlhKaGJHbDZaU0JwY3lCd1lYVnpaV1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVFvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURCaENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpYldsemMybHVaMTlrWldOcGJXRnNjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2diV2x6YzJsdVoxOWtaV05wYldGc2N5QmxlR2x6ZEhNS0NuSmxZMjlzYkdGMFpYSmhiR2w2WlVaU1FWaGZkMmhwYkdWZmRHOXdRREk2Q2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWVpQnlaV052Ykd4aGRHVnlZV3hwZW1WR1VrRllYMkZtZEdWeVgzZG9hV3hsUURZS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpSmdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQmllaUJ5WldOdmJHeGhkR1Z5WVd4cGVtVkdVa0ZZWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmlLZ29nSUNBZ1luVnllU0F6Q2dweVpXTnZiR3hoZEdWeVlXeHBlbVZHVWtGWVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnd01nb2dJQ0FnWWk4S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWWlvS0lDQWdJR0oxY25rZ01nb2dJQ0FnWWlCeVpXTnZiR3hoZEdWeVlXeHBlbVZHVWtGWVgzZG9hV3hsWDNSdmNFQXlDZ3B5WldOdmJHeGhkR1Z5WVd4cGVtVkdVa0ZZWDJGbWRHVnlYM2RvYVd4bFFEWTZDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSXFDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpUmxKQldDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1JsSkJXQ0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF6TVNBdkx5QnRaWFJvYjJRZ0ltWjRjMTl3Y21salpTZ3BkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWW5WeWVTQTRDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUExTmlBdkx5QnRaWFJvYjJRZ0luUnZkR0ZzVTNWd2NHeDVLQ2wxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJRzFsZEdodlpDQWlaMnh2WW1Gc1gyTnZiR3hoZEdWeVlXeGZjbUYwYVc4b0tYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRFUzSUM4dklHMWxkR2h2WkNBaVoyeHZZbUZzUTI5c2JHRjBaWEpoYkZaaGJIVmxLQ2wxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xtZGxkRU52Ykd4aGRHVnlZV3hRY21salpRb2dJQ0FnWkdsbklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dOUW9nSUNBZ1pHbG5JRFVLSUNBZ0lHTmhiR3h6ZFdJZ1JuSmhlRkJ2YjJ4TWFXSnlZWEo1TG1OaGJHTlNaV052Ykd4aGRHVnlZV3hwZW1WR1VrRllTVzV1WlhJS0lDQWdJSEJ2Y0FvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1blpYUkRiMnhzWVhSbGNtRnNVSEpwWTJVS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTJGc2JITjFZaUJHY21GNFVHOXZiRXhwWW5KaGNua3VZMkZzWTFKbFkyOXNiR0YwWlhKaGJHbDZaVVpTUVZoSmJtNWxjZ29nSUNBZ1luVnllU0E1Q2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVFvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE1HRUtJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSnRhWE56YVc1blgyUmxZMmx0WVd4eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnRhWE56YVc1blgyUmxZMmx0WVd4eklHVjRhWE4wY3dvS2NtVmpiMnhzWVhSbGNtRnNhWHBsUmxKQldGOTNhR2xzWlY5MGIzQkFNVEU2Q2lBZ0lDQmthV2NnT1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHSjZJSEpsWTI5c2JHRjBaWEpoYkdsNlpVWlNRVmhmWVdaMFpYSmZkMmhwYkdWQU1UVUtJQ0FnSUdScFp5QTVDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSW1DaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdKNklISmxZMjlzYkdGMFpYSmhiR2w2WlVaU1FWaGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Bb2dJQ0FnWkdsbklEZ0tJQ0FnSUdScFp5QXhNUW9nSUNBZ1lpb0tJQ0FnSUdKMWNua2dPUW9LY21WamIyeHNZWFJsY21Gc2FYcGxSbEpCV0Y5aFpuUmxjbDlwWmw5bGJITmxRREUwT2dvZ0lDQWdaR2xuSURrS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1ESUtJQ0FnSUdJdkNpQWdJQ0JpZFhKNUlERXdDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHUjFjQW9nSUNBZ1lpb0tJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHSWdjbVZqYjJ4c1lYUmxjbUZzYVhwbFJsSkJXRjkzYUdsc1pWOTBiM0JBTVRFS0NuSmxZMjlzYkdGMFpYSmhiR2w2WlVaU1FWaGZZV1owWlhKZmQyaHBiR1ZBTVRVNkNpQWdJQ0JrYVdjZ05nb2dJQ0FnWkdsbklEa0tJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WkdsMkNpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFF3SUM4dklDSmliMjUxYzE5eVlYUmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmliMjUxYzE5eVlYUmxJR1Y0YVhOMGN3b2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVoWkdRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBek9TQXZMeUFpY21WamIyeHNZWFJmWm1WbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCeVpXTnZiR3hoZEY5bVpXVWdaWGhwYzNSekNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9Mbk4xWWdvZ0lDQWdaR2xuSURrS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3ViWFZzQ2lBZ0lDQmthV2NnTndvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNWthWFlLSUNBZ0lHUnBaeUExQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZanc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMnhwY0hCaFoyVWdiR2x0YVhRZ2NtVmhZMmhsWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU52Ykd4aGRHVnlZV3hmZEc5clpXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiR3hoZEdWeVlXeGZkRzlyWlc0Z1pYaHBjM1J6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqWVd4c2MzVmlJRlJ5WVc1elptVnlTR1ZzY0dWeUxuTmhabVZVY21GdWMyWmxja1p5YjIwS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJa1pZVXlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUmxoVElHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXpNQ0F2THlCdFpYUm9iMlFnSW5CdmIyeGZiV2x1ZENoaFpHUnlaWE56TEhWcGJuUXlOVFlwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VZblY1UW1GamEwWllVMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21KMWVVSmhZMnRHV0ZNNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTXpVZ0x5OGdJbUoxZVVKaFkydFFZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdKMWVVSmhZMnRRWVhWelpXUWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRblY1WW1GamF5QnBjeUJ3WVhWelpXUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pHVWtGWUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCR1VrRllJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF6TVNBdkx5QnRaWFJvYjJRZ0ltWjRjMTl3Y21salpTZ3BkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdKOENpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzTG1kbGRFTnZiR3hoZEdWeVlXeFFjbWxqWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURJS0lDQWdJR0o4Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbUYyWVdsc1lXSnNaVVY0WTJWemMwTnZiR3hoZEVSV0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ013b2dJQ0FnWW53S0lDQWdJR1JwWnlBMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdKOENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpZV3hzYzNWaUlFWnlZWGhRYjI5c1RHbGljbUZ5ZVM1allXeGpRblY1UW1GamEwWllVd29nSUNBZ2NHOXdDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNREF3TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURNNElDOHZJQ0ppZFhsaVlXTnJYMlpsWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWW5WNVltRmphMTltWldVZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXpkV0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV0ZFd3S0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VaR2wyQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd1lRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW0xcGMzTnBibWRmWkdWamFXMWhiSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzFwYzNOcGJtZGZaR1ZqYVcxaGJITWdaWGhwYzNSekNncGlkWGxDWVdOclJsaFRYM2RvYVd4bFgzUnZjRUF6T2dvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lub2dZblY1UW1GamEwWllVMTloWm5SbGNsOTNhR2xzWlVBM0NpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nWW5WNVFtRmphMFpZVTE5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTXdvS1luVjVRbUZqYTBaWVUxOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1ESUtJQ0FnSUdJdkNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdJcUNpQWdJQ0JpZFhKNUlESUtJQ0FnSUdJZ1luVjVRbUZqYTBaWVUxOTNhR2xzWlY5MGIzQkFNd29LWW5WNVFtRmphMFpZVTE5aFpuUmxjbDkzYUdsc1pVQTNPZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtUnBkZ29nSUNBZ1pHbG5JRFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRiR2x3Y0dGblpTQnNhVzFwZENCeVpXRmphR1ZrQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ05nb2dJQ0FnWkdsbklEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKR1dGTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFWllVeUJsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTXpJZ0x5OGdiV1YwYUc5a0lDSndiMjlzWDJKMWNtNWZabkp2YlNoaFpHUnlaWE56TEhWcGJuUXlOVFlwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVkyOXNiR0YwWlhKaGJGOTBiMnRsYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWTI5c2JHRjBaWEpoYkY5MGIydGxiaUJsZUdsemRITUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCVWNtRnVjMlpsY2tobGJIQmxjaTV6WVdabFZISmhibk5tWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1MGIyZG5iR1ZOYVc1MGFXNW5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEc5bloyeGxUV2x1ZEdsdVp6b0tJQ0FnSUdKNWRHVmpJRFE1SUM4dklEQjRZelkxTlRNeU1UZzFaV1EzTUdJeVpUazVPVFF6TTJVeVpUbG1ZV014TWpSbE1EZ3pZV05pTVRObFl6RTRNMkUwWlRBMU9UUTBaR0V3TnpreU16TTNZZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1b1lYTlNiMnhsQ2lBZ0lDQmhjM05sY25RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE9DQXZMeUFpYldsdWRGQmhkWE5sWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYldsdWRGQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdKNWRHVmpJREU0SUM4dklDSnRhVzUwVUdGMWMyVmtJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFkxTUdFM05EZzJJQzh2SUcxbGRHaHZaQ0FpVFdsdWRHbHVaMVJ2WjJkc1pXUW9ZbTl2YkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xuUnZaMmRzWlZKbFpHVmxiV2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnZaMmRzWlZKbFpHVmxiV2x1WnpvS0lDQWdJR0o1ZEdWaklEVXdJQzh2SURCNFlUZzBZVFV6T0RsaFpEUXhaamxoWVdJd09ETXhZakF4WlRVek9EUmpZV1UzTm1VM1lUZG1aREE1TVRNeFl6SXdObVptTnpreU4yTXlNREZqTXpnMU53b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHY21GNFVHOXZiQzVvWVhOU2IyeGxDaUFnSUNCaGMzTmxjblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QWljbVZrWldWdFVHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ5WldSbFpXMVFZWFZ6WldRZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QWljbVZrWldWdFVHRjFjMlZrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdWbVpXTmtZamsySUM4dklHMWxkR2h2WkNBaVVtVmtaV1Z0YVc1blZHOW5aMnhsWkNoaWIyOXNLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1ZEc5bloyeGxVbVZqYjJ4c1lYUmxjbUZzYVhwbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkRzluWjJ4bFVtVmpiMnhzWVhSbGNtRnNhWHBsT2dvZ0lDQWdZbmwwWldNZ05URWdMeThnTUhnNE1URTRaV1ZpTlRJek1XRTFabVUwTURBNFlUVTFZall5T0RZd1pqWmhNR1JpTkdZMll6TmhZekEwWmpneE5ERTVNamRoT1dJelptVmtaRGcyWkRKbUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbWhoYzFKdmJHVUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRE0wSUM4dklDSnlaV052Ykd4aGRHVnlZV3hwZW1WUVlYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEpsWTI5c2JHRjBaWEpoYkdsNlpWQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdKNWRHVmpJRE0wSUM4dklDSnlaV052Ykd4aGRHVnlZV3hwZW1WUVlYVnpaV1FpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERXhJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WXpWbFlUWTVNemtnTHk4Z2JXVjBhRzlrSUNKU1pXTnZiR3hoZEdWeVlXeHBlbVZVYjJkbmJHVmtLR0p2YjJ3cElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNTBiMmRuYkdWQ2RYbENZV05yVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOW5aMnhsUW5WNVFtRmphem9LSUNBZ0lHSjVkR1ZqSURVeUlDOHZJREI0TVRBelpHRTNPV1ptTXpjMU5XWm1OMkV4TjJFMU5UZGtNamhpTnpOa016ZGpZalJrWlRCaU0yTXpZMk13TW1aaE5tTTBPR1JtTUdZek5UQTNNV1ppWmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNW9ZWE5TYjJ4bENpQWdJQ0JoYzNObGNuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXpOU0F2THlBaVluVjVRbUZqYTFCaGRYTmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZblY1UW1GamExQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdKNWRHVmpJRE0xSUM4dklDSmlkWGxDWVdOclVHRjFjMlZrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFM1ltRTJaR0kzSUM4dklHMWxkR2h2WkNBaVFuVjVZbUZqYTFSdloyZHNaV1FvWW05dmJDa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMblJ2WjJkc1pVTnZiR3hoZEdWeVlXeFFjbWxqWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnZaMmRzWlVOdmJHeGhkR1Z5WVd4UWNtbGpaVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnWW5sMFpXTWdOVE1nTHk4Z01IaGlZakpqTmpoaU9HUmpOV0pqWTJSa01qVXpOak13TnpBNE1HRTNPRFkxWVRkbE1UTXpZbVkxTkdVek1XUTBaRFEyTTJJeFlqYzBPV0kwWW1ObU1qWmtDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzTG1oaGMxSnZiR1VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURJd0lDOHZJQ0pqYjJ4c1lYUmxjbUZzVUhKcFkyVlFZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJHeGhkR1Z5WVd4UWNtbGpaVkJoZFhObFpDQmxlR2x6ZEhNS0lDQWdJR0p1ZWlCMGIyZG5iR1ZEYjJ4c1lYUmxjbUZzVUhKcFkyVmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lHSjVkR1ZqSURJM0lDOHZJQ0p3WVhWelpXUlFjbWxqWlNJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tkRzluWjJ4bFEyOXNiR0YwWlhKaGJGQnlhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QWlZMjlzYkdGMFpYSmhiRkJ5YVdObFVHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjJ4c1lYUmxjbUZzVUhKcFkyVlFZWFZ6WldRZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QWlZMjlzYkdGMFpYSmhiRkJ5YVdObFVHRjFjMlZrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU0yUTJNR1JsSUM4dklHMWxkR2h2WkNBaVEyOXNiR0YwWlhKaGJGQnlhV05sVkc5bloyeGxaQ2hpYjI5c0tTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3AwYjJkbmJHVkRiMnhzWVhSbGNtRnNVSEpwWTJWZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNamNnTHk4Z0luQmhkWE5sWkZCeWFXTmxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSWdkRzluWjJ4bFEyOXNiR0YwWlhKaGJGQnlhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbk5sZEZCdmIyeFFZWEpoYldWMFpYSnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFVHOXZiRkJoY21GdFpYUmxjbk02Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURZS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luUnBiV1ZzYjJOclgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhScGJXVnNiMk5yWDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklITmxkRkJ2YjJ4UVlYSmhiV1YwWlhKelgySnZiMnhmZEhKMVpVQXpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UTWdMeThnSW05M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWVpQnpaWFJRYjI5c1VHRnlZVzFsZEdWeWMxOWliMjlzWDJaaGJITmxRRFFLQ25ObGRGQnZiMnhRWVhKaGJXVjBaWEp6WDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0NuTmxkRkJ2YjJ4UVlYSmhiV1YwWlhKelgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9iM1FnYjNkdVpYSWdiM0lnZEdsdFpXeHZZMnNLSUNBZ0lHSjVkR1ZqSURJMklDOHZJQ0p3YjI5c1gyTmxhV3hwYm1jaUNpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURRd0lDOHZJQ0ppYjI1MWMxOXlZWFJsSWdvZ0lDQWdaR2xuSURFekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEwTVNBdkx5QWljbVZrWlcxd2RHbHZibDlrWld4aGVTSUtJQ0FnSUdScFp5QXhNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01qUWdMeThnSW0xcGJuUnBibWRmWm1WbElnb2dJQ0FnWkdsbklERXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeU5TQXZMeUFpY21Wa1pXMXdkR2x2Ymw5bVpXVWlDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklETTRJQzh2SUNKaWRYbGlZV05yWDJabFpTSUtJQ0FnSUdScFp5QTVDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBek9TQXZMeUFpY21WamIyeHNZWFJmWm1WbElnb2dJQ0FnWkdsbklEZ0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHUnBaeUF4TndvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JREV3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNd29nSUNBZ1lud0tJQ0FnSUdScFp5QXhOQW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdScFp5QTBDaUFnSUNCaWZBb2dJQ0FnWkdsbklEZ0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBeE1nb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURFMkNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCaWZBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3T0RWbU1EbGlOU0F2THlCdFpYUm9iMlFnSWxCdmIyeFFZWEpoYldWMFpYSnpVMlYwS0hWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk5sZEZCdmIyeFFZWEpoYldWMFpYSnpYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSE5sZEZCdmIyeFFZWEpoYldWMFpYSnpYMkp2YjJ4ZmJXVnlaMlZBTlFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzTG5ObGRGUnBiV1ZzYjJOclczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwVkdsdFpXeHZZMnM2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMGFXMWxiRzlqYTE5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYVcxbGJHOWphMTloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCelpYUlVhVzFsYkc5amExOWliMjlzWDNSeWRXVkFNd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2diM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lub2djMlYwVkdsdFpXeHZZMnRmWW05dmJGOW1ZV3h6WlVBMENncHpaWFJVYVcxbGJHOWphMTlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dwelpYUlVhVzFsYkc5amExOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUc5M2JtVnlJRzl5SUhScGJXVnNiMk5yQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0owYVcxbGJHOWphMTloWkdSeVpYTnpJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdRNU0yUmhOR1E1SUM4dklHMWxkR2h2WkNBaVZHbHRaV3h2WTJ0VFpYUW9ZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYzJWMFZHbHRaV3h2WTJ0ZlltOXZiRjltWVd4elpVQTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2MyVjBWR2x0Wld4dlkydGZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1Ym05dGFXNWhkR1ZPWlhkUGQyNWxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q201dmJXbHVZWFJsVG1WM1QzZHVaWEk2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaWIzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhSb1pTQmpiMjUwY21GamRDQnZkMjVsY2lCdFlYa2djR1Z5Wm05eWJTQjBhR2x6SUdGamRHbHZiZ29nSUNBZ1lubDBaV01nTXpNZ0x5OGdJbTV2YldsdVlYUmxaRTkzYm1WeUlnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGlNamd4TWpFNFlTQXZMeUJ0WlhSb2IyUWdJazkzYm1WeVRtOXRhVzVoZEdWa0tHRmtaSEpsYzNNcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNWhZMk5sY0hSUGQyNWxjbk5vYVhCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhZMk5sY0hSUGQyNWxjbk5vYVhBNkNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTXpNZ0x5OGdJbTV2YldsdVlYUmxaRTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdWIyMXBibUYwWldSUGQyNWxjaUJsZUdsemRITUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZsdmRTQnRkWE4wSUdKbElHNXZiV2x1WVhSbFpDQmlaV1p2Y21VZ2VXOTFJR05oYmlCaFkyTmxjSFFnYjNkdVpYSnphR2x3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdmQyNWxjaUJsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1F5WTJObU1qa3dJQzh2SUcxbGRHaHZaQ0FpVDNkdVpYSkRhR0Z1WjJWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltOTNibVZ5SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklETXpJQzh2SUNKdWIyMXBibUYwWldSUGQyNWxjaUlLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbWhoYzFKdmJHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BvWVhOU2IyeGxPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJuSmhlRkJ2YjJ3dWFHRnpVbTlzWlFvZ0lDQWdZbmwwWldNZ01URWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1WjJWMFVtOXNaVTFsYldKbGNrTnZkVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBVbTlzWlUxbGJXSmxja052ZFc1ME9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJREUzSUM4dklDSmZjbTlzWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURBeU1qQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF5TURBd05EQXdNRFl3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBMbXhsYm1kMGFBb2dJQ0FnY0c5d0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzTG1kbGRGSnZiR1ZOWlcxaVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSU2IyeGxUV1Z0WW1WeU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lITjNZWEFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UY2dMeThnSWw5eWIyeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZ3dNREl5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESXdNREEwTURBd05qQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRVZ1ZFcxbGNtRmliR1ZUWlhRdVlYUUtJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xtZGxkRkp2YkdWQlpHMXBibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGSnZiR1ZCWkcxcGJqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QWlYM0p2YkdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUF3ZURBd01qSXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWpBd01EUXdNREEyTURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F5SURNeUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJuSmhlRkJ2YjJ3dVozSmhiblJTYjJ4bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taM0poYm5SU2IyeGxPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJuSmhlRkJ2YjJ3dVozSmhiblJTYjJ4bENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJuSmhlRkJ2YjJ3dWNtVjJiMnRsVW05c1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsZG05clpWSnZiR1U2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1pHbG5JREVLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UY2dMeThnSWw5eWIyeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZ3dNREl5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESXdNREEwTURBd05qQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ01pQXpNZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1b1lYTlNiMnhsQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV05qWlhOelEyOXVkSEp2YkRvZ2MyVnVaR1Z5SUcxMWMzUWdZbVVnWVc0Z1lXUnRhVzRnZEc4Z2NtVjJiMnRsQ2lBZ0lDQmpZV3hzYzNWaUlGOXlaWFp2YTJWU2IyeGxDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VjbVZ1YjNWdVkyVlNiMnhsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnViM1Z1WTJWU2IyeGxPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdSMWNBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk5sYzNORGIyNTBjbTlzT2lCallXNGdiMjVzZVNCeVpXNXZkVzVqWlNCeWIyeGxjeUJtYjNJZ2MyVnNaZ29nSUNBZ1kyRnNiSE4xWWlCZmNtVjJiMnRsVW05c1pRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xtTnZiR3hoZEY5bGRHaGZiM0poWTJ4bFgyRmtaSEpsYzNOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMnhzWVhSZlpYUm9YMjl5WVdOc1pWOWhaR1J5WlhOek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUTBJQzh2SUNKamIyeHNZWFJmWlhSb1gyOXlZV05zWlY5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjJ4c1lYUmZaWFJvWDI5eVlXTnNaVjloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xtMXBiblJwYm1kZlptVmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldsdWRHbHVaMTltWldVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01qUWdMeThnSW0xcGJuUnBibWRmWm1WbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdGFXNTBhVzVuWDJabFpTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1Y21Wa1pXMXdkR2x2Ymw5bVpXVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldSbGJYQjBhVzl1WDJabFpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXlOU0F2THlBaWNtVmtaVzF3ZEdsdmJsOW1aV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEpsWkdWdGNIUnBiMjVmWm1WbElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHY21GNFVHOXZiQzVpZFhsaVlXTnJYMlpsWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSjFlV0poWTJ0ZlptVmxPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRE00SUM4dklDSmlkWGxpWVdOclgyWmxaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZblY1WW1GamExOW1aV1VnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xuSmxZMjlzYkdGMFgyWmxaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyOXNiR0YwWDJabFpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXpPU0F2THlBaWNtVmpiMnhzWVhSZlptVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnlaV052Ykd4aGRGOW1aV1VnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xuVnVZMnhoYVcxbFpGQnZiMnhEYjJ4c1lYUmxjbUZzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3c2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkVzVqYkdGcGJXVmtVRzl2YkVOdmJHeGhkR1Z5WVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhWdVkyeGhhVzFsWkZCdmIyeERiMnhzWVhSbGNtRnNJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1MWJtTnNZV2x0WldSUWIyOXNSbGhUVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RXNWpiR0ZwYldWa1VHOXZiRVpZVXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpZFc1amJHRnBiV1ZrVUc5dmJFWllVeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkVzVqYkdGcGJXVmtVRzl2YkVaWVV5QmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1Y0c5dmJGOWpaV2xzYVc1blczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjRzl2YkY5alpXbHNhVzVuT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURJMklDOHZJQ0p3YjI5c1gyTmxhV3hwYm1jaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhCdmIyeGZZMlZwYkdsdVp5QmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1Y0dGMWMyVmtVSEpwWTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdZWFZ6WldSUWNtbGpaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF5TnlBdkx5QWljR0YxYzJWa1VISnBZMlVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEJoZFhObFpGQnlhV05sSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNWliMjUxYzE5eVlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW05dWRYTmZjbUYwWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBME1DQXZMeUFpWW05dWRYTmZjbUYwWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWW05dWRYTmZjbUYwWlNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VjbVZrWlcxd2RHbHZibDlrWld4aGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWkdWdGNIUnBiMjVmWkdWc1lYazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOREVnTHk4Z0luSmxaR1Z0Y0hScGIyNWZaR1ZzWVhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhKbFpHVnRjSFJwYjI1ZlpHVnNZWGtnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xtMXBiblJRWVhWelpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0YVc1MFVHRjFjMlZrT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFNElDOHZJQ0p0YVc1MFVHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ0YVc1MFVHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VjbVZrWldWdFVHRjFjMlZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmtaV1Z0VUdGMWMyVmtPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREU1SUM4dklDSnlaV1JsWlcxUVlYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEpsWkdWbGJWQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbkpsWTI5c2JHRjBaWEpoYkdsNlpWQmhkWE5sWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZMjlzYkdGMFpYSmhiR2w2WlZCaGRYTmxaRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF6TkNBdkx5QWljbVZqYjJ4c1lYUmxjbUZzYVhwbFVHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ5WldOdmJHeGhkR1Z5WVd4cGVtVlFZWFZ6WldRZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHY21GNFVHOXZiQzVpZFhsQ1lXTnJVR0YxYzJWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZblY1UW1GamExQmhkWE5sWkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBek5TQXZMeUFpWW5WNVFtRmphMUJoZFhObFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1luVjVRbUZqYTFCaGRYTmxaQ0JsZUdsemRITUtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xtTnZiR3hoZEdWeVlXeFFjbWxqWlZCaGRYTmxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OdmJHeGhkR1Z5WVd4UWNtbGpaVkJoZFhObFpEb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXlNQ0F2THlBaVkyOXNiR0YwWlhKaGJGQnlhV05sVUdGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmpiMnhzWVhSbGNtRnNVSEpwWTJWUVlYVnpaV1FnWlhocGMzUnpDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNXZkMjVsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtOTNibVZ5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2IzZHVaWElnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VibTl0YVc1aGRHVmtUM2R1WlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHViMjFwYm1GMFpXUlBkMjVsY2pvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBek15QXZMeUFpYm05dGFXNWhkR1ZrVDNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHNXZiV2x1WVhSbFpFOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbUYyWVdsc1lXSnNaVVY0WTJWemMwTnZiR3hoZEVSV0tDa2dMVDRnWW5sMFpYTTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzTG1GMllXbHNZV0pzWlVWNFkyVnpjME52Ykd4aGRFUldPZ29nSUNBZ2NISnZkRzhnTUNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lrWlNRVmdpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRVpTUVZnZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ05UWWdMeThnYldWMGFHOWtJQ0owYjNSaGJGTjFjSEJzZVNncGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ01UWWdMeThnYldWMGFHOWtJQ0puYkc5aVlXeGZZMjlzYkdGMFpYSmhiRjl5WVhScGJ5Z3BkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUExTnlBdkx5QnRaWFJvYjJRZ0ltZHNiMkpoYkVOdmJHeGhkR1Z5WVd4V1lXeDFaU2dwZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV01nTWpFZ0x5OGdNSGd3WmpReU5EQUtJQ0FnSUdJK0NpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNWhkbUZwYkdGaWJHVkZlR05sYzNORGIyeHNZWFJFVmw5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbUYyWVdsc1lXSnNaVVY0WTJWemMwTnZiR3hoZEVSV1gyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1dGRXd0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtUnBkZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JpUEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJuSmhlRkJ2YjJ3dVlYWmhhV3hoWW14bFJYaGpaWE56UTI5c2JHRjBSRlpmWld4elpWOWliMlI1UURjS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1emRXSUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJsaFRMbk52YkM1R2NtRjRVRzl2YkM1aGRtRnBiR0ZpYkdWRmVHTmxjM05EYjJ4c1lYUkVWbDlsYkhObFgySnZaSGxBTnpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzTG1kbGRFTnZiR3hoZEdWeVlXeFFjbWxqWlNncElDMCtJR0o1ZEdWek9nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHY21GNFVHOXZiQzVuWlhSRGIyeHNZWFJsY21Gc1VISnBZMlU2Q2lBZ0lDQndjbTkwYnlBd0lERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlEUUtJQ0FnSUdKNWRHVmpJREl3SUM4dklDSmpiMnhzWVhSbGNtRnNVSEpwWTJWUVlYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052Ykd4aGRHVnlZV3hRY21salpWQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VaMlYwUTI5c2JHRjBaWEpoYkZCeWFXTmxYMlZzYzJWZlltOWtlVUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWpjZ0x5OGdJbkJoZFhObFpGQnlhV05sSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ3WVhWelpXUlFjbWxqWlNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNW5aWFJEYjJ4c1lYUmxjbUZzVUhKcFkyVmZaV3h6WlY5aWIyUjVRREk2Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVJsSkJXQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSbEpCV0NCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ05UUWdMeThnYldWMGFHOWtJQ0psZEdoZmRYTmtYM0J5YVdObEtDbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE1HRUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW0xcGMzTnBibWRmWkdWamFXMWhiSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2diV2x6YzJsdVoxOWtaV05wYldGc2N5QmxlR2x6ZEhNS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbWRsZEVOdmJHeGhkR1Z5WVd4UWNtbGpaVjkzYUdsc1pWOTBiM0JBTkRvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1WjJWMFEyOXNiR0YwWlhKaGJGQnlhV05sWDJGbWRHVnlYM2RvYVd4bFFEZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdXRk11YzI5c0xrWnlZWGhRYjI5c0xtZGxkRU52Ykd4aGRHVnlZV3hRY21salpWOWhablJsY2w5cFpsOWxiSE5sUURjS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1lpb0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1WjJWMFEyOXNiR0YwWlhKaGJGQnlhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF5Q2lBZ0lDQmlMd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JpS2dvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R1dGTXVjMjlzTGtaeVlYaFFiMjlzTG1kbGRFTnZiR3hoZEdWeVlXeFFjbWxqWlY5M2FHbHNaVjkwYjNCQU5Bb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1WjJWMFEyOXNiR0YwWlhKaGJGQnlhV05sWDJGbWRHVnlYM2RvYVd4bFFEZzZDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ016Y2dMeThnSW5kbGRHaGZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2QyVjBhRjloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW5sMFpXTWdNakVnTHk4Z01IZ3daalF5TkRBS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmlLZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNellnTHk4Z0ltTnZiR3hoZEVWMGFFOXlZV05zWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWTI5c2JHRjBSWFJvVDNKaFkyeGxJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUExTlNBdkx5QnRaWFJvYjJRZ0ltTnZibk4xYkhRb1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBd01EQUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbTExYkFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VhR0Z6VW05c1pTaHliMnhsT2lCaWVYUmxjeXdnWVdOamIzVnVkRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWllVeTV6YjJ3dVJuSmhlRkJ2YjJ3dWFHRnpVbTlzWlRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0pmY205c1pYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE1EQXlNakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeU1EQXdOREF3TURZd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlFVnVkVzFsY21GaWJHVlRaWFF1WTI5dWRHRnBibk1LSUNBZ0lIQnZjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaWVV5NXpiMnd1Um5KaGVGQnZiMnd1WjNKaGJuUlNiMnhsS0hKdmJHVTZJR0o1ZEdWekxDQmhZMk52ZFc1ME9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VaM0poYm5SU2IyeGxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVGNnTHk4Z0lsOXliMnhsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGd3TURJeU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREl3TURBME1EQXdOakF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF6TWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbGhUTG5OdmJDNUdjbUY0VUc5dmJDNW9ZWE5TYjJ4bENpQWdJQ0JoYzNObGNuUWdMeThnUVdOalpYTnpRMjl1ZEhKdmJEb2djMlZ1WkdWeUlHMTFjM1FnWW1VZ1lXNGdZV1J0YVc0Z2RHOGdaM0poYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOW5jbUZ1ZEZKdmJHVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHV0ZNdWMyOXNMa1p5WVhoUWIyOXNMbDluY21GdWRGSnZiR1VvY205c1pUb2dZbmwwWlhNc0lHRmpZMjkxYm5RNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZlozSmhiblJTYjJ4bE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UY2dMeThnSWw5eWIyeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBd2VEQXdNakl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01qQXdNRFF3TURBMk1EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwTG1Ga1pBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpZWlCZlozSmhiblJTYjJ4bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhpTjJabVpXSm1PQ0F2THlCdFpYUm9iMlFnSWxKdmJHVkhjbUZ1ZEdWa0tHSjVkR1ZiTXpKZExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b0tYMmR5WVc1MFVtOXNaVjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QXdlREF3TWpJd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNakF3TURRd01EQTJNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXlJRE15Q2lBZ0lDQmllWFJsWXlBMU9DQXZMeUF3ZURBd01qSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFpZVXk1emIyd3VSbkpoZUZCdmIyd3VYM0psZG05clpWSnZiR1VvY205c1pUb2dZbmwwWlhNc0lHRmpZMjkxYm5RNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZmNtVjJiMnRsVW05c1pUb0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKZmNtOXNaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZ3dNREl5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESXdNREEwTURBd05qQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdSVzUxYldWeVlXSnNaVk5sZEM1eVpXMXZkbVVLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1lub2dYM0psZG05clpWSnZiR1ZmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQTJZMlV4TXpoaUlDOHZJRzFsZEdodlpDQWlVbTlzWlZKbGRtOXJaV1FvWW5sMFpWc3pNbDBzWVdSa2NtVnpjeXhoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2dwZmNtVjJiMnRsVW05c1pWOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBd2VEQXdNakl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01qQXdNRFF3TURBMk1EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBeUlETXlDaUFnSUNCaWVYUmxZeUExT0NBdkx5QXdlREF3TWpJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12UmxoVExuTnZiQzVHY21GNFVHOXZiQzVqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRkFDQUJCc0NFUFNZN0FBRUJCQlVmZkhVZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFUmxKQldCQmpiMnhzWVhSbGNtRnNYM1J2YTJWdUVHMXBjM05wYm1kZlpHVmphVzFoYkhNWGRXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dRZEdsdFpXeHZZMnRmWVdSa2NtVnpjd0VLQVFJQkFDd0FJZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUFCQUFHQUFBQUFBVnZkMjVsY2dOR1dGTVFkVzVqYkdGcGJXVmtVRzl2YkVaWVV3VHNOazQwQmw5eWIyeGxjd3B0YVc1MFVHRjFjMlZrREhKbFpHVmxiVkJoZFhObFpCVmpiMnhzWVhSbGNtRnNVSEpwWTJWUVlYVnpaV1FERDBKQUdISmxaR1ZsYlVOdmJHeGhkR1Z5WVd4Q1lXeGhibU5sY3hGeVpXUmxaVzFHV0ZOQ1lXeGhibU5sY3d0dGFXNTBhVzVuWDJabFpRNXlaV1JsYlhCMGFXOXVYMlpsWlF4d2IyOXNYMk5sYVd4cGJtY0xjR0YxYzJWa1VISnBZMlVoQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCSU82MTh3RUV6SitLQVJzU3l2UEJNZkJELzRPYm05dGFXNWhkR1ZrVDNkdVpYSVZjbVZqYjJ4c1lYUmxjbUZzYVhwbFVHRjFjMlZrRFdKMWVVSmhZMnRRWVhWelpXUVBZMjlzYkdGMFJYUm9UM0poWTJ4bERIZGxkR2hmWVdSa2NtVnpjd3RpZFhsaVlXTnJYMlpsWlF4eVpXTnZiR3hoZEY5bVpXVUtZbTl1ZFhOZmNtRjBaUkJ5WldSbGJYQjBhVzl1WDJSbGJHRjVDRjlwYm1SbGVHVnpER3hoYzNSU1pXUmxaVzFsWkJsamIyeHNZWFJmWlhSb1gyOXlZV05zWlY5aFpHUnlaWE56RGw5ZlkzUnZjbDl3Wlc1a2FXNW5FbU52Ykd4aGRHVnlZV3hmWVdSa2NtVnpjeFZtY21GNFgyTnZiblJ5WVdOMFgyRmtaSEpsYzNNVVpuaHpYMk52Ym5SeVlXTjBYMkZrWkhKbGMzTWd4bFV5R0Y3WEN5NlpsRFBpNmZyQkpPQ0RyTEUrd1lPazRGbEUyZ2VTTTNzZ3FFcFRpYTFCK2Fxd2d4c0I1VGhNcm5ibnAvMEpFeHdnYi9lU2ZDQWNPRmNnZ1JqdXRTTWFYK1FBaWxXMktHRDJvTnRQYkRyQVQ0RkJrbnFiUCszWWJTOGdFRDJubi9OMVgvZWhlbFY5S0xjOU44dE40TFBEekFMNmJFamZEelVISDc4Z3V5eG91Tnhiek4wbE5qQndnS2VHV240VE8vVk9NZFRVWTdHM1NiUzg4bTBFckZldG9nUXRNZnkxQkhuNnRHVUVuY1NUaVFJQUlqRVlRQUIvSncwclp5Y2hLMmNuQlN0bkp5NHJaeWN2SzJjbk1DdG5Kd2dyWnljT0syY25CQ3RuSnlRclp5Y3NLMmNuSlN0bkp4Z29aeWNaS0djbkppaG5KeWNvWnljSEtHY25EeWhuSndZb1p5SVdKeHBMQVdjbkcweG5nY3c2Rmljb1RHY2tGaWNwVEdjbkVpSm5KeE1pWnljaUltY25JeUpuSnhRaVp5Y3RKR2NrUXpFWkZFUXhHRVNDTUFSdU5oekRCUEczN2RnRTZ3RWFVd1I0NFN1c0JIVXRJZDBFTDNrMGh3U0x4QnJDQkx2d3dQMEVvODNzSlFSNk1hNjJCRHNISjJvRUJnZWFYZ1FPRjJ2eEJFWHRwVmdFTFBPdytBVCt5OU0xQkRhTDM4a0VTYkdsb2dTNVVybWtCSk9xanQwRXF2dXdpd1E2MDZFREJOVWgxZ1FFV0trUUtBUU9IRXVnQkNSZGYxa0VaeWljZlFRVUhFOFlCSU1OWUxFRW5rbUM3UVJaVnlUbUJHT2cwNlVFcVFXSTJRUWJUZ3lXQks4WTNSc0VVaktOcXdTL1puMmNCTmZ2OXpBRUdHRTIvQVNXZHErMUJDRCtRcklFdDlUME5nUng3cEhHQkNzYzYyQUVQSmxBUEFRT0dObUNCTEc3c0tnRWZTODFYRFlhQUk0d0ExSUVod1lrQmpVR1JnYUZCNFlJVFFvRUN5Z05HdzRrRHUwUVlCRmJFWDhSb3hISEVlc1NMUk1rRTFzVGZCT2pFOElUN2hRY0ZEZ1VUUlI0RkpJVW5SU3dGTU1VMWhUcEZQd1ZEeFVpRlRVVlNCVmJGV3dWZlJXT0ZaOFZzQlc3QUlvQ0FvditpLytJQU1TTS9rQUFLNHYrSWxtTC9vRUNXWXYrVGdKU2dRSWlXRW1MLzFCSUZTTUtGb3YvQVNjcVRGQkp2RWhNdnlTTC9va2lpLzZKaWdJQ2kvOEJKeXBNVUVtK0tFNENUVWtvcVVFQWNvc0JKeHlnS2FFbkhLcUwvaUpaaS82QkFsbUwvazRDVW9FQ0lsaEpGVWtqQ2hZbkhLQXBvU2NjcW9FSXIwbFBBbEJKRllFSUNWc2pDMHNEVENOWVRFc0VVRWtWZ1FnSld5TUxTd05NU3dKZFNFOERLYUJNQVNjcVRGQkp2RWhNdnlNSklreFNTSXNBdkVna2kvNVBBMDhEaVNLTC9rOERUd09KaWdJQ2kvOEJKeXBNVUw0b1RnSk5LS21ML29tS0FRS0wveUpaaS8rQkFsbUwvMDRDVW9FQ0lsZ1ZJd29XaS8rSmlnSUNpLzRpV1l2K2dRSlppLzVPQWxLQkFpSllTUlVqQ2hhTC82VkVnUWl2aS85UVNSV0JDQWxiSXdzaldJditpWW9DQTR2K0lsbUwvaFdML2s0Q1Vvdi9pUDY5U0l2K1NZbUtBZ09ML2lKWmkvNFZpLzVPQWxLTC80ais0a2lML2ttSmlnSUNpLzRpV1l2K0ZZditUZ0pTaS8rSS8xbElpLzZKaWdFQ2kvOGlXWXYvRll2L1RnSlNpUDlYU0l2L2lZb0NBb3YrSWxtTC9oV0wvazRDVW92L2lQOWJTSXYraVlvQ0FZdi9pLzZJQVVnaEJCYUlBVjJKaWdJQmkvK0wvb2dCTnlFRUZvZ0JUSW1LQVFPTC8xZGdJSXYvVnlBZ2lBRWdJUVFXVEVzQmlBRXlTVXNDaUFFUmkvOVhnQ0NJQVNSTEFZZ0F4RWxQQTRnQS9vdi9Wd0FnaUFFUlRnS0lBS05NaS8rSmlnSUJJUVFXaS85TWlBRGhpLzZJQVBlSmlnRUNpLzlYQUNCSktLVkVpLzlYWUNDTC8xY2dJSWdBd2lFRUZreExBWWdBMUVsUEE2WkVUSWdBc0l2L1YwQWdpQUREaS8rSmlnVUNpL3VML0lnQW15RUVGa2xQQWtzQmlBQ3JTVThDaS8xTEFZZ0Fob3YraUFDY2kvK0wvb2dBZW92K1R3S0lBSE9JQURCTWlBQ0hTVTRDcGtFQUVvc0JTWXNBaUFCZGkveUlBSE9NQUl3QmlZc0NRdi9yaWdJQmkvNkwvNkJKaS82blJJbUtBZ0dML292L2dCNVRZV1psVFdGMGFEb2djM1ZpZEhKaFkzUnBiMjRnYjNabGNtWnNiM2VJQUFHSmlnTUJpLzZML2FaRWkvMG5IS0NML3FFbkhLcUppZ0lCaS80b3FFRUFBeUlXaVl2K2kvK2pTWXYrb292L3FFU0ppZ0lCaS82TC80QWFVMkZtWlUxaGRHZzZJR1JwZG1semFXOXVJR0o1SUhwbGNtK0lBQUdKaWdNQmkvNG9wVVNML1l2K29vbUtBd0NKaWdRQWlUWWFBVWNDRlNNU1JEWWFBa2xPQWhVakVrUTJHZ05KVGdJVkl4SkVOaG9FU1JVakVrUTJHZ1ZKVGdNVkl4SkVOaG9HU1U0REZTTVNSQ2N0WkVRbkxTSm5TU3NUU1U0RFJDY05Td0ZuZ0NUU3pQS1FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCTVVMQXJFMEVBdGtzRUt4TkJBSzlMQXlzVFFRQ29TVUVBcEVzQ0t4TkJBSjBrUkNjRVN3WkpUZ0puSnc1TEJrbE9BMmNuTDB4bkp6Qk1aeWN1U3dSSlRnSm5Kd2hMQkdjbkJVeG5KeHBMQW1leElpY0ZaVVNCR0ZzbHNoQWlzaGtpc2dHeUdJQUV1SGVlNTdJYXM0RVNGclErVndRQUZ4YUkvbm9uQmt4bkt6RUFpQkx5SWljSVpVUW5NVXlJRXNZaUp3aGxSQ2N5VElnU3V5SW5DR1ZFSnpOTWlCS3dJaWNJWlVRbk5FeUlFcVVpSndobFJDYzFUSWdTbWlSRElrTC9ZQ0pIRENjVVpVUWtFa0VBZ2JFeUNpSW5CV1ZFZ1JoYkpiSVFJcklaSXJJQnNoZ25IYklhc2hxektVVUdKd2xGRENJbkJtVk1SUXBFU3dnb3BVRUFJRXNJS2F3b3FVRUFCMHNGU3d5alJRWkxDQ2NLb2tVSlN3dEpvMFVNUXYvWnRENVhCQUFpSndkbFJJajl4MHNHaVA0Q0lpY2JaVVNJL2ZvaEJCYUkvZzlKRlNNT1JDT3ZxeXBNVUxBa1E3RWlKd1JsUklFWVd5V3lFQ0t5R1NLeUFiSVlKemF5R3JPMFBsY0VBRVVDS1VVRkp3bEZDeUluQm1WTVJRbEVTd2NvcFVFQUlFc0hLYXdvcVVFQUIwc0VTd3VqUlFWTEJ5Y0tva1VJU3dwSm8wVUxRdi9ac1NJbkpXVkVJNjhuRlVzSG8xQkpGU01KSTFnaUp5UmxSSUVZV3lXeUVDS3lHU0t5QWJJWUp6ZXlHa3l5R3JJYXM3UStWd1FBSVFRV1NVVURTd05NaVAxT1RJajlaVVVEc1RJS0lpY0ZaVVNCR0ZzbHNoQWlzaGtpc2dHeUdDY2RzaHF5R3JNcFJRUW5DVVVLSWljR1pVeEZDRVJMQmlpbFFRQWdTd1lwckNpcFFRQUhTd05MQ3FORkJFc0dKd3FpUlFkTENVbWpSUXBDLzltMFBsY0VBQ0luQjJWRWlQeW9Td1NJL09OTEE0ajgza3NCaVB6MFF2N2lpQStmU1JVakRrUWpyNnNxVEZDd0pFT0lFQk5KRlNNT1JDT3ZxeXBNVUxBa1F6WWFBVWtWSXhKRU5ob0NTUlVqRWtReEFDSW5DR1ZFRWtBQUN6RUFJaWNOWlVRU1FRQVZKRVFuTEVzQ1NVNENaeWNrVEdjbkpVc0JaeVJESWtMLzZEWWFBVWtWSXhKRU5ob0NTUlVqRWtRaUp4SmxSQlJFS1NjSklpY0daVVJKS0tWQkFCNUpLYXdvcVVFQUIwc0NTd0tqUlFOSkp3cWlSUUZMQVVtalJRSkMvOXhMQkVsTEJLT3hJaWNFWlVTQkdGc2xzaEFpc2hraXNnR3lHQ2NRc2hxenRENVhCQUFuRmFkRXNUSUtJaWNGWlVTQkdGc2xzaEFpc2hraXNnR3lHQ2Nkc2hxeUdyTzBQbGNFQUNJbkIyVkVpUHVnU3dLSSs0MGlKeHBsUktaRWlBOGlUSWo2ZXlFRUZpSW5HR1ZFU3dGTWlQdC9Ud0pNaVB1NVRJajcwRXNGU3dHbVJDSW5CV1ZFTVFBeUNrOEVpUHYxc1RFQUk2OVBBbEJKRlNNSkkxZ2lKd1JsUklFWVd5V3lFQ0t5R1NLeUFiSVlKeDZ5R2t5eUdySWFzeVJETmhvQlNSVWpFa1EyR2dKSkZTTVNSQ0luRW1WRUZFU3hJaWNFWlVTQkdGc2xzaEFpc2hraXNnRkpzaGduSDdJYXM3UStWd1FBc1NXeUVDS3lHU0t5QVVzQnNoZ25FTElhczdRK1Z3UUFLS2hFU3dPSStkMGhCQllpSnhobFJFc0JUSWo2MEU4Q1RJajdDa3lJK3lGUEFrc0Jwa1N4TVFBanIwbFBCVkJKRlNNSkkxZ2lKdzVsUklFWVd5V3lFQ0t5R1NLeUFiSVlKeUN5R2s4Q3NocXlHck94TVFCTVR3SlFTUlVqQ1NOWUpiSVFJcklaSXJJQlR3S3lHQ2Nlc2hwTXNocXlHck1rUXlKSEFqWWFBVWtWSXhKRU5ob0NTUlZKSXhKRU5ob0RTUlVqRWtRaUp4SmxSQlJFc1NJbkJHVkVnUmhiSmJJUUlySVpJcklCU2JJWUp4K3lHck8wUGxjRUFFeXhKYklRSXJJWklySUJzaGduRUxJYXM3UStWd1FBU1NjVnBFRUJVMGtvcFVFQlRTUkVzVElLSWljRlpVU0JHRnNsc2hBaXNoa2lzZ0d5R0NjZHNocXlHck8wUGxjRUFDSW5CMlZFaVBuYlN3YUkrY2dpSnhwbFJLWkVLVVVISndsRkNTSW5CbVZNUlFsRVN3Y29wVUVBSUVzSEthd29xVUVBQjBzR1N3bWpSUWRMQnljS29rVUlTd2hKbzBVSlF2L1pTd1ZKU3dpamlBMGhTUlVqRGtRanIweExBYXRMQkVrVkl3NUVTd0tyU3dNVkl3NUVUd05MQTZ0TENDTU9SRXNKU1U0RlN3U3JTd2hKRlNNT1JFc0ZxMDhFVUV4UVRGQk1VSWo0WFU0Q1NFeUkrRlpJVGdKSUlRUVdJaWNZWlVSTEFVeUkrVFJQQWt5SStXNU1pUG1GU3dkTEFhWkVTd0ZQQktaRXNURUFTd05QQTFCSkZTTUpJMWdpSnc1bFJJRVlXeVd5RUNLeUdTS3lBYklZSnlDeUdreXlHcklhc3lJbkJXVkVNUUF5Q2s4RmlQbDVzVEVBVGdKUVNSVWpDU05ZSWljRVpVU0JHRnNsc2hBaXNoa2lzZ0d5R0NjZXNocE1zaHF5R3JNa1F5SkMvckEyR2dGSkZTTVNSRFlhQWtrVkl4SkVJaWNUWlVRVVJMRWlKd1JsUklFWVd5V3lFQ0t5R1NLeUFiSVlKeEN5R3JPMFBsY0VBQ2NWcUVRcEp3a2lKd1psUkVrb3BVRUFIa2twckNpcFFRQUhTd0pMQXFORkEwa25DcUpGQVVzQlNhTkZBa0wvM0VzRVNVc0VpUGlraUF2WFRJajNsU0VFRmlJbkdXVkVTd0ZNaVBnMFR3Sk1pUGh1VElqNGhiRXlDaUluQldWRWdSaGJKYklRSXJJWklySUJzaGduSGJJYXNocXp0RDVYQkFBaUp3ZGxSRXhMQVlqMy9Vc0NwMFJMQmtzQ3BrUXhBQUVuRmt4UXZpaE9BazFMQW9qMzFERUFBU2NXVEZCSnZFaE12MHlJOThRbkIweG5NZ1lXTVFBQkp5dE1VRW04U0V5L3NURUFJNjlQQWxCSkZTTUpJMWdpSndSbFJJRVlXeVd5RUNLeUdTS3lBYklZSnlDeUdreXlHcklhc3lSRElrY0dOaG9CU1JVakVrUTJHZ0pKRlNNU1JEWWFBMGtWSXhKRUlpY1RaVVFVUkxFaUp3UmxSSUVZV3lXeUVDS3lHU0t5QVVteUdDY2ZzaHF6dEQ1WEJBQk1zU1d5RUNLeUdTS3lBYklZSnhDeUdyTzBQbGNFQUVrbkZhUkJBWkJKS0tWQkFZb2tSSWdLdVVVSUlRUVdTVVVISWljWlpVUkxBVXlJOXhWTEJreUk5MDlMQVlqM1pVbEZEa2xMQTRqM1FVc0NpUGRYaVBiNVRJajNOVXNDaVBkTFJRY3BSUWtuQ1VVTElpY0daVXhGQzBSTENTaWxRUUFnU3drcHJDaXBRUUFIU3doTEM2TkZDVXNKSndxaVJRcExDa21qUlF0Qy85bExDMHNKaVBjTVN3R0k5dXhMQmtsT0FvajIvMHlJOXVCTENJajI5ckV5Q2lJbkJXVkVnUmhiSmJJUUlySVpJcklCc2hnbkhiSWFzaHF6dEQ1WEJBQWlKd2RsUkV4TEFZajJia3NDcDBSTEJFc0Nwa1JMQlVzSlNVNEVwa1F4QUFFbkZreFF2aWhPQWsxTEFvajJQREVBQVNjV1RGQkp2RWhNdjB5STlpd25CMHhuTVFBQkp4ZE1VTDRvVGdKTlN3R0k5aGN4QUFFbkYweFFTYnhJVEw4aUp3OWxSRXNCaVBZQkp3OU1aeklHRmpFQUFTY3JURkJKdkVoTXY3RXhBQ092U1VzSVVFa1ZJd2tqV0NJbkJHVkVnUmhiSmJJUUlySVpJcklCc2hnbklMSWFUd0t5R3JJYXM3RXlDa3hQQWxCSkZTTUpJMWdpSnc1bFJJRVlXeVd5RUNLeUdTS3lBYklZSng2eUdreXlHcklhc3lSRElrTCtjellhQVVrVkl4SkVOaG9DU1JVakVrUWlKeE5sUkJSRXNTSW5CR1ZFZ1JoYkpiSVFJcklaSXJJQlNiSVlKeCt5R3JPMFBsY0VBTEVsc2hBaXNoa2lzZ0ZNc2hnbkVMSWFzN1ErVndRQUtLaEVJUVFXSWljWlpVUkxBVXlJOVVGTEJFeUk5WHRMQVlqMWtVeUk5WEpNaVBXSk1RQUJKeGRNVUw0b1RnSk5Td0dJOVE4eEFBRW5GMHhRU2J4SVRMOGlKdzlsUkVzQmlQVDVKdzlNWnpJR0ZqRUFBU2NyVEZCSnZFaE12MHhMQWFaRXNURUFJNjlKVHdSUVNSVWpDU05ZSWljRVpVU0JHRnNsc2hBaXNoa2lzZ0d5R0NjZ3NocFBBcklhc2hxenNUSUtURThDVUVrVkl3a2pXQ0luRG1WRWdSaGJKYklRSXJJWklySUJzaGduSHJJYVRMSWFzaHF6SkVNaVNURUFBU2NyVEZDK0tFNENUU0luS1dWRWlQUnlNZ1lXcGtRaVJ3SVdNUUFCSnhkTVVMNG9UZ0pOS0tWQUFHcEpSUVF4QUFFbkZreFF2aWhPQWswb3BVQUFKMGxGQlVzQ1FRQU1JaWNPWlVReEFFc0ZpUFRPU3dGQkFBd2lKd1ZsUkRFQVN3YUk5TDBrUXpFQUFTY1dURkMrS0U0Q1RVbEZCakVBQVNjV1RGQkp2RWhMQXI4aUp3ZGxSRXlJOUFZbkIweG5KRVVDUXYrdE1RQUJKeGRNVUw0b1RnSk5TVVVGTVFBQkp4ZE1VRW04U0VzQ3Z5SW5EMlZFVElqejF5Y1BUR2NrUlFOQy8yb2lSd1UyR2dGSkZTTVNSRFlhQWtrVkl4SkVJaWNpWlVRVVJDa25DU0luQm1WRVNTaWxRUUFlU1Ntc0tLbEJBQWRMQWtzQ28wVURTU2NLb2tVQlN3RkpvMFVDUXYvY1N3UkxBNk94SWljRVpVU0JHRnNsc2hBaXNoa2lzZ0ZKc2hnbkg3SWFzN1ErVndRQVJRaXhKYklRSXJJWklySUJTYklZSnppeUdyTzBQbGNFQUxFbHNoQWlzaGtpc2dGTEFiSVlKeEN5R3JPMFBsY0VBTEVsc2hBaXNoa2lzZ0ZQQXJJWUp6bXlHck8wUGxjRUFJZ0dxRXNFVEVzQ1N3VkxCWWp5cGtoRkM0Z0dsazhFVEU4Q1R3UlBCSWp5bEVVSlNDbEZDU2NKUlFzaUp3WmxURVVMUkVzSktLVkJBQ0JMQ1Ntc0tLbEJBQWRMQ0VzTG8wVUpTd2tuQ3FKRkNrc0tTYU5GQzBMLzJVc0dTd21JOHhRaEJCWWlKeWhsUklqeW9DSW5KMlZFaVBLbVN3bE1pUExnU3dlSTh2WkxCVXNCcGtRaUp3VmxSREVBTWdwUEJJanpHN0V4QUNPdlR3SlFTUlVqQ1NOWUlpY09aVVNCR0ZzbHNoQWlzaGtpc2dHeUdDY2VzaHBNc2hxeUdyTWtRellhQVVjQ0ZVa2pFa1EyR2dKSlRnTVZJeEpFSWljalpVUVVSTEVpSndSbFJJRVlXeVd5RUNLeUdTS3lBYklZSngreUdyTzBQbGNFQUV3akRrUWpyMGxPQTA4Q1N3R3JpQVdoU1JVakRrUkxBcXVJQlJGSkZTTU9SRXNEcTBzRUZTTU9SRThFVHdTclVFeFFURkNJOFU5SUlRUVdJaWNtWlVSTEFVeUk4ZHRQQWt5SThoVk1pUElzS1NjSklpY0daVVJKS0tWQkFCNUpLYXdvcVVFQUIwc0NTd0tqUlFOSkp3cWlSUUZMQVVtalJRSkMvOXhMQTBzRGlQSDVTd1pMQWFaRXNURUFTd1pMQ1ZCSkZTTUpJMWdpSnc1bFJJRVlXeVd5RUNLeUdTS3lBYklZSnlDeUdreXlHcklhc3lJbkJXVkVNUUJQQW9qeDhTUkRKekV4QUlnRm0wUWlKeEpsUkJRbkVrc0JaeWNMSWs4Q1ZJQUVaUXAwaGt4UXNDUkRKekl4QUlnRmQwUWlKeE5sUkJRbkUwc0JaeWNMSWs4Q1ZJQUU3K3pibGt4UXNDUkRKek14QUlnRlUwUWlKeUpsUkJRbklrc0JaeWNMSWs4Q1ZJQUV4ZXBwT1V4UXNDUkRKelF4QUlnRkwwUWlKeU5sUkJRbkkwc0JaeWNMSWs4Q1ZJQUVGN3B0dDB4UXNDUkROaG9CU1JVakVrUW5OVEVBaUFVRFJDSW5GR1ZFUUFBaEp4dExBV2NpSnhSbFJCUW5GRXNCWnljTElrOENWSUFFRlQxZzNreFFzQ1JESWhZbkcweG5Rdi9iTmhvQlNSVkpJeEpFTmhvQ1NSVkpJeEpFTmhvRFNSVkpJeEpFTmhvRVNSVkpJeEpFTmhvRlNSVkpJeEpFTmhvR1NSVkpJeEpFTmhvSFNSVkpJeEpFTVFBaUp3aGxSQkpBQUFzeEFDSW5EV1ZFRWtFQW5pUkVKeHBMRGtsT0FtY25LRXNOU1U0Q1p5Y3BTd3hKVGdSbkp4aExDMGxPQkdjbkdVc0tTVTRGWnljbVN3bEpUZ0puSnlkTENFbE9CbWRMRVNNT1JDT3ZUd0pMQWF0TENpTU9SRThDU3dLclN4UWpEa1JQQTBzRHEwc09JdzVFVHdSTEJLdExDQ01PUkU4RlN3V3JTd3dqRGtSUEJrc0dxMHNRSXc1RVR3ZFBCNnRQQkU4R1VFeFFUd05RVEZCUEFsQk1VSUFFQ0Y4SnRVeFFzQ1JESWtML1h6WWFBVWtWSXhKRU1RQWlKd2hsUkJKQUFBc3hBQ0luRFdWRUVrRUFGU1JFSndoTEFVbE9BbWVBQk5rOXBObE1VTEFrUXlKQy8rZzJHZ0ZKRlNNU1JERUFJaWNOWlVRU1JDY2hTd0ZuZ0FTeWdTR0tURkN3SkVNeEFDSW5JV1ZFVEVzQkVrUWlKdzFsUkVzQlVJQUUwc3p5a0V4UXNDY05UR2NuSVN0bkpFTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRWlBTkhKd3NpVHdKVUtreFFzQ1JETmhvQlNSVWpFa1FCSnhGTVVMNG5ERTRDVFVraVdVc0JGVktJN1p0SVNSVWpEa1FqcjZzcVRGQ3dKRU0yR2dGSkZTTVNSRFlhQWtrVkl4SkVUQUVuRVV4UXZpY01UZ0pOU1NKWlN3RVZVa3lJN1h0SUtreFFzQ1JETmhvQlNSVWpFa1FCSnhGTVVMNG5ERTRDVFZjQ0lDcE1VTEFrUXpZYUFVa1ZJeEpFTmhvQ1NSVWpFa1NJQXRBa1F6WWFBVWtWSXhKRU5ob0NTUlVqRWtSTEFRRW5FVXhRdmljTVRnSk5Wd0lnTVFDSUFvdEVpQU1USkVNMkdnRkpGU01TUkRZYUFra1ZJeEpFU1RFQUVrU0lBdmtrUXlJbkxHVkVLa3hRc0NSRElpY1laVVJKRlNNT1JDT3ZxeXBNVUxBa1F5SW5HV1ZFU1JVakRrUWpyNnNxVEZDd0pFTWlKeVpsUkVrVkl3NUVJNityS2t4UXNDUkRJaWNuWlVSSkZTTU9SQ092cXlwTVVMQWtReUluQjJWRVNSVWpEa1FqcjZzcVRGQ3dKRU1pSnc5bFJFa1ZJdzVFSTYrcktreFFzQ1JESWljYVpVUkpGU01PUkNPdnF5cE1VTEFrUXlJbkcyVkVTUlVqRGtRanI2c3FURkN3SkVNaUp5aGxSRWtWSXc1RUk2K3JLa3hRc0NSRElpY3BaVVJKRlNNT1JDT3ZxeXBNVUxBa1F5SW5FbVZFSndzaVR3SlVLa3hRc0NSRElpY1RaVVFuQ3lKUEFsUXFURkN3SkVNaUp5SmxSQ2NMSWs4Q1ZDcE1VTEFrUXlJbkkyVkVKd3NpVHdKVUtreFFzQ1JESWljVVpVUW5DeUpQQWxRcVRGQ3dKRU1pSncxbFJDcE1VTEFrUXlJbklXVkVLa3hRc0NSRGlnQUJJckVpSndSbFJJRVlXeVd5RUNLeUdTS3lBVW15R0NjNHNocXp0RDVYQkFCTXNTV3lFQ0t5R1NLeUFVbXlHQ2NRc2hxenRENVhCQUJKVHdLeEpiSVFJcklaSXJJQnNoZ25PYklhczdRK1Z3UUFUQ2NWcFVFQUJTRUVGb3dDaXdHTEFvanN6U0VFRm9qczRrbU1BSXNEcEVFQUNvc0Rpd0NJN0hlTUFJa2lGb3dBaVlvQUFTSkhCQ2NVWlVRa0VrRUFDQ0luRzJWRWpBQ0pzU0luQkdWRWdSaGJKYklRSXJJWklySUJzaGduTnJJYXM3UStWd1FBakFNcGpBSW5DWXdBSWljR1pVeU1BVVNMQVNpbFFRQWdpd0VwckNpcFFRQUhpd0tMQUtPTUFvc0JKd3FpakFHTEFFbWpqQUJDLzlteElpY2xaVVFqcnljVml3S2pVRWtWSXdraldDSW5KR1ZFZ1JoYkpiSVFJcklaSXJJQnNoZ25ON0lhVExJYXNocXpJUVFXaXdOTWlPd0l0RDVYQkFDSTdCdU1BSW1LQWdHTC9nRW5FVXhRdmljTVRnSk5TU0paU3dFVlVvdi9pT3BKU0ltS0FnQ0wvZ0VuRVV4UXZpY01UZ0pOVndJZ01RQ0kvOHBFaS82TC80Z0FBWW1LQWdDTC9nRW5FVXhRU2I0bkRFNENUVWtpV1VzQkZWS0wvNGpwMTBoTVFRQVNNUUNML292L1VFeFFnQVMzLyt2NFRGQ3dpd0JKdmljTVRnSk5Wd0lnSnpwTVVJc0JVRXNCdkVpL2lZb0NBSXYrQVNjUlRGQkp2aWNNVGdKTlNTSlpTd0VWVW92L2lPbWpTRXhCQUJJeEFJditpLzlRVEZDQUJBYk9FNHRNVUxDTEFFbStKd3hPQWsxWEFpQW5Pa3hRaXdGUVN3RzhTTCtKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJDaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9sZE93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVHcmFudGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJNaW50aW5nVG9nZ2xlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9nZ2xlZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVkZWVtaW5nVG9nZ2xlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9nZ2xlZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVjb2xsYXRlcmFsaXplVG9nZ2xlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9nZ2xlZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQnV5YmFja1RvZ2dsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZ2dsZWQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNvbGxhdGVyYWxQcmljZVRvZ2dsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZ2dsZWQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlBvb2xQYXJhbWV0ZXJzU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfY2VpbGluZyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfYm9udXNfcmF0ZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcmVkZW1wdGlvbl9kZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfbWludF9mZWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3JlZGVlbV9mZWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2J1eWJhY2tfZmVlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19yZWNvbGxhdF9mZWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRpbWVsb2NrU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld190aW1lbG9jayIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3duZXJOb21pbmF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVSZXZva2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
