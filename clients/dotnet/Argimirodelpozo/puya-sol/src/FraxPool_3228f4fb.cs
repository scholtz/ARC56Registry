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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.FraxPool_3228f4fb
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRnJheFBvb2wiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWRkcmVzc1NldCI6W3sibmFtZSI6Il9pbm5lciIsInR5cGUiOiJTZXQifV0sIlJvbGVEYXRhIjpbeyJuYW1lIjoibWVtYmVycyIsInR5cGUiOiJBZGRyZXNzU2V0In0seyJuYW1lIjoiYWRtaW5Sb2xlIiwidHlwZSI6InVpbnQ4WzMyXSJ9XSwiU2V0IjpbeyJuYW1lIjoiX3ZhbHVlcyIsInR5cGUiOiJ1aW50OFszMl1bXSJ9LHsibmFtZSI6Il9pbmRleGVzIiwidHlwZSI6ImJ5dGVbXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJfX3Bvc3RJbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfZnJheF9jb250cmFjdF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2Z4c19jb250cmFjdF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2NvbGxhdGVyYWxfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9jcmVhdG9yX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfdGltZWxvY2tfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9wb29sX2NlaWxpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSb2xlR3JhbnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbGxhdERvbGxhckJhbGFuY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhdmFpbGFibGVFeGNlc3NDb2xsYXREViIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldENvbGxhdGVyYWxQcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldENvbGxhdEVUSE9yYWNsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2NvbGxhdGVyYWxfd2V0aF9vcmFjbGVfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il93ZXRoX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWludDF0MUZSQVgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbGxhdGVyYWxfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiRlJBWF9vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnRBbGdvcml0aG1pY0ZSQVgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZ4c19hbW91bnRfZDE4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiRlJBWF9vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnRGcmFjdGlvbmFsRlJBWCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29sbGF0ZXJhbF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmeHNfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiRlJBWF9vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZGVlbTF0MUZSQVgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IkZSQVhfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiQ09MTEFURVJBTF9vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZGVlbUZyYWN0aW9uYWxGUkFYIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJGUkFYX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IkZYU19vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiQ09MTEFURVJBTF9vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZGVlbUFsZ29yaXRobWljRlJBWCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiRlJBWF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJGWFNfb3V0X21pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb2xsZWN0UmVkZW1wdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvbGxhdGVyYWxpemVGUkFYIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb2xsYXRlcmFsX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IkZYU19vdXRfbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eUJhY2tGWFMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IkZYU19hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJDT0xMQVRFUkFMX291dF9taW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9nZ2xlTWludGluZyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTWludGluZ1RvZ2dsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZ2dsZWQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2dnbGVSZWRlZW1pbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlZGVlbWluZ1RvZ2dsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZ2dsZWQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2dnbGVSZWNvbGxhdGVyYWxpemUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlY29sbGF0ZXJhbGl6ZVRvZ2dsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZ2dsZWQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2dnbGVCdXlCYWNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJCdXliYWNrVG9nZ2xlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9nZ2xlZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvZ2dsZUNvbGxhdGVyYWxQcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX25ld19wcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29sbGF0ZXJhbFByaWNlVG9nZ2xlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9nZ2xlZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFBvb2xQYXJhbWV0ZXJzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfY2VpbGluZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19ib251c19yYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3JlZGVtcHRpb25fZGVsYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfbWludF9mZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcmVkZWVtX2ZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19idXliYWNrX2ZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19yZWNvbGxhdF9mZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlBvb2xQYXJhbWV0ZXJzU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfY2VpbGluZyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfYm9udXNfcmF0ZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcmVkZW1wdGlvbl9kZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfbWludF9mZWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3JlZGVlbV9mZWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2J1eWJhY2tfZmVlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19yZWNvbGxhdF9mZWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRUaW1lbG9jayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3RpbWVsb2NrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUaW1lbG9ja1NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfdGltZWxvY2siLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub21pbmF0ZU5ld093bmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfb3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyTm9taW5hdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWNjZXB0T3duZXJzaGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc1JvbGUiLCJkZXNjIjoiIEBkZXYgUmV0dXJucyBgdHJ1ZWAgaWYgYGFjY291bnRgIGhhcyBiZWVuIGdyYW50ZWQgYHJvbGVgLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZU1lbWJlckNvdW50IiwiZGVzYyI6IiBAZGV2IFJldHVybnMgdGhlIG51bWJlciBvZiBhY2NvdW50cyB0aGF0IGhhdmUgYHJvbGVgLiBDYW4gYmUgdXNlZFxuIHRvZ2V0aGVyIHdpdGgge2dldFJvbGVNZW1iZXJ9IHRvIGVudW1lcmF0ZSBhbGwgYmVhcmVycyBvZiBhIHJvbGUuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvbGVNZW1iZXIiLCJkZXNjIjoiIEBkZXYgUmV0dXJucyBvbmUgb2YgdGhlIGFjY291bnRzIHRoYXQgaGF2ZSBgcm9sZWAuIGBpbmRleGAgbXVzdCBiZSBhXG4gdmFsdWUgYmV0d2VlbiAwIGFuZCB7Z2V0Um9sZU1lbWJlckNvdW50fSwgbm9uLWluY2x1c2l2ZS5cbiBSb2xlIGJlYXJlcnMgYXJlIG5vdCBzb3J0ZWQgaW4gYW55IHBhcnRpY3VsYXIgd2F5LCBhbmQgdGhlaXIgb3JkZXJpbmcgbWF5XG4gY2hhbmdlIGF0IGFueSBwb2ludC5cbiBXQVJOSU5HOiBXaGVuIHVzaW5nIHtnZXRSb2xlTWVtYmVyfSBhbmQge2dldFJvbGVNZW1iZXJDb3VudH0sIG1ha2Ugc3VyZVxuIHlvdSBwZXJmb3JtIGFsbCBxdWVyaWVzIG9uIHRoZSBzYW1lIGJsb2NrLiBTZWUgdGhlIGZvbGxvd2luZ1xuIGh0dHBzOi8vZm9ydW0ub3BlbnplcHBlbGluLmNvbS90L2l0ZXJhdGluZy1vdmVyLWVsZW1lbnRzLW9uLWVudW1lcmFibGVzZXQtaW4tb3BlbnplcHBlbGluLWNvbnRyYWN0cy8yMjk2W2ZvcnVtIHBvc3RdXG4gZm9yIG1vcmUgaW5mb3JtYXRpb24uIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Um9sZUFkbWluIiwiZGVzYyI6IiBAZGV2IFJldHVybnMgdGhlIGFkbWluIHJvbGUgdGhhdCBjb250cm9scyBgcm9sZWAuIFNlZSB7Z3JhbnRSb2xlfSBhbmRcbiB7cmV2b2tlUm9sZX0uXG4gVG8gY2hhbmdlIGEgcm9sZSdzIGFkbWluLCB1c2Uge19zZXRSb2xlQWRtaW59LiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ3JhbnRSb2xlIiwiZGVzYyI6IiBAZGV2IEdyYW50cyBgcm9sZWAgdG8gYGFjY291bnRgLlxuIElmIGBhY2NvdW50YCBoYWQgbm90IGJlZW4gYWxyZWFkeSBncmFudGVkIGByb2xlYCwgZW1pdHMgYSB7Um9sZUdyYW50ZWR9XG4gZXZlbnQuXG4gUmVxdWlyZW1lbnRzOlxuIC0gdGhlIGNhbGxlciBtdXN0IGhhdmUgYGByb2xlYGAncyBhZG1pbiByb2xlLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSb2xlR3JhbnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZVJvbGUiLCJkZXNjIjoiIEBkZXYgUmV2b2tlcyBgcm9sZWAgZnJvbSBgYWNjb3VudGAuXG4gSWYgYGFjY291bnRgIGhhZCBiZWVuIGdyYW50ZWQgYHJvbGVgLCBlbWl0cyBhIHtSb2xlUmV2b2tlZH0gZXZlbnQuXG4gUmVxdWlyZW1lbnRzOlxuIC0gdGhlIGNhbGxlciBtdXN0IGhhdmUgYGByb2xlYGAncyBhZG1pbiByb2xlLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSb2xlUmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbm91bmNlUm9sZSIsImRlc2MiOiIgQGRldiBSZXZva2VzIGByb2xlYCBmcm9tIHRoZSBjYWxsaW5nIGFjY291bnQuXG4gUm9sZXMgYXJlIG9mdGVuIG1hbmFnZWQgdmlhIHtncmFudFJvbGV9IGFuZCB7cmV2b2tlUm9sZX06IHRoaXMgZnVuY3Rpb24nc1xuIHB1cnBvc2UgaXMgdG8gcHJvdmlkZSBhIG1lY2hhbmlzbSBmb3IgYWNjb3VudHMgdG8gbG9zZSB0aGVpciBwcml2aWxlZ2VzXG4gaWYgdGhleSBhcmUgY29tcHJvbWlzZWQgKHN1Y2ggYXMgd2hlbiBhIHRydXN0ZWQgZGV2aWNlIGlzIG1pc3BsYWNlZCkuXG4gSWYgdGhlIGNhbGxpbmcgYWNjb3VudCBoYWQgYmVlbiBncmFudGVkIGByb2xlYCwgZW1pdHMgYSB7Um9sZVJldm9rZWR9XG4gZXZlbnQuXG4gUmVxdWlyZW1lbnRzOlxuIC0gdGhlIGNhbGxlciBtdXN0IGJlIGBhY2NvdW50YC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUm9sZVJldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb2xsYXRfZXRoX29yYWNsZV9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWludGluZ19mZWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlbXB0aW9uX2ZlZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eWJhY2tfZmVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb2xsYXRfZmVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5jbGFpbWVkUG9vbENvbGxhdGVyYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bmNsYWltZWRQb29sRlhTIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicG9vbF9jZWlsaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2VkUHJpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib251c19yYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVkZW1wdGlvbl9kZWxheSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnRQYXVzZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlZW1QYXVzZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvbGxhdGVyYWxpemVQYXVzZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlCYWNrUGF1c2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29sbGF0ZXJhbFByaWNlUGF1c2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub21pbmF0ZWRPd25lciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo2LCJieXRlcyI6MjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzY2MTBdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NDb250cm9sOiBjYW4gb25seSByZW5vdW5jZSByb2xlcyBmb3Igc2VsZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyODldLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NDb250cm9sOiBzZW5kZXIgbXVzdCBiZSBhbiBhZG1pbiB0byBncmFudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1ODRdLCJlcnJvck1lc3NhZ2UiOiJBY2Nlc3NDb250cm9sOiBzZW5kZXIgbXVzdCBiZSBhbiBhZG1pbiB0byByZXZva2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTY4XSwiZXJyb3JNZXNzYWdlIjoiQnV5YmFjayBpcyBwYXVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzU2LDQ3ODRdLCJlcnJvck1lc3NhZ2UiOiJDb2xsYXRlcmFsIHJhdGlvIG11c3QgYmUgMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5NzBdLCJlcnJvck1lc3NhZ2UiOiJDb2xsYXRlcmFsIHJhdGlvIG11c3QgYmUgPT0gMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMjVdLCJlcnJvck1lc3NhZ2UiOiJDb2xsYXRlcmFsIHJhdGlvIG11c3QgYmUgPj0gMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NzgsNDMwOF0sImVycm9yTWVzc2FnZSI6IkNvbGxhdGVyYWwgcmF0aW8gbmVlZHMgdG8gYmUgYmV0d2VlbiAuMDAwMDAxIGFuZCAuOTk5OTk5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzNF0sImVycm9yTWVzc2FnZSI6IkVudW1lcmFibGVTZXQ6IGluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDQxLDMyOTgsMzUwOV0sImVycm9yTWVzc2FnZSI6Ik1pbnRpbmcgaXMgcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk5Nl0sImVycm9yTWVzc2FnZSI6Ik11c3Qgd2FpdCBmb3IgcmVkZW1wdGlvbl9kZWxheSBibG9ja3MgYmVmb3JlIGNvbGxlY3RpbmcgcmVkZW1wdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MDRdLCJlcnJvck1lc3NhZ2UiOiJObyBleGNlc3MgY29sbGF0ZXJhbCB0byBidXkgYmFjayEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODA5XSwiZXJyb3JNZXNzYWdlIjoiTm90IGVub3VnaCBGWFMgaW5wdXR0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTAyLDQ1MDFdLCJlcnJvck1lc3NhZ2UiOiJOb3QgZW5vdWdoIGNvbGxhdGVyYWwgaW4gcG9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OTUsNjA4OSw2MjgxXSwiZXJyb3JNZXNzYWdlIjoiTm90IG93bmVyIG9yIHRpbWVsb2NrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjMyMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGNvbnRyYWN0IG93bmVyIG1heSBwZXJmb3JtIHRoaXMgYWN0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI3MV0sImVycm9yTWVzc2FnZSI6Ik93bmVyIGFkZHJlc3MgY2Fubm90IGJlIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjMyXSwiZXJyb3JNZXNzYWdlIjoiUG9vbCBjZWlsaW5nIHJlYWNoZWQsIG5vIG1vcmUgRlJBWCBjYW4gYmUgbWludGVkIHdpdGggdGhpcyBjb2xsYXRlcmFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE5Nl0sImVycm9yTWVzc2FnZSI6IlJlY29sbGF0ZXJhbGl6ZSBpcyBwYXVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTM2LDQyMzksNDcyN10sImVycm9yTWVzc2FnZSI6IlJlZGVlbWluZyBpcyBwYXVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDQ2XSwiZXJyb3JNZXNzYWdlIjoiU2FmZU1hdGg6IGFkZGl0aW9uIG92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEzN10sImVycm9yTWVzc2FnZSI6IlNhZmVNYXRoOiBtdWx0aXBsaWNhdGlvbiBvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMTYsMzM5MSwzODAzLDQxMDgsNDg4MCw1NDgyLDU3MzVdLCJlcnJvck1lc3NhZ2UiOiJTbGlwcGFnZSBsaW1pdCByZWFjaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxNl0sImVycm9yTWVzc2FnZSI6IlNsaXBwYWdlIGxpbWl0IHJlYWNoZWQgW0ZYU10iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTA3XSwiZXJyb3JNZXNzYWdlIjoiU2xpcHBhZ2UgbGltaXQgcmVhY2hlZCBbY29sbGF0ZXJhbF0iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTMxXSwiZXJyb3JNZXNzYWdlIjoiWW91IGFyZSB0cnlpbmcgdG8gYnV5IGJhY2sgbW9yZSB0aGFuIHRoZSBleGNlc3MhIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM0OV0sImVycm9yTWVzc2FnZSI6IllvdSBtdXN0IGJlIG5vbWluYXRlZCBiZWZvcmUgeW91IGNhbiBhY2NlcHQgb3duZXJzaGlwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM0OV0sImVycm9yTWVzc2FnZSI6Ilplcm8gYWRkcmVzcyBkZXRlY3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNzldLCJlcnJvck1lc3NhZ2UiOiJbUG9vbCdzIENsb3NlZF06IENlaWxpbmcgcmVhY2hlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNjBdLCJlcnJvck1lc3NhZ2UiOiJfX3Bvc3RJbml0IGFscmVhZHkgY2FsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA5OSwyMTg1XSwiZXJyb3JNZXNzYWdlIjoiYXNzZXJ0aW9uIGZhaWxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NTUsMzA5NywzMjQ5LDMzMDQsMzUxNSwzODgzLDM5NDIsNDE3OSw0MjQ1LDQ2MzEsNDczMyw0OTAwLDUyNTEsNTU3NCw2OTMzLDcwODVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBGUkFYIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0MTEsMzgyOCw0Njc0LDQ5NDMsNTA1MCw1NTE1LDU3NTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBGWFMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ1NCw2NzgzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgYm9udXNfcmF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTY2LDU5MTMsNjg3Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGJ1eUJhY2tQYXVzZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY2Miw2NjY5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgYnV5YmFja19mZWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc2MCw3MTkwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgY29sbGF0RXRoT3JhY2xlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2MjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBjb2xsYXRfZXRoX29yYWNsZV9hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MTUsNTk1Nyw1OTcwLDY4ODksNzA2Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGNvbGxhdGVyYWxQcmljZVBhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDAxLDI1MjgsMjgxNSwzMTMzLDMyMjEsMzU4NiwzODU3LDQwNjEsNDQ2MCw1MDY3LDU0ODcsNTc4M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIGNvbGxhdGVyYWxfdG9rZW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAzOSwzMjk2LDM1MDcsNTgwNSw2ODIxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbWludFBhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTk0LDMzNjksMzc4MSw2NjMxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbWludGluZ19mZWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU2NCwyNjk2LDI4NTEsMzA0OSwzNjQ3LDM5NzgsNDM4NCw1MjA0LDU0MDAsNTY4Niw3MTI2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbWlzc2luZ19kZWNpbWFscyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzQ0LDY5MTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBub21pbmF0ZWRPd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTg5LDYwODMsNjI3NSw2MzE5LDYzNTQsNjkwNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIG93bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MjYsNjc2NCw3MDc2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcGF1c2VkUHJpY2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE3NywzNjMwLDY3NDVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBwb29sX2NlaWxpbmcgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ2Miw2Njg4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcmVjb2xsYXRfZmVlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxOTQsNTg3Nyw2ODU1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcmVjb2xsYXRlcmFsaXplUGF1c2VkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5MzQsNDIzNyw0NzI1LDU4NDEsNjgzOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHJlZGVlbVBhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTg4LDY4MDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayByZWRlbXB0aW9uX2RlbGF5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMzcsNDMyNCw0NzkyLDY2NTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayByZWRlbXB0aW9uX2ZlZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDUyLDI0NjMsMjQ3NCwyNDg1LDI0OTYsMjk3OCw2MDcyLDYyNjRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB0aW1lbG9ja19hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MTMsMjkwMCwzMTY0LDM2MTcsNDA5Miw0NDkxLDUxMDksNjcwN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHVuY2xhaW1lZFBvb2xDb2xsYXRlcmFsIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1ODcsNDg1MSw1MTU2LDY3MjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB1bmNsYWltZWRQb29sRlhTIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NDEsNzE3MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHdldGhfYWRkcmVzcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDk2LDE1MTQsMTY1MF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIwOCwyMjE4LDIyMjgsMjIzNiwyMjQ2LDI5NjMsMjk3MSw2MjU3LDYzMTIsNjM4NCw2MzkyLDY0MTUsNjQ1OSw2NTA1LDY1MzMsNjU0MSw2NTU0LDY1NjIsNjU5Nyw2NjA1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNTYsMzAyNiwzMDM0LDMyODMsMzI5MSwzNDg1LDM0OTQsMzUwMiwzOTIxLDM5MjksNDIxNiw0MjI0LDQyMzIsNDcxMiw0NzIwLDUxODEsNTE4OSw1NTUxLDU1NjEsNTk0NCw2MDExLDYwMjAsNjAyOSw2MDM4LDYwNDcsNjA1Niw2MDY1LDY0NjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM4N10sImVycm9yTWVzc2FnZSI6Im1heCBhcnJheSBsZW5ndGggZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjQwLDI5MjksMjk0NiwzNzAwLDM3MTMsMzcyMiwzNzMyLDM3NDcsNTYwMiw1NjIwLDU2MzEsNTY0MCw2MTUwLDYxNjIsNjE3Miw2MTgyLDYxOTIsNjIwMiw2MjEyLDY0NDIsNjYzNiw2NjU1LDY2NzQsNjY5Myw2NzEyLDY3MzEsNjc1MCw2NzY5LDY3ODgsNjgwN10sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ3dVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURNeUlERWdOaUF4TURBd01EQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRJREI0TURFZ01IZ3hOVEZtTjJNM05TQXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnSWtaU1FWZ2lJQ0pqYjJ4c1lYUmxjbUZzWDNSdmEyVnVJaUFpYldsemMybHVaMTlrWldOcGJXRnNjeUlnSW5WdVkyeGhhVzFsWkZCdmIyeERiMnhzWVhSbGNtRnNJaUFpZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUlnTUhnd1lTQXdlREF5SURCNE1EQWdNSGd3TURJeU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREl3TURBME1EQXdOakF3TURBd01EQXdJQ0p2ZDI1bGNpSWdJa1pZVXlJZ0luVnVZMnhoYVcxbFpGQnZiMnhHV0ZNaUlEQjRaV016TmpSbE16UWdJbDl5YjJ4bGN5SWdJbTFwYm5SUVlYVnpaV1FpSUNKeVpXUmxaVzFRWVhWelpXUWlJQ0pqYjJ4c1lYUmxjbUZzVUhKcFkyVlFZWFZ6WldRaUlEQjRNR1kwTWpRd0lDSnlaV1JsWlcxRGIyeHNZWFJsY21Gc1FtRnNZVzVqWlhNaUlDSnlaV1JsWlcxR1dGTkNZV3hoYm1ObGN5SWdJbTFwYm5ScGJtZGZabVZsSWlBaWNtVmtaVzF3ZEdsdmJsOW1aV1VpSUNKd2IyOXNYMk5sYVd4cGJtY2lJQ0p3WVhWelpXUlFjbWxqWlNJZ01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnTUhnNE0ySmhaRGRqWXlBd2VERXpNekkzWlRJNElEQjRObU0wWWpKaVkyWWdNSGhqTjJNeE1HWm1aU0FpYm05dGFXNWhkR1ZrVDNkdVpYSWlJQ0p5WldOdmJHeGhkR1Z5WVd4cGVtVlFZWFZ6WldRaUlDSmlkWGxDWVdOclVHRjFjMlZrSWlBaVkyOXNiR0YwUlhSb1QzSmhZMnhsSWlBaWQyVjBhRjloWkdSeVpYTnpJaUFpWW5WNVltRmphMTltWldVaUlDSnlaV052Ykd4aGRGOW1aV1VpSUNKaWIyNTFjMTl5WVhSbElpQWljbVZrWlcxd2RHbHZibDlrWld4aGVTSWdJbDlwYm1SbGVHVnpJaUFpYkdGemRGSmxaR1ZsYldWa0lpQWlZMjlzYkdGMFgyVjBhRjl2Y21GamJHVmZZV1JrY21WemN5SWdJbDlmWTNSdmNsOXdaVzVrYVc1bklpQWlZMjlzYkdGMFpYSmhiRjloWkdSeVpYTnpJaUFpWm5KaGVGOWpiMjUwY21GamRGOWhaR1J5WlhOeklpQWlabmh6WDJOdmJuUnlZV04wWDJGa1pISmxjM01pSURCNFl6WTFOVE15TVRnMVpXUTNNR0l5WlRrNU9UUXpNMlV5WlRsbVlXTXhNalJsTURnellXTmlNVE5sWXpFNE0yRTBaVEExT1RRMFpHRXdOemt5TXpNM1lpQXdlR0U0TkdFMU16ZzVZV1EwTVdZNVlXRmlNRGd6TVdJd01XVTFNemcwWTJGbE56WmxOMkUzWm1Rd09URXpNV015TURabVpqYzVNamRqTWpBeFl6TTROVGNnTUhnNE1URTRaV1ZpTlRJek1XRTFabVUwTURBNFlUVTFZall5T0RZd1pqWmhNR1JpTkdZMll6TmhZekEwWmpneE5ERTVNamRoT1dJelptVmtaRGcyWkRKbUlEQjRNVEF6WkdFM09XWm1NemMxTldabU4yRXhOMkUxTlRka01qaGlOek5rTXpkallqUmtaVEJpTTJNelkyTXdNbVpoTm1NME9HUm1NR1l6TlRBM01XWmlaaUF3ZUdKaU1tTTJPR0k0WkdNMVltTmpaR1F5TlRNMk16QTNNRGd3WVRjNE5qVmhOMlV4TXpOaVpqVTBaVE14WkRSa05EWXpZakZpTnpRNVlqUmlZMll5Tm1RZ01IaGhZelUzWVdSaE1pQXdlREprTXpGbVkySTFJREI0TnpsbVlXSTBOalVnTUhnNVpHTTBPVE00T1NBd2VEQXdNaklLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSnZkMjVsY2lJS0lDQWdJR0o1ZEdWalh6TWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ016TWdMeThnSW01dmJXbHVZWFJsWkU5M2JtVnlJZ29nSUNBZ1lubDBaV05mTXlBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmpiMnhzWVhSbGNtRnNYM1J2YTJWdUlnb2dJQ0FnWW5sMFpXTmZNeUF2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QTBOaUF2THlBaVkyOXNiR0YwWlhKaGJGOWhaR1J5WlhOeklnb2dJQ0FnWW5sMFpXTmZNeUF2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QTBOeUF2THlBaVpuSmhlRjlqYjI1MGNtRmpkRjloWkdSeVpYTnpJZ29nSUNBZ1lubDBaV05mTXlBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEwT0NBdkx5QWlabmh6WDJOdmJuUnlZV04wWDJGa1pISmxjM01pQ2lBZ0lDQmllWFJsWTE4eklDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblJwYldWc2IyTnJYMkZrWkhKbGMzTWlDaUFnSUNCaWVYUmxZMTh6SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREUwSUM4dklDSkdXRk1pQ2lBZ0lDQmllWFJsWTE4eklDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJa1pTUVZnaUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklETTJJQzh2SUNKamIyeHNZWFJGZEdoUGNtRmpiR1VpQ2lBZ0lDQmllWFJsWTE4eklDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURRMElDOHZJQ0pqYjJ4c1lYUmZaWFJvWDI5eVlXTnNaVjloWkdSeVpYTnpJZ29nSUNBZ1lubDBaV05mTXlBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF6TnlBdkx5QWlkMlYwYUY5aFpHUnlaWE56SWdvZ0lDQWdZbmwwWldOZk15QXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeU5DQXZMeUFpYldsdWRHbHVaMTltWldVaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNalVnTHk4Z0luSmxaR1Z0Y0hScGIyNWZabVZsSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklETTRJQzh2SUNKaWRYbGlZV05yWDJabFpTSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF6T1NBdkx5QWljbVZqYjJ4c1lYUmZabVZsSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5WdVkyeGhhVzFsWkZCdmIyeERiMnhzWVhSbGNtRnNJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0oxYm1Oc1lXbHRaV1JRYjI5c1JsaFRJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbTFwYzNOcGJtZGZaR1ZqYVcxaGJITWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJREkySUM4dklDSndiMjlzWDJObGFXeHBibWNpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklESTNJQzh2SUNKd1lYVnpaV1JRY21salpTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCd2RYTm9hVzUwSURjMU1EQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFF3SUM4dklDSmliMjUxYzE5eVlYUmxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEwTVNBdkx5QWljbVZrWlcxd2RHbHZibDlrWld4aGVTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QWliV2x1ZEZCaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRrZ0x5OGdJbkpsWkdWbGJWQmhkWE5sWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ016UWdMeThnSW5KbFkyOXNiR0YwWlhKaGJHbDZaVkJoZFhObFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNelVnTHk4Z0ltSjFlVUpoWTJ0UVlYVnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURJd0lDOHZJQ0pqYjJ4c1lYUmxjbUZzVUhKcFkyVlFZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEUTFJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMlpUTTJNV05qTXlBd2VHWXhZamRsWkdRNElEQjRaV0l3TVRGaE5UTWdNSGczT0dVeE1tSmhZeUF3ZURjMU1tUXlNV1JrSURCNE1tWTNPVE0wT0RjZ01IZzRZbU0wTVdGak1pQXdlR0ppWmpCak1HWmtJREI0WVROalpHVmpNalVnTUhnM1lUTXhZV1ZpTmlBd2VETmlNRGN5TnpaaElEQjRNRFl3TnpsaE5XVWdNSGd3WlRFM05tSm1NU0F3ZURRMVpXUmhOVFU0SURCNE1tTm1NMkl3WmpnZ01IaG1aV05pWkRNek5TQXdlRE0yT0dKa1ptTTVJREI0TkRsaU1XRTFZVElnTUhoaU9UVXlZamxoTkNBd2VEa3pZV0U0WldSa0lEQjRZV0ZtWW1Jd09HSWdNSGd6WVdRellURXdNeUF3ZUdRMU1qRmtOakEwSURCNE5UaGhPVEV3TWpnZ01IZ3daVEZqTkdKaE1DQXdlREkwTldRM1pqVTVJREI0TmpjeU9EbGpOMlFnTUhneE5ERmpOR1l4T0NBd2VEZ3pNR1EyTUdJeElEQjRPV1UwT1RneVpXUWdNSGcxT1RVM01qUmxOaUF3ZURZellUQmtNMkUxSURCNFlUa3dOVGc0WkRrZ01IZ3hZalJsTUdNNU5pQXdlR0ZtTVRoa1pERmlJREI0TlRJek1qaGtZV0lnTUhoaVpqWTJOMlE1WXlBd2VHUTNaV1ptTnpNd0lEQjRNVGcyTVRNMlptTWdNSGc1TmpjMllXWmlOU0F3ZURJd1ptVTBNbUl5SURCNFlqZGtOR1kwTXpZZ01IZzNNV1ZsT1RGak5pQXdlREppTVdObFlqWXdJREI0TTJNNU9UUXdNMk1nTUhnd1pURTRaRGs0TWlBd2VHSXhZbUppTUdFNElEQjROMlF5WmpNMU5XTWdMeThnYldWMGFHOWtJQ0pmWDNCdmMzUkpibWwwS0dGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMktYWnZhV1FpTENCdFpYUm9iMlFnSW1OdmJHeGhkRVJ2Ykd4aGNrSmhiR0Z1WTJVb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltRjJZV2xzWVdKc1pVVjRZMlZ6YzBOdmJHeGhkRVJXS0NsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKblpYUkRiMnhzWVhSbGNtRnNVSEpwWTJVb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0luTmxkRU52Ykd4aGRFVlVTRTl5WVdOc1pTaGhaR1J5WlhOekxHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYldsdWRERjBNVVpTUVZnb2RXbHVkREkxTml4MWFXNTBNalUyS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTFwYm5SQmJHZHZjbWwwYUcxcFkwWlNRVmdvZFdsdWRESTFOaXgxYVc1ME1qVTJLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltMXBiblJHY21GamRHbHZibUZzUmxKQldDaDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTmlsMmIybGtJaXdnYldWMGFHOWtJQ0p5WldSbFpXMHhkREZHVWtGWUtIVnBiblF5TlRZc2RXbHVkREkxTmlsMmIybGtJaXdnYldWMGFHOWtJQ0p5WldSbFpXMUdjbUZqZEdsdmJtRnNSbEpCV0NoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaV1JsWlcxQmJHZHZjbWwwYUcxcFkwWlNRVmdvZFdsdWRESTFOaXgxYVc1ME1qVTJLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTnZiR3hsWTNSU1pXUmxiWEIwYVc5dUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXTnZiR3hoZEdWeVlXeHBlbVZHVWtGWUtIVnBiblF5TlRZc2RXbHVkREkxTmlsMmIybGtJaXdnYldWMGFHOWtJQ0ppZFhsQ1lXTnJSbGhUS0hWcGJuUXlOVFlzZFdsdWRESTFOaWwyYjJsa0lpd2diV1YwYUc5a0lDSjBiMmRuYkdWTmFXNTBhVzVuS0NsMmIybGtJaXdnYldWMGFHOWtJQ0owYjJkbmJHVlNaV1JsWlcxcGJtY29LWFp2YVdRaUxDQnRaWFJvYjJRZ0luUnZaMmRzWlZKbFkyOXNiR0YwWlhKaGJHbDZaU2dwZG05cFpDSXNJRzFsZEdodlpDQWlkRzluWjJ4bFFuVjVRbUZqYXlncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEc5bloyeGxRMjlzYkdGMFpYSmhiRkJ5YVdObEtIVnBiblF5TlRZcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFVHOXZiRkJoY21GdFpYUmxjbk1vZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTmlsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSVWFXMWxiRzlqYXloaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbTV2YldsdVlYUmxUbVYzVDNkdVpYSW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKaFkyTmxjSFJQZDI1bGNuTm9hWEFvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWhoYzFKdmJHVW9ZbmwwWlZzek1sMHNZV1JrY21WemN5bGliMjlzSWl3Z2JXVjBhRzlrSUNKblpYUlNiMnhsVFdWdFltVnlRMjkxYm5Rb1lubDBaVnN6TWwwcGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVoyVjBVbTlzWlUxbGJXSmxjaWhpZVhSbFd6TXlYU3gxYVc1ME1qVTJLV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbWRsZEZKdmJHVkJaRzFwYmloaWVYUmxXek15WFNsaWVYUmxXek15WFNJc0lHMWxkR2h2WkNBaVozSmhiblJTYjJ4bEtHSjVkR1ZiTXpKZExHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WMmIydGxVbTlzWlNoaWVYUmxXek15WFN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYm05MWJtTmxVbTlzWlNoaWVYUmxXek15WFN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbU52Ykd4aGRGOWxkR2hmYjNKaFkyeGxYMkZrWkhKbGMzTW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbTFwYm5ScGJtZGZabVZsS0NsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKeVpXUmxiWEIwYVc5dVgyWmxaU2dwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWW5WNVltRmphMTltWldVb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0luSmxZMjlzYkdGMFgyWmxaU2dwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpZFc1amJHRnBiV1ZrVUc5dmJFTnZiR3hoZEdWeVlXd29LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJblZ1WTJ4aGFXMWxaRkJ2YjJ4R1dGTW9LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbkJ2YjJ4ZlkyVnBiR2x1WnlncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWNHRjFjMlZrVUhKcFkyVW9LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbUp2Ym5WelgzSmhkR1VvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW5KbFpHVnRjSFJwYjI1ZlpHVnNZWGtvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW0xcGJuUlFZWFZ6WldRb0tXSnZiMndpTENCdFpYUm9iMlFnSW5KbFpHVmxiVkJoZFhObFpDZ3BZbTl2YkNJc0lHMWxkR2h2WkNBaWNtVmpiMnhzWVhSbGNtRnNhWHBsVUdGMWMyVmtLQ2xpYjI5c0lpd2diV1YwYUc5a0lDSmlkWGxDWVdOclVHRjFjMlZrS0NsaWIyOXNJaXdnYldWMGFHOWtJQ0pqYjJ4c1lYUmxjbUZzVUhKcFkyVlFZWFZ6WldRb0tXSnZiMndpTENCdFpYUm9iMlFnSW05M2JtVnlLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0p1YjIxcGJtRjBaV1JQZDI1bGNpZ3BZV1JrY21WemN5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRjlmY0c5emRFbHVhWFFnWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlNCaGRtRnBiR0ZpYkdWRmVHTmxjM05EYjJ4c1lYUkVWaUJuWlhSRGIyeHNZWFJsY21Gc1VISnBZMlVnYzJWMFEyOXNiR0YwUlZSSVQzSmhZMnhsSUcxcGJuUXhkREZHVWtGWUlHMXBiblJCYkdkdmNtbDBhRzFwWTBaU1FWZ2diV2x1ZEVaeVlXTjBhVzl1WVd4R1VrRllJSEpsWkdWbGJURjBNVVpTUVZnZ2NtVmtaV1Z0Um5KaFkzUnBiMjVoYkVaU1FWZ2djbVZrWldWdFFXeG5iM0pwZEdodGFXTkdVa0ZZSUdOdmJHeGxZM1JTWldSbGJYQjBhVzl1SUhKbFkyOXNiR0YwWlhKaGJHbDZaVVpTUVZnZ1luVjVRbUZqYTBaWVV5QjBiMmRuYkdWTmFXNTBhVzVuSUhSdloyZHNaVkpsWkdWbGJXbHVaeUIwYjJkbmJHVlNaV052Ykd4aGRHVnlZV3hwZW1VZ2RHOW5aMnhsUW5WNVFtRmpheUIwYjJkbmJHVkRiMnhzWVhSbGNtRnNVSEpwWTJVZ2MyVjBVRzl2YkZCaGNtRnRaWFJsY25NZ2MyVjBWR2x0Wld4dlkyc2dibTl0YVc1aGRHVk9aWGRQZDI1bGNpQmhZMk5sY0hSUGQyNWxjbk5vYVhBZ2FHRnpVbTlzWlNCblpYUlNiMnhsVFdWdFltVnlRMjkxYm5RZ1oyVjBVbTlzWlUxbGJXSmxjaUJuWlhSU2IyeGxRV1J0YVc0Z1ozSmhiblJTYjJ4bElISmxkbTlyWlZKdmJHVWdjbVZ1YjNWdVkyVlNiMnhsSUdOdmJHeGhkRjlsZEdoZmIzSmhZMnhsWDJGa1pISmxjM01nYldsdWRHbHVaMTltWldVZ2NtVmtaVzF3ZEdsdmJsOW1aV1VnWW5WNVltRmphMTltWldVZ2NtVmpiMnhzWVhSZlptVmxJSFZ1WTJ4aGFXMWxaRkJ2YjJ4RGIyeHNZWFJsY21Gc0lIVnVZMnhoYVcxbFpGQnZiMnhHV0ZNZ2NHOXZiRjlqWldsc2FXNW5JSEJoZFhObFpGQnlhV05sSUdKdmJuVnpYM0poZEdVZ2NtVmtaVzF3ZEdsdmJsOWtaV3hoZVNCdGFXNTBVR0YxYzJWa0lISmxaR1ZsYlZCaGRYTmxaQ0J5WldOdmJHeGhkR1Z5WVd4cGVtVlFZWFZ6WldRZ1luVjVRbUZqYTFCaGRYTmxaQ0JqYjJ4c1lYUmxjbUZzVUhKcFkyVlFZWFZ6WldRZ2IzZHVaWElnYm05dGFXNWhkR1ZrVDNkdVpYSUtJQ0FnSUdWeWNnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwTGw5aFpHUW9jMlYwT2lCaWVYUmxjeXdnZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUXNJR0o1ZEdWek9ncEZiblZ0WlhKaFlteGxVMlYwTGw5aFpHUTZDaUFnSUNCd2NtOTBieUF5SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlFVnVkVzFsY21GaWJHVlRaWFF1WDJOdmJuUmhhVzV6Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB5Q2lBZ0lDQmlibm9nUlc1MWJXVnlZV0pzWlZObGRDNWZZV1JrWDJWc2MyVmZZbTlrZVVBMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMElDOHZJRzl1SUdWeWNtOXlPaUJ0WVhnZ1lYSnlZWGtnYkdWdVozUm9JR1Y0WTJWbFpHVmtDaUFnSUNCd2IzQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F2Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ05ESWdMeThnSWw5cGJtUmxlR1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY21WMGMzVmlDZ3BGYm5WdFpYSmhZbXhsVTJWMExsOWhaR1JmWld4elpWOWliMlI1UURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJXNTFiV1Z5WVdKc1pWTmxkQzVmY21WdGIzWmxLSE5sZERvZ1lubDBaWE1zSUhaaGJIVmxPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBMQ0JpZVhSbGN6b0tSVzUxYldWeVlXSnNaVk5sZEM1ZmNtVnRiM1psT2dvZ0lDQWdjSEp2ZEc4Z01pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTkRJZ0x5OGdJbDlwYm1SbGVHVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdKNklFVnVkVzFsY21GaWJHVlRaWFF1WDNKbGJXOTJaVjlsYkhObFgySnZaSGxBTWdvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHSjVkR1ZqSURJNElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpTFFvZ0lDQWdZbmwwWldNZ01qZ2dMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJREk0SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV01nTWpnZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUNvS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnY21Wd2JHRmpaVE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCd2IzQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpS3dvZ0lDQWdjM2RoY0FvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QTBNaUF2THlBaVgybHVaR1Y0WlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCeVpYUnpkV0lLQ2tWdWRXMWxjbUZpYkdWVFpYUXVYM0psYlc5MlpWOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRDNWZZMjl1ZEdGcGJuTW9jMlYwT2lCaWVYUmxjeXdnZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUXNJR0o1ZEdWek9ncEZiblZ0WlhKaFlteGxVMlYwTGw5amIyNTBZV2x1Y3pvS0lDQWdJSEJ5YjNSdklESWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURReUlDOHZJQ0pmYVc1a1pYaGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtWdWRXMWxjbUZpYkdWVFpYUXVYMnhsYm1kMGFDaHpaWFE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDa1Z1ZFcxbGNtRmliR1ZUWlhRdVgyeGxibWQwYURvS0lDQWdJSEJ5YjNSdklERWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUM4S0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrVnVkVzFsY21GaWJHVlRaWFF1WDJGMEtITmxkRG9nWW5sMFpYTXNJR2x1WkdWNE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6T2dwRmJuVnRaWEpoWW14bFUyVjBMbDloZERvS0lDQWdJSEJ5YjNSdklESWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTHdvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlQZ29nSUNBZ1lYTnpaWEowSUM4dklFVnVkVzFsY21GaWJHVlRaWFE2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRDNWhaR1FvTWlsZk1DaHpaWFE2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dZbmwwWlhNc0lHSjVkR1Z6T2dwRmJuVnRaWEpoWW14bFUyVjBMbUZrWkRvS0lDQWdJSEJ5YjNSdklESWdNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwTGw5aFpHUUtJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JrZFhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwTG5KbGJXOTJaU2d5S1Y4d0tITmxkRG9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZMExDQmllWFJsY3l3Z1lubDBaWE02Q2tWdWRXMWxjbUZpYkdWVFpYUXVjbVZ0YjNabE9nb2dJQ0FnY0hKdmRHOGdNaUF6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRVZ1ZFcxbGNtRmliR1ZUWlhRdVgzSmxiVzkyWlFvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHUjFjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtWdWRXMWxjbUZpYkdWVFpYUXVZMjl1ZEdGcGJuTW9NaWxmTUNoelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE02Q2tWdWRXMWxjbUZpYkdWVFpYUXVZMjl1ZEdGcGJuTTZDaUFnSUNCd2NtOTBieUF5SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnUlc1MWJXVnlZV0pzWlZObGRDNWZZMjl1ZEdGcGJuTUtJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSVzUxYldWeVlXSnNaVk5sZEM1c1pXNW5kR2dvTVNsZk1DaHpaWFE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDa1Z1ZFcxbGNtRmliR1ZUWlhRdWJHVnVaM1JvT2dvZ0lDQWdjSEp2ZEc4Z01TQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwTGw5c1pXNW5kR2dLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRDNWhkQ2d5S1Y4d0tITmxkRG9nWW5sMFpYTXNJR2x1WkdWNE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6T2dwRmJuVnRaWEpoWW14bFUyVjBMbUYwT2dvZ0lDQWdjSEp2ZEc4Z01pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlFVnVkVzFsY21GaWJHVlRaWFF1WDJGMENpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c1RHbGljbUZ5ZVM1allXeGpUV2x1ZERGME1VWlNRVmdvWTI5c1gzQnlhV05sT2lCaWVYUmxjeXdnWTI5c2JHRjBaWEpoYkY5aGJXOTFiblJmWkRFNE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrWnlZWGhRYjI5c1RHbGljbUZ5ZVM1allXeGpUV2x1ZERGME1VWlNRVmc2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbTExYkFvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBd01EQUtJQ0FnSUdsMGIySUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WkdsMkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyeE1hV0p5WVhKNUxtTmhiR05OYVc1MFFXeG5iM0pwZEdodGFXTkdVa0ZZS0daNGMxOXdjbWxqWlY5MWMyUTZJR0o1ZEdWekxDQm1lSE5mWVcxdmRXNTBYMlF4T0RvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwR2NtRjRVRzl2YkV4cFluSmhjbmt1WTJGc1kwMXBiblJCYkdkdmNtbDBhRzFwWTBaU1FWZzZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtMTFiQW9nSUNBZ2FXNTBZeUEwSUM4dklERXdNREF3TURBS0lDQWdJR2wwYjJJS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VaR2wyQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ4TWFXSnlZWEo1TG1OaGJHTk5hVzUwUm5KaFkzUnBiMjVoYkVaU1FWZ29jR0Z5WVcxek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6TENCaWVYUmxjem9LUm5KaGVGQnZiMnhNYVdKeVlYSjVMbU5oYkdOTmFXNTBSbkpoWTNScGIyNWhiRVpTUVZnNkNpQWdJQ0J3Y205MGJ5QXhJRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBNU5pQXpNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG0xMWJBb2dJQ0FnYVc1MFl5QTBJQzh2SURFd01EQXdNREFLSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtUnBkZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1dGRXd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ016SUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WkdsMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV6ZFdJS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG0xMWJBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VaR2wyQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbUZrWkFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ4TWFXSnlZWEo1TG1OaGJHTlNaV1JsWlcweGRERkdVa0ZZS0dOdmJGOXdjbWxqWlY5MWMyUTZJR0o1ZEdWekxDQkdVa0ZZWDJGdGIzVnVkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BHY21GNFVHOXZiRXhwWW5KaGNua3VZMkZzWTFKbFpHVmxiVEYwTVVaU1FWZzZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01EQXdDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YlhWc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VaR2wyQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ4TWFXSnlZWEo1TG1OaGJHTkNkWGxDWVdOclJsaFRLSEJoY21GdGN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3pvS1JuSmhlRkJ2YjJ4TWFXSnlZWEo1TG1OaGJHTkNkWGxDWVdOclJsaFRPZ29nSUNBZ2NISnZkRzhnTVNBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lYTnpaWEowSUM4dklFNXZJR1Y0WTJWemN5QmpiMnhzWVhSbGNtRnNJSFJ2SUdKMWVTQmlZV05ySVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWJYVnNDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNREF3TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VaR2wyQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWWp3OUNpQWdJQ0JoYzNObGNuUWdMeThnV1c5MUlHRnlaU0IwY25scGJtY2dkRzhnWW5WNUlHSmhZMnNnYlc5eVpTQjBhR0Z1SUhSb1pTQmxlR05sYzNNaENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbTExYkFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRE15Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtUnBkZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnhNYVdKeVlYSjVMbU5oYkdOU1pXTnZiR3hoZEdWeVlXeHBlbVZHVWtGWVNXNXVaWElvWTI5c2JHRjBaWEpoYkY5aGJXOTFiblE2SUdKNWRHVnpMQ0JqYjJ4ZmNISnBZMlU2SUdKNWRHVnpMQ0JuYkc5aVlXeGZZMjlzYkdGMFgzWmhiSFZsT2lCaWVYUmxjeXdnWm5KaGVGOTBiM1JoYkY5emRYQndiSGs2SUdKNWRHVnpMQ0JuYkc5aVlXeGZZMjlzYkdGMFpYSmhiRjl5WVhScGJ6b2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3pvS1JuSmhlRkJ2YjJ4TWFXSnlZWEo1TG1OaGJHTlNaV052Ykd4aGRHVnlZV3hwZW1WR1VrRllTVzV1WlhJNkNpQWdJQ0J3Y205MGJ5QTFJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG0xMWJBb2dJQ0FnYVc1MFl5QTBJQzh2SURFd01EQXdNREFLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVrYVhZS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG0xMWJBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbVJwZGdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWJYVnNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXRkV3dLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWMzVmlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1ScGRnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaVBEMEtJQ0FnSUdKNklFWnlZWGhRYjI5c1RHbGljbUZ5ZVM1allXeGpVbVZqYjJ4c1lYUmxjbUZzYVhwbFJsSkJXRWx1Ym1WeVgyVnNjMlZmWW05a2VVQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb0tSbkpoZUZCdmIyeE1hV0p5WVhKNUxtTmhiR05TWldOdmJHeGhkR1Z5WVd4cGVtVkdVa0ZZU1c1dVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXRkV3dLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0J5WlhSemRXSUtDa1p5WVhoUWIyOXNUR2xpY21GeWVTNWpZV3hqVW1WamIyeHNZWFJsY21Gc2FYcGxSbEpCV0VsdWJtVnlYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHSWdSbkpoZUZCdmIyeE1hV0p5WVhKNUxtTmhiR05TWldOdmJHeGhkR1Z5WVd4cGVtVkdVa0ZZU1c1dVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBekNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xsTmhabVZOWVhSb0xtRmtaQ2hoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwVFlXWmxUV0YwYUM1aFpHUTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlLd29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdJK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZOaFptVk5ZWFJvT2lCaFpHUnBkR2x2YmlCdmRtVnlabXh2ZHdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xsTmhabVZOWVhSb0xuTjFZaWd5S1NoaE9pQmllWFJsY3l3Z1lqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncFRZV1psVFdGMGFDNXpkV0k2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxOaFptVk5ZWFJvT2lCemRXSjBjbUZqZEdsdmJpQnZkbVZ5Wm14dmR5SUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xsTmhabVZOWVhSb0xuTjFZaWd6S1FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xsTmhabVZOWVhSb0xuTjFZaWd6S1NoaE9pQmllWFJsY3l3Z1lqb2dZbmwwWlhNc0lHVnljbTl5VFdWemMyRm5aVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVUyRm1aVTFoZEdndWMzVmlLRE1wT2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWWp3OUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBhVzl1SUdaaGFXeGxaQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaWVYUmxZeUF5T0NBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpJREk0SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGxOaFptVk5ZWFJvTG0xMWJDaGhPaUJpZVhSbGN5d2dZam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BUWVdabFRXRjBhQzV0ZFd3NkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqMDlDaUFnSUNCaWVpQlRZV1psVFdGMGFDNXRkV3hmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnY21WMGMzVmlDZ3BUWVdabFRXRjBhQzV0ZFd4ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSXFDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWk4S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZajA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMkZtWlUxaGRHZzZJRzExYkhScGNHeHBZMkYwYVc5dUlHOTJaWEptYkc5M0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VVMkZtWlUxaGRHZ3VaR2wyS0RJcEtHRTZJR0o1ZEdWekxDQmlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbE5oWm1WTllYUm9MbVJwZGpvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBaVUyRm1aVTFoZEdnNklHUnBkbWx6YVc5dUlHSjVJSHBsY204aUNpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1VFlXWmxUV0YwYUM1a2FYWW9NeWtLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1VFlXWmxUV0YwYUM1a2FYWW9NeWtvWVRvZ1lubDBaWE1zSUdJNklHSjVkR1Z6TENCbGNuSnZjazFsYzNOaFoyVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGxOaFptVk5ZWFJvTG1ScGRpZ3pLVG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUGdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWeWRHbHZiaUJtWVdsc1pXUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpTHdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xsUnlZVzV6Wm1WeVNHVnNjR1Z5TG5OaFptVlVjbUZ1YzJabGNpaDBiMnRsYmpvZ1lubDBaWE1zSUhSdk9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BVY21GdWMyWmxja2hsYkhCbGNpNXpZV1psVkhKaGJuTm1aWEk2Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHY21GNExuTnZiQzVVY21GdWMyWmxja2hsYkhCbGNpNXpZV1psVkhKaGJuTm1aWEpHY205dEtIUnZhMlZ1T2lCaWVYUmxjeXdnWm5KdmJUb2dZbmwwWlhNc0lIUnZPaUJpZVhSbGN5d2dkbUZzZFdVNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwVWNtRnVjMlpsY2tobGJIQmxjaTV6WVdabFZISmhibk5tWlhKR2NtOXRPZ29nSUNBZ2NISnZkRzhnTkNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VYMTl3YjNOMFNXNXBkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2w5ZmNHOXpkRWx1YVhRNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQmllWFJsWXlBME5TQXZMeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklGOWZjRzl6ZEVsdWFYUWdZV3h5WldGa2VTQmpZV3hzWldRS0lDQWdJR0o1ZEdWaklEUTFJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh6SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnSVQwS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWVhOelpYSjBJQzh2SUU5M2JtVnlJR0ZrWkhKbGMzTWdZMkZ1Ym05MElHSmxJREFLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklHSmhjMlV6TWlneVRFZFFSa1ZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJLUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNBaFBRb2dJQ0FnWW5vZ1gxOXdiM04wU1c1cGRGOWliMjlzWDJaaGJITmxRRGNLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmllWFJsWTE4eklDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ0lUMEtJQ0FnSUdKNklGOWZjRzl6ZEVsdWFYUmZZbTl2YkY5bVlXeHpaVUEzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZbmwwWldOZk15QXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lDRTlDaUFnSUNCaWVpQmZYM0J2YzNSSmJtbDBYMkp2YjJ4ZlptRnNjMlZBTndvZ0lDQWdaSFZ3Q2lBZ0lDQmllaUJmWDNCdmMzUkpibWwwWDJKdmIyeGZabUZzYzJWQU53b2dJQ0FnWkdsbklESUtJQ0FnSUdKNWRHVmpYek1nTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0FoUFFvZ0lDQWdZbm9nWDE5d2IzTjBTVzVwZEY5aWIyOXNYMlpoYkhObFFEY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENncGZYM0J2YzNSSmJtbDBYMkp2YjJ4ZmJXVnlaMlZBT0RvS0lDQWdJR0Z6YzJWeWRDQXZMeUJhWlhKdklHRmtaSEpsYzNNZ1pHVjBaV04wWldRS0lDQWdJR0o1ZEdWaklEUWdMeThnSWtaU1FWZ2lDaUFnSUNCa2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01UUWdMeThnSWtaWVV5SUtJQ0FnSUdScFp5QTJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBME55QXZMeUFpWm5KaGVGOWpiMjUwY21GamRGOWhaR1J5WlhOeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFE0SUM4dklDSm1lSE5mWTI5dWRISmhZM1JmWVdSa2NtVnpjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBME5pQXZMeUFpWTI5c2JHRjBaWEpoYkY5aFpHUnlaWE56SWdvZ0lDQWdaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luUnBiV1ZzYjJOclgyRmtaSEpsYzNNaUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiR3hoZEdWeVlXeGZkRzlyWlc0aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNallnTHk4Z0luQnZiMnhmWTJWcGJHbHVaeUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiR3hoZEdWeVlXeGZkRzlyWlc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJHeGhkR1Z5WVd4ZmRHOXJaVzRnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0k0TnpjNVpXVTNJQzh2SUcxbGRHaHZaQ0FpWkdWamFXMWhiSE1vS1hWcGJuUTJOQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdjSFZ6YUdsdWRDQXhPQW9nSUNBZ2FYUnZZZ29nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWW5SdmFRb2dJQ0FnYVhSdllnb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV6ZFdJS0lDQWdJR0o1ZEdWaklEWWdMeThnSW0xcGMzTnBibWRmWkdWamFXMWhiSE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTmhiR3h6ZFdJZ1gyZHlZVzUwVW05c1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5ScGJXVnNiMk5yWDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJwYldWc2IyTnJYMkZrWkhKbGMzTWdaWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTBPU0F2THlBd2VHTTJOVFV6TWpFNE5XVmtOekJpTW1VNU9UazBNek5sTW1VNVptRmpNVEkwWlRBNE0yRmpZakV6WldNeE9ETmhOR1V3TlRrME5HUmhNRGM1TWpNek4ySUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xtZHlZVzUwVW05c1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5ScGJXVnNiMk5yWDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJwYldWc2IyTnJYMkZrWkhKbGMzTWdaWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTFNQ0F2THlBd2VHRTROR0UxTXpnNVlXUTBNV1k1WVdGaU1EZ3pNV0l3TVdVMU16ZzBZMkZsTnpabE4yRTNabVF3T1RFek1XTXlNRFptWmpjNU1qZGpNakF4WXpNNE5UY0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xtZHlZVzUwVW05c1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5ScGJXVnNiMk5yWDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJwYldWc2IyTnJYMkZrWkhKbGMzTWdaWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTFNU0F2THlBd2VEZ3hNVGhsWldJMU1qTXhZVFZtWlRRd01EaGhOVFZpTmpJNE5qQm1ObUV3WkdJMFpqWmpNMkZqTURSbU9ERTBNVGt5TjJFNVlqTm1aV1JrT0Raa01tWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xtZHlZVzUwVW05c1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5ScGJXVnNiMk5yWDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJwYldWc2IyTnJYMkZrWkhKbGMzTWdaWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTFNaUF2THlBd2VERXdNMlJoTnpsbVpqTTNOVFZtWmpkaE1UZGhOVFUzWkRJNFlqY3paRE0zWTJJMFpHVXdZak5qTTJOak1ESm1ZVFpqTkRoa1pqQm1NelV3TnpGbVltWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xtZHlZVzUwVW05c1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5ScGJXVnNiMk5yWDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJwYldWc2IyTnJYMkZrWkhKbGMzTWdaWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTFNeUF2THlBd2VHSmlNbU0yT0dJNFpHTTFZbU5qWkdReU5UTTJNekEzTURnd1lUYzROalZoTjJVeE16TmlaalUwWlRNeFpEUmtORFl6WWpGaU56UTVZalJpWTJZeU5tUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xtZHlZVzUwVW05c1pRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tYMTl3YjNOMFNXNXBkRjlpYjI5c1gyWmhiSE5sUURjNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJmWDNCdmMzUkpibWwwWDJKdmIyeGZiV1Z5WjJWQU9Bb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNUdjbUY0VUc5dmJDNWpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURFeUNpQWdJQ0JpZVhSbFl5QXlNQ0F2THlBaVkyOXNiR0YwWlhKaGJGQnlhV05sVUdGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmpiMnhzWVhSbGNtRnNVSEpwWTJWUVlYVnpaV1FnWlhocGMzUnpDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdOdmJHeGhkRVJ2Ykd4aGNrSmhiR0Z1WTJWZlpXeHpaVjlpYjJSNVFEa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWTI5c2JHRjBaWEpoYkY5MGIydGxiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjlzYkdGMFpYSmhiRjkwYjJ0bGJpQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNamtnTHk4Z2JXVjBhRzlrSUNKaVlXeGhibU5sVDJZb1lXUmtjbVZ6Y3lsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlkWEo1SURZS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd1lRb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltMXBjM05wYm1kZlpHVmphVzFoYkhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0F4TUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHMXBjM05wYm1kZlpHVmphVzFoYkhNZ1pYaHBjM1J6Q2dwamIyeHNZWFJFYjJ4c1lYSkNZV3hoYm1ObFgzZG9hV3hsWDNSdmNFQTBPZ29nSUNBZ1pHbG5JRGdLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWVpQmpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxYMkZtZEdWeVgzZG9hV3hsUURnS0lDQWdJR1JwWnlBNENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUdOdmJHeGhkRVJ2Ykd4aGNrSmhiR0Z1WTJWZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaR2xuSURFeUNpQWdJQ0JpS2dvZ0lDQWdZblZ5ZVNBMkNncGpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUdScFp5QTRDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF5Q2lBZ0lDQmlMd29nSUNBZ1luVnllU0E1Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR1IxY0FvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTVRJS0lDQWdJR0lnWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlY5M2FHbHNaVjkwYjNCQU5Bb0tZMjlzYkdGMFJHOXNiR0Z5UW1Gc1lXNWpaVjloWm5SbGNsOTNhR2xzWlVBNE9nb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblZ1WTJ4aGFXMWxaRkJ2YjJ4RGIyeHNZWFJsY21Gc0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMWJtTnNZV2x0WldSUWIyOXNRMjlzYkdGMFpYSmhiQ0JsZUdsemRITUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YzNWaUNpQWdJQ0JrYVdjZ05nb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV0ZFd3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU55QXZMeUFpY0dGMWMyVmtVSEpwWTJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhCaGRYTmxaRkJ5YVdObElHVjRhWE4wY3dvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXRkV3dLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbVJwZGdvS1kyOXNiR0YwUkc5c2JHRnlRbUZzWVc1alpWOWhablJsY2w5cGJteHBibVZrWHk5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNUdjbUY0VUc5dmJDNWpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxRREl6T2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21OdmJHeGhkRVJ2Ykd4aGNrSmhiR0Z1WTJWZlpXeHpaVjlpYjJSNVFEazZDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpUmxKQldDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1JsSkJXQ0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTlRRZ0x5OGdiV1YwYUc5a0lDSmxkR2hmZFhOa1gzQnlhV05sS0NsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmlkWEo1SURJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWW5WeWVTQTFDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRNR0VLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p0YVhOemFXNW5YMlJsWTJsdFlXeHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzFwYzNOcGJtZGZaR1ZqYVcxaGJITWdaWGhwYzNSekNncGpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxYM2RvYVd4bFgzUnZjRUF4TVRvS0lDQWdJR1JwWnlBM0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUGdvZ0lDQWdZbm9nWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlY5aFpuUmxjbDkzYUdsc1pVQXhOUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVFvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lub2dZMjlzYkdGMFJHOXNiR0Z5UW1Gc1lXNWpaVjloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQmlLZ29nSUNBZ1luVnllU0ExQ2dwamIyeHNZWFJFYjJ4c1lYSkNZV3hoYm1ObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRNkNpQWdJQ0JrYVdjZ053b2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3dNZ29nSUNBZ1lpOEtJQ0FnSUdKMWNua2dPQW9nSUNBZ1pHbG5JREV3Q2lBZ0lDQmtkWEFLSUNBZ0lHSXFDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQmlJR052Ykd4aGRFUnZiR3hoY2tKaGJHRnVZMlZmZDJocGJHVmZkRzl3UURFeENncGpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxYMkZtZEdWeVgzZG9hV3hsUURFMU9nb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURNM0lDOHZJQ0ozWlhSb1gyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhkbGRHaGZZV1JrY21WemN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o1ZEdWaklESXhJQzh2SURCNE1HWTBNalF3Q2lBZ0lDQmthV2NnTndvZ0lDQWdZaW9LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRE0ySUM4dklDSmpiMnhzWVhSRmRHaFBjbUZqYkdVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJHeGhkRVYwYUU5eVlXTnNaU0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTlRVZ0x5OGdiV1YwYUc5a0lDSmpiMjV6ZFd4MEtHRmtaSEpsYzNNc2RXbHVkREkxTmlsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ013b2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YlhWc0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbVJwZGdvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU52Ykd4aGRHVnlZV3hmZEc5clpXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiR3hoZEdWeVlXeGZkRzlyWlc0Z1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWaklESTVJQzh2SUcxbGRHaHZaQ0FpWW1Gc1lXNWpaVTltS0dGa1pISmxjM01wZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1luVnllU0EwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJREI0TUdFS0lDQWdJR0oxY25rZ01UQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKdGFYTnphVzVuWDJSbFkybHRZV3h6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdKMWNua2dPQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUcxcGMzTnBibWRmWkdWamFXMWhiSE1nWlhocGMzUnpDZ3BqYjJ4c1lYUkViMnhzWVhKQ1lXeGhibU5sWDNkb2FXeGxYM1J2Y0VBeE9Eb0tJQ0FnSUdScFp5QTJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBnb2dJQ0FnWW5vZ1kyOXNiR0YwUkc5c2JHRnlRbUZzWVc1alpWOWhablJsY2w5M2FHbHNaVUF5TWdvZ0lDQWdaR2xuSURZS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlY5aFpuUmxjbDlwWmw5bGJITmxRREl4Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JpS2dvZ0lDQWdZblZ5ZVNBMENncGpiMnhzWVhSRWIyeHNZWEpDWVd4aGJtTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qRTZDaUFnSUNCa2FXY2dOZ29nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TWdvZ0lDQWdZaThLSUNBZ0lHSjFjbmtnTndvZ0lDQWdaR2xuSURrS0lDQWdJR1IxY0FvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTVRBS0lDQWdJR0lnWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlY5M2FHbHNaVjkwYjNCQU1UZ0tDbU52Ykd4aGRFUnZiR3hoY2tKaGJHRnVZMlZmWVdaMFpYSmZkMmhwYkdWQU1qSTZDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZFc1amJHRnBiV1ZrVUc5dmJFTnZiR3hoZEdWeVlXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIVnVZMnhoYVcxbFpGQnZiMnhEYjJ4c1lYUmxjbUZzSUdWNGFYTjBjd29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1emRXSUtJQ0FnSUdScFp5QTBDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG0xMWJBb2dJQ0FnWkdsbklETUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YlhWc0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVrYVhZS0lDQWdJR0lnWTI5c2JHRjBSRzlzYkdGeVFtRnNZVzVqWlY5aFpuUmxjbDlwYm14cGJtVmtYeTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1amIyeHNZWFJFYjJ4c1lYSkNZV3hoYm1ObFFESXpDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFp5WVhndWMyOXNMa1p5WVhoUWIyOXNMbUYyWVdsc1lXSnNaVVY0WTJWemMwTnZiR3hoZEVSV1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWFpoYVd4aFlteGxSWGhqWlhOelEyOXNiR0YwUkZZNkNpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1aGRtRnBiR0ZpYkdWRmVHTmxjM05EYjJ4c1lYUkVWZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VaMlYwUTI5c2JHRjBaWEpoYkZCeWFXTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFEyOXNiR0YwWlhKaGJGQnlhV05sT2dvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1WjJWMFEyOXNiR0YwWlhKaGJGQnlhV05sQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHY21GNExuTnZiQzVHY21GNFVHOXZiQzV6WlhSRGIyeHNZWFJGVkVoUGNtRmpiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkRiMnhzWVhSRlZFaFBjbUZqYkdVNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luUnBiV1ZzYjJOclgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhScGJXVnNiMk5yWDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklITmxkRU52Ykd4aGRFVlVTRTl5WVdOc1pWOWliMjlzWDNSeWRXVkFNd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2diM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lub2djMlYwUTI5c2JHRjBSVlJJVDNKaFkyeGxYMkp2YjJ4ZlptRnNjMlZBTkFvS2MyVjBRMjlzYkdGMFJWUklUM0poWTJ4bFgySnZiMnhmZEhKMVpVQXpPZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtDbk5sZEVOdmJHeGhkRVZVU0U5eVlXTnNaVjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElHOTNibVZ5SUc5eUlIUnBiV1ZzYjJOckNpQWdJQ0JpZVhSbFl5QTBOQ0F2THlBaVkyOXNiR0YwWDJWMGFGOXZjbUZqYkdWZllXUmtjbVZ6Y3lJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF6TmlBdkx5QWlZMjlzYkdGMFJYUm9UM0poWTJ4bElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRE0zSUM4dklDSjNaWFJvWDJGa1pISmxjM01pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuTmxkRU52Ykd4aGRFVlVTRTl5WVdOc1pWOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnpaWFJEYjJ4c1lYUkZWRWhQY21GamJHVmZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG0xcGJuUXhkREZHVWtGWVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiV2x1ZERGME1VWlNRVmc2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFNElDOHZJQ0p0YVc1MFVHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ0YVc1MFVHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUUxcGJuUnBibWNnYVhNZ2NHRjFjMlZrQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd1lRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW0xcGMzTnBibWRmWkdWamFXMWhiSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzFwYzNOcGJtZGZaR1ZqYVcxaGJITWdaWGhwYzNSekNncHRhVzUwTVhReFJsSkJXRjkzYUdsc1pWOTBiM0JBTWpvS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHSjZJRzFwYm5ReGRERkdVa0ZZWDJGbWRHVnlYM2RvYVd4bFFEWUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhDaUFnSUNCaUpnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0JpZWlCdGFXNTBNWFF4UmxKQldGOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWWlvS0lDQWdJR0oxY25rZ013b0tiV2x1ZERGME1VWlNRVmhmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF5Q2lBZ0lDQmlMd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlLZ29nSUNBZ1luVnllU0F5Q2lBZ0lDQmlJRzFwYm5ReGRERkdVa0ZZWDNkb2FXeGxYM1J2Y0VBeUNncHRhVzUwTVhReFJsSkJXRjloWm5SbGNsOTNhR2xzWlVBMk9nb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEUUtJQ0FnSUdJcUNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlSbEpCV0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUmxKQldDQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z2JXVjBhRzlrSUNKbmJHOWlZV3hmWTI5c2JHRjBaWEpoYkY5eVlYUnBieWdwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWW5sMFpXTWdNakVnTHk4Z01IZ3daalF5TkRBS0lDQWdJR0krUFFvZ0lDQWdZWE56WlhKMElDOHZJRU52Ykd4aGRHVnlZV3dnY21GMGFXOGdiWFZ6ZENCaVpTQStQU0F4Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiR3hoZEdWeVlXeGZkRzlyWlc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJHeGhkR1Z5WVd4ZmRHOXJaVzRnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURJNUlDOHZJRzFsZEdodlpDQWlZbUZzWVc1alpVOW1LR0ZrWkhKbGMzTXBkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjFibU5zWVdsdFpXUlFiMjlzUTI5c2JHRjBaWEpoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZFc1amJHRnBiV1ZrVUc5dmJFTnZiR3hoZEdWeVlXd2daWGhwYzNSekNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9Mbk4xWWdvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VZV1JrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWpZZ0x5OGdJbkJ2YjJ4ZlkyVnBiR2x1WnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY0c5dmJGOWpaV2xzYVc1bklHVjRhWE4wY3dvZ0lDQWdZanc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdXMUJ2YjJ3bmN5QkRiRzl6WldSZE9pQkRaV2xzYVc1bklISmxZV05vWldRS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG1kbGRFTnZiR3hoZEdWeVlXeFFjbWxqWlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQkdjbUY0VUc5dmJFeHBZbkpoY25rdVkyRnNZMDFwYm5ReGRERkdVa0ZZQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TURBd01Bb2dJQ0FnYVhSdllnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklESTBJQzh2SUNKdGFXNTBhVzVuWDJabFpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2JXbHVkR2x1WjE5bVpXVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV6ZFdJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1dGRXd0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WkdsMkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklERUtJQ0FnSUdJOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZOc2FYQndZV2RsSUd4cGJXbDBJSEpsWVdOb1pXUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKamIyeHNZWFJsY21Gc1gzUnZhMlZ1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjJ4c1lYUmxjbUZzWDNSdmEyVnVJR1Y0YVhOMGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyRnNiSE4xWWlCVWNtRnVjMlpsY2tobGJIQmxjaTV6WVdabFZISmhibk5tWlhKR2NtOXRDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSWtaU1FWZ2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFWlNRVmdnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURNd0lDOHZJRzFsZEdodlpDQWljRzl2YkY5dGFXNTBLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ3dWJXbHVkRUZzWjI5eWFYUm9iV2xqUmxKQldGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTFwYm5SQmJHZHZjbWwwYUcxcFkwWlNRVmc2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFNElDOHZJQ0p0YVc1MFVHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ0YVc1MFVHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUUxcGJuUnBibWNnYVhNZ2NHRjFjMlZrQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVJsSkJXQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSbEpCV0NCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBek1TQXZMeUJ0WlhSb2IyUWdJbVo0YzE5d2NtbGpaU2dwZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBeE5pQXZMeUJ0WlhSb2IyUWdJbWRzYjJKaGJGOWpiMnhzWVhSbGNtRnNYM0poZEdsdktDbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiMnhzWVhSbGNtRnNJSEpoZEdsdklHMTFjM1FnWW1VZ01Bb2dJQ0FnWkdsbklETUtJQ0FnSUdOaGJHeHpkV0lnUm5KaGVGQnZiMnhNYVdKeVlYSjVMbU5oYkdOTmFXNTBRV3huYjNKcGRHaHRhV05HVWtGWUNpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREkwSUM4dklDSnRhVzUwYVc1blgyWmxaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2diV2x1ZEdsdVoxOW1aV1VnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1emRXSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXRkV3dLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndVpHbDJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBeENpQWdJQ0JpUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUYkdsd2NHRm5aU0JzYVcxcGRDQnlaV0ZqYUdWa0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJa1pZVXlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUmxoVElHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXpNaUF2THlCdFpYUm9iMlFnSW5CdmIyeGZZblZ5Ymw5bWNtOXRLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRE13SUM4dklHMWxkR2h2WkNBaWNHOXZiRjl0YVc1MEtHRmtaSEpsYzNNc2RXbHVkREkxTmlsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1YldsdWRFWnlZV04wYVc5dVlXeEdVa0ZZVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JXbHVkRVp5WVdOMGFXOXVZV3hHVWtGWU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbTFwYm5SUVlYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzFwYm5SUVlYVnpaV1FnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVFdsdWRHbHVaeUJwY3lCd1lYVnpaV1FLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKR1VrRllJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkdVa0ZZSUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURNeElDOHZJRzFsZEdodlpDQWlabmh6WDNCeWFXTmxLQ2wxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdiV1YwYUc5a0lDSm5iRzlpWVd4ZlkyOXNiR0YwWlhKaGJGOXlZWFJwYnlncGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZeUF5TVNBdkx5QXdlREJtTkRJME1Bb2dJQ0FnWWp3S0lDQWdJR0o2SUcxcGJuUkdjbUZqZEdsdmJtRnNSbEpCV0Y5aWIyOXNYMlpoYkhObFFEWUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWo0S0lDQWdJR0o2SUcxcGJuUkdjbUZqZEdsdmJtRnNSbEpCV0Y5aWIyOXNYMlpoYkhObFFEWUtJQ0FnSUdsdWRHTmZNaUF2THlBeENncHRhVzUwUm5KaFkzUnBiMjVoYkVaU1FWaGZZbTl2YkY5dFpYSm5aVUEzT2dvZ0lDQWdZWE56WlhKMElDOHZJRU52Ykd4aGRHVnlZV3dnY21GMGFXOGdibVZsWkhNZ2RHOGdZbVVnWW1WMGQyVmxiaUF1TURBd01EQXhJR0Z1WkNBdU9UazVPVGs1Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiR3hoZEdWeVlXeGZkRzlyWlc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJHeGhkR1Z5WVd4ZmRHOXJaVzRnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURJNUlDOHZJRzFsZEdodlpDQWlZbUZzWVc1alpVOW1LR0ZrWkhKbGMzTXBkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjFibU5zWVdsdFpXUlFiMjlzUTI5c2JHRjBaWEpoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZFc1amJHRnBiV1ZrVUc5dmJFTnZiR3hoZEdWeVlXd2daWGhwYzNSekNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9Mbk4xWWdvZ0lDQWdaR2xuSURZS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VZV1JrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWpZZ0x5OGdJbkJ2YjJ4ZlkyVnBiR2x1WnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY0c5dmJGOWpaV2xzYVc1bklHVjRhWE4wY3dvZ0lDQWdZanc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVRzl2YkNCalpXbHNhVzVuSUhKbFlXTm9aV1FzSUc1dklHMXZjbVVnUmxKQldDQmpZVzRnWW1VZ2JXbHVkR1ZrSUhkcGRHZ2dkR2hwY3lCamIyeHNZWFJsY21Gc0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUdKMWNua2dOd29nSUNBZ1lubDBaV01nT1NBdkx5QXdlREJoQ2lBZ0lDQmlkWEo1SURrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p0YVhOemFXNW5YMlJsWTJsdFlXeHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzFwYzNOcGJtZGZaR1ZqYVcxaGJITWdaWGhwYzNSekNncHRhVzUwUm5KaFkzUnBiMjVoYkVaU1FWaGZkMmhwYkdWZmRHOXdRRGs2Q2lBZ0lDQmthV2NnTndvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHSjZJRzFwYm5SR2NtRmpkR2x2Ym1Gc1JsSkJXRjloWm5SbGNsOTNhR2xzWlVBeE13b2dJQ0FnWkdsbklEY0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1lpWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWW5vZ2JXbHVkRVp5WVdOMGFXOXVZV3hHVWtGWVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0lDQWdJR1JwWnlBMkNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWWlvS0lDQWdJR0oxY25rZ053b0tiV2x1ZEVaeVlXTjBhVzl1WVd4R1VrRllYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNCa2FXY2dOd29nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TWdvZ0lDQWdZaThLSUNBZ0lHSjFjbmtnT0FvZ0lDQWdaR2xuSURnS0lDQWdJR1IxY0FvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnT1FvZ0lDQWdZaUJ0YVc1MFJuSmhZM1JwYjI1aGJFWlNRVmhmZDJocGJHVmZkRzl3UURrS0NtMXBiblJHY21GamRHbHZibUZzUmxKQldGOWhablJsY2w5M2FHbHNaVUF4TXpvS0lDQWdJR1JwWnlBMUNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBNENpQWdJQ0JpS2dvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1WjJWMFEyOXNiR0YwWlhKaGJGQnlhV05sQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNd29nSUNBZ1lud0tJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURVS0lDQWdJR1JwWnlBMENpQWdJQ0JpZkFvZ0lDQWdaR2xuSURnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBMUNpQWdJQ0JpZkFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdOaGJHeHpkV0lnUm5KaGVGQnZiMnhNYVdKeVlYSjVMbU5oYkdOTmFXNTBSbkpoWTNScGIyNWhiRVpTUVZnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJHY21GNFVHOXZiRXhwWW5KaGNua3VZMkZzWTAxcGJuUkdjbUZqZEdsdmJtRnNSbEpCV0FvZ0lDQWdjRzl3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01EQXdDaUFnSUNCcGRHOWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNalFnTHk4Z0ltMXBiblJwYm1kZlptVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnRhVzUwYVc1blgyWmxaU0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtMTFiQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUdScFp5QTNDaUFnSUNCa2FXY2dNUW9nSUNBZ1lqdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1UyeHBjSEJoWjJVZ2JHbHRhWFFnY21WaFkyaGxaQW9nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWWp3OUNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElHVnViM1ZuYUNCR1dGTWdhVzV3ZFhSMFpXUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKR1dGTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFWllVeUJsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTXpJZ0x5OGdiV1YwYUc5a0lDSndiMjlzWDJKMWNtNWZabkp2YlNoaFpHUnlaWE56TEhWcGJuUXlOVFlwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVkyOXNiR0YwWlhKaGJGOTBiMnRsYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWTI5c2JHRjBaWEpoYkY5MGIydGxiaUJsZUdsemRITUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTmhiR3h6ZFdJZ1ZISmhibk5tWlhKSVpXeHdaWEl1YzJGbVpWUnlZVzV6Wm1WeVJuSnZiUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpUmxKQldDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1JsSkJXQ0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTXpBZ0x5OGdiV1YwYUc5a0lDSndiMjlzWDIxcGJuUW9ZV1JrY21WemN5eDFhVzUwTWpVMktYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXbHVkRVp5WVdOMGFXOXVZV3hHVWtGWVgySnZiMnhmWm1Gc2MyVkFOam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHMXBiblJHY21GamRHbHZibUZzUmxKQldGOWliMjlzWDIxbGNtZGxRRGNLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1Y21Wa1pXVnRNWFF4UmxKQldGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWkdWbGJURjBNVVpTUVZnNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTVJQzh2SUNKeVpXUmxaVzFRWVhWelpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklISmxaR1ZsYlZCaGRYTmxaQ0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWldSbFpXMXBibWNnYVhNZ2NHRjFjMlZrQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVJsSkJXQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSbEpCV0NCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ01UWWdMeThnYldWMGFHOWtJQ0puYkc5aVlXeGZZMjlzYkdGMFpYSmhiRjl5WVhScGJ5Z3BkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZbmwwWldNZ01qRWdMeThnTUhnd1pqUXlOREFLSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFTnZiR3hoZEdWeVlXd2djbUYwYVc4Z2JYVnpkQ0JpWlNBOVBTQXhDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3WVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbTFwYzNOcGJtZGZaR1ZqYVcxaGJITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHMXBjM05wYm1kZlpHVmphVzFoYkhNZ1pYaHBjM1J6Q2dweVpXUmxaVzB4ZERGR1VrRllYM2RvYVd4bFgzUnZjRUF6T2dvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lub2djbVZrWldWdE1YUXhSbEpCV0Y5aFpuUmxjbDkzYUdsc1pVQTNDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1lpWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWW5vZ2NtVmtaV1Z0TVhReFJsSkJXRjloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1lpb0tJQ0FnSUdKMWNua2dNd29LY21Wa1pXVnRNWFF4UmxKQldGOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1ESUtJQ0FnSUdJdkNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdJcUNpQWdJQ0JpZFhKNUlESUtJQ0FnSUdJZ2NtVmtaV1Z0TVhReFJsSkJXRjkzYUdsc1pWOTBiM0JBTXdvS2NtVmtaV1Z0TVhReFJsSkJXRjloWm5SbGNsOTNhR2xzWlVBM09nb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEUUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WkdsMkNpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1blpYUkRiMnhzWVhSbGNtRnNVSEpwWTJVS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdSbkpoZUZCdmIyeE1hV0p5WVhKNUxtTmhiR05TWldSbFpXMHhkREZHVWtGWUNpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREkxSUM4dklDSnlaV1JsYlhCMGFXOXVYMlpsWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21Wa1pXMXdkR2x2Ymw5bVpXVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV6ZFdJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1dGRXd0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WkdsMkNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU52Ykd4aGRHVnlZV3hmZEc5clpXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiR3hoZEdWeVlXeGZkRzlyWlc0Z1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWaklESTVJQzh2SUcxbGRHaHZaQ0FpWW1Gc1lXNWpaVTltS0dGa1pISmxjM01wZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0oxYm1Oc1lXbHRaV1JRYjI5c1EyOXNiR0YwWlhKaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1emRXSUtJQ0FnSUdScFp5QXlDaUFnSUNCaVBqMEtJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUWdaVzV2ZFdkb0lHTnZiR3hoZEdWeVlXd2dhVzRnY0c5dmJBb2dJQ0FnWkdsbklEWUtJQ0FnSUdScFp5QXlDaUFnSUNCaVBEMEtJQ0FnSUdGemMyVnlkQ0F2THlCVGJHbHdjR0ZuWlNCc2FXMXBkQ0J5WldGamFHVmtDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJREl5SUM4dklDSnlaV1JsWlcxRGIyeHNZWFJsY21Gc1FtRnNZVzVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WVdSa0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklESXlJQzh2SUNKeVpXUmxaVzFEYjJ4c1lYUmxjbUZzUW1Gc1lXNWpaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1Ga1pBb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdaMnh2WW1Gc0lGSnZkVzVrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURReklDOHZJQ0pzWVhOMFVtVmtaV1Z0WldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lrWlNRVmdpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRVpTUVZnZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWaklETXlJQzh2SUcxbGRHaHZaQ0FpY0c5dmJGOWlkWEp1WDJaeWIyMG9ZV1JrY21WemN5eDFhVzUwTWpVMktYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1eVpXUmxaVzFHY21GamRHbHZibUZzUmxKQldGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWkdWbGJVWnlZV04wYVc5dVlXeEdVa0ZZT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjRzRnTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREU1SUM4dklDSnlaV1JsWlcxUVlYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEpsWkdWbGJWQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pXUmxaVzFwYm1jZ2FYTWdjR0YxYzJWa0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlSbEpCV0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUmxKQldDQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXpNU0F2THlCdFpYUm9iMlFnSW1aNGMxOXdjbWxqWlNncGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWaklERTJJQzh2SUcxbGRHaHZaQ0FpWjJ4dlltRnNYMk52Ykd4aGRHVnlZV3hmY21GMGFXOG9LWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldNZ01qRWdMeThnTUhnd1pqUXlOREFLSUNBZ0lHSThDaUFnSUNCaWVpQnlaV1JsWlcxR2NtRmpkR2x2Ym1Gc1JsSkJXRjlpYjI5c1gyWmhiSE5sUURZS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHSjZJSEpsWkdWbGJVWnlZV04wYVc5dVlXeEdVa0ZZWDJKdmIyeGZabUZzYzJWQU5nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0NuSmxaR1ZsYlVaeVlXTjBhVzl1WVd4R1VrRllYMkp2YjJ4ZmJXVnlaMlZBTnpvS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYjJ4c1lYUmxjbUZzSUhKaGRHbHZJRzVsWldSeklIUnZJR0psSUdKbGRIZGxaVzRnTGpBd01EQXdNU0JoYm1RZ0xqazVPVGs1T1FvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1WjJWMFEyOXNiR0YwWlhKaGJGQnlhV05sQ2lBZ0lDQmlkWEo1SURnS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01EQXdDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREkxSUM4dklDSnlaV1JsYlhCMGFXOXVYMlpsWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21Wa1pXMXdkR2x2Ymw5bVpXVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV6ZFdJS0lDQWdJR1JwWnlBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9MbTExYkFvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3VaR2wyQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRRS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3ViWFZzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNWthWFlLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWMzVmlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG0xMWJBb2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WkdsMkNpQWdJQ0JpZFhKNUlEY0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1luVnllU0E1Q2lBZ0lDQmllWFJsWXlBNUlDOHZJREI0TUdFS0lDQWdJR0oxY25rZ01URUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKdGFYTnphVzVuWDJSbFkybHRZV3h6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdGFYTnphVzVuWDJSbFkybHRZV3h6SUdWNGFYTjBjd29LY21Wa1pXVnRSbkpoWTNScGIyNWhiRVpTUVZoZmQyaHBiR1ZmZEc5d1FEZzZDaUFnSUNCa2FXY2dPUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNklISmxaR1ZsYlVaeVlXTjBhVzl1WVd4R1VrRllYMkZtZEdWeVgzZG9hV3hsUURFeUNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhDaUFnSUNCaUpnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0JpZWlCeVpXUmxaVzFHY21GamRHbHZibUZzUmxKQldGOWhablJsY2w5cFpsOWxiSE5sUURFeENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWkdsbklERXhDaUFnSUNCaUtnb2dJQ0FnWW5WeWVTQTVDZ3B5WldSbFpXMUdjbUZqZEdsdmJtRnNSbEpCV0Y5aFpuUmxjbDlwWmw5bGJITmxRREV4T2dvZ0lDQWdaR2xuSURrS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1ESUtJQ0FnSUdJdkNpQWdJQ0JpZFhKNUlERXdDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHUjFjQW9nSUNBZ1lpb0tJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHSWdjbVZrWldWdFJuSmhZM1JwYjI1aGJFWlNRVmhmZDJocGJHVmZkRzl3UURnS0NuSmxaR1ZsYlVaeVlXTjBhVzl1WVd4R1VrRllYMkZtZEdWeVgzZG9hV3hsUURFeU9nb2dJQ0FnWkdsbklERXhDaUFnSUNCa2FXY2dPUW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG0xMWJBb2dJQ0FnWkdsbklEWUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YlhWc0NpQWdJQ0JrYVdjZ09Bb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVrYVhZS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZMjlzYkdGMFpYSmhiRjkwYjJ0bGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1kyOXNiR0YwWlhKaGJGOTBiMnRsYmlCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ01qa2dMeThnYldWMGFHOWtJQ0ppWVd4aGJtTmxUMllvWVdSa2NtVnpjeWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblZ1WTJ4aGFXMWxaRkJ2YjJ4RGIyeHNZWFJsY21Gc0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMWJtTnNZV2x0WldSUWIyOXNRMjlzYkdGMFpYSmhiQ0JsZUdsemRITUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnWkdsbklESUtJQ0FnSUdJK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUU1dmRDQmxibTkxWjJnZ1kyOXNiR0YwWlhKaGJDQnBiaUJ3YjI5c0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklESUtJQ0FnSUdJOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZOc2FYQndZV2RsSUd4cGJXbDBJSEpsWVdOb1pXUWdXMk52Ykd4aGRHVnlZV3hkQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaR2xuSURrS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWWp3OUNpQWdJQ0JoYzNObGNuUWdMeThnVTJ4cGNIQmhaMlVnYkdsdGFYUWdjbVZoWTJobFpDQmJSbGhUWFFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeU1pQXZMeUFpY21Wa1pXVnRRMjlzYkdGMFpYSmhiRUpoYkdGdVkyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtRmtaQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF5TWlBdkx5QWljbVZrWldWdFEyOXNiR0YwWlhKaGJFSmhiR0Z1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNWhaR1FLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblZ1WTJ4aGFXMWxaRkJ2YjJ4RGIyeHNZWFJsY21Gc0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNak1nTHk4Z0luSmxaR1ZsYlVaWVUwSmhiR0Z1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1Ga1pBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXlNeUF2THlBaWNtVmtaV1Z0UmxoVFFtRnNZVzVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJblZ1WTJ4aGFXMWxaRkJ2YjJ4R1dGTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIVnVZMnhoYVcxbFpGQnZiMnhHV0ZNZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNWhaR1FLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0oxYm1Oc1lXbHRaV1JRYjI5c1JsaFRJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUEwTXlBdkx5QWliR0Z6ZEZKbFpHVmxiV1ZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlSbEpCV0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUmxKQldDQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNeklnTHk4Z2JXVjBhRzlrSUNKd2IyOXNYMkoxY201ZlpuSnZiU2hoWkdSeVpYTnpMSFZwYm5ReU5UWXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pHV0ZNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVaWVV5QmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNekFnTHk4Z2JXVjBhRzlrSUNKd2IyOXNYMjFwYm5Rb1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY21Wa1pXVnRSbkpoWTNScGIyNWhiRVpTUVZoZlltOXZiRjltWVd4elpVQTJPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2NtVmtaV1Z0Um5KaFkzUnBiMjVoYkVaU1FWaGZZbTl2YkY5dFpYSm5aVUEzQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG5KbFpHVmxiVUZzWjI5eWFYUm9iV2xqUmxKQldGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWkdWbGJVRnNaMjl5YVhSb2JXbGpSbEpCV0RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01Ua2dMeThnSW5KbFpHVmxiVkJoZFhObFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2NtVmtaV1Z0VUdGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRkpsWkdWbGJXbHVaeUJwY3lCd1lYVnpaV1FLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKR1VrRllJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkdVa0ZZSUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURNeElDOHZJRzFsZEdodlpDQWlabmh6WDNCeWFXTmxLQ2wxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdiV1YwYUc5a0lDSm5iRzlpWVd4ZlkyOXNiR0YwWlhKaGJGOXlZWFJwYnlncGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1EyOXNiR0YwWlhKaGJDQnlZWFJwYnlCdGRYTjBJR0psSURBS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01EQXdDaUFnSUNCcGRHOWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNalVnTHk4Z0luSmxaR1Z0Y0hScGIyNWZabVZsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ5WldSbGJYQjBhVzl1WDJabFpTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9Mbk4xWWdvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHZ3ViWFZzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNWthWFlLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndWJYVnNDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1ScGRnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXlNeUF2THlBaWNtVmtaV1Z0UmxoVFFtRnNZVzVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklERUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1WVdSa0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklESXpJQzh2SUNKeVpXUmxaVzFHV0ZOQ1lXeGhibU5sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWlkVzVqYkdGcGJXVmtVRzl2YkVaWVV5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RXNWpiR0ZwYldWa1VHOXZiRVpZVXlCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb0xtRmtaQW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJblZ1WTJ4aGFXMWxaRkJ2YjJ4R1dGTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJRFF6SUM4dklDSnNZWE4wVW1Wa1pXVnRaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lqdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1UyeHBjSEJoWjJVZ2JHbHRhWFFnY21WaFkyaGxaQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSWtaU1FWZ2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFWlNRVmdnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURNeUlDOHZJRzFsZEdodlpDQWljRzl2YkY5aWRYSnVYMlp5YjIwb1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaVJsaFRJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkdXRk1nWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURNd0lDOHZJRzFsZEdodlpDQWljRzl2YkY5dGFXNTBLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ3dVkyOXNiR1ZqZEZKbFpHVnRjSFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMnhzWldOMFVtVmtaVzF3ZEdsdmJqb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ05ETWdMeThnSW14aGMzUlNaV1JsWlcxbFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOREVnTHk4Z0luSmxaR1Z0Y0hScGIyNWZaR1ZzWVhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhKbFpHVnRjSFJwYjI1ZlpHVnNZWGtnWlhocGMzUnpDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1Ga1pBb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JwZEc5aUNpQWdJQ0JpUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMElIZGhhWFFnWm05eUlISmxaR1Z0Y0hScGIyNWZaR1ZzWVhrZ1lteHZZMnR6SUdKbFptOXlaU0JqYjJ4c1pXTjBhVzVuSUhKbFpHVnRjSFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2wwYjJJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01qTWdMeThnSW5KbFpHVmxiVVpZVTBKaGJHRnVZMlZ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0krQ2lBZ0lDQmlibm9nWTI5c2JHVmpkRkpsWkdWdGNIUnBiMjVmYVdaZlltOWtlVUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTkFvS1kyOXNiR1ZqZEZKbFpHVnRjSFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeU1pQXZMeUFpY21Wa1pXVnRRMjlzYkdGMFpYSmhiRUpoYkdGdVkyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWJub2dZMjlzYkdWamRGSmxaR1Z0Y0hScGIyNWZhV1pmWW05a2VVQTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOUW9LWTI5c2JHVmpkRkpsWkdWdGNIUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ1pHbG5JRElLSUNBZ0lHSjZJR052Ykd4bFkzUlNaV1JsYlhCMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU53b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKR1dGTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFWllVeUJsZUdsemRITUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBMUNpQWdJQ0JqWVd4c2MzVmlJRlJ5WVc1elptVnlTR1ZzY0dWeUxuTmhabVZVY21GdWMyWmxjZ29LWTI5c2JHVmpkRkpsWkdWdGNIUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjZJR052Ykd4bFkzUlNaV1JsYlhCMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1OdmJHeGhkR1Z5WVd4ZmRHOXJaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052Ykd4aGRHVnlZV3hmZEc5clpXNGdaWGhwYzNSekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTmdvZ0lDQWdZMkZzYkhOMVlpQlVjbUZ1YzJabGNraGxiSEJsY2k1ellXWmxWSEpoYm5ObVpYSUtDbU52Ykd4bFkzUlNaV1JsYlhCMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU9Ub0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU52Ykd4bFkzUlNaV1JsYlhCMGFXOXVYMmxtWDJKdlpIbEFORG9LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTWpJZ0x5OGdJbkpsWkdWbGJVTnZiR3hoZEdWeVlXeENZV3hoYm1ObGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF5TWlBdkx5QWljbVZrWldWdFEyOXNiR0YwWlhKaGJFSmhiR0Z1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0oxYm1Oc1lXbHRaV1JRYjI5c1EyOXNiR0YwWlhKaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZaUJqYjJ4c1pXTjBVbVZrWlcxd2RHbHZibDloWm5SbGNsOXBabDlsYkhObFFEVUtDbU52Ykd4bFkzUlNaV1JsYlhCMGFXOXVYMmxtWDJKdlpIbEFNam9LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTWpNZ0x5OGdJbkpsWkdWbGJVWllVMEpoYkdGdVkyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURJeklDOHZJQ0p5WldSbFpXMUdXRk5DWVd4aGJtTmxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1JwWnlBeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0luVnVZMnhoYVcxbFpGQnZiMnhHV0ZNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhWdVkyeGhhVzFsWkZCdmIyeEdXRk1nWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0luVnVZMnhoYVcxbFpGQnZiMnhHV0ZNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR0oxY25rZ013b2dJQ0FnWWlCamIyeHNaV04wVW1Wa1pXMXdkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1Y21WamIyeHNZWFJsY21Gc2FYcGxSbEpCV0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZMjlzYkdGMFpYSmhiR2w2WlVaU1FWZzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd2JpQTFDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRE0wSUM4dklDSnlaV052Ykd4aGRHVnlZV3hwZW1WUVlYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEpsWTI5c2JHRjBaWEpoYkdsNlpWQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pXTnZiR3hoZEdWeVlXeHBlbVVnYVhNZ2NHRjFjMlZrQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd1lRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW0xcGMzTnBibWRmWkdWamFXMWhiSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzFwYzNOcGJtZGZaR1ZqYVcxaGJITWdaWGhwYzNSekNncHlaV052Ykd4aGRHVnlZV3hwZW1WR1VrRllYM2RvYVd4bFgzUnZjRUF5T2dvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lub2djbVZqYjJ4c1lYUmxjbUZzYVhwbFJsSkJXRjloWm5SbGNsOTNhR2xzWlVBMkNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nY21WamIyeHNZWFJsY21Gc2FYcGxSbEpCV0Y5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTXdvS2NtVmpiMnhzWVhSbGNtRnNhWHBsUmxKQldGOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1ESUtJQ0FnSUdJdkNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdJcUNpQWdJQ0JpZFhKNUlESUtJQ0FnSUdJZ2NtVmpiMnhzWVhSbGNtRnNhWHBsUmxKQldGOTNhR2xzWlY5MGIzQkFNZ29LY21WamIyeHNZWFJsY21Gc2FYcGxSbEpCV0Y5aFpuUmxjbDkzYUdsc1pVQTJPZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlLZ29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSWtaU1FWZ2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFWlNRVmdnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTXpFZ0x5OGdiV1YwYUc5a0lDSm1lSE5mY0hKcFkyVW9LWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdKMWNua2dPQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTlRZZ0x5OGdiV1YwYUc5a0lDSjBiM1JoYkZOMWNIQnNlU2dwZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBeE5pQXZMeUJ0WlhSb2IyUWdJbWRzYjJKaGJGOWpiMnhzWVhSbGNtRnNYM0poZEdsdktDbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUExTnlBdkx5QnRaWFJvYjJRZ0ltZHNiMkpoYkVOdmJHeGhkR1Z5WVd4V1lXeDFaU2dwZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VaMlYwUTI5c2JHRjBaWEpoYkZCeWFXTmxDaUFnSUNCa2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUExQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZMkZzYkhOMVlpQkdjbUY0VUc5dmJFeHBZbkpoY25rdVkyRnNZMUpsWTI5c2JHRjBaWEpoYkdsNlpVWlNRVmhKYm01bGNnb2dJQ0FnY0c5d0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNUdjbUY0VUc5dmJDNW5aWFJEYjJ4c1lYUmxjbUZzVUhKcFkyVUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyRnNiSE4xWWlCR2NtRjRVRzl2YkV4cFluSmhjbmt1WTJGc1kxSmxZMjlzYkdGMFpYSmhiR2w2WlVaU1FWaEpibTVsY2dvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWW5WeWVTQTVDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRNR0VLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p0YVhOemFXNW5YMlJsWTJsdFlXeHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR0oxY25rZ01URUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ0YVhOemFXNW5YMlJsWTJsdFlXeHpJR1Y0YVhOMGN3b0tjbVZqYjJ4c1lYUmxjbUZzYVhwbFJsSkJXRjkzYUdsc1pWOTBiM0JBTVRFNkNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWo0S0lDQWdJR0o2SUhKbFkyOXNiR0YwWlhKaGJHbDZaVVpTUVZoZllXWjBaWEpmZDJocGJHVkFNVFVLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0ltQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJSEpsWTI5c2JHRjBaWEpoYkdsNlpVWlNRVmhmWVdaMFpYSmZhV1pmWld4elpVQXhOQW9nSUNBZ1pHbG5JRGdLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnT1FvS2NtVmpiMnhzWVhSbGNtRnNhWHBsUmxKQldGOWhablJsY2w5cFpsOWxiSE5sUURFME9nb2dJQ0FnWkdsbklEa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjRNRElLSUNBZ0lHSXZDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR1IxY0FvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR0lnY21WamIyeHNZWFJsY21Gc2FYcGxSbEpCV0Y5M2FHbHNaVjkwYjNCQU1URUtDbkpsWTI5c2JHRjBaWEpoYkdsNlpVWlNRVmhmWVdaMFpYSmZkMmhwYkdWQU1UVTZDaUFnSUNCa2FXY2dOZ29nSUNBZ1pHbG5JRGtLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndVpHbDJDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNREF3TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRd0lDOHZJQ0ppYjI1MWMxOXlZWFJsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJpYjI1MWMxOXlZWFJsSUdWNGFYTjBjd29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1aFpHUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXpPU0F2THlBaWNtVmpiMnhzWVhSZlptVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnlaV052Ykd4aGRGOW1aV1VnWlhocGMzUnpDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnWkdsbklEa0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YlhWc0NpQWdJQ0JrYVdjZ053b2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzVrYVhZS0lDQWdJR1JwWnlBMUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWp3OUNpQWdJQ0JoYzNObGNuUWdMeThnVTJ4cGNIQmhaMlVnYkdsdGFYUWdjbVZoWTJobFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1OdmJHeGhkR1Z5WVd4ZmRHOXJaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052Ykd4aGRHVnlZV3hmZEc5clpXNGdaWGhwYzNSekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCallXeHNjM1ZpSUZSeVlXNXpabVZ5U0dWc2NHVnlMbk5oWm1WVWNtRnVjMlpsY2taeWIyMEtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UUWdMeThnSWtaWVV5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1JsaFRJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF6TUNBdkx5QnRaWFJvYjJRZ0luQnZiMnhmYldsdWRDaGhaR1J5WlhOekxIVnBiblF5TlRZcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG1KMWVVSmhZMnRHV0ZOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGlkWGxDWVdOclJsaFRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklETTFJQzh2SUNKaWRYbENZV05yVUdGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmlkWGxDWVdOclVHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVKMWVXSmhZMnNnYVhNZ2NHRjFjMlZrQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVJsSkJXQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSbEpCV0NCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ016RWdMeThnYldWMGFHOWtJQ0ptZUhOZmNISnBZMlVvS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VaMlYwUTI5c2JHRjBaWEpoYkZCeWFXTmxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xtRjJZV2xzWVdKc1pVVjRZMlZ6YzBOdmJHeGhkRVJXQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZbndLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCallXeHNjM1ZpSUVaeVlYaFFiMjlzVEdsaWNtRnllUzVqWVd4alFuVjVRbUZqYTBaWVV3b2dJQ0FnY0c5d0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRE00SUM4dklDSmlkWGxpWVdOclgyWmxaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZblY1WW1GamExOW1aV1VnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1emRXSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFDNXRkV3dLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndVpHbDJDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3WVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbTFwYzNOcGJtZGZaR1ZqYVcxaGJITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHMXBjM05wYm1kZlpHVmphVzFoYkhNZ1pYaHBjM1J6Q2dwaWRYbENZV05yUmxoVFgzZG9hV3hsWDNSdmNFQXpPZ29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBnb2dJQ0FnWW5vZ1luVjVRbUZqYTBaWVUxOWhablJsY2w5M2FHbHNaVUEzQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVFvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lub2dZblY1UW1GamEwWllVMTloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1lpb0tJQ0FnSUdKMWNua2dNd29LWW5WNVFtRmphMFpZVTE5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TURJS0lDQWdJR0l2Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR0lxQ2lBZ0lDQmlkWEo1SURJS0lDQWdJR0lnWW5WNVFtRmphMFpZVTE5M2FHbHNaVjkwYjNCQU13b0tZblY1UW1GamEwWllVMTloWm5SbGNsOTNhR2xzWlVBM09nb2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG1ScGRnb2dJQ0FnWkdsbklEWUtJQ0FnSUdScFp5QXhDaUFnSUNCaVBEMEtJQ0FnSUdGemMyVnlkQ0F2THlCVGJHbHdjR0ZuWlNCc2FXMXBkQ0J5WldGamFHVmtDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTmdvZ0lDQWdaR2xuSURrS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pHV0ZNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVaWVV5QmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNeklnTHk4Z2JXVjBhRzlrSUNKd2IyOXNYMkoxY201ZlpuSnZiU2hoWkdSeVpYTnpMSFZwYm5ReU5UWXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWTI5c2JHRjBaWEpoYkY5MGIydGxiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjlzYkdGMFpYSmhiRjkwYjJ0bGJpQmxlR2x6ZEhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJVY21GdWMyWmxja2hsYkhCbGNpNXpZV1psVkhKaGJuTm1aWElLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1ZEc5bloyeGxUV2x1ZEdsdVoxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ2WjJkc1pVMXBiblJwYm1jNkNpQWdJQ0JpZVhSbFl5QTBPU0F2THlBd2VHTTJOVFV6TWpFNE5XVmtOekJpTW1VNU9UazBNek5sTW1VNVptRmpNVEkwWlRBNE0yRmpZakV6WldNeE9ETmhOR1V3TlRrME5HUmhNRGM1TWpNek4ySUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG1oaGMxSnZiR1VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFNElDOHZJQ0p0YVc1MFVHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ0YVc1MFVHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWW5sMFpXTWdNVGdnTHk4Z0ltMXBiblJRWVhWelpXUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROalV3WVRjME9EWWdMeThnYldWMGFHOWtJQ0pOYVc1MGFXNW5WRzluWjJ4bFpDaGliMjlzS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xuUnZaMmRzWlZKbFpHVmxiV2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnZaMmRzWlZKbFpHVmxiV2x1WnpvS0lDQWdJR0o1ZEdWaklEVXdJQzh2SURCNFlUZzBZVFV6T0RsaFpEUXhaamxoWVdJd09ETXhZakF4WlRVek9EUmpZV1UzTm1VM1lUZG1aREE1TVRNeFl6SXdObVptTnpreU4yTXlNREZqTXpnMU53b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1YUdGelVtOXNaUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRrZ0x5OGdJbkpsWkdWbGJWQmhkWE5sWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21Wa1pXVnRVR0YxYzJWa0lHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lubDBaV01nTVRrZ0x5OGdJbkpsWkdWbGJWQmhkWE5sWkNJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobFptVmpaR0k1TmlBdkx5QnRaWFJvYjJRZ0lsSmxaR1ZsYldsdVoxUnZaMmRzWldRb1ltOXZiQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1MGIyZG5iR1ZTWldOdmJHeGhkR1Z5WVd4cGVtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwYjJkbmJHVlNaV052Ykd4aGRHVnlZV3hwZW1VNkNpQWdJQ0JpZVhSbFl5QTFNU0F2THlBd2VEZ3hNVGhsWldJMU1qTXhZVFZtWlRRd01EaGhOVFZpTmpJNE5qQm1ObUV3WkdJMFpqWmpNMkZqTURSbU9ERTBNVGt5TjJFNVlqTm1aV1JrT0Raa01tWUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG1oaGMxSnZiR1VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURNMElDOHZJQ0p5WldOdmJHeGhkR1Z5WVd4cGVtVlFZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhKbFkyOXNiR0YwWlhKaGJHbDZaVkJoZFhObFpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHSjVkR1ZqSURNMElDOHZJQ0p5WldOdmJHeGhkR1Z5WVd4cGVtVlFZWFZ6WldRaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFl6VmxZVFk1TXprZ0x5OGdiV1YwYUc5a0lDSlNaV052Ykd4aGRHVnlZV3hwZW1WVWIyZG5iR1ZrS0dKdmIyd3BJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1ZEc5bloyeGxRblY1UW1GamExdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ2WjJkc1pVSjFlVUpoWTJzNkNpQWdJQ0JpZVhSbFl5QTFNaUF2THlBd2VERXdNMlJoTnpsbVpqTTNOVFZtWmpkaE1UZGhOVFUzWkRJNFlqY3paRE0zWTJJMFpHVXdZak5qTTJOak1ESm1ZVFpqTkRoa1pqQm1NelV3TnpGbVltWUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG1oaGMxSnZiR1VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURNMUlDOHZJQ0ppZFhsQ1lXTnJVR0YxYzJWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaWRYbENZV05yVUdGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZbmwwWldNZ016VWdMeThnSW1KMWVVSmhZMnRRWVhWelpXUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVGRpWVRaa1lqY2dMeThnYldWMGFHOWtJQ0pDZFhsaVlXTnJWRzluWjJ4bFpDaGliMjlzS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xuUnZaMmRzWlVOdmJHeGhkR1Z5WVd4UWNtbGpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SdloyZHNaVU52Ykd4aGRHVnlZV3hRY21salpUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZbmwwWldNZ05UTWdMeThnTUhoaVlqSmpOamhpT0dSak5XSmpZMlJrTWpVek5qTXdOekE0TUdFM09EWTFZVGRsTVRNelltWTFOR1V6TVdRMFpEUTJNMkl4WWpjME9XSTBZbU5tTWpaa0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHY21GNExuTnZiQzVHY21GNFVHOXZiQzVvWVhOU2IyeGxDaUFnSUNCaGMzTmxjblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QWlZMjlzYkdGMFpYSmhiRkJ5YVdObFVHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjJ4c1lYUmxjbUZzVUhKcFkyVlFZWFZ6WldRZ1pYaHBjM1J6Q2lBZ0lDQmlibm9nZEc5bloyeGxRMjlzYkdGMFpYSmhiRkJ5YVdObFgyVnNjMlZmWW05a2VVQXpDaUFnSUNCaWVYUmxZeUF5TnlBdkx5QWljR0YxYzJWa1VISnBZMlVpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NuUnZaMmRzWlVOdmJHeGhkR1Z5WVd4UWNtbGpaVjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z0ltTnZiR3hoZEdWeVlXeFFjbWxqWlZCaGRYTmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjlzYkdGMFpYSmhiRkJ5YVdObFVHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z0ltTnZiR3hoZEdWeVlXeFFjbWxqWlZCaGRYTmxaQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01URWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlROa05qQmtaU0F2THlCdFpYUm9iMlFnSWtOdmJHeGhkR1Z5WVd4UWNtbGpaVlJ2WjJkc1pXUW9ZbTl2YkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkRzluWjJ4bFEyOXNiR0YwWlhKaGJGQnlhV05sWDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklESTNJQzh2SUNKd1lYVnpaV1JRY21salpTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaUlIUnZaMmRzWlVOdmJHeGhkR1Z5WVd4UWNtbGpaVjloWm5SbGNsOXBabDlsYkhObFFEUUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VjMlYwVUc5dmJGQmhjbUZ0WlhSbGNuTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSUWIyOXNVR0Z5WVcxbGRHVnljem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEY0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWRHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2MyVjBVRzl2YkZCaGNtRnRaWFJsY25OZlltOXZiRjkwY25WbFFETUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE15QXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKNklITmxkRkJ2YjJ4UVlYSmhiV1YwWlhKelgySnZiMnhmWm1Gc2MyVkFOQW9LYzJWMFVHOXZiRkJoY21GdFpYUmxjbk5mWW05dmJGOTBjblZsUURNNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvS2MyVjBVRzl2YkZCaGNtRnRaWFJsY25OZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0J2ZDI1bGNpQnZjaUIwYVcxbGJHOWphd29nSUNBZ1lubDBaV01nTWpZZ0x5OGdJbkJ2YjJ4ZlkyVnBiR2x1WnlJS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTkRBZ0x5OGdJbUp2Ym5WelgzSmhkR1VpQ2lBZ0lDQmthV2NnTVRNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFF4SUM4dklDSnlaV1JsYlhCMGFXOXVYMlJsYkdGNUlnb2dJQ0FnWkdsbklERXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeU5DQXZMeUFpYldsdWRHbHVaMTltWldVaUNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURJMUlDOHZJQ0p5WldSbGJYQjBhVzl1WDJabFpTSUtJQ0FnSUdScFp5QXhNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUExQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ016Z2dMeThnSW1KMWVXSmhZMnRmWm1WbElnb2dJQ0FnWkdsbklEa0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURNNUlDOHZJQ0p5WldOdmJHeGhkRjltWldVaUNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1pHbG5JREUzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdScFp5QXlNQW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdScFp5QXpDaUFnSUNCaWZBb2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWkdsbklEUUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR1JwWnlBMUNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdaR2xuSURZS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdKOENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREE0TldZd09XSTFJQzh2SUcxbGRHaHZaQ0FpVUc5dmJGQmhjbUZ0WlhSbGNuTlRaWFFvZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTmlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjMlYwVUc5dmJGQmhjbUZ0WlhSbGNuTmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdjMlYwVUc5dmJGQmhjbUZ0WlhSbGNuTmZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG5ObGRGUnBiV1ZzYjJOclczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwVkdsdFpXeHZZMnM2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMGFXMWxiRzlqYTE5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYVcxbGJHOWphMTloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCelpYUlVhVzFsYkc5amExOWliMjlzWDNSeWRXVkFNd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2diM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lub2djMlYwVkdsdFpXeHZZMnRmWW05dmJGOW1ZV3h6WlVBMENncHpaWFJVYVcxbGJHOWphMTlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dwelpYUlVhVzFsYkc5amExOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUc5M2JtVnlJRzl5SUhScGJXVnNiMk5yQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0owYVcxbGJHOWphMTloWkdSeVpYTnpJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdRNU0yUmhOR1E1SUM4dklHMWxkR2h2WkNBaVZHbHRaV3h2WTJ0VFpYUW9ZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYzJWMFZHbHRaV3h2WTJ0ZlltOXZiRjltWVd4elpVQTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2MyVjBWR2x0Wld4dlkydGZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG01dmJXbHVZWFJsVG1WM1QzZHVaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdWIyMXBibUYwWlU1bGQwOTNibVZ5T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCMGFHVWdZMjl1ZEhKaFkzUWdiM2R1WlhJZ2JXRjVJSEJsY21admNtMGdkR2hwY3lCaFkzUnBiMjRLSUNBZ0lHSjVkR1ZqSURNeklDOHZJQ0p1YjIxcGJtRjBaV1JQZDI1bGNpSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZakk0TVRJeE9HRWdMeThnYldWMGFHOWtJQ0pQZDI1bGNrNXZiV2x1WVhSbFpDaGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFp5WVhndWMyOXNMa1p5WVhoUWIyOXNMbUZqWTJWd2RFOTNibVZ5YzJocGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZqWTJWd2RFOTNibVZ5YzJocGNEb0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBek15QXZMeUFpYm05dGFXNWhkR1ZrVDNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHNXZiV2x1WVhSbFpFOTNibVZ5SUdWNGFYTjBjd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1dXOTFJRzExYzNRZ1ltVWdibTl0YVc1aGRHVmtJR0psWm05eVpTQjViM1VnWTJGdUlHRmpZMlZ3ZENCdmQyNWxjbk5vYVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE15QXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WkRKalkyWXlPVEFnTHk4Z2JXVjBhRzlrSUNKUGQyNWxja05vWVc1blpXUW9ZV1JrY21WemN5eGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWliM2R1WlhJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNek1nTHk4Z0ltNXZiV2x1WVhSbFpFOTNibVZ5SWdvZ0lDQWdZbmwwWldOZk15QXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG1oaGMxSnZiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwb1lYTlNiMnhsT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFp5WVhndWMyOXNMa1p5WVhoUWIyOXNMbWhoYzFKdmJHVUtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNUdjbUY0VUc5dmJDNW5aWFJTYjJ4bFRXVnRZbVZ5UTI5MWJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSU2IyeGxUV1Z0WW1WeVEyOTFiblE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UY2dMeThnSWw5eWIyeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZ3dNREl5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESXdNREEwTURBd05qQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JqWVd4c2MzVmlJRVZ1ZFcxbGNtRmliR1ZUWlhRdWJHVnVaM1JvQ2lBZ0lDQndiM0FLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFp5WVhndWMyOXNMa1p5WVhoUWIyOXNMbWRsZEZKdmJHVk5aVzFpWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJTYjJ4bFRXVnRZbVZ5T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhOM1lYQUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRjZ0x5OGdJbDl5YjJ4bGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhnd01ESXlNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURJd01EQTBNREF3TmpBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlFVnVkVzFsY21GaWJHVlRaWFF1WVhRS0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1blpYUlNiMnhsUVdSdGFXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSU2IyeGxRV1J0YVc0NkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVGNnTHk4Z0lsOXliMnhsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGd3TURJeU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREl3TURBME1EQXdOakF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF6TWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1bmNtRnVkRkp2YkdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5jbUZ1ZEZKdmJHVTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ3dVozSmhiblJTYjJ4bENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xuSmxkbTlyWlZKdmJHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhadmEyVlNiMnhsT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKZmNtOXNaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNREF5TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNREF3TkRBd01EWXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElESWdNeklLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xtaGhjMUp2YkdVS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTkRiMjUwY205c09pQnpaVzVrWlhJZ2JYVnpkQ0JpWlNCaGJpQmhaRzFwYmlCMGJ5QnlaWFp2YTJVS0lDQWdJR05oYkd4emRXSWdYM0psZG05clpWSnZiR1VLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1Y21WdWIzVnVZMlZTYjJ4bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ1YjNWdVkyVlNiMnhsT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHUjFjQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGMzTkRiMjUwY205c09pQmpZVzRnYjI1c2VTQnlaVzV2ZFc1alpTQnliMnhsY3lCbWIzSWdjMlZzWmdvZ0lDQWdZMkZzYkhOMVlpQmZjbVYyYjJ0bFVtOXNaUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHY21GNExuTnZiQzVHY21GNFVHOXZiQzVqYjJ4c1lYUmZaWFJvWDI5eVlXTnNaVjloWkdSeVpYTnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTI5c2JHRjBYMlYwYUY5dmNtRmpiR1ZmWVdSa2NtVnpjem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwTkNBdkx5QWlZMjlzYkdGMFgyVjBhRjl2Y21GamJHVmZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1kyOXNiR0YwWDJWMGFGOXZjbUZqYkdWZllXUmtjbVZ6Y3lCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1YldsdWRHbHVaMTltWldWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHRhVzUwYVc1blgyWmxaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF5TkNBdkx5QWliV2x1ZEdsdVoxOW1aV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzFwYm5ScGJtZGZabVZsSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VjbVZrWlcxd2RHbHZibDltWldWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV1JsYlhCMGFXOXVYMlpsWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU5TQXZMeUFpY21Wa1pXMXdkR2x2Ymw5bVpXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklISmxaR1Z0Y0hScGIyNWZabVZsSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VZblY1WW1GamExOW1aV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWRYbGlZV05yWDJabFpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXpPQ0F2THlBaVluVjVZbUZqYTE5bVpXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHSjFlV0poWTJ0ZlptVmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ3dWNtVmpiMnhzWVhSZlptVmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WamIyeHNZWFJmWm1WbE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklETTVJQzh2SUNKeVpXTnZiR3hoZEY5bVpXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklISmxZMjlzYkdGMFgyWmxaU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xuVnVZMnhoYVcxbFpGQnZiMnhEYjJ4c1lYUmxjbUZzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3c2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkVzVqYkdGcGJXVmtVRzl2YkVOdmJHeGhkR1Z5WVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhWdVkyeGhhVzFsWkZCdmIyeERiMnhzWVhSbGNtRnNJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ3dWRXNWpiR0ZwYldWa1VHOXZiRVpZVTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVnVZMnhoYVcxbFpGQnZiMnhHV0ZNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UVWdMeThnSW5WdVkyeGhhVzFsWkZCdmIyeEdXRk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFZ1WTJ4aGFXMWxaRkJ2YjJ4R1dGTWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1d2IyOXNYMk5sYVd4cGJtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B3YjI5c1gyTmxhV3hwYm1jNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01qWWdMeThnSW5CdmIyeGZZMlZwYkdsdVp5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2NHOXZiRjlqWldsc2FXNW5JR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ3dWNHRjFjMlZrVUhKcFkyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B3WVhWelpXUlFjbWxqWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU55QXZMeUFpY0dGMWMyVmtVSEpwWTJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhCaGRYTmxaRkJ5YVdObElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1WW05dWRYTmZjbUYwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSnZiblZ6WDNKaGRHVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOREFnTHk4Z0ltSnZiblZ6WDNKaGRHVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHSnZiblZ6WDNKaGRHVWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1eVpXUmxiWEIwYVc5dVgyUmxiR0Y1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmtaVzF3ZEdsdmJsOWtaV3hoZVRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBME1TQXZMeUFpY21Wa1pXMXdkR2x2Ymw5a1pXeGhlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djbVZrWlcxd2RHbHZibDlrWld4aGVTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG0xcGJuUlFZWFZ6WldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHRhVzUwVUdGMWMyVmtPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREU0SUM4dklDSnRhVzUwVUdGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnRhVzUwVUdGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xuSmxaR1ZsYlZCaGRYTmxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFpHVmxiVkJoZFhObFpEb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhPU0F2THlBaWNtVmtaV1Z0VUdGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnlaV1JsWlcxUVlYVnpaV1FnWlhocGMzUnpDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VjbVZqYjJ4c1lYUmxjbUZzYVhwbFVHRjFjMlZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmpiMnhzWVhSbGNtRnNhWHBsVUdGMWMyVmtPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRE0wSUM4dklDSnlaV052Ykd4aGRHVnlZV3hwZW1WUVlYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEpsWTI5c2JHRjBaWEpoYkdsNlpWQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHY21GNExuTnZiQzVHY21GNFVHOXZiQzVpZFhsQ1lXTnJVR0YxYzJWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZblY1UW1GamExQmhkWE5sWkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBek5TQXZMeUFpWW5WNVFtRmphMUJoZFhObFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1luVjVRbUZqYTFCaGRYTmxaQ0JsZUdsemRITUtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNUdjbUY0VUc5dmJDNWpiMnhzWVhSbGNtRnNVSEpwWTJWUVlYVnpaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamIyeHNZWFJsY21Gc1VISnBZMlZRWVhWelpXUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z0ltTnZiR3hoZEdWeVlXeFFjbWxqWlZCaGRYTmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjlzYkdGMFpYSmhiRkJ5YVdObFVHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFp5WVhndWMyOXNMa1p5WVhoUWIyOXNMbTkzYm1WeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiM2R1WlhJNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UTWdMeThnSW05M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1Ym05dGFXNWhkR1ZrVDNkdVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B1YjIxcGJtRjBaV1JQZDI1bGNqb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXpNeUF2THlBaWJtOXRhVzVoZEdWa1QzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzV2YldsdVlYUmxaRTkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1aGRtRnBiR0ZpYkdWRmVHTmxjM05EYjJ4c1lYUkVWaWdwSUMwK0lHSjVkR1Z6T2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VZWFpoYVd4aFlteGxSWGhqWlhOelEyOXNiR0YwUkZZNkNpQWdJQ0J3Y205MGJ5QXdJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpUmxKQldDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1JsSkJXQ0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUExTmlBdkx5QnRaWFJvYjJRZ0luUnZkR0ZzVTNWd2NHeDVLQ2wxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QnRaWFJvYjJRZ0ltZHNiMkpoYkY5amIyeHNZWFJsY21Gc1gzSmhkR2x2S0NsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWaklEVTNJQzh2SUcxbGRHaHZaQ0FpWjJ4dlltRnNRMjlzYkdGMFpYSmhiRlpoYkhWbEtDbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpZVhSbFl5QXlNU0F2THlBd2VEQm1OREkwTUFvZ0lDQWdZajRLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1aGRtRnBiR0ZpYkdWRmVHTmxjM05EYjJ4c1lYUkVWbDloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNUdjbUY0VUc5dmJDNWhkbUZwYkdGaWJHVkZlR05sYzNORGIyeHNZWFJFVmw5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2d1YlhWc0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUM1a2FYWUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdZandLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1aGRtRnBiR0ZpYkdWRmVHTmxjM05EYjJ4c1lYUkVWbDlsYkhObFgySnZaSGxBTndvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvTG5OMVlnb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1aGRtRnBiR0ZpYkdWRmVHTmxjM05EYjJ4c1lYUkVWbDlsYkhObFgySnZaSGxBTnpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1blpYUkRiMnhzWVhSbGNtRnNVSEpwWTJVb0tTQXRQaUJpZVhSbGN6b0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG1kbGRFTnZiR3hoZEdWeVlXeFFjbWxqWlRvS0lDQWdJSEJ5YjNSdklEQWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNHNGdOQW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdJbU52Ykd4aGRHVnlZV3hRY21salpWQmhkWE5sWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWTI5c2JHRjBaWEpoYkZCeWFXTmxVR0YxYzJWa0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1WjJWMFEyOXNiR0YwWlhKaGJGQnlhV05sWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01qY2dMeThnSW5CaGRYTmxaRkJ5YVdObElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCd1lYVnpaV1JRY21salpTQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Um5KaGVGQnZiMnd1WjJWMFEyOXNiR0YwWlhKaGJGQnlhV05sWDJWc2MyVmZZbTlrZVVBeU9nb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJa1pTUVZnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVaU1FWZ2daWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRFUwSUM4dklHMWxkR2h2WkNBaVpYUm9YM1Z6WkY5d2NtbGpaU2dwZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNZ29nSUNBZ1lubDBaV01nT1NBdkx5QXdlREJoQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSnRhWE56YVc1blgyUmxZMmx0WVd4eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUcxcGMzTnBibWRmWkdWamFXMWhiSE1nWlhocGMzUnpDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVJuSmhlRkJ2YjJ3dVoyVjBRMjlzYkdGMFpYSmhiRkJ5YVdObFgzZG9hV3hsWDNSdmNFQTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJK0NpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VaMlYwUTI5c2JHRjBaWEpoYkZCeWFXTmxYMkZtZEdWeVgzZG9hV3hsUURnS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0ltQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1blpYUkRiMnhzWVhSbGNtRnNVSEpwWTJWZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdJcUNpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHY21GNExuTnZiQzVHY21GNFVHOXZiQzVuWlhSRGIyeHNZWFJsY21Gc1VISnBZMlZmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjRNRElLSUNBZ0lHSXZDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JrZFhBS0lDQWdJR0lxQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG1kbGRFTnZiR3hoZEdWeVlXeFFjbWxqWlY5M2FHbHNaVjkwYjNCQU5Bb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGtaeVlYaFFiMjlzTG1kbGRFTnZiR3hoZEdWeVlXeFFjbWxqWlY5aFpuUmxjbDkzYUdsc1pVQTRPZ29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklETTNJQzh2SUNKM1pYUm9YMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIZGxkR2hmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKNWRHVmpJREl4SUM4dklEQjRNR1kwTWpRd0NpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdZaW9LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRE0ySUM4dklDSmpiMnhzWVhSRmRHaFBjbUZqYkdVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJHeGhkRVYwYUU5eVlXTnNaU0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTlRVZ0x5OGdiV1YwYUc5a0lDSmpiMjV6ZFd4MEtHRmtaSEpsYzNNc2RXbHVkREkxTmlsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01EQXdDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhQzV0ZFd3S0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdndVpHbDJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHY21GNExuTnZiQzVHY21GNFVHOXZiQzVvWVhOU2IyeGxLSEp2YkdVNklHSjVkR1Z6TENCaFkyTnZkVzUwT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VhR0Z6VW05c1pUb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKZmNtOXNaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNREF5TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNREF3TkRBd01EWXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRVZ1ZFcxbGNtRmliR1ZUWlhRdVkyOXVkR0ZwYm5NS0lDQWdJSEJ2Y0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xrWnlZWGhRYjI5c0xtZHlZVzUwVW05c1pTaHliMnhsT2lCaWVYUmxjeXdnWVdOamIzVnVkRG9nWW5sMFpYTXBJQzArSUhadmFXUTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1bmNtRnVkRkp2YkdVNkNpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpWDNKdmJHVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBd2VEQXdNakl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01qQXdNRFF3TURBMk1EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBeUlETXlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2NtRjRVRzl2YkM1b1lYTlNiMnhsQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV05qWlhOelEyOXVkSEp2YkRvZ2MyVnVaR1Z5SUcxMWMzUWdZbVVnWVc0Z1lXUnRhVzRnZEc4Z1ozSmhiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5bmNtRnVkRkp2YkdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNUdjbUY0VUc5dmJDNWZaM0poYm5SU2IyeGxLSEp2YkdVNklHSjVkR1Z6TENCaFkyTnZkVzUwT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWDJkeVlXNTBVbTlzWlRvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0pmY205c1pYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhnd01ESXlNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURJd01EQTBNREF3TmpBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1JXNTFiV1Z5WVdKc1pWTmxkQzVoWkdRS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbm9nWDJkeVlXNTBVbTlzWlY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZamRtWm1WaVpqZ2dMeThnYldWMGFHOWtJQ0pTYjJ4bFIzSmhiblJsWkNoaWVYUmxXek15WFN4aFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0NsOW5jbUZ1ZEZKdmJHVmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZ3dNREl5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESXdNREEwTURBd05qQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ01pQXpNZ29nSUNBZ1lubDBaV01nTlRnZ0x5OGdNSGd3TURJeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNUdjbUY0VUc5dmJDNWZjbVYyYjJ0bFVtOXNaU2h5YjJ4bE9pQmllWFJsY3l3Z1lXTmpiM1Z1ZERvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q2w5eVpYWnZhMlZTYjJ4bE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UY2dMeThnSWw5eWIyeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBd2VEQXdNakl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01qQXdNRFF3TURBMk1EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwTG5KbGJXOTJaUW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWVpQmZjbVYyYjJ0bFVtOXNaVjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EWmpaVEV6T0dJZ0x5OGdiV1YwYUc5a0lDSlNiMnhsVW1WMmIydGxaQ2hpZVhSbFd6TXlYU3hoWkdSeVpYTnpMR0ZrWkhKbGMzTXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLQ2w5eVpYWnZhMlZTYjJ4bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE1EQXlNakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeU1EQXdOREF3TURZd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURJZ016SUtJQ0FnSUdKNWRHVmpJRFU0SUM4dklEQjRNREF5TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VSbkpoZUZCdmIyd3VZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRkFDQUJCc0NFUFNZN0FBRUJCQlVmZkhVZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFUmxKQldCQmpiMnhzWVhSbGNtRnNYM1J2YTJWdUVHMXBjM05wYm1kZlpHVmphVzFoYkhNWGRXNWpiR0ZwYldWa1VHOXZiRU52Ykd4aGRHVnlZV3dRZEdsdFpXeHZZMnRmWVdSa2NtVnpjd0VLQVFJQkFDd0FJZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUFCQUFHQUFBQUFBVnZkMjVsY2dOR1dGTVFkVzVqYkdGcGJXVmtVRzl2YkVaWVV3VHNOazQwQmw5eWIyeGxjd3B0YVc1MFVHRjFjMlZrREhKbFpHVmxiVkJoZFhObFpCVmpiMnhzWVhSbGNtRnNVSEpwWTJWUVlYVnpaV1FERDBKQUdISmxaR1ZsYlVOdmJHeGhkR1Z5WVd4Q1lXeGhibU5sY3hGeVpXUmxaVzFHV0ZOQ1lXeGhibU5sY3d0dGFXNTBhVzVuWDJabFpRNXlaV1JsYlhCMGFXOXVYMlpsWlF4d2IyOXNYMk5sYVd4cGJtY0xjR0YxYzJWa1VISnBZMlVoQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCSU82MTh3RUV6SitLQVJzU3l2UEJNZkJELzRPYm05dGFXNWhkR1ZrVDNkdVpYSVZjbVZqYjJ4c1lYUmxjbUZzYVhwbFVHRjFjMlZrRFdKMWVVSmhZMnRRWVhWelpXUVBZMjlzYkdGMFJYUm9UM0poWTJ4bERIZGxkR2hmWVdSa2NtVnpjd3RpZFhsaVlXTnJYMlpsWlF4eVpXTnZiR3hoZEY5bVpXVUtZbTl1ZFhOZmNtRjBaUkJ5WldSbGJYQjBhVzl1WDJSbGJHRjVDRjlwYm1SbGVHVnpER3hoYzNSU1pXUmxaVzFsWkJsamIyeHNZWFJmWlhSb1gyOXlZV05zWlY5aFpHUnlaWE56RGw5ZlkzUnZjbDl3Wlc1a2FXNW5FbU52Ykd4aGRHVnlZV3hmWVdSa2NtVnpjeFZtY21GNFgyTnZiblJ5WVdOMFgyRmtaSEpsYzNNVVpuaHpYMk52Ym5SeVlXTjBYMkZrWkhKbGMzTWd4bFV5R0Y3WEN5NlpsRFBpNmZyQkpPQ0RyTEUrd1lPazRGbEUyZ2VTTTNzZ3FFcFRpYTFCK2Fxd2d4c0I1VGhNcm5ibnAvMEpFeHdnYi9lU2ZDQWNPRmNnZ1JqdXRTTWFYK1FBaWxXMktHRDJvTnRQYkRyQVQ0RkJrbnFiUCszWWJTOGdFRDJubi9OMVgvZWhlbFY5S0xjOU44dE40TFBEekFMNmJFamZEelVISDc4Z3V5eG91Tnhiek4wbE5qQndnS2VHV240VE8vVk9NZFRVWTdHM1NiUzg4bTBFckZldG9nUXRNZnkxQkhuNnRHVUVuY1NUaVFJQUlqRVlRQUIvSncwclp5Y2hLMmNuQlN0bkp5NHJaeWN2SzJjbk1DdG5Kd2dyWnljT0syY25CQ3RuSnlRclp5Y3NLMmNuSlN0bkp4Z29aeWNaS0djbkppaG5KeWNvWnljSEtHY25EeWhuSndZb1p5SVdKeHBMQVdjbkcweG5nY3c2Rmljb1RHY2tGaWNwVEdjbkVpSm5KeE1pWnljaUltY25JeUpuSnhRaVp5Y3RKR2NrUXpFWkZFUXhHRVNDTUFSdU5oekRCUEczN2RnRTZ3RWFVd1I0NFN1c0JIVXRJZDBFTDNrMGh3U0x4QnJDQkx2d3dQMEVvODNzSlFSNk1hNjJCRHNISjJvRUJnZWFYZ1FPRjJ2eEJFWHRwVmdFTFBPdytBVCt5OU0xQkRhTDM4a0VTYkdsb2dTNVVybWtCSk9xanQwRXF2dXdpd1E2MDZFREJOVWgxZ1FFV0trUUtBUU9IRXVnQkNSZGYxa0VaeWljZlFRVUhFOFlCSU1OWUxFRW5rbUM3UVJaVnlUbUJHT2cwNlVFcVFXSTJRUWJUZ3lXQks4WTNSc0VVaktOcXdTL1puMmNCTmZ2OXpBRUdHRTIvQVNXZHErMUJDRCtRcklFdDlUME5nUng3cEhHQkNzYzYyQUVQSmxBUEFRT0dObUNCTEc3c0tnRWZTODFYRFlhQUk0d0ExSUVod1lrQmpVR1JnYUZCNFlJVFFvRUN5Z05HdzRrRHUwUVlCRmJFWDhSb3hISEVlc1NMUk1rRTFzVGZCT2pFOElUN2hRY0ZEZ1VUUlI0RkpJVW5SU3dGTU1VMWhUcEZQd1ZEeFVpRlRVVlNCVmJGV3dWZlJXT0ZaOFZzQlc3QUlvQ0FvditpLytJQU1TTS9rQUFLNHYrSWxtTC9vRUNXWXYrVGdKU2dRSWlXRW1MLzFCSUZTTUtGb3YvQVNjcVRGQkp2RWhNdnlTTC9va2lpLzZKaWdJQ2kvOEJKeXBNVUVtK0tFNENUVWtvcVVFQWNvc0JKeHlnS2FFbkhLcUwvaUpaaS82QkFsbUwvazRDVW9FQ0lsaEpGVWtqQ2hZbkhLQXBvU2NjcW9FSXIwbFBBbEJKRllFSUNWc2pDMHNEVENOWVRFc0VVRWtWZ1FnSld5TUxTd05NU3dKZFNFOERLYUJNQVNjcVRGQkp2RWhNdnlNSklreFNTSXNBdkVna2kvNVBBMDhEaVNLTC9rOERUd09KaWdJQ2kvOEJKeXBNVUw0b1RnSk5LS21ML29tS0FRS0wveUpaaS8rQkFsbUwvMDRDVW9FQ0lsZ1ZJd29XaS8rSmlnSUNpLzRpV1l2K2dRSlppLzVPQWxLQkFpSllTUlVqQ2hhTC82VkVnUWl2aS85UVNSV0JDQWxiSXdzaldJditpWW9DQTR2K0lsbUwvaFdML2s0Q1Vvdi9pUDY5U0l2K1NZbUtBZ09ML2lKWmkvNFZpLzVPQWxLTC80ais0a2lML2ttSmlnSUNpLzRpV1l2K0ZZditUZ0pTaS8rSS8xbElpLzZKaWdFQ2kvOGlXWXYvRll2L1RnSlNpUDlYU0l2L2lZb0NBb3YrSWxtTC9oV0wvazRDVW92L2lQOWJTSXYraVlvQ0FZdi9pLzZJQVVnaEJCYUlBVjJKaWdJQmkvK0wvb2dCTnlFRUZvZ0JUSW1LQVFPTC8xZGdJSXYvVnlBZ2lBRWdJUVFXVEVzQmlBRXlTVXNDaUFFUmkvOVhnQ0NJQVNSTEFZZ0F4RWxQQTRnQS9vdi9Wd0FnaUFFUlRnS0lBS05NaS8rSmlnSUJJUVFXaS85TWlBRGhpLzZJQVBlSmlnRUNpLzlYQUNCSktLVkVpLzlYWUNDTC8xY2dJSWdBd2lFRUZreExBWWdBMUVsUEE2WkVUSWdBc0l2L1YwQWdpQUREaS8rSmlnVUNpL3VML0lnQW15RUVGa2xQQWtzQmlBQ3JTVThDaS8xTEFZZ0Fob3YraUFDY2kvK0wvb2dBZW92K1R3S0lBSE9JQURCTWlBQ0hTVTRDcGtFQUVvc0JTWXNBaUFCZGkveUlBSE9NQUl3QmlZc0NRdi9yaWdJQmkvNkwvNkJKaS82blJJbUtBZ0dML292L2dCNVRZV1psVFdGMGFEb2djM1ZpZEhKaFkzUnBiMjRnYjNabGNtWnNiM2VJQUFHSmlnTUJpLzZML2FaRWkvMG5IS0NML3FFbkhLcUppZ0lCaS80b3FFRUFBeUlXaVl2K2kvK2pTWXYrb292L3FFU0ppZ0lCaS82TC80QWFVMkZtWlUxaGRHZzZJR1JwZG1semFXOXVJR0o1SUhwbGNtK0lBQUdKaWdNQmkvNG9wVVNML1l2K29vbUtBd0NKaWdRQWlUWWFBVWNDRlNNU1JEWWFBa2xPQWhVakVrUTJHZ05KVGdJVkl4SkVOaG9FU1JVakVrUTJHZ1ZKVGdNVkl4SkVOaG9HU1U0REZTTVNSQ2N0WkVRbkxTSm5TU3NUU1U0RFJDY05Td0ZuZ0NUU3pQS1FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCTVVMQXJFMEVBdGtzRUt4TkJBSzlMQXlzVFFRQ29TVUVBcEVzQ0t4TkJBSjBrUkNjRVN3WkpUZ0puSnc1TEJrbE9BMmNuTDB4bkp6Qk1aeWN1U3dSSlRnSm5Kd2hMQkdjbkJVeG5KeHBMQW1leElpY0ZaVVNCR0ZzbHNoQWlzaGtpc2dHeUdJQUV1SGVlNTdJYXM0RVNGclErVndRQUZ4YUkvbm9uQmt4bkt6RUFpQkx5SWljSVpVUW5NVXlJRXNZaUp3aGxSQ2N5VElnU3V5SW5DR1ZFSnpOTWlCS3dJaWNJWlVRbk5FeUlFcVVpSndobFJDYzFUSWdTbWlSRElrTC9ZQ0pIRENjVVpVUWtFa0VBZ2JFeUNpSW5CV1ZFZ1JoYkpiSVFJcklaSXJJQnNoZ25IYklhc2hxektVVUdKd2xGRENJbkJtVk1SUXBFU3dnb3BVRUFJRXNJS2F3b3FVRUFCMHNGU3d5alJRWkxDQ2NLb2tVSlN3dEpvMFVNUXYvWnRENVhCQUFpSndkbFJJajl4MHNHaVA0Q0lpY2JaVVNJL2ZvaEJCYUkvZzlKRlNNT1JDT3ZxeXBNVUxBa1E3RWlKd1JsUklFWVd5V3lFQ0t5R1NLeUFiSVlKemF5R3JPMFBsY0VBRVVDS1VVRkp3bEZDeUluQm1WTVJRbEVTd2NvcFVFQUlFc0hLYXdvcVVFQUIwc0VTd3VqUlFWTEJ5Y0tva1VJU3dwSm8wVUxRdi9ac1NJbkpXVkVJNjhuRlVzSG8xQkpGU01KSTFnaUp5UmxSSUVZV3lXeUVDS3lHU0t5QWJJWUp6ZXlHa3l5R3JJYXM3UStWd1FBSVFRV1NVVURTd05NaVAxT1RJajlaVVVEc1RJS0lpY0ZaVVNCR0ZzbHNoQWlzaGtpc2dHeUdDY2RzaHF5R3JNcFJRUW5DVVVLSWljR1pVeEZDRVJMQmlpbFFRQWdTd1lwckNpcFFRQUhTd05MQ3FORkJFc0dKd3FpUlFkTENVbWpSUXBDLzltMFBsY0VBQ0luQjJWRWlQeW9Td1NJL09OTEE0ajgza3NCaVB6MFF2N2lpQStmU1JVakRrUWpyNnNxVEZDd0pFT0lFQk5KRlNNT1JDT3ZxeXBNVUxBa1F6WWFBVWtWSXhKRU5ob0NTUlVqRWtReEFDSW5DR1ZFRWtBQUN6RUFJaWNOWlVRU1FRQVZKRVFuTEVzQ1NVNENaeWNrVEdjbkpVc0JaeVJESWtMLzZEWWFBVWtWSXhKRU5ob0NTUlVqRWtRaUp4SmxSQlJFS1NjSklpY0daVVJKS0tWQkFCNUpLYXdvcVVFQUIwc0NTd0tqUlFOSkp3cWlSUUZMQVVtalJRSkMvOXhMQkVsTEJLT3hJaWNFWlVTQkdGc2xzaEFpc2hraXNnR3lHQ2NRc2hxenRENVhCQUFuRmFkRXNUSUtJaWNGWlVTQkdGc2xzaEFpc2hraXNnR3lHQ2Nkc2hxeUdyTzBQbGNFQUNJbkIyVkVpUHVnU3dLSSs0MGlKeHBsUktaRWlBOGlUSWo2ZXlFRUZpSW5HR1ZFU3dGTWlQdC9Ud0pNaVB1NVRJajcwRXNGU3dHbVJDSW5CV1ZFTVFBeUNrOEVpUHYxc1RFQUk2OVBBbEJKRlNNSkkxZ2lKd1JsUklFWVd5V3lFQ0t5R1NLeUFiSVlKeDZ5R2t5eUdySWFzeVJETmhvQlNSVWpFa1EyR2dKSkZTTVNSQ0luRW1WRUZFU3hJaWNFWlVTQkdGc2xzaEFpc2hraXNnRkpzaGduSDdJYXM3UStWd1FBc1NXeUVDS3lHU0t5QVVzQnNoZ25FTElhczdRK1Z3UUFLS2hFU3dPSStkMGhCQllpSnhobFJFc0JUSWo2MEU4Q1RJajdDa3lJK3lGUEFrc0Jwa1N4TVFBanIwbFBCVkJKRlNNSkkxZ2lKdzVsUklFWVd5V3lFQ0t5R1NLeUFiSVlKeUN5R2s4Q3NocXlHck94TVFCTVR3SlFTUlVqQ1NOWUpiSVFJcklaSXJJQlR3S3lHQ2Nlc2hwTXNocXlHck1rUXlKSEFqWWFBVWtWSXhKRU5ob0NTUlZKSXhKRU5ob0RTUlVqRWtRaUp4SmxSQlJFc1NJbkJHVkVnUmhiSmJJUUlySVpJcklCU2JJWUp4K3lHck8wUGxjRUFFeXhKYklRSXJJWklySUJzaGduRUxJYXM3UStWd1FBU1NjVnBFRUJVMGtvcFVFQlRTUkVzVElLSWljRlpVU0JHRnNsc2hBaXNoa2lzZ0d5R0NjZHNocXlHck8wUGxjRUFDSW5CMlZFaVBuYlN3YUkrY2dpSnhwbFJLWkVLVVVISndsRkNTSW5CbVZNUlFsRVN3Y29wVUVBSUVzSEthd29xVUVBQjBzR1N3bWpSUWRMQnljS29rVUlTd2hKbzBVSlF2L1pTd1ZKU3dpamlBMGhTUlVqRGtRanIweExBYXRMQkVrVkl3NUVTd0tyU3dNVkl3NUVUd05MQTZ0TENDTU9SRXNKU1U0RlN3U3JTd2hKRlNNT1JFc0ZxMDhFVUV4UVRGQk1VSWo0WFU0Q1NFeUkrRlpJVGdKSUlRUVdJaWNZWlVSTEFVeUkrVFJQQWt5SStXNU1pUG1GU3dkTEFhWkVTd0ZQQktaRXNURUFTd05QQTFCSkZTTUpJMWdpSnc1bFJJRVlXeVd5RUNLeUdTS3lBYklZSnlDeUdreXlHcklhc3lJbkJXVkVNUUF5Q2s4RmlQbDVzVEVBVGdKUVNSVWpDU05ZSWljRVpVU0JHRnNsc2hBaXNoa2lzZ0d5R0NjZXNocE1zaHF5R3JNa1F5SkMvckEyR2dGSkZTTVNSRFlhQWtrVkl4SkVJaWNUWlVRVVJMRWlKd1JsUklFWVd5V3lFQ0t5R1NLeUFiSVlKeEN5R3JPMFBsY0VBQ2NWcUVRcEp3a2lKd1psUkVrb3BVRUFIa2twckNpcFFRQUhTd0pMQXFORkEwa25DcUpGQVVzQlNhTkZBa0wvM0VzRVNVc0VpUGlraUF2WFRJajNsU0VFRmlJbkdXVkVTd0ZNaVBnMFR3Sk1pUGh1VElqNGhiRXlDaUluQldWRWdSaGJKYklRSXJJWklySUJzaGduSGJJYXNocXp0RDVYQkFBaUp3ZGxSRXhMQVlqMy9Vc0NwMFJMQmtzQ3BrUXhBQUVuRmt4UXZpaE9BazFMQW9qMzFERUFBU2NXVEZCSnZFaE12MHlJOThRbkIweG5NZ1lXTVFBQkp5dE1VRW04U0V5L3NURUFJNjlQQWxCSkZTTUpJMWdpSndSbFJJRVlXeVd5RUNLeUdTS3lBYklZSnlDeUdreXlHcklhc3lSRElrY0dOaG9CU1JVakVrUTJHZ0pKRlNNU1JEWWFBMGtWSXhKRUlpY1RaVVFVUkxFaUp3UmxSSUVZV3lXeUVDS3lHU0t5QVVteUdDY2ZzaHF6dEQ1WEJBQk1zU1d5RUNLeUdTS3lBYklZSnhDeUdyTzBQbGNFQUVrbkZhUkJBWkJKS0tWQkFZb2tSSWdLdVVVSUlRUVdTVVVISWljWlpVUkxBVXlJOXhWTEJreUk5MDlMQVlqM1pVbEZEa2xMQTRqM1FVc0NpUGRYaVBiNVRJajNOVXNDaVBkTFJRY3BSUWtuQ1VVTElpY0daVXhGQzBSTENTaWxRUUFnU3drcHJDaXBRUUFIU3doTEM2TkZDVXNKSndxaVJRcExDa21qUlF0Qy85bExDMHNKaVBjTVN3R0k5dXhMQmtsT0FvajIvMHlJOXVCTENJajI5ckV5Q2lJbkJXVkVnUmhiSmJJUUlySVpJcklCc2hnbkhiSWFzaHF6dEQ1WEJBQWlKd2RsUkV4TEFZajJia3NDcDBSTEJFc0Nwa1JMQlVzSlNVNEVwa1F4QUFFbkZreFF2aWhPQWsxTEFvajJQREVBQVNjV1RGQkp2RWhNdjB5STlpd25CMHhuTVFBQkp4ZE1VTDRvVGdKTlN3R0k5aGN4QUFFbkYweFFTYnhJVEw4aUp3OWxSRXNCaVBZQkp3OU1aeklHRmpFQUFTY3JURkJKdkVoTXY3RXhBQ092U1VzSVVFa1ZJd2tqV0NJbkJHVkVnUmhiSmJJUUlySVpJcklCc2hnbklMSWFUd0t5R3JJYXM3RXlDa3hQQWxCSkZTTUpJMWdpSnc1bFJJRVlXeVd5RUNLeUdTS3lBYklZSng2eUdreXlHcklhc3lSRElrTCtjellhQVVrVkl4SkVOaG9DU1JVakVrUWlKeE5sUkJSRXNTSW5CR1ZFZ1JoYkpiSVFJcklaSXJJQlNiSVlKeCt5R3JPMFBsY0VBTEVsc2hBaXNoa2lzZ0ZNc2hnbkVMSWFzN1ErVndRQUtLaEVJUVFXSWljWlpVUkxBVXlJOVVGTEJFeUk5WHRMQVlqMWtVeUk5WEpNaVBXSk1RQUJKeGRNVUw0b1RnSk5Td0dJOVE4eEFBRW5GMHhRU2J4SVRMOGlKdzlsUkVzQmlQVDVKdzlNWnpJR0ZqRUFBU2NyVEZCSnZFaE12MHhMQWFaRXNURUFJNjlKVHdSUVNSVWpDU05ZSWljRVpVU0JHRnNsc2hBaXNoa2lzZ0d5R0NjZ3NocFBBcklhc2hxenNUSUtURThDVUVrVkl3a2pXQ0luRG1WRWdSaGJKYklRSXJJWklySUJzaGduSHJJYVRMSWFzaHF6SkVNaVNURUFBU2NyVEZDK0tFNENUU0luS1dWRWlQUnlNZ1lXcGtRaVJ3SVdNUUFCSnhkTVVMNG9UZ0pOS0tWQUFHcEpSUVF4QUFFbkZreFF2aWhPQWswb3BVQUFKMGxGQlVzQ1FRQU1JaWNPWlVReEFFc0ZpUFRPU3dGQkFBd2lKd1ZsUkRFQVN3YUk5TDBrUXpFQUFTY1dURkMrS0U0Q1RVbEZCakVBQVNjV1RGQkp2RWhMQXI4aUp3ZGxSRXlJOUFZbkIweG5KRVVDUXYrdE1RQUJKeGRNVUw0b1RnSk5TVVVGTVFBQkp4ZE1VRW04U0VzQ3Z5SW5EMlZFVElqejF5Y1BUR2NrUlFOQy8yb2lSd1UyR2dGSkZTTVNSRFlhQWtrVkl4SkVJaWNpWlVRVVJDa25DU0luQm1WRVNTaWxRUUFlU1Ntc0tLbEJBQWRMQWtzQ28wVURTU2NLb2tVQlN3RkpvMFVDUXYvY1N3UkxBNk94SWljRVpVU0JHRnNsc2hBaXNoa2lzZ0ZKc2hnbkg3SWFzN1ErVndRQVJRaXhKYklRSXJJWklySUJTYklZSnppeUdyTzBQbGNFQUxFbHNoQWlzaGtpc2dGTEFiSVlKeEN5R3JPMFBsY0VBTEVsc2hBaXNoa2lzZ0ZQQXJJWUp6bXlHck8wUGxjRUFJZ0dxRXNFVEVzQ1N3VkxCWWp5cGtoRkM0Z0dsazhFVEU4Q1R3UlBCSWp5bEVVSlNDbEZDU2NKUlFzaUp3WmxURVVMUkVzSktLVkJBQ0JMQ1Ntc0tLbEJBQWRMQ0VzTG8wVUpTd2tuQ3FKRkNrc0tTYU5GQzBMLzJVc0dTd21JOHhRaEJCWWlKeWhsUklqeW9DSW5KMlZFaVBLbVN3bE1pUExnU3dlSTh2WkxCVXNCcGtRaUp3VmxSREVBTWdwUEJJanpHN0V4QUNPdlR3SlFTUlVqQ1NOWUlpY09aVVNCR0ZzbHNoQWlzaGtpc2dHeUdDY2VzaHBNc2hxeUdyTWtRellhQVVjQ0ZVa2pFa1EyR2dKSlRnTVZJeEpFSWljalpVUVVSTEVpSndSbFJJRVlXeVd5RUNLeUdTS3lBYklZSngreUdyTzBQbGNFQUV3akRrUWpyMGxPQTA4Q1N3R3JpQVdoU1JVakRrUkxBcXVJQlJGSkZTTU9SRXNEcTBzRUZTTU9SRThFVHdTclVFeFFURkNJOFU5SUlRUVdJaWNtWlVSTEFVeUk4ZHRQQWt5SThoVk1pUElzS1NjSklpY0daVVJKS0tWQkFCNUpLYXdvcVVFQUIwc0NTd0tqUlFOSkp3cWlSUUZMQVVtalJRSkMvOXhMQTBzRGlQSDVTd1pMQWFaRXNURUFTd1pMQ1ZCSkZTTUpJMWdpSnc1bFJJRVlXeVd5RUNLeUdTS3lBYklZSnlDeUdreXlHcklhc3lJbkJXVkVNUUJQQW9qeDhTUkRKekV4QUlnRm0wUWlKeEpsUkJRbkVrc0JaeWNMSWs4Q1ZJQUVaUXAwaGt4UXNDUkRKekl4QUlnRmQwUWlKeE5sUkJRbkUwc0JaeWNMSWs4Q1ZJQUU3K3pibGt4UXNDUkRKek14QUlnRlUwUWlKeUpsUkJRbklrc0JaeWNMSWs4Q1ZJQUV4ZXBwT1V4UXNDUkRKelF4QUlnRkwwUWlKeU5sUkJRbkkwc0JaeWNMSWs4Q1ZJQUVGN3B0dDB4UXNDUkROaG9CU1JVakVrUW5OVEVBaUFVRFJDSW5GR1ZFUUFBaEp4dExBV2NpSnhSbFJCUW5GRXNCWnljTElrOENWSUFFRlQxZzNreFFzQ1JESWhZbkcweG5Rdi9iTmhvQlNSVkpJeEpFTmhvQ1NSVkpJeEpFTmhvRFNSVkpJeEpFTmhvRVNSVkpJeEpFTmhvRlNSVkpJeEpFTmhvR1NSVkpJeEpFTmhvSFNSVkpJeEpFTVFBaUp3aGxSQkpBQUFzeEFDSW5EV1ZFRWtFQW5pUkVKeHBMRGtsT0FtY25LRXNOU1U0Q1p5Y3BTd3hKVGdSbkp4aExDMGxPQkdjbkdVc0tTVTRGWnljbVN3bEpUZ0puSnlkTENFbE9CbWRMRVNNT1JDT3ZUd0pMQWF0TENpTU9SRThDU3dLclN4UWpEa1JQQTBzRHEwc09JdzVFVHdSTEJLdExDQ01PUkU4RlN3V3JTd3dqRGtSUEJrc0dxMHNRSXc1RVR3ZFBCNnRQQkU4R1VFeFFUd05RVEZCUEFsQk1VSUFFQ0Y4SnRVeFFzQ1JESWtML1h6WWFBVWtWSXhKRU1RQWlKd2hsUkJKQUFBc3hBQ0luRFdWRUVrRUFGU1JFSndoTEFVbE9BbWVBQk5rOXBObE1VTEFrUXlKQy8rZzJHZ0ZKRlNNU1JERUFJaWNOWlVRU1JDY2hTd0ZuZ0FTeWdTR0tURkN3SkVNeEFDSW5JV1ZFVEVzQkVrUWlKdzFsUkVzQlVJQUUwc3p5a0V4UXNDY05UR2NuSVN0bkpFTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRWlBTkhKd3NpVHdKVUtreFFzQ1JETmhvQlNSVWpFa1FCSnhGTVVMNG5ERTRDVFVraVdVc0JGVktJN1p0SVNSVWpEa1FqcjZzcVRGQ3dKRU0yR2dGSkZTTVNSRFlhQWtrVkl4SkVUQUVuRVV4UXZpY01UZ0pOU1NKWlN3RVZVa3lJN1h0SUtreFFzQ1JETmhvQlNSVWpFa1FCSnhGTVVMNG5ERTRDVFZjQ0lDcE1VTEFrUXpZYUFVa1ZJeEpFTmhvQ1NSVWpFa1NJQXRBa1F6WWFBVWtWSXhKRU5ob0NTUlVqRWtSTEFRRW5FVXhRdmljTVRnSk5Wd0lnTVFDSUFvdEVpQU1USkVNMkdnRkpGU01TUkRZYUFra1ZJeEpFU1RFQUVrU0lBdmtrUXlJbkxHVkVLa3hRc0NSRElpY1laVVJKRlNNT1JDT3ZxeXBNVUxBa1F5SW5HV1ZFU1JVakRrUWpyNnNxVEZDd0pFTWlKeVpsUkVrVkl3NUVJNityS2t4UXNDUkRJaWNuWlVSSkZTTU9SQ092cXlwTVVMQWtReUluQjJWRVNSVWpEa1FqcjZzcVRGQ3dKRU1pSnc5bFJFa1ZJdzVFSTYrcktreFFzQ1JESWljYVpVUkpGU01PUkNPdnF5cE1VTEFrUXlJbkcyVkVTUlVqRGtRanI2c3FURkN3SkVNaUp5aGxSRWtWSXc1RUk2K3JLa3hRc0NSRElpY3BaVVJKRlNNT1JDT3ZxeXBNVUxBa1F5SW5FbVZFSndzaVR3SlVLa3hRc0NSRElpY1RaVVFuQ3lKUEFsUXFURkN3SkVNaUp5SmxSQ2NMSWs4Q1ZDcE1VTEFrUXlJbkkyVkVKd3NpVHdKVUtreFFzQ1JESWljVVpVUW5DeUpQQWxRcVRGQ3dKRU1pSncxbFJDcE1VTEFrUXlJbklXVkVLa3hRc0NSRGlnQUJJckVpSndSbFJJRVlXeVd5RUNLeUdTS3lBVW15R0NjNHNocXp0RDVYQkFCTXNTV3lFQ0t5R1NLeUFVbXlHQ2NRc2hxenRENVhCQUJKVHdLeEpiSVFJcklaSXJJQnNoZ25PYklhczdRK1Z3UUFUQ2NWcFVFQUJTRUVGb3dDaXdHTEFvanN6U0VFRm9qczRrbU1BSXNEcEVFQUNvc0Rpd0NJN0hlTUFJa2lGb3dBaVlvQUFTSkhCQ2NVWlVRa0VrRUFDQ0luRzJWRWpBQ0pzU0luQkdWRWdSaGJKYklRSXJJWklySUJzaGduTnJJYXM3UStWd1FBakFNcGpBSW5DWXdBSWljR1pVeU1BVVNMQVNpbFFRQWdpd0VwckNpcFFRQUhpd0tMQUtPTUFvc0JKd3FpakFHTEFFbWpqQUJDLzlteElpY2xaVVFqcnljVml3S2pVRWtWSXdraldDSW5KR1ZFZ1JoYkpiSVFJcklaSXJJQnNoZ25ON0lhVExJYXNocXpJUVFXaXdOTWlPd0l0RDVYQkFDSTdCdU1BSW1LQWdHTC9nRW5FVXhRdmljTVRnSk5TU0paU3dFVlVvdi9pT3BKU0ltS0FnQ0wvZ0VuRVV4UXZpY01UZ0pOVndJZ01RQ0kvOHBFaS82TC80Z0FBWW1LQWdDTC9nRW5FVXhRU2I0bkRFNENUVWtpV1VzQkZWS0wvNGpwMTBoTVFRQVNNUUNML292L1VFeFFnQVMzLyt2NFRGQ3dpd0JKdmljTVRnSk5Wd0lnSnpwTVVJc0JVRXNCdkVpL2lZb0NBSXYrQVNjUlRGQkp2aWNNVGdKTlNTSlpTd0VWVW92L2lPbWpTRXhCQUJJeEFJditpLzlRVEZDQUJBYk9FNHRNVUxDTEFFbStKd3hPQWsxWEFpQW5Pa3hRaXdGUVN3RzhTTCtKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJDaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9sZE93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVHcmFudGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJNaW50aW5nVG9nZ2xlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9nZ2xlZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVkZWVtaW5nVG9nZ2xlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9nZ2xlZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVjb2xsYXRlcmFsaXplVG9nZ2xlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9nZ2xlZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQnV5YmFja1RvZ2dsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZ2dsZWQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNvbGxhdGVyYWxQcmljZVRvZ2dsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZ2dsZWQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlBvb2xQYXJhbWV0ZXJzU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfY2VpbGluZyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfYm9udXNfcmF0ZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcmVkZW1wdGlvbl9kZWxheSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfbWludF9mZWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3JlZGVlbV9mZWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2J1eWJhY2tfZmVlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19yZWNvbGxhdF9mZWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRpbWVsb2NrU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld190aW1lbG9jayIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3duZXJOb21pbmF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVSZXZva2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
