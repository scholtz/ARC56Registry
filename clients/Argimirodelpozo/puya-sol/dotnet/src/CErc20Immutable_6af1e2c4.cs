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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.CErc20Immutable_6af1e2c4
{


    //
    //  @title Compound's CErc20Immutable Contract
    // @notice CTokens which wrap an EIP-20 underlying and are immutable
    // @author Compound
    //
    public class CErc20ImmutableProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CErc20ImmutableProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BorrowSnapshot : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Principal { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 InterestIndex { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vPrincipal.From(Principal);
                    ret.AddRange(vPrincipal.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInterestIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vInterestIndex.From(InterestIndex);
                    ret.AddRange(vInterestIndex.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BorrowSnapshot Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BorrowSnapshot();
                    uint count = 0;
                    var vPrincipal = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Principal = vPrincipal;
                    var vInterestIndex = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vInterestIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.InterestIndex = vInterestIndex;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BorrowSnapshot);
                }
                public bool Equals(BorrowSnapshot? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BorrowSnapshot left, BorrowSnapshot right)
                {
                    return EqualityComparer<BorrowSnapshot>.Default.Equals(left, right);
                }
                public static bool operator !=(BorrowSnapshot left, BorrowSnapshot right)
                {
                    return !(left == right);
                }

            }

            public class GetAccountSnapshotReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field3 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetAccountSnapshotReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetAccountSnapshotReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetAccountSnapshotReturn);
                }
                public bool Equals(GetAccountSnapshotReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetAccountSnapshotReturn left, GetAccountSnapshotReturn right)
                {
                    return EqualityComparer<GetAccountSnapshotReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetAccountSnapshotReturn left, GetAccountSnapshotReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class NewComptrollerEvent
            {
                public static readonly byte[] Selector = new byte[4] { 247, 179, 95, 167 };
                public const string Signature = "NewComptroller(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] OldComptroller { get; set; }
                public byte[] NewComptroller { get; set; }

                public static NewComptrollerEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NewComptrollerEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOldComptroller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOldComptroller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOldComptroller = vOldComptroller.ToValue();
                    if (valueOldComptroller is byte[] vOldComptrollerValue) { ret.OldComptroller = vOldComptrollerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewComptroller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewComptroller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewComptroller = vNewComptroller.ToValue();
                    if (valueNewComptroller is byte[] vNewComptrollerValue) { ret.NewComptroller = vNewComptrollerValue; }
                    return ret;

                }

            }

            public class NewMarketInterestRateModelEvent
            {
                public static readonly byte[] Selector = new byte[4] { 222, 67, 216, 42 };
                public const string Signature = "NewMarketInterestRateModel(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] OldInterestRateModel { get; set; }
                public byte[] NewInterestRateModel { get; set; }

                public static NewMarketInterestRateModelEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NewMarketInterestRateModelEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOldInterestRateModel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOldInterestRateModel.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOldInterestRateModel = vOldInterestRateModel.ToValue();
                    if (valueOldInterestRateModel is byte[] vOldInterestRateModelValue) { ret.OldInterestRateModel = vOldInterestRateModelValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewInterestRateModel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewInterestRateModel.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewInterestRateModel = vNewInterestRateModel.ToValue();
                    if (valueNewInterestRateModel is byte[] vNewInterestRateModelValue) { ret.NewInterestRateModel = vNewInterestRateModelValue; }
                    return ret;

                }

            }

            public class AccrueInterestEvent
            {
                public static readonly byte[] Selector = new byte[4] { 246, 109, 162, 138 };
                public const string Signature = "AccrueInterest(uint256,uint256,uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 CashPrior { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 InterestAccumulated { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 BorrowIndex { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalBorrows { get; set; }

                public static AccrueInterestEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AccrueInterestEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCashPrior = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vCashPrior.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCashPrior = vCashPrior.ToValue();
                    if (valueCashPrior is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vCashPriorValue) { ret.CashPrior = vCashPriorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInterestAccumulated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vInterestAccumulated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInterestAccumulated = vInterestAccumulated.ToValue();
                    if (valueInterestAccumulated is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vInterestAccumulatedValue) { ret.InterestAccumulated = vInterestAccumulatedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrowIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vBorrowIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBorrowIndex = vBorrowIndex.ToValue();
                    if (valueBorrowIndex is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vBorrowIndexValue) { ret.BorrowIndex = vBorrowIndexValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBorrows = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vTotalBorrows.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBorrows = vTotalBorrows.ToValue();
                    if (valueTotalBorrows is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vTotalBorrowsValue) { ret.TotalBorrows = vTotalBorrowsValue; }
                    return ret;

                }

            }

            public class MintEvent
            {
                public static readonly byte[] Selector = new byte[4] { 251, 246, 72, 245 };
                public const string Signature = "Mint(uint8[32],uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Minter { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 MintAmount { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 MintTokens { get; set; }

                public static MintEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new MintEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinter = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vMinter.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinter = vMinter.ToValue();
                    if (valueMinter is byte[] vMinterValue) { ret.Minter = vMinterValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMintAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vMintAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMintAmount = vMintAmount.ToValue();
                    if (valueMintAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vMintAmountValue) { ret.MintAmount = vMintAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMintTokens = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vMintTokens.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMintTokens = vMintTokens.ToValue();
                    if (valueMintTokens is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vMintTokensValue) { ret.MintTokens = vMintTokensValue; }
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
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmountValue) { ret.Amount = vAmountValue; }
                    return ret;

                }

            }

            public class RedeemEvent
            {
                public static readonly byte[] Selector = new byte[4] { 1, 194, 171, 74 };
                public const string Signature = "Redeem(uint8[32],uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Redeemer { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 RedeemAmount { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 RedeemTokens { get; set; }

                public static RedeemEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RedeemEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRedeemer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vRedeemer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRedeemer = vRedeemer.ToValue();
                    if (valueRedeemer is byte[] vRedeemerValue) { ret.Redeemer = vRedeemerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRedeemAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vRedeemAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRedeemAmount = vRedeemAmount.ToValue();
                    if (valueRedeemAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vRedeemAmountValue) { ret.RedeemAmount = vRedeemAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRedeemTokens = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vRedeemTokens.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRedeemTokens = vRedeemTokens.ToValue();
                    if (valueRedeemTokens is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vRedeemTokensValue) { ret.RedeemTokens = vRedeemTokensValue; }
                    return ret;

                }

            }

            public class BorrowEvent
            {
                public static readonly byte[] Selector = new byte[4] { 76, 181, 25, 95 };
                public const string Signature = "Borrow(uint8[32],uint256,uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Borrower { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 BorrowAmount { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AccountBorrows { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalBorrows { get; set; }

                public static BorrowEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new BorrowEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vBorrower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBorrower = vBorrower.ToValue();
                    if (valueBorrower is byte[] vBorrowerValue) { ret.Borrower = vBorrowerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrowAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vBorrowAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBorrowAmount = vBorrowAmount.ToValue();
                    if (valueBorrowAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vBorrowAmountValue) { ret.BorrowAmount = vBorrowAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccountBorrows = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAccountBorrows.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccountBorrows = vAccountBorrows.ToValue();
                    if (valueAccountBorrows is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAccountBorrowsValue) { ret.AccountBorrows = vAccountBorrowsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBorrows = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vTotalBorrows.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBorrows = vTotalBorrows.ToValue();
                    if (valueTotalBorrows is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vTotalBorrowsValue) { ret.TotalBorrows = vTotalBorrowsValue; }
                    return ret;

                }

            }

            public class RepayBorrowEvent
            {
                public static readonly byte[] Selector = new byte[4] { 121, 187, 111, 29 };
                public const string Signature = "RepayBorrow(uint8[32],uint8[32],uint256,uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Payer { get; set; }
                public byte[] Borrower { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 RepayAmount { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AccountBorrows { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalBorrows { get; set; }

                public static RepayBorrowEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RepayBorrowEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vPayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayer = vPayer.ToValue();
                    if (valuePayer is byte[] vPayerValue) { ret.Payer = vPayerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vBorrower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBorrower = vBorrower.ToValue();
                    if (valueBorrower is byte[] vBorrowerValue) { ret.Borrower = vBorrowerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepayAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vRepayAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRepayAmount = vRepayAmount.ToValue();
                    if (valueRepayAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vRepayAmountValue) { ret.RepayAmount = vRepayAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccountBorrows = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAccountBorrows.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccountBorrows = vAccountBorrows.ToValue();
                    if (valueAccountBorrows is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAccountBorrowsValue) { ret.AccountBorrows = vAccountBorrowsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBorrows = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vTotalBorrows.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBorrows = vTotalBorrows.ToValue();
                    if (valueTotalBorrows is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vTotalBorrowsValue) { ret.TotalBorrows = vTotalBorrowsValue; }
                    return ret;

                }

            }

            public class ReservesAddedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 136, 122, 147, 10 };
                public const string Signature = "ReservesAdded(uint8[32],uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Benefactor { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AddAmount { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewTotalReserves { get; set; }

                public static ReservesAddedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ReservesAddedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBenefactor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vBenefactor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBenefactor = vBenefactor.ToValue();
                    if (valueBenefactor is byte[] vBenefactorValue) { ret.Benefactor = vBenefactorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAddAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddAmount = vAddAmount.ToValue();
                    if (valueAddAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAddAmountValue) { ret.AddAmount = vAddAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewTotalReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewTotalReserves.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewTotalReserves = vNewTotalReserves.ToValue();
                    if (valueNewTotalReserves is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewTotalReservesValue) { ret.NewTotalReserves = vNewTotalReservesValue; }
                    return ret;

                }

            }

            public class LiquidateBorrowEvent
            {
                public static readonly byte[] Selector = new byte[4] { 155, 153, 176, 142 };
                public const string Signature = "LiquidateBorrow(uint8[32],uint8[32],uint256,uint8[32],uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Liquidator { get; set; }
                public byte[] Borrower { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 RepayAmount { get; set; }
                public byte[] CTokenCollateral { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 SeizeTokens { get; set; }

                public static LiquidateBorrowEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new LiquidateBorrowEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vLiquidator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLiquidator = vLiquidator.ToValue();
                    if (valueLiquidator is byte[] vLiquidatorValue) { ret.Liquidator = vLiquidatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vBorrower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBorrower = vBorrower.ToValue();
                    if (valueBorrower is byte[] vBorrowerValue) { ret.Borrower = vBorrowerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepayAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vRepayAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRepayAmount = vRepayAmount.ToValue();
                    if (valueRepayAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vRepayAmountValue) { ret.RepayAmount = vRepayAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCTokenCollateral = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCTokenCollateral.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCTokenCollateral = vCTokenCollateral.ToValue();
                    if (valueCTokenCollateral is byte[] vCTokenCollateralValue) { ret.CTokenCollateral = vCTokenCollateralValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeizeTokens = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vSeizeTokens.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeizeTokens = vSeizeTokens.ToValue();
                    if (valueSeizeTokens is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vSeizeTokensValue) { ret.SeizeTokens = vSeizeTokensValue; }
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
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmountValue) { ret.Amount = vAmountValue; }
                    return ret;

                }

            }

            public class NewPendingAdminEvent
            {
                public static readonly byte[] Selector = new byte[4] { 228, 88, 40, 83 };
                public const string Signature = "NewPendingAdmin(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] OldPendingAdmin { get; set; }
                public byte[] NewPendingAdmin { get; set; }

                public static NewPendingAdminEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NewPendingAdminEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOldPendingAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOldPendingAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOldPendingAdmin = vOldPendingAdmin.ToValue();
                    if (valueOldPendingAdmin is byte[] vOldPendingAdminValue) { ret.OldPendingAdmin = vOldPendingAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewPendingAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewPendingAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewPendingAdmin = vNewPendingAdmin.ToValue();
                    if (valueNewPendingAdmin is byte[] vNewPendingAdminValue) { ret.NewPendingAdmin = vNewPendingAdminValue; }
                    return ret;

                }

            }

            public class NewAdminEvent
            {
                public static readonly byte[] Selector = new byte[4] { 216, 12, 236, 132 };
                public const string Signature = "NewAdmin(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] OldAdmin { get; set; }
                public byte[] NewAdmin { get; set; }

                public static NewAdminEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NewAdminEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOldAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOldAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOldAdmin = vOldAdmin.ToValue();
                    if (valueOldAdmin is byte[] vOldAdminValue) { ret.OldAdmin = vOldAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewAdmin = vNewAdmin.ToValue();
                    if (valueNewAdmin is byte[] vNewAdminValue) { ret.NewAdmin = vNewAdminValue; }
                    return ret;

                }

            }

            public class NewReserveFactorEvent
            {
                public static readonly byte[] Selector = new byte[4] { 81, 15, 160, 240 };
                public const string Signature = "NewReserveFactor(uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 OldReserveFactorMantissa { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewReserveFactorMantissa { get; set; }

                public static NewReserveFactorEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NewReserveFactorEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOldReserveFactorMantissa = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vOldReserveFactorMantissa.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOldReserveFactorMantissa = vOldReserveFactorMantissa.ToValue();
                    if (valueOldReserveFactorMantissa is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vOldReserveFactorMantissaValue) { ret.OldReserveFactorMantissa = vOldReserveFactorMantissaValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewReserveFactorMantissa = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewReserveFactorMantissa.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewReserveFactorMantissa = vNewReserveFactorMantissa.ToValue();
                    if (valueNewReserveFactorMantissa is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewReserveFactorMantissaValue) { ret.NewReserveFactorMantissa = vNewReserveFactorMantissaValue; }
                    return ret;

                }

            }

            public class ReservesReducedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 160, 87, 217, 119 };
                public const string Signature = "ReservesReduced(uint8[32],uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Admin { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ReduceAmount { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 NewTotalReserves { get; set; }

                public static ReservesReducedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ReservesReducedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is byte[] vAdminValue) { ret.Admin = vAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReduceAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vReduceAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReduceAmount = vReduceAmount.ToValue();
                    if (valueReduceAmount is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vReduceAmountValue) { ret.ReduceAmount = vReduceAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewTotalReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vNewTotalReserves.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewTotalReserves = vNewTotalReserves.ToValue();
                    if (valueNewTotalReserves is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vNewTotalReservesValue) { ret.NewTotalReserves = vNewTotalReservesValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        /// @notice Initialize the new money market
        /// @param underlying_ The address of the underlying asset
        /// @param comptroller_ The address of the Comptroller
        /// @param interestRateModel_ The address of the interest rate model
        /// @param initialExchangeRateMantissa_ The initial exchange rate, scaled by 1e18
        /// @param name_ ERC-20 name of this token
        /// @param symbol_ ERC-20 symbol of this token
        /// @param decimals_ ERC-20 decimal precision of this token
        ///</summary>
        /// <param name="underlying_"> </param>
        /// <param name="comptroller_"> </param>
        /// <param name="interestRateModel_"> </param>
        /// <param name="initialExchangeRateMantissa_"> </param>
        /// <param name="name_"> </param>
        /// <param name="symbol_"> </param>
        /// <param name="decimals_"> </param>
        public async Task Initialize(Algorand.Address underlying_, Algorand.Address comptroller_, Algorand.Address interestRateModel_, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 initialExchangeRateMantissa_, string name_, string symbol_, ulong decimals_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 190, 123, 1 };
            var underlying_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); underlying_Abi.From(underlying_);
            var comptroller_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); comptroller_Abi.From(comptroller_);
            var interestRateModel_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); interestRateModel_Abi.From(interestRateModel_);
            var name_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); name_Abi.From(name_);
            var symbol_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbol_Abi.From(symbol_);
            var decimals_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); decimals_Abi.From(decimals_);

            var result = await base.CallApp(new List<object> { abiHandle, underlying_Abi, comptroller_Abi, interestRateModel_Abi, initialExchangeRateMantissa_, name_Abi, symbol_Abi, decimals_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(Algorand.Address underlying_, Algorand.Address comptroller_, Algorand.Address interestRateModel_, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 initialExchangeRateMantissa_, string name_, string symbol_, ulong decimals_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 190, 123, 1 };
            var underlying_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); underlying_Abi.From(underlying_);
            var comptroller_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); comptroller_Abi.From(comptroller_);
            var interestRateModel_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); interestRateModel_Abi.From(interestRateModel_);
            var name_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); name_Abi.From(name_);
            var symbol_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbol_Abi.From(symbol_);
            var decimals_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); decimals_Abi.From(decimals_);

            return await base.MakeTransactionList(new List<object> { abiHandle, underlying_Abi, comptroller_Abi, interestRateModel_Abi, initialExchangeRateMantissa_, name_Abi, symbol_Abi, decimals_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Sender supplies assets into the market and receives cTokens in exchange
        /// @dev Accrues interest whether or not the operation succeeds, unless reverted
        /// @param mintAmount The amount of the underlying asset to supply
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="mintAmount"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Mint(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 mintAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 197, 180, 132 };

            var result = await base.CallApp(new List<object> { abiHandle, mintAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Mint_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 mintAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 197, 180, 132 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mintAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Sender redeems cTokens in exchange for the underlying asset
        /// @dev Accrues interest whether or not the operation succeeds, unless reverted
        /// @param redeemTokens The number of cTokens to redeem into underlying
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="redeemTokens"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Redeem(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 redeemTokens, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 172, 143, 60 };

            var result = await base.CallApp(new List<object> { abiHandle, redeemTokens }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Redeem_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 redeemTokens, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 172, 143, 60 };

            return await base.MakeTransactionList(new List<object> { abiHandle, redeemTokens }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Sender redeems cTokens in exchange for a specified amount of underlying asset
        /// @dev Accrues interest whether or not the operation succeeds, unless reverted
        /// @param redeemAmount The amount of underlying to redeem
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="redeemAmount"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> RedeemUnderlying(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 redeemAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 12, 190, 51 };

            var result = await base.CallApp(new List<object> { abiHandle, redeemAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> RedeemUnderlying_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 redeemAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 12, 190, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle, redeemAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Sender borrows assets from the protocol to their own address
        /// @param borrowAmount The amount of the underlying asset to borrow
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="borrowAmount"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Borrow(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 borrowAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 3, 86, 91 };

            var result = await base.CallApp(new List<object> { abiHandle, borrowAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Borrow_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 borrowAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 3, 86, 91 };

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Sender repays their own borrow
        /// @param repayAmount The amount to repay, or -1 for the full outstanding amount
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="repayAmount"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> RepayBorrow(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 repayAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 211, 135, 255 };

            var result = await base.CallApp(new List<object> { abiHandle, repayAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> RepayBorrow_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 repayAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 211, 135, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle, repayAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Sender repays a borrow belonging to borrower
        /// @param borrower the account with the debt being payed off
        /// @param repayAmount The amount to repay, or -1 for the full outstanding amount
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="borrower"> </param>
        /// <param name="repayAmount"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> RepayBorrowBehalf(Algorand.Address borrower, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 repayAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 151, 17, 254 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            var result = await base.CallApp(new List<object> { abiHandle, borrowerAbi, repayAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> RepayBorrowBehalf_Transactions(Algorand.Address borrower, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 repayAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 151, 17, 254 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi, repayAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice The sender liquidates the borrowers collateral.
        ///  The collateral seized is transferred to the liquidator.
        /// @param borrower The borrower of this cToken to be liquidated
        /// @param repayAmount The amount of the underlying borrowed asset to repay
        /// @param cTokenCollateral The market in which to seize collateral from the borrower
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="borrower"> </param>
        /// <param name="repayAmount"> </param>
        /// <param name="cTokenCollateral"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> LiquidateBorrow(Algorand.Address borrower, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 repayAmount, Algorand.Address cTokenCollateral, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 150, 203, 195 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var cTokenCollateralAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cTokenCollateralAbi.From(cTokenCollateral);

            var result = await base.CallApp(new List<object> { abiHandle, borrowerAbi, repayAmount, cTokenCollateralAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> LiquidateBorrow_Transactions(Algorand.Address borrower, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 repayAmount, Algorand.Address cTokenCollateral, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 150, 203, 195 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var cTokenCollateralAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cTokenCollateralAbi.From(cTokenCollateral);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi, repayAmount, cTokenCollateralAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice A public function to sweep accidental ERC-20 transfers to this contract. Tokens are sent to admin (timelock)
        /// @param token The address of the ERC-20 token to sweep
        ///</summary>
        /// <param name="token"> </param>
        public async Task SweepToken(Algorand.Address token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 202, 248, 79 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);

            var result = await base.CallApp(new List<object> { abiHandle, tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SweepToken_Transactions(Algorand.Address token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 202, 248, 79 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice The sender adds to reserves.
        /// @param addAmount The amount fo underlying token to add as reserves
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="addAmount"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> AddReserves(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 addAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 187, 194, 81 };

            var result = await base.CallApp(new List<object> { abiHandle, addAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> AddReserves_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 addAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 187, 194, 81 };

            return await base.MakeTransactionList(new List<object> { abiHandle, addAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Admin call to delegate the votes of the COMP-like underlying
        /// @param compLikeDelegatee The address to delegate votes to
        /// @dev CTokens whose underlying are not CompLike should revert here
        ///</summary>
        /// <param name="compLikeDelegatee"> </param>
        public async Task DelegateCompLikeTo(Algorand.Address compLikeDelegatee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 158, 204, 126 };
            var compLikeDelegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); compLikeDelegateeAbi.From(compLikeDelegatee);

            var result = await base.CallApp(new List<object> { abiHandle, compLikeDelegateeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DelegateCompLikeTo_Transactions(Algorand.Address compLikeDelegatee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 158, 204, 126 };
            var compLikeDelegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); compLikeDelegateeAbi.From(compLikeDelegatee);

            return await base.MakeTransactionList(new List<object> { abiHandle, compLikeDelegateeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Initialize the money market
        /// @param comptroller_ The address of the Comptroller
        /// @param interestRateModel_ The address of the interest rate model
        /// @param initialExchangeRateMantissa_ The initial exchange rate, scaled by 1e18
        /// @param name_ EIP-20 name of this token
        /// @param symbol_ EIP-20 symbol of this token
        /// @param decimals_ EIP-20 decimal precision of this token
        ///</summary>
        /// <param name="comptroller_"> </param>
        /// <param name="interestRateModel_"> </param>
        /// <param name="initialExchangeRateMantissa_"> </param>
        /// <param name="name_"> </param>
        /// <param name="symbol_"> </param>
        /// <param name="decimals_"> </param>
        public async Task Initialize(Algorand.Address comptroller_, Algorand.Address interestRateModel_, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 initialExchangeRateMantissa_, string name_, string symbol_, ulong decimals_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 218, 165, 189 };
            var comptroller_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); comptroller_Abi.From(comptroller_);
            var interestRateModel_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); interestRateModel_Abi.From(interestRateModel_);
            var name_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); name_Abi.From(name_);
            var symbol_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbol_Abi.From(symbol_);
            var decimals_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); decimals_Abi.From(decimals_);

            var result = await base.CallApp(new List<object> { abiHandle, comptroller_Abi, interestRateModel_Abi, initialExchangeRateMantissa_, name_Abi, symbol_Abi, decimals_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(Algorand.Address comptroller_, Algorand.Address interestRateModel_, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 initialExchangeRateMantissa_, string name_, string symbol_, ulong decimals_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 218, 165, 189 };
            var comptroller_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); comptroller_Abi.From(comptroller_);
            var interestRateModel_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); interestRateModel_Abi.From(interestRateModel_);
            var name_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); name_Abi.From(name_);
            var symbol_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbol_Abi.From(symbol_);
            var decimals_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); decimals_Abi.From(decimals_);

            return await base.MakeTransactionList(new List<object> { abiHandle, comptroller_Abi, interestRateModel_Abi, initialExchangeRateMantissa_, name_Abi, symbol_Abi, decimals_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Transfer `amount` tokens from `msg.sender` to `dst`
        /// @param dst The address of the destination account
        /// @param amount The number of tokens to transfer
        /// @return Whether or not the transfer succeeded
        ///</summary>
        /// <param name="dst"> </param>
        /// <param name="amount"> </param>
        public async Task<bool> Transfer(Algorand.Address dst, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 140, 152, 32 };
            var dstAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); dstAbi.From(dst);

            var result = await base.CallApp(new List<object> { abiHandle, dstAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Transfer_Transactions(Algorand.Address dst, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 140, 152, 32 };
            var dstAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); dstAbi.From(dst);

            return await base.MakeTransactionList(new List<object> { abiHandle, dstAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Transfer `amount` tokens from `src` to `dst`
        /// @param src The address of the source account
        /// @param dst The address of the destination account
        /// @param amount The number of tokens to transfer
        /// @return Whether or not the transfer succeeded
        ///</summary>
        /// <param name="src"> </param>
        /// <param name="dst"> </param>
        /// <param name="amount"> </param>
        public async Task<bool> TransferFrom(Algorand.Address src, Algorand.Address dst, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 244, 31, 109 };
            var srcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); srcAbi.From(src);
            var dstAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); dstAbi.From(dst);

            var result = await base.CallApp(new List<object> { abiHandle, srcAbi, dstAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TransferFrom_Transactions(Algorand.Address src, Algorand.Address dst, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 244, 31, 109 };
            var srcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); srcAbi.From(src);
            var dstAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); dstAbi.From(dst);

            return await base.MakeTransactionList(new List<object> { abiHandle, srcAbi, dstAbi, amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Approve `spender` to transfer up to `amount` from `src`
        /// @dev This will overwrite the approval amount for `spender`
        ///  and is subject to issues noted [here](https://eips.ethereum.org/EIPS/eip-20#approve)
        /// @param spender The address of the account which may transfer tokens
        /// @param amount The number of tokens that are approved (uint256.max means infinite)
        /// @return Whether or not the approval succeeded
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
        /// @notice Get the current allowance from `owner` for `spender`
        /// @param owner The address of the account which owns the tokens to be spent
        /// @param spender The address of the account which may transfer tokens
        /// @return The number of tokens allowed to be spent (-1 means infinite)
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
        /// @notice Get the token balance of the `owner`
        /// @param owner The address of the account to query
        /// @return The number of tokens owned by `owner`
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BalanceOf(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 186, 215, 204 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BalanceOf_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 186, 215, 204 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Get the underlying balance of the `owner`
        /// @dev This also accrues interest in a transaction
        /// @param owner The address of the account to query
        /// @return The amount of underlying owned by `owner`
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BalanceOfUnderlying(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 3, 98, 121 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BalanceOfUnderlying_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 3, 98, 121 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Get a snapshot of the account's balances, and the cached exchange rate
        /// @dev This is used by comptroller to more efficiently perform liquidity checks.
        /// @param account Address of the account to snapshot
        /// @return (possible error, token balance, borrow balance, exchange rate mantissa)
        ///</summary>
        /// <param name="account"> </param>
        public async Task<Structs.GetAccountSnapshotReturn> GetAccountSnapshot(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 239, 171, 68 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetAccountSnapshotReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAccountSnapshot_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 239, 171, 68 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Returns the current per-block borrow interest rate for this cToken
        /// @return The borrow interest rate per block, scaled by 1e18
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BorrowRatePerBlock(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 159, 225, 161 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BorrowRatePerBlock_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 159, 225, 161 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Returns the current per-block supply interest rate for this cToken
        /// @return The supply interest rate per block, scaled by 1e18
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> SupplyRatePerBlock(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 147, 217, 29 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> SupplyRatePerBlock_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 147, 217, 29 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Returns the current total borrows plus accrued interest
        /// @return The total borrows with interest
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> TotalBorrowsCurrent(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 212, 153, 100 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TotalBorrowsCurrent_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 212, 153, 100 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Accrue interest to updated borrowIndex and then calculate account's borrow balance using the updated borrowIndex
        /// @param account The address whose balance should be calculated after updating borrowIndex
        /// @return The calculated balance
        ///</summary>
        /// <param name="account"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BorrowBalanceCurrent(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 231, 236, 254 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BorrowBalanceCurrent_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 231, 236, 254 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Return the borrow balance of account based on stored data
        /// @param account The address whose balance should be calculated
        /// @return The calculated balance
        ///</summary>
        /// <param name="account"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BorrowBalanceStored(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 200, 52, 255 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BorrowBalanceStored_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 200, 52, 255 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Accrue interest then return the up-to-date exchange rate
        /// @return Calculated exchange rate scaled by 1e18
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ExchangeRateCurrent(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 245, 6, 213 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ExchangeRateCurrent_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 245, 6, 213 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Calculates the exchange rate from the underlying to the CToken
        /// @dev This function does not accrue interest before calculating the exchange rate
        /// @return Calculated exchange rate scaled by 1e18
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ExchangeRateStored(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 30, 138, 87 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ExchangeRateStored_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 30, 138, 87 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Get cash balance of this cToken in the underlying asset
        /// @return The quantity of underlying asset owned by this contract
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetCash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 117, 249, 114 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetCash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 117, 249, 114 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Applies accrued interest to total borrows and reserves
        /// @dev This calculates interest accrued from the last checkpointed block
        ///   up to the current block and writes new checkpoint to storage.
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> AccrueInterest(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 187, 81, 178 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> AccrueInterest_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 187, 81, 178 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Transfers collateral tokens (this market) to the liquidator.
        /// @dev Will fail unless called by another cToken during the process of liquidation.
        ///  Its absolutely critical to use msg.sender as the borrowed cToken and not a parameter.
        /// @param liquidator The account receiving seized collateral
        /// @param borrower The account having collateral seized
        /// @param seizeTokens The number of cTokens to seize
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="liquidator"> </param>
        /// <param name="borrower"> </param>
        /// <param name="seizeTokens"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Seize(Algorand.Address liquidator, Algorand.Address borrower, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 seizeTokens, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 66, 92, 124 };
            var liquidatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); liquidatorAbi.From(liquidator);
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            var result = await base.CallApp(new List<object> { abiHandle, liquidatorAbi, borrowerAbi, seizeTokens }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Seize_Transactions(Algorand.Address liquidator, Algorand.Address borrower, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 seizeTokens, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 66, 92, 124 };
            var liquidatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); liquidatorAbi.From(liquidator);
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            return await base.MakeTransactionList(new List<object> { abiHandle, liquidatorAbi, borrowerAbi, seizeTokens }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Begins transfer of admin rights. The newPendingAdmin must call `_acceptAdmin` to finalize the transfer.
        /// @dev Admin function to begin change of admin. The newPendingAdmin must call `_acceptAdmin` to finalize the transfer.
        /// @param newPendingAdmin New pending admin.
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="newPendingAdmin"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> SetPendingAdmin(Algorand.Address newPendingAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 243, 94, 11 };
            var newPendingAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newPendingAdminAbi.From(newPendingAdmin);

            var result = await base.CallApp(new List<object> { abiHandle, newPendingAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> SetPendingAdmin_Transactions(Algorand.Address newPendingAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 243, 94, 11 };
            var newPendingAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newPendingAdminAbi.From(newPendingAdmin);

            return await base.MakeTransactionList(new List<object> { abiHandle, newPendingAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Accepts transfer of admin rights. msg.sender must be pendingAdmin
        /// @dev Admin function for pending admin to accept role and update admin
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> AcceptAdmin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 205, 137, 84 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> AcceptAdmin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 205, 137, 84 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Sets a new comptroller for the market
        /// @dev Admin function to set a new comptroller
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="newComptroller"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> SetComptroller(Algorand.Address newComptroller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 86, 214, 65 };
            var newComptrollerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newComptrollerAbi.From(newComptroller);

            var result = await base.CallApp(new List<object> { abiHandle, newComptrollerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> SetComptroller_Transactions(Algorand.Address newComptroller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 86, 214, 65 };
            var newComptrollerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newComptrollerAbi.From(newComptroller);

            return await base.MakeTransactionList(new List<object> { abiHandle, newComptrollerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice accrues interest and sets a new reserve factor for the protocol using _setReserveFactorFresh
        /// @dev Admin function to accrue interest and set a new reserve factor
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="newReserveFactorMantissa"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> SetReserveFactor(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 newReserveFactorMantissa, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 180, 212, 110 };

            var result = await base.CallApp(new List<object> { abiHandle, newReserveFactorMantissa }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> SetReserveFactor_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 newReserveFactorMantissa, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 180, 212, 110 };

            return await base.MakeTransactionList(new List<object> { abiHandle, newReserveFactorMantissa }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Accrues interest and reduces reserves by transferring to admin
        /// @param reduceAmount Amount of reduction to reserves
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="reduceAmount"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ReduceReserves(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 reduceAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 147, 171, 130 };

            var result = await base.CallApp(new List<object> { abiHandle, reduceAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ReduceReserves_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 reduceAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 147, 171, 130 };

            return await base.MakeTransactionList(new List<object> { abiHandle, reduceAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice accrues interest and updates the interest rate model using _setInterestRateModelFresh
        /// @dev Admin function to accrue interest and update the interest rate model
        /// @param newInterestRateModel the new interest rate model to use
        /// @return uint 0=success, otherwise a failure (see ErrorReporter.sol for details)
        ///</summary>
        /// <param name="newInterestRateModel"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> SetInterestRateModel(Algorand.Address newInterestRateModel, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 192, 135, 248 };
            var newInterestRateModelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newInterestRateModelAbi.From(newInterestRateModel);

            var result = await base.CallApp(new List<object> { abiHandle, newInterestRateModelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> SetInterestRateModel_Transactions(Algorand.Address newInterestRateModel, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 192, 135, 248 };
            var newInterestRateModelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newInterestRateModelAbi.From(newInterestRateModel);

            return await base.MakeTransactionList(new List<object> { abiHandle, newInterestRateModelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Underlying(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 195, 193, 239 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Underlying_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 195, 193, 239 };

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
        public async Task<ulong> Decimals(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 119, 158, 231 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Decimals_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 119, 158, 231 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Admin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 79, 182, 179 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Admin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 79, 182, 179 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> PendingAdmin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 152, 205, 3 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> PendingAdmin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 152, 205, 3 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Comptroller(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 154, 16, 11 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Comptroller_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 154, 16, 11 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> InterestRateModel(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 90, 9, 196 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> InterestRateModel_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 90, 9, 196 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ReserveFactorMantissa(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 51, 179, 231 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ReserveFactorMantissa_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 51, 179, 231 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> AccrualBlockNumber(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 36, 51, 239 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> AccrualBlockNumber_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 36, 51, 239 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BorrowIndex(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 167, 81, 175 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BorrowIndex_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 167, 81, 175 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> TotalBorrows(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 116, 56, 79 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TotalBorrows_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 116, 56, 79 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> TotalReserves(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 108, 60, 210 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TotalReserves_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 108, 60, 210 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ0VyYzIwSW1tdXRhYmxlIiwiZGVzYyI6IiBAdGl0bGUgQ29tcG91bmQncyBDRXJjMjBJbW11dGFibGUgQ29udHJhY3RcbiBAbm90aWNlIENUb2tlbnMgd2hpY2ggd3JhcCBhbiBFSVAtMjAgdW5kZXJseWluZyBhbmQgYXJlIGltbXV0YWJsZVxuIEBhdXRob3IgQ29tcG91bmQiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQm9ycm93U25hcHNob3QiOlt7Im5hbWUiOiJwcmluY2lwYWwiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImludGVyZXN0SW5kZXgiLCJ0eXBlIjoidWludDI1NiJ9XSwiR2V0QWNjb3VudFNuYXBzaG90UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOiIgQG5vdGljZSBJbml0aWFsaXplIHRoZSBuZXcgbW9uZXkgbWFya2V0XG4gQHBhcmFtIHVuZGVybHlpbmdfIFRoZSBhZGRyZXNzIG9mIHRoZSB1bmRlcmx5aW5nIGFzc2V0XG4gQHBhcmFtIGNvbXB0cm9sbGVyXyBUaGUgYWRkcmVzcyBvZiB0aGUgQ29tcHRyb2xsZXJcbiBAcGFyYW0gaW50ZXJlc3RSYXRlTW9kZWxfIFRoZSBhZGRyZXNzIG9mIHRoZSBpbnRlcmVzdCByYXRlIG1vZGVsXG4gQHBhcmFtIGluaXRpYWxFeGNoYW5nZVJhdGVNYW50aXNzYV8gVGhlIGluaXRpYWwgZXhjaGFuZ2UgcmF0ZSwgc2NhbGVkIGJ5IDFlMThcbiBAcGFyYW0gbmFtZV8gRVJDLTIwIG5hbWUgb2YgdGhpcyB0b2tlblxuIEBwYXJhbSBzeW1ib2xfIEVSQy0yMCBzeW1ib2wgb2YgdGhpcyB0b2tlblxuIEBwYXJhbSBkZWNpbWFsc18gRVJDLTIwIGRlY2ltYWwgcHJlY2lzaW9uIG9mIHRoaXMgdG9rZW4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuZGVybHlpbmdfIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tcHRyb2xsZXJfIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJlc3RSYXRlTW9kZWxfIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbEV4Y2hhbmdlUmF0ZU1hbnRpc3NhXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZV8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbF8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlY2ltYWxzXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTmV3Q29tcHRyb2xsZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkQ29tcHRyb2xsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDb21wdHJvbGxlciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTmV3TWFya2V0SW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkSW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnQiLCJkZXNjIjoiIEBub3RpY2UgU2VuZGVyIHN1cHBsaWVzIGFzc2V0cyBpbnRvIHRoZSBtYXJrZXQgYW5kIHJlY2VpdmVzIGNUb2tlbnMgaW4gZXhjaGFuZ2VcbiBAZGV2IEFjY3J1ZXMgaW50ZXJlc3Qgd2hldGhlciBvciBub3QgdGhlIG9wZXJhdGlvbiBzdWNjZWVkcywgdW5sZXNzIHJldmVydGVkXG4gQHBhcmFtIG1pbnRBbW91bnQgVGhlIGFtb3VudCBvZiB0aGUgdW5kZXJseWluZyBhc3NldCB0byBzdXBwbHlcbiBAcmV0dXJuIHVpbnQgMD1zdWNjZXNzLCBvdGhlcndpc2UgYSBmYWlsdXJlIChzZWUgRXJyb3JSZXBvcnRlci5zb2wgZm9yIGRldGFpbHMpIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW50QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJNaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbnRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW50QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbnRUb2tlbnMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlZW0iLCJkZXNjIjoiIEBub3RpY2UgU2VuZGVyIHJlZGVlbXMgY1Rva2VucyBpbiBleGNoYW5nZSBmb3IgdGhlIHVuZGVybHlpbmcgYXNzZXRcbiBAZGV2IEFjY3J1ZXMgaW50ZXJlc3Qgd2hldGhlciBvciBub3QgdGhlIG9wZXJhdGlvbiBzdWNjZWVkcywgdW5sZXNzIHJldmVydGVkXG4gQHBhcmFtIHJlZGVlbVRva2VucyBUaGUgbnVtYmVyIG9mIGNUb2tlbnMgdG8gcmVkZWVtIGludG8gdW5kZXJseWluZ1xuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbVRva2VucyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRlZW1Ub2tlbnMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlZW1VbmRlcmx5aW5nIiwiZGVzYyI6IiBAbm90aWNlIFNlbmRlciByZWRlZW1zIGNUb2tlbnMgaW4gZXhjaGFuZ2UgZm9yIGEgc3BlY2lmaWVkIGFtb3VudCBvZiB1bmRlcmx5aW5nIGFzc2V0XG4gQGRldiBBY2NydWVzIGludGVyZXN0IHdoZXRoZXIgb3Igbm90IHRoZSBvcGVyYXRpb24gc3VjY2VlZHMsIHVubGVzcyByZXZlcnRlZFxuIEBwYXJhbSByZWRlZW1BbW91bnQgVGhlIGFtb3VudCBvZiB1bmRlcmx5aW5nIHRvIHJlZGVlbVxuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbUFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRlZW1Ub2tlbnMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3Jyb3ciLCJkZXNjIjoiIEBub3RpY2UgU2VuZGVyIGJvcnJvd3MgYXNzZXRzIGZyb20gdGhlIHByb3RvY29sIHRvIHRoZWlyIG93biBhZGRyZXNzXG4gQHBhcmFtIGJvcnJvd0Ftb3VudCBUaGUgYW1vdW50IG9mIHRoZSB1bmRlcmx5aW5nIGFzc2V0IHRvIGJvcnJvd1xuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQm9ycm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0Ftb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50Qm9ycm93cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbEJvcnJvd3MiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXBheUJvcnJvdyIsImRlc2MiOiIgQG5vdGljZSBTZW5kZXIgcmVwYXlzIHRoZWlyIG93biBib3Jyb3dcbiBAcGFyYW0gcmVwYXlBbW91bnQgVGhlIGFtb3VudCB0byByZXBheSwgb3IgLTEgZm9yIHRoZSBmdWxsIG91dHN0YW5kaW5nIGFtb3VudFxuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSZXBheUJvcnJvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRCb3Jyb3dzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcGF5Qm9ycm93QmVoYWxmIiwiZGVzYyI6IiBAbm90aWNlIFNlbmRlciByZXBheXMgYSBib3Jyb3cgYmVsb25naW5nIHRvIGJvcnJvd2VyXG4gQHBhcmFtIGJvcnJvd2VyIHRoZSBhY2NvdW50IHdpdGggdGhlIGRlYnQgYmVpbmcgcGF5ZWQgb2ZmXG4gQHBhcmFtIHJlcGF5QW1vdW50IFRoZSBhbW91bnQgdG8gcmVwYXksIG9yIC0xIGZvciB0aGUgZnVsbCBvdXRzdGFuZGluZyBhbW91bnRcbiBAcmV0dXJuIHVpbnQgMD1zdWNjZXNzLCBvdGhlcndpc2UgYSBmYWlsdXJlIChzZWUgRXJyb3JSZXBvcnRlci5zb2wgZm9yIGRldGFpbHMpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSZXBheUJvcnJvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRCb3Jyb3dzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxpcXVpZGF0ZUJvcnJvdyIsImRlc2MiOiIgQG5vdGljZSBUaGUgc2VuZGVyIGxpcXVpZGF0ZXMgdGhlIGJvcnJvd2VycyBjb2xsYXRlcmFsLlxuICBUaGUgY29sbGF0ZXJhbCBzZWl6ZWQgaXMgdHJhbnNmZXJyZWQgdG8gdGhlIGxpcXVpZGF0b3IuXG4gQHBhcmFtIGJvcnJvd2VyIFRoZSBib3Jyb3dlciBvZiB0aGlzIGNUb2tlbiB0byBiZSBsaXF1aWRhdGVkXG4gQHBhcmFtIHJlcGF5QW1vdW50IFRoZSBhbW91bnQgb2YgdGhlIHVuZGVybHlpbmcgYm9ycm93ZWQgYXNzZXQgdG8gcmVwYXlcbiBAcGFyYW0gY1Rva2VuQ29sbGF0ZXJhbCBUaGUgbWFya2V0IGluIHdoaWNoIHRvIHNlaXplIGNvbGxhdGVyYWwgZnJvbSB0aGUgYm9ycm93ZXJcbiBAcmV0dXJuIHVpbnQgMD1zdWNjZXNzLCBvdGhlcndpc2UgYSBmYWlsdXJlIChzZWUgRXJyb3JSZXBvcnRlci5zb2wgZm9yIGRldGFpbHMpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY1Rva2VuQ29sbGF0ZXJhbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVwYXlCb3Jyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBheUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50Qm9ycm93cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbEJvcnJvd3MiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlc2VydmVzQWRkZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmVuZWZhY3RvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRBbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VG90YWxSZXNlcnZlcyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTGlxdWlkYXRlQm9ycm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpcXVpZGF0b3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBheUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNUb2tlbkNvbGxhdGVyYWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VpemVUb2tlbnMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzd2VlcFRva2VuIiwiZGVzYyI6IiBAbm90aWNlIEEgcHVibGljIGZ1bmN0aW9uIHRvIHN3ZWVwIGFjY2lkZW50YWwgRVJDLTIwIHRyYW5zZmVycyB0byB0aGlzIGNvbnRyYWN0LiBUb2tlbnMgYXJlIHNlbnQgdG8gYWRtaW4gKHRpbWVsb2NrKVxuIEBwYXJhbSB0b2tlbiBUaGUgYWRkcmVzcyBvZiB0aGUgRVJDLTIwIHRva2VuIHRvIHN3ZWVwIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfYWRkUmVzZXJ2ZXMiLCJkZXNjIjoiIEBub3RpY2UgVGhlIHNlbmRlciBhZGRzIHRvIHJlc2VydmVzLlxuIEBwYXJhbSBhZGRBbW91bnQgVGhlIGFtb3VudCBmbyB1bmRlcmx5aW5nIHRva2VuIHRvIGFkZCBhcyByZXNlcnZlc1xuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZEFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVzZXJ2ZXNBZGRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiZW5lZmFjdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZEFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdUb3RhbFJlc2VydmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX2RlbGVnYXRlQ29tcExpa2VUbyIsImRlc2MiOiIgQG5vdGljZSBBZG1pbiBjYWxsIHRvIGRlbGVnYXRlIHRoZSB2b3RlcyBvZiB0aGUgQ09NUC1saWtlIHVuZGVybHlpbmdcbiBAcGFyYW0gY29tcExpa2VEZWxlZ2F0ZWUgVGhlIGFkZHJlc3MgdG8gZGVsZWdhdGUgdm90ZXMgdG9cbiBAZGV2IENUb2tlbnMgd2hvc2UgdW5kZXJseWluZyBhcmUgbm90IENvbXBMaWtlIHNob3VsZCByZXZlcnQgaGVyZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tcExpa2VEZWxlZ2F0ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOiIgQG5vdGljZSBJbml0aWFsaXplIHRoZSBtb25leSBtYXJrZXRcbiBAcGFyYW0gY29tcHRyb2xsZXJfIFRoZSBhZGRyZXNzIG9mIHRoZSBDb21wdHJvbGxlclxuIEBwYXJhbSBpbnRlcmVzdFJhdGVNb2RlbF8gVGhlIGFkZHJlc3Mgb2YgdGhlIGludGVyZXN0IHJhdGUgbW9kZWxcbiBAcGFyYW0gaW5pdGlhbEV4Y2hhbmdlUmF0ZU1hbnRpc3NhXyBUaGUgaW5pdGlhbCBleGNoYW5nZSByYXRlLCBzY2FsZWQgYnkgMWUxOFxuIEBwYXJhbSBuYW1lXyBFSVAtMjAgbmFtZSBvZiB0aGlzIHRva2VuXG4gQHBhcmFtIHN5bWJvbF8gRUlQLTIwIHN5bWJvbCBvZiB0aGlzIHRva2VuXG4gQHBhcmFtIGRlY2ltYWxzXyBFSVAtMjAgZGVjaW1hbCBwcmVjaXNpb24gb2YgdGhpcyB0b2tlbiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tcHRyb2xsZXJfIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJlc3RSYXRlTW9kZWxfIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbEV4Y2hhbmdlUmF0ZU1hbnRpc3NhXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZV8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbF8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlY2ltYWxzXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTmV3Q29tcHRyb2xsZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkQ29tcHRyb2xsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDb21wdHJvbGxlciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTmV3TWFya2V0SW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkSW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyIiwiZGVzYyI6IiBAbm90aWNlIFRyYW5zZmVyIGBhbW91bnRgIHRva2VucyBmcm9tIGBtc2cuc2VuZGVyYCB0byBgZHN0YFxuIEBwYXJhbSBkc3QgVGhlIGFkZHJlc3Mgb2YgdGhlIGRlc3RpbmF0aW9uIGFjY291bnRcbiBAcGFyYW0gYW1vdW50IFRoZSBudW1iZXIgb2YgdG9rZW5zIHRvIHRyYW5zZmVyXG4gQHJldHVybiBXaGV0aGVyIG9yIG5vdCB0aGUgdHJhbnNmZXIgc3VjY2VlZGVkIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkc3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlckZyb20iLCJkZXNjIjoiIEBub3RpY2UgVHJhbnNmZXIgYGFtb3VudGAgdG9rZW5zIGZyb20gYHNyY2AgdG8gYGRzdGBcbiBAcGFyYW0gc3JjIFRoZSBhZGRyZXNzIG9mIHRoZSBzb3VyY2UgYWNjb3VudFxuIEBwYXJhbSBkc3QgVGhlIGFkZHJlc3Mgb2YgdGhlIGRlc3RpbmF0aW9uIGFjY291bnRcbiBAcGFyYW0gYW1vdW50IFRoZSBudW1iZXIgb2YgdG9rZW5zIHRvIHRyYW5zZmVyXG4gQHJldHVybiBXaGV0aGVyIG9yIG5vdCB0aGUgdHJhbnNmZXIgc3VjY2VlZGVkIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcmMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkc3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlIiwiZGVzYyI6IiBAbm90aWNlIEFwcHJvdmUgYHNwZW5kZXJgIHRvIHRyYW5zZmVyIHVwIHRvIGBhbW91bnRgIGZyb20gYHNyY2BcbiBAZGV2IFRoaXMgd2lsbCBvdmVyd3JpdGUgdGhlIGFwcHJvdmFsIGFtb3VudCBmb3IgYHNwZW5kZXJgXG4gIGFuZCBpcyBzdWJqZWN0IHRvIGlzc3VlcyBub3RlZCBbaGVyZV0oaHR0cHM6Ly9laXBzLmV0aGVyZXVtLm9yZy9FSVBTL2VpcC0yMCNhcHByb3ZlKVxuIEBwYXJhbSBzcGVuZGVyIFRoZSBhZGRyZXNzIG9mIHRoZSBhY2NvdW50IHdoaWNoIG1heSB0cmFuc2ZlciB0b2tlbnNcbiBAcGFyYW0gYW1vdW50IFRoZSBudW1iZXIgb2YgdG9rZW5zIHRoYXQgYXJlIGFwcHJvdmVkICh1aW50MjU2Lm1heCBtZWFucyBpbmZpbml0ZSlcbiBAcmV0dXJuIFdoZXRoZXIgb3Igbm90IHRoZSBhcHByb3ZhbCBzdWNjZWVkZWQiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhbGxvd2FuY2UiLCJkZXNjIjoiIEBub3RpY2UgR2V0IHRoZSBjdXJyZW50IGFsbG93YW5jZSBmcm9tIGBvd25lcmAgZm9yIGBzcGVuZGVyYFxuIEBwYXJhbSBvd25lciBUaGUgYWRkcmVzcyBvZiB0aGUgYWNjb3VudCB3aGljaCBvd25zIHRoZSB0b2tlbnMgdG8gYmUgc3BlbnRcbiBAcGFyYW0gc3BlbmRlciBUaGUgYWRkcmVzcyBvZiB0aGUgYWNjb3VudCB3aGljaCBtYXkgdHJhbnNmZXIgdG9rZW5zXG4gQHJldHVybiBUaGUgbnVtYmVyIG9mIHRva2VucyBhbGxvd2VkIHRvIGJlIHNwZW50ICgtMSBtZWFucyBpbmZpbml0ZSkiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJhbGFuY2VPZiIsImRlc2MiOiIgQG5vdGljZSBHZXQgdGhlIHRva2VuIGJhbGFuY2Ugb2YgdGhlIGBvd25lcmBcbiBAcGFyYW0gb3duZXIgVGhlIGFkZHJlc3Mgb2YgdGhlIGFjY291bnQgdG8gcXVlcnlcbiBAcmV0dXJuIFRoZSBudW1iZXIgb2YgdG9rZW5zIG93bmVkIGJ5IGBvd25lcmAiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFsYW5jZU9mVW5kZXJseWluZyIsImRlc2MiOiIgQG5vdGljZSBHZXQgdGhlIHVuZGVybHlpbmcgYmFsYW5jZSBvZiB0aGUgYG93bmVyYFxuIEBkZXYgVGhpcyBhbHNvIGFjY3J1ZXMgaW50ZXJlc3QgaW4gYSB0cmFuc2FjdGlvblxuIEBwYXJhbSBvd25lciBUaGUgYWRkcmVzcyBvZiB0aGUgYWNjb3VudCB0byBxdWVyeVxuIEByZXR1cm4gVGhlIGFtb3VudCBvZiB1bmRlcmx5aW5nIG93bmVkIGJ5IGBvd25lcmAiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWNjb3VudFNuYXBzaG90IiwiZGVzYyI6IiBAbm90aWNlIEdldCBhIHNuYXBzaG90IG9mIHRoZSBhY2NvdW50J3MgYmFsYW5jZXMsIGFuZCB0aGUgY2FjaGVkIGV4Y2hhbmdlIHJhdGVcbiBAZGV2IFRoaXMgaXMgdXNlZCBieSBjb21wdHJvbGxlciB0byBtb3JlIGVmZmljaWVudGx5IHBlcmZvcm0gbGlxdWlkaXR5IGNoZWNrcy5cbiBAcGFyYW0gYWNjb3VudCBBZGRyZXNzIG9mIHRoZSBhY2NvdW50IHRvIHNuYXBzaG90XG4gQHJldHVybiAocG9zc2libGUgZXJyb3IsIHRva2VuIGJhbGFuY2UsIGJvcnJvdyBiYWxhbmNlLCBleGNoYW5nZSByYXRlIG1hbnRpc3NhKSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJHZXRBY2NvdW50U25hcHNob3RSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvcnJvd1JhdGVQZXJCbG9jayIsImRlc2MiOiIgQG5vdGljZSBSZXR1cm5zIHRoZSBjdXJyZW50IHBlci1ibG9jayBib3Jyb3cgaW50ZXJlc3QgcmF0ZSBmb3IgdGhpcyBjVG9rZW5cbiBAcmV0dXJuIFRoZSBib3Jyb3cgaW50ZXJlc3QgcmF0ZSBwZXIgYmxvY2ssIHNjYWxlZCBieSAxZTE4IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VwcGx5UmF0ZVBlckJsb2NrIiwiZGVzYyI6IiBAbm90aWNlIFJldHVybnMgdGhlIGN1cnJlbnQgcGVyLWJsb2NrIHN1cHBseSBpbnRlcmVzdCByYXRlIGZvciB0aGlzIGNUb2tlblxuIEByZXR1cm4gVGhlIHN1cHBseSBpbnRlcmVzdCByYXRlIHBlciBibG9jaywgc2NhbGVkIGJ5IDFlMTgiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b3RhbEJvcnJvd3NDdXJyZW50IiwiZGVzYyI6IiBAbm90aWNlIFJldHVybnMgdGhlIGN1cnJlbnQgdG90YWwgYm9ycm93cyBwbHVzIGFjY3J1ZWQgaW50ZXJlc3RcbiBAcmV0dXJuIFRoZSB0b3RhbCBib3Jyb3dzIHdpdGggaW50ZXJlc3QiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFjY3J1ZUludGVyZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXNoUHJpb3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJlc3RBY2N1bXVsYXRlZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dJbmRleCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbEJvcnJvd3MiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3Jyb3dCYWxhbmNlQ3VycmVudCIsImRlc2MiOiIgQG5vdGljZSBBY2NydWUgaW50ZXJlc3QgdG8gdXBkYXRlZCBib3Jyb3dJbmRleCBhbmQgdGhlbiBjYWxjdWxhdGUgYWNjb3VudCdzIGJvcnJvdyBiYWxhbmNlIHVzaW5nIHRoZSB1cGRhdGVkIGJvcnJvd0luZGV4XG4gQHBhcmFtIGFjY291bnQgVGhlIGFkZHJlc3Mgd2hvc2UgYmFsYW5jZSBzaG91bGQgYmUgY2FsY3VsYXRlZCBhZnRlciB1cGRhdGluZyBib3Jyb3dJbmRleFxuIEByZXR1cm4gVGhlIGNhbGN1bGF0ZWQgYmFsYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvcnJvd0JhbGFuY2VTdG9yZWQiLCJkZXNjIjoiIEBub3RpY2UgUmV0dXJuIHRoZSBib3Jyb3cgYmFsYW5jZSBvZiBhY2NvdW50IGJhc2VkIG9uIHN0b3JlZCBkYXRhXG4gQHBhcmFtIGFjY291bnQgVGhlIGFkZHJlc3Mgd2hvc2UgYmFsYW5jZSBzaG91bGQgYmUgY2FsY3VsYXRlZFxuIEByZXR1cm4gVGhlIGNhbGN1bGF0ZWQgYmFsYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4Y2hhbmdlUmF0ZUN1cnJlbnQiLCJkZXNjIjoiIEBub3RpY2UgQWNjcnVlIGludGVyZXN0IHRoZW4gcmV0dXJuIHRoZSB1cC10by1kYXRlIGV4Y2hhbmdlIHJhdGVcbiBAcmV0dXJuIENhbGN1bGF0ZWQgZXhjaGFuZ2UgcmF0ZSBzY2FsZWQgYnkgMWUxOCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4Y2hhbmdlUmF0ZVN0b3JlZCIsImRlc2MiOiIgQG5vdGljZSBDYWxjdWxhdGVzIHRoZSBleGNoYW5nZSByYXRlIGZyb20gdGhlIHVuZGVybHlpbmcgdG8gdGhlIENUb2tlblxuIEBkZXYgVGhpcyBmdW5jdGlvbiBkb2VzIG5vdCBhY2NydWUgaW50ZXJlc3QgYmVmb3JlIGNhbGN1bGF0aW5nIHRoZSBleGNoYW5nZSByYXRlXG4gQHJldHVybiBDYWxjdWxhdGVkIGV4Y2hhbmdlIHJhdGUgc2NhbGVkIGJ5IDFlMTgiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDYXNoIiwiZGVzYyI6IiBAbm90aWNlIEdldCBjYXNoIGJhbGFuY2Ugb2YgdGhpcyBjVG9rZW4gaW4gdGhlIHVuZGVybHlpbmcgYXNzZXRcbiBAcmV0dXJuIFRoZSBxdWFudGl0eSBvZiB1bmRlcmx5aW5nIGFzc2V0IG93bmVkIGJ5IHRoaXMgY29udHJhY3QiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NydWVJbnRlcmVzdCIsImRlc2MiOiIgQG5vdGljZSBBcHBsaWVzIGFjY3J1ZWQgaW50ZXJlc3QgdG8gdG90YWwgYm9ycm93cyBhbmQgcmVzZXJ2ZXNcbiBAZGV2IFRoaXMgY2FsY3VsYXRlcyBpbnRlcmVzdCBhY2NydWVkIGZyb20gdGhlIGxhc3QgY2hlY2twb2ludGVkIGJsb2NrXG4gICB1cCB0byB0aGUgY3VycmVudCBibG9jayBhbmQgd3JpdGVzIG5ldyBjaGVja3BvaW50IHRvIHN0b3JhZ2UuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2VpemUiLCJkZXNjIjoiIEBub3RpY2UgVHJhbnNmZXJzIGNvbGxhdGVyYWwgdG9rZW5zICh0aGlzIG1hcmtldCkgdG8gdGhlIGxpcXVpZGF0b3IuXG4gQGRldiBXaWxsIGZhaWwgdW5sZXNzIGNhbGxlZCBieSBhbm90aGVyIGNUb2tlbiBkdXJpbmcgdGhlIHByb2Nlc3Mgb2YgbGlxdWlkYXRpb24uXG4gIEl0cyBhYnNvbHV0ZWx5IGNyaXRpY2FsIHRvIHVzZSBtc2cuc2VuZGVyIGFzIHRoZSBib3Jyb3dlZCBjVG9rZW4gYW5kIG5vdCBhIHBhcmFtZXRlci5cbiBAcGFyYW0gbGlxdWlkYXRvciBUaGUgYWNjb3VudCByZWNlaXZpbmcgc2VpemVkIGNvbGxhdGVyYWxcbiBAcGFyYW0gYm9ycm93ZXIgVGhlIGFjY291bnQgaGF2aW5nIGNvbGxhdGVyYWwgc2VpemVkXG4gQHBhcmFtIHNlaXplVG9rZW5zIFRoZSBudW1iZXIgb2YgY1Rva2VucyB0byBzZWl6ZVxuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpcXVpZGF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlaXplVG9rZW5zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSZXNlcnZlc0FkZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJlbmVmYWN0b3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkQW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1RvdGFsUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfc2V0UGVuZGluZ0FkbWluIiwiZGVzYyI6IiBAbm90aWNlIEJlZ2lucyB0cmFuc2ZlciBvZiBhZG1pbiByaWdodHMuIFRoZSBuZXdQZW5kaW5nQWRtaW4gbXVzdCBjYWxsIGBfYWNjZXB0QWRtaW5gIHRvIGZpbmFsaXplIHRoZSB0cmFuc2Zlci5cbiBAZGV2IEFkbWluIGZ1bmN0aW9uIHRvIGJlZ2luIGNoYW5nZSBvZiBhZG1pbi4gVGhlIG5ld1BlbmRpbmdBZG1pbiBtdXN0IGNhbGwgYF9hY2NlcHRBZG1pbmAgdG8gZmluYWxpemUgdGhlIHRyYW5zZmVyLlxuIEBwYXJhbSBuZXdQZW5kaW5nQWRtaW4gTmV3IHBlbmRpbmcgYWRtaW4uXG4gQHJldHVybiB1aW50IDA9c3VjY2Vzcywgb3RoZXJ3aXNlIGEgZmFpbHVyZSAoc2VlIEVycm9yUmVwb3J0ZXIuc29sIGZvciBkZXRhaWxzKSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3UGVuZGluZ0FkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJOZXdQZW5kaW5nQWRtaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkUGVuZGluZ0FkbWluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3UGVuZGluZ0FkbWluIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX2FjY2VwdEFkbWluIiwiZGVzYyI6IiBAbm90aWNlIEFjY2VwdHMgdHJhbnNmZXIgb2YgYWRtaW4gcmlnaHRzLiBtc2cuc2VuZGVyIG11c3QgYmUgcGVuZGluZ0FkbWluXG4gQGRldiBBZG1pbiBmdW5jdGlvbiBmb3IgcGVuZGluZyBhZG1pbiB0byBhY2NlcHQgcm9sZSBhbmQgdXBkYXRlIGFkbWluXG4gQHJldHVybiB1aW50IDA9c3VjY2Vzcywgb3RoZXJ3aXNlIGEgZmFpbHVyZSAoc2VlIEVycm9yUmVwb3J0ZXIuc29sIGZvciBkZXRhaWxzKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTmV3QWRtaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkQWRtaW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBZG1pbiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTmV3UGVuZGluZ0FkbWluIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9sZFBlbmRpbmdBZG1pbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1BlbmRpbmdBZG1pbiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9zZXRDb21wdHJvbGxlciIsImRlc2MiOiIgQG5vdGljZSBTZXRzIGEgbmV3IGNvbXB0cm9sbGVyIGZvciB0aGUgbWFya2V0XG4gQGRldiBBZG1pbiBmdW5jdGlvbiB0byBzZXQgYSBuZXcgY29tcHRyb2xsZXJcbiBAcmV0dXJuIHVpbnQgMD1zdWNjZXNzLCBvdGhlcndpc2UgYSBmYWlsdXJlIChzZWUgRXJyb3JSZXBvcnRlci5zb2wgZm9yIGRldGFpbHMpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDb21wdHJvbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTmV3Q29tcHRyb2xsZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkQ29tcHRyb2xsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDb21wdHJvbGxlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9zZXRSZXNlcnZlRmFjdG9yIiwiZGVzYyI6IiBAbm90aWNlIGFjY3J1ZXMgaW50ZXJlc3QgYW5kIHNldHMgYSBuZXcgcmVzZXJ2ZSBmYWN0b3IgZm9yIHRoZSBwcm90b2NvbCB1c2luZyBfc2V0UmVzZXJ2ZUZhY3RvckZyZXNoXG4gQGRldiBBZG1pbiBmdW5jdGlvbiB0byBhY2NydWUgaW50ZXJlc3QgYW5kIHNldCBhIG5ldyByZXNlcnZlIGZhY3RvclxuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1Jlc2VydmVGYWN0b3JNYW50aXNzYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTmV3UmVzZXJ2ZUZhY3RvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkUmVzZXJ2ZUZhY3Rvck1hbnRpc3NhIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1Jlc2VydmVGYWN0b3JNYW50aXNzYSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9yZWR1Y2VSZXNlcnZlcyIsImRlc2MiOiIgQG5vdGljZSBBY2NydWVzIGludGVyZXN0IGFuZCByZWR1Y2VzIHJlc2VydmVzIGJ5IHRyYW5zZmVycmluZyB0byBhZG1pblxuIEBwYXJhbSByZWR1Y2VBbW91bnQgQW1vdW50IG9mIHJlZHVjdGlvbiB0byByZXNlcnZlc1xuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZHVjZUFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVzZXJ2ZXNSZWR1Y2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZHVjZUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdUb3RhbFJlc2VydmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX3NldEludGVyZXN0UmF0ZU1vZGVsIiwiZGVzYyI6IiBAbm90aWNlIGFjY3J1ZXMgaW50ZXJlc3QgYW5kIHVwZGF0ZXMgdGhlIGludGVyZXN0IHJhdGUgbW9kZWwgdXNpbmcgX3NldEludGVyZXN0UmF0ZU1vZGVsRnJlc2hcbiBAZGV2IEFkbWluIGZ1bmN0aW9uIHRvIGFjY3J1ZSBpbnRlcmVzdCBhbmQgdXBkYXRlIHRoZSBpbnRlcmVzdCByYXRlIG1vZGVsXG4gQHBhcmFtIG5ld0ludGVyZXN0UmF0ZU1vZGVsIHRoZSBuZXcgaW50ZXJlc3QgcmF0ZSBtb2RlbCB0byB1c2VcbiBAcmV0dXJuIHVpbnQgMD1zdWNjZXNzLCBvdGhlcndpc2UgYSBmYWlsdXJlIChzZWUgRXJyb3JSZXBvcnRlci5zb2wgZm9yIGRldGFpbHMpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTmV3TWFya2V0SW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkSW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVuZGVybHlpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzeW1ib2wiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlY2ltYWxzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBlbmRpbmdBZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbXB0cm9sbGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNlcnZlRmFjdG9yTWFudGlzc2EiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NydWFsQmxvY2tOdW1iZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3Jyb3dJbmRleCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvdGFsUmVzZXJ2ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b3RhbFN1cHBseSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MTR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM0MjMsMzQzMF0sImVycm9yTWVzc2FnZSI6IkFjY2VwdEFkbWluUGVuZGluZ0FkbWluQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjg2XSwiZXJyb3JNZXNzYWdlIjoiQWRkUmVzZXJ2ZXNGYWN0b3JGcmVzaENoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxMF0sImVycm9yTWVzc2FnZSI6IkJvcnJvd0Nhc2hOb3RBdmFpbGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDkxXSwiZXJyb3JNZXNzYWdlIjoiQm9ycm93Q29tcHRyb2xsZXJSZWplY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTAyXSwiZXJyb3JNZXNzYWdlIjoiQm9ycm93RnJlc2huZXNzQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTg3XSwiZXJyb3JNZXNzYWdlIjoiQ0VyYzIwOjpzd2VlcFRva2VuOiBjYW4gbm90IHN3ZWVwIHVuZGVybHlpbmcgdG9rZW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTc4XSwiZXJyb3JNZXNzYWdlIjoiQ0VyYzIwOjpzd2VlcFRva2VuOiBvbmx5IGFkbWluIGNhbiBzd2VlcCB0b2tlbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDEzXSwiZXJyb3JNZXNzYWdlIjoiTElRVUlEQVRFX0NPTVBUUk9MTEVSX0NBTENVTEFURV9BTU9VTlRfU0VJWkVfRkFJTEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA0Ml0sImVycm9yTWVzc2FnZSI6IkxJUVVJREFURV9TRUlaRV9UT09fTVVDSCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OTZdLCJlcnJvck1lc3NhZ2UiOiJMaXF1aWRhdGVBY2NydWVDb2xsYXRlcmFsSW50ZXJlc3RGYWlsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTM1XSwiZXJyb3JNZXNzYWdlIjoiTGlxdWlkYXRlQ2xvc2VBbW91bnRJc1VpbnRNYXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTI4XSwiZXJyb3JNZXNzYWdlIjoiTGlxdWlkYXRlQ2xvc2VBbW91bnRJc1plcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTE1XSwiZXJyb3JNZXNzYWdlIjoiTGlxdWlkYXRlQ29sbGF0ZXJhbEZyZXNobmVzc0NoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg3NF0sImVycm9yTWVzc2FnZSI6IkxpcXVpZGF0ZUNvbXB0cm9sbGVyUmVqZWN0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4NV0sImVycm9yTWVzc2FnZSI6IkxpcXVpZGF0ZUZyZXNobmVzc0NoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkyMl0sImVycm9yTWVzc2FnZSI6IkxpcXVpZGF0ZUxpcXVpZGF0b3JJc0JvcnJvd2VyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYxNF0sImVycm9yTWVzc2FnZSI6IkxpcXVpZGF0ZVNlaXplQ29tcHRyb2xsZXJSZWplY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjIxXSwiZXJyb3JNZXNzYWdlIjoiTGlxdWlkYXRlU2VpemVMaXF1aWRhdG9ySXNCb3Jyb3dlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMDZdLCJlcnJvck1lc3NhZ2UiOiJNaW50Q29tcHRyb2xsZXJSZWplY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjE3XSwiZXJyb3JNZXNzYWdlIjoiTWludEZyZXNobmVzc0NoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTEyMl0sImVycm9yTWVzc2FnZSI6IlJlZGVlbUNvbXB0cm9sbGVyUmVqZWN0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTEzM10sImVycm9yTWVzc2FnZSI6IlJlZGVlbUZyZXNobmVzc0NoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE0NF0sImVycm9yTWVzc2FnZSI6IlJlZGVlbVRyYW5zZmVyT3V0Tm90UG9zc2libGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjMwXSwiZXJyb3JNZXNzYWdlIjoiUmVkdWNlUmVzZXJ2ZXNBZG1pbkNoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY0OV0sImVycm9yTWVzc2FnZSI6IlJlZHVjZVJlc2VydmVzQ2FzaE5vdEF2YWlsYWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2NjFdLCJlcnJvck1lc3NhZ2UiOiJSZWR1Y2VSZXNlcnZlc0Nhc2hWYWxpZGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY0MV0sImVycm9yTWVzc2FnZSI6IlJlZHVjZVJlc2VydmVzRnJlc2hDaGVjayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzODJdLCJlcnJvck1lc3NhZ2UiOiJSZXBheUJvcnJvd0NvbXB0cm9sbGVyUmVqZWN0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM5M10sImVycm9yTWVzc2FnZSI6IlJlcGF5Qm9ycm93RnJlc2huZXNzQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODYwXSwiZXJyb3JNZXNzYWdlIjoiU2V0Q29tcHRyb2xsZXJPd25lckNoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTk0M10sImVycm9yTWVzc2FnZSI6IlNldEludGVyZXN0UmF0ZU1vZGVsRnJlc2hDaGVjayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5MzJdLCJlcnJvck1lc3NhZ2UiOiJTZXRJbnRlcmVzdFJhdGVNb2RlbE93bmVyQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzg4XSwiZXJyb3JNZXNzYWdlIjoiU2V0UGVuZGluZ0FkbWluT3duZXJDaGVjayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MzJdLCJlcnJvck1lc3NhZ2UiOiJTZXRSZXNlcnZlRmFjdG9yQWRtaW5DaGVjayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NTBdLCJlcnJvck1lc3NhZ2UiOiJTZXRSZXNlcnZlRmFjdG9yQm91bmRzQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTQzXSwiZXJyb3JNZXNzYWdlIjoiU2V0UmVzZXJ2ZUZhY3RvckZyZXNoQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjQ2XSwiZXJyb3JNZXNzYWdlIjoiVE9LRU5fVFJBTlNGRVJfSU5fRkFJTEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM1Ml0sImVycm9yTWVzc2FnZSI6IlRPS0VOX1RSQU5TRkVSX09VVF9GQUlMRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDI4XSwiZXJyb3JNZXNzYWdlIjoiVHJhbnNmZXJDb21wdHJvbGxlclJlamVjdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0MzVdLCJlcnJvck1lc3NhZ2UiOiJUcmFuc2Zlck5vdEFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODI2XSwiZXJyb3JNZXNzYWdlIjoiYm9ycm93IHJhdGUgaXMgYWJzdXJkbHkgaGlnaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMzQsMTM0MywxMzgxLDE0MTksMTY1MywxNjk4LDE3NTQsMjI2NywyNTg0LDI2NDEsMzE2MCwzMjAyLDMzNTEsMzUxMSwzNjA5LDQ2MzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfbm90RW50ZXJlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjExLDE0OTYsMTg3OSwyMjgwLDI0ODIsMzUzNywzNjM1LDM4ODksMzk5Niw0NzE1LDUxMjcsNTM4Nyw1OTM3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgYWNjcnVhbEJsb2NrTnVtYmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNzMsMjM2NSwyNDc1LDMzODUsMzQzNSwzNDUwLDM1MjksMzYyNywzNjc4LDM2ODgsMzgyNiwzOTg5LDU4NTcsNTkyOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NjMsMjQ5MiwzOTA4LDQwMDYsNDYxOSw0NzQyLDU0NzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBib3Jyb3dJbmRleCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTY0LDE0NDksMTgyNCwxOTYzLDM4NDgsNDM4Myw1MDgwLDUyNjEsNTMzNiw1NTY0LDU4NjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBjb21wdHJvbGxlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODE0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgZGVjaW1hbHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY2OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGluaXRpYWxFeGNoYW5nZVJhdGVNYW50aXNzYSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTg2LDMxMDMsMzg1OSw0NzgyLDU5NDhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBpbnRlcmVzdFJhdGVNb2RlbCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzc2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbmFtZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzkzLDM0MTcsMzgzN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHBlbmRpbmdBZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDg4LDM1NTUsMzg3MCw0ODczXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcmVzZXJ2ZUZhY3Rvck1hbnRpc3NhIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3OTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzeW1ib2wgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUyMywyOTU2LDMwNTgsMzE3NiwzOTI3LDQ2NzgsNDczMiw1NDI5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgdG90YWxCb3Jyb3dzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOTcsMjk3MSwzMDczLDM2NTQsMzk0Niw0Njg2LDQ3MzcsNTY5Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHRvdGFsUmVzZXJ2ZXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0NiwzOTY1LDQ2NTgsNTE0OSw1NzA5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgdG90YWxTdXBwbHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE4MywyMzczLDM3NjUsNDEwOCw0MTQ4LDQyOTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB1bmRlcmx5aW5nIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MTAsNDAyM10sImVycm9yTWVzc2FnZSI6ImluaXRpYWwgZXhjaGFuZ2UgcmF0ZSBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvLiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNzksMTA5NiwyNDMwLDI0NDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDg3LDExMDQsMjQzOCwyNDU1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNDksMTA1NywxMDY1LDE2ODYsMTczMSwxNzUwLDIxNjYsMjM1OCwyNDA4LDI0MTYsMjU3MiwyNjIxLDI2MjksMjY3NSwyNzM4LDI3NDYsMjc3OSwyODExLDI4NjYsMzE5OCwzMjM4LDMzMzEsMzMzOSwzMzc4LDM0ODEsMzczOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDczLDExMzAsMTMzOSwxMzc3LDE0MTUsMTY0OSwxNjk0LDE3MzksMjI2MywyNDI0LDI1ODAsMjYzNywyNjg0LDMzNDcsMzUwNywzNjA1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTYsMjQ2N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4OTksNTk4Ml0sImVycm9yTWVzc2FnZSI6Im1hcmtlciBtZXRob2QgcmV0dXJuZWQgZmFsc2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDk5LDQwMTNdLCJlcnJvck1lc3NhZ2UiOiJtYXJrZXQgbWF5IG9ubHkgYmUgaW5pdGlhbGl6ZWQgb25jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwMTldLCJlcnJvck1lc3NhZ2UiOiJvbmUgb2YgcmVkZWVtVG9rZW5zSW4gb3IgcmVkZWVtQW1vdW50SW4gbXVzdCBiZSB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ3NywzOTkxXSwiZXJyb3JNZXNzYWdlIjoib25seSBhZG1pbiBtYXkgaW5pdGlhbGl6ZSB0aGUgbWFya2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM2N10sImVycm9yTWVzc2FnZSI6Im9ubHkgdGhlIGFkbWluIG1heSBzZXQgdGhlIGNvbXAtbGlrZSBkZWxlZ2F0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMjUsMTI4MCwxMjkwLDE1NDksMTU2OCwxNTk4LDE2MDksMjA2NiwyMzExLDIzMjYsMjcwNSwyNzYyLDI3OTQsMjgxOSwyODUxLDI4OTIsMjkwNywyOTE5LDMwMjQsMzE0OSwzMTgxLDMyMjEsMzI0NiwzMjYzLDMyODAsMzI5NywzMzE0LDM0ODksMzU2NCwzNTc3LDM2OTQsMzcwNiwzNzUxLDM4NzUsMzg5NCwzOTEzLDM5MzIsMzk1MSwzOTcwLDQ1MzMsNDg0NCw0ODc4LDQ5NDAsNDk0OSw0OTYwLDQ5NzEsNTAyNyw1MTk4LDUyMjIsNTQ1OSw1NDc4LDU1MDIsNTUxMyw1Njc3LDU3NzIsNTc5NSw1ODE4LDU4MzAsNjAyMyw2MDUxLDYwODJdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMzUsMTM0NCwxMzgyLDE0MjAsMTY1NCwxNjk5LDE3NTUsMjI2OCwyNTg1LDI2NDIsMzE2MSwzMjAzLDMzNTIsMzUxMiwzNjEwLDQ2MzJdLCJlcnJvck1lc3NhZ2UiOiJyZS1lbnRlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI0MSw0MzQ3XSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUxOCw0MDMxXSwiZXJyb3JNZXNzYWdlIjoic2V0dGluZyBjb21wdHJvbGxlciBmYWlsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTQwLDQwNTNdLCJlcnJvck1lc3NhZ2UiOiJzZXR0aW5nIGludGVyZXN0IHJhdGUgbW9kZWwgZmFpbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE1NV0sImVycm9yTWVzc2FnZSI6InRva2VuIHNlaXp1cmUgZmFpbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1Gd2NISnZkbUZzWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F6TWlBeElEWWdNVEF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlQ0FpWDI1dmRFVnVkR1Z5WldRaUlEQjRNVFV4Wmpkak56VWdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ0ltRmtiV2x1SWlBaVlXTmpjblZoYkVKc2IyTnJUblZ0WW1WeUlpQWlZMjl0Y0hSeWIyeHNaWElpSUNKMGIzUmhiRkpsYzJWeWRtVnpJaUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUNBaWRHOTBZV3hDYjNKeWIzZHpJaUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ0ltSnZjbkp2ZDBsdVpHVjRJaUFpZEc5MFlXeFRkWEJ3YkhraUlDSmhZMk52ZFc1MFZHOXJaVzV6SWlBd2VEQmtaVEJpTm1JellUYzJOREF3TURBZ0luVnVaR1Z5YkhscGJtY2lJQ0pwYm5SbGNtVnpkRkpoZEdWTmIyUmxiQ0lnSW5CbGJtUnBibWRCWkcxcGJpSWdJbkpsYzJWeWRtVkdZV04wYjNKTllXNTBhWE56WVNJZ01IZzRNMkpoWkRkall5QXdlREk0T1RFNE9EWXhJQ0p1WVcxbElpQWljM2x0WW05c0lpQWlaR1ZqYVcxaGJITWlJQ0pwYm1sMGFXRnNSWGhqYUdGdVoyVlNZWFJsVFdGdWRHbHpjMkVpSURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptSUNKMGNtRnVjMlpsY2tGc2JHOTNZVzVqWlhNaUlDSmhZMk52ZFc1MFFtOXljbTkzY3lJZ01IZzNObUppTlRGaU1pQXdlRFEyTkRJMVl6ZGpJREI0TlRBeU5ETXpaV1lnTUhnM09XWmhZalEyTlNBd2VEbG1ZV0kyTW1JNUlEQjRaamt4TVRJeVlURWdNSGhrTUdVNU1qa3laQ0F3ZUdFeFptRTNPVGc1SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeU1Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklESXhJQzh2SUNKdVlXMWxJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJQ0p6ZVcxaWIyd2lDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTWpNZ0x5OGdJbVJsWTJsdFlXeHpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJR0o1ZEdWaklERXdJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKd1pXNWthVzVuUVdSdGFXNGlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEySUM4dklDSmpiMjF3ZEhKdmJHeGxjaUlLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0pwYm5SbGNtVnpkRkpoZEdWTmIyUmxiQ0lLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURJMElDOHZJQ0pwYm1sMGFXRnNSWGhqYUdGdVoyVlNZWFJsVFdGdWRHbHpjMkVpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01UZ2dMeThnSW5KbGMyVnlkbVZHWVdOMGIzSk5ZVzUwYVhOellTSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhZMk55ZFdGc1FteHZZMnRPZFcxaVpYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUp2Y25KdmQwbHVaR1Y0SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5SdmRHRnNRbTl5Y205M2N5SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjBiM1JoYkZKbGMyVnlkbVZ6SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKMGIzUmhiRk4xY0hCc2VTSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWlkVzVrWlhKc2VXbHVaeUlLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZrYldsdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR052ZG1WeUlEY0tJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUVsdGJYVjBZV0pzWlM1cGJtbDBhV0ZzYVhwbEtEY3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFZqWW1VM1lqQXhJREI0T0RSak5XSTBPRFFnTUhobU0yRmpPR1l6WXlBd2VEa3dNR05pWlRNeklEQjRZakV3TXpVMk5XSWdNSGczWVdRek9EZG1aaUF3ZURFeU9UY3hNV1psSURCNFlqVTVObU5pWXpNZ01IZzJNR05oWmpnMFppQXdlRGN3WW1Kak1qVXhJREI0WVRZNVpXTmpOMlVnTUhnMU5tUmhZVFZpWkNBd2VERTVPR001T0RJd0lEQjRObVJtTkRGbU5tUWdNSGhtWVdaaU5tRXdPQ0F3ZURWa09EVTBaREJsSUM4dklHMWxkR2h2WkNBaWFXNXBkR2xoYkdsNlpTaGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEhOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW0xcGJuUW9kV2x1ZERJMU5pbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSnlaV1JsWlcwb2RXbHVkREkxTmlsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKeVpXUmxaVzFWYm1SbGNteDVhVzVuS0hWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWW05eWNtOTNLSFZwYm5ReU5UWXBkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWljbVZ3WVhsQ2IzSnliM2NvZFdsdWRESTFOaWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0p5WlhCaGVVSnZjbkp2ZDBKbGFHRnNaaWhoWkdSeVpYTnpMSFZwYm5ReU5UWXBkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWliR2x4ZFdsa1lYUmxRbTl5Y205M0tHRmtaSEpsYzNNc2RXbHVkREkxTml4aFpHUnlaWE56S1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW5OM1pXVndWRzlyWlc0b1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0pmWVdSa1VtVnpaWEoyWlhNb2RXbHVkREkxTmlsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKZlpHVnNaV2RoZEdWRGIyMXdUR2xyWlZSdktHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYVc1cGRHbGhiR2w2WlNoaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0owY21GdWMyWmxjaWhoWkdSeVpYTnpMSFZwYm5ReU5UWXBZbTl2YkNJc0lHMWxkR2h2WkNBaWRISmhibk5tWlhKR2NtOXRLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMktXSnZiMndpTENCdFpYUm9iMlFnSW1Gd2NISnZkbVVvWVdSa2NtVnpjeXgxYVc1ME1qVTJLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltRnNiRzkzWVc1alpTaGhaR1J5WlhOekxHRmtaSEpsYzNNcGRXbHVkREkxTmlJS0lDQWdJR0o1ZEdWaklERTVJQzh2SUcxbGRHaHZaQ0FpWW1Gc1lXNWpaVTltS0dGa1pISmxjM01wZFdsdWRESTFOaUlLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc1WmpBek5qSTNPU0F3ZURobVpXWmhZalEwSURCNE5UTTVabVV4WVRFZ01IaGxZVGt6WkRreFpDQXdlRGxoWkRRNU9UWTBJREI0TmpkbE4yVmpabVVnTUhoaE1HTTRNelJtWmlBd2VEWXhaalV3Tm1RMUlEQjRZVFV4WlRoaE5UY2dNSGhsTmpjMVpqazNNaUF2THlCdFpYUm9iMlFnSW1KaGJHRnVZMlZQWmxWdVpHVnliSGxwYm1jb1lXUmtjbVZ6Y3lsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKblpYUkJZMk52ZFc1MFUyNWhjSE5vYjNRb1lXUmtjbVZ6Y3lrb2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaWtpTENCdFpYUm9iMlFnSW1KdmNuSnZkMUpoZEdWUVpYSkNiRzlqYXlncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWMzVndjR3g1VW1GMFpWQmxja0pzYjJOcktDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSjBiM1JoYkVKdmNuSnZkM05EZFhKeVpXNTBLQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0ppYjNKeWIzZENZV3hoYm1ObFEzVnljbVZ1ZENoaFpHUnlaWE56S1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1KdmNuSnZkMEpoYkdGdVkyVlRkRzl5WldRb1lXUmtjbVZ6Y3lsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKbGVHTm9ZVzVuWlZKaGRHVkRkWEp5Wlc1MEtDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmxlR05vWVc1blpWSmhkR1ZUZEc5eVpXUW9LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbWRsZEVOaGMyZ29LWFZwYm5ReU5UWWlDaUFnSUNCaWVYUmxZeUF5T1NBdkx5QnRaWFJvYjJRZ0ltRmpZM0oxWlVsdWRHVnlaWE4wS0NsMWFXNTBNalUySWdvZ0lDQWdZbmwwWldNZ016QWdMeThnYldWMGFHOWtJQ0p6WldsNlpTaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTmlsMWFXNTBNalUySWdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdJd1pqTTFaVEJpSURCNE5tUmpaRGc1TlRRZ01IZzVaalUyWkRZME1TQXdlR00yWWpSa05EWmxJREI0TlRnNU0yRmlPRElnTUhobE5XTXdPRGRtT0NBd2VEWXhZek5qTVdWbUlEQjRNVGszTlRBMk1UWWdNSGd3TURWaU5USmlPQ0F3ZUdJNE56YzVaV1UzSURCNE1HRTBabUkyWWpNZ01IaG1ZVGs0WTJRd015QXdlREkyT1dFeE1EQmlJREI0TURVMVlUQTVZelFnTUhnek9UTXpZak5sTnlBdkx5QnRaWFJvYjJRZ0lsOXpaWFJRWlc1a2FXNW5RV1J0YVc0b1lXUmtjbVZ6Y3lsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKZllXTmpaWEIwUVdSdGFXNG9LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbDl6WlhSRGIyMXdkSEp2Ykd4bGNpaGhaR1J5WlhOektYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0lsOXpaWFJTWlhObGNuWmxSbUZqZEc5eUtIVnBiblF5TlRZcGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVgzSmxaSFZqWlZKbGMyVnlkbVZ6S0hWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWDNObGRFbHVkR1Z5WlhOMFVtRjBaVTF2WkdWc0tHRmtaSEpsYzNNcGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWRXNWtaWEpzZVdsdVp5Z3BZV1JrY21WemN5SXNJRzFsZEdodlpDQWlibUZ0WlNncGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKemVXMWliMndvS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWkdWamFXMWhiSE1vS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWVdSdGFXNG9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbkJsYm1ScGJtZEJaRzFwYmlncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaVkyOXRjSFJ5YjJ4c1pYSW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbWx1ZEdWeVpYTjBVbUYwWlUxdlpHVnNLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0p5WlhObGNuWmxSbUZqZEc5eVRXRnVkR2x6YzJFb0tYVnBiblF5TlRZaUNpQWdJQ0JpZVhSbFl5QXpNU0F2THlCdFpYUm9iMlFnSW1GalkzSjFZV3hDYkc5amEwNTFiV0psY2lncGRXbHVkREkxTmlJS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoak1HRTNOVEZoWmlBd2VEZzBOelF6T0RSbUlEQjROVEEyWXpOalpESWdMeThnYldWMGFHOWtJQ0ppYjNKeWIzZEpibVJsZUNncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWRHOTBZV3hDYjNKeWIzZHpLQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0owYjNSaGJGSmxjMlZ5ZG1WektDbDFhVzUwTWpVMklnb2dJQ0FnWW5sMFpXTWdNeklnTHk4Z2JXVjBhRzlrSUNKMGIzUmhiRk4xY0hCc2VTZ3BkV2x1ZERJMU5pSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR2x1YVhScFlXeHBlbVVvTnlrZ2JXbHVkQ0J5WldSbFpXMGdjbVZrWldWdFZXNWtaWEpzZVdsdVp5QmliM0p5YjNjZ2NtVndZWGxDYjNKeWIzY2djbVZ3WVhsQ2IzSnliM2RDWldoaGJHWWdiR2x4ZFdsa1lYUmxRbTl5Y205M0lITjNaV1Z3Vkc5clpXNGdYMkZrWkZKbGMyVnlkbVZ6SUY5a1pXeGxaMkYwWlVOdmJYQk1hV3RsVkc4Z2FXNXBkR2xoYkdsNlpTZzJLU0IwY21GdWMyWmxjaUIwY21GdWMyWmxja1p5YjIwZ1lYQndjbTkyWlNCaGJHeHZkMkZ1WTJVZ1ltRnNZVzVqWlU5bUlHSmhiR0Z1WTJWUFpsVnVaR1Z5YkhscGJtY2daMlYwUVdOamIzVnVkRk51WVhCemFHOTBJR0p2Y25KdmQxSmhkR1ZRWlhKQ2JHOWpheUJ6ZFhCd2JIbFNZWFJsVUdWeVFteHZZMnNnZEc5MFlXeENiM0p5YjNkelEzVnljbVZ1ZENCaWIzSnliM2RDWVd4aGJtTmxRM1Z5Y21WdWRDQmliM0p5YjNkQ1lXeGhibU5sVTNSdmNtVmtJR1Y0WTJoaGJtZGxVbUYwWlVOMWNuSmxiblFnWlhoamFHRnVaMlZTWVhSbFUzUnZjbVZrSUdkbGRFTmhjMmdnWVdOamNuVmxTVzUwWlhKbGMzUWdjMlZwZW1VZ1gzTmxkRkJsYm1ScGJtZEJaRzFwYmlCZllXTmpaWEIwUVdSdGFXNGdYM05sZEVOdmJYQjBjbTlzYkdWeUlGOXpaWFJTWlhObGNuWmxSbUZqZEc5eUlGOXlaV1IxWTJWU1pYTmxjblpsY3lCZmMyVjBTVzUwWlhKbGMzUlNZWFJsVFc5a1pXd2dkVzVrWlhKc2VXbHVaeUJ1WVcxbElITjViV0p2YkNCa1pXTnBiV0ZzY3lCaFpHMXBiaUJ3Wlc1a2FXNW5RV1J0YVc0Z1kyOXRjSFJ5YjJ4c1pYSWdhVzUwWlhKbGMzUlNZWFJsVFc5a1pXd2djbVZ6WlhKMlpVWmhZM1J2Y2sxaGJuUnBjM05oSUdGalkzSjFZV3hDYkc5amEwNTFiV0psY2lCaWIzSnliM2RKYm1SbGVDQjBiM1JoYkVKdmNuSnZkM01nZEc5MFlXeFNaWE5sY25abGN5QjBiM1JoYkZOMWNIQnNlUW9nSUNBZ1pYSnlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNXBibWwwYVdGc2FYcGxLRGNwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FXNXBkR2xoYkdsNlpTZzNLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEY0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdWFXNXBkR2xoYkdsNlpTZzNLUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQkpiVzExZEdGaWJHVXViV2x1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMXBiblE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmJtOTBSVzUwWlhKbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gyNXZkRVZ1ZEdWeVpXUWdaWGhwYzNSekNpQWdJQ0JoYzNObGNuUWdMeThnY21VdFpXNTBaWEpsWkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNRWx0YlhWMFlXSnNaUzVoWTJOeWRXVkpiblJsY21WemRBb2dJQ0FnY0c5d0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVkyOXRjSFJ5YjJ4c1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiWEIwY205c2JHVnlJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGhZak0yTkRsbE15QXZMeUJ0WlhSb2IyUWdJbTFwYm5SQmJHeHZkMlZrS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTFwYm5SRGIyMXdkSEp2Ykd4bGNsSmxhbVZqZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1GalkzSjFZV3hDYkc5amEwNTFiV0psY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWVdOamNuVmhiRUpzYjJOclRuVnRZbVZ5SUdWNGFYTjBjd29nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNCaUlUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJOYVc1MFJuSmxjMmh1WlhOelEyaGxZMnNLSUNBZ0lHTmhiR3h6ZFdJZ1pYaGphR0Z1WjJWU1lYUmxVM1J2Y21Wa1NXNTBaWEp1WVd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeENpQWdJQ0JpZkFvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyRnNiSE4xWWlCa2IxUnlZVzV6Wm1WeVNXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlHUnBkbDhvTWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpZEc5MFlXeFRkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhSdmRHRnNVM1Z3Y0d4NUlHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpZEc5MFlXeFRkWEJ3YkhraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWkdsbklETUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbUZqWTI5MWJuUlViMnRsYm5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWWlzS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRORGRtWkRReE5tRWdMeThnYldWMGFHOWtJQ0pOYVc1MEtHRmtaSEpsYzNNc2RXbHVkREkxTml4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z2JXVjBhRzlrSUNKVWNtRnVjMlpsY2loaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhneE5URm1OMk0zTlRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1Y21Wa1pXVnRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21Wa1pXVnRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5dWIzUkZiblJsY21Wa0lHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJSEpsTFdWdWRHVnlaV1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQkpiVzExZEdGaWJHVXVZV05qY25WbFNXNTBaWEpsYzNRS0lDQWdJSEJ2Y0FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ2NtVmtaV1Z0Um5KbGMyZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd1NXMXRkWFJoWW14bExuSmxaR1ZsYlZWdVpHVnliSGxwYm1kYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV1JsWlcxVmJtUmxjbXg1YVc1bk9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjl1YjNSRmJuUmxjbVZrSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklISmxMV1Z1ZEdWeVpXUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVlXTmpjblZsU1c1MFpYSmxjM1FLSUNBZ0lIQnZjQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCeVpXUmxaVzFHY21WemFBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgyNXZkRVZ1ZEdWeVpXUWlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVltOXljbTkzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltOXljbTkzT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmJtOTBSVzUwWlhKbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gyNXZkRVZ1ZEdWeVpXUWdaWGhwYzNSekNpQWdJQ0JoYzNObGNuUWdMeThnY21VdFpXNTBaWEpsWkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNRWx0YlhWMFlXSnNaUzVoWTJOeWRXVkpiblJsY21WemRBb2dJQ0FnY0c5d0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVkyOXRjSFJ5YjJ4c1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiWEIwY205c2JHVnlJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVNVGt6TVdReE9DQXZMeUJ0WlhSb2IyUWdJbUp2Y25KdmQwRnNiRzkzWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlwZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUW05eWNtOTNRMjl0Y0hSeWIyeHNaWEpTWldwbFkzUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhZMk55ZFdGc1FteHZZMnRPZFcxaVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpQmxlR2x6ZEhNS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZaUU5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOXljbTkzUm5KbGMyaHVaWE56UTJobFkyc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFEyRnphRkJ5YVc5eUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWWp3S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM0p5YjNkRFlYTm9UbTkwUVhaaGFXeGhZbXhsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQmliM0p5YjNkQ1lXeGhibU5sVTNSdmNtVmtTVzUwWlhKdVlXd0tJQ0FnSUdScFp5QTBDaUFnSUNCaUt3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5SdmRHRnNRbTl5Y205M2N5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOTBZV3hDYjNKeWIzZHpJR1Y0YVhOMGN3b2dJQ0FnWkdsbklEVUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ013b2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF5T0NBdkx5QWlZV05qYjNWdWRFSnZjbkp2ZDNNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTWpVZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkdsbklEUUtJQ0FnSUdKOENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUp2Y25KdmQwbHVaR1Y0SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJpYjNKeWIzZEpibVJsZUNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUExQ2lBZ0lDQmlmQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlkRzkwWVd4Q2IzSnliM2R6SWdvZ0lDQWdaR2xuSURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklEWUtJQ0FnSUdOaGJHeHpkV0lnWkc5VWNtRnVjMlpsY2s5MWRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSjhDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlmQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WlRkbE9EUXlZV01nTHk4Z2JXVjBhRzlrSUNKQ2IzSnliM2NvWVdSa2NtVnpjeXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5pa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQkpiVzExZEdGaWJHVXVjbVZ3WVhsQ2IzSnliM2RiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYQmhlVUp2Y25KdmR6b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYm05MFJXNTBaWEpsWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaUzFsYm5SbGNtVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd1NXMXRkWFJoWW14bExtRmpZM0oxWlVsdWRHVnlaWE4wQ2lBZ0lDQndiM0FLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlISmxjR0Y1UW05eWNtOTNSbkpsYzJnS0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhneE5URm1OMk0zTlRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1Y21Wd1lYbENiM0p5YjNkQ1pXaGhiR1piY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYQmhlVUp2Y25KdmQwSmxhR0ZzWmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgyNXZkRVZ1ZEdWeVpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOXViM1JGYm5SbGNtVmtJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUhKbExXVnVkR1Z5WldRS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5dWIzUkZiblJsY21Wa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1WVdOamNuVmxTVzUwWlhKbGMzUUtJQ0FnSUhCdmNBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJ5WlhCaGVVSnZjbkp2ZDBaeVpYTm9DaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd1NXMXRkWFJoWW14bExteHBjWFZwWkdGMFpVSnZjbkp2ZDF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteHBjWFZwWkdGMFpVSnZjbkp2ZHpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYm05MFJXNTBaWEpsWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaUzFsYm5SbGNtVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd1NXMXRkWFJoWW14bExtRmpZM0oxWlVsdWRHVnlaWE4wQ2lBZ0lDQndiM0FLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTWprZ0x5OGdiV1YwYUc5a0lDSmhZMk55ZFdWSmJuUmxjbVZ6ZENncGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1RHbHhkV2xrWVhSbFFXTmpjblZsUTI5c2JHRjBaWEpoYkVsdWRHVnlaWE4wUm1GcGJHVmtDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEY0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1OdmJYQjBjbTlzYkdWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCamIyMXdkSEp2Ykd4bGNpQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlXTTNaalJrWXpnZ0x5OGdiV1YwYUc5a0lDSnNhWEYxYVdSaGRHVkNiM0p5YjNkQmJHeHZkMlZrS0dGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUR2x4ZFdsa1lYUmxRMjl0Y0hSeWIyeHNaWEpTWldwbFkzUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhZMk55ZFdGc1FteHZZMnRPZFcxaVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpQmxlR2x6ZEhNS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZaUU5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1RHbHhkV2xrWVhSbFJuSmxjMmh1WlhOelEyaGxZMnNLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ016RWdMeThnYldWMGFHOWtJQ0poWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElvS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lpRTlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVEdseGRXbGtZWFJsUTI5c2JHRjBaWEpoYkVaeVpYTm9ibVZ6YzBOb1pXTnJDaUFnSUNCa2FXY2dOUW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVEdseGRXbGtZWFJsVEdseGRXbGtZWFJ2Y2tselFtOXljbTkzWlhJS0lDQWdJR1JwWnlBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1hWEYxYVdSaGRHVkRiRzl6WlVGdGIzVnVkRWx6V21WeWJ3b2dJQ0FnWkdsbklEUUtJQ0FnSUdKNWRHVmpJREkySUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lqMDlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVEdseGRXbGtZWFJsUTJ4dmMyVkJiVzkxYm5SSmMxVnBiblJOWVhnS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBMUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTmhiR3h6ZFdJZ2NtVndZWGxDYjNKeWIzZEdjbVZ6YUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTI5dGNIUnliMnhzWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJYQjBjbTlzYkdWeUlHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVpqRXdZekkwTVNBdkx5QnRaWFJvYjJRZ0lteHBjWFZwWkdGMFpVTmhiR04xYkdGMFpWTmxhWHBsVkc5clpXNXpLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMktTaDFhVzUwTWpVMkxIVnBiblF5TlRZcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNeklLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBek5pQXpNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJNU1ZGVlNVUkJWRVZmUTA5TlVGUlNUMHhNUlZKZlEwRk1RMVZNUVZSRlgwRk5UMVZPVkY5VFJVbGFSVjlHUVVsTVJVUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QnRaWFJvYjJRZ0ltSmhiR0Z1WTJWUFppaGhaR1J5WlhOektYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR0k4UFFvZ0lDQWdZWE56WlhKMElDOHZJRXhKVVZWSlJFRlVSVjlUUlVsYVJWOVVUMDlmVFZWRFNBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JpZWlCc2FYRjFhV1JoZEdWQ2IzSnliM2RmWld4elpWOWliMlI1UURNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklEZ0tJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUhObGFYcGxTVzUwWlhKdVlXd0tDbXhwY1hWcFpHRjBaVUp2Y25KdmQxOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTlFvZ0lDQWdaR2xuSURrS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROekk0TlRZd09UTWdMeThnYldWMGFHOWtJQ0pNYVhGMWFXUmhkR1ZDYjNKeWIzY29ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmJtOTBSVzUwWlhKbFpDSUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHNhWEYxYVdSaGRHVkNiM0p5YjNkZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2FXY2dOUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBek1DQXZMeUJ0WlhSb2IyUWdJbk5sYVhwbEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUWdMeThnZEc5clpXNGdjMlZwZW5WeVpTQm1ZV2xzWldRS0lDQWdJR0lnYkdseGRXbGtZWFJsUW05eWNtOTNYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMzZGxaWEJVYjJ0bGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk4zWldWd1ZHOXJaVzQ2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRSWEpqTWpBNk9uTjNaV1Z3Vkc5clpXNDZJRzl1YkhrZ1lXUnRhVzRnWTJGdUlITjNaV1Z3SUhSdmEyVnVjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSjFibVJsY214NWFXNW5JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjFibVJsY214NWFXNW5JR1Y0YVhOMGN3b2dJQ0FnWkdsbklESUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnUTBWeVl6SXdPanB6ZDJWbGNGUnZhMlZ1T2lCallXNGdibTkwSUhOM1pXVndJSFZ1WkdWeWJIbHBibWNnZEc5clpXNEtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBeE9TQXZMeUJ0WlhSb2IyUWdJbUpoYkdGdVkyVlBaaWhoWkdSeVpYTnpLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBek15QXZMeUJ0WlhSb2IyUWdJblJ5WVc1elptVnlLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTGw5aFpHUlNaWE5sY25abGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbDloWkdSU1pYTmxjblpsY3pvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZibTkwUlc1MFpYSmxaQ0JsZUdsemRITUtJQ0FnSUdGemMyVnlkQ0F2THlCeVpTMWxiblJsY21Wa0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmJtOTBSVzUwWlhKbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1GalkzSjFaVWx1ZEdWeVpYTjBDaUFnSUNCd2IzQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaFkyTnlkV0ZzUW14dlkydE9kVzFpWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdGalkzSjFZV3hDYkc5amEwNTFiV0psY2lCbGVHbHpkSE1LSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lpRTlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdSa1VtVnpaWEoyWlhOR1lXTjBiM0pHY21WemFFTm9aV05yQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUdSdlZISmhibk5tWlhKSmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SdmRHRnNVbVZ6WlhKMlpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnZkR0ZzVW1WelpYSjJaWE1nWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZkR0ZzVW1WelpYSjJaWE1pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjhDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUF6TkNBdkx5QnRaWFJvYjJRZ0lsSmxjMlZ5ZG1WelFXUmtaV1FvWVdSa2NtVnpjeXgxYVc1ME1qVTJMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMbDlrWld4bFoyRjBaVU52YlhCTWFXdGxWRzliY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwZlpHVnNaV2RoZEdWRGIyMXdUR2xyWlZSdk9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdGa2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Ym14NUlIUm9aU0JoWkcxcGJpQnRZWGtnYzJWMElIUm9aU0JqYjIxd0xXeHBhMlVnWkdWc1pXZGhkR1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaWRXNWtaWEpzZVdsdVp5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RXNWtaWEpzZVdsdVp5QmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlqTmlOalZtTWpnZ0x5OGdiV1YwYUc5a0lDSmtaV3hsWjJGMFpTaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNXBibWwwYVdGc2FYcGxLRFlwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FXNXBkR2xoYkdsNlpTZzJLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0JoWkcxcGJpQnRZWGtnYVc1cGRHbGhiR2w2WlNCMGFHVWdiV0Z5YTJWMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWVdOamNuVmhiRUpzYjJOclRuVnRZbVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJoWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBUMEtJQ0FnSUdKNklHbHVhWFJwWVd4cGVtVW9OaWxmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01URWdMeThnSW1KdmNuSnZkMGx1WkdWNElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaWIzSnliM2RKYm1SbGVDQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nYVc1cGRHbGhiR2w2WlNnMktWOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3BwYm1sMGFXRnNhWHBsS0RZcFgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QnRZWEpyWlhRZ2JXRjVJRzl1YkhrZ1ltVWdhVzVwZEdsaGJHbDZaV1FnYjI1alpRb2dJQ0FnWW5sMFpXTWdNalFnTHk4Z0ltbHVhWFJwWVd4RmVHTm9ZVzVuWlZKaGRHVk5ZVzUwYVhOellTSUtJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVhWFJwWVd3Z1pYaGphR0Z1WjJVZ2NtRjBaU0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlCNlpYSnZMZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNWZjMlYwUTI5dGNIUnliMnhzWlhJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJSE5sZEhScGJtY2dZMjl0Y0hSeWIyeHNaWElnWm1GcGJHVmtDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltSnZjbkp2ZDBsdVpHVjRJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpZV3hzYzNWaUlGOXpaWFJKYm5SbGNtVnpkRkpoZEdWTmIyUmxiRVp5WlhOb0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6WlhSMGFXNW5JR2x1ZEdWeVpYTjBJSEpoZEdVZ2JXOWtaV3dnWm1GcGJHVmtDaUFnSUNCaWVYUmxZeUF5TVNBdkx5QWlibUZ0WlNJS0lDQWdJR1JwWnlBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNaklnTHk4Z0luTjViV0p2YkNJS0lDQWdJR1JwWnlBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNak1nTHk4Z0ltUmxZMmx0WVd4eklnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYVc1cGRHbGhiR2w2WlNnMktWOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnBibWwwYVdGc2FYcGxLRFlwWDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdWRISmhibk5tWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBjbUZ1YzJabGNqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjl1YjNSRmJuUmxjbVZrSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklISmxMV1Z1ZEdWeVpXUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqWVd4c2MzVmlJSFJ5WVc1elptVnlWRzlyWlc1ekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMblJ5WVc1elptVnlSbkp2YlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnlZVzV6Wm1WeVJuSnZiVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmYm05MFJXNTBaWEpsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWDI1dmRFVnVkR1Z5WldRZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RZ0x5OGdjbVV0Wlc1MFpYSmxaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ2RISmhibk5tWlhKVWIydGxibk1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSTlQUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVlYQndjbTkyWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRndjSEp2ZG1VNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklESTNJQzh2SUNKMGNtRnVjMlpsY2tGc2JHOTNZVzVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCa2FXY2dNd29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREU0WlRBNU5EWXhJQzh2SUcxbGRHaHZaQ0FpUVhCd2NtOTJZV3dvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQkpiVzExZEdGaWJHVXVZV3hzYjNkaGJtTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVd4c2IzZGhibU5sT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXlOeUF2THlBaWRISmhibk5tWlhKQmJHeHZkMkZ1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUVsdGJYVjBZV0pzWlM1aVlXeGhibU5sVDJaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGlZV3hoYm1ObFQyWTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbUZqWTI5MWJuUlViMnRsYm5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1KaGJHRnVZMlZQWmxWdVpHVnliSGxwYm1kYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGlZV3hoYm1ObFQyWlZibVJsY214NWFXNW5PZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVpYaGphR0Z1WjJWU1lYUmxRM1Z5Y21WdWRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdKOENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UTWdMeThnSW1GalkyOTFiblJVYjJ0bGJuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1kyRnNiSE4xWWlCdGRXeGZLRElwQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TUdSbE1HSTJZak5oTnpZME1EQXdNQW9nSUNBZ1lpOEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUVsdGJYVjBZV0pzWlM1blpYUkJZMk52ZFc1MFUyNWhjSE5vYjNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJCWTJOdmRXNTBVMjVoY0hOb2IzUTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdSMWNBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlZV05qYjNWdWRGUnZhMlZ1Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJR0p2Y25KdmQwSmhiR0Z1WTJWVGRHOXlaV1JKYm5SbGNtNWhiQW9nSUNBZ1kyRnNiSE4xWWlCbGVHTm9ZVzVuWlZKaGRHVlRkRzl5WldSSmJuUmxjbTVoYkFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWZBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNWliM0p5YjNkU1lYUmxVR1Z5UW14dlkydGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYjNKeWIzZFNZWFJsVUdWeVFteHZZMnM2Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCallXeHNjM1ZpSUdkbGRFTmhjMmhRY21sdmNnb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyRnNiSE4xWWlCblpYUkRZWE5vVUhKcGIzSUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hDYjNKeWIzZHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiM1JoYkVKdmNuSnZkM01nWlhocGMzUnpDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOTBZV3hTWlhObGNuWmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4U1pYTmxjblpsY3lCbGVHbHpkSE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlhVzUwWlhKbGMzUlNZWFJsVFc5a1pXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHbHVkR1Z5WlhOMFVtRjBaVTF2WkdWc0lHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXpOU0F2THlCdFpYUm9iMlFnSW1kbGRFSnZjbkp2ZDFKaGRHVW9kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZcGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQkpiVzExZEdGaWJHVXVjM1Z3Y0d4NVVtRjBaVkJsY2tKc2IyTnJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNWd2NHeDVVbUYwWlZCbGNrSnNiMk5yT2dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1kyRnNiSE4xWWlCblpYUkRZWE5vVUhKcGIzSUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBRMkZ6YUZCeWFXOXlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luUnZkR0ZzUW05eWNtOTNjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4Q2IzSnliM2R6SUdWNGFYTjBjd29nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZkR0ZzVW1WelpYSjJaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJ2ZEdGc1VtVnpaWEoyWlhNZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbkpsYzJWeWRtVkdZV04wYjNKTllXNTBhWE56WVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21WelpYSjJaVVpoWTNSdmNrMWhiblJwYzNOaElHVjRhWE4wY3dvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0pwYm5SbGNtVnpkRkpoZEdWTmIyUmxiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dhVzUwWlhKbGMzUlNZWFJsVFc5a1pXd2daWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHUmlNMlEzWmpSaElDOHZJRzFsZEdodlpDQWlaMlYwVTNWd2NHeDVVbUYwWlNoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG5SdmRHRnNRbTl5Y205M2MwTjFjbkpsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBiM1JoYkVKdmNuSnZkM05EZFhKeVpXNTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZibTkwUlc1MFpYSmxaQ0JsZUdsemRITUtJQ0FnSUdGemMyVnlkQ0F2THlCeVpTMWxiblJsY21Wa0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmJtOTBSVzUwWlhKbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1GalkzSjFaVWx1ZEdWeVpYTjBDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hDYjNKeWIzZHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiM1JoYkVKdmNuSnZkM01nWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVltOXljbTkzUW1Gc1lXNWpaVU4xY25KbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYjNKeWIzZENZV3hoYm1ObFEzVnljbVZ1ZERvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYm05MFJXNTBaWEpsWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaUzFsYm5SbGNtVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd1NXMXRkWFJoWW14bExtRmpZM0oxWlVsdWRHVnlaWE4wQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmpZV3hzYzNWaUlHSnZjbkp2ZDBKaGJHRnVZMlZUZEc5eVpXUkpiblJsY201aGJBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1KdmNuSnZkMEpoYkdGdVkyVlRkRzl5WldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGliM0p5YjNkQ1lXeGhibU5sVTNSdmNtVmtPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCallXeHNjM1ZpSUdKdmNuSnZkMEpoYkdGdVkyVlRkRzl5WldSSmJuUmxjbTVoYkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMbVY0WTJoaGJtZGxVbUYwWlVOMWNuSmxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbGVHTm9ZVzVuWlZKaGRHVkRkWEp5Wlc1ME9nb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1WNFkyaGhibWRsVW1GMFpVTjFjbkpsYm5RS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNRWx0YlhWMFlXSnNaUzVsZUdOb1lXNW5aVkpoZEdWVGRHOXlaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbGVHTm9ZVzVuWlZKaGRHVlRkRzl5WldRNkNpQWdJQ0JqWVd4c2MzVmlJR1Y0WTJoaGJtZGxVbUYwWlZOMGIzSmxaRWx1ZEdWeWJtRnNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVoyVjBRMkZ6YUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRU5oYzJnNkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEVOaGMyaFFjbWx2Y2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMbUZqWTNKMVpVbHVkR1Z5WlhOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV05qY25WbFNXNTBaWEpsYzNRNkNpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1WVdOamNuVmxTVzUwWlhKbGMzUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUVsdGJYVjBZV0pzWlM1elpXbDZaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGFYcGxPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYm05MFJXNTBaWEpsWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaUzFsYm5SbGNtVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCelpXbDZaVWx1ZEdWeWJtRnNDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNWZjMlYwVUdWdVpHbHVaMEZrYldsdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tYM05sZEZCbGJtUnBibWRCWkcxcGJqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaFpHMXBiaUJsZUdsemRITUtJQ0FnSUNFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdVMlYwVUdWdVpHbHVaMEZrYldsdVQzZHVaWEpEYUdWamF3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKd1pXNWthVzVuUVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIQmxibVJwYm1kQlpHMXBiaUJsZUdsemRITUtJQ0FnSUdKNWRHVmpJREUzSUM4dklDSndaVzVrYVc1blFXUnRhVzRpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNellnTHk4Z2JXVjBhRzlrSUNKT1pYZFFaVzVrYVc1blFXUnRhVzRvWVdSa2NtVnpjeXhoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMbDloWTJObGNIUkJaRzFwYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNsOWhZMk5sY0hSQlpHMXBiam9LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOeUF2THlBaWNHVnVaR2x1WjBGa2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QndaVzVrYVc1blFXUnRhVzRnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ0lUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGNIUkJaRzFwYmxCbGJtUnBibWRCWkcxcGJrTm9aV05yQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUQwOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV05qWlhCMFFXUnRhVzVRWlc1a2FXNW5RV1J0YVc1RGFHVmphd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpY0dWdVpHbHVaMEZrYldsdUlnb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WXpCbE0yWXpZMllnTHk4Z2JXVjBhRzlrSUNKT1pYZEJaRzFwYmloaFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR0o1ZEdWaklERXdJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXpOaUF2THlCdFpYUm9iMlFnSWs1bGQxQmxibVJwYm1kQlpHMXBiaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQkpiVzExZEdGaWJHVXVYM05sZEVOdmJYQjBjbTlzYkdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tYM05sZEVOdmJYQjBjbTlzYkdWeU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1WDNObGRFTnZiWEIwY205c2JHVnlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVgzTmxkRkpsYzJWeWRtVkdZV04wYjNKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGZjMlYwVW1WelpYSjJaVVpoWTNSdmNqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjl1YjNSRmJuUmxjbVZrSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklISmxMV1Z1ZEdWeVpXUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVlXTmpjblZsU1c1MFpYSmxjM1FLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQWhQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZObGRGSmxjMlZ5ZG1WR1lXTjBiM0pCWkcxcGJrTm9aV05yQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV05qY25WaGJFSnNiMk5yVG5WdFltVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmhZMk55ZFdGc1FteHZZMnRPZFcxaVpYSWdaWGhwYzNSekNpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJR0loUFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGTmxkRkpsYzJWeWRtVkdZV04wYjNKR2NtVnphRU5vWldOckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z01IZ3daR1V3WWpaaU0yRTNOalF3TURBd0NpQWdJQ0JpUGdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGTmxkRkpsYzJWeWRtVkdZV04wYjNKQ2IzVnVaSE5EYUdWamF3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTRJQzh2SUNKeVpYTmxjblpsUm1GamRHOXlUV0Z1ZEdsemMyRWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklISmxjMlZ5ZG1WR1lXTjBiM0pOWVc1MGFYTnpZU0JsZUdsemRITUtJQ0FnSUdKNWRHVmpJREU0SUM4dklDSnlaWE5sY25abFJtRmpkRzl5VFdGdWRHbHpjMkVpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW53S0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5URXdabUV3WmpBZ0x5OGdiV1YwYUc5a0lDSk9aWGRTWlhObGNuWmxSbUZqZEc5eUtIVnBiblF5TlRZc2RXbHVkREkxTmlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUVsdGJYVjBZV0pzWlM1ZmNtVmtkV05sVW1WelpYSjJaWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwZmNtVmtkV05sVW1WelpYSjJaWE02Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5dWIzUkZiblJsY21Wa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCZmJtOTBSVzUwWlhKbFpDQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJ5WlMxbGJuUmxjbVZrQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmYm05MFJXNTBaWEpsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMbUZqWTNKMVpVbHVkR1Z5WlhOMENpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5dWIzUkZiblJsY21Wa0lnb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdGa2JXbHVJR1Y0YVhOMGN3b2dJQ0FnSVQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaV1IxWTJWU1pYTmxjblpsYzBGa2JXbHVRMmhsWTJzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0poWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR0ZqWTNKMVlXeENiRzlqYTA1MWJXSmxjaUJsZUdsemRITUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYVhSdllnb2dJQ0FnWWlFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdVbVZrZFdObFVtVnpaWEoyWlhOR2NtVnphRU5vWldOckNpQWdJQ0JqWVd4c2MzVmlJR2RsZEVOaGMyaFFjbWx2Y2dvZ0lDQWdaR2xuSURJS0lDQWdJR0k4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1VtVmtkV05sVW1WelpYSjJaWE5EWVhOb1RtOTBRWFpoYVd4aFlteGxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOTBZV3hTWlhObGNuWmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4U1pYTmxjblpsY3lCbGVHbHpkSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZajRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pXUjFZMlZTWlhObGNuWmxjME5oYzJoV1lXeHBaR0YwYVc5dUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWkdsbklESUtJQ0FnSUdJdENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOTBZV3hTWlhObGNuWmxjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaFpHMXBiaUJsZUdsemRITUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUdSdlZISmhibk5tWlhKUGRYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKOENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa05tWXlZelE1WXlBdkx5QnRaWFJvYjJRZ0lsSmxjMlZ5ZG1WelVtVmtkV05sWkNoaFpHUnlaWE56TEhWcGJuUXlOVFlzZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNRWx0YlhWMFlXSnNaUzVmYzJWMFNXNTBaWEpsYzNSU1lYUmxUVzlrWld4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGZjMlYwU1c1MFpYSmxjM1JTWVhSbFRXOWtaV3c2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNWhZMk55ZFdWSmJuUmxjbVZ6ZEFvZ0lDQWdjRzl3Q2lBZ0lDQmpZV3hzYzNWaUlGOXpaWFJKYm5SbGNtVnpkRkpoZEdWTmIyUmxiRVp5WlhOb0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1ZFc1a1pYSnNlV2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVnVaR1Z5YkhscGJtYzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0luVnVaR1Z5YkhscGJtY2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIVnVaR1Z5YkhscGJtY2daWGhwYzNSekNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUVsdGJYVjBZV0pzWlM1dVlXMWxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYm1GdFpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXlNU0F2THlBaWJtRnRaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dibUZ0WlNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNXplVzFpYjJ4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHplVzFpYjJ3NkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01qSWdMeThnSW5ONWJXSnZiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djM2x0WW05c0lHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMbVJsWTJsdFlXeHpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWamFXMWhiSE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWpNZ0x5OGdJbVJsWTJsdFlXeHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmtaV05wYldGc2N5QmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1Ga2JXbHVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVdSdGFXNDZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR0ZrYldsdUlHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1Y0dWdVpHbHVaMEZrYldsdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR1Z1WkdsdVowRmtiV2x1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0p3Wlc1a2FXNW5RV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhCbGJtUnBibWRCWkcxcGJpQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1OdmJYQjBjbTlzYkdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMjl0Y0hSeWIyeHNaWEk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlZMjl0Y0hSeWIyeHNaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052YlhCMGNtOXNiR1Z5SUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQkpiVzExZEdGaWJHVXVhVzUwWlhKbGMzUlNZWFJsVFc5a1pXeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYm5SbGNtVnpkRkpoZEdWTmIyUmxiRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlhVzUwWlhKbGMzUlNZWFJsVFc5a1pXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHbHVkR1Z5WlhOMFVtRjBaVTF2WkdWc0lHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1Y21WelpYSjJaVVpoWTNSdmNrMWhiblJwYzNOaFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ6WlhKMlpVWmhZM1J2Y2sxaGJuUnBjM05oT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFNElDOHZJQ0p5WlhObGNuWmxSbUZqZEc5eVRXRnVkR2x6YzJFaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhKbGMyVnlkbVZHWVdOMGIzSk5ZVzUwYVhOellTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNRWx0YlhWMFlXSnNaUzVoWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFkyTnlkV0ZzUW14dlkydE9kVzFpWlhJNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWVdOamNuVmhiRUpzYjJOclRuVnRZbVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJoWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVltOXljbTkzU1c1a1pYaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYjNKeWIzZEpibVJsZURvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWW05eWNtOTNTVzVrWlhnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdKdmNuSnZkMGx1WkdWNElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMblJ2ZEdGc1FtOXljbTkzYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnZkR0ZzUW05eWNtOTNjem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSjBiM1JoYkVKdmNuSnZkM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJ2ZEdGc1FtOXljbTkzY3lCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNTBiM1JoYkZKbGMyVnlkbVZ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOTBZV3hTWlhObGNuWmxjem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjBiM1JoYkZKbGMyVnlkbVZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYjNSaGJGSmxjMlZ5ZG1WeklHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMblJ2ZEdGc1UzVndjR3g1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOTBZV3hUZFhCd2JIazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0luUnZkR0ZzVTNWd2NHeDVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiM1JoYkZOMWNIQnNlU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUVsdGJYVjBZV0pzWlM1cGJtbDBhV0ZzYVhwbEtEY3BLSFZ1WkdWeWJIbHBibWRmT2lCaWVYUmxjeXdnWTI5dGNIUnliMnhzWlhKZk9pQmllWFJsY3l3Z2FXNTBaWEpsYzNSU1lYUmxUVzlrWld4Zk9pQmllWFJsY3l3Z2FXNXBkR2xoYkVWNFkyaGhibWRsVW1GMFpVMWhiblJwYzNOaFh6b2dZbmwwWlhNc0lHNWhiV1ZmT2lCaWVYUmxjeXdnYzNsdFltOXNYem9nWW5sMFpYTXNJR1JsWTJsdFlXeHpYem9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1sdWFYUnBZV3hwZW1Vb055azZDaUFnSUNCd2NtOTBieUEzSURBS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ1lXUnRhVzRnYldGNUlHbHVhWFJwWVd4cGVtVWdkR2hsSUcxaGNtdGxkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1lXTmpjblZoYkVKc2IyTnJUblZ0WW1WeUlHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1sdWFYUnBZV3hwZW1Vb055bGZZbTl2YkY5bVlXeHpaVUExQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUp2Y25KdmQwbHVaR1Y0SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJpYjNKeWIzZEpibVJsZUNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSTlQUW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNRWx0YlhWMFlXSnNaUzVwYm1sMGFXRnNhWHBsS0RjcFgySnZiMnhmWm1Gc2MyVkFOUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1YVc1cGRHbGhiR2w2WlNnM0tWOWliMjlzWDIxbGNtZGxRRFk2Q2lBZ0lDQmhjM05sY25RZ0x5OGdiV0Z5YTJWMElHMWhlU0J2Ym14NUlHSmxJR2x1YVhScFlXeHBlbVZrSUc5dVkyVUtJQ0FnSUdKNWRHVmpJREkwSUM4dklDSnBibWwwYVdGc1JYaGphR0Z1WjJWU1lYUmxUV0Z1ZEdsemMyRWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJK0NpQWdJQ0JoYzNObGNuUWdMeThnYVc1cGRHbGhiQ0JsZUdOb1lXNW5aU0J5WVhSbElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJSHBsY204dUNpQWdJQ0JtY21GdFpWOWthV2NnTFRZS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNRWx0YlhWMFlXSnNaUzVmYzJWMFEyOXRjSFJ5YjJ4c1pYSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhObGRIUnBibWNnWTI5dGNIUnliMnhzWlhJZ1ptRnBiR1ZrQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUZqWTNKMVlXeENiRzlqYTA1MWJXSmxjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUp2Y25KdmQwbHVaR1Y0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdZMkZzYkhOMVlpQmZjMlYwU1c1MFpYSmxjM1JTWVhSbFRXOWtaV3hHY21WemFBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUWdMeThnYzJWMGRHbHVaeUJwYm5SbGNtVnpkQ0J5WVhSbElHMXZaR1ZzSUdaaGFXeGxaQW9nSUNBZ1lubDBaV01nTWpFZ0x5OGdJbTVoYldVaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXlNaUF2THlBaWMzbHRZbTlzSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01qTWdMeThnSW1SbFkybHRZV3h6SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERTFJQzh2SUNKMWJtUmxjbXg1YVc1bklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwM0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdabkpoYldWZlpHbG5JQzAzQ2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWaklETXlJQzh2SUcxbGRHaHZaQ0FpZEc5MFlXeFRkWEJ3Ykhrb0tYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUhKbGRITjFZZ29LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUVsdGJYVjBZV0pzWlM1cGJtbDBhV0ZzYVhwbEtEY3BYMkp2YjJ4ZlptRnNjMlZBTlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1YVc1cGRHbGhiR2w2WlNnM0tWOWliMjlzWDIxbGNtZGxRRFlLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMbWRsZEVOaGMyaFFjbWx2Y2lncElDMCtJR0o1ZEdWek9ncG5aWFJEWVhOb1VISnBiM0k2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJblZ1WkdWeWJIbHBibWNpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFZ1WkdWeWJIbHBibWNnWlhocGMzUnpDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QnRaWFJvYjJRZ0ltSmhiR0Z1WTJWUFppaGhaR1J5WlhOektYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMbVJ2VkhKaGJuTm1aWEpKYmlobWNtOXRPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtUnZWSEpoYm5ObVpYSkpiam9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldNZ01UVWdMeThnSW5WdVpHVnliSGxwYm1jaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhWdVpHVnliSGxwYm1jZ1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ01Ua2dMeThnYldWMGFHOWtJQ0ppWVd4aGJtTmxUMllvWVdSa2NtVnpjeWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGlOek5sWVRKa1ppQXZMeUJ0WlhSb2IyUWdJblJ5WVc1elptVnlSbkp2YlNoaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaWwyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZbmwwWldNZ016Y2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURJd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0J0WVhSamFDQmtiMVJ5WVc1elptVnlTVzVmYzNkcGRHTm9YMk5oYzJWZk1FQXpJR1J2VkhKaGJuTm1aWEpKYmw5emQybDBZMmhmWTJGelpWOHhRRFFLSUNBZ0lHVnljaUF2THlCeVpYWmxjblFLQ21SdlZISmhibk5tWlhKSmJsOXpkMmwwWTJoZlkyRnpaVjh4UURRNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2dwa2IxUnlZVzV6Wm1WeVNXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTJPZ29nSUNBZ1lYTnpaWEowSUM4dklGUlBTMFZPWDFSU1FVNVRSa1ZTWDBsT1gwWkJTVXhGUkFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ01Ua2dMeThnYldWMGFHOWtJQ0ppWVd4aGJtTmxUMllvWVdSa2NtVnpjeWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwa2IxUnlZVzV6Wm1WeVNXNWZjM2RwZEdOb1gyTmhjMlZmTUVBek9nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR0lnWkc5VWNtRnVjMlpsY2tsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5nb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVpHOVVjbUZ1YzJabGNrOTFkQ2gwYnpvZ1lubDBaWE1zSUdGdGIzVnVkRG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbVJ2VkhKaGJuTm1aWEpQZFhRNkNpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSjFibVJsY214NWFXNW5JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjFibVJsY214NWFXNW5JR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ016TWdMeThnYldWMGFHOWtJQ0owY21GdWMyWmxjaWhoWkdSeVpYTnpMSFZwYm5ReU5UWXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW5sMFpXTWdNemNnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESXdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCdFlYUmphQ0JrYjFSeVlXNXpabVZ5VDNWMFgzTjNhWFJqYUY5allYTmxYekJBTWlCa2IxUnlZVzV6Wm1WeVQzVjBYM04zYVhSamFGOWpZWE5sWHpGQU13b2dJQ0FnWlhKeUlDOHZJSEpsZG1WeWRBb0taRzlVY21GdWMyWmxjazkxZEY5emQybDBZMmhmWTJGelpWOHhRRE02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDZ3BrYjFSeVlXNXpabVZ5VDNWMFgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Ub0tJQ0FnSUdGemMyVnlkQ0F2THlCVVQwdEZUbDlVVWtGT1UwWkZVbDlQVlZSZlJrRkpURVZFQ2lBZ0lDQnlaWFJ6ZFdJS0NtUnZWSEpoYm5ObVpYSlBkWFJmYzNkcGRHTm9YMk5oYzJWZk1FQXlPZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdJZ1pHOVVjbUZ1YzJabGNrOTFkRjl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFVLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdTVzF0ZFhSaFlteGxMblJ5WVc1elptVnlWRzlyWlc1ektITndaVzVrWlhJNklHSjVkR1Z6TENCemNtTTZJR0o1ZEdWekxDQmtjM1E2SUdKNWRHVnpMQ0IwYjJ0bGJuTTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkSEpoYm5ObVpYSlViMnRsYm5NNkNpQWdJQ0J3Y205MGJ5QTBJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1OdmJYQjBjbTlzYkdWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCamIyMXdkSEp2Ykd4bGNpQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9UaG1PVEUxWW1ZZ0x5OGdiV1YwYUc5a0lDSjBjbUZ1YzJabGNrRnNiRzkzWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGUnlZVzV6Wm1WeVEyOXRjSFJ5YjJ4c1pYSlNaV3BsWTNScGIyNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0E5UFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGUnlZVzV6Wm1WeVRtOTBRV3hzYjNkbFpBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJRDA5Q2lBZ0lDQmllaUIwY21GdWMyWmxjbFJ2YTJWdWMxOWxiSE5sWDJKdlpIbEFOd29nSUNBZ1lubDBaV01nTWpZZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2dwMGNtRnVjMlpsY2xSdmEyVnVjMTloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJdENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltRmpZMjkxYm5SVWIydGxibk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE15QXZMeUFpWVdOamIzVnVkRlJ2YTJWdWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWlzS0lDQWdJR1JwWnlBekNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCaWVYUmxZeUF5TmlBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHSWhQUW9nSUNBZ1lub2dkSEpoYm5ObVpYSlViMnRsYm5OZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXlOeUF2THlBaWRISmhibk5tWlhKQmJHeHZkMkZ1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdKdmVGOXdkWFFLQ25SeVlXNXpabVZ5Vkc5clpXNXpYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpZkFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXlNQ0F2THlCdFpYUm9iMlFnSWxSeVlXNXpabVZ5S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ25SeVlXNXpabVZ5Vkc5clpXNXpYMlZzYzJWZlltOWtlVUEzT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXlOeUF2THlBaWRISmhibk5tWlhKQmJHeHZkMkZ1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdJZ2RISmhibk5tWlhKVWIydGxibk5mWVdaMFpYSmZhV1pmWld4elpVQTRDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNWliM0p5YjNkQ1lXeGhibU5sVTNSdmNtVmtTVzUwWlhKdVlXd29ZV05qYjNWdWREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGliM0p5YjNkQ1lXeGhibU5sVTNSdmNtVmtTVzUwWlhKdVlXdzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXlPQ0F2THlBaVlXTmpiM1Z1ZEVKdmNuSnZkM01pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdNalVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nWW05eWNtOTNRbUZzWVc1alpWTjBiM0psWkVsdWRHVnlibUZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LWW05eWNtOTNRbUZzWVc1alpWTjBiM0psWkVsdWRHVnlibUZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWXlBeU5TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltSnZjbkp2ZDBsdVpHVjRJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmliM0p5YjNkSmJtUmxlQ0JsZUdsemRITUtJQ0FnSUdJcUNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JpTHdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUVsdGJYVjBZV0pzWlM1bGVHTm9ZVzVuWlZKaGRHVkRkWEp5Wlc1MEtDa2dMVDRnWW5sMFpYTTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1WlhoamFHRnVaMlZTWVhSbFEzVnljbVZ1ZERvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmYm05MFJXNTBaWEpsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWDI1dmRFVnVkR1Z5WldRZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RZ0x5OGdjbVV0Wlc1MFpYSmxaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNWhZMk55ZFdWSmJuUmxjbVZ6ZEFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmYm05MFJXNTBaWEpsWkNJS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZMkZzYkhOMVlpQmxlR05vWVc1blpWSmhkR1ZUZEc5eVpXUkpiblJsY201aGJBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1FbHRiWFYwWVdKc1pTNWxlR05vWVc1blpWSmhkR1ZUZEc5eVpXUkpiblJsY201aGJDZ3BJQzArSUdKNWRHVnpPZ3BsZUdOb1lXNW5aVkpoZEdWVGRHOXlaV1JKYm5SbGNtNWhiRG9LSUNBZ0lIQnliM1J2SURBZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKMGIzUmhiRk4xY0hCc2VTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJ2ZEdGc1UzVndjR3g1SUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqMDlDaUFnSUNCaWVpQmxlR05vWVc1blpWSmhkR1ZUZEc5eVpXUkpiblJsY201aGJGOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREkwSUM4dklDSnBibWwwYVdGc1JYaGphR0Z1WjJWU1lYUmxUV0Z1ZEdsemMyRWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHbHVhWFJwWVd4RmVHTm9ZVzVuWlZKaGRHVk5ZVzUwYVhOellTQmxlR2x6ZEhNS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0taWGhqYUdGdVoyVlNZWFJsVTNSdmNtVmtTVzUwWlhKdVlXeGZaV3h6WlY5aWIyUjVRREk2Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRU5oYzJoUWNtbHZjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luUnZkR0ZzUW05eWNtOTNjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4Q2IzSnliM2R6SUdWNGFYTjBjd29nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXJDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOTBZV3hTWlhObGNuWmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4U1pYTmxjblpsY3lCbGVHbHpkSE1LSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdNSGd3WkdVd1lqWmlNMkUzTmpRd01EQXdDaUFnSUNCaUtnb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0l2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1GalkzSjFaVWx1ZEdWeVpYTjBLQ2tnTFQ0Z1lubDBaWE02Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVlXTmpjblZsU1c1MFpYSmxjM1E2Q2lBZ0lDQndjbTkwYnlBd0lERUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWVdOamNuVmhiRUpzYjJOclRuVnRZbVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpQmxlR2x6ZEhNS0lDQWdJR0k5UFFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUVsdGJYVjBZV0pzWlM1aFkyTnlkV1ZKYm5SbGNtVnpkRjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNRWx0YlhWMFlXSnNaUzVoWTJOeWRXVkpiblJsY21WemRGOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEVOaGMyaFFjbWx2Y2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblJ2ZEdGc1FtOXljbTkzY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEc5MFlXeENiM0p5YjNkeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2ZEdGc1VtVnpaWEoyWlhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhSdmRHRnNVbVZ6WlhKMlpYTWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01URWdMeThnSW1KdmNuSnZkMGx1WkdWNElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaWIzSnliM2RKYm1SbGVDQmxlR2x6ZEhNS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdJbWx1ZEdWeVpYTjBVbUYwWlUxdlpHVnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnBiblJsY21WemRGSmhkR1ZOYjJSbGJDQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNelVnTHk4Z2JXVjBhRzlrSUNKblpYUkNiM0p5YjNkU1lYUmxLSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMktYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TkRoak1qY3pPVFV3TURBS0lDQWdJR0k4UFFvZ0lDQWdZWE56WlhKMElDOHZJR0p2Y25KdmR5QnlZWFJsSUdseklHRmljM1Z5Wkd4NUlHaHBaMmdLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmlmQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCdGRXeGZLRElwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmpZV3hzYzNWaUlHMTFiRjhvTWlrS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZbmwwWldNZ01UUWdMeThnTUhnd1pHVXdZalppTTJFM05qUXdNREF3Q2lBZ0lDQmlMd29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR0lyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbkpsYzJWeWRtVkdZV04wYjNKTllXNTBhWE56WVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21WelpYSjJaVVpoWTNSdmNrMWhiblJwYzNOaElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURRS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQnRkV3hmS0RJcENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR0o1ZEdWaklERTBJQzh2SURCNE1HUmxNR0kyWWpOaE56WTBNREF3TUFvZ0lDQWdZaThLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTJGc2JITjFZaUJoWkdSZktESXBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1JwWnlBMkNpQWdJQ0JqWVd4c2MzVmlJRzExYkY4b01pa0tJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z01IZ3daR1V3WWpaaU0yRTNOalF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCallXeHNjM1ZpSUdGa1pGOG9NaWtLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUZqWTNKMVlXeENiRzlqYTA1MWJXSmxjaUlLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmliM0p5YjNkSmJtUmxlQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpZEc5MFlXeENiM0p5YjNkeklnb2dJQ0FnWkdsbklETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjBiM1JoYkZKbGMyVnlkbVZ6SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pHbG5JRE1LSUNBZ0lHSjhDaUFnSUNCa2FXY2dOQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWkdsbklEUUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaR2xuSURRS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JpZkFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1OalprWVRJNFlTQXZMeUJ0WlhSb2IyUWdJa0ZqWTNKMVpVbHVkR1Z5WlhOMEtIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakJKYlcxMWRHRmliR1V1Y21Wa1pXVnRSbkpsYzJnb2NtVmtaV1Z0WlhJNklHSjVkR1Z6TENCeVpXUmxaVzFVYjJ0bGJuTkpiam9nWW5sMFpYTXNJSEpsWkdWbGJVRnRiM1Z1ZEVsdU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2NtVmtaV1Z0Um5KbGMyZzZDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqMDlDaUFnSUNCaWJub2djbVZrWldWdFJuSmxjMmhmWW05dmJGOTBjblZsUURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQmllaUJ5WldSbFpXMUdjbVZ6YUY5aWIyOXNYMlpoYkhObFFETUtDbkpsWkdWbGJVWnlaWE5vWDJKdmIyeGZkSEoxWlVBeU9nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0NuSmxaR1ZsYlVaeVpYTm9YMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Ym1VZ2IyWWdjbVZrWldWdFZHOXJaVzV6U1c0Z2IzSWdjbVZrWldWdFFXMXZkVzUwU1c0Z2JYVnpkQ0JpWlNCNlpYSnZDaUFnSUNCallXeHNjM1ZpSUdWNFkyaGhibWRsVW1GMFpWTjBiM0psWkVsdWRHVnlibUZzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lud0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWo0S0lDQWdJR0o2SUhKbFpHVmxiVVp5WlhOb1gyVnNjMlZmWW05a2VVQTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnYlhWc1h5Z3lLUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QXdlREJrWlRCaU5tSXpZVGMyTkRBd01EQUtJQ0FnSUdJdkNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvS2NtVmtaV1Z0Um5KbGMyaGZZV1owWlhKZmFXWmZaV3h6WlVBM09nb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSmpiMjF3ZEhKdmJHeGxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjl0Y0hSeWIyeHNaWElnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE01TnpRd1lqa3dJQzh2SUcxbGRHaHZaQ0FpY21Wa1pXVnRRV3hzYjNkbFpDaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTmlsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1VtVmtaV1Z0UTI5dGNIUnliMnhzWlhKU1pXcGxZM1JwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0poWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR0ZqWTNKMVlXeENiRzlqYTA1MWJXSmxjaUJsZUdsemRITUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYVhSdllnb2dJQ0FnWWlFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdVbVZrWldWdFJuSmxjMmh1WlhOelEyaGxZMnNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBRMkZ6YUZCeWFXOXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaVBBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRkpsWkdWbGJWUnlZVzV6Wm1WeVQzVjBUbTkwVUc5emMybGliR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWlkRzkwWVd4VGRYQndiSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJ2ZEdGc1UzVndjR3g1SUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0owYjNSaGJGTjFjSEJzZVNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltRmpZMjkxYm5SVWIydGxibk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdaR2xuSURRS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCa2IxUnlZVzV6Wm1WeVQzVjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklETUtJQ0FnSUdKOENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURJd0lDOHZJRzFsZEdodlpDQWlWSEpoYm5ObVpYSW9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRZeVpEYzVZeklnTHk4Z2JXVjBhRzlrSUNKU1pXUmxaVzBvWVdSa2NtVnpjeXgxYVc1ME1qVTJMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVkyOXRjSFJ5YjJ4c1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiWEIwY205c2JHVnlJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGxabUprTWpGa09DQXZMeUJ0WlhSb2IyUWdJbkpsWkdWbGJWWmxjbWxtZVNoaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaXgxYVc1ME1qVTJLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJSEpsZEhOMVlnb0tjbVZrWldWdFJuSmxjMmhmWld4elpWOWliMlI1UURZNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdaR2wyWHlneUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnY21Wa1pXVnRSbkpsYzJoZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2dweVpXUmxaVzFHY21WemFGOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnlaV1JsWlcxR2NtVnphRjlpYjI5c1gyMWxjbWRsUURRS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG5KbGNHRjVRbTl5Y205M1JuSmxjMmdvY0dGNVpYSTZJR0o1ZEdWekxDQmliM0p5YjNkbGNqb2dZbmwwWlhNc0lISmxjR0Y1UVcxdmRXNTBPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbkpsY0dGNVFtOXljbTkzUm5KbGMyZzZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVkyOXRjSFJ5YjJ4c1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiWEIwY205c2JHVnlJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hPREZqT1dGa015QXZMeUJ0WlhSb2IyUWdJbkpsY0dGNVFtOXljbTkzUVd4c2IzZGxaQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMktYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaWEJoZVVKdmNuSnZkME52YlhCMGNtOXNiR1Z5VW1WcVpXTjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV05qY25WaGJFSnNiMk5yVG5WdFltVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmhZMk55ZFdGc1FteHZZMnRPZFcxaVpYSWdaWGhwYzNSekNpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJR0loUFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGSmxjR0Y1UW05eWNtOTNSbkpsYzJodVpYTnpRMmhsWTJzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMkZzYkhOMVlpQmliM0p5YjNkQ1lXeGhibU5sVTNSdmNtVmtTVzUwWlhKdVlXd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTWdNallnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaVBUMEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdaRzlVY21GdWMyWmxja2x1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdaR2xuSURFS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblJ2ZEdGc1FtOXljbTkzY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEc5MFlXeENiM0p5YjNkeklHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1JwWnlBeUNpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXlPQ0F2THlBaVlXTmpiM1Z1ZEVKdmNuSnZkM01pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdNalVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaR2xuSURVS0lDQWdJR0o4Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltSnZjbkp2ZDBsdVpHVjRJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmliM0p5YjNkSmJtUmxlQ0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTJDaUFnSUNCaWZBb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hDYjNKeWIzZHpJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWW53S0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdKOENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WVdRMk0yVTBaalFnTHk4Z2JXVjBhRzlrSUNKU1pYQmhlVUp2Y25KdmR5aGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyVnBlbVZKYm5SbGNtNWhiQ2h6WldsNlpYSlViMnRsYmpvZ1lubDBaWE1zSUd4cGNYVnBaR0YwYjNJNklHSjVkR1Z6TENCaWIzSnliM2RsY2pvZ1lubDBaWE1zSUhObGFYcGxWRzlyWlc1ek9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2MyVnBlbVZKYm5SbGNtNWhiRG9LSUNBZ0lIQnliM1J2SURRZ01Bb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSmpiMjF3ZEhKdmJHeGxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjl0Y0hSeWIyeHNaWElnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREptWkdSalpUbG1JQzh2SUcxbGRHaHZaQ0FpYzJWcGVtVkJiR3h2ZDJWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1RHbHhkV2xrWVhSbFUyVnBlbVZEYjIxd2RISnZiR3hsY2xKbGFtVmpkR2x2YmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lEMDlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVEdseGRXbGtZWFJsVTJWcGVtVk1hWEYxYVdSaGRHOXlTWE5DYjNKeWIzZGxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURZek56bGtZVEExWWpZd01EQXdDaUFnSUNCallXeHNjM1ZpSUcxMWJGOG9NaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHTmhiR3h6ZFdJZ1pYaGphR0Z1WjJWU1lYUmxVM1J2Y21Wa1NXNTBaWEp1WVd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBekNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdiWFZzWHlneUtRb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBd2VEQmtaVEJpTm1JellUYzJOREF3TURBS0lDQWdJR0l2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkRzkwWVd4U1pYTmxjblpsY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEc5MFlXeFNaWE5sY25abGN5QmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0JpS3dvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEc5MFlXeFNaWE5sY25abGN5SUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSjBiM1JoYkZOMWNIQnNlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4VGRYQndiSGtnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLd29nSUNBZ1pHbG5JRFFLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdJblJ2ZEdGc1UzVndjR3g1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaVlXTmpiM1Z1ZEZSdmEyVnVjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSmhZMk52ZFc1MFZHOXJaVzV6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURRS0lDQWdJR0lyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklEUUtJQ0FnSUdKOENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJREl3SUM4dklHMWxkR2h2WkNBaVZISmhibk5tWlhJb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZbndLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXlNQ0F2THlCdFpYUm9iMlFnSWxSeVlXNXpabVZ5S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeUNpQWdJQ0JpZkFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdKOENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXpOQ0F2THlCdFpYUm9iMlFnSWxKbGMyVnlkbVZ6UVdSa1pXUW9ZV1JrY21WemN5eDFhVzUwTWpVMkxIVnBiblF5TlRZcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQkpiVzExZEdGaWJHVXVYM05sZEVOdmJYQjBjbTlzYkdWeUtHNWxkME52YlhCMGNtOXNiR1Z5T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpCSmJXMTFkR0ZpYkdVdVgzTmxkRU52YlhCMGNtOXNiR1Z5T2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHRmtiV2x1SUdWNGFYTjBjd29nSUNBZ0lUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWlhSRGIyMXdkSEp2Ykd4bGNrOTNibVZ5UTJobFkyc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKamIyMXdkSEp2Ykd4bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1kyOXRjSFJ5YjJ4c1pYSWdaWGhwYzNSekNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0Rrd05EWmhZV01nTHk4Z2JXVjBhRzlrSUNKcGMwTnZiWEIwY205c2JHVnlLQ2xpYjI5c0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JoYzNObGNuUWdMeThnYldGeWEyVnlJRzFsZEdodlpDQnlaWFIxY201bFpDQm1ZV3h6WlFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTI5dGNIUnliMnhzWlhJaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE56VmlOakpsTXpnZ0x5OGdiV1YwYUc5a0lDSk9aWGREYjIxd2RISnZiR3hsY2loaFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTGw5elpYUkpiblJsY21WemRGSmhkR1ZOYjJSbGJFWnlaWE5vS0c1bGQwbHVkR1Z5WlhOMFVtRjBaVTF2WkdWc09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsOXpaWFJKYm5SbGNtVnpkRkpoZEdWTmIyUmxiRVp5WlhOb09nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR0ZrYldsdUlHVjRhWE4wY3dvZ0lDQWdJVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCVFpYUkpiblJsY21WemRGSmhkR1ZOYjJSbGJFOTNibVZ5UTJobFkyc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaFkyTnlkV0ZzUW14dlkydE9kVzFpWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdGalkzSjFZV3hDYkc5amEwNTFiV0psY2lCbGVHbHpkSE1LSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lpRTlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVTJWMFNXNTBaWEpsYzNSU1lYUmxUVzlrWld4R2NtVnphRU5vWldOckNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UWWdMeThnSW1sdWRHVnlaWE4wVW1GMFpVMXZaR1ZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJwYm5SbGNtVnpkRkpoZEdWTmIyUmxiQ0JsZUdsemRITUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE56azJZV1UwTVNBdkx5QnRaWFJvYjJRZ0ltbHpTVzUwWlhKbGMzUlNZWFJsVFc5a1pXd29LV0p2YjJ3aUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJ0WVhKclpYSWdiV1YwYUc5a0lISmxkSFZ5Ym1Wa0lHWmhiSE5sQ2lBZ0lDQmllWFJsWXlBeE5pQXZMeUFpYVc1MFpYSmxjM1JTWVhSbFRXOWtaV3dpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WWpoaU9ERmpaRE1nTHk4Z2JXVjBhRzlrSUNKT1pYZE5ZWEpyWlhSSmJuUmxjbVZ6ZEZKaGRHVk5iMlJsYkNoaFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1Ga1pGOG9NaWtvWVRvZ1lubDBaWE1zSUdJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1lXUmtYeWd5S1RvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JqWVd4c2MzVmlJR0ZrWkY4b01pa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd1NXMXRkWFJoWW14bExtMTFiRjhvTWlrb1lUb2dZbmwwWlhNc0lHSTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tiWFZzWHlneUtUb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCallXeHNjM1ZpSUcxMWJGOG9NaWtLSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TUdSbE1HSTJZak5oTnpZME1EQXdNQW9nSUNBZ1lpOEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd1NXMXRkWFJoWW14bExtUnBkbDhvTWlrb1lUb2dZbmwwWlhNc0lHSTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taR2wyWHlneUtUb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCcGRHOWlDaUFnSUNCallXeHNjM1ZpSUcxMWJGOG9NaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCallXeHNjM1ZpSUdScGRsOG9NaWtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3U1cxdGRYUmhZbXhsTG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUZBQ0FCQm9DQWtMdTYxcTN3RFNZbUFBdGZibTkwUlc1MFpYSmxaQVFWSDN4MUlRRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFWaFpHMXBiaEpoWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElMWTI5dGNIUnliMnhzWlhJTmRHOTBZV3hTWlhObGNuWmxjeVFWSDN4MUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFNZEc5MFlXeENiM0p5YjNkeklBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQzJKdmNuSnZkMGx1WkdWNEMzUnZkR0ZzVTNWd2NHeDVEV0ZqWTI5MWJuUlViMnRsYm5NSURlQzJzNmRrQUFBS2RXNWtaWEpzZVdsdVp4RnBiblJsY21WemRGSmhkR1ZOYjJSbGJBeHdaVzVrYVc1blFXUnRhVzRWY21WelpYSjJaVVpoWTNSdmNrMWhiblJwYzNOaEJJTzYxOHdFS0pHSVlRUnVZVzFsQm5ONWJXSnZiQWhrWldOcGJXRnNjeHRwYm1sMGFXRnNSWGhqYUdGdVoyVlNZWFJsVFdGdWRHbHpjMkZBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNELy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8veEowY21GdWMyWmxja0ZzYkc5M1lXNWpaWE1PWVdOamIzVnVkRUp2Y25KdmQzTUVkcnRSc2dSR1FseDhCRkFrTSs4RWVmcTBaUVNmcTJLNUJQa1JJcUVFME9rcExRU2grbm1KSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdNUmhBQUcwcEltY25GU2huSnhZb1p5Y1hJbWNuQkNjS1p5Y1JKd3BuSndZbkNtY25FQ2NLWnljWUtHY25FaWhuSndVb1p5Y0xLR2NuQ1Nobkp3Y29aeWNNS0djbkR5Y0taellhQURZYUFUWWFBallhQXpZYUJEWWFCVFlhQmhjMkdnY25CREVBWjA0SGlBemRKd1JNWnlSRE1Sa1VSREVZUklJUUJGeStld0VFaE1XMGhBVHpySTg4QkpBTXZqTUVzUU5XV3dSNjA0Zi9CQktYRWY0RXRaYkx3d1JneXZoUEJIQzd3bEVFcHA3TWZnUlcycVc5QkJtTW1DQUViZlFmYlFUNisyb0lCRjJGVFE0bkU0SUtCSjhEWW5rRWorK3JSQVJUbitHaEJPcVQyUjBFbXRTWlpBUm41K3orQktESU5QOEVZZlVHMVFTbEhvcFhCT1oxK1hJbkhTY2VnZzhFc1BOZUN3UnR6WWxVQko5VzFrRUV4clRVYmdSWWs2dUNCT1hBaC9nRVljUEI3d1FaZFFZV0JBQmJVcmdFdUhlZTV3UUtUN2F6QlBxWXpRTUVKcG9RQ3dRRldnbkVCRGt6cytjbkg0SURCTUNuVWE4RWhIUTRUd1JRYkR6U0p5QTJHZ0NPTVFBQkFGSUJJd0ZKQVc0Q1dRSitBcW9FWGdTL0JSNEZVQVgwQmlVR1d3YWFCc01HNHdjYUIyRUh4d2hFQ0dZSWpnaW5DTGdJeVFqYUNPc0pHZ2xDQ1lFSm1nbjhDb01Lb0FxckNyNEswUXJkQ3VnSzh3citDd2tMSEFzdkMwSUxWUXRvQURZYUFVa1ZJeEpFTmhvQ1NSVWpFa1EyR2dOSkZTTVNSRFlhQkVrVkl4SkVOaG9GU1NKWmdRSUlTd0VWRWtSWEFnQTJHZ1pKSWxtQkFnaExBUlVTUkZjQ0FEWWFCMGtWZ1FnU1JCZUlDeXNrUXpZYUFVa1ZJeEpFSWlsbFJFUXBJbWVJRGVSSU1RQ3hNZ29qcjBsTEJGQkpGU01KSTFnaUp3WmxSSUVZV3lXeUVDS3lHU0t5QWJJWWdBU3JOa25qc2hwUEFySWFTd0t5R3JJYXM3UStWd1FBS0trVVJDSW5CV1ZFTWdZV3FSUkVpQTFpU1JVakRrUkxBYXRMQWs4RWlBdFlTVThDaUJMT0lpY01aVVJMQWFBbkRFeG5Td01CSncxTVVFbStLRTRDVFVzQ29Fc0J2RWkvU3dFVkl3NUVURXNDcTBzQkZTTU9SRXhQQXF0TEFrOENVRXNCVUlBRVIvMUJha3hRc0RJS1R3SlFURkFuRkV4UXNDa2taeWNJc0NSRE5ob0JTUlVqRWtRaUtXVkVSQ2tpWjRnTkUwZ3hBQ0lXVEU0Q2lBNDFLU1JuSndpd0pFTTJHZ0ZKRlNNU1JDSXBaVVJFS1NKbmlBenRTREVBSWhaUEFvZ09FQ2trWnljSXNDUkROaG9CU1JWSkl4SkVJaWxsUkVRcEltZUlETWRJTVFDeE1nb2pyMGxMQlZCSkZTTUpJMWdpSndabFJJRVlXeVd5RUNLeUdTS3lBYklZZ0FTUmt4MFlzaHBQQXJJYVN3S3lHcklhczdRK1Z3UUFLS2tVUkNJbkJXVkVNZ1lXcVJSRWlBb21Td1NrRkVSTEFZZ0w4a3NFb0NJbkNXVkVTd1dnU3dNQkp4eE1VRW0rSnhsT0FrMVhJQ0JMQXhVakRrUlBBMHNFcTBsUEFsQWlKd3RsUkVrVkl3NUVTd1dyVEZjQUlFeFFUd0pNdnljSlN3Sm5Td05MQm9nS2gwOEVJdzVFVHdSTEE2dExBaFVqRGtSUEFrOERxMDhEVHdKUVR3SlFURkNBQk9mb1FxeE1VTEFwSkdjbkNMQWtRellhQVVrVkl4SkVJaWxsUkVRcEltZUlDOTFJTVFCSlR3S0lEanhJS1NSbkp3aXdKRU0yR2dGSkZTTVNSRFlhQWtrVkl4SkVJaWxsUkVRcEltZUlDN0JJTVFCT0FvZ09FRWdwSkdjbkNMQWtRellhQVVjQ0ZTTVNSRFlhQWtrVkl4SkVOaG9EU1U0RFNSVWpFa1FpS1dWRVJDa2laNGdMZUVpeFNZRVlXMGxPQkNXeUVDS3lHU0t5QVVteUdDY2RzaHF6dEQ1WEJBQW9xUlJFTVFCSlRnV3hNZ29qcjBsT0IwbExCbEJKRlNNSkkxZ2lKd1psUklFWVd5V3lFQ0t5R1NLeUFiSVlnQVNzZjAzSXNocFBBcklhU3dTeUdrc0NzaHBMQnJJYXNocXp0RDVYQkFBb3FSUkVJaWNGWlVReUJoYXBGRVN4SmJJUUlySVpJcklCU3dLeUdDY2ZzaHF6dEQ1WEJBQXlCaGFwRkVSTEJVc0NFaFJFU3dRb3FCUkVTd1FuR3FnVVJFeExCVThGaUEwcVNVNEZzVElLVGdKUVNSVWpDU05ZSWljR1pVU0JHRnNsc2hBaXNoa2lzZ0d5R0lBRS94RENRYklhVExJYVN3S3lHcklhczdRK1Z3UWd0RDVYSkNCSlRnSk9CU2lvUkxFbHNoQWlzaGtpc2dGTXNoZ25FN0lhVHdLeUdyTzBQbGNFQUtaRU1nb1NRUUE3TWdwTEJFc0lTd09JRFpwTEFVa1ZJdzVFU3dOSlRnS3JTd0pQQXF0TEJVc0pVRThDVUVzSFVFeFFnQVJ5aFdDVFRGQ3dLU1JuSndpd0pFT3hTd0pMQVZCSkZTTUpJMWdsc2hBaXNoa2lzZ0ZMQmJJWUp4NnlHa3NFc2hwTEI3SWFzaHF6dEQ1WEJBQW9xRVJDLzUwMkdnRkpGU01TUkRFQUlpY0VaVVJNU3dFU1JDSW5EMlZFU3dJVFJMRXlDazhDZ1JoYkpiSVFJcklaSXJJQlNiSVlKeE95R2t5eUdyTzBQbGNFQUxFanIweFFTUlVqQ1NOWUpiSVFJcklaSXJJQlRMSVlKeUd5R2t5eUdySWFzeVJETmhvQlNSVWpFa1FpS1dWRVJDa2laNGdKZDBnaUp3VmxSRElHRnFrVVJERUFUSWdITnlJbkIyVkVTd0dnSndkTEFXZExBUlVqRGtRanIwOENTd0dyTVFCTEF4VWpEa1JQQTA4RHEweFBBbEJNVUNjaVRGQ3dLU1JuSndpd0pFTTJHZ0ZKRlNNU1JERUFJaWNFWlVRU1JMRWlKdzlsUklFWVd5V3lFQ0t5R1NLeUFiSVlnQVN6dGw4b3NocXlHck1rUXpZYUFVa1ZJeEpFTmhvQ1NSVWpFa1EyR2dOSkZTTVNSRFlhQkVraVdZRUNDRXNCRlJKRVZ3SUFOaG9GU1NKWmdRSUlTd0VWRWtSWEFnQTJHZ1pKRllFSUVrUVhNUUFpSndSbFJCSkVJaWNGWlVRb3FFRUFTU0luQzJWRUtLaEJBRDhrUkNjWVN3UkpUZ0puS0tWRVN3V0lEUVFvcUVReUJoWW5CVXhuSVFRV0p3dE1aMHNFaUEwMktLaEVKeFZMQTJjbkZrc0NaeWNYU3dGbktTUm5KRU1pUXYrK05ob0JTUlVqRWtRMkdnSkpGU01TUkNJcFpVUkVLU1JuTVFCSlR3TlBBNGdHM3lpb2dBRUFJazhDVkNwTVVMQWtRellhQVVrVkl4SkVOaG9DU1JVakVrUTJHZ05KRlNNU1JDSXBaVVJFS1NSbk1RQk9BNGdHcVNpb2dBRUFJazhDVkNwTVVMQWtRellhQVVrVkl4SkVOaG9DU1JWSkl4SkVNUUJQQTFCSkFTY2JURkJKdkVoTEE3OU1JdzVFSTY5UEFxdFFnQVFZNEpSaFRGQ3dnQVVWSDN4MWdMQWtRellhQVVrVkl4SkVOaG9DU1JVakVrUlFBU2NiVEZDK0tFNENUVWtWSXc1RUk2K3JLa3hRc0NSRE5ob0JTUlVqRWtRQkp3MU1VTDRvVGdKTlNSVWpEa1FqcjZzcVRGQ3dKRU0yR2dGSkZTTVNSSWdIRlVrVkl3NUVJNjlNU3dHclR3SUJKdzFNVUw0b1RnSk5pQXh6VndBZ0p3NmlTUlVqRGtTcktreFFzQ1JETmhvQlNSVWpFa1JKQVNjTlRGQytLRTRDVFV5SUJweUlCdUlqcjBzREZTTU9SRThEU3dHckp3cE1VRXNERlNNT1JFOERTd0tyVUVzQ0ZTTU9SRTRDcTFBcVRGQ3dKRU94STYrSUJKQkxBVXhRaUFTSlN3Sk1VQlVqQ1NOWUlpY0paVVJMQWt4UVNSVWpDU05ZSWljSFpVUkxBMHhRU1JVakNTTllJaWNRWlVTQkdGc2xzaEFpc2hraXNnR3lHQ2Nqc2hwUEFySWFUTElhc2hxenRENVhCQUJKRlNNT1JLc3FURkN3SkVPeEk2K0lCQ3BMQVV4UWlBUWpTd0pNVUJVakNTTllJaWNKWlVSTEFreFFTUlVqQ1NOWUlpY0haVVJMQTB4UVNSVWpDU05ZSWljU1pVUkxCRXhRU1JVakNTTllJaWNRWlVTQkdGc2xzaEFpc2hraXNnR3lHSUFFMnoxL1NySWFUd095R2s4Q3NocE1zaHF5R3JPMFBsY0VBRWtWSXc1RXF5cE1VTEFrUXlJcFpVUkVLU0puaUFYNlNDa2taeUluQ1dWRVNSVWpEa1FqcjZzcVRGQ3dKRU0yR2dGSkZTTVNSQ0lwWlVSRUtTSm5pQVhRU0Nra1o0Z0ZUVWtWSXc1RUk2K3JLa3hRc0NSRE5ob0JTUlVqRWtTSUJUUkpGU01PUkNPdnF5cE1VTEFrUTRnRldVa1ZJdzVFSTYrcktreFFzQ1JEaUFWYlNSVWpEa1FqcjZzcVRGQ3dKRU9JQXl0SkZTTU9SQ092cXlwTVVMQWtRNGdGYkVrVkl3NUVJNityS2t4UXNDUkROaG9CU1JVakVrUTJHZ0pKRlNNU1JEWWFBMGtWSXhKRUlpbGxSRVFwSW1jeEFFNERpQWlES1NSbkp3aXdKRU0yR2dGSkZTTVNSREVBSWljRVpVUVRGRVFpSnhGbFJDY1JTd0puVEZBbkpFeFFzQ2NJc0NSRE1RQWlKeEZsUkV4TEFSTVVSREVBSndvU0ZFUWlKd1JsUkNjRVN3Sm5KeEVuQ21jaUp3UmxSRkNBQk1Eajg4OU1VTEFuQ2xBbkpFeFFzQ2NJc0NSRE5ob0JTUlVqRWtTSUNUdEpGU01PUkNPdnF5cE1VTEFrUXpZYUFVa1ZTU01TUkNJcFpVUkVLU0puaUFTYlNDa2taekVBSWljRVpVUVRGRVFpSndWbFJESUdGcWtVUkVzQkp3NmxGRVFpSnhKbFJDY1NTd05uVENNT1JDT3ZUd0pMQWF0TEFoVWpEa1JPQXF0TVVJQUVVUStnOEV4UXNDY0lzQ1JETmhvQlNSVkpJeEpFSWlsbFJFUXBJbWVJQkRsSUtTUm5NUUFpSndSbFJCTVVSQ0luQldWRU1nWVdxUlJFaUFITFN3S2tGRVFpSndkbFJFc0NTd0dsRkVRcm9Fc0NvU3VxSndkTEFXY2lKd1JsUkVzRGlBSmRJaWNFWlVSTEFSVWpEa1FqcjA4Q1N3R3JUd01qRGtSUEEwOENxMDhDVEZCTVVJQUUxdkxFbkV4UXNDY0lzQ1JETmhvQlNSVWpFa1NJQTd0SWlBaDlTUlVqRGtRanI2c3FURkN3SkVNaUp3OWxSQ3BNVUxBa1F5SW5GV1ZFU1JVV1Z3WUNURkFxVEZDd0pFTWlKeFpsUkVrVkZsY0dBa3hRS2t4UXNDUkRJaWNYWlVRV0treFFzQ1JESWljRVpVUXFURkN3SkVNaUp4RmxSQ3BNVUxBa1F5SW5CbVZFS2t4UXNDUkRJaWNRWlVRcVRGQ3dKRU1pSnhKbFJFa1ZJdzVFSTYrcktreFFzQ1JESWljRlpVUkpGU01PUkNPdnF5cE1VTEFrUXlJbkMyVkVTUlVqRGtRanI2c3FURkN3SkVNaUp3bGxSRWtWSXc1RUk2K3JLa3hRc0NSRElpY0haVVJKRlNNT1JDT3ZxeXBNVUxBa1F5SW5ER1ZFU1JVakRrUWpyNnNxVEZDd0pFT0tCd0F4QUNJbkJHVkVFa1FpSndWbFJDaW9RUUJpSWljTFpVUW9xRUVBV0NSRUp4aUwvR2VML0NpbFJJdjZpQWNiS0toRU1nWVdKd1ZNWnlFRUZpY0xUR2VMKzRnSFRTaW9SQ2NWaS8xbkp4YUwvbWNuRjR2L1p5a2taeWNQaS9sbnNZdjVnUmhiSmJJUUlySVpJcklCc2hnbklMSWFzNGtpUXYrbElpY1BaVVN4TWdwTWdSaGJKYklRSXJJWklySUJzaGduRTdJYXNocXp0RDVYQkFDSmlnSUJJa2tuRDJWRXNUSUtUSUVZVzBsT0FpV3lFQ0t5R1NLeUFVbXlHQ2NUc2hwTXNocXp0RDVYQkFCTXNUSUtJNitMLzFCSkZTTUpJMWdsc2hBaXNoa2lzZ0ZQQXJJWWdBUzNQcUxmc2hxTC9ySWFUTElhc2hxekp3b25KU2lPQWdBc0FBRUFpd0FvcVVTeE1nb2xzaEFpc2hraXNnR0xBYklZSnhPeUdySWFzN1ErVndRQUs2Q0xBcUVycW93QWlTUkMvOVdLQWdBaVNTY1BaVVN4STYrTC8xQkpGU01KSTFoTWdSaGJKYklRSXJJWklySUJzaGduSWJJYWkvNnlHcklhc3ljS0p5VW9qZ0lBQndBQkFJc0FLS2xFaVNSQy8vcUtCQUVpc1RJS0k2OUpUZ0tMLzFCSkZTTUpJMWdpSndabFJJRVlXeVd5RUNLeUdTS3lBYklZZ0FTWStSVy9zaHBNc2hxTC9iSWFpLzZ5R3JJYXM3UStWd1FBS0trVVJJdjlpLzRTRkVTTC9JdjlFa0VBY0NjYVNTdWdpLytoSzZxTUFJdjlBU2NOVEZCSnZpaE9BazByb0l2L29TdXFpLzRCSncxTVVFbStLRTRDVFl2L29Fc0R2RWhQQTA4RHYwc0J2RWkvSnhxcFFRQVFpLzJML0ZBQkp4dE1VRW04U0lzQXY0di9GU01PUkl2L2l3R3JpLzJML2xCTVVDY1VURkN3SWhhTUFJbUwvWXY4VUFFbkcweFF2aWhPQWsxQy80Q0tBUUdML3dFbkhFeFFTYjRuR1U0Q1RWY0FJQ2lvUVFBRUloWk1pWXNBdmljWlRnSk5TVmNBSUNJbkMyVkVvMHhYSUNDaVRJa2lLV1ZFUkNraVo0Z0FPMGdwSkdlSUFBR0ppZ0FCSWljTVpVeEpUd0pFS0toQkFBY2lKeGhsUkV5SmlQM0dJaWNKWlVTZ0s2QWlKd2RsUktFcnFpY09vNHNBb2t5SmlnQUJNZ1lXU1NJbkJXVk1TVTRDVGdORXFFRUFCU0lXakFDSmlQMlFJaWNKWlVRaUp3ZGxSQ0luQzJWRXNTT3ZTVXNGVUVrVkl3a2pXRXNCU3dWUVNSVWpDU05ZU3dKTEJWQkpGU01KSTFnaUp4QmxSSUVZV3lXeUVDS3lHU0t5QWJJWUp5T3lHazhDc2hwTXNocXlHck8wUGxjRUFFbUFCZ1NNSnpsUUFLWkVpd0JKVGdNcm9Jc0JvU3VxU3dFVkl3NUVURXNDcTB5SUJKZEpTd2FJQkpGWEFDQW5EcUpKVHdlZ0lpY1NaVVJKRlNNT1JFc0VxMHNDaUFSMVZ3QWdKdzZpVHdlSUJGRlBBMHNHaUFSalZ3QWdKdzZpVHdhSUJEOG5CVThHWnljTFN3Rm5Kd2xMQTJjbkIwOENaMGtWSXc1RVN3T3JTd1FWSXc1RVR3UkxCS3RMQXhVakRrUlBBMHNFcTBzREZTTU9SRThEVHdTclRnSlFUd0pRVEZDQUJQWnRvb3BNVUxBaUZvd0FpWW9EQUNKSmkvNG9xRUFBQjR2L0tLaEJBU1FrUklqK2lFa1ZJdzVFSTY5SmpBQ3JpLzRvcFVFQkFJditpQVBXVndBZ0p3NmlqQUdML3JFeUNvc0FTVTRDVHdOSlRnTlFTUlVqQ1NOWUlpY0daVVNCR0ZzbHNoQWlzaGtpc2dHeUdJQUVPWFFMa0xJYVRMSWFpLzJ5R2tteUdyTzBQbGNFQUNpcEZFUWlKd1ZsUkRJR0Zxa1VSSWo3OTRzQlNVNENwQlJFSWljTVpVUXJvRXNEb1N1cUp3eE1aNHY5QVNjTlRGQkp2aWhPQWswcm9Fc0VvU3VxU3dHOFNMK0wvVXNCaVB4NFN3SVZJdzVFVHdKTEE2dUwvVElLVUVzQlVDY1VURkN3U3dFVkl3NUVTd0ZMQkt1TC9VeFFURkNBQkJZdGVjSk1VTEN4TWdwUEEwOENVRWtWSXdraldDSW5CbVZFZ1JoYkpiSVFJcklaSXJJQnNoaUFCTys5SWRpeUdreXlHb3Y5c2hxeUdySWFzNG1MLzB5SUF2R0wvNHdCUXY4Q0lrTCsyWW9EQWJFeUNpT3ZTWXYvVUVrVkl3a2pXQ0luQm1WRWdSaGJKYklRSXJJWklySUJzaGlBQkJnY210T3lHazhDc2hxTC9iSWFpLzZ5R3JJYXM3UStWd1FBS0trVVJDSW5CV1ZFTWdZV3FSUkVpLzZJL01lTC95Y2FxSXYvU3dKUEFrMkwvVXlJK3dOTUs2QkxBYUVycWlJbkNXVkVLNkJMQXFFcnFvditBU2NjVEZCSnZpY1pUZ0pOVnlBZ1N3TVZJdzVFVHdOTEJhdEpUd0pRSWljTFpVUkpGU01PUkVzR3EweFhBQ0JNVUU4Q1RMOG5DVXNDWjBzQ0ZTTU9SRXNDU3dTclN3SVZJdzVFVHdKUEJLdUwvWXYrVUU4Q1VFOENVRXhRZ0FTdFkrVDBURkN3aVlvRUFMRXlDaU92U1l2L1VFa1ZJd2tqV0NJbkJtVkVnUmhiSmJJUUlySVpJcklCc2hpQUJDL2R6cCt5R2s4Q3NocUwvTElhaS8yeUdvditzaHF5R3JPMFBsY0VBQ2lwRkVTTC9vdjlFaFJFaS8rQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCamVkb0Z0Z0FBaUFGdmkvOHJvRXNCb1N1cWlQditTUlVqRGtSTEE2dExBb2dCVmxjQUlDY09vaUluQjJWRVN3R2dKd2RMQVdjaUp3eGxSQ3VnU3dTaEs2b25ERXhuaS80Qkp3MU1VRW0rS0U0Q1RTdWdpLytoSzZwTEFieEl2NHY5QVNjTlRGQkp2aWhPQWsxTEJLQkxBYnhJdjBzQ0ZTTU9SRThDU3dTcmkvNkwvVkJNVUNjVVRGQ3dTd0lWSXc1RVR3SkxBNnVML2pJS1VFeFFKeFJNVUxCTEFSVWpEa1JNU3dLck1ncExBaFVqRGtSUEFrOERxMHhQQWxCTVVDY2lURkN3aVlvQkFURUFJaWNFWlVRVEZFUWlKd1psUkxHTC80RVlXeVd5RUNLeUdTS3lBYklZZ0FTSkJHcXNzaHF6dEQ1WEJBQWlVMFFuQm92L1o0di9VSUFFZGJZdU9FeFFzQ0lXaVlvQkFURUFJaWNFWlVRVEZFUWlKd1ZsUkRJR0Zxa1VSQ0luRUdWRXNZdi9nUmhiSmJJUUlySVpJcklCc2hpQUJCZVdya0d5R3JPMFBsY0VBQ0pUUkNjUWkvOW5pLzlRZ0FTNHVCelRURkN3SWhhSmlnSUJpLzVYQUNDTC8xY0FJSWovOEVrVkl3NUVJNityaVlvQ0FZditWd0FnaS85WEFDQ0kvL0FuRHFKSkZTTU9SQ092cTRtS0FnR0wvbGNBSUNFRUZvai8xb3YvVndBZ2lQL3FTUlVqRGtRanI2dUoiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJOZXdDb21wdHJvbGxlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRDb21wdHJvbGxlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0NvbXB0cm9sbGVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJOZXdNYXJrZXRJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0ludGVyZXN0UmF0ZU1vZGVsIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJNaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbnRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW50QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbnRUb2tlbnMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlZGVlbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRlZW1lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRlZW1BbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVkZWVtVG9rZW5zIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJCb3Jyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRCb3Jyb3dzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVwYXlCb3Jyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBheUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50Qm9ycm93cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbEJvcnJvd3MiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlc2VydmVzQWRkZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmVuZWZhY3RvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRBbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VG90YWxSZXNlcnZlcyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTGlxdWlkYXRlQm9ycm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpcXVpZGF0b3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBheUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNUb2tlbkNvbGxhdGVyYWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VpemVUb2tlbnMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik5ld1BlbmRpbmdBZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRQZW5kaW5nQWRtaW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdQZW5kaW5nQWRtaW4iLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik5ld0FkbWluIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9sZEFkbWluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QWRtaW4iLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik5ld1Jlc2VydmVGYWN0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9sZFJlc2VydmVGYWN0b3JNYW50aXNzYSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdSZXNlcnZlRmFjdG9yTWFudGlzc2EiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlc2VydmVzUmVkdWNlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWR1Y2VBbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VG90YWxSZXNlcnZlcyIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
