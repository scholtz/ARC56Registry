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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.Morpho_62aabe11
{


    //
    // @title Morpho
    // @author Morpho Labs
    // @custom:contact security@morpho.org
    // @notice The Morpho contract.
    //
    public class MorphoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MorphoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Authorization : AVMObjectType
            {
                public byte[] Authorizer { get; set; }

                public byte[] Authorized { get; set; }

                public bool IsAuthorized { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthorizer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vAuthorizer.From(Authorizer);
                    ret.AddRange(vAuthorizer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthorized = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vAuthorized.From(Authorized);
                    ret.AddRange(vAuthorized.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsAuthorized = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsAuthorized.From(IsAuthorized);
                    ret.AddRange(vIsAuthorized.Encode());
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

                public static Authorization Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Authorization();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthorizer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vAuthorizer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAuthorizer = vAuthorizer.ToValue();
                    if (valueAuthorizer is byte[] vAuthorizerValue) { ret.Authorizer = vAuthorizerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthorized = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vAuthorized.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAuthorized = vAuthorized.ToValue();
                    if (valueAuthorized is byte[] vAuthorizedValue) { ret.Authorized = vAuthorizedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsAuthorized = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsAuthorized.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsAuthorized = vIsAuthorized.ToValue();
                    if (valueIsAuthorized is bool vIsAuthorizedValue) { ret.IsAuthorized = vIsAuthorizedValue; }
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
                    return Equals(obj as Authorization);
                }
                public bool Equals(Authorization? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Authorization left, Authorization right)
                {
                    return EqualityComparer<Authorization>.Default.Equals(left, right);
                }
                public static bool operator !=(Authorization left, Authorization right)
                {
                    return !(left == right);
                }

            }

            public class Market : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalSupplyAssets { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalSupplyShares { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalBorrowAssets { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalBorrowShares { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 LastUpdate { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Fee { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalSupplyAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vTotalSupplyAssets.From(TotalSupplyAssets);
                    ret.AddRange(vTotalSupplyAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalSupplyShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vTotalSupplyShares.From(TotalSupplyShares);
                    ret.AddRange(vTotalSupplyShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBorrowAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vTotalBorrowAssets.From(TotalBorrowAssets);
                    ret.AddRange(vTotalBorrowAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBorrowShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vTotalBorrowShares.From(TotalBorrowShares);
                    ret.AddRange(vTotalBorrowShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLastUpdate.From(LastUpdate);
                    ret.AddRange(vLastUpdate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vFee.From(Fee);
                    ret.AddRange(vFee.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Market Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Market();
                    uint count = 0;
                    var vTotalSupplyAssets = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vTotalSupplyAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.TotalSupplyAssets = vTotalSupplyAssets;
                    var vTotalSupplyShares = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vTotalSupplyShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.TotalSupplyShares = vTotalSupplyShares;
                    var vTotalBorrowAssets = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vTotalBorrowAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.TotalBorrowAssets = vTotalBorrowAssets;
                    var vTotalBorrowShares = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vTotalBorrowShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.TotalBorrowShares = vTotalBorrowShares;
                    var vLastUpdate = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLastUpdate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LastUpdate = vLastUpdate;
                    var vFee = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Fee = vFee;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Market);
                }
                public bool Equals(Market? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Market left, Market right)
                {
                    return EqualityComparer<Market>.Default.Equals(left, right);
                }
                public static bool operator !=(Market left, Market right)
                {
                    return !(left == right);
                }

            }

            public class MarketParams : AVMObjectType
            {
                public byte[] LoanToken { get; set; }

                public byte[] CollateralToken { get; set; }

                public byte[] Oracle { get; set; }

                public byte[] Irm { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Lltv { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLoanToken = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vLoanToken.From(LoanToken);
                    ret.AddRange(vLoanToken.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateralToken = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vCollateralToken.From(CollateralToken);
                    ret.AddRange(vCollateralToken.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOracle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOracle.From(Oracle);
                    ret.AddRange(vOracle.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIrm = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vIrm.From(Irm);
                    ret.AddRange(vIrm.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLltv = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLltv.From(Lltv);
                    ret.AddRange(vLltv.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MarketParams Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MarketParams();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLoanToken = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vLoanToken.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLoanToken = vLoanToken.ToValue();
                    if (valueLoanToken is byte[] vLoanTokenValue) { ret.LoanToken = vLoanTokenValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateralToken = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCollateralToken.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCollateralToken = vCollateralToken.ToValue();
                    if (valueCollateralToken is byte[] vCollateralTokenValue) { ret.CollateralToken = vCollateralTokenValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOracle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOracle.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOracle = vOracle.ToValue();
                    if (valueOracle is byte[] vOracleValue) { ret.Oracle = vOracleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIrm = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vIrm.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIrm = vIrm.ToValue();
                    if (valueIrm is byte[] vIrmValue) { ret.Irm = vIrmValue; }
                    var vLltv = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLltv.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Lltv = vLltv;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MarketParams);
                }
                public bool Equals(MarketParams? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MarketParams left, MarketParams right)
                {
                    return EqualityComparer<MarketParams>.Default.Equals(left, right);
                }
                public static bool operator !=(MarketParams left, MarketParams right)
                {
                    return !(left == right);
                }

            }

            public class Position : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 SupplyShares { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 BorrowShares { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Collateral { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSupplyShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vSupplyShares.From(SupplyShares);
                    ret.AddRange(vSupplyShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrowShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vBorrowShares.From(BorrowShares);
                    ret.AddRange(vBorrowShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateral = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vCollateral.From(Collateral);
                    ret.AddRange(vCollateral.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Position Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Position();
                    uint count = 0;
                    var vSupplyShares = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vSupplyShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.SupplyShares = vSupplyShares;
                    var vBorrowShares = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vBorrowShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.BorrowShares = vBorrowShares;
                    var vCollateral = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vCollateral.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Collateral = vCollateral;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Position);
                }
                public bool Equals(Position? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Position left, Position right)
                {
                    return EqualityComparer<Position>.Default.Equals(left, right);
                }
                public static bool operator !=(Position left, Position right)
                {
                    return !(left == right);
                }

            }

            public class Signature : AVMObjectType
            {
                public ulong V { get; set; }

                public byte[] R { get; set; }

                public byte[] S { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vV = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vV.From(V);
                    ret.AddRange(vV.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vR = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vR.From(R);
                    ret.AddRange(vR.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vS = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vS.From(S);
                    ret.AddRange(vS.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Signature Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Signature();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vV = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vV.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueV = vV.ToValue();
                    if (valueV is ulong vVValue) { ret.V = vVValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vR = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vR.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueR = vR.ToValue();
                    if (valueR is byte[] vRValue) { ret.R = vRValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vS = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vS.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueS = vS.ToValue();
                    if (valueS is byte[] vSValue) { ret.S = vSValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Signature);
                }
                public bool Equals(Signature? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Signature left, Signature right)
                {
                    return EqualityComparer<Signature>.Default.Equals(left, right);
                }
                public static bool operator !=(Signature left, Signature right)
                {
                    return !(left == right);
                }

            }

            public class SupplyReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SupplyReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SupplyReturn();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
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
                    return Equals(obj as SupplyReturn);
                }
                public bool Equals(SupplyReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SupplyReturn left, SupplyReturn right)
                {
                    return EqualityComparer<SupplyReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(SupplyReturn left, SupplyReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class EventEvent
            {
                public static readonly byte[] Selector = new byte[4] { 2, 211, 131, 50 };
                public const string Signature = "Event(uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] 0 { get; set; }

            public static EventEvent Decode(byte[] log)
            {
                if (!Matches(log)) throw new Exception("Log does not match event selector");
                var ret = new EventEvent();
                var eventData = log.Skip(4).ToArray();
                var queue = new Queue<byte>(eventData);
                uint count = 0;
                AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                count = v0.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var value0 = v0.ToValue();
                if (value0 is byte[] v0Value) { ret.0 = v0Value; }
                return ret;

            }

        }

        public class EventEvent2
        {
            public static readonly byte[] Selector = new byte[4] { 46, 120, 48, 176 };
            public const string Signature = "Event(uint256)";
            public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
            public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 0 { get; set; }

        public static EventEvent2 Decode(byte[] log)
        {
            if (!Matches(log)) throw new Exception("Log does not match event selector");
            var ret = new EventEvent2();
            var eventData = log.Skip(4).ToArray();
            var queue = new Queue<byte>(eventData);
            uint count = 0;
            AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
            count = v0.Decode(queue.ToArray());
            for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
            var value0 = v0.ToValue();
            if (value0 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v0Value) { ret.0 = v0Value; }
            return ret;

        }

    }

    public class EventEvent3
    {
        public static readonly byte[] Selector = new byte[4] { 51, 194, 185, 119 };
        public const string Signature = "Event(uint8[32],uint256,uint256,uint256)";
        public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
        public byte[] 0 { get; set; }
    public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 1 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 2 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 3 { get; set; }

public static EventEvent3 Decode(byte[] log)
{
    if (!Matches(log)) throw new Exception("Log does not match event selector");
    var ret = new EventEvent3();
    var eventData = log.Skip(4).ToArray();
    var queue = new Queue<byte>(eventData);
    uint count = 0;
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v0.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value0 = v0.ToValue();
    if (value0 is byte[] v0Value) { ret.0 = v0Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v1.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value1 = v1.ToValue();
    if (value1 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v1Value) { ret.1 = v1Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v2.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value2 = v2.ToValue();
    if (value2 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v2Value) { ret.2 = v2Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v3.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value3 = v3.ToValue();
    if (value3 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v3Value) { ret.3 = v3Value; }
    return ret;

}

			}

			public class EventEvent4
{
    public static readonly byte[] Selector = new byte[4] { 132, 105, 32, 46 };
    public const string Signature = "Event(uint8[32],uint256)";
    public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
    public byte[] 0 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 1 { get; set; }

public static EventEvent4 Decode(byte[] log)
{
    if (!Matches(log)) throw new Exception("Log does not match event selector");
    var ret = new EventEvent4();
    var eventData = log.Skip(4).ToArray();
    var queue = new Queue<byte>(eventData);
    uint count = 0;
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v0.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value0 = v0.ToValue();
    if (value0 is byte[] v0Value) { ret.0 = v0Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v1.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value1 = v1.ToValue();
    if (value1 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v1Value) { ret.1 = v1Value; }
    return ret;

}

			}

			public class EventEvent5
{
    public static readonly byte[] Selector = new byte[4] { 133, 167, 236, 89 };
    public const string Signature = "Event(uint8[32],(uint8[32],uint8[32],uint8[32],uint8[32],uint256))";
    public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
    public byte[] 0 { get; set; }
public Structs.MarketParams 1 { get; set; }

public static EventEvent5 Decode(byte[] log)
{
    if (!Matches(log)) throw new Exception("Log does not match event selector");
    var ret = new EventEvent5();
    var eventData = log.Skip(4).ToArray();
    var queue = new Queue<byte>(eventData);
    uint count = 0;
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v0.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value0 = v0.ToValue();
    if (value0 is byte[] v0Value) { ret.0 = v0Value; }
    ret.1 = Structs.MarketParams.Parse(queue.ToArray());
    { var consumed1 = ret.1.ToByteArray().Length; for (int i = 0; i < consumed1 && queue.Count > 0; i++) { queue.Dequeue(); } }
    return ret;

}

			}

			public class EventEvent6
{
    public static readonly byte[] Selector = new byte[4] { 240, 167, 113, 119 };
    public const string Signature = "Event(uint8[32],uint8[32],uint8[32],uint256,uint256)";
    public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
    public byte[] 0 { get; set; }
public byte[] 1 { get; set; }
public byte[] 2 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 3 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 4 { get; set; }

public static EventEvent6 Decode(byte[] log)
{
    if (!Matches(log)) throw new Exception("Log does not match event selector");
    var ret = new EventEvent6();
    var eventData = log.Skip(4).ToArray();
    var queue = new Queue<byte>(eventData);
    uint count = 0;
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v0.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value0 = v0.ToValue();
    if (value0 is byte[] v0Value) { ret.0 = v0Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v1.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value1 = v1.ToValue();
    if (value1 is byte[] v1Value) { ret.1 = v1Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v2.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value2 = v2.ToValue();
    if (value2 is byte[] v2Value) { ret.2 = v2Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v3.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value3 = v3.ToValue();
    if (value3 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v3Value) { ret.3 = v3Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v4.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value4 = v4.ToValue();
    if (value4 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v4Value) { ret.4 = v4Value; }
    return ret;

}

			}

			public class EventEvent7
{
    public static readonly byte[] Selector = new byte[4] { 14, 98, 202, 18 };
    public const string Signature = "Event(uint8[32],uint8[32],uint8[32],uint8[32],uint256,uint256)";
    public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
    public byte[] 0 { get; set; }
public byte[] 1 { get; set; }
public byte[] 2 { get; set; }
public byte[] 3 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 4 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 5 { get; set; }

public static EventEvent7 Decode(byte[] log)
{
    if (!Matches(log)) throw new Exception("Log does not match event selector");
    var ret = new EventEvent7();
    var eventData = log.Skip(4).ToArray();
    var queue = new Queue<byte>(eventData);
    uint count = 0;
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v0.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value0 = v0.ToValue();
    if (value0 is byte[] v0Value) { ret.0 = v0Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v1.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value1 = v1.ToValue();
    if (value1 is byte[] v1Value) { ret.1 = v1Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v2.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value2 = v2.ToValue();
    if (value2 is byte[] v2Value) { ret.2 = v2Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v3.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value3 = v3.ToValue();
    if (value3 is byte[] v3Value) { ret.3 = v3Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v4.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value4 = v4.ToValue();
    if (value4 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v4Value) { ret.4 = v4Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v5.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value5 = v5.ToValue();
    if (value5 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v5Value) { ret.5 = v5Value; }
    return ret;

}

			}

			public class EventEvent8
{
    public static readonly byte[] Selector = new byte[4] { 232, 60, 242, 216 };
    public const string Signature = "Event(uint8[32],uint8[32],uint8[32],uint256)";
    public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
    public byte[] 0 { get; set; }
public byte[] 1 { get; set; }
public byte[] 2 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 3 { get; set; }

public static EventEvent8 Decode(byte[] log)
{
    if (!Matches(log)) throw new Exception("Log does not match event selector");
    var ret = new EventEvent8();
    var eventData = log.Skip(4).ToArray();
    var queue = new Queue<byte>(eventData);
    uint count = 0;
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v0.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value0 = v0.ToValue();
    if (value0 is byte[] v0Value) { ret.0 = v0Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v1.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value1 = v1.ToValue();
    if (value1 is byte[] v1Value) { ret.1 = v1Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v2.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value2 = v2.ToValue();
    if (value2 is byte[] v2Value) { ret.2 = v2Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v3.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value3 = v3.ToValue();
    if (value3 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v3Value) { ret.3 = v3Value; }
    return ret;

}

			}

			public class EventEvent9
{
    public static readonly byte[] Selector = new byte[4] { 215, 159, 237, 149 };
    public const string Signature = "Event(uint8[32],uint8[32],uint8[32],uint8[32],uint256)";
    public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
    public byte[] 0 { get; set; }
public byte[] 1 { get; set; }
public byte[] 2 { get; set; }
public byte[] 3 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 4 { get; set; }

public static EventEvent9 Decode(byte[] log)
{
    if (!Matches(log)) throw new Exception("Log does not match event selector");
    var ret = new EventEvent9();
    var eventData = log.Skip(4).ToArray();
    var queue = new Queue<byte>(eventData);
    uint count = 0;
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v0.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value0 = v0.ToValue();
    if (value0 is byte[] v0Value) { ret.0 = v0Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v1.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value1 = v1.ToValue();
    if (value1 is byte[] v1Value) { ret.1 = v1Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v2.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value2 = v2.ToValue();
    if (value2 is byte[] v2Value) { ret.2 = v2Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v3.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value3 = v3.ToValue();
    if (value3 is byte[] v3Value) { ret.3 = v3Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v4.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value4 = v4.ToValue();
    if (value4 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v4Value) { ret.4 = v4Value; }
    return ret;

}

			}

			public class EventEvent10
{
    public static readonly byte[] Selector = new byte[4] { 91, 131, 84, 240 };
    public const string Signature = "Event(uint8[32],uint8[32],uint8[32],uint256,uint256,uint256,uint256,uint256)";
    public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
    public byte[] 0 { get; set; }
public byte[] 1 { get; set; }
public byte[] 2 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 3 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 4 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 5 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 6 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 7 { get; set; }

public static EventEvent10 Decode(byte[] log)
{
    if (!Matches(log)) throw new Exception("Log does not match event selector");
    var ret = new EventEvent10();
    var eventData = log.Skip(4).ToArray();
    var queue = new Queue<byte>(eventData);
    uint count = 0;
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v0.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value0 = v0.ToValue();
    if (value0 is byte[] v0Value) { ret.0 = v0Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v1.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value1 = v1.ToValue();
    if (value1 is byte[] v1Value) { ret.1 = v1Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v2.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value2 = v2.ToValue();
    if (value2 is byte[] v2Value) { ret.2 = v2Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v3.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value3 = v3.ToValue();
    if (value3 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v3Value) { ret.3 = v3Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v4.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value4 = v4.ToValue();
    if (value4 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v4Value) { ret.4 = v4Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v5.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value5 = v5.ToValue();
    if (value5 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v5Value) { ret.5 = v5Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v6.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value6 = v6.ToValue();
    if (value6 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v6Value) { ret.6 = v6Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v7.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value7 = v7.ToValue();
    if (value7 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v7Value) { ret.7 = v7Value; }
    return ret;

}

			}

			public class EventEvent11
{
    public static readonly byte[] Selector = new byte[4] { 185, 248, 34, 8 };
    public const string Signature = "Event(uint8[32],uint8[32],uint256)";
    public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
    public byte[] 0 { get; set; }
public byte[] 1 { get; set; }
public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 2 { get; set; }

public static EventEvent11 Decode(byte[] log)
{
    if (!Matches(log)) throw new Exception("Log does not match event selector");
    var ret = new EventEvent11();
    var eventData = log.Skip(4).ToArray();
    var queue = new Queue<byte>(eventData);
    uint count = 0;
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v0.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value0 = v0.ToValue();
    if (value0 is byte[] v0Value) { ret.0 = v0Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v1.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value1 = v1.ToValue();
    if (value1 is byte[] v1Value) { ret.1 = v1Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
    count = v2.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value2 = v2.ToValue();
    if (value2 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v2Value) { ret.2 = v2Value; }
    return ret;

}

			}

			public class EventEvent12
{
    public static readonly byte[] Selector = new byte[4] { 40, 25, 223, 106 };
    public const string Signature = "Event(uint8[32],uint8[32],uint8[32],bool)";
    public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
    public byte[] 0 { get; set; }
public byte[] 1 { get; set; }
public byte[] 2 { get; set; }
public bool 3 { get; set; }

public static EventEvent12 Decode(byte[] log)
{
    if (!Matches(log)) throw new Exception("Log does not match event selector");
    var ret = new EventEvent12();
    var eventData = log.Skip(4).ToArray();
    var queue = new Queue<byte>(eventData);
    uint count = 0;
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v0.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value0 = v0.ToValue();
    if (value0 is byte[] v0Value) { ret.0 = v0Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v1.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value1 = v1.ToValue();
    if (value1 is byte[] v1Value) { ret.1 = v1Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
    count = v2.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value2 = v2.ToValue();
    if (value2 is byte[] v2Value) { ret.2 = v2Value; }
    AVM.ClientGenerator.ABI.ARC4.Types.WireType v3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
    count = v3.Decode(queue.ToArray());
    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
    var value3 = v3.ToValue();
    if (value3 is bool v3Value) { ret.3 = v3Value; }
    return ret;

}

			}

		}

		///<summary>
        ///@inheritdoc IMorphoBase
        ///</summary>
		/// <param name="newOwner"> </param>
		public async Task SetOwner(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 100, 230, 24, 18 };
    var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

    var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> SetOwner_Transactions(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 100, 230, 24, 18 };
    var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

    return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="irm"> </param>
public async Task EnableIrm(Algorand.Address irm, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 71, 63, 234, 61 };
    var irmAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); irmAbi.From(irm);

    var result = await base.CallApp(new List<object> { abiHandle, irmAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> EnableIrm_Transactions(Algorand.Address irm, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 71, 63, 234, 61 };
    var irmAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); irmAbi.From(irm);

    return await base.MakeTransactionList(new List<object> { abiHandle, irmAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="lltv"> </param>
public async Task EnableLltv(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 lltv, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 170, 212, 146, 116 };

    var result = await base.CallApp(new List<object> { abiHandle, lltv }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> EnableLltv_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 lltv, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 170, 212, 146, 116 };

    return await base.MakeTransactionList(new List<object> { abiHandle, lltv }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="marketParams"> MarketParams</param>
/// <param name="newFee"> </param>
public async Task SetFee(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 newFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 144, 249, 49, 53 };

    var result = await base.CallApp(new List<object> { abiHandle, marketParams, newFee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> SetFee_Transactions(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 newFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 144, 249, 49, 53 };

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams, newFee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="newFeeRecipient"> </param>
public async Task SetFeeRecipient(Algorand.Address newFeeRecipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 120, 25, 42, 36 };
    var newFeeRecipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newFeeRecipientAbi.From(newFeeRecipient);

    var result = await base.CallApp(new List<object> { abiHandle, newFeeRecipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> SetFeeRecipient_Transactions(Algorand.Address newFeeRecipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 120, 25, 42, 36 };
    var newFeeRecipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newFeeRecipientAbi.From(newFeeRecipient);

    return await base.MakeTransactionList(new List<object> { abiHandle, newFeeRecipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="marketParams"> MarketParams</param>
public async Task CreateMarket(Structs.MarketParams marketParams, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 190, 198, 150, 91 };

    var result = await base.CallApp(new List<object> { abiHandle, marketParams }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> CreateMarket_Transactions(Structs.MarketParams marketParams, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 190, 198, 150, 91 };

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="marketParams"> MarketParams</param>
/// <param name="assets"> </param>
/// <param name="shares"> </param>
/// <param name="onBehalf"> </param>
/// <param name="data"> </param>
public async Task<Structs.SupplyReturn> Supply(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, Algorand.Address onBehalf, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 200, 123, 251, 206 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    var result = await base.CallApp(new List<object> { abiHandle, marketParams, assets, shares, onBehalfAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    return Structs.SupplyReturn.Parse(lastLogBytes.Skip(4).ToArray());

}

public async Task<List<Transaction>> Supply_Transactions(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, Algorand.Address onBehalf, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 200, 123, 251, 206 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams, assets, shares, onBehalfAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="marketParams"> MarketParams</param>
/// <param name="assets"> </param>
/// <param name="shares"> </param>
/// <param name="onBehalf"> </param>
/// <param name="receiver"> </param>
public async Task<Structs.SupplyReturn> Withdraw(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, Algorand.Address onBehalf, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 57, 96, 114, 129 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

    var result = await base.CallApp(new List<object> { abiHandle, marketParams, assets, shares, onBehalfAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    return Structs.SupplyReturn.Parse(lastLogBytes.Skip(4).ToArray());

}

public async Task<List<Transaction>> Withdraw_Transactions(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, Algorand.Address onBehalf, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 57, 96, 114, 129 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams, assets, shares, onBehalfAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="marketParams"> MarketParams</param>
/// <param name="assets"> </param>
/// <param name="shares"> </param>
/// <param name="onBehalf"> </param>
/// <param name="receiver"> </param>
public async Task<Structs.SupplyReturn> Borrow(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, Algorand.Address onBehalf, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 199, 181, 55, 96 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

    var result = await base.CallApp(new List<object> { abiHandle, marketParams, assets, shares, onBehalfAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    return Structs.SupplyReturn.Parse(lastLogBytes.Skip(4).ToArray());

}

public async Task<List<Transaction>> Borrow_Transactions(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, Algorand.Address onBehalf, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 199, 181, 55, 96 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams, assets, shares, onBehalfAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="marketParams"> MarketParams</param>
/// <param name="assets"> </param>
/// <param name="shares"> </param>
/// <param name="onBehalf"> </param>
/// <param name="data"> </param>
public async Task<Structs.SupplyReturn> Repay(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, Algorand.Address onBehalf, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 8, 80, 207, 254 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    var result = await base.CallApp(new List<object> { abiHandle, marketParams, assets, shares, onBehalfAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    return Structs.SupplyReturn.Parse(lastLogBytes.Skip(4).ToArray());

}

public async Task<List<Transaction>> Repay_Transactions(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, Algorand.Address onBehalf, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 8, 80, 207, 254 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams, assets, shares, onBehalfAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="marketParams"> MarketParams</param>
/// <param name="assets"> </param>
/// <param name="onBehalf"> </param>
/// <param name="data"> </param>
public async Task SupplyCollateral(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, Algorand.Address onBehalf, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 25, 184, 57, 136 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    var result = await base.CallApp(new List<object> { abiHandle, marketParams, assets, onBehalfAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> SupplyCollateral_Transactions(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, Algorand.Address onBehalf, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 25, 184, 57, 136 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams, assets, onBehalfAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="marketParams"> MarketParams</param>
/// <param name="assets"> </param>
/// <param name="onBehalf"> </param>
/// <param name="receiver"> </param>
public async Task WithdrawCollateral(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, Algorand.Address onBehalf, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 233, 85, 200, 236 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

    var result = await base.CallApp(new List<object> { abiHandle, marketParams, assets, onBehalfAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> WithdrawCollateral_Transactions(Structs.MarketParams marketParams, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, Algorand.Address onBehalf, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 233, 85, 200, 236 };
    var onBehalfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfAbi.From(onBehalf);
    var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams, assets, onBehalfAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="marketParams"> MarketParams</param>
/// <param name="borrower"> </param>
/// <param name="seizedAssets"> </param>
/// <param name="repaidShares"> </param>
/// <param name="data"> </param>
public async Task<Structs.SupplyReturn> Liquidate(Structs.MarketParams marketParams, Algorand.Address borrower, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 seizedAssets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 repaidShares, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 247, 83, 221, 11 };
    var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    var result = await base.CallApp(new List<object> { abiHandle, marketParams, borrowerAbi, seizedAssets, repaidShares, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    return Structs.SupplyReturn.Parse(lastLogBytes.Skip(4).ToArray());

}

public async Task<List<Transaction>> Liquidate_Transactions(Structs.MarketParams marketParams, Algorand.Address borrower, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 seizedAssets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 repaidShares, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 247, 83, 221, 11 };
    var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams, borrowerAbi, seizedAssets, repaidShares, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="token"> </param>
/// <param name="assets"> </param>
/// <param name="data"> </param>
public async Task FlashLoan(Algorand.Address token, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 197, 162, 246, 23 };
    var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    var result = await base.CallApp(new List<object> { abiHandle, tokenAbi, assets, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> FlashLoan_Transactions(Algorand.Address token, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 197, 162, 246, 23 };
    var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi, assets, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="authorized"> </param>
/// <param name="newIsAuthorized"> </param>
public async Task SetAuthorization(Algorand.Address authorized, bool newIsAuthorized, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 138, 44, 30, 190 };
    var authorizedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); authorizedAbi.From(authorized);
    var newIsAuthorizedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); newIsAuthorizedAbi.From(newIsAuthorized);

    var result = await base.CallApp(new List<object> { abiHandle, authorizedAbi, newIsAuthorizedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> SetAuthorization_Transactions(Algorand.Address authorized, bool newIsAuthorized, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 138, 44, 30, 190 };
    var authorizedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); authorizedAbi.From(authorized);
    var newIsAuthorizedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); newIsAuthorizedAbi.From(newIsAuthorized);

    return await base.MakeTransactionList(new List<object> { abiHandle, authorizedAbi, newIsAuthorizedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="authorization"> Authorization</param>
/// <param name="signature"> Signature</param>
public async Task SetAuthorizationWithSig(Structs.Authorization authorization, Structs.Signature signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 35, 200, 223, 66 };

    var result = await base.CallApp(new List<object> { abiHandle, authorization, signature }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> SetAuthorizationWithSig_Transactions(Structs.Authorization authorization, Structs.Signature signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 35, 200, 223, 66 };

    return await base.MakeTransactionList(new List<object> { abiHandle, authorization, signature }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="marketParams"> MarketParams</param>
public async Task AccrueInterest(Structs.MarketParams marketParams, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 40, 47, 18, 58 };

    var result = await base.CallApp(new List<object> { abiHandle, marketParams }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> AccrueInterest_Transactions(Structs.MarketParams marketParams, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 40, 47, 18, 58 };

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="__arc4_slots"> </param>
public async Task<byte[][]> ExtSloads(byte[][] __arc4_slots, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 54, 33, 104, 229 };
    var __arc4_slotsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("uint8[32]"); __arc4_slotsAbi.From(__arc4_slots);

    var result = await base.SimApp(new List<object> { abiHandle, __arc4_slotsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    throw new Exception("Conversion not implemented"); // <unknown return conversion>

}

public async Task<List<Transaction>> ExtSloads_Transactions(byte[][] __arc4_slots, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 54, 33, 104, 229 };
    var __arc4_slotsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("uint8[32]"); __arc4_slotsAbi.From(__arc4_slots);

    return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_slotsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
public async Task<Algorand.Address> FeeRecipient(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 98, 176, 213, 199 };

    var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
    returnValueObj.Decode(lastLogReturnData);
    return new Algorand.Address(returnValueObj.ToByteArray());

}

public async Task<List<Transaction>> FeeRecipient_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 98, 176, 213, 199 };

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
protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ycGhvIiwiZGVzYyI6IkB0aXRsZSBNb3JwaG9cbiBAYXV0aG9yIE1vcnBobyBMYWJzXG4gQGN1c3RvbTpjb250YWN0IHNlY3VyaXR5QG1vcnBoby5vcmdcbiBAbm90aWNlIFRoZSBNb3JwaG8gY29udHJhY3QuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkF1dGhvcml6YXRpb24iOlt7Im5hbWUiOiJhdXRob3JpemVyIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6ImF1dGhvcml6ZWQiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoiaXNBdXRob3JpemVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGVhZGxpbmUiLCJ0eXBlIjoidWludDI1NiJ9XSwiTWFya2V0IjpbeyJuYW1lIjoidG90YWxTdXBwbHlBc3NldHMiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRvdGFsU3VwcGx5U2hhcmVzIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJ0b3RhbEJvcnJvd0Fzc2V0cyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoidG90YWxCb3Jyb3dTaGFyZXMiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6Imxhc3RVcGRhdGUiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZlZSIsInR5cGUiOiJ1aW50MjU2In1dLCJNYXJrZXRQYXJhbXMiOlt7Im5hbWUiOiJsb2FuVG9rZW4iLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoiY29sbGF0ZXJhbFRva2VuIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6Im9yYWNsZSIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJpcm0iLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoibGx0diIsInR5cGUiOiJ1aW50MjU2In1dLCJQb3NpdGlvbiI6W3sibmFtZSI6InN1cHBseVNoYXJlcyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiYm9ycm93U2hhcmVzIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJjb2xsYXRlcmFsIiwidHlwZSI6InVpbnQyNTYifV0sIlNpZ25hdHVyZSI6W3sibmFtZSI6InYiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiciIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJzIiwidHlwZSI6InVpbnQ4WzMyXSJ9XSwiU3VwcGx5UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDI1NiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRPd25lciIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTW9ycGhvQmFzZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW5hYmxlSXJtIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElNb3JwaG9CYXNlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpcm0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW5hYmxlTGx0diIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTW9ycGhvQmFzZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGx0diIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0RmVlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElNb3JwaG9CYXNlIiwiYXJncyI6W3sidHlwZSI6Iih1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDI1NikiLCJzdHJ1Y3QiOiJNYXJrZXRQYXJhbXMiLCJuYW1lIjoibWFya2V0UGFyYW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3RmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRGZWVSZWNpcGllbnQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSU1vcnBob0Jhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0ZlZVJlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVNYXJrZXQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSU1vcnBob0Jhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50MjU2KSIsInN0cnVjdCI6Ik1hcmtldFBhcmFtcyIsIm5hbWUiOiJtYXJrZXRQYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50MjU2KSIsInN0cnVjdCI6Ik1hcmtldFBhcmFtcyIsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1cHBseSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTW9ycGhvQmFzZSIsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQyNTYpIiwic3RydWN0IjoiTWFya2V0UGFyYW1zIiwibmFtZSI6Im1hcmtldFBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9uQmVoYWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiU3VwcGx5UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8zIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTW9ycGhvQmFzZSIsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQyNTYpIiwic3RydWN0IjoiTWFya2V0UGFyYW1zIiwibmFtZSI6Im1hcmtldFBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9uQmVoYWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJTdXBwbHlSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8zIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il80IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il81IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9ycm93IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElNb3JwaG9CYXNlIiwiYXJncyI6W3sidHlwZSI6Iih1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDI1NikiLCJzdHJ1Y3QiOiJNYXJrZXRQYXJhbXMiLCJuYW1lIjoibWFya2V0UGFyYW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib25CZWhhbGYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlN1cHBseVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXBheSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTW9ycGhvQmFzZSIsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQyNTYpIiwic3RydWN0IjoiTWFya2V0UGFyYW1zIiwibmFtZSI6Im1hcmtldFBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9uQmVoYWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiU3VwcGx5UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8zIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdXBwbHlDb2xsYXRlcmFsIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElNb3JwaG9CYXNlIiwiYXJncyI6W3sidHlwZSI6Iih1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDI1NikiLCJzdHJ1Y3QiOiJNYXJrZXRQYXJhbXMiLCJuYW1lIjoibWFya2V0UGFyYW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib25CZWhhbGYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3Q29sbGF0ZXJhbCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTW9ycGhvQmFzZSIsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQyNTYpIiwic3RydWN0IjoiTWFya2V0UGFyYW1zIiwibmFtZSI6Im1hcmtldFBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9uQmVoYWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8zIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfNCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxpcXVpZGF0ZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTW9ycGhvQmFzZSIsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQyNTYpIiwic3RydWN0IjoiTWFya2V0UGFyYW1zIiwibmFtZSI6Im1hcmtldFBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VpemVkQXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVwYWlkU2hhcmVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiU3VwcGx5UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8zIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzYiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzciLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmbGFzaExvYW4iLCJkZXNjIjoiQGluaGVyaXRkb2MgSU1vcnBob0Jhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QXV0aG9yaXphdGlvbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTW9ycGhvQmFzZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXplZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0lzQXV0aG9yaXplZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8zIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QXV0aG9yaXphdGlvbldpdGhTaWciLCJkZXNjIjoiQGluaGVyaXRkb2MgSU1vcnBob0Jhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50OFszMl0sYm9vbCx1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiQXV0aG9yaXphdGlvbiIsIm5hbWUiOiJhdXRob3JpemF0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHVpbnQ4WzMyXSx1aW50OFszMl0pIiwic3RydWN0IjoiU2lnbmF0dXJlIiwibmFtZSI6InNpZ25hdHVyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8zIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWNjcnVlSW50ZXJlc3QiLCJkZXNjIjoiQGluaGVyaXRkb2MgSU1vcnBob0Jhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50MjU2KSIsInN0cnVjdCI6Ik1hcmtldFBhcmFtcyIsIm5hbWUiOiJtYXJrZXRQYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8zIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXh0U2xvYWRzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElNb3JwaG9CYXNlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3Nsb3RzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ4WzMyXVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZmVlUmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNzI2XSwiZXJyb3JNZXNzYWdlIjoiSVJNIG5vdCBlbmFibGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc1N10sImVycm9yTWVzc2FnZSI6IkxMVFYgbm90IGVuYWJsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzczLDE0MTgsMTQ3MywxNTU5LDE2ODIsNTM3MF0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTUxOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIERPTUFJTl9TRVBBUkFUT1IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY3OCw1NzU2LDYwOTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBmZWVSZWNpcGllbnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2NCwxMzk5LDE0NDMsMTUyNiwxNjcxLDU3NDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBvd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTk4LDI0NzUsMjkxMSwzMzYyLDQyOTNdLCJlcnJvck1lc3NhZ2UiOiJpbmNvbnNpc3RlbnQgaW5wdXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTU2LDQxNTFdLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnQgY29sbGF0ZXJhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MjcsMzE2Nl0sImVycm9yTWVzc2FnZSI6Imluc3VmZmljaWVudCBsaXF1aWRpdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTQ5LDMzMTMsMzc5Nyw0MjQ0LDUyMTQsNTY4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0NjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG5vbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBBdXRob3JpemF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxMCwxNzAyLDE5MTAsMjM5NSwyODMxLDMyNzQsMzc3MSw0MDEwLDQyMDUsNTY1Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBNYXJrZXRQYXJhbXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDE4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFNpZ25hdHVyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzNDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY5OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NTcsMzMyMSwzODA1LDQyNTIsNTIyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzU3LDEzOTIsMTY2NCwxOTQzLDI0MjgsMjQzOSwyODY0LDI4NzUsMzMwNywzNzkxLDQwMjcsNDAzNSw0MjE2LDUxOTksNTMzN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDM2LDE1MTksMTkyMSwxOTMyLDI0MDYsMjQxNywyODQyLDI4NTMsMzI4NSwzMjk2LDM3ODMsNDAxOSw0MjI3LDQyMzgsNTIwOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBzaWduYXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzc4XSwiZXJyb3JNZXNzYWdlIjoibWFya2V0IGFscmVhZHkgY3JlYXRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NTIsMTk5MCwyNDY3LDI5MDMsMzM1NCwzODM1LDQwNTcsNDI4NSw1Njc3XSwiZXJyb3JNZXNzYWdlIjoibWFya2V0IG5vdCBjcmVhdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4N10sImVycm9yTWVzc2FnZSI6Im1heCBMTFRWIGV4Y2VlZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3M10sImVycm9yTWVzc2FnZSI6Im1heCBmZWUgZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzE2XSwiZXJyb3JNZXNzYWdlIjoibWF4IHVpbnQxMjggZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDI3LDExMDNdLCJlcnJvck1lc3NhZ2UiOiJubyBjb2RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2OSwxNDAxLDE0NDUsMTUyOCwxNjczXSwiZXJyb3JNZXNzYWdlIjoibm90IG93bmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ5NCwxNTkwLDE2NDYsMTc5MywyMDgzLDIxNTIsMjIwMywyMjMzLDIyNDgsMjU2OSwyNjM5LDI2OTQsMjczNSwyNzQ2LDI5OTQsMzA1OSwzMTEwLDMxNzQsMzE4NSwzNDQ0LDM1MTYsMzU2OSwzNjA5LDM2MjQsMzg4MiwzOTEyLDQxMjEsNDE1OCw0NTA2LDQ1NzUsNDYyNSw0Njg5LDQ4MDEsNDg2Niw0OTE4LDQ5NzIsNDk5MCw1MDAwLDUwMTYsNTAyNiw1MjM3LDU5NDAsNjAxMSw2MTI4LDYxODcsNjIwOCw2MjIxLDYyMzEsNjI3MV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM0Nl0sImVycm9yTWVzc2FnZSI6InBvc2l0aW9uIGlzIGhlYWx0aHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDI4XSwiZXJyb3JNZXNzYWdlIjoic2lnbmF0dXJlIGV4cGlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDg1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNmZXIgcmV0dXJuZWQgZmFsc2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTY1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNmZXJGcm9tIHJldHVybmVkIGZhbHNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ4NSwyOTIxLDQwNzRdLCJlcnJvck1lc3NhZ2UiOiJ1bmF1dGhvcml6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTAsMjAwMywyNDgwLDI5MTYsMzM2NywzODQ2LDQwNjhdLCJlcnJvck1lc3NhZ2UiOiJ6ZXJvIGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODQwLDQwNjIsNTIzMF0sImVycm9yTWVzc2FnZSI6Inplcm8gYXNzZXRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2TG1Gd2NISnZkbUZzWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNeklnTUNBeElESTBJREUyTUNBeE1EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNElEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SURCNE5URTFOREptTmpjZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0lDSnRZWEpyWlhRaUlEQjRNREVnSW5CdmMybDBhVzl1SWlBaWIzZHVaWElpSURCNE1UVXhaamRqTnpVZ0ltWmxaVkpsWTJsd2FXVnVkQ0lnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aaUF3ZURCbU5ESTBNQ0FpYVhOQmRYUm9iM0pwZW1Wa0lpQWlSRTlOUVVsT1gxTkZVRUZTUVZSUFVpSWdNSGhqTURrM1kyVTNZbU01TURjeE5XSXpOR0k1WmpFd01EQXdNREF3TURBZ0ltbHpTWEp0Ulc1aFlteGxaQ0lnSW1selRHeDBka1Z1WVdKc1pXUWlJREI0TmpjeE1UWXdaREFnTUhoak1qQmxNbU0zWXlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUdSbE1HSTJZak5oTnpZME1EQXdNQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0lrUlBUVUZKVGw5VFJWQkJVa0ZVVDFJaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWIzZHVaWElpQ2lBZ0lDQmllWFJsWXlBMUlDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0ptWldWU1pXTnBjR2xsYm5RaUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldNZ05TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z2VtVnlieUJoWkdSeVpYTnpDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURRM1pUYzVOVE0wWVRJME5UazFNbVU0WWpFMk9Ea3pZVE16Tm1JNE5XRXpaRGxsWVRsbVlUaGpOVGN6WmpOa09EQXpZV1ppT1RKaE56azBOamt5TVRnS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaVJFOU5RVWxPWDFORlVFRlNRVlJQVWlJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk15QXZMeUJ0WlhSb2IyUWdJa1YyWlc1MEtDa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMk5HVTJNVGd4TWlBd2VEUTNNMlpsWVROa0lEQjRZV0ZrTkRreU56UWdNSGc1TUdZNU16RXpOU0F3ZURjNE1Ua3lZVEkwSURCNFltVmpOamsyTldJZ01IaGpPRGRpWm1KalpTQXdlRE01TmpBM01qZ3hJREI0WXpkaU5UTTNOakFnTUhnd09EVXdZMlptWlNBd2VERTVZamd6T1RnNElEQjRaVGsxTldNNFpXTWdNSGhtTnpVelpHUXdZaUF3ZUdNMVlUSm1OakUzSURCNE9HRXlZekZsWW1VZ01IZ3lNMk00WkdZME1pQXdlREk0TW1ZeE1qTmhJREI0TXpZeU1UWTRaVFVnTUhoaU1XSmlZakJoT0NBd2VEWXlZakJrTldNM0lDOHZJRzFsZEdodlpDQWljMlYwVDNkdVpYSW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKbGJtRmliR1ZKY20wb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0psYm1GaWJHVk1iSFIyS0hWcGJuUXlOVFlwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwUm1WbEtDaDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWRESTFOaWtzZFdsdWRESTFOaWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJHWldWU1pXTnBjR2xsYm5Rb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0pqY21WaGRHVk5ZWEpyWlhRb0tIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME1qVTJLU2wyYjJsa0lpd2diV1YwYUc5a0lDSnpkWEJ3Ykhrb0tIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME1qVTJLU3gxYVc1ME1qVTJMSFZwYm5ReU5UWXNZV1JrY21WemN5eGllWFJsVzEwcEtIVnBiblF5TlRZc2RXbHVkREkxTmlraUxDQnRaWFJvYjJRZ0luZHBkR2hrY21GM0tDaDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWRESTFOaWtzZFdsdWRESTFOaXgxYVc1ME1qVTJMR0ZrWkhKbGMzTXNZV1JrY21WemN5a29kV2x1ZERJMU5peDFhVzUwTWpVMktTSXNJRzFsZEdodlpDQWlZbTl5Y205M0tDaDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWRESTFOaWtzZFdsdWRESTFOaXgxYVc1ME1qVTJMR0ZrWkhKbGMzTXNZV1JrY21WemN5a29kV2x1ZERJMU5peDFhVzUwTWpVMktTSXNJRzFsZEdodlpDQWljbVZ3WVhrb0tIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME1qVTJLU3gxYVc1ME1qVTJMSFZwYm5ReU5UWXNZV1JrY21WemN5eGllWFJsVzEwcEtIVnBiblF5TlRZc2RXbHVkREkxTmlraUxDQnRaWFJvYjJRZ0luTjFjSEJzZVVOdmJHeGhkR1Z5WVd3b0tIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME1qVTJLU3gxYVc1ME1qVTJMR0ZrWkhKbGMzTXNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5kcGRHaGtjbUYzUTI5c2JHRjBaWEpoYkNnb2RXbHVkRGhiTXpKZExIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5ReU5UWXBMSFZwYm5ReU5UWXNZV1JrY21WemN5eGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW14cGNYVnBaR0YwWlNnb2RXbHVkRGhiTXpKZExIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5ReU5UWXBMR0ZrWkhKbGMzTXNkV2x1ZERJMU5peDFhVzUwTWpVMkxHSjVkR1ZiWFNrb2RXbHVkREkxTml4MWFXNTBNalUyS1NJc0lHMWxkR2h2WkNBaVpteGhjMmhNYjJGdUtHRmtaSEpsYzNNc2RXbHVkREkxTml4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwUVhWMGFHOXlhWHBoZEdsdmJpaGhaR1J5WlhOekxHSnZiMndwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwUVhWMGFHOXlhWHBoZEdsdmJsZHBkR2hUYVdjb0tIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNZbTl2YkN4MWFXNTBNalUyTEhWcGJuUXlOVFlwTENoMWFXNTBOalFzZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFNrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdOamNuVmxTVzUwWlhKbGMzUW9LSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBNalUyS1NsMmIybGtJaXdnYldWMGFHOWtJQ0psZUhSVGJHOWhaSE1vZFdsdWREaGJNekpkVzEwcGRXbHVkRGhiTXpKZFcxMGlMQ0J0WlhSb2IyUWdJbTkzYm1WeUtDbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSm1aV1ZTWldOcGNHbGxiblFvS1dGa1pISmxjM01pQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCelpYUlBkMjVsY2lCbGJtRmliR1ZKY20wZ1pXNWhZbXhsVEd4MGRpQnpaWFJHWldVZ2MyVjBSbVZsVW1WamFYQnBaVzUwSUdOeVpXRjBaVTFoY210bGRDQnpkWEJ3YkhrZ2QybDBhR1J5WVhjZ1ltOXljbTkzSUhKbGNHRjVJSE4xY0hCc2VVTnZiR3hoZEdWeVlXd2dkMmwwYUdSeVlYZERiMnhzWVhSbGNtRnNJR3hwY1hWcFpHRjBaU0JtYkdGemFFeHZZVzRnYzJWMFFYVjBhRzl5YVhwaGRHbHZiaUJ6WlhSQmRYUm9iM0pwZW1GMGFXOXVWMmwwYUZOcFp5QmhZMk55ZFdWSmJuUmxjbVZ6ZENCbGVIUlRiRzloWkhNZ2IzZHVaWElnWm1WbFVtVmphWEJwWlc1MENpQWdJQ0JsY25JS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXRnlhMlYwVUdGeVlXMXpUR2xpTG1sa0tHMWhjbXRsZEZCaGNtRnRjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BOWVhKclpYUlFZWEpoYlhOTWFXSXVhV1E2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0E1TmlBek1nb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JyWldOallXc3lOVFlLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TllYUm9UR2xpTG5kTmRXeEViM2R1S0hnNklHSjVkR1Z6TENCNU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrMWhkR2hNYVdJdWQwMTFiRVJ2ZDI0NkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHbHVkR01nTlNBdkx5QXhNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlFMWhkR2hNYVdJdWJYVnNSR2wyUkc5M2Jnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazFoZEdoTWFXSXVkMFJwZGtSdmQyNG9lRG9nWW5sMFpYTXNJSGs2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LVFdGMGFFeHBZaTUzUkdsMlJHOTNiam9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnYVc1MFl5QTFJQzh2SURFd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlFMWhkR2hNYVdJdWJYVnNSR2wyUkc5M2Jnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazFoZEdoTWFXSXVkMFJwZGxWd0tIZzZJR0o1ZEdWekxDQjVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDazFoZEdoTWFXSXVkMFJwZGxWd09nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQnBiblJqSURVZ0x5OGdNVEF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnVFdGMGFFeHBZaTV0ZFd4RWFYWlZjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxaGRHaE1hV0l1YlhWc1JHbDJSRzkzYmloNE9pQmllWFJsY3l3Z2VUb2dZbmwwWlhNc0lHUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tUV0YwYUV4cFlpNXRkV3hFYVhaRWIzZHVPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaW9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpOEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOWVhSb1RHbGlMbTExYkVScGRsVndLSGc2SUdKNWRHVnpMQ0I1T2lCaWVYUmxjeXdnWkRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwTllYUm9UR2xpTG0xMWJFUnBkbFZ3T2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWlvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01Rb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlMd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxaGRHaE1hV0l1ZDFSaGVXeHZja052YlhCdmRXNWtaV1FvZURvZ1lubDBaWE1zSUc0NklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1RXRjBhRXhwWWk1M1ZHRjViRzl5UTI5dGNHOTFibVJsWkRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJcUNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneFltTXhObVEyTnpSbFl6Z3dNREF3Q2lBZ0lDQmpZV3hzYzNWaUlFMWhkR2hNYVdJdWJYVnNSR2wyUkc5M2Jnb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1qbGhNakkwTVdGbU5qSmpNREF3TUFvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvVEdsaUxtMTFiRVJwZGtSdmQyNEtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHSXJDaUFnSUNCaUt3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMbE5oWm1WVWNtRnVjMlpsY2t4cFlpNXpZV1psVkhKaGJuTm1aWElvZEc5clpXNDZJR0o1ZEdWekxDQjBiem9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1UyRm1aVlJ5WVc1elptVnlUR2xpTG5OaFptVlVjbUZ1YzJabGNqb0tJQ0FnSUhCeWIzUnZJRE1nTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRndjSEp2ZG1Gc1VISnZaM0poYlFvZ0lDQWdjRzl3Q2lBZ0lDQnNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QnVieUJqYjJSbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4T1Roak9UZ3lNQ0F2THlCdFpYUm9iMlFnSW5SeVlXNXpabVZ5S0dGa1pISmxjM01zZFdsdWRESTFOaWxpYjI5c0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHSjZJRk5oWm1WVWNtRnVjMlpsY2t4cFlpNXpZV1psVkhKaGJuTm1aWEpmWW05dmJGOTBjblZsUURNS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmllaUJUWVdabFZISmhibk5tWlhKTWFXSXVjMkZtWlZSeVlXNXpabVZ5WDJKdmIyeGZabUZzYzJWQU5Bb0tVMkZtWlZSeVlXNXpabVZ5VEdsaUxuTmhabVZVY21GdWMyWmxjbDlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dwVFlXWmxWSEpoYm5ObVpYSk1hV0l1YzJGbVpWUnlZVzV6Wm1WeVgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJabGNpQnlaWFIxY201bFpDQm1ZV3h6WlFvZ0lDQWdjbVYwYzNWaUNncFRZV1psVkhKaGJuTm1aWEpNYVdJdWMyRm1aVlJ5WVc1elptVnlYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRk5oWm1WVWNtRnVjMlpsY2t4cFlpNXpZV1psVkhKaGJuTm1aWEpmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xsTmhabVZVY21GdWMyWmxja3hwWWk1ellXWmxWSEpoYm5ObVpYSkdjbTl0S0hSdmEyVnVPaUJpZVhSbGN5d2dabkp2YlRvZ1lubDBaWE1zSUhSdk9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BUWVdabFZISmhibk5tWlhKTWFXSXVjMkZtWlZSeVlXNXpabVZ5Um5KdmJUb0tJQ0FnSUhCeWIzUnZJRFFnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRndjSEp2ZG1Gc1VISnZaM0poYlFvZ0lDQWdjRzl3Q2lBZ0lDQnNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QnVieUJqYjJSbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcyWkdZME1XWTJaQ0F2THlCdFpYUm9iMlFnSW5SeVlXNXpabVZ5Um5KdmJTaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTmlsaWIyOXNJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdKNklGTmhabVZVY21GdWMyWmxja3hwWWk1ellXWmxWSEpoYm5ObVpYSkdjbTl0WDJKdmIyeGZkSEoxWlVBekNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZblJ2YVFvZ0lDQWdZbm9nVTJGbVpWUnlZVzV6Wm1WeVRHbGlMbk5oWm1WVWNtRnVjMlpsY2taeWIyMWZZbTl2YkY5bVlXeHpaVUEwQ2dwVFlXWmxWSEpoYm5ObVpYSk1hV0l1YzJGbVpWUnlZVzV6Wm1WeVJuSnZiVjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dwVFlXWmxWSEpoYm5ObVpYSk1hV0l1YzJGbVpWUnlZVzV6Wm1WeVJuSnZiVjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTm1aWEpHY205dElISmxkSFZ5Ym1Wa0lHWmhiSE5sQ2lBZ0lDQnlaWFJ6ZFdJS0NsTmhabVZVY21GdWMyWmxja3hwWWk1ellXWmxWSEpoYm5ObVpYSkdjbTl0WDJKdmIyeGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUZOaFptVlVjbUZ1YzJabGNreHBZaTV6WVdabFZISmhibk5tWlhKR2NtOXRYMkp2YjJ4ZmJXVnlaMlZBTlFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1VGFHRnlaWE5OWVhSb1RHbGlMblJ2VTJoaGNtVnpSRzkzYmloaGMzTmxkSE02SUdKNWRHVnpMQ0IwYjNSaGJFRnpjMlYwY3pvZ1lubDBaWE1zSUhSdmRHRnNVMmhoY21Wek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsTm9ZWEpsYzAxaGRHaE1hV0l1ZEc5VGFHRnlaWE5FYjNkdU9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqSURFeklDOHZJREI0TUdZME1qUXdDaUFnSUNCaUt3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1ERUtJQ0FnSUdJckNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnVFdGMGFFeHBZaTV0ZFd4RWFYWkViM2R1Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVUyaGhjbVZ6VFdGMGFFeHBZaTUwYjBGemMyVjBjMFJ2ZDI0b2MyaGhjbVZ6T2lCaWVYUmxjeXdnZEc5MFlXeEJjM05sZEhNNklHSjVkR1Z6TENCMGIzUmhiRk5vWVhKbGN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncFRhR0Z5WlhOTllYUm9UR2xpTG5SdlFYTnpaWFJ6Ukc5M2Jqb0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURFS0lDQWdJR0lyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqSURFeklDOHZJREI0TUdZME1qUXdDaUFnSUNCaUt3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUUxaGRHaE1hV0l1YlhWc1JHbDJSRzkzYmdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xsTm9ZWEpsYzAxaGRHaE1hV0l1ZEc5VGFHRnlaWE5WY0NoaGMzTmxkSE02SUdKNWRHVnpMQ0IwYjNSaGJFRnpjMlYwY3pvZ1lubDBaWE1zSUhSdmRHRnNVMmhoY21Wek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsTm9ZWEpsYzAxaGRHaE1hV0l1ZEc5VGFHRnlaWE5WY0RvS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QXdlREJtTkRJME1Bb2dJQ0FnWWlzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBeENpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRTFoZEdoTWFXSXViWFZzUkdsMlZYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVUYUdGeVpYTk5ZWFJvVEdsaUxuUnZRWE56WlhSelZYQW9jMmhoY21Wek9pQmllWFJsY3l3Z2RHOTBZV3hCYzNObGRITTZJR0o1ZEdWekxDQjBiM1JoYkZOb1lYSmxjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BUYUdGeVpYTk5ZWFJvVEdsaUxuUnZRWE56WlhSelZYQTZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBeENpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBeE15QXZMeUF3ZURCbU5ESTBNQW9nSUNBZ1lpc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCTllYUm9UR2xpTG0xMWJFUnBkbFZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVZYUnBiSE5NYVdJdVpYaGhZM1JzZVU5dVpWcGxjbThvZURvZ1lubDBaWE1zSUhrNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNsVjBhV3h6VEdsaUxtVjRZV04wYkhsUGJtVmFaWEp2T2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJOVBRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0plQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1VmRHbHNjMHhwWWk1dGFXNG9lRG9nWW5sMFpYTXNJSGs2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LVlhScGJITk1hV0l1YldsdU9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lsNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpUEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSmVDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VlhScGJITk1hV0l1ZEc5VmFXNTBNVEk0S0hnNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1ZYUnBiSE5NYVdJdWRHOVZhVzUwTVRJNE9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUcxaGVDQjFhVzUwTVRJNElHVjRZMlZsWkdWa0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHSW1DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VlhScGJITk1hV0l1ZW1WeWIwWnNiMjl5VTNWaUtIZzZJR0o1ZEdWekxDQjVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbFYwYVd4elRHbGlMbnBsY205R2JHOXZjbE4xWWpvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJK0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1ERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2TG5ObGRFOTNibVZ5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBUM2R1WlhJNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYjNkdVpYSWdaWGhwYzNSekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2IzZHVaWElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklHRnNjbVZoWkhrZ2MyVjBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnZkMjVsY2lJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSWtWMlpXNTBLQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzh1Wlc1aFlteGxTWEp0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pXNWhZbXhsU1hKdE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUc5M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2IzZHVaWElLSUNBZ0lHUjFjQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpYVhOSmNtMUZibUZpYkdWa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR0ZzY21WaFpIa2djMlYwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdZbmwwWldOZk15QXZMeUJ0WlhSb2IyUWdJa1YyWlc1MEtDa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOHVaVzVoWW14bFRHeDBkbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WdVlXSnNaVXhzZEhZNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW05M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJRzkzYm1WeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVGdnTHk4Z0ltbHpUR3gwZGtWdVlXSnNaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1lXeHlaV0ZrZVNCelpYUUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3daR1V3WWpaaU0yRTNOalF3TURBd0NpQWdJQ0JpUEFvZ0lDQWdZWE56WlhKMElDOHZJRzFoZUNCTVRGUldJR1Y0WTJWbFpHVmtDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTXlBdkx5QnRaWFJvYjJRZ0lrVjJaVzUwS0NraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc4dWMyVjBSbVZsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBSbVZsT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR01nTkNBdkx5QXhOakFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlFMWhjbXRsZEZCaGNtRnRjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCdmQyNWxjZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ1RXRnlhMlYwVUdGeVlXMXpUR2xpTG1sa0NpQWdJQ0JrZFhBS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJXRnlhMlYwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaGMzTmxjblFnTHk4Z2JXRnlhMlYwSUc1dmRDQmpjbVZoZEdWa0NpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklEUUtJQ0FnSUdJaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUdGc2NtVmhaSGtnYzJWMENpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ETTNPREprWVdObE9XUTVNREF3TUFvZ0lDQWdZanc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiV0Y0SUdabFpTQmxlR05sWldSbFpBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQmZZV05qY25WbFNXNTBaWEpsYzNRS0lDQWdJR1JwWnlBekNpQWdJQ0JpZVhSbFl5QXhNaUF2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJRzFsZEdodlpDQWlSWFpsYm5Rb0tTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2J5NXpaWFJHWldWU1pXTnBjR2xsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJHWldWU1pXTnBjR2xsYm5RNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCdmQyNWxjZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSm1aV1ZTWldOcGNHbGxiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR1psWlZKbFkybHdhV1Z1ZENCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklHRnNjbVZoWkhrZ2MyVjBDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlabVZsVW1WamFYQnBaVzUwSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpUlhabGJuUW9LU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9ieTVqY21WaGRHVk5ZWEpyWlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWTllYSnJaWFE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZeUEwSUM4dklERTJNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1RXRnlhMlYwVUdGeVlXMXpDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnVFdGeWEyVjBVR0Z5WVcxelRHbGlMbWxrQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKcGMwbHliVVZ1WVdKc1pXUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1lYTnpaWEowSUM4dklFbFNUU0J1YjNRZ1pXNWhZbXhsWkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJREU0SUM4dklDSnBjMHhzZEhaRmJtRmliR1ZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0Z6YzJWeWRDQXZMeUJNVEZSV0lHNXZkQ0JsYm1GaWJHVmtDaUFnSUNCa2FXY2dNZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p0WVhKclpYUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREV5T0NBek1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUWdMeThnYldGeWEyVjBJR0ZzY21WaFpIa2dZM0psWVhSbFpBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0E1TmlBek1nb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pwWkZSdlRXRnlhMlYwVUdGeVlXMXpJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdiV1YwYUc5a0lDSkZkbVZ1ZENncElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh6SUM4dklESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBeE9TQXZMeUJ0WlhSb2IyUWdJbUp2Y25KdmQxSmhkR1VvS0hWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc2RXbHVkRGhiTXpKZExIVnBiblE0V3pNeVhTeDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlwS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzh1YzNWd2NHeDVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNWd2NHeDVPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR01nTkNBdkx5QXhOakFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlFMWhjbXRsZEZCaGNtRnRjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZMkZzYkhOMVlpQk5ZWEpyWlhSUVlYSmhiWE5NYVdJdWFXUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ1pIVndDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbTFoY210bGRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEyQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdFlYSnJaWFFnYm05MElHTnlaV0YwWldRS0lDQWdJR1JwWnlBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1ZYUnBiSE5NYVdJdVpYaGhZM1JzZVU5dVpWcGxjbThLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibU52Ym5OcGMzUmxiblFnYVc1d2RYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJSHBsY204Z1lXUmtjbVZ6Y3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUY5aFkyTnlkV1ZKYm5SbGNtVnpkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNklITjFjSEJzZVY5bGJITmxYMkp2WkhsQU13b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCa2FXY2dOd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQlRhR0Z5WlhOTllYUm9UR2xpTG5SdlUyaGhjbVZ6Ukc5M2Jnb2dJQ0FnWW5WeWVTQTFDZ3B6ZFhCd2JIbGZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5CdmMybDBhVzl1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JpS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFM0NpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCa2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F4TmpBZ016SUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QTNDaUFnSUNCallXeHNjM1ZpSUZWMGFXeHpUR2xpTG5SdlZXbHVkREV5T0FvZ0lDQWdZaXNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMkNpQWdJQ0JqWVd4c2MzVmlJRlYwYVd4elRHbGlMblJ2VldsdWRERXlPQW9nSUNBZ1lpc0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTNDaUFnSUNCaWZBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESUtJQ0FnSUdKOENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKMWNua2dNVGNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0o4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRVS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpUlhabGJuUW9LU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnT1FvZ0lDQWdZbm9nYzNWd2NHeDVYMkZtZEdWeVgybG1YMlZzYzJWQU53b2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURnS0lDQWdJR1JwWnlBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdaR2xuSURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4eklDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNU5UUXhaV1JoTkNBdkx5QnRaWFJvYjJRZ0ltOXVUVzl5Y0dodlUzVndjR3g1S0hWcGJuUXlOVFlzZFdsdWREaGJYU2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtDbk4xY0hCc2VWOWhablJsY2w5cFpsOWxiSE5sUURjNkNpQWdJQ0JrYVdjZ05nb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdaR2xuSURnS0lDQWdJR05oYkd4emRXSWdVMkZtWlZSeVlXNXpabVZ5VEdsaUxuTmhabVZVY21GdWMyWmxja1p5YjIwS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWkdsbklERXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwemRYQndiSGxmWld4elpWOWliMlI1UURNNkNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QTJDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlGTm9ZWEpsYzAxaGRHaE1hV0l1ZEc5QmMzTmxkSE5WY0FvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0JpSUhOMWNIQnNlVjloWm5SbGNsOXBabDlsYkhObFFEUUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodkxuZHBkR2hrY21GM1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkMmwwYUdSeVlYYzZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZeUEwSUM4dklERTJNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1RXRnlhMlYwVUdGeVlXMXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnWkdsbklEUUtJQ0FnSUdOaGJHeHpkV0lnVFdGeWEyVjBVR0Z5WVcxelRHbGlMbWxrQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURZS0lDQWdJR1IxY0FvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKdFlYSnJaWFFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ053b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0F6TWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiV0Z5YTJWMElHNXZkQ0JqY21WaGRHVmtDaUFnSUNCa2FXY2dOQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqWVd4c2MzVmlJRlYwYVd4elRHbGlMbVY0WVdOMGJIbFBibVZhWlhKdkNpQWdJQ0JoYzNObGNuUWdMeThnYVc1amIyNXphWE4wWlc1MElHbHVjSFYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCNlpYSnZJR0ZrWkhKbGMzTUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWDJselUyVnVaR1Z5UVhWMGFHOXlhWHBsWkFvZ0lDQWdZWE56WlhKMElDOHZJSFZ1WVhWMGFHOXlhWHBsWkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUY5aFkyTnlkV1ZKYm5SbGNtVnpkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNklIZHBkR2hrY21GM1gyVnNjMlZmWW05a2VVQXpDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRk5vWVhKbGMwMWhkR2hNYVdJdWRHOVRhR0Z5WlhOVmNBb2dJQ0FnWW5WeWVTQTFDZ3AzYVhSb1pISmhkMTloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dOUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWNHOXphWFJwYjI0aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTFDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWZBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURFMk1DQXpNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01USTRJRE15Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR1JwWnlBMENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmpZV3hzYzNWaUlGVjBhV3h6VEdsaUxuUnZWV2x1ZERFeU9Bb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ05nb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeE5qQWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0F6TWdvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWkdsbklERTJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRGdLSUNBZ0lHTmhiR3h6ZFdJZ1ZYUnBiSE5NYVdJdWRHOVZhVzUwTVRJNENpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZkFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZanc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzV6ZFdabWFXTnBaVzUwSUd4cGNYVnBaR2wwZVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZkFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSWtWMlpXNTBLQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdaR2xuSURFd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WVWNtRnVjMlpsY2t4cFlpNXpZV1psVkhKaGJuTm1aWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuZHBkR2hrY21GM1gyVnNjMlZmWW05a2VVQXpPZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmthV2NnTmdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJUYUdGeVpYTk5ZWFJvVEdsaUxuUnZRWE56WlhSelJHOTNiZ29nSUNBZ1luVnllU0EyQ2lBZ0lDQmlJSGRwZEdoa2NtRjNYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc4dVltOXljbTkzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltOXljbTkzT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdNZ05DQXZMeUF4TmpBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRTFoY210bGRGQmhjbUZ0Y3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUExQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpZV3hzYzNWaUlFMWhjbXRsZEZCaGNtRnRjMHhwWWk1cFpBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTJDaUFnSUNCa2RYQUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTmlBdkx5QWliV0Z5YTJWMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRGNLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ016SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUcxaGNtdGxkQ0J1YjNRZ1kzSmxZWFJsWkFvZ0lDQWdaR2xuSURRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyRnNiSE4xWWlCVmRHbHNjMHhwWWk1bGVHRmpkR3g1VDI1bFdtVnlid29nSUNBZ1lYTnpaWEowSUM4dklHbHVZMjl1YzJsemRHVnVkQ0JwYm5CMWRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTWdOU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdlbVZ5YnlCaFpHUnlaWE56Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOXBjMU5sYm1SbGNrRjFkR2h2Y21sNlpXUUtJQ0FnSUdGemMyVnlkQ0F2THlCMWJtRjFkR2h2Y21sNlpXUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQmZZV05qY25WbFNXNTBaWEpsYzNRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0krQ2lBZ0lDQmllaUJpYjNKeWIzZGZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR1JwWnlBM0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUZOb1lYSmxjMDFoZEdoTWFXSXVkRzlUYUdGeVpYTlZjQW9nSUNBZ1luVnllU0ExQ2dwaWIzSnliM2RmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luQnZjMmwwYVc5dUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCa2FXY2dPUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmpZV3hzYzNWaUlGVjBhV3h6VEdsaUxuUnZWV2x1ZERFeU9Bb2dJQ0FnWWlzS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JpZkFvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmpZV3hzYzNWaUlGVjBhV3h6VEdsaUxuUnZWV2x1ZERFeU9Bb2dJQ0FnWWlzS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBMUNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNVFl3SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTmdvZ0lDQWdZMkZzYkhOMVlpQlZkR2xzYzB4cFlpNTBiMVZwYm5ReE1qZ0tJQ0FnSUdJckNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWW53S0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdScFp5QXhNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdaR2xuSURnS0lDQWdJR05oYkd4emRXSWdYMmx6U0dWaGJIUm9lU2d6S1FvZ0lDQWdZWE56WlhKMElDOHZJR2x1YzNWbVptbGphV1Z1ZENCamIyeHNZWFJsY21Gc0NpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZanc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzV6ZFdabWFXTnBaVzUwSUd4cGNYVnBaR2wwZVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTlFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZkFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBM0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSWtWMlpXNTBLQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCallXeHNjM1ZpSUZOaFptVlVjbUZ1YzJabGNreHBZaTV6WVdabFZISmhibk5tWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbUp2Y25KdmQxOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR1JwWnlBMkNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUZOb1lYSmxjMDFoZEdoTWFXSXVkRzlCYzNObGRITkViM2R1Q2lBZ0lDQmlkWEo1SURZS0lDQWdJR0lnWW05eWNtOTNYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc4dWNtVndZWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYQmhlVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2RYQnVJRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVFl3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQk5ZWEpyWlhSUVlYSmhiWE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdaR2xuSURNS0lDQWdJR05oYkd4emRXSWdUV0Z5YTJWMFVHRnlZVzF6VEdsaUxtbGtDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHUjFjQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p0WVhKclpYUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTmdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaGMzTmxjblFnTHk4Z2JXRnlhMlYwSUc1dmRDQmpjbVZoZEdWa0NpQWdJQ0JrYVdjZ013b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlGVjBhV3h6VEdsaUxtVjRZV04wYkhsUGJtVmFaWEp2Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVqYjI1emFYTjBaVzUwSUdsdWNIVjBDaUFnSUNCemQyRndDaUFnSUNCaWVYUmxZeUExSUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUI2WlhKdklHRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCZllXTmpjblZsU1c1MFpYSmxjM1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWVpQnlaWEJoZVY5bGJITmxYMkp2WkhsQU13b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBNU5pQXpNZ29nSUNBZ1pHbG5JRGNLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdVMmhoY21WelRXRjBhRXhwWWk1MGIxTm9ZWEpsYzBSdmQyNEtJQ0FnSUdKMWNua2dOUW9LY21Wd1lYbGZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5CdmMybDBhVzl1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWkdsbklEa0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1kyRnNiSE4xWWlCVmRHbHNjMHhwWWk1MGIxVnBiblF4TWpnS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCa2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F4TmpBZ016SUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdaR2xuSURZS0lDQWdJR05oYkd4emRXSWdWWFJwYkhOTWFXSXVkRzlWYVc1ME1USTRDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTFDaUFnSUNCaWZBb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRE15Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Rb2dJQ0FnWTJGc2JITjFZaUJWZEdsc2MweHBZaTU2WlhKdlJteHZiM0pUZFdJS0lDQWdJR05oYkd4emRXSWdWWFJwYkhOTWFXSXVkRzlWYVc1ME1USTRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dOUW9nSUNBZ1lud0tJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1luVnllU0F4TndvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWW53S0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKRmRtVnVkQ2dwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JpZWlCeVpYQmhlVjloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1JwWnlBNENpQWdJQ0JrYVdjZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpXRmxNVGd4TnpnZ0x5OGdiV1YwYUc5a0lDSnZiazF2Y25Cb2IxSmxjR0Y1S0hWcGJuUXlOVFlzZFdsdWREaGJYU2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtDbkpsY0dGNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTnpvS0lDQWdJR1JwWnlBMkNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmthV2NnT0FvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVkhKaGJuTm1aWEpNYVdJdWMyRm1aVlJ5WVc1elptVnlSbkp2YlFvZ0lDQWdaR2xuSURFd0NpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KbGNHRjVYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0E1TmlBek1nb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1UyaGhjbVZ6VFdGMGFFeHBZaTUwYjBGemMyVjBjMVZ3Q2lBZ0lDQmlkWEo1SURZS0lDQWdJR0lnY21Wd1lYbGZZV1owWlhKZmFXWmZaV3h6WlVBMENnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYnk1emRYQndiSGxEYjJ4c1lYUmxjbUZzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MzVndjR3g1UTI5c2JHRjBaWEpoYkRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5SaklEUWdMeThnTVRZd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJOWVhKclpYUlFZWEpoYlhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR052ZG1WeUlEVUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMkZzYkhOMVlpQk5ZWEpyWlhSUVlYSmhiWE5NYVdJdWFXUUtJQ0FnSUdSMWNBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUEySUM4dklDSnRZWEpyWlhRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXhNamdnTXpJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZWE56WlhKMElDOHZJRzFoY210bGRDQnViM1FnWTNKbFlYUmxaQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lYTnpaWEowSUM4dklIcGxjbThnWVhOelpYUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV01nTlNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnZW1WeWJ5QmhaR1J5WlhOekNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nT0NBdkx5QWljRzl6YVhScGIyNGlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRE15Q2lBZ0lDQmthV2NnTndvZ0lDQWdZMkZzYkhOMVlpQlZkR2xzYzB4cFlpNTBiMVZwYm5ReE1qZ0tJQ0FnSUdJckNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlERXdDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW53S0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTXlBdkx5QnRaWFJvYjJRZ0lrVjJaVzUwS0NraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR0o2SUhOMWNIQnNlVU52Ykd4aGRHVnlZV3hmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkdsbklEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHRTFZbUZrTUdNMElDOHZJRzFsZEdodlpDQWliMjVOYjNKd2FHOVRkWEJ3YkhsRGIyeHNZWFJsY21Gc0tIVnBiblF5TlRZc2RXbHVkRGhiWFNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLQ25OMWNIQnNlVU52Ykd4aGRHVnlZV3hmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCa2FXY2dOZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxWSEpoYm5ObVpYSk1hV0l1YzJGbVpWUnlZVzV6Wm1WeVJuSnZiUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOHVkMmwwYUdSeVlYZERiMnhzWVhSbGNtRnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZDJsMGFHUnlZWGREYjJ4c1lYUmxjbUZzT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR01nTkNBdkx5QXhOakFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlFMWhjbXRsZEZCaGNtRnRjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQmthV2NnTkFvZ0lDQWdZMkZzYkhOMVlpQk5ZWEpyWlhSUVlYSmhiWE5NYVdJdWFXUUtJQ0FnSUdSMWNBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUEySUM4dklDSnRZWEpyWlhRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXhNamdnTXpJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZWE56WlhKMElDOHZJRzFoY210bGRDQnViM1FnWTNKbFlYUmxaQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lYTnpaWEowSUM4dklIcGxjbThnWVhOelpYUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV01nTlNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnZW1WeWJ5QmhaR1J5WlhOekNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTJGc2JITjFZaUJmYVhOVFpXNWtaWEpCZFhSb2IzSnBlbVZrQ2lBZ0lDQmhjM05sY25RZ0x5OGdkVzVoZFhSb2IzSnBlbVZrQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdYMkZqWTNKMVpVbHVkR1Z5WlhOMENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nT0NBdkx5QWljRzl6YVhScGIyNGlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRE15Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdaR2xuSURnS0lDQWdJR05oYkd4emRXSWdWWFJwYkhOTWFXSXVkRzlWYVc1ME1USTRDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWZBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTlFvZ0lDQWdZMkZzYkhOMVlpQmZhWE5JWldGc2RHaDVLRE1wQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzV6ZFdabWFXTnBaVzUwSUdOdmJHeGhkR1Z5WVd3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dOUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpZkFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJRzFsZEdodlpDQWlSWFpsYm5Rb0tTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxWSEpoYm5ObVpYSk1hV0l1YzJGbVpWUnlZVzV6Wm1WeUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYnk1c2FYRjFhV1JoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHNhWEYxYVdSaGRHVTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkhWd2JpQTJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZeUEwSUM4dklERTJNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1RXRnlhMlYwVUdGeVlXMXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpZV3hzYzNWaUlFMWhjbXRsZEZCaGNtRnRjMHhwWWk1cFpBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTFDaUFnSUNCa2RYQUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTmlBdkx5QWliV0Z5YTJWMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFlLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ016SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUcxaGNtdGxkQ0J1YjNRZ1kzSmxZWFJsWkFvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCVmRHbHNjMHhwWWk1bGVHRmpkR3g1VDI1bFdtVnlid29nSUNBZ1lYTnpaWEowSUM4dklHbHVZMjl1YzJsemRHVnVkQ0JwYm5CMWRBb2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUY5aFkyTnlkV1ZKYm5SbGNtVnpkQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUdsdWRHTmZNeUF2THlBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdiV1YwYUc5a0lDSndjbWxqWlNncGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMkZzYkhOMVlpQmZhWE5JWldGc2RHaDVLRFFwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2NHOXphWFJwYjI0Z2FYTWdhR1ZoYkhSb2VRb2dJQ0FnY0hWemFHbHVkQ0F4TVRVd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnBiblJqSURVZ0x5OGdNVEF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR2x1ZENBek1EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHSjVkR1ZqSURJeElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdaR1V3WWpaaU0yRTNOalF3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR05oYkd4emRXSWdUV0YwYUV4cFlpNTNUWFZzUkc5M2Jnb2dJQ0FnWW5sMFpXTWdNakVnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURCa1pUQmlObUl6WVRjMk5EQXdNREFLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1kyRnNiSE4xWWlCTllYUm9UR2xpTG5kRWFYWkViM2R1Q2lBZ0lDQmpZV3hzYzNWaUlGVjBhV3h6VEdsaUxtMXBiZ29nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNklHeHBjWFZwWkdGMFpWOWxiSE5sWDJKdlpIbEFOQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmllWFJsWXlBeE5pQXZMeUF3ZUdNd09UZGpaVGRpWXprd056RTFZak0wWWpsbU1UQXdNREF3TURBd01Bb2dJQ0FnWTJGc2JITjFZaUJOWVhSb1RHbGlMbTExYkVScGRsVndDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUUxaGRHaE1hV0l1ZDBScGRsVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR05oYkd4emRXSWdVMmhoY21WelRXRjBhRXhwWWk1MGIxTm9ZWEpsYzFWd0NpQWdJQ0JpZFhKNUlEVUtDbXhwY1hWcFpHRjBaVjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCVGFHRnlaWE5OWVhSb1RHbGlMblJ2UVhOelpYUnpWWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZblZ5ZVNBeE13b2dJQ0FnWkdsbklEVUtJQ0FnSUdScFp5QXhNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5CdmMybDBhVzl1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UVUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXJDaUFnSUNCa2FXY2dNd29nSUNBZ1kyRnNiSE4xWWlCVmRHbHNjMHhwWWk1MGIxVnBiblF4TWpnS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJeENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR1JwWnlBekNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeE5qQWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0F6TWdvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpZV3hzYzNWaUlGVjBhV3h6VEdsaUxuUnZWV2x1ZERFeU9Bb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBMENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqWVd4c2MzVmlJRlYwYVd4elRHbGlMbnBsY205R2JHOXZjbE4xWWdvZ0lDQWdZMkZzYkhOMVlpQlZkR2xzYzB4cFlpNTBiMVZwYm5ReE1qZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTBDaUFnSUNCaWZBb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRE15Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdaR2xuSURFd0NpQWdJQ0JqWVd4c2MzVmlJRlYwYVd4elRHbGlMblJ2VldsdWRERXlPQW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0o4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSjFjbmtnTVRNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0oxY25rZ01UUUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJOVBRb2dJQ0FnWW5vZ2JHbHhkV2xrWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTndvZ0lDQWdaR2xuSURFd0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTBDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ1UyaGhjbVZ6VFdGMGFFeHBZaTUwYjBGemMyVjBjMVZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQlZkR2xzYzB4cFlpNXRhVzRLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZblZ5ZVNBeU1Bb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdScFp5QTBDaUFnSUNCallXeHNjM1ZpSUZWMGFXeHpUR2xpTG5SdlZXbHVkREV5T0FvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTWpJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ053b2dJQ0FnWW53S0lDQWdJR1JwWnlBMUNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lyQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOaGJHeHpkV0lnVlhScGJITk1hV0l1ZEc5VmFXNTBNVEk0Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmlmQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01UWXdJRE15Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXhNamdnTXpJS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0E1TmlBek1nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMkZzYkhOMVlpQlZkR2xzYzB4cFlpNTBiMVZwYm5ReE1qZ0tJQ0FnSUdJdENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmlmQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYM0IxZEFvS2JHbHhkV2xrWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTnpvS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKOENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKMWNua2dNVGdLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlmQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlkWEo1SURJeUNpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTBDaUFnSUNCaWZBb2dJQ0FnWkdsbklERTRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR0o4Q2lBZ0lDQmthV2NnT1FvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh6SUM4dklHMWxkR2h2WkNBaVJYWmxiblFvS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUZOaFptVlVjbUZ1YzJabGNreHBZaTV6WVdabFZISmhibk5tWlhJS0lDQWdJR1JwWnlBekNpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1Bb2dJQ0FnWW5vZ2JHbHhkV2xrWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdaR2xuSURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4eklDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNU5EQmlNVEkzTmlBdkx5QnRaWFJvYjJRZ0ltOXVUVzl5Y0dodlRHbHhkV2xrWVhSbEtIVnBiblF5TlRZc2RXbHVkRGhiWFNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLQ214cGNYVnBaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRREV3T2dvZ0lDQWdaR2xuSURjS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHUnBaeUF4TWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVkhKaGJuTm1aWEpNYVdJdWMyRm1aVlJ5WVc1elptVnlSbkp2YlFvZ0lDQWdaR2xuSURFMUNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ214cGNYVnBaR0YwWlY5bGJITmxYMkp2WkhsQU5Eb0tJQ0FnSUdScFp5QXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaR2xuSURjS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnVTJoaGNtVnpUV0YwYUV4cFlpNTBiMEZ6YzJWMGMwUnZkMjRLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1RXRjBhRXhwWWk1M1RYVnNSRzkzYmdvZ0lDQWdZbmwwWldNZ01UWWdMeThnTUhoak1EazNZMlUzWW1NNU1EY3hOV0l6TkdJNVpqRXdNREF3TURBd01EQUtJQ0FnSUdScFp5QXlDaUFnSUNCallXeHNjM1ZpSUUxaGRHaE1hV0l1YlhWc1JHbDJSRzkzYmdvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0JpSUd4cGNYVnBaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRFVLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZMbVpzWVhOb1RHOWhibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21ac1lYTm9URzloYmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lYTnpaWEowSUM4dklIcGxjbThnWVhOelpYUnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURNS0lDQWdJR1JwWnlBeENpQWdJQ0JpZkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnYldWMGFHOWtJQ0pGZG1WdWRDZ3BJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxWSEpoYm5ObVpYSk1hV0l1YzJGbVpWUnlZVzV6Wm1WeUNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5XUmxNelZpTURRZ0x5OGdiV1YwYUc5a0lDSnZiazF2Y25Cb2IwWnNZWE5vVEc5aGJpaDFhVzUwTWpVMkxIVnBiblE0VzEwcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdVMkZtWlZSeVlXNXpabVZ5VEdsaUxuTmhabVZVY21GdWMyWmxja1p5YjIwS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2TG5ObGRFRjFkR2h2Y21sNllYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkJkWFJvYjNKcGVtRjBhVzl1T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKcGMwRjFkR2h2Y21sNlpXUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JREVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1lXeHlaV0ZrZVNCelpYUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRRZ0x5OGdJbWx6UVhWMGFHOXlhWHBsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKRmRtVnVkQ2dwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2TG5ObGRFRjFkR2h2Y21sNllYUnBiMjVYYVhSb1UybG5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFFYVjBhRzl5YVhwaGRHbHZibGRwZEdoVGFXYzZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE1qa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUVGMWRHaHZjbWw2WVhScGIyNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGN5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQlRhV2R1WVhSMWNtVUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURrM0lETXlDaUFnSUNCaVBEMEtJQ0FnSUdGemMyVnlkQ0F2THlCemFXZHVZWFIxY21VZ1pYaHdhWEpsWkFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdOalVnTXpJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJSEIxYzJoaWVYUmxjeUFpYm05dVkyVWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1JwWnlBeENpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzV2Ym1ObENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1ERUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TVdRd01qZzBabUl3WlRKalpHVXhPR1F3TlRVellqQTJNVGc1WkRabU56WXhNMk01Tm1Fd01XSmlOV0kxWlRjNE1qaGxZV1JsTm1Fd1pHTmhZemt4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UVWdMeThnSWtSUFRVRkpUbDlUUlZCQlVrRlVUMUlpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRVJQVFVGSlRsOVRSVkJCVWtGVVQxSWdaWGhwYzNSekNpQWdJQ0J3ZFhOb1lubDBaWE1nSWx4NE1UbGNlREF4SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd0bFkyTmhhekkxTmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQXlOd29nSUNBZ0xRb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnT0NBek1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSFJ5WVdOMElEUXdJRE15Q2lBZ0lDQmxZMlJ6WVY5d2ExOXlaV052ZG1WeUlGTmxZM0F5TlRack1Rb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdZbnBsY204S0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JsZUhSeVlXTjBJREV5SURJd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTWdOU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ6WlhSQmRYUm9iM0pwZW1GMGFXOXVWMmwwYUZOcFoxOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHUjFjRElLSUNBZ0lEMDlDaUFnSUNCaWVpQnpaWFJCZFhSb2IzSnBlbUYwYVc5dVYybDBhRk5wWjE5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENncHpaWFJCZFhSb2IzSnBlbUYwYVc5dVYybDBhRk5wWjE5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCemFXZHVZWFIxY21VS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlmQW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKRmRtVnVkQ2dwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOVEV5Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpYVhOQmRYUm9iM0pwZW1Wa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSWtWMlpXNTBLQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2MyVjBRWFYwYUc5eWFYcGhkR2x2YmxkcGRHaFRhV2RmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYzJWMFFYVjBhRzl5YVhwaGRHbHZibGRwZEdoVGFXZGZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9ieTVoWTJOeWRXVkpiblJsY21WemRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZqWTNKMVpVbHVkR1Z5WlhOME9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdNZ05DQXZMeUF4TmpBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRTFoY210bGRGQmhjbUZ0Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlFMWhjbXRsZEZCaGNtRnRjMHhwWWk1cFpBb2dJQ0FnWkhWd0NpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltMWhjbXRsZENJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0F6TWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiV0Z5YTJWMElHNXZkQ0JqY21WaGRHVmtDaUFnSUNCallXeHNjM1ZpSUY5aFkyTnlkV1ZKYm5SbGNtVnpkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOHVaWGgwVTJ4dllXUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWlhoMFUyeHZZV1J6T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNCtDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9LWlhoMFUyeHZZV1J6WDNkb2FXeGxYM1J2Y0VBeU9nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWkdsbklESUtJQ0FnSUdJOENpQWdJQ0JpZWlCbGVIUlRiRzloWkhOZllXWjBaWEpmZDJocGJHVkFOQW9nSUNBZ1pHbG5JRElLSUNBZ0lIQnZjQW9nSUNBZ1lpQmxlSFJUYkc5aFpITmZkMmhwYkdWZmRHOXdRRElLQ21WNGRGTnNiMkZrYzE5aFpuUmxjbDkzYUdsc1pVQTBPZ29nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0x3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodkxtOTNibVZ5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2IzZHVaWEk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUc5M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodkxtWmxaVkpsWTJsd2FXVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21abFpWSmxZMmx3YVdWdWREb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaVptVmxVbVZqYVhCcFpXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qm1aV1ZTWldOcGNHbGxiblFnWlhocGMzUnpDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOHVYMmx6VTJWdVpHVnlRWFYwYUc5eWFYcGxaQ2h2YmtKbGFHRnNaam9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LWDJselUyVnVaR1Z5UVhWMGFHOXlhWHBsWkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUY5cGMxTmxibVJsY2tGMWRHaHZjbWw2WldSZlltOXZiRjkwY25WbFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJREUwSUM4dklDSnBjMEYxZEdodmNtbDZaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZbm9nWDJselUyVnVaR1Z5UVhWMGFHOXlhWHBsWkY5aWIyOXNYMlpoYkhObFFETUtDbDlwYzFObGJtUmxja0YxZEdodmNtbDZaV1JmWW05dmJGOTBjblZsUURJNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwYzNWaUNncGZhWE5UWlc1a1pYSkJkWFJvYjNKcGVtVmtYMkp2YjJ4ZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2TGw5aFkyTnlkV1ZKYm5SbGNtVnpkQ2h0WVhKclpYUlFZWEpoYlhNNklHSjVkR1Z6TENCcFpEb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNsOWhZMk55ZFdWSmJuUmxjbVZ6ZERvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdSMWNHNGdOQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p0WVhKclpYUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJOVBRb2dJQ0FnWW5vZ1gyRmpZM0oxWlVsdWRHVnlaWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ2NtVjBjM1ZpQ2dwZllXTmpjblZsU1c1MFpYSmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWW5sMFpXTWdOU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJQ0U5Q2lBZ0lDQmllaUJmWVdOamNuVmxTVzUwWlhKbGMzUmZZV1owWlhKZmFXWmZaV3h6WlVBM0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWaklERTVJQzh2SUcxbGRHaHZaQ0FpWW05eWNtOTNVbUYwWlNnb2RXbHVkRGhiTXpKZExIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5ReU5UWXBMQ2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTmlrcGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnWTJGc2JITjFZaUJOWVhSb1RHbGlMbmRVWVhsc2IzSkRiMjF3YjNWdVpHVmtDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCTllYUm9UR2xpTG5kTmRXeEViM2R1Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01UWXdJRE15Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQXhNamdnTXpJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRlYwYVd4elRHbGlMblJ2VldsdWRERXlPQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JpS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXhOakFnTXpJS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREV5T0NBek1nb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR05oYkd4emRXSWdWWFJwYkhOTWFXSXVkRzlWYVc1ME1USTRDaUFnSUNCaUt3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmlmQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0JpZWlCZllXTmpjblZsU1c1MFpYSmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeE5qQWdNeklLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUUxaGRHaE1hV0l1ZDAxMWJFUnZkMjRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdOaGJHeHpkV0lnVTJoaGNtVnpUV0YwYUV4cFlpNTBiMU5vWVhKbGMwUnZkMjRLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltWmxaVkpsWTJsd2FXVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dabVZsVW1WamFYQnBaVzUwSUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ09DQXZMeUFpY0c5emFYUnBiMjRpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHSXJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTJDaUFnSUNCaWZBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpZV3hzYzNWaUlGVjBhV3h6VEdsaUxuUnZWV2x1ZERFeU9Bb2dJQ0FnWWlzS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5d2RYUUtDbDloWTJOeWRXVkpiblJsY21WemRGOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbndLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpUlhabGJuUW9LU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2dwZllXTmpjblZsU1c1MFpYSmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01UWXdJRE15Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaUpnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0E1TmlBek1nb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2TGw5cGMwaGxZV3gwYUhrb015a29iV0Z5YTJWMFVHRnlZVzF6T2lCaWVYUmxjeXdnYVdRNklHSjVkR1Z6TENCaWIzSnliM2RsY2pvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1gybHpTR1ZoYkhSb2VTZ3pLVG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUE0SUM4dklDSndiM05wZEdsdmJpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJRjlwYzBobFlXeDBhSGtvTXlsZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBjM1ZpQ2dwZmFYTklaV0ZzZEdoNUtETXBYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdhVzUwWTE4eklDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXlNQ0F2THlCdFpYUm9iMlFnSW5CeWFXTmxLQ2wxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1gybHpTR1ZoYkhSb2VTZzBLUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9ieTVmYVhOSVpXRnNkR2g1S0RRcEtHMWhjbXRsZEZCaGNtRnRjem9nWW5sMFpYTXNJR2xrT2lCaWVYUmxjeXdnWW05eWNtOTNaWEk2SUdKNWRHVnpMQ0JqYjJ4c1lYUmxjbUZzVUhKcFkyVTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbDlwYzBobFlXeDBhSGtvTkNrNkNpQWdJQ0J3Y205MGJ5QTBJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ09DQXZMeUFpY0c5emFYUnBiMjRpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJXRnlhMlYwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBNU5pQXpNZ29nSUNBZ1kyRnNiSE4xWWlCVGFHRnlaWE5OWVhSb1RHbGlMblJ2UVhOelpYUnpWWEFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdNSGhqTURrM1kyVTNZbU01TURjeE5XSXpOR0k1WmpFd01EQXdNREF3TURBS0lDQWdJR05oYkd4emRXSWdUV0YwYUV4cFlpNXRkV3hFYVhaRWIzZHVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCallXeHNjM1ZpSUUxaGRHaE1hV0l1ZDAxMWJFUnZkMjRLSUNBZ0lHSThQUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodkxtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFHSUFBQkdLQUJnSUNRdTdyV3JmQU5KaFlBSVFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBTUFCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJGRlVMMmRnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJtMWhjbXRsZEFFQkNIQnZjMmwwYVc5dUJXOTNibVZ5QkJVZmZIVU1abVZsVW1WamFYQnBaVzUwRVAvLy8vLy8vLy8vLy8vLy8vLy8vLzhERDBKQURHbHpRWFYwYUc5eWFYcGxaQkJFVDAxQlNVNWZVMFZRUVZKQlZFOVNEOENYem52SkJ4V3pTNThRQUFBQUFBeHBjMGx5YlVWdVlXSnNaV1FOYVhOTWJIUjJSVzVoWW14bFpBUm5FV0RRQk1JT0xId2hBUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBM2d0ck9uWkFBQU1SaEFBRkFuRHlobkp3a25CV2NuQ3ljRlp6WWFBRWtuQlJORU1nZ1dnQ0JINTVVMG9rV1ZMb3NXaVRvemE0V2oyZXFmcU1Wejg5Z0RyN2txZVVhU0dFeFFNZ3BRQWljUFRHY25DVXNCWnl0TVVMQWtRekVaRkVReEdFU0NGQVJrNWhnU0JFYy82ajBFcXRTU2RBU1ErVEUxQkhnWktpUUV2c2FXV3dUSWUvdk9CRGxnY29FRXg3VTNZQVFJVU0vK0JCbTRPWWdFNlZYSTdBVDNVOTBMQk1XaTloY0VpaXdldmdRanlOOUNCQ2d2RWpvRU5pRm81UVN4dTdDb0JHS3cxY2MyR2dDT0ZBSWpBa1lDY1FLN0ExWURld1JHQmk4SDR3bWFDNDhNZncwOUVTVVJyeEgwRXUwVEVCTkpFMVVBaWdFQklxK0wvMWNBSUVzQlRGQkpGU0lKSWxpTC8xY2dJRXNDVEZCSkZTSUpJbGhRaS85WFFDQkxBa3hRU1JVaUNTSllVSXYvVjJBZ1N3Sk1VRWtWSWdraVdGQ0wvMWVBSUU4Q1RGQkpGU0lKSWxoUUFvbUtBZ0VoQlJhTC9vdi9Ud0tJQUIrSmlnSUJJUVVXaS81TWkvK0lBQkNKaWdJQklRVVdpLzVNaS8rSUFBMkppZ01CaS8yTC9xT0wvNktKaWdNQmkvMkwvcU9ML3ltZ0p3ZWhLYXFnaS8raWlZb0NBWXYraS8ralNVc0JnQWdid1cxblRzZ0FBSWoveGtsTEFvQUlLYUlrR3ZZc0FBQ0kvN1pPQXFDZ2lZb0RBSXY5SlZ0SmNnQklGVVN4SXErTC8xQkpGU0lKSWxpQkJySVFJN0laSTdJQlRMSVlnQVFaakpnZ3NocUwvcklhc2hxenRENVhCQUJKRlVFQUJvc0FGMEVBQXlSRWlTTkMvL3FLQkFDTC9DVmJTWElBU0JWRXNTS3ZpLzlRU1JVaUNTSllnUWF5RUNPeUdTT3lBVXl5R0lBRWJmUWZiYklhaS8yeUdvditzaHF5R3JPMFBsY0VBRWtWUVFBR2l3QVhRUUFESkVTSkkwTC8rb29EQVl2L0p3MmdpLzRuQjZDTC9VNENpUDhCaVlvREFZditKd2VnaS84bkRhQ0wvVTRDaVA3c2lZb0RBWXYvSncyZ2kvNG5CNkNML1U0Q2lQN2ppWW9EQVl2K0p3ZWdpLzhuRGFDTC9VNENpUDdPaVlvQ0FZditLS2dvSndkUEFrMkwveWlvS0NjSFR3Sk5yU2lwaVlvQ0FZditpLyt0aS8rTC9xUW9Kd2RQQWsyakthcUwvcTJKaWdFQmkvOG5ES1pFaS84bkRLeUppZ0lCaS82TC82VW9Kd2RQQWsyTC9pbWdpLytoS2FxakthcUpOaG9CU1JVaUVrUXhBQ01uQ1dWRVRFc0JFa1JMQVJORUp3bExBV2NyVEZDd0pFTTJHZ0ZKRlNJU1JERUFJeWNKWlVRU1JFa0JKeEZNVUVtK1RCY2pURThDVFJSRUpCYS9LMHhRc0NSRE5ob0JTUlZKSWhKRU1RQWpKd2xsUkJKRUlxOUpTd05RU1JVaUNTSllBU2NTVEZCSnZrd1hJMHhQQWswVVJFc0RnQWdONExhenAyUUFBS1JFSkJhL1RDSU9SS3NyVEZDd0pFTTJHZ0ZKRlNFRUVrUTJHZ0pKRlVraUVrUXhBQ01uQ1dWRUVrUkxBb2o5SmtrQkp3Wk1VRW0rS2s0Q1RVbFhnQ0FvcVVSWG9DQkxCS2xFU3dPQUNBTjRMYXpwMlFBQXBrUlBCRXNDaUJCN1N3TW5ES3hKRlNJT1JDS3ZURXNCcTBzQ3ZpcE9BazFKVjRBZ1N3RlhRQ0JMQWxkZ0lFc0RWd0FnVHdSWElDQlFUd0pRVEZCTVVFeFFUd0pNdjA4Q0lnNUVUd0tyVUN0TVVMQWtRellhQVVrVkloSkVNUUFqSndsbFJCSkVJeWNMWlVSTEFSTkVKd3RMQVdjclRGQ3dKRU0yR2dGSkZTRUVFa1JKaVB4NVN3RlhZQ0JKQVNjUlRGQytUQmNqVEU4Q1RVUWlyMHNEVjRBZ1N3Rk1VRWtWSWdraVdBRW5Fa3hRdmt3WEkweFBBazFFU3dJQkp3WkxBVkJKdmlwT0FrMUpWNEFnS0toRVNWZWdJRElIRmljTXJFa1ZJZzVFVHdXclN3SlhRQ0JMQTFkZ0lFc0VWd0FnVHdWWElDQlFUd0pRVEZCTVVFeFFTd0ZNdjRBUWFXUlViMDFoY210bGRGQmhjbUZ0YzA4Q1VFc0V2MDhDU3dOUUsweFFzTEcrS2s0Q1RVd2xXNEVHc2hBanNoa2pzZ0d5R0NjVHNocE1zaHF5R3JNa1F5TkhBaWcyR2dGSEFoVWhCQkpFTmhvQ1NVNENTUlVpRWtRMkdnTkpUZ05KRlNJU1JEWWFCRWxPQkVrVkloSkVOaG9GU1NOWmdRSUlTd0VWRWtSWEFnQk9CRXNEaVB0MFNVNEZTUUVuQmt4UVNVNEd2aXBPQWsxWGdDQW9xVVJMQTA4RGlQMFpSRXduQlJORVR3Sk1pQTdPS0tWQkFWbEp2aXBPQWsxSlZ3QWdURmNnSUVzSFRnS0kvSjlGQlVzQlNVc0ZTVTREVUFFbkNFeFFTYjRuQkU0Q1RVbFhJQ0JMQVZkQUlFOENWd0FnU3dwSlRnV2dTUlVpRGtRaXIwbEZFVXhMQWF0UEExQlBBbEJQQWt5L1N3UkpUZ08rS2s0Q1RVbFhvQ0JMQVZlQUlFc0NWMEFnU3dOWFlDQkxCRmNBSUU4RlZ5QWdTd2VJL0xtZ1NSVWlEa1JMQnF0UVR3SlFURkJNVUV4UVNWZWdJRXNCVjRBZ1N3SlhRQ0JMQTFkZ0lFc0VWd0FnU3hCSlRnYUkvSWFnU1JVaURrUkxCNnRQQmxjZ0lGQlBBbEJNVUV4UVRGQlBCRXkvTVFCTEFSVWlEa1JNU3dLclNVNENSUkZMQXhVaURrUlBBMDhEcTBsRkQwOERUd0pRVHdOUVR3SlFURkFyVEZDd1N3SVZTVVVKUVFBenNVc0lTd1pRU1JVaUNTSllTd2dXVndZQ1N3UlFNUUFsVzRFR3NoQWpzaGtqc2dHeUdJQUVsVUh0cExJYVRMSWFzaHF6U3daWEFDQXhBRElLU3dpSSt4ZExDa3NLVUNjS1RGQ3dKRU5KdmlwT0FrMUpWd0FnVEZjZ0lFc0dUZ0tJKzRWRkJrTCtwRFlhQVVjQ0ZTRUVFa1EyR2dKSlRnSkpGU0lTUkRZYUEwbE9BMGtWSWhKRU5ob0VTVTRFU1JVaUVrUTJHZ1ZKVGdWSkZTSVNSRXNFaVBtWFNVNEdTUUVuQmt4UVNVNEh2aXBPQWsxWGdDQW9xVVJMQkU4RWlQczhSRXduQlJORVRJZ016MFJQQWt5SURPd29wVUVCSzBtK0trNENUVWxYQUNCTVZ5QWdTd2RPQW9qNjUwVUZTd0ZKU3dWSlRnTlFBU2NJVEZCSnZpY0VUZ0pOU1ZjZ0lFc0JWMEFnVHdKWEFDQXBvRXNLU1U0Rm9TbXFTUlVpRGtRaXIweExBYXRQQTFCUEFsQlBBa3kvU3dSSlRnTytLazRDVFVsWG9DQkxBVmVBSUVzQ1YwQWdTd05YWUNCTEJGY0FJRThGVnlBZ0thQkxCNGo2MUtFcHFra1ZJZzVFU3dhclVFOENVRXhRVEZCTVVFbFhvQ0JMQVZlQUlFc0NWMEFnU3dOWFlDQkxCRmNBSUNtZ1N4QkpUZ2lJK3AyaEthcEpGU0lPUkVzR3EwOEZWeUFnVUU4Q1VFeFFURkJNVUU4RVN3Ry9TVmRBSUV4WEFDQ21SREVBU3dJVklnNUVTd0pMQXF0TEJCVWlEa1JQQkU4RHEwOEVUd05RVHdSUVN3WkpUZ05RU3dOUVN3RlFLMHhRc0VzS1Z3QWdUd0pQQklqNUUxQW5Da3hRc0NSRFNiNHFUZ0pOU1ZjQUlFeFhJQ0JMQms0Q2lQbW5SUVpDL3RJMkdnRkhBaFVoQkJKRU5ob0NTVTRDU1JVaUVrUTJHZ05KVGdOSkZTSVNSRFlhQkVsT0JFa1ZJaEpFTmhvRlNVNEZTUlVpRWtSTEJJajM0MGxPQmtrQkp3Wk1VRWxPQjc0cVRnSk5WNEFnS0tsRVN3UlBCSWo1aUVSTUp3VVRSRXlJQ3h0RVR3Sk1pQXM0S0tWQkFTNUp2aXBPQWsxSlYwQWdURmRnSUVzSFRnS0krVE5GQlVzQlNVc0ZTVTREVUFFbkNFeFFTYjRuQkU0Q1RVbFhJQ0JMQ1VsT0JJajViNkJKRlNJT1JDS3ZURXNCcTBzQ1YwQWdUd05YQUNCUEFsQk1VRThDVEw5TEJFbE9BNzRxVGdKTlNWZWdJRXNCVjRBZ1N3SlhRQ0JMQTFkZ0lFc0dpUGt1b0VrVklnNUVTd1dyU3dSWEFDQlBCVmNnSUZCUEFsQk1VRXhRVEZCSlY2QWdTd0ZYZ0NCTEFsZEFJRXNPU1U0R2lQajdvRWtWSWc1RVN3U3JTd05YWUNCTEJGY0FJRThGVnlBZ1VFOENVRXhRVEZCTVVFOEVTd0cvU3d4SlRnUkxCa3NJaUF4UFJFbFhRQ0JNVndBZ3BrUXhBRXNDRlNJT1JFc0NTd0tyU3dVVklnNUVUd1ZQQTZ0UEJVOERVRThGVUVzSFNVNERVRXNEVUVzQlVDdE1VTEJQQkZjQUlFOENUd1NJOTF4UUp3cE1VTEFrUTBtK0trNENUVWxYUUNCTVYyQWdTd1pPQW9qMzhFVUdRdjdQSTBjQ0tEWWFBVWNDRlNFRUVrUTJHZ0pKVGdKSkZTSVNSRFlhQTBsT0Ewa1ZJaEpFTmhvRVNVNEVTUlVpRWtRMkdnVkpJMW1CQWdoTEFSVVNSRmNDQUU0RVN3T0k5aUJKVGdWSkFTY0dURkJKVGdhK0trNENUVmVBSUNpcFJFc0RUd09JOThWRVRDY0ZFMFJQQWt5SUNYb29wVUVCWlVtK0trNENUVWxYUUNCTVYyQWdTd2RPQW9qM1MwVUZTd0ZKU3dWSlRnTlFBU2NJVEZCSnZpY0VUZ0pOU1ZjZ0lDbWdTd2xKVGdTSTk2K2hLYXBKRlNJT1JDS3ZTVVVRVEVzQnEwc0NWMEFnVHdOWEFDQlBBbEJNVUU4Q1RMOUxCRWxPQTc0cVRnSk5TVmVnSUVzQlY0QWdTd0pYUUNCTEExZGdJQ21nU3dhSTkyZWhLYXBKRlNJT1JFc0ZxMHNFVndBZ1R3VlhJQ0JRVHdKUVRGQk1VRXhRU1ZlZ0lFc0JWNEFnU3dKWFFDQkxEa2xPQllqM1FZajNMMGtWSWc1RVN3V3JTd05YWUNCTEJGY0FJRThGVnlBZ1VFOENVRXhRVEZCTVVFOEVUTDh4QUVzQkZTSU9SRXhMQXF0SlRnSkZFVXNERlNJT1JFOERUd09yU1VVUFR3TlBBbEJQQTFCUEFsQk1VQ3RNVUxCTEFoVkpSUWxCQURPeFN3aExCbEJKRlNJSklsaExDQlpYQmdKTEJGQXhBQ1ZiZ1FheUVDT3lHU095QWJJWWdBVHE0WUY0c2hwTXNocXlHck5MQmxjQUlERUFNZ3BMQ0lqMXQwc0tTd3BRSndwTVVMQWtRMG0rS2s0Q1RVbFhRQ0JNVjJBZ1N3Wk9Bb2oySlVVR1F2NllOaG9CUndJVklRUVNSRFlhQWtsT0Fra1ZTU0lTUkRZYUEwa1ZJaEpFTmhvRVNTTlpnUUlJU3dFVkVrUlhBZ0JKVGdST0JVOEVpUFE1U1FFbkJreFF2aXBPQWsxWGdDQW9xVVJMQXlpcFJFc0JKd1VUUkVsTEFsQUJKd2hNVUVtK0p3Uk9BazFKVnlBZ1N3RlhRQ0JMQjRqMTk2QkpGU0lPUkNLdlNVNEtURXNCcTA4RFZ3QWdUd05RVEZCUEFreS9NUUJQQkNJT1JFOEVUd0tyVGdKUVR3SlFURkFyVEZDd0ZVbEJBRE94U3dGTEJGQkpGU0lKSWxoTEFSWlhCZ0pMQkZBeEFDVmJnUWF5RUNPeUdTT3lBYklZZ0FTbHV0REVzaHBNc2hxeUdyTkxCRmNnSURFQU1ncExCb2owb3lSRE5ob0JTUlVoQkJKRU5ob0NTUlZKSWhKRU5ob0RTUlVpRWtRMkdnUkpGU0lTUkVzRWlQTmJTUUVuQmt4UXZpcE9BazFYZ0NBb3FVUkxCQ2lwUkVzQkp3VVRSRXNDaUFhYVJFc0ZTd0dJQnJaSlN3TlFBU2NJVEZCSnZpY0VUZ0pOU1ZjZ0lFc0JWMEFnS2FCTENJajFDcUVwcWtrVklnNUVJcTlNU3dHclR3TlhBQ0JQQTFCTVVFOENUTDlMQmtzQ1N3V0lDR3hFTVFCUEJTSU9SRXNGVHdLclRnSlFUd05RU3dKUVRGQXJURkN3VHdKWElDQk1Ud0tJODVra1F5TkhCaWcyR2dGSEFoVWhCQkpFTmhvQ1NVNENTUlVpRWtRMkdnTkpUZ05KRlNJU1JEWWFCRWxPQkVrVkloSkVOaG9GU1NOWmdRSUlTd0VWRWtSWEFnQk9CRXNEaVBKOVNVNEZTUUVuQmt4UVNVNEd2aXBPQWsxWGdDQW9xVVJMQWs4Q2lQUWlSRXNEU3dHSUJkdXhTd05YUUNBbFc0RUdzaEFqc2hranNnR3lHQ2NVc2hxenRENVhCQUJKVGdWTEJFOENUd1JQQTRnSDhSUkVnWUNBekoyRDNlZjZEeFloQlJhQmdJRDR4SkdOOUpRRUZrOEVWNEFnSnhWTW9TbXFpUEpZSnhWTW9TbXFpUEpmaVBQVVRDaWxRUUx1U3daTEFpY1FpUEozVElqeVdFc0N2aXBPQWsxSlYwQWdURmRnSUlqemFrVUZTd0ZKdmlwT0FrMUpWMEFnVEZkZ0lFc0hTVTREVGdLSTgyTkpUZ05GRFVzRlN3cFFBU2NJVEZCSlJROUp2aWNFVGdKTlNWY2dJQ21nU3dPSTg0bWhLYXBKRlNJT1JDS3ZTVVVWVEVzQnEwc0NWMEFnVHdOWEFDQlBBbEJNVUVzQ1RMOUxBNzRxVGdKTlNWZWdJRXNCVjRBZ1N3SlhRQ0JMQTFkZ0lDbWdUd2VJODBTaEthcEpGU0lPUkVzRnEwc0VWd0FnVHdWWElDQlFUd0pRVEZCTVVFeFFTVmVnSUVzQlY0QWdTd0pYUUNCUEI0anpJWWp6RDBrVklnNUVTd1NyU3dOWFlDQkxCRmNBSUU4RlZ5QWdVRThDVUV4UVRGQk1VRThEVEw5TEFiNG5CRTRDVFVsWElDQkxBVmRBSUNtZ1N3cUk4dEtoS2FwSkZTSU9SRThEcTA4Q1Z3QWdUd0pRVEZCTVN3Ry9LRVVOS0VVT1YwQWdLS2hCQVBOTENrbStKd1JPQWsxWElDQkpSUTVMQTBsT0FyNHFUZ0pOU1ZkQUlFc0JWMkFnU3dOTEFrc0NpUEkyU3dKTWlQSmdTVTRDUlJSTEExZWdJRXNFVjRBZ1R3UXBvRXNFaVBKaW9TbXFTUlVpRGtSTEZrbE9CNnRMQlZjQUlFOEdWeUFnVUV4UVR3TlFURkJNVUVsWG9DQkxBVmVBSUVzQ1YwQWdTd05YWUNCTEJGY0FJQ21nVHdhSThpR2hLYXBKRlNJT1JFc0dxMDhGVnlBZ1VFOENVRXhRVEZCTVVFbFhvQ0JMQVZlQUlFc0NWMEFnU3dOWFlDQXBvRThHaVBIdG9TbXFTUlVpRGtSUEJhdExCRmNBSUU4RlZ5QWdVRThDVUV4UVRGQk1VTDlKdmljRVRnSk5TVmRBSUV4WEFDQW5CVkJNVUw4eEFFc0tTUlVpRGtSTEQwbE9BcXRKVGdKRkVrc0hTUlVpRGtSTEFhdExDVWtWSWc1RVNVc0RxMGxPQWtVV1N4SkpGU0lPUkVzRXEwc1NTUlVpRGtSUEJhdExDVThIVUVzTlVFOEdVRThGVUU4RVVFOENVRXhRSzB4UXNFc0lWeUFnTVFCUEFvandLMHNERlVsRkNrRUFNN0ZMRFVzS1VFa1ZJZ2tpV0VzSkZsY0dBa3NGVURFQUpWdUJCcklRSTdJWkk3SUJzaGlBQkpRTEVuYXlHa3l5R3JJYXMwc0hWd0FnTVFBeUNrc01pUEF0U3c5TEQxQW5Da3hRc0NSRFN3SytLazRDVFVsWFFDQk1WMkFnU3dkT0FvandjRXlJN3o0bkVFc0NpTzlsUlFaQy9RMDJHZ0ZKRlNJU1JEWWFBa2tWU1NJU1JEWWFBMGtqV1lFQ0NFc0JGUkpFVndJQVN3SW9xVVF4QUU4Q0lnNUVJcTlMQTBzQnEwOENTd1ZRVEZBclRGQ3dTd014QUVzRWlPOW1zVXNDVUVrVklna2lXRXNCRlJaWEJnSlBBbEF4QUNWYmdRYXlFQ095R1NPeUFiSVlnQVJkNDFzRXNocE1zaHF5R3JNeEFESUtUd05PQWs4RGlPOXpKRU0yR2dGSkZTSVNSRFlhQWtrVkpCSkVTU05UTVFCTEExQUJKdzVNVUw1TUZ5Tk1Ud0pOU3dFVFJERUFTd05RQVNjT1RGQk1Gcjh4QUVsUVR3SlFURkFyVEZDd0pFTTJHZ0ZIQWhXQmdRRVNSRFlhQWtrVmdVZ1NSRElIRmtzQ1YyRWdwa1JMQVZkQklFbE9BazREU3dKWEFDQkpUZ1FCZ0FWdWIyNWpaVXhRU2I0b1RnSk5Ud05MQWFoRUp3ZWdTd0c4U0wrQUlJSFFLRSt3NHMzaGpRVlRzR0dKMXZkaFBKYWdHN1cxNTRLT3JlYWczS3lSVHdKUUFpTW5EMlZFZ0FJWkFVeFFURkFDU3dFalc0RWJDVXNDVndnZ1R3TlhLQ0FIQUlFTXIwNENVQUpYREJSUVNTY0ZFMEVBVGtvU1FRQkpKRVF4QUNLdlN3U3JURXNEU1U0RFVFeFFLMHhRc0VzRVNZR0FCRk9BQVFBalR3SlVTU05UVHdKWElDQkxBMHNCVUFFbkRreFFUd0lXdnpFQVR3TlFURkJNVUN0TVVMQWtReU5DLzdRMkdnRkpGU0VFRWtSSmlPMEhTUUVuQmt4UXZpcE9BazFYZ0NBb3FVU0lBSGNrUXpZYUFVa2pXU0lMZ1FJSVN3RVZFa1NCQWlOWVNSVWlDaFlvS0VzQ3BFRUFCa3NDU0VMLzgwY0NGU0lLRmxjR0FreFFKd3BNVUxBa1F5TW5DV1ZFSndwTVVMQWtReU1uQzJWRUp3cE1VTEFrUTRvQkFURUFpLzhTUUFBVmkvOHhBRkFCSnc1TVVMNU1GeU5NVHdKTlFRQUNKSWtqaVlvQ0FDTkhCRElIRmltZ2kvOEJKd1pNVUVsT0FyNHFUZ0pOVjRBZ29TbXFTU2lvUVFBQmlZditWMkFnU1l3Qkp3VVRRUUdNc1lzRlNiNHFUZ0pOaXdFbFc0RUdzaEFqc2hranNnR3lHQ2NUc2hxTC9ySWFTYklhczdRK1Z3UUFTWXdDU3dGWFFDQk1pd2FJN0xWTEFVeUk3RjlKakFSTEFsZWdJRXNEVjRBZ1N3S0k3ZTlQQktCSkZTSU9SQ0t2U1l3QVRFc0JxMHNGVjJBZ1N3WlhBQ0JQQjFjZ0lGQlBBbEJNVUU4Q1VFOENVRWxYb0NCTEFWZUFJRXNDVjBBZ1N3TlhZQ0JMQkZjQUlFOEhpTzJtb0VrVklnNUVUd2FyVHdWWElDQlFUd0pRVEZCTVVFeFFURXNCdnlpTUExZWdJQ2lwUVFDZGl3Vkp2aXBPQWsxSlY2QWdpd1JNaU92TFN3RlhBQ0Fwb0VzQm9TbXFUd0pYSUNDSTdOQkpqQU1qSnd0bFJJdi9URkFCSndoTVVFbStKd1JPQWsxSlZ5QWdTd0ZYUUNCUEFsY0FJRXNFb0VrVklnNUVpd0JKVGdhclR3SlFURkMvU3dLK0trNENUVWxYb0NCTEFWZUFJRXNDVjBBZ1N3TlhZQ0JMQkZjQUlFOEZWeUFnVHdhSTdQYWdTUlVpRGtSUEJxdFFUd0pRVEZCTVVFeFF2NHNDU1JVaURrU0xBRWxPQXF1TEJFa1ZJZzVFU3dLcml3TkpGU0lPUkU4RHE0di9Ud05RVHdKUVRGQXJURkN3aXdWSnZpcE9BazFKVjZBZ01nY1dKd3lzU1JVaURrUWlyNnRMQWxkQUlFc0RWMkFnU3dSWEFDQlBCVmNnSUZCUEFsQk1VRXhRVEZDL2lZb0RBWXYraS85UUFTY0lURkMrSndST0FrMVhJQ0FvcUVFQUFpU0pzWXY5VjBBZ0pWdUJCcklRSTdJWkk3SUJzaGduRkxJYXM3UStWd1FBaS8yTC9vdi9Ud09JQUFHSmlnUUJpLzJML2xBQkp3aE1VTDRuQkU0Q1RVbFhJQ0NML1FFbkJreFF2aXBPQWsxSlYwQWdURmRnSUlqcnVreFhRQ0NML3ljUWlPcUZpL3hYZ0NDSTZrK21pUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9LHsidHlwZSI6Iih1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDI1NikiLCJzdHJ1Y3QiOiJNYXJrZXRQYXJhbXMiLCJuYW1lIjoiXzEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfNCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfNCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfNSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfNiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfNyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8zIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
	}

}
