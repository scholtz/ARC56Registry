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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.CErc20_c2df1789
{


    //
    //  @title Compound's CErc20 Contract
    // @notice CTokens which wrap an EIP-20 underlying
    // @author Compound
    //
    public class CErc20Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CErc20Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ0VyYzIwIiwiZGVzYyI6IiBAdGl0bGUgQ29tcG91bmQncyBDRXJjMjAgQ29udHJhY3RcbiBAbm90aWNlIENUb2tlbnMgd2hpY2ggd3JhcCBhbiBFSVAtMjAgdW5kZXJseWluZ1xuIEBhdXRob3IgQ29tcG91bmQiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQm9ycm93U25hcHNob3QiOlt7Im5hbWUiOiJwcmluY2lwYWwiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImludGVyZXN0SW5kZXgiLCJ0eXBlIjoidWludDI1NiJ9XSwiR2V0QWNjb3VudFNuYXBzaG90UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOiIgQG5vdGljZSBJbml0aWFsaXplIHRoZSBuZXcgbW9uZXkgbWFya2V0XG4gQHBhcmFtIHVuZGVybHlpbmdfIFRoZSBhZGRyZXNzIG9mIHRoZSB1bmRlcmx5aW5nIGFzc2V0XG4gQHBhcmFtIGNvbXB0cm9sbGVyXyBUaGUgYWRkcmVzcyBvZiB0aGUgQ29tcHRyb2xsZXJcbiBAcGFyYW0gaW50ZXJlc3RSYXRlTW9kZWxfIFRoZSBhZGRyZXNzIG9mIHRoZSBpbnRlcmVzdCByYXRlIG1vZGVsXG4gQHBhcmFtIGluaXRpYWxFeGNoYW5nZVJhdGVNYW50aXNzYV8gVGhlIGluaXRpYWwgZXhjaGFuZ2UgcmF0ZSwgc2NhbGVkIGJ5IDFlMThcbiBAcGFyYW0gbmFtZV8gRVJDLTIwIG5hbWUgb2YgdGhpcyB0b2tlblxuIEBwYXJhbSBzeW1ib2xfIEVSQy0yMCBzeW1ib2wgb2YgdGhpcyB0b2tlblxuIEBwYXJhbSBkZWNpbWFsc18gRVJDLTIwIGRlY2ltYWwgcHJlY2lzaW9uIG9mIHRoaXMgdG9rZW4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuZGVybHlpbmdfIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tcHRyb2xsZXJfIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJlc3RSYXRlTW9kZWxfIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbEV4Y2hhbmdlUmF0ZU1hbnRpc3NhXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZV8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbF8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlY2ltYWxzXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTmV3Q29tcHRyb2xsZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkQ29tcHRyb2xsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDb21wdHJvbGxlciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTmV3TWFya2V0SW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkSW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnQiLCJkZXNjIjoiIEBub3RpY2UgU2VuZGVyIHN1cHBsaWVzIGFzc2V0cyBpbnRvIHRoZSBtYXJrZXQgYW5kIHJlY2VpdmVzIGNUb2tlbnMgaW4gZXhjaGFuZ2VcbiBAZGV2IEFjY3J1ZXMgaW50ZXJlc3Qgd2hldGhlciBvciBub3QgdGhlIG9wZXJhdGlvbiBzdWNjZWVkcywgdW5sZXNzIHJldmVydGVkXG4gQHBhcmFtIG1pbnRBbW91bnQgVGhlIGFtb3VudCBvZiB0aGUgdW5kZXJseWluZyBhc3NldCB0byBzdXBwbHlcbiBAcmV0dXJuIHVpbnQgMD1zdWNjZXNzLCBvdGhlcndpc2UgYSBmYWlsdXJlIChzZWUgRXJyb3JSZXBvcnRlci5zb2wgZm9yIGRldGFpbHMpIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW50QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJNaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbnRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW50QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbnRUb2tlbnMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlZW0iLCJkZXNjIjoiIEBub3RpY2UgU2VuZGVyIHJlZGVlbXMgY1Rva2VucyBpbiBleGNoYW5nZSBmb3IgdGhlIHVuZGVybHlpbmcgYXNzZXRcbiBAZGV2IEFjY3J1ZXMgaW50ZXJlc3Qgd2hldGhlciBvciBub3QgdGhlIG9wZXJhdGlvbiBzdWNjZWVkcywgdW5sZXNzIHJldmVydGVkXG4gQHBhcmFtIHJlZGVlbVRva2VucyBUaGUgbnVtYmVyIG9mIGNUb2tlbnMgdG8gcmVkZWVtIGludG8gdW5kZXJseWluZ1xuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbVRva2VucyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRlZW1Ub2tlbnMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlZW1VbmRlcmx5aW5nIiwiZGVzYyI6IiBAbm90aWNlIFNlbmRlciByZWRlZW1zIGNUb2tlbnMgaW4gZXhjaGFuZ2UgZm9yIGEgc3BlY2lmaWVkIGFtb3VudCBvZiB1bmRlcmx5aW5nIGFzc2V0XG4gQGRldiBBY2NydWVzIGludGVyZXN0IHdoZXRoZXIgb3Igbm90IHRoZSBvcGVyYXRpb24gc3VjY2VlZHMsIHVubGVzcyByZXZlcnRlZFxuIEBwYXJhbSByZWRlZW1BbW91bnQgVGhlIGFtb3VudCBvZiB1bmRlcmx5aW5nIHRvIHJlZGVlbVxuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbUFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVkZWVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZGVlbUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRlZW1Ub2tlbnMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3Jyb3ciLCJkZXNjIjoiIEBub3RpY2UgU2VuZGVyIGJvcnJvd3MgYXNzZXRzIGZyb20gdGhlIHByb3RvY29sIHRvIHRoZWlyIG93biBhZGRyZXNzXG4gQHBhcmFtIGJvcnJvd0Ftb3VudCBUaGUgYW1vdW50IG9mIHRoZSB1bmRlcmx5aW5nIGFzc2V0IHRvIGJvcnJvd1xuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQm9ycm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0Ftb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50Qm9ycm93cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbEJvcnJvd3MiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXBheUJvcnJvdyIsImRlc2MiOiIgQG5vdGljZSBTZW5kZXIgcmVwYXlzIHRoZWlyIG93biBib3Jyb3dcbiBAcGFyYW0gcmVwYXlBbW91bnQgVGhlIGFtb3VudCB0byByZXBheSwgb3IgLTEgZm9yIHRoZSBmdWxsIG91dHN0YW5kaW5nIGFtb3VudFxuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSZXBheUJvcnJvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRCb3Jyb3dzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcGF5Qm9ycm93QmVoYWxmIiwiZGVzYyI6IiBAbm90aWNlIFNlbmRlciByZXBheXMgYSBib3Jyb3cgYmVsb25naW5nIHRvIGJvcnJvd2VyXG4gQHBhcmFtIGJvcnJvd2VyIHRoZSBhY2NvdW50IHdpdGggdGhlIGRlYnQgYmVpbmcgcGF5ZWQgb2ZmXG4gQHBhcmFtIHJlcGF5QW1vdW50IFRoZSBhbW91bnQgdG8gcmVwYXksIG9yIC0xIGZvciB0aGUgZnVsbCBvdXRzdGFuZGluZyBhbW91bnRcbiBAcmV0dXJuIHVpbnQgMD1zdWNjZXNzLCBvdGhlcndpc2UgYSBmYWlsdXJlIChzZWUgRXJyb3JSZXBvcnRlci5zb2wgZm9yIGRldGFpbHMpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSZXBheUJvcnJvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRCb3Jyb3dzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxpcXVpZGF0ZUJvcnJvdyIsImRlc2MiOiIgQG5vdGljZSBUaGUgc2VuZGVyIGxpcXVpZGF0ZXMgdGhlIGJvcnJvd2VycyBjb2xsYXRlcmFsLlxuICBUaGUgY29sbGF0ZXJhbCBzZWl6ZWQgaXMgdHJhbnNmZXJyZWQgdG8gdGhlIGxpcXVpZGF0b3IuXG4gQHBhcmFtIGJvcnJvd2VyIFRoZSBib3Jyb3dlciBvZiB0aGlzIGNUb2tlbiB0byBiZSBsaXF1aWRhdGVkXG4gQHBhcmFtIHJlcGF5QW1vdW50IFRoZSBhbW91bnQgb2YgdGhlIHVuZGVybHlpbmcgYm9ycm93ZWQgYXNzZXQgdG8gcmVwYXlcbiBAcGFyYW0gY1Rva2VuQ29sbGF0ZXJhbCBUaGUgbWFya2V0IGluIHdoaWNoIHRvIHNlaXplIGNvbGxhdGVyYWwgZnJvbSB0aGUgYm9ycm93ZXJcbiBAcmV0dXJuIHVpbnQgMD1zdWNjZXNzLCBvdGhlcndpc2UgYSBmYWlsdXJlIChzZWUgRXJyb3JSZXBvcnRlci5zb2wgZm9yIGRldGFpbHMpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY1Rva2VuQ29sbGF0ZXJhbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVwYXlCb3Jyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBheUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50Qm9ycm93cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbEJvcnJvd3MiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlc2VydmVzQWRkZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmVuZWZhY3RvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRBbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VG90YWxSZXNlcnZlcyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTGlxdWlkYXRlQm9ycm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpcXVpZGF0b3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBheUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNUb2tlbkNvbGxhdGVyYWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VpemVUb2tlbnMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzd2VlcFRva2VuIiwiZGVzYyI6IiBAbm90aWNlIEEgcHVibGljIGZ1bmN0aW9uIHRvIHN3ZWVwIGFjY2lkZW50YWwgRVJDLTIwIHRyYW5zZmVycyB0byB0aGlzIGNvbnRyYWN0LiBUb2tlbnMgYXJlIHNlbnQgdG8gYWRtaW4gKHRpbWVsb2NrKVxuIEBwYXJhbSB0b2tlbiBUaGUgYWRkcmVzcyBvZiB0aGUgRVJDLTIwIHRva2VuIHRvIHN3ZWVwIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfYWRkUmVzZXJ2ZXMiLCJkZXNjIjoiIEBub3RpY2UgVGhlIHNlbmRlciBhZGRzIHRvIHJlc2VydmVzLlxuIEBwYXJhbSBhZGRBbW91bnQgVGhlIGFtb3VudCBmbyB1bmRlcmx5aW5nIHRva2VuIHRvIGFkZCBhcyByZXNlcnZlc1xuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZEFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVzZXJ2ZXNBZGRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiZW5lZmFjdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZEFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdUb3RhbFJlc2VydmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX2RlbGVnYXRlQ29tcExpa2VUbyIsImRlc2MiOiIgQG5vdGljZSBBZG1pbiBjYWxsIHRvIGRlbGVnYXRlIHRoZSB2b3RlcyBvZiB0aGUgQ09NUC1saWtlIHVuZGVybHlpbmdcbiBAcGFyYW0gY29tcExpa2VEZWxlZ2F0ZWUgVGhlIGFkZHJlc3MgdG8gZGVsZWdhdGUgdm90ZXMgdG9cbiBAZGV2IENUb2tlbnMgd2hvc2UgdW5kZXJseWluZyBhcmUgbm90IENvbXBMaWtlIHNob3VsZCByZXZlcnQgaGVyZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tcExpa2VEZWxlZ2F0ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOiIgQG5vdGljZSBJbml0aWFsaXplIHRoZSBtb25leSBtYXJrZXRcbiBAcGFyYW0gY29tcHRyb2xsZXJfIFRoZSBhZGRyZXNzIG9mIHRoZSBDb21wdHJvbGxlclxuIEBwYXJhbSBpbnRlcmVzdFJhdGVNb2RlbF8gVGhlIGFkZHJlc3Mgb2YgdGhlIGludGVyZXN0IHJhdGUgbW9kZWxcbiBAcGFyYW0gaW5pdGlhbEV4Y2hhbmdlUmF0ZU1hbnRpc3NhXyBUaGUgaW5pdGlhbCBleGNoYW5nZSByYXRlLCBzY2FsZWQgYnkgMWUxOFxuIEBwYXJhbSBuYW1lXyBFSVAtMjAgbmFtZSBvZiB0aGlzIHRva2VuXG4gQHBhcmFtIHN5bWJvbF8gRUlQLTIwIHN5bWJvbCBvZiB0aGlzIHRva2VuXG4gQHBhcmFtIGRlY2ltYWxzXyBFSVAtMjAgZGVjaW1hbCBwcmVjaXNpb24gb2YgdGhpcyB0b2tlbiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tcHRyb2xsZXJfIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJlc3RSYXRlTW9kZWxfIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbEV4Y2hhbmdlUmF0ZU1hbnRpc3NhXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZV8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbF8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlY2ltYWxzXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTmV3Q29tcHRyb2xsZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkQ29tcHRyb2xsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDb21wdHJvbGxlciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTmV3TWFya2V0SW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkSW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyIiwiZGVzYyI6IiBAbm90aWNlIFRyYW5zZmVyIGBhbW91bnRgIHRva2VucyBmcm9tIGBtc2cuc2VuZGVyYCB0byBgZHN0YFxuIEBwYXJhbSBkc3QgVGhlIGFkZHJlc3Mgb2YgdGhlIGRlc3RpbmF0aW9uIGFjY291bnRcbiBAcGFyYW0gYW1vdW50IFRoZSBudW1iZXIgb2YgdG9rZW5zIHRvIHRyYW5zZmVyXG4gQHJldHVybiBXaGV0aGVyIG9yIG5vdCB0aGUgdHJhbnNmZXIgc3VjY2VlZGVkIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkc3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlckZyb20iLCJkZXNjIjoiIEBub3RpY2UgVHJhbnNmZXIgYGFtb3VudGAgdG9rZW5zIGZyb20gYHNyY2AgdG8gYGRzdGBcbiBAcGFyYW0gc3JjIFRoZSBhZGRyZXNzIG9mIHRoZSBzb3VyY2UgYWNjb3VudFxuIEBwYXJhbSBkc3QgVGhlIGFkZHJlc3Mgb2YgdGhlIGRlc3RpbmF0aW9uIGFjY291bnRcbiBAcGFyYW0gYW1vdW50IFRoZSBudW1iZXIgb2YgdG9rZW5zIHRvIHRyYW5zZmVyXG4gQHJldHVybiBXaGV0aGVyIG9yIG5vdCB0aGUgdHJhbnNmZXIgc3VjY2VlZGVkIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcmMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkc3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlIiwiZGVzYyI6IiBAbm90aWNlIEFwcHJvdmUgYHNwZW5kZXJgIHRvIHRyYW5zZmVyIHVwIHRvIGBhbW91bnRgIGZyb20gYHNyY2BcbiBAZGV2IFRoaXMgd2lsbCBvdmVyd3JpdGUgdGhlIGFwcHJvdmFsIGFtb3VudCBmb3IgYHNwZW5kZXJgXG4gIGFuZCBpcyBzdWJqZWN0IHRvIGlzc3VlcyBub3RlZCBbaGVyZV0oaHR0cHM6Ly9laXBzLmV0aGVyZXVtLm9yZy9FSVBTL2VpcC0yMCNhcHByb3ZlKVxuIEBwYXJhbSBzcGVuZGVyIFRoZSBhZGRyZXNzIG9mIHRoZSBhY2NvdW50IHdoaWNoIG1heSB0cmFuc2ZlciB0b2tlbnNcbiBAcGFyYW0gYW1vdW50IFRoZSBudW1iZXIgb2YgdG9rZW5zIHRoYXQgYXJlIGFwcHJvdmVkICh1aW50MjU2Lm1heCBtZWFucyBpbmZpbml0ZSlcbiBAcmV0dXJuIFdoZXRoZXIgb3Igbm90IHRoZSBhcHByb3ZhbCBzdWNjZWVkZWQiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhbGxvd2FuY2UiLCJkZXNjIjoiIEBub3RpY2UgR2V0IHRoZSBjdXJyZW50IGFsbG93YW5jZSBmcm9tIGBvd25lcmAgZm9yIGBzcGVuZGVyYFxuIEBwYXJhbSBvd25lciBUaGUgYWRkcmVzcyBvZiB0aGUgYWNjb3VudCB3aGljaCBvd25zIHRoZSB0b2tlbnMgdG8gYmUgc3BlbnRcbiBAcGFyYW0gc3BlbmRlciBUaGUgYWRkcmVzcyBvZiB0aGUgYWNjb3VudCB3aGljaCBtYXkgdHJhbnNmZXIgdG9rZW5zXG4gQHJldHVybiBUaGUgbnVtYmVyIG9mIHRva2VucyBhbGxvd2VkIHRvIGJlIHNwZW50ICgtMSBtZWFucyBpbmZpbml0ZSkiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJhbGFuY2VPZiIsImRlc2MiOiIgQG5vdGljZSBHZXQgdGhlIHRva2VuIGJhbGFuY2Ugb2YgdGhlIGBvd25lcmBcbiBAcGFyYW0gb3duZXIgVGhlIGFkZHJlc3Mgb2YgdGhlIGFjY291bnQgdG8gcXVlcnlcbiBAcmV0dXJuIFRoZSBudW1iZXIgb2YgdG9rZW5zIG93bmVkIGJ5IGBvd25lcmAiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFsYW5jZU9mVW5kZXJseWluZyIsImRlc2MiOiIgQG5vdGljZSBHZXQgdGhlIHVuZGVybHlpbmcgYmFsYW5jZSBvZiB0aGUgYG93bmVyYFxuIEBkZXYgVGhpcyBhbHNvIGFjY3J1ZXMgaW50ZXJlc3QgaW4gYSB0cmFuc2FjdGlvblxuIEBwYXJhbSBvd25lciBUaGUgYWRkcmVzcyBvZiB0aGUgYWNjb3VudCB0byBxdWVyeVxuIEByZXR1cm4gVGhlIGFtb3VudCBvZiB1bmRlcmx5aW5nIG93bmVkIGJ5IGBvd25lcmAiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWNjb3VudFNuYXBzaG90IiwiZGVzYyI6IiBAbm90aWNlIEdldCBhIHNuYXBzaG90IG9mIHRoZSBhY2NvdW50J3MgYmFsYW5jZXMsIGFuZCB0aGUgY2FjaGVkIGV4Y2hhbmdlIHJhdGVcbiBAZGV2IFRoaXMgaXMgdXNlZCBieSBjb21wdHJvbGxlciB0byBtb3JlIGVmZmljaWVudGx5IHBlcmZvcm0gbGlxdWlkaXR5IGNoZWNrcy5cbiBAcGFyYW0gYWNjb3VudCBBZGRyZXNzIG9mIHRoZSBhY2NvdW50IHRvIHNuYXBzaG90XG4gQHJldHVybiAocG9zc2libGUgZXJyb3IsIHRva2VuIGJhbGFuY2UsIGJvcnJvdyBiYWxhbmNlLCBleGNoYW5nZSByYXRlIG1hbnRpc3NhKSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJHZXRBY2NvdW50U25hcHNob3RSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvcnJvd1JhdGVQZXJCbG9jayIsImRlc2MiOiIgQG5vdGljZSBSZXR1cm5zIHRoZSBjdXJyZW50IHBlci1ibG9jayBib3Jyb3cgaW50ZXJlc3QgcmF0ZSBmb3IgdGhpcyBjVG9rZW5cbiBAcmV0dXJuIFRoZSBib3Jyb3cgaW50ZXJlc3QgcmF0ZSBwZXIgYmxvY2ssIHNjYWxlZCBieSAxZTE4IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VwcGx5UmF0ZVBlckJsb2NrIiwiZGVzYyI6IiBAbm90aWNlIFJldHVybnMgdGhlIGN1cnJlbnQgcGVyLWJsb2NrIHN1cHBseSBpbnRlcmVzdCByYXRlIGZvciB0aGlzIGNUb2tlblxuIEByZXR1cm4gVGhlIHN1cHBseSBpbnRlcmVzdCByYXRlIHBlciBibG9jaywgc2NhbGVkIGJ5IDFlMTgiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b3RhbEJvcnJvd3NDdXJyZW50IiwiZGVzYyI6IiBAbm90aWNlIFJldHVybnMgdGhlIGN1cnJlbnQgdG90YWwgYm9ycm93cyBwbHVzIGFjY3J1ZWQgaW50ZXJlc3RcbiBAcmV0dXJuIFRoZSB0b3RhbCBib3Jyb3dzIHdpdGggaW50ZXJlc3QiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFjY3J1ZUludGVyZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXNoUHJpb3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJlc3RBY2N1bXVsYXRlZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dJbmRleCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbEJvcnJvd3MiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3Jyb3dCYWxhbmNlQ3VycmVudCIsImRlc2MiOiIgQG5vdGljZSBBY2NydWUgaW50ZXJlc3QgdG8gdXBkYXRlZCBib3Jyb3dJbmRleCBhbmQgdGhlbiBjYWxjdWxhdGUgYWNjb3VudCdzIGJvcnJvdyBiYWxhbmNlIHVzaW5nIHRoZSB1cGRhdGVkIGJvcnJvd0luZGV4XG4gQHBhcmFtIGFjY291bnQgVGhlIGFkZHJlc3Mgd2hvc2UgYmFsYW5jZSBzaG91bGQgYmUgY2FsY3VsYXRlZCBhZnRlciB1cGRhdGluZyBib3Jyb3dJbmRleFxuIEByZXR1cm4gVGhlIGNhbGN1bGF0ZWQgYmFsYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvcnJvd0JhbGFuY2VTdG9yZWQiLCJkZXNjIjoiIEBub3RpY2UgUmV0dXJuIHRoZSBib3Jyb3cgYmFsYW5jZSBvZiBhY2NvdW50IGJhc2VkIG9uIHN0b3JlZCBkYXRhXG4gQHBhcmFtIGFjY291bnQgVGhlIGFkZHJlc3Mgd2hvc2UgYmFsYW5jZSBzaG91bGQgYmUgY2FsY3VsYXRlZFxuIEByZXR1cm4gVGhlIGNhbGN1bGF0ZWQgYmFsYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4Y2hhbmdlUmF0ZUN1cnJlbnQiLCJkZXNjIjoiIEBub3RpY2UgQWNjcnVlIGludGVyZXN0IHRoZW4gcmV0dXJuIHRoZSB1cC10by1kYXRlIGV4Y2hhbmdlIHJhdGVcbiBAcmV0dXJuIENhbGN1bGF0ZWQgZXhjaGFuZ2UgcmF0ZSBzY2FsZWQgYnkgMWUxOCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4Y2hhbmdlUmF0ZVN0b3JlZCIsImRlc2MiOiIgQG5vdGljZSBDYWxjdWxhdGVzIHRoZSBleGNoYW5nZSByYXRlIGZyb20gdGhlIHVuZGVybHlpbmcgdG8gdGhlIENUb2tlblxuIEBkZXYgVGhpcyBmdW5jdGlvbiBkb2VzIG5vdCBhY2NydWUgaW50ZXJlc3QgYmVmb3JlIGNhbGN1bGF0aW5nIHRoZSBleGNoYW5nZSByYXRlXG4gQHJldHVybiBDYWxjdWxhdGVkIGV4Y2hhbmdlIHJhdGUgc2NhbGVkIGJ5IDFlMTgiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDYXNoIiwiZGVzYyI6IiBAbm90aWNlIEdldCBjYXNoIGJhbGFuY2Ugb2YgdGhpcyBjVG9rZW4gaW4gdGhlIHVuZGVybHlpbmcgYXNzZXRcbiBAcmV0dXJuIFRoZSBxdWFudGl0eSBvZiB1bmRlcmx5aW5nIGFzc2V0IG93bmVkIGJ5IHRoaXMgY29udHJhY3QiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NydWVJbnRlcmVzdCIsImRlc2MiOiIgQG5vdGljZSBBcHBsaWVzIGFjY3J1ZWQgaW50ZXJlc3QgdG8gdG90YWwgYm9ycm93cyBhbmQgcmVzZXJ2ZXNcbiBAZGV2IFRoaXMgY2FsY3VsYXRlcyBpbnRlcmVzdCBhY2NydWVkIGZyb20gdGhlIGxhc3QgY2hlY2twb2ludGVkIGJsb2NrXG4gICB1cCB0byB0aGUgY3VycmVudCBibG9jayBhbmQgd3JpdGVzIG5ldyBjaGVja3BvaW50IHRvIHN0b3JhZ2UuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2VpemUiLCJkZXNjIjoiIEBub3RpY2UgVHJhbnNmZXJzIGNvbGxhdGVyYWwgdG9rZW5zICh0aGlzIG1hcmtldCkgdG8gdGhlIGxpcXVpZGF0b3IuXG4gQGRldiBXaWxsIGZhaWwgdW5sZXNzIGNhbGxlZCBieSBhbm90aGVyIGNUb2tlbiBkdXJpbmcgdGhlIHByb2Nlc3Mgb2YgbGlxdWlkYXRpb24uXG4gIEl0cyBhYnNvbHV0ZWx5IGNyaXRpY2FsIHRvIHVzZSBtc2cuc2VuZGVyIGFzIHRoZSBib3Jyb3dlZCBjVG9rZW4gYW5kIG5vdCBhIHBhcmFtZXRlci5cbiBAcGFyYW0gbGlxdWlkYXRvciBUaGUgYWNjb3VudCByZWNlaXZpbmcgc2VpemVkIGNvbGxhdGVyYWxcbiBAcGFyYW0gYm9ycm93ZXIgVGhlIGFjY291bnQgaGF2aW5nIGNvbGxhdGVyYWwgc2VpemVkXG4gQHBhcmFtIHNlaXplVG9rZW5zIFRoZSBudW1iZXIgb2YgY1Rva2VucyB0byBzZWl6ZVxuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpcXVpZGF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlaXplVG9rZW5zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSZXNlcnZlc0FkZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJlbmVmYWN0b3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkQW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1RvdGFsUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfc2V0UGVuZGluZ0FkbWluIiwiZGVzYyI6IiBAbm90aWNlIEJlZ2lucyB0cmFuc2ZlciBvZiBhZG1pbiByaWdodHMuIFRoZSBuZXdQZW5kaW5nQWRtaW4gbXVzdCBjYWxsIGBfYWNjZXB0QWRtaW5gIHRvIGZpbmFsaXplIHRoZSB0cmFuc2Zlci5cbiBAZGV2IEFkbWluIGZ1bmN0aW9uIHRvIGJlZ2luIGNoYW5nZSBvZiBhZG1pbi4gVGhlIG5ld1BlbmRpbmdBZG1pbiBtdXN0IGNhbGwgYF9hY2NlcHRBZG1pbmAgdG8gZmluYWxpemUgdGhlIHRyYW5zZmVyLlxuIEBwYXJhbSBuZXdQZW5kaW5nQWRtaW4gTmV3IHBlbmRpbmcgYWRtaW4uXG4gQHJldHVybiB1aW50IDA9c3VjY2Vzcywgb3RoZXJ3aXNlIGEgZmFpbHVyZSAoc2VlIEVycm9yUmVwb3J0ZXIuc29sIGZvciBkZXRhaWxzKSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3UGVuZGluZ0FkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJOZXdQZW5kaW5nQWRtaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkUGVuZGluZ0FkbWluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3UGVuZGluZ0FkbWluIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX2FjY2VwdEFkbWluIiwiZGVzYyI6IiBAbm90aWNlIEFjY2VwdHMgdHJhbnNmZXIgb2YgYWRtaW4gcmlnaHRzLiBtc2cuc2VuZGVyIG11c3QgYmUgcGVuZGluZ0FkbWluXG4gQGRldiBBZG1pbiBmdW5jdGlvbiBmb3IgcGVuZGluZyBhZG1pbiB0byBhY2NlcHQgcm9sZSBhbmQgdXBkYXRlIGFkbWluXG4gQHJldHVybiB1aW50IDA9c3VjY2Vzcywgb3RoZXJ3aXNlIGEgZmFpbHVyZSAoc2VlIEVycm9yUmVwb3J0ZXIuc29sIGZvciBkZXRhaWxzKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTmV3QWRtaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkQWRtaW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBZG1pbiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTmV3UGVuZGluZ0FkbWluIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9sZFBlbmRpbmdBZG1pbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1BlbmRpbmdBZG1pbiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9zZXRDb21wdHJvbGxlciIsImRlc2MiOiIgQG5vdGljZSBTZXRzIGEgbmV3IGNvbXB0cm9sbGVyIGZvciB0aGUgbWFya2V0XG4gQGRldiBBZG1pbiBmdW5jdGlvbiB0byBzZXQgYSBuZXcgY29tcHRyb2xsZXJcbiBAcmV0dXJuIHVpbnQgMD1zdWNjZXNzLCBvdGhlcndpc2UgYSBmYWlsdXJlIChzZWUgRXJyb3JSZXBvcnRlci5zb2wgZm9yIGRldGFpbHMpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDb21wdHJvbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTmV3Q29tcHRyb2xsZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkQ29tcHRyb2xsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDb21wdHJvbGxlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9zZXRSZXNlcnZlRmFjdG9yIiwiZGVzYyI6IiBAbm90aWNlIGFjY3J1ZXMgaW50ZXJlc3QgYW5kIHNldHMgYSBuZXcgcmVzZXJ2ZSBmYWN0b3IgZm9yIHRoZSBwcm90b2NvbCB1c2luZyBfc2V0UmVzZXJ2ZUZhY3RvckZyZXNoXG4gQGRldiBBZG1pbiBmdW5jdGlvbiB0byBhY2NydWUgaW50ZXJlc3QgYW5kIHNldCBhIG5ldyByZXNlcnZlIGZhY3RvclxuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1Jlc2VydmVGYWN0b3JNYW50aXNzYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTmV3UmVzZXJ2ZUZhY3RvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkUmVzZXJ2ZUZhY3Rvck1hbnRpc3NhIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1Jlc2VydmVGYWN0b3JNYW50aXNzYSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9yZWR1Y2VSZXNlcnZlcyIsImRlc2MiOiIgQG5vdGljZSBBY2NydWVzIGludGVyZXN0IGFuZCByZWR1Y2VzIHJlc2VydmVzIGJ5IHRyYW5zZmVycmluZyB0byBhZG1pblxuIEBwYXJhbSByZWR1Y2VBbW91bnQgQW1vdW50IG9mIHJlZHVjdGlvbiB0byByZXNlcnZlc1xuIEByZXR1cm4gdWludCAwPXN1Y2Nlc3MsIG90aGVyd2lzZSBhIGZhaWx1cmUgKHNlZSBFcnJvclJlcG9ydGVyLnNvbCBmb3IgZGV0YWlscykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZHVjZUFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVzZXJ2ZXNSZWR1Y2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZHVjZUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdUb3RhbFJlc2VydmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX3NldEludGVyZXN0UmF0ZU1vZGVsIiwiZGVzYyI6IiBAbm90aWNlIGFjY3J1ZXMgaW50ZXJlc3QgYW5kIHVwZGF0ZXMgdGhlIGludGVyZXN0IHJhdGUgbW9kZWwgdXNpbmcgX3NldEludGVyZXN0UmF0ZU1vZGVsRnJlc2hcbiBAZGV2IEFkbWluIGZ1bmN0aW9uIHRvIGFjY3J1ZSBpbnRlcmVzdCBhbmQgdXBkYXRlIHRoZSBpbnRlcmVzdCByYXRlIG1vZGVsXG4gQHBhcmFtIG5ld0ludGVyZXN0UmF0ZU1vZGVsIHRoZSBuZXcgaW50ZXJlc3QgcmF0ZSBtb2RlbCB0byB1c2VcbiBAcmV0dXJuIHVpbnQgMD1zdWNjZXNzLCBvdGhlcndpc2UgYSBmYWlsdXJlIChzZWUgRXJyb3JSZXBvcnRlci5zb2wgZm9yIGRldGFpbHMpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjcnVlSW50ZXJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2hQcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlcmVzdEFjY3VtdWxhdGVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd0luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTmV3TWFya2V0SW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkSW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVuZGVybHlpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzeW1ib2wiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlY2ltYWxzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBlbmRpbmdBZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbXB0cm9sbGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW50ZXJlc3RSYXRlTW9kZWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNlcnZlRmFjdG9yTWFudGlzc2EiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NydWFsQmxvY2tOdW1iZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3Jyb3dJbmRleCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvdGFsUmVzZXJ2ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b3RhbFN1cHBseSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MTR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM1MDMsMzUxMF0sImVycm9yTWVzc2FnZSI6IkFjY2VwdEFkbWluUGVuZGluZ0FkbWluQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzY2XSwiZXJyb3JNZXNzYWdlIjoiQWRkUmVzZXJ2ZXNGYWN0b3JGcmVzaENoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU5MF0sImVycm9yTWVzc2FnZSI6IkJvcnJvd0Nhc2hOb3RBdmFpbGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTcxXSwiZXJyb3JNZXNzYWdlIjoiQm9ycm93Q29tcHRyb2xsZXJSZWplY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTgyXSwiZXJyb3JNZXNzYWdlIjoiQm9ycm93RnJlc2huZXNzQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjY3XSwiZXJyb3JNZXNzYWdlIjoiQ0VyYzIwOjpzd2VlcFRva2VuOiBjYW4gbm90IHN3ZWVwIHVuZGVybHlpbmcgdG9rZW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjU4XSwiZXJyb3JNZXNzYWdlIjoiQ0VyYzIwOjpzd2VlcFRva2VuOiBvbmx5IGFkbWluIGNhbiBzd2VlcCB0b2tlbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDkzXSwiZXJyb3JNZXNzYWdlIjoiTElRVUlEQVRFX0NPTVBUUk9MTEVSX0NBTENVTEFURV9BTU9VTlRfU0VJWkVfRkFJTEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEyMl0sImVycm9yTWVzc2FnZSI6IkxJUVVJREFURV9TRUlaRV9UT09fTVVDSCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NzZdLCJlcnJvck1lc3NhZ2UiOiJMaXF1aWRhdGVBY2NydWVDb2xsYXRlcmFsSW50ZXJlc3RGYWlsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDE1XSwiZXJyb3JNZXNzYWdlIjoiTGlxdWlkYXRlQ2xvc2VBbW91bnRJc1VpbnRNYXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDA4XSwiZXJyb3JNZXNzYWdlIjoiTGlxdWlkYXRlQ2xvc2VBbW91bnRJc1plcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTk1XSwiZXJyb3JNZXNzYWdlIjoiTGlxdWlkYXRlQ29sbGF0ZXJhbEZyZXNobmVzc0NoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk1NF0sImVycm9yTWVzc2FnZSI6IkxpcXVpZGF0ZUNvbXB0cm9sbGVyUmVqZWN0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk2NV0sImVycm9yTWVzc2FnZSI6IkxpcXVpZGF0ZUZyZXNobmVzc0NoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAwMl0sImVycm9yTWVzc2FnZSI6IkxpcXVpZGF0ZUxpcXVpZGF0b3JJc0JvcnJvd2VyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU3MF0sImVycm9yTWVzc2FnZSI6IkxpcXVpZGF0ZVNlaXplQ29tcHRyb2xsZXJSZWplY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTc3XSwiZXJyb3JNZXNzYWdlIjoiTGlxdWlkYXRlU2VpemVMaXF1aWRhdG9ySXNCb3Jyb3dlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyODZdLCJlcnJvck1lc3NhZ2UiOiJNaW50Q29tcHRyb2xsZXJSZWplY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjk3XSwiZXJyb3JNZXNzYWdlIjoiTWludEZyZXNobmVzc0NoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA3OF0sImVycm9yTWVzc2FnZSI6IlJlZGVlbUNvbXB0cm9sbGVyUmVqZWN0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA4OV0sImVycm9yTWVzc2FnZSI6IlJlZGVlbUZyZXNobmVzc0NoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTEwMF0sImVycm9yTWVzc2FnZSI6IlJlZGVlbVRyYW5zZmVyT3V0Tm90UG9zc2libGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzEwXSwiZXJyb3JNZXNzYWdlIjoiUmVkdWNlUmVzZXJ2ZXNBZG1pbkNoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcyOV0sImVycm9yTWVzc2FnZSI6IlJlZHVjZVJlc2VydmVzQ2FzaE5vdEF2YWlsYWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NDFdLCJlcnJvck1lc3NhZ2UiOiJSZWR1Y2VSZXNlcnZlc0Nhc2hWYWxpZGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcyMV0sImVycm9yTWVzc2FnZSI6IlJlZHVjZVJlc2VydmVzRnJlc2hDaGVjayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzMzhdLCJlcnJvck1lc3NhZ2UiOiJSZXBheUJvcnJvd0NvbXB0cm9sbGVyUmVqZWN0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM0OV0sImVycm9yTWVzc2FnZSI6IlJlcGF5Qm9ycm93RnJlc2huZXNzQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODE2XSwiZXJyb3JNZXNzYWdlIjoiU2V0Q29tcHRyb2xsZXJPd25lckNoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg5OV0sImVycm9yTWVzc2FnZSI6IlNldEludGVyZXN0UmF0ZU1vZGVsRnJlc2hDaGVjayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4ODhdLCJlcnJvck1lc3NhZ2UiOiJTZXRJbnRlcmVzdFJhdGVNb2RlbE93bmVyQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDY4XSwiZXJyb3JNZXNzYWdlIjoiU2V0UGVuZGluZ0FkbWluT3duZXJDaGVjayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MTJdLCJlcnJvck1lc3NhZ2UiOiJTZXRSZXNlcnZlRmFjdG9yQWRtaW5DaGVjayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MzBdLCJlcnJvck1lc3NhZ2UiOiJTZXRSZXNlcnZlRmFjdG9yQm91bmRzQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjIzXSwiZXJyb3JNZXNzYWdlIjoiU2V0UmVzZXJ2ZUZhY3RvckZyZXNoQ2hlY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjAyXSwiZXJyb3JNZXNzYWdlIjoiVE9LRU5fVFJBTlNGRVJfSU5fRkFJTEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMwOF0sImVycm9yTWVzc2FnZSI6IlRPS0VOX1RSQU5TRkVSX09VVF9GQUlMRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0Mzg0XSwiZXJyb3JNZXNzYWdlIjoiVHJhbnNmZXJDb21wdHJvbGxlclJlamVjdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzOTFdLCJlcnJvck1lc3NhZ2UiOiJUcmFuc2Zlck5vdEFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzgyXSwiZXJyb3JNZXNzYWdlIjoiYm9ycm93IHJhdGUgaXMgYWJzdXJkbHkgaGlnaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMTQsMTQyMywxNDYxLDE0OTksMTczMywxNzc4LDE4MzQsMjM0NywyNjY0LDI3MjEsMzI0MCwzMjgyLDM0MzEsMzU5MSwzNjg5LDQ1ODddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfbm90RW50ZXJlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDkyLDEyOTEsMTU3NiwxOTU5LDIzNjAsMjU2MiwzNjE3LDM3MTUsMzk2OSw0NjcxLDUwODMsNTM0Myw1ODkzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgYWNjcnVhbEJsb2NrTnVtYmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODUsMjI1MywyNDQ1LDI1NTUsMzQ2NSwzNTE1LDM1MzAsMzYwOSwzNzA3LDM3NTgsMzc2OCwzOTA2LDU4MTMsNTg4NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMDIsMTY0MywyNTcyLDM5ODgsNDU3NSw0Njk4LDU0MjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBib3Jyb3dJbmRleCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjQ0LDE1MjksMTkwNCwyMDQzLDM5MjgsNDMzOSw1MDM2LDUyMTcsNTI5Miw1NTIwLDU4MjFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBjb21wdHJvbGxlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODk0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgZGVjaW1hbHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYyNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGluaXRpYWxFeGNoYW5nZVJhdGVNYW50aXNzYSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDY2LDMxODMsMzkzOSw0NzM4LDU5MDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBpbnRlcmVzdFJhdGVNb2RlbCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODU2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbmFtZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDczLDM0OTcsMzkxN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHBlbmRpbmdBZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTY4LDM2MzUsMzk1MCw0ODI5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcmVzZXJ2ZUZhY3Rvck1hbnRpc3NhIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4NzVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzeW1ib2wgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwMywzMDM2LDMxMzgsMzI1Niw0MDA3LDQ2MzQsNDY4OCw1Mzg1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgdG90YWxCb3Jyb3dzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNzcsMzA1MSwzMTUzLDM3MzQsNDAyNiw0NjQyLDQ2OTMsNTY1Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHRvdGFsUmVzZXJ2ZXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMyNiw0MDQ1LDQ2MTQsNTEwNSw1NjY1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgdG90YWxTdXBwbHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI2MywyNDUzLDM4NDUsNDA2NCw0MTA0LDQyNTNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB1bmRlcmx5aW5nIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMjAsMjU5MF0sImVycm9yTWVzc2FnZSI6ImluaXRpYWwgZXhjaGFuZ2UgcmF0ZSBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvLiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNDAsMTA1NywyNTEwLDI1MjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQ4LDEwNjUsMjUxOCwyNTM1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMTAsMTAxOCwxMDI2LDE3NjYsMTgxMSwxODMwLDIyNDYsMjQzOCwyNDg4LDI0OTYsMjY1MiwyNzAxLDI3MDksMjc1NSwyODE4LDI4MjYsMjg1OSwyODkxLDI5NDYsMzI3OCwzMzE4LDM0MTEsMzQxOSwzNDU4LDM1NjEsMzgxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDM0LDEyMTAsMTQxOSwxNDU3LDE0OTUsMTcyOSwxNzc0LDE4MTksMjM0MywyNTA0LDI2NjAsMjcxNywyNzY0LDM0MjcsMzU4NywzNjg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNzcsMjU0N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4NTUsNTkzOF0sImVycm9yTWVzc2FnZSI6Im1hcmtlciBtZXRob2QgcmV0dXJuZWQgZmFsc2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTA5LDI1NzldLCJlcnJvck1lc3NhZ2UiOiJtYXJrZXQgbWF5IG9ubHkgYmUgaW5pdGlhbGl6ZWQgb25jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5NzVdLCJlcnJvck1lc3NhZ2UiOiJvbmUgb2YgcmVkZWVtVG9rZW5zSW4gb3IgcmVkZWVtQW1vdW50SW4gbXVzdCBiZSB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA4NywyNTU3XSwiZXJyb3JNZXNzYWdlIjoib25seSBhZG1pbiBtYXkgaW5pdGlhbGl6ZSB0aGUgbWFya2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ0N10sImVycm9yTWVzc2FnZSI6Im9ubHkgdGhlIGFkbWluIG1heSBzZXQgdGhlIGNvbXAtbGlrZSBkZWxlZ2F0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMDUsMTM2MCwxMzcwLDE2MjksMTY0OCwxNjc4LDE2ODksMjE0NiwyMzkxLDI0MDYsMjc4NSwyODQyLDI4NzQsMjg5OSwyOTMxLDI5NzIsMjk4NywyOTk5LDMxMDQsMzIyOSwzMjYxLDMzMDEsMzMyNiwzMzQzLDMzNjAsMzM3NywzMzk0LDM1NjksMzY0NCwzNjU3LDM3NzQsMzc4NiwzODMxLDM5NTUsMzk3NCwzOTkzLDQwMTIsNDAzMSw0MDUwLDQ0ODksNDgwMCw0ODM0LDQ4OTYsNDkwNSw0OTE2LDQ5MjcsNDk4Myw1MTU0LDUxNzgsNTQxNSw1NDM0LDU0NTgsNTQ2OSw1NjMzLDU3MjgsNTc1MSw1Nzc0LDU3ODYsNTk3OSw2MDA3LDYwMzhdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMTUsMTQyNCwxNDYyLDE1MDAsMTczNCwxNzc5LDE4MzUsMjM0OCwyNjY1LDI3MjIsMzI0MSwzMjgzLDM0MzIsMzU5MiwzNjkwLDQ1ODhdLCJlcnJvck1lc3NhZ2UiOiJyZS1lbnRlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE5Nyw0MzAzXSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyOCwyNTk4XSwiZXJyb3JNZXNzYWdlIjoic2V0dGluZyBjb21wdHJvbGxlciBmYWlsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTUwLDI2MjBdLCJlcnJvck1lc3NhZ2UiOiJzZXR0aW5nIGludGVyZXN0IHJhdGUgbW9kZWwgZmFpbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIzNV0sImVycm9yTWVzc2FnZSI6InRva2VuIHNlaXp1cmUgZmFpbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TG1Gd2NISnZkbUZzWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F6TWlBeElEWWdNVEF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlQ0FpWDI1dmRFVnVkR1Z5WldRaUlEQjRNVFV4Wmpkak56VWdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ0ltRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpSWdJbUZrYldsdUlpQWlZMjl0Y0hSeWIyeHNaWElpSUNKMGIzUmhiRkpsYzJWeWRtVnpJaUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUNBaWRHOTBZV3hDYjNKeWIzZHpJaUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ0ltSnZjbkp2ZDBsdVpHVjRJaUFpZEc5MFlXeFRkWEJ3YkhraUlDSmhZMk52ZFc1MFZHOXJaVzV6SWlBd2VEQmtaVEJpTm1JellUYzJOREF3TURBZ0luVnVaR1Z5YkhscGJtY2lJQ0pwYm5SbGNtVnpkRkpoZEdWTmIyUmxiQ0lnSW5CbGJtUnBibWRCWkcxcGJpSWdJbkpsYzJWeWRtVkdZV04wYjNKTllXNTBhWE56WVNJZ01IZzRNMkpoWkRkall5QXdlREk0T1RFNE9EWXhJQ0p1WVcxbElpQWljM2x0WW05c0lpQWlaR1ZqYVcxaGJITWlJQ0pwYm1sMGFXRnNSWGhqYUdGdVoyVlNZWFJsVFdGdWRHbHpjMkVpSURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptSUNKMGNtRnVjMlpsY2tGc2JHOTNZVzVqWlhNaUlDSmhZMk52ZFc1MFFtOXljbTkzY3lJZ01IZzNObUppTlRGaU1pQXdlRFEyTkRJMVl6ZGpJREI0TlRBeU5ETXpaV1lnTUhnM09XWmhZalEyTlNBd2VEbG1ZV0kyTW1JNUlEQjRaamt4TVRJeVlURWdNSGhrTUdVNU1qa3laQ0F3ZUdFeFptRTNPVGc1SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeU1Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklESXhJQzh2SUNKdVlXMWxJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJQ0p6ZVcxaWIyd2lDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTWpNZ0x5OGdJbVJsWTJsdFlXeHpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhaRzFwYmlJS0lDQWdJR0o1ZEdWaklERXdJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKd1pXNWthVzVuUVdSdGFXNGlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEySUM4dklDSmpiMjF3ZEhKdmJHeGxjaUlLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0pwYm5SbGNtVnpkRkpoZEdWTmIyUmxiQ0lLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURJMElDOHZJQ0pwYm1sMGFXRnNSWGhqYUdGdVoyVlNZWFJsVFdGdWRHbHpjMkVpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01UZ2dMeThnSW5KbGMyVnlkbVZHWVdOMGIzSk5ZVzUwYVhOellTSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhZMk55ZFdGc1FteHZZMnRPZFcxaVpYSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUp2Y25KdmQwbHVaR1Y0SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5SdmRHRnNRbTl5Y205M2N5SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjBiM1JoYkZKbGMyVnlkbVZ6SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKMGIzUmhiRk4xY0hCc2VTSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWlkVzVrWlhKc2VXbHVaeUlLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5XTmlaVGRpTURFZ01IZzROR00xWWpRNE5DQXdlR1l6WVdNNFpqTmpJREI0T1RBd1kySmxNek1nTUhoaU1UQXpOVFkxWWlBd2VEZGhaRE00TjJabUlEQjRNVEk1TnpFeFptVWdNSGhpTlRrMlkySmpNeUF3ZURZd1kyRm1PRFJtSURCNE56QmlZbU15TlRFZ01IaGhOamxsWTJNM1pTQXdlRFUyWkdGaE5XSmtJREI0TVRrNFl6azRNakFnTUhnMlpHWTBNV1kyWkNBd2VHWmhabUkyWVRBNElEQjROV1E0TlRSa01HVWdMeThnYldWMGFHOWtJQ0pwYm1sMGFXRnNhWHBsS0dGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXNjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliV2x1ZENoMWFXNTBNalUyS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW5KbFpHVmxiU2gxYVc1ME1qVTJLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbkpsWkdWbGJWVnVaR1Z5YkhscGJtY29kV2x1ZERJMU5pbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmliM0p5YjNjb2RXbHVkREkxTmlsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKeVpYQmhlVUp2Y25KdmR5aDFhVzUwTWpVMktYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0luSmxjR0Y1UW05eWNtOTNRbVZvWVd4bUtHRmtaSEpsYzNNc2RXbHVkREkxTmlsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKc2FYRjFhV1JoZEdWQ2IzSnliM2NvWVdSa2NtVnpjeXgxYVc1ME1qVTJMR0ZrWkhKbGMzTXBkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWljM2RsWlhCVWIydGxiaWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0lsOWhaR1JTWlhObGNuWmxjeWgxYVc1ME1qVTJLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbDlrWld4bFoyRjBaVU52YlhCTWFXdGxWRzhvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnBibWwwYVdGc2FYcGxLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMkxITjBjbWx1Wnl4emRISnBibWNzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luUnlZVzV6Wm1WeUtHRmtaSEpsYzNNc2RXbHVkREkxTmlsaWIyOXNJaXdnYldWMGFHOWtJQ0owY21GdWMyWmxja1p5YjIwb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlwWW05dmJDSXNJRzFsZEdodlpDQWlZWEJ3Y205MlpTaGhaR1J5WlhOekxIVnBiblF5TlRZcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWVd4c2IzZGhibU5sS0dGa1pISmxjM01zWVdSa2NtVnpjeWwxYVc1ME1qVTJJZ29nSUNBZ1lubDBaV01nTVRrZ0x5OGdiV1YwYUc5a0lDSmlZV3hoYm1ObFQyWW9ZV1JrY21WemN5bDFhVzUwTWpVMklnb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEbG1NRE0yTWpjNUlEQjRPR1psWm1GaU5EUWdNSGcxTXpsbVpURmhNU0F3ZUdWaE9UTmtPVEZrSURCNE9XRmtORGs1TmpRZ01IZzJOMlUzWldObVpTQXdlR0V3WXpnek5HWm1JREI0TmpGbU5UQTJaRFVnTUhoaE5URmxPR0UxTnlBd2VHVTJOelZtT1RjeUlDOHZJRzFsZEdodlpDQWlZbUZzWVc1alpVOW1WVzVrWlhKc2VXbHVaeWhoWkdSeVpYTnpLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbWRsZEVGalkyOTFiblJUYm1Gd2MyaHZkQ2hoWkdSeVpYTnpLU2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMktTSXNJRzFsZEdodlpDQWlZbTl5Y205M1VtRjBaVkJsY2tKc2IyTnJLQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0p6ZFhCd2JIbFNZWFJsVUdWeVFteHZZMnNvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW5SdmRHRnNRbTl5Y205M2MwTjFjbkpsYm5Rb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltSnZjbkp2ZDBKaGJHRnVZMlZEZFhKeVpXNTBLR0ZrWkhKbGMzTXBkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlZbTl5Y205M1FtRnNZVzVqWlZOMGIzSmxaQ2hoWkdSeVpYTnpLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbVY0WTJoaGJtZGxVbUYwWlVOMWNuSmxiblFvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1WNFkyaGhibWRsVW1GMFpWTjBiM0psWkNncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVoyVjBRMkZ6YUNncGRXbHVkREkxTmlJS0lDQWdJR0o1ZEdWaklESTVJQzh2SUcxbGRHaHZaQ0FpWVdOamNuVmxTVzUwWlhKbGMzUW9LWFZwYm5ReU5UWWlDaUFnSUNCaWVYUmxZeUF6TUNBdkx5QnRaWFJvYjJRZ0luTmxhWHBsS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLWFZwYm5ReU5UWWlDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZakJtTXpWbE1HSWdNSGcyWkdOa09EazFOQ0F3ZURsbU5UWmtOalF4SURCNFl6WmlOR1EwTm1VZ01IZzFPRGt6WVdJNE1pQXdlR1UxWXpBNE4yWTRJREI0TmpGak0yTXhaV1lnTUhneE9UYzFNRFl4TmlBd2VEQXdOV0kxTW1JNElEQjRZamczTnpsbFpUY2dNSGd3WVRSbVlqWmlNeUF3ZUdaaE9UaGpaREF6SURCNE1qWTVZVEV3TUdJZ01IZ3dOVFZoTURsak5DQXdlRE01TXpOaU0yVTNJQzh2SUcxbGRHaHZaQ0FpWDNObGRGQmxibVJwYm1kQlpHMXBiaWhoWkdSeVpYTnpLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbDloWTJObGNIUkJaRzFwYmlncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVgzTmxkRU52YlhCMGNtOXNiR1Z5S0dGa1pISmxjM01wZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWDNObGRGSmxjMlZ5ZG1WR1lXTjBiM0lvZFdsdWRESTFOaWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0pmY21Wa2RXTmxVbVZ6WlhKMlpYTW9kV2x1ZERJMU5pbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmZjMlYwU1c1MFpYSmxjM1JTWVhSbFRXOWtaV3dvWVdSa2NtVnpjeWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0oxYm1SbGNteDVhVzVuS0NsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKdVlXMWxLQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbk41YldKdmJDZ3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSmtaV05wYldGc2N5Z3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmhaRzFwYmlncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaWNHVnVaR2x1WjBGa2JXbHVLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0pqYjIxd2RISnZiR3hsY2lncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaWFXNTBaWEpsYzNSU1lYUmxUVzlrWld3b0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0luSmxjMlZ5ZG1WR1lXTjBiM0pOWVc1MGFYTnpZU2dwZFdsdWRESTFOaUlLSUNBZ0lHSjVkR1ZqSURNeElDOHZJRzFsZEdodlpDQWlZV05qY25WaGJFSnNiMk5yVG5WdFltVnlLQ2wxYVc1ME1qVTJJZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR013WVRjMU1XRm1JREI0T0RRM05ETTROR1lnTUhnMU1EWmpNMk5rTWlBdkx5QnRaWFJvYjJRZ0ltSnZjbkp2ZDBsdVpHVjRLQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0owYjNSaGJFSnZjbkp2ZDNNb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0luUnZkR0ZzVW1WelpYSjJaWE1vS1hWcGJuUXlOVFlpQ2lBZ0lDQmllWFJsWXlBek1pQXZMeUJ0WlhSb2IyUWdJblJ2ZEdGc1UzVndjR3g1S0NsMWFXNTBNalUySWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2FXNXBkR2xoYkdsNlpTZzNLU0J0YVc1MElISmxaR1ZsYlNCeVpXUmxaVzFWYm1SbGNteDVhVzVuSUdKdmNuSnZkeUJ5WlhCaGVVSnZjbkp2ZHlCeVpYQmhlVUp2Y25KdmQwSmxhR0ZzWmlCc2FYRjFhV1JoZEdWQ2IzSnliM2NnYzNkbFpYQlViMnRsYmlCZllXUmtVbVZ6WlhKMlpYTWdYMlJsYkdWbllYUmxRMjl0Y0V4cGEyVlVieUJwYm1sMGFXRnNhWHBsS0RZcElIUnlZVzV6Wm1WeUlIUnlZVzV6Wm1WeVJuSnZiU0JoY0hCeWIzWmxJR0ZzYkc5M1lXNWpaU0JpWVd4aGJtTmxUMllnWW1Gc1lXNWpaVTltVlc1a1pYSnNlV2x1WnlCblpYUkJZMk52ZFc1MFUyNWhjSE5vYjNRZ1ltOXljbTkzVW1GMFpWQmxja0pzYjJOcklITjFjSEJzZVZKaGRHVlFaWEpDYkc5amF5QjBiM1JoYkVKdmNuSnZkM05EZFhKeVpXNTBJR0p2Y25KdmQwSmhiR0Z1WTJWRGRYSnlaVzUwSUdKdmNuSnZkMEpoYkdGdVkyVlRkRzl5WldRZ1pYaGphR0Z1WjJWU1lYUmxRM1Z5Y21WdWRDQmxlR05vWVc1blpWSmhkR1ZUZEc5eVpXUWdaMlYwUTJGemFDQmhZMk55ZFdWSmJuUmxjbVZ6ZENCelpXbDZaU0JmYzJWMFVHVnVaR2x1WjBGa2JXbHVJRjloWTJObGNIUkJaRzFwYmlCZmMyVjBRMjl0Y0hSeWIyeHNaWElnWDNObGRGSmxjMlZ5ZG1WR1lXTjBiM0lnWDNKbFpIVmpaVkpsYzJWeWRtVnpJRjl6WlhSSmJuUmxjbVZ6ZEZKaGRHVk5iMlJsYkNCMWJtUmxjbXg1YVc1bklHNWhiV1VnYzNsdFltOXNJR1JsWTJsdFlXeHpJR0ZrYldsdUlIQmxibVJwYm1kQlpHMXBiaUJqYjIxd2RISnZiR3hsY2lCcGJuUmxjbVZ6ZEZKaGRHVk5iMlJsYkNCeVpYTmxjblpsUm1GamRHOXlUV0Z1ZEdsemMyRWdZV05qY25WaGJFSnNiMk5yVG5WdFltVnlJR0p2Y25KdmQwbHVaR1Y0SUhSdmRHRnNRbTl5Y205M2N5QjBiM1JoYkZKbGMyVnlkbVZ6SUhSdmRHRnNVM1Z3Y0d4NUNpQWdJQ0JsY25JS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TG1sdWFYUnBZV3hwZW1Vb055bGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYm1sMGFXRnNhWHBsS0RjcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTndvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ1lXUnRhVzRnYldGNUlHbHVhWFJwWVd4cGVtVWdkR2hsSUcxaGNtdGxkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1lXTmpjblZoYkVKc2IyTnJUblZ0WW1WeUlHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQmllaUJwYm1sMGFXRnNhWHBsS0RjcFgySnZiMnhmWm1Gc2MyVkFOQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmliM0p5YjNkSmJtUmxlQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZbTl5Y205M1NXNWtaWGdnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBUMEtJQ0FnSUdKNklHbHVhWFJwWVd4cGVtVW9OeWxmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvS2FXNXBkR2xoYkdsNlpTZzNLVjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0JoYzNObGNuUWdMeThnYldGeWEyVjBJRzFoZVNCdmJteDVJR0psSUdsdWFYUnBZV3hwZW1Wa0lHOXVZMlVLSUNBZ0lHSjVkR1ZqSURJMElDOHZJQ0pwYm1sMGFXRnNSWGhqYUdGdVoyVlNZWFJsVFdGdWRHbHpjMkVpQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWo0S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1sMGFXRnNJR1Y0WTJoaGJtZGxJSEpoZEdVZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdlbVZ5Ynk0S0lDQWdJR1JwWnlBMUNpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1WDNObGRFTnZiWEIwY205c2JHVnlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBUMEtJQ0FnSUdGemMyVnlkQ0F2THlCelpYUjBhVzVuSUdOdmJYQjBjbTlzYkdWeUlHWmhhV3hsWkFvZ0lDQWdaMnh2WW1Gc0lGSnZkVzVrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0ppYjNKeWIzZEpibVJsZUNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTJGc2JITjFZaUJmYzJWMFNXNTBaWEpsYzNSU1lYUmxUVzlrWld4R2NtVnphQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2MyVjBkR2x1WnlCcGJuUmxjbVZ6ZENCeVlYUmxJRzF2WkdWc0lHWmhhV3hsWkFvZ0lDQWdZbmwwWldNZ01qRWdMeThnSW01aGJXVWlDaUFnSUNCa2FXY2dNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJQ0p6ZVcxaWIyd2lDaUFnSUNCa2FXY2dNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURJeklDOHZJQ0prWldOcGJXRnNjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERTFJQzh2SUNKMWJtUmxjbXg1YVc1bklnb2dJQ0FnWkdsbklEY0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTXpJZ0x5OGdiV1YwYUc5a0lDSjBiM1JoYkZOMWNIQnNlU2dwZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2FXNXBkR2xoYkdsNlpTZzNLVjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJwYm1sMGFXRnNhWHBsS0RjcFgySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQXViV2x1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMXBiblE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmJtOTBSVzUwWlhKbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gyNXZkRVZ1ZEdWeVpXUWdaWGhwYzNSekNpQWdJQ0JoYzNObGNuUWdMeThnY21VdFpXNTBaWEpsWkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNQzVoWTJOeWRXVkpiblJsY21WemRBb2dJQ0FnY0c5d0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVkyOXRjSFJ5YjJ4c1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiWEIwY205c2JHVnlJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGhZak0yTkRsbE15QXZMeUJ0WlhSb2IyUWdJbTFwYm5SQmJHeHZkMlZrS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTFwYm5SRGIyMXdkSEp2Ykd4bGNsSmxhbVZqZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1GalkzSjFZV3hDYkc5amEwNTFiV0psY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWVdOamNuVmhiRUpzYjJOclRuVnRZbVZ5SUdWNGFYTjBjd29nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNCaUlUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJOYVc1MFJuSmxjMmh1WlhOelEyaGxZMnNLSUNBZ0lHTmhiR3h6ZFdJZ1pYaGphR0Z1WjJWU1lYUmxVM1J2Y21Wa1NXNTBaWEp1WVd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeENpQWdJQ0JpZkFvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyRnNiSE4xWWlCa2IxUnlZVzV6Wm1WeVNXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlHUnBkbDhvTWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpZEc5MFlXeFRkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhSdmRHRnNVM1Z3Y0d4NUlHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpZEc5MFlXeFRkWEJ3YkhraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWkdsbklETUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbUZqWTI5MWJuUlViMnRsYm5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWWlzS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRORGRtWkRReE5tRWdMeThnYldWMGFHOWtJQ0pOYVc1MEtHRmtaSEpsYzNNc2RXbHVkREkxTml4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z2JXVjBhRzlrSUNKVWNtRnVjMlpsY2loaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhneE5URm1OMk0zTlRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1Y21Wa1pXVnRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21Wa1pXVnRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5dWIzUkZiblJsY21Wa0lHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJSEpsTFdWdWRHVnlaV1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQXVZV05qY25WbFNXNTBaWEpsYzNRS0lDQWdJSEJ2Y0FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ2NtVmtaV1Z0Um5KbGMyZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd0xuSmxaR1ZsYlZWdVpHVnliSGxwYm1kYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV1JsWlcxVmJtUmxjbXg1YVc1bk9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjl1YjNSRmJuUmxjbVZrSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklISmxMV1Z1ZEdWeVpXUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdVlXTmpjblZsU1c1MFpYSmxjM1FLSUNBZ0lIQnZjQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCeVpXUmxaVzFHY21WemFBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgyNXZkRVZ1ZEdWeVpXUWlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdVltOXljbTkzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltOXljbTkzT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmJtOTBSVzUwWlhKbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gyNXZkRVZ1ZEdWeVpXUWdaWGhwYzNSekNpQWdJQ0JoYzNObGNuUWdMeThnY21VdFpXNTBaWEpsWkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNQzVoWTJOeWRXVkpiblJsY21WemRBb2dJQ0FnY0c5d0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVkyOXRjSFJ5YjJ4c1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHTnZiWEIwY205c2JHVnlJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVNVGt6TVdReE9DQXZMeUJ0WlhSb2IyUWdJbUp2Y25KdmQwRnNiRzkzWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlwZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUW05eWNtOTNRMjl0Y0hSeWIyeHNaWEpTWldwbFkzUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhZMk55ZFdGc1FteHZZMnRPZFcxaVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpQmxlR2x6ZEhNS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZaUU5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOXljbTkzUm5KbGMyaHVaWE56UTJobFkyc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFEyRnphRkJ5YVc5eUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWWp3S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM0p5YjNkRFlYTm9UbTkwUVhaaGFXeGhZbXhsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQmliM0p5YjNkQ1lXeGhibU5sVTNSdmNtVmtTVzUwWlhKdVlXd0tJQ0FnSUdScFp5QTBDaUFnSUNCaUt3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5SdmRHRnNRbTl5Y205M2N5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOTBZV3hDYjNKeWIzZHpJR1Y0YVhOMGN3b2dJQ0FnWkdsbklEVUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ013b2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF5T0NBdkx5QWlZV05qYjNWdWRFSnZjbkp2ZDNNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTWpVZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkdsbklEUUtJQ0FnSUdKOENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUp2Y25KdmQwbHVaR1Y0SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJpYjNKeWIzZEpibVJsZUNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUExQ2lBZ0lDQmlmQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlkRzkwWVd4Q2IzSnliM2R6SWdvZ0lDQWdaR2xuSURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklEWUtJQ0FnSUdOaGJHeHpkV0lnWkc5VWNtRnVjMlpsY2s5MWRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSjhDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlmQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WlRkbE9EUXlZV01nTHk4Z2JXVjBhRzlrSUNKQ2IzSnliM2NvWVdSa2NtVnpjeXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5pa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQXVjbVZ3WVhsQ2IzSnliM2RiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYQmhlVUp2Y25KdmR6b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYm05MFJXNTBaWEpsWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaUzFsYm5SbGNtVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd0xtRmpZM0oxWlVsdWRHVnlaWE4wQ2lBZ0lDQndiM0FLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlISmxjR0Y1UW05eWNtOTNSbkpsYzJnS0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDI1dmRFVnVkR1Z5WldRaUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhneE5URm1OMk0zTlRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1Y21Wd1lYbENiM0p5YjNkQ1pXaGhiR1piY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYQmhlVUp2Y25KdmQwSmxhR0ZzWmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgyNXZkRVZ1ZEdWeVpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOXViM1JGYm5SbGNtVmtJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUhKbExXVnVkR1Z5WldRS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5dWIzUkZiblJsY21Wa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1WVdOamNuVmxTVzUwWlhKbGMzUUtJQ0FnSUhCdmNBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJ5WlhCaGVVSnZjbkp2ZDBaeVpYTm9DaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd0xteHBjWFZwWkdGMFpVSnZjbkp2ZDF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteHBjWFZwWkdGMFpVSnZjbkp2ZHpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYm05MFJXNTBaWEpsWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaUzFsYm5SbGNtVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd0xtRmpZM0oxWlVsdWRHVnlaWE4wQ2lBZ0lDQndiM0FLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTWprZ0x5OGdiV1YwYUc5a0lDSmhZMk55ZFdWSmJuUmxjbVZ6ZENncGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1RHbHhkV2xrWVhSbFFXTmpjblZsUTI5c2JHRjBaWEpoYkVsdWRHVnlaWE4wUm1GcGJHVmtDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEY0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1OdmJYQjBjbTlzYkdWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCamIyMXdkSEp2Ykd4bGNpQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlXTTNaalJrWXpnZ0x5OGdiV1YwYUc5a0lDSnNhWEYxYVdSaGRHVkNiM0p5YjNkQmJHeHZkMlZrS0dGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUR2x4ZFdsa1lYUmxRMjl0Y0hSeWIyeHNaWEpTWldwbFkzUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhZMk55ZFdGc1FteHZZMnRPZFcxaVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpQmxlR2x6ZEhNS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZaUU5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1RHbHhkV2xrWVhSbFJuSmxjMmh1WlhOelEyaGxZMnNLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ016RWdMeThnYldWMGFHOWtJQ0poWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElvS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lpRTlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVEdseGRXbGtZWFJsUTI5c2JHRjBaWEpoYkVaeVpYTm9ibVZ6YzBOb1pXTnJDaUFnSUNCa2FXY2dOUW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVEdseGRXbGtZWFJsVEdseGRXbGtZWFJ2Y2tselFtOXljbTkzWlhJS0lDQWdJR1JwWnlBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1hWEYxYVdSaGRHVkRiRzl6WlVGdGIzVnVkRWx6V21WeWJ3b2dJQ0FnWkdsbklEUUtJQ0FnSUdKNWRHVmpJREkySUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lqMDlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVEdseGRXbGtZWFJsUTJ4dmMyVkJiVzkxYm5SSmMxVnBiblJOWVhnS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBMUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTmhiR3h6ZFdJZ2NtVndZWGxDYjNKeWIzZEdjbVZ6YUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTI5dGNIUnliMnhzWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJYQjBjbTlzYkdWeUlHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVpqRXdZekkwTVNBdkx5QnRaWFJvYjJRZ0lteHBjWFZwWkdGMFpVTmhiR04xYkdGMFpWTmxhWHBsVkc5clpXNXpLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMktTaDFhVzUwTWpVMkxIVnBiblF5TlRZcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNeklLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBek5pQXpNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJNU1ZGVlNVUkJWRVZmUTA5TlVGUlNUMHhNUlZKZlEwRk1RMVZNUVZSRlgwRk5UMVZPVkY5VFJVbGFSVjlHUVVsTVJVUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QnRaWFJvYjJRZ0ltSmhiR0Z1WTJWUFppaGhaR1J5WlhOektYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR0k4UFFvZ0lDQWdZWE56WlhKMElDOHZJRXhKVVZWSlJFRlVSVjlUUlVsYVJWOVVUMDlmVFZWRFNBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JpZWlCc2FYRjFhV1JoZEdWQ2IzSnliM2RmWld4elpWOWliMlI1UURNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklEZ0tJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUhObGFYcGxTVzUwWlhKdVlXd0tDbXhwY1hWcFpHRjBaVUp2Y25KdmQxOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTlFvZ0lDQWdaR2xuSURrS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROekk0TlRZd09UTWdMeThnYldWMGFHOWtJQ0pNYVhGMWFXUmhkR1ZDYjNKeWIzY29ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmJtOTBSVzUwWlhKbFpDSUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHNhWEYxYVdSaGRHVkNiM0p5YjNkZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2FXY2dOUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBek1DQXZMeUJ0WlhSb2IyUWdJbk5sYVhwbEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUWdMeThnZEc5clpXNGdjMlZwZW5WeVpTQm1ZV2xzWldRS0lDQWdJR0lnYkdseGRXbGtZWFJsUW05eWNtOTNYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdWMzZGxaWEJVYjJ0bGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk4zWldWd1ZHOXJaVzQ2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRSWEpqTWpBNk9uTjNaV1Z3Vkc5clpXNDZJRzl1YkhrZ1lXUnRhVzRnWTJGdUlITjNaV1Z3SUhSdmEyVnVjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSjFibVJsY214NWFXNW5JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjFibVJsY214NWFXNW5JR1Y0YVhOMGN3b2dJQ0FnWkdsbklESUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnUTBWeVl6SXdPanB6ZDJWbGNGUnZhMlZ1T2lCallXNGdibTkwSUhOM1pXVndJSFZ1WkdWeWJIbHBibWNnZEc5clpXNEtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBeE9TQXZMeUJ0WlhSb2IyUWdJbUpoYkdGdVkyVlBaaWhoWkdSeVpYTnpLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBek15QXZMeUJ0WlhSb2IyUWdJblJ5WVc1elptVnlLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TGw5aFpHUlNaWE5sY25abGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbDloWkdSU1pYTmxjblpsY3pvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZibTkwUlc1MFpYSmxaQ0JsZUdsemRITUtJQ0FnSUdGemMyVnlkQ0F2THlCeVpTMWxiblJsY21Wa0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmJtOTBSVzUwWlhKbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TG1GalkzSjFaVWx1ZEdWeVpYTjBDaUFnSUNCd2IzQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFkyTnlkV0ZzUW14dlkydE9kVzFpWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdGalkzSjFZV3hDYkc5amEwNTFiV0psY2lCbGVHbHpkSE1LSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lpRTlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVdSa1VtVnpaWEoyWlhOR1lXTjBiM0pHY21WemFFTm9aV05yQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUdSdlZISmhibk5tWlhKSmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SdmRHRnNVbVZ6WlhKMlpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnZkR0ZzVW1WelpYSjJaWE1nWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZkR0ZzVW1WelpYSjJaWE1pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjhDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUF6TkNBdkx5QnRaWFJvYjJRZ0lsSmxjMlZ5ZG1WelFXUmtaV1FvWVdSa2NtVnpjeXgxYVc1ME1qVTJMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbDlrWld4bFoyRjBaVU52YlhCTWFXdGxWRzliY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwZlpHVnNaV2RoZEdWRGIyMXdUR2xyWlZSdk9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdGa2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Ym14NUlIUm9aU0JoWkcxcGJpQnRZWGtnYzJWMElIUm9aU0JqYjIxd0xXeHBhMlVnWkdWc1pXZGhkR1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaWRXNWtaWEpzZVdsdVp5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RXNWtaWEpzZVdsdVp5QmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlqTmlOalZtTWpnZ0x5OGdiV1YwYUc5a0lDSmtaV3hsWjJGMFpTaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNXBibWwwYVdGc2FYcGxLRFlwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FXNXBkR2xoYkdsNlpTZzJLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0JoWkcxcGJpQnRZWGtnYVc1cGRHbGhiR2w2WlNCMGFHVWdiV0Z5YTJWMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdOamNuVmhiRUpzYjJOclRuVnRZbVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJoWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBUMEtJQ0FnSUdKNklHbHVhWFJwWVd4cGVtVW9OaWxmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01URWdMeThnSW1KdmNuSnZkMGx1WkdWNElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaWIzSnliM2RKYm1SbGVDQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nYVc1cGRHbGhiR2w2WlNnMktWOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3BwYm1sMGFXRnNhWHBsS0RZcFgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QnRZWEpyWlhRZ2JXRjVJRzl1YkhrZ1ltVWdhVzVwZEdsaGJHbDZaV1FnYjI1alpRb2dJQ0FnWW5sMFpXTWdNalFnTHk4Z0ltbHVhWFJwWVd4RmVHTm9ZVzVuWlZKaGRHVk5ZVzUwYVhOellTSUtJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVhWFJwWVd3Z1pYaGphR0Z1WjJVZ2NtRjBaU0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlCNlpYSnZMZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNWZjMlYwUTI5dGNIUnliMnhzWlhJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJSE5sZEhScGJtY2dZMjl0Y0hSeWIyeHNaWElnWm1GcGJHVmtDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltSnZjbkp2ZDBsdVpHVjRJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpZV3hzYzNWaUlGOXpaWFJKYm5SbGNtVnpkRkpoZEdWTmIyUmxiRVp5WlhOb0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6WlhSMGFXNW5JR2x1ZEdWeVpYTjBJSEpoZEdVZ2JXOWtaV3dnWm1GcGJHVmtDaUFnSUNCaWVYUmxZeUF5TVNBdkx5QWlibUZ0WlNJS0lDQWdJR1JwWnlBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNaklnTHk4Z0luTjViV0p2YkNJS0lDQWdJR1JwWnlBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNak1nTHk4Z0ltUmxZMmx0WVd4eklnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYVc1cGRHbGhiR2w2WlNnMktWOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnBibWwwYVdGc2FYcGxLRFlwWDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdWRISmhibk5tWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBjbUZ1YzJabGNqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjl1YjNSRmJuUmxjbVZrSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklISmxMV1Z1ZEdWeVpXUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqWVd4c2MzVmlJSFJ5WVc1elptVnlWRzlyWlc1ekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMblJ5WVc1elptVnlSbkp2YlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnlZVzV6Wm1WeVJuSnZiVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmYm05MFJXNTBaWEpsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWDI1dmRFVnVkR1Z5WldRZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RZ0x5OGdjbVV0Wlc1MFpYSmxaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ2RISmhibk5tWlhKVWIydGxibk1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSTlQUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdVlYQndjbTkyWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRndjSEp2ZG1VNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklESTNJQzh2SUNKMGNtRnVjMlpsY2tGc2JHOTNZVzVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCa2FXY2dNd29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREU0WlRBNU5EWXhJQzh2SUcxbGRHaHZaQ0FpUVhCd2NtOTJZV3dvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQXVZV3hzYjNkaGJtTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVd4c2IzZGhibU5sT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXlOeUF2THlBaWRISmhibk5tWlhKQmJHeHZkMkZ1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUM1aVlXeGhibU5sVDJaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGlZV3hoYm1ObFQyWTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbUZqWTI5MWJuUlViMnRsYm5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TG1KaGJHRnVZMlZQWmxWdVpHVnliSGxwYm1kYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGlZV3hoYm1ObFQyWlZibVJsY214NWFXNW5PZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdVpYaGphR0Z1WjJWU1lYUmxRM1Z5Y21WdWRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdKOENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UTWdMeThnSW1GalkyOTFiblJVYjJ0bGJuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1kyRnNiSE4xWWlCdGRXeGZLRElwQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TUdSbE1HSTJZak5oTnpZME1EQXdNQW9nSUNBZ1lpOEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUM1blpYUkJZMk52ZFc1MFUyNWhjSE5vYjNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJCWTJOdmRXNTBVMjVoY0hOb2IzUTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdSMWNBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlZV05qYjNWdWRGUnZhMlZ1Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJR0p2Y25KdmQwSmhiR0Z1WTJWVGRHOXlaV1JKYm5SbGNtNWhiQW9nSUNBZ1kyRnNiSE4xWWlCbGVHTm9ZVzVuWlZKaGRHVlRkRzl5WldSSmJuUmxjbTVoYkFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWZBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNWliM0p5YjNkU1lYUmxVR1Z5UW14dlkydGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYjNKeWIzZFNZWFJsVUdWeVFteHZZMnM2Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCallXeHNjM1ZpSUdkbGRFTmhjMmhRY21sdmNnb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyRnNiSE4xWWlCblpYUkRZWE5vVUhKcGIzSUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hDYjNKeWIzZHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiM1JoYkVKdmNuSnZkM01nWlhocGMzUnpDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOTBZV3hTWlhObGNuWmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4U1pYTmxjblpsY3lCbGVHbHpkSE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlhVzUwWlhKbGMzUlNZWFJsVFc5a1pXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHbHVkR1Z5WlhOMFVtRjBaVTF2WkdWc0lHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXpOU0F2THlCdFpYUm9iMlFnSW1kbGRFSnZjbkp2ZDFKaGRHVW9kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZcGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQXVjM1Z3Y0d4NVVtRjBaVkJsY2tKc2IyTnJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNWd2NHeDVVbUYwWlZCbGNrSnNiMk5yT2dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1kyRnNiSE4xWWlCblpYUkRZWE5vVUhKcGIzSUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBRMkZ6YUZCeWFXOXlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luUnZkR0ZzUW05eWNtOTNjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4Q2IzSnliM2R6SUdWNGFYTjBjd29nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZkR0ZzVW1WelpYSjJaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJ2ZEdGc1VtVnpaWEoyWlhNZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbkpsYzJWeWRtVkdZV04wYjNKTllXNTBhWE56WVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21WelpYSjJaVVpoWTNSdmNrMWhiblJwYzNOaElHVjRhWE4wY3dvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0pwYm5SbGNtVnpkRkpoZEdWTmIyUmxiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dhVzUwWlhKbGMzUlNZWFJsVFc5a1pXd2daWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHUmlNMlEzWmpSaElDOHZJRzFsZEdodlpDQWlaMlYwVTNWd2NHeDVVbUYwWlNoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TG5SdmRHRnNRbTl5Y205M2MwTjFjbkpsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBiM1JoYkVKdmNuSnZkM05EZFhKeVpXNTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZibTkwUlc1MFpYSmxaQ0JsZUdsemRITUtJQ0FnSUdGemMyVnlkQ0F2THlCeVpTMWxiblJsY21Wa0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmJtOTBSVzUwWlhKbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TG1GalkzSjFaVWx1ZEdWeVpYTjBDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hDYjNKeWIzZHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiM1JoYkVKdmNuSnZkM01nWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdVltOXljbTkzUW1Gc1lXNWpaVU4xY25KbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYjNKeWIzZENZV3hoYm1ObFEzVnljbVZ1ZERvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYm05MFJXNTBaWEpsWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaUzFsYm5SbGNtVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd0xtRmpZM0oxWlVsdWRHVnlaWE4wQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmpZV3hzYzNWaUlHSnZjbkp2ZDBKaGJHRnVZMlZUZEc5eVpXUkpiblJsY201aGJBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TG1KdmNuSnZkMEpoYkdGdVkyVlRkRzl5WldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGliM0p5YjNkQ1lXeGhibU5sVTNSdmNtVmtPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCallXeHNjM1ZpSUdKdmNuSnZkMEpoYkdGdVkyVlRkRzl5WldSSmJuUmxjbTVoYkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbVY0WTJoaGJtZGxVbUYwWlVOMWNuSmxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbGVHTm9ZVzVuWlZKaGRHVkRkWEp5Wlc1ME9nb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TG1WNFkyaGhibWRsVW1GMFpVTjFjbkpsYm5RS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNQzVsZUdOb1lXNW5aVkpoZEdWVGRHOXlaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbGVHTm9ZVzVuWlZKaGRHVlRkRzl5WldRNkNpQWdJQ0JqWVd4c2MzVmlJR1Y0WTJoaGJtZGxVbUYwWlZOMGIzSmxaRWx1ZEdWeWJtRnNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdVoyVjBRMkZ6YUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRU5oYzJnNkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEVOaGMyaFFjbWx2Y2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbUZqWTNKMVpVbHVkR1Z5WlhOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV05qY25WbFNXNTBaWEpsYzNRNkNpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1WVdOamNuVmxTVzUwWlhKbGMzUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUM1elpXbDZaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGFYcGxPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl1YjNSRmJuUmxjbVZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYm05MFJXNTBaWEpsWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaUzFsYm5SbGNtVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCelpXbDZaVWx1ZEdWeWJtRnNDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZibTkwUlc1MFpYSmxaQ0lLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNWZjMlYwVUdWdVpHbHVaMEZrYldsdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tYM05sZEZCbGJtUnBibWRCWkcxcGJqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaFpHMXBiaUJsZUdsemRITUtJQ0FnSUNFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdVMlYwVUdWdVpHbHVaMEZrYldsdVQzZHVaWEpEYUdWamF3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKd1pXNWthVzVuUVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIQmxibVJwYm1kQlpHMXBiaUJsZUdsemRITUtJQ0FnSUdKNWRHVmpJREUzSUM4dklDSndaVzVrYVc1blFXUnRhVzRpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNellnTHk4Z2JXVjBhRzlrSUNKT1pYZFFaVzVrYVc1blFXUnRhVzRvWVdSa2NtVnpjeXhoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbDloWTJObGNIUkJaRzFwYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNsOWhZMk5sY0hSQlpHMXBiam9LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOeUF2THlBaWNHVnVaR2x1WjBGa2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QndaVzVrYVc1blFXUnRhVzRnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ0lUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJObGNIUkJaRzFwYmxCbGJtUnBibWRCWkcxcGJrTm9aV05yQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUQwOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV05qWlhCMFFXUnRhVzVRWlc1a2FXNW5RV1J0YVc1RGFHVmphd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpY0dWdVpHbHVaMEZrYldsdUlnb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WXpCbE0yWXpZMllnTHk4Z2JXVjBhRzlrSUNKT1pYZEJaRzFwYmloaFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR0o1ZEdWaklERXdJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXpOaUF2THlCdFpYUm9iMlFnSWs1bGQxQmxibVJwYm1kQlpHMXBiaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQXVYM05sZEVOdmJYQjBjbTlzYkdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tYM05sZEVOdmJYQjBjbTlzYkdWeU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1WDNObGRFTnZiWEIwY205c2JHVnlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdVgzTmxkRkpsYzJWeWRtVkdZV04wYjNKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGZjMlYwVW1WelpYSjJaVVpoWTNSdmNqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjl1YjNSRmJuUmxjbVZrSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklISmxMV1Z1ZEdWeVpXUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXViM1JGYm5SbGNtVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdVlXTmpjblZsU1c1MFpYSmxjM1FLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMjV2ZEVWdWRHVnlaV1FpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQWhQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZObGRGSmxjMlZ5ZG1WR1lXTjBiM0pCWkcxcGJrTm9aV05yQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV05qY25WaGJFSnNiMk5yVG5WdFltVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmhZMk55ZFdGc1FteHZZMnRPZFcxaVpYSWdaWGhwYzNSekNpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJR0loUFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGTmxkRkpsYzJWeWRtVkdZV04wYjNKR2NtVnphRU5vWldOckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z01IZ3daR1V3WWpaaU0yRTNOalF3TURBd0NpQWdJQ0JpUGdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGTmxkRkpsYzJWeWRtVkdZV04wYjNKQ2IzVnVaSE5EYUdWamF3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTRJQzh2SUNKeVpYTmxjblpsUm1GamRHOXlUV0Z1ZEdsemMyRWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklISmxjMlZ5ZG1WR1lXTjBiM0pOWVc1MGFYTnpZU0JsZUdsemRITUtJQ0FnSUdKNWRHVmpJREU0SUM4dklDSnlaWE5sY25abFJtRmpkRzl5VFdGdWRHbHpjMkVpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW53S0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5URXdabUV3WmpBZ0x5OGdiV1YwYUc5a0lDSk9aWGRTWlhObGNuWmxSbUZqZEc5eUtIVnBiblF5TlRZc2RXbHVkREkxTmlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUM1ZmNtVmtkV05sVW1WelpYSjJaWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwZmNtVmtkV05sVW1WelpYSjJaWE02Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5dWIzUkZiblJsY21Wa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCZmJtOTBSVzUwWlhKbFpDQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJ5WlMxbGJuUmxjbVZrQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmYm05MFJXNTBaWEpsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbUZqWTNKMVpVbHVkR1Z5WlhOMENpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5dWIzUkZiblJsY21Wa0lnb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdGa2JXbHVJR1Y0YVhOMGN3b2dJQ0FnSVQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaV1IxWTJWU1pYTmxjblpsYzBGa2JXbHVRMmhsWTJzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR0ZqWTNKMVlXeENiRzlqYTA1MWJXSmxjaUJsZUdsemRITUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYVhSdllnb2dJQ0FnWWlFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdVbVZrZFdObFVtVnpaWEoyWlhOR2NtVnphRU5vWldOckNpQWdJQ0JqWVd4c2MzVmlJR2RsZEVOaGMyaFFjbWx2Y2dvZ0lDQWdaR2xuSURJS0lDQWdJR0k4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1VtVmtkV05sVW1WelpYSjJaWE5EWVhOb1RtOTBRWFpoYVd4aFlteGxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOTBZV3hTWlhObGNuWmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4U1pYTmxjblpsY3lCbGVHbHpkSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZajRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pXUjFZMlZTWlhObGNuWmxjME5oYzJoV1lXeHBaR0YwYVc5dUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWkdsbklESUtJQ0FnSUdJdENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOTBZV3hTWlhObGNuWmxjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaFpHMXBiaUJsZUdsemRITUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUdSdlZISmhibk5tWlhKUGRYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKOENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa05tWXlZelE1WXlBdkx5QnRaWFJvYjJRZ0lsSmxjMlZ5ZG1WelVtVmtkV05sWkNoaFpHUnlaWE56TEhWcGJuUXlOVFlzZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNQzVmYzJWMFNXNTBaWEpsYzNSU1lYUmxUVzlrWld4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGZjMlYwU1c1MFpYSmxjM1JTWVhSbFRXOWtaV3c2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNWhZMk55ZFdWSmJuUmxjbVZ6ZEFvZ0lDQWdjRzl3Q2lBZ0lDQmpZV3hzYzNWaUlGOXpaWFJKYm5SbGNtVnpkRkpoZEdWTmIyUmxiRVp5WlhOb0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1ZFc1a1pYSnNlV2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVnVaR1Z5YkhscGJtYzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0luVnVaR1Z5YkhscGJtY2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIVnVaR1Z5YkhscGJtY2daWGhwYzNSekNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUM1dVlXMWxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYm1GdFpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXlNU0F2THlBaWJtRnRaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dibUZ0WlNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNXplVzFpYjJ4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHplVzFpYjJ3NkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01qSWdMeThnSW5ONWJXSnZiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djM2x0WW05c0lHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbVJsWTJsdFlXeHpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWamFXMWhiSE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWpNZ0x5OGdJbVJsWTJsdFlXeHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmtaV05wYldGc2N5QmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TG1Ga2JXbHVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVdSdGFXNDZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR0ZrYldsdUlHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1Y0dWdVpHbHVaMEZrYldsdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR1Z1WkdsdVowRmtiV2x1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0p3Wlc1a2FXNW5RV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhCbGJtUnBibWRCWkcxcGJpQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TG1OdmJYQjBjbTlzYkdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMjl0Y0hSeWIyeHNaWEk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlZMjl0Y0hSeWIyeHNaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052YlhCMGNtOXNiR1Z5SUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQXVhVzUwWlhKbGMzUlNZWFJsVFc5a1pXeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYm5SbGNtVnpkRkpoZEdWTmIyUmxiRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlhVzUwWlhKbGMzUlNZWFJsVFc5a1pXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHbHVkR1Z5WlhOMFVtRjBaVTF2WkdWc0lHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1Y21WelpYSjJaVVpoWTNSdmNrMWhiblJwYzNOaFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ6WlhKMlpVWmhZM1J2Y2sxaGJuUnBjM05oT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFNElDOHZJQ0p5WlhObGNuWmxSbUZqZEc5eVRXRnVkR2x6YzJFaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhKbGMyVnlkbVZHWVdOMGIzSk5ZVzUwYVhOellTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNQzVoWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFkyTnlkV0ZzUW14dlkydE9kVzFpWlhJNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdOamNuVmhiRUpzYjJOclRuVnRZbVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJoWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdVltOXljbTkzU1c1a1pYaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYjNKeWIzZEpibVJsZURvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWW05eWNtOTNTVzVrWlhnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdKdmNuSnZkMGx1WkdWNElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMblJ2ZEdGc1FtOXljbTkzYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnZkR0ZzUW05eWNtOTNjem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSjBiM1JoYkVKdmNuSnZkM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJ2ZEdGc1FtOXljbTkzY3lCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNTBiM1JoYkZKbGMyVnlkbVZ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOTBZV3hTWlhObGNuWmxjem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjBiM1JoYkZKbGMyVnlkbVZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYjNSaGJGSmxjMlZ5ZG1WeklHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMblJ2ZEdGc1UzVndjR3g1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOTBZV3hUZFhCd2JIazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0luUnZkR0ZzVTNWd2NHeDVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiM1JoYkZOMWNIQnNlU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUM1blpYUkRZWE5vVUhKcGIzSW9LU0F0UGlCaWVYUmxjem9LWjJWMFEyRnphRkJ5YVc5eU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTFJQzh2SUNKMWJtUmxjbXg1YVc1bklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMWJtUmxjbXg1YVc1bklHVjRhWE4wY3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ01Ua2dMeThnYldWMGFHOWtJQ0ppWVd4aGJtTmxUMllvWVdSa2NtVnpjeWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUM1a2IxUnlZVzV6Wm1WeVNXNG9abkp2YlRvZ1lubDBaWE1zSUdGdGIzVnVkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BrYjFSeVlXNXpabVZ5U1c0NkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSjFibVJsY214NWFXNW5JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjFibVJsY214NWFXNW5JR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJREU1SUM4dklHMWxkR2h2WkNBaVltRnNZVzVqWlU5bUtHRmtaSEpsYzNNcGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WWpjelpXRXlaR1lnTHk4Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2taeWIyMG9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdKNWRHVmpJRE0zSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ2JXRjBZMmdnWkc5VWNtRnVjMlpsY2tsdVgzTjNhWFJqYUY5allYTmxYekJBTXlCa2IxUnlZVzV6Wm1WeVNXNWZjM2RwZEdOb1gyTmhjMlZmTVVBMENpQWdJQ0JsY25JZ0x5OGdjbVYyWlhKMENncGtiMVJ5WVc1elptVnlTVzVmYzNkcGRHTm9YMk5oYzJWZk1VQTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb0taRzlVY21GdWMyWmxja2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTmpvS0lDQWdJR0Z6YzJWeWRDQXZMeUJVVDB0RlRsOVVVa0ZPVTBaRlVsOUpUbDlHUVVsTVJVUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJREU1SUM4dklHMWxkR2h2WkNBaVltRnNZVzVqWlU5bUtHRmtaSEpsYzNNcGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXJDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0taRzlVY21GdWMyWmxja2x1WDNOM2FYUmphRjlqWVhObFh6QkFNem9LSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaUlHUnZWSEpoYm5ObVpYSkpibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFlLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbVJ2VkhKaGJuTm1aWEpQZFhRb2RHODZJR0o1ZEdWekxDQmhiVzkxYm5RNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwa2IxUnlZVzV6Wm1WeVQzVjBPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpZFc1a1pYSnNlV2x1WnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZFc1a1pYSnNlV2x1WnlCbGVHbHpkSE1LSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRE16SUM4dklHMWxkR2h2WkNBaWRISmhibk5tWlhJb1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSjVkR1ZqSURNM0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF5TUFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdiV0YwWTJnZ1pHOVVjbUZ1YzJabGNrOTFkRjl6ZDJsMFkyaGZZMkZ6WlY4d1FESWdaRzlVY21GdWMyWmxjazkxZEY5emQybDBZMmhmWTJGelpWOHhRRE1LSUNBZ0lHVnljaUF2THlCeVpYWmxjblFLQ21SdlZISmhibk5tWlhKUGRYUmZjM2RwZEdOb1gyTmhjMlZmTVVBek9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvS1pHOVVjbUZ1YzJabGNrOTFkRjl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFU2Q2lBZ0lDQmhjM05sY25RZ0x5OGdWRTlMUlU1ZlZGSkJUbE5HUlZKZlQxVlVYMFpCU1V4RlJBb2dJQ0FnY21WMGMzVmlDZ3BrYjFSeVlXNXpabVZ5VDNWMFgzTjNhWFJqYUY5allYTmxYekJBTWpvS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQmlJR1J2VkhKaGJuTm1aWEpQZFhSZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMk52YlhCdmRXNWtMWFl5TDJOdmJuUnlZV04wY3k5RFJYSmpNakJKYlcxMWRHRmliR1V1YzI5c0xrTkZjbU15TUM1MGNtRnVjMlpsY2xSdmEyVnVjeWh6Y0dWdVpHVnlPaUJpZVhSbGN5d2djM0pqT2lCaWVYUmxjeXdnWkhOME9pQmllWFJsY3l3Z2RHOXJaVzV6T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q25SeVlXNXpabVZ5Vkc5clpXNXpPZ29nSUNBZ2NISnZkRzhnTkNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSmpiMjF3ZEhKdmJHeGxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZMjl0Y0hSeWIyeHNaWElnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGs0WmpreE5XSm1JQzh2SUcxbGRHaHZaQ0FpZEhKaGJuTm1aWEpCYkd4dmQyVmtLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJVY21GdWMyWmxja052YlhCMGNtOXNiR1Z5VW1WcVpXTjBhVzl1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1BUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJVY21GdWMyWmxjazV2ZEVGc2JHOTNaV1FLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNBOVBRb2dJQ0FnWW5vZ2RISmhibk5tWlhKVWIydGxibk5mWld4elpWOWliMlI1UURjS0lDQWdJR0o1ZEdWaklESTJJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpnb0tkSEpoYm5ObVpYSlViMnRsYm5OZllXWjBaWEpmYVdaZlpXeHpaVUE0T2dvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0poWTJOdmRXNTBWRzlyWlc1eklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltRmpZMjkxYm5SVWIydGxibk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSXJDaUFnSUNCa2FXY2dNd29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdZbmwwWldNZ01qWWdMeThnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpSVQwS0lDQWdJR0o2SUhSeVlXNXpabVZ5Vkc5clpXNXpYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTWpjZ0x5OGdJblJ5WVc1elptVnlRV3hzYjNkaGJtTmxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmliM2hmY0hWMENncDBjbUZ1YzJabGNsUnZhMlZ1YzE5aFpuUmxjbDlwWmw5bGJITmxRREV3T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdiV1YwYUc5a0lDSlVjbUZ1YzJabGNpaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTmlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncDBjbUZ1YzJabGNsUnZhMlZ1YzE5bGJITmxYMkp2WkhsQU56b0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTWpjZ0x5OGdJblJ5WVc1elptVnlRV3hzYjNkaGJtTmxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmlJSFJ5WVc1elptVnlWRzlyWlc1elgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1WW05eWNtOTNRbUZzWVc1alpWTjBiM0psWkVsdWRHVnlibUZzS0dGalkyOTFiblE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWW05eWNtOTNRbUZzWVc1alpWTjBiM0psWkVsdWRHVnlibUZzT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTWpnZ0x5OGdJbUZqWTI5MWJuUkNiM0p5YjNkeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURJMUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBUMEtJQ0FnSUdKNklHSnZjbkp2ZDBKaGJHRnVZMlZUZEc5eVpXUkpiblJsY201aGJGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NtSnZjbkp2ZDBKaGJHRnVZMlZUZEc5eVpXUkpiblJsY201aGJGOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdNalVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0ppYjNKeWIzZEpibVJsZUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWW05eWNtOTNTVzVrWlhnZ1pYaHBjM1J6Q2lBZ0lDQmlLZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ1lpOEtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQXVaWGhqYUdGdVoyVlNZWFJsUTNWeWNtVnVkQ2dwSUMwK0lHSjVkR1Z6T2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd0xtVjRZMmhoYm1kbFVtRjBaVU4xY25KbGJuUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgyNXZkRVZ1ZEdWeVpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOXViM1JGYm5SbGNtVmtJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUhKbExXVnVkR1Z5WldRS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5dWIzUkZiblJsY21Wa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1WVdOamNuVmxTVzUwWlhKbGMzUUtJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgyNXZkRVZ1ZEdWeVpXUWlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdOaGJHeHpkV0lnWlhoamFHRnVaMlZTWVhSbFUzUnZjbVZrU1c1MFpYSnVZV3dLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OWpiMjF3YjNWdVpDMTJNaTlqYjI1MGNtRmpkSE12UTBWeVl6SXdTVzF0ZFhSaFlteGxMbk52YkM1RFJYSmpNakF1WlhoamFHRnVaMlZTWVhSbFUzUnZjbVZrU1c1MFpYSnVZV3dvS1NBdFBpQmllWFJsY3pvS1pYaGphR0Z1WjJWU1lYUmxVM1J2Y21Wa1NXNTBaWEp1WVd3NkNpQWdJQ0J3Y205MGJ5QXdJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWlkRzkwWVd4VGRYQndiSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGIzUmhiRk4xY0hCc2VTQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nWlhoamFHRnVaMlZTWVhSbFUzUnZjbVZrU1c1MFpYSnVZV3hmWld4elpWOWliMlI1UURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU5DQXZMeUFpYVc1cGRHbGhiRVY0WTJoaGJtZGxVbUYwWlUxaGJuUnBjM05oSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJwYm1sMGFXRnNSWGhqYUdGdVoyVlNZWFJsVFdGdWRHbHpjMkVnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ21WNFkyaGhibWRsVW1GMFpWTjBiM0psWkVsdWRHVnlibUZzWDJWc2MyVmZZbTlrZVVBeU9nb2dJQ0FnWTJGc2JITjFZaUJuWlhSRFlYTm9VSEpwYjNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0owYjNSaGJFSnZjbkp2ZDNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhSdmRHRnNRbTl5Y205M2N5QmxlR2x6ZEhNS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2ZEdGc1VtVnpaWEoyWlhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhSdmRHRnNVbVZ6WlhKMlpYTWdaWGhwYzNSekNpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR0o1ZEdWaklERTBJQzh2SURCNE1HUmxNR0kyWWpOaE56WTBNREF3TUFvZ0lDQWdZaW9LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaUx3b2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNWhZMk55ZFdWSmJuUmxjbVZ6ZENncElDMCtJR0o1ZEdWek9nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbUZqWTNKMVpVbHVkR1Z5WlhOME9nb2dJQ0FnY0hKdmRHOGdNQ0F4Q2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmpZM0oxWVd4Q2JHOWphMDUxYldKbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJoWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElnWlhocGMzUnpDaUFnSUNCaVBUMEtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5amIyMXdiM1Z1WkMxMk1pOWpiMjUwY21GamRITXZRMFZ5WXpJd1NXMXRkWFJoWW14bExuTnZiQzVEUlhKak1qQXVZV05qY25WbFNXNTBaWEpsYzNSZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlqYjIxd2IzVnVaQzEyTWk5amIyNTBjbUZqZEhNdlEwVnlZekl3U1cxdGRYUmhZbXhsTG5OdmJDNURSWEpqTWpBdVlXTmpjblZsU1c1MFpYSmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ1kyRnNiSE4xWWlCblpYUkRZWE5vVUhKcGIzSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKMGIzUmhiRUp2Y25KdmQzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnZkR0ZzUW05eWNtOTNjeUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIzUmhiRkpsYzJWeWRtVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiM1JoYkZKbGMyVnlkbVZ6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmliM0p5YjNkSmJtUmxlQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZbTl5Y205M1NXNWtaWGdnWlhocGMzUnpDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKcGJuUmxjbVZ6ZEZKaGRHVk5iMlJsYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYVc1MFpYSmxjM1JTWVhSbFRXOWtaV3dnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURNMUlDOHZJRzFsZEdodlpDQWlaMlYwUW05eWNtOTNVbUYwWlNoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EUTRZekkzTXprMU1EQXdDaUFnSUNCaVBEMEtJQ0FnSUdGemMyVnlkQ0F2THlCaWIzSnliM2NnY21GMFpTQnBjeUJoWW5OMWNtUnNlU0JvYVdkb0NpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdiWFZzWHlneUtRb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05nb2dJQ0FnWTJGc2JITjFZaUJ0ZFd4ZktESXBDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdKNWRHVmpJREUwSUM4dklEQjRNR1JsTUdJMllqTmhOelkwTURBd01Bb2dJQ0FnWWk4S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCaUt3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTRJQzh2SUNKeVpYTmxjblpsUm1GamRHOXlUV0Z1ZEdsemMyRWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklISmxjMlZ5ZG1WR1lXTjBiM0pOWVc1MGFYTnpZU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTBDaUFnSUNCaWZBb2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnYlhWc1h5Z3lLUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QXdlREJrWlRCaU5tSXpZVGMyTkRBd01EQUtJQ0FnSUdJdkNpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTmhiR3h6ZFdJZ1lXUmtYeWd5S1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dOZ29nSUNBZ1kyRnNiSE4xWWlCdGRXeGZLRElwQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TUdSbE1HSTJZak5oTnpZME1EQXdNQW9nSUNBZ1lpOEtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMkZzYkhOMVlpQmhaR1JmS0RJcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFkyTnlkV0ZzUW14dlkydE9kVzFpWlhJaUNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWW05eWNtOTNTVzVrWlhnaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luUnZkR0ZzUW05eWNtOTNjeUlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEc5MFlXeFNaWE5sY25abGN5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBekNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlmQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdScFp5QTBDaUFnSUNCaWZBb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1lud0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WmpZMlpHRXlPR0VnTHk4Z2JXVjBhRzlrSUNKQlkyTnlkV1ZKYm5SbGNtVnpkQ2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WTI5dGNHOTFibVF0ZGpJdlkyOXVkSEpoWTNSekwwTkZjbU15TUVsdGJYVjBZV0pzWlM1emIyd3VRMFZ5WXpJd0xuSmxaR1ZsYlVaeVpYTm9LSEpsWkdWbGJXVnlPaUJpZVhSbGN5d2djbVZrWldWdFZHOXJaVzV6U1c0NklHSjVkR1Z6TENCeVpXUmxaVzFCYlc5MWJuUkpiam9nWW5sMFpYTXBJQzArSUhadmFXUTZDbkpsWkdWbGJVWnlaWE5vT2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbTU2SUhKbFpHVmxiVVp5WlhOb1gySnZiMnhmZEhKMVpVQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJOVBRb2dJQ0FnWW5vZ2NtVmtaV1Z0Um5KbGMyaGZZbTl2YkY5bVlXeHpaVUF6Q2dweVpXUmxaVzFHY21WemFGOWliMjlzWDNSeWRXVkFNam9LSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3B5WldSbFpXMUdjbVZ6YUY5aWIyOXNYMjFsY21kbFFEUTZDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNWxJRzltSUhKbFpHVmxiVlJ2YTJWdWMwbHVJRzl5SUhKbFpHVmxiVUZ0YjNWdWRFbHVJRzExYzNRZ1ltVWdlbVZ5YndvZ0lDQWdZMkZzYkhOMVlpQmxlR05vWVc1blpWSmhkR1ZUZEc5eVpXUkpiblJsY201aGJBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0o4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWVpQnlaV1JsWlcxR2NtVnphRjlsYkhObFgySnZaSGxBTmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlHMTFiRjhvTWlrS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZbmwwWldNZ01UUWdMeThnTUhnd1pHVXdZalppTTJFM05qUXdNREF3Q2lBZ0lDQmlMd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtDbkpsWkdWbGJVWnlaWE5vWDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTI5dGNIUnliMnhzWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJYQjBjbTlzYkdWeUlHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnek9UYzBNR0k1TUNBdkx5QnRaWFJvYjJRZ0luSmxaR1ZsYlVGc2JHOTNaV1FvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXBkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRkpsWkdWbGJVTnZiWEIwY205c2JHVnlVbVZxWldOMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXTmpjblZoYkVKc2IyTnJUblZ0WW1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaFkyTnlkV0ZzUW14dlkydE9kVzFpWlhJZ1pYaHBjM1J6Q2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbDBiMklLSUNBZ0lHSWhQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZKbFpHVmxiVVp5WlhOb2JtVnpjME5vWldOckNpQWdJQ0JqWVd4c2MzVmlJR2RsZEVOaGMyaFFjbWx2Y2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZandLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pXUmxaVzFVY21GdWMyWmxjazkxZEU1dmRGQnZjM05wWW14bENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01USWdMeThnSW5SdmRHRnNVM1Z3Y0d4NUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGIzUmhiRk4xY0hCc2VTQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ013b2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaWRHOTBZV3hUZFhCd2JIa2lDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0poWTJOdmRXNTBWRzlyWlc1eklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdScFp5QTBDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdaRzlVY21GdWMyWmxjazkxZEFvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXlNQ0F2THlCdFpYUm9iMlFnSWxSeVlXNXpabVZ5S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWW53S0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTJNbVEzT1dNeUlDOHZJRzFsZEdodlpDQWlVbVZrWldWdEtHRmtaSEpsYzNNc2RXbHVkREkxTml4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbU52YlhCMGNtOXNiR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjIxd2RISnZiR3hsY2lCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WldaaVpESXhaRGdnTHk4Z2JXVjBhRzlrSUNKeVpXUmxaVzFXWlhKcFpua29ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZc2RXbHVkREkxTmlsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCeVpYUnpkV0lLQ25KbFpHVmxiVVp5WlhOb1gyVnNjMlZmWW05a2VVQTJPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUdScGRsOG9NaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCaUlISmxaR1ZsYlVaeVpYTm9YMkZtZEdWeVgybG1YMlZzYzJWQU53b0tjbVZrWldWdFJuSmxjMmhmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnY21Wa1pXVnRSbkpsYzJoZlltOXZiRjl0WlhKblpVQTBDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNXlaWEJoZVVKdmNuSnZkMFp5WlhOb0tIQmhlV1Z5T2lCaWVYUmxjeXdnWW05eWNtOTNaWEk2SUdKNWRHVnpMQ0J5WlhCaGVVRnRiM1Z1ZERvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dweVpYQmhlVUp2Y25KdmQwWnlaWE5vT2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbU52YlhCMGNtOXNiR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJqYjIxd2RISnZiR3hsY2lCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRneFl6bGhaRE1nTHk4Z2JXVjBhRzlrSUNKeVpYQmhlVUp2Y25KdmQwRnNiRzkzWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVW1Wd1lYbENiM0p5YjNkRGIyMXdkSEp2Ykd4bGNsSmxhbVZqZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1GalkzSjFZV3hDYkc5amEwNTFiV0psY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWVdOamNuVmhiRUpzYjJOclRuVnRZbVZ5SUdWNGFYTjBjd29nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNCaUlUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWlhCaGVVSnZjbkp2ZDBaeVpYTm9ibVZ6YzBOb1pXTnJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnWW05eWNtOTNRbUZzWVc1alpWTjBiM0psWkVsdWRHVnlibUZzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqSURJMklDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZajA5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUdSdlZISmhibk5tWlhKSmJnb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdScFp5QXhDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKMGIzUmhiRUp2Y25KdmQzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnZkR0ZzUW05eWNtOTNjeUJsZUdsemRITUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXJDaUFnSUNCa2FXY2dNZ29nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTWpnZ0x5OGdJbUZqWTI5MWJuUkNiM0p5YjNkeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURJMUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdScFp5QTFDaUFnSUNCaWZBb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0ppYjNKeWIzZEpibVJsZUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWW05eWNtOTNTVzVrWlhnZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTmdvZ0lDQWdZbndLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblJ2ZEdGc1FtOXljbTkzY3lJS0lDQWdJR1JwWnlBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWkdsbklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHRmtOak5sTkdZMElDOHZJRzFsZEdodlpDQWlVbVZ3WVhsQ2IzSnliM2NvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbk5sYVhwbFNXNTBaWEp1WVd3b2MyVnBlbVZ5Vkc5clpXNDZJR0o1ZEdWekxDQnNhWEYxYVdSaGRHOXlPaUJpZVhSbGN5d2dZbTl5Y205M1pYSTZJR0o1ZEdWekxDQnpaV2w2WlZSdmEyVnVjem9nWW5sMFpYTXBJQzArSUhadmFXUTZDbk5sYVhwbFNXNTBaWEp1WVd3NkNpQWdJQ0J3Y205MGJ5QTBJREFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTI5dGNIUnliMnhzWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOdmJYQjBjbTlzYkdWeUlHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneVptUmtZMlU1WmlBdkx5QnRaWFJvYjJRZ0luTmxhWHBsUVd4c2IzZGxaQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRXhwY1hWcFpHRjBaVk5sYVhwbFEyOXRjSFJ5YjJ4c1pYSlNaV3BsWTNScGIyNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0E5UFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFeHBjWFZwWkdGMFpWTmxhWHBsVEdseGRXbGtZWFJ2Y2tselFtOXljbTkzWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTJNemM1WkdFd05XSTJNREF3TUFvZ0lDQWdZMkZzYkhOMVlpQnRkV3hmS0RJcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JqWVd4c2MzVmlJR1Y0WTJoaGJtZGxVbUYwWlZOMGIzSmxaRWx1ZEdWeWJtRnNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNd29nSUNBZ1lud0tJQ0FnSUdScFp5QXlDaUFnSUNCallXeHNjM1ZpSUcxMWJGOG9NaWtLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1lubDBaV01nTVRRZ0x5OGdNSGd3WkdVd1lqWmlNMkUzTmpRd01EQXdDaUFnSUNCaUx3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SdmRHRnNVbVZ6WlhKMlpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnZkR0ZzVW1WelpYSjJaWE1nWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZkR0ZzVW1WelpYSjJaWE1pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpZEc5MFlXeFRkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhSdmRHRnNVM1Z3Y0d4NUlHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1JwWnlBMENpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKMGIzUmhiRk4xY0hCc2VTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbUZqWTI5MWJuUlViMnRsYm5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE15QXZMeUFpWVdOamIzVnVkRlJ2YTJWdWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdScFp5QTBDaUFnSUNCaUt3b2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeU1DQXZMeUJ0WlhSb2IyUWdJbFJ5WVc1elptVnlLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklETUtJQ0FnSUdKOENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdiV1YwYUc5a0lDSlVjbUZ1YzJabGNpaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTmlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlmQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTXpRZ0x5OGdiV1YwYUc5a0lDSlNaWE5sY25abGMwRmtaR1ZrS0dGa1pISmxjM01zZFdsdWRESTFOaXgxYVc1ME1qVTJLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZZMjl0Y0c5MWJtUXRkakl2WTI5dWRISmhZM1J6TDBORmNtTXlNRWx0YlhWMFlXSnNaUzV6YjJ3dVEwVnlZekl3TGw5elpYUkRiMjF3ZEhKdmJHeGxjaWh1WlhkRGIyMXdkSEp2Ykd4bGNqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbDl6WlhSRGIyMXdkSEp2Ykd4bGNqb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJQ0U5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1UyVjBRMjl0Y0hSeWIyeHNaWEpQZDI1bGNrTm9aV05yQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlZMjl0Y0hSeWIyeHNaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR052YlhCMGNtOXNiR1Z5SUdWNGFYTjBjd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZzVNRFEyWVdGaklDOHZJRzFsZEdodlpDQWlhWE5EYjIxd2RISnZiR3hsY2lncFltOXZiQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lYTnpaWEowSUM4dklHMWhjbXRsY2lCdFpYUm9iMlFnY21WMGRYSnVaV1FnWm1Gc2MyVUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltTnZiWEIwY205c2JHVnlJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGMxWWpZeVpUTTRJQzh2SUcxbGRHaHZaQ0FpVG1WM1EyOXRjSFJ5YjJ4c1pYSW9ZV1JrY21WemN5eGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNWZjMlYwU1c1MFpYSmxjM1JTWVhSbFRXOWtaV3hHY21WemFDaHVaWGRKYm5SbGNtVnpkRkpoZEdWTmIyUmxiRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BmYzJWMFNXNTBaWEpsYzNSU1lYUmxUVzlrWld4R2NtVnphRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaFpHMXBiaUJsZUdsemRITUtJQ0FnSUNFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdVMlYwU1c1MFpYSmxjM1JTWVhSbFRXOWtaV3hQZDI1bGNrTm9aV05yQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV05qY25WaGJFSnNiMk5yVG5WdFltVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmhZMk55ZFdGc1FteHZZMnRPZFcxaVpYSWdaWGhwYzNSekNpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJR0loUFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGTmxkRWx1ZEdWeVpYTjBVbUYwWlUxdlpHVnNSbkpsYzJoRGFHVmphd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUySUM4dklDSnBiblJsY21WemRGSmhkR1ZOYjJSbGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2FXNTBaWEpsYzNSU1lYUmxUVzlrWld3Z1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVGM1Tm1GbE5ERWdMeThnYldWMGFHOWtJQ0pwYzBsdWRHVnlaWE4wVW1GMFpVMXZaR1ZzS0NsaWIyOXNJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaGMzTmxjblFnTHk4Z2JXRnlhMlZ5SUcxbGRHaHZaQ0J5WlhSMWNtNWxaQ0JtWVd4elpRb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0ltbHVkR1Z5WlhOMFVtRjBaVTF2WkdWc0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHSTRZamd4WTJReklDOHZJRzFsZEdodlpDQWlUbVYzVFdGeWEyVjBTVzUwWlhKbGMzUlNZWFJsVFc5a1pXd29ZV1JrY21WemN5eGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJOdmJYQnZkVzVrTFhZeUwyTnZiblJ5WVdOMGN5OURSWEpqTWpCSmJXMTFkR0ZpYkdVdWMyOXNMa05GY21NeU1DNWhaR1JmS0RJcEtHRTZJR0o1ZEdWekxDQmlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbUZrWkY4b01pazZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1kyRnNiSE4xWWlCaFpHUmZLRElwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNQzV0ZFd4ZktESXBLR0U2SUdKNWRHVnpMQ0JpT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q20xMWJGOG9NaWs2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZMkZzYkhOMVlpQnRkV3hmS0RJcENpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBd2VEQmtaVEJpTm1JellUYzJOREF3TURBS0lDQWdJR0l2Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyTnZiWEJ2ZFc1a0xYWXlMMk52Ym5SeVlXTjBjeTlEUlhKak1qQkpiVzExZEdGaWJHVXVjMjlzTGtORmNtTXlNQzVrYVhaZktESXBLR0U2SUdKNWRHVnpMQ0JpT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21ScGRsOG9NaWs2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMkZzYkhOMVlpQnRkV3hmS0RJcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZMkZzYkhOMVlpQmthWFpmS0RJcENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlkyOXRjRzkxYm1RdGRqSXZZMjl1ZEhKaFkzUnpMME5GY21NeU1FbHRiWFYwWVdKc1pTNXpiMnd1UTBWeVl6SXdMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRkFDQUJCb0NBa0x1NjFxM3dEU1ltQUF0ZmJtOTBSVzUwWlhKbFpBUVZIM3gxSVFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQkpoWTJOeWRXRnNRbXh2WTJ0T2RXMWlaWElGWVdSdGFXNExZMjl0Y0hSeWIyeHNaWElOZEc5MFlXeFNaWE5sY25abGN5UVZIM3gxQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQU1kRzkwWVd4Q2IzSnliM2R6SUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDMkp2Y25KdmQwbHVaR1Y0QzNSdmRHRnNVM1Z3Y0d4NURXRmpZMjkxYm5SVWIydGxibk1JRGVDMnM2ZGtBQUFLZFc1a1pYSnNlV2x1WnhGcGJuUmxjbVZ6ZEZKaGRHVk5iMlJsYkF4d1pXNWthVzVuUVdSdGFXNFZjbVZ6WlhKMlpVWmhZM1J2Y2sxaGJuUnBjM05oQklPNjE4d0VLSkdJWVFSdVlXMWxCbk41YldKdmJBaGtaV05wYldGc2N4dHBibWwwYVdGc1JYaGphR0Z1WjJWU1lYUmxUV0Z1ZEdsemMyRkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0QvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy94SjBjbUZ1YzJabGNrRnNiRzkzWVc1alpYTU9ZV05qYjNWdWRFSnZjbkp2ZDNNRWRydFJzZ1JHUWx4OEJGQWtNKzhFZWZxMFpRU2ZxMks1QlBrUklxRUUwT2twTFFTaCtubUpJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBZ01SaEFBRVlwSW1jbkZTaG5KeFlvWnljWEltY25CU2NLWnljUkp3cG5Kd1luQ21jbkVDY0taeWNZS0djbkVpaG5Kd1FvWnljTEtHY25DU2huSndjb1p5Y01LR2NuRHljS1p5UkRNUmtVUkRFWVJJSVFCRnkrZXdFRWhNVzBoQVR6ckk4OEJKQU12ak1Fc1FOV1d3UjYwNGYvQkJLWEVmNEV0WmJMd3dSZ3l2aFBCSEM3d2xFRXBwN01mZ1JXMnFXOUJCbU1tQ0FFYmZRZmJRVDYrMm9JQkYyRlRRNG5FNElLQko4RFlua0VqKytyUkFSVG4rR2hCT3FUMlIwRW10U1paQVJuNSt6K0JLRElOUDhFWWZVRzFRU2xIb3BYQk9aMStYSW5IU2NlZ2c4RXNQTmVDd1J0ellsVUJKOVcxa0VFeHJUVWJnUllrNnVDQk9YQWgvZ0VZY1BCN3dRWmRRWVdCQUJiVXJnRXVIZWU1d1FLVDdhekJQcVl6UU1FSnBvUUN3UUZXZ25FQkRrenMrY25INElEQk1DblVhOEVoSFE0VHdSUWJEelNKeUEyR2dDT01RQUJBTWtCbWdIQUFlVUMwQUwxQXlFRTFRVTJCWlVGeHdackJwd0cwZ2NSQnpvSFdnZVJCOWdJUGdpN0NOMEpCUWtlQ1M4SlFBbFJDV0lKa1FtNUNmZ0tFUXB6Q3ZvTEZ3c2lDelVMU0F0VUMxOExhZ3QxQzRBTGt3dW1DN2tMekF2ZkFEWWFBVWtWSXhKRU5ob0NTUlVqRWtRMkdnTkpGU01TUkRZYUJFa1ZJeEpFTmhvRlNTSlpnUUlJU3dFVkVrUlhBZ0EyR2daSklsbUJBZ2hMQVJVU1JGY0NBRFlhQjBrVmdRZ1NSQmN4QUNJbkJXVkVFa1FpSndSbFJDaW9RUUJsSWljTFpVUW9xRUVBV3lSRUp4aExCRWxPQW1jb3BVUkxCWWdTUmlpb1JESUdGaWNFVEdjaEJCWW5DMHhuU3dTSUVuZ29xRVFuRlVzRFp5Y1dTd0puSnhkTEFXY3BKR2NuRDBzSFNVNENaN0dCR0ZzbHNoQWlzaGtpc2dHeUdDY2dzaHF6SkVNaVF2K2lOaG9CU1JVakVrUWlLV1ZFUkNraVo0Z05hRWd4QUxFeUNpT3ZTVXNFVUVrVkl3a2pXQ0luQm1WRWdSaGJKYklRSXJJWklySUJzaGlBQktzMlNlT3lHazhDc2hwTEFySWFzaHF6dEQ1WEJBQW9xUlJFSWljRVpVUXlCaGFwRkVTSURPWkpGU01PUkVzQnEwc0NUd1NJQ3R4SlR3S0lFbElpSnd4bFJFc0JvQ2NNVEdkTEF3RW5EVXhRU2I0b1RnSk5Td0tnU3dHOFNMOUxBUlVqRGtSTVN3S3JTd0VWSXc1RVRFOENxMHNDVHdKUVN3RlFnQVJIL1VGcVRGQ3dNZ3BQQWxCTVVDY1VURkN3S1NSbkp3aXdKRU0yR2dGSkZTTVNSQ0lwWlVSRUtTSm5pQXlYU0RFQUloWk1UZ0tJRGJrcEpHY25DTEFrUXpZYUFVa1ZJeEpFSWlsbFJFUXBJbWVJREhGSU1RQWlGazhDaUEyVUtTUm5Kd2l3SkVNMkdnRkpGVWtqRWtRaUtXVkVSQ2tpWjRnTVMwZ3hBTEV5Q2lPdlNVc0ZVRWtWSXdraldDSW5CbVZFZ1JoYkpiSVFJcklaSXJJQnNoaUFCSkdUSFJpeUdrOENzaHBMQXJJYXNocXp0RDVYQkFBb3FSUkVJaWNFWlVReUJoYXBGRVNJQ2FwTEJLUVVSRXNCaUF0MlN3U2dJaWNKWlVSTEJhQkxBd0VuSEV4UVNiNG5HVTRDVFZjZ0lFc0RGU01PUkU4RFN3U3JTVThDVUNJbkMyVkVTUlVqRGtSTEJhdE1Wd0FnVEZCUEFreS9Kd2xMQW1kTEEwc0dpQW9MVHdRakRrUlBCRXNEcTBzQ0ZTTU9SRThDVHdPclR3TlBBbEJQQWxCTVVJQUU1K2hDckV4UXNDa2taeWNJc0NSRE5ob0JTUlVqRWtRaUtXVkVSQ2tpWjRnTFlVZ3hBRWxQQW9nTndFZ3BKR2NuQ0xBa1F6WWFBVWtWSXhKRU5ob0NTUlVqRWtRaUtXVkVSQ2tpWjRnTE5FZ3hBRTRDaUEyVVNDa2taeWNJc0NSRE5ob0JSd0lWSXhKRU5ob0NTUlVqRWtRMkdnTkpUZ05KRlNNU1JDSXBaVVJFS1NKbmlBcjhTTEZKZ1JoYlNVNEVKYklRSXJJWklySUJTYklZSngyeUdyTzBQbGNFQUNpcEZFUXhBRWxPQmJFeUNpT3ZTVTRIU1VzR1VFa1ZJd2tqV0NJbkJtVkVnUmhiSmJJUUlySVpJcklCc2hpQUJLeC9UY2l5R2s4Q3NocExCTElhU3dLeUdrc0dzaHF5R3JPMFBsY0VBQ2lwRkVRaUp3UmxSRElHRnFrVVJMRWxzaEFpc2hraXNnRkxBcklZSngreUdyTzBQbGNFQURJR0Zxa1VSRXNGU3dJU0ZFUkxCQ2lvRkVSTEJDY2FxQlJFVEVzRlR3V0lESzVKVGdXeE1ncE9BbEJKRlNNSkkxZ2lKd1psUklFWVd5V3lFQ0t5R1NLeUFiSVlnQVQvRU1KQnNocE1zaHBMQXJJYXNocXp0RDVYQkNDMFBsY2tJRWxPQWs0RktLaEVzU1d5RUNLeUdTS3lBVXl5R0NjVHNocFBBcklhczdRK1Z3UUFwa1F5Q2hKQkFEc3lDa3NFU3doTEE0Z05Ia3NCU1JVakRrUkxBMGxPQXF0TEFrOENxMHNGU3dsUVR3SlFTd2RRVEZDQUJIS0ZZSk5NVUxBcEpHY25DTEFrUTdGTEFrc0JVRWtWSXdraldDV3lFQ0t5R1NLeUFVc0ZzaGduSHJJYVN3U3lHa3NIc2hxeUdyTzBQbGNFQUNpb1JFTC9uVFlhQVVrVkl4SkVNUUFpSndWbFJFeExBUkpFSWljUFpVUkxBaE5Fc1RJS1R3S0JHRnNsc2hBaXNoa2lzZ0ZKc2hnbkU3SWFUTElhczdRK1Z3UUFzU092VEZCSkZTTUpJMWdsc2hBaXNoa2lzZ0ZNc2hnbkliSWFUTElhc2hxekpFTTJHZ0ZKRlNNU1JDSXBaVVJFS1NKbmlBajdTQ0luQkdWRU1nWVdxUlJFTVFCTWlBYTdJaWNIWlVSTEFhQW5CMHNCWjBzQkZTTU9SQ092VHdKTEFhc3hBRXNERlNNT1JFOERUd09yVEU4Q1VFeFFKeUpNVUxBcEpHY25DTEFrUXpZYUFVa1ZJeEpFTVFBaUp3VmxSQkpFc1NJbkQyVkVnUmhiSmJJUUlySVpJcklCc2hpQUJMTzJYeWl5R3JJYXN5UkROaG9CU1JVakVrUTJHZ0pKRlNNU1JEWWFBMGtWSXhKRU5ob0VTU0paZ1FJSVN3RVZFa1JYQWdBMkdnVkpJbG1CQWdoTEFSVVNSRmNDQURZYUJra1ZnUWdTUkJjeEFDSW5CV1ZFRWtRaUp3UmxSQ2lvUVFCSklpY0xaVVFvcUVFQVB5UkVKeGhMQkVsT0FtY29wVVJMQllnTWlDaW9SRElHRmljRVRHY2hCQlluQzB4blN3U0lETG9vcUVRbkZVc0RaeWNXU3dKbkp4ZExBV2NwSkdja1F5SkMvNzQyR2dGSkZTTVNSRFlhQWtrVkl4SkVJaWxsUkVRcEpHY3hBRWxQQTA4RGlBWmpLS2lBQVFBaVR3SlVLa3hRc0NSRE5ob0JTUlVqRWtRMkdnSkpGU01TUkRZYUEwa1ZJeEpFSWlsbFJFUXBKR2N4QUU0RGlBWXRLS2lBQVFBaVR3SlVLa3hRc0NSRE5ob0JTUlVqRWtRMkdnSkpGVWtqRWtReEFFOERVRWtCSnh0TVVFbThTRXNEdjB3akRrUWpyMDhDcTFDQUJCamdsR0ZNVUxDQUJSVWZmSFdBc0NSRE5ob0JTUlVqRWtRMkdnSkpGU01TUkZBQkp4dE1VTDRvVGdKTlNSVWpEa1FqcjZzcVRGQ3dKRU0yR2dGSkZTTVNSQUVuRFV4UXZpaE9BazFKRlNNT1JDT3ZxeXBNVUxBa1F6WWFBVWtWSXhKRWlBYVpTUlVqRGtRanIweExBYXRQQWdFbkRVeFF2aWhPQWsySUMvZFhBQ0FuRHFKSkZTTU9SS3NxVEZDd0pFTTJHZ0ZKRlNNU1JFa0JKdzFNVUw0b1RnSk5USWdHSUlnR1ppT3ZTd01WSXc1RVR3TkxBYXNuQ2t4UVN3TVZJdzVFVHdOTEFxdFFTd0lWSXc1RVRnS3JVQ3BNVUxBa1E3RWpyNGdFRkVzQlRGQ0lCQTFMQWt4UUZTTUpJMWdpSndsbFJFc0NURkJKRlNNSkkxZ2lKd2RsUkVzRFRGQkpGU01KSTFnaUp4QmxSSUVZV3lXeUVDS3lHU0t5QWJJWUp5T3lHazhDc2hwTXNocXlHck8wUGxjRUFFa1ZJdzVFcXlwTVVMQWtRN0VqcjRnRHJrc0JURkNJQTZkTEFreFFGU01KSTFnaUp3bGxSRXNDVEZCSkZTTUpJMWdpSndkbFJFc0RURkJKRlNNSkkxZ2lKeEpsUkVzRVRGQkpGU01KSTFnaUp4QmxSSUVZV3lXeUVDS3lHU0t5QWJJWWdBVGJQWDlLc2hwUEE3SWFUd0t5R2t5eUdySWFzN1ErVndRQVNSVWpEa1NyS2t4UXNDUkRJaWxsUkVRcEltZUlCWDVJS1NSbklpY0paVVJKRlNNT1JDT3ZxeXBNVUxBa1F6WWFBVWtWSXhKRUlpbGxSRVFwSW1lSUJWUklLU1JuaUFUUlNSVWpEa1FqcjZzcVRGQ3dKRU0yR2dGSkZTTVNSSWdFdUVrVkl3NUVJNityS2t4UXNDUkRpQVRkU1JVakRrUWpyNnNxVEZDd0pFT0lCTjlKRlNNT1JDT3ZxeXBNVUxBa1E0Z0NyMGtWSXc1RUk2K3JLa3hRc0NSRGlBVHdTUlVqRGtRanI2c3FURkN3SkVNMkdnRkpGU01TUkRZYUFra1ZJeEpFTmhvRFNSVWpFa1FpS1dWRVJDa2laekVBVGdPSUNBY3BKR2NuQ0xBa1F6WWFBVWtWSXhKRU1RQWlKd1ZsUkJNVVJDSW5FV1ZFSnhGTEFtZE1VQ2NrVEZDd0p3aXdKRU14QUNJbkVXVkVURXNCRXhSRU1RQW5DaElVUkNJbkJXVkVKd1ZMQW1jbkVTY0taeUluQldWRVVJQUV3T1B6ejB4UXNDY0tVQ2NrVEZDd0p3aXdKRU0yR2dGSkZTTVNSSWdJdjBrVkl3NUVJNityS2t4UXNDUkROaG9CU1JWSkl4SkVJaWxsUkVRcEltZUlCQjlJS1NSbk1RQWlKd1ZsUkJNVVJDSW5CR1ZFTWdZV3FSUkVTd0VuRHFVVVJDSW5FbVZFSnhKTEEyZE1JdzVFSTY5UEFrc0JxMHNDRlNNT1JFNENxMHhRZ0FSUkQ2RHdURkN3Sndpd0pFTTJHZ0ZKRlVrakVrUWlLV1ZFUkNraVo0Z0R2VWdwSkdjeEFDSW5CV1ZFRXhSRUlpY0VaVVF5QmhhcEZFU0lBVTlMQXFRVVJDSW5CMlZFU3dKTEFhVVVSQ3VnU3dLaEs2b25CMHNCWnlJbkJXVkVTd09JQWVFaUp3VmxSRXNCRlNNT1JDT3ZUd0pMQWF0UEF5TU9SRThEVHdLclR3Sk1VRXhRZ0FUVzhzU2NURkN3Sndpd0pFTTJHZ0ZKRlNNU1JJZ0RQMGlJQ0FGSkZTTU9SQ092cXlwTVVMQWtReUluRDJWRUtreFFzQ1JESWljVlpVUkpGUlpYQmdKTVVDcE1VTEFrUXlJbkZtVkVTUlVXVndZQ1RGQXFURkN3SkVNaUp4ZGxSQllxVEZDd0pFTWlKd1ZsUkNwTVVMQWtReUluRVdWRUtreFFzQ1JESWljR1pVUXFURkN3SkVNaUp4QmxSQ3BNVUxBa1F5SW5FbVZFU1JVakRrUWpyNnNxVEZDd0pFTWlKd1JsUkVrVkl3NUVJNityS2t4UXNDUkRJaWNMWlVSSkZTTU9SQ092cXlwTVVMQWtReUluQ1dWRVNSVWpEa1FqcjZzcVRGQ3dKRU1pSndkbFJFa1ZJdzVFSTYrcktreFFzQ1JESWljTVpVUkpGU01PUkNPdnF5cE1VTEFrUXlJbkQyVkVzVElLVElFWVd5V3lFQ0t5R1NLeUFiSVlKeE95R3JJYXM3UStWd1FBaVlvQ0FTSkpKdzlsUkxFeUNreUJHRnRKVGdJbHNoQWlzaGtpc2dGSnNoZ25FN0lhVExJYXM3UStWd1FBVExFeUNpT3ZpLzlRU1JVakNTTllKYklRSXJJWklySUJUd0t5R0lBRXR6NmkzN0lhaS82eUdreXlHcklhc3ljS0p5VW9qZ0lBTEFBQkFJc0FLS2xFc1RJS0piSVFJcklaSXJJQml3R3lHQ2NUc2hxeUdyTzBQbGNFQUN1Z2l3S2hLNnFNQUlra1F2L1ZpZ0lBSWtrbkQyVkVzU092aS85UVNSVWpDU05ZVElFWVd5V3lFQ0t5R1NLeUFiSVlKeUd5R292K3NocXlHck1uQ2ljbEtJNENBQWNBQVFDTEFDaXBSSWtrUXYvNmlnUUJJckV5Q2lPdlNVNENpLzlRU1JVakNTTllJaWNHWlVTQkdGc2xzaEFpc2hraXNnR3lHSUFFbVBrVnY3SWFUTElhaS8yeUdvditzaHF5R3JPMFBsY0VBQ2lwRkVTTC9ZditFaFJFaS95TC9SSkJBSEFuR2trcm9Jdi9vU3VxakFDTC9RRW5EVXhRU2I0b1RnSk5LNkNMLzZFcnFvditBU2NOVEZCSnZpaE9BazJMLzZCTEE3eElUd05QQTc5TEFieEl2eWNhcVVFQUVJdjlpL3hRQVNjYlRGQkp2RWlMQUwrTC94VWpEa1NMLzRzQnE0djlpLzVRVEZBbkZFeFFzQ0lXakFDSmkvMkwvRkFCSnh0TVVMNG9UZ0pOUXYrQWlnRUJpLzhCSnh4TVVFbStKeGxPQWsxWEFDQW9xRUVBQkNJV1RJbUxBTDRuR1U0Q1RVbFhBQ0FpSnd0bFJLTk1WeUFnb2t5SklpbGxSRVFwSW1lSUFEdElLU1JuaUFBQmlZb0FBU0luREdWTVNVOENSQ2lvUVFBSElpY1laVVJNaVlqOXhpSW5DV1ZFb0N1Z0lpY0haVVNoSzZvbkRxT0xBS0pNaVlvQUFUSUdGa2tpSndSbFRFbE9BazREUktoQkFBVWlGb3dBaVlqOWtDSW5DV1ZFSWljSFpVUWlKd3RsUkxFanIwbExCVkJKRlNNSkkxaExBVXNGVUVrVkl3a2pXRXNDU3dWUVNSVWpDU05ZSWljUVpVU0JHRnNsc2hBaXNoa2lzZ0d5R0NjanNocFBBcklhVExJYXNocXp0RDVYQkFCSmdBWUVqQ2M1VUFDbVJJc0FTVTRESzZDTEFhRXJxa3NCRlNNT1JFeExBcXRNaUFTWFNVc0dpQVNSVndBZ0p3NmlTVThIb0NJbkVtVkVTUlVqRGtSTEJLdExBb2dFZFZjQUlDY09vazhIaUFSUlR3TkxCb2dFWTFjQUlDY09vazhHaUFRL0p3UlBCbWNuQzBzQlp5Y0pTd05uSndkUEFtZEpGU01PUkVzRHEwc0VGU01PUkU4RVN3U3JTd01WSXc1RVR3TkxCS3RMQXhVakRrUlBBMDhFcTA0Q1VFOENVRXhRZ0FUMmJhS0tURkN3SWhhTUFJbUtBd0FpU1l2K0tLaEFBQWVML3lpb1FRRWtKRVNJL29oSkZTTU9SQ092U1l3QXE0ditLS1ZCQVFDTC9vZ0QxbGNBSUNjT29vd0JpLzZ4TWdxTEFFbE9BazhEU1U0RFVFa1ZJd2tqV0NJbkJtVkVnUmhiSmJJUUlySVpJcklCc2hpQUJEbDBDNUN5R2t5eUdvdjlzaHBKc2hxenRENVhCQUFvcVJSRUlpY0VaVVF5QmhhcEZFU0krL2VMQVVsT0FxUVVSQ0luREdWRUs2QkxBNkVycWljTVRHZUwvUUVuRFV4UVNiNG9UZ0pOSzZCTEJLRXJxa3NCdkVpL2kvMUxBWWo4ZUVzQ0ZTTU9SRThDU3dPcmkvMHlDbEJMQVZBbkZFeFFzRXNCRlNNT1JFc0JTd1NyaS8xTVVFeFFnQVFXTFhuQ1RGQ3dzVElLVHdOUEFsQkpGU01KSTFnaUp3WmxSSUVZV3lXeUVDS3lHU0t5QWJJWWdBVHZ2U0hZc2hwTXNocUwvYklhc2hxeUdyT0ppLzlNaUFMeGkvK01BVUwvQWlKQy90bUtBd0d4TWdvanIwbUwvMUJKRlNNSkkxZ2lKd1psUklFWVd5V3lFQ0t5R1NLeUFiSVlnQVFZSEpyVHNocFBBcklhaS8yeUdvditzaHF5R3JPMFBsY0VBQ2lwRkVRaUp3UmxSRElHRnFrVVJJditpUHpIaS84bkdxaUwvMHNDVHdKTmkvMU1pUHNEVEN1Z1N3R2hLNm9pSndsbFJDdWdTd0toSzZxTC9nRW5IRXhRU2I0bkdVNENUVmNnSUVzREZTTU9SRThEU3dXclNVOENVQ0luQzJWRVNSVWpEa1JMQnF0TVZ3QWdURkJQQWt5L0p3bExBbWRMQWhVakRrUkxBa3NFcTBzQ0ZTTU9SRThDVHdTcmkvMkwvbEJQQWxCUEFsQk1VSUFFcldQazlFeFFzSW1LQkFDeE1nb2pyMG1MLzFCSkZTTUpJMWdpSndabFJJRVlXeVd5RUNLeUdTS3lBYklZZ0FRdjNjNmZzaHBQQXJJYWkveXlHb3Y5c2hxTC9ySWFzaHF6dEQ1WEJBQW9xUlJFaS82TC9SSVVSSXYvZ0NBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBWTNuYUJiWUFBSWdCYjR2L0s2QkxBYUVycW9qNy9ra1ZJdzVFU3dPclN3S0lBVlpYQUNBbkRxSWlKd2RsUkVzQm9DY0hTd0ZuSWljTVpVUXJvRXNFb1N1cUp3eE1aNHYrQVNjTlRGQkp2aWhPQWswcm9Jdi9vU3VxU3dHOFNMK0wvUUVuRFV4UVNiNG9UZ0pOU3dTZ1N3RzhTTDlMQWhVakRrUlBBa3NFcTR2K2kvMVFURkFuRkV4UXNFc0NGU01PUkU4Q1N3T3JpLzR5Q2xCTVVDY1VURkN3U3dFVkl3NUVURXNDcXpJS1N3SVZJdzVFVHdKUEE2dE1Ud0pRVEZBbklreFFzSW1LQVFFeEFDSW5CV1ZFRXhSRUlpY0daVVN4aS8rQkdGc2xzaEFpc2hraXNnR3lHSUFFaVFScXJMSWFzN1ErVndRQUlsTkVKd2FMLzJlTC8xQ0FCSFcyTGpoTVVMQWlGb21LQVFFeEFDSW5CV1ZFRXhSRUlpY0VaVVF5QmhhcEZFUWlKeEJsUkxHTC80RVlXeVd5RUNLeUdTS3lBYklZZ0FRWGxxNUJzaHF6dEQ1WEJBQWlVMFFuRUl2L1o0di9VSUFFdUxnYzAweFFzQ0lXaVlvQ0FZditWd0FnaS85WEFDQ0kvL0JKRlNNT1JDT3ZxNG1LQWdHTC9sY0FJSXYvVndBZ2lQL3dKdzZpU1JVakRrUWpyNnVKaWdJQmkvNVhBQ0FoQkJhSS85YUwvMWNBSUlqLzZra1ZJdzVFSTYrcmlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJOZXdDb21wdHJvbGxlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRDb21wdHJvbGxlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0NvbXB0cm9sbGVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJOZXdNYXJrZXRJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRJbnRlcmVzdFJhdGVNb2RlbCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0ludGVyZXN0UmF0ZU1vZGVsIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJBY2NydWVJbnRlcmVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FzaFByaW9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0QWNjdW11bGF0ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93SW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxCb3Jyb3dzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJNaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbnRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW50QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbnRUb2tlbnMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlZGVlbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRlZW1lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWRlZW1BbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVkZWVtVG9rZW5zIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJCb3Jyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRCb3Jyb3dzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQm9ycm93cyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVwYXlCb3Jyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBheUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50Qm9ycm93cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbEJvcnJvd3MiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlc2VydmVzQWRkZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmVuZWZhY3RvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRBbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VG90YWxSZXNlcnZlcyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTGlxdWlkYXRlQm9ycm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpcXVpZGF0b3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBheUFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNUb2tlbkNvbGxhdGVyYWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VpemVUb2tlbnMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik5ld1BlbmRpbmdBZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRQZW5kaW5nQWRtaW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdQZW5kaW5nQWRtaW4iLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik5ld0FkbWluIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9sZEFkbWluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QWRtaW4iLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik5ld1Jlc2VydmVGYWN0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9sZFJlc2VydmVGYWN0b3JNYW50aXNzYSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdSZXNlcnZlRmFjdG9yTWFudGlzc2EiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlc2VydmVzUmVkdWNlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWR1Y2VBbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VG90YWxSZXNlcnZlcyIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
