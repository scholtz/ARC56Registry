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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.SignatureGateway_855423ec
{


    //
    // @title SignatureGateway
    // @author Aave Labs
    // @notice Gateway to consume EIP-712 typed intents for spoke actions on behalf of a user.
    // @dev Uses keyed-nonces where each key's namespace nonce is consumed sequentially. Intents bundled through
    // multicall can be executed independently in order of signed nonce & deadline; does not guarantee batch atomicity.
    //
    public class SignatureGatewayProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SignatureGatewayProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Borrow : AVMObjectType
            {
                public byte[] Spoke { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ReserveId { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte[] OnBehalfOf { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vSpoke.From(Spoke);
                    ret.AddRange(vSpoke.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserveId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vReserveId.From(ReserveId);
                    ret.AddRange(vReserveId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOnBehalfOf.From(OnBehalfOf);
                    ret.AddRange(vOnBehalfOf.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Borrow Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Borrow();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpoke.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpoke = vSpoke.ToValue();
                    if (valueSpoke is byte[] vSpokeValue) { ret.Spoke = vSpokeValue; }
                    var vReserveId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vReserveId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ReserveId = vReserveId;
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOnBehalfOf.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOnBehalfOf = vOnBehalfOf.ToValue();
                    if (valueOnBehalfOf is byte[] vOnBehalfOfValue) { ret.OnBehalfOf = vOnBehalfOfValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Borrow);
                }
                public bool Equals(Borrow? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Borrow left, Borrow right)
                {
                    return EqualityComparer<Borrow>.Default.Equals(left, right);
                }
                public static bool operator !=(Borrow left, Borrow right)
                {
                    return !(left == right);
                }

            }

            public class Repay : AVMObjectType
            {
                public byte[] Spoke { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ReserveId { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte[] OnBehalfOf { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vSpoke.From(Spoke);
                    ret.AddRange(vSpoke.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserveId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vReserveId.From(ReserveId);
                    ret.AddRange(vReserveId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOnBehalfOf.From(OnBehalfOf);
                    ret.AddRange(vOnBehalfOf.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Repay Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Repay();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpoke.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpoke = vSpoke.ToValue();
                    if (valueSpoke is byte[] vSpokeValue) { ret.Spoke = vSpokeValue; }
                    var vReserveId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vReserveId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ReserveId = vReserveId;
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOnBehalfOf.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOnBehalfOf = vOnBehalfOf.ToValue();
                    if (valueOnBehalfOf is byte[] vOnBehalfOfValue) { ret.OnBehalfOf = vOnBehalfOfValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Repay);
                }
                public bool Equals(Repay? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Repay left, Repay right)
                {
                    return EqualityComparer<Repay>.Default.Equals(left, right);
                }
                public static bool operator !=(Repay left, Repay right)
                {
                    return !(left == right);
                }

            }

            public class SetUsingAsCollateral : AVMObjectType
            {
                public byte[] Spoke { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ReserveId { get; set; }

                public bool UseAsCollateral { get; set; }

                public byte[] OnBehalfOf { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vSpoke.From(Spoke);
                    ret.AddRange(vSpoke.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserveId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vReserveId.From(ReserveId);
                    ret.AddRange(vReserveId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseAsCollateral = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vUseAsCollateral.From(UseAsCollateral);
                    ret.AddRange(vUseAsCollateral.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOnBehalfOf.From(OnBehalfOf);
                    ret.AddRange(vOnBehalfOf.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SetUsingAsCollateral Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SetUsingAsCollateral();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpoke.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpoke = vSpoke.ToValue();
                    if (valueSpoke is byte[] vSpokeValue) { ret.Spoke = vSpokeValue; }
                    var vReserveId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vReserveId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ReserveId = vReserveId;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseAsCollateral = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vUseAsCollateral.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUseAsCollateral = vUseAsCollateral.ToValue();
                    if (valueUseAsCollateral is bool vUseAsCollateralValue) { ret.UseAsCollateral = vUseAsCollateralValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOnBehalfOf.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOnBehalfOf = vOnBehalfOf.ToValue();
                    if (valueOnBehalfOf is byte[] vOnBehalfOfValue) { ret.OnBehalfOf = vOnBehalfOfValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SetUsingAsCollateral);
                }
                public bool Equals(SetUsingAsCollateral? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SetUsingAsCollateral left, SetUsingAsCollateral right)
                {
                    return EqualityComparer<SetUsingAsCollateral>.Default.Equals(left, right);
                }
                public static bool operator !=(SetUsingAsCollateral left, SetUsingAsCollateral right)
                {
                    return !(left == right);
                }

            }

            public class Supply : AVMObjectType
            {
                public byte[] Spoke { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ReserveId { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte[] OnBehalfOf { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vSpoke.From(Spoke);
                    ret.AddRange(vSpoke.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserveId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vReserveId.From(ReserveId);
                    ret.AddRange(vReserveId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOnBehalfOf.From(OnBehalfOf);
                    ret.AddRange(vOnBehalfOf.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Supply Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Supply();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpoke.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpoke = vSpoke.ToValue();
                    if (valueSpoke is byte[] vSpokeValue) { ret.Spoke = vSpokeValue; }
                    var vReserveId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vReserveId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ReserveId = vReserveId;
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOnBehalfOf.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOnBehalfOf = vOnBehalfOf.ToValue();
                    if (valueOnBehalfOf is byte[] vOnBehalfOfValue) { ret.OnBehalfOf = vOnBehalfOfValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Supply);
                }
                public bool Equals(Supply? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Supply left, Supply right)
                {
                    return EqualityComparer<Supply>.Default.Equals(left, right);
                }
                public static bool operator !=(Supply left, Supply right)
                {
                    return !(left == right);
                }

            }

            public class UpdateUserDynamicConfig : AVMObjectType
            {
                public byte[] Spoke { get; set; }

                public byte[] OnBehalfOf { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vSpoke.From(Spoke);
                    ret.AddRange(vSpoke.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOnBehalfOf.From(OnBehalfOf);
                    ret.AddRange(vOnBehalfOf.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UpdateUserDynamicConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new UpdateUserDynamicConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpoke.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpoke = vSpoke.ToValue();
                    if (valueSpoke is byte[] vSpokeValue) { ret.Spoke = vSpokeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOnBehalfOf.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOnBehalfOf = vOnBehalfOf.ToValue();
                    if (valueOnBehalfOf is byte[] vOnBehalfOfValue) { ret.OnBehalfOf = vOnBehalfOfValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UpdateUserDynamicConfig);
                }
                public bool Equals(UpdateUserDynamicConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UpdateUserDynamicConfig left, UpdateUserDynamicConfig right)
                {
                    return EqualityComparer<UpdateUserDynamicConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(UpdateUserDynamicConfig left, UpdateUserDynamicConfig right)
                {
                    return !(left == right);
                }

            }

            public class UpdateUserRiskPremium : AVMObjectType
            {
                public byte[] Spoke { get; set; }

                public byte[] OnBehalfOf { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vSpoke.From(Spoke);
                    ret.AddRange(vSpoke.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOnBehalfOf.From(OnBehalfOf);
                    ret.AddRange(vOnBehalfOf.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UpdateUserRiskPremium Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new UpdateUserRiskPremium();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpoke.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpoke = vSpoke.ToValue();
                    if (valueSpoke is byte[] vSpokeValue) { ret.Spoke = vSpokeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOnBehalfOf.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOnBehalfOf = vOnBehalfOf.ToValue();
                    if (valueOnBehalfOf is byte[] vOnBehalfOfValue) { ret.OnBehalfOf = vOnBehalfOfValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UpdateUserRiskPremium);
                }
                public bool Equals(UpdateUserRiskPremium? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UpdateUserRiskPremium left, UpdateUserRiskPremium right)
                {
                    return EqualityComparer<UpdateUserRiskPremium>.Default.Equals(left, right);
                }
                public static bool operator !=(UpdateUserRiskPremium left, UpdateUserRiskPremium right)
                {
                    return !(left == right);
                }

            }

            public class Withdraw : AVMObjectType
            {
                public byte[] Spoke { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ReserveId { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

                public byte[] OnBehalfOf { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vSpoke.From(Spoke);
                    ret.AddRange(vSpoke.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserveId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vReserveId.From(ReserveId);
                    ret.AddRange(vReserveId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOnBehalfOf.From(OnBehalfOf);
                    ret.AddRange(vOnBehalfOf.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Withdraw Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Withdraw();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpoke.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpoke = vSpoke.ToValue();
                    if (valueSpoke is byte[] vSpokeValue) { ret.Spoke = vSpokeValue; }
                    var vReserveId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vReserveId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ReserveId = vReserveId;
                    var vAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount = vAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnBehalfOf = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOnBehalfOf.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOnBehalfOf = vOnBehalfOf.ToValue();
                    if (valueOnBehalfOf is byte[] vOnBehalfOfValue) { ret.OnBehalfOf = vOnBehalfOfValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Withdraw);
                }
                public bool Equals(Withdraw? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Withdraw left, Withdraw right)
                {
                    return EqualityComparer<Withdraw>.Default.Equals(left, right);
                }
                public static bool operator !=(Withdraw left, Withdraw right)
                {
                    return !(left == right);
                }

            }

            public class Eip712DomainReturn : AVMObjectType
            {
                public byte[] Fields { get; set; }

                public string Name { get; set; }

                public string Version { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 ChainId { get; set; }

                public Algorand.Address VerifyingContract { get; set; }

                public byte[] Salt { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] Extensions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1]");
                    vFields.From(Fields);
                    ret.AddRange(vFields.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.From(Version);
                    stringRef[ret.Count] = vVersion.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChainId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vChainId.From(ChainId);
                    ret.AddRange(vChainId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifyingContract = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vVerifyingContract.From(VerifyingContract);
                    ret.AddRange(vVerifyingContract.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vSalt.From(Salt);
                    ret.AddRange(vSalt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExtensions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[]");
                    vExtensions.From(Extensions);
                    ret.AddRange(vExtensions.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Eip712DomainReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Eip712DomainReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1]");
                    count = vFields.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFields = vFields.ToValue();
                    if (valueFields is byte[] vFieldsValue) { ret.Fields = vFieldsValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexVersion = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.Decode(bytes.Skip(indexVersion + prefixOffset).ToArray());
                    var valueVersion = vVersion.ToValue();
                    if (valueVersion is string vVersionValue) { ret.Version = vVersionValue; }
                    var vChainId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vChainId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ChainId = vChainId;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifyingContract = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vVerifyingContract.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVerifyingContract = vVerifyingContract.ToValue();
                    if (valueVerifyingContract is Algorand.Address vVerifyingContractValue) { ret.VerifyingContract = vVerifyingContractValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vSalt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSalt = vSalt.ToValue();
                    if (valueSalt is byte[] vSaltValue) { ret.Salt = vSaltValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExtensions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[]");
                    count = vExtensions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExtensions = vExtensions.ToValue();
                    if (valueExtensions is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vExtensionsValue) { ret.Extensions = vExtensionsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Eip712DomainReturn);
                }
                public bool Equals(Eip712DomainReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Eip712DomainReturn left, Eip712DomainReturn right)
                {
                    return EqualityComparer<Eip712DomainReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(Eip712DomainReturn left, Eip712DomainReturn right)
                {
                    return !(left == right);
                }

            }

            public class SupplyWithSigReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
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

                public static SupplyWithSigReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SupplyWithSigReturn();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SupplyWithSigReturn);
                }
                public bool Equals(SupplyWithSigReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SupplyWithSigReturn left, SupplyWithSigReturn right)
                {
                    return EqualityComparer<SupplyWithSigReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(SupplyWithSigReturn left, SupplyWithSigReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class OwnershipTransferredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 98, 102, 143, 204 };
                public const string Signature = "OwnershipTransferred(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] PreviousOwner { get; set; }
                public byte[] NewOwner { get; set; }

                public static OwnershipTransferredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OwnershipTransferredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is byte[] vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is byte[] vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

            public class SpokeRegisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 161, 144, 53, 134 };
                public const string Signature = "SpokeRegistered(uint8[32],bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Spoke { get; set; }
                public bool Registered { get; set; }

                public static SpokeRegisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SpokeRegisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpoke.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpoke = vSpoke.ToValue();
                    if (valueSpoke is byte[] vSpokeValue) { ret.Spoke = vSpokeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegistered = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vRegistered.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegistered = vRegistered.ToValue();
                    if (valueRegistered is bool vRegisteredValue) { ret.Registered = vRegisteredValue; }
                    return ret;

                }

            }

            public class OwnershipTransferStartedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 142, 90, 121, 135 };
                public const string Signature = "OwnershipTransferStarted(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] PreviousOwner { get; set; }
                public byte[] NewOwner { get; set; }

                public static OwnershipTransferStartedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OwnershipTransferStartedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is byte[] vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is byte[] vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="initialOwner_"> </param>
        public async Task PostInit(Algorand.Address initialOwner_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 15, 48, 174 };
            var initialOwner_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); initialOwner_Abi.From(initialOwner_);

            var result = await base.CallApp(new List<object> { abiHandle, initialOwner_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Algorand.Address initialOwner_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 15, 48, 174 };
            var initialOwner_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); initialOwner_Abi.From(initialOwner_);

            return await base.MakeTransactionList(new List<object> { abiHandle, initialOwner_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISignatureGateway
        ///</summary>
        /// <param name="params"> Supply</param>
        /// <param name="signature"> </param>
        public async Task<Structs.SupplyWithSigReturn> SupplyWithSig(Structs.Supply @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 239, 179, 235 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SupplyWithSigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> SupplyWithSig_Transactions(Structs.Supply @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 239, 179, 235 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISignatureGateway
        ///</summary>
        /// <param name="params"> Withdraw</param>
        /// <param name="signature"> </param>
        public async Task<Structs.SupplyWithSigReturn> WithdrawWithSig(Structs.Withdraw @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 227, 97, 144 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SupplyWithSigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> WithdrawWithSig_Transactions(Structs.Withdraw @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 227, 97, 144 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISignatureGateway
        ///</summary>
        /// <param name="params"> Borrow</param>
        /// <param name="signature"> </param>
        public async Task<Structs.SupplyWithSigReturn> BorrowWithSig(Structs.Borrow @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 208, 72, 94 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SupplyWithSigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> BorrowWithSig_Transactions(Structs.Borrow @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 208, 72, 94 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISignatureGateway
        ///</summary>
        /// <param name="params"> Repay</param>
        /// <param name="signature"> </param>
        public async Task<Structs.SupplyWithSigReturn> RepayWithSig(Structs.Repay @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 44, 130, 170 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SupplyWithSigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RepayWithSig_Transactions(Structs.Repay @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 44, 130, 170 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISignatureGateway
        ///</summary>
        /// <param name="params"> SetUsingAsCollateral</param>
        /// <param name="signature"> </param>
        public async Task SetUsingAsCollateralWithSig(Structs.SetUsingAsCollateral @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 99, 84, 63 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetUsingAsCollateralWithSig_Transactions(Structs.SetUsingAsCollateral @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 99, 84, 63 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISignatureGateway
        ///</summary>
        /// <param name="params"> UpdateUserRiskPremium</param>
        /// <param name="signature"> </param>
        public async Task UpdateUserRiskPremiumWithSig(Structs.UpdateUserRiskPremium @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 21, 25, 206 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateUserRiskPremiumWithSig_Transactions(Structs.UpdateUserRiskPremium @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 21, 25, 206 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISignatureGateway
        ///</summary>
        /// <param name="params"> UpdateUserDynamicConfig</param>
        /// <param name="signature"> </param>
        public async Task UpdateUserDynamicConfigWithSig(Structs.UpdateUserDynamicConfig @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 183, 175, 152 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateUserDynamicConfigWithSig_Transactions(Structs.UpdateUserDynamicConfig @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 183, 175, 152 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> SupplyTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 123, 40, 241 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> SupplyTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 123, 40, 241 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> WithdrawTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 108, 167, 193 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> WithdrawTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 108, 167, 193 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> BorrowTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 238, 187, 215 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> BorrowTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 238, 187, 215 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> RepayTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 228, 156, 137 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> RepayTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 228, 156, 137 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> SetUsingAsCollateralTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 147, 110, 140 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> SetUsingAsCollateralTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 147, 110, 140 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> UpdateUserRiskPremiumTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 73, 129, 249 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> UpdateUserRiskPremiumTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 73, 129, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> UpdateUserDynamicConfigTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 84, 200, 131 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> UpdateUserDynamicConfigTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 84, 200, 131 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IPositionManagerBase
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="registered"> </param>
        public async Task RegisterSpoke(Algorand.Address spoke, bool registered, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 47, 162, 152 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var registeredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); registeredAbi.From(registered);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, registeredAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterSpoke_Transactions(Algorand.Address spoke, bool registered, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 47, 162, 152 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var registeredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); registeredAbi.From(registered);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, registeredAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IPositionManagerBase
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="onBehalfOf"> </param>
        /// <param name="approve"> </param>
        /// <param name="__arc4_nonce"> </param>
        /// <param name="__arc4_deadline"> </param>
        /// <param name="signature"> </param>
        public async Task SetSelfAsUserPositionManagerWithSig(Algorand.Address spoke, Algorand.Address onBehalfOf, bool approve, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_nonce, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 169, 68, 51 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);
            var approveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approveAbi.From(approve);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, onBehalfOfAbi, approveAbi, __arc4_nonce, __arc4_deadline, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSelfAsUserPositionManagerWithSig_Transactions(Algorand.Address spoke, Algorand.Address onBehalfOf, bool approve, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_nonce, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 169, 68, 51 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);
            var approveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approveAbi.From(approve);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, onBehalfOfAbi, approveAbi, __arc4_nonce, __arc4_deadline, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IPositionManagerBase
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="onBehalfOf"> </param>
        /// <param name="__arc4_value"> </param>
        /// <param name="__arc4_deadline"> </param>
        /// <param name="permitV"> </param>
        /// <param name="permitR"> </param>
        /// <param name="permitS"> </param>
        public async Task PermitReserveUnderlying(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Algorand.Address onBehalfOf, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, ulong permitV, byte[] permitR, byte[] permitS, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 0, 77, 131 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);
            var permitVAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permitVAbi.From(permitV);
            var permitRAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); permitRAbi.From(permitR);
            var permitSAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); permitSAbi.From(permitS);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, onBehalfOfAbi, __arc4_value, __arc4_deadline, permitVAbi, permitRAbi, permitSAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PermitReserveUnderlying_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Algorand.Address onBehalfOf, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, ulong permitV, byte[] permitR, byte[] permitS, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 0, 77, 131 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);
            var permitVAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permitVAbi.From(permitV);
            var permitRAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); permitRAbi.From(permitR);
            var permitSAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); permitSAbi.From(permitS);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, onBehalfOfAbi, __arc4_value, __arc4_deadline, permitVAbi, permitRAbi, permitSAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IPositionManagerBase
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="user"> </param>
        public async Task RenouncePositionManagerRole(Algorand.Address spoke, Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 50, 241, 201 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenouncePositionManagerRole_Transactions(Algorand.Address spoke, Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 50, 241, 201 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///@inheritdoc IPositionManagerBase
        ///</summary>
        /// <param name="spoke"> </param>
        public async Task<bool> IsSpokeRegistered(Algorand.Address spoke, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 210, 248, 20 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.SimApp(new List<object> { abiHandle, spokeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsSpokeRegistered_Transactions(Algorand.Address spoke, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 210, 248, 20 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IRescuable
        ///</summary>
        /// <param name="token"> </param>
        /// <param name="to"> </param>
        /// <param name="__arc4_amount"> </param>
        public async Task RescueToken(Algorand.Address token, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 185, 140, 95 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, tokenAbi, toAbi, __arc4_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RescueToken_Transactions(Algorand.Address token, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 185, 140, 95 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi, toAbi, __arc4_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IRescuable
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="__arc4_amount"> </param>
        public async Task RescueNative(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 219, 16, 152 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, __arc4_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RescueNative_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 219, 16, 152 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, __arc4_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IRescuable
        ///</summary>
        public async Task<Algorand.Address> RescueGuardian(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 106, 38, 223 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> RescueGuardian_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 106, 38, 223 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IIntentConsumer
        ///</summary>
        public async Task<byte[]> DomainSeparator(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 11, 142, 70 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> DomainSeparator_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 11, 142, 70 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev See: https://eips.ethereum.org/EIPS/eip-5267
        ///</summary>
        public async Task<Structs.Eip712DomainReturn> Eip712Domain(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 107, 24, 50 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Eip712DomainReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Eip712Domain_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 107, 24, 50 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc INoncesKeyed
        ///</summary>
        /// <param name="__arc4_key"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> UseNonce(System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 214, 133, 147 };
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> UseNonce_Transactions(System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 214, 133, 147 };
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc INoncesKeyed
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="__arc4_key"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Nonces(Algorand.Address owner, System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 235, 249, 27 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Nonces_Transactions(Algorand.Address owner, System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 235, 249, 27 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Returns the address of the pending owner.
        ///</summary>
        public async Task<Algorand.Address> PendingOwner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 173, 69, 22 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> PendingOwner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 173, 69, 22 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Starts the ownership transfer of the contract to a new account. Replaces the pending transfer if there is one.
        /// Can only be called by the current owner.
        /// Setting `newOwner` to the zero address is allowed; this can be used to cancel an initiated ownership transfer.
        ///</summary>
        /// <param name="newOwner"> </param>
        public async Task TransferOwnership(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 123, 175, 180 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferOwnership_Transactions(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 123, 175, 180 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev The new owner accepts the ownership transfer.
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
        /// @dev Returns the address of the current owner.
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
        /// @dev Leaves the contract without owner. It will not be possible to call
        /// `onlyOwner` functions. Can only be called by the current owner.
        /// NOTE: Renouncing ownership will leave the contract without an owner,
        /// thereby disabling any functionality that is only available to the owner.
        ///</summary>
        public async Task RenounceOwnership(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 44, 97, 229 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenounceOwnership_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 44, 97, 229 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2lnbmF0dXJlR2F0ZXdheSIsImRlc2MiOiJAdGl0bGUgU2lnbmF0dXJlR2F0ZXdheVxuIEBhdXRob3IgQWF2ZSBMYWJzXG4gQG5vdGljZSBHYXRld2F5IHRvIGNvbnN1bWUgRUlQLTcxMiB0eXBlZCBpbnRlbnRzIGZvciBzcG9rZSBhY3Rpb25zIG9uIGJlaGFsZiBvZiBhIHVzZXIuXG4gQGRldiBVc2VzIGtleWVkLW5vbmNlcyB3aGVyZSBlYWNoIGtleSdzIG5hbWVzcGFjZSBub25jZSBpcyBjb25zdW1lZCBzZXF1ZW50aWFsbHkuIEludGVudHMgYnVuZGxlZCB0aHJvdWdoXG4gbXVsdGljYWxsIGNhbiBiZSBleGVjdXRlZCBpbmRlcGVuZGVudGx5IGluIG9yZGVyIG9mIHNpZ25lZCBub25jZSAmIGRlYWRsaW5lOyBkb2VzIG5vdCBndWFyYW50ZWUgYmF0Y2ggYXRvbWljaXR5LiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJCb3Jyb3ciOlt7Im5hbWUiOiJzcG9rZSIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJyZXNlcnZlSWQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoib25CZWhhbGZPZiIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGVhZGxpbmUiLCJ0eXBlIjoidWludDI1NiJ9XSwiUmVwYXkiOlt7Im5hbWUiOiJzcG9rZSIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJyZXNlcnZlSWQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoib25CZWhhbGZPZiIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGVhZGxpbmUiLCJ0eXBlIjoidWludDI1NiJ9XSwiU2V0VXNpbmdBc0NvbGxhdGVyYWwiOlt7Im5hbWUiOiJzcG9rZSIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJyZXNlcnZlSWQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InVzZUFzQ29sbGF0ZXJhbCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoib25CZWhhbGZPZiIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGVhZGxpbmUiLCJ0eXBlIjoidWludDI1NiJ9XSwiU3VwcGx5IjpbeyJuYW1lIjoic3Bva2UiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoicmVzZXJ2ZUlkIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6Im9uQmVoYWxmT2YiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoibm9uY2UiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImRlYWRsaW5lIiwidHlwZSI6InVpbnQyNTYifV0sIlVwZGF0ZVVzZXJEeW5hbWljQ29uZmlnIjpbeyJuYW1lIjoic3Bva2UiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoib25CZWhhbGZPZiIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGVhZGxpbmUiLCJ0eXBlIjoidWludDI1NiJ9XSwiVXBkYXRlVXNlclJpc2tQcmVtaXVtIjpbeyJuYW1lIjoic3Bva2UiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoib25CZWhhbGZPZiIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGVhZGxpbmUiLCJ0eXBlIjoidWludDI1NiJ9XSwiV2l0aGRyYXciOlt7Im5hbWUiOiJzcG9rZSIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJyZXNlcnZlSWQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoib25CZWhhbGZPZiIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGVhZGxpbmUiLCJ0eXBlIjoidWludDI1NiJ9XSwiZWlwNzEyRG9tYWluUmV0dXJuIjpbeyJuYW1lIjoiZmllbGRzIiwidHlwZSI6ImJ5dGVbMV0ifSx7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InZlcnNpb24iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiY2hhaW5JZCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidmVyaWZ5aW5nQ29udHJhY3QiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InNhbHQiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJleHRlbnNpb25zIiwidHlwZSI6InVpbnQyNTZbXSJ9XSwiU3VwcGx5V2l0aFNpZ1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ1MTIifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiX19wb3N0SW5pdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbE93bmVyXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VwcGx5V2l0aFNpZyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJU2lnbmF0dXJlR2F0ZXdheSIsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQyNTYsdWludDI1Nix1aW50OFszMl0sdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlN1cHBseSIsIm5hbWUiOiJwYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hdHVyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlN1cHBseVdpdGhTaWdSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd1dpdGhTaWciLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNpZ25hdHVyZUdhdGV3YXkiLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDhbMzJdLHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJXaXRoZHJhdyIsIm5hbWUiOiJwYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hdHVyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlN1cHBseVdpdGhTaWdSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3Jyb3dXaXRoU2lnIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElTaWduYXR1cmVHYXRld2F5IiwiYXJncyI6W3sidHlwZSI6Iih1aW50OFszMl0sdWludDI1Nix1aW50MjU2LHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiQm9ycm93IiwibmFtZSI6InBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmF0dXJlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIpIiwic3RydWN0IjoiU3VwcGx5V2l0aFNpZ1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcGF5V2l0aFNpZyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJU2lnbmF0dXJlR2F0ZXdheSIsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQyNTYsdWludDI1Nix1aW50OFszMl0sdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlJlcGF5IiwibmFtZSI6InBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmF0dXJlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIpIiwic3RydWN0IjoiU3VwcGx5V2l0aFNpZ1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFVzaW5nQXNDb2xsYXRlcmFsV2l0aFNpZyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJU2lnbmF0dXJlR2F0ZXdheSIsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQyNTYsYm9vbCx1aW50OFszMl0sdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlNldFVzaW5nQXNDb2xsYXRlcmFsIiwibmFtZSI6InBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmF0dXJlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZVVzZXJSaXNrUHJlbWl1bVdpdGhTaWciLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNpZ25hdHVyZUdhdGV3YXkiLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlVwZGF0ZVVzZXJSaXNrUHJlbWl1bSIsIm5hbWUiOiJwYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hdHVyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVVc2VyRHluYW1pY0NvbmZpZ1dpdGhTaWciLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNpZ25hdHVyZUdhdGV3YXkiLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlVwZGF0ZVVzZXJEeW5hbWljQ29uZmlnIiwibmFtZSI6InBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmF0dXJlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlNVUFBMWV9UWVBFSEFTSCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJXSVRIRFJBV19UWVBFSEFTSCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJCT1JST1dfVFlQRUhBU0giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUkVQQVlfVFlQRUhBU0giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiU0VUX1VTSU5HX0FTX0NPTExBVEVSQUxfVFlQRUhBU0giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiVVBEQVRFX1VTRVJfUklTS19QUkVNSVVNX1RZUEVIQVNIIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlVQREFURV9VU0VSX0RZTkFNSUNfQ09ORklHX1RZUEVIQVNIIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyU3Bva2UiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVBvc2l0aW9uTWFuYWdlckJhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0ZXJlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU3Bva2VSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRTZWxmQXNVc2VyUG9zaXRpb25NYW5hZ2VyV2l0aFNpZyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJUG9zaXRpb25NYW5hZ2VyQmFzZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbkJlaGFsZk9mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwcm92ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9ub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9kZWFkbGluZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmF0dXJlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBlcm1pdFJlc2VydmVVbmRlcmx5aW5nIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElQb3NpdGlvbk1hbmFnZXJCYXNlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbkJlaGFsZk9mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3ZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2RlYWRsaW5lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJtaXRWIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1pdFIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybWl0UyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW5vdW5jZVBvc2l0aW9uTWFuYWdlclJvbGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVBvc2l0aW9uTWFuYWdlckJhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtdWx0aWNhbGwiLCJkZXNjIjoiQGluaGVyaXRkb2MgSU11bHRpY2FsbCIsImFyZ3MiOlt7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzU3Bva2VSZWdpc3RlcmVkIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElQb3NpdGlvbk1hbmFnZXJCYXNlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlc2N1ZVRva2VuIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElSZXNjdWFibGUiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlc2N1ZU5hdGl2ZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJUmVzY3VhYmxlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzY3VlR3VhcmRpYW4iLCJkZXNjIjoiQGluaGVyaXRkb2MgSVJlc2N1YWJsZSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkRPTUFJTl9TRVBBUkFUT1IiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUludGVudENvbnN1bWVyIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVpcDcxMkRvbWFpbiIsImRlc2MiOiJAZGV2IFNlZTogaHR0cHM6Ly9laXBzLmV0aGVyZXVtLm9yZy9FSVBTL2VpcC01MjY3IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihieXRlWzFdLHN0cmluZyxzdHJpbmcsdWludDUxMixhZGRyZXNzLGJ5dGVbMzJdLHVpbnQyNTZbXSkiLCJzdHJ1Y3QiOiJlaXA3MTJEb21haW5SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVzZU5vbmNlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElOb25jZXNLZXllZCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MTkyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub25jZXMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSU5vbmNlc0tleWVkIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDE5MiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwZW5kaW5nT3duZXIiLCJkZXNjIjoiIEBkZXYgUmV0dXJucyB0aGUgYWRkcmVzcyBvZiB0aGUgcGVuZGluZyBvd25lci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2Zlck93bmVyc2hpcCIsImRlc2MiOiIgQGRldiBTdGFydHMgdGhlIG93bmVyc2hpcCB0cmFuc2ZlciBvZiB0aGUgY29udHJhY3QgdG8gYSBuZXcgYWNjb3VudC4gUmVwbGFjZXMgdGhlIHBlbmRpbmcgdHJhbnNmZXIgaWYgdGhlcmUgaXMgb25lLlxuIENhbiBvbmx5IGJlIGNhbGxlZCBieSB0aGUgY3VycmVudCBvd25lci5cbiBTZXR0aW5nIGBuZXdPd25lcmAgdG8gdGhlIHplcm8gYWRkcmVzcyBpcyBhbGxvd2VkOyB0aGlzIGNhbiBiZSB1c2VkIHRvIGNhbmNlbCBhbiBpbml0aWF0ZWQgb3duZXJzaGlwIHRyYW5zZmVyLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVyU3RhcnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NlcHRPd25lcnNoaXAiLCJkZXNjIjoiIEBkZXYgVGhlIG5ldyBvd25lciBhY2NlcHRzIHRoZSBvd25lcnNoaXAgdHJhbnNmZXIuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvd25lciIsImRlc2MiOiIgQGRldiBSZXR1cm5zIHRoZSBhZGRyZXNzIG9mIHRoZSBjdXJyZW50IG93bmVyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbm91bmNlT3duZXJzaGlwIiwiZGVzYyI6IiBAZGV2IExlYXZlcyB0aGUgY29udHJhY3Qgd2l0aG91dCBvd25lci4gSXQgd2lsbCBub3QgYmUgcG9zc2libGUgdG8gY2FsbFxuIGBvbmx5T3duZXJgIGZ1bmN0aW9ucy4gQ2FuIG9ubHkgYmUgY2FsbGVkIGJ5IHRoZSBjdXJyZW50IG93bmVyLlxuIE5PVEU6IFJlbm91bmNpbmcgb3duZXJzaGlwIHdpbGwgbGVhdmUgdGhlIGNvbnRyYWN0IHdpdGhvdXQgYW4gb3duZXIsXG4gdGhlcmVieSBkaXNhYmxpbmcgYW55IGZ1bmN0aW9uYWxpdHkgdGhhdCBpcyBvbmx5IGF2YWlsYWJsZSB0byB0aGUgb3duZXIuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjd9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIxMTIsMjI2N10sImVycm9yTWVzc2FnZSI6IkFCSSBib29sIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTE4XSwiZXJyb3JNZXNzYWdlIjoiQUJJIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzI0XSwiZXJyb3JNZXNzYWdlIjoiRmFpbGVkQ2FsbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMDZdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnRCYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ2NV0sImVycm9yTWVzc2FnZSI6IkludmFsaWRBY2NvdW50Tm9uY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjczXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZEFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzA3LDY0MjNdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkU2lnbmF0dXJlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI5Ml0sImVycm9yTWVzc2FnZSI6Ik9ubHlSZXNjdWVHdWFyZGlhbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNDFdLCJlcnJvck1lc3NhZ2UiOiJPd25hYmxlSW52YWxpZE93bmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODI5LDY4MTZdLCJlcnJvck1lc3NhZ2UiOiJPd25hYmxlVW5hdXRob3JpemVkQWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0ODMsNTUwMCw1NTMwLDU1NDFdLCJlcnJvck1lc3NhZ2UiOiJTYWZlRVJDMjBGYWlsZWRPcGVyYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTEwLDIxMDcsMjc2MSwyODgyLDMwMDMsMzE2NCwzNDE4LDM2MjEsMzgyNF0sImVycm9yTWVzc2FnZSI6IlNwb2tlTm90UmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5OTVdLCJlcnJvck1lc3NhZ2UiOiJfX3Bvc3RJbml0IGFscmVhZHkgY2FsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjY0MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWRDaGFpbklkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMjMsNjMxMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWREb21haW5TZXBhcmF0b3IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ3MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWROYW1lSGFzaCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjQ2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX2NhY2hlZFRoaXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ3Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWRWZXJzaW9uSGFzaCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzY3LDY4MDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfb3duZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc0Myw2NzU4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX3BlbmRpbmdPd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTgwXSwiZXJyb3JNZXNzYWdlIjoiZW51bSBvdXQgb2YgcmFuZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTU2XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjU4XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzNCwxNDg4LDIwNzQsMjcyNSwyODQ2LDI5NjcsMzEyNywzMzgxLDM1ODQsMzc4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgQm9ycm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBSZXBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgU2V0VXNpbmdBc0NvbGxhdGVyYWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzgxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFN1cHBseSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgVXBkYXRlVXNlckR5bmFtaWNDb25maWciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFVwZGF0ZVVzZXJSaXNrUHJlbWl1bSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgV2l0aGRyYXciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDQ0LDIyNDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwODIsMjczMywyODU0LDI5NzUsMzEzNSwzMzg5LDM1OTIsMzc5NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDgsOTEyLDEyODMsMTMzMiwxMzQyLDEzOTMsMTc0NiwxNzU2LDE4MTksMTgzOSwxODgwLDE4OTAsMjAyMywyMDMzLDIyMzAsMzk5MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MjMsMTAwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQxOTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjkzLDEzNTIsMTgyOSwxODQ5LDE4NTksMjA1OCwyMDY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDgyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKGxlbit1aW50OFtdKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4Myw4MTksODYxLDkzNiwxMDE4LDEwNTcsMTIxNSwxMjU5LDEzMDYsMTM2NSwxNDA2LDE1MjMsMTUzNiwxNzY5LDE5MDMsMjEwMCwyMjU4LDIzMTQsMjM3MiwyNDMwLDI0ODgsMjU0NiwyNjA0LDI2NjIsMjc1MSwyODcyLDI5OTMsMzE1MywzNDA3LDM2MTAsMzgxMyw2NzM4LDY3OThdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4MiwxMDMwXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDM5LDU2NDUsNTc3Nyw1OTA5XSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFOcFoyNWhkSFZ5WlVkaGRHVjNZWGt1YzI5c0xsTnBaMjVoZEhWeVpVZGhkR1YzWVhrdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF6TWlBd0lERWdPQ0F4T1RJS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0TURFZ01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnTUhneE5URm1OMk0zTlNBaVgzQmxibVJwYm1kUGQyNWxjaUlnSWw5allXTm9aV1JFYjIxaGFXNVRaWEJoY21GMGIzSWlJREI0TURBZ0lsOXZkMjVsY2lJZ0lsOWZZM1J2Y2w5d1pXNWthVzVuSWlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQWdNSGd3TURBd0lDSmZjbVZuYVhOMFpYSmxaRk53YjJ0bGN5SWdJbDlqWVdOb1pXUlVhR2x6SWlBaVgyTmhZMmhsWkVOb1lXbHVTV1FpSUNKZlkyRmphR1ZrVG1GdFpVaGhjMmdpSUNKZlkyRmphR1ZrVm1WeWMybHZia2hoYzJnaUlEQjRNakFnSWw5dWIyNWpaWE1pSURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aaUF3ZURZMk9UWTFaVFUzWldGbVpETXhNMk16TVRFMFpUQTVNekpsWm1VeE1qbGxZakpoTmpGbU9HUXpOMkV6WXpRek1EQTNZelJsWlRWaE56WmlPRFZpTjJRZ01IaGpPRGxsWm1SaFlUVTBZekJtTWpCak4yRmtaall4TWpnNE1tUm1NRGsxTUdZMVlUazFNVFl6TjJVd016QTNZMlJqWWpSak5qY3laakk1T0dJNFltTTJJREI0T0dJM00yTXpZelk1WW1JNFptVXpaRFV4TW1Wall6UmpaamMxT1dOak56a3lNemxtTjJJeE56bGlNR1ptWVdOaFlUbGhOelZrTlRJeVlqTTVOREF3WmlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERWdNSGd4TmpJMlltRTNaVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pIVndiaUF5TXdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpSWdvZ0lDQWdaSFZ3YmlBM0NpQWdJQ0J3ZFhOb2FXNTBJRFF3T1RZS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSE4wYjNKbElEVUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREE0TUFvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lITjBiM0psSURBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbDlmWTNSdmNsOXdaVzVrYVc1bklnb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGs1TUdZek1HRmxJREI0T0RCbFptSXpaV0lnTUhneU5XVXpOakU1TUNBd2VETXhaREEwT0RWbElEQjROREF5WXpneVlXRWdNSGc0TnpZek5UUXpaaUF3ZURJd01UVXhPV05sSURCNFlUZGlOMkZtT1RnZ01IZ3hOVGRpTWpobU1TQXdlRGd6Tm1OaE4yTXhJREI0T0RabFpXSmlaRGNnTUhoa1lXVTBPV000T1NBd2VHVmlPVE0yWlRoaklEQjRPRFkwT1RneFpqa2dNSGhqTURVMFl6ZzRNeUF3ZUdJNE1tWmhNams0SURCNE9ERmhPVFEwTXpNZ01IZzNOekF3TkdRNE15QXdlR0ZqTXpKbU1XTTVJREI0TURRNU1UbGhNallnTUhnek5XUXlaamd4TkNBd2VEZGhZams0WXpWbUlEQjRNV0prWWpFd09UZ2dNSGhsWXpaaE1qWmtaaUF3ZUdKa01HSTRaVFEySURCNFl6ZzJZakU0TXpJZ01IaGtObVEyT0RVNU15QXdlRFJpWldKbU9URmlJREI0WkRWaFpEUTFNVFlnTUhobE1UZGlZV1ppTkNBd2VHUTFNakZrTmpBMElEQjRZakZpWW1Jd1lUZ2dNSGd6WlRKak5qRmxOU0F2THlCdFpYUm9iMlFnSWw5ZmNHOXpkRWx1YVhRb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p6ZFhCd2JIbFhhWFJvVTJsbktDaDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblE0V3pNeVhTeDFhVzUwTWpVMkxIVnBiblF5TlRZcExHSjVkR1ZiWFNrb2RXbHVkRFV4TWl4MWFXNTBOVEV5S1NJc0lHMWxkR2h2WkNBaWQybDBhR1J5WVhkWGFYUm9VMmxuS0NoMWFXNTBPRnN6TWwwc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUTRXek15WFN4MWFXNTBNalUyTEhWcGJuUXlOVFlwTEdKNWRHVmJYU2tvZFdsdWREVXhNaXgxYVc1ME5URXlLU0lzSUcxbGRHaHZaQ0FpWW05eWNtOTNWMmwwYUZOcFp5Z29kV2x1ZERoYk16SmRMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwTWpVMktTeGllWFJsVzEwcEtIVnBiblExTVRJc2RXbHVkRFV4TWlraUxDQnRaWFJvYjJRZ0luSmxjR0Y1VjJsMGFGTnBaeWdvZFdsdWREaGJNekpkTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME9Gc3pNbDBzZFdsdWRESTFOaXgxYVc1ME1qVTJLU3hpZVhSbFcxMHBLSFZwYm5RMU1USXNkV2x1ZERVeE1pa2lMQ0J0WlhSb2IyUWdJbk5sZEZWemFXNW5RWE5EYjJ4c1lYUmxjbUZzVjJsMGFGTnBaeWdvZFdsdWREaGJNekpkTEhWcGJuUXlOVFlzWW05dmJDeDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwTWpVMktTeGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxWWE5sY2xKcGMydFFjbVZ0YVhWdFYybDBhRk5wWnlnb2RXbHVkRGhiTXpKZExIVnBiblE0V3pNeVhTeDFhVzUwTWpVMkxIVnBiblF5TlRZcExHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVlZjMlZ5UkhsdVlXMXBZME52Ym1acFoxZHBkR2hUYVdjb0tIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwTWpVMktTeGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpVTFWUVVFeFpYMVJaVUVWSVFWTklLQ2xpZVhSbFd6TXlYU0lzSUcxbGRHaHZaQ0FpVjBsVVNFUlNRVmRmVkZsUVJVaEJVMGdvS1dKNWRHVmJNekpkSWl3Z2JXVjBhRzlrSUNKQ1QxSlNUMWRmVkZsUVJVaEJVMGdvS1dKNWRHVmJNekpkSWl3Z2JXVjBhRzlrSUNKU1JWQkJXVjlVV1ZCRlNFRlRTQ2dwWW5sMFpWc3pNbDBpTENCdFpYUm9iMlFnSWxORlZGOVZVMGxPUjE5QlUxOURUMHhNUVZSRlVrRk1YMVJaVUVWSVFWTklLQ2xpZVhSbFd6TXlYU0lzSUcxbGRHaHZaQ0FpVlZCRVFWUkZYMVZUUlZKZlVrbFRTMTlRVWtWTlNWVk5YMVJaVUVWSVFWTklLQ2xpZVhSbFd6TXlYU0lzSUcxbGRHaHZaQ0FpVlZCRVFWUkZYMVZUUlZKZlJGbE9RVTFKUTE5RFQwNUdTVWRmVkZsUVJVaEJVMGdvS1dKNWRHVmJNekpkSWl3Z2JXVjBhRzlrSUNKeVpXZHBjM1JsY2xOd2IydGxLR0ZrWkhKbGMzTXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSVFpXeG1RWE5WYzJWeVVHOXphWFJwYjI1TllXNWhaMlZ5VjJsMGFGTnBaeWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZbTl2YkN4MWFXNTBNalUyTEhWcGJuUXlOVFlzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luQmxjbTFwZEZKbGMyVnlkbVZWYm1SbGNteDVhVzVuS0dGa1pISmxjM01zZFdsdWRESTFOaXhoWkdSeVpYTnpMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTmpRc1lubDBaVnN6TWwwc1lubDBaVnN6TWwwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WdWIzVnVZMlZRYjNOcGRHbHZiazFoYm1GblpYSlNiMnhsS0dGa1pISmxjM01zWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnRkV3gwYVdOaGJHd29ZbmwwWlZ0ZFcxMHBZbmwwWlZ0ZFcxMGlMQ0J0WlhSb2IyUWdJbWx6VTNCdmEyVlNaV2RwYzNSbGNtVmtLR0ZrWkhKbGMzTXBZbTl2YkNJc0lHMWxkR2h2WkNBaWNtVnpZM1ZsVkc5clpXNG9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WelkzVmxUbUYwYVhabEtHRmtaSEpsYzNNc2RXbHVkREkxTmlsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhOamRXVkhkV0Z5WkdsaGJpZ3BZV1JrY21WemN5SXNJRzFsZEdodlpDQWlSRTlOUVVsT1gxTkZVRUZTUVZSUFVpZ3BZbmwwWlZzek1sMGlMQ0J0WlhSb2IyUWdJbVZwY0RjeE1rUnZiV0ZwYmlncEtHSjVkR1ZiTVYwc2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME5URXlMR0ZrWkhKbGMzTXNZbmwwWlZzek1sMHNkV2x1ZERJMU5sdGRLU0lzSUcxbGRHaHZaQ0FpZFhObFRtOXVZMlVvZFdsdWRERTVNaWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0p1YjI1alpYTW9ZV1JrY21WemN5eDFhVzUwTVRreUtYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0luQmxibVJwYm1kUGQyNWxjaWdwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmhZMk5sY0hSUGQyNWxjbk5vYVhBb0tYWnZhV1FpTENCdFpYUm9iMlFnSW05M2JtVnlLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0p5Wlc1dmRXNWpaVTkzYm1WeWMyaHBjQ2dwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlgxOXdiM04wU1c1cGRGOXliM1YwWlVBMUlHMWhhVzVmYzNWd2NHeDVWMmwwYUZOcFoxOXliM1YwWlVBMklHMWhhVzVmZDJsMGFHUnlZWGRYYVhSb1UybG5YM0p2ZFhSbFFEY2diV0ZwYmw5aWIzSnliM2RYYVhSb1UybG5YM0p2ZFhSbFFEZ2diV0ZwYmw5eVpYQmhlVmRwZEdoVGFXZGZjbTkxZEdWQU9TQnRZV2x1WDNObGRGVnphVzVuUVhORGIyeHNZWFJsY21Gc1YybDBhRk5wWjE5eWIzVjBaVUF4TUNCdFlXbHVYM1Z3WkdGMFpWVnpaWEpTYVhOclVISmxiV2wxYlZkcGRHaFRhV2RmY205MWRHVkFNVEVnYldGcGJsOTFjR1JoZEdWVmMyVnlSSGx1WVcxcFkwTnZibVpwWjFkcGRHaFRhV2RmY205MWRHVkFNVElnYldGcGJsOVRWVkJRVEZsZlZGbFFSVWhCVTBoZmNtOTFkR1ZBTVRNZ2JXRnBibDlYU1ZSSVJGSkJWMTlVV1ZCRlNFRlRTRjl5YjNWMFpVQXhOQ0J0WVdsdVgwSlBVbEpQVjE5VVdWQkZTRUZUU0Y5eWIzVjBaVUF4TlNCdFlXbHVYMUpGVUVGWlgxUlpVRVZJUVZOSVgzSnZkWFJsUURFMklHMWhhVzVmVTBWVVgxVlRTVTVIWDBGVFgwTlBURXhCVkVWU1FVeGZWRmxRUlVoQlUwaGZjbTkxZEdWQU1UY2diV0ZwYmw5VlVFUkJWRVZmVlZORlVsOVNTVk5MWDFCU1JVMUpWVTFmVkZsUVJVaEJVMGhmY205MWRHVkFNVGdnYldGcGJsOVZVRVJCVkVWZlZWTkZVbDlFV1U1QlRVbERYME5QVGtaSlIxOVVXVkJGU0VGVFNGOXliM1YwWlVBeE9TQnRZV2x1WDNKbFoybHpkR1Z5VTNCdmEyVmZjbTkxZEdWQU1qQWdiV0ZwYmw5elpYUlRaV3htUVhOVmMyVnlVRzl6YVhScGIyNU5ZVzVoWjJWeVYybDBhRk5wWjE5eWIzVjBaVUF5TVNCdFlXbHVYM0JsY20xcGRGSmxjMlZ5ZG1WVmJtUmxjbXg1YVc1blgzSnZkWFJsUURJeUlHMWhhVzVmY21WdWIzVnVZMlZRYjNOcGRHbHZiazFoYm1GblpYSlNiMnhsWDNKdmRYUmxRREl6SUcxaGFXNWZiWFZzZEdsallXeHNYM0p2ZFhSbFFESTBJRzFoYVc1ZmFYTlRjRzlyWlZKbFoybHpkR1Z5WldSZmNtOTFkR1ZBTWpVZ2JXRnBibDl5WlhOamRXVlViMnRsYmw5eWIzVjBaVUF5TmlCdFlXbHVYM0psYzJOMVpVNWhkR2wyWlY5eWIzVjBaVUF5TnlCdFlXbHVYM0psYzJOMVpVZDFZWEprYVdGdVgzSnZkWFJsUURJNElHMWhhVzVmUkU5TlFVbE9YMU5GVUVGU1FWUlBVbDl5YjNWMFpVQXlPU0J0WVdsdVgyVnBjRGN4TWtSdmJXRnBibDl5YjNWMFpVQXpNQ0J0WVdsdVgzVnpaVTV2Ym1ObFgzSnZkWFJsUURNeElHMWhhVzVmYm05dVkyVnpYM0p2ZFhSbFFETXlJRzFoYVc1ZmNHVnVaR2x1WjA5M2JtVnlYM0p2ZFhSbFFETXpJRzFoYVc1ZmRISmhibk5tWlhKUGQyNWxjbk5vYVhCZmNtOTFkR1ZBTXpRZ2JXRnBibDloWTJObGNIUlBkMjVsY25Ob2FYQmZjbTkxZEdWQU16VWdiV0ZwYmw5dmQyNWxjbDl5YjNWMFpVQXpOaUJ0WVdsdVgzSmxibTkxYm1ObFQzZHVaWEp6YUdsd1gzSnZkWFJsUURNM0NpQWdJQ0JsY25JS0NtMWhhVzVmY21WdWIzVnVZMlZQZDI1bGNuTm9hWEJmY205MWRHVkFNemM2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURRekNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURRME9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTA5M2JtVnlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyRnNiSE4xWWlCZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTBNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTBOQW9LYldGcGJsOXZkMjVsY2w5eWIzVjBaVUF6TmpvS0lDQWdJR05oYkd4emRXSWdiM2R1WlhJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdOalpYQjBUM2R1WlhKemFHbHdYM0p2ZFhSbFFETTFPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTUFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTVRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUJ3Wlc1a2FXNW5UM2R1WlhJS0lDQWdJR1JwWnlBeENpQWdJQ0FoUFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOTNibUZpYkdWVmJtRjFkR2h2Y21sNlpXUkJZMk52ZFc1MENpQWdJQ0JqWVd4c2MzVmlJRjkwY21GdWMyWmxjazkzYm1WeWMyaHBjQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURVd09nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURVeENncHRZV2x1WDNSeVlXNXpabVZ5VDNkdVpYSnphR2x3WDNKdmRYUmxRRE0wT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEVTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEVTJPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwOTNibVZ5Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pmY0dWdVpHbHVaMDkzYm1WeUlnb2dJQ0FnWkdsbklESXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmpZV3hzYzNWaUlHOTNibVZ5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURobE5XRTNPVGczSUM4dklHMWxkR2h2WkNBaVQzZHVaWEp6YUdsd1ZISmhibk5tWlhKVGRHRnlkR1ZrS0hWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTlRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTmdvS2JXRnBibDl3Wlc1a2FXNW5UM2R1WlhKZmNtOTFkR1ZBTXpNNkNpQWdJQ0JqWVd4c2MzVmlJSEJsYm1ScGJtZFBkMjVsY2dvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl1YjI1alpYTmZjbTkxZEdWQU16STZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNaklLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F6TVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReE9USUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOaklLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOak02Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREl6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVGdnTHk4Z0lsOXViMjVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKOENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JpZkFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEWXlPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWXpDZ3B0WVdsdVgzVnpaVTV2Ym1ObFgzSnZkWFJsUURNeE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlETXhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREU1TWdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk53b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk9Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JRE13Q2lBZ0lDQmpZV3hzYzNWaUlGOTFjMlZPYjI1alpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTJOem9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJPQW9LYldGcGJsOWxhWEEzTVRKRWIyMWhhVzVmY205MWRHVkFNekE2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURjeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURjek9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3WmpBd09EY3dNRGs1TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGxqTURBeE1EVXpOamsyTnpabE5qRTNORGMxTnpJMk5UUTNOakUzTkRZMU56YzJNVGM1TURBd01UTXhNREF3TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOekk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOek1LQ20xaGFXNWZSRTlOUVVsT1gxTkZVRUZTUVZSUFVsOXliM1YwWlVBeU9Ub0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOemNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOemc2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKZlkyRmphR1ZrUkc5dFlXbHVVMlZ3WVhKaGRHOXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR0oxY25rZ01UY0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmWTJGamFHVmtSRzl0WVdsdVUyVndZWEpoZEc5eUlHVjRhWE4wY3dvZ0lDQWdZMkZzYkhOMVlpQmZZMkZqYUdWa1JHOXRZV2x1VTJWd1lYSmhkRzl5U1c1MllXeHBaR0YwWldRS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU1UY0tJQ0FnSUdOaGJHeHpkV0lnWDJKMWFXeGtSRzl0WVdsdVUyVndZWEpoZEc5eUNpQWdJQ0JpZFhKNUlERTJDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpFM09nb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTnpjNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTnpnS0NtMWhhVzVmY21WelkzVmxSM1ZoY21ScFlXNWZjbTkxZEdWQU1qZzZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGd5Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGd6T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCallXeHNjM1ZpSUc5M2JtVnlDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBT0RJNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBT0RNS0NtMWhhVzVmY21WelkzVmxUbUYwYVhabFgzSnZkWFJsUURJM09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNek1LSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFPRGNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFPRGc2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJVbVZ6WTNWbFIzVmhjbVJwWVc0S0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWkdsbklETXlDaUFnSUNCallXeHNjM1ZpSUVGa1pISmxjM011YzJWdVpGWmhiSFZsQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU9EYzZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU9EZ0tDbTFoYVc1ZmNtVnpZM1ZsVkc5clpXNWZjbTkxZEdWQU1qWTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURNekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURreUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURrek9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTFKbGMyTjFaVWQxWVhKa2FXRnVDaUFnSUNCa2FXY2dPUW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQmthV2NnTXpNS0lDQWdJR05oYkd4emRXSWdVMkZtWlVWU1F6SXdMbk5oWm1WVWNtRnVjMlpsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEa3lPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEa3pDZ3B0WVdsdVgybHpVM0J2YTJWU1pXZHBjM1JsY21Wa1gzSnZkWFJsUURJMU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGszQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGs0T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHTmhiR3h6ZFdJZ1gybHpVM0J2YTJWU1pXZHBjM1JsY21Wa0NpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEazNPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEazRDZ3B0WVdsdVgyMTFiSFJwWTJGc2JGOXliM1YwWlVBeU5Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E1Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNvS0lDQWdJR0oxY25rZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR0oxY25rZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0oxY25rZ01qVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZFhKNUlEVUtDbTFoYVc1ZlptOXlYMmhsWVdSbGNrQXhNREU2Q2lBZ0lDQmthV2NnTkFvZ0lDQWdaR2xuSURjS0lDQWdJRHdLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmWm05eVFERXdNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWpZS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR1p2Y2lBb2JHVnVLeWhzWlc0cmRXbHVkRGhiWFNsYlhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUdKMWNua2dOUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ05Rb2dJQ0FnWWlCdFlXbHVYMlp2Y2w5b1pXRmtaWEpBTVRBeENncHRZV2x1WDJGbWRHVnlYMlp2Y2tBeE1ETTZDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXdOam9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlNak1LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNakkwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlREF3TURBS0lDQWdJR0oxY25rZ01qWUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZFhKNUlEZ0tDbTFoYVc1ZmQyaHBiR1ZmZEc5d1FESXlOVG9LSUNBZ0lHUnBaeUEzQ2lBZ0lDQmthV2NnTndvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQXlNamNLSUNBZ0lHUnBaeUF5TlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR0o2WlhKdkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURBd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZMkZzYkhOMVlpQmZjbVZqWVd4amRXeGhkR1ZmYUdWaFpGOW1iM0pmWld4bGJXVnVkSE5mZDJsMGFGOWllWFJsWDJ4bGJtZDBhRjlvWldGa0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JpZFhKNUlESTJDaUFnSUNCaUlHMWhhVzVmZDJocGJHVmZkRzl3UURJeU5Rb0tiV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQXlNamM2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlkWEo1SURJMENpQWdJQ0JrYVdjZ01qVUtJQ0FnSUdKMWNua2dNVGNLQ20xaGFXNWZkMmhwYkdWZmRHOXdRREl5T0RvS0lDQWdJR1JwWnlBMkNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01qUUtJQ0FnSUdJK0NpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURJek1Bb2dJQ0FnYkc5aFpDQXdDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF5TkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JREVLSUNBZ0lITjFZbk4wY21sdVp5QXdJRElLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2RYQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lDc0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURBd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJmY21WallXeGpkV3hoZEdWZmFHVmhaRjltYjNKZlpXeGxiV1Z1ZEhOZmQybDBhRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTVRnS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Rb2dJQ0FnWWlzS0lDQWdJR0oxY25rZ01qUUtJQ0FnSUdJZ2JXRnBibDkzYUdsc1pWOTBiM0JBTWpJNENncHRZV2x1WDJGbWRHVnlYM2RvYVd4bFFESXpNRG9LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1pHbG5JREUzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESXlNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlNalFLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1EVTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UQTJDZ3B0WVdsdVgzSmxibTkxYm1ObFVHOXphWFJwYjI1TllXNWhaMlZ5VW05c1pWOXliM1YwWlVBeU16b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhOUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFeE1Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1URTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR05oYkd4emRXSWdYMk5vWldOclQzZHVaWElLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdScFp5QXhNd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZbVZrTXpjNFpUZ2dMeThnYldWMGFHOWtJQ0p5Wlc1dmRXNWpaVkJ2YzJsMGFXOXVUV0Z1WVdkbGNsSnZiR1VvWVdSa2NtVnpjeWwyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhNVEE2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVEV4Q2dwdFlXbHVYM0JsY20xcGRGSmxjMlZ5ZG1WVmJtUmxjbXg1YVc1blgzSnZkWFJsUURJeU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNamtLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREk0Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNeklLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEWUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTndvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBNENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01Ua0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEUxQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV4TmpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1pHbG5JREV6Q2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gybHpVM0J2YTJWU1pXZHBjM1JsY21Wa0NpQWdJQ0JoYzNObGNuUWdMeThnVTNCdmEyVk9iM1JTWldkcGMzUmxjbVZrQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElESTFOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dkbUZzYVdSaGRHbHZiZ29nSUNBZ2NIVnphR2x1ZENBeU5UVUtJQ0FnSUNZS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeU9Rb2dJQ0FnWTJGc2JITjFZaUJmWjJWMFVtVnpaWEoyWlZWdVpHVnliSGxwYm1jS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTXpVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSaE9HUmtNRGhtSUM4dklHMWxkR2h2WkNBaWNHVnliV2wwS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERZMExHSjVkR1ZiTXpKZExHSjVkR1ZiTXpKZEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklESTFDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTVRnS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXhOVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNVFlLQ20xaGFXNWZjMlYwVTJWc1prRnpWWE5sY2xCdmMybDBhVzl1VFdGdVlXZGxjbGRwZEdoVGFXZGZjbTkxZEdWQU1qRTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVFVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5WeWVTQTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNekFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXpNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFeU1Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1qRTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR1JwWnlBeE13b2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRjlwYzFOd2IydGxVbVZuYVhOMFpYSmxaQW9nSUNBZ1lYTnpaWEowSUM4dklGTndiMnRsVG05MFVtVm5hWE4wWlhKbFpBb2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZDU1NCaWIyOXNJSFpoYkdsa1lYUnBiMjRLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1JwWnlBeE5Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQTJNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXpFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFMkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFOMlU1WVRSak9DQXZMeUJ0WlhSb2IyUWdJbk5sZEZWelpYSlFiM05wZEdsdmJrMWhibUZuWlhKelYybDBhRk5wWnlnb2RXbHVkRGhiTXpKZExDaDFhVzUwT0Zzek1sMHNZbTl2YkNsYlhTeDFhVzUwTWpVMkxIVnBiblF5TlRZcExHSjVkR1ZiWFNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1qQTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1USXhDZ3B0WVdsdVgzSmxaMmx6ZEdWeVUzQnZhMlZmY205MWRHVkFNakE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRVS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKMWNua2dNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TWpVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRJMk9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTA5M2JtVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCUWtrZ1ltOXZiQ0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpFRmtaSEpsYzNNS0lDQWdJR1IxY0FvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaVgzSmxaMmx6ZEdWeVpXUlRjRzlyWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWkdsbklERXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0V4T1RBek5UZzJJQzh2SUcxbGRHaHZaQ0FpVTNCdmEyVlNaV2RwYzNSbGNtVmtLSFZwYm5RNFd6TXlYU3hpYjI5c0tTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRJMU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFeU5nb0tiV0ZwYmw5VlVFUkJWRVZmVlZORlVsOUVXVTVCVFVsRFgwTlBUa1pKUjE5VVdWQkZTRUZUU0Y5eWIzVjBaVUF4T1RvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UTXdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXpNVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVMFlURTJPR1JrT0dJek1tUXlOakJrTURka05tWXdZbVU0TXpKbE1qTXdNelZoTmpWaE5EZG1Oemc0TmpjMVlqQmlNREl5TnpCak5qaGlPVGczT0RnMkNpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhNekE2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVE14Q2dwdFlXbHVYMVZRUkVGVVJWOVZVMFZTWDFKSlUwdGZVRkpGVFVsVlRWOVVXVkJGU0VGVFNGOXliM1YwWlVBeE9Eb0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVE0xQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV6TmpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VTVNVFV4TURZd09UaGxNMlZsWlRGbVltVTVNR0ZsWW1OaVptUTJPR1U1TXpGak5UTTVORGsxWVdZMk0yVXlOREEyTm1WaVpXVmlZall6T0dRek1ESXpDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TXpVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRNMkNncHRZV2x1WDFORlZGOVZVMGxPUjE5QlUxOURUMHhNUVZSRlVrRk1YMVJaVUVWSVFWTklYM0p2ZFhSbFFERTNPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TkRBS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRReE9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOV1EwTXpVd1pURm1NalZsWTJRMk1tRXpOV0kxTUdVNFkyUXhaVEF3WW1Nek5ETXpNV0ZsT0dNM01qaGxaVFJrWW1JMk9XVmpaakV3TWpOa1lXVmpaamNLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFME1Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5ERUtDbTFoYVc1ZlVrVlFRVmxmVkZsUVJVaEJVMGhmY205MWRHVkFNVFk2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFME5Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5EWTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxWkRJelptVTVPV0UzWVdGak16azRaREF6T1RVeVlUQTVPR1poWVRnNE9Ea3lOVGxrTURZeU56ZzBZbVE0TUdWaE1HWXhOVGxsTkdGbU5qQTBZekEwTlFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UUTFPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTBOZ29LYldGcGJsOUNUMUpTVDFkZlZGbFFSVWhCVTBoZmNtOTFkR1ZBTVRVNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERTFNQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhOVEU2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMVpUSTBPRGc1TldFeU16TTJPRGhpWVRKaE56QmlObVkxTmpBME56SmtZbU15TjJVek5XVmpaVEJrT0RZNU1UUm1OMlEwTTJKbU1tWTNaR1k0TURJMVlnb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVFV3T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUxTVFvS2JXRnBibDlYU1ZSSVJGSkJWMTlVV1ZCRlNFRlRTRjl5YjNWMFpVQXhORG9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRVMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFMU5qb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3WW1NM00yVmlOVGhqWmpRd05qaGhNamxpT1RVNU0yVm1NVGhqTUdReU5tSXpZalEwTlROaVpESXhOVFUwTWpSaE9UQmpZakkyWVRJeVpqUXhaRGRtQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5UVTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UVTJDZ3B0WVdsdVgxTlZVRkJNV1Y5VVdWQkZTRUZUU0Y5eWIzVjBaVUF4TXpvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UWXdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTJNVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpWbE9EVTBPVGRsWWpJNU0yTXdNREZsT0RRNE0yWmxNVEExWldaaFpHUXhaRFV3WVdFd1pHRmtabU13TlRjd1lqSTNNRFU0TURNeFpHWmpaV0ZpTW1VMkNpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhOakE2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVFl4Q2dwdFlXbHVYM1Z3WkdGMFpWVnpaWEpFZVc1aGJXbGpRMjl1Wm1sblYybDBhRk5wWjE5eWIzVjBaVUF4TWpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU1Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREV5T0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdWWEJrWVhSbFZYTmxja1I1Ym1GdGFXTkRiMjVtYVdjS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5WeWVTQXhOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TmpVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRZMk9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmthV2NnTVRrS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmpZV3hzYzNWaUlGOXBjMU53YjJ0bFVtVm5hWE4wWlhKbFpBb2dJQ0FnWVhOelpYSjBJQzh2SUZOd2IydGxUbTkwVW1WbmFYTjBaWEpsWkFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZVMmxuYm1GMGRYSmxSMkYwWlhkaGVTNXpiMnd1UlVsUU56RXlTR0Z6YUM1b1lYTm9LREVwWHpZS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTkFvZ0lDQWdaR2xuSURFNUNpQWdJQ0JqWVd4c2MzVmlJRjkyWlhKcFpubEJibVJEYjI1emRXMWxTVzUwWlc1MENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNV1l4WkRGaU1EWWdMeThnYldWMGFHOWtJQ0oxY0dSaGRHVlZjMlZ5UkhsdVlXMXBZME52Ym1acFp5aGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRZMU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFMk5nb0tiV0ZwYmw5MWNHUmhkR1ZWYzJWeVVtbHphMUJ5WlcxcGRXMVhhWFJvVTJsblgzSnZkWFJsUURFeE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRJNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJWY0dSaGRHVlZjMlZ5VW1semExQnlaVzFwZFcwS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5WeWVTQXhOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TnpBS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRjeE9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmthV2NnTVRrS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmpZV3hzYzNWaUlGOXBjMU53YjJ0bFVtVm5hWE4wWlhKbFpBb2dJQ0FnWVhOelpYSjBJQzh2SUZOd2IydGxUbTkwVW1WbmFYTjBaWEpsWkFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZVMmxuYm1GMGRYSmxSMkYwWlhkaGVTNXpiMnd1UlVsUU56RXlTR0Z6YUM1b1lYTm9LREVwWHpVS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTkFvZ0lDQWdaR2xuSURFNUNpQWdJQ0JqWVd4c2MzVmlJRjkyWlhKcFpubEJibVJEYjI1emRXMWxTVzUwWlc1MENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVE14TWpjeE4yRWdMeThnYldWMGFHOWtJQ0oxY0dSaGRHVlZjMlZ5VW1semExQnlaVzFwZFcwb1lXUmtjbVZ6Y3lsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREUzTURvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TnpFS0NtMWhhVzVmYzJWMFZYTnBibWRCYzBOdmJHeGhkR1Z5WVd4WGFYUm9VMmxuWDNKdmRYUmxRREV3T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJeENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFl4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQlRaWFJWYzJsdVowRnpRMjlzYkdGMFpYSmhiQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmlkWEo1SURFMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERTNOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhOelk2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdScFp5QXhPUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdOaGJHeHpkV0lnWDJselUzQnZhMlZTWldkcGMzUmxjbVZrQ2lBZ0lDQmhjM05sY25RZ0x5OGdVM0J2YTJWT2IzUlNaV2RwYzNSbGNtVmtDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTmpVZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VGFXZHVZWFIxY21WSFlYUmxkMkY1TG5OdmJDNUZTVkEzTVRKSVlYTm9MbWhoYzJnb01TbGZOQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURrM0lETXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeE1qa2dNeklLSUNBZ0lHUnBaeUEwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNakFLSUNBZ0lHTmhiR3h6ZFdJZ1gzWmxjbWxtZVVGdVpFTnZibk4xYldWSmJuUmxiblFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURVeE1nb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpNbUZpWlRZNE9DQXZMeUJ0WlhSb2IyUWdJbk5sZEZWemFXNW5RWE5EYjJ4c1lYUmxjbUZzS0hWcGJuUXlOVFlzWW05dmJDeGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TnpVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRjMkNncHRZV2x1WDNKbGNHRjVWMmwwYUZOcFoxOXliM1YwWlVBNU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTWdOQ0F2THlBeE9USUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUZKbGNHRjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjFjbmtnTVRVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UZ3dDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTRNVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWkdsbklERTVDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRjlwYzFOd2IydGxVbVZuYVhOMFpYSmxaQW9nSUNBZ1lYTnpaWEowSUM4dklGTndiMnRsVG05MFVtVm5hWE4wWlhKbFpBb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlUYVdkdVlYUjFjbVZIWVhSbGQyRjVMbk52YkM1RlNWQTNNVEpJWVhOb0xtaGhjMmdvTVNsZk13b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREV5T0NBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dOQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkdsbklESXlDaUFnSUNCallXeHNjM1ZpSUY5MlpYSnBabmxCYm1SRGIyNXpkVzFsU1c1MFpXNTBDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHTmhiR3h6ZFdJZ1gyZGxkRkpsYzJWeWRtVlZibVJsY214NWFXNW5DaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOUW9nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dORFkzTVdGa1lpQXZMeUJ0WlhSb2IyUWdJbWRsZEZWelpYSlViM1JoYkVSbFluUW9kV2x1ZERJMU5peGhaR1J5WlhOektYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHTmhiR3h6ZFdJZ1RXRjBhRlYwYVd4ekxtMXBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHUnBaeUExQ2lBZ0lDQmthV2NnTndvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNd29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxSVkpETWpBdWMyRm1aVlJ5WVc1elptVnlSbkp2YlFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WRlVrTXlNQzVtYjNKalpVRndjSEp2ZG1VS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHRTNaakpqTjJWaUlDOHZJRzFsZEdodlpDQWljbVZ3WVhrb2RXbHVkREkxTml4MWFXNTBNalUyTEdGa1pISmxjM01wS0hWcGJuUXlOVFlzZFdsdWRESTFOaWtpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURNeUNpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdNellnTXpJS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QXhDaUFnSUNCaWZBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFNE1Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE9ERUtDbTFoYVc1ZlltOXljbTkzVjJsMGFGTnBaMTl5YjNWMFpVQTRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREl4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR01nTkNBdkx5QXhPVElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlFSnZjbkp2ZHdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREU0TlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4T0RZNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZmFYTlRjRzlyWlZKbFoybHpkR1Z5WldRS0lDQWdJR0Z6YzJWeWRDQXZMeUJUY0c5clpVNXZkRkpsWjJsemRHVnlaV1FLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlUybG5ibUYwZFhKbFIyRjBaWGRoZVM1emIyd3VSVWxRTnpFeVNHRnphQzVvWVhOb0tERXBYeklLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdaR2xuSURRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHUnBaeUF5TWdvZ0lDQWdZMkZzYkhOMVlpQmZkbVZ5YVdaNVFXNWtRMjl1YzNWdFpVbHVkR1Z1ZEFvZ0lDQWdaR2xuSURNS0lDQWdJR1JwWnlBekNpQWdJQ0JqWVd4c2MzVmlJRjluWlhSU1pYTmxjblpsVlc1a1pYSnNlV2x1WndvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pNams1WXpabVpTQXZMeUJ0WlhSb2IyUWdJbUp2Y25KdmR5aDFhVzUwTWpVMkxIVnBiblF5TlRZc1lXUmtjbVZ6Y3lrb2RXbHVkREkxTml4MWFXNTBNalUyS1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElETXlDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTXpZZ016SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxSVkpETWpBdWMyRm1aVlJ5WVc1elptVnlDaUFnSUNCd2RYTm9hVzUwSURZMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhPRFU2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVGcyQ2dwdFlXbHVYM2RwZEdoa2NtRjNWMmwwYUZOcFoxOXliM1YwWlVBM09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTWdOQ0F2THlBeE9USUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUZkcGRHaGtjbUYzQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0oxY25rZ01UVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVGt3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREU1TVRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1pHbG5JREU1Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pIVndDaUFnSUNCallXeHNjM1ZpSUY5cGMxTndiMnRsVW1WbmFYTjBaWEpsWkFvZ0lDQWdZWE56WlhKMElDOHZJRk53YjJ0bFRtOTBVbVZuYVhOMFpYSmxaQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VGFXZHVZWFIxY21WSFlYUmxkMkY1TG5OdmJDNUZTVkEzTVRKSVlYTm9MbWhoYzJnb01TbGZNUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01UWXdJRE15Q2lBZ0lDQmthV2NnTkFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pHbG5JREl5Q2lBZ0lDQmpZV3hzYzNWaUlGOTJaWEpwWm5sQmJtUkRiMjV6ZFcxbFNXNTBaVzUwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURNS0lDQWdJR05oYkd4emRXSWdYMmRsZEZKbGMyVnlkbVZWYm1SbGNteDVhVzVuQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWmhaak5qTnpsbUlDOHZJRzFsZEdodlpDQWlkMmwwYUdSeVlYY29kV2x1ZERJMU5peDFhVzUwTWpVMkxHRmtaSEpsYzNNcEtIVnBiblF5TlRZc2RXbHVkREkxTmlraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXpNZ29nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURNMklETXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVVZTUXpJd0xuTmhabVZVY21GdWMyWmxjZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR0o4Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVGt3T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREU1TVFvS2JXRnBibDl6ZFhCd2JIbFhhWFJvVTJsblgzSnZkWFJsUURZNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qRUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFl5QTBJQzh2SURFNU1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVTNWd2NHeDVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjFjbmtnTVRVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UazFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTVOam9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWkdsbklERTVDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRjlwYzFOd2IydGxVbVZuYVhOMFpYSmxaQW9nSUNBZ1lYTnpaWEowSUM4dklGTndiMnRsVG05MFVtVm5hWE4wWlhKbFpBb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdSVWxRTnpFeVNHRnphQzVvWVhOb0NpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F4TmpBZ016SUtJQ0FnSUdScFp5QTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JrYVdjZ01qSUtJQ0FnSUdOaGJHeHpkV0lnWDNabGNtbG1lVUZ1WkVOdmJuTjFiV1ZKYm5SbGJuUUtJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNd29nSUNBZ1kyRnNiSE4xWWlCZloyVjBVbVZ6WlhKMlpWVnVaR1Z5YkhscGJtY0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psUlZKRE1qQXVjMkZtWlZSeVlXNXpabVZ5Um5KdmJRb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QXlDaUFnSUNCallXeHNjM1ZpSUZOaFptVkZVa015TUM1bWIzSmpaVUZ3Y0hKdmRtVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dNVFV5TTJNeElDOHZJRzFsZEdodlpDQWljM1Z3Y0d4NUtIVnBiblF5TlRZc2RXbHVkREkxTml4aFpHUnlaWE56S1NoMWFXNTBNalUyTEhWcGJuUXlOVFlwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBek1nb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRE0ySURNeUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE9UVTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UazJDZ3B0WVdsdVgxOWZjRzl6ZEVsdWFYUmZjbTkxZEdWQU5Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnWW5sMFpXTWdPU0F2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRjlmY0c5emRFbHVhWFFnWVd4eVpXRmtlU0JqWVd4c1pXUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0lsOWZZM1J2Y2w5d1pXNWthVzVuSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpWDNKbFoybHpkR1Z5WldSVGNHOXJaWE1pQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWDI5M2JtVnlJZ29nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmZjR1Z1WkdsdVowOTNibVZ5SWdvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE15QXZMeUFpWDJOaFkyaGxaRlJvYVhNaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0lsOWpZV05vWldSRGFHRnBia2xrSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERTFJQzh2SUNKZlkyRmphR1ZrVG1GdFpVaGhjMmdpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKZlkyRmphR1ZrVm1WeWMybHZia2hoYzJnaUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lsOWpZV05vWldSRWIyMWhhVzVUWlhCaGNtRjBiM0lpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnUFQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBkMjVoWW14bFNXNTJZV3hwWkU5M2JtVnlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0FvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR0o1ZEdWaklERTVJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lpWUtJQ0FnSUdKNWRHVmpJREU1SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0pmWTJGamFHVmtWR2hwY3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaVgyTmhZMmhsWkVOb1lXbHVTV1FpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaVgyTmhZMmhsWkU1aGJXVklZWE5vSWdvZ0lDQWdZbmwwWldNZ01qQWdMeThnTUhnMk5qazJOV1UxTjJWaFptUXpNVE5qTXpFeE5HVXdPVE15WldabE1USTVaV0l5WVRZeFpqaGtNemRoTTJNME16QXdOMk0wWldVMVlUYzJZamcxWWpka0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0lsOWpZV05vWldSV1pYSnphVzl1U0dGemFDSUtJQ0FnSUdKNWRHVmpJREl4SUM4dklEQjRZemc1Wldaa1lXRTFOR013WmpJd1l6ZGhaR1kyTVRJNE9ESmtaakE1TlRCbU5XRTVOVEUyTXpkbE1ETXdOMk5rWTJJMFl6WTNNbVl5T1RoaU9HSmpOZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaSFZ3TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1JwWnlBeENpQWdJQ0JpZVhSbFl5QXlNaUF2THlBd2VEaGlOek5qTTJNMk9XSmlPR1psTTJRMU1USmxZMk0wWTJZM05UbGpZemM1TWpNNVpqZGlNVGM1WWpCbVptRmpZV0U1WVRjMVpEVXlNbUl6T1RRd01HWUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZbmwwWldNZ01UY2dMeThnTUhneU1Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmllWFJsWXlBeU1DQXZMeUF3ZURZMk9UWTFaVFUzWldGbVpETXhNMk16TVRFMFpUQTVNekpsWm1VeE1qbGxZakpoTmpGbU9HUXpOMkV6WXpRek1EQTNZelJsWlRWaE56WmlPRFZpTjJRS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROREFLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWW5sMFpXTWdNakVnTHk4Z01IaGpPRGxsWm1SaFlUVTBZekJtTWpCak4yRmtaall4TWpnNE1tUm1NRGsxTUdZMVlUazFNVFl6TjJVd016QTNZMlJqWWpSak5qY3laakk1T0dJNFltTTJDaUFnSUNCeVpYQnNZV05sTXdvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURZd0NpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1JwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjVkR1ZqSURJeklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVFvZ0lDQWdjbVZ3YkdGalpUTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RBS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBekNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHTnZibU5oZEFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBeE5qQUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnJaV05qWVdzeU5UWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lITjNZWEFLSUNBZ0lITjBiM0psSURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSWw5allXTm9aV1JFYjIxaGFXNVRaWEJoY21GMGIzSWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNWhjbU0wTGw5eVpXTmhiR04xYkdGMFpWOW9aV0ZrWDJadmNsOWxiR1Z0Wlc1MGMxOTNhWFJvWDJKNWRHVmZiR1Z1WjNSb1gyaGxZV1FvWVhKeVlYbGZhR1ZoWkY5aGJtUmZkR0ZwYkRvZ1lubDBaWE1zSUd4bGJtZDBhRG9nZFdsdWREWTBMQ0J6ZEdGeWRGOWhkRjlwYm1SbGVEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tYM0psWTJGc1kzVnNZWFJsWDJobFlXUmZabTl5WDJWc1pXMWxiblJ6WDNkcGRHaGZZbmwwWlY5c1pXNW5kR2hmYUdWaFpEb0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNvS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MyVnNaV04wQ2lBZ0lDQnpkMkZ3Q2dwZmNtVmpZV3hqZFd4aGRHVmZhR1ZoWkY5bWIzSmZaV3hsYldWdWRITmZkMmwwYUY5aWVYUmxYMnhsYm1kMGFGOW9aV0ZrWDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdQQW9nSUNBZ1lub2dYM0psWTJGc1kzVnNZWFJsWDJobFlXUmZabTl5WDJWc1pXMWxiblJ6WDNkcGRHaGZZbmwwWlY5c1pXNW5kR2hmYUdWaFpGOWhablJsY2w5bWIzSkFOQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCeVpYQnNZV05sTXdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvZ0lDQWdZaUJmY21WallXeGpkV3hoZEdWZmFHVmhaRjltYjNKZlpXeGxiV1Z1ZEhOZmQybDBhRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtYMlp2Y2w5b1pXRmtaWEpBTVFvS1gzSmxZMkZzWTNWc1lYUmxYMmhsWVdSZlptOXlYMlZzWlcxbGJuUnpYM2RwZEdoZllubDBaVjlzWlc1bmRHaGZhR1ZoWkY5aFpuUmxjbDltYjNKQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxTnBaMjVoZEhWeVpVZGhkR1YzWVhrdWMyOXNMa0ZrWkhKbGMzTXVjMlZ1WkZaaGJIVmxLSEpsWTJsd2FXVnVkRG9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNrRmtaSEpsYzNNdWMyVnVaRlpoYkhWbE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JDWVd4aGJtTmxDaUFnSUNCd2IzQUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWp3S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5Qkpibk4xWm1acFkybGxiblJDWVd4aGJtTmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnWTJGc2JITjFZaUJNYjNkTVpYWmxiRU5oYkd3dVkyRnNiRTV2VW1WMGRYSnVDaUFnSUNCaWVpQkJaR1J5WlhOekxuTmxibVJXWVd4MVpWOWxiSE5sWDJKdlpIbEFOQW9nSUNBZ2NtVjBjM1ZpQ2dwQlpHUnlaWE56TG5ObGJtUldZV3gxWlY5bGJITmxYMkp2WkhsQU5Eb0tJQ0FnSUdOaGJHeHpkV0lnVEc5M1RHVjJaV3hEWVd4c0xuSmxkSFZ5YmtSaGRHRlRhWHBsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lYTnpaWEowSUM4dklFWmhhV3hsWkVOaGJHd0tJQ0FnSUdJZ1RHOTNUR1YyWld4RFlXeHNMbUoxWW1Kc1pWSmxkbVZ5ZEFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12VTJsbmJtRjBkWEpsUjJGMFpYZGhlUzV6YjJ3dVJVTkVVMEV1ZEhKNVVtVmpiM1psY2tOaGJHeGtZWFJoS0doaGMyZzZJR0o1ZEdWekxDQnphV2R1WVhSMWNtVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN5d2dkV2x1ZERZMExDQmllWFJsY3pvS1JVTkVVMEV1ZEhKNVVtVmpiM1psY2tOaGJHeGtZWFJoT2dvZ0lDQWdjSEp2ZEc4Z01pQXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRFS0lDQWdJR0k5UFFvZ0lDQWdZbm9nUlVORVUwRXVkSEo1VW1WamIzWmxja05oYkd4a1lYUmhYMlZzYzJWZlltOWtlVUF5Q2lBZ0lDQnNiMkZrSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHVjRkSEpoWTNRZ01DQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1aZ29nSUNBZ1lpWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOaGJHeHpkV0lnUlVORVUwRXVkSEo1VW1WamIzWmxjZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lISmxkSE4xWWdvS1JVTkVVMEV1ZEhKNVVtVmpiM1psY2tOaGJHeGtZWFJoWDJWc2MyVmZZbTlrZVVBeU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OVRhV2R1WVhSMWNtVkhZWFJsZDJGNUxuTnZiQzVGUTBSVFFTNTBjbmxTWldOdmRtVnlLRFFwS0doaGMyZzZJR0o1ZEdWekxDQjJPaUIxYVc1ME5qUXNJSEk2SUdKNWRHVnpMQ0J6T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE1zSUhWcGJuUTJOQ3dnWW5sMFpYTTZDa1ZEUkZOQkxuUnllVkpsWTI5MlpYSTZDaUFnSUNCd2NtOTBieUEwSURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0o1ZEdWalh6QWdMeThnSWlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TjJabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWTFaRFUzTm1VM016VTNZVFExTURGa1pHWmxPVEptTkRZMk9ERmlNakJoTUFvZ0lDQWdZajRLSUNBZ0lHSjZJRVZEUkZOQkxuUnllVkpsWTI5MlpYSmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LUlVORVUwRXVkSEo1VW1WamIzWmxjbDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUhCMWMyaHBiblFnTWpjS0lDQWdJRDQ5Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1lub2dSVU5FVTBFdWRISjVVbVZqYjNabGNsOTBaWEp1WVhKNVgyWmhiSE5sUURRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjSFZ6YUdsdWRDQXlOd29nSUNBZ0xRb0tSVU5FVTBFdWRISjVVbVZqYjNabGNsOTBaWEp1WVhKNVgyMWxjbWRsUURVNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdKZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWldOa2MyRmZjR3RmY21WamIzWmxjaUJUWldOd01qVTJhekVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWW5vZ1JVTkVVMEV1ZEhKNVVtVmpiM1psY2w5MFpYSnVZWEo1WDJaaGJITmxRRGdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2NIVnphR2x1ZENBeU9Bb2dJQ0FnUEQwS0lDQWdJR0o2SUVWRFJGTkJMblJ5ZVZKbFkyOTJaWEpmZEdWeWJtRnllVjltWVd4elpVQTRDaUFnSUNCd2RYTm9hVzUwSURFeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3RsWTJOaGF6STFOZ29nSUNBZ1pYaDBjbUZqZENBeE1pQXlNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLQ2tWRFJGTkJMblJ5ZVZKbFkyOTJaWEpmZEdWeWJtRnllVjl0WlhKblpVQTVPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBOVBRb2dJQ0FnWW5vZ1JVTkVVMEV1ZEhKNVVtVmpiM1psY2w5aFpuUmxjbDlwWmw5bGJITmxRREV4Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2tWRFJGTkJMblJ5ZVZKbFkyOTJaWEpmWVdaMFpYSmZhV1pmWld4elpVQXhNVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tSVU5FVTBFdWRISjVVbVZqYjNabGNsOTBaWEp1WVhKNVgyWmhiSE5sUURnNkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJR0lnUlVORVUwRXVkSEo1VW1WamIzWmxjbDkwWlhKdVlYSjVYMjFsY21kbFFEa0tDa1ZEUkZOQkxuUnllVkpsWTI5MlpYSmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnUlVORVUwRXVkSEo1VW1WamIzWmxjbDkwWlhKdVlYSjVYMjFsY21kbFFEVUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxTnBaMjVoZEhWeVpVZGhkR1YzWVhrdWMyOXNMa1ZKVURjeE1raGhjMmd1YUdGemFDZ3hLVjh3S0hCaGNtRnRjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpMQ0JpZVhSbGN6b0tSVWxRTnpFeVNHRnphQzVvWVhOb09nb2dJQ0FnY0hKdmRHOGdNU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaVGcxTkRrM1pXSXlPVE5qTURBeFpUZzBPRE5tWlRFd05XVm1ZV1JrTVdRMU1HRmhNR1JoWkdaak1EVTNNR0l5TnpBMU9EQXpNV1JtWTJWaFlqSmxOZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlUybG5ibUYwZFhKbFIyRjBaWGRoZVM1emIyd3VSVWxRTnpFeVNHRnphQzVvWVhOb0tERXBYekVvY0dGeVlXMXpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWek9nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMU5wWjI1aGRIVnlaVWRoZEdWM1lYa3VjMjlzTGtWSlVEY3hNa2hoYzJndWFHRnphQ2d4S1Y4eE9nb2dJQ0FnY0hKdmRHOGdNU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR0pqTnpObFlqVTRZMlkwTURZNFlUSTVZamsxT1RObFpqRTRZekJrTWpaaU0ySTBORFV6WW1ReU1UVTFOREkwWVRrd1kySXlObUV5TW1ZME1XUTNaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlUybG5ibUYwZFhKbFIyRjBaWGRoZVM1emIyd3VSVWxRTnpFeVNHRnphQzVvWVhOb0tERXBYeklvY0dGeVlXMXpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWek9nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMU5wWjI1aGRIVnlaVWRoZEdWM1lYa3VjMjlzTGtWSlVEY3hNa2hoYzJndWFHRnphQ2d4S1Y4eU9nb2dJQ0FnY0hKdmRHOGdNU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaVEkwT0RnNU5XRXlNek0yT0RoaVlUSmhOekJpTm1ZMU5qQTBOekprWW1NeU4yVXpOV1ZqWlRCa09EWTVNVFJtTjJRME0ySm1NbVkzWkdZNE1ESTFZZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlUybG5ibUYwZFhKbFIyRjBaWGRoZVM1emIyd3VSVWxRTnpFeVNHRnphQzVvWVhOb0tERXBYek1vY0dGeVlXMXpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWek9nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMU5wWjI1aGRIVnlaVWRoZEdWM1lYa3VjMjlzTGtWSlVEY3hNa2hoYzJndWFHRnphQ2d4S1Y4ek9nb2dJQ0FnY0hKdmRHOGdNU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaREl6Wm1VNU9XRTNZV0ZqTXprNFpEQXpPVFV5WVRBNU9HWmhZVGc0T0RreU5UbGtNRFl5TnpnMFltUTRNR1ZoTUdZeE5UbGxOR0ZtTmpBMFl6QTBOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlUybG5ibUYwZFhKbFIyRjBaWGRoZVM1emIyd3VSVWxRTnpFeVNHRnphQzVvWVhOb0tERXBYelFvY0dGeVlXMXpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWek9nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMU5wWjI1aGRIVnlaVWRoZEdWM1lYa3VjMjlzTGtWSlVEY3hNa2hoYzJndWFHRnphQ2d4S1Y4ME9nb2dJQ0FnY0hKdmRHOGdNU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaRFF6TlRCbE1XWXlOV1ZqWkRZeVlUTTFZalV3WlRoalpERmxNREJpWXpNME16TXhZV1U0WXpjeU9HVmxOR1JpWWpZNVpXTm1NVEF5TTJSaFpXTm1Od29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTlRFeUNpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0EyTlNBek1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnT1RjZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURFeU9TQXpNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYTJWalkyRnJNalUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12VTJsbmJtRjBkWEpsUjJGMFpYZGhlUzV6YjJ3dVJVbFFOekV5U0dGemFDNW9ZWE5vS0RFcFh6VW9jR0Z5WVcxek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6T2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxTnBaMjVoZEhWeVpVZGhkR1YzWVhrdWMyOXNMa1ZKVURjeE1raGhjMmd1YUdGemFDZ3hLVjgxT2dvZ0lDQWdjSEp2ZEc4Z01TQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9URTFNVEEyTURrNFpUTmxaV1V4Wm1KbE9UQmhaV0pqWW1aa05qaGxPVE14WXpVek9UUTVOV0ZtTmpObE1qUXdOalpsWW1WbFltSTJNemhrTXpBeU13b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnJaV05qWVdzeU5UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OVRhV2R1WVhSMWNtVkhZWFJsZDJGNUxuTnZiQzVGU1ZBM01USklZWE5vTG1oaGMyZ29NU2xmTmlod1lYSmhiWE02SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12VTJsbmJtRjBkWEpsUjJGMFpYZGhlUzV6YjJ3dVJVbFFOekV5U0dGemFDNW9ZWE5vS0RFcFh6WTZDaUFnSUNCd2NtOTBieUF4SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwWVRFMk9HUmtPR0l6TW1ReU5qQmtNRGRrTm1Zd1ltVTRNekpsTWpNd016VmhOalZoTkRkbU56ZzROamMxWWpCaU1ESXlOekJqTmpoaU9UZzNPRGcyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjI1allYUUtJQ0FnSUd0bFkyTmhhekkxTmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFOcFoyNWhkSFZ5WlVkaGRHVjNZWGt1YzI5c0xreHZkMHhsZG1Wc1EyRnNiQzVqWVd4c1RtOVNaWFIxY200b015a29kR0Z5WjJWME9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpMQ0JrWVhSaE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncE1iM2RNWlhabGJFTmhiR3d1WTJGc2JFNXZVbVYwZFhKdU9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQnNiMkZrSURBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBeE55QXZMeUF3ZURJd0NpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lITjBiM0psSURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFOcFoyNWhkSFZ5WlVkaGRHVjNZWGt1YzI5c0xreHZkMHhsZG1Wc1EyRnNiQzV5WlhSMWNtNUVZWFJoVTJsNlpTZ3BJQzArSUdKNWRHVnpPZ3BNYjNkTVpYWmxiRU5oYkd3dWNtVjBkWEp1UkdGMFlWTnBlbVU2Q2lBZ0lDQnNiMkZrSURBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZVMmxuYm1GMGRYSmxSMkYwWlhkaGVTNXpiMnd1VEc5M1RHVjJaV3hEWVd4c0xtSjFZbUpzWlZKbGRtVnlkQ2d3S1NncElDMCtJSFp2YVdRNkNreHZkMHhsZG1Wc1EyRnNiQzVpZFdKaWJHVlNaWFpsY25RNkNpQWdJQ0JsY25JZ0x5OGdjbVYyWlhKMENnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VGFXZHVZWFIxY21WSFlYUmxkMkY1TG5OdmJDNU5ZWFJvVlhScGJITXViV2x1S0dFNklHSjVkR1Z6TENCaU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrMWhkR2hWZEdsc2N5NXRhVzQ2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUd4dllXUWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKZUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZandLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaVhnb2dJQ0FnYzNkaGNBb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlUYVdkdVlYUjFjbVZIWVhSbGQyRjVMbk52YkM1VFlXWmxSVkpETWpBdWMyRm1aVlJ5WVc1elptVnlLSFJ2YTJWdU9pQmllWFJsY3l3Z2RHODZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q2xOaFptVkZVa015TUM1ellXWmxWSEpoYm5ObVpYSTZDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCallXeHNjM1ZpSUZOaFptVkZVa015TUM1ZmMyRm1aVlJ5WVc1elptVnlDaUFnSUNCaGMzTmxjblFnTHk4Z1UyRm1aVVZTUXpJd1JtRnBiR1ZrVDNCbGNtRjBhVzl1Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFOcFoyNWhkSFZ5WlVkaGRHVjNZWGt1YzI5c0xsTmhabVZGVWtNeU1DNXpZV1psVkhKaGJuTm1aWEpHY205dEtIUnZhMlZ1T2lCaWVYUmxjeXdnWm5KdmJUb2dZbmwwWlhNc0lIUnZPaUJpZVhSbGN5d2dkbUZzZFdVNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwVFlXWmxSVkpETWpBdWMyRm1aVlJ5WVc1elptVnlSbkp2YlRvS0lDQWdJSEJ5YjNSdklEUWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psUlZKRE1qQXVYM05oWm1WVWNtRnVjMlpsY2taeWIyMEtJQ0FnSUdGemMyVnlkQ0F2THlCVFlXWmxSVkpETWpCR1lXbHNaV1JQY0dWeVlYUnBiMjRLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12VTJsbmJtRjBkWEpsUjJGMFpYZGhlUzV6YjJ3dVUyRm1aVVZTUXpJd0xtWnZjbU5sUVhCd2NtOTJaU2gwYjJ0bGJqb2dZbmwwWlhNc0lITndaVzVrWlhJNklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbE5oWm1WRlVrTXlNQzVtYjNKalpVRndjSEp2ZG1VNkNpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WRlVrTXlNQzVmYzJGbVpVRndjSEp2ZG1VS0lDQWdJR0p1ZWlCVFlXWmxSVkpETWpBdVptOXlZMlZCY0hCeWIzWmxYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WRlVrTXlNQzVmYzJGbVpVRndjSEp2ZG1VS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWVdabFJWSkRNakJHWVdsc1pXUlBjR1Z5WVhScGIyNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZGVWtNeU1DNWZjMkZtWlVGd2NISnZkbVVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRZV1psUlZKRE1qQkdZV2xzWldSUGNHVnlZWFJwYjI0S0NsTmhabVZGVWtNeU1DNW1iM0pqWlVGd2NISnZkbVZmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlUYVdkdVlYUjFjbVZIWVhSbGQyRjVMbk52YkM1VFlXWmxSVkpETWpBdVgzTmhabVZVY21GdWMyWmxjaWgwYjJ0bGJqb2dZbmwwWlhNc0lIUnZPaUJpZVhSbGN5d2dkbUZzZFdVNklHSjVkR1Z6TENCaWRXSmliR1U2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwVFlXWmxSVkpETWpBdVgzTmhabVZVY21GdWMyWmxjam9LSUNBZ0lIQnliM1J2SURRZ01Rb2dJQ0FnYkc5aFpDQXdDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhoT1RBMU9XTmlZakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2NtVndiR0ZqWlRJZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsY0d4aFkyVXlJRE0yQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTJPQW9nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFS0lDQWdJR0k5UFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBeENpQWdJQ0JpSmdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQmllaUJUWVdabFJWSkRNakF1WDNOaFptVlVjbUZ1YzJabGNsOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaWFpsY25RS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LQ2xOaFptVkZVa015TUM1ZmMyRm1aVlJ5WVc1elptVnlYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ05qUUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZVMmxuYm1GMGRYSmxSMkYwWlhkaGVTNXpiMnd1VTJGbVpVVlNRekl3TGw5ellXWmxWSEpoYm5ObVpYSkdjbTl0S0hSdmEyVnVPaUJpZVhSbGN5d2dabkp2YlRvZ1lubDBaWE1zSUhSdk9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpMQ0JpZFdKaWJHVTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BUWVdabFJWSkRNakF1WDNOaFptVlVjbUZ1YzJabGNrWnliMjA2Q2lBZ0lDQndjbTkwYnlBMUlERUtJQ0FnSUd4dllXUWdNQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpOaU9EY3laR1F3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxjR3hoWTJVeUlEUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCeVpYQnNZV05sTWlBek5nb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsY0d4aFkyVXlJRFk0Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXhNREFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBeENpQWdJQ0JpUFQwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Rb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nVTJGbVpVVlNRekl3TGw5ellXWmxWSEpoYm5ObVpYSkdjbTl0WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0ltQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCeVpYWmxjblFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtDbE5oWm1WRlVrTXlNQzVmYzJGbVpWUnlZVzV6Wm1WeVJuSnZiVjloWm5SbGNsOXBabDlsYkhObFFERTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQTJOQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxjR3hoWTJVeUlEazJDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMU5wWjI1aGRIVnlaVWRoZEdWM1lYa3VjMjlzTGxOaFptVkZVa015TUM1ZmMyRm1aVUZ3Y0hKdmRtVW9kRzlyWlc0NklHSjVkR1Z6TENCemNHVnVaR1Z5T2lCaWVYUmxjeXdnZG1Gc2RXVTZJR0o1ZEdWekxDQmlkV0ppYkdVNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncFRZV1psUlZKRE1qQXVYM05oWm1WQmNIQnliM1psT2dvZ0lDQWdjSEp2ZEc4Z05DQXhDaUFnSUNCc2IyRmtJREFLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBNU5XVmhOMkl6TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE1pQTBDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY21Wd2JHRmpaVElnTXpZS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRFk0Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Rb2dJQ0FnWWowOUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ERUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJR0o2SUZOaFptVkZVa015TUM1ZmMyRm1aVUZ3Y0hKdmRtVmZZV1owWlhKZmFXWmZaV3h6WlVBNENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzJWc1pXTjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUpnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdjbVYyWlhKMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdabkpoYldWZlluVnllU0F6Q2dwVFlXWmxSVkpETWpBdVgzTmhabVZCY0hCeWIzWmxYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ05qUUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZVMmxuYm1GMGRYSmxSMkYwWlhkaGVTNXpiMnd1VTJsbmJtRjBkWEpsUTJobFkydGxjaTVwYzFaaGJHbGtVMmxuYm1GMGRYSmxUbTkzUTJGc2JHUmhkR0VvYzJsbmJtVnlPaUJpZVhSbGN5d2dhR0Z6YURvZ1lubDBaWE1zSUhOcFoyNWhkSFZ5WlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1UybG5ibUYwZFhKbFEyaGxZMnRsY2k1cGMxWmhiR2xrVTJsbmJtRjBkWEpsVG05M1EyRnNiR1JoZEdFNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJCY0hCeWIzWmhiRkJ5YjJkeVlXMEtJQ0FnSUhCdmNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJR0o2SUZOcFoyNWhkSFZ5WlVOb1pXTnJaWEl1YVhOV1lXeHBaRk5wWjI1aGRIVnlaVTV2ZDBOaGJHeGtZWFJoWDJWc2MyVmZZbTlrZVVBMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQkZRMFJUUVM1MGNubFNaV052ZG1WeVEyRnNiR1JoZEdFS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQkZRMFJUUVM1MGNubFNaV052ZG1WeVEyRnNiR1JoZEdFS0lDQWdJSEJ2Y0FvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUdWdWRXMGdiM1YwSUc5bUlISmhibWRsQ2lBZ0lDQmlibm9nVTJsbmJtRjBkWEpsUTJobFkydGxjaTVwYzFaaGJHbGtVMmxuYm1GMGRYSmxUbTkzUTJGc2JHUmhkR0ZmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQTlQUW9nSUNBZ1lub2dVMmxuYm1GMGRYSmxRMmhsWTJ0bGNpNXBjMVpoYkdsa1UybG5ibUYwZFhKbFRtOTNRMkZzYkdSaGRHRmZZbTl2YkY5bVlXeHpaVUEwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9LVTJsbmJtRjBkWEpsUTJobFkydGxjaTVwYzFaaGJHbGtVMmxuYm1GMGRYSmxUbTkzUTJGc2JHUmhkR0ZmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ3BUYVdkdVlYUjFjbVZEYUdWamEyVnlMbWx6Vm1Gc2FXUlRhV2R1WVhSMWNtVk9iM2REWVd4c1pHRjBZVjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJUYVdkdVlYUjFjbVZEYUdWamEyVnlMbWx6Vm1Gc2FXUlRhV2R1WVhSMWNtVk9iM2REWVd4c1pHRjBZVjlpYjI5c1gyMWxjbWRsUURVS0NsTnBaMjVoZEhWeVpVTm9aV05yWlhJdWFYTldZV3hwWkZOcFoyNWhkSFZ5WlU1dmQwTmhiR3hrWVhSaFgyVnNjMlZmWW05a2VVQTJPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJUYVdkdVlYUjFjbVZEYUdWamEyVnlMbWx6Vm1Gc2FXUkZVa014TWpjeFUybG5ibUYwZFhKbFRtOTNDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMU5wWjI1aGRIVnlaVWRoZEdWM1lYa3VjMjlzTGxOcFoyNWhkSFZ5WlVOb1pXTnJaWEl1YVhOV1lXeHBaRVZTUXpFeU56RlRhV2R1WVhSMWNtVk9iM2NvYzJsbmJtVnlPaUJpZVhSbGN5d2dhR0Z6YURvZ1lubDBaWE1zSUhOcFoyNWhkSFZ5WlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1UybG5ibUYwZFhKbFEyaGxZMnRsY2k1cGMxWmhiR2xrUlZKRE1USTNNVk5wWjI1aGRIVnlaVTV2ZHpvS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUd4dllXUWdNQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKNlpYSnZDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pIVndNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmllWFJsWXlBeU5DQXZMeUF3ZURFMk1qWmlZVGRsTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNRFFLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pHbG5JRFVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREkwQ2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd05EQUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUTBDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWTBDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1lubDBaV01nTWpRZ0x5OGdNSGd4TmpJMlltRTNaVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlQVDBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSW1DaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREVLSUNBZ0lHSW1DaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUhOM1lYQUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12VTJsbmJtRjBkWEpsUjJGMFpYZGhlUzV6YjJ3dVUybG5ibUYwZFhKbFIyRjBaWGRoZVM1ZmFYTlRjRzlyWlZKbFoybHpkR1Z5WldRb2MzQnZhMlU2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q2w5cGMxTndiMnRsVW1WbmFYTjBaWEpsWkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0pmY21WbmFYTjBaWEpsWkZOd2IydGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFOcFoyNWhkSFZ5WlVkaGRHVjNZWGt1YzI5c0xsTnBaMjVoZEhWeVpVZGhkR1YzWVhrdVgyZGxkRkpsYzJWeWRtVlZibVJsY214NWFXNW5LSE53YjJ0bE9pQmllWFJsY3l3Z2NtVnpaWEoyWlVsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsOW5aWFJTWlhObGNuWmxWVzVrWlhKc2VXbHVaem9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPR1V6TldabU4yVWdMeThnYldWMGFHOWtJQ0puWlhSU1pYTmxjblpsS0hWcGJuUXlOVFlwS0hWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc2RXbHVkREUyTEhWcGJuUTRMSFZwYm5ReU5DeDFhVzUwT0N4MWFXNTBNeklwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ016SUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZVMmxuYm1GMGRYSmxSMkYwWlhkaGVTNXpiMnd1VTJsbmJtRjBkWEpsUjJGMFpYZGhlUzVmWTJobFkydFNaWE5qZFdWSGRXRnlaR2xoYmlncElDMCtJSFp2YVdRNkNsOWphR1ZqYTFKbGMyTjFaVWQxWVhKa2FXRnVPZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUJ2ZDI1bGNnb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCZlkyaGxZMnRTWlhOamRXVkhkV0Z5WkdsaGJsOWliMjlzWDNSeWRXVkFNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdkc2IySmhiQ0JEWVd4c1pYSkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR05oYkd4emRXSWdiM2R1WlhJS0lDQWdJRDA5Q2lBZ0lDQmllaUJmWTJobFkydFNaWE5qZFdWSGRXRnlaR2xoYmw5aWIyOXNYMlpoYkhObFFETUtDbDlqYUdWamExSmxjMk4xWlVkMVlYSmthV0Z1WDJKdmIyeGZkSEoxWlVBeU9nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0NsOWphR1ZqYTFKbGMyTjFaVWQxWVhKa2FXRnVYMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NVVtVnpZM1ZsUjNWaGNtUnBZVzRLSUNBZ0lISmxkSE4xWWdvS1gyTm9aV05yVW1WelkzVmxSM1ZoY21ScFlXNWZZbTl2YkY5bVlXeHpaVUF6T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdYMk5vWldOclVtVnpZM1ZsUjNWaGNtUnBZVzVmWW05dmJGOXRaWEpuWlVBMENnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VGFXZHVZWFIxY21WSFlYUmxkMkY1TG5OdmJDNVRhV2R1WVhSMWNtVkhZWFJsZDJGNUxsOTJaWEpwWm5sQmJtUkRiMjV6ZFcxbFNXNTBaVzUwS0hOcFoyNWxjam9nWW5sMFpYTXNJR2x1ZEdWdWRFaGhjMmc2SUdKNWRHVnpMQ0J1YjI1alpUb2dZbmwwWlhNc0lHUmxZV1JzYVc1bE9pQmllWFJsY3l3Z2MybG5ibUYwZFhKbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1gzWmxjbWxtZVVGdVpFTnZibk4xYldWSmJuUmxiblE2Q2lBZ0lDQndjbTkwYnlBMUlEQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWp3OUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaRk5wWjI1aGRIVnlaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lsOWpZV05vWldSRWIyMWhhVzVUWlhCaGNtRjBiM0lpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjlqWVdOb1pXUkViMjFoYVc1VFpYQmhjbUYwYjNJZ1pYaHBjM1J6Q2lBZ0lDQmpZV3hzYzNWaUlGOWpZV05vWldSRWIyMWhhVzVUWlhCaGNtRjBiM0pKYm5aaGJHbGtZWFJsWkFvZ0lDQWdZbm9nWDNabGNtbG1lVUZ1WkVOdmJuTjFiV1ZKYm5SbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0JqWVd4c2MzVmlJRjlpZFdsc1pFUnZiV0ZwYmxObGNHRnlZWFJ2Y2dvZ0lDQWdabkpoYldWZlluVnllU0F3Q2dwZmRtVnlhV1o1UVc1a1EyOXVjM1Z0WlVsdWRHVnVkRjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNCc2IyRmtJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFNU1ERXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUdScFp5QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNaUF5TmdvZ0lDQWdaR2xuSURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnlaWEJzWVdObE1pQTFPQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJMElEWTBDaUFnSUNCclpXTmpZV3N5TlRZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCeVpYQnNZV05sTWlBMU9Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnVTJsbmJtRjBkWEpsUTJobFkydGxjaTVwYzFaaGJHbGtVMmxuYm1GMGRYSmxUbTkzUTJGc2JHUmhkR0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa1UybG5ibUYwZFhKbENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWk4S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpnb2dJQ0FnWWlZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQmZkWE5sVG05dVkyVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaRUZqWTI5MWJuUk9iMjVqWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VGFXZHVZWFIxY21WSFlYUmxkMkY1TG5OdmJDNVRhV2R1WVhSMWNtVkhZWFJsZDJGNUxsOWlkV2xzWkVSdmJXRnBibE5sY0dGeVlYUnZjaWdwSUMwK0lHSjVkR1Z6T2dwZlluVnBiR1JFYjIxaGFXNVRaWEJoY21GMGIzSTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0lsOWpZV05vWldST1lXMWxTR0Z6YUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWDJOaFkyaGxaRTVoYldWSVlYTm9JR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKZlkyRmphR1ZrVm1WeWMybHZia2hoYzJnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5allXTm9aV1JXWlhKemFXOXVTR0Z6YUNCbGVHbHpkSE1LSUNBZ0lHeHZZV1FnTUFvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaSFZ3TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR1JwWnlBeUNpQWdJQ0JpZVhSbFl5QXlNaUF2THlBd2VEaGlOek5qTTJNMk9XSmlPR1psTTJRMU1USmxZMk0wWTJZM05UbGpZemM1TWpNNVpqZGlNVGM1WWpCbVptRmpZV0U1WVRjMVpEVXlNbUl6T1RRd01HWUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZbmwwWldNZ01UY2dMeThnTUhneU1Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRBS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFl3Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdKNWRHVmpJREl6SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNUW9nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREFLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY0hWemFHbHVkQ0F4TmpBS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCclpXTmpZV3N5TlRZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12VTJsbmJtRjBkWEpsUjJGMFpYZGhlUzV6YjJ3dVUybG5ibUYwZFhKbFIyRjBaWGRoZVM1ZlkyRmphR1ZrUkc5dFlXbHVVMlZ3WVhKaGRHOXlTVzUyWVd4cFpHRjBaV1FvS1NBdFBpQjFhVzUwTmpRNkNsOWpZV05vWldSRWIyMWhhVzVUWlhCaGNtRjBiM0pKYm5aaGJHbGtZWFJsWkRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpWDJOaFkyaGxaRU5vWVdsdVNXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOWpZV05vWldSRGFHRnBia2xrSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSmZZMkZqYUdWa1ZHaHBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYMk5oWTJobFpGUm9hWE1nWlhocGMzUnpDaUFnSUNCc2IyRmtJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaVBUMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0k5UFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSTlQUW9nSUNBZ2MzZGhjQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VGFXZHVZWFIxY21WSFlYUmxkMkY1TG5OdmJDNVRhV2R1WVhSMWNtVkhZWFJsZDJGNUxsOTFjMlZPYjI1alpTaHZkMjVsY2pvZ1lubDBaWE1zSUd0bGVUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGZkWE5sVG05dVkyVTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBaVgyNXZibU5sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW53S0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlUybG5ibUYwZFhKbFIyRjBaWGRoZVM1emIyd3VVMmxuYm1GMGRYSmxSMkYwWlhkaGVTNXdaVzVrYVc1blQzZHVaWElvS1NBdFBpQmllWFJsY3pvS2NHVnVaR2x1WjA5M2JtVnlPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJSEJsYm1ScGJtZFBkMjVsY2w5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHdaVzVrYVc1blQzZHVaWEpmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWDNCbGJtUnBibWRQZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gzQmxibVJwYm1kUGQyNWxjaUJsZUdsemRITUtJQ0FnSUhKbGRITjFZZ29LY0dWdVpHbHVaMDkzYm1WeVgzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJSEJsYm1ScGJtZFBkMjVsY2w5MFpYSnVZWEo1WDIxbGNtZGxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMU5wWjI1aGRIVnlaVWRoZEdWM1lYa3VjMjlzTGxOcFoyNWhkSFZ5WlVkaGRHVjNZWGt1WDNSeVlXNXpabVZ5VDNkdVpYSnphR2x3S0c1bGQwOTNibVZ5T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWDNSeVlXNXpabVZ5VDNkdVpYSnphR2x3T2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVgzQmxibVJwYm1kUGQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmY0dWdVpHbHVaMDkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWDNCbGJtUnBibWRQZDI1bGNpSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0lsOXZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWDI5M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVgyOTNibVZ5SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURZeU5qWTRabU5qSUM4dklHMWxkR2h2WkNBaVQzZHVaWEp6YUdsd1ZISmhibk5tWlhKeVpXUW9kV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VGFXZHVZWFIxY21WSFlYUmxkMkY1TG5OdmJDNVRhV2R1WVhSMWNtVkhZWFJsZDJGNUxtOTNibVZ5S0NrZ0xUNGdZbmwwWlhNNkNtOTNibVZ5T2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUc5M2JtVnlYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ205M2JtVnlYM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbDl2ZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gyOTNibVZ5SUdWNGFYTjBjd29nSUNBZ2NtVjBjM1ZpQ2dwdmQyNWxjbDkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdmQyNWxjbDkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxTnBaMjVoZEhWeVpVZGhkR1YzWVhrdWMyOXNMbE5wWjI1aGRIVnlaVWRoZEdWM1lYa3VYMk5vWldOclQzZHVaWElvS1NBdFBpQjJiMmxrT2dwZlkyaGxZMnRQZDI1bGNqb0tJQ0FnSUdOaGJHeHpkV0lnYjNkdVpYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQ0U5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QzZHVZV0pzWlZWdVlYVjBhRzl5YVhwbFpFRmpZMjkxYm5RS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMU5wWjI1aGRIVnlaVWRoZEdWM1lYa3VjMjlzTGxOcFoyNWhkSFZ5WlVkaGRHVjNZWGt1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUZJQUFCQ01BQkpoa0FJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRRWhBUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJCVWZmSFVOWDNCbGJtUnBibWRQZDI1bGNoWmZZMkZqYUdWa1JHOXRZV2x1VTJWd1lYSmhkRzl5QVFBR1gyOTNibVZ5RGw5ZlkzUnZjbDl3Wlc1a2FXNW5JQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRQUFBQUFBQUFBQUFnQUFFVjl5WldkcGMzUmxjbVZrVTNCdmEyVnpDMTlqWVdOb1pXUlVhR2x6RGw5allXTm9aV1JEYUdGcGJrbGtEMTlqWVdOb1pXUk9ZVzFsU0dGemFCSmZZMkZqYUdWa1ZtVnljMmx2YmtoaGMyZ0JJQWRmYm05dVkyVnpGUC8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vSUdhV1hsZnEvVEU4TVJUZ2t5NytFcDZ5cGgrTk42UEVNQWZFN2xwMnVGdDlJTWllL2FwVXdQSU1ldDloS0lMZkNWRDFxVkZqZmdNSHpjdE1aeThwaTR2R0lJdHp3OGFidVA0OVVTN01UUGRaekhram4zc1htdy82eXFtblhWSXJPVUFQSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJJQlltdW40QUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUkwY1hLRWNIZ1lBZ3IwazFCVFVBTkFDQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNBWEVBMUFERVlRQUFHSndra1p5UkRNUmtVUkRFWVJJSWhCSmtQTUs0RWdPK3o2d1FsNDJHUUJESFFTRjRFUUN5Q3FnU0hZMVEvQkNBVkdjNEVwN2V2bUFRVmV5anhCSU5zcDhFRWh1Njcxd1RhNUp5SkJPdVRib3dFaGttQitRVEFWTWlEQkxndm9wZ0VnYWxFTXdSM0FFMkRCS3d5OGNrRUJKR2FKZ1ExMHZnVUJIcTVqRjhFRzlzUW1BVHNhaWJmQkwwTGprWUV5R3NZTWdUVzFvV1RCRXZyK1JzRTFhMUZGZ1RoZTYrMEJOVWgxZ1FFc2J1d3FBUStMR0hsTmhvQWppRU1qZ3U1Q3U0S0l3a2xDSVFJQ3dlU0IxZ0hIZ2JrQnFvR2NBWTJCZndGcXdUY0JCQUR4d0tUQW1ZQ0tRSDRBZDBCc1FFVEFPRUFoUUI3QUVVQUpRQWJBQUVBTVJaQkFCRXhGaVFKT0FnVVJJZ1hoaW1JRjBZa1F5TkMvL0dJRjJJbkJFeFFzQ1JETVJaQkFCY3hGaVFKT0FnVVJERUFpQmNOU3dFVEZFU0lGeHdrUXlOQy8rczJHZ0ZKUlJnVkloSkVNUlpCQUNNeEZpUUpPQWdVUklnWE9DY0ZTeGRKVGdKbmlCY1dURkNBQkk1YWVZZE1VTEFrUXlOQy85K0lGc1luQkV4UXNDUkROaG9CU1VVV0ZTSVNSRFlhQWtsRkh4V0JHQkpFTVJaQkFENHhGaVFKT0FnVVJDS3ZTVXNmU1U0Q1VFa1ZJZ2tpV0VzWFRGQUJKeEpNVUw1TUZ5Tk1Ud0pOVENjS295dXFUQmFyU1JVaURrU3JKd1JNVUxBa1F5TkMvOFEyR2dGSlJSOFZnUmdTUkRFV1FRQWVNUllrQ1RnSUZFUXhBRXNlaUJZUlNSVWlEa1FpcjZzbkJFeFFzQ1JESTBMLzVERVdRUUNWTVJZa0NUZ0lGRVNBUlE4QWh3Q1pBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBVElLVUlBNUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBbkFBUVUybG5ibUYwZFhKbFIyRjBaWGRoZVFBQk1RQUFVQ2NFVEZDd0pFTWpRdjl0TVJaQkFDTXhGaVFKT0FnVVJDTW5CbVZNUlJGRWlCVWlRUUFGaUJSeVJSQW5CRXNRVUxBa1F5TkMvOTh4RmtFQUVqRVdKQWs0Q0JSRWlCV1RKd1JNVUxBa1F5TkMvL0EyR2dGSlJRd1ZJaEpFTmhvQ1NVVWhGU0lTUkRFV1FRQVVNUllrQ1RnSUZFU0lFMTVMQ2tzZ2lBdWdKRU1qUXYvdU5ob0JTVVVMRlNJU1JEWWFBa2xGREJVaUVrUTJHZ05KUlNFVkloSkVNUlpCQUJZeEZpUUpPQWdVUklnVEkwc0pTd3RMSVlnUC9DUkRJMEwvN0RZYUFVbEZEeFVpRWtReEZrRUFHakVXSkFrNENCUkVTdzJJRXJRbkJ5TlBBbFFuQkV4UXNDUkRJMEwvNkRZYUFVa2pXVWxGQ1lFQ0MwVUZTUlZGQWxjQ0FFVVpJMFVGU3dSTEJ3eEJBQ2RMQkVtQkFndExHa2xQQWxsSlN3ZEpUZ1FTUkVzQkZWSWpXWUVDQ0FoRkJTUUlSUVZDLzlGTEE0RUNDRXNCRWtReEZrRUEyVEVXSkFrNENCUkVNUlpCQU1neEZpUUpPQWdVUkNjTFJSb2pSUWhMQjBzSERFRUFQMHNaU1NOWlNZRUNDNEVDQ0VzQ2dRSkxBbEtCQXE5UVN3TVZUd1JQQTA4Q1VpY0xVRkJNSkFoSkZsY0dBRTRDSTRnS05sQkxDQ1FJUlFsRkdrTC91U2hGR0VzWlJSRkxCaFpMR0tWQkFGbzBBRFVBSmE5TEdFbE9BbEJKRlNVSlcwc1NTVTRDSTFsTEFRMUVTd0ZSQUFKSkYwOERWd0lBU3dPQkFndExBVXhaU2xsTEFRaUJBZ2hMQWlOUEExSW5DMUJMQWhWTVRnTlNVRXhQQTRnSnlsQkZFaXFnUlJoQy81MG5CRXNSVUxBa1F5TkMvem9qUXY4cE5ob0JTVVVQRlNJU1JEWWFBa2xGQ2hVaUVrUXhGa0VBTERFV0pBazRDQlJFaUJPc3NVc05nUmhiZ1FheUVDT3lHU095QWJJWWdBUyswM2pvc2hwTENMSWFzeVJESTBMLzFqWWFBVWxGRHhVaUVrUTJHZ0pKUlIwVkloSkVOaG9EU1VVWEZTSVNSRFlhQkVsRkhCVWlFa1EyR2dWSlJTQVZJaEpFTmhvR1NSVWxFa1FYUlFNMkdnZEpSUlFWSWhKRU5ob0lTVVVURlNJU1JERVdRUUJ5TVJZa0NUZ0lGRVJMRFVtSUVNSkVTd05KZ2Y4QkRrU0Ivd0VhVEVzZGlCRENzVElLSXE5SlN4OVFTUlVpQ1NKWVRFc2pVRWtWSWdraVdFOEVGazhFZ1JoYmdRYXlFQ095R1NPeUFiSVlnQVJLamRDUHNocExHYklhVHdPeUdrOENzaHBNc2hxeUdrc1NzaHBMRWJJYXN5UkRJMEwva0RZYUFVbEZEeFVpRWtRMkdnSkpSUTRWSWhKRU5ob0RTVVVOU1JVa0VrUWpVMFVHTmhvRVNVVWVGU0lTUkRZYUJVbEZJQlVpRWtRMkdnWkpJMW1CQWdoTEFSVVNSRmNDQUVVUE1SWkJBSHd4RmlRSk9BZ1VSRXNOU1lnUC9VUkxCaVFPUkRJS1N3MVFnQ01BQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRXhjQXJGTERvQUNBR0pRU3g5UVN5RlFURkJMRUVrVkZsY0dBa3hRVHdLQkdGdUJCcklRSTdJWkk3SUJzaGlBQkZmcHBNaXlHa3l5R3JJYXN5UkRJMEwvaGpZYUFVbEZEeFVpRWtRMkdnSkpSUTVKRlNRU1JDTlRSUUl4RmtFQUx6RVdKQWs0Q0JSRWlCSERTd0ZKSkE1RVN3NUpLUk5FU1FFbkRFeFFUd0lXdjBzTlVJQUVvWkExaGt4UXNDUkRJMEwvMHpFV1FRQXhNUllrQ1RnSUZFU0FKQlVmZkhWS0ZvM1lzeTBtRFFmVzhMNkRMaU1EV21Xa2YzaUdkYkN3SW5ER2k1aDRockFrUXlOQy85RXhGa0VBTVRFV0pBazRDQlJFZ0NRVkgzeDFrVkVHQ1k0KzdoKytrSzY4djlhT2t4eFRsSld2WStKQVp1dnV1Mk9OTUNPd0pFTWpRdi9STVJaQkFERXhGaVFKT0FnVVJJQWtGUjk4ZGRRMURoOGw3TllxTmJVT2pOSGdDOE5ETWE2TWNvN2syN2FlenhBajJ1ejNzQ1JESTBMLzBURVdRUUF4TVJZa0NUZ0lGRVNBSkJVZmZIWFNQK21hZXF3NWpRT1ZLZ21QcW9pSkpaMEdKNFM5Z09vUEZaNUs5Z1RBUmJBa1F5TkMvOUV4RmtFQU1URVdKQWs0Q0JSRWdDUVZIM3gxNGtpSldpTTJpTG9xY0xiMVlFY3R2Q2ZqWHM0TmhwRlBmVU8vTDMzNEFsdXdKRU1qUXYvUk1SWkJBREV4RmlRSk9BZ1VSSUFrRlI5OGRRdkhQcldNOUFhS0tibFpQdkdNRFNhenRFVTcwaFZVSktrTXNtb2k5QjEvc0NSREkwTC8wVEVXUVFBeE1SWWtDVGdJRkVTQUpCVWZmSFhvVkpmcktUd0FIb1NEL2hCZSt0MGRVS29OcmZ3RmNMSndXQU1kL09xeTVyQWtReU5DLzlFMkdnRkpSUlVWZ1lBQkVrUTJHZ0pKSTFtQkFnaExBUlVTUkZjQ0FFVVBNUlpCQUZFeEZpUUpPQWdVUkVzVFNWY0FJSWdOYjBSSlZ5QWdUSWdKNFVsWFFDQkxBVmRnSUU4Q1RnUkxFNGdOdHJGSlZ5QWdURmNBSUlFWVc0RUdzaEFqc2hranNnR3lHSUFFSHgwYkJySWFzaHF6SkVNalF2K3hOaG9CU1VVVkZZR0FBUkpFTmhvQ1NTTlpnUUlJU3dFVkVrUlhBZ0JGRHpFV1FRQlJNUllrQ1RnSUZFUkxFMGxYQUNDSURQWkVTVmNnSUV5SUNRMUpWMEFnU3dGWFlDQlBBazRFU3hPSURUMnhTVmNnSUV4WEFDQ0JHRnVCQnJJUUk3SVpJN0lCc2hpQUJCTVNjWHF5R3JJYXN5UkRJMEwvc1RZYUFVbEZGUldCb1FFU1JEWWFBa2tqV1lFQ0NFc0JGUkpFVndJQVJROHhGa0VBZVRFV0pBazRDQlJFU3hOSlZ3QWdpQXg5UkVsWFFTQk1pQWdaU1ZkaElFc0JWNEVnU3dSUEJFOERUd05MRklnTXdMRWlyMHNCVnlBZ1VFa1ZJZ2tpV0VzQmdZQUVVeWNISTA4Q1ZDTlRKd2NqVHdKVVR3SlhBQ0NCR0Z1QkJySVFJN0laSTdJQnNoaUFCTUtyNW9peUdreXlHcklhc2hxekpFTWpRditKTmhvQlNVVVZGU0VFRWtRMkdnSkpJMW1CQWdoTEFSVVNSRmNDQUVVUE1SWkJBTmN4RmlRSk9BZ1VSRXNUU1ZjQUlFbUlDOXhFU3dGWElDQkxBbGRnSUU4RGlBYjJTVmVBSUVzQlY2QWdTd1JQQkU4RFR3TkxGb2dNR0VzRFN3T0lDOEt4SXE5SlR3VlFTUlVpQ1NKWVN3V0JHRnVCQnJJUUk3SVpJN0lCU2JJWWdBUUVaeHJic2hwTEFiSWFTd1d5R3JOUEJGZEFJTFErVndRQWlBaDZNZ3BMQlVzSFR3SkxBNGdJbWs4RVR3WkxBb2dJb3JGUEEweFFTUlVpQ1NKWWdRYXlFQ095R1NPeUFVeXlHSUFFcC9MSDY3SWFUTElhc2hxeUdyTzBQbGNFSUxRK1Z5UWdnVUN2VHdKTEFhdE9BcXRRSndSTVVMQWtReU5DL3lzMkdnRkpSUlVWSVFRU1JEWWFBa2tqV1lFQ0NFc0JGUkpFVndJQVJROHhGa0VBcERFV0pBazRDQlJFU3hOSlZ3QWdTWWdLM2tSTEFWY2dJRXNDVjJBZ1R3T0lCWDFKVjRBZ1N3RlhvQ0JMQkU4RVR3TlBBMHNXaUFzYVN3TkxBNGdLeExFaXIwbFBCVkJKRlNJSklsaFBBMWRBSUU4Q1RGQkpGU0lKSWxoUEJJRVlXNEVHc2hBanNoa2pzZ0d5R0lBRU1wbkcvcklhVExJYXNocExBYklhczdRK1Z3UWd0RDVYSkNCUEFrOERTd0tJQjRXQlFLOVBBa3NCcTA0Q3ExQW5CRXhRc0NSREkwTC9YallhQVVsRkZSVWhCQkpFTmhvQ1NTTlpnUUlJU3dFVkVrUlhBZ0JGRHpFV1FRQ2tNUllrQ1RnSUZFUkxFMGxYQUNCSmlBb1RSRXNCVnlBZ1N3SlhZQ0JQQTRnRU4wbFhnQ0JMQVZlZ0lFc0VUd1JQQTA4RFN4YUlDazlMQTBzRGlBbjVzU0t2U1U4RlVFa1ZJZ2tpV0U4RFYwQWdUd0pNVUVrVklna2lXRThFZ1JoYmdRYXlFQ095R1NPeUFiSVlnQVJxODhlZnNocE1zaHF5R2tzQnNocXp0RDVYQkNDMFBsY2tJRThDVHdOTEFvZ0d1b0ZBcjA4Q1N3R3JUZ0tyVUNjRVRGQ3dKRU1qUXY5ZU5ob0JTVVVWRlNFRUVrUTJHZ0pKSTFtQkFnaExBUlVTUkZjQ0FFVVBNUlpCQUs0eEZpUUpPQWdVUkVzVFNWY0FJRW1JQ1VoRVN3RlhJQ0JMQWxkZ0lFOERpQUx4U1ZlQUlFc0JWNkFnU3dSUEJFOERUd05MRm9nSmhFc0RTd09JQ1M0eUNrOENWMEFnU3dKTEJFOERTd09JQmo1TVN3UkxBb2dHUjdFaXIwbFBCRkJKRlNJSklsaE1Ud0pRU1JVaUNTSllUd09CR0Z1QkJySVFJN0laSTdJQnNoaUFCSUFWSThHeUdreXlHcklhc2hxenRENVhCQ0MwUGxja0lJRkFyMDhDU3dHclRnS3JVQ2NFVEZDd0pFTWpRdjlVTmhvQlNSVWlFa1FuQ1dSRUp3a2paeWNNZ1FLNVNDY0lLV2NuQlNsbkp3MG9aeWNPS0djbkR5bG5KeEFwWnljR0tXY2lyMHNCS1JJVVJFeUlDbzh5Q2ljVHJDY1RyQ2NOVEdjbkRpcG5KdzhuRkdjbkVDY1ZaelFBSmE5TEFWZEFJRXBRU1JVbENWdFBBMHNCSnhaZFN3SW5FYUFycWtzRVRGQkpGU1VKV3ljVVhVc0NnQUZBb0N1cVN3Uk1VRWtWSlFsYkp4VmRTd0tBQVdDZ0s2cExCRXhRU1JVbENWc25GMTFQQW9BQmdLQXJxazhEVEZCSkZTVUpXMHNETWdwUVN3UXlDbEFWSWdraVdGMUpUd0tCb0FGWUFrOENURkJKRlNJSklsaFhBQ0JNTlFBbkJreG5KRU9LQXdHTC9vRUNDMG1MLzRFQ0M0djlTd0ZaVHdKTWkvOU5USXNDaXdBTVFRQWxpd0ZKRmxjR0FJdjlpd0pKVGdSUEFsMUpqUDFMQVZtQkFnZ0lqQUdCQWdpTUFrTC8wNHY5akFDSmlnSUFNZ3B6QUVnV2kvK2tGRVNML292L0tJZ0VNMEVBQVltSUJGY29wVVJDQkZlS0FnTWppLzhWRmttQUFVR29RUUJITkFBaXI0di9Wd0FnU3dGTVVFa1ZJZ2tpV0ZjQUlDV3Zpd0JYQUNCUEEweFFTUlVpQ1NKWVZ3QUJnQUgvckZCSkZTVUpXMDhDTlFDTC9reExBazhEaUFBYVR3UlBCSWtpcjRzQlVFa1ZJZ2tpV0NtQkFrOENUd1JQQkltS0JBTWpSd0lvaS8rQUlILy8vLy8vLy8vLy8vLy8vLy8vLy85ZFYyNXpWNlJRSGQvcEwwWm9HeUNncFVFQURDbUJBNHYvakFLTUFZd0FpWXY5Z1JzUFNZd0RRUUJUaS8yQkd3a2tHb3Y4VEl2K2kvOEhBSXdCakFDTEEwRUFNNHY5Z1J3T1FRQXJnUXl2aXdDTEFWQUNWd3dVVUl3Q2l3SXBFa0VBQ2lra0tZd0NqQUdNQUltTEFpTXBqQUtNQVl3QWlTS3ZqQUpDLzkwalF2K3VpZ0VDaS85WEFDQ0FJT2hVbCtzcFBBQWVoSVArRUY3NjNSMVFxZzJ0L0FWd3NuQllBeDM4NnJMbVRGQWlyNHYvVnlBZ1N3Rk1VRWtWSWdraVdFOENURkNMLzFkQUlFc0NURkJKRlNJSklsaFFpLzlYWUNCUWkvOVhnQ0JMQWt4UVNSVWlDU0pZVUl2L1Y2QWdUd0pNVUVrVklna2lXRkFDaS8rSmlnRUNpLzlYQUNDQUlBdkhQcldNOUFhS0tibFpQdkdNRFNhenRFVTcwaFZVSktrTXNtb2k5QjEvVEZBaXI0di9WeUFnU3dGTVVFa1ZJZ2tpV0U4Q1RGQ0wvMWRBSUVzQ1RGQkpGU0lKSWxoUWkvOVhZQ0JRaS85WGdDQkxBa3hRU1JVaUNTSllVSXYvVjZBZ1R3Sk1VRWtWSWdraVdGQUNpLytKaWdFQ2kvOVhBQ0NBSU9KSWlWb2pOb2k2S25DMjlXQkhMYnduNDE3T0RZYVJUMzFEdnk5OStBSmJURkFpcjR2L1Z5QWdTd0ZNVUVrVklna2lXRThDVEZDTC8xZEFJRXNDVEZCSkZTSUpJbGhRaS85WFlDQlFpLzlYZ0NCTEFreFFTUlVpQ1NKWVVJdi9WNkFnVHdKTVVFa1ZJZ2tpV0ZBQ2kvK0ppZ0VDaS85WEFDQ0FJTkkvNlpwNnJEbU5BNVVxQ1krcWlJa2xuUVluaEwyQTZnOFZua3IyQk1CRlRGQWlyNHYvVnlBZ1N3Rk1VRWtWSWdraVdFOENURkNMLzFkQUlFc0NURkJKRlNJSklsaFFpLzlYWUNCUWkvOVhnQ0JMQWt4UVNSVWlDU0pZVUl2L1Y2QWdUd0pNVUVrVklna2lXRkFDaS8rSmlnRUNpLzlYQUNDQUlOUTFEaDhsN05ZcU5iVU9qTkhnQzhORE1hNk1jbzdrMjdhZXp4QWoydXozVEZBaXI0di9WeUFnU3dGTVVFa1ZJZ2tpV0U4Q1RGQ0wvNEdBQkZNbkJ5TlBBbFFqVXhaUWkvOVhRU0JRaS85WFlTQkxBa3hRU1JVaUNTSllVSXYvVjRFZ1R3Sk1VRWtWSWdraVdGQUNpLytKaWdFQ2kvOVhBQ0NBSUpGUkJnbU9QdTRmdnBDdXZML1dqcE1jVTVTVnIyUGlRR2JyN3J0ampUQWpURkNMLzFjZ0lGQWlyNHYvVjBBZ1N3Rk1VRWtWSWdraVdFOENURkNMLzFkZ0lFOENURkJKRlNJSklsaFFBb3YvaVlvQkFvdi9Wd0FnZ0NCS0ZvM1lzeTBtRFFmVzhMNkRMaU1EV21Xa2YzaUdkYkN3SW5ER2k1aDRoa3hRaS85WElDQlFJcStMLzFkQUlFc0JURkJKRlNJSklsaFBBa3hRaS85WFlDQlBBa3hRU1JVaUNTSllVQUtMLzRtS0F3RTBBQ1d2aS84bkVhQXJxa3NCVEZCSkZTVUpXMHlMLzFCSkZTVUpXMHNDVGdKWVhBQTFBQ1NKTkFBMUFDaUpBSW9DQVRRQWkvNkwvNjJML292L3BDZ3FUd0pOb3l1cWkvK3RURFVBaVlvREFJdjlpLzZML3lTSUFEeEVpWW9FQUl2OGkvMkwvb3YvSklnQXJFU0ppZ01BaS8yTC9vdi9JNGdCSkVBQUdDTVdpLzJML2s4Q0pJZ0JGVVNML1l2K2kvOGtpQUVLUkltS0JBRTBBRWxYUUNCTUlxOUpUd0tBSUtrRm5Mc0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFYQUFwWEFSTWkvNVFTUlVpQ1NKWVhDUkpWd0JFWEFCSkpFeFhBQ0FxcUNncVR3Sk5LcXdvcUVFQURpZ3FpLzlOS0t3b3FSUkVKSXdEaXdHTEFGQkpGU0lKSWxpTEFreGNRRFVBaXdPTUFJbUtCUUUwQUVsWFFDQk1JcTlKVHdLQUlDTzRjdDBBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBWEFBcFhBUXBYQ1JNaS81UVNSVWlDU0pZWEVSSlZ3QmtYQUJKSkV4WEFDQXFxQ2dxVHdKTktxd29xRUVBRGlncWkvOU5LS3dvcVJSRUpJd0Rpd0dMQUZCSkZTSUpJbGlMQWt4Y1FDbGNZRFVBaXdPTUFJbUtCQUUwQUVsWFFDQk1JcTlKVHdLQUlBbGVwN01BQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBWEFBcFhBUk1pLzVRU1JVaUNTSllYQ1JKVndCRVhBQkpKRXhYQUNBcXFDZ3FUd0pOS3F3b3FFRUFEaWdxaS85TktLd29xUlJFSkl3RGl3R0xBRkJKRlNJSklsaUxBa3hjUURVQWl3T01BSW1LQXdFamkvMkJHRnR5QUVnVkZpaW9RUUFzaS82TC80ajVua1lDakFDTC9vdi9pUG1UU0VVQlNZRUVERVJBQUF1TEFJdjlFa0VBQXlSTWlTTkMvL3FML1l2K2kvK0lBQUpNaVlvREFZdi9GUlkwQUNXdlN3RlhRQ0JLVUVrVkpRbGJJcTlQQkVzQ0p4aGRTd09BQVFTZ0s2cExCVXhRU1JVbENWdExBb3YrVUVrVklna2lXRjFMQTRBQkpLQXJxa3NGVEZCSkZTVUpXNEFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFQmRUd09BQVVTZ0s2cExCRXhRU1JVbENWdFBBb3YvVUVrVklna2lXRjFQQTRBQlpLQXJxazhEVEZCSkZTVUpXMHNCVHdOUEFsaGNBRWxYQUNBbkdLZ29LazhDVFNpc0txd29xVXcxQUltS0FRR0wvd0VuREV4UXZrd1hJMHhQQWsySmlnSUJzU0t2aS85UVNSVWlDU0pZaS82QkdGdUJCcklRSTdJWkk3SUJzaGlBQkk0MS8zNnlHcklhczdRK1Z3UWdpVEVBaUFJQkVrQUFEb0VZcnpJTkZsQ0lBZk1TUVFBREpFU0pJMEwvK29vRkFESUhGb3YrcGtRakp3WmxSSWdCUVVFQUJZZ0FrWXdBTkFBaXIweUFJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCa0JBQUFBQUFBQVhBQkxBWXNBVUVrVklna2lXRndhU3dHTC9GQkpGU0lKSWxoY09rbFhHRUFDVHdKTVVFa1ZJZ2tpV0ZjQUlFd3BYRG8xQUl2N1RJdi9pUDRaUkl2OUp3cWlnQmovLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vK3NpL3RNaUFEVmkvMm9SSWtqSnc5bFJDTW5FR1ZFTkFBbHIwc0JWMEFnU2xCSkZTVUpXeUt2VHdSTEFpY1dYVXNESnhHZ0s2cExCVXhRU1JVbENWdExBazhJVUVrVklna2lXRjFMQTRBQlFLQXJxa3NGVEZCSkZTVUpXMHNDVHdkUVNSVWlDU0pZWFVzRGdBRmdvQ3VxU3dWTVVFa1ZKUWxiSnhkZFR3T0FBWUNnSzZwUEJFeFFTUlVsQ1Z0TEFqSUtVRXNETWdwUUZTSUpJbGhkU1U4RGdhQUJXQUpQQWt4UVNSVWlDU0pZVndBZ1REVUFpU01uRG1WRUl5Y05aVVEwQUNwUEE2Z29LazhDVFRJS1R3T29LQ3BQQWsyc0tLaE1OUUNKaWdJQklxK0wvMUJKRlNJSklsaUwva3hRQVNjU1RGQkp2a3dYSTB4UEFrMUpKQWdXVHdKTXY0di9Kd3FqSzZwTUZxdUpNUlpCQUE0eEZpUUpPQWdVUkNNbkJXVkVpU05DLy9TS0FRQWpKd1ZsUlFGRUp3VXBaeU1uQ0dWRUp3aUwvMmVMLzFDQUJHSm1qOHhNVUxDSk1SWkJBQTR4RmlRSk9BZ1VSQ01uQ0dWRWlTTkMvL1NJLytZeEFCTVVSSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJTcG9rZVJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0ZXJlZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJTdGFydGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
