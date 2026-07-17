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

namespace Arc56.Generated.SamyaDeb.ChainStrike.PerpetualsMarket_5a0805b2
{


    //
    // 
    //    Perpetual futures market contract.
    //
    //    Enables leveraged trading on ALGO price with no expiry.
    //    Pool acts as counterparty to all positions.
    //
    //    Position Mechanics:
    //    - Long: Profit when price increases, loss when decreases
    //    - Short: Profit when price decreases, loss when increases
    //    - Leverage amplifies both profits and losses
    //
    //    Liquidation:
    //    - Triggered when margin ratio falls below maintenance margin
    //    - Liquidator receives reward (percentage of remaining margin)
    //    - Remaining margin goes to pool
    //
    //    Funding:
    //    - Paid every hour
    //    - Rate determined by OI imbalance
    //    - Incentivizes balanced market
    //    
    //
    public class PerpetualsMarketProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PerpetualsMarketProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MarketStats : AVMObjectType
            {
                public ulong TotalPositions { get; set; }

                public ulong ActivePositions { get; set; }

                public ulong TotalVolume { get; set; }

                public ulong TotalLongOi { get; set; }

                public ulong TotalShortOi { get; set; }

                public ulong TotalLiquidations { get; set; }

                public ulong TotalFeesCollected { get; set; }

                public ulong CurrentPrice { get; set; }

                public ulong FundingRate { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalPositions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalPositions.From(TotalPositions);
                    ret.AddRange(vTotalPositions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActivePositions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActivePositions.From(ActivePositions);
                    ret.AddRange(vActivePositions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalVolume.From(TotalVolume);
                    ret.AddRange(vTotalVolume.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalLongOi = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalLongOi.From(TotalLongOi);
                    ret.AddRange(vTotalLongOi.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalShortOi = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalShortOi.From(TotalShortOi);
                    ret.AddRange(vTotalShortOi.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalLiquidations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalLiquidations.From(TotalLiquidations);
                    ret.AddRange(vTotalLiquidations.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalFeesCollected = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalFeesCollected.From(TotalFeesCollected);
                    ret.AddRange(vTotalFeesCollected.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrentPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCurrentPrice.From(CurrentPrice);
                    ret.AddRange(vCurrentPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFundingRate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFundingRate.From(FundingRate);
                    ret.AddRange(vFundingRate.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MarketStats Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MarketStats();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalPositions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalPositions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalPositions = vTotalPositions.ToValue();
                    if (valueTotalPositions is ulong vTotalPositionsValue) { ret.TotalPositions = vTotalPositionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActivePositions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActivePositions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActivePositions = vActivePositions.ToValue();
                    if (valueActivePositions is ulong vActivePositionsValue) { ret.ActivePositions = vActivePositionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalVolume.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalVolume = vTotalVolume.ToValue();
                    if (valueTotalVolume is ulong vTotalVolumeValue) { ret.TotalVolume = vTotalVolumeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalLongOi = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalLongOi.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalLongOi = vTotalLongOi.ToValue();
                    if (valueTotalLongOi is ulong vTotalLongOiValue) { ret.TotalLongOi = vTotalLongOiValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalShortOi = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalShortOi.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalShortOi = vTotalShortOi.ToValue();
                    if (valueTotalShortOi is ulong vTotalShortOiValue) { ret.TotalShortOi = vTotalShortOiValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalLiquidations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalLiquidations.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalLiquidations = vTotalLiquidations.ToValue();
                    if (valueTotalLiquidations is ulong vTotalLiquidationsValue) { ret.TotalLiquidations = vTotalLiquidationsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalFeesCollected = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalFeesCollected.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalFeesCollected = vTotalFeesCollected.ToValue();
                    if (valueTotalFeesCollected is ulong vTotalFeesCollectedValue) { ret.TotalFeesCollected = vTotalFeesCollectedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrentPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCurrentPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCurrentPrice = vCurrentPrice.ToValue();
                    if (valueCurrentPrice is ulong vCurrentPriceValue) { ret.CurrentPrice = vCurrentPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFundingRate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFundingRate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFundingRate = vFundingRate.ToValue();
                    if (valueFundingRate is ulong vFundingRateValue) { ret.FundingRate = vFundingRateValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MarketStats);
                }
                public bool Equals(MarketStats? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MarketStats left, MarketStats right)
                {
                    return EqualityComparer<MarketStats>.Default.Equals(left, right);
                }
                public static bool operator !=(MarketStats left, MarketStats right)
                {
                    return !(left == right);
                }

            }

            public class Position : AVMObjectType
            {
                public ulong PositionId { get; set; }

                public Algorand.Address Trader { get; set; }

                public bool IsLong { get; set; }

                public ulong Size { get; set; }

                public ulong Collateral { get; set; }

                public ulong Leverage { get; set; }

                public ulong EntryPrice { get; set; }

                public ulong LiquidationPrice { get; set; }

                public ulong LastFundingTime { get; set; }

                public ulong AccumulatedFunding { get; set; }

                public ulong OpenTime { get; set; }

                public bool IsOpen { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPositionId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPositionId.From(PositionId);
                    ret.AddRange(vPositionId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTrader = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTrader.From(Trader);
                    ret.AddRange(vTrader.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsLong = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsLong.From(IsLong);
                    ret.AddRange(vIsLong.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSize.From(Size);
                    ret.AddRange(vSize.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateral = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCollateral.From(Collateral);
                    ret.AddRange(vCollateral.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLeverage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLeverage.From(Leverage);
                    ret.AddRange(vLeverage.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEntryPrice.From(EntryPrice);
                    ret.AddRange(vEntryPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidationPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLiquidationPrice.From(LiquidationPrice);
                    ret.AddRange(vLiquidationPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastFundingTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastFundingTime.From(LastFundingTime);
                    ret.AddRange(vLastFundingTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccumulatedFunding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAccumulatedFunding.From(AccumulatedFunding);
                    ret.AddRange(vAccumulatedFunding.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOpenTime.From(OpenTime);
                    ret.AddRange(vOpenTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOpen = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsOpen.From(IsOpen);
                    ret.AddRange(vIsOpen.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPositionId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPositionId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePositionId = vPositionId.ToValue();
                    if (valuePositionId is ulong vPositionIdValue) { ret.PositionId = vPositionIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTrader = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTrader.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTrader = vTrader.ToValue();
                    if (valueTrader is Algorand.Address vTraderValue) { ret.Trader = vTraderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsLong = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsLong.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsLong = vIsLong.ToValue();
                    if (valueIsLong is bool vIsLongValue) { ret.IsLong = vIsLongValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSize = vSize.ToValue();
                    if (valueSize is ulong vSizeValue) { ret.Size = vSizeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateral = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCollateral.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCollateral = vCollateral.ToValue();
                    if (valueCollateral is ulong vCollateralValue) { ret.Collateral = vCollateralValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLeverage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLeverage.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLeverage = vLeverage.ToValue();
                    if (valueLeverage is ulong vLeverageValue) { ret.Leverage = vLeverageValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEntryPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEntryPrice = vEntryPrice.ToValue();
                    if (valueEntryPrice is ulong vEntryPriceValue) { ret.EntryPrice = vEntryPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidationPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLiquidationPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLiquidationPrice = vLiquidationPrice.ToValue();
                    if (valueLiquidationPrice is ulong vLiquidationPriceValue) { ret.LiquidationPrice = vLiquidationPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastFundingTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastFundingTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastFundingTime = vLastFundingTime.ToValue();
                    if (valueLastFundingTime is ulong vLastFundingTimeValue) { ret.LastFundingTime = vLastFundingTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccumulatedFunding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAccumulatedFunding.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccumulatedFunding = vAccumulatedFunding.ToValue();
                    if (valueAccumulatedFunding is ulong vAccumulatedFundingValue) { ret.AccumulatedFunding = vAccumulatedFundingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOpenTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOpenTime = vOpenTime.ToValue();
                    if (valueOpenTime is ulong vOpenTimeValue) { ret.OpenTime = vOpenTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOpen = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsOpen.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsOpen = vIsOpen.ToValue();
                    if (valueIsOpen is bool vIsOpenValue) { ret.IsOpen = vIsOpenValue; }
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

            public class PositionPnL : AVMObjectType
            {
                public ulong UnrealizedPnl { get; set; }

                public bool IsProfit { get; set; }

                public ulong FundingPnl { get; set; }

                public bool FundingIsPositive { get; set; }

                public ulong LiquidationPrice { get; set; }

                public ulong MarginRatio { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnrealizedPnl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUnrealizedPnl.From(UnrealizedPnl);
                    ret.AddRange(vUnrealizedPnl.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsProfit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsProfit.From(IsProfit);
                    ret.AddRange(vIsProfit.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFundingPnl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFundingPnl.From(FundingPnl);
                    ret.AddRange(vFundingPnl.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFundingIsPositive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vFundingIsPositive.From(FundingIsPositive);
                    ret.AddRange(vFundingIsPositive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidationPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLiquidationPrice.From(LiquidationPrice);
                    ret.AddRange(vLiquidationPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarginRatio = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMarginRatio.From(MarginRatio);
                    ret.AddRange(vMarginRatio.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PositionPnL Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PositionPnL();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnrealizedPnl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUnrealizedPnl.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUnrealizedPnl = vUnrealizedPnl.ToValue();
                    if (valueUnrealizedPnl is ulong vUnrealizedPnlValue) { ret.UnrealizedPnl = vUnrealizedPnlValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsProfit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsProfit.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsProfit = vIsProfit.ToValue();
                    if (valueIsProfit is bool vIsProfitValue) { ret.IsProfit = vIsProfitValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFundingPnl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFundingPnl.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFundingPnl = vFundingPnl.ToValue();
                    if (valueFundingPnl is ulong vFundingPnlValue) { ret.FundingPnl = vFundingPnlValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFundingIsPositive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vFundingIsPositive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFundingIsPositive = vFundingIsPositive.ToValue();
                    if (valueFundingIsPositive is bool vFundingIsPositiveValue) { ret.FundingIsPositive = vFundingIsPositiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidationPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLiquidationPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLiquidationPrice = vLiquidationPrice.ToValue();
                    if (valueLiquidationPrice is ulong vLiquidationPriceValue) { ret.LiquidationPrice = vLiquidationPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarginRatio = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMarginRatio.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMarginRatio = vMarginRatio.ToValue();
                    if (valueMarginRatio is ulong vMarginRatioValue) { ret.MarginRatio = vMarginRatioValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PositionPnL);
                }
                public bool Equals(PositionPnL? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PositionPnL left, PositionPnL right)
                {
                    return EqualityComparer<PositionPnL>.Default.Equals(left, right);
                }
                public static bool operator !=(PositionPnL left, PositionPnL right)
                {
                    return !(left == right);
                }

            }

            public class GetOperationalStatsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetOperationalStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetOperationalStatsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetOperationalStatsReturn);
                }
                public bool Equals(GetOperationalStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetOperationalStatsReturn left, GetOperationalStatsReturn right)
                {
                    return EqualityComparer<GetOperationalStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetOperationalStatsReturn left, GetOperationalStatsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetCurrentFeeSplitReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetCurrentFeeSplitReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetCurrentFeeSplitReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetCurrentFeeSplitReturn);
                }
                public bool Equals(GetCurrentFeeSplitReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetCurrentFeeSplitReturn left, GetCurrentFeeSplitReturn right)
                {
                    return EqualityComparer<GetCurrentFeeSplitReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetCurrentFeeSplitReturn left, GetCurrentFeeSplitReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize market with contract references.
        ///</summary>
        /// <param name="oracle">Oracle contract address </param>
        /// <param name="perps_pool">Perpetuals pool contract address </param>
        /// <param name="staking_contract">Staking contract for fees </param>
        /// <param name="oracle_app">Oracle application ID for reading price </param>
        /// <param name="perps_pool_app">Perpetuals pool application ID for PnL calls </param>
        public async Task<bool> Initialize(Algorand.Address oracle, Algorand.Address perps_pool, Algorand.Address staking_contract, ulong oracle_app, ulong perps_pool_app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 126, 41, 112 };
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);
            var perps_poolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); perps_poolAbi.From(perps_pool);
            var staking_contractAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); staking_contractAbi.From(staking_contract);
            var oracle_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oracle_appAbi.From(oracle_app);
            var perps_pool_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); perps_pool_appAbi.From(perps_pool_app);

            var result = await base.CallApp(new List<object> { abiHandle, oracleAbi, perps_poolAbi, staking_contractAbi, oracle_appAbi, perps_pool_appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Initialize_Transactions(Algorand.Address oracle, Algorand.Address perps_pool, Algorand.Address staking_contract, ulong oracle_app, ulong perps_pool_app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 126, 41, 112 };
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);
            var perps_poolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); perps_poolAbi.From(perps_pool);
            var staking_contractAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); staking_contractAbi.From(staking_contract);
            var oracle_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oracle_appAbi.From(oracle_app);
            var perps_pool_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); perps_pool_appAbi.From(perps_pool_app);

            return await base.MakeTransactionList(new List<object> { abiHandle, oracleAbi, perps_poolAbi, staking_contractAbi, oracle_appAbi, perps_pool_appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Open a perpetual position.
        ///Margin must be sent as ALGO payment in group transaction.
        ///</summary>
        /// <param name="is_long">True for long, False for short </param>
        /// <param name="size">Position size in microALGO </param>
        /// <param name="leverage">Leverage multiplier (100-2000) </param>
        public async Task<ulong> OpenPosition(bool is_long, ulong size, ulong leverage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 41, 217, 122 };
            var is_longAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_longAbi.From(is_long);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);
            var leverageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); leverageAbi.From(leverage);

            var result = await base.CallApp(new List<object> { abiHandle, is_longAbi, sizeAbi, leverageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> OpenPosition_Transactions(bool is_long, ulong size, ulong leverage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 41, 217, 122 };
            var is_longAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_longAbi.From(is_long);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);
            var leverageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); leverageAbi.From(leverage);

            return await base.MakeTransactionList(new List<object> { abiHandle, is_longAbi, sizeAbi, leverageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Close an open position.
        ///</summary>
        /// <param name="position_id">Position to close </param>
        public async Task<ulong> ClosePosition(ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 110, 126, 143 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            var result = await base.CallApp(new List<object> { abiHandle, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ClosePosition_Transactions(ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 110, 126, 143 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add margin to an existing position.
        ///ALGO must be sent in group transaction.
        ///</summary>
        /// <param name="position_id">Position to add margin to </param>
        /// <param name="amount">Amount of margin to add </param>
        public async Task<bool> AddMargin(ulong position_id, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 64, 49, 118 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, position_idAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddMargin_Transactions(ulong position_id, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 64, 49, 118 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, position_idAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove margin from a position.
        ///</summary>
        /// <param name="position_id">Position to remove margin from </param>
        /// <param name="amount">Amount of margin to remove </param>
        public async Task<bool> RemoveMargin(ulong position_id, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 148, 205, 128 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, position_idAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RemoveMargin_Transactions(ulong position_id, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 148, 205, 128 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, position_idAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Liquidate an underwater position.
        ///Anyone can call this to liquidate positions below maintenance margin. Liquidator receives a reward.
        ///</summary>
        /// <param name="position_id">Position to liquidate </param>
        public async Task<bool> Liquidate(ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 42, 176, 230 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            var result = await base.CallApp(new List<object> { abiHandle, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Liquidate_Transactions(ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 42, 176, 230 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Apply accumulated funding to a position.
        ///Can be called by anyone (keeper bot).
        ///</summary>
        /// <param name="position_id">Position to apply funding to </param>
        public async Task<bool> ApplyFunding(ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 68, 117, 57 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            var result = await base.CallApp(new List<object> { abiHandle, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ApplyFunding_Transactions(ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 68, 117, 57 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate position PnL.
        ///</summary>
        /// <param name="is_long">Position direction </param>
        /// <param name="entry_price">Entry price in microUSD </param>
        /// <param name="current_price">Current price in microUSD </param>
        /// <param name="size">Position size in microALGO </param>
        public async Task<Structs.PositionPnL> CalculatePnl(bool is_long, ulong entry_price, ulong current_price, ulong size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 137, 231, 177 };
            var is_longAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_longAbi.From(is_long);
            var entry_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); entry_priceAbi.From(entry_price);
            var current_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); current_priceAbi.From(current_price);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);

            var result = await base.CallApp(new List<object> { abiHandle, is_longAbi, entry_priceAbi, current_priceAbi, sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PositionPnL.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CalculatePnl_Transactions(bool is_long, ulong entry_price, ulong current_price, ulong size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 137, 231, 177 };
            var is_longAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_longAbi.From(is_long);
            var entry_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); entry_priceAbi.From(entry_price);
            var current_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); current_priceAbi.From(current_price);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);

            return await base.MakeTransactionList(new List<object> { abiHandle, is_longAbi, entry_priceAbi, current_priceAbi, sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a position is liquidatable.
        ///</summary>
        /// <param name="is_long">Position direction </param>
        /// <param name="entry_price">Entry price </param>
        /// <param name="collateral">Current margin </param>
        /// <param name="size">Position size </param>
        /// <param name="current_price">Current price </param>
        public async Task<bool> IsLiquidatable(bool is_long, ulong entry_price, ulong collateral, ulong size, ulong current_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 82, 46, 119 };
            var is_longAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_longAbi.From(is_long);
            var entry_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); entry_priceAbi.From(entry_price);
            var collateralAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); collateralAbi.From(collateral);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);
            var current_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); current_priceAbi.From(current_price);

            var result = await base.CallApp(new List<object> { abiHandle, is_longAbi, entry_priceAbi, collateralAbi, sizeAbi, current_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsLiquidatable_Transactions(bool is_long, ulong entry_price, ulong collateral, ulong size, ulong current_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 82, 46, 119 };
            var is_longAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_longAbi.From(is_long);
            var entry_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); entry_priceAbi.From(entry_price);
            var collateralAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); collateralAbi.From(collateral);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);
            var current_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); current_priceAbi.From(current_price);

            return await base.MakeTransactionList(new List<object> { abiHandle, is_longAbi, entry_priceAbi, collateralAbi, sizeAbi, current_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get position details.
        ///</summary>
        /// <param name="position_id"> </param>
        public async Task<Structs.Position> GetPosition(ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 50, 81, 125 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            var result = await base.CallApp(new List<object> { abiHandle, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Position.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPosition_Transactions(ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 50, 81, 125 };
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get market statistics.
        ///</summary>
        public async Task<Structs.MarketStats> GetMarketStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 139, 13, 151 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MarketStats.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMarketStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 139, 13, 151 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current ALGO price from oracle.
        ///</summary>
        public async Task<ulong> GetCurrentPrice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 29, 80, 206 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCurrentPrice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 29, 80, 206 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate required margin for a position.
        ///</summary>
        /// <param name="size">Position size in microALGO </param>
        /// <param name="leverage">Leverage multiplier (100 = 1x) </param>
        public async Task<ulong> CalculateRequiredMargin(ulong size, ulong leverage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 123, 55, 245 };
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);
            var leverageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); leverageAbi.From(leverage);

            var result = await base.CallApp(new List<object> { abiHandle, sizeAbi, leverageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateRequiredMargin_Transactions(ulong size, ulong leverage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 123, 55, 245 };
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);
            var leverageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); leverageAbi.From(leverage);

            return await base.MakeTransactionList(new List<object> { abiHandle, sizeAbi, leverageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate liquidation price for a position.
        ///</summary>
        /// <param name="is_long">Position direction </param>
        /// <param name="entry_price">Entry price </param>
        /// <param name="collateral">Margin posted </param>
        /// <param name="size">Position size </param>
        public async Task<ulong> CalculateLiquidationPriceView(bool is_long, ulong entry_price, ulong collateral, ulong size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 52, 134, 198 };
            var is_longAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_longAbi.From(is_long);
            var entry_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); entry_priceAbi.From(entry_price);
            var collateralAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); collateralAbi.From(collateral);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);

            var result = await base.CallApp(new List<object> { abiHandle, is_longAbi, entry_priceAbi, collateralAbi, sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateLiquidationPriceView_Transactions(bool is_long, ulong entry_price, ulong collateral, ulong size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 52, 134, 198 };
            var is_longAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_longAbi.From(is_long);
            var entry_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); entry_priceAbi.From(entry_price);
            var collateralAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); collateralAbi.From(collateral);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);

            return await base.MakeTransactionList(new List<object> { abiHandle, is_longAbi, entry_priceAbi, collateralAbi, sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set leverage limits.
        ///</summary>
        /// <param name="min_lev"> </param>
        /// <param name="max_lev"> </param>
        public async Task<bool> SetLeverageLimits(ulong min_lev, ulong max_lev, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 202, 51, 120 };
            var min_levAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_levAbi.From(min_lev);
            var max_levAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_levAbi.From(max_lev);

            var result = await base.CallApp(new List<object> { abiHandle, min_levAbi, max_levAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetLeverageLimits_Transactions(ulong min_lev, ulong max_lev, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 202, 51, 120 };
            var min_levAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_levAbi.From(min_lev);
            var max_levAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_levAbi.From(max_lev);

            return await base.MakeTransactionList(new List<object> { abiHandle, min_levAbi, max_levAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set trading fees.
        ///</summary>
        /// <param name="open_fee"> </param>
        /// <param name="close_fee"> </param>
        /// <param name="liquidation_fee"> </param>
        public async Task<bool> SetFees(ulong open_fee, ulong close_fee, ulong liquidation_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 159, 248, 226 };
            var open_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); open_feeAbi.From(open_fee);
            var close_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); close_feeAbi.From(close_fee);
            var liquidation_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); liquidation_feeAbi.From(liquidation_fee);

            var result = await base.CallApp(new List<object> { abiHandle, open_feeAbi, close_feeAbi, liquidation_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetFees_Transactions(ulong open_fee, ulong close_fee, ulong liquidation_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 159, 248, 226 };
            var open_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); open_feeAbi.From(open_fee);
            var close_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); close_feeAbi.From(close_fee);
            var liquidation_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); liquidation_feeAbi.From(liquidation_fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, open_feeAbi, close_feeAbi, liquidation_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set margin requirements.
        ///</summary>
        /// <param name="initial"> </param>
        /// <param name="maintenance"> </param>
        public async Task<bool> SetMarginRequirements(ulong initial, ulong maintenance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 101, 127, 146 };
            var initialAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initialAbi.From(initial);
            var maintenanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maintenanceAbi.From(maintenance);

            var result = await base.CallApp(new List<object> { abiHandle, initialAbi, maintenanceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetMarginRequirements_Transactions(ulong initial, ulong maintenance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 101, 127, 146 };
            var initialAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initialAbi.From(initial);
            var maintenanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maintenanceAbi.From(maintenance);

            return await base.MakeTransactionList(new List<object> { abiHandle, initialAbi, maintenanceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update pool application ID (for contract upgrades).
        ///</summary>
        /// <param name="pool_app_id"> </param>
        public async Task<bool> UpdatePoolAppId(ulong pool_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 22, 53, 155 };
            var pool_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pool_app_idAbi.From(pool_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, pool_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UpdatePoolAppId_Transactions(ulong pool_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 22, 53, 155 };
            var pool_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pool_app_idAbi.From(pool_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, pool_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer admin role.
        ///</summary>
        /// <param name="new_admin"> </param>
        public async Task<bool> TransferAdmin(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 241, 170, 110 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            var result = await base.CallApp(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TransferAdmin_Transactions(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 241, 170, 110 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pause market operations.
        ///</summary>
        public async Task<bool> Pause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 251, 204, 215 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Pause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 251, 204, 215 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unpause market operations.
        ///</summary>
        public async Task<bool> Unpause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 140, 48, 89 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Unpause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 140, 48, 89 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get operational health metrics.
        ///</summary>
        public async Task<Structs.GetOperationalStatsReturn> GetOperationalStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 253, 179, 66 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetOperationalStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetOperationalStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 253, 179, 66 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current fee split percentages based on contract health.
        ///</summary>
        public async Task<Structs.GetCurrentFeeSplitReturn> GetCurrentFeeSplit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 11, 181, 96 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetCurrentFeeSplitReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetCurrentFeeSplit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 11, 181, 96 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set fee routing thresholds (admin only).
        ///</summary>
        /// <param name="min_operational">Minimum balance before critical mode (default 1 ALGO) </param>
        /// <param name="reserve_target">Target balance for healthy mode (default 10 ALGO) </param>
        public async Task<bool> SetFeeRoutingThresholds(ulong min_operational, ulong reserve_target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 46, 244, 63 };
            var min_operationalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_operationalAbi.From(min_operational);
            var reserve_targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reserve_targetAbi.From(reserve_target);

            var result = await base.CallApp(new List<object> { abiHandle, min_operationalAbi, reserve_targetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetFeeRoutingThresholds_Transactions(ulong min_operational, ulong reserve_target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 46, 244, 63 };
            var min_operationalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_operationalAbi.From(min_operational);
            var reserve_targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reserve_targetAbi.From(reserve_target);

            return await base.MakeTransactionList(new List<object> { abiHandle, min_operationalAbi, reserve_targetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGVycGV0dWFsc01hcmtldCIsImRlc2MiOiJcbiAgICBQZXJwZXR1YWwgZnV0dXJlcyBtYXJrZXQgY29udHJhY3QuXG5cbiAgICBFbmFibGVzIGxldmVyYWdlZCB0cmFkaW5nIG9uIEFMR08gcHJpY2Ugd2l0aCBubyBleHBpcnkuXG4gICAgUG9vbCBhY3RzIGFzIGNvdW50ZXJwYXJ0eSB0byBhbGwgcG9zaXRpb25zLlxuXG4gICAgUG9zaXRpb24gTWVjaGFuaWNzOlxuICAgIC0gTG9uZzogUHJvZml0IHdoZW4gcHJpY2UgaW5jcmVhc2VzLCBsb3NzIHdoZW4gZGVjcmVhc2VzXG4gICAgLSBTaG9ydDogUHJvZml0IHdoZW4gcHJpY2UgZGVjcmVhc2VzLCBsb3NzIHdoZW4gaW5jcmVhc2VzXG4gICAgLSBMZXZlcmFnZSBhbXBsaWZpZXMgYm90aCBwcm9maXRzIGFuZCBsb3NzZXNcblxuICAgIExpcXVpZGF0aW9uOlxuICAgIC0gVHJpZ2dlcmVkIHdoZW4gbWFyZ2luIHJhdGlvIGZhbGxzIGJlbG93IG1haW50ZW5hbmNlIG1hcmdpblxuICAgIC0gTGlxdWlkYXRvciByZWNlaXZlcyByZXdhcmQgKHBlcmNlbnRhZ2Ugb2YgcmVtYWluaW5nIG1hcmdpbilcbiAgICAtIFJlbWFpbmluZyBtYXJnaW4gZ29lcyB0byBwb29sXG5cbiAgICBGdW5kaW5nOlxuICAgIC0gUGFpZCBldmVyeSBob3VyXG4gICAgLSBSYXRlIGRldGVybWluZWQgYnkgT0kgaW1iYWxhbmNlXG4gICAgLSBJbmNlbnRpdml6ZXMgYmFsYW5jZWQgbWFya2V0XG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik1hcmtldFN0YXRzIjpbeyJuYW1lIjoidG90YWxfcG9zaXRpb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFjdGl2ZV9wb3NpdGlvbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfdm9sdW1lIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsX2xvbmdfb2kiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfc2hvcnRfb2kiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfbGlxdWlkYXRpb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsX2ZlZXNfY29sbGVjdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImN1cnJlbnRfcHJpY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZnVuZGluZ19yYXRlIiwidHlwZSI6InVpbnQ2NCJ9XSwiUG9zaXRpb24iOlt7Im5hbWUiOiJwb3NpdGlvbl9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0cmFkZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImlzX2xvbmciLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6InNpemUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29sbGF0ZXJhbCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsZXZlcmFnZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlbnRyeV9wcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsaXF1aWRhdGlvbl9wcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0X2Z1bmRpbmdfdGltZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY2N1bXVsYXRlZF9mdW5kaW5nIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im9wZW5fdGltZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpc19vcGVuIiwidHlwZSI6ImJvb2wifV0sIlBvc2l0aW9uUG5MIjpbeyJuYW1lIjoidW5yZWFsaXplZF9wbmwiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNfcHJvZml0IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmdW5kaW5nX3BubCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmdW5kaW5nX2lzX3Bvc2l0aXZlIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJsaXF1aWRhdGlvbl9wcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXJnaW5fcmF0aW8iLCJ0eXBlIjoidWludDY0In1dLCJHZXRPcGVyYXRpb25hbFN0YXRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dLCJHZXRDdXJyZW50RmVlU3BsaXRSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6IkluaXRpYWxpemUgbWFya2V0IHdpdGggY29udHJhY3QgcmVmZXJlbmNlcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yYWNsZSIsImRlc2MiOiJPcmFjbGUgY29udHJhY3QgYWRkcmVzcyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcnBzX3Bvb2wiLCJkZXNjIjoiUGVycGV0dWFscyBwb29sIGNvbnRyYWN0IGFkZHJlc3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFraW5nX2NvbnRyYWN0IiwiZGVzYyI6IlN0YWtpbmcgY29udHJhY3QgZm9yIGZlZXMiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yYWNsZV9hcHAiLCJkZXNjIjoiT3JhY2xlIGFwcGxpY2F0aW9uIElEIGZvciByZWFkaW5nIHByaWNlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJwc19wb29sX2FwcCIsImRlc2MiOiJQZXJwZXR1YWxzIHBvb2wgYXBwbGljYXRpb24gSUQgZm9yIFBuTCBjYWxscyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBzdGF0dXMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcGVuX3Bvc2l0aW9uIiwiZGVzYyI6Ik9wZW4gYSBwZXJwZXR1YWwgcG9zaXRpb24uXG5NYXJnaW4gbXVzdCBiZSBzZW50IGFzIEFMR08gcGF5bWVudCBpbiBncm91cCB0cmFuc2FjdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzX2xvbmciLCJkZXNjIjoiVHJ1ZSBmb3IgbG9uZywgRmFsc2UgZm9yIHNob3J0IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaXplIiwiZGVzYyI6IlBvc2l0aW9uIHNpemUgaW4gbWljcm9BTEdPIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsZXZlcmFnZSIsImRlc2MiOiJMZXZlcmFnZSBtdWx0aXBsaWVyICgxMDAtMjAwMCkiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiUG9zaXRpb24gSUQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbG9zZV9wb3NpdGlvbiIsImRlc2MiOiJDbG9zZSBhbiBvcGVuIHBvc2l0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb3NpdGlvbl9pZCIsImRlc2MiOiJQb3NpdGlvbiB0byBjbG9zZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJBbW91bnQgcmV0dXJuZWQgdG8gdHJhZGVyIChtYXJnaW4gKy8tIFBuTCAtIGZlZXMpIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX21hcmdpbiIsImRlc2MiOiJBZGQgbWFyZ2luIHRvIGFuIGV4aXN0aW5nIHBvc2l0aW9uLlxuQUxHTyBtdXN0IGJlIHNlbnQgaW4gZ3JvdXAgdHJhbnNhY3Rpb24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvc2l0aW9uX2lkIiwiZGVzYyI6IlBvc2l0aW9uIHRvIGFkZCBtYXJnaW4gdG8iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJBbW91bnQgb2YgbWFyZ2luIHRvIGFkZCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBzdGF0dXMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmVfbWFyZ2luIiwiZGVzYyI6IlJlbW92ZSBtYXJnaW4gZnJvbSBhIHBvc2l0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb3NpdGlvbl9pZCIsImRlc2MiOiJQb3NpdGlvbiB0byByZW1vdmUgbWFyZ2luIGZyb20iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJBbW91bnQgb2YgbWFyZ2luIHRvIHJlbW92ZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBzdGF0dXMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsaXF1aWRhdGUiLCJkZXNjIjoiTGlxdWlkYXRlIGFuIHVuZGVyd2F0ZXIgcG9zaXRpb24uXG5BbnlvbmUgY2FuIGNhbGwgdGhpcyB0byBsaXF1aWRhdGUgcG9zaXRpb25zIGJlbG93IG1haW50ZW5hbmNlIG1hcmdpbi4gTGlxdWlkYXRvciByZWNlaXZlcyBhIHJld2FyZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9zaXRpb25faWQiLCJkZXNjIjoiUG9zaXRpb24gdG8gbGlxdWlkYXRlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJTdWNjZXNzIHN0YXR1cyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcGx5X2Z1bmRpbmciLCJkZXNjIjoiQXBwbHkgYWNjdW11bGF0ZWQgZnVuZGluZyB0byBhIHBvc2l0aW9uLlxuQ2FuIGJlIGNhbGxlZCBieSBhbnlvbmUgKGtlZXBlciBib3QpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb3NpdGlvbl9pZCIsImRlc2MiOiJQb3NpdGlvbiB0byBhcHBseSBmdW5kaW5nIHRvIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJTdWNjZXNzIHN0YXR1cyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZV9wbmwiLCJkZXNjIjoiQ2FsY3VsYXRlIHBvc2l0aW9uIFBuTC4iLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzX2xvbmciLCJkZXNjIjoiUG9zaXRpb24gZGlyZWN0aW9uIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbnRyeV9wcmljZSIsImRlc2MiOiJFbnRyeSBwcmljZSBpbiBtaWNyb1VTRCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3VycmVudF9wcmljZSIsImRlc2MiOiJDdXJyZW50IHByaWNlIGluIG1pY3JvVVNEIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaXplIiwiZGVzYyI6IlBvc2l0aW9uIHNpemUgaW4gbWljcm9BTEdPIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYm9vbCx1aW50NjQsYm9vbCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlBvc2l0aW9uUG5MIiwiZGVzYyI6IlBuTCBkZXRhaWxzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfbGlxdWlkYXRhYmxlIiwiZGVzYyI6IkNoZWNrIGlmIGEgcG9zaXRpb24gaXMgbGlxdWlkYXRhYmxlLiIsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXNfbG9uZyIsImRlc2MiOiJQb3NpdGlvbiBkaXJlY3Rpb24iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVudHJ5X3ByaWNlIiwiZGVzYyI6IkVudHJ5IHByaWNlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb2xsYXRlcmFsIiwiZGVzYyI6IkN1cnJlbnQgbWFyZ2luIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaXplIiwiZGVzYyI6IlBvc2l0aW9uIHNpemUiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1cnJlbnRfcHJpY2UiLCJkZXNjIjoiQ3VycmVudCBwcmljZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVHJ1ZSBpZiBsaXF1aWRhdGFibGUifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcG9zaXRpb24iLCJkZXNjIjoiR2V0IHBvc2l0aW9uIGRldGFpbHMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvc2l0aW9uX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxib29sLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJQb3NpdGlvbiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tYXJrZXRfc3RhdHMiLCJkZXNjIjoiR2V0IG1hcmtldCBzdGF0aXN0aWNzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiTWFya2V0U3RhdHMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY3VycmVudF9wcmljZSIsImRlc2MiOiJHZXQgY3VycmVudCBBTEdPIHByaWNlIGZyb20gb3JhY2xlLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZV9yZXF1aXJlZF9tYXJnaW4iLCJkZXNjIjoiQ2FsY3VsYXRlIHJlcXVpcmVkIG1hcmdpbiBmb3IgYSBwb3NpdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2l6ZSIsImRlc2MiOiJQb3NpdGlvbiBzaXplIGluIG1pY3JvQUxHTyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGV2ZXJhZ2UiLCJkZXNjIjoiTGV2ZXJhZ2UgbXVsdGlwbGllciAoMTAwID0gMXgpIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlJlcXVpcmVkIG1hcmdpbiBpbiBtaWNyb0FMR08ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGVfbGlxdWlkYXRpb25fcHJpY2VfdmlldyIsImRlc2MiOiJDYWxjdWxhdGUgbGlxdWlkYXRpb24gcHJpY2UgZm9yIGEgcG9zaXRpb24uIiwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc19sb25nIiwiZGVzYyI6IlBvc2l0aW9uIGRpcmVjdGlvbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW50cnlfcHJpY2UiLCJkZXNjIjoiRW50cnkgcHJpY2UiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbGxhdGVyYWwiLCJkZXNjIjoiTWFyZ2luIHBvc3RlZCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2l6ZSIsImRlc2MiOiJQb3NpdGlvbiBzaXplIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IkxpcXVpZGF0aW9uIHByaWNlIGluIG1pY3JvVVNEIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2xldmVyYWdlX2xpbWl0cyIsImRlc2MiOiJTZXQgbGV2ZXJhZ2UgbGltaXRzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5fbGV2IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfbGV2IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9mZWVzIiwiZGVzYyI6IlNldCB0cmFkaW5nIGZlZXMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZW5fZmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjbG9zZV9mZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpcXVpZGF0aW9uX2ZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfbWFyZ2luX3JlcXVpcmVtZW50cyIsImRlc2MiOiJTZXQgbWFyZ2luIHJlcXVpcmVtZW50cy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFpbnRlbmFuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3Bvb2xfYXBwX2lkIiwiZGVzYyI6IlVwZGF0ZSBwb29sIGFwcGxpY2F0aW9uIElEIChmb3IgY29udHJhY3QgdXBncmFkZXMpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sX2FwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2Zlcl9hZG1pbiIsImRlc2MiOiJUcmFuc2ZlciBhZG1pbiByb2xlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2FkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhdXNlIiwiZGVzYyI6IlBhdXNlIG1hcmtldCBvcGVyYXRpb25zLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bnBhdXNlIiwiZGVzYyI6IlVucGF1c2UgbWFya2V0IG9wZXJhdGlvbnMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9vcGVyYXRpb25hbF9zdGF0cyIsImRlc2MiOiJHZXQgb3BlcmF0aW9uYWwgaGVhbHRoIG1ldHJpY3MuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRPcGVyYXRpb25hbFN0YXRzUmV0dXJuIiwiZGVzYyI6Iihjb250cmFjdF9iYWxhbmNlLCBvcGVyYXRpb25hbF9yZXNlcnZlLCByZXNlcnZlX3RhcmdldCkifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jdXJyZW50X2ZlZV9zcGxpdCIsImRlc2MiOiJHZXQgY3VycmVudCBmZWUgc3BsaXQgcGVyY2VudGFnZXMgYmFzZWQgb24gY29udHJhY3QgaGVhbHRoLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRDdXJyZW50RmVlU3BsaXRSZXR1cm4iLCJkZXNjIjoiKG9wZXJhdGlvbmFsX3BlcmNlbnRhZ2UsIHN0YWtpbmdfcGVyY2VudGFnZSkgaW4gYmFzaXMgcG9pbnRzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfZmVlX3JvdXRpbmdfdGhyZXNob2xkcyIsImRlc2MiOiJTZXQgZmVlIHJvdXRpbmcgdGhyZXNob2xkcyAoYWRtaW4gb25seSkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbl9vcGVyYXRpb25hbCIsImRlc2MiOiJNaW5pbXVtIGJhbGFuY2UgYmVmb3JlIGNyaXRpY2FsIG1vZGUgKGRlZmF1bHQgMSBBTEdPKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZV90YXJnZXQiLCJkZXNjIjoiVGFyZ2V0IGJhbGFuY2UgZm9yIGhlYWx0aHkgbW9kZSAoZGVmYXVsdCAxMCBBTEdPKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBzdGF0dXMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MjksImJ5dGVzIjo0fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMDc3XSwiZXJyb3JNZXNzYWdlIjoiSW5pdGlhbCA+IG1haW50ZW5hbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExOF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBtYXJnaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTYyXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IHBheW1lbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTMwLDE0NTAsMjA0N10sImVycm9yTWVzc2FnZSI6IkludmFsaWQgb3JhY2xlIHByaWNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2OV0sImVycm9yTWVzc2FnZSI6IkxldmVyYWdlIHRvbyBoaWdoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2MF0sImVycm9yTWVzc2FnZSI6IkxldmVyYWdlIHRvbyBsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTA0XSwiZXJyb3JNZXNzYWdlIjoiTWFyZ2luIHRvbyBsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQwLDE0MDQsMTk0NiwyMDE0LDIwNDBdLCJlcnJvck1lc3NhZ2UiOiJNYXJrZXQgcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAxOV0sImVycm9yTWVzc2FnZSI6Ik1heCAxJSBjbG9zZSBmZWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDExXSwiZXJyb3JNZXNzYWdlIjoiTWF4IDElIG9wZW4gZmVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk1OF0sImVycm9yTWVzc2FnZSI6Ik1heCAxMDB4IGxldmVyYWdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAyOF0sImVycm9yTWVzc2FnZSI6Ik1heCA1JSBsaXF1aWRhdGlvbiBmZWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzE2XSwiZXJyb3JNZXNzYWdlIjoiTWluIDAuMSBBTEdPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA4Ml0sImVycm9yTWVzc2FnZSI6Ik1pbiAxJSBtYWludGVuYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NTJdLCJlcnJvck1lc3NhZ2UiOiJNaW4gMXggbGV2ZXJhZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQ5XSwiZXJyb3JNZXNzYWdlIjoiTm90IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ0M10sImVycm9yTWVzc2FnZSI6Ik5vdCBwb3NpdGlvbiBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3OSwyOTQ1LDMwMDMsMzA3MCwzMTExLDMxMzcsMzE1MiwzMTY4LDMzMDddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU1N10sImVycm9yTWVzc2FnZSI6Ik9yYWNsZSBub3QgY29uZmlndXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NzZdLCJlcnJvck1lc3NhZ2UiOiJPcmFjbGUgcHJpY2UgaXMgemVybyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NzRdLCJlcnJvck1lc3NhZ2UiOiJPcmFjbGUgcHJpY2Ugbm90IGF2YWlsYWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MzEsMjA3NF0sImVycm9yTWVzc2FnZSI6IlBvc2l0aW9uIGFscmVhZHkgY2xvc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQxNCwyMDU3LDI3MTVdLCJlcnJvck1lc3NhZ2UiOiJQb3NpdGlvbiBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjA3XSwiZXJyb3JNZXNzYWdlIjoiUG9zaXRpb24gbm90IGxpcXVpZGF0YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODRdLCJlcnJvck1lc3NhZ2UiOiJQb3NpdGlvbiB0b28gc21hbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzIzXSwiZXJyb3JNZXNzYWdlIjoiVGFyZ2V0ID4gbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyNSwxOTY5XSwiZXJyb3JNZXNzYWdlIjoiV3JvbmcgcmVjZWl2ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjY1LDE3NDUsMjM4MiwyNzM3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hY3RpdmVfcG9zaXRpb25zIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3NywyOTQzLDMwMDEsMzA2OCwzMTA5LDMxMzUsMzE1MCwzMTY2LDMzMDVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJ1aWxkaW5nX29wZXJhdGlvbmFsX3NoYXJlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNsb3NlX2ZlZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTQyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5oZWFsdGh5X29wZXJhdGlvbmFsX3NoYXJlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzgsMTQwMiwxOTQ0LDIwMTIsMjAzOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaXNfcGF1c2VkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODksMjgzNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubGV2ZXJhZ2VfcHJlY2lzaW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxpcXVpZGF0b3JfcmV3YXJkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMDMsMjY1OSwzNTk3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYWludGVuYW5jZV9tYXJnaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWF4X2xldmVyYWdlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbl9sZXZlcmFnZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTAwLDI4NDYsMjg1OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWluX21hcmdpbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjEyLDM0OTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbl9vcGVyYXRpb25hbF9iYWxhbmNlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbl9wb3NpdGlvbl9zaXplIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm5leHRfcG9zaXRpb25faWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzNV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3Blbl9mZWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMxOSwxNzA4LDMxODVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm9wZXJhdGlvbmFsX3Jlc2VydmUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3JhY2xlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm9yYWNsZV9hcHBfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwMiwxOTc3LDIzNTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBlcnBzX3Bvb2wgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY2OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGVycHNfcG9vbF9hcHBfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE5MSwzMjQwLDM1MThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlc2VydmVfdGFyZ2V0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMzksMTcyOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3Rha2luZ19jb250cmFjdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzU2LDE3NTYsMjc2Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZmVlc19jb2xsZWN0ZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM3MSwyNzYwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9saXF1aWRhdGlvbnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI5MCwxNzcxLDE3ODEsMjM5NiwyNDA2LDI3NDhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2xvbmdfb2kgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1NCwyNzMxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9wb3NpdGlvbnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3NSwxODAxLDE4MTIsMjQyMSwyNDMyLDI3NTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3Nob3J0X29pIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNzYsMjc0M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfdm9sdW1lIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMTcsMjUzMSwyNTc0LDI4NzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTM3LDk0Niw5NTUsMzEyOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjMsOTcxLDEwMjUsMTAzMywxMzk3LDE5MzEsMTkzOSwyMDAwLDIwMDcsMjAzMywyNTE5LDI1MzksMjU0NywyNTU1LDI1ODIsMjU5MCwyNjAxLDI2MDksMjcwNiwyODIxLDI4MjksMjg4MiwyODkwLDI4OTgsMjkyOSwyOTM3LDI5NzksMjk4NywyOTk1LDMwNTQsMzA2MiwzMTAzLDMyOTEsMzI5OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTAsMTk1Ml0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F4TURBd01DQXhNREF3TURBd0lERXdNREF3TURBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVNE1DQWlZV1J0YVc0aUlEQjRNVFV4Wmpkak56VWdJblJ2ZEdGc1gyeHZibWRmYjJraUlDSjBiM1JoYkY5emFHOXlkRjl2YVNJZ01IZ3dNQ0FpWVdOMGFYWmxYM0J2YzJsMGFXOXVjeUlnSW1selgzQmhkWE5sWkNJZ0luUnZkR0ZzWDJabFpYTmZZMjlzYkdWamRHVmtJaUFpYjNCbGNtRjBhVzl1WVd4ZmNtVnpaWEoyWlNJZ0luQmxjbkJ6WDNCdmIyd2lJQ0p5WlhObGNuWmxYM1JoY21kbGRDSWdJbTFoYVc1MFpXNWhibU5sWDIxaGNtZHBiaUlnSW5OMFlXdHBibWRmWTI5dWRISmhZM1FpSUNKd1pYSndjMTl3YjI5c1gyRndjRjlwWkNJZ0luUnZkR0ZzWDNCdmMybDBhVzl1Y3lJZ0luUnZkR0ZzWDNadmJIVnRaU0lnSW5SdmRHRnNYMnhwY1hWcFpHRjBhVzl1Y3lJZ0ltMXBibDl0WVhKbmFXNGlJQ0p0YVc1ZmIzQmxjbUYwYVc5dVlXeGZZbUZzWVc1alpTSWdNSGczTURabU56TTFaaUFpYjNKaFkyeGxJaUFpYjNKaFkyeGxYMkZ3Y0Y5cFpDSWdJbTVsZUhSZmNHOXphWFJwYjI1ZmFXUWlJQ0p0YVc1ZmJHVjJaWEpoWjJVaUlDSnRZWGhmYkdWMlpYSmhaMlVpSUNKdmNHVnVYMlpsWlNJZ0ltTnNiM05sWDJabFpTSWdJbXhsZG1WeVlXZGxYM0J5WldOcGMybHZiaUlnSW0xcGJsOXdiM05wZEdsdmJsOXphWHBsSWlBaWJHbHhkV2xrWVhScGIyNWZabVZsSWlBaWJHbHhkV2xrWVhSdmNsOXlaWGRoY21RaUlDSmlkV2xzWkdsdVoxOXZjR1Z5WVhScGIyNWhiRjl6YUdGeVpTSWdJbWhsWVd4MGFIbGZiM0JsY21GMGFXOXVZV3hmYzJoaGNtVWlJQ0pwYm1sMGFXRnNYMjFoY21kcGJpSWdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3hNRE10TVRBMENpQWdJQ0F2THlBaklFTnZiblJ5WVdOMElISmxabVZ5Wlc1alpYTUtJQ0FnSUM4dklITmxiR1l1YjNKaFkyeGxJRDBnUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3dvZ0lDQWdZbmwwWldNZ01qRWdMeThnSW05eVlXTnNaU0lLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPakV3TlFvZ0lDQWdMeThnYzJWc1ppNXdaWEp3YzE5d2IyOXNJRDBnUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3dvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5CbGNuQnpYM0J2YjJ3aUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveE1EWUtJQ0FnSUM4dklITmxiR1l1YzNSaGEybHVaMTlqYjI1MGNtRmpkQ0E5SUVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKemRHRnJhVzVuWDJOdmJuUnlZV04wSWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TVRBM0NpQWdJQ0F2THlCelpXeG1MbTl5WVdOc1pWOWhjSEJmYVdRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJREl5SUM4dklDSnZjbUZqYkdWZllYQndYMmxrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveE1EZ0tJQ0FnSUM4dklITmxiR1l1Y0dWeWNITmZjRzl2YkY5aGNIQmZhV1FnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKd1pYSndjMTl3YjI5c1gyRndjRjlwWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1URXdMVEV4TVFvZ0lDQWdMeThnSXlCUWIzTnBkR2x2YmlCMGNtRmphMmx1WndvZ0lDQWdMeThnYzJWc1ppNXVaWGgwWDNCdmMybDBhVzl1WDJsa0lEMGdWVWx1ZERZMEtERXBDaUFnSUNCaWVYUmxZeUF5TXlBdkx5QWlibVY0ZEY5d2IzTnBkR2x2Ymw5cFpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNVEV5Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNCdmMybDBhVzl1Y3lBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0luUnZkR0ZzWDNCdmMybDBhVzl1Y3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1URXpDaUFnSUNBdkx5QnpaV3htTG1GamRHbDJaVjl3YjNOcGRHbHZibk1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1GamRHbDJaVjl3YjNOcGRHbHZibk1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pFeE5Bb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXNiMjVuWDI5cElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5c2IyNW5YMjlwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveE1UVUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjMmh2Y25SZmIya2dQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblJ2ZEdGc1gzTm9iM0owWDI5cElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3hNVGN0TVRFNENpQWdJQ0F2THlBaklGWnZiSFZ0WlNCaGJtUWdabVZsY3dvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5MmIyeDFiV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKMGIzUmhiRjkyYjJ4MWJXVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPakV4T1FvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5bVpXVnpYMk52Ykd4bFkzUmxaQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZEc5MFlXeGZabVZsYzE5amIyeHNaV04wWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qRXlNQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjlzYVhGMWFXUmhkR2x2Ym5NZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJREUzSUM4dklDSjBiM1JoYkY5c2FYRjFhV1JoZEdsdmJuTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPakV5TWkweE1qTUtJQ0FnSUM4dklDTWdRMjl1Wm1sbmRYSmhkR2x2YmdvZ0lDQWdMeThnYzJWc1ppNWhaRzFwYmlBOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNVEkwQ2lBZ0lDQXZMeUJ6Wld4bUxtMXBibDlzWlhabGNtRm5aU0E5SUZWSmJuUTJOQ2d4TURBcElDQWpJREY0SUNoelkyRnNaV1FnWW5rZ01UQXdLUW9nSUNBZ1lubDBaV01nTWpRZ0x5OGdJbTFwYmw5c1pYWmxjbUZuWlNJS0lDQWdJSEIxYzJocGJuUWdNVEF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1USTFDaUFnSUNBdkx5QnpaV3htTG0xaGVGOXNaWFpsY21GblpTQTlJRlZKYm5RMk5DZ3lNREF3S1NBZ0l5QXlNSGdLSUNBZ0lHSjVkR1ZqSURJMUlDOHZJQ0p0WVhoZmJHVjJaWEpoWjJVaUNpQWdJQ0J3ZFhOb2FXNTBJREl3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3hNallLSUNBZ0lDOHZJSE5sYkdZdWJXbHVYMjFoY21kcGJpQTlJRlZKYm5RMk5DZ3hYekF3TUY4d01EQXBJQ0FqSURFZ1FVeEhUeUJ0YVc1cGJYVnRJRzFoY21kcGJnb2dJQ0FnWW5sMFpXTWdNVGdnTHk4Z0ltMXBibDl0WVhKbmFXNGlDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qRXlOd29nSUNBZ0x5OGdjMlZzWmk1dGFXNWZjRzl6YVhScGIyNWZjMmw2WlNBOUlGVkpiblEyTkNneE1GOHdNREJmTURBd0tTQWdJeUF4TUNCQlRFZFBJRzFwYm1sdGRXMGdjMmw2WlFvZ0lDQWdZbmwwWldNZ01qa2dMeThnSW0xcGJsOXdiM05wZEdsdmJsOXphWHBsSWdvZ0lDQWdhVzUwWXlBMUlDOHZJREV3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TVRJNUxURXpNQW9nSUNBZ0x5OGdJeUJHWldVZ2MzUnlkV04wZFhKbElDaGlZWE5wY3lCd2IybHVkSE1wQ2lBZ0lDQXZMeUJ6Wld4bUxtOXdaVzVmWm1WbElEMGdWVWx1ZERZMEtERXdLU0FnSXlBd0xqRWxJRzl3Wlc1cGJtY2dabVZsQ2lBZ0lDQmllWFJsWXlBeU5pQXZMeUFpYjNCbGJsOW1aV1VpQ2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TVRNeENpQWdJQ0F2THlCelpXeG1MbU5zYjNObFgyWmxaU0E5SUZWSmJuUTJOQ2d4TUNrZ0lDTWdNQzR4SlNCamJHOXphVzVuSUdabFpRb2dJQ0FnWW5sMFpXTWdNamNnTHk4Z0ltTnNiM05sWDJabFpTSUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3hNeklLSUNBZ0lDOHZJSE5sYkdZdWJHbHhkV2xrWVhScGIyNWZabVZsSUQwZ1ZVbHVkRFkwS0RFd01Da2dJQ01nTVNVZ2JHbHhkV2xrWVhScGIyNGdjR1Z1WVd4MGVRb2dJQ0FnWW5sMFpXTWdNekFnTHk4Z0lteHBjWFZwWkdGMGFXOXVYMlpsWlNJS0lDQWdJSEIxYzJocGJuUWdNVEF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1UTXpDaUFnSUNBdkx5QnpaV3htTG14cGNYVnBaR0YwYjNKZmNtVjNZWEprSUQwZ1ZVbHVkRFkwS0RVd0tTQWdJeUF3TGpVbElIUnZJR3hwY1hWcFpHRjBiM0lLSUNBZ0lHSjVkR1ZqSURNeElDOHZJQ0pzYVhGMWFXUmhkRzl5WDNKbGQyRnlaQ0lLSUNBZ0lIQjFjMmhwYm5RZ05UQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG94TXpVdE1UTTJDaUFnSUNBdkx5QWpJRVI1Ym1GdGFXTWdabVZsSUhKdmRYUnBibWNnZEdoeVpYTm9iMnhrY3lBb1RXOWtaV3dnTVNrS0lDQWdJQzh2SUhObGJHWXViV2x1WDI5d1pYSmhkR2x2Ym1Gc1gySmhiR0Z1WTJVZ1BTQlZTVzUwTmpRb01WOHdNREJmTURBd0tTQWdJeUF4SUVGTVIwOGdMU0JqY21sMGFXTmhiQ0IwYUhKbGMyaHZiR1FLSUNBZ0lHSjVkR1ZqSURFNUlDOHZJQ0p0YVc1ZmIzQmxjbUYwYVc5dVlXeGZZbUZzWVc1alpTSUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1UTTNDaUFnSUNBdkx5QnpaV3htTG5KbGMyVnlkbVZmZEdGeVoyVjBJRDBnVlVsdWREWTBLREV3WHpBd01GOHdNREFwSUNBaklERXdJRUZNUjA4Z0xTQm9aV0ZzZEdoNUlIUm9jbVZ6YUc5c1pBb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0luSmxjMlZ5ZG1WZmRHRnlaMlYwSWdvZ0lDQWdhVzUwWXlBMUlDOHZJREV3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TVRNNUxURTBNd29nSUNBZ0x5OGdJeUJHWldVZ2MzQnNhWFFnY0dWeVkyVnVkR0ZuWlhNZ0tHSmhjMmx6SUhCdmFXNTBjeWtnWm05eUlHUnBabVpsY21WdWRDQnpkR0YwWlhNS0lDQWdJQzh2SUNNZ1ExSkpWRWxEUVV3Z0tEd3hJRUZNUjA4cE9pQXhNREFsSUc5d1pYSmhkR2x2Ym1Gc0xDQXdKU0J6ZEdGcmFXNW5DaUFnSUNBdkx5QWpJRUpWU1V4RVNVNUhJQ2d4TFRFd0lFRk1SMDhwT2lBMU1DVWdiM0JsY21GMGFXOXVZV3dzSURVd0pTQnpkR0ZyYVc1bkNpQWdJQ0F2THlBaklFaEZRVXhVU0ZrZ0tENHhNQ0JCVEVkUEtUb2dNVEFsSUc5d1pYSmhkR2x2Ym1Gc0xDQTVNQ1VnYzNSaGEybHVad29nSUNBZ0x5OGdjMlZzWmk1amNtbDBhV05oYkY5dmNHVnlZWFJwYjI1aGJGOXphR0Z5WlNBOUlGVkpiblEyTkNneE1EQXdNQ2tnSUNNZ01UQXdKUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmpjbWwwYVdOaGJGOXZjR1Z5WVhScGIyNWhiRjl6YUdGeVpTSUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pFME5Bb2dJQ0FnTHk4Z2MyVnNaaTVpZFdsc1pHbHVaMTl2Y0dWeVlYUnBiMjVoYkY5emFHRnlaU0E5SUZWSmJuUTJOQ2cxTURBd0tTQWdJeUExTUNVS0lDQWdJR0o1ZEdWaklETXlJQzh2SUNKaWRXbHNaR2x1WjE5dmNHVnlZWFJwYjI1aGJGOXphR0Z5WlNJS0lDQWdJSEIxYzJocGJuUWdOVEF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qRTBOUW9nSUNBZ0x5OGdjMlZzWmk1b1pXRnNkR2g1WDI5d1pYSmhkR2x2Ym1Gc1gzTm9ZWEpsSUQwZ1ZVbHVkRFkwS0RFd01EQXBJQ0FqSURFd0pRb2dJQ0FnWW5sMFpXTWdNek1nTHk4Z0ltaGxZV3gwYUhsZmIzQmxjbUYwYVc5dVlXeGZjMmhoY21VaUNpQWdJQ0J3ZFhOb2FXNTBJREV3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3hORGN0TVRRNENpQWdJQ0F2THlBaklFOXdaWEpoZEdsdmJtRnNJSEpsYzJWeWRtVWdkSEpoWTJ0cGJtY0tJQ0FnSUM4dklITmxiR1l1YjNCbGNtRjBhVzl1WVd4ZmNtVnpaWEoyWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWIzQmxjbUYwYVc5dVlXeGZjbVZ6WlhKMlpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNVFV3TFRFMU1Rb2dJQ0FnTHk4Z0l5Qk5ZWEpuYVc0Z2NtVnhkV2x5WlcxbGJuUnpJQ2hpWVhOcGN5QndiMmx1ZEhNcENpQWdJQ0F2THlCelpXeG1MbWx1YVhScFlXeGZiV0Z5WjJsdUlEMGdWVWx1ZERZMEtEVXdNQ2tnSUNNZ05TVWdhVzVwZEdsaGJDQnRZWEpuYVc0S0lDQWdJR0o1ZEdWaklETTBJQzh2SUNKcGJtbDBhV0ZzWDIxaGNtZHBiaUlLSUNBZ0lIQjFjMmhwYm5RZ05UQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TVRVeUNpQWdJQ0F2THlCelpXeG1MbTFoYVc1MFpXNWhibU5sWDIxaGNtZHBiaUE5SUZWSmJuUTJOQ2d5TlRBcElDQWpJREl1TlNVZ2JXRnBiblJsYm1GdVkyVWdiV0Z5WjJsdUNpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaWJXRnBiblJsYm1GdVkyVmZiV0Z5WjJsdUlnb2dJQ0FnY0hWemFHbHVkQ0F5TlRBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3hOVFF0TVRVMUNpQWdJQ0F2THlBaklGTjBZWFJsQ2lBZ0lDQXZMeUJ6Wld4bUxtbHpYM0JoZFhObFpDQTlJRVpoYkhObENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qRTFOeTB4TlRnS0lDQWdJQzh2SUNNZ1VISmxZMmx6YVc5dUNpQWdJQ0F2THlCelpXeG1MbkJ5YVdObFgzQnlaV05wYzJsdmJpQTlJRlZKYm5RMk5DZ3hYekF3TUY4d01EQXBJQ0FqSURZZ1pHVmphVzFoYkhNS0lDQWdJSEIxYzJoaWVYUmxjeUFpY0hKcFkyVmZjSEpsWTJsemFXOXVJZ29nSUNBZ2FXNTBZeUEwSUM4dklERXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3hOVGtLSUNBZ0lDOHZJSE5sYkdZdWJHVjJaWEpoWjJWZmNISmxZMmx6YVc5dUlEMGdWVWx1ZERZMEtERXdNQ2tnSUNNZ01UQXdJRDBnTVhnS0lDQWdJR0o1ZEdWaklESTRJQzh2SUNKc1pYWmxjbUZuWlY5d2NtVmphWE5wYjI0aUNpQWdJQ0J3ZFhOb2FXNTBJREV3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TnpnS0lDQWdJQzh2SUdOc1lYTnpJRkJsY25CbGRIVmhiSE5OWVhKclpYUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFETXpDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzBaamRsTWprM01DQXdlRGN3TWpsa09UZGhJREI0T1RVMlpUZGxPR1lnTUhnMlpEUXdNekUzTmlBd2VHSTRPVFJqWkRnd0lEQjROamt5WVdJd1pUWWdNSGd6TlRRME56VXpPU0F3ZUdWbU9EbGxOMkl4SURCNFlXSTFNakpsTnpjZ01IZ3pPRE15TlRFM1pDQXdlRGcxT0dJd1pEazNJREI0TWpFeFpEVXdZMlVnTUhoa01qZGlNemRtTlNBd2VEa3pNelE0Tm1NMklEQjRaRFZqWVRNek56Z2dNSGc0TWpsbVpqaGxNaUF3ZURjM05qVTNaamt5SURCNE1EY3hOak0xT1dJZ01IZzROR1l4WVdFMlpTQXdlR0kzWm1KalkyUTNJREI0T0RrNFl6TXdOVGtnTUhnd01XWmtZak0wTWlBd2VHSTBNR0ppTlRZd0lEQjRaakl5WldZME0yWWdMeThnYldWMGFHOWtJQ0pwYm1sMGFXRnNhWHBsS0dGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpYjNCbGJsOXdiM05wZEdsdmJpaGliMjlzTEhWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSmpiRzl6WlY5d2IzTnBkR2x2YmloMWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0poWkdSZmJXRnlaMmx1S0hWcGJuUTJOQ3gxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaWNtVnRiM1psWDIxaGNtZHBiaWgxYVc1ME5qUXNkV2x1ZERZMEtXSnZiMndpTENCdFpYUm9iMlFnSW14cGNYVnBaR0YwWlNoMWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWlZWEJ3YkhsZlpuVnVaR2x1WnloMWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWlZMkZzWTNWc1lYUmxYM0J1YkNoaWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NoMWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc1ltOXZiQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlhWE5mYkdseGRXbGtZWFJoWW14bEtHSnZiMndzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZEY5d2IzTnBkR2x2YmloMWFXNTBOalFwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMR0p2YjJ3c2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzS1NJc0lHMWxkR2h2WkNBaVoyVjBYMjFoY210bGRGOXpkR0YwY3lncEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwWDJOMWNuSmxiblJmY0hKcFkyVW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZMkZzWTNWc1lYUmxYM0psY1hWcGNtVmtYMjFoY21kcGJpaDFhVzUwTmpRc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWTJGc1kzVnNZWFJsWDJ4cGNYVnBaR0YwYVc5dVgzQnlhV05sWDNacFpYY29ZbTl2YkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luTmxkRjlzWlhabGNtRm5aVjlzYVcxcGRITW9kV2x1ZERZMExIVnBiblEyTkNsaWIyOXNJaXdnYldWMGFHOWtJQ0p6WlhSZlptVmxjeWgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsaWIyOXNJaXdnYldWMGFHOWtJQ0p6WlhSZmJXRnlaMmx1WDNKbGNYVnBjbVZ0Wlc1MGN5aDFhVzUwTmpRc2RXbHVkRFkwS1dKdmIyd2lMQ0J0WlhSb2IyUWdJblZ3WkdGMFpWOXdiMjlzWDJGd2NGOXBaQ2gxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaWRISmhibk5tWlhKZllXUnRhVzRvWVdSa2NtVnpjeWxpYjI5c0lpd2diV1YwYUc5a0lDSndZWFZ6WlNncFltOXZiQ0lzSUcxbGRHaHZaQ0FpZFc1d1lYVnpaU2dwWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwWDI5d1pYSmhkR2x2Ym1Gc1gzTjBZWFJ6S0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZlkzVnljbVZ1ZEY5bVpXVmZjM0JzYVhRb0tTaDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWMyVjBYMlpsWlY5eWIzVjBhVzVuWDNSb2NtVnphRzlzWkhNb2RXbHVkRFkwTEhWcGJuUTJOQ2xpYjI5c0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dhVzVwZEdsaGJHbDZaU0J2Y0dWdVgzQnZjMmwwYVc5dUlHTnNiM05sWDNCdmMybDBhVzl1SUdGa1pGOXRZWEpuYVc0Z2NtVnRiM1psWDIxaGNtZHBiaUJzYVhGMWFXUmhkR1VnWVhCd2JIbGZablZ1WkdsdVp5QmpZV3hqZFd4aGRHVmZjRzVzSUdselgyeHBjWFZwWkdGMFlXSnNaU0JuWlhSZmNHOXphWFJwYjI0Z1oyVjBYMjFoY210bGRGOXpkR0YwY3lCblpYUmZZM1Z5Y21WdWRGOXdjbWxqWlNCallXeGpkV3hoZEdWZmNtVnhkV2x5WldSZmJXRnlaMmx1SUdOaGJHTjFiR0YwWlY5c2FYRjFhV1JoZEdsdmJsOXdjbWxqWlY5MmFXVjNJSE5sZEY5c1pYWmxjbUZuWlY5c2FXMXBkSE1nYzJWMFgyWmxaWE1nYzJWMFgyMWhjbWRwYmw5eVpYRjFhWEpsYldWdWRITWdkWEJrWVhSbFgzQnZiMnhmWVhCd1gybGtJSFJ5WVc1elptVnlYMkZrYldsdUlIQmhkWE5sSUhWdWNHRjFjMlVnWjJWMFgyOXdaWEpoZEdsdmJtRnNYM04wWVhSeklHZGxkRjlqZFhKeVpXNTBYMlpsWlY5emNHeHBkQ0J6WlhSZlptVmxYM0p2ZFhScGJtZGZkR2h5WlhOb2IyeGtjd29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURNek9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1UVpYSndaWFIxWVd4elRXRnlhMlYwTG1sdWFYUnBZV3hwZW1WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBibWwwYVdGc2FYcGxPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TVRZMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qRTROZ29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYml3Z0lrOXViSGtnWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lXUnRhVzRLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pFNE9Bb2dJQ0FnTHk4Z2MyVnNaaTV2Y21GamJHVWdQU0J2Y21GamJHVXVibUYwYVhabENpQWdJQ0JpZVhSbFl5QXlNU0F2THlBaWIzSmhZMnhsSWdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TVRnNUNpQWdJQ0F2THlCelpXeG1MbkJsY25CelgzQnZiMndnUFNCd1pYSndjMTl3YjI5c0xtNWhkR2wyWlFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5CbGNuQnpYM0J2YjJ3aUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveE9UQUtJQ0FnSUM4dklITmxiR1l1YzNSaGEybHVaMTlqYjI1MGNtRmpkQ0E5SUhOMFlXdHBibWRmWTI5dWRISmhZM1F1Ym1GMGFYWmxDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWljM1JoYTJsdVoxOWpiMjUwY21GamRDSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qRTVNUW9nSUNBZ0x5OGdjMlZzWmk1dmNtRmpiR1ZmWVhCd1gybGtJRDBnYjNKaFkyeGxYMkZ3Y0M1dVlYUnBkbVVLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJQ0p2Y21GamJHVmZZWEJ3WDJsa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPakU1TWdvZ0lDQWdMeThnYzJWc1ppNXdaWEp3YzE5d2IyOXNYMkZ3Y0Y5cFpDQTlJSEJsY25CelgzQnZiMnhmWVhCd0xtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldNZ01UUWdMeThnSW5CbGNuQnpYM0J2YjJ4ZllYQndYMmxrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qRTJOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelU0TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVVR1Z5Y0dWMGRXRnNjMDFoY210bGRDNXZjR1Z1WDNCdmMybDBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2IzQmxibDl3YjNOcGRHbHZiam9LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pFNU5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNakUxQ2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUhObGJHWXVhWE5mY0dGMWMyVmtMQ0FpVFdGeWEyVjBJSEJoZFhObFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE5mY0dGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTFoY210bGRDQndZWFZ6WldRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qSXhOZ29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YjNKaFkyeGxJQ0U5SUVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0lDSk9iM1FnYVc1cGRHbGhiR2w2WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01qRWdMeThnSW05eVlXTnNaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmNtRmpiR1VnWlhocGMzUnpDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdsdWFYUnBZV3hwZW1Wa0NpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3lNVGd0TWpFNUNpQWdJQ0F2THlBaklGWmhiR2xrWVhSbElHeGxkbVZ5WVdkbENpQWdJQ0F2THlCaGMzTmxjblFnYkdWMlpYSmhaMlV1Ym1GMGFYWmxJRDQ5SUhObGJHWXViV2x1WDJ4bGRtVnlZV2RsTENBaVRHVjJaWEpoWjJVZ2RHOXZJR3h2ZHlJS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURJMElDOHZJQ0p0YVc1ZmJHVjJaWEpoWjJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV2x1WDJ4bGRtVnlZV2RsSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1RHVjJaWEpoWjJVZ2RHOXZJR3h2ZHdvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1qSXdDaUFnSUNBdkx5QmhjM05sY25RZ2JHVjJaWEpoWjJVdWJtRjBhWFpsSUR3OUlITmxiR1l1YldGNFgyeGxkbVZ5WVdkbExDQWlUR1YyWlhKaFoyVWdkRzl2SUdocFoyZ2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNalVnTHk4Z0ltMWhlRjlzWlhabGNtRm5aU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dFlYaGZiR1YyWlhKaFoyVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJNWlhabGNtRm5aU0IwYjI4Z2FHbG5hQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TWpJeUxUSXlNd29nSUNBZ0x5OGdJeUJXWVd4cFpHRjBaU0J6YVhwbENpQWdJQ0F2THlCaGMzTmxjblFnYzJsNlpTNXVZWFJwZG1VZ1BqMGdjMlZzWmk1dGFXNWZjRzl6YVhScGIyNWZjMmw2WlN3Z0lsQnZjMmwwYVc5dUlIUnZieUJ6YldGc2JDSUtJQ0FnSUdScFp5QXlDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF5T1NBdkx5QWliV2x1WDNCdmMybDBhVzl1WDNOcGVtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldsdVgzQnZjMmwwYVc5dVgzTnBlbVVnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCUWIzTnBkR2x2YmlCMGIyOGdjMjFoYkd3S0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qSXlOUzB5TWpjS0lDQWdJQzh2SUNNZ1EyRnNZM1ZzWVhSbElISmxjWFZwY21Wa0lHMWhjbWRwYmdvZ0lDQWdMeThnSXlCdFlYSm5hVzRnUFNCemFYcGxJQzhnYkdWMlpYSmhaMlVLSUNBZ0lDOHZJSEpsY1hWcGNtVmtYMjFoY21kcGJpQTlJQ2h6YVhwbExtNWhkR2wyWlNBcUlITmxiR1l1YkdWMlpYSmhaMlZmY0hKbFkybHphVzl1S1NBdkx5QnNaWFpsY21GblpTNXVZWFJwZG1VS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU9DQXZMeUFpYkdWMlpYSmhaMlZmY0hKbFkybHphVzl1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteGxkbVZ5WVdkbFgzQnlaV05wYzJsdmJpQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0FxQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUM4S0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qSXlPQW9nSUNBZ0x5OGdZWE56WlhKMElISmxjWFZwY21Wa1gyMWhjbWRwYmlBK1BTQnpaV3htTG0xcGJsOXRZWEpuYVc0c0lDSk5ZWEpuYVc0Z2RHOXZJR3h2ZHlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE9DQXZMeUFpYldsdVgyMWhjbWRwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRhVzVmYldGeVoybHVJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVFdGeVoybHVJSFJ2YnlCc2IzY0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPakl6TUMweU16RUtJQ0FnSUM4dklDTWdWbVZ5YVdaNUlHMWhjbWRwYmlCd1lYbHRaVzUwQ2lBZ0lDQXZMeUJ3WVhsdFpXNTBYMkZ0YjNWdWRDQTlJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUtEQXBMbUZ0YjNWdWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveU16SUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwWDJGdGIzVnVkQ0ErUFNCeVpYRjFhWEpsWkY5dFlYSm5hVzRzSUNKSmJuTjFabVpwWTJsbGJuUWdiV0Z5WjJsdUlnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBJRzFoY21kcGJnb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNak16Q2lBZ0lDQXZMeUJoYzNObGNuUWdaM1I0Ymk1UVlYbHRaVzUwVkhKaGJuTmhZM1JwYjI0b01Da3VjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWxkeWIyNW5JSEpsWTJWcGRtVnlJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCWGNtOXVaeUJ5WldObGFYWmxjZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TWpNMUxUSXpOZ29nSUNBZ0x5OGdJeUJIWlhRZ1kzVnljbVZ1ZENCd2NtbGpaUW9nSUNBZ0x5OGdZM1Z5Y21WdWRGOXdjbWxqWlNBOUlITmxiR1l1WDJkbGRGOXZjbUZqYkdWZmNISnBZMlVvS1FvZ0lDQWdZMkZzYkhOMVlpQmZaMlYwWDI5eVlXTnNaVjl3Y21salpRb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNak0zQ2lBZ0lDQXZMeUJoYzNObGNuUWdZM1Z5Y21WdWRGOXdjbWxqWlNBK0lEQXNJQ0pKYm5aaGJHbGtJRzl5WVdOc1pTQndjbWxqWlNJS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdiM0poWTJ4bElIQnlhV05sQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveU16a3RNalF3Q2lBZ0lDQXZMeUFqSUVOaGJHTjFiR0YwWlNCdmNHVnVhVzVuSUdabFpRb2dJQ0FnTHk4Z2RHOTBZV3hmWm1WbElEMGdLSE5wZW1VdWJtRjBhWFpsSUNvZ2MyVnNaaTV2Y0dWdVgyWmxaU2tnTHk4Z01UQXdNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF5TmlBdkx5QWliM0JsYmw5bVpXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNCbGJsOW1aV1VnWlhocGMzUnpDaUFnSUNCa2FXY2dNd29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01EQXdDaUFnSUNBdkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEZ0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPakkwTVFvZ0lDQWdMeThnYm1WMFgyMWhjbWRwYmlBOUlIQmhlVzFsYm5SZllXMXZkVzUwSUMwZ2RHOTBZV3hmWm1WbENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZkbVZ5SURnS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qSTBNeTB5TkRRS0lDQWdJQzh2SUNNZ1JIbHVZVzFwWXlCbVpXVWdjbTkxZEdsdVp5QmlZWE5sWkNCdmJpQmpiMjUwY21GamRDQmlZV3hoYm1ObENpQWdJQ0F2THlCdmNHVnlZWFJwYjI1aGJGOW1aV1VzSUhOMFlXdHBibWRmWm1WbElEMGdjMlZzWmk1ZmNtOTFkR1ZmWm1WbEtIUnZkR0ZzWDJabFpTa0tJQ0FnSUdOaGJHeHpkV0lnWDNKdmRYUmxYMlpsWlFvZ0lDQWdZMjkyWlhJZ09Bb2dJQ0FnWTI5MlpYSWdOd29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TWpRNENpQWdJQ0F2THlCcGMxOXNiMjVuTG01aGRHbDJaU3dLSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveU5EWXRNalV5Q2lBZ0lDQXZMeUFqSUVOaGJHTjFiR0YwWlNCc2FYRjFhV1JoZEdsdmJpQndjbWxqWlFvZ0lDQWdMeThnYkdseGRXbGtZWFJwYjI1ZmNISnBZMlVnUFNCelpXeG1MbDlqWVd4amRXeGhkR1ZmYkdseGRXbGtZWFJwYjI1ZmNISnBZMlVvQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZiRzl1Wnk1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1kzVnljbVZ1ZEY5d2NtbGpaU3dLSUNBZ0lDOHZJQ0FnSUNCdVpYUmZiV0Z5WjJsdUxBb2dJQ0FnTHk4Z0lDQWdJSE5wZW1VdWJtRjBhWFpsTEFvZ0lDQWdMeThnS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURNS0lDQWdJR1JwWnlBMkNpQWdJQ0JqWVd4c2MzVmlJRjlqWVd4amRXeGhkR1ZmYkdseGRXbGtZWFJwYjI1ZmNISnBZMlVLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pJMU5DMHlOVFVLSUNBZ0lDOHZJQ01nUTNKbFlYUmxJSEJ2YzJsMGFXOXVDaUFnSUNBdkx5QndiM05wZEdsdmJsOXBaQ0E5SUhObGJHWXVibVY0ZEY5d2IzTnBkR2x2Ymw5cFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklESXpJQzh2SUNKdVpYaDBYM0J2YzJsMGFXOXVYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtNWxlSFJmY0c5emFYUnBiMjVmYVdRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveU5UWUtJQ0FnSUM4dklITmxiR1l1Ym1WNGRGOXdiM05wZEdsdmJsOXBaQ0FyUFNBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUF5TXlBdkx5QWlibVY0ZEY5d2IzTnBkR2x2Ymw5cFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG95TlRndE1qVTVDaUFnSUNBdkx5QWpJRk4wYjNKbElIQnZjMmwwYVc5dUlHbHVJRUp2ZUUxaGNBb2dJQ0FnTHk4Z2NHOXphWFJwYjI1ZmEyVjVJRDBnWVhKak5DNVZTVzUwTmpRb2NHOXphWFJwYjI1ZmFXUXBDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJREV3Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveU5qSUtJQ0FnSUM4dklIUnlZV1JsY2oxQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1qWTFDaUFnSUNBdkx5QmpiMnhzWVhSbGNtRnNQV0Z5WXpRdVZVbHVkRFkwS0c1bGRGOXRZWEpuYVc0cExBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveU5qY0tJQ0FnSUM4dklHVnVkSEo1WDNCeWFXTmxQV0Z5WXpRdVZVbHVkRFkwS0dOMWNuSmxiblJmY0hKcFkyVXBMQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3lOamdLSUNBZ0lDOHZJR3hwY1hWcFpHRjBhVzl1WDNCeWFXTmxQV0Z5WXpRdVZVbHVkRFkwS0d4cGNYVnBaR0YwYVc5dVgzQnlhV05sS1N3S0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TWpZNUNpQWdJQ0F2THlCc1lYTjBYMloxYm1ScGJtZGZkR2x0WlQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3lOekVLSUNBZ0lDOHZJRzl3Wlc1ZmRHbHRaVDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveU5qQXRNamN6Q2lBZ0lDQXZMeUJ6Wld4bUxuQnZjMmwwYVc5dWMxdHdiM05wZEdsdmJsOXJaWGxkSUQwZ1VHOXphWFJwYjI0b0NpQWdJQ0F2THlBZ0lDQWdjRzl6YVhScGIyNWZhV1E5WVhKak5DNVZTVzUwTmpRb2NHOXphWFJwYjI1ZmFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUhSeVlXUmxjajFCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNBZ0lHbHpYMnh2Ym1jOWFYTmZiRzl1Wnl3S0lDQWdJQzh2SUNBZ0lDQnphWHBsUFhOcGVtVXNDaUFnSUNBdkx5QWdJQ0FnWTI5c2JHRjBaWEpoYkQxaGNtTTBMbFZKYm5RMk5DaHVaWFJmYldGeVoybHVLU3dLSUNBZ0lDOHZJQ0FnSUNCc1pYWmxjbUZuWlQxc1pYWmxjbUZuWlN3S0lDQWdJQzh2SUNBZ0lDQmxiblJ5ZVY5d2NtbGpaVDFoY21NMExsVkpiblEyTkNoamRYSnlaVzUwWDNCeWFXTmxLU3dLSUNBZ0lDOHZJQ0FnSUNCc2FYRjFhV1JoZEdsdmJsOXdjbWxqWlQxaGNtTTBMbFZKYm5RMk5DaHNhWEYxYVdSaGRHbHZibDl3Y21salpTa3NDaUFnSUNBdkx5QWdJQ0FnYkdGemRGOW1kVzVrYVc1blgzUnBiV1U5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnSUNBZ0lHRmpZM1Z0ZFd4aGRHVmtYMloxYm1ScGJtYzlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdiM0JsYmw5MGFXMWxQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCcGMxOXZjR1Z1UFVKdmIyd29WSEoxWlNrc0NpQWdJQ0F2THlBcENpQWdJQ0JrYVdjZ05nb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pJM01Bb2dJQ0FnTHk4Z1lXTmpkVzExYkdGMFpXUmZablZ1WkdsdVp6MWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJR0o1ZEdWaklETTFJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1qWXdMVEkzTXdvZ0lDQWdMeThnYzJWc1ppNXdiM05wZEdsdmJuTmJjRzl6YVhScGIyNWZhMlY1WFNBOUlGQnZjMmwwYVc5dUtBb2dJQ0FnTHk4Z0lDQWdJSEJ2YzJsMGFXOXVYMmxrUFdGeVl6UXVWVWx1ZERZMEtIQnZjMmwwYVc5dVgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCMGNtRmtaWEk5UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQnBjMTlzYjI1blBXbHpYMnh2Ym1jc0NpQWdJQ0F2THlBZ0lDQWdjMmw2WlQxemFYcGxMQW9nSUNBZ0x5OGdJQ0FnSUdOdmJHeGhkR1Z5WVd3OVlYSmpOQzVWU1c1ME5qUW9ibVYwWDIxaGNtZHBiaWtzQ2lBZ0lDQXZMeUFnSUNBZ2JHVjJaWEpoWjJVOWJHVjJaWEpoWjJVc0NpQWdJQ0F2THlBZ0lDQWdaVzUwY25sZmNISnBZMlU5WVhKak5DNVZTVzUwTmpRb1kzVnljbVZ1ZEY5d2NtbGpaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2JHbHhkV2xrWVhScGIyNWZjSEpwWTJVOVlYSmpOQzVWU1c1ME5qUW9iR2x4ZFdsa1lYUnBiMjVmY0hKcFkyVXBMQW9nSUNBZ0x5OGdJQ0FnSUd4aGMzUmZablZ1WkdsdVoxOTBhVzFsUFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3S1N3S0lDQWdJQzh2SUNBZ0lDQmhZMk4xYlhWc1lYUmxaRjltZFc1a2FXNW5QV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJRzl3Wlc1ZmRHbHRaVDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZiM0JsYmoxQ2IyOXNLRlJ5ZFdVcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pJM01nb2dJQ0FnTHk4Z2FYTmZiM0JsYmoxQ2IyOXNLRlJ5ZFdVcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EQUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPakkyTUMweU56TUtJQ0FnSUM4dklITmxiR1l1Y0c5emFYUnBiMjV6VzNCdmMybDBhVzl1WDJ0bGVWMGdQU0JRYjNOcGRHbHZiaWdLSUNBZ0lDOHZJQ0FnSUNCd2IzTnBkR2x2Ymw5cFpEMWhjbU0wTGxWSmJuUTJOQ2h3YjNOcGRHbHZibDlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdkSEpoWkdWeVBVRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnYVhOZmJHOXVaejFwYzE5c2IyNW5MQW9nSUNBZ0x5OGdJQ0FnSUhOcGVtVTljMmw2WlN3S0lDQWdJQzh2SUNBZ0lDQmpiMnhzWVhSbGNtRnNQV0Z5WXpRdVZVbHVkRFkwS0c1bGRGOXRZWEpuYVc0cExBb2dJQ0FnTHk4Z0lDQWdJR3hsZG1WeVlXZGxQV3hsZG1WeVlXZGxMQW9nSUNBZ0x5OGdJQ0FnSUdWdWRISjVYM0J5YVdObFBXRnlZelF1VlVsdWREWTBLR04xY25KbGJuUmZjSEpwWTJVcExBb2dJQ0FnTHk4Z0lDQWdJR3hwY1hWcFpHRjBhVzl1WDNCeWFXTmxQV0Z5WXpRdVZVbHVkRFkwS0d4cGNYVnBaR0YwYVc5dVgzQnlhV05sS1N3S0lDQWdJQzh2SUNBZ0lDQnNZWE4wWDJaMWJtUnBibWRmZEdsdFpUMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QWdJQ0FnWVdOamRXMTFiR0YwWldSZlpuVnVaR2x1WnoxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCdmNHVnVYM1JwYldVOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0lDQWdJR2x6WDI5d1pXNDlRbTl2YkNoVWNuVmxLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1qWXdDaUFnSUNBdkx5QnpaV3htTG5CdmMybDBhVzl1YzF0d2IzTnBkR2x2Ymw5clpYbGRJRDBnVUc5emFYUnBiMjRvQ2lBZ0lDQmllWFJsWXlBeU1DQXZMeUF3ZURjd05tWTNNelZtQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TWpZd0xUSTNNd29nSUNBZ0x5OGdjMlZzWmk1d2IzTnBkR2x2Ym5OYmNHOXphWFJwYjI1ZmEyVjVYU0E5SUZCdmMybDBhVzl1S0FvZ0lDQWdMeThnSUNBZ0lIQnZjMmwwYVc5dVgybGtQV0Z5WXpRdVZVbHVkRFkwS0hCdmMybDBhVzl1WDJsa0tTd0tJQ0FnSUM4dklDQWdJQ0IwY21Ga1pYSTlRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCcGMxOXNiMjVuUFdselgyeHZibWNzQ2lBZ0lDQXZMeUFnSUNBZ2MybDZaVDF6YVhwbExBb2dJQ0FnTHk4Z0lDQWdJR052Ykd4aGRHVnlZV3c5WVhKak5DNVZTVzUwTmpRb2JtVjBYMjFoY21kcGJpa3NDaUFnSUNBdkx5QWdJQ0FnYkdWMlpYSmhaMlU5YkdWMlpYSmhaMlVzQ2lBZ0lDQXZMeUFnSUNBZ1pXNTBjbmxmY0hKcFkyVTlZWEpqTkM1VlNXNTBOalFvWTNWeWNtVnVkRjl3Y21salpTa3NDaUFnSUNBdkx5QWdJQ0FnYkdseGRXbGtZWFJwYjI1ZmNISnBZMlU5WVhKak5DNVZTVzUwTmpRb2JHbHhkV2xrWVhScGIyNWZjSEpwWTJVcExBb2dJQ0FnTHk4Z0lDQWdJR3hoYzNSZlpuVnVaR2x1WjE5MGFXMWxQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCaFkyTjFiWFZzWVhSbFpGOW1kVzVrYVc1blBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHOXdaVzVmZEdsdFpUMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QWdJQ0FnYVhOZmIzQmxiajFDYjI5c0tGUnlkV1VwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNamMxTFRJM05nb2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ2JXRnlhMlYwSUhOMFlYUmxDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM0J2YzJsMGFXOXVjeUFyUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UVWdMeThnSW5SdmRHRnNYM0J2YzJsMGFXOXVjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl3YjNOcGRHbHZibk1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldNZ01UVWdMeThnSW5SdmRHRnNYM0J2YzJsMGFXOXVjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveU56Y0tJQ0FnSUM4dklITmxiR1l1WVdOMGFYWmxYM0J2YzJsMGFXOXVjeUFyUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWVdOMGFYWmxYM0J2YzJsMGFXOXVjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFkzUnBkbVZmY0c5emFYUnBiMjV6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1GamRHbDJaVjl3YjNOcGRHbHZibk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1qYzRDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM1p2YkhWdFpTQXJQU0J6YVhwbExtNWhkR2wyWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0owYjNSaGJGOTJiMngxYldVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmRtOXNkVzFsSUdWNGFYTjBjd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBeE5pQXZMeUFpZEc5MFlXeGZkbTlzZFcxbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPakk0TUFvZ0lDQWdMeThnYVdZZ2FYTmZiRzl1Wnk1dVlYUnBkbVU2Q2lBZ0lDQmllaUJ2Y0dWdVgzQnZjMmwwYVc5dVgyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG95T0RFS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmJHOXVaMTl2YVNBclBTQnphWHBsTG01aGRHbDJaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDJ4dmJtZGZiMmtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYkc5dVoxOXZhU0JsZUdsemRITUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMnh2Ym1kZmIya2lDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYjNCbGJsOXdiM05wZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3lPRFV0TWprd0NpQWdJQ0F2THlBaklGUnlZVzV6Wm1WeUlHMWhjbWRwYmlCMGJ5QndiMjlzQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1d1pYSndjMTl3YjI5c0xBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXVaWFJmYldGeVoybHVMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMUhiRzlpWVd3dWJXbHVYM1I0Ymw5bVpXVXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3lPRGtLSUNBZ0lDOHZJR1psWlQxSGJHOWlZV3d1YldsdVgzUjRibDltWldVc0NpQWdJQ0JuYkc5aVlXd2dUV2x1VkhodVJtVmxDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG95T0RjS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFhObGJHWXVjR1Z5Y0hOZmNHOXZiQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWljR1Z5Y0hOZmNHOXZiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d1pYSndjMTl3YjI5c0lHVjRhWE4wY3dvZ0lDQWdaR2xuSURVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3lPRFV0TWpnMkNpQWdJQ0F2THlBaklGUnlZVzV6Wm1WeUlHMWhjbWRwYmlCMGJ5QndiMjlzQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1qZzFMVEk1TUFvZ0lDQWdMeThnSXlCVWNtRnVjMlpsY2lCdFlYSm5hVzRnZEc4Z2NHOXZiQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYTmxiR1l1Y0dWeWNITmZjRzl2YkN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWJtVjBYMjFoY21kcGJpd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVIyeHZZbUZzTG0xcGJsOTBlRzVmWm1WbExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qSTVNaTB5T1RNS0lDQWdJQzh2SUNNZ1MyVmxjQ0J2Y0dWeVlYUnBiMjVoYkNCbVpXVWdhVzRnWTI5dWRISmhZM1FnS0c1dklHRmpkR2x2YmlCdVpXVmtaV1FnTFNCemRHRjVjeUJwYmlCaVlXeGhibU5sS1FvZ0lDQWdMeThnYzJWc1ppNXZjR1Z5WVhScGIyNWhiRjl5WlhObGNuWmxJQ3M5SUc5d1pYSmhkR2x2Ym1Gc1gyWmxaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltOXdaWEpoZEdsdmJtRnNYM0psYzJWeWRtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNCbGNtRjBhVzl1WVd4ZmNtVnpaWEoyWlNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnZjR1Z5WVhScGIyNWhiRjl5WlhObGNuWmxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pJNU5TMHlPVFlLSUNBZ0lDOHZJQ01nVkhKaGJuTm1aWElnYjI1c2VTQnpkR0ZyYVc1bklIQnZjblJwYjI0Z2RHOGdjM1JoYTJsdVp5QmpiMjUwY21GamRBb2dJQ0FnTHk4Z2FXWWdjM1JoYTJsdVoxOW1aV1VnUGlBd09nb2dJQ0FnWkdsbklESUtJQ0FnSUdKNklHOXdaVzVmY0c5emFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG95T1RjdE16QXhDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTV6ZEdGcmFXNW5YMk52Ym5SeVlXTjBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF6ZEdGcmFXNW5YMlpsWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5UjJ4dlltRnNMbTFwYmw5MGVHNWZabVZsTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TXpBd0NpQWdJQ0F2THlCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ1oyeHZZbUZzSUUxcGJsUjRia1psWlFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk1qazRDaUFnSUNBdkx5QnlaV05sYVhabGNqMXpaV3htTG5OMFlXdHBibWRmWTI5dWRISmhZM1FzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbk4wWVd0cGJtZGZZMjl1ZEhKaFkzUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzNSaGEybHVaMTlqYjI1MGNtRmpkQ0JsZUdsemRITUtJQ0FnSUdScFp5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TWprM0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNamszTFRNd01Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXVjM1JoYTJsdVoxOWpiMjUwY21GamRDd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljM1JoYTJsdVoxOW1aV1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3B2Y0dWdVgzQnZjMmwwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qTXdNd29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjltWldWelgyTnZiR3hsWTNSbFpDQXJQU0IwYjNSaGJGOW1aV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSjBiM1JoYkY5bVpXVnpYMk52Ykd4bFkzUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjltWldWelgyTnZiR3hsWTNSbFpDQmxlR2x6ZEhNS0lDQWdJR1JwWnlBMUNpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0owYjNSaGJGOW1aV1Z6WDJOdmJHeGxZM1JsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3hPVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtOXdaVzVmY0c5emFYUnBiMjVmWld4elpWOWliMlI1UURNNkNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3lPRE1LSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYzJodmNuUmZiMmtnS3owZ2MybDZaUzV1WVhScGRtVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGIzUmhiRjl6YUc5eWRGOXZhU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl6YUc5eWRGOXZhU0JsZUdsemRITUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SdmRHRnNYM05vYjNKMFgyOXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSWdiM0JsYmw5d2IzTnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRFFLQ2dvdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNVFaWEp3WlhSMVlXeHpUV0Z5YTJWMExtTnNiM05sWDNCdmMybDBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyeHZjMlZmY0c5emFYUnBiMjQ2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNHNGdPQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TXpBM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pNeE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQnpaV3htTG1selgzQmhkWE5sWkN3Z0lrMWhjbXRsZENCd1lYVnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlhWE5mY0dGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgzQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCTllYSnJaWFFnY0dGMWMyVmtDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG96TWpJS0lDQWdJQzh2SUdGemMyVnlkQ0J3YjNOcGRHbHZibDlyWlhrZ2FXNGdjMlZzWmk1d2IzTnBkR2x2Ym5Nc0lDSlFiM05wZEdsdmJpQnViM1FnWm05MWJtUWlDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QXdlRGN3Tm1ZM016Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1VHOXphWFJwYjI0Z2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3pNak1LSUNBZ0lDOHZJSEJ2Y3lBOUlITmxiR1l1Y0c5emFYUnBiMjV6VzNCdmMybDBhVzl1WDJ0bGVWMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TXpJMUNpQWdJQ0F2THlCaGMzTmxjblFnY0c5ekxtbHpYMjl3Wlc0dWJtRjBhWFpsTENBaVVHOXphWFJwYjI0Z1lXeHlaV0ZrZVNCamJHOXpaV1FpQ2lBZ0lDQndkWE5vYVc1MElEZzBNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lYTnpaWEowSUM4dklGQnZjMmwwYVc5dUlHRnNjbVZoWkhrZ1kyeHZjMlZrQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvek1qWUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSEJ2Y3k1MGNtRmtaWEl1Ym1GMGFYWmxMQ0FpVG05MElIQnZjMmwwYVc5dUlHOTNibVZ5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ09DQXpNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0J3YjNOcGRHbHZiaUJ2ZDI1bGNnb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNekk0TFRNeU9Rb2dJQ0FnTHk4Z0l5QkhaWFFnWTNWeWNtVnVkQ0J3Y21salpRb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5d2NtbGpaU0E5SUhObGJHWXVYMmRsZEY5dmNtRmpiR1ZmY0hKcFkyVW9LUW9nSUNBZ1kyRnNiSE4xWWlCZloyVjBYMjl5WVdOc1pWOXdjbWxqWlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3pNekFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpkWEp5Wlc1MFgzQnlhV05sSUQ0Z01Dd2dJa2x1ZG1Gc2FXUWdiM0poWTJ4bElIQnlhV05sSWdvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdiM0poWTJ4bElIQnlhV05sQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvek16SXRNek16Q2lBZ0lDQXZMeUFqSUVOaGJHTjFiR0YwWlNCUWJrd0tJQ0FnSUM4dklIQnViQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pNek5nb2dJQ0FnTHk4Z2FXWWdjRzl6TG1selgyeHZibWN1Ym1GMGFYWmxPZ29nSUNBZ2NIVnphR2x1ZENBek1qQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZWlCamJHOXpaVjl3YjNOcGRHbHZibDlsYkhObFgySnZaSGxBTmdvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk16TTNDaUFnSUNBdkx5QnBaaUJqZFhKeVpXNTBYM0J5YVdObElENDlJSEJ2Y3k1bGJuUnllVjl3Y21salpTNXVZWFJwZG1VNkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnY0hWemFHbHVkQ0EyTlFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURVS0lDQWdJRHc5Q2lBZ0lDQmllaUJqYkc5elpWOXdiM05wZEdsdmJsOWxiSE5sWDJKdlpIbEFOQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TXpNNENpQWdJQ0F2THlCd2NtbGpaVjlrYVdabUlEMGdZM1Z5Y21WdWRGOXdjbWxqWlNBdElIQnZjeTVsYm5SeWVWOXdjbWxqWlM1dVlYUnBkbVVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXRDaUFnSUNCaWRYSjVJREV6Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvek16a0tJQ0FnSUM4dklHbHpYM0J5YjJacGRDQTlJRlJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmlkWEo1SURFMkNncGpiRzl6WlY5d2IzTnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRREV3T2dvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk16VXhDaUFnSUNBdkx5QnBaaUJ3YjNNdVpXNTBjbmxmY0hKcFkyVXVibUYwYVhabElENGdNRG9LSUNBZ0lHUnBaeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05qVWdPQW9nSUNBZ1luVnllU0F4T1FvZ0lDQWdjSFZ6YUdsdWRDQTJOUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TWdvZ0lDQWdZbm9nWTJ4dmMyVmZjRzl6YVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNelV5Q2lBZ0lDQXZMeUJ3Ym13Z1BTQW9jSEpwWTJWZlpHbG1aaUFxSUhCdmN5NXphWHBsTG01aGRHbDJaU2tnTHk4Z2NHOXpMbVZ1ZEhKNVgzQnlhV05sTG01aGRHbDJaUW9nSUNBZ1pHbG5JRFVLSUNBZ0lIQjFjMmhwYm5RZ05ERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNVE1LSUNBZ0lDb0tJQ0FnSUdScFp5QXhNUW9nSUNBZ0x3b2dJQ0FnWW5WeWVTQXpDZ3BqYkc5elpWOXdiM05wZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURFeU9nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNelUwTFRNMU5Rb2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdZMnh2YzJsdVp5Qm1aV1VLSUNBZ0lDOHZJSFJ2ZEdGc1gyWmxaU0E5SUNod2IzTXVjMmw2WlM1dVlYUnBkbVVnS2lCelpXeG1MbU5zYjNObFgyWmxaU2tnTHk4Z01UQXdNREFLSUNBZ0lHUnBaeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05ERWdPQW9nSUNBZ1luVnllU0F4T0FvZ0lDQWdjSFZ6YUdsdWRDQTBNUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURJM0lDOHZJQ0pqYkc5elpWOW1aV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyeHZjMlZmWm1WbElHVjRhWE4wY3dvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh6SUM4dklERXdNREF3Q2lBZ0lDQXZDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dPUW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TXpVM0xUTTFPQW9nSUNBZ0x5OGdJeUJFZVc1aGJXbGpJR1psWlNCeWIzVjBhVzVuSUdKaGMyVmtJRzl1SUdOdmJuUnlZV04wSUdKaGJHRnVZMlVLSUNBZ0lDOHZJRzl3WlhKaGRHbHZibUZzWDJabFpTd2djM1JoYTJsdVoxOW1aV1VnUFNCelpXeG1MbDl5YjNWMFpWOW1aV1VvZEc5MFlXeGZabVZsS1FvZ0lDQWdZMkZzYkhOMVlpQmZjbTkxZEdWZlptVmxDaUFnSUNCaWRYSjVJREV6Q2lBZ0lDQmlkWEo1SURFMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3pOaklLSUNBZ0lDOHZJR2xtSUdselgzQnliMlpwZERvS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnWW5vZ1kyeHZjMlZmY0c5emFYUnBiMjVmWld4elpWOWliMlI1UURFM0NpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3pOak1LSUNBZ0lDOHZJRzVsZEY5eVpYUjFjbTRnUFNCd2IzTXVZMjlzYkdGMFpYSmhiQzV1WVhScGRtVWdLeUJ3Ym13S0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRFE1Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURNS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TmdvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk16WTBDaUFnSUNBdkx5QnBaaUJ1WlhSZmNtVjBkWEp1SUQ0Z2RHOTBZV3hmWm1WbE9nb2dJQ0FnWkdsbklEZ0tJQ0FnSUQ0S0lDQWdJR0o2SUdOc2IzTmxYM0J2YzJsMGFXOXVYMlZzYzJWZlltOWtlVUF4TlFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk16WTFDaUFnSUNBdkx5QnVaWFJmY21WMGRYSnVJQzA5SUhSdmRHRnNYMlpsWlFvZ0lDQWdaR2xuSURFMENpQWdJQ0JrYVdjZ09Bb2dJQ0FnTFFvZ0lDQWdZblZ5ZVNBeE5Rb0tZMnh2YzJWZmNHOXphWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TkRvS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qTTRNQW9nSUNBZ0x5OGdjRzl6YVhScGIyNWZhV1E5Y0c5ekxuQnZjMmwwYVc5dVgybGtMQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEZ0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPak00TkFvZ0lDQWdMeThnWTI5c2JHRjBaWEpoYkQxd2IzTXVZMjlzYkdGMFpYSmhiQ3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEUTVJRGdLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pNNE5Rb2dJQ0FnTHk4Z2JHVjJaWEpoWjJVOWNHOXpMbXhsZG1WeVlXZGxMQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05UY2dPQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TXpnM0NpQWdJQ0F2THlCc2FYRjFhV1JoZEdsdmJsOXdjbWxqWlQxd2IzTXViR2x4ZFdsa1lYUnBiMjVmY0hKcFkyVXNDaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBM015QTRDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG96T0RnS0lDQWdJQzh2SUd4aGMzUmZablZ1WkdsdVoxOTBhVzFsUFhCdmN5NXNZWE4wWDJaMWJtUnBibWRmZEdsdFpTd0tJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURneElEZ0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPak00T1FvZ0lDQWdMeThnWVdOamRXMTFiR0YwWldSZlpuVnVaR2x1Wnoxd2IzTXVZV05qZFcxMWJHRjBaV1JmWm5WdVpHbHVaeXdLSUNBZ0lHUnBaeUExQ2lBZ0lDQmxlSFJ5WVdOMElEZzVJRGdLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pNNU1Bb2dJQ0FnTHk4Z2IzQmxibDkwYVcxbFBYQnZjeTV2Y0dWdVgzUnBiV1VzQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdWNGRISmhZM1FnT1RjZ09Bb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNemM0TFRNNU1nb2dJQ0FnTHk4Z0l5Qk5ZWEpySUhCdmMybDBhVzl1SUdGeklHTnNiM05sWkNCcGJpQkNiM2hOWVhBS0lDQWdJQzh2SUhObGJHWXVjRzl6YVhScGIyNXpXM0J2YzJsMGFXOXVYMnRsZVYwZ1BTQlFiM05wZEdsdmJpZ0tJQ0FnSUM4dklDQWdJQ0J3YjNOcGRHbHZibDlwWkQxd2IzTXVjRzl6YVhScGIyNWZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2RISmhaR1Z5UFhCdmN5NTBjbUZrWlhJc0NpQWdJQ0F2THlBZ0lDQWdhWE5mYkc5dVp6MXdiM011YVhOZmJHOXVaeXdLSUNBZ0lDOHZJQ0FnSUNCemFYcGxQWEJ2Y3k1emFYcGxMQW9nSUNBZ0x5OGdJQ0FnSUdOdmJHeGhkR1Z5WVd3OWNHOXpMbU52Ykd4aGRHVnlZV3dzQ2lBZ0lDQXZMeUFnSUNBZ2JHVjJaWEpoWjJVOWNHOXpMbXhsZG1WeVlXZGxMQW9nSUNBZ0x5OGdJQ0FnSUdWdWRISjVYM0J5YVdObFBYQnZjeTVsYm5SeWVWOXdjbWxqWlN3S0lDQWdJQzh2SUNBZ0lDQnNhWEYxYVdSaGRHbHZibDl3Y21salpUMXdiM011YkdseGRXbGtZWFJwYjI1ZmNISnBZMlVzQ2lBZ0lDQXZMeUFnSUNBZ2JHRnpkRjltZFc1a2FXNW5YM1JwYldVOWNHOXpMbXhoYzNSZlpuVnVaR2x1WjE5MGFXMWxMQW9nSUNBZ0x5OGdJQ0FnSUdGalkzVnRkV3hoZEdWa1gyWjFibVJwYm1jOWNHOXpMbUZqWTNWdGRXeGhkR1ZrWDJaMWJtUnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2IzQmxibDkwYVcxbFBYQnZjeTV2Y0dWdVgzUnBiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZiM0JsYmoxQ2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdaR2xuSURFeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pNNU1Rb2dJQ0FnTHk4Z2FYTmZiM0JsYmoxQ2IyOXNLRVpoYkhObEtTd0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TXpjNExUTTVNZ29nSUNBZ0x5OGdJeUJOWVhKcklIQnZjMmwwYVc5dUlHRnpJR05zYjNObFpDQnBiaUJDYjNoTllYQUtJQ0FnSUM4dklITmxiR1l1Y0c5emFYUnBiMjV6VzNCdmMybDBhVzl1WDJ0bGVWMGdQU0JRYjNOcGRHbHZiaWdLSUNBZ0lDOHZJQ0FnSUNCd2IzTnBkR2x2Ymw5cFpEMXdiM011Y0c5emFYUnBiMjVmYVdRc0NpQWdJQ0F2THlBZ0lDQWdkSEpoWkdWeVBYQnZjeTUwY21Ga1pYSXNDaUFnSUNBdkx5QWdJQ0FnYVhOZmJHOXVaejF3YjNNdWFYTmZiRzl1Wnl3S0lDQWdJQzh2SUNBZ0lDQnphWHBsUFhCdmN5NXphWHBsTEFvZ0lDQWdMeThnSUNBZ0lHTnZiR3hoZEdWeVlXdzljRzl6TG1OdmJHeGhkR1Z5WVd3c0NpQWdJQ0F2THlBZ0lDQWdiR1YyWlhKaFoyVTljRzl6TG14bGRtVnlZV2RsTEFvZ0lDQWdMeThnSUNBZ0lHVnVkSEo1WDNCeWFXTmxQWEJ2Y3k1bGJuUnllVjl3Y21salpTd0tJQ0FnSUM4dklDQWdJQ0JzYVhGMWFXUmhkR2x2Ymw5d2NtbGpaVDF3YjNNdWJHbHhkV2xrWVhScGIyNWZjSEpwWTJVc0NpQWdJQ0F2THlBZ0lDQWdiR0Z6ZEY5bWRXNWthVzVuWDNScGJXVTljRzl6TG14aGMzUmZablZ1WkdsdVoxOTBhVzFsTEFvZ0lDQWdMeThnSUNBZ0lHRmpZM1Z0ZFd4aGRHVmtYMloxYm1ScGJtYzljRzl6TG1GalkzVnRkV3hoZEdWa1gyWjFibVJwYm1jc0NpQWdJQ0F2THlBZ0lDQWdiM0JsYmw5MGFXMWxQWEJ2Y3k1dmNHVnVYM1JwYldVc0NpQWdJQ0F2THlBZ0lDQWdhWE5mYjNCbGJqMUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURjS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPak01TkMwek9UWUtJQ0FnSUM4dklDTWdVSEp2WTJWemN5QlFia3dnWVc1a0lISmxkSFZ5YmlCbWRXNWtjeUIwYUhKdmRXZG9JSEJ2YjJ3S0lDQWdJQzh2SUNNZ1VHOXZiQ0JvWVc1a2JHVnpJSFJvWlNCd1lYbHZkWFFnZEc4Z2RISmhaR1Z5SUdsbUlIQnliMlpwZEdGaWJHVUtJQ0FnSUM4dklHbG1JRzVsZEY5eVpYUjFjbTRnUGlBd09nb2dJQ0FnWkdsbklERTBDaUFnSUNCaWVpQmpiRzl6WlY5d2IzTnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRREkzQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvek9UY3ROREE1Q2lBZ0lDQXZMeUFqSUVOaGJHd2djRzl2YkNkeklIQnliMk5sYzNOZmNHNXNJRzFsZEdodlpDQjBieUJvWVc1a2JHVWdkSEpoWkdWeUlIQmhlVzkxZEFvZ0lDQWdMeThnSXlCR2IzSWdjSEp2Wm1sME9pQndiMjlzSUhCaGVYTWdkSEpoWkdWeUNpQWdJQ0F2THlBaklFWnZjaUJzYjNOek9pQmpiMnhzWVhSbGNtRnNJSE4wWVhseklHbHVJSEJ2YjJ3Z0tHRnNjbVZoWkhrZ2RISmhibk5tWlhKeVpXUWdaSFZ5YVc1bklHOXdaVzRwQ2lBZ0lDQXZMeUJwZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROVFYQndiR2xqWVhScGIyNG9jMlZzWmk1d1pYSndjMTl3YjI5c1gyRndjRjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJGeVozTTlLQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjbU0wTG1GeVl6UmZjMmxuYm1GMGRYSmxLQ0p3Y205alpYTnpYM0J1YkNoMWFXNTBOalFzWW05dmJDeGhaR1J5WlhOektXSnZiMndpS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhKak5DNVZTVzUwTmpRb2JtVjBYM0psZEhWeWJpa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnlZelF1UW05dmJDaHBjMTl3Y205bWFYUXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQndiM011ZEhKaFpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFVkc2IySmhiQzV0YVc1ZmRIaHVYMlpsWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pRd09Bb2dJQ0FnTHk4Z1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lHZHNiMkpoYkNCTmFXNVVlRzVHWldVS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qUXdNUW9nSUNBZ0x5OGdZWEJ3WDJsa1BVRndjR3hwWTJGMGFXOXVLSE5sYkdZdWNHVnljSE5mY0c5dmJGOWhjSEJmYVdRcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKd1pYSndjMTl3YjI5c1gyRndjRjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdaWEp3YzE5d2IyOXNYMkZ3Y0Y5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qUXdOQW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYm1WMFgzSmxkSFZ5Ymlrc0NpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalF3TlFvZ0lDQWdMeThnWVhKak5DNUNiMjlzS0dselgzQnliMlpwZENrc0NpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrYVdjZ01qQUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TkRBekNpQWdJQ0F2THlCaGNtTTBMbUZ5WXpSZmMybG5ibUYwZFhKbEtDSndjbTlqWlhOelgzQnViQ2gxYVc1ME5qUXNZbTl2YkN4aFpHUnlaWE56S1dKdmIyd2lLU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFl5TkRZMFpEWTNJQzh2SUcxbGRHaHZaQ0FpY0hKdlkyVnpjMTl3Ym13b2RXbHVkRFkwTEdKdmIyd3NZV1JrY21WemN5bGliMjlzSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qTTVOeTAwTURBS0lDQWdJQzh2SUNNZ1EyRnNiQ0J3YjI5c0ozTWdjSEp2WTJWemMxOXdibXdnYldWMGFHOWtJSFJ2SUdoaGJtUnNaU0IwY21Ga1pYSWdjR0Y1YjNWMENpQWdJQ0F2THlBaklFWnZjaUJ3Y205bWFYUTZJSEJ2YjJ3Z2NHRjVjeUIwY21Ga1pYSUtJQ0FnSUM4dklDTWdSbTl5SUd4dmMzTTZJR052Ykd4aGRHVnlZV3dnYzNSaGVYTWdhVzRnY0c5dmJDQW9ZV3h5WldGa2VTQjBjbUZ1YzJabGNuSmxaQ0JrZFhKcGJtY2diM0JsYmlrS0lDQWdJQzh2SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG96T1RjdE5EQTVDaUFnSUNBdkx5QWpJRU5oYkd3Z2NHOXZiQ2R6SUhCeWIyTmxjM05mY0c1c0lHMWxkR2h2WkNCMGJ5Qm9ZVzVrYkdVZ2RISmhaR1Z5SUhCaGVXOTFkQW9nSUNBZ0x5OGdJeUJHYjNJZ2NISnZabWwwT2lCd2IyOXNJSEJoZVhNZ2RISmhaR1Z5Q2lBZ0lDQXZMeUFqSUVadmNpQnNiM056T2lCamIyeHNZWFJsY21Gc0lITjBZWGx6SUdsdUlIQnZiMndnS0dGc2NtVmhaSGtnZEhKaGJuTm1aWEp5WldRZ1pIVnlhVzVuSUc5d1pXNHBDaUFnSUNBdkx5QnBkSGh1TGtGd2NHeHBZMkYwYVc5dVEyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZhV1E5UVhCd2JHbGpZWFJwYjI0b2MyVnNaaTV3WlhKd2MxOXdiMjlzWDJGd2NGOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMkZ5WjNNOUtBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGNtTTBMbUZ5WXpSZmMybG5ibUYwZFhKbEtDSndjbTlqWlhOelgzQnViQ2gxYVc1ME5qUXNZbTl2YkN4aFpHUnlaWE56S1dKdmIyd2lLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYm1WMFgzSmxkSFZ5Ymlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVRbTl2YkNocGMxOXdjbTltYVhRcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCd2IzTXVkSEpoWkdWeUxBb2dJQ0FnTHk4Z0lDQWdJQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3BqYkc5elpWOXdiM05wZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURJM09nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOREV4TFRReE1nb2dJQ0FnTHk4Z0l5QkxaV1Z3SUc5d1pYSmhkR2x2Ym1Gc0lHWmxaU0JwYmlCamIyNTBjbUZqZENBb2JtOGdZV04wYVc5dUlHNWxaV1JsWkNBdElITjBZWGx6SUdsdUlHSmhiR0Z1WTJVcENpQWdJQ0F2THlCelpXeG1MbTl3WlhKaGRHbHZibUZzWDNKbGMyVnlkbVVnS3owZ2IzQmxjbUYwYVc5dVlXeGZabVZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWliM0JsY21GMGFXOXVZV3hmY21WelpYSjJaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmNHVnlZWFJwYjI1aGJGOXlaWE5sY25abElHVjRhWE4wY3dvZ0lDQWdaR2xuSURFMENpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p2Y0dWeVlYUnBiMjVoYkY5eVpYTmxjblpsSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qUXhOQzAwTVRVS0lDQWdJQzh2SUNNZ1ZISmhibk5tWlhJZ2IyNXNlU0J6ZEdGcmFXNW5JSEJ2Y25ScGIyNGdkRzhnYzNSaGEybHVaeUJqYjI1MGNtRmpkQW9nSUNBZ0x5OGdhV1lnYzNSaGEybHVaMTltWldVZ1BpQXdPZ29nSUNBZ1pHbG5JREV4Q2lBZ0lDQmllaUJqYkc5elpWOXdiM05wZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURNd0NpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzBNVFl0TkRJd0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YzJWc1ppNXpkR0ZyYVc1blgyTnZiblJ5WVdOMExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXpkR0ZyYVc1blgyWmxaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOREU1Q2lBZ0lDQXZMeUJtWldVOVIyeHZZbUZzTG0xcGJsOTBlRzVmWm1WbExBb2dJQ0FnWjJ4dlltRnNJRTFwYmxSNGJrWmxaUW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TkRFM0NpQWdJQ0F2THlCeVpXTmxhWFpsY2oxelpXeG1Mbk4wWVd0cGJtZGZZMjl1ZEhKaFkzUXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0luTjBZV3RwYm1kZlkyOXVkSEpoWTNRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoYTJsdVoxOWpiMjUwY21GamRDQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeE13b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalF4TmdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qUXhOaTAwTWpBS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxuTjBZV3RwYm1kZlkyOXVkSEpoWTNRc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYTjBZV3RwYm1kZlptVmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMUhiRzlpWVd3dWJXbHVYM1I0Ymw5bVpXVXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tZMnh2YzJWZmNHOXphWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF6TURvS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qUXlNaTAwTWpNS0lDQWdJQzh2SUNNZ1ZYQmtZWFJsSUcxaGNtdGxkQ0J6ZEdGMFpRb2dJQ0FnTHk4Z2MyVnNaaTVoWTNScGRtVmZjRzl6YVhScGIyNXpJQzA5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0poWTNScGRtVmZjRzl6YVhScGIyNXpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GamRHbDJaVjl3YjNOcGRHbHZibk1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWVdOMGFYWmxYM0J2YzJsMGFXOXVjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvME1qUUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZabVZsYzE5amIyeHNaV04wWldRZ0t6MGdkRzkwWVd4ZlptVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWRHOTBZV3hmWm1WbGMxOWpiMnhzWldOMFpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZabVZsYzE5amIyeHNaV04wWldRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdLd29nSUNBZ1lubDBaV01nT0NBdkx5QWlkRzkwWVd4ZlptVmxjMTlqYjJ4c1pXTjBaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5ESTJDaUFnSUNBdkx5QnBaaUJ3YjNNdWFYTmZiRzl1Wnk1dVlYUnBkbVU2Q2lBZ0lDQmtkWEFLSUNBZ0lHSjZJR05zYjNObFgzQnZjMmwwYVc5dVgyVnNjMlZmWW05a2VVQXpOQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TkRJM0NpQWdJQ0F2THlCcFppQnpaV3htTG5SdmRHRnNYMnh2Ym1kZmIya2dQajBnY0c5ekxuTnBlbVV1Ym1GMGFYWmxPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDJ4dmJtZGZiMmtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYkc5dVoxOXZhU0JsZUdsemRITUtJQ0FnSUdScFp5QXhNQW9nSUNBZ1BqMEtJQ0FnSUdKNklHTnNiM05sWDNCdmMybDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFNemNLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pReU9Bb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXNiMjVuWDI5cElDMDlJSEJ2Y3k1emFYcGxMbTVoZEdsMlpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMnh2Ym1kZmIya2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZiRzl1WjE5dmFTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZiRzl1WjE5dmFTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3BqYkc5elpWOXdiM05wZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURNM09nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZORE16Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYm1WMFgzSmxkSFZ5YmlrS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNekEzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtTnNiM05sWDNCdmMybDBhVzl1WDJWc2MyVmZZbTlrZVVBek5Eb0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalF6TUFvZ0lDQWdMeThnYVdZZ2MyVnNaaTUwYjNSaGJGOXphRzl5ZEY5dmFTQStQU0J3YjNNdWMybDZaUzV1WVhScGRtVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRHOTBZV3hmYzJodmNuUmZiMmtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYzJodmNuUmZiMmtnWlhocGMzUnpDaUFnSUNCa2FXY2dNVEFLSUNBZ0lENDlDaUFnSUNCaWVpQmpiRzl6WlY5d2IzTnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRE0zQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvME16RUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjMmh2Y25SZmIya2dMVDBnY0c5ekxuTnBlbVV1Ym1GMGFYWmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRHOTBZV3hmYzJodmNuUmZiMmtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYzJodmNuUmZiMmtnWlhocGMzUnpDaUFnSUNCa2FXY2dNVEFLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZkR0ZzWDNOb2IzSjBYMjlwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0lnWTJ4dmMyVmZjRzl6YVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBek53b0tZMnh2YzJWZmNHOXphWFJwYjI1ZlpXeHpaVjlpYjJSNVFERTFPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TXpZM0NpQWdJQ0F2THlCdVpYUmZjbVYwZFhKdUlEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhOUW9nSUNBZ1lpQmpiRzl6WlY5d2IzTnBkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRREkwQ2dwamJHOXpaVjl3YjNOcGRHbHZibDlsYkhObFgySnZaSGxBTVRjNkNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUb3pOamtLSUNBZ0lDOHZJR2xtSUhCdmN5NWpiMnhzWVhSbGNtRnNMbTVoZEdsMlpTQStJSEJ1YkRvS0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRFE1Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUGdvZ0lDQWdZbm9nWTJ4dmMyVmZjRzl6YVhScGIyNWZaV3h6WlY5aWIyUjVRREl5Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvek56QUtJQ0FnSUM4dklHNWxkRjl5WlhSMWNtNGdQU0J3YjNNdVkyOXNiR0YwWlhKaGJDNXVZWFJwZG1VZ0xTQndibXdLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmthV2NnTXdvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUyQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvek56RUtJQ0FnSUM4dklHbG1JRzVsZEY5eVpYUjFjbTRnUGlCMGIzUmhiRjltWldVNkNpQWdJQ0JrYVdjZ09Bb2dJQ0FnUGdvZ0lDQWdZbm9nWTJ4dmMyVmZjRzl6YVhScGIyNWZaV3h6WlY5aWIyUjVRREl3Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvek56SUtJQ0FnSUM4dklHNWxkRjl5WlhSMWNtNGdMVDBnZEc5MFlXeGZabVZsQ2lBZ0lDQmthV2NnTVRRS0lDQWdJR1JwWnlBNENpQWdJQ0F0Q2lBZ0lDQmlkWEo1SURFMUNpQWdJQ0JpSUdOc2IzTmxYM0J2YzJsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1qUUtDbU5zYjNObFgzQnZjMmwwYVc5dVgyVnNjMlZmWW05a2VVQXlNRG9LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pNM05Bb2dJQ0FnTHk4Z2JtVjBYM0psZEhWeWJpQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKMWNua2dNVFVLSUNBZ0lHSWdZMnh2YzJWZmNHOXphWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TkFvS1kyeHZjMlZmY0c5emFYUnBiMjVmWld4elpWOWliMlI1UURJeU9nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNemMyQ2lBZ0lDQXZMeUJ1WlhSZmNtVjBkWEp1SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBeE5Rb2dJQ0FnWWlCamJHOXpaVjl3YjNOcGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFESTBDZ3BqYkc5elpWOXdiM05wZEdsdmJsOWxiSE5sWDJKdlpIbEFORG9LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pNME1Rb2dJQ0FnTHk4Z2NISnBZMlZmWkdsbVppQTlJSEJ2Y3k1bGJuUnllVjl3Y21salpTNXVZWFJwZG1VZ0xTQmpkWEp5Wlc1MFgzQnlhV05sQ2lBZ0lDQmthV2NnTkFvZ0lDQWdMUW9nSUNBZ1luVnllU0F4TXdvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk16UXlDaUFnSUNBdkx5QnBjMTl3Y205bWFYUWdQU0JHWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ01UWUtJQ0FnSUdJZ1kyeHZjMlZmY0c5emFYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9LWTJ4dmMyVmZjRzl6YVhScGIyNWZaV3h6WlY5aWIyUjVRRFk2Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvek5EUUtJQ0FnSUM4dklHbG1JSEJ2Y3k1bGJuUnllVjl3Y21salpTNXVZWFJwZG1VZ1BqMGdZM1Z5Y21WdWRGOXdjbWxqWlRvS0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRFkxQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdQajBLSUNBZ0lHSjZJR05zYjNObFgzQnZjMmwwYVc5dVgyVnNjMlZmWW05a2VVQTRDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG96TkRVS0lDQWdJQzh2SUhCeWFXTmxYMlJwWm1ZZ1BTQndiM011Wlc1MGNubGZjSEpwWTJVdWJtRjBhWFpsSUMwZ1kzVnljbVZ1ZEY5d2NtbGpaUW9nSUNBZ1pHbG5JRFFLSUNBZ0lDMEtJQ0FnSUdKMWNua2dNVE1LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pNME5nb2dJQ0FnTHk4Z2FYTmZjSEp2Wm1sMElEMGdWSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSjFjbmtnTVRZS0lDQWdJR0lnWTJ4dmMyVmZjRzl6YVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb0tZMnh2YzJWZmNHOXphWFJwYjI1ZlpXeHpaVjlpYjJSNVFEZzZDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG96TkRnS0lDQWdJQzh2SUhCeWFXTmxYMlJwWm1ZZ1BTQmpkWEp5Wlc1MFgzQnlhV05sSUMwZ2NHOXpMbVZ1ZEhKNVgzQnlhV05sTG01aGRHbDJaUW9nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdKMWNua2dNVE1LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pNME9Rb2dJQ0FnTHk4Z2FYTmZjSEp2Wm1sMElEMGdSbUZzYzJVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlkWEo1SURFMkNpQWdJQ0JpSUdOc2IzTmxYM0J2YzJsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtDZ292THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1UVpYSndaWFIxWVd4elRXRnlhMlYwTG1Ga1pGOXRZWEpuYVc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhaR1JmYldGeVoybHVPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TkRNMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzBORGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYzJWc1ppNXBjMTl3WVhWelpXUXNJQ0pOWVhKclpYUWdjR0YxYzJWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW1selgzQmhkWE5sWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBjMTl3WVhWelpXUWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUV0Z5YTJWMElIQmhkWE5sWkFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5EVXdMVFExTVFvZ0lDQWdMeThnSXlCV1pYSnBabmtnY0dGNWJXVnVkQW9nSUNBZ0x5OGdZWE56WlhKMElHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1S0RBcExtRnRiM1Z1ZENBK1BTQmhiVzkxYm5RdWJtRjBhWFpsTENBaVNXNXpkV1ptYVdOcFpXNTBJSEJoZVcxbGJuUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCd1lYbHRaVzUwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvME5USUtJQ0FnSUM4dklHRnpjMlZ5ZENCbmRIaHVMbEJoZVcxbGJuUlVjbUZ1YzJGamRHbHZiaWd3S1M1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlWM0p2Ym1jZ2NtVmpaV2wyWlhJaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRmR5YjI1bklISmxZMlZwZG1WeUNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzBOakV0TkRZMkNpQWdJQ0F2THlBaklGUnlZVzV6Wm1WeUlHMWhjbWRwYmlCMGJ5QndiMjlzQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1d1pYSndjMTl3YjI5c0xBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhiVzkxYm5RdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFIYkc5aVlXd3ViV2x1WDNSNGJsOW1aV1VzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8wTmpVS0lDQWdJQzh2SUdabFpUMUhiRzlpWVd3dWJXbHVYM1I0Ymw5bVpXVXNDaUFnSUNCbmJHOWlZV3dnVFdsdVZIaHVSbVZsQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvME5qTUtJQ0FnSUM4dklISmxZMlZwZG1WeVBYTmxiR1l1Y0dWeWNITmZjRzl2YkN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpY0dWeWNITmZjRzl2YkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdaWEp3YzE5d2IyOXNJR1Y0YVhOMGN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5EWXhMVFEyTWdvZ0lDQWdMeThnSXlCVWNtRnVjMlpsY2lCdFlYSm5hVzRnZEc4Z2NHOXZiQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pRMk1TMDBOallLSUNBZ0lDOHZJQ01nVkhKaGJuTm1aWElnYldGeVoybHVJSFJ2SUhCdmIyd0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxelpXeG1MbkJsY25CelgzQnZiMndzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBVZHNiMkpoYkM1dGFXNWZkSGh1WDJabFpTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzBNelVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbEJsY25CbGRIVmhiSE5OWVhKclpYUXVjbVZ0YjNabFgyMWhjbWRwYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxiVzkyWlY5dFlYSm5hVzQ2Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvME56QUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8wT0RJS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ2MyVnNaaTVwYzE5d1lYVnpaV1FzSUNKTllYSnJaWFFnY0dGMWMyVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltbHpYM0JoZFhObFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYzE5d1lYVnpaV1FnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVFdGeWEyVjBJSEJoZFhObFpBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZORGN3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzVRWlhKd1pYUjFZV3h6VFdGeWEyVjBMbXhwY1hWcFpHRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q214cGNYVnBaR0YwWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3YmlBM0NpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzBPVFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOVEEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUhObGJHWXVhWE5mY0dGMWMyVmtMQ0FpVFdGeWEyVjBJSEJoZFhObFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE5mY0dGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTFoY210bGRDQndZWFZ6WldRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qVXdPUzAxTVRBS0lDQWdJQzh2SUNNZ1IyVjBJR04xY25KbGJuUWdjSEpwWTJVS0lDQWdJQzh2SUdOMWNuSmxiblJmY0hKcFkyVWdQU0J6Wld4bUxsOW5aWFJmYjNKaFkyeGxYM0J5YVdObEtDa0tJQ0FnSUdOaGJHeHpkV0lnWDJkbGRGOXZjbUZqYkdWZmNISnBZMlVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5URXhDaUFnSUNBdkx5QmhjM05sY25RZ1kzVnljbVZ1ZEY5d2NtbGpaU0ErSURBc0lDSkpiblpoYkdsa0lHOXlZV05zWlNCd2NtbGpaU0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lHOXlZV05zWlNCd2NtbGpaUW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TlRFMUNpQWdJQ0F2THlCaGMzTmxjblFnY0c5emFYUnBiMjVmYTJWNUlHbHVJSE5sYkdZdWNHOXphWFJwYjI1ekxDQWlVRzl6YVhScGIyNGdibTkwSUdadmRXNWtJZ29nSUNBZ1lubDBaV01nTWpBZ0x5OGdNSGczTURabU56TTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklGQnZjMmwwYVc5dUlHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOVEUyQ2lBZ0lDQXZMeUJ3YjNNZ1BTQnpaV3htTG5CdmMybDBhVzl1YzF0d2IzTnBkR2x2Ymw5clpYbGRMbU52Y0hrb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCa2RYQnVJRElLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pVeE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCdmN5NXBjMTl2Y0dWdUxtNWhkR2wyWlN3Z0lsQnZjMmwwYVc5dUlHRnNjbVZoWkhrZ1kyeHZjMlZrSWdvZ0lDQWdjSFZ6YUdsdWRDQTROREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFiM05wZEdsdmJpQmhiSEpsWVdSNUlHTnNiM05sWkFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5USXdMVFV5TVFvZ0lDQWdMeThnSXlCRFlXeGpkV3hoZEdVZ1kzVnljbVZ1ZENCUWJrd0tJQ0FnSUM4dklIQnViQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pVeU5Bb2dJQ0FnTHk4Z2FXWWdjRzl6TG1selgyeHZibWN1Ym1GMGFYWmxPZ29nSUNBZ2NIVnphR2x1ZENBek1qQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZWlCc2FYRjFhV1JoZEdWZlpXeHpaVjlpYjJSNVFEWUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalV5TlFvZ0lDQWdMeThnYVdZZ1kzVnljbVZ1ZEY5d2NtbGpaU0ErUFNCd2IzTXVaVzUwY25sZmNISnBZMlV1Ym1GMGFYWmxPZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ05qVUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTNDaUFnSUNBOFBRb2dJQ0FnWW5vZ2JHbHhkV2xrWVhSbFgyVnNjMlZmWW05a2VVQTBDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8xTWpZS0lDQWdJQzh2SUdselgzQnliMlpwZENBOUlGUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaWRYSjVJREUwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMU1qY0tJQ0FnSUM4dklIQnlhV05sWDJScFptWWdQU0JqZFhKeVpXNTBYM0J5YVdObElDMGdjRzl6TG1WdWRISjVYM0J5YVdObExtNWhkR2wyWlFvZ0lDQWdaR2xuSURZS0lDQWdJSE4zWVhBS0lDQWdJQzBLSUNBZ0lHSjFjbmtnTVRFS0NteHBjWFZwWkdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOVE01Q2lBZ0lDQXZMeUJwWmlCd2IzTXVaVzUwY25sZmNISnBZMlV1Ym1GMGFYWmxJRDRnTURvS0lDQWdJR1JwWnlBekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOalVnT0FvZ0lDQWdZblZ5ZVNBeE9Bb2dJQ0FnY0hWemFHbHVkQ0EyTlFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JpZWlCc2FYRjFhV1JoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5UUXdDaUFnSUNBdkx5QndibXdnUFNBb2NISnBZMlZmWkdsbVppQXFJSEJ2Y3k1emFYcGxMbTVoZEdsMlpTa2dMeThnY0c5ekxtVnVkSEo1WDNCeWFXTmxMbTVoZEdsMlpRb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTkRFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01URUtJQ0FnSUNvS0lDQWdJR1JwWnlBNENpQWdJQ0F2Q2lBZ0lDQmlkWEo1SURNS0NteHBjWFZwWkdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURFeU9nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOVFF5TFRVME13b2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdaV1ptWldOMGFYWmxJRzFoY21kcGJnb2dJQ0FnTHk4Z1pXWm1aV04wYVhabFgyMWhjbWRwYmlBOUlIQnZjeTVqYjJ4c1lYUmxjbUZzTG01aGRHbDJaUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBME9TQTRDaUFnSUNCaWRYSjVJREUzQ2lBZ0lDQndkWE5vYVc1MElEUTVDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1luVnllU0F4TkFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5UUTBDaUFnSUNBdkx5QnBaaUJwYzE5d2NtOW1hWFE2Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR0o2SUd4cGNYVnBaR0YwWlY5bGJITmxYMkp2WkhsQU1UUUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalUwTlFvZ0lDQWdMeThnWldabVpXTjBhWFpsWDIxaGNtZHBiaUFyUFNCd2Jtd0tJQ0FnSUdScFp5QXhNd29nSUNBZ1pHbG5JRE1LSUNBZ0lDc0tJQ0FnSUdKMWNua2dNVFFLQ214cGNYVnBaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRREU0T2dvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5UVXlMVFUxTXdvZ0lDQWdMeThnSXlCV1pYSnBabmtnY0c5emFYUnBiMjRnYVhNZ2JHbHhkV2xrWVhSaFlteGxDaUFnSUNBdkx5QnRZWEpuYVc1ZmNtRjBhVzhnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlkWEo1SURFeUNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzFOVFFLSUNBZ0lDOHZJR2xtSUhCdmN5NXphWHBsTG01aGRHbDJaU0ErSURBNkNpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFF4SURnS0lDQWdJR0oxY25rZ01UWUtJQ0FnSUhCMWMyaHBiblFnTkRFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Bb2dJQ0FnWW5vZ2JHbHhkV2xrWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qVTFOUW9nSUNBZ0x5OGdiV0Z5WjJsdVgzSmhkR2x2SUQwZ0tHVm1abVZqZEdsMlpWOXRZWEpuYVc0Z0tpQXhNREF3TUNrZ0x5OGdjRzl6TG5OcGVtVXVibUYwYVhabENpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1EQXdNQW9nSUNBZ0tnb2dJQ0FnWkdsbklEY0tJQ0FnSUM4S0lDQWdJR0oxY25rZ01USUtDbXhwY1hWcFpHRjBaVjloWm5SbGNsOXBabDlsYkhObFFESXdPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TlRVMkNpQWdJQ0F2THlCaGMzTmxjblFnYldGeVoybHVYM0poZEdsdklEd2djMlZzWmk1dFlXbHVkR1Z1WVc1alpWOXRZWEpuYVc0c0lDSlFiM05wZEdsdmJpQnViM1FnYkdseGRXbGtZWFJoWW14bElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKdFlXbHVkR1Z1WVc1alpWOXRZWEpuYVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV0ZwYm5SbGJtRnVZMlZmYldGeVoybHVJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERXlDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnVUc5emFYUnBiMjRnYm05MElHeHBjWFZwWkdGMFlXSnNaUW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TlRVNExUVTFPUW9nSUNBZ0x5OGdJeUJEWVd4amRXeGhkR1VnYkdseGRXbGtZWFJ2Y2lCeVpYZGhjbVFLSUNBZ0lDOHZJSEpsZDJGeVpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKMWNua2dPUW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TlRZd0NpQWdJQ0F2THlCcFppQmxabVpsWTNScGRtVmZiV0Z5WjJsdUlENGdNRG9LSUNBZ0lHUnBaeUF4TXdvZ0lDQWdZbm9nYkdseGRXbGtZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNaklLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pVMk1Rb2dJQ0FnTHk4Z2NtVjNZWEprSUQwZ0tHVm1abVZqZEdsMlpWOXRZWEpuYVc0Z0tpQnpaV3htTG14cGNYVnBaR0YwYjNKZmNtVjNZWEprS1NBdkx5QXhNREF3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURNeElDOHZJQ0pzYVhGMWFXUmhkRzl5WDNKbGQyRnlaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c2FYRjFhV1JoZEc5eVgzSmxkMkZ5WkNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4TkFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh6SUM4dklERXdNREF3Q2lBZ0lDQXZDaUFnSUNCaWRYSjVJRGtLQ214cGNYVnBaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRREl5T2dvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5UWXpMVFUyTkFvZ0lDQWdMeThnSXlCU1pXMWhhVzVrWlhJZ1oyOWxjeUIwYnlCd2IyOXNDaUFnSUNBdkx5QnlaVzFoYVc1a1pYSWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMU5qVUtJQ0FnSUM4dklHbG1JR1ZtWm1WamRHbDJaVjl0WVhKbmFXNGdQaUJ5WlhkaGNtUTZDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQStDaUFnSUNCaWVpQnNhWEYxYVdSaGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBeU5Bb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOVFkyQ2lBZ0lDQXZMeUJ5WlcxaGFXNWtaWElnUFNCbFptWmxZM1JwZG1WZmJXRnlaMmx1SUMwZ2NtVjNZWEprQ2lBZ0lDQmthV2NnTVRNS0lDQWdJR1JwWnlBNUNpQWdJQ0F0Q2lBZ0lDQmlkWEo1SURFd0NncHNhWEYxYVdSaGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBeU5Eb0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalUzTUFvZ0lDQWdMeThnY0c5emFYUnBiMjVmYVdROWNHOXpMbkJ2YzJsMGFXOXVYMmxrTEFvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRGdLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pVM01Rb2dJQ0FnTHk4Z2RISmhaR1Z5UFhCdmN5NTBjbUZrWlhJc0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0E0SURNeUNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzFOelVLSUNBZ0lDOHZJR3hsZG1WeVlXZGxQWEJ2Y3k1c1pYWmxjbUZuWlN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFUzSURnS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qVTNOd29nSUNBZ0x5OGdiR2x4ZFdsa1lYUnBiMjVmY0hKcFkyVTljRzl6TG14cGNYVnBaR0YwYVc5dVgzQnlhV05sTEFvZ0lDQWdaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdOek1nT0FvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5UYzRDaUFnSUNBdkx5QnNZWE4wWDJaMWJtUnBibWRmZEdsdFpUMXdiM011YkdGemRGOW1kVzVrYVc1blgzUnBiV1VzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQTRNU0E0Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMU56a0tJQ0FnSUM4dklHRmpZM1Z0ZFd4aGRHVmtYMloxYm1ScGJtYzljRzl6TG1GalkzVnRkV3hoZEdWa1gyWjFibVJwYm1jc0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWlhoMGNtRmpkQ0E0T1NBNENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzFPREFLSUNBZ0lDOHZJRzl3Wlc1ZmRHbHRaVDF3YjNNdWIzQmxibDkwYVcxbExBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmxlSFJ5WVdOMElEazNJRGdLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pVMk9DMDFPRElLSUNBZ0lDOHZJQ01nVFdGeWF5QndiM05wZEdsdmJpQmhjeUJqYkc5elpXUUtJQ0FnSUM4dklITmxiR1l1Y0c5emFYUnBiMjV6VzNCdmMybDBhVzl1WDJ0bGVWMGdQU0JRYjNOcGRHbHZiaWdLSUNBZ0lDOHZJQ0FnSUNCd2IzTnBkR2x2Ymw5cFpEMXdiM011Y0c5emFYUnBiMjVmYVdRc0NpQWdJQ0F2THlBZ0lDQWdkSEpoWkdWeVBYQnZjeTUwY21Ga1pYSXNDaUFnSUNBdkx5QWdJQ0FnYVhOZmJHOXVaejF3YjNNdWFYTmZiRzl1Wnl3S0lDQWdJQzh2SUNBZ0lDQnphWHBsUFhCdmN5NXphWHBsTEFvZ0lDQWdMeThnSUNBZ0lHTnZiR3hoZEdWeVlXdzljRzl6TG1OdmJHeGhkR1Z5WVd3c0NpQWdJQ0F2THlBZ0lDQWdiR1YyWlhKaFoyVTljRzl6TG14bGRtVnlZV2RsTEFvZ0lDQWdMeThnSUNBZ0lHVnVkSEo1WDNCeWFXTmxQWEJ2Y3k1bGJuUnllVjl3Y21salpTd0tJQ0FnSUM4dklDQWdJQ0JzYVhGMWFXUmhkR2x2Ymw5d2NtbGpaVDF3YjNNdWJHbHhkV2xrWVhScGIyNWZjSEpwWTJVc0NpQWdJQ0F2THlBZ0lDQWdiR0Z6ZEY5bWRXNWthVzVuWDNScGJXVTljRzl6TG14aGMzUmZablZ1WkdsdVoxOTBhVzFsTEFvZ0lDQWdMeThnSUNBZ0lHRmpZM1Z0ZFd4aGRHVmtYMloxYm1ScGJtYzljRzl6TG1GalkzVnRkV3hoZEdWa1gyWjFibVJwYm1jc0NpQWdJQ0F2THlBZ0lDQWdiM0JsYmw5MGFXMWxQWEJ2Y3k1dmNHVnVYM1JwYldVc0NpQWdJQ0F2THlBZ0lDQWdhWE5mYjNCbGJqMUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWpFS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeU1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qVTRNUW9nSUNBZ0x5OGdhWE5mYjNCbGJqMUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TUFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5UWTRMVFU0TWdvZ0lDQWdMeThnSXlCTllYSnJJSEJ2YzJsMGFXOXVJR0Z6SUdOc2IzTmxaQW9nSUNBZ0x5OGdjMlZzWmk1d2IzTnBkR2x2Ym5OYmNHOXphWFJwYjI1ZmEyVjVYU0E5SUZCdmMybDBhVzl1S0FvZ0lDQWdMeThnSUNBZ0lIQnZjMmwwYVc5dVgybGtQWEJ2Y3k1d2IzTnBkR2x2Ymw5cFpDd0tJQ0FnSUM4dklDQWdJQ0IwY21Ga1pYSTljRzl6TG5SeVlXUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCcGMxOXNiMjVuUFhCdmN5NXBjMTlzYjI1bkxBb2dJQ0FnTHk4Z0lDQWdJSE5wZW1VOWNHOXpMbk5wZW1Vc0NpQWdJQ0F2THlBZ0lDQWdZMjlzYkdGMFpYSmhiRDF3YjNNdVkyOXNiR0YwWlhKaGJDd0tJQ0FnSUM4dklDQWdJQ0JzWlhabGNtRm5aVDF3YjNNdWJHVjJaWEpoWjJVc0NpQWdJQ0F2THlBZ0lDQWdaVzUwY25sZmNISnBZMlU5Y0c5ekxtVnVkSEo1WDNCeWFXTmxMQW9nSUNBZ0x5OGdJQ0FnSUd4cGNYVnBaR0YwYVc5dVgzQnlhV05sUFhCdmN5NXNhWEYxYVdSaGRHbHZibDl3Y21salpTd0tJQ0FnSUM4dklDQWdJQ0JzWVhOMFgyWjFibVJwYm1kZmRHbHRaVDF3YjNNdWJHRnpkRjltZFc1a2FXNW5YM1JwYldVc0NpQWdJQ0F2THlBZ0lDQWdZV05qZFcxMWJHRjBaV1JmWm5WdVpHbHVaejF3YjNNdVlXTmpkVzExYkdGMFpXUmZablZ1WkdsdVp5d0tJQ0FnSUM4dklDQWdJQ0J2Y0dWdVgzUnBiV1U5Y0c5ekxtOXdaVzVmZEdsdFpTd0tJQ0FnSUM4dklDQWdJQ0JwYzE5dmNHVnVQVUp2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TlRnMExUVTROUW9nSUNBZ0x5OGdJeUJRWVhrZ2JHbHhkV2xrWVhSdmNpQnlaWGRoY21RS0lDQWdJQzh2SUdsbUlISmxkMkZ5WkNBK0lEQTZDaUFnSUNCa2FXY2dPQW9nSUNBZ1lub2diR2x4ZFdsa1lYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qY0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalU0TmkwMU9UQUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXlaWGRoY21Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFVkc2IySmhiQzV0YVc1ZmRIaHVYMlpsWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pVNE9Rb2dJQ0FnTHk4Z1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lHZHNiMkpoYkNCTmFXNVVlRzVHWldVS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qVTROd29nSUNBZ0x5OGdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXhNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pVNE5nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalU0TmkwMU9UQUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXlaWGRoY21Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFVkc2IySmhiQzV0YVc1ZmRIaHVYMlpsWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dwc2FYRjFhV1JoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF5TnpvS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qVTVNaTAxT1RNS0lDQWdJQzh2SUNNZ1UyVnVaQ0J5WlcxaGFXNWtaWElnZEc4Z2NHOXZiQW9nSUNBZ0x5OGdhV1lnY21WdFlXbHVaR1Z5SUQ0Z01Eb0tJQ0FnSUdScFp5QTVDaUFnSUNCaWVpQnNhWEYxYVdSaGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBek1Bb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOVGswTFRVNU9Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXVjR1Z5Y0hOZmNHOXZiQ3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Y21WdFlXbHVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFIYkc5aVlXd3ViV2x1WDNSNGJsOW1aV1VzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8xT1RjS0lDQWdJQzh2SUdabFpUMUhiRzlpWVd3dWJXbHVYM1I0Ymw5bVpXVXNDaUFnSUNCbmJHOWlZV3dnVFdsdVZIaHVSbVZsQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMU9UVUtJQ0FnSUM4dklISmxZMlZwZG1WeVBYTmxiR1l1Y0dWeWNITmZjRzl2YkN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpY0dWeWNITmZjRzl2YkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdaWEp3YzE5d2IyOXNJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TlRrMENpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOVGswTFRVNU9Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXVjR1Z5Y0hOZmNHOXZiQ3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Y21WdFlXbHVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFIYkc5aVlXd3ViV2x1WDNSNGJsOW1aV1VzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LYkdseGRXbGtZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNekE2Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMk1EQXROakF4Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0J0WVhKclpYUWdjM1JoZEdVS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmJHbHhkV2xrWVhScGIyNXpJQ3M5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpZEc5MFlXeGZiR2x4ZFdsa1lYUnBiMjV6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR0YwYVc5dWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QWlkRzkwWVd4ZmJHbHhkV2xrWVhScGIyNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pZd01nb2dJQ0FnTHk4Z2MyVnNaaTVoWTNScGRtVmZjRzl6YVhScGIyNXpJQzA5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0poWTNScGRtVmZjRzl6YVhScGIyNXpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GamRHbDJaVjl3YjNOcGRHbHZibk1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWVdOMGFYWmxYM0J2YzJsMGFXOXVjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMk1EUUtJQ0FnSUM4dklHbG1JSEJ2Y3k1cGMxOXNiMjVuTG01aGRHbDJaVG9LSUNBZ0lHUjFjQW9nSUNBZ1lub2diR2x4ZFdsa1lYUmxYMlZzYzJWZlltOWtlVUF6TkFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5qQTFDaUFnSUNBdkx5QnBaaUJ6Wld4bUxuUnZkR0ZzWDJ4dmJtZGZiMmtnUGowZ2NHOXpMbk5wZW1VdWJtRjBhWFpsT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1gyeHZibWRmYjJraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmJHOXVaMTl2YVNCbGVHbHpkSE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQStQUW9nSUNBZ1lub2diR2x4ZFdsa1lYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU16Y0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPall3TmdvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5c2IyNW5YMjlwSUMwOUlIQnZjeTV6YVhwbExtNWhkR2wyWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1gyeHZibWRmYjJraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmJHOXVaMTl2YVNCbGVHbHpkSE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5c2IyNW5YMjlwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NteHBjWFZwWkdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURNM09nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZORGswQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NteHBjWFZwWkdGMFpWOWxiSE5sWDJKdlpIbEFNelE2Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMk1EZ0tJQ0FnSUM4dklHbG1JSE5sYkdZdWRHOTBZV3hmYzJodmNuUmZiMmtnUGowZ2NHOXpMbk5wZW1VdWJtRjBhWFpsT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblJ2ZEdGc1gzTm9iM0owWDI5cElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzTm9iM0owWDI5cElHVjRhWE4wY3dvZ0lDQWdaR2xuSURjS0lDQWdJRDQ5Q2lBZ0lDQmllaUJzYVhGMWFXUmhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpOd29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TmpBNUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzTm9iM0owWDI5cElDMDlJSEJ2Y3k1emFYcGxMbTVoZEdsMlpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SdmRHRnNYM05vYjNKMFgyOXBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM05vYjNKMFgyOXBJR1Y0YVhOMGN3b2dJQ0FnWkdsbklEY0tJQ0FnSUMwS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SdmRHRnNYM05vYjNKMFgyOXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSWdiR2x4ZFdsa1lYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU16Y0tDbXhwY1hWcFpHRjBaVjlsYkhObFgySnZaSGxBTVRRNkNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzFORGNLSUNBZ0lDOHZJR2xtSUdWbVptVmpkR2wyWlY5dFlYSm5hVzRnUGlCd2JtdzZDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQStDaUFnSUNCaWVpQnNhWEYxYVdSaGRHVmZaV3h6WlY5aWIyUjVRREUyQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMU5EZ0tJQ0FnSUM4dklHVm1abVZqZEdsMlpWOXRZWEpuYVc0Z0xUMGdjRzVzQ2lBZ0lDQmthV2NnTVRNS0lDQWdJR1JwWnlBekNpQWdJQ0F0Q2lBZ0lDQmlkWEo1SURFMENpQWdJQ0JpSUd4cGNYVnBaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRREU0Q2dwc2FYRjFhV1JoZEdWZlpXeHpaVjlpYjJSNVFERTJPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TlRVd0NpQWdJQ0F2THlCbFptWmxZM1JwZG1WZmJXRnlaMmx1SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBeE5Bb2dJQ0FnWWlCc2FYRjFhV1JoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF4T0FvS2JHbHhkV2xrWVhSbFgyVnNjMlZmWW05a2VVQTBPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TlRJNUNpQWdJQ0F2THlCcGMxOXdjbTltYVhRZ1BTQkdZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjFjbmtnTVRRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qVXpNQW9nSUNBZ0x5OGdjSEpwWTJWZlpHbG1aaUE5SUhCdmN5NWxiblJ5ZVY5d2NtbGpaUzV1WVhScGRtVWdMU0JqZFhKeVpXNTBYM0J5YVdObENpQWdJQ0JrYVdjZ05nb2dJQ0FnTFFvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnWWlCc2FYRjFhV1JoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS2JHbHhkV2xrWVhSbFgyVnNjMlZmWW05a2VVQTJPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TlRNeUNpQWdJQ0F2THlCcFppQndiM011Wlc1MGNubGZjSEpwWTJVdWJtRjBhWFpsSUQ0OUlHTjFjbkpsYm5SZmNISnBZMlU2Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQTJOUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRGNLSUNBZ0lENDlDaUFnSUNCaWVpQnNhWEYxYVdSaGRHVmZaV3h6WlY5aWIyUjVRRGdLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pVek13b2dJQ0FnTHk4Z2FYTmZjSEp2Wm1sMElEMGdWSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSjFjbmtnTVRRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qVXpOQW9nSUNBZ0x5OGdjSEpwWTJWZlpHbG1aaUE5SUhCdmN5NWxiblJ5ZVY5d2NtbGpaUzV1WVhScGRtVWdMU0JqZFhKeVpXNTBYM0J5YVdObENpQWdJQ0JrYVdjZ05nb2dJQ0FnTFFvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnWWlCc2FYRjFhV1JoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS2JHbHhkV2xrWVhSbFgyVnNjMlZmWW05a2VVQTRPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TlRNMkNpQWdJQ0F2THlCcGMxOXdjbTltYVhRZ1BTQkdZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjFjbmtnTVRRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qVXpOd29nSUNBZ0x5OGdjSEpwWTJWZlpHbG1aaUE5SUdOMWNuSmxiblJmY0hKcFkyVWdMU0J3YjNNdVpXNTBjbmxmY0hKcFkyVXVibUYwYVhabENpQWdJQ0JrYVdjZ05nb2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnWWlCc2FYRjFhV1JoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS0NpOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbEJsY25CbGRIVmhiSE5OWVhKclpYUXVZWEJ3YkhsZlpuVnVaR2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRndjR3g1WDJaMWJtUnBibWM2Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMk1UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzVRWlhKd1pYUjFZV3h6VFdGeWEyVjBMbU5oYkdOMWJHRjBaVjl3Ym14YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZV3hqZFd4aGRHVmZjRzVzT2dvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5qTTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmpZV3hzYzNWaUlIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExsQmxjbkJsZEhWaGJITk5ZWEpyWlhRdVkyRnNZM1ZzWVhSbFgzQnViQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExsQmxjbkJsZEhWaGJITk5ZWEpyWlhRdWFYTmZiR2x4ZFdsa1lYUmhZbXhsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTmZiR2x4ZFdsa1lYUmhZbXhsT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMk9UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOekV5TFRjeE13b2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdZM1Z5Y21WdWRDQlFia3dLSUNBZ0lDOHZJSEJ1YkY5eVpYTjFiSFFnUFNCelpXeG1MbU5oYkdOMWJHRjBaVjl3Ym13b2FYTmZiRzl1Wnl3Z1pXNTBjbmxmY0hKcFkyVXNJR04xY25KbGJuUmZjSEpwWTJVc0lITnBlbVVwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVVR1Z5Y0dWMGRXRnNjMDFoY210bGRDNWpZV3hqZFd4aGRHVmZjRzVzQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOekUxTFRjeE5nb2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdZM1Z5Y21WdWRDQnRZWEpuYVc0S0lDQWdJQzh2SUdWbVptVmpkR2wyWlY5dFlYSm5hVzRnUFNCamIyeHNZWFJsY21Gc0xtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOekUzQ2lBZ0lDQXZMeUJwWmlCd2JteGZjbVZ6ZFd4MExtbHpYM0J5YjJacGRDNXVZWFJwZG1VNkNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllaUJwYzE5c2FYRjFhV1JoZEdGaWJHVmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pjeE9Bb2dJQ0FnTHk4Z1pXWm1aV04wYVhabFgyMWhjbWRwYmlBclBTQndibXhmY21WemRXeDBMblZ1Y21WaGJHbDZaV1JmY0c1c0xtNWhkR2wyWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2dwcGMxOXNhWEYxYVdSaGRHRmliR1ZmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TnpJMkxUY3lPQW9nSUNBZ0x5OGdJeUJEWVd4amRXeGhkR1VnYldGeVoybHVJSEpoZEdsdkNpQWdJQ0F2THlBaklHMWhjbWRwYmw5eVlYUnBieUE5SUNobFptWmxZM1JwZG1WZmJXRnlaMmx1SUNvZ01UQXdNREFwSUM4Z2MybDZaUW9nSUNBZ0x5OGdiV0Z5WjJsdVgzSmhkR2x2SUQwZ0tHVm1abVZqZEdsMlpWOXRZWEpuYVc0Z0tpQXhNREF3TUNrZ0x5OGdjMmw2WlM1dVlYUnBkbVVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklERXdNREF3Q2lBZ0lDQXFDaUFnSUNCa2FXY2dNZ29nSUNBZ1luUnZhUW9nSUNBZ0x3b2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOek13TFRjek1Rb2dJQ0FnTHk4Z0l5Qk1hWEYxYVdSaGRHRmliR1VnYVdZZ1ltVnNiM2NnYldGcGJuUmxibUZ1WTJVZ2JXRnlaMmx1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRbTl2YkNodFlYSm5hVzVmY21GMGFXOGdQQ0J6Wld4bUxtMWhhVzUwWlc1aGJtTmxYMjFoY21kcGJpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaWJXRnBiblJsYm1GdVkyVmZiV0Z5WjJsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTFoYVc1MFpXNWhibU5sWDIxaGNtZHBiaUJsZUdsemRITUtJQ0FnSUR3S0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2dwcGMxOXNhWEYxYVdSaGRHRmliR1ZmWVdaMFpYSmZhVzVzYVc1bFpGOXdaWEp3WlhSMVlXeHpYMjFoY210bGRDNVFaWEp3WlhSMVlXeHpUV0Z5YTJWMExtbHpYMnhwY1hWcFpHRjBZV0pzWlVBNE9nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOamt3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtbHpYMnhwY1hWcFpHRjBZV0pzWlY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamN5TUFvZ0lDQWdMeThnYVdZZ1pXWm1aV04wYVhabFgyMWhjbWRwYmlBK0lIQnViRjl5WlhOMWJIUXVkVzV5WldGc2FYcGxaRjl3Ym13dWJtRjBhWFpsT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdaR2xuSURFS0lDQWdJRHdLSUNBZ0lHSjZJR2x6WDJ4cGNYVnBaR0YwWVdKc1pWOWxiSE5sWDJKdlpIbEFOUW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TnpJeENpQWdJQ0F2THlCbFptWmxZM1JwZG1WZmJXRnlaMmx1SUMwOUlIQnViRjl5WlhOMWJIUXVkVzV5WldGc2FYcGxaRjl3Ym13dWJtRjBhWFpsQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXRDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdhWE5mYkdseGRXbGtZWFJoWW14bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTndvS2FYTmZiR2x4ZFdsa1lYUmhZbXhsWDJWc2MyVmZZbTlrZVVBMU9nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOekl6TFRjeU5Bb2dJQ0FnTHk4Z0l5Qk9aV2RoZEdsMlpTQnRZWEpuYVc0Z1BTQmtaV1pwYm1sMFpXeDVJR3hwY1hWcFpHRjBZV0pzWlFvZ0lDQWdMeThnY21WMGRYSnVJRUp2YjJ3b1ZISjFaU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGd3Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvMk9UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lpQnBjMTlzYVhGMWFXUmhkR0ZpYkdWZllXWjBaWEpmYVc1c2FXNWxaRjl3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzVRWlhKd1pYUjFZV3h6VFdGeWEyVjBMbWx6WDJ4cGNYVnBaR0YwWVdKc1pVQTRDZ29LTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdVVHVnljR1YwZFdGc2MwMWhjbXRsZEM1blpYUmZjRzl6YVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmNHOXphWFJwYjI0NkNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzNNek1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOek00Q2lBZ0lDQXZMeUJoYzNObGNuUWdjRzl6YVhScGIyNWZhMlY1SUdsdUlITmxiR1l1Y0c5emFYUnBiMjV6TENBaVVHOXphWFJwYjI0Z2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z01IZzNNRFptTnpNMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRkJ2YzJsMGFXOXVJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TnpNNUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXdiM05wZEdsdmJuTmJjRzl6YVhScGIyNWZhMlY1WFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk56TXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNVFaWEp3WlhSMVlXeHpUV0Z5YTJWMExtZGxkRjl0WVhKclpYUmZjM1JoZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYldGeWEyVjBYM04wWVhSek9nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOelEwQ2lBZ0lDQXZMeUJqZFhKeVpXNTBYM0J5YVdObElEMGdjMlZzWmk1ZloyVjBYMjl5WVdOc1pWOXdjbWxqWlNncENpQWdJQ0JqWVd4c2MzVmlJRjluWlhSZmIzSmhZMnhsWDNCeWFXTmxDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8zTlRBS0lDQWdJQzh2SUhSdmRHRnNYM0J2YzJsMGFXOXVjejFoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzQnZjMmwwYVc5dWN5a3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0luUnZkR0ZzWDNCdmMybDBhVzl1Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5d2IzTnBkR2x2Ym5NZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvM05URUtJQ0FnSUM4dklHRmpkR2wyWlY5d2IzTnBkR2x2Ym5NOVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1aFkzUnBkbVZmY0c5emFYUnBiMjV6S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0poWTNScGRtVmZjRzl6YVhScGIyNXpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GamRHbDJaVjl3YjNOcGRHbHZibk1nWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8zTlRJS0lDQWdJQzh2SUhSdmRHRnNYM1p2YkhWdFpUMWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDNadmJIVnRaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdJblJ2ZEdGc1gzWnZiSFZ0WlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5MmIyeDFiV1VnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8zTlRNS0lDQWdJQzh2SUhSdmRHRnNYMnh2Ym1kZmIyazlZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5c2IyNW5YMjlwS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOXNiMjVuWDI5cElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyeHZibWRmYjJrZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvM05UUUtJQ0FnSUM4dklIUnZkR0ZzWDNOb2IzSjBYMjlwUFdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5MFlXeGZjMmh2Y25SZmIya3BMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZkR0ZzWDNOb2IzSjBYMjlwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNOb2IzSjBYMjlwSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TnpVMUNpQWdJQ0F2THlCMGIzUmhiRjlzYVhGMWFXUmhkR2x2Ym5NOVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjlzYVhGMWFXUmhkR2x2Ym5NcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKMGIzUmhiRjlzYVhGMWFXUmhkR2x2Ym5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmJHbHhkV2xrWVhScGIyNXpJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOelUyQ2lBZ0lDQXZMeUIwYjNSaGJGOW1aV1Z6WDJOdmJHeGxZM1JsWkQxaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYMlpsWlhOZlkyOXNiR1ZqZEdWa0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMGIzUmhiRjltWldWelgyTnZiR3hsWTNSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOW1aV1Z6WDJOdmJHeGxZM1JsWkNCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pjMU53b2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5d2NtbGpaVDFoY21NMExsVkpiblEyTkNoamRYSnlaVzUwWDNCeWFXTmxLU3dLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOelEyTFRjME53b2dJQ0FnTHk4Z0l5QkhaWFFnWm5WdVpHbHVaeUJ5WVhSbElHWnliMjBnY0c5dmJDQW9kMjkxYkdRZ1ltVWdhVzV1WlhJZ2RISmhibk5oWTNScGIyNHBDaUFnSUNBdkx5Qm1kVzVrYVc1blgzSmhkR1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvM05UZ0tJQ0FnSUM4dklHWjFibVJwYm1kZmNtRjBaVDFoY21NMExsVkpiblEyTkNobWRXNWthVzVuWDNKaGRHVXBMQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TnpRNUxUYzFPUW9nSUNBZ0x5OGdjbVYwZFhKdUlFMWhjbXRsZEZOMFlYUnpLQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYM0J2YzJsMGFXOXVjejFoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzQnZjMmwwYVc5dWN5a3NDaUFnSUNBdkx5QWdJQ0FnWVdOMGFYWmxYM0J2YzJsMGFXOXVjejFoY21NMExsVkpiblEyTkNoelpXeG1MbUZqZEdsMlpWOXdiM05wZEdsdmJuTXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYM1p2YkhWdFpUMWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDNadmJIVnRaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3hmYkc5dVoxOXZhVDFoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gyeHZibWRmYjJrcExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gzTm9iM0owWDI5cFBXRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHOTBZV3hmYzJodmNuUmZiMmtwTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDJ4cGNYVnBaR0YwYVc5dWN6MWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR0YwYVc5dWN5a3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZabVZsYzE5amIyeHNaV04wWldROVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjltWldWelgyTnZiR3hsWTNSbFpDa3NDaUFnSUNBdkx5QWdJQ0FnWTNWeWNtVnVkRjl3Y21salpUMWhjbU0wTGxWSmJuUTJOQ2hqZFhKeVpXNTBYM0J5YVdObEtTd0tJQ0FnSUM4dklDQWdJQ0JtZFc1a2FXNW5YM0poZEdVOVlYSmpOQzVWU1c1ME5qUW9ablZ1WkdsdVoxOXlZWFJsS1N3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOelF4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzVRWlhKd1pYUjFZV3h6VFdGeWEyVjBMbWRsZEY5amRYSnlaVzUwWDNCeWFXTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyTjFjbkpsYm5SZmNISnBZMlU2Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvM05qUUtJQ0FnSUM4dklIQnlhV05sSUQwZ2MyVnNaaTVmWjJWMFgyOXlZV05zWlY5d2NtbGpaU2dwQ2lBZ0lDQmpZV3hzYzNWaUlGOW5aWFJmYjNKaFkyeGxYM0J5YVdObENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzNOalVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2h3Y21salpTa0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamMyTVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1VUdWeWNHVjBkV0ZzYzAxaGNtdGxkQzVqWVd4amRXeGhkR1ZmY21WeGRXbHlaV1JmYldGeVoybHVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJGc1kzVnNZWFJsWDNKbGNYVnBjbVZrWDIxaGNtZHBiam9LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pjMk53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzNPRE1LSUNBZ0lDOHZJRzFoY21kcGJpQTlJQ2h6YVhwbExtNWhkR2wyWlNBcUlITmxiR1l1YkdWMlpYSmhaMlZmY0hKbFkybHphVzl1S1NBdkx5QnNaWFpsY21GblpTNXVZWFJwZG1VS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU9DQXZMeUFpYkdWMlpYSmhaMlZmY0hKbFkybHphVzl1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteGxkbVZ5WVdkbFgzQnlaV05wYzJsdmJpQmxlR2x6ZEhNS0lDQWdJQ29LSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lDOEtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZOemcwQ2lBZ0lDQXZMeUJwWmlCdFlYSm5hVzRnUENCelpXeG1MbTFwYmw5dFlYSm5hVzQ2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbTFwYmw5dFlYSm5hVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHVYMjFoY21kcGJpQmxlR2x6ZEhNS0lDQWdJRHdLSUNBZ0lHSjZJR05oYkdOMWJHRjBaVjl5WlhGMWFYSmxaRjl0WVhKbmFXNWZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzNPRFVLSUNBZ0lDOHZJRzFoY21kcGJpQTlJSE5sYkdZdWJXbHVYMjFoY21kcGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTRJQzh2SUNKdGFXNWZiV0Z5WjJsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldsdVgyMWhjbWRwYmlCbGVHbHpkSE1LQ21OaGJHTjFiR0YwWlY5eVpYRjFhWEpsWkY5dFlYSm5hVzVmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TnpnMkNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb2JXRnlaMmx1S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvM05qY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExsQmxjbkJsZEhWaGJITk5ZWEpyWlhRdVkyRnNZM1ZzWVhSbFgyeHBjWFZwWkdGMGFXOXVYM0J5YVdObFgzWnBaWGRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwallXeGpkV3hoZEdWZmJHbHhkV2xrWVhScGIyNWZjSEpwWTJWZmRtbGxkem9LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pjNE9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T0RBNUNpQWdJQ0F2THlCcGMxOXNiMjVuTG01aGRHbDJaU3dLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZPREV3Q2lBZ0lDQXZMeUJsYm5SeWVWOXdjbWxqWlM1dVlYUnBkbVVzQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamd4TVFvZ0lDQWdMeThnWTI5c2JHRjBaWEpoYkM1dVlYUnBkbVVzQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamd4TWdvZ0lDQWdMeThnYzJsNlpTNXVZWFJwZG1Vc0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pnd09DMDRNVE1LSUNBZ0lDOHZJR3hwY1Y5d2NtbGpaU0E5SUhObGJHWXVYMk5oYkdOMWJHRjBaVjlzYVhGMWFXUmhkR2x2Ymw5d2NtbGpaU2dLSUNBZ0lDOHZJQ0FnSUNCcGMxOXNiMjVuTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCbGJuUnllVjl3Y21salpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZMjlzYkdGMFpYSmhiQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnYzJsNlpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBcENpQWdJQ0JqWVd4c2MzVmlJRjlqWVd4amRXeGhkR1ZmYkdseGRXbGtZWFJwYjI1ZmNISnBZMlVLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pneE5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtHeHBjVjl3Y21salpTa0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamM0T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1VUdWeWNHVjBkV0ZzYzAxaGNtdGxkQzV6WlhSZmJHVjJaWEpoWjJWZmJHbHRhWFJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYMnhsZG1WeVlXZGxYMnhwYldsMGN6b0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamd4T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvNE1qRUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzRzSUNKUGJteDVJR0ZrYldsdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGa2JXbHVDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG80TWpJS0lDQWdJQzh2SUdGemMyVnlkQ0J0YVc1ZmJHVjJMbTVoZEdsMlpTQStQU0F4TURBc0lDSk5hVzRnTVhnZ2JHVjJaWEpoWjJVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEF3Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFMXBiaUF4ZUNCc1pYWmxjbUZuWlFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk9ESXpDaUFnSUNBdkx5QmhjM05sY25RZ2JXRjRYMnhsZGk1dVlYUnBkbVVnUEQwZ01UQXdNREFzSUNKTllYZ2dNVEF3ZUNCc1pYWmxjbUZuWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJREV3TURBd0NpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRTFoZUNBeE1EQjRJR3hsZG1WeVlXZGxDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG80TWpRS0lDQWdJQzh2SUhObGJHWXViV2x1WDJ4bGRtVnlZV2RsSUQwZ2JXbHVYMnhsZGk1dVlYUnBkbVVLSUNBZ0lHSjVkR1ZqSURJMElDOHZJQ0p0YVc1ZmJHVjJaWEpoWjJVaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvNE1qVUtJQ0FnSUM4dklITmxiR1l1YldGNFgyeGxkbVZ5WVdkbElEMGdiV0Y0WDJ4bGRpNXVZWFJwZG1VS0lDQWdJR0o1ZEdWaklESTFJQzh2SUNKdFlYaGZiR1YyWlhKaFoyVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T0RFNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1UVpYSndaWFIxWVd4elRXRnlhMlYwTG5ObGRGOW1aV1Z6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYMlpsWlhNNkNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzRNamdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk9ETTJDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TENBaVQyNXNlU0JoWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCaFpHMXBiZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T0RNM0NpQWdJQ0F2THlCaGMzTmxjblFnYjNCbGJsOW1aV1V1Ym1GMGFYWmxJRHc5SURFd01Dd2dJazFoZUNBeEpTQnZjR1Z1SUdabFpTSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXdNQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCTllYZ2dNU1VnYjNCbGJpQm1aV1VLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pnek9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdOc2IzTmxYMlpsWlM1dVlYUnBkbVVnUEQwZ01UQXdMQ0FpVFdGNElERWxJR05zYjNObElHWmxaU0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3TUFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWGdnTVNVZ1kyeHZjMlVnWm1WbENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzRNemtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnNhWEYxYVdSaGRHbHZibDltWldVdWJtRjBhWFpsSUR3OUlEVXdNQ3dnSWsxaGVDQTFKU0JzYVhGMWFXUmhkR2x2YmlCbVpXVWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTFNREFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1RXRjRJRFVsSUd4cGNYVnBaR0YwYVc5dUlHWmxaUW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T0RRd0NpQWdJQ0F2THlCelpXeG1MbTl3Wlc1ZlptVmxJRDBnYjNCbGJsOW1aV1V1Ym1GMGFYWmxDaUFnSUNCaWVYUmxZeUF5TmlBdkx5QWliM0JsYmw5bVpXVWlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzROREVLSUNBZ0lDOHZJSE5sYkdZdVkyeHZjMlZmWm1WbElEMGdZMnh2YzJWZlptVmxMbTVoZEdsMlpRb2dJQ0FnWW5sMFpXTWdNamNnTHk4Z0ltTnNiM05sWDJabFpTSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qZzBNZ29nSUNBZ0x5OGdjMlZzWmk1c2FYRjFhV1JoZEdsdmJsOW1aV1VnUFNCc2FYRjFhV1JoZEdsdmJsOW1aV1V1Ym1GMGFYWmxDaUFnSUNCaWVYUmxZeUF6TUNBdkx5QWliR2x4ZFdsa1lYUnBiMjVmWm1WbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamd5T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVNE1Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1VUdWeWNHVjBkV0ZzYzAxaGNtdGxkQzV6WlhSZmJXRnlaMmx1WDNKbGNYVnBjbVZ0Wlc1MGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5dFlYSm5hVzVmY21WeGRXbHlaVzFsYm5Sek9nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZPRFExQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pnMU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaXdnSWs5dWJIa2dZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNEtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamcxTXdvZ0lDQWdMeThnWVhOelpYSjBJR2x1YVhScFlXd3VibUYwYVhabElENGdiV0ZwYm5SbGJtRnVZMlV1Ym1GMGFYWmxMQ0FpU1c1cGRHbGhiQ0ErSUcxaGFXNTBaVzVoYm1ObElnb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd01nb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJRWx1YVhScFlXd2dQaUJ0WVdsdWRHVnVZVzVqWlFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk9EVTBDaUFnSUNBdkx5QmhjM05sY25RZ2JXRnBiblJsYm1GdVkyVXVibUYwYVhabElENDlJREV3TUN3Z0lrMXBiaUF4SlNCdFlXbHVkR1Z1WVc1alpTSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TURBS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUV2x1SURFbElHMWhhVzUwWlc1aGJtTmxDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG80TlRVS0lDQWdJQzh2SUhObGJHWXVhVzVwZEdsaGJGOXRZWEpuYVc0Z1BTQnBibWwwYVdGc0xtNWhkR2wyWlFvZ0lDQWdZbmwwWldNZ016UWdMeThnSW1sdWFYUnBZV3hmYldGeVoybHVJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZPRFUyQ2lBZ0lDQXZMeUJ6Wld4bUxtMWhhVzUwWlc1aGJtTmxYMjFoY21kcGJpQTlJRzFoYVc1MFpXNWhibU5sTG01aGRHbDJaUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbTFoYVc1MFpXNWhibU5sWDIxaGNtZHBiaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvNE5EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExsQmxjbkJsZEhWaGJITk5ZWEpyWlhRdWRYQmtZWFJsWDNCdmIyeGZZWEJ3WDJsa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFgzQnZiMnhmWVhCd1gybGtPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T0RVNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pnMk1nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaXdnSWs5dWJIa2dZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNEtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamcyTXdvZ0lDQWdMeThnYzJWc1ppNXdaWEp3YzE5d2IyOXNYMkZ3Y0Y5cFpDQTlJSEJ2YjJ4ZllYQndYMmxrTG01aGRHbDJaUW9nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJbkJsY25CelgzQnZiMnhmWVhCd1gybGtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pnMU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VTRNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdVVHVnljR1YwZFdGc2MwMWhjbXRsZEM1MGNtRnVjMlpsY2w5aFpHMXBibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SeVlXNXpabVZ5WDJGa2JXbHVPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T0RZMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qZzJPUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYml3Z0lrOXViSGtnWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lXUnRhVzRLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pnM01Bb2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJpQTlJRzVsZDE5aFpHMXBiaTV1WVhScGRtVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qZzJOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelU0TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVVR1Z5Y0dWMGRXRnNjMDFoY210bGRDNXdZWFZ6WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQmhkWE5sT2dvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk9EYzJDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TENBaVQyNXNlU0JoWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCaFpHMXBiZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T0RjM0NpQWdJQ0F2THlCelpXeG1MbWx6WDNCaGRYTmxaQ0E5SUZSeWRXVUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltbHpYM0JoZFhObFpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZPRGN6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzVRWlhKd1pYUjFZV3h6VFdGeWEyVjBMblZ1Y0dGMWMyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxYm5CaGRYTmxPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T0RnekNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMQ0FpVDI1c2VTQmhaRzFwYmlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoWkcxcGJnb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZPRGcwQ2lBZ0lDQXZMeUJ6Wld4bUxtbHpYM0JoZFhObFpDQTlJRVpoYkhObENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qZzRNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelU0TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVVR1Z5Y0dWMGRXRnNjMDFoY210bGRDNW5aWFJmYjNCbGNtRjBhVzl1WVd4ZmMzUmhkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZiM0JsY21GMGFXOXVZV3hmYzNSaGRITTZDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG80T1RnS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtHOXdMbUpoYkdGdVkyVW9SMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5a3BMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHSmhiR0Z1WTJVS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qZzVPUW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXZjR1Z5WVhScGIyNWhiRjl5WlhObGNuWmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnZjR1Z5WVhScGIyNWhiRjl5WlhObGNuWmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05d1pYSmhkR2x2Ym1Gc1gzSmxjMlZ5ZG1VZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvNU1EQUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWNtVnpaWEoyWlY5MFlYSm5aWFFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0p5WlhObGNuWmxYM1JoY21kbGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV5WlhObGNuWmxYM1JoY21kbGRDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qZzRPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzVRWlhKd1pYUjFZV3h6VFdGeWEyVjBMbWRsZEY5amRYSnlaVzUwWDJabFpWOXpjR3hwZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjlqZFhKeVpXNTBYMlpsWlY5emNHeHBkRG9LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2preE1Rb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5aVlXeGhibU5sSUQwZ2IzQXVZbUZzWVc1alpTaEhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOektRb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdKaGJHRnVZMlVLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T1RFekNpQWdJQ0F2THlCcFppQmpkWEp5Wlc1MFgySmhiR0Z1WTJVZ1BDQnpaV3htTG0xcGJsOXZjR1Z5WVhScGIyNWhiRjlpWVd4aGJtTmxPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREU1SUM4dklDSnRhVzVmYjNCbGNtRjBhVzl1WVd4ZlltRnNZVzVqWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRhVzVmYjNCbGNtRjBhVzl1WVd4ZlltRnNZVzVqWlNCbGVHbHpkSE1LSUNBZ0lEd0tJQ0FnSUdKNklHZGxkRjlqZFhKeVpXNTBYMlpsWlY5emNHeHBkRjlsYkhObFgySnZaSGxBTXdvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk9URTBDaUFnSUNBdkx5QnlaWFIxY200Z0tHRnlZelF1VlVsdWREWTBLREV3TURBd0tTd2dZWEpqTkM1VlNXNTBOalFvTUNrcElDQWpJREV3TUM4d0lDMGdRM0pwZEdsallXd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREkzTVRBS0lDQWdJR0o1ZEdWaklETTFJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvS1oyVjBYMk4xY25KbGJuUmZabVZsWDNOd2JHbDBYMkZtZEdWeVgybHViR2x1WldSZmNHVnljR1YwZFdGc2MxOXRZWEpyWlhRdVVHVnljR1YwZFdGc2MwMWhjbXRsZEM1blpYUmZZM1Z5Y21WdWRGOW1aV1ZmYzNCc2FYUkFOam9LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2prd013b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJmWTNWeWNtVnVkRjltWldWZmMzQnNhWFJmWld4elpWOWliMlI1UURNNkNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzVNVFVLSUNBZ0lDOHZJR1ZzYVdZZ1kzVnljbVZ1ZEY5aVlXeGhibU5sSUR3Z2MyVnNaaTV5WlhObGNuWmxYM1JoY21kbGREb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWNtVnpaWEoyWlY5MFlYSm5aWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVnpaWEoyWlY5MFlYSm5aWFFnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWW5vZ1oyVjBYMk4xY25KbGJuUmZabVZsWDNOd2JHbDBYMlZzYzJWZlltOWtlVUExQ2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvNU1UWUtJQ0FnSUM4dklISmxkSFZ5YmlBb1lYSmpOQzVWU1c1ME5qUW9OVEF3TUNrc0lHRnlZelF1VlVsdWREWTBLRFV3TURBcEtTQWdJeUExTUM4MU1DQXRJRUoxYVd4a2FXNW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF4TXpnNENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qa3dNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCblpYUmZZM1Z5Y21WdWRGOW1aV1ZmYzNCc2FYUmZZV1owWlhKZmFXNXNhVzVsWkY5d1pYSndaWFIxWVd4elgyMWhjbXRsZEM1UVpYSndaWFIxWVd4elRXRnlhMlYwTG1kbGRGOWpkWEp5Wlc1MFgyWmxaVjl6Y0d4cGRFQTJDZ3BuWlhSZlkzVnljbVZ1ZEY5bVpXVmZjM0JzYVhSZlpXeHpaVjlpYjJSNVFEVTZDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG81TVRnS0lDQWdJQzh2SUhKbGRIVnliaUFvWVhKak5DNVZTVzUwTmpRb01UQXdNQ2tzSUdGeVl6UXVWVWx1ZERZMEtEa3dNREFwS1NBZ0l5QXhNQzg1TUNBdElFaGxZV3gwYUhrS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnd01EQXdNREF3TURBd01EQXdNMlU0SURCNE1EQXdNREF3TURBd01EQXdNak15T0FvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk9UQXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdkbGRGOWpkWEp5Wlc1MFgyWmxaVjl6Y0d4cGRGOWhablJsY2w5cGJteHBibVZrWDNCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTGxCbGNuQmxkSFZoYkhOTllYSnJaWFF1WjJWMFgyTjFjbkpsYm5SZlptVmxYM053YkdsMFFEWUtDZ292THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1UVpYSndaWFIxWVd4elRXRnlhMlYwTG5ObGRGOW1aV1ZmY205MWRHbHVaMTkwYUhKbGMyaHZiR1J6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYMlpsWlY5eWIzVjBhVzVuWDNSb2NtVnphRzlzWkhNNkNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzVNakFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T1RNMkNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMQ0FpVDI1c2VTQmhaRzFwYmlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoWkcxcGJnb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZPVE0zQ2lBZ0lDQXZMeUJoYzNObGNuUWdiV2x1WDI5d1pYSmhkR2x2Ym1Gc0xtNWhkR2wyWlNBK1BTQXhNREJmTURBd0xDQWlUV2x1SURBdU1TQkJURWRQSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXdNREF3TUFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5hVzRnTUM0eElFRk1SMDhLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2prek9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbGMyVnlkbVZmZEdGeVoyVjBMbTVoZEdsMlpTQStJRzFwYmw5dmNHVnlZWFJwYjI1aGJDNXVZWFJwZG1Vc0lDSlVZWEpuWlhRZ1BpQnRhVzRpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHRnlaMlYwSUQ0Z2JXbHVDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG81TkRBS0lDQWdJQzh2SUhObGJHWXViV2x1WDI5d1pYSmhkR2x2Ym1Gc1gySmhiR0Z1WTJVZ1BTQnRhVzVmYjNCbGNtRjBhVzl1WVd3dWJtRjBhWFpsQ2lBZ0lDQmllWFJsWXlBeE9TQXZMeUFpYldsdVgyOXdaWEpoZEdsdmJtRnNYMkpoYkdGdVkyVWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzVOREVLSUNBZ0lDOHZJSE5sYkdZdWNtVnpaWEoyWlY5MFlYSm5aWFFnUFNCeVpYTmxjblpsWDNSaGNtZGxkQzV1WVhScGRtVUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSnlaWE5sY25abFgzUmhjbWRsZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzVNakFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbEJsY25CbGRIVmhiSE5OWVhKclpYUXVZMkZzWTNWc1lYUmxYM0J1YkNocGMxOXNiMjVuT2lCaWVYUmxjeXdnWlc1MGNubGZjSEpwWTJVNklHSjVkR1Z6TENCamRYSnlaVzUwWDNCeWFXTmxPaUJpZVhSbGN5d2djMmw2WlRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1UVpYSndaWFIxWVd4elRXRnlhMlYwTG1OaGJHTjFiR0YwWlY5d2JtdzZDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8yTXpZdE5qUXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCallXeGpkV3hoZEdWZmNHNXNLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnYVhOZmJHOXVaem9nUW05dmJDd0tJQ0FnSUM4dklDQWdJQ0JsYm5SeWVWOXdjbWxqWlRvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWTNWeWNtVnVkRjl3Y21salpUb2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2MybDZaVG9nWVhKak5DNVZTVzUwTmpRc0NpQWdJQ0F2THlBcElDMCtJRkJ2YzJsMGFXOXVVRzVNT2dvZ0lDQWdjSEp2ZEc4Z05DQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNHNGdOQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TmpVMkNpQWdJQ0F2THlCd2Jtd2dQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8yTlRrS0lDQWdJQzh2SUdsbUlHbHpYMnh2Ym1jdWJtRjBhWFpsT2dvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllaUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzVRWlhKd1pYUjFZV3h6VFdGeWEyVjBMbU5oYkdOMWJHRjBaVjl3Ym14ZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalkyTUMwMk5qRUtJQ0FnSUM4dklDTWdURzl1WnlCUWJrd2dQU0FvWTNWeWNtVnVkQ0F0SUdWdWRISjVLU0F2SUdWdWRISjVJQ29nYzJsNlpRb2dJQ0FnTHk4Z2FXWWdZM1Z5Y21WdWRGOXdjbWxqWlM1dVlYUnBkbVVnUGowZ1pXNTBjbmxmY0hKcFkyVXVibUYwYVhabE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJRDQ5Q2lBZ0lDQmllaUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzVRWlhKd1pYUjFZV3h6VFdGeWEyVjBMbU5oYkdOMWJHRjBaVjl3Ym14ZlpXeHpaVjlpYjJSNVFETUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalkyTWdvZ0lDQWdMeThnY0hKcFkyVmZaR2xtWmlBOUlHTjFjbkpsYm5SZmNISnBZMlV1Ym1GMGFYWmxJQzBnWlc1MGNubGZjSEpwWTJVdWJtRjBhWFpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ0xRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzJOak1LSUNBZ0lDOHZJR2x6WDNCeWIyWnBkQ0E5SUZSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0NuQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExsQmxjbkJsZEhWaGJITk5ZWEpyWlhRdVkyRnNZM1ZzWVhSbFgzQnViRjloWm5SbGNsOXBabDlsYkhObFFEazZDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8yTnpZdE5qYzRDaUFnSUNBdkx5QWpJRU5oYkdOMWJHRjBaU0JRYmt3Z2FXNGdRVXhIVHdvZ0lDQWdMeThnSXlCd2Jtd2dQU0FvY0hKcFkyVmZaR2xtWmlBcUlITnBlbVVwSUM4Z1pXNTBjbmxmY0hKcFkyVUtJQ0FnSUM4dklHbG1JR1Z1ZEhKNVgzQnlhV05sTG01aGRHbDJaU0ErSURBNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQmllaUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzVRWlhKd1pYUjFZV3h6VFdGeWEyVjBMbU5oYkdOMWJHRjBaVjl3Ym14ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5qYzVDaUFnSUNBdkx5QndibXdnUFNBb2NISnBZMlZmWkdsbVppQXFJSE5wZW1VdWJtRjBhWFpsS1NBdkx5QmxiblJ5ZVY5d2NtbGpaUzV1WVhScGRtVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5SdmFRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJQ29LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNBdkNpQWdJQ0JtY21GdFpWOWlkWEo1SURVS0NuQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExsQmxjbkJsZEhWaGJITk5ZWEpyWlhRdVkyRnNZM1ZzWVhSbFgzQnViRjloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TmpneUNpQWdJQ0F2THlCMWJuSmxZV3hwZW1Wa1gzQnViRDFoY21NMExsVkpiblEyTkNod2Jtd3BMQW9nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalk0TXdvZ0lDQWdMeThnYVhOZmNISnZabWwwUFVKdmIyd29hWE5mY0hKdlptbDBLU3dLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCelpYUmlhWFFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pZNE1TMDJPRGdLSUNBZ0lDOHZJSEpsZEhWeWJpQlFiM05wZEdsdmJsQnVUQ2dLSUNBZ0lDOHZJQ0FnSUNCMWJuSmxZV3hwZW1Wa1gzQnViRDFoY21NMExsVkpiblEyTkNod2Jtd3BMQW9nSUNBZ0x5OGdJQ0FnSUdselgzQnliMlpwZEQxQ2IyOXNLR2x6WDNCeWIyWnBkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1puVnVaR2x1WjE5d2JtdzlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdablZ1WkdsdVoxOXBjMTl3YjNOcGRHbDJaVDFDYjI5c0tGUnlkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHeHBjWFZwWkdGMGFXOXVYM0J5YVdObFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHMWhjbWRwYmw5eVlYUnBiejFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbkJsY25CbGRIVmhiSE5mYldGeWEyVjBMbEJsY25CbGRIVmhiSE5OWVhKclpYUXVZMkZzWTNWc1lYUmxYM0J1YkY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPalkyTlFvZ0lDQWdMeThnY0hKcFkyVmZaR2xtWmlBOUlHVnVkSEo1WDNCeWFXTmxMbTVoZEdsMlpTQXRJR04xY25KbGJuUmZjSEpwWTJVdWJtRjBhWFpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ0xRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzJOallLSUNBZ0lDOHZJR2x6WDNCeWIyWnBkQ0E5SUVaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpSUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTGxCbGNuQmxkSFZoYkhOTllYSnJaWFF1WTJGc1kzVnNZWFJsWDNCdWJGOWhablJsY2w5cFpsOWxiSE5sUURrS0NuQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExsQmxjbkJsZEhWaGJITk5ZWEpyWlhRdVkyRnNZM1ZzWVhSbFgzQnViRjlsYkhObFgySnZaSGxBTlRvS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qWTJPQzAyTmprS0lDQWdJQzh2SUNNZ1UyaHZjblFnVUc1TUlEMGdLR1Z1ZEhKNUlDMGdZM1Z5Y21WdWRDa2dMeUJsYm5SeWVTQXFJSE5wZW1VS0lDQWdJQzh2SUdsbUlHVnVkSEo1WDNCeWFXTmxMbTVoZEdsMlpTQStQU0JqZFhKeVpXNTBYM0J5YVdObExtNWhkR2wyWlRvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQStQUW9nSUNBZ1lub2djR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVVR1Z5Y0dWMGRXRnNjMDFoY210bGRDNWpZV3hqZFd4aGRHVmZjRzVzWDJWc2MyVmZZbTlrZVVBM0NpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzJOekFLSUNBZ0lDOHZJSEJ5YVdObFgyUnBabVlnUFNCbGJuUnllVjl3Y21salpTNXVZWFJwZG1VZ0xTQmpkWEp5Wlc1MFgzQnlhV05sTG01aGRHbDJaUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnY0dWeWNHVjBkV0ZzYzE5dFlYSnJaWFF1Y0hrNk5qY3hDaUFnSUNBdkx5QnBjMTl3Y205bWFYUWdQU0JVY25WbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmlJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbEJsY25CbGRIVmhiSE5OWVhKclpYUXVZMkZzWTNWc1lYUmxYM0J1YkY5aFpuUmxjbDlwWmw5bGJITmxRRGtLQ25CbGNuQmxkSFZoYkhOZmJXRnlhMlYwTGxCbGNuQmxkSFZoYkhOTllYSnJaWFF1WTJGc1kzVnNZWFJsWDNCdWJGOWxiSE5sWDJKdlpIbEFOem9LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pZM013b2dJQ0FnTHk4Z2NISnBZMlZmWkdsbVppQTlJR04xY25KbGJuUmZjSEpwWTJVdWJtRjBhWFpsSUMwZ1pXNTBjbmxmY0hKcFkyVXVibUYwYVhabENpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdMUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG8yTnpRS0lDQWdJQzh2SUdselgzQnliMlpwZENBOUlFWmhiSE5sQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCaUlIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExsQmxjbkJsZEhWaGJITk5ZWEpyWlhRdVkyRnNZM1ZzWVhSbFgzQnViRjloWm5SbGNsOXBabDlsYkhObFFEa0tDZ292THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1UVpYSndaWFIxWVd4elRXRnlhMlYwTGw5eWIzVjBaVjltWldVb2RHOTBZV3hmWm1WbE9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncGZjbTkxZEdWZlptVmxPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T1RRMkxUazBOd29nSUNBZ0x5OGdRSE4xWW5KdmRYUnBibVVLSUNBZ0lDOHZJR1JsWmlCZmNtOTFkR1ZmWm1WbEtITmxiR1lzSUhSdmRHRnNYMlpsWlRvZ1ZVbHVkRFkwS1NBdFBpQjBkWEJzWlZ0VlNXNTBOalFzSUZWSmJuUTJORjA2Q2lBZ0lDQndjbTkwYnlBeElESUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamsxTkFvZ0lDQWdMeThnWTNWeWNtVnVkRjlpWVd4aGJtTmxJRDBnYjNBdVltRnNZVzVqWlNoSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56S1FvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR0poYkdGdVkyVUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZPVFU0Q2lBZ0lDQXZMeUJwWmlCamRYSnlaVzUwWDJKaGJHRnVZMlVnUENCelpXeG1MbTFwYmw5dmNHVnlZWFJwYjI1aGJGOWlZV3hoYm1ObE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTVJQzh2SUNKdGFXNWZiM0JsY21GMGFXOXVZV3hmWW1Gc1lXNWpaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dGFXNWZiM0JsY21GMGFXOXVZV3hmWW1Gc1lXNWpaU0JsZUdsemRITUtJQ0FnSUR3S0lDQWdJR0o2SUY5eWIzVjBaVjltWldWZlpXeHpaVjlpYjJSNVFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb0tYM0p2ZFhSbFgyWmxaVjloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG81TmpnS0lDQWdJQzh2SUhOMFlXdHBibWRmWm1WbElEMGdkRzkwWVd4ZlptVmxJQzBnYjNCbGNtRjBhVzl1WVd4ZlptVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdScFp5QXhDaUFnSUNBdENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzVOekFLSUNBZ0lDOHZJSEpsZEhWeWJpQnZjR1Z5WVhScGIyNWhiRjltWldVc0lITjBZV3RwYm1kZlptVmxDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEpsZEhOMVlnb0tYM0p2ZFhSbFgyWmxaVjlsYkhObFgySnZaSGxBTWpvS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qazJNUW9nSUNBZ0x5OGdaV3hwWmlCamRYSnlaVzUwWDJKaGJHRnVZMlVnUENCelpXeG1MbkpsYzJWeWRtVmZkR0Z5WjJWME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKeVpYTmxjblpsWDNSaGNtZGxkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYTmxjblpsWDNSaGNtZGxkQ0JsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0ErQ2lBZ0lDQmllaUJmY205MWRHVmZabVZsWDJWc2MyVmZZbTlrZVVBMENpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzVOakl0T1RZekNpQWdJQ0F2THlBaklFSlZTVXhFU1U1SE9pQTFNQzgxTUNCemNHeHBkQW9nSUNBZ0x5OGdiM0JsY21GMGFXOXVZV3hmWm1WbElEMGdLSFJ2ZEdGc1gyWmxaU0FxSUhObGJHWXVZblZwYkdScGJtZGZiM0JsY21GMGFXOXVZV3hmYzJoaGNtVXBJQzh2SURFd01EQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNeklnTHk4Z0ltSjFhV3hrYVc1blgyOXdaWEpoZEdsdmJtRnNYM05vWVhKbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUoxYVd4a2FXNW5YMjl3WlhKaGRHbHZibUZzWDNOb1lYSmxJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEF3TURBS0lDQWdJQzhLSUNBZ0lHSWdYM0p2ZFhSbFgyWmxaVjloWm5SbGNsOXBabDlsYkhObFFEWUtDbDl5YjNWMFpWOW1aV1ZmWld4elpWOWliMlI1UURRNkNpQWdJQ0F2THlCd1pYSndaWFIxWVd4elgyMWhjbXRsZEM1d2VUbzVOalV0T1RZMkNpQWdJQ0F2THlBaklFaEZRVXhVU0ZrNklERXdKU0J2Y0dWeVlYUnBiMjVoYkN3Z09UQWxJSE4wWVd0cGJtY0tJQ0FnSUM4dklHOXdaWEpoZEdsdmJtRnNYMlpsWlNBOUlDaDBiM1JoYkY5bVpXVWdLaUJ6Wld4bUxtaGxZV3gwYUhsZmIzQmxjbUYwYVc5dVlXeGZjMmhoY21VcElDOHZJREV3TURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ016TWdMeThnSW1obFlXeDBhSGxmYjNCbGNtRjBhVzl1WVd4ZmMyaGhjbVVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFHVmhiSFJvZVY5dmNHVnlZWFJwYjI1aGJGOXphR0Z5WlNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01EQXdDaUFnSUNBdkNpQWdJQ0JpSUY5eWIzVjBaVjltWldWZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2dvS0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVVR1Z5Y0dWMGRXRnNjMDFoY210bGRDNWZaMlYwWDI5eVlXTnNaVjl3Y21salpTZ3BJQzArSUhWcGJuUTJORG9LWDJkbGRGOXZjbUZqYkdWZmNISnBZMlU2Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRvNU56VUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbTl5WVdOc1pWOWhjSEJmYVdRZ1BpQXdMQ0FpVDNKaFkyeGxJRzV2ZENCamIyNW1hV2QxY21Wa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklESXlJQzh2SUNKdmNtRmpiR1ZmWVhCd1gybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05eVlXTnNaVjloY0hCZmFXUWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJQY21GamJHVWdibTkwSUdOdmJtWnBaM1Z5WldRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qazNOZ29nSUNBZ0x5OGdjSEpwWTJVc0lHVjRhWE4wY3lBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSZlpYaGZkV2x1ZERZMEtITmxiR1l1YjNKaFkyeGxYMkZ3Y0Y5cFpDd2dZaUpqZFhKeVpXNTBYM0J5YVdObElpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWXpOelUzTWpjeU5qVTJaVGMwTldZM01EY3lOamsyTXpZMUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2T1RjM0NpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpVDNKaFkyeGxJSEJ5YVdObElHNXZkQ0JoZG1GcGJHRmliR1VpQ2lBZ0lDQmhjM05sY25RZ0x5OGdUM0poWTJ4bElIQnlhV05sSUc1dmRDQmhkbUZwYkdGaWJHVUtJQ0FnSUM4dklIQmxjbkJsZEhWaGJITmZiV0Z5YTJWMExuQjVPamszT0FvZ0lDQWdMeThnWVhOelpYSjBJSEJ5YVdObElENGdNQ3dnSWs5eVlXTnNaU0J3Y21salpTQnBjeUI2WlhKdklnb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnVDNKaFkyeGxJSEJ5YVdObElHbHpJSHBsY204S0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qazNPUW9nSUNBZ0x5OGdjbVYwZFhKdUlIQnlhV05sQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzVRWlhKd1pYUjFZV3h6VFdGeWEyVjBMbDlqWVd4amRXeGhkR1ZmYkdseGRXbGtZWFJwYjI1ZmNISnBZMlVvYVhOZmJHOXVaem9nZFdsdWREWTBMQ0JsYm5SeWVWOXdjbWxqWlRvZ2RXbHVkRFkwTENCamIyeHNZWFJsY21Gc09pQjFhVzUwTmpRc0lITnBlbVU2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwZlkyRnNZM1ZzWVhSbFgyeHBjWFZwWkdGMGFXOXVYM0J5YVdObE9nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZPVGd4TFRrNE9Bb2dJQ0FnTHk4Z1FITjFZbkp2ZFhScGJtVUtJQ0FnSUM4dklHUmxaaUJmWTJGc1kzVnNZWFJsWDJ4cGNYVnBaR0YwYVc5dVgzQnlhV05sS0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZiRzl1WnpvZ1ltOXZiQ3dLSUNBZ0lDOHZJQ0FnSUNCbGJuUnllVjl3Y21salpUb2dWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR052Ykd4aGRHVnlZV3c2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCemFYcGxPaUJWU1c1ME5qUXNDaUFnSUNBdkx5QXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURRZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qRXdNREVLSUNBZ0lDOHZJR2xtSUhOcGVtVWdQVDBnTURvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbTU2SUY5allXeGpkV3hoZEdWZmJHbHhkV2xrWVhScGIyNWZjSEpwWTJWZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveE1EQXlDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWpZV3hqZFd4aGRHVmZiR2x4ZFdsa1lYUnBiMjVmY0hKcFkyVmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNVEF3TkMweE1EQTFDaUFnSUNBdkx5QWpJRTFoYVc1MFpXNWhibU5sSUcxaGNtZHBiaUJoYlc5MWJuUUtJQ0FnSUM4dklHMWhhVzUwWDJGdGIzVnVkQ0E5SUNoemFYcGxJQ29nYzJWc1ppNXRZV2x1ZEdWdVlXNWpaVjl0WVhKbmFXNHBJQzh2SURFd01EQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0ltMWhhVzUwWlc1aGJtTmxYMjFoY21kcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WVdsdWRHVnVZVzVqWlY5dFlYSm5hVzRnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBd01Bb2dJQ0FnTHdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pFd01EY0tJQ0FnSUM4dklHbG1JR052Ykd4aGRHVnlZV3dnUEQwZ2JXRnBiblJmWVcxdmRXNTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBK1BRb2dJQ0FnWW5vZ1gyTmhiR04xYkdGMFpWOXNhWEYxYVdSaGRHbHZibDl3Y21salpWOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhCbGNuQmxkSFZoYkhOZmJXRnlhMlYwTG5CNU9qRXdNRGd0TVRBd09Rb2dJQ0FnTHk4Z0l5QkJiSEpsWVdSNUlHeHBjWFZwWkdGMFlXSnNaUW9nSUNBZ0x5OGdjbVYwZFhKdUlHVnVkSEo1WDNCeWFXTmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BmWTJGc1kzVnNZWFJsWDJ4cGNYVnBaR0YwYVc5dVgzQnlhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pFd01URXRNVEF4TWdvZ0lDQWdMeThnSXlCQ2RXWm1aWElnWW1WbWIzSmxJR3hwY1hWcFpHRjBhVzl1Q2lBZ0lDQXZMeUJpZFdabVpYSWdQU0JqYjJ4c1lYUmxjbUZzSUMwZ2JXRnBiblJmWVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0F0Q2lBZ0lDQXZMeUJ3WlhKd1pYUjFZV3h6WDIxaGNtdGxkQzV3ZVRveE1ERTBMVEV3TVRZS0lDQWdJQzh2SUNNZ1VISnBZMlVnYlc5MlpXMWxiblFnZEdoaGRDQjBjbWxuWjJWeWN5QnNhWEYxYVdSaGRHbHZiZ29nSUNBZ0x5OGdJeUJ3Y21salpWOWphR0Z1WjJVZ1BTQW9ZblZtWm1WeUlDb2daVzUwY25sZmNISnBZMlVwSUM4Z2MybDZaUW9nSUNBZ0x5OGdjSEpwWTJWZlkyaGhibWRsSUQwZ0tHSjFabVpsY2lBcUlHVnVkSEo1WDNCeWFXTmxLU0F2THlCemFYcGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdMd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG94TURFNENpQWdJQ0F2THlCcFppQnBjMTlzYjI1bk9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JpZWlCZlkyRnNZM1ZzWVhSbFgyeHBjWFZwWkdGMGFXOXVYM0J5YVdObFgyVnNjMlZmWW05a2VVQTRDaUFnSUNBdkx5QndaWEp3WlhSMVlXeHpYMjFoY210bGRDNXdlVG94TURFNUxURXdNakFLSUNBZ0lDOHZJQ01nVEc5dVp5QnNhWEYxYVdSaGRHVnpJSGRvWlc0Z2NISnBZMlVnWkhKdmNITUtJQ0FnSUM4dklHbG1JR1Z1ZEhKNVgzQnlhV05sSUQ0Z2NISnBZMlZmWTJoaGJtZGxPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnUGdvZ0lDQWdZbm9nWDJOaGJHTjFiR0YwWlY5c2FYRjFhV1JoZEdsdmJsOXdjbWxqWlY5bGJITmxYMkp2WkhsQU53b2dJQ0FnTHk4Z2NHVnljR1YwZFdGc2MxOXRZWEpyWlhRdWNIazZNVEF5TVFvZ0lDQWdMeThnY21WMGRYSnVJR1Z1ZEhKNVgzQnlhV05sSUMwZ2NISnBZMlZmWTJoaGJtZGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0F0Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1gyTmhiR04xYkdGMFpWOXNhWEYxYVdSaGRHbHZibDl3Y21salpWOWxiSE5sWDJKdlpIbEFOem9LSUNBZ0lDOHZJSEJsY25CbGRIVmhiSE5mYldGeWEyVjBMbkI1T2pFd01qTUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTVNrZ0lDTWdUV2x1YVcxMWJTQndjbWxqWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwZlkyRnNZM1ZzWVhSbFgyeHBjWFZwWkdGMGFXOXVYM0J5YVdObFgyVnNjMlZmWW05a2VVQTRPZ29nSUNBZ0x5OGdjR1Z5Y0dWMGRXRnNjMTl0WVhKclpYUXVjSGs2TVRBeU5TMHhNREkyQ2lBZ0lDQXZMeUFqSUZOb2IzSjBJR3hwY1hWcFpHRjBaWE1nZDJobGJpQndjbWxqWlNCeWFYTmxjd29nSUNBZ0x5OGdjbVYwZFhKdUlHVnVkSEo1WDNCeWFXTmxJQ3NnY0hKcFkyVmZZMmhoYm1kbENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBR0FBRUlrRTdBaEQyQXJlSUVKaVFGRlI5OGRZQUZZV1J0YVc0RUZSOThkUTEwYjNSaGJGOXNiMjVuWDI5cERuUnZkR0ZzWDNOb2IzSjBYMjlwQVFBUVlXTjBhWFpsWDNCdmMybDBhVzl1Y3dscGMxOXdZWFZ6WldRVWRHOTBZV3hmWm1WbGMxOWpiMnhzWldOMFpXUVRiM0JsY21GMGFXOXVZV3hmY21WelpYSjJaUXB3WlhKd2MxOXdiMjlzRG5KbGMyVnlkbVZmZEdGeVoyVjBFbTFoYVc1MFpXNWhibU5sWDIxaGNtZHBiaEJ6ZEdGcmFXNW5YMk52Ym5SeVlXTjBFWEJsY25CelgzQnZiMnhmWVhCd1gybGtEM1J2ZEdGc1gzQnZjMmwwYVc5dWN3eDBiM1JoYkY5MmIyeDFiV1VTZEc5MFlXeGZiR2x4ZFdsa1lYUnBiMjV6Q20xcGJsOXRZWEpuYVc0WGJXbHVYMjl3WlhKaGRHbHZibUZzWDJKaGJHRnVZMlVFY0c5elh3WnZjbUZqYkdVTmIzSmhZMnhsWDJGd2NGOXBaQkJ1WlhoMFgzQnZjMmwwYVc5dVgybGtERzFwYmw5c1pYWmxjbUZuWlF4dFlYaGZiR1YyWlhKaFoyVUliM0JsYmw5bVpXVUpZMnh2YzJWZlptVmxFbXhsZG1WeVlXZGxYM0J5WldOcGMybHZiaEZ0YVc1ZmNHOXphWFJwYjI1ZmMybDZaUTlzYVhGMWFXUmhkR2x2Ymw5bVpXVVJiR2x4ZFdsa1lYUnZjbDl5WlhkaGNtUWFZblZwYkdScGJtZGZiM0JsY21GMGFXOXVZV3hmYzJoaGNtVVphR1ZoYkhSb2VWOXZjR1Z5WVhScGIyNWhiRjl6YUdGeVpRNXBibWwwYVdGc1gyMWhjbWRwYmdnQUFBQUFBQUFBQURFWVFBREVKeFV5QTJjbkNqSURaeWNOTWdObkp4WWlaeWNPSW1jbkZ5Tm5KdzhpWnljR0ltY3JJbWNuQkNKbkp4QWlaeWNJSW1jbkVTSm5LVElKWnljWWdXUm5KeG1CMEE5bkp4SWhCR2NuSFNFRlp5Y2FnUXBuSnh1QkNtY25Ib0ZrWnljZmdUSm5KeE1oQkdjbkN5RUZaNEFhWTNKcGRHbGpZV3hmYjNCbGNtRjBhVzl1WVd4ZmMyaGhjbVVsWnljZ2dZZ25aeWNoZ2VnSFp5Y0pJbWNuSW9IMEEyY25ESUg2QVdjbkJ5Sm5nQTl3Y21salpWOXdjbVZqYVhOcGIyNGhCR2NuSElGa1p6RWJRUUMzTVJrVVJERVlSSUlZQkU5K0tYQUVjQ25aZWdTVmJuNlBCRzFBTVhZRXVKVE5nQVJwS3JEbUJEVkVkVGtFNzRubnNRU3JVaTUzQkRneVVYMEVoWXNObHdRaEhWRE9CTko3Ti9VRWt6U0d4Z1RWeWpONEJJS2YrT0lFZDJWL2tnUUhGaldiQklUeHFtNEV0L3ZNMXdTSmpEQlpCQUg5czBJRXRBdTFZQVR5THZRL05ob0FqaGdBQ1FCYUFkQUQ3UVF5QkVzR09RWkVCbTBHOHdjTUIxd0haZ2ViQjlJSUJBaFBDSUFJbVFpeENNRUkwUWpzQ1R3QU1Sa1VNUmdVRUVNMkdnRkpGWUVnRWtRMkdnSkpGWUVnRWtRMkdnTkpGWUVnRWtRMkdnUkpGU1FTUkRZYUJVa1ZKQkpFTVFBaUtXVkVFa1FuRlU4Rlp5Y0tUd1JuSncxUEEyZE1GeWNXVEdjWEp3NU1aeWl3STBNMkdnRkpGU01TUkRZYUFra1ZKQkpFTmhvRFNSVWtFa1FpSndkbFJCUkVJaWNWWlVReUF4TkVTUmNpSnhobFJFc0JEa1FpSnhsbFJFc0JEMFJMQWhkSlRnVWlKeDFsUkVzQkRrUWlKeHhsUkVzQkMwOENDaUluRW1WRVN3RU9SQ0k0RUNNU1JDSTRDRWxQQWc5RUlqZ0hNZ29TUklnSmRrbEVJaWNhWlVSTEF3c2xDa2xPQ0U4Q1N3RUpTVTRDVGdpSUNSdE9DRTRIU3dVaVUwbExBMHNEU3dhSUNXTWlKeGRsUkVrakNDY1hUR2NXU1U0S01RQlBCQlpQQlJaUEJCWXlCeFl5QnhaTEJrOEdVRThMVUU4S1VFOEZVRThJVUU4RVVFOERVRThDVUNjalVFeFFnQUdBVUNjVVR3SlFUTDhpSnc5bFJDTUlKdzlNWnlJbkJtVkVJd2duQmt4bklpY1FaVVJQQWdnbkVFeG5RUUJVSWl0bFJBZ3JUR2V4TWdBaUp3cGxSRXNGc2dpeUJ5T3lFTElCc3lJbkNXVkVTd0lJSndsTVowc0NRUUFVc1RJQUlpY05aVVJMQkxJSXNnY2pzaEN5QWJNaUp3aGxSRXNGQ0NjSVRHY3FTd0ZRc0NORElpY0VaVVFJSndSTVowTC9weUpKZ0FCSENEWWFBVWtWSkJKRUlpY0haVVFVUkNjVVRGQkhBcjFGQVVTK1NFY0NnY2dHVXljRklrOENWQ0pUUkRFQVN3RlhDQ0JKVGdNU1JJZ0lPRWxPQWtRaVRJSEFBbE1uQlNKUEFsUkpJbE5KUVFHa1N3V0JRVnRKU3dVT1FRR05Td1JNQ1VVTkkwVVFTd1ZKVjBFSVJST0JRVnRKUlF4QkFBMUxCWUVwVzBzTkMwc0xDa1VEU3dWSlZ5a0lSUktCS1Z0SlJRc2lKeHRsUkFzbENrbEZDWWdIazBVTlJRNUxEMEVCRDBzRmdURmJTd01JU1VVUVN3Z05RUUQ0U3c1TENBbEZEMHNGU1ZjQUNFc0JWekVJU3dKWE9RaExBMWRKQ0VzRVYxRUlTd1ZYV1FoUEJsZGhDRThHU3d0UVN3aFFTeGRRVHdaUVR3VlFTeFpRVHdSUVR3TlFUd0pRVEZBbkJWQkxCMHkvU3c1QkFDdXhNZ0FpSnc1bFJFc1FGaWNGSWtzVVZJQUVZa1pOWjdJYVRMSWFzaHBMQnJJYXNoaUJCcklRc2dHeklpY0paVVJMRGdnbkNVeG5Td3RCQUJTeE1nQWlKdzFsUkVzTnNnaXlCeU95RUxJQnN5SW5CbVZFSXdrbkJreG5JaWNJWlVSTENBZ25DRXhuU1VFQUhTSXJaVVJMQ2c5QkFBb2lLMlZFU3dvSksweG5TdzRXS2t4UXNDTkRJaWNFWlVSTENnOUIvK3dpSndSbFJFc0tDU2NFVEdkQy85MGlSUTlDL3dsTEJZRXhXMGxGQ2tzRERVRUFIa3NJU3dNSlNVVVFTd2dOUVFBS1N3NUxDQWxGRDBMKzR5SkZEMEwrM1NKRkQwTCsxMHNFQ1VVTklrVVFRdjV4U3dXQlFWdEpTd1VQUVFBTFN3UUpSUTBqUlJCQy9scExCRXdKUlEwaVJSQkMvazQyR2dFVkpCSkVOaG9DU1JVa0VrUWlKd2RsUkJSRUlqZ1FJeEpFSWpnSVRCZE1Td0VQUkNJNEJ6SUtFa1N4TWdBaUp3cGxSRThDc2dpeUJ5T3lFTElCc3lpd0kwTTJHZ0VWSkJKRU5ob0NGU1FTUkNJbkIyVkVGRVFvc0NORElrY0NnQUJIQnpZYUFVa1ZKQkpFSWljSFpVUVVSSWdGNDBsT0FrUW5GRXhRUndLOVJRRkV2a2hIQW9ISUJsTW5CU0pQQWxRaVUwUWlUSUhBQWxNbkJTSlBBbFJKSWxOSlFRR0FTd09CUVZ0SlN3Y09RUUZwSTBVT1N3Wk1DVVVMU3dOSlYwRUlSUktCUVZ0SlJRbEJBQTFMQTRFcFcwc0xDMHNJQ2tVRFN3TkpWekVJUlJHQk1WdEZEa3NNUVFFWVN3MUxBd2hGRGlKRkRFc0RTVmNwQ0VVUWdTbGJTVVVJUVFBSlN3MGxDMHNIQ2tVTUlpY01aVVJMREExRUlrVUpTdzFCQUF3aUp4OWxSRXNPQ3lVS1JRa2lSUXBMRFVzSkRVRUFCMHNOU3drSlJRcExBMGxYQUFoTEFWY0lJRXNDVnprSVN3TlhTUWhMQkZkUkNFc0ZWMWtJVHdaWFlRaFBCazhHVUVzSFVFc1VVRXNWVUU4RlVFc1ZVRThFVUU4RFVFOENVRXhRSndWUVN3Vk12MHNJUVFBUnNUSUFNUUJMQ3JJSXNnY2pzaEN5QWJOTENVRUFGTEV5QUNJbkNtVkVTd3V5Q0xJSEk3SVFzZ0d6SWljUlpVUWpDQ2NSVEdjaUp3WmxSQ01KSndaTVowbEJBQmdpSzJWRVN3Y1BRUUFLSWl0bFJFc0hDU3RNWnlpd0kwTWlKd1JsUkVzSEQwSC84U0luQkdWRVN3Y0pKd1JNWjBMLzRrc05Td01OUVFBS1N3MUxBd2xGRGtMKzNTSkZEa0wrMXlKRkRrc0dDVVVMUXY2VlN3T0JRVnRKU3djUFFRQUxJMFVPU3dZSlJRdEMvbjRpUlE1TEJrd0pSUXRDL25JMkdnRVZKQkpFS0xBalF6WWFBVWtWSXhKRU5ob0NTUlVrRWtRMkdnTkpGU1FTUkRZYUJFa1ZKQkpFaUFNS0treFFzQ05EZ0FBMkdnRkpGU01TUkRZYUFra1ZKQkpFTmhvRFNSVWtFa1EyR2dSSlRnUkpGU1FTUkRZYUJVa1ZKQkpFVHdSUEJFOENUd09JQXN4SlR3SVhUZ0tCUUZNbkJTSlBBbFFpVTBFQUlDSmJTd0VJUlFGSkpRdExBaGNLSWljTVpVUU1Kd1VpVHdKVUtreFFzQ05ESWx0SlJRUkxBUXhCQUFsSlN3TUpSUUZDLzlPQUFZQkMvK0EyR2dGSkZTUVNSQ2NVVEZCSnZVVUJSTDVJS2t4UXNDTkRpQU00SWljUFpVUVdJaWNHWlVRV0lpY1FaVVFXSWl0bFJCWWlKd1JsUkJZaUp4RmxSQllpSndobFJCWlBCeFlpRms4SVR3aFFUd2RRVHdaUVR3VlFUd1JRVHdOUVR3SlFURkFxVEZDd0kwT0lBdWdXS2t4UXNDTkROaG9CU1JVa0VrUTJHZ0pKRlNRU1JFd1hJaWNjWlVRTFRCY0tTU0luRW1WRURFRUFDQ0luRW1WTVJRSkVTUllxVEZDd0kwTTJHZ0ZKRlNNU1JEWWFBa2tWSkJKRU5ob0RTUlVrRWtRMkdnUkpGU1FTUkU4RElsTlBBeGRQQXhkUEF4ZUlBcGNXS2t4UXNDTkROaG9CU1JVa0VrUTJHZ0pKRlNRU1JERUFJaWxsUkJKRVRCZEpnV1FQUkV3WFNTVU9SQ2NZVHdKbkp4bE1aeWl3STBNMkdnRkpGU1FTUkRZYUFra1ZKQkpFTmhvRFNSVWtFa1F4QUNJcFpVUVNSRThDRjBtQlpBNUVUd0lYU1lGa0RrUlBBaGRKZ2ZRRERrUW5HazhEWnljYlR3Sm5KeDVNWnlpd0kwTTJHZ0ZKRlNRU1JEWWFBa2tWSkJKRU1RQWlLV1ZFRWtSTUYwd1hTZzFFU1lGa0QwUW5JazhDWnljTVRHY29zQ05ETmhvQlNSVWtFa1F4QUNJcFpVUVNSQmNuRGt4bktMQWpRellhQVVrVmdTQVNSREVBSWlsbFJCSkVLVXhuS0xBalF6RUFJaWxsUkJKRUp3Y2paeWl3STBNeEFDSXBaVVFTUkNjSEltY29zQ05ETWdwZ0ZpSW5DV1ZFRmlJbkMyVkVGazRDVUV4UUtreFFzQ05ETWdwZ1NTSW5FMlZFREVFQUU0QUlBQUFBQUFBQUp4QW5JMUFxVEZDd0kwTWlKd3RsUkVzQkRVRUFEb0FJQUFBQUFBQUFFNGhKUXYvZ2dnSUlBQUFBQUFBQUErZ0lBQUFBQUFBQUl5aEMvOGsyR2dGSkZTUVNSRFlhQWtrVkpCSkVNUUFpS1dWRUVrUk1GMG1Cb0kwR0QwUk1GMGxMQWcxRUp4TlBBbWNuQzB4bktMQWpRNG9FQVlBQVJ3UWlpL3dpVTBFQVlZditGMG1NQW92OUYwbE9BZzlCQUVhTEFrd0pqQUVqakFDTC9SZEpqQVJCQUF1TC94ZUxBUXVMQkFxTUJZc0ZGaWNGSW9zQVZGQ0FHUUFBQUFBQUFBQUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQlFqQUNKaXdJSmpBRWlqQUJDLzdpTC9SZEpqQU9ML2hkSlRnSVBRUUFNaXdOTUNZd0JJNHdBUXYrY2l3TUpqQUVpakFCQy81R0tBUUl5Q21CSklpY1RaVVFNUVFBS2kvK0wvMHNCQ1U4Q2lTSW5DMlZFaXdBTlFRQU5JaWNnWlVTTC93c2xDa0wvNENJbklXVkVpLzhMSlFwQy85TWlKeFpsUkVsRWdBMWpkWEp5Wlc1MFgzQnlhV05sWlVSSlJJbUtCQUdBQUVtTC8wQUFCQ0tNQUlraUp3eGxSSXYvQ3lVS1NZd0FpLzRQUVFBRmkvMk1BSW1ML29zQUNZdjlDNHYvQ293QmkveEJBQlNML1lzQkRVRUFDSXY5aXdFSmpBQ0pJNHdBaVl2OWl3RUlqQUNKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
